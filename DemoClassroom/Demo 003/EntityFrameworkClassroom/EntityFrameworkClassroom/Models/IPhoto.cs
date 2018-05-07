using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkClassroom.Models
{
    public interface IPhoto
    {
        ICollection<Comments> Comments { get; set; }
        [Display(Name = "descripción de la foto")]
        string Descripcion { get; set; }
        int Id { get; set; }
        [Display(Name = "Nombre de la foto")]
        string Name { get; set; }
    }
}