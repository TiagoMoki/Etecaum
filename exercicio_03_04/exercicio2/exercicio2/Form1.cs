using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        double precoto;
        String usuario;
        public Form1()
        {
            InitializeComponent();
            txt_npedi.Enabled = false;
            txt_cod.Enabled = false;
            txt_frete.Enabled = false;
            txt_func.Enabled = false;
            txt_nomep.Enabled = false;
            txt_par.Enabled = false;
            txt_preco.Enabled = false;
            txt_precot.Enabled = false;
            txt_qtde.Enabled = false;
            txt_valort.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            String senha;
            usuario = txt_usuario.Text;
            senha = txt_senha.Text;
            if ((usuario == "jjcarlos") && (senha == "999"))
            {
                txt_npedi.Enabled = true;
                txt_cod.Enabled = true;
                txt_frete.Enabled = true;
                txt_func.Enabled = true;
                txt_nomep.Enabled = true;
                txt_par.Enabled = true;
                txt_preco.Enabled = true;
                txt_precot.Enabled = true;
                txt_qtde.Enabled = true;
                txt_valort.Enabled = true;
                txt_func.Text = "Jjcarlos";
            }
            else
            {

                MessageBox.Show("Usuario e(ou) senha incorreto(s)");

            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novope_Click(object sender, EventArgs e)
        {
            txt_cod.Text = "";
            txt_nomep.Text = "";
            txt_qtde.Text = "";
            txt_preco.Text = "";
            txt_precot.Text = "";
            txt_valort.Text = "";
            txt_par.Text = "";
            txt_frete.Text = "";
            txt_npedi.Text = Convert.ToString(int.Parse(txt_npedi.Text) + 1);
        }

        private void btn_confirmado_Click(object sender, EventArgs e)
        {
            {

                double ValorTotal = double.Parse(txt_valort.Text);
                int parcelas = int.Parse(txt_par.Text);


                if ((txt_frete.Text == "S") || (txt_frete.Text == "s"))
                {
                    ValorTotal += 20;
                    double total = ValorTotal / parcelas;
                    MessageBox.Show(Convert.ToString(total));
                }
                else
                {
                    double total = ValorTotal / parcelas;
                    MessageBox.Show((Convert.ToString(parcelas)) + "X de R$" + (Convert.ToString(total)) );
                }
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_cod.Text = "";
            txt_nomep.Text = "";
            txt_qtde.Text = "";
            txt_preco.Text = "";
            txt_precot.Text = "";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string codigo;
            codigo = txt_cod.Text;

            if (codigo == "1")
            {
                txt_nomep.Text = "Camiseta";
                txt_preco.Text = "50";
            }

            if (codigo == "2")
            {
                txt_nomep.Text = "Camisa";
                txt_preco.Text = "80";
            }


            if (codigo == "3")
            {
                txt_nomep.Text = "Vestido";
                txt_preco.Text = "150";
            }


            if (codigo == "4")
            {
                txt_nomep.Text = "Calça";
                txt_preco.Text = "120";
            }
            if ((codigo != "1") && (codigo != "2") && (codigo != "3") && (codigo != "4"))
            {
                MessageBox.Show("Còdigo invalido!");
                return;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int qnt;
            double preco;

            qnt = int.Parse(txt_qtde.Text);
            preco = double.Parse(txt_preco.Text);

            txt_precot.Text = Convert.ToString(qnt * preco);
            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            double valorTotal;
            valorTotal = double.Parse(txt_precot.Text);
            precoto += valorTotal;


            txt_valort.Text = Convert.ToString(precoto);
        }
    }
}
