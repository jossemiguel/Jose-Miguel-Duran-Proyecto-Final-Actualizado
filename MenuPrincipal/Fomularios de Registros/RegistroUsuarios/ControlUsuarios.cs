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
using DAL;

namespace MenuPrincipal.RegistroUsuario
{
    public partial class ControlUsuarios : Form
    {
        
        public ControlUsuarios()
        {
            InitializeComponent();
            //txtTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            
          
            user.DataSource = EmpleadosBLL.Getlista();
          user.ValueMember = "EmpleadoId";
          user.DisplayMember = "Nombre";

          


            user.Enabled = false;
            txtTipoUsuario.Enabled = false;
            txtRcontrasena.Enabled = false;
            txtRConfirmaContrasena.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;


        }

       private void LimpiarCampos()
        {
            //txtNombreUsuario.Clear();
            txtRcontrasena.Clear();
            txtRConfirmaContrasena.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();


            //usuario.UsuarioId = Convert.ToInt32(txtId.Text);
            usuario.NombreUsuario = user.Text;
            usuario.TipoUsuario = txtTipoUsuario.Text;
            usuario.Contraseña = txtRcontrasena.Text;
            usuario.FechaRegistro = FechaR.Text;
            
            if (UsuariosBLL.insertar(usuario))
            {
                MessageBox.Show("Registro Exitoso");
                txtRcontrasena.Clear();
                txtRConfirmaContrasena.Clear();
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

            }


        }

        private bool Validar()
        {
            bool retorno = true;
            do
            {

            //    if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            //{
            //    errorProvider1.SetError(txtNombreUsuario, "Campo Nombre Vacio");
            //    retorno = false;
                


            //}

            //else
            //    errorProvider1.Clear();


            if (string.IsNullOrEmpty(txtTipoUsuario.Text))
            {
                errorProvider1.SetError(txtTipoUsuario, "Seleccione un tipo de usuario");
                retorno = false;
            }
            else
                errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtRcontrasena.Text))
            {
                errorProvider1.SetError(txtRcontrasena, "Ingrese una contrasena");
                retorno = false;
            }

            else
                errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtRConfirmaContrasena.Text) & txtRConfirmaContrasena!=txtRcontrasena)
            {
                errorProvider1.SetError(txtRConfirmaContrasena, " Contrasena Incorrecta");
                retorno = false;
            }


                if (txtRConfirmaContrasena.Text != txtRcontrasena.Text)
                {
                    errorProvider1.SetError(txtRConfirmaContrasena, "Contrasena Invalida");
                    retorno = false;
                }




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
           

            //d.UsuarioIdColumn = Utilidades.ToInt(txtId, Text);
            //d.TipoUsuarioColumn.ColumnMapping.CompareTo(txtTipoUsuario);
            usuario.UsuarioId = Utilidades.ToInt(txtId.Text);
            usuario.NombreUsuario = user.Text;
            usuario.TipoUsuario = txtTipoUsuario.Text;
            usuario.Contraseña = txtRcontrasena.Text;
            usuario.FechaRegistro = FechaR.Text;
          
            //usuario.ConfirmeContraseña = txtRConfirmaContrasena.Text;
            usuario.FechaRegistro = FechaR.Text;
            
            

            return usuario;
        }
        




        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user.Text))
            {
                MessageBox.Show("Error, no hay Clientes para Eliminar");
            }

            //if //(txtCedula.Text!= null)
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Deseas borrar este Usuario?", " Borrando usuario de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int UsuarioId = Convert.ToInt32(txtId.Text);
                    PersonasBLL.Eliminar(UsuarioId);
                    txtId.Clear();
                  txtRcontrasena.Clear();
                   txtRConfirmaContrasena.Clear();
                   

                    MessageBox.Show("! Usuario Eliminado !", MessageBoxOptions.ServiceNotification.ToString());
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView1 = new DataGridView();
            //bool validar = true; ;

            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Error, no hay Usuario para Modificar");
            }

            //if (validar && txtNombre.Text !=null)
            else
            {
                //validar = true;
                UsuariosBLL.Modificar(new Usuarios()
                {
                    UsuarioId = Convert.ToInt32(txtId.Text),
                    NombreUsuario = user.Text,
                    TipoUsuario = txtTipoUsuario.Text,
                    Contraseña = txtRcontrasena.Text,
                    FechaRegistro = FechaR.Text,
                    
                    //List = UsuariosBLL.Getlista(),
                });


                DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
                if (dialogo == DialogResult.OK)

                    txtId.Clear();
                
                txtRcontrasena.Clear();
               txtRConfirmaContrasena.Clear();
                
                btnNuevo.Enabled = true;
                //btnModificar.Enabled = false;
                lista = PersonasBLL.Getlista();
                //dataGridView1.DataSource = lista;

            }



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
            
            //this.personasTableAdapter.Fill(this.compraventasDbDataSet1.Personas);
            // TODO: This line of code loads data into the 'compraventasDbDataSet.RegistroUsuario' table. You can move, or remove it, as needed.
            //this.registroUsuarioTableAdapter.Fill(this.compraventasDbDataSet.RegistroUsuario);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 5;
            if (Convert.ToInt32(progressBar1.Value) > 70)
            {
                timer1.Stop();
                progressBar1.Visible = false;

                MessageBox.Show("Usuario Creado", MessageBoxOptions.RtlReading.ToString());
                LimpiarCampos();

            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                txtTipoUsuario.Focus();

            }
        }

        private void txtTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                txtRcontrasena.Focus();


            }
        }

        private void txtRcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRConfirmaContrasena.Focus();


            }
        }

        private void txtRConfirmaContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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

                    progressBar1.Visible = true;
                    timer1.Start();


                }

            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personasTableAdapter.FillBy(this.compraventasDbDataSet1.Personas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               // this.usuariosTableAdapter.FillBy(this.compraventasDbDataSet2.Usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public List<Personas> lista = new List<Personas>();

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //bool retorno = true;
            if (String.IsNullOrEmpty(txtId.Text))
            {
                DialogResult res = MessageBox.Show("Id Invalido o No Existe");
                errorProvider1.SetError(txtId, " ");
                //retorno = false;
                if (res == DialogResult.OK)
                {
                    btnNuevo.Enabled = true;

                }

                //lista = PersonasBLL.GetLista(txtCedula.Text);

            }

            cedula();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            // btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;


            lista = PersonasBLL.Getlista();

            //dataGridView1.DataSource = lista;
        }

        public void cedula()
        {
            var b = UsuariosBLL.Buscar(Convert.ToInt32(txtId.Text));

            if (b != null)
            {
                user.Text = b.NombreUsuario;
                txtRcontrasena.Text = b.Contraseña;
                txtTipoUsuario.Text = b.TipoUsuario;
                FechaR.Text = b.FechaRegistro;
                

            }

            else
            {
                MessageBox.Show("Id Invalido o No Existe");
            }
        }



        private void comboBox1_LocationChanged(object sender, EventArgs e)
        {
            MessageBox.Show(user.Text);
        }

        private void DatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DatosUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personasTableAdapter.FillBy1(this.compraventasDbDataSet1.Personas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personasTableAdapter.FillBy2(this.compraventasDbDataSet1.Personas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
               // this.personasTableAdapter1.FillBy(this.compraventasDbDataSet3.Personas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtPersonaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //txtId.Text = "0";
            user.Enabled = true;
            txtTipoUsuario.Enabled = true;
            txtRConfirmaContrasena.Enabled = true;
            txtRcontrasena.Enabled = true;
            FechaR.Enabled = true;
            user.Focus();
            btnGuardar.Enabled = true;




        }
    }
    }

