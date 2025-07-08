public class Pais
{
    public int IdPais { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }

    public ICollection<Empresa> Empresas { get; set; }
}
