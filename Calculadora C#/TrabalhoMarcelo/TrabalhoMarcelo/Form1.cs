using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMarcelo
{
    public partial class Form1 : Form
    {
        bool valorc = true;
        bool pontoc = true;
        
        String operation = "";
        String Valor = "";

        Double Contar1 = 0;
        Double Contar2 = 0;
        Double Result = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //fuçoes de operação
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textBoxCalculo.Text = "0";
            lblOp.Text = "";
            listBoxResults.Items.Clear();
            Contar1 = 0;
            Contar2 = 0;
            valorc = true;
        }

        private void btnZera_Click(object sender, EventArgs e)
        {
            textBoxCalculo.Text = "0";
            lblOp.Text = "";
            valorc = true;
            Contar1 = 0;
            Contar2 = 0;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            int temp = 0;
            Valor = textBoxCalculo.Text;
            temp = Valor.Length - 1;
            Valor = Valor.Substring(0,temp);
            textBoxCalculo.Text = Valor;
            lblOp.Text = "";
            valorc = true;
            if (textBoxCalculo.Text == "")
            {
                textBoxCalculo.Text = "0";
                valorc = true;
            }
            if (textBoxCalculo.Text == "0")
            {
                return;
            }
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {//n^2
            Contar2 = Double.Parse(textBoxCalculo.Text);
            textBoxCalculo.Text =(Contar2 * Contar2).ToString();
            lblOp.Text = textBoxCalculo.Text;
            listBoxResults.Items.Add( Contar2.ToString() +" ^2 " + " = " + Result);
            valorc = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {// função 1/n
            Contar2 = Double.Parse(textBoxCalculo.Text);
            textBoxCalculo.Text = (1 / Contar2).ToString();
            lblOp.Text = textBoxCalculo.Text;
            listBoxResults.Items.Add(" 1 " + "/" + Contar2.ToString() + " = " + textBoxCalculo.Text);
            valorc = true;
        }

        private void btnI_Click(object sender, EventArgs e)
        {// *-1
            Contar2 = Double.Parse(textBoxCalculo.Text);
            textBoxCalculo.Text = (Contar2 * -1).ToString();
            lblOp.Text = textBoxCalculo.Text;
            listBoxResults.Items.Add(Contar2.ToString() +" * -1 " + " = " + textBoxCalculo.Text);
            valorc = true;
        }

        private void btnP_Click(object sender, EventArgs e)
        {//Função do ponto
            if (valorc == true)
            {
                return;
            }
            if(pontoc == true)
            {
                textBoxCalculo.Text = textBoxCalculo.Text + ",";
                pontoc = false;
            }
            
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {//raiz
            Contar2 = Double.Parse(textBoxCalculo.Text);
            textBoxCalculo.Text = Math.Sqrt(Contar2).ToString();
            lblOp.Text = textBoxCalculo.Text;
            listBoxResults.Items.Add(" √ " +Contar2.ToString()+" = " + textBoxCalculo.Text);
            valorc = true;
        }

        private void btnPorc_Click(object sender, EventArgs e)
        {//  %
            Contar2 = Double.Parse(textBoxCalculo.Text);
            lblOp.Text = (Contar2 / 100).ToString();
            textBoxCalculo.Text = (Contar2 / 100).ToString();
            listBoxResults.Items.Add(Contar2.ToString() +" % "+ " = "+ textBoxCalculo.Text);
            valorc = true;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operation = "*";
            Contar1 = Double.Parse(textBoxCalculo.Text);
            lblOp.Text = Contar1.ToString() + operation;
            textBoxCalculo.Text = "";
            valorc = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            Contar1 = Double.Parse(textBoxCalculo.Text);
            lblOp.Text = Contar1.ToString() + operation;
            textBoxCalculo.Text = "";
            valorc = true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operation = "+";
            Contar1 = Double.Parse(textBoxCalculo.Text);
            lblOp.Text = Contar1.ToString() + operation;
            textBoxCalculo.Text = "";
            valorc = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            Contar1 = Double.Parse(textBoxCalculo.Text);
            lblOp.Text = Contar1.ToString() + operation;
            textBoxCalculo.Text = "";
            valorc = true;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            Contar2 = Double.Parse(textBoxCalculo.Text);

            if (operation == "+")
            {
                Result = Contar1 + Contar2;
                lblOp.Text = Result.ToString();
                textBoxCalculo.Text = Result.ToString();
                listBoxResults.Items.Add(Contar1.ToString() + " + " + Contar2.ToString() + " = " + Result);
                valorc = true;   
            }

            if (operation == "-")
            {
                Result = Contar1 - Contar2;
                lblOp.Text = Contar1.ToString() + operation + Contar2.ToString() + " = " + Result;
                textBoxCalculo.Text = Result.ToString();
                listBoxResults.Items.Add(Contar1.ToString() + " - " + Contar2.ToString() + " = " + Result);
                valorc = true;
            }
            if (operation == "/")
            {
                Result = Contar1 / Contar2;
                lblOp.Text = Result.ToString();
                textBoxCalculo.Text = Result.ToString();
                listBoxResults.Items.Add(Contar1.ToString() + " / " + Contar2.ToString() + " = " + Result);
                valorc = true;                
            }
            if (operation == "*")
            {
                Result = Contar1 * Contar2;
                lblOp.Text = Result.ToString();
                textBoxCalculo.Text = Result.ToString();
                listBoxResults.Items.Add(Contar1.ToString() + " * " + Contar2.ToString() + " = " + Result);
                valorc = true;
            }

            if(textBoxCalculo.Text == "0")
            {
                return;
            }
        }
        //Botoes dos numeros
        private void Btn0_Click(object sender, EventArgs e)
        {
            if (textBoxCalculo.Text == "0")
            {
                return;
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "0";
                
            }
            if(valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "0";
                lblOp.Text = lblOp.Text + "0";
                valorc = false;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "9";
                lblOp.Text = lblOp.Text + "9";
                valorc = false;
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "9";
            }
           
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "8";
                lblOp.Text = lblOp.Text + "8";
                valorc = false;
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "8";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "7";
                lblOp.Text = lblOp.Text + "7";
                valorc = false;
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "7";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "6";
                lblOp.Text = lblOp.Text + "6";
                valorc = false;
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "6";
            } 
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "5";
                lblOp.Text = lblOp.Text + "5";
                valorc = false;  
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "5";
            }
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "4";
                lblOp.Text = lblOp.Text + "4";
                valorc = false;  
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "4";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "3";
                lblOp.Text = lblOp.Text + "3";
                valorc = false;  
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "3";
            }
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "2";
                lblOp.Text = lblOp.Text + "2";
                valorc = false;
            }
            else
            {
                textBoxCalculo.Text = textBoxCalculo.Text + "2";   
            }
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (valorc == true)
            {
                textBoxCalculo.Text = "";
                textBoxCalculo.Text = "1";
                lblOp.Text = lblOp.Text + "1";
                valorc = false; 
            }
            else
            { 
                textBoxCalculo.Text = textBoxCalculo.Text + "1";
            }
        }
    }
}
