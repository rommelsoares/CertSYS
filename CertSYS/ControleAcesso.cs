using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertSYS
{
    public class ControleAcesso
    {
        public bool acesso_OK;
        public string mensagem = "";
        public bool acesso(string login, string senha)
        {
            LoginAcesso loginOk = new LoginAcesso();
            acesso_OK = loginOk.validarLogin(login, senha);
            return acesso_OK;
        }
    }
}
