using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Aula Calcula Média do aluno 

            // Declarando as variaveis

            double num1, num2, num3, media;
            num1 = Convert.ToDouble(textNota1.Text);
            num2 = Convert.ToDouble(textNota2.Text);
            num3 = Convert.ToDouble(textNota3.Text);
            media = (num1 + num2 + num3) / 3;

            // Declarando o textbox Media

            textMedia.Text = media.ToString();
            

            if(media <5)
            {
                MessageBox.Show("Aluno Reprovado", "Messagem");
            }
                // se a media for nenor que 5, aparacera msg, aluno Reprovado
            else if(media >=7)
            {
                MessageBox.Show("Aluno Aprovado Com Sucesso", "Messagem");
            }
                // se a media for maior e igual a 7, aparecera msg, aluno aprovado 
            else
            {
                MessageBox.Show("Aluno em Recuperação", "Messagem");
            }
               // se a meida for menor que 7 , aparecer msg, aluno em recuperação 

            
            //fim do programa

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            // Declarando codigo limpar

            textNota1.Text = " ";
            textNota2.Text = " ";
            textNota3.Text = " ";
            textMedia.Text = " ";


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            // Declarando codigo Sair

            Close();

        }
    }
}
