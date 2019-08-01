namespace Andre_Butler___12Ho___VS___Game
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
            this.components = new System.ComponentModel.Container();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrFirework = new System.Windows.Forms.Timer(this.components);
            this.tmrPotato = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.Location = new System.Drawing.Point(12, 38);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(650, 400);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tmrFirework
            // 
            this.tmrFirework.Enabled = true;
            this.tmrFirework.Tick += new System.EventHandler(this.tmrFirework_Tick);
            // 
            // tmrPotato
            // 
            this.tmrPotato.Enabled = true;
            this.tmrPotato.Interval = 50;
            this.tmrPotato.Tick += new System.EventHandler(this.tmrPotato_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrFirework;
        private System.Windows.Forms.Timer tmrPotato;
    }
}

