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
    public partial class Pantalla_de_bievenida : Form
    {
        public Pantalla_de_bievenida()
        {
            InitializeComponent();
        }

        private void bt_siguiente_Click(object sender, EventArgs e)
        {
            Login p = new Login();/*Al desloguearse volvemos a login*/
            p.Show();
            this.Hide();
        }
    }
}
