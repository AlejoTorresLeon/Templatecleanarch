using MyProject.Application.DTOs;
using MyProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Features.Login
{
    public class LoginService: ILoginService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioLoginDto?> LoginAsync(string username, string? password)
        {
            UsuarioLoginDto? usuario = await _usuarioRepository.ObtenerUsuarioPorLoginAsync(username);

            return usuario;

        }
    }
}
