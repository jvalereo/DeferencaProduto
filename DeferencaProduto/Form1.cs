using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace DeferencaProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento - Calcule a diferença do produto , tipo double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double  

            double a, b, c, d, diferenca;


            //Declarando entrada de dado no textbox

            a = double.Parse(textBoxValor1.Text, CultureInfo.InvariantCulture);
            b = double.Parse(textBoxValor2.Text, CultureInfo.InvariantCulture);
            c = double.Parse(textBoxValor3.Text, CultureInfo.InvariantCulture);
            d = double.Parse(textBoxValor4.Text, CultureInfo.InvariantCulture);

            //Declarando a diferença do produto

            diferenca = (a * b - c * d);


            //imprimir saida de dados no MessagemBox, concatenação

            MessageBox.Show("O valor do produto = " + diferenca.ToString("F1", CultureInfo.InvariantCulture),
                "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Teste de novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo limpar a textbox, focus

            textBoxValor1.Text = " ";
            textBoxValor2.Text = " ";
            textBoxValor3.Text = " ";
            textBoxValor4.Text = " ";
            textBoxValor1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair da aplicação 

            Close();
        }


        //Fim do programa
    }
}
