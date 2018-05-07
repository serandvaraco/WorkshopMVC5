namespace EntityFrameworkClassroom.Models
{
    public interface IComments
    {
        string Comment { get; set; }
        int Id { get; set; }
        int IdPhoto { get; set; }
        Photo Photo { get; set; }
    }
}