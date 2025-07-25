using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
public class Rol : IdentityRole<string>
{
    [Key]
    public int IdRol { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }
}
