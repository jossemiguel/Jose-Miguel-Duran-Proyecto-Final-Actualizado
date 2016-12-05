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
namespace MenuPrincipal.Compra
{
    public partial class BucarCompras : Form
    {
        public BucarCompras()
        {
            InitializeComponent();
        }
        public List<Entidades.Compras> lista = new List<Entidades.Compras>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverBC_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Hide();

        }

        private void btnVolverBC_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Hide();


        }

        private void btnBuscarCompras_Click(object sender, EventArgs e)
        {
            lista = ComprasBLL.GetLista();
            dataGridView1.DataSource = lista;
        }
        
    }
}
