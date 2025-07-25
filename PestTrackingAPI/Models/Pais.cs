using System.ComponentModel.DataAnnotations;

public class Pais
{
[Key]
    public int IdPais { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }

    public ICollection<Empresa> Empresas { get; set; }
    public ICollection<Provincia> Provincias { get; set; }
}
