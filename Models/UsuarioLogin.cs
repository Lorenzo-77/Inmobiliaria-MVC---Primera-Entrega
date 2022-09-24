using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inmobiliaria_Lorenzo.Models;

public class UsuarioLogin
{

    public string Email { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }

}