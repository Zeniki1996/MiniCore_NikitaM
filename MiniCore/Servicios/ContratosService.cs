
using MiniCore.Data;
using Microsoft.EntityFrameworkCore;

namespace MiniCore.Servicios
{
    public class ContratosService
    {
        private ApplicationDbContext context;
        public ContratosService(ApplicationDbContext context)
        {

            this.context = context;
        }

        public List<Contratos> GetAllContratos()
        {
            return context.Contratos.ToList();
        }

        public async Task<Contratos> GetContratos(int codigo)
        {
            var contratos = await context.Contratos.FirstOrDefaultAsync(p => p.idContratos == codigo);
            return contratos ?? new() { idContratos = codigo };

        }

        public async Task DeleteContratos(int codigo)
        {
            var contratos = await context.Contratos.FirstOrDefaultAsync(p => p.idContratos == codigo);
            context.Contratos.Remove(contratos);
            context.SaveChanges();
        }


        public async Task Crear(Contratos contratos)
        {
            var contratoExistente = await context.Contratos.FirstOrDefaultAsync(p => p.idContratos == contratos.idContratos);
            if (contratoExistente is not null)
            {
                return;
            }
            context.Contratos.Add(contratos);
            await context.SaveChangesAsync();
        }

        public async Task<List<ContratosFiltrados>> RetornarLista(DateTime fechainicio, DateTime fechafin)
        {

            var proyecto = await context.Contratos.Where(p => p.fecha >= fechainicio && p.fecha <= fechafin)
                .GroupBy(p => p.idCliente, (x, y) => new ContratosFiltrados
                {
                    nombre = context.Cliente.FirstOrDefault(p => p.idCliente == x).nombre,
                    montofinal = y.Select(p => p.montos).Sum()
                }).ToListAsync();

            return proyecto;
        }
    }
}

