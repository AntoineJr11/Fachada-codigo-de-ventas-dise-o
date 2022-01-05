using GUI_MODERNISTA.Movimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{

    public partial class ReporteVentas : Form
    {
        Movimiento nuevo = new Movimiento();
        public ReporteVentas()
        {
            InitializeComponent();
        }
        private void lblMostrar_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = nuevo.Mostrar().ToList();
        }
    }
}
