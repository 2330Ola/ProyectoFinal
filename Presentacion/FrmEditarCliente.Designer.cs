namespace Presentacion
{
    partial class FrmEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCliente));
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtTelCliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirecCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRNCCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(826, 491);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtEmailCliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(348, 375);
            this.txtEmailCliente.Multiline = true;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(339, 39);
            this.txtEmailCliente.TabIndex = 54;
            this.txtEmailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailCliente_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 53;
            this.label6.Text = "Email";
            // 
            // mtxtTelCliente
            // 
            this.mtxtTelCliente.BackColor = System.Drawing.Color.LightBlue;
            this.mtxtTelCliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelCliente.Location = new System.Drawing.Point(12, 375);
            this.mtxtTelCliente.Name = "mtxtTelCliente";
            this.mtxtTelCliente.Size = new System.Drawing.Size(259, 34);
            this.mtxtTelCliente.TabIndex = 52;
            this.mtxtTelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelCliente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Telefono";
            // 
            // txtDirecCliente
            // 
            this.txtDirecCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtDirecCliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecCliente.Location = new System.Drawing.Point(348, 262);
            this.txtDirecCliente.Multiline = true;
            this.txtDirecCliente.Name = "txtDirecCliente";
            this.txtDirecCliente.Size = new System.Drawing.Size(627, 39);
            this.txtDirecCliente.TabIndex = 50;
            this.txtDirecCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirecCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "Direccion";
            // 
            // txtRNCCliente
            // 
            this.txtRNCCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtRNCCliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRNCCliente.Location = new System.Drawing.Point(8, 262);
            this.txtRNCCliente.Multiline = true;
            this.txtRNCCliente.Name = "txtRNCCliente";
            this.txtRNCCliente.Size = new System.Drawing.Size(263, 39);
            this.txtRNCCliente.TabIndex = 48;
            this.txtRNCCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRNCCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "RNC Proveedor";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtNomCliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCliente.Location = new System.Drawing.Point(348, 124);
            this.txtNomCliente.Multiline = true;
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(627, 39);
            this.txtNomCliente.TabIndex = 46;
            this.txtNomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(8, 124);
            this.txtCodCliente.Multiline = true;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(254, 39);
            this.txtCodCliente.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo Proveedor";
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.BackColor = System.Drawing.Color.LightBlue;
            this.txtId_Cliente.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Cliente.Location = new System.Drawing.Point(215, 43);
            this.txtId_Cliente.Multiline = true;
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(105, 40);
            this.txtId_Cliente.TabIndex = 42;
            this.txtId_Cliente.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(664, 491);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 38);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbEstadoCliente
            // 
            this.cbEstadoCliente.BackColor = System.Drawing.Color.LightBlue;
            this.cbEstadoCliente.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCliente.FormattingEnabled = true;
            this.cbEstadoCliente.Items.AddRange(new object[] {
            "Activo",
            " Inactivo"});
            this.cbEstadoCliente.Location = new System.Drawing.Point(33, 504);
            this.cbEstadoCliente.Name = "cbEstadoCliente";
            this.cbEstadoCliente.Size = new System.Drawing.Size(305, 37);
            this.cbEstadoCliente.TabIndex = 57;
            this.cbEstadoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEstadoCliente_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 27);
            this.label7.TabIndex = 56;
            this.label7.Text = "Estado";
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.cbEstadoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtTelCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirecCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRNCCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId_Cliente);
            this.Name = "FrmEditarCliente";
            this.Text = "FrmEditarCliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtId_Cliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNomCliente, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRNCCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDirecCliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.mtxtTelCliente, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtEmailCliente, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cbEstadoCliente, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox mtxtTelCliente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDirecCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRNCCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtId_Cliente;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cbEstadoCliente;
        private System.Windows.Forms.Label label7;
    }
}