using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuebleríaU
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            entUsuario obj = negUsuario.Login(txtNombreUsuario.Text, txtContrasenna.Text);
            if (obj!=null)
            {
                PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
                paginaPrincipal.Visible = true;
                this.Dispose(false);
            }
            MessageBox.Show("El usuario no está registrado"); 
        }
    }
}
