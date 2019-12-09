namespace Tia
{
    partial class INICIO
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.lab_fecha = new System.Windows.Forms.Label();
            this.lab_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelingreso = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.che_clave = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_clave = new System.Windows.Forms.TextBox();
            this.tex_usuario = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_fecha
            // 
            this.lab_fecha.AutoSize = true;
            this.lab_fecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_fecha.ForeColor = System.Drawing.Color.White;
            this.lab_fecha.Location = new System.Drawing.Point(9, 283);
            this.lab_fecha.Name = "lab_fecha";
            this.lab_fecha.Size = new System.Drawing.Size(55, 26);
            this.lab_fecha.TabIndex = 11;
            this.lab_fecha.Text = "fecha";
            // 
            // lab_hora
            // 
            this.lab_hora.AutoSize = true;
            this.lab_hora.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_hora.ForeColor = System.Drawing.Color.White;
            this.lab_hora.Location = new System.Drawing.Point(334, 277);
            this.lab_hora.Name = "lab_hora";
            this.lab_hora.Size = new System.Drawing.Size(75, 32);
            this.lab_hora.TabIndex = 12;
            this.lab_hora.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelingreso
            // 
            this.panelingreso.BackColor = System.Drawing.Color.Transparent;
            this.panelingreso.BackgroundImage = global::Tia.Properties.Resources.logo_tia_ConvertImage_opaco;
            this.panelingreso.Controls.Add(this.label3);
            this.panelingreso.Controls.Add(this.panel1);
            this.panelingreso.Controls.Add(this.pictureBox5);
            this.panelingreso.Controls.Add(this.che_clave);
            this.panelingreso.Controls.Add(this.label4);
            this.panelingreso.Controls.Add(this.tex_clave);
            this.panelingreso.Controls.Add(this.tex_usuario);
            this.panelingreso.Controls.Add(this.pictureBox4);
            this.panelingreso.Controls.Add(this.pictureBox3);
            this.panelingreso.Controls.Add(this.label2);
            this.panelingreso.Controls.Add(this.label1);
            this.panelingreso.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelingreso.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelingreso.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.panelingreso.Location = new System.Drawing.Point(14, 12);
            this.panelingreso.Name = "panelingreso";
            this.panelingreso.Size = new System.Drawing.Size(455, 258);
            this.panelingreso.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "INICIO DE SESIÓN   TÍA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(138, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 37);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Tia.Properties.Resources.flecha_next3;
            this.pictureBox5.Location = new System.Drawing.Point(346, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // che_clave
            // 
            this.che_clave.AutoSize = true;
            this.che_clave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.che_clave.Image = global::Tia.Properties.Resources.seguridad_ojo;
            this.che_clave.Location = new System.Drawing.Point(356, 179);
            this.che_clave.Name = "che_clave";
            this.che_clave.Size = new System.Drawing.Size(39, 14);
            this.che_clave.TabIndex = 3;
            this.che_clave.UseVisualStyleBackColor = true;
            this.che_clave.CheckedChanged += new System.EventHandler(this.che_clave_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "¿Olvido su Clave?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // tex_clave
            // 
            this.tex_clave.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_clave.Location = new System.Drawing.Point(179, 162);
            this.tex_clave.Name = "tex_clave";
            this.tex_clave.Size = new System.Drawing.Size(161, 36);
            this.tex_clave.TabIndex = 2;
            this.tex_clave.UseSystemPasswordChar = true;
            this.tex_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_clave_KeyPress);
            // 
            // tex_usuario
            // 
            this.tex_usuario.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_usuario.Location = new System.Drawing.Point(179, 99);
            this.tex_usuario.Name = "tex_usuario";
            this.tex_usuario.Size = new System.Drawing.Size(161, 36);
            this.tex_usuario.TabIndex = 1;
            this.tex_usuario.Enter += new System.EventHandler(this.tex_usuario_Enter);
            this.tex_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_usuario_KeyPress);
            this.tex_usuario.MouseLeave += new System.EventHandler(this.tex_usuario_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Tia.Properties.Resources.pass32;
            this.pictureBox4.Location = new System.Drawing.Point(8, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tia.Properties.Resources.user32;
            this.pictureBox3.Location = new System.Drawing.Point(8, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLAVE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO:";
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(487, 318);
            this.Controls.Add(this.lab_fecha);
            this.Controls.Add(this.panelingreso);
            this.Controls.Add(this.lab_hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "INICIO";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICICO DE SIECION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelingreso.ResumeLayout(false);
            this.panelingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_clave;
        private System.Windows.Forms.TextBox tex_usuario;
        private System.Windows.Forms.CheckBox che_clave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lab_fecha;
        private System.Windows.Forms.Label lab_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;

    }
}

