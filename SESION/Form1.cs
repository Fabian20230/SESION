using SESION.SESION_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SESION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int intentos = 3;
            string u = usuario.Text;
            string c = contraseña.Text;
            if (u.ToLower() == "pedro" && c.ToLower() == "enter")
            { 
                BIENVENIDA si = new BIENVENIDA();
                this.Hide();
                si.Show();

            }else 
            {
                intentos--;
                usuario.Clear();
                contraseña.Clear();
                MessageBox.Show("Usuaio o Contraseña incorrecta");
                if (intentos <= 0)
                {
                    button1.Enabled = false;
                    //MessageBox.Show("Ya perdiste, demasiados intentos");
                    //Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario.Clear();
            contraseña.Clear();
           Application.Exit();  
        }
    }
}
