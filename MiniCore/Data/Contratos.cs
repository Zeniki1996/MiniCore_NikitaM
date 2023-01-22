using System.ComponentModel.DataAnnotations;

namespace MiniCore.Data
{
    public class Contratos
    {
        [Key]
        public int idContratos { get; set; }
        public int idCliente { get; set; }
        public string nombreContrato { get; set; }
        public float monto { get; set; }
        public DateTime? fecha{ get; set; }
    }
}
