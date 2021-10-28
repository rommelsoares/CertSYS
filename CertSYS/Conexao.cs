using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertSYS
{
    public class Conexao
    {

        SqlConnection conex = new SqlConnection();
        //Construtor
        public Conexao()
        {
            conex.ConnectionString = @"Data Source=NB_ROMMEL2021\SQLEXPRESS;Initial Catalog=CertSYS;Integrated Security=True";
        }

        //Metodo Conectar
        public SqlConnection conectarBase()
        {
            if(conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Open();
            }
            return conex;
        }

        //Metodo Desconectar
        public void desconectarBase()
        {
            if (conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }
        }
    }
}
