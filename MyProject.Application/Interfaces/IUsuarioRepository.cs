using MyProject.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioLoginDto?> ObtenerUsuarioPorLoginAsync(string usuario);
    }
}
