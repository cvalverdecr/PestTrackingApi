using System.ComponentModel.DataAnnotations;

public class Canton
{
    [Key]
    public int IdCanton { get; set; }
    public string Descripcion { get; set; }
    public int IdProvincia { get; set; }
    public int Orden { get; set; }

    public Provincia Provincia { get; set; }
    public ICollection<Distrito> Distritos { get; set; }
}
