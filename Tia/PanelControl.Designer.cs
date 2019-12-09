namespace Tia
{
    partial class PanelControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelControl));
            this.lab_tipo_usuario = new System.Windows.Forms.Label();
            this.lab_NombreCuenta = new System.Windows.Forms.Label();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_modi_registro = new System.Windows.Forms.Button();
            this.btn_modi_producto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cambiar_imagen = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_tipo_usuario
            // 
            this.lab_tipo_usuario.AutoSize = true;
            this.lab_tipo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo_usuario.Location = new System.Drawing.Point(21, 21);
            this.lab_tipo_usuario.Name = "lab_tipo_usuario";
            this.lab_tipo_usuario.Size = new System.Drawing.Size(393, 73);
            this.lab_tipo_usuario.TabIndex = 0;
            this.lab_tipo_usuario.Text = "Tipo Cuenta";
            this.lab_tipo_usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_NombreCuenta
            // 
            this.lab_NombreCuenta.AutoSize = true;
            this.lab_NombreCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_NombreCuenta.ForeColor = System.Drawing.Color.Red;
            this.lab_NombreCuenta.Location = new System.Drawing.Point(37, 111);
            this.lab_NombreCuenta.Name = "lab_NombreCuenta";
            this.lab_NombreCuenta.Size = new System.Drawing.Size(223, 39);
            this.lab_NombreCuenta.TabIndex = 1;
            this.lab_NombreCuenta.Text = "nombre user";
            // 
            // btn_consulta
            // 
            this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(317, 197);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(275, 62);
            this.btn_consulta.TabIndex = 3;
            this.btn_consulta.Text = "VENDER PRODUCTO";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_modi_registro
            // 
            this.btn_modi_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modi_registro.Location = new System.Drawing.Point(317, 289);
            this.btn_modi_registro.Name = "btn_modi_registro";
            this.btn_modi_registro.Size = new System.Drawing.Size(275, 62);
            this.btn_modi_registro.TabIndex = 4;
            this.btn_modi_registro.Text = "INSERTAR PRODUCTO";
            this.btn_modi_registro.UseVisualStyleBackColor = true;
            this.btn_modi_registro.Click += new System.EventHandler(this.btn_modi_registro_Click);
            // 
            // btn_modi_producto
            // 
            this.btn_modi_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modi_producto.Location = new System.Drawing.Point(317, 387);
            this.btn_modi_producto.Name = "btn_modi_producto";
            this.btn_modi_producto.Size = new System.Drawing.Size(275, 62);
            this.btn_modi_producto.TabIndex = 5;
            this.btn_modi_producto.Text = "ELIMINAR PRODUCTO";
            this.btn_modi_producto.UseVisualStyleBackColor = true;
            this.btn_modi_producto.Click += new System.EventHandler(this.btn_modi_producto_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(507, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cambiar la Contraceña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(530, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cambiar de usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave_1);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(124, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Created by: Stevyn Marcelo Poveda Velasquez      ®2018 - 2019";
            // 
            // btn_cambiar_imagen
            // 
            this.btn_cambiar_imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cambiar_imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar_imagen.Location = new System.Drawing.Point(67, 408);
            this.btn_cambiar_imagen.Name = "btn_cambiar_imagen";
            this.btn_cambiar_imagen.Size = new System.Drawing.Size(143, 23);
            this.btn_cambiar_imagen.TabIndex = 13;
            this.btn_cambiar_imagen.Text = "cambiar imagen";
            this.btn_cambiar_imagen.UseVisualStyleBackColor = true;
            this.btn_cambiar_imagen.Click += new System.EventHandler(this.btn_cambiar_imagen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tia.Properties.Resources.logo_tia_ConvertImage_3;
            this.pictureBox2.Location = new System.Drawing.Point(450, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(673, 494);
            this.Controls.Add(this.btn_cambiar_imagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_modi_producto);
            this.Controls.Add(this.btn_modi_registro);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_NombreCuenta);
            this.Controls.Add(this.lab_tipo_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PanelControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelControl";
            this.MouseHover += new System.EventHandler(this.PanelControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_tipo_usuario;
        private System.Windows.Forms.Label lab_NombreCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_modi_registro;
        private System.Windows.Forms.Button btn_modi_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cambiar_imagen;
    }
}