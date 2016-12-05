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

namespace MenuPrincipal.Compra
{
    public partial class RegistroCompras : Form
    {
        public RegistroCompras()
        {
            InitializeComponent();

            txtRIdCompras.Enabled=false;
            txtNombreArticulo.Enabled = false;
            btnPNuevo.Enabled = false;
            btnUsado.Enabled = false;
            txtcantidadArticulo.Enabled = false;
            txtPrecioCompra.Enabled = false;
            txtComprasFecha.Enabled = false;
            txtComprasObservaciones.Enabled = false;
            txtComprasCodigo.Enabled = false;
            txtPrecioVenta.Enabled = false;
            //txtComprasGanancia.Enabled = false;

            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private void iTalk_HeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra.MenuCompras menu = new Compra.MenuCompras();
            menu.Visible = true;
            this.Hide();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Visible = true;
            this.Hide();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                txtcantidadArticulo.Focus();
            }
        }

        private void txtRcantidaArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRcantidaArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioCompra.Focus();
            }
        }

        private void txtRprecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtComprasObservaciones.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuCompras m = new MenuCompras();
            m.Visible = true;
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Compras compras = new Entidades.Compras();




            if (!Validar())
            {
                MessageBox.Show("Complete todos los datos", MessageBoxIcon.Stop.ToString());
                return;
            }

            compras = LlenarClase();

           if (ComprasBLL.insertar(compras))
            {
                txtRIdCompras.Clear();
                txtNombreArticulo.Clear();
                //btnPNuevo.Clear();
                //btnUsado.Clear();
                txtcantidadArticulo.Clear();
                txtPrecioCompra.Clear();
                txtComprasFecha.Clear();
                txtComprasObservaciones.Clear();
                txtComprasCodigo.Clear();
                txtPrecioVenta.Clear();
                //txtComprasGanancia.Clear();



                MessageBox.Show("Compra Registrada", MessageBoxOptions.RtlReading.ToString());
                //progressBar1.Visible = true;
                //timer1.Start();


            }



        }
        private bool Validar()
        {
            bool retorno = true;
            
           

                if (string.IsNullOrEmpty(txtNombreArticulo.Text))
                {
                    errorProvider1.SetError(txtNombreArticulo, "");
                    retorno = false;
                    errorProvider1.Clear();


                }

                else
                    errorProvider1.Clear();


                if (string.IsNullOrEmpty(txtcantidadArticulo.Text))
                {
                    errorProvider1.SetError(txtcantidadArticulo, "");
                    retorno = false;
                }
                else
                    errorProvider1.Clear();

                if (string.IsNullOrEmpty(btnPNuevo.Text))
                {
                    errorProvider1.SetError(btnPNuevo, "");
                    retorno = false;
                }

                else
                    errorProvider1.Clear();
                if (string.IsNullOrEmpty(btnUsado.Text))
                {
                    errorProvider1.SetError(btnUsado, "");
                    retorno = false;
                }


                if (string.IsNullOrEmpty(txtPrecioCompra.Text))
                {
                    errorProvider1.SetError(txtPrecioCompra, "");
                    retorno = false;
                }

                else
                    errorProvider1.Clear();


            return retorno;
        



    }

        private Entidades.Compras LlenarClase()
        {
            Entidades.Compras compras = new Entidades.Compras();

           
            compras.CompraId = Utilidades.ToInt(txtRIdCompras.Text);
            compras.NombreArticulo = txtNombreArticulo.Text;
            compras.Condicion = btnPNuevo.Text;
            compras.Condicion = btnUsado.Text;
            compras.CantidadArticulo = Utilidades.ToInt(txtcantidadArticulo.Text);
            compras.Precio = Utilidades.ToInt(txtPrecioCompra.Text);
            compras.Fecha = txtComprasFecha.Text;
            compras.Observaciones= txtComprasObservaciones.Text;
            compras.Codigo = txtComprasCodigo.Text;
            //compras.Ganancia = Convert.ToInt32(txtComprasGanancia.Text);
            compras.PrecioCompra = Convert.ToInt32(txtPrecioCompra.Text);

            
            
            

            return compras;
        }

        private void txtComprasGanancia_TextChanged(object sender, EventArgs e)
        {
           

            //txtComprasGanancia.Text =(Convert.ToInt32 (txtPrecioVenta.Text) - Convert.ToInt32 (txtPrecioCompra.Text)).ToString();


        }

        private void txtPrecioVenta_TabIndexChanged(object sender, EventArgs e)
        {
           // txtComprasGanancia.Text = (Convert.ToUInt32(txtPrecioVenta.Text) - Convert.ToUInt32(txtPrecioCompra.Text)).ToString();
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            //txtComprasGanancia.Text = (Convert.ToUInt32(txtPrecioVenta.Text) - Convert.ToUInt32(txtPrecioCompra.Text)).ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Facturaid.Text = "0";

            txtRIdCompras.Enabled = true;
            txtNombreArticulo.Enabled = true;
            btnPNuevo.Enabled = true;
            btnUsado.Enabled = true;
            txtcantidadArticulo.Enabled = true;
            txtPrecioCompra.Enabled = true;
            txtComprasFecha.Enabled = true;
            txtComprasObservaciones.Enabled = true;
            txtComprasCodigo.Enabled = true;
            txtPrecioVenta.Enabled = true;
            //txtComprasGanancia.Enabled = true;

            btnBuscar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnModificar.Enabled = true;
            btnGuardar.Enabled = true;
            txtComprasCodigo.Focus();
        }

        private void RegistroCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //dataGridView1 = new DataGridView();
            //bool validar = true; ;

            if (String.IsNullOrEmpty(txtNombreArticulo.Text))
            {
                MessageBox.Show("Error, no hay Articulos para Modificar");
            }

            //if (validar && txtNombre.Text !=null)
            else
            {
                //validar = true;
                ComprasBLL.Modificar(new Entidades.Compras()
                {
                    CompraId = Convert.ToInt32(txtRIdCompras.Text),
                    NombreArticulo = txtNombreArticulo.Text,
                    Condicion = btnPNuevo.Text,

                    CantidadArticulo = Convert.ToInt32(txtcantidadArticulo.Text),
                    PrecioCompra = Convert.ToInt32(txtPrecioCompra.Text),
                    Fecha = txtComprasFecha.Text,
                    Observaciones = txtComprasObservaciones.Text,
                    Codigo = txtComprasCodigo.Text,
                    Precio = Convert.ToInt32(txtPrecioVenta.Text),
                    //Ganancia = Convert.ToInt32(txtComprasGanancia.Text),

                    //List = ComprasBLL.GetLista();
                });


                DialogResult dialogo = MessageBox.Show("Articulo Actualizado Correctamente");
                if (dialogo == DialogResult.OK)

                    txtRIdCompras.Clear();
                txtNombreArticulo.Clear();
                //btnPNuevo.Clear();
                //btnUsado.Clear();
                txtcantidadArticulo.Clear();
                txtPrecioCompra.Clear();
                txtComprasFecha.Clear();
                txtComprasObservaciones.Clear();
                txtComprasCodigo.Clear();
                txtPrecioVenta.Clear();
                //txtComprasGanancia.Clear();
                btnNuevo.Enabled = true;
                //btnModificar.Enabled = false;
                //lista = PersonasBLL.Getlista();
               // dataGridView1.DataSource = lista;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreArticulo.Text))
            {
                MessageBox.Show("Error, no hay Articulo para Eliminar");
            }

            //if //(txtCedula.Text!= null)
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Deseas borrar este Articulo?", " Borrando Articulo de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int CompraId = Convert.ToInt32(txtRIdCompras.Text);
                    ComprasBLL.Eliminar(CompraId);
                    txtRIdCompras.Clear();
                    txtNombreArticulo.Clear();
                    //btnPNuevo.Clear();
                    //btnUsado.Clear();
                    txtcantidadArticulo.Clear();
                    txtPrecioCompra.Clear();
                    txtComprasFecha.Clear();
                    txtComprasObservaciones.Clear();
                    txtComprasCodigo.Clear();
                    txtPrecioVenta.Clear();
                    //txtComprasGanancia.Clear();

                    MessageBox.Show("! Cliente Eliminado !", MessageBoxOptions.ServiceNotification.ToString());
                }

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //bool retorno = true;
            if (String.IsNullOrEmpty(txtRIdCompras.Text))
            {
                DialogResult res = MessageBox.Show("Id Invalido o No Existe");
                errorProvider1.SetError(txtRIdCompras, " ");
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


            //lista = PersonasBLL.Getlista();

            //dataGridView1.DataSource = lista;
        }

        public void cedula()
        {
            var b = ComprasBLL.Buscar(Convert.ToInt32(txtRIdCompras.Text));

            if (b != null)
            {


                txtNombreArticulo.Text = b.NombreArticulo;
                //btnPNuevo.Clear();
                //btnUsado.Clear();
                txtcantidadArticulo.Text = b.CantidadArticulo.ToString();
                txtPrecioCompra.Text = b.PrecioCompra.ToString();
                txtComprasFecha.Text = b.Fecha;
                txtComprasObservaciones.Text = b.Observaciones;
                txtComprasCodigo.Text = b.Codigo;
                txtPrecioVenta.Text = b.Precio.ToString();
                //txtComprasGanancia.Text = b.Ganancia.ToString();

                

            }

            else
            {
                MessageBox.Show("Id Invalido o No Existe");
            }
        }

        private void txtPrecioVenta_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtComprasGanancia_TabIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
