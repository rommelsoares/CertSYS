using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertSYS
{
    class LoginAcesso
    {
        public bool contemAcesso = false;
        public string mensagem;
        SqlCommand c = new SqlCommand();
        Conexao conex = new Conexao();
        SqlDataReader d;
        public bool validarLogin(string login, string senha)
        {
            c.CommandText = "Select * from [usuario] where usu_login = @login and usu_senha = @senha";
            c.Parameters.AddWithValue("@login", login);
            c.Parameters.AddWithValue("@senha", senha);
            try
            {
                c.Connection = conex.conectarBase();
                d = c.ExecuteReader();
                if (d.HasRows)
                {
                    contemAcesso = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao acessar a base de dados!";
            }
            return contemAcesso;
        }
    }
}
