namespace EntityFrameworkClassroomCodeFirst.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class ModelPhoto : DbContext
    {
        public ModelPhoto() : base("name=ModelPhoto") { }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual IDbSet<Comments> Comments { get; set; }
    }

    public class Photo
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }

    public class Comments
    {
        public int Id { get; set; }
        [Required]
        public string Comment { get; set; }
        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}