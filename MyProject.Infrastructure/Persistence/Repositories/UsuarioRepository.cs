using Dapper;
using MyProject.Application.DTOs;
using MyProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly IDbConnection _dbConnection;

        public UsuarioRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<UsuarioLoginDto?> ObtenerUsuarioPorLoginAsync(string usuario)
        {
            var sql = "SELECT usuario, cedula, nombre, codigo, email, nivel FROM usuario WHERE usuario = @usuario";
            return await _dbConnection.QueryFirstOrDefaultAsync<UsuarioLoginDto>(sql, new { usuario });
        }

    }
}
