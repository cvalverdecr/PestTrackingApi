using System.ComponentModel.DataAnnotations;

public class TipoCultivo
{
    [Key]
    public int IdTipoCultivo { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }

    public ICollection<Cultivo> Cultivos { get; set; }
}
