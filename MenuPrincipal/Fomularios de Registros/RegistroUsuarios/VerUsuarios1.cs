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

namespace MenuPrincipal.RegistroUsuarios
{
    public partial class VerUsuarios1 : Form
    {
       
        public VerUsuarios1()
        {
            InitializeComponent();
        }
        public List<Usuarios> lista = new List<Usuarios>();
        
       
        CompraventaDb db = new CompraventaDb();
       
        private void Buscarbutton_Click(object sender, EventArgs e)
        {


            //if (ListaSeleccion.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Favor Seleccione una Opcion");
            //}


            if (!String.IsNullOrEmpty(VerId.Text))
            {
                lista = UsuariosBLL.GetLista(Utilidades.ToInt(VerId.Text));
                VerId.Clear();
            }

            if (!String.IsNullOrEmpty(VerNombre.Text))
            {
                lista = UsuariosBLL.BuscarNombre(VerNombre.Text);
                VerNombre.Clear();

            }

            if (ListaSeleccion.SelectedIndex == 2)
            {
                lista = UsuariosBLL.BusrcarPorFecha(FDesdedateTimePicker.Value, FHastadateTimePicker.Value);
                FDesdedateTimePicker.Refresh();
                FHastadateTimePicker.Refresh();
            }



            if (ListaSeleccion.SelectedIndex == 3)
            {
                lista = UsuariosBLL.Getlista();

            }

            else
            {
                MessageBox.Show("Favor Seleccione una Opcion");
            }

            lista = UsuariosBLL.Getlista();
            DatosdataGridView.DataSource = lista;
            textBox1.Text = DatosdataGridView.Rows.Count.ToString();
        }


       

        private void CamposComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void DatosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void VerUsuarios1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compraventasDbDataSet.RegistroUsuario' table. You can move, or remove it, as needed.
            //this.registroUsuarioTableAdapter.Fill(this.compraventasDbDataSet.RegistroUsuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Atras_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            
            MenuPrincipal.RegistroUsuario.ControlUsuarios foward = new MenuPrincipal.RegistroUsuario.ControlUsuarios();
            foward.Show();

            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (DatosdataGridView.CurrentRow !=null)
            {
                DialogResult dialogo = MessageBox.Show("¿Deseas borrar este usuario?", " Borrando usuario de la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo==DialogResult.Yes)
                {
                    int UsuarioId = Convert.ToInt32(DatosdataGridView.CurrentRow.Cells["UsuarioId"].Value);
                    UsuariosBLL.Eliminar(UsuarioId);
                    //lista = PersonaUsuarioBLL.Getlista();
                    MessageBox.Show("! Usuario Eliminado !",MessageBoxOptions.ServiceNotification.ToString());
                }

            }
             else
            {
                return;
                
            }
            DatosdataGridView.DataSource = lista;
            textBox1.Text = DatosdataGridView.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.CurrentRow!=null)
            {
                MenuPrincipal.ModificarUsuarios m = new MenuPrincipal.ModificarUsuarios();
                m.Show();

                m.txtMId.Text = DatosdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                m.txtMnombre.Text = DatosdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                m.txtMtipo.Text = DatosdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                m.txtMcontrasena.Text = DatosdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                m.txtMConfirmaContrasena.Text = DatosdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                m.FechaR.Text = DatosdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            }

            else
            {
                MessageBox.Show("No hay Usuario para Modificar");
                
            }
            
            

           // DatosdataGridView.CurrentRow.Cells[1]= m.txt
            
            
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //int v;
            

            //for(v=0; v<DatosdataGridView.Rows.Count; v++ )
            //{
                textBox1.Text = DatosdataGridView.Rows.Count.ToString();
           // }
        }

        private void VerUsuarios1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compraventasDbDataSet.RegistroUsuario' table. You can move, or remove it, as needed.
            // this.registroUsuarioTableAdapter.Fill(this.compraventasDbDataSet.RegistroUsuario);

            FehaInicial.Visible = false;
            FHastadateTimePicker.Visible = false;
            FechaFinal.Visible = false;
            FDesdedateTimePicker.Visible = false;

            VerId.Visible = false;
            IngreseIdL.Visible = false;
            VerNombre.Visible = false;
            IngreseNombreL.Visible = false;

           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lista = UsuariosBLL.Getlista();
            DatosdataGridView.DataSource = lista;
            textBox1.Text = DatosdataGridView.Rows.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImprimirRegistroUsuarios i = new ImprimirRegistroUsuarios();
            i.Show();
        }

        private void FiltrotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ListaSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListaSeleccion.SelectedIndex==0)
            {
                IngreseNombreL.Visible = false;
                VerNombre.Visible = false;
                FehaInicial.Visible = false;
                FechaFinal.Visible = false;
                FDesdedateTimePicker.Visible = false;
                FHastadateTimePicker.Visible = false;

                IngreseIdL.Visible = true;
                VerId.Visible = true;

            }

            if (ListaSeleccion.SelectedIndex==1)
            {
                IngreseIdL.Visible = false;
                VerId.Visible = false;
                FehaInicial.Visible = false;
                FechaFinal.Visible = false;
                FDesdedateTimePicker.Visible = false;
                FHastadateTimePicker.Visible = false;

                IngreseNombreL.Visible = true;
                VerNombre.Visible = true;
            }

            if (ListaSeleccion.SelectedIndex==2)
            {
                IngreseIdL.Visible = false;
                VerId.Visible = false;
                IngreseNombreL.Visible = false;
                VerNombre.Visible = false;

                FehaInicial.Visible = true;
                FechaFinal.Visible = true;
                FDesdedateTimePicker.Visible = true;
                FHastadateTimePicker.Visible = true;



            }

            if (ListaSeleccion.SelectedIndex==3)
            {
                IngreseIdL.Visible = false;
                VerId.Visible = false;
                IngreseNombreL.Visible = false;
                VerNombre.Visible = false;
                FehaInicial.Visible = false;
                FechaFinal.Visible = false;
                FDesdedateTimePicker.Visible = false;
                FHastadateTimePicker.Visible = false;

            }
        }

        private void VerNombre_TextChanged(object sender, EventArgs e)
        {
            
            //lista = UsuariosBLL.BuscarNombre(VerNombre.Text);
            DatosdataGridView.DataSource = lista;

        }
    }
    }

