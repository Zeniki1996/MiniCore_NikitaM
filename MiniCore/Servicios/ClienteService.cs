using MiniCore.Data;
using Microsoft.EntityFrameworkCore;

namespace MiniCore.Servicios
{
    public class ClienteService
    {
        private ApplicationDbContext context;
        public ClienteService(ApplicationDbContext context)
        {

            this.context = context;
        }

        public List<Cliente> GetAllCliente()
        {
            return context.Cliente.ToList();
        }

        public async Task<Cliente> GetCliente(int codigo)
        {
            var cliente = await context.Cliente.FirstOrDefaultAsync(p => p.idCliente == codigo);
            return cliente ?? new() { idCliente = codigo };

        }

        public async Task DeleteCliente(int codigo)
        {
            var cliente = await context.Cliente.FirstOrDefaultAsync(p => p.idCliente == codigo);
            context.Cliente.Remove(cliente);
            context.SaveChanges();
        }


        public async Task Crear(Cliente cliente)
        {
            var clienteExistente = await context.Cliente.FirstOrDefaultAsync(p => p.idCliente == cliente.idCliente);
            if (clienteExistente is not null)
            {
                return;
            }
            context.Cliente.Add(cliente);
            await context.SaveChangesAsync();
        }
    }
    
    //Minicore cambios 
}
