using System.ComponentModel.DataAnnotations;

namespace MiniCore.Data
{
    public class ContratosFiltrados
    {

        [Key]

        public string nombre { get; set; }
        public decimal montofinal { get; set; }

    }
}

