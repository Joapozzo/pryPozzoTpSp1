using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPozzoEj2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtContaseña.Text != "") 
            {
                lstModulo.Enabled = true;
            }
            else
            {
                lstModulo.Enabled = false;
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtNum1.Text) > Convert.ToInt32(txtNum2.Text))
            {
                MessageBox.Show("Es mayor");
            }

            if (Convert.ToInt32(txtNum2.Text) > Convert.ToInt32(txtNum1.Text))
            {
                MessageBox.Show("Es menor");
            }
            if (Convert.ToInt32(txtNum1.Text) == Convert.ToInt32(txtNum2.Text))
            {
                MessageBox.Show("Es igual");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContaseña.Enabled = true;

            }
            else
            {
                txtContaseña.Enabled = false;
            }
        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContaseña.Text == "@1a" && (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA"))
                
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }
            else
            {
                if (txtUsuario.Text == "John" && txtContaseña.Text == "*2b" && lstModulo.Text == "SIST")
                {
                    this.Hide();
                    frmMain frmMain = new frmMain();
                    frmMain.ShowDialog();
                }
                else
                {
                    if (txtUsuario.Text == "Ceci" && txtContaseña.Text == "@3c" && (lstModulo.Text == "ADM" || lstModulo.Text == "VTA"))
                    {
                        this.Hide();
                        frmMain frmMain = new frmMain();
                        frmMain.ShowDialog();
                    }
                    else
                    {
                       if (txtUsuario.Text == "God" && txtContaseña.Text == "@#4d" && (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA" || lstModulo.Text == "SIST"))
                        {
                            this.Hide();
                            frmMain frmMain = new frmMain();
                            frmMain.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Acceso Denegado");
                            intentos++;
                            if(intentos == 2)
                            {
                                this.Close();
                            }

                        }        
                    }
                }



            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
