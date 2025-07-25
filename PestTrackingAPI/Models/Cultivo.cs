using System.ComponentModel.DataAnnotations;

public class Cultivo
{
    [Key]
    public int IdCultivo { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }
    public string Ubicacion { get; set; }
    public string EtapaFenologica { get; set; }
    public DateTime FechaSiembra { get; set; }
    public string Variedad { get; set; }
    public int IdEmpresa { get; set; }
    public int IdTipoCultivo { get; set; }

    public Empresa Empresa { get; set; }
    public TipoCultivo TipoCultivo { get; set; }
}
