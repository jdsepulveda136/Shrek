namespace Shrek
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
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.txt_base = new System.Windows.Forms.TextBox();
            this.chk_escalao = new System.Windows.Forms.CheckBox();
            this.chk_socio = new System.Windows.Forms.CheckBox();
            this.chk_agrava = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_concelho = new System.Windows.Forms.ComboBox();
            this.bt_calcula = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(41, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(167, 24);
            label3.TabIndex = 2;
            label3.Text = "Data Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo do valor da avença";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor base";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Shrek.Properties.Resources.CARETA3;
            this.pictureBox1.Location = new System.Drawing.Point(507, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(223, 89);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(261, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(223, 141);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(120, 20);
            this.txt_nascimento.TabIndex = 6;
            // 
            // txt_base
            // 
            this.txt_base.Location = new System.Drawing.Point(223, 189);
            this.txt_base.Name = "txt_base";
            this.txt_base.Size = new System.Drawing.Size(120, 20);
            this.txt_base.TabIndex = 7;
            // 
            // chk_escalao
            // 
            this.chk_escalao.AutoSize = true;
            this.chk_escalao.Location = new System.Drawing.Point(223, 258);
            this.chk_escalao.Name = "chk_escalao";
            this.chk_escalao.Size = new System.Drawing.Size(162, 17);
            this.chk_escalao.TabIndex = 8;
            this.chk_escalao.Text = "Desconto de escalão? (10%)";
            this.chk_escalao.UseVisualStyleBackColor = true;
            // 
            // chk_socio
            // 
            this.chk_socio.AutoSize = true;
            this.chk_socio.Location = new System.Drawing.Point(223, 282);
            this.chk_socio.Name = "chk_socio";
            this.chk_socio.Size = new System.Drawing.Size(132, 17);
            this.chk_socio.TabIndex = 9;
            this.chk_socio.Text = "Desconto  sócio? (5%)";
            this.chk_socio.UseVisualStyleBackColor = true;
            // 
            // chk_agrava
            // 
            this.chk_agrava.AutoSize = true;
            this.chk_agrava.Location = new System.Drawing.Point(223, 306);
            this.chk_agrava.Name = "chk_agrava";
            this.chk_agrava.Size = new System.Drawing.Size(168, 17);
            this.chk_agrava.TabIndex = 10;
            this.chk_agrava.Text = "Tem agravamento? (12 euros)";
            this.chk_agrava.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reside no Distrito?";
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Location = new System.Drawing.Point(158, 368);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(42, 17);
            this.rb_sim.TabIndex = 12;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "Sim";
            this.rb_sim.UseVisualStyleBackColor = true;
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Location = new System.Drawing.Point(206, 368);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(45, 17);
            this.rb_nao.TabIndex = 13;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CONCELHO";
            // 
            // cmb_concelho
            // 
            this.cmb_concelho.FormattingEnabled = true;
            this.cmb_concelho.Items.AddRange(new object[] {
            "Braga",
            "Amares",
            "Guimarães"});
            this.cmb_concelho.Location = new System.Drawing.Point(421, 364);
            this.cmb_concelho.Name = "cmb_concelho";
            this.cmb_concelho.Size = new System.Drawing.Size(121, 21);
            this.cmb_concelho.TabIndex = 15;
            // 
            // bt_calcula
            // 
            this.bt_calcula.Location = new System.Drawing.Point(507, 409);
            this.bt_calcula.Name = "bt_calcula";
            this.bt_calcula.Size = new System.Drawing.Size(75, 23);
            this.bt_calcula.TabIndex = 16;
            this.bt_calcula.Text = "Calcular";
            this.bt_calcula.UseVisualStyleBackColor = true;
            this.bt_calcula.Click += new System.EventHandler(this.Bt_calcula_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(589, 409);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 17;
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Location = new System.Drawing.Point(48, 409);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(0, 13);
            this.lbl_mensagem.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_mensagem);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.bt_calcula);
            this.Controls.Add(this.cmb_concelho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_nao);
            this.Controls.Add(this.rb_sim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_agrava);
            this.Controls.Add(this.chk_socio);
            this.Controls.Add(this.chk_escalao);
            this.Controls.Add(this.txt_base);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.CheckBox chk_escalao;
        private System.Windows.Forms.CheckBox chk_socio;
        private System.Windows.Forms.CheckBox chk_agrava;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_concelho;
        private System.Windows.Forms.Button bt_calcula;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label lbl_mensagem;
    }
}

