namespace teste_flap
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.Pontos = new System.Windows.Forms.Label();
            this.newObj = new System.Windows.Forms.Timer(this.components);
            this.PointPlus = new System.Windows.Forms.Timer(this.components);
            this.DearhLava = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Caixa = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.espaco = new teste_flap.Lava();
            this.lava6 = new teste_flap.Lava();
            this.lava5 = new teste_flap.Lava();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava5)).BeginInit();
            this.SuspendLayout();
            // 
            // timerG
            // 
            this.timerG.Enabled = true;
            this.timerG.Interval = 40;
            this.timerG.Tick += new System.EventHandler(this.timerG_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 40;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // timerX
            // 
            this.timerX.Enabled = true;
            this.timerX.Interval = 50;
            this.timerX.Tick += new System.EventHandler(this.timerX_Tick);
            // 
            // Pontos
            // 
            this.Pontos.AutoSize = true;
            this.Pontos.Location = new System.Drawing.Point(61, 89);
            this.Pontos.Name = "Pontos";
            this.Pontos.Size = new System.Drawing.Size(72, 16);
            this.Pontos.TabIndex = 17;
            this.Pontos.Text = "Pontuação";
            // 
            // newObj
            // 
            this.newObj.Enabled = true;
            this.newObj.Interval = 50;
            this.newObj.Tick += new System.EventHandler(this.newObj_Tick);
            // 
            // PointPlus
            // 
            this.PointPlus.Enabled = true;
            this.PointPlus.Interval = 40;
            // 
            // DearhLava
            // 
            this.DearhLava.Enabled = true;
            this.DearhLava.Interval = 20;
            this.DearhLava.Tick += new System.EventHandler(this.DearhLava_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Pontos);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(187, 212);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // Caixa
            // 
            this.Caixa.Image = global::teste_flap.Properties.Resources.personagem;
            this.Caixa.Location = new System.Drawing.Point(212, 124);
            this.Caixa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Caixa.Name = "Caixa";
            this.Caixa.Size = new System.Drawing.Size(51, 50);
            this.Caixa.TabIndex = 2;
            this.Caixa.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::teste_flap.Properties.Resources.newreset1;
            this.pictureBox3.Location = new System.Drawing.Point(581, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(11, 464);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "reset1";
            this.pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::teste_flap.Properties.Resources.newreset1;
            this.pictureBox1.Location = new System.Drawing.Point(195, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 463);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "reset";
            this.pictureBox1.Visible = false;
            // 
            // espaco
            // 
            this.espaco.Image = global::teste_flap.Properties.Resources.espacamento;
            this.espaco.Location = new System.Drawing.Point(631, 128);
            this.espaco.Margin = new System.Windows.Forms.Padding(4);
            this.espaco.Name = "espaco";
            this.espaco.Size = new System.Drawing.Size(41, 97);
            this.espaco.TabIndex = 21;
            this.espaco.TabStop = false;
            this.espaco.Visible = false;
            // 
            // lava6
            // 
            this.lava6.BackColor = System.Drawing.Color.White;
            this.lava6.Image = global::teste_flap.Properties.Resources.Lava_concertada;
            this.lava6.Location = new System.Drawing.Point(631, 231);
            this.lava6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lava6.Name = "lava6";
            this.lava6.Size = new System.Drawing.Size(55, 305);
            this.lava6.TabIndex = 16;
            this.lava6.TabStop = false;
            // 
            // lava5
            // 
            this.lava5.Image = global::teste_flap.Properties.Resources.Lava_concertada;
            this.lava5.Location = new System.Drawing.Point(631, 0);
            this.lava5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lava5.Name = "lava5";
            this.lava5.Size = new System.Drawing.Size(55, 122);
            this.lava5.TabIndex = 15;
            this.lava5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Caixa);
            this.Controls.Add(this.espaco);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lava6);
            this.Controls.Add(this.lava5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "w";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.PictureBox Caixa;
        private System.Windows.Forms.Label Pontos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Lava lava5;
        private Lava lava6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer newObj;
        private Lava espaco;
        private System.Windows.Forms.Timer PointPlus;
        private System.Windows.Forms.Timer DearhLava;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

