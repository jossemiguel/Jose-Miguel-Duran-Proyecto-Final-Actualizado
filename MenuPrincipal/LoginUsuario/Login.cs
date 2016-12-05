using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MenuPrincipal.LoginUsuario
{
    public partial class Login : Form
    {
       // public static bool ok = false;
        public Login()
        {
            InitializeComponent();
        }

        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            validar();

            if (ValidarSeccion() == DialogResult.OK)
            {
               
                iTalk_ProgressIndicator1.Visible = true;
                timer1.Start();
            }
            else
                MessageBox.Show("Usuario o Contrasena incorrecta");
        }

        public bool validarUsuario()
        {
            if (UsuariosBLL.getlistaNombreUsuario(txtUsuario.Text).Count()==0)
            {
                return false;

            }

            return true;
        }

        public bool validarContrasena()
        {
            if (UsuariosBLL.getlistacontrasena(txtContrasena.Text).Count()==0)
            {
                return false;
            }

            return true;
        }

        public DialogResult ValidarSeccion()
        {
            if (validarUsuario()==true && validarContrasena()==true )
            {
                return DialogResult.OK;
            }

            return DialogResult.Cancel;
        }
        private void validar()
        {
            if (txtUsuario.Text == string.Empty)
            {
                error.SetError(txtUsuario, "CAMPO VACIO");
            }

            else

            {
                error.Clear();
            }

            if (txtContrasena.Text == string.Empty)
            {
                error.SetError(txtContrasena, "CAMPO VACIO");

            }
            else

            {
                error.Clear();
               
            }

           
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value = Convert.ToSByte(progressBar1.Value)+2;

            iTalk_ProgressBar1.Value = Convert.ToByte(iTalk_ProgressBar1.Value) + 2;
            if (Convert.ToInt32(iTalk_ProgressBar1.Value)>99)
            {
                timer1.Stop();
                Menu menu = new Menu();
                menu.Visible = true;
                
                this.Hide();
                
                
            }
        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            //this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                txtContrasena.Focus();

            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                validar();

                if (ValidarSeccion() == DialogResult.OK)
                {

                    iTalk_ProgressIndicator1.Visible = true;
                    timer1.Start();
                }
                else
                    MessageBox.Show("Usuario o Contrasena incorrecta");
            }
        }
    }
}
