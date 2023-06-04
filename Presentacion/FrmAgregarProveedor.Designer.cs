namespace Presentacion
{
    partial class FrmAgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRNCProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirecProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtTelProveedor = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(969, 447);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Proveedor:";
            // 
            // txtNomProveedor
            // 
            this.txtNomProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtNomProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProveedor.Location = new System.Drawing.Point(367, 113);
            this.txtNomProveedor.Multiline = true;
            this.txtNomProveedor.Name = "txtNomProveedor";
            this.txtNomProveedor.Size = new System.Drawing.Size(627, 39);
            this.txtNomProveedor.TabIndex = 4;
            this.txtNomProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // txtRNCProveedor
            // 
            this.txtRNCProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtRNCProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRNCProveedor.Location = new System.Drawing.Point(27, 251);
            this.txtRNCProveedor.Multiline = true;
            this.txtRNCProveedor.Name = "txtRNCProveedor";
            this.txtRNCProveedor.Size = new System.Drawing.Size(263, 39);
            this.txtRNCProveedor.TabIndex = 6;
            this.txtRNCProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRNCProveedor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "RNC Proveedor";
            // 
            // txtDirecProveedor
            // 
            this.txtDirecProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtDirecProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecProveedor.Location = new System.Drawing.Point(367, 251);
            this.txtDirecProveedor.Multiline = true;
            this.txtDirecProveedor.Name = "txtDirecProveedor";
            this.txtDirecProveedor.Size = new System.Drawing.Size(627, 39);
            this.txtDirecProveedor.TabIndex = 8;
            this.txtDirecProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirecProveedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // mtxtTelProveedor
            // 
            this.mtxtTelProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelProveedor.Location = new System.Drawing.Point(52, 364);
            this.mtxtTelProveedor.Mask = "00000000";
            this.mtxtTelProveedor.Name = "mtxtTelProveedor";
            this.mtxtTelProveedor.Size = new System.Drawing.Size(211, 34);
            this.mtxtTelProveedor.TabIndex = 10;
            this.mtxtTelProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelProveedor_KeyPress);
            // 
            // txtEmailProveedor
            // 
            this.txtEmailProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtEmailProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailProveedor.Location = new System.Drawing.Point(358, 407);
            this.txtEmailProveedor.Multiline = true;
            this.txtEmailProveedor.Name = "txtEmailProveedor";
            this.txtEmailProveedor.Size = new System.Drawing.Size(339, 39);
            this.txtEmailProveedor.TabIndex = 12;
            this.txtEmailProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailProveedor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Azure;
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(797, 447);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 38);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProveedor.Location = new System.Drawing.Point(38, 113);
            this.txtCodProveedor.Multiline = true;
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(252, 39);
            this.txtCodProveedor.TabIndex = 17;
           
            // 
            // FrmAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 514);
            this.Controls.Add(this.txtCodProveedor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmailProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtTelProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirecProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRNCProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarProveedor";
            this.Text = "Agregar Proveedor";
            this.Load += new System.EventHandler(this.FrmAgregarProveedor_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNomProveedor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRNCProveedor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDirecProveedor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.mtxtTelProveedor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtEmailProveedor, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.txtCodProveedor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRNCProveedor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDirecProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox mtxtTelProveedor;
        public System.Windows.Forms.TextBox txtEmailProveedor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtCodProveedor;
    }
}