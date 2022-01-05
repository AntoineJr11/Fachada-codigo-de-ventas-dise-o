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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        // login para el usuario
        private void btnaceptarLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptarLogin_Click_1(object sender, EventArgs e)
        {
            frmMenuPrincipal logeo;

            if ((txtUsuario.Text != "") && (txtContrasenia.Text != ""))
            {


                if ((txtUsuario.Text == "admin") && (txtContrasenia.Text == "12345"))
                {

                    logeo = new frmMenuPrincipal();
                    logeo.Show();
                    this.Hide();

                    MessageBox.Show("Es correcto");


                }
                else
                {

                    MessageBox.Show("Incorrecto");
                }
            } 
        }
    }
}
