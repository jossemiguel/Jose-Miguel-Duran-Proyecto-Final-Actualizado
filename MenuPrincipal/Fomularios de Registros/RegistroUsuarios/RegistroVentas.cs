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
    public partial class RegistroVentas : Form
    {
        Entidades.Ventas v;
         public RegistroVentas()
        {
           
            InitializeComponent();
            txtClientes.DataSource = PersonasBLL.Getlista();
            txtClientes.DisplayMember = "Nombre";
            txtClientes.ValueMember = "PersonaId";

            txtArticulos.DataSource = ComprasBLL.GetLista();
            txtArticulos.DisplayMember = "NombreArticulo";
            txtArticulos.ValueMember= "CompraId";
            DatosFactura.Columns[0].Visible = false;

            v = new Entidades.Ventas();

        }
        

        private void Ventas_Load(object sender, EventArgs e)
        {

        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //Entidades.Ventas v = new Entidades.Ventas();

           // int id = (int)txtArticulos.SelectedValue;
            v.Com.Add(ComprasBLL.Buscar((int)txtArticulos.SelectedValue));
            //v.Com.Add(new Compras(id, txtArticulos.Text, Compras.GetPrecio(id), Utilidades.ToInt(txtCantidad.Text)));
          
            DatosFactura.DataSource = null;
            //DatosFactura.Rows.Add();
            
            DatosFactura.DataSource =v.Com ;

            //DatosFactura.Columns[1].Visible = false;
            // DatosFactura.Columns[2].Visible = false;
            //DatosFactura.Columns[3].Visible = false;
            // DatosFactura.Columns[4].Visible = false;
            DatosFactura.Columns[5].Visible = false;
            DatosFactura.Columns[6].Visible = false;
            DatosFactura.Columns[7].Visible = false;
            DatosFactura.Columns[8].Visible = false;
            DatosFactura.Columns[9].Visible = false;
            DatosFactura.Columns[10].Visible = false;
            DatosFactura.Columns[11].Visible = false;
            DatosFactura.Columns[0].Visible = true ;
            //DatosFactura.Rows.Add(txtCantidad.Text);

            //DatosFactura.Rows[0].Cells. = txtCantidad.Text;
            Calcular();



        }

        
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientes.Text)
                 || string.IsNullOrEmpty(DatosFactura.DataSource.ToString()))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {

                
                int id;
                int.TryParse(txtFacturaId.Text, out id);
                v.Fecha = txtFecha.Value;
                v.Nombre = txtClientes.Text;
                v.Direccion = txtDireccion.Text;
                v.Articulos = txtArticulos.Text;
                v.Cantidad = Convert.ToInt32(txtCantidad.Text);
                v.Total = Convert.ToInt32(txtTotal.Text);
                v.FacturaId = id;
                
                

                if (VentasBLL.insertar(v))
                {
                    MessageBox.Show("Datos registrados");
                    txtClientes.Items.Clear();
                    txtDireccion.Clear();
                    txtArticulos.Items.Clear();
                    txtCantidad.Clear();
                }
            }
        }
        public List<Compras> lista = new List<Compras>();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DatosFactura.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("¿Deseas borrar este Articulo?", " Borrando articulo de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int CompraId= Convert.ToInt32(DatosFactura.CurrentRow.Cells["CompraId"].Value);
                    ComprasBLL.Eliminar(CompraId);
                    //lista = PersonaUsuarioBLL.Getlista();
                    MessageBox.Show("! Articulo Eliminado !", MessageBoxOptions.ServiceNotification.ToString());
                }

            }
            else
            {
                return;

            }
            DatosFactura.DataSource = lista;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFacturaId.Text))
            {
                MessageBox.Show("Tienes el campo ID vacio");
            }
            else
            {
                var c = VentasBLL.Buscar(Convert.ToInt32(txtFacturaId.Text));
                if (c != null)
                {

                    txtClientes.Text = c.Nombre;
                    txtFecha.Text = c.Fecha.ToString();
                    txtDireccion.Text = c.Direccion;
                    txtArticulos.Text = c.Articulos;
                    txtCantidad.Text = c.Cantidad.ToString();
                    txtTotal.Text = c.Total.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Factura no Existe");
                }
            }
        }

        public void Calcular()
        {
            int suma = 0;



            foreach (DataGridViewRow row in DatosFactura.Rows)

            {

                suma += Convert.ToInt32(row.Cells[4].Value);  

            }

            txtTotal.Text = Convert.ToString(suma); 

        }

    }
    }

