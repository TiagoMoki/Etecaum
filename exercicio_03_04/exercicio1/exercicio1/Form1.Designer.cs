namespace exercicio1
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
            this.gb_dp = new System.Windows.Forms.GroupBox();
            this.txt_func = new System.Windows.Forms.TextBox();
            this.lbl_func = new System.Windows.Forms.Label();
            this.gb_sb = new System.Windows.Forms.GroupBox();
            this.btn_calcularsb = new System.Windows.Forms.Button();
            this.txt_calcularsb = new System.Windows.Forms.TextBox();
            this.txt_horase = new System.Windows.Forms.TextBox();
            this.txt_horast = new System.Windows.Forms.TextBox();
            this.lbl_horase = new System.Windows.Forms.Label();
            this.lbl_horast = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_calcularco = new System.Windows.Forms.TextBox();
            this.txt_valorv = new System.Windows.Forms.TextBox();
            this.btn_calcuco = new System.Windows.Forms.Button();
            this.lbl_valorv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_calculardes = new System.Windows.Forms.TextBox();
            this.btn_calculardes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_calcularsl = new System.Windows.Forms.TextBox();
            this.btn_calcularsl = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.gb_dp.SuspendLayout();
            this.gb_sb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_dp
            // 
            this.gb_dp.Controls.Add(this.txt_func);
            this.gb_dp.Controls.Add(this.lbl_func);
            this.gb_dp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dp.ForeColor = System.Drawing.Color.Red;
            this.gb_dp.Location = new System.Drawing.Point(23, 13);
            this.gb_dp.Name = "gb_dp";
            this.gb_dp.Size = new System.Drawing.Size(312, 75);
            this.gb_dp.TabIndex = 0;
            this.gb_dp.TabStop = false;
            this.gb_dp.Text = "DADOS PESSOAIS";
            // 
            // txt_func
            // 
            this.txt_func.Location = new System.Drawing.Point(132, 29);
            this.txt_func.Name = "txt_func";
            this.txt_func.Size = new System.Drawing.Size(133, 20);
            this.txt_func.TabIndex = 1;
            // 
            // lbl_func
            // 
            this.lbl_func.AutoSize = true;
            this.lbl_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_func.ForeColor = System.Drawing.Color.Black;
            this.lbl_func.Location = new System.Drawing.Point(38, 32);
            this.lbl_func.Name = "lbl_func";
            this.lbl_func.Size = new System.Drawing.Size(77, 13);
            this.lbl_func.TabIndex = 0;
            this.lbl_func.Text = "Funcionário:";
            // 
            // gb_sb
            // 
            this.gb_sb.Controls.Add(this.btn_calcularsb);
            this.gb_sb.Controls.Add(this.txt_calcularsb);
            this.gb_sb.Controls.Add(this.txt_horase);
            this.gb_sb.Controls.Add(this.txt_horast);
            this.gb_sb.Controls.Add(this.lbl_horase);
            this.gb_sb.Controls.Add(this.lbl_horast);
            this.gb_sb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_sb.ForeColor = System.Drawing.Color.Red;
            this.gb_sb.Location = new System.Drawing.Point(23, 114);
            this.gb_sb.Name = "gb_sb";
            this.gb_sb.Size = new System.Drawing.Size(312, 157);
            this.gb_sb.TabIndex = 1;
            this.gb_sb.TabStop = false;
            this.gb_sb.Text = "SÁLARIO BASE";
            // 
            // btn_calcularsb
            // 
            this.btn_calcularsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcularsb.ForeColor = System.Drawing.Color.Black;
            this.btn_calcularsb.Location = new System.Drawing.Point(231, 128);
            this.btn_calcularsb.Name = "btn_calcularsb";
            this.btn_calcularsb.Size = new System.Drawing.Size(75, 23);
            this.btn_calcularsb.TabIndex = 5;
            this.btn_calcularsb.Text = "Calcular";
            this.btn_calcularsb.UseVisualStyleBackColor = true;
            this.btn_calcularsb.Click += new System.EventHandler(this.btn_calcularsb_Click);
            // 
            // txt_calcularsb
            // 
            this.txt_calcularsb.Location = new System.Drawing.Point(125, 131);
            this.txt_calcularsb.Name = "txt_calcularsb";
            this.txt_calcularsb.Size = new System.Drawing.Size(100, 20);
            this.txt_calcularsb.TabIndex = 4;
            // 
            // txt_horase
            // 
            this.txt_horase.Location = new System.Drawing.Point(125, 85);
            this.txt_horase.Name = "txt_horase";
            this.txt_horase.Size = new System.Drawing.Size(100, 20);
            this.txt_horase.TabIndex = 3;
            // 
            // txt_horast
            // 
            this.txt_horast.Location = new System.Drawing.Point(125, 40);
            this.txt_horast.Name = "txt_horast";
            this.txt_horast.Size = new System.Drawing.Size(100, 20);
            this.txt_horast.TabIndex = 2;
            this.txt_horast.TextChanged += new System.EventHandler(this.txt_horast_TextChanged);
            // 
            // lbl_horase
            // 
            this.lbl_horase.AutoSize = true;
            this.lbl_horase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horase.ForeColor = System.Drawing.Color.Black;
            this.lbl_horase.Location = new System.Drawing.Point(41, 85);
            this.lbl_horase.Name = "lbl_horase";
            this.lbl_horase.Size = new System.Drawing.Size(83, 13);
            this.lbl_horase.TabIndex = 1;
            this.lbl_horase.Text = "Horas Extras:";
            // 
            // lbl_horast
            // 
            this.lbl_horast.AutoSize = true;
            this.lbl_horast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horast.ForeColor = System.Drawing.Color.Black;
            this.lbl_horast.Location = new System.Drawing.Point(3, 43);
            this.lbl_horast.Name = "lbl_horast";
            this.lbl_horast.Size = new System.Drawing.Size(118, 13);
            this.lbl_horast.TabIndex = 0;
            this.lbl_horast.Text = "Horas Trabalhadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_calcularco);
            this.groupBox1.Controls.Add(this.txt_valorv);
            this.groupBox1.Controls.Add(this.btn_calcuco);
            this.groupBox1.Controls.Add(this.lbl_valorv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(23, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMISSÃO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_calcularco
            // 
            this.txt_calcularco.Location = new System.Drawing.Point(125, 93);
            this.txt_calcularco.Name = "txt_calcularco";
            this.txt_calcularco.Size = new System.Drawing.Size(100, 20);
            this.txt_calcularco.TabIndex = 4;
            this.txt_calcularco.TextChanged += new System.EventHandler(this.txt_resulco_TextChanged);
            // 
            // txt_valorv
            // 
            this.txt_valorv.Location = new System.Drawing.Point(125, 52);
            this.txt_valorv.Name = "txt_valorv";
            this.txt_valorv.Size = new System.Drawing.Size(100, 20);
            this.txt_valorv.TabIndex = 3;
            // 
            // btn_calcuco
            // 
            this.btn_calcuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcuco.ForeColor = System.Drawing.Color.Black;
            this.btn_calcuco.Location = new System.Drawing.Point(231, 121);
            this.btn_calcuco.Name = "btn_calcuco";
            this.btn_calcuco.Size = new System.Drawing.Size(75, 23);
            this.btn_calcuco.TabIndex = 2;
            this.btn_calcuco.Text = "Calcular";
            this.btn_calcuco.UseVisualStyleBackColor = true;
            this.btn_calcuco.Click += new System.EventHandler(this.btn_calcuco_Click);
            // 
            // lbl_valorv
            // 
            this.lbl_valorv.AutoSize = true;
            this.lbl_valorv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorv.ForeColor = System.Drawing.Color.Black;
            this.lbl_valorv.Location = new System.Drawing.Point(41, 52);
            this.lbl_valorv.Name = "lbl_valorv";
            this.lbl_valorv.Size = new System.Drawing.Size(80, 13);
            this.lbl_valorv.TabIndex = 1;
            this.lbl_valorv.Text = "Valor Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0% <2000 - 2% <3000 -15%> 3000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_calculardes);
            this.groupBox2.Controls.Add(this.btn_calculardes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(23, 509);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESCONTOS";
            // 
            // txt_calculardes
            // 
            this.txt_calculardes.Location = new System.Drawing.Point(41, 55);
            this.txt_calculardes.Name = "txt_calculardes";
            this.txt_calculardes.Size = new System.Drawing.Size(155, 20);
            this.txt_calculardes.TabIndex = 2;
            // 
            // btn_calculardes
            // 
            this.btn_calculardes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculardes.ForeColor = System.Drawing.Color.Black;
            this.btn_calculardes.Location = new System.Drawing.Point(231, 52);
            this.btn_calculardes.Name = "btn_calculardes";
            this.btn_calculardes.Size = new System.Drawing.Size(75, 23);
            this.btn_calculardes.TabIndex = 1;
            this.btn_calculardes.Text = "Calcular";
            this.btn_calculardes.UseVisualStyleBackColor = true;
            this.btn_calculardes.Click += new System.EventHandler(this.btn_calculardes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "0% <1400 -  9% <2600 - 15% > 2600";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_calcularsl);
            this.groupBox3.Controls.Add(this.btn_calcularsl);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(23, 660);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 77);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SÁLARIO LÍQUIDO";
            // 
            // txt_calcularsl
            // 
            this.txt_calcularsl.Location = new System.Drawing.Point(41, 42);
            this.txt_calcularsl.Name = "txt_calcularsl";
            this.txt_calcularsl.Size = new System.Drawing.Size(155, 20);
            this.txt_calcularsl.TabIndex = 1;
            // 
            // btn_calcularsl
            // 
            this.btn_calcularsl.BackColor = System.Drawing.SystemColors.Control;
            this.btn_calcularsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcularsl.ForeColor = System.Drawing.Color.Black;
            this.btn_calcularsl.Location = new System.Drawing.Point(231, 39);
            this.btn_calcularsl.Name = "btn_calcularsl";
            this.btn_calcularsl.Size = new System.Drawing.Size(75, 23);
            this.btn_calcularsl.TabIndex = 0;
            this.btn_calcularsl.Text = "Calcular";
            this.btn_calcularsl.UseVisualStyleBackColor = false;
            this.btn_calcularsl.Click += new System.EventHandler(this.btn_calcularsl_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sair.Image = global::exercicio1.Properties.Resources.passarin;
            this.btn_sair.Location = new System.Drawing.Point(408, 372);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "X";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 763);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_sb);
            this.Controls.Add(this.gb_dp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_dp.ResumeLayout(false);
            this.gb_dp.PerformLayout();
            this.gb_sb.ResumeLayout(false);
            this.gb_sb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_dp;
        private System.Windows.Forms.TextBox txt_func;
        private System.Windows.Forms.Label lbl_func;
        private System.Windows.Forms.GroupBox gb_sb;
        private System.Windows.Forms.Button btn_calcularsb;
        private System.Windows.Forms.TextBox txt_calcularsb;
        private System.Windows.Forms.TextBox txt_horase;
        private System.Windows.Forms.TextBox txt_horast;
        private System.Windows.Forms.Label lbl_horase;
        private System.Windows.Forms.Label lbl_horast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_calcularco;
        private System.Windows.Forms.TextBox txt_valorv;
        private System.Windows.Forms.Button btn_calcuco;
        private System.Windows.Forms.Label lbl_valorv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_calculardes;
        private System.Windows.Forms.Button btn_calculardes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_calcularsl;
        private System.Windows.Forms.Button btn_calcularsl;
        private System.Windows.Forms.Button btn_sair;
    }
}

