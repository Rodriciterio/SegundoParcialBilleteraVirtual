using SegundoParcialBilleteraVirtual.Datos;
using SegundoParcialBilleteraVirtual.Entidades;
using SegundoParcialBilleteraVirtual.Windows.Helpers;

namespace SegundoParcialBilleteraVirtual.Windows
{
    public partial class frmBilleteraVirtual : Form
    {
        Billetera billetera;
        public frmBilleteraVirtual()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            billetera.GuardarDatos();
            Application.Exit();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            frmDeposito frm = new frmDeposito() { Text = "Depositar Moneda:" };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Moneda monedaDeposito = frm.moneda;
                billetera.Deposito(monedaDeposito);
                var contenido = billetera.MostrarContenido();
                GridHelper.MostrarDatosEnGrilla(contenido, dgvDatos);  
            }
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {
            frmRetiro frm = new frmRetiro(billetera);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GridHelper.MostrarDatosEnGrilla(billetera.MostrarContenido(), dgvDatos);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagar frm = new frmPagar();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                GridHelper.MostrarDatosEnGrilla(billetera.MostrarContenido(), dgvDatos);
            }
        }

        private void frmBilleteraVirtual_Load(object sender, EventArgs e)
        {
        }

        private void btnComprarDivisas_Click(object sender, EventArgs e)
        {
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
        }

        private void btnUltimosMovimientos_Click(object sender, EventArgs e)
        {

        }
    }
}
