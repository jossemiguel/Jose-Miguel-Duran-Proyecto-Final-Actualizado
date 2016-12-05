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

namespace MenuPrincipal.Fomularios_de_Registros.RegistroUsuarios
{
    public partial class VerClientes : Form
    {
        public VerClientes()
        {
            InitializeComponent();
        }
        public List<Personas> lista = new List<Personas>();
        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            
            lista = PersonasBLL.Getlista();
            dataGridView1.DataSource = lista;

        }
    }
}
