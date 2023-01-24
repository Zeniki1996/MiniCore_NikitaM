using System.ComponentModel.DataAnnotations;

namespace MiniCore.Data
{
    public class Contratos
    {
        [Key]
        public int idContratos { get; set; }
        public int idCliente { get; set; }
        public string nombreContrato { get; set; }
        public decimal montos { get; set; }
        public DateTime? fecha{ get; set; }
    }
}
