using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Envio_de_Email_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
         
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            //dedo nervoso
            btnEnviarEmail.Enabled = false;

            //------
            // Configurar as credenciais e detalhes do servidor SMTP
            var smtpServer = "smtp.example.com";
            var smtpPort = 587;
            var smtpUsername = "seuemail@example.com";
            var smtpPassword = "suasenha";
            //-----

            //email destinatario
            string emailDestinatario = txtEmailDestinatario.Text;

            //assunto
            string emailAssunto = txtAssunto.Text;

            //mensagem
            string emailMensagem = txtMensagem.Text;

            MailMessage mail = new MailMessage();
            
            //email do EmailInfo 
            emailInfo InfoEmail;
            InfoEmail = new emailInfo();

            mail.From = new MailAddress(smtpUsername);//De
            mail.To.Add(emailDestinatario);// Para
            mail.Subject = emailAssunto;   // Assunto
            mail.Body = emailMensagem; //mensagem

            using (var smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                try
                {
                    smtpClient.Send(mail);
                    MessageBox.Show("Email Enviado com sucesso!!!");

                    txtAssunto.Text = string.Empty;
                    txtEmailDestinatario.Text = string.Empty;
                    txtMensagem.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar emeil\nErro:", ex.Message);

                    txtAssunto.Text = string.Empty;
                    txtEmailDestinatario.Text = string.Empty;
                    txtMensagem.Text = string.Empty;
                }
            }
        }

        private void btConfigEmail_Click(object sender, EventArgs e)
        {
            FmConfig_email fmConfig_Email = new FmConfig_email();
            fmConfig_Email.Show();
        }
    }
}