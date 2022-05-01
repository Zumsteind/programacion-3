
namespace unidad4windforms
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.etiquetanombre = new System.Windows.Forms.Label();
            this.cajanombre = new System.Windows.Forms.TextBox();
            this.listadenombres = new System.Windows.Forms.ListView();
            this.mostrarnombres = new System.Windows.Forms.Button();
            this.checkmujer = new System.Windows.Forms.CheckBox();
            this.checkhombre = new System.Windows.Forms.CheckBox();
            this.opcionalto = new System.Windows.Forms.RadioButton();
            this.opcionmediano = new System.Windows.Forms.RadioButton();
            this.opcionbajo = new System.Windows.Forms.RadioButton();
            this.marcoopciones = new System.Windows.Forms.GroupBox();
            this.fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.etiquetafechanacimiento = new System.Windows.Forms.Label();
            this.colorfavorito = new System.Windows.Forms.ComboBox();
            this.cargarperfil = new System.Windows.Forms.Button();
            this.etiquetacolorfavorito = new System.Windows.Forms.Label();
            this.marcoopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.titulo.Location = new System.Drawing.Point(30, 23);
            this.titulo.Name = "titulo";
            this.titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titulo.Size = new System.Drawing.Size(293, 42);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "PERFIL PERSONA";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // etiquetanombre
            // 
            this.etiquetanombre.AutoSize = true;
            this.etiquetanombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.etiquetanombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetanombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.etiquetanombre.Location = new System.Drawing.Point(33, 86);
            this.etiquetanombre.Name = "etiquetanombre";
            this.etiquetanombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etiquetanombre.Size = new System.Drawing.Size(101, 22);
            this.etiquetanombre.TabIndex = 1;
            this.etiquetanombre.Text = "Nombre: ";
            this.etiquetanombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.etiquetanombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // cajanombre
            // 
            this.cajanombre.Location = new System.Drawing.Point(151, 88);
            this.cajanombre.Name = "cajanombre";
            this.cajanombre.Size = new System.Drawing.Size(158, 20);
            this.cajanombre.TabIndex = 2;
            // 
            // listadenombres
            // 
            this.listadenombres.HideSelection = false;
            this.listadenombres.Location = new System.Drawing.Point(524, 23);
            this.listadenombres.Name = "listadenombres";
            this.listadenombres.Size = new System.Drawing.Size(264, 216);
            this.listadenombres.TabIndex = 3;
            this.listadenombres.UseCompatibleStateImageBehavior = false;
            this.listadenombres.View = System.Windows.Forms.View.List;
            // 
            // mostrarnombres
            // 
            this.mostrarnombres.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarnombres.Location = new System.Drawing.Point(348, 82);
            this.mostrarnombres.Name = "mostrarnombres";
            this.mostrarnombres.Size = new System.Drawing.Size(98, 25);
            this.mostrarnombres.TabIndex = 4;
            this.mostrarnombres.Text = "Agregar nombres";
            this.mostrarnombres.UseVisualStyleBackColor = true;
            this.mostrarnombres.Click += new System.EventHandler(this.mostrarnombres_Click);
            // 
            // checkmujer
            // 
            this.checkmujer.AutoSize = true;
            this.checkmujer.Location = new System.Drawing.Point(37, 142);
            this.checkmujer.Name = "checkmujer";
            this.checkmujer.Size = new System.Drawing.Size(63, 17);
            this.checkmujer.TabIndex = 5;
            this.checkmujer.Text = "MUJER";
            this.checkmujer.UseVisualStyleBackColor = true;
            // 
            // checkhombre
            // 
            this.checkhombre.AutoSize = true;
            this.checkhombre.Cursor = System.Windows.Forms.Cursors.No;
            this.checkhombre.Location = new System.Drawing.Point(166, 142);
            this.checkhombre.Name = "checkhombre";
            this.checkhombre.Size = new System.Drawing.Size(73, 17);
            this.checkhombre.TabIndex = 6;
            this.checkhombre.Text = "HOMBRE";
            this.checkhombre.UseVisualStyleBackColor = true;
            // 
            // opcionalto
            // 
            this.opcionalto.AutoSize = true;
            this.opcionalto.Location = new System.Drawing.Point(0, 24);
            this.opcionalto.Name = "opcionalto";
            this.opcionalto.Size = new System.Drawing.Size(108, 23);
            this.opcionalto.TabIndex = 7;
            this.opcionalto.TabStop = true;
            this.opcionalto.Text = "tamaño alto";
            this.opcionalto.UseVisualStyleBackColor = true;
            // 
            // opcionmediano
            // 
            this.opcionmediano.AutoSize = true;
            this.opcionmediano.Location = new System.Drawing.Point(114, 24);
            this.opcionmediano.Name = "opcionmediano";
            this.opcionmediano.Size = new System.Drawing.Size(86, 23);
            this.opcionmediano.TabIndex = 8;
            this.opcionmediano.TabStop = true;
            this.opcionmediano.Text = "Mediano";
            this.opcionmediano.UseVisualStyleBackColor = true;
            // 
            // opcionbajo
            // 
            this.opcionbajo.AutoSize = true;
            this.opcionbajo.Location = new System.Drawing.Point(206, 24);
            this.opcionbajo.Name = "opcionbajo";
            this.opcionbajo.Size = new System.Drawing.Size(57, 23);
            this.opcionbajo.TabIndex = 9;
            this.opcionbajo.TabStop = true;
            this.opcionbajo.Text = "Bajo";
            this.opcionbajo.UseVisualStyleBackColor = true;
            // 
            // marcoopciones
            // 
            this.marcoopciones.Controls.Add(this.opcionalto);
            this.marcoopciones.Controls.Add(this.opcionbajo);
            this.marcoopciones.Controls.Add(this.opcionmediano);
            this.marcoopciones.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcoopciones.Location = new System.Drawing.Point(37, 186);
            this.marcoopciones.Name = "marcoopciones";
            this.marcoopciones.Size = new System.Drawing.Size(324, 53);
            this.marcoopciones.TabIndex = 10;
            this.marcoopciones.TabStop = false;
            this.marcoopciones.Text = "Como consideras tu altura:";
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Location = new System.Drawing.Point(155, 270);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(230, 20);
            this.fechanacimiento.TabIndex = 11;
            // 
            // etiquetafechanacimiento
            // 
            this.etiquetafechanacimiento.AutoSize = true;
            this.etiquetafechanacimiento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.etiquetafechanacimiento.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetafechanacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.etiquetafechanacimiento.Location = new System.Drawing.Point(33, 272);
            this.etiquetafechanacimiento.Name = "etiquetafechanacimiento";
            this.etiquetafechanacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etiquetafechanacimiento.Size = new System.Drawing.Size(116, 20);
            this.etiquetafechanacimiento.TabIndex = 12;
            this.etiquetafechanacimiento.Text = "Fecha nacimiento : ";
            this.etiquetafechanacimiento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorfavorito
            // 
            this.colorfavorito.FormattingEnabled = true;
            this.colorfavorito.Location = new System.Drawing.Point(177, 322);
            this.colorfavorito.Name = "colorfavorito";
            this.colorfavorito.Size = new System.Drawing.Size(123, 21);
            this.colorfavorito.TabIndex = 13;
            this.colorfavorito.SelectedIndexChanged += new System.EventHandler(this.colorfavorito_SelectedIndexChanged);
            // 
            // cargarperfil
            // 
            this.cargarperfil.Location = new System.Drawing.Point(445, 296);
            this.cargarperfil.Name = "cargarperfil";
            this.cargarperfil.Size = new System.Drawing.Size(115, 46);
            this.cargarperfil.TabIndex = 14;
            this.cargarperfil.Text = "Cargar perfil";
            this.cargarperfil.UseVisualStyleBackColor = true;
            this.cargarperfil.Click += new System.EventHandler(this.cargarperfil_Click);
            // 
            // etiquetacolorfavorito
            // 
            this.etiquetacolorfavorito.AutoSize = true;
            this.etiquetacolorfavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetacolorfavorito.Location = new System.Drawing.Point(52, 322);
            this.etiquetacolorfavorito.Name = "etiquetacolorfavorito";
            this.etiquetacolorfavorito.Size = new System.Drawing.Size(93, 16);
            this.etiquetacolorfavorito.TabIndex = 15;
            this.etiquetacolorfavorito.Text = "Color favorito: ";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetacolorfavorito);
            this.Controls.Add(this.cargarperfil);
            this.Controls.Add(this.colorfavorito);
            this.Controls.Add(this.etiquetafechanacimiento);
            this.Controls.Add(this.fechanacimiento);
            this.Controls.Add(this.marcoopciones);
            this.Controls.Add(this.checkhombre);
            this.Controls.Add(this.checkmujer);
            this.Controls.Add(this.mostrarnombres);
            this.Controls.Add(this.listadenombres);
            this.Controls.Add(this.cajanombre);
            this.Controls.Add(this.etiquetanombre);
            this.Controls.Add(this.titulo);
            this.Name = "inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.marcoopciones.ResumeLayout(false);
            this.marcoopciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label etiquetanombre;
        private System.Windows.Forms.TextBox cajanombre;
        private System.Windows.Forms.ListView listadenombres;
        private System.Windows.Forms.Button mostrarnombres;
        private System.Windows.Forms.CheckBox checkmujer;
        private System.Windows.Forms.CheckBox checkhombre;
        private System.Windows.Forms.RadioButton opcionalto;
        private System.Windows.Forms.RadioButton opcionmediano;
        private System.Windows.Forms.RadioButton opcionbajo;
        private System.Windows.Forms.GroupBox marcoopciones;
        private System.Windows.Forms.DateTimePicker fechanacimiento;
        private System.Windows.Forms.Label etiquetafechanacimiento;
        private System.Windows.Forms.ComboBox colorfavorito;
        private System.Windows.Forms.Button cargarperfil;
        private System.Windows.Forms.Label etiquetacolorfavorito;
    }
}

