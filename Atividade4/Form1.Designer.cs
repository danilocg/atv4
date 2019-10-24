namespace Atividade4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoAltoConstrasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoAmpliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoAtv = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoAltoConstrasteToolStripMenuItem,
            this.modoAmpliadoToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // modoAltoConstrasteToolStripMenuItem
            // 
            this.modoAltoConstrasteToolStripMenuItem.Name = "modoAltoConstrasteToolStripMenuItem";
            this.modoAltoConstrasteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modoAltoConstrasteToolStripMenuItem.Text = "Modo Alto Constraste";
            this.modoAltoConstrasteToolStripMenuItem.Click += new System.EventHandler(this.modoAltoConstrasteToolStripMenuItem_Click);
            // 
            // modoAmpliadoToolStripMenuItem
            // 
            this.modoAmpliadoToolStripMenuItem.Name = "modoAmpliadoToolStripMenuItem";
            this.modoAmpliadoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modoAmpliadoToolStripMenuItem.Text = "Modo Ampliado";
            this.modoAmpliadoToolStripMenuItem.Click += new System.EventHandler(this.modoAmpliadoToolStripMenuItem_Click);
            // 
            // textoAtv
            // 
            this.textoAtv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoAtv.BackColor = System.Drawing.SystemColors.Window;
            this.textoAtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoAtv.Location = new System.Drawing.Point(12, 58);
            this.textoAtv.Name = "textoAtv";
            this.textoAtv.ReadOnly = true;
            this.textoAtv.Size = new System.Drawing.Size(784, 450);
            this.textoAtv.TabIndex = 1;
            this.textoAtv.Text = resources.GetString("textoAtv.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 564);
            this.Controls.Add(this.textoAtv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoAltoConstrasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoAmpliadoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textoAtv;
    }
}

