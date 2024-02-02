using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculando
{
    public partial class fmCreditos : Form
    {
        Thread voltar;
        public fmCreditos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void VoltarButtonOpcoes_Click(object sender, EventArgs e)
        {
            this.Close();
            voltar = new Thread(VoltarParaTela);
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }
        private void VoltarParaTela(object obj)
        {
            Application.Run(new TelaInicial());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
