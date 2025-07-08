using Microsoft.AspNetCore.Identity;
public class Rol : IdentityRole<int>
{
    public int IdRol { get; set; }
    public string Descripcion { get; set; }
    public int Orden { get; set; }
}
