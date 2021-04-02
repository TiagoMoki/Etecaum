namespace exLancaNota
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboAluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtMf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalm = new System.Windows.Forms.Button();
            this.lstDados = new System.Windows.Forms.ListBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pcb_aluno = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "Administração",
            "Informática"});
            this.cboCurso.Location = new System.Drawing.Point(61, 70);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 0;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º"});
            this.cboAno.Location = new System.Drawing.Point(228, 70);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(121, 21);
            this.cboAno.TabIndex = 1;
            this.cboAno.SelectedIndexChanged += new System.EventHandler(this.cboAno_SelectedIndexChanged);
            // 
            // cboAluno
            // 
            this.cboAluno.FormattingEnabled = true;
            this.cboAluno.Location = new System.Drawing.Point(416, 70);
            this.cboAluno.Name = "cboAluno";
            this.cboAluno.Size = new System.Drawing.Size(121, 21);
            this.cboAluno.TabIndex = 2;
            this.cboAluno.SelectedIndexChanged += new System.EventHandler(this.cboAluno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aluno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.txtMf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalm);
            this.groupBox1.Location = new System.Drawing.Point(61, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mençoes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "4ºBimestre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "3ºBimestre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "2ºBimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "1ºBimestre";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(75, 176);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(75, 128);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(75, 85);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(75, 46);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // txtMf
            // 
            this.txtMf.Location = new System.Drawing.Point(348, 159);
            this.txtMf.Name = "txtMf";
            this.txtMf.Size = new System.Drawing.Size(110, 20);
            this.txtMf.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Média Final:";
            // 
            // btnCalm
            // 
            this.btnCalm.Location = new System.Drawing.Point(355, 19);
            this.btnCalm.Name = "btnCalm";
            this.btnCalm.Size = new System.Drawing.Size(103, 60);
            this.btnCalm.TabIndex = 0;
            this.btnCalm.Text = "Calcular Média";
            this.btnCalm.UseVisualStyleBackColor = true;
            this.btnCalm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDados
            // 
            this.lstDados.FormattingEnabled = true;
            this.lstDados.Location = new System.Drawing.Point(61, 402);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(476, 134);
            this.lstDados.TabIndex = 8;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(629, 264);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 66);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(629, 336);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(108, 69);
            this.btnConf.TabIndex = 10;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(629, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 71);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pcb_aluno
            // 
            this.pcb_aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_aluno.Location = new System.Drawing.Point(580, 31);
            this.pcb_aluno.Name = "pcb_aluno";
            this.pcb_aluno.Size = new System.Drawing.Size(173, 161);
            this.pcb_aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_aluno.TabIndex = 3;
            this.pcb_aluno.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_aluno);
            this.Controls.Add(this.cboAluno);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.cboCurso);
            this.Name = "Form1";
            this.Text = "Lançamento de Notas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboAluno;
        private System.Windows.Forms.PictureBox pcb_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalm;
        private System.Windows.Forms.ListBox lstDados;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtMf;
        private System.Windows.Forms.Label label4;
    }
}

