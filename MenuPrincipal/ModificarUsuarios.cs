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



        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool validar = true; ;

            if (validar)
            {
                validar = true;
                UsuariosBLL.Modificar(new Usuarios()
                {
                    UsuarioId = Convert.ToInt32(txtMId.Text),
                    NombreUsurio = txtMnombre.Text,
                    Contraseña = txtMcontrasena.Text,
                    ConfirmeContraseña = txtMcontrasena.Text,
                    TipoUsuario = txtMtipo.Text,
                    lista = UsuariosBLL.GetLista(),



                });

                DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
                if (dialogo == DialogResult.OK)
                {
                    this.Close();
                    lista = UsuariosBLL.GetLista();
                    
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
    }
}
