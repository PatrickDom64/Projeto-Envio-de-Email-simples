using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Envio_de_Email_simples
{
    public partial class FmConfig_email : Form
    {
        public FmConfig_email()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FmConfig_email fmConfig_Email = new FmConfig_email();
            //tenho que fechar o form 
        }

        //criar uma forma de pegar as informaçoes do textbox e passar para classe emailinfo
    }
}
