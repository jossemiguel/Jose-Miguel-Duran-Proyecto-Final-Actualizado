using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace MenuPrincipal.RegistroUsuario
{
    public partial class ControlUsuarios : Form
    {
        
        public ControlUsuarios()
        {
            InitializeComponent();
            txtTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

       private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtRcontrasena.Clear();
            txtRConfirmaContrasena.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            
            
            if (!Validar())
            {
                MessageBox.Show("Complete todos los datos", MessageBoxIcon.Stop.ToString());
                return;
            }

            usuario = LlenarClase();

            if (UsuariosBLL.insertar(usuario))
            {
               
                progressBar1.Visible=true;
                timer1.Start();

                
            }
            


        }

        private bool Validar()
        {
            bool retorno = true;
            do
            {

                if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                errorProvider1.SetError(txtNombreUsuario, "");
                retorno = false;
                errorProvider1.Clear();


            }

            else
                errorProvider1.Clear();


            if (string.IsNullOrEmpty(txtTipoUsuario.Text))
            {
                errorProvider1.SetError(txtNombreUsuario, "");
                retorno = false;
            }
            else
                errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtRcontrasena.Text))
            {
                errorProvider1.SetError(txtNombreUsuario, "");
                retorno = false;
            }

            else
                errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtRConfirmaContrasena.Text))
            {
                errorProvider1.SetError(txtNombreUsuario, "");
                retorno = false;
            }

            
                //if (txtRConfirmaContrasena.Text != txtRcontrasena.Text)
               // {
                   // errorProvider1.SetError(txtRConfirmaContrasena, "Contrasena Invalida");
                //}
            

           
            
            else
            {
                errorProvider1.Clear();
            }

            } while (txtRConfirmaContrasena == txtRcontrasena);


            return retorno;
        }
       

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
           
            usuario.UsuarioId = Utilidades.ToInt(txtId.Text);
            usuario.NombreUsurio = txtNombreUsuario.Text;
            usuario.TipoUsuario = txtTipoUsuario.Text;
            usuario.Contraseña = txtRcontrasena.Text;
            usuario.ConfirmeContraseña = txtRConfirmaContrasena.Text;
            //usuario.FechaRegistro = FechaR.Text;
            
            

            return usuario;
        }
        




        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Deseas Cancelar el Registro?", " Registro de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {

                MenuPrincipal.Menu menu = new MenuPrincipal.Menu();
                menu.Show();
                this.Hide();
            }

            else
                return;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal.RegistroUsuarios.VerUsuarios1 ver = new MenuPrincipal.RegistroUsuarios.VerUsuarios1();
            ver.Show();
            this.Hide();




        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compraventasDbDataSet.RegistroUsuario' table. You can move, or remove it, as needed.
            //this.registroUsuarioTableAdapter.Fill(this.compraventasDbDataSet.RegistroUsuario);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 5;
            if (Convert.ToInt32(progressBar1.Value) > 99)
            {
                timer1.Stop();
                progressBar1.Visible = false;
                MessageBox.Show("Usuario Creado", MessageBoxOptions.RtlReading.ToString());
                LimpiarCampos();

            }
        }
    }
    }

