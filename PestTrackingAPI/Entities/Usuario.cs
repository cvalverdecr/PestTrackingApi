using Microsoft.AspNetCore.Identity;

public class Usuario :IdentityUser<int>
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public string Correo { get; set; }
    public string Password { get; set; }
    public bool Estado { get; set; }
}
