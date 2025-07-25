using System.ComponentModel.DataAnnotations;

public class Provincia
{
    [Key]
    public int IdProvincia { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }

    public ICollection<Canton> Cantones { get; set; }
}
