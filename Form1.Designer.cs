namespace CursoCSharpWindowsForm {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coleçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayBidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleçõesArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coleçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coleçõesToolStripMenuItem
            // 
            this.coleçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayToolStripMenuItem,
            this.arrayBidimensionalToolStripMenuItem,
            this.listToolStripMenuItem,
            this.coleçõesArrayToolStripMenuItem,
            this.classesListToolStripMenuItem});
            this.coleçõesToolStripMenuItem.Name = "coleçõesToolStripMenuItem";
            this.coleçõesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.coleçõesToolStripMenuItem.Text = "Coleções";
            // 
            // arrayToolStripMenuItem
            // 
            this.arrayToolStripMenuItem.Name = "arrayToolStripMenuItem";
            this.arrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrayToolStripMenuItem.Text = "Array";
            this.arrayToolStripMenuItem.Click += new System.EventHandler(this.arrayToolStripMenuItem_Click);
            // 
            // arrayBidimensionalToolStripMenuItem
            // 
            this.arrayBidimensionalToolStripMenuItem.Name = "arrayBidimensionalToolStripMenuItem";
            this.arrayBidimensionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrayBidimensionalToolStripMenuItem.Text = "Array Bidimensional";
            this.arrayBidimensionalToolStripMenuItem.Click += new System.EventHandler(this.arrayBidimensionalToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // coleçõesArrayToolStripMenuItem
            // 
            this.coleçõesArrayToolStripMenuItem.Name = "coleçõesArrayToolStripMenuItem";
            this.coleçõesArrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coleçõesArrayToolStripMenuItem.Text = "Coleções Array";
            this.coleçõesArrayToolStripMenuItem.Click += new System.EventHandler(this.coleçõesArrayToolStripMenuItem_Click);
            // 
            // classesListToolStripMenuItem
            // 
            this.classesListToolStripMenuItem.Name = "classesListToolStripMenuItem";
            this.classesListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classesListToolStripMenuItem.Text = "Classes List";
            this.classesListToolStripMenuItem.Click += new System.EventHandler(this.classesListToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso C#";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coleçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayBidimensionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleçõesArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesListToolStripMenuItem;
    }
}

