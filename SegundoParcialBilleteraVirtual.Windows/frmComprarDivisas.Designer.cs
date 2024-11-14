namespace SegundoParcialBilleteraVirtual.Windows
{
    partial class frmComprarDivisas
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
            txtCantidad = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtYuan = new RadioButton();
            rbtEuro = new RadioButton();
            rbtDolar = new RadioButton();
            label2 = new Label();
            txtTotal = new TextBox();
            btnCancelar = new Button();
            btnOK = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(44, 203);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 23);
            txtCantidad.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 178);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 4;
            label1.Text = "Cantidad a Comprar:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtYuan);
            groupBox1.Controls.Add(rbtEuro);
            groupBox1.Controls.Add(rbtDolar);
            groupBox1.Location = new Point(44, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 129);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = " Seleccione Moneda ";
            // 
            // rbtYuan
            // 
            rbtYuan.AutoSize = true;
            rbtYuan.Location = new Point(16, 80);
            rbtYuan.Name = "rbtYuan";
            rbtYuan.Size = new Size(52, 19);
            rbtYuan.TabIndex = 0;
            rbtYuan.Text = "Yuan";
            rbtYuan.UseVisualStyleBackColor = true;
            // 
            // rbtEuro
            // 
            rbtEuro.AutoSize = true;
            rbtEuro.Location = new Point(16, 55);
            rbtEuro.Name = "rbtEuro";
            rbtEuro.Size = new Size(49, 19);
            rbtEuro.TabIndex = 0;
            rbtEuro.Text = "Euro";
            rbtEuro.UseVisualStyleBackColor = true;
            // 
            // rbtDolar
            // 
            rbtDolar.AutoSize = true;
            rbtDolar.Checked = true;
            rbtDolar.Location = new Point(16, 30);
            rbtDolar.Name = "rbtDolar";
            rbtDolar.Size = new Size(53, 19);
            rbtDolar.TabIndex = 0;
            rbtDolar.TabStop = true;
            rbtDolar.Text = "Dólar";
            rbtDolar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 243);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Total a Pagar:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(44, 268);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(200, 23);
            txtTotal.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 43);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(44, 324);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 43);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmComprarDivisas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 393);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmComprarDivisas";
            Text = "frmComprarDivisas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtYuan;
        private RadioButton rbtEuro;
        private RadioButton rbtDolar;
        private Label label2;
        private TextBox txtTotal;
        private Button btnCancelar;
        private Button btnOK;
    }
}