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
namespace MenuPrincipal.Ventas.RegistroUsuarios
{
    public partial class RegistroPersonas : Form
    {
        public RegistroPersonas()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Personas p = new Personas();
            

            p.PersonaId = Convert.ToInt32(txtId.Text);
            p.Cedula =txtCedula.Text;
            p.Nombre = txtNombre.Text;
            p.Apellidos = txtApellidos.Text;
            p.Direccion = txtDireccion.Text;
            p.Telefono = txtTelefono.Text;
            p.Correo = txtCorreo.Text;
            if (PersonasBLL.insertar(p))
            {
                MessageBox.Show("Registro Exitoso");
                txtCedula.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtDireccion.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegistroPersonas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compraventasDbDataSet1.Personas' table. You can move, or remove it, as needed.
            this.personasTableAdapter.Fill(this.compraventasDbDataSet1.Personas);
            txtId.Text = "0";
            txtId.Enabled = false;
            label7.Enabled = false;
            txtNombre.Enabled=false;
            txtCedula.Enabled = false;
            txtApellidos.Enabled = false;
            txtDireccion.Enabled = false;
            txtCorreo.Enabled = false;
            txtTelefono.Enabled=false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;



           
           

           


        }
        public List<Personas> lista = new List<Personas>();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //bool retorno = true;
            if (String.IsNullOrEmpty(txtId.Text))
            {
                DialogResult res = MessageBox.Show("Id Invalido o No Existe");
                errorProvider1.SetError(txtId, " ");
                //retorno = false;
                if (res==DialogResult.OK)
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
            
            dataGridView1.DataSource =lista;
        }

        public void cedula()
        {
            var b = PersonasBLL.Buscar(Convert.ToInt32(txtId.Text));

            if (b != null)
            {
                txtCedula.Text = b.Cedula;
                txtNombre.Text = b.Nombre;
                txtApellidos.Text = b.Apellidos;
                txtDireccion.Text = b.Direccion;
                txtTelefono.Text = b.Telefono;
                txtCorreo.Text = b.Correo;
                
            }

            else
            {
                MessageBox.Show("Id Invalido o No Existe");
            }
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.BackColor = Color.LemonChiffon;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_MouseMove(object sender, MouseEventArgs e)
        {
            txtNombre.BackColor = Color.GreenYellow;
        }

        private void txtNombre_MouseLeave(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";

            txtId.Enabled = true;
            label7.Enabled = true;
            txtNombre.Enabled = true;
            txtCedula.Enabled = true;
            txtApellidos.Enabled = true;
            txtDireccion.Enabled = true;
            txtCorreo.Enabled = true;
            txtTelefono.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            


            txtCedula.Focus();
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
           

            dataGridView1 = new DataGridView();
            //bool validar = true; ;

            if(String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Error, no hay Clientes para Modificar");
            }

            //if (validar && txtNombre.Text !=null)
            else
            {
                //validar = true;
                PersonasBLL.Modificar(new Personas()
                {
                    PersonaId = Convert.ToInt32(txtId.Text),
                    Cedula=txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Apellidos=txtApellidos.Text,
                    Direccion=txtDireccion.Text,
                    Telefono=txtTelefono.Text,
                    Correo=txtCorreo.Text,

                    List = PersonasBLL.Getlista(),
                });


                DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
                if (dialogo == DialogResult.OK)

                    txtId.Clear();
                    txtCedula.Clear();
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtDireccion.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                    btnNuevo.Enabled = true;
                    //btnModificar.Enabled = false;
                lista = PersonasBLL.Getlista();
                    dataGridView1.DataSource = lista;
                    
                }
                
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Error, no hay Clientes para Eliminar");
            }

            //if //(txtCedula.Text!= null)
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Deseas borrar este Cliente?", " Borrando usuario de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int PersonaId = Convert.ToInt32(txtId.Text);
                    PersonasBLL.Eliminar(PersonaId);
                    txtId.Clear();
                    txtCedula.Clear();
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtDireccion.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();

                    MessageBox.Show("! Cliente Eliminado !", MessageBoxOptions.ServiceNotification.ToString());
                }

            }
            
        }
    }
    }
    

