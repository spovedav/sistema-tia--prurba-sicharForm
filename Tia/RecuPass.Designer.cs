namespace Tia
{
    partial class RecuPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuPass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_clave = new System.Windows.Forms.TextBox();
            this.tex_nuevaclave = new System.Windows.Forms.TextBox();
            this.tex_repiclave = new System.Windows.Forms.TextBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.che_clave = new System.Windows.Forms.CheckBox();
            this.che_repclave = new System.Windows.Forms.CheckBox();
            this.che_nuevaclave = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antigua Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repita Clave:";
            // 
            // tex_clave
            // 
            this.tex_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_clave.Location = new System.Drawing.Point(160, 85);
            this.tex_clave.Name = "tex_clave";
            this.tex_clave.Size = new System.Drawing.Size(127, 26);
            this.tex_clave.TabIndex = 3;
            this.tex_clave.UseSystemPasswordChar = true;
            // 
            // tex_nuevaclave
            // 
            this.tex_nuevaclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nuevaclave.Location = new System.Drawing.Point(160, 128);
            this.tex_nuevaclave.Name = "tex_nuevaclave";
            this.tex_nuevaclave.Size = new System.Drawing.Size(127, 26);
            this.tex_nuevaclave.TabIndex = 4;
            this.tex_nuevaclave.UseSystemPasswordChar = true;
            // 
            // tex_repiclave
            // 
            this.tex_repiclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_repiclave.Location = new System.Drawing.Point(160, 168);
            this.tex_repiclave.Name = "tex_repiclave";
            this.tex_repiclave.Size = new System.Drawing.Size(127, 26);
            this.tex_repiclave.TabIndex = 5;
            this.tex_repiclave.UseSystemPasswordChar = true;
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuario.ForeColor = System.Drawing.Color.White;
            this.labUsuario.Location = new System.Drawing.Point(39, 11);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(0, 37);
            this.labUsuario.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "CAMBIAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labUsuario);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 57);
            this.panel1.TabIndex = 11;
            // 
            // che_clave
            // 
            this.che_clave.AutoSize = true;
            this.che_clave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.che_clave.Image = global::Tia.Properties.Resources.seguridad_ojo;
            this.che_clave.Location = new System.Drawing.Point(293, 84);
            this.che_clave.Name = "che_clave";
            this.che_clave.Size = new System.Drawing.Size(39, 19);
            this.che_clave.TabIndex = 8;
            this.che_clave.UseVisualStyleBackColor = true;
            this.che_clave.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // che_repclave
            // 
            this.che_repclave.AutoSize = true;
            this.che_repclave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.che_repclave.Image = global::Tia.Properties.Resources.seguridad_ojo;
            this.che_repclave.Location = new System.Drawing.Point(293, 169);
            this.che_repclave.Name = "che_repclave";
            this.che_repclave.Size = new System.Drawing.Size(39, 19);
            this.che_repclave.TabIndex = 7;
            this.che_repclave.UseVisualStyleBackColor = true;
            // 
            // che_nuevaclave
            // 
            this.che_nuevaclave.AutoSize = true;
            this.che_nuevaclave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.che_nuevaclave.Image = global::Tia.Properties.Resources.seguridad_ojo;
            this.che_nuevaclave.Location = new System.Drawing.Point(293, 131);
            this.che_nuevaclave.Name = "che_nuevaclave";
            this.che_nuevaclave.Size = new System.Drawing.Size(39, 19);
            this.che_nuevaclave.TabIndex = 6;
            this.che_nuevaclave.UseVisualStyleBackColor = true;
            // 
            // RecuPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.che_clave);
            this.Controls.Add(this.che_repclave);
            this.Controls.Add(this.che_nuevaclave);
            this.Controls.Add(this.tex_repiclave);
            this.Controls.Add(this.tex_nuevaclave);
            this.Controls.Add(this.tex_clave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecuPass";
            this.Text = "Cambiar Clave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tex_clave;
        private System.Windows.Forms.TextBox tex_nuevaclave;
        private System.Windows.Forms.TextBox tex_repiclave;
        private System.Windows.Forms.CheckBox che_nuevaclave;
        private System.Windows.Forms.CheckBox che_repclave;
        private System.Windows.Forms.CheckBox che_clave;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}