using System.ComponentModel.DataAnnotations;

public class Caracteristica
{
    [Key]
    public int IdCaracteristica { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }
}
