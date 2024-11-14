
using SegundoParcialBilleteraVirtual.Entidades;

namespace SegundoParcialBilleteraVirtual.Windows.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }

        private static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                //case Moneda moneda:
                //    r.Cells[0].Value = moneda.Codigo;
                //    r.Cells[1].Value = moneda.Cantidad;
                //    r.Cells[2].Value = moneda.ConvertirA(typeof(PesoArgentino)).Cantidad.ToString("C0");
                //    r.Cells[3].Value = moneda.ConvertirA(typeof(Dolar)).Cantidad.ToString("C0");
                //    break;
                //case Movimiento movimiento:
                //    r.Cells[0].Value = movimiento.FechaMovimiento.ToShortDateString();
                //    r.Cells[1].Value = movimiento.CodigoMoneda;
                //    r.Cells[2].Value = movimiento.TipoMovimiento.ToString();
                //    r.Cells[3].Value = movimiento.Retiro?.ToString("C");
                //    r.Cells[4].Value = movimiento.Deposito?.ToString("C");
                //    break;

            }
            r.Tag = obj;
        }

    }
}
