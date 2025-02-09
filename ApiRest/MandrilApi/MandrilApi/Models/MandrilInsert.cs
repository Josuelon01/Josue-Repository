using System.ComponentModel.DataAnnotations;

namespace MandrilApi.Models
{
    public class MandrilInsert
    {
        [Required] // para que solo requiera algo especifico
        [MaxLength(50)] // el maximo que se debe escribir


        public string Name { get; set; } = string.Empty; 

        public string Apellido { get; set; } = string.Empty;
    }
}
