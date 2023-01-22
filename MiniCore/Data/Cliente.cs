using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MiniCore.Data

{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        public string nombre { get; set; }


    }
}
