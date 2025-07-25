using System.ComponentModel.DataAnnotations;

public class CaracteristicaTipoCultivo
{
    [Key]
    public int IdDetalleCaracteristicas { get; set; }
    public int IdTipoCultivo { get; set; }
    public string Descripcion { get; set; }
    public int IdCaracteristica { get; set; }

    public TipoCultivo TipoCultivo { get; set; }
    public Caracteristica Caracteristica { get; set; }
}
