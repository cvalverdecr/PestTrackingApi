using System.ComponentModel.DataAnnotations;

public class Empresa
{
    [Key]
    public int IdEmpresa { get; set; }
    public int IdPais { get; set; }
    public string Descripcion { get; set; }
    public string Direccion { get; set; }
    public string Telefono1 { get; set; }
    public string Telefono2 { get; set; }
    public string Website { get; set; }
    public string Email { get; set; }
    public string Logo { get; set; }

    public Pais Pais { get; set; }
}
