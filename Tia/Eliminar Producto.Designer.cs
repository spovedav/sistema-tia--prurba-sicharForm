namespace Tia
{
    partial class Eliminar_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_Producto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agregarimg = new System.Windows.Forms.Button();
            this.lab_cod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CODIGO = new System.Windows.Forms.Label();
            this.lab_nombre = new System.Windows.Forms.TextBox();
            this.pictBx_foto = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_panelcontrol = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.descricion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 76);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIMINAR PRODUCTO";
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
            // agregarimg
            // 
            this.agregarimg.Location = new System.Drawing.Point(573, 324);
            this.agregarimg.Name = "agregarimg";
            this.agregarimg.Size = new System.Drawing.Size(160, 23);
            this.agregarimg.TabIndex = 56;
            this.agregarimg.Text = "Agrega imagen";
            this.agregarimg.UseVisualStyleBackColor = true;
            this.agregarimg.Click += new System.EventHandler(this.agregarimg_Click);
            // 
            // lab_cod
            // 
            this.lab_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_cod.Location = new System.Drawing.Point(305, 125);
            this.lab_cod.Name = "lab_cod";
            this.lab_cod.Size = new System.Drawing.Size(92, 29);
            this.lab_cod.TabIndex = 47;
            this.lab_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lab_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lab_cod_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "CANTIDA:";
            // 
            // lab_cantidad
            // 
            this.lab_cantidad.Enabled = false;
            this.lab_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_cantidad.Location = new System.Drawing.Point(281, 289);
            this.lab_cantidad.Name = "lab_cantidad";
            this.lab_cantidad.Size = new System.Drawing.Size(153, 29);
            this.lab_cantidad.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 52;
            this.label5.Text = "PRECIO:";
            // 
            // lab_precio
            // 
            this.lab_precio.Enabled = false;
            this.lab_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_precio.Location = new System.Drawing.Point(281, 235);
            this.lab_precio.Name = "lab_precio";
            this.lab_precio.Size = new System.Drawing.Size(153, 29);
            this.lab_precio.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 50;
            this.label3.Text = "NOMBRE:";
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSize = true;
            this.CODIGO.BackColor = System.Drawing.Color.Transparent;
            this.CODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODIGO.ForeColor = System.Drawing.Color.White;
            this.CODIGO.Location = new System.Drawing.Point(73, 124);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Size = new System.Drawing.Size(122, 29);
            this.CODIGO.TabIndex = 49;
            this.CODIGO.Text = "CODIGO:";
            // 
            // lab_nombre
            // 
            this.lab_nombre.Enabled = false;
            this.lab_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(281, 177);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(153, 29);
            this.lab_nombre.TabIndex = 48;
            // 
            // pictBx_foto
            // 
            this.pictBx_foto.Location = new System.Drawing.Point(540, 104);
            this.pictBx_foto.Name = "pictBx_foto";
            this.pictBx_foto.Size = new System.Drawing.Size(222, 214);
            this.pictBx_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBx_foto.TabIndex = 55;
            this.pictBx_foto.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 530);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 138);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.BackColor = System.Drawing.Color.Transparent;
            this.lab_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total.ForeColor = System.Drawing.Color.White;
            this.lab_total.Location = new System.Drawing.Point(355, 345);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(36, 37);
            this.lab_total.TabIndex = 64;
            this.lab_total.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 29);
            this.label4.TabIndex = 63;
            this.label4.Text = "TOTAL DE INVERSION";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(663, 477);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(173, 38);
            this.btn_eliminar.TabIndex = 62;
            this.btn_eliminar.Text = "Agregar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_nuevo.Location = new System.Drawing.Point(663, 412);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(173, 38);
            this.btn_nuevo.TabIndex = 61;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_panelcontrol
            // 
            this.btn_panelcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_panelcontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_panelcontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_panelcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panelcontrol.ForeColor = System.Drawing.Color.Black;
            this.btn_panelcontrol.Location = new System.Drawing.Point(663, 368);
            this.btn_panelcontrol.Name = "btn_panelcontrol";
            this.btn_panelcontrol.Size = new System.Drawing.Size(173, 38);
            this.btn_panelcontrol.TabIndex = 60;
            this.btn_panelcontrol.Text = "Panel Control";
            this.btn_panelcontrol.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(25, 477);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(170, 38);
            this.btn_agregar.TabIndex = 59;
            this.btn_agregar.Text = "Eliminar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "DESCRICIÓN";
            // 
            // descricion
            // 
            this.descricion.Enabled = false;
            this.descricion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricion.Location = new System.Drawing.Point(219, 417);
            this.descricion.Multiline = true;
            this.descricion.Name = "descricion";
            this.descricion.Size = new System.Drawing.Size(410, 107);
            this.descricion.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(235, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Created by: Stevyn Marcelo Poveda Velasquez      ®2018 - 2019";
            // 
            // Eliminar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Tia.Properties.Resources.logo_tia_ConvertImage_11;
            this.ClientSize = new System.Drawing.Size(832, 693);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_panelcontrol);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descricion);
            this.Controls.Add(this.agregarimg);
            this.Controls.Add(this.lab_cod);
            this.Controls.Add(this.pictBx_foto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CODIGO);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Producto";
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
        private System.Windows.Forms.Button agregarimg;
        private System.Windows.Forms.PictureBox pictBx_foto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CODIGO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_panelcontrol;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox lab_cod;
        public System.Windows.Forms.TextBox lab_cantidad;
        public System.Windows.Forms.TextBox lab_precio;
        public System.Windows.Forms.TextBox lab_nombre;
        public System.Windows.Forms.Label lab_total;
        public System.Windows.Forms.TextBox descricion;
    }
}