using MyProject.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Features.Login
{
    public interface ILoginService
    {
        Task<UsuarioLoginDto?> LoginAsync(string username, string? password);
    }
}
