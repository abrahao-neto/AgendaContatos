using AgendaContatos.Data.Configurations;
using AgendaContatos.Data.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Data.Repositories
{
    public class UsuarioRepository
    {
        public void Inserir(Usuario usuario)
        {
            var query = @"
                INSERT INTO USUARIO(
                    IDUSUARIO,
                    NOME,
                    EMAIL,
                    SENHA,
                    DATACRIACAO)
                VALUES(
                    @IdUsuario,
                    @Nome,
                    @Email,
                    CONVERT(VARCHAR(32), HASHBYTES('MD5', @Senha), 2),
                    @DataCriacao)
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.ConnectionString))
            {
                connection.Execute(query, usuario);
            }
        }

        public Usuario? ObterPorEmail(string email)
        {
            var query = @"
                SELECT * FROM USUARIO
                WHERE EMAIL = @email
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.ConnectionString)) 
            { 
                return connection.Query<Usuario>(query, new { email }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Método para consultar 1 usuário através do email e da senha
        /// </summary>
        public Usuario? ObterPorEmailESenha(string email, string senha)
        {
            var query = @"
                SELECT * FROM USUARIO
                WHERE EMAIL = @email
                AND SENHA = CONVERT(VARCHAR(32), HASHBYTES('MD5', @Senha), 2)
            ";

            using (var conection = new SqlConnection(SqlServerConfiguration.ConnectionString))
            {
                return conection.Query<Usuario>(query, new { email, senha }).FirstOrDefault();
            }
        }

    }
}
