using Modelos;
using Negocio;
namespace Escritorio
{
    public partial class FormUsuarios : Form
    {
        private List<Usuario>? usuarios;
        public FormUsuarios()
        {
            InitializeComponent();
            //dataGridView1.DataSource = cargarTabla();
        }

        private List<Usuario> cargarTabla()
        {
            usuarios = Usuarios.getAll();
            return usuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormDataUsuarios().ShowDialog();
            button4_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
            new FormDataUsuarios(usuarios[filaSeleccionada]).ShowDialog();
            button4_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
            Usuarios.Delete(usuarios[filaSeleccionada]);
            button4_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cargarTabla();
        }
    }
}
