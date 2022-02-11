
namespace MeuDespertador
{
    partial class Frm_Temporizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Temporizador));
            this.Lbl_Tempo = new System.Windows.Forms.Label();
            this.Lbl_TempoInicial = new System.Windows.Forms.Label();
            this.Txt_Minutos = new System.Windows.Forms.TextBox();
            this.Pnl_Image = new System.Windows.Forms.Panel();
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Btn_Pausar = new System.Windows.Forms.Button();
            this.Btn_Resetar = new System.Windows.Forms.Button();
            this.Lbl_TempoAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Tempo
            // 
            this.Lbl_Tempo.AutoSize = true;
            this.Lbl_Tempo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Tempo.Location = new System.Drawing.Point(12, 72);
            this.Lbl_Tempo.Name = "Lbl_Tempo";
            this.Lbl_Tempo.Size = new System.Drawing.Size(187, 20);
            this.Lbl_Tempo.TabIndex = 1;
            this.Lbl_Tempo.Text = "Tempo (em minutos):";
            // 
            // Lbl_TempoInicial
            // 
            this.Lbl_TempoInicial.AutoSize = true;
            this.Lbl_TempoInicial.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoInicial.Location = new System.Drawing.Point(199, 232);
            this.Lbl_TempoInicial.Name = "Lbl_TempoInicial";
            this.Lbl_TempoInicial.Size = new System.Drawing.Size(121, 30);
            this.Lbl_TempoInicial.TabIndex = 2;
            this.Lbl_TempoInicial.Text = "00:00:00";
            // 
            // Txt_Minutos
            // 
            this.Txt_Minutos.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Minutos.Location = new System.Drawing.Point(206, 68);
            this.Txt_Minutos.Name = "Txt_Minutos";
            this.Txt_Minutos.Size = new System.Drawing.Size(114, 31);
            this.Txt_Minutos.TabIndex = 3;
            // 
            // Pnl_Image
            // 
            this.Pnl_Image.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_Image.BackgroundImage")));
            this.Pnl_Image.Location = new System.Drawing.Point(12, 140);
            this.Pnl_Image.Name = "Pnl_Image";
            this.Pnl_Image.Size = new System.Drawing.Size(116, 159);
            this.Pnl_Image.TabIndex = 4;
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.Location = new System.Drawing.Point(206, 105);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Ativar.TabIndex = 5;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.UseVisualStyleBackColor = true;
            this.Btn_Ativar.Click += new System.EventHandler(this.Btn_Ativar_Click);
            // 
            // Btn_Pausar
            // 
            this.Btn_Pausar.Location = new System.Drawing.Point(206, 146);
            this.Btn_Pausar.Name = "Btn_Pausar";
            this.Btn_Pausar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Pausar.TabIndex = 6;
            this.Btn_Pausar.Text = "Pausar";
            this.Btn_Pausar.UseVisualStyleBackColor = true;
            this.Btn_Pausar.Click += new System.EventHandler(this.Btn_Pausar_Click);
            // 
            // Btn_Resetar
            // 
            this.Btn_Resetar.Location = new System.Drawing.Point(206, 187);
            this.Btn_Resetar.Name = "Btn_Resetar";
            this.Btn_Resetar.Size = new System.Drawing.Size(114, 34);
            this.Btn_Resetar.TabIndex = 7;
            this.Btn_Resetar.Text = "Resetar";
            this.Btn_Resetar.UseVisualStyleBackColor = true;
            this.Btn_Resetar.Click += new System.EventHandler(this.Btn_Resetar_Click);
            // 
            // Lbl_TempoAtual
            // 
            this.Lbl_TempoAtual.AutoSize = true;
            this.Lbl_TempoAtual.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoAtual.Location = new System.Drawing.Point(206, 266);
            this.Lbl_TempoAtual.Name = "Lbl_TempoAtual";
            this.Lbl_TempoAtual.Size = new System.Drawing.Size(88, 23);
            this.Lbl_TempoAtual.TabIndex = 8;
            this.Lbl_TempoAtual.Text = "00:00:00";
            // 
            // Frm_Temporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.Lbl_TempoAtual);
            this.Controls.Add(this.Btn_Resetar);
            this.Controls.Add(this.Btn_Pausar);
            this.Controls.Add(this.Btn_Ativar);
            this.Controls.Add(this.Pnl_Image);
            this.Controls.Add(this.Txt_Minutos);
            this.Controls.Add(this.Lbl_TempoInicial);
            this.Controls.Add(this.Lbl_Tempo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Temporizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despertador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Tempo;
        private System.Windows.Forms.Label Lbl_TempoInicial;
        private System.Windows.Forms.TextBox Txt_Minutos;
        private System.Windows.Forms.Panel Pnl_Image;
        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.Button Btn_Pausar;
        private System.Windows.Forms.Button Btn_Resetar;
        private System.Windows.Forms.Label Lbl_TempoAtual;
    }
}

