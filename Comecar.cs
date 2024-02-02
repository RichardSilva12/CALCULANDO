using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_Calculando
{
    public partial class Comecar : Form
    {
        public Comecar()
        {
            InitializeComponent();
            OperacoesButton.Text = operacoes[indexOperacoes];
            NiveisButton.Text = niveis[indexNiveis];
        }


        //Eventos de mouse enter e mouse leave
        private void VoltarButton_MouseEnter(object sender, EventArgs e)
        {
            Voltarlbl.ForeColor = Color.White;
        }

        private void VoltarButton_MouseLeave(object sender, EventArgs e)
        {
            Voltarlbl.ForeColor= Color.DarkOrange;
        }

        private void EsquerdaOperacaoButton_MouseEnter(object sender, EventArgs e)
        {
            EsquerdaOperacaoButton.ForeColor = Color.White;
        }

        private void EsquerdaOperacaoButton_MouseLeave(object sender, EventArgs e)
        {
            EsquerdaOperacaoButton.ForeColor= Color.DarkOrange;
        }

        private void DireitaOperacaoButton_MouseEnter(object sender, EventArgs e)
        {
            DireitaOperacaoButton.ForeColor= Color.White;
        }

        private void DireitaOperacaoButton_MouseLeave(object sender, EventArgs e)
        {
            DireitaOperacaoButton.ForeColor = Color.DarkOrange; 
        }

        private void EsquerdaNivelButton_MouseEnter(object sender, EventArgs e)
        {
            EsquerdaNivelButton.ForeColor= Color.White;
        }

        private void EsquerdaNivelButton_MouseLeave(object sender, EventArgs e)
        {
            EsquerdaNivelButton.ForeColor = Color.DarkOrange;
        }

        private void DireitaNivelButton_MouseEnter(object sender, EventArgs e)
        {
            DireitaNivelButton.ForeColor = Color.White;
        }

        private void DireitaNivelButton_MouseLeave(object sender, EventArgs e)
        {
            DireitaNivelButton.ForeColor = Color.DarkOrange;
        }

        private void ComecarButton_MouseEnter(object sender, EventArgs e)
        {
            ComecarButton.ForeColor= Color.White;
        }

        private void ComecarButton_MouseLeave(object sender, EventArgs e)
        {
            ComecarButton.ForeColor = Color.DarkGreen;
        }
        //

        //Escolha das operações
        private string[] operacoes = { "ADIÇÃO", "SUBTRAÇÃO", "MULTIPLICAÇÃO" /*, "DIVISÃO" */};

        private int indexOperacoes = 0;

        private void DireitaOperacaoButton_Click(object sender, EventArgs e)
        {
            indexOperacoes = (indexOperacoes + 1) % operacoes.Length;
            OperacoesButton.Text = operacoes[indexOperacoes];
        }

        private void EsquerdaOperacaoButton_Click(object sender, EventArgs e)
        {
            if(indexOperacoes == 0)
            {
                indexOperacoes += 3;
                indexOperacoes = (indexOperacoes - 1) % operacoes.Length;
                OperacoesButton.Text = operacoes[indexOperacoes];

            }
            else
            {
                indexOperacoes = (indexOperacoes - 1) % operacoes.Length;
                OperacoesButton.Text = operacoes[indexOperacoes];
            }
        }

        //Escolha dos níveis
        private string[] niveis = { "FÁCIL", "MÉDIO", "DÍFICIL" };

        private int indexNiveis = 0;

        private void DireitaNivelButton_Click(object sender, EventArgs e)
        {
            indexNiveis = (indexNiveis + 1) % niveis.Length;
            NiveisButton.Text = niveis[indexNiveis];
        }

        private void EsquerdaNivelButton_Click(object sender, EventArgs e)
        {
            if(indexNiveis == 0) 
            {
                indexNiveis += 3;
                indexNiveis = (indexNiveis - 1) % niveis.Length;
                NiveisButton.Text = niveis[indexNiveis];
            }
            else
            {
                indexNiveis = (indexNiveis - 1) % niveis.Length;
                NiveisButton.Text = niveis[indexNiveis];
            }
        }
        //


        //Abrir questões
        Questoes questoes = new Questoes();
        Thread abrirquestoes;

        private void ComecarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            abrirquestoes = new Thread(AbrirQuestões);
            abrirquestoes.SetApartmentState(ApartmentState.STA);
            abrirquestoes.Start();

            questoes.Operacao = operacoes[indexOperacoes];
            questoes.Nivel = niveis[indexNiveis];          
        }
              
        private void AbrirQuestões()
        {
            Application.Run(questoes);
        }


        //Voltar
        Thread voltarInicio;
        private void VoltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            voltarInicio = new Thread(AbrirVoltar);
            voltarInicio.SetApartmentState(ApartmentState.STA);
            voltarInicio.Start();
        }

        private void AbrirVoltar()
        {
            Application.Run(new TelaInicial());
        }

        private void Comecar_Load(object sender, EventArgs e)
        {

        }

    }
}
