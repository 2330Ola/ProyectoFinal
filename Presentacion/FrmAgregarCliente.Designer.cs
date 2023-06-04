namespace Presentacion
{
    partial class FrmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCliente));
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirecCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRNCLiente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.msxTelCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1122, 442);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodCliente.Location = new System.Drawing.Point(75, 126);
            this.txtCodCliente.Multiline = true;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(196, 30);
            this.txtCodCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(-283, 186);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Direccion Cliente";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtEmailCliente.Location = new System.Drawing.Point(351, 360);
            this.txtEmailCliente.Multiline = true;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(338, 30);
            this.txtEmailCliente.TabIndex = 4;
            this.txtEmailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "RNC Cliente";
            // 
            // txtDirecCliente
            // 
            this.txtDirecCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtDirecCliente.Location = new System.Drawing.Point(75, 248);
            this.txtDirecCliente.Multiline = true;
            this.txtDirecCliente.Name = "txtDirecCliente";
            this.txtDirecCliente.Size = new System.Drawing.Size(196, 30);
            this.txtDirecCliente.TabIndex = 6;
            this.txtDirecCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirecCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(754, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // txtRNCLiente
            // 
            this.txtRNCLiente.BackColor = System.Drawing.Color.LightBlue;
            this.txtRNCLiente.Location = new System.Drawing.Point(351, 248);
            this.txtRNCLiente.Multiline = true;
            this.txtRNCLiente.Name = "txtRNCLiente";
            this.txtRNCLiente.Size = new System.Drawing.Size(666, 30);
            this.txtRNCLiente.TabIndex = 8;
            this.txtRNCLiente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRNCLiente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo Cliente";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtNomCliente.Location = new System.Drawing.Point(351, 126);
            this.txtNomCliente.Multiline = true;
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(687, 30);
            this.txtNomCliente.TabIndex = 10;
            this.txtNomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCliente_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-172, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // cbEstadoCliente
            // 
            this.cbEstadoCliente.BackColor = System.Drawing.Color.LightBlue;
            this.cbEstadoCliente.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCliente.FormattingEnabled = true;
            this.cbEstadoCliente.Items.AddRange(new object[] {
            "Activo",
            " Inactivo"});
            this.cbEstadoCliente.Location = new System.Drawing.Point(759, 360);
            this.cbEstadoCliente.Name = "cbEstadoCliente";
            this.cbEstadoCliente.Size = new System.Drawing.Size(279, 37);
            this.cbEstadoCliente.TabIndex = 14;
            this.cbEstadoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEstadoCliente_KeyPress);
            // 
            // msxTelCliente
            // 
            this.msxTelCliente.BackColor = System.Drawing.Color.LightBlue;
            this.msxTelCliente.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msxTelCliente.Location = new System.Drawing.Point(86, 362);
            this.msxTelCliente.Name = "msxTelCliente";
            this.msxTelCliente.Size = new System.Drawing.Size(205, 37);
            this.msxTelCliente.TabIndex = 11;
            this.msxTelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msxTelCliente_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Azure;
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(952, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 38);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(608, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono";
            // 
            // FrmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbEstadoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msxTelCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRNCLiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDirecCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodCliente);
            this.Name = "FrmAgregarCliente";
            this.Text = "FrmAgregarCliente";
            this.Load += new System.EventHandler(this.FrmAgregarCliente_Load);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.txtEmailCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDirecCliente, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRNCLiente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNomCliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.msxTelCliente, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbEstadoCliente, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDirecCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRNCLiente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbEstadoCliente;
        public System.Windows.Forms.MaskedTextBox msxTelCliente;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}