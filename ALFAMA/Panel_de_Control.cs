using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Panel_de_Control : Form
    {
        public Panel_de_Control()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_abmRol_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Login p = new Login();/*Al desloguearse volvemos a login*/
            p.Show();
            this.Hide();
        }
    }
}
