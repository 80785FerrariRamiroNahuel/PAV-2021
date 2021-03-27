using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba.Business;
using Prueba.Entities;

namespace Prueba
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = TxtUser.Text;
            string Password = TxtPass.Text;
            UsuarioEnt usu = new UsuarioEnt(Usuario, Password);
            if (Usuario.Equals("") || Password.Equals(""))
            {
                MessageBox.Show("Ingrese un Usuario o Contraseña");
                TxtUser.Focus();


            }
            else if (Usuario.Equals("Ramiro") && Password.Equals("123"))
            {
                MessageBox.Show("Correcto");
                FrmPrincipal ventana = new FrmPrincipal();
                ventana.Show();
                this.Hide();


            }


            else
            {
                MessageBox.Show("Ingrese una credencial correcta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUser.Focus();
            }

        }
    }
}
