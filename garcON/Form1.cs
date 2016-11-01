using garcON.Data;
using garcON.Model;
using System;
using System.Windows.Forms;

namespace garcON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pess = new Pessoa();
            pess.Nome = "AAA";
            pess.SobreNome = "BBB";
            pess.Endereco = new Endereco();

            GarcONContext context = new GarcONContext();
            context.Pessoas.Add(pess);
            context.SaveChanges();
        }
    }
}
