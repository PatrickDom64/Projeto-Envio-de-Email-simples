using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Envio_de_Email_simples
{
    public class emailInfo
    {
         
        //aqui devese armazenar localmente o email e a senha
        private string Email
        {
            get { return Email; }
            set { Email = value; }
        }
        private string password
        { 
            get { return password; }
            set { password = value; }
        }
    }
}
