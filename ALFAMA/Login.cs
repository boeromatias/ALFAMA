using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"server=.\SQLSERVER2008;user=gd; password=gd2013;database=GD1C2013");
            try
            {
                //TENGO QUE SABER BIEN COMO SE VA A LLAMAR LA VARIABLE USUARIO 
                //EN LA BD Y REEMPLAZAR POR USER_NAME, LO MISMO PARA USER_PASS
                //VER SI LA TABLA DE ALEX ME SIRVE O CREAR UNA LLAMADA LOGIN

                SqlCommand cmd = new SqlCommand("select user_name,user_pass fronm login where user_name ='" + txt_user.Text + "' AND user_pass = '" + txt_pass.Text + "' ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Login"); //Login es el nombre de la tabla en sql

                DataRow dro;
                dro = ds.Tables["Login"].Rows[0];// login es el nombre de la tabla en sql

                if ((txt_user.Text == dro["user_name"].ToString()) && (txt_pass.Text == dro["user_pass"].ToString()))
                {
                    Panel_de_Control p = new Panel_de_Control();/*llamamos a nuestro formulario principal creo que en este caso es el de las funciones*/
                    p.Show();
                    this.Hide();

                }
            }
            catch { }
            finally
            {
                cn.Close();

            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
