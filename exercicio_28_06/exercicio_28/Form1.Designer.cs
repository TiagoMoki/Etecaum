namespace exercicio_28
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_curso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_ano = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_aluno = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gb_notas = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mf = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_notas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // cbb_curso
            // 
            this.cbb_curso.FormattingEnabled = true;
            this.cbb_curso.Items.AddRange(new object[] {
            "Administração",
            "Informática"});
            this.cbb_curso.Location = new System.Drawing.Point(12, 79);
            this.cbb_curso.Name = "cbb_curso";
            this.cbb_curso.Size = new System.Drawing.Size(121, 21);
            this.cbb_curso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano:";
            // 
            // cbb_ano
            // 
            this.cbb_ano.FormattingEnabled = true;
            this.cbb_ano.Items.AddRange(new object[] {
            "1ºAno",
            "2ºAno",
            "3ºAno"});
            this.cbb_ano.Location = new System.Drawing.Point(184, 79);
            this.cbb_ano.Name = "cbb_ano";
            this.cbb_ano.Size = new System.Drawing.Size(121, 21);
            this.cbb_ano.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aluno:";
            // 
            // cbb_aluno
            // 
            this.cbb_aluno.FormattingEnabled = true;
            this.cbb_aluno.Location = new System.Drawing.Point(363, 79);
            this.cbb_aluno.Name = "cbb_aluno";
            this.cbb_aluno.Size = new System.Drawing.Size(121, 21);
            this.cbb_aluno.TabIndex = 5;
            this.cbb_aluno.SelectedIndexChanged += new System.EventHandler(this.cbb_aluno_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(541, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(553, 232);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(133, 69);
            this.btn_novo.TabIndex = 7;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 67);
            this.button2.TabIndex = 8;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 68);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gb_notas
            // 
            this.gb_notas.Controls.Add(this.txt_mf);
            this.gb_notas.Controls.Add(this.label8);
            this.gb_notas.Controls.Add(this.button4);
            this.gb_notas.Controls.Add(this.txt_4);
            this.gb_notas.Controls.Add(this.txt_3);
            this.gb_notas.Controls.Add(this.txt_2);
            this.gb_notas.Controls.Add(this.txt_1);
            this.gb_notas.Controls.Add(this.label7);
            this.gb_notas.Controls.Add(this.label6);
            this.gb_notas.Controls.Add(this.label5);
            this.gb_notas.Controls.Add(this.label4);
            this.gb_notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_notas.Location = new System.Drawing.Point(15, 170);
            this.gb_notas.Name = "gb_notas";
            this.gb_notas.Size = new System.Drawing.Size(469, 203);
            this.gb_notas.TabIndex = 10;
            this.gb_notas.TabStop = false;
            this.gb_notas.Text = "Menções";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "1ºAno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "2ºAno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "3ºAno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "4ºAno";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(84, 45);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 22);
            this.txt_1.TabIndex = 4;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(84, 85);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 22);
            this.txt_2.TabIndex = 5;
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(84, 122);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(100, 22);
            this.txt_3.TabIndex = 6;
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(84, 165);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(100, 22);
            this.txt_4.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 57);
            this.button4.TabIndex = 8;
            this.button4.Text = "Calcular Média";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Média Final:";
            // 
            // txt_mf
            // 
            this.txt_mf.Location = new System.Drawing.Point(307, 159);
            this.txt_mf.Name = "txt_mf";
            this.txt_mf.Size = new System.Drawing.Size(115, 22);
            this.txt_mf.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 396);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 186);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 611);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gb_notas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbb_aluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_ano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_curso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_notas.ResumeLayout(false);
            this.gb_notas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_aluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gb_notas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_mf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

