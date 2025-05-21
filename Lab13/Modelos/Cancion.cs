using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Lab13.Modelos
{
    public class Cancion
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Artista { get; set; }
        [Required]
        public TimeSpan Duracion { get; set; }
    }
}

