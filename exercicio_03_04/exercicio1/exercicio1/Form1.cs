using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form1 : Form
    {
        double vendap, venda,th,desconto;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_resulco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcularsb_Click(object sender, EventArgs e)
        {
            double hora = 100,horat,horae;
            horat = double.Parse(txt_horast.Text);
            horae = double.Parse(txt_horase.Text);
           th =  (horat + horae) * hora;

            txt_calcularsb.Text = Convert.ToString(th);
        }

        private void txt_horast_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcuco_Click(object sender, EventArgs e)
        {
        
            venda = double.Parse(txt_valorv.Text);
            if ((venda < 3000) && ( venda > 2000)) 
            {
                vendap = venda * 2/100;
            }//venda2k
            else if (venda > 3000)
            {
                vendap = venda * 15/100;
            }
           
            txt_calcularco.Text = Convert.ToString(vendap);
        }

        private void btn_calculardes_Click(object sender, EventArgs e)
        {
            
            if ((venda < 2600) && (venda > 1400))
            {
                desconto = venda * 9 / 100;
            }//venda2k
            else if (venda > 2600)
            {
                desconto = venda * 15 / 100;
            }
            txt_calculardes.Text = Convert.ToString(desconto);
        }

        private void btn_calcularsl_Click(object sender, EventArgs e)
        {
            double sl;
            sl = (th + vendap) - desconto;
            txt_calcularsl.Text = Convert.ToString(sl);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
