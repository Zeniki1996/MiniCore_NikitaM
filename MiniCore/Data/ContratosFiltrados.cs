using System.ComponentModel.DataAnnotations;

namespace MiniCore.Data
{
    public class ContratosFiltrados
    {
        
        [Key]
        public int? IdContratos { get; set; }
        public string nombre { get; set; }
        public List<Contratos> contratos { get; set; }
    }
}

