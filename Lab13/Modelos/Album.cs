using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab13.Modelos
{
    public class Album
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Artista { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        public List<Cancion> Canciones { get; set; } = new();
    }
}
