using SegundoParcialBilleteraVirtual.Datos;
using SegundoParcialBilleteraVirtual.Entidades;

namespace SegundoParcialBilleteraVirtual.Windows
{
    public partial class frmDeposito : Form
    {
        public Moneda moneda;
        private Dictionary<string,Moneda> monedas;
        private Billetera billetera;
        public frmDeposito()
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
                if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) && cantidad > 0)
                {
                    moneda = new PesoArgentino(cantidad); 
                    DialogResult = DialogResult.OK;
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
