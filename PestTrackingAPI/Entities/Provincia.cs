public class Provincia
{
    public int IdProvincia { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }

    public ICollection<Canton> Cantones { get; set; }
}
