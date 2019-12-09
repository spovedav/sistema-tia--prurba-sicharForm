namespace Tia
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CODIGO = new System.Windows.Forms.Label();
            this.lab_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_descricion = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_panelcontrol = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.pictBx_foto = new System.Windows.Forms.PictureBox();
            this.lab_cod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            this.agregarimg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculartotal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBx_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 73);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUEVO PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tia.Properties.Resources.logo_tia2;
            this.pictureBox1.Location = new System.Drawing.Point(636, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "NOMBRE:";
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSize = true;
            this.CODIGO.BackColor = System.Drawing.Color.Transparent;
            this.CODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODIGO.ForeColor = System.Drawing.Color.White;
            this.CODIGO.Location = new System.Drawing.Point(52, 103);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Size = new System.Drawing.Size(122, 29);
            this.CODIGO.TabIndex = 18;
            this.CODIGO.Text = "CODIGO:";
            // 
            // lab_nombre
            // 
            this.lab_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(260, 156);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(153, 29);
            this.lab_nombre.TabIndex = 17;
            this.lab_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_nombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "PRECIO:";
            // 
            // lab_precio
            // 
            this.lab_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_precio.Location = new System.Drawing.Point(260, 214);
            this.lab_precio.Name = "lab_precio";
            this.lab_precio.Size = new System.Drawing.Size(153, 29);
            this.lab_precio.TabIndex = 24;
            this.lab_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_precio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "CANTIDA:";
            // 
            // lab_cantidad
            // 
            this.lab_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_cantidad.Location = new System.Drawing.Point(260, 268);
            this.lab_cantidad.Name = "lab_cantidad";
            this.lab_cantidad.Size = new System.Drawing.Size(153, 29);
            this.lab_cantidad.TabIndex = 26;
            this.lab_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_cantida_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "DESCRICIÓN";
            // 
            // lab_descricion
            // 
            this.lab_descricion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descricion.Location = new System.Drawing.Point(217, 397);
            this.lab_descricion.Multiline = true;
            this.lab_descricion.Name = "lab_descricion";
            this.lab_descricion.Size = new System.Drawing.Size(410, 107);
            this.lab_descricion.TabIndex = 28;
            this.lab_descricion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_descricion_KeyPress);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_nuevo.Location = new System.Drawing.Point(661, 392);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(173, 38);
            this.btn_nuevo.TabIndex = 34;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_panelcontrol
            // 
            this.btn_panelcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_panelcontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_panelcontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_panelcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panelcontrol.ForeColor = System.Drawing.Color.Black;
            this.btn_panelcontrol.Location = new System.Drawing.Point(661, 348);
            this.btn_panelcontrol.Name = "btn_panelcontrol";
            this.btn_panelcontrol.Size = new System.Drawing.Size(173, 38);
            this.btn_panelcontrol.TabIndex = 33;
            this.btn_panelcontrol.Text = "Panel Control";
            this.btn_panelcontrol.UseVisualStyleBackColor = false;
            this.btn_panelcontrol.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_panelcontrol.MouseLeave += new System.EventHandler(this.btn_panelcontrol_MouseLeave);
            this.btn_panelcontrol.MouseHover += new System.EventHandler(this.btn_panelcontrol_MouseHover);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(24, 466);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(170, 38);
            this.btn_agregar.TabIndex = 32;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(214, 676);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Created by: Stevyn Marcelo Poveda Velasquez      ®2018 - 2019";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(661, 457);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(173, 38);
            this.btn_eliminar.TabIndex = 41;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // pictBx_foto
            // 
            this.pictBx_foto.Location = new System.Drawing.Point(519, 83);
            this.pictBx_foto.Name = "pictBx_foto";
            this.pictBx_foto.Size = new System.Drawing.Size(222, 214);
            this.pictBx_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBx_foto.TabIndex = 36;
            this.pictBx_foto.TabStop = false;
            // 
            // lab_cod
            // 
            this.lab_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_cod.Location = new System.Drawing.Point(284, 104);
            this.lab_cod.Name = "lab_cod";
            this.lab_cod.Size = new System.Drawing.Size(92, 29);
            this.lab_cod.TabIndex = 1;
            this.lab_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lab_cod.TextChanged += new System.EventHandler(this.lab_cod_TextChanged);
            this.lab_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "TOTAL DE INVERSION";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.BackColor = System.Drawing.Color.Transparent;
            this.lab_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total.ForeColor = System.Drawing.Color.White;
            this.lab_total.Location = new System.Drawing.Point(353, 325);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(36, 37);
            this.lab_total.TabIndex = 45;
            this.lab_total.Text = "$";
            // 
            // agregarimg
            // 
            this.agregarimg.Location = new System.Drawing.Point(552, 303);
            this.agregarimg.Name = "agregarimg";
            this.agregarimg.Size = new System.Drawing.Size(160, 23);
            this.agregarimg.TabIndex = 46;
            this.agregarimg.Text = "Agrega imagen";
            this.agregarimg.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 138);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // calculartotal
            // 
            this.calculartotal.Location = new System.Drawing.Point(360, 363);
            this.calculartotal.Name = "calculartotal";
            this.calculartotal.Size = new System.Drawing.Size(138, 23);
            this.calculartotal.TabIndex = 48;
            this.calculartotal.Text = "Calcular Total";
            this.calculartotal.UseVisualStyleBackColor = true;
            this.calculartotal.Click += new System.EventHandler(this.calculartotal_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Tia.Properties.Resources.logo_tia_ConvertImage_11;
            this.ClientSize = new System.Drawing.Size(832, 698);
            this.Controls.Add(this.calculartotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.agregarimg);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_cod);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictBx_foto);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_panelcontrol);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lab_descricion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CODIGO);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBx_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CODIGO;
        private System.Windows.Forms.TextBox lab_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lab_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lab_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lab_descricion;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_panelcontrol;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pictBx_foto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Button agregarimg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calculartotal;
        public System.Windows.Forms.TextBox lab_cod;
    }
}