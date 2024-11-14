namespace SegundoParcialBilleteraVirtual.Windows
{
    partial class frmRetiro
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
            btnCancelar = new Button();
            btnOK = new Button();
            txtCantidad = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtYuan = new RadioButton();
            rbtEuro = new RadioButton();
            rbtDolar = new RadioButton();
            rbtPesoArgentino = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 43);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(44, 235);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 43);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(44, 195);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 23);
            txtCantidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 170);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Cantidad a Retirar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtYuan);
            groupBox1.Controls.Add(rbtEuro);
            groupBox1.Controls.Add(rbtDolar);
            groupBox1.Controls.Add(rbtPesoArgentino);
            groupBox1.Location = new Point(44, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 141);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = " Seleccione Moneda ";
            // 
            // rbtYuan
            // 
            rbtYuan.AutoSize = true;
            rbtYuan.Location = new Point(16, 97);
            rbtYuan.Name = "rbtYuan";
            rbtYuan.Size = new Size(52, 19);
            rbtYuan.TabIndex = 0;
            rbtYuan.Text = "Yuan";
            rbtYuan.UseVisualStyleBackColor = true;
            // 
            // rbtEuro
            // 
            rbtEuro.AutoSize = true;
            rbtEuro.Location = new Point(16, 72);
            rbtEuro.Name = "rbtEuro";
            rbtEuro.Size = new Size(49, 19);
            rbtEuro.TabIndex = 0;
            rbtEuro.Text = "Euro";
            rbtEuro.UseVisualStyleBackColor = true;
            // 
            // rbtDolar
            // 
            rbtDolar.AutoSize = true;
            rbtDolar.Location = new Point(16, 47);
            rbtDolar.Name = "rbtDolar";
            rbtDolar.Size = new Size(53, 19);
            rbtDolar.TabIndex = 0;
            rbtDolar.Text = "Dólar";
            rbtDolar.UseVisualStyleBackColor = true;
            // 
            // rbtPesoArgentino
            // 
            rbtPesoArgentino.AutoSize = true;
            rbtPesoArgentino.Checked = true;
            rbtPesoArgentino.Location = new Point(16, 22);
            rbtPesoArgentino.Name = "rbtPesoArgentino";
            rbtPesoArgentino.Size = new Size(116, 19);
            rbtPesoArgentino.TabIndex = 0;
            rbtPesoArgentino.TabStop = true;
            rbtPesoArgentino.Text = "Pesos Argentinos";
            rbtPesoArgentino.UseVisualStyleBackColor = true;
            // 
            // frmRetiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 299);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximumSize = new Size(297, 338);
            MinimumSize = new Size(297, 338);
            Name = "frmRetiro";
            Text = "frmRetiro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtCantidad;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtYuan;
        private RadioButton rbtEuro;
        private RadioButton rbtDolar;
        private RadioButton rbtPesoArgentino;
    }
}