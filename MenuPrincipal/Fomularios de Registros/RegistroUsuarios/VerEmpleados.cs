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
using Entidades;

namespace MenuPrincipal.Fomularios_de_Registros.RegistroUsuarios
{
    public partial class VerEmpleados : Form
    {
        public VerEmpleados()
        {
            InitializeComponent();
        }
        public List<Entidades.Empleados> lista = new List<Entidades.Empleados>();
        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            lista = EmpleadosBLL.Getlista();
            dataGridView1.DataSource = lista;
        }
    }
}
