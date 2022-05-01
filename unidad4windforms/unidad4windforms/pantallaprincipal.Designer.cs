
namespace unidad4windforms
{
    partial class pantallaprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suma2 = new System.Windows.Forms.TextBox();
            this.suma1 = new System.Windows.Forms.TextBox();
            this.muestrasuma = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilPersonaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // perfilPersonaToolStripMenuItem
            // 
            this.perfilPersonaToolStripMenuItem.Name = "perfilPersonaToolStripMenuItem";
            this.perfilPersonaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.perfilPersonaToolStripMenuItem.Text = "Perfil Persona";
            this.perfilPersonaToolStripMenuItem.Click += new System.EventHandler(this.perfilPersonaToolStripMenuItem_Click);
            // 
            // suma2
            // 
            this.suma2.Location = new System.Drawing.Point(287, 153);
            this.suma2.Name = "suma2";
            this.suma2.Size = new System.Drawing.Size(158, 20);
            this.suma2.TabIndex = 3;
            this.suma2.TextChanged += new System.EventHandler(this.cajanombre_TextChanged);
            // 
            // suma1
            // 
            this.suma1.Location = new System.Drawing.Point(287, 105);
            this.suma1.Name = "suma1";
            this.suma1.Size = new System.Drawing.Size(158, 20);
            this.suma1.TabIndex = 4;
            // 
            // muestrasuma
            // 
            this.muestrasuma.AutoSize = true;
            this.muestrasuma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.muestrasuma.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestrasuma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.muestrasuma.Location = new System.Drawing.Point(192, 234);
            this.muestrasuma.Name = "muestrasuma";
            this.muestrasuma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.muestrasuma.Size = new System.Drawing.Size(139, 22);
            this.muestrasuma.TabIndex = 5;
            this.muestrasuma.Text = "La suma es:  ";
            this.muestrasuma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(306, 194);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(98, 25);
            this.sumar.TabIndex = 6;
            this.sumar.Text = "sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // pantallaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.muestrasuma);
            this.Controls.Add(this.suma1);
            this.Controls.Add(this.suma2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pantallaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pantallaprincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilPersonaToolStripMenuItem;
        private System.Windows.Forms.TextBox suma2;
        private System.Windows.Forms.TextBox suma1;
        private System.Windows.Forms.Label muestrasuma;
        private System.Windows.Forms.Button sumar;
    }
}