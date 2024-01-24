using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Verifica();
        }
        public void Verifica()
        {

        }
        private void BtCalcular_Click(object sender, EventArgs e)
        {

            // string Nome = BoxNome.text; int yourVar = int.Parse(yourTextBoxname.Text);
            if (BoxLadoA.Text.Length == 0 || BoxLadoB.Text.Length == 0 || BoxLadoC.Text.Length == 0)
            {
                MessageBox.Show("Preencha o lado A");
                MessageBox.Show("Preencha o lado B");
                MessageBox.Show("Preencha o lado C");//mensagem exibida  para cada campo vazio
            }
            else
            {
                int CalcLadoA = int.Parse(BoxLadoA.Text);//entrando com numero INTeiro
                int CalcLadoB = int.Parse(BoxLadoB.Text);
                int CalcLadoC = int.Parse(BoxLadoC.Text);
                int calculo = CalcLadoA + CalcLadoB + CalcLadoC;// int calculo = CalcLadoA + CalcLadoB + CalcLadoC;

                if (calculo == 10) //supondo que o resultado do calculo seja igual a 10
                {
                    MessageBox.Show("Triangulo é TAL");//depois vão fazer os calculos baseado no PORTUGOL para saber o trialgulo
                    calculo = 0; //cuidado a diferença entre zero e nulo
                }
            }
            MessageBox.Show("Triangulo não encontrado.");//mensagem em tela quando o triangulo não foi calculado
            
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
             BoxLadoA.Clear();//textBoxName.Clear(); apaga os valores dos textbox
             BoxLadoB.Clear();
             BoxLadoC.Clear();            
        }
        private void BtFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // aqui o comando para fechar o formulario
            // this.Close();
        }
    }
}
