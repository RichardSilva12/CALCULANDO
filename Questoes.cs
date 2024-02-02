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
using System.Reflection.Emit;

namespace Projeto_Calculando
{
    public partial class Questoes : Form
    {      
        public Questoes()
        {
            InitializeComponent();
        }


        //Conexão com a classe Comecar
        public string Operacao { get; set; }
        public string Nivel { get; set; }

        private void Questoes_Load(object sender, EventArgs e)
        {
            EscolhaOperacaolbl.Text = Operacao;
            EscolhaNivellbl.Text = Nivel;
            GerarQuestao();
        }
        //


        //Botão voltar
        Thread voltar;

        private void VoltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            voltar = new Thread(VoltarComecar);
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }

        private void VoltarComecar()
        {
            Application.Run(new Comecar());
        }


        //Eventos de mouse enter e mouse leave
        private void VoltarButton_MouseEnter(object sender, EventArgs e)
        {
            Voltarlbl.ForeColor = Color.White;
        }

        private void VoltarButton_MouseLeave(object sender, EventArgs e)
        {
            Voltarlbl.ForeColor = Color.Gold;
        }        

        private void Opcao1Button_MouseEnter(object sender, EventArgs e)
        {
            Opcao1Button.ForeColor = Color.White;
        }

        private void Opcao1Button_MouseLeave(object sender, EventArgs e)
        {
            Opcao1Button.ForeColor = Color.DarkOrange;
        }

        private void Opcao2Button_MouseEnter(object sender, EventArgs e)
        {
            Opcao2Button.ForeColor = Color.White;
        }

        private void Opcao2Button_MouseLeave(object sender, EventArgs e)
        {
            Opcao2Button.ForeColor = Color.DarkOrange;
        }

        private void Opcao3Button_MouseEnter(object sender, EventArgs e)
        {
            Opcao3Button.ForeColor = Color.White;
        }

        private void Opcao3Button_MouseLeave(object sender, EventArgs e)
        {
            Opcao3Button.ForeColor = Color.DarkOrange;
        }

        private void Opcao4Button_MouseEnter(object sender, EventArgs e)
        {
            Opcao4Button.ForeColor = Color.White;
        }

        private void Opcao4Button_MouseLeave(object sender, EventArgs e)
        {
            Opcao4Button.ForeColor = Color.DarkOrange;
        }

        private void ContinuarButton_MouseEnter(object sender, EventArgs e)
        {
            if(ContinuarButton.Enabled == true)
            {
                ContinuarButton.ForeColor = Color.White;
            }
        }

        private void ContinuarButton_MouseLeave(object sender, EventArgs e)
        {
            ContinuarButton.ForeColor = Color.DarkGreen;
        }


        //Gerar Questões Adição
        private int respostasCorretas = 0;
        private Random random = new Random();
        private int questaoAtual = 0;
        private int respostaCorreta = 0;
        private List<Tuple<int, int>> contasUsadas = new List<Tuple<int, int>>();


        private void GerarQuestao()
        {
            switch (EscolhaOperacaolbl.Text)
            {
                case "ADIÇÃO":
                    Adicao();
                    break;
                case "SUBTRAÇÃO":
                    Subtracao();
                    break;
                case "MULTIPLICAÇÃO":
                    Multiplicacao();
                    break;
            }
        }


        private void Adicao()
        {
            Questoeslbl.Text = $"QUESTÃO {questaoAtual + 1}";
            Checklbl.Visible = false;
            Opcao1Button.Enabled = true;
            Opcao2Button.Enabled = true;
            Opcao3Button.Enabled = true;
            Opcao4Button.Enabled = true;
            ContinuarButton.Enabled = false;

            int minimo;
            int maximo;
                      
            if (EscolhaNivellbl.Text == "FÁCIL")
            {
                minimo = 1;
                maximo = 11;
            }
            else if (EscolhaNivellbl.Text == "MÉDIO")
            {
                minimo = 11;
                maximo = 21;
            }
            else // Difícil
            {
                minimo = 21;
                maximo = 50;
            }

            //Garante que a mesma conta não apareça mais de uma vez
            Tuple<int, int> numerosUsados;

            do
            {
                int numero1 = random.Next(minimo, maximo + 1);
                int numero2 = random.Next(minimo, maximo + 1);
                numerosUsados = Tuple.Create(numero1, numero2);
                Contaslbl.Text = $"{numero1} + {numero2} = ?";

                // Verificar se a conta inversa já foi usada
                if (contasUsadas.Contains(numerosUsados) || contasUsadas.Contains(Tuple.Create(numero2, numero1)))
                {
                    numerosUsados = null; // Define como nulo para gerar um novo par
                }
            } while (numerosUsados == null);

            contasUsadas.Add(numerosUsados);

            int soma = numerosUsados.Item1 + numerosUsados.Item2;
            respostaCorreta = soma;

            // Gera quatro números aleatórios para as opções
            List<int> opcoes = new List<int> { soma };

            while (opcoes.Count < 4)
            {
                int opcao = random.Next(minimo, maximo * 2 - 2); // Gera números aleatórios
                if (!opcoes.Contains(opcao))
                    opcoes.Add(opcao);
            }

            // Embaralha as opções
            opcoes = Shuffle(opcoes);

            Opcao1Button.Text = opcoes[0].ToString();
            Opcao2Button.Text = opcoes[1].ToString();
            Opcao3Button.Text = opcoes[2].ToString();
            Opcao4Button.Text = opcoes[3].ToString();

            questaoAtual++;
        }


        private void Subtracao()
        {
            Questoeslbl.Text = $"QUESTÃO {questaoAtual + 1}";
            Checklbl.Visible = false;
            Opcao1Button.Enabled = true;
            Opcao2Button.Enabled = true;
            Opcao3Button.Enabled = true;
            Opcao4Button.Enabled = true;
            ContinuarButton.Enabled = false;
           
            int minimo;
            int maximo;
            int numero1;
            int numero2;

            if (EscolhaNivellbl.Text == "FÁCIL")
            {
                minimo = 2;
                maximo = 12;

                Tuple<int, int> numerosUsados;

                do
                {
                    numero1 = random.Next(minimo + 2, maximo + 1);
                    numero2 = random.Next(minimo, numero1);
                    numerosUsados = Tuple.Create(numero1, numero2);
                    Contaslbl.Text = $"{numero1} - {numero2} = ?";
                } while (contasUsadas.Contains(numerosUsados));

                contasUsadas.Add(numerosUsados);

                int subtracao = numerosUsados.Item1 - numerosUsados.Item2;
                respostaCorreta = subtracao;

                List<int> opcoes = new List<int> { subtracao };

                while (opcoes.Count < 4)
                {
                    int opcao = random.Next(1, numero1+4);
                    if (!opcoes.Contains(opcao))
                        opcoes.Add(opcao);
                }

                opcoes = Shuffle(opcoes);

                Opcao1Button.Text = opcoes[0].ToString();
                Opcao2Button.Text = opcoes[1].ToString();
                Opcao3Button.Text = opcoes[2].ToString();
                Opcao4Button.Text = opcoes[3].ToString();
            }
            else if (EscolhaNivellbl.Text == "MÉDIO")
            {
                minimo = 9;
                maximo = 25;

                Tuple<int, int> numerosUsados;

                do
                {
                    numero1 = random.Next(minimo + 5, maximo + 1);
                    numero2 = random.Next(minimo, numero1 - 2);
                    numerosUsados = Tuple.Create(numero1, numero2);
                    Contaslbl.Text = $"{numero1} - {numero2} = ?";
                } while (contasUsadas.Contains(numerosUsados));

                contasUsadas.Add(numerosUsados);

                int subtracao = numerosUsados.Item1 - numerosUsados.Item2;
                respostaCorreta = subtracao;

                List<int> opcoes = new List<int> { subtracao };

                while (opcoes.Count < 4)
                {
                    int opcao = random.Next(1, numero1 - 1);
                    if (!opcoes.Contains(opcao))
                        opcoes.Add(opcao);
                }

                opcoes = Shuffle(opcoes);

                Opcao1Button.Text = opcoes[0].ToString();
                Opcao2Button.Text = opcoes[1].ToString();
                Opcao3Button.Text = opcoes[2].ToString();
                Opcao4Button.Text = opcoes[3].ToString();
            }
            else // Difícil
            {
                minimo = 15;
                maximo = 50;

                Tuple<int, int> numerosUsados;

                do
                {
                    numero1 = random.Next(32, maximo + 1);
                    numero2 = random.Next(minimo, numero1 - 9);
                    numerosUsados = Tuple.Create(numero1, numero2);
                    Contaslbl.Text = $"{numero1} - {numero2} = ?";
                } while (contasUsadas.Contains(numerosUsados));

                contasUsadas.Add(numerosUsados);

                int subtracao = numerosUsados.Item1 - numerosUsados.Item2;
                respostaCorreta = subtracao;

                List<int> opcoes = new List<int> { subtracao };

                while (opcoes.Count < 4)
                {
                    int opcao = random.Next(subtracao - 5, numero1);
                    if (!opcoes.Contains(opcao))
                        opcoes.Add(opcao);
                }

                opcoes = Shuffle(opcoes);

                Opcao1Button.Text = opcoes[0].ToString();
                Opcao2Button.Text = opcoes[1].ToString();
                Opcao3Button.Text = opcoes[2].ToString();
                Opcao4Button.Text = opcoes[3].ToString();
            }
            questaoAtual++;
        }


        private void Multiplicacao()
        {
            Questoeslbl.Text = $"QUESTÃO {questaoAtual + 1}";
            Checklbl.Visible = false;
            Opcao1Button.Enabled = true;
            Opcao2Button.Enabled = true;
            Opcao3Button.Enabled = true;
            Opcao4Button.Enabled = true;
            ContinuarButton.Enabled = false;

            
            int minimo;
            int maximo;
            int numero1;
            int numero2;

            if (EscolhaNivellbl.Text == "FÁCIL")
            {
                minimo = 2;
                maximo = 6;

                Tuple<int, int> numerosUsados;

                do
                {
                    numero1 = random.Next(minimo, maximo + 1);
                    numero2 = random.Next(minimo, maximo + 1);
                    numerosUsados = Tuple.Create(numero1, numero2);
                    Contaslbl.Text = $"{numero1} x {numero2} = ?";
                } while (contasUsadas.Contains(numerosUsados));

                contasUsadas.Add(numerosUsados);

                int produto = numerosUsados.Item1 * numerosUsados.Item2;
                respostaCorreta = produto;

                List<int> opcoes = new List<int> { produto };

                while (opcoes.Count < 4)
                {
                    int opcao = random.Next(numero1, produto + 5);
                    if (!opcoes.Contains(opcao))
                        opcoes.Add(opcao);
                }

                opcoes = Shuffle(opcoes);

                Opcao1Button.Text = opcoes[0].ToString();
                Opcao2Button.Text = opcoes[1].ToString();
                Opcao3Button.Text = opcoes[2].ToString();
                Opcao4Button.Text = opcoes[3].ToString();
            }
            else if (EscolhaNivellbl.Text == "MÉDIO")
            {
                minimo = 5;
                maximo = 10;

                Tuple<int, int> numerosUsados;

                do
                {
                    numero1 = random.Next(minimo + 2, maximo + 1);
                    numero2 = random.Next(minimo, maximo + 1);
                    numerosUsados = Tuple.Create(numero1, numero2);
                    Contaslbl.Text = $"{numero1} x {numero2} = ?";

                    if (contasUsadas.Contains(numerosUsados) || contasUsadas.Contains(Tuple.Create(numero2, numero1)))
                    {
                        numerosUsados = null; 
                    }
                } while (numerosUsados == null);

                contasUsadas.Add(numerosUsados);

                int produto = numerosUsados.Item1 * numerosUsados.Item2;
                respostaCorreta = produto;

                List<int> opcoes = new List<int> { produto };

                while (opcoes.Count < 4)
                {
                    int opcao = random.Next(numero1+numero2, produto + 5);
                    if (!opcoes.Contains(opcao))
                        opcoes.Add(opcao);
                }

                opcoes = Shuffle(opcoes);

                Opcao1Button.Text = opcoes[0].ToString();
                Opcao2Button.Text = opcoes[1].ToString();
                Opcao3Button.Text = opcoes[2].ToString();
                Opcao4Button.Text = opcoes[3].ToString();


            }
            else // Difícil
            {
                minimo = 6;
                maximo = 12;

                Tuple<int, int> numerosUsados;

                do
                {
                    numero1 = random.Next(minimo + 3, maximo + 1);
                    numero2 = random.Next(minimo, maximo + 1);
                    numerosUsados = Tuple.Create(numero1, numero2);
                    Contaslbl.Text = $"{numero1} x {numero2} = ?";

                    if (contasUsadas.Contains(numerosUsados) || contasUsadas.Contains(Tuple.Create(numero2, numero1)))
                    {
                        numerosUsados = null; 
                    }
                } while (numerosUsados == null);

                contasUsadas.Add(numerosUsados);

                int produto = numerosUsados.Item1 * numerosUsados.Item2;
                respostaCorreta = produto;

                List<int> opcoes = new List<int> { produto };

                while (opcoes.Count < 4)
                {
                    int opcao = random.Next(numero1+numero2, produto + 5);
                    if (!opcoes.Contains(opcao))
                        opcoes.Add(opcao);
                }

                opcoes = Shuffle(opcoes);

                Opcao1Button.Text = opcoes[0].ToString();
                Opcao2Button.Text = opcoes[1].ToString();
                Opcao3Button.Text = opcoes[2].ToString();
                Opcao4Button.Text = opcoes[3].ToString();
            }

            questaoAtual++;
        }


        private List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }


        //Verifica as respostas
        private void Opcao1Button_Click(object sender, EventArgs e)
        {
            VerificarResposta(Opcao1Button);
        }

        private void Opcao2Button_Click(object sender, EventArgs e)
        {
            VerificarResposta(Opcao2Button);
        }

        private void Opcao3Button_Click(object sender, EventArgs e)
        {
            VerificarResposta(Opcao3Button);
        }

        private void Opcao4Button_Click(object sender, EventArgs e)
        {
            VerificarResposta(Opcao4Button);
        }

        private void VerificarResposta(Button botaoResposta)
        {
            int respostaSelecionada = Convert.ToInt32(botaoResposta.Text);

            if (respostaSelecionada == respostaCorreta)
            {
                
                Checklbl.Text = $"Correto\n Resposta: {respostaCorreta}";
                Checklbl.BackColor = Color.LawnGreen;
                Checklbl.ForeColor = Color.DarkGreen;
                respostasCorretas++;
            }
            else
            {
                Checklbl.Text = $"Incorreto\n Resposta: {respostaCorreta}";
                Checklbl.BackColor = Color.Red;
                Checklbl.ForeColor = Color.DarkRed;
            }

            Opcao1Button.Enabled = false;
            Opcao2Button.Enabled = false;
            Opcao3Button.Enabled = false;
            Opcao4Button.Enabled = false;
            Checklbl.Visible = true;

            ContinuarButton.Enabled = true;           
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            if (questaoAtual >= 10)
            {
                Painel.Visible = true;
                Painel.Enabled = true;
                nAcaertoslbl.Text = ($"{respostasCorretas}/10");
                ContinuarButton.Enabled = false;
                if (respostasCorretas == 10)
                    Mensagemlbl.Text = "PARABÉNS!";
                if (respostasCorretas >= 7 && respostasCorretas <= 9)
                    Mensagemlbl.Text = "MUITO BEM!";
                if (respostasCorretas >= 4 && respostasCorretas <= 6)
                    Mensagemlbl.Text = "DÁ PARA MELHORAR!";
                if (respostasCorretas >= 1 && respostasCorretas <= 3)
                    Mensagemlbl.Text = "VAMOS PRATICAR MAIS!";
                if(respostasCorretas == 0)
                    Mensagemlbl.Text = "QUE PENA!";
                return;
                
            }
            ContinuarButton.Enabled = false;
            Checklbl.Visible = false;
            GerarQuestao();
        }
    }
}
