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
using DAL;
using BLL;


namespace MenuPrincipal
{
    public partial class ModificarUsuarios : Form
    {
        public ModificarUsuarios()
        {
            InitializeComponent();
        }
        public List<Usuarios> lista = new List<Usuarios>();
        RegistroUsuarios.VerUsuarios1 ver = new RegistroUsuarios.VerUsuarios1();
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ver.DatosdataGridView = new DataGridView();
            
            bool validar = true; ;

            if (validar)
            {
                validar = true;
                UsuariosBLL.Modificar(new Usuarios()
                {
                    UsuarioId = Convert.ToInt32(txtMId.Text),
                    //NombreUsuario = txtMnombre.Text,
                    Contraseña = txtMcontrasena.Text,
                    //ConfirmeContraseña = txtMcontrasena.Text,
                    TipoUsuario = txtMtipo.Text,
                    FechaRegistro=FechaR.Text,
                    List = UsuariosBLL.Getlista(),
                    
                    


            });
                

                DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
                if (dialogo == DialogResult.OK)
                {
                    
                    lista = UsuariosBLL.Getlista();
                    ver.DatosdataGridView.DataSource = lista;
                    
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error");
                }





            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
