using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Projeto_Calculando
{
    public partial class Opcoes : Form
    {

        //Slider para som
        public Opcoes()
        {
            InitializeComponent();
            slider.Height = 30;
        }

        float Default_value = 0.1f, Min = 0.0f, Max = 1.0f;     

        public float Bar(float value)
        {
            return(slider.Width - 24) * (value - Min)/ (float)(Max - Min);
        }

        public void thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            Default_value = value;
            slider.Refresh();
        }

        public float slider_width(int x)
        {
            return Min + (Max - Min) * x / (float)(slider.Width);
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar(Default_value);
            int y = (int)(slider.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, slider.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Gold, 0, y, x, slider.Height - 2 * y);

            using (Pen pen = new Pen(Color.Orange,10))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 3 , slider.Height / 3 , slider.Height / 3);
            }
        }

        bool mouse = false;
        private void slider_mousedown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(slider_width(e.X));
        }
        //Fim Slider para som


        //Muda Cor ao passar o mouse
        private void MudaCor_VoltarOpcoes(object sender, EventArgs e)
        {
            Voltaropcoeslbl.ForeColor = Color.White;
        }

        private void Voltacor_VoltarOpcoes(object sender, EventArgs e)
        {
            Voltaropcoeslbl.ForeColor = Color.Gold;
        }
        //Fim Muda Cor ao passar o mouse


        
        Thread t1opcoes;
     
        //Volta para a tela inicial ao ser clicado
        private void VoltarButtonOpcoes_Click(object sender, EventArgs e)
        {
            this.Close();
            t1opcoes = new Thread(VoltarParaTelaInicial_opcoes);
            t1opcoes.SetApartmentState(ApartmentState.STA);
            t1opcoes.Start();
        }

        private void VoltarParaTelaInicial_opcoes(object obj)
        {
            Application.Run(new TelaInicial());
        }
        //
    }
}
