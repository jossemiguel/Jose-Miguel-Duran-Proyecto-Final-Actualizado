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

namespace MenuPrincipal.Ventas.RegistroUsuarios
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
            txtEmpleadoCedula.Enabled = false;
            txtEmpleadoNombre.Enabled = false;
            txtEmpleadoApellidos.Enabled = false;
            txtEmpleadoTelefono.Enabled = false;
            txtEmpleadoDireccion.Enabled = false;
            btnEmpleadoMasculino.Enabled = false;
            btnEmpleadoFemenino.Enabled = false;
            txtEmpleadoNacionalidad.Enabled = false;
            txtEmpleadoSalario.Enabled = false;
            txtEmpleadoFechaEntrada.Enabled = false;
            txtEmpleadoCargo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            txtEmpleadoCedula.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleados em = new Empleados();



            em.EmpleadoId = Convert.ToInt32(txtEmpleadoId.Text);
            em.Cedula = txtEmpleadoCedula.Text;
            em.Nombre = txtEmpleadoNombre.Text;
            em.Apellidos = txtEmpleadoApellidos.Text;
            em.Sexo = btnEmpleadoMasculino.Text;
            em.Sexo = btnEmpleadoFemenino.Text;
            em.Telefono = txtEmpleadoTelefono.Text;
            em.Direccion = txtEmpleadoDireccion.Text;
            em.Nacionalidad = txtEmpleadoNacionalidad.Text;
            em.Cargo = txtEmpleadoCargo.Text;
            em.Salario = Convert.ToInt32(txtEmpleadoSalario.Text);
            em.FechaEntrada = txtEmpleadoFechaEntrada.Text;

            if (EmpleadosBLL.insertar(em))
            {
                MessageBox.Show("Registro Exitoso");

                txtEmpleadoCedula.Clear();
                txtEmpleadoNombre.Clear();
                txtEmpleadoApellidos.Clear();
                txtEmpleadoTelefono.Clear();
                txtEmpleadoDireccion.Clear();
                //btnEmpleadoMasculino.Clear();
                // btnEmpleadoFemenino.Clear();
                txtEmpleadoNacionalidad.Clear();
                txtEmpleadoSalario.Clear();
                txtEmpleadoFechaEntrada.Clear();
                txtEmpleadoCargo.Clear();
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEmpleadoId.Text = "0";

            txtEmpleadoCedula.Enabled = true;
            txtEmpleadoNombre.Enabled = true;
            txtEmpleadoApellidos.Enabled = true;
            txtEmpleadoTelefono.Enabled = true;
            txtEmpleadoDireccion.Enabled = true;
            btnEmpleadoMasculino.Enabled = true;
            btnEmpleadoFemenino.Enabled = true;
            txtEmpleadoNacionalidad.Enabled = true;
            txtEmpleadoSalario.Enabled = true;
            txtEmpleadoFechaEntrada.Enabled = true;
            txtEmpleadoCargo.Enabled = true;
            btnGuardar.Enabled = true;



            txtEmpleadoCedula.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            //dataGridView1 = new DataGridView();
            //bool validar = true; ;

            if (String.IsNullOrEmpty(txtEmpleadoNombre.Text))
            {
                MessageBox.Show("Error, no hay Clientes para Modificar");
            }

            //if (validar && txtNombre.Text !=null)
            else
            {
                //validar = true;
                EmpleadosBLL.Modificar(new Empleados()
                {
                    EmpleadoId = Convert.ToInt32(txtEmpleadoId.Text),
                    Cedula = txtEmpleadoCedula.Text,
                    Nombre = txtEmpleadoNombre.Text,
                    Apellidos = txtEmpleadoApellidos.Text,
                    Sexo = btnEmpleadoMasculino.Text,
                    //Sexo = btnEmpleadoFemenino.Text,
                    Telefono = txtEmpleadoTelefono.Text,
                    Direccion = txtEmpleadoDireccion.Text,
                    Nacionalidad = txtEmpleadoNacionalidad.Text,
                    Cargo = txtEmpleadoCargo.Text,
                    Salario = Convert.ToInt32(txtEmpleadoSalario.Text),
                    FechaEntrada = txtEmpleadoFechaEntrada.Text,
                    List = EmpleadosBLL.Getlista(),
                });


                DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
                if (dialogo == DialogResult.OK)

                    txtEmpleadoCedula.Clear();
                txtEmpleadoNombre.Clear();
                txtEmpleadoApellidos.Clear();
                txtEmpleadoTelefono.Clear();
                txtEmpleadoDireccion.Clear();
                //btnEmpleadoMasculino.Clear();
                // btnEmpleadoFemenino.Clear();
                txtEmpleadoNacionalidad.Clear();
                txtEmpleadoSalario.Clear();
                txtEmpleadoFechaEntrada.Clear();
                txtEmpleadoCargo.Clear();
                btnNuevo.Enabled = true;
                //btnModificar.Enabled = false;
                //lista = EmpleadosBLL.Getlista();
                //dataGridView1.DataSource = lista;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmpleadoNombre.Text))
            {
                MessageBox.Show("Error, no hay empleados  para Eliminar");
            }

            //if //(txtCedula.Text!= null)
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Deseas borrar este Empleado?", " Borrando usuario de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int EmpeladoId = Convert.ToInt32(txtEmpleadoId.Text);
                    EmpleadosBLL.Eliminar(EmpeladoId);

                    txtEmpleadoId.Clear();
                    txtEmpleadoCedula.Clear();
                    txtEmpleadoNombre.Clear();
                    txtEmpleadoApellidos.Clear();
                    txtEmpleadoTelefono.Clear();
                    txtEmpleadoDireccion.Clear();
                    //btnEmpleadoMasculino.Clear();
                    // btnEmpleadoFemenino.Clear();
                    txtEmpleadoNacionalidad.Clear();
                    txtEmpleadoSalario.Clear();
                    txtEmpleadoFechaEntrada.Clear();
                    txtEmpleadoCargo.Clear();


                    MessageBox.Show("! Cliente Eliminado !", MessageBoxOptions.ServiceNotification.ToString());
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //bool retorno = true;
            if (String.IsNullOrEmpty(txtEmpleadoId.Text))
            {
                DialogResult res = MessageBox.Show("Id Invalido o No Existe");
                //errorProvider1.SetError(txtId, " ");
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
        }
        public void cedula()
        {
            var b = EmpleadosBLL.Buscar(Convert.ToInt32(txtEmpleadoId.Text));

            if (b != null)
            {


                //txtEmpleadoId.Text = b.EmpleadoId;
                txtEmpleadoCedula.Text = b.Cedula;
                txtEmpleadoNombre.Text = b.Nombre;
                txtEmpleadoApellidos.Text = b.Apellidos;
                txtEmpleadoTelefono.Text = b.Telefono;
                txtEmpleadoDireccion.Text = b.Direccion;
                btnEmpleadoMasculino.Text = b.Sexo;
                btnEmpleadoFemenino.Text = b.Sexo;
                txtEmpleadoNacionalidad.Text = b.Nacionalidad;
                txtEmpleadoSalario.Text = b.Salario.ToString();
                txtEmpleadoFechaEntrada.Text = b.FechaEntrada;
                txtEmpleadoCargo.Text = b.Cargo;



            }

            else
            {
                MessageBox.Show("Id Invalido o No Existe");
            }
        }
    }
}
