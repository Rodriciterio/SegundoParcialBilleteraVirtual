using SegundoParcialBilleteraVirtual.Datos;

namespace SegundoParcialBilleteraVirtual.Windows
{
    public partial class frmPagar : Form
    {
        private Billetera billetera;  
        private (string, decimal) pago;

        public frmPagar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string pagoDescripcion = txtPago.Text;
                if (string.IsNullOrEmpty(pagoDescripcion))
                {
                    MessageBox.Show("Debe ingresar una descripción para el pago.", "Descripción inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) && cantidad > 0)
                {
                    var resultado = billetera.Pagar(cantidad);

                    if (resultado.Item1)
                    {
                        MessageBox.Show("Pago realizado con éxito.", "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK; 
                    }
                    else 
                    {
                        MessageBox.Show(resultado.Item2, "Error en el pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Cantidad inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
