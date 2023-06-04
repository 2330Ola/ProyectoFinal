namespace Presentacion
{
    partial class FrmAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPresProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(816, 426);
            this.btnCancelar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Producto:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodProducto.Enabled = false;
            this.txtCodProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(50, 86);
            this.txtCodProducto.Multiline = true;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(281, 29);
            this.txtCodProducto.TabIndex = 2;
            this.txtCodProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.BackColor = System.Drawing.Color.LightBlue;
            this.txtCostoUnitario.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(50, 341);
            this.txtCostoUnitario.Multiline = true;
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(250, 29);
            this.txtCostoUnitario.TabIndex = 4;
            this.txtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnitario_KeyPress);
            this.txtCostoUnitario.Leave += new System.EventHandler(this.txtCostoUnitario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo Unitario:";
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtNomProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProducto.Location = new System.Drawing.Point(393, 86);
            this.txtNomProducto.Multiline = true;
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(519, 29);
            this.txtNomProducto.TabIndex = 0;
            this.txtNomProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Producto:";
            // 
            // txtPresProducto
            // 
            this.txtPresProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtPresProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresProducto.Location = new System.Drawing.Point(678, 225);
            this.txtPresProducto.Multiline = true;
            this.txtPresProducto.Name = "txtPresProducto";
            this.txtPresProducto.Size = new System.Drawing.Size(234, 29);
            this.txtPresProducto.TabIndex = 8;
            this.txtPresProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Presentacion Producto:";
            // 
            // txtDesProducto
            // 
            this.txtDesProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtDesProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProducto.Location = new System.Drawing.Point(50, 225);
            this.txtDesProducto.Multiline = true;
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.Size = new System.Drawing.Size(538, 29);
            this.txtDesProducto.TabIndex = 10;
            this.txtDesProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesProducto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripcion Producto:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(362, 341);
            this.txtPrecioVenta.Multiline = true;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(265, 29);
            this.txtPrecioVenta.TabIndex = 11;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio Venta:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.LightBlue;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IVA12%",
            "Exento"});
            this.comboBox1.Location = new System.Drawing.Point(678, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 33);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(673, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de Cargo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.Azure;
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(657, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 38);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 493);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtDesProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPresProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodProducto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCostoUnitario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNomProducto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPresProducto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDesProducto, 0);
            this.Controls.SetChildIndex(this.txtPrecioVenta, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPresProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtNomProducto;
    }
}