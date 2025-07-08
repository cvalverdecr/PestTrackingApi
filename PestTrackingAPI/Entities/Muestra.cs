public class Muestra
{
    public int IdMuestra { get; set; }
    public DateTime FechaHora { get; set; }
    public double Latitud { get; set; }
    public double Longuitud { get; set; }
    public int IdCultivo { get; set; }
    public DateTime FechaHoraUltimaModificacion { get; set; }
    public string Comentario { get; set; }
    public string Foto { get; set; }
    public int IdUsuario { get; set; }
    public int IdUsuarioModificacion { get; set; }

    public Cultivo Cultivo { get; set; }
}
