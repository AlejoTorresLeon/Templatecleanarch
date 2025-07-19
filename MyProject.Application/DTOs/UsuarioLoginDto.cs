using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.DTOs
{
    public class UsuarioLoginDto
    {
        public string? Usuario { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
        public string? Email { get; set; }
        public string? Nivel { get; set; }
    }
}
