using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_Tiago
{
    public partial class btn_cancelar : Form
    {

        double preco = 8, hor, data, toi;
        int ti, tim;
        
        
        public btn_cancelar()
        {
            InitializeComponent();
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Sair ?",
                "Pergunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            cbb_filme.SelectedIndex = 0;
            txt_total.Text = "";
            txt_ing.Text="";
            txt_data.Text="";
            cbb_ho.SelectedIndex = 0;
            ckb_sim.Checked = false;
            rdb_3d.Checked = false;
            rdb_4d.Checked = false;
            rdb_5d.Checked = false;
       
        }

        private void cbb_filme_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
            }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            string hor;
            hor = cbb_ho.Text;
            if (cbb_filme.SelectedIndex == 1) //Jurassic
            {
                MessageBox.Show("Owen e Claire retornam à ilha Nublar para salvar os dinossauros restantes de um vulcão que está prestes a entrar em erupção. Eles encontram novas e aterrorizantes raças de dinossauros gigantes ao descobrir uma conspiração que ameaça todo o planeta.",
                    "Sinopse do filme");
                MessageBox.Show(txt_data.Text,
                    "Data");
                MessageBox.Show(hor, "Horario");
                
                
            }
            if (cbb_filme.SelectedIndex == 2) //DeadPool
            {
                MessageBox.Show("Sequência das aventuras do Mercenário Tagarela, interpretado por Ryan Reynolds. Na história original, o herói adquire superpoderes após uma experiência científica, e decide se vingar da pessoa responsável por sequestrar sua namorada.");
                MessageBox.Show(txt_data.Text,
                   "Data");
                MessageBox.Show(hor, "Horario");
            }
            if (cbb_filme.SelectedIndex == 3) //Han
            {
                MessageBox.Show("Após uma série de ousadas aventuras, o jovem Han Solo encontra seu futuro copiloto, Chewbacca, e o notório jogador Lando Calrissian.");
                MessageBox.Show(txt_data.Text,
                        "Data");
                MessageBox.Show(hor, "Horario");
            }  
        }

        private void rdb_3d_CheckedChanged(object sender, EventArgs e)
        {
            preco = 9.00;
        }

        private void rdb_4d_CheckedChanged(object sender, EventArgs e)
        {
            preco = 10.00;
        }

        private void rdb_5d_CheckedChanged(object sender, EventArgs e)
        {
            preco = 12.00;
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
        }

        private void ckb_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sim.Checked == true)
            {
                txt_ing.Enabled = true;
              
            }
            else
            {
                txt_ing.Enabled = false;
                txt_ing.Text =  "";
            }
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            double tm,pt;
            ti = int.Parse(txt_total.Text);
            if (ckb_sim.Checked == false)
            {
                pt = preco * ti;
            }
            else
            {
                tim = int.Parse(txt_ing.Text);//aaaa
                toi = ti - tim;
                toi = toi * preco;
                tm = preco / 2;
                pt = toi + tm;
            
            }                                                                                                                                   
          
            
            MessageBox.Show("Valor final foi de:" + pt,
                "Obrigado!");
        }

        private void cbb_ho_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
