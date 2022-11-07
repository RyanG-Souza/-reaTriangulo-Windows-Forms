using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁreaTriangulo_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Calcular_Click(object sender, EventArgs e)
        {
            //armazenar os valores base e altura
            double b = double.Parse(txb_Base.Text.ToString());
            double a = double.Parse(txb_Altura.Text.ToString());

            //fazer a area do triangulo
            double area = (b * a) / 2;
           
            txb_Resultado.Text = (area.ToString());

            //se o resultado for positivo deixar verde, caso contrario vermelho
            if (double.Parse(txb_Resultado.Text.ToString()) >= 0)
            {
                txb_Resultado.ForeColor = Color.Green;
            }
            else
            {
                txb_Resultado.ForeColor = Color.Red;
            }
        }

        
    }
}
