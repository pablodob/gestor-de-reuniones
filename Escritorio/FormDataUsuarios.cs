using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escritorio
{
    public partial class FormDataUsuarios : Form
    {
        public FormDataUsuarios()
        {
            InitializeComponent();
        }

        public FormDataUsuarios(Usuario usuarioAModificar)
        {
            InitializeComponent();
            button1.Text = "Editar";
            textBox1.Text = usuarioAModificar.Nombre;
            textBox2.Text = usuarioAModificar.NombreUsuario;
            label4.Text = Convert.ToString(usuarioAModificar.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.NombreUsuario = textBox1.Text;
            u.Nombre = textBox2.Text;
            u.Id = 5;
            Console.WriteLine(u);
            Console.WriteLine(u.Nombre);
            if (button1.Text == "Editar")
                Usuarios.Update(u);
            else Usuarios.Add(u);
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
