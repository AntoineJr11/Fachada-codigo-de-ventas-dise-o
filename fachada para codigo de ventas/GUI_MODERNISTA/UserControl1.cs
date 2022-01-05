using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos dos = new Productos();
            dos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro tres = new Registro();
            tres.Show();
        }
    }
}
