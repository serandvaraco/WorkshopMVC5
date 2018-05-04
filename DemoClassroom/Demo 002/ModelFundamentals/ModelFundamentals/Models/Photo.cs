
namespace ModelFundamentals.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Photo
    {
        
        public int Id { get; set; }

        [DataType(DataType.ImageUrl)]
        [Url(ErrorMessage ="Url Valida")]
        [Display(Name="Ruta de imagen")]
        public string PhotoFile { get; set; } /* Blob Storage  */

        [Required(ErrorMessage ="El nombre es requerido" )]
        [Display(Name = "Ingrese el nombre de la fotografía")]
        public string Name { get; set; }

        [Range(0, 400)]
        [Display(Name = "Ingrese el tamaño")]
        public int Length { get; set; }

    }
}