using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exLancaNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota, notat = 0;
            if ((txt1.Equals("")) || (txt2.Equals("")) || (txt3.Equals("")) || (txt4.Equals("")))
            {

            }
            else
            {
                nota = double.Parse(txt1.Text);
                notat = notat + nota;
                nota = double.Parse(txt2.Text);
                notat = notat + nota;
                nota = double.Parse(txt3.Text);
                notat = notat + nota;
                nota = double.Parse(txt4.Text);
                notat = notat + nota;
                notat = notat / 4;

                txtMf.Text = Convert.ToString(notat);
            }
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboCurso.SelectedIndex == 0) && (cboAno.SelectedIndex == 0))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Gabriel");
                cboAluno.Items.Add("Bruno");
            }
            else if ((cboCurso.SelectedIndex == 0) && (cboAno.SelectedIndex == 1))
            {
                cboAluno.Items.Clear();

            }
            else if ((cboCurso.SelectedIndex == 0) && (cboAno.SelectedIndex == 2))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Isabela");
                cboAluno.Items.Add("Karina");
            }
            else if ((cboCurso.SelectedIndex == 1) && (cboAno.SelectedIndex == 0))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Carlos");

            }
            else if ((cboCurso.SelectedIndex == 1) && (cboAno.SelectedIndex == 1))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Maria Eduarda");
                cboAluno.Items.Add("Samuel");
            }

            else if ((cboCurso.SelectedIndex == 1) && (cboAno.SelectedIndex == 2))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Paulo");
                cboAluno.Items.Add("Mayara");
            }
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboCurso.SelectedIndex == 0) && (cboAno.SelectedIndex == 0))
            {

                cboAluno.Items.Clear();
                cboAluno.Items.Add("Gabriel");
                cboAluno.Items.Add("Bruno");
            }
            else if ((cboCurso.SelectedIndex == 0) && (cboAno.SelectedIndex == 1))
            {
                cboAluno.Items.Clear();

            }
            else if ((cboCurso.SelectedIndex == 0) && (cboAno.SelectedIndex == 2))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Isabela");
                cboAluno.Items.Add("Karina");
            }
            else if ((cboCurso.SelectedIndex == 1) && (cboAno.SelectedIndex == 0))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Carlos");

            }
            else if ((cboCurso.SelectedIndex == 1) && (cboAno.SelectedIndex == 1))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Maria Eduarda");
                cboAluno.Items.Add("Samuel");
            }
            else if ((cboCurso.SelectedIndex == 1) && (cboAno.SelectedIndex == 2))
            {
                cboAluno.Items.Clear();
                cboAluno.Items.Add("Paulo");
                cboAluno.Items.Add("Mayara");


            }
        }

        private void cboAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurso.SelectedIndex == 0) // Adm
            {
                if (cboAno.SelectedIndex == 0)
                {
                    if (cboAluno.SelectedIndex == 0)
                    {
                        pcb_aluno.Image = Properties.Resources.fotoh1;
                    }//Gabriel
                    else if (cboAluno.SelectedIndex == 1)
                    {                      
                            pcb_aluno.Image = Properties.Resources.fotoh2;
                        }//Bruno
                    
                }// if ano
                else  if (cboAno.SelectedIndex == 2)
                {
                    if (cboAluno.SelectedIndex == 0)
                    {
                        pcb_aluno.Image = Properties.Resources.fotom1;
                    }//Isabela
                    else if (cboAluno.SelectedIndex == 1)
                    {
                        pcb_aluno.Image = Properties.Resources.fotom2;
                    }//Karina
                }// 3 ano
            }//if curso
            else if (cboCurso.SelectedIndex == 1)//inf 
            {
                if (cboAno.SelectedIndex == 0)
                {
                    if (cboAluno.SelectedIndex == 0)
                    {
                        pcb_aluno.Image = Properties.Resources.fotoh3;
                    }//Carlos
                }// if ano
                else if (cboAno.SelectedIndex == 1)
                {
                    if (cboAluno.SelectedIndex == 0)
                    {
                        pcb_aluno.Image = Properties.Resources.fotom3;
                    }//Maria Eduarda
                    if (cboAluno.SelectedIndex == 1)
                    {
                        pcb_aluno.Image = Properties.Resources.fotoh4;
                    }//Samuel
                }//ano2
                else if (cboAno.SelectedIndex == 2)
                {
                    if (cboAluno.SelectedIndex == 0)
                    {
                        pcb_aluno.Image = Properties.Resources.fotoh5;
                    }//Paulo
                    if (cboAluno.SelectedIndex == 1)
                    {
                        pcb_aluno.Image = Properties.Resources.fotom4;
                    }//Mayara
                }//ano3
            }//if curso
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtMf.Text = "";
            txt1.Text = "";
            txt4.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            cboAluno.SelectedIndex = -1;
            cboAno.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            pcb_aluno.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
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

        private void btnConf_Click(object sender, EventArgs e)
        {
            lstDados.Items.Add("Curso: " + cboCurso.Text + " Ano: " + cboAno.Text + " Nome:  " + cboAluno.Text + " Media final: " + txtMf.Text);
        }
    }//i
}//i
