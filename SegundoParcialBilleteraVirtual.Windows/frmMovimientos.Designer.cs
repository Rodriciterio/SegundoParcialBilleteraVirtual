namespace SegundoParcialBilleteraVirtual.Windows
{
    partial class frmMovimientos
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
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            btnCerrar = new Button();
            colFecha = new DataGridViewTextBoxColumn();
            colMoneda = new DataGridViewTextBoxColumn();
            colTipoMov = new DataGridViewTextBoxColumn();
            colRetiro = new DataGridViewTextBoxColumn();
            colDeposito = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnCerrar);
            splitContainer1.Size = new Size(595, 561);
            splitContainer1.SplitterDistance = 481;
            splitContainer1.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colFecha, colMoneda, colTipoMov, colRetiro, colDeposito });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(595, 481);
            dgvDatos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(492, 13);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 50);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha Mov.";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colMoneda
            // 
            colMoneda.HeaderText = "Moneda";
            colMoneda.Name = "colMoneda";
            colMoneda.ReadOnly = true;
            // 
            // colTipoMov
            // 
            colTipoMov.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoMov.HeaderText = "Tipo Movimiento";
            colTipoMov.Name = "colTipoMov";
            colTipoMov.ReadOnly = true;
            // 
            // colRetiro
            // 
            colRetiro.HeaderText = "Retiros";
            colRetiro.Name = "colRetiro";
            colRetiro.ReadOnly = true;
            // 
            // colDeposito
            // 
            colDeposito.HeaderText = "Depósitos";
            colDeposito.Name = "colDeposito";
            colDeposito.ReadOnly = true;
            // 
            // frmMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 561);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(611, 600);
            MinimumSize = new Size(611, 600);
            Name = "frmMovimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMovimientos";
            Load += frmMovimientos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colMoneda;
        private DataGridViewTextBoxColumn colTipoMov;
        private DataGridViewTextBoxColumn colRetiro;
        private DataGridViewTextBoxColumn colDeposito;
    }
}