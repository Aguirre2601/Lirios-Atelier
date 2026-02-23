namespace SPOO_Clase09
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnEditar = new System.Windows.Forms.Button();
            this.bttnAñadir = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Fondo_Azul_Acuarela;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.bttnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.bttnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.bttnEditar);
            this.splitContainer1.Panel1.Controls.Add(this.bttnAñadir);
            this.splitContainer1.Panel1.Controls.Add(this.bttnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.bttnInicio);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImage = global::SPOO_Clase09.Properties.Resources.BIENVENIDOS_liriosAtlier;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(1274, 601);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 1;
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.Transparent;
            this.bttnSalir.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Salir;
            this.bttnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bttnSalir.FlatAppearance.BorderSize = 0;
            this.bttnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bttnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalir.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSalir.Location = new System.Drawing.Point(76, 559);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(110, 42);
            this.bttnSalir.TabIndex = 49;
            this.bttnSalir.Text = "Salir";
            this.bttnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.bttnEliminar.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Tacho_de_Basura_ELIMINAR;
            this.bttnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bttnEliminar.FlatAppearance.BorderSize = 0;
            this.bttnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.bttnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEliminar.Location = new System.Drawing.Point(12, 373);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(152, 42);
            this.bttnEliminar.TabIndex = 48;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnEditar
            // 
            this.bttnEditar.BackColor = System.Drawing.Color.Transparent;
            this.bttnEditar.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Editar;
            this.bttnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bttnEditar.FlatAppearance.BorderSize = 0;
            this.bttnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.bttnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.bttnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEditar.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEditar.Location = new System.Drawing.Point(12, 317);
            this.bttnEditar.Name = "bttnEditar";
            this.bttnEditar.Size = new System.Drawing.Size(152, 42);
            this.bttnEditar.TabIndex = 47;
            this.bttnEditar.Text = "Editar";
            this.bttnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEditar.UseVisualStyleBackColor = false;
            this.bttnEditar.Click += new System.EventHandler(this.bttnEditar_Click);
            // 
            // bttnAñadir
            // 
            this.bttnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.bttnAñadir.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Añadir_USUARIO;
            this.bttnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bttnAñadir.FlatAppearance.BorderSize = 0;
            this.bttnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.bttnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.bttnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAñadir.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAñadir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAñadir.Location = new System.Drawing.Point(12, 261);
            this.bttnAñadir.Name = "bttnAñadir";
            this.bttnAñadir.Size = new System.Drawing.Size(152, 42);
            this.bttnAñadir.TabIndex = 46;
            this.bttnAñadir.Text = "Añadir";
            this.bttnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAñadir.UseVisualStyleBackColor = false;
            this.bttnAñadir.Click += new System.EventHandler(this.bttnAñadir_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.bttnBuscar.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Lupa_buscador;
            this.bttnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bttnBuscar.FlatAppearance.BorderSize = 0;
            this.bttnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.bttnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.bttnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscar.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscar.Location = new System.Drawing.Point(12, 205);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(152, 42);
            this.bttnBuscar.TabIndex = 45;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnInicio
            // 
            this.bttnInicio.BackColor = System.Drawing.Color.Transparent;
            this.bttnInicio.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Casa32PX;
            this.bttnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bttnInicio.FlatAppearance.BorderSize = 0;
            this.bttnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(182)))), ((int)(((byte)(218)))));
            this.bttnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.bttnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnInicio.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnInicio.Location = new System.Drawing.Point(12, 149);
            this.bttnInicio.Name = "bttnInicio";
            this.bttnInicio.Size = new System.Drawing.Size(152, 42);
            this.bttnInicio.TabIndex = 44;
            this.bttnInicio.Text = "Inicio";
            this.bttnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnInicio.UseVisualStyleBackColor = false;
            this.bttnInicio.Click += new System.EventHandler(this.bttnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SPOO_Clase09.Properties.Resources.LirioAtelier_LOGOTIPO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPOO_Clase09.Properties.Resources.Fondo_Azul_Acuarela;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 601);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base De Datos Lirios Atelier";
            //this.Load += new System.EventHandler(this.FormInicio_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnEditar;
        private System.Windows.Forms.Button bttnAñadir;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnInicio;
    }
}

