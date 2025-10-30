namespace CarritoDeCompras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCarritoDeCompras = new ListBox();
            btnAgregar = new Button();
            btnCalcular = new Button();
            cboProductos = new ComboBox();
            label1 = new Label();
            txtCodigoDescuento = new TextBox();
            SuspendLayout();
            // 
            // listCarritoDeCompras
            // 
            listCarritoDeCompras.FormattingEnabled = true;
            listCarritoDeCompras.Location = new Point(39, 60);
            listCarritoDeCompras.Name = "listCarritoDeCompras";
            listCarritoDeCompras.Size = new Size(224, 319);
            listCarritoDeCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(283, 114);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(376, 114);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Precio";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(311, 60);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(194, 23);
            cboProductos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 162);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 4;
            label1.Text = "Codigo de descuento: ";
            // 
            // txtCodigoDescuento
            // 
            txtCodigoDescuento.Location = new Point(401, 162);
            txtCodigoDescuento.Name = "txtCodigoDescuento";
            txtCodigoDescuento.Size = new Size(127, 23);
            txtCodigoDescuento.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 416);
            Controls.Add(txtCodigoDescuento);
            Controls.Add(label1);
            Controls.Add(cboProductos);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(listCarritoDeCompras);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCarritoDeCompras;
        private Button btnAgregar;
        private Button btnCalcular;
        private ComboBox cboProductos;
        private Label label1;
        private TextBox txtCodigoDescuento;
    }
}
