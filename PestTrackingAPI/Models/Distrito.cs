using System.ComponentModel.DataAnnotations;

public class Distrito
{
    [Key]
    public int IdDistrito { get; set; }
    public string Descripcion { get; set; }
    public int IdCanton { get; set; }
    public int Orden { get; set; }

    public Canton Canton { get; set; }
}
