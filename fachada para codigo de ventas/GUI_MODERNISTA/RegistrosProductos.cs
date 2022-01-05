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
    public partial class RegistrosProductos : Form
    {

        Movimiento nuevo = new Movimiento();
        public RegistrosProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo.insertar(
                Convert.ToString(txtid.Text),
                Convert.ToString(txtNombre.Text),
                Convert.ToString(txtPrecio.Text),
                Convert.ToString(txtCantidad.Text)
                );
            dataGridView1.DataSource = nuevo.Mostrar().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nuevo.eliminar(Convert.ToString(TxtIdEliminar.Text));
            dataGridView1.DataSource = nuevo.Mostrar().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevo.modificar(
               Convert.ToString(txtid.Text),
               Convert.ToString(txtNombre.Text),
               Convert.ToString(txtPrecio.Text),
               Convert.ToString(txtCantidad.Text)
               );
            dataGridView1.DataSource = nuevo.Mostrar().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cliente uno = new cliente();
            uno.Show();
        }
    }
}
