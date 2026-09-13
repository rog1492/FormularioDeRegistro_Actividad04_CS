namespace FormularioDeRegistro_Actividad04_CS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.txbEstatura = new System.Windows.Forms.TextBox();
            this.gbGeneros = new System.Windows.Forms.GroupBox();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbGeneros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(28, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 26);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(28, 170);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(103, 26);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(28, 230);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(67, 26);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatura.Location = new System.Drawing.Point(28, 290);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(101, 26);
            this.lblEstatura.TabIndex = 4;
            this.lblEstatura.Text = "Estatura";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(154, 50);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(221, 26);
            this.txbNombre.TabIndex = 5;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(154, 110);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(221, 26);
            this.txbApellido.TabIndex = 6;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(154, 170);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(221, 26);
            this.txbTelefono.TabIndex = 7;
            // 
            // txbEdad
            // 
            this.txbEdad.Location = new System.Drawing.Point(154, 230);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(221, 26);
            this.txbEdad.TabIndex = 8;
            // 
            // txbEstatura
            // 
            this.txbEstatura.Location = new System.Drawing.Point(154, 290);
            this.txbEstatura.Name = "txbEstatura";
            this.txbEstatura.Size = new System.Drawing.Size(221, 26);
            this.txbEstatura.TabIndex = 9;
            // 
            // gbGeneros
            // 
            this.gbGeneros.BackColor = System.Drawing.SystemColors.Info;
            this.gbGeneros.Controls.Add(this.rbOtros);
            this.gbGeneros.Controls.Add(this.rbFemenino);
            this.gbGeneros.Controls.Add(this.rbMasculino);
            this.gbGeneros.Location = new System.Drawing.Point(33, 351);
            this.gbGeneros.Name = "gbGeneros";
            this.gbGeneros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbGeneros.Size = new System.Drawing.Size(342, 73);
            this.gbGeneros.TabIndex = 10;
            this.gbGeneros.TabStop = false;
            this.gbGeneros.Text = "Género";
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(258, 25);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(73, 24);
            this.rbOtros.TabIndex = 2;
            this.rbOtros.TabStop = true;
            this.rbOtros.Text = "Otros";
            this.rbOtros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOtros.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(133, 26);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(105, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(12, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbMasculino.Size = new System.Drawing.Size(105, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(33, 453);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 93);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(245, 453);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 93);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormularioDeRegistro_Actividad04_CS.Properties.Resources._716f63d260ea2d25f6784a82f0def40e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 693);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbGeneros);
            this.Controls.Add(this.txbEstatura);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formulario De Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGeneros.ResumeLayout(false);
            this.gbGeneros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbEdad;
        private System.Windows.Forms.TextBox txbEstatura;
        private System.Windows.Forms.GroupBox gbGeneros;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

