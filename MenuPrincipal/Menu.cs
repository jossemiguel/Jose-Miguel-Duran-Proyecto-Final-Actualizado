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

namespace MenuPrincipal
{
    public partial class Menu : Form
    {
        LoginUsuario.Login l = new LoginUsuario.Login();
        public Menu()
        {
             InitializeComponent();

            timer1.Enabled = true;
            //Mostrar.Text = l.txtUsuario.Text;

        }
        
        
        private void button5_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MenuPrincipal.RegistroUsuario.ControlUsuarios user = new MenuPrincipal.RegistroUsuario.ControlUsuarios();
            user.Show();
            this.Hide();
            
          
        }

        private void btnUsuario_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnUsuario_MouseLeave(object sender, EventArgs e)
        {
                    }

        private void btnCompras_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVentas_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnEmpeños_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnEmpeños_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Deseas salir del Sistema?", "Saliendo del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo==DialogResult.Yes)
            {
                this.Close();
               MenuPrincipal.LoginUsuario.Login log = new MenuPrincipal.LoginUsuario.Login();
                log.Close();
               

            }

            else
                return;
           
        }

       

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compra.MenuCompras compra = new Compra.MenuCompras();
            compra.Visible = true;
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Menu m = new MenuPrincipal.Menu();
            m.Hide();
            //this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }
      

        private void label12_Click_1(object sender, EventArgs e)
        {
            //Mostrar.Text = l.txtUsuario.Text;
           
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            MenuPrincipal.Ventas.RegistroUsuarios.RegistroPersonas p = new Ventas.RegistroUsuarios.RegistroPersonas();
            p.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal.Ventas.RegistroUsuarios.RegistroPersonas p = new Ventas.RegistroUsuarios.RegistroPersonas();
            p.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal.RegistroUsuario.ControlUsuarios user = new MenuPrincipal.RegistroUsuario.ControlUsuarios();
            user.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra.RegistroCompras r = new Compra.RegistroCompras();
            r.Visible = true;

            
        }

        private void btnEmpeños_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Deseas salir del Sistema?", "Saliendo del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                this.Close();
                MenuPrincipal.LoginUsuario.Login log = new MenuPrincipal.LoginUsuario.Login();
                log.Close();


            }

            else
                return;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            RegistroUsuarios.VerUsuarios1 ver = new RegistroUsuarios.VerUsuarios1();
            ver.Show();
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Ventas.RegistroUsuarios.RegistroEmpleados Em = new Ventas.RegistroUsuarios.RegistroEmpleados();
            Em.Show();
        }

        private void artuculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal.Ventas.RegistroUsuarios.RegistroVentas v = new Ventas.RegistroUsuarios.RegistroVentas();
            v.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.Compra.BucarCompras c = new Compra.BucarCompras();
            
            c.Visible = true;
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fomularios_de_Registros.RegistroUsuarios.VerEmpleados ver = new Fomularios_de_Registros.RegistroUsuarios.VerEmpleados();
            ver.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.Fomularios_de_Registros.RegistroUsuarios.VerClientes ver = new Fomularios_de_Registros.RegistroUsuarios.VerClientes();
            ver.Show();
        }
    }
}
