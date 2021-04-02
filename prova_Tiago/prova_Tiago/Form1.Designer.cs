namespace prova_Tiago
{
    partial class btn_cancelar
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
            this.gb_me = new System.Windows.Forms.GroupBox();
            this.txt_ing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckb_sim = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_visu = new System.Windows.Forms.GroupBox();
            this.rdb_5d = new System.Windows.Forms.RadioButton();
            this.rdb_4d = new System.Windows.Forms.RadioButton();
            this.rdb_3d = new System.Windows.Forms.RadioButton();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.cbb_ho = new System.Windows.Forms.ComboBox();
            this.cbb_filme = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.gb_me.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_visu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_me
            // 
            this.gb_me.Controls.Add(this.txt_ing);
            this.gb_me.Controls.Add(this.label5);
            this.gb_me.Controls.Add(this.ckb_sim);
            this.gb_me.Location = new System.Drawing.Point(414, 361);
            this.gb_me.Name = "gb_me";
            this.gb_me.Size = new System.Drawing.Size(250, 266);
            this.gb_me.TabIndex = 0;
            this.gb_me.TabStop = false;
            this.gb_me.Text = "Meia Entrada";
            // 
            // txt_ing
            // 
            this.txt_ing.Enabled = false;
            this.txt_ing.Location = new System.Drawing.Point(34, 127);
            this.txt_ing.Name = "txt_ing";
            this.txt_ing.Size = new System.Drawing.Size(100, 20);
            this.txt_ing.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Qtde.ingresso";
            // 
            // ckb_sim
            // 
            this.ckb_sim.AutoSize = true;
            this.ckb_sim.Location = new System.Drawing.Point(34, 59);
            this.ckb_sim.Name = "ckb_sim";
            this.ckb_sim.Size = new System.Drawing.Size(43, 17);
            this.ckb_sim.TabIndex = 0;
            this.ckb_sim.Text = "Sim";
            this.ckb_sim.UseVisualStyleBackColor = true;
            this.ckb_sim.CheckedChanged += new System.EventHandler(this.ckb_sim_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prova_Tiago.Properties.Resources.cinema;
            this.pictureBox1.Location = new System.Drawing.Point(472, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 265);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horário:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de Ingressos:";
            // 
            // gb_visu
            // 
            this.gb_visu.Controls.Add(this.rdb_5d);
            this.gb_visu.Controls.Add(this.rdb_4d);
            this.gb_visu.Controls.Add(this.rdb_3d);
            this.gb_visu.Location = new System.Drawing.Point(53, 376);
            this.gb_visu.Name = "gb_visu";
            this.gb_visu.Size = new System.Drawing.Size(235, 186);
            this.gb_visu.TabIndex = 6;
            this.gb_visu.TabStop = false;
            this.gb_visu.Text = "Visualização";
            // 
            // rdb_5d
            // 
            this.rdb_5d.AutoSize = true;
            this.rdb_5d.Location = new System.Drawing.Point(37, 149);
            this.rdb_5d.Name = "rdb_5d";
            this.rdb_5d.Size = new System.Drawing.Size(39, 17);
            this.rdb_5d.TabIndex = 2;
            this.rdb_5d.TabStop = true;
            this.rdb_5d.Text = "5D";
            this.rdb_5d.UseVisualStyleBackColor = true;
            this.rdb_5d.CheckedChanged += new System.EventHandler(this.rdb_5d_CheckedChanged);
            // 
            // rdb_4d
            // 
            this.rdb_4d.AutoSize = true;
            this.rdb_4d.Location = new System.Drawing.Point(37, 98);
            this.rdb_4d.Name = "rdb_4d";
            this.rdb_4d.Size = new System.Drawing.Size(39, 17);
            this.rdb_4d.TabIndex = 1;
            this.rdb_4d.TabStop = true;
            this.rdb_4d.Text = "4D";
            this.rdb_4d.UseVisualStyleBackColor = true;
            this.rdb_4d.CheckedChanged += new System.EventHandler(this.rdb_4d_CheckedChanged);
            // 
            // rdb_3d
            // 
            this.rdb_3d.AutoSize = true;
            this.rdb_3d.Location = new System.Drawing.Point(37, 44);
            this.rdb_3d.Name = "rdb_3d";
            this.rdb_3d.Size = new System.Drawing.Size(39, 17);
            this.rdb_3d.TabIndex = 0;
            this.rdb_3d.TabStop = true;
            this.rdb_3d.Text = "3D";
            this.rdb_3d.UseVisualStyleBackColor = true;
            this.rdb_3d.CheckedChanged += new System.EventHandler(this.rdb_3d_CheckedChanged);
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(704, 361);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(86, 44);
            this.btn_comprar.TabIndex = 7;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(704, 429);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(86, 40);
            this.btn_can.TabIndex = 8;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(704, 499);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(86, 43);
            this.btn_finalizar.TabIndex = 9;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(704, 569);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(86, 44);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // cbb_ho
            // 
            this.cbb_ho.FormattingEnabled = true;
            this.cbb_ho.Items.AddRange(new object[] {
            "",
            "15:00",
            "19:00",
            "21:30"});
            this.cbb_ho.Location = new System.Drawing.Point(53, 215);
            this.cbb_ho.Name = "cbb_ho";
            this.cbb_ho.Size = new System.Drawing.Size(121, 21);
            this.cbb_ho.TabIndex = 0;
            this.cbb_ho.SelectedIndexChanged += new System.EventHandler(this.cbb_ho_SelectedIndexChanged);
            // 
            // cbb_filme
            // 
            this.cbb_filme.FormattingEnabled = true;
            this.cbb_filme.Items.AddRange(new object[] {
            "",
            "Jurassic World: Reino Ameaçado",
            "Deadpool 2",
            "Han Solo: Uma História Star Wars"});
            this.cbb_filme.Location = new System.Drawing.Point(256, 111);
            this.cbb_filme.Name = "cbb_filme";
            this.cbb_filme.Size = new System.Drawing.Size(121, 21);
            this.cbb_filme.TabIndex = 11;
            this.cbb_filme.SelectedIndexChanged += new System.EventHandler(this.cbb_filme_SelectedIndexChanged);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(53, 112);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(100, 20);
            this.txt_data.TabIndex = 12;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(256, 216);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 13;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // btn_cancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 678);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.cbb_filme);
            this.Controls.Add(this.cbb_ho);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.gb_visu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_me);
            this.Name = "btn_cancelar";
            this.Text = "Form1";
            this.gb_me.ResumeLayout(false);
            this.gb_me.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_visu.ResumeLayout(false);
            this.gb_visu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_me;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_visu;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_ing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckb_sim;
        private System.Windows.Forms.RadioButton rdb_5d;
        private System.Windows.Forms.RadioButton rdb_4d;
        private System.Windows.Forms.RadioButton rdb_3d;
        private System.Windows.Forms.ComboBox cbb_ho;
        private System.Windows.Forms.ComboBox cbb_filme;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_total;
    }
}

