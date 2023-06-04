namespace Presentacion
{
    partial class FrmEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProducto));
            this.btnEditar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtDesProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPresProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Producto = new System.Windows.Forms.TextBox();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(782, 426);
            this.btnCancelar.Size = new System.Drawing.Size(172, 38);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(619, 426);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 38);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tipo de Cargo:";
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
            this.comboBox1.Location = new System.Drawing.Point(640, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 33);
            this.comboBox1.TabIndex = 39;
            
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Precio Venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(324, 341);
            this.txtPrecioVenta.Multiline = true;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(265, 29);
            this.txtPrecioVenta.TabIndex = 26;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // txtDesProducto
            // 
            this.txtDesProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtDesProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProducto.Location = new System.Drawing.Point(12, 225);
            this.txtDesProducto.Multiline = true;
            this.txtDesProducto.Name = "txtDesProducto";
            this.txtDesProducto.Size = new System.Drawing.Size(538, 29);
            this.txtDesProducto.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Descripcion Producto:";
            // 
            // txtPresProducto
            // 
            this.txtPresProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtPresProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresProducto.Location = new System.Drawing.Point(640, 225);
            this.txtPresProducto.Multiline = true;
            this.txtPresProducto.Name = "txtPresProducto";
            this.txtPresProducto.Size = new System.Drawing.Size(234, 29);
            this.txtPresProducto.TabIndex = 23;
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Presentacion Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre Producto:";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.BackColor = System.Drawing.Color.LightBlue;
            this.txtCostoUnitario.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(12, 341);
            this.txtCostoUnitario.Multiline = true;
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(250, 29);
            this.txtCostoUnitario.TabIndex = 19;
            this.txtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
             //
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Costo Unitario:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtCodProducto.Enabled = false;
            this.txtCodProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(12, 86);
            this.txtCodProducto.Multiline = true;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(281, 29);
            this.txtCodProducto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo Producto:";
            // 
            // txtId_Producto
            // 
            this.txtId_Producto.BackColor = System.Drawing.Color.LightBlue;
            this.txtId_Producto.Enabled = false;
            this.txtId_Producto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Producto.Location = new System.Drawing.Point(222, 42);
            this.txtId_Producto.Multiline = true;
            this.txtId_Producto.Name = "txtId_Producto";
            this.txtId_Producto.ReadOnly = true;
            this.txtId_Producto.Size = new System.Drawing.Size(66, 29);
            this.txtId_Producto.TabIndex = 31;
            this.txtId_Producto.Visible = false;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.BackColor = System.Drawing.Color.LightBlue;
            this.txtNomProducto.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProducto.Location = new System.Drawing.Point(375, 86);
            this.txtNomProducto.Multiline = true;
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(519, 29);
            this.txtNomProducto.TabIndex = 0;
            // 
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 493);
            this.Controls.Add(this.txtNomProducto);
            this.Controls.Add(this.txtId_Producto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtDesProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPresProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarProducto";
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.FrmEditarProductos_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodProducto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCostoUnitario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPresProducto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDesProducto, 0);
            this.Controls.SetChildIndex(this.txtPrecioVenta, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.txtId_Producto, 0);
            this.Controls.SetChildIndex(this.txtNomProducto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtId_Producto;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        public System.Windows.Forms.TextBox txtDesProducto;
        public System.Windows.Forms.TextBox txtPresProducto;
        public System.Windows.Forms.TextBox txtCostoUnitario;
        public System.Windows.Forms.TextBox txtCodProducto;
        public System.Windows.Forms.TextBox txtNomProducto;
    }
}