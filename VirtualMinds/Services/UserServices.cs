using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtualMinds.Models;
using Dapper;
using System.Data;

namespace VirtualMinds.Services
{
    public class UserServices
    {
        public string _ConStr { get; }
        public UserServices()
        {
                _ConStr = System.Configuration.ConfigurationManager.ConnectionStrings["UserContext"].ConnectionString; 
           
        }

        public List<Usuario> GetUser()
        {
            
            List<Usuario> usuarioRetorno = new List<Usuario>();
            string sql = "select * from Users";

            using (var connection = ConnectionFactory.GetOpenConnection(_ConStr))
            {
                usuarioRetorno = connection.Query<Usuario>(sql).ToList();
            }

            return usuarioRetorno;
        }

        public void DeleteUser(Usuario user)
        {            
            List<Usuario> usuarioRetorno = new List<Usuario>();
            string sql = "delete from Users where idUser = @id";

            using (var connection = ConnectionFactory.GetOpenConnection(_ConStr))
            {
                connection.Execute(sql, new {id = user.idUser });
            }
        }

        public void Save(Usuario user)
        {
            List<Usuario> usuarioRetorno = new List<Usuario>();
            string sqlExist = "select count(*) from Users where idUser = @idUser";

            using (var connection = ConnectionFactory.GetOpenConnection(_ConStr))
            {
                if (connection.QueryFirst<int>(sqlExist, user) == 0)
                {
                    string sqlInsert = "INSERT INTO [dbo].[Users] ([Usuario],[Password],[Nombre],[Apellido],[Email]) VALUES (@Usuario,@Password,@Nombre,@Apellido,@Email)";
                    connection.Execute(sqlInsert, user);
                }
                else
                {
                    string sqlUpdate = "UPDATE [dbo].[Users] SET [Usuario] = @Usuario ,[Password] = @Password ,[Nombre] = @Nombre,[Apellido] = @Apellido ,[Email] = @Email WHERE [idUser] = @idUser";
                    connection.Execute(sqlUpdate, user);
                }
            }
        }
    }
}