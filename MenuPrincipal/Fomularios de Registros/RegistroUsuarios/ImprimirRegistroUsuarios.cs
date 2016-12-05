using Entidades;
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

namespace MenuPrincipal.RegistroUsuarios
{
    public partial class ImprimirRegistroUsuarios : Form
    {
        public ImprimirRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void ImprimirRegistroUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compraventasDbDataSet.RegistroUsuario' table. You can move, or remove it, as needed.
            //this.registroUsuarioTableAdapter.Fill(this.compraventasDbDataSet.RegistroUsuario);
            // TODO: This line of code loads data into the 'compraventasDbDataSet.RegistroUsuario' table. You can move, or remove it, as needed.
            //this.registroUsuarioTableAdapter.Fill(this.compraventasDbDataSet.RegistroUsuario);
            

            this.UsuariosBindingSource.Add(UsuariosBLL.Getlista());
        }

        private void UsuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
