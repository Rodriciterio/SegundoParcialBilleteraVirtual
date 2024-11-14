namespace SegundoParcialBilleteraVirtual.Windows
{
    partial class frmPagar
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
            label1 = new Label();
            txtPago = new TextBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            btnCancelar = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 25);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese descripción del Pago:";
            // 
            // txtPago
            // 
            txtPago.Location = new Point(53, 47);
            txtPago.MaxLength = 100;
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(438, 23);
            txtPago.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 76);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese monto del Pago:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(53, 99);
            txtCantidad.MaxLength = 10;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(438, 23);
            txtCantidad.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(416, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 43);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(53, 138);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 43);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 204);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(txtPago);
            Controls.Add(label1);
            MaximumSize = new Size(549, 243);
            MinimumSize = new Size(549, 243);
            Name = "frmPagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPagar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPago;
        private Label label2;
        private TextBox txtCantidad;
        private Button btnCancelar;
        private Button btnOK;
    }
}