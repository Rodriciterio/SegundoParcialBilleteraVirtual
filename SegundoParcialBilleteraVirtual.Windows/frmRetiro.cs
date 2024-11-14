using SegundoParcialBilleteraVirtual.Datos;
using SegundoParcialBilleteraVirtual.Entidades;

namespace SegundoParcialBilleteraVirtual.Windows
{
    public partial class frmRetiro : Form
    {
        private Billetera billetera;
        private Moneda monedaRetiro;

        public frmRetiro(Billetera billetera)
        {
            InitializeComponent();
            this.billetera = billetera;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) && cantidad > 0)
                {
                    monedaRetiro = new PesoArgentino(cantidad); 
                    var (exito, mensaje) = billetera.Retiro(monedaRetiro); 

                    MessageBox.Show(mensaje, exito ? "Éxito" : "Error", MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (exito)
                    {
                        DialogResult = DialogResult.OK;
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
