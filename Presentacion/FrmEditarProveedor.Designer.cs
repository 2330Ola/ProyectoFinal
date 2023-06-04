namespace Presentacion
{
    partial class FrmEditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProveedor));
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtId_Proveedor = new System.Windows.Forms.TextBox();
            this.txtEmailProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtTelProveedor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirecProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRNCProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1031, 429);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(877, 429);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 38);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // txtId_Proveedor
            // 
            this.txtId_Proveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtId_Proveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Proveedor.Location = new System.Drawing.Point(285, 26);
            this.txtId_Proveedor.Multiline = true;
            this.txtId_Proveedor.Name = "txtId_Proveedor";
            this.txtId_Proveedor.Size = new System.Drawing.Size(105, 40);
            this.txtId_Proveedor.TabIndex = 28;
            this.txtId_Proveedor.Visible = false;
            // 
            // txtEmailProveedor
            // 
            this.txtEmailProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtEmailProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailProveedor.Location = new System.Drawing.Point(418, 358);
            this.txtEmailProveedor.Multiline = true;
            this.txtEmailProveedor.Name = "txtEmailProveedor";
            this.txtEmailProveedor.Size = new System.Drawing.Size(339, 39);
            this.txtEmailProveedor.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Email";
            // 
            // mtxtTelProveedor
            // 
            this.mtxtTelProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelProveedor.Location = new System.Drawing.Point(103, 358);
            this.mtxtTelProveedor.Mask = "00000000";
            this.mtxtTelProveedor.Name = "mtxtTelProveedor";
            this.mtxtTelProveedor.Size = new System.Drawing.Size(211, 34);
            this.mtxtTelProveedor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Telefono";
            // 
            // txtDirecProveedor
            // 
            this.txtDirecProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtDirecProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecProveedor.Location = new System.Drawing.Point(418, 245);
            this.txtDirecProveedor.Multiline = true;
            this.txtDirecProveedor.Name = "txtDirecProveedor";
            this.txtDirecProveedor.Size = new System.Drawing.Size(627, 39);
            this.txtDirecProveedor.TabIndex = 37;
            this.txtDirecProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirecProveedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "Direccion";
            // 
            // txtRNCProveedor
            // 
            this.txtRNCProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtRNCProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRNCProveedor.Location = new System.Drawing.Point(78, 245);
            this.txtRNCProveedor.Multiline = true;
            this.txtRNCProveedor.Name = "txtRNCProveedor";
            this.txtRNCProveedor.Size = new System.Drawing.Size(263, 39);
            this.txtRNCProveedor.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "RNC Proveedor";
            // 
            // txtNomProveedor
            // 
            this.txtNomProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtNomProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProveedor.Location = new System.Drawing.Point(418, 107);
            this.txtNomProveedor.Multiline = true;
            this.txtNomProveedor.Name = "txtNomProveedor";
            this.txtNomProveedor.Size = new System.Drawing.Size(627, 39);
            this.txtNomProveedor.TabIndex = 33;
            this.txtNomProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodProveedor.Enabled = false;
            this.txtCodProveedor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProveedor.Location = new System.Drawing.Point(78, 107);
            this.txtCodProveedor.Multiline = true;
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.ReadOnly = true;
            this.txtCodProveedor.Size = new System.Drawing.Size(254, 39);
            this.txtCodProveedor.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo Proveedor:";
            // 
            // FrmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 490);
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
            this.Controls.Add(this.txtCodProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtId_Proveedor);
            this.Name = "FrmEditarProveedor";
            this.Text = "Editar Proveedor";
            this.Load += new System.EventHandler(this.FrmEditarProveedor_Load_1);
            this.Controls.SetChildIndex(this.txtId_Proveedor, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodProveedor, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox txtId_Proveedor;
        public System.Windows.Forms.TextBox txtEmailProveedor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox mtxtTelProveedor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDirecProveedor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRNCProveedor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNomProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.Label label1;
    }
}