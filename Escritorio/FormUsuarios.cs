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
            dataGridView1.DataSource = cargarTabla();
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
            int filaSeleccionada;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    filaSeleccionada = dataGridView1.SelectedCells[0].RowIndex;
                }
                else
                {
                    return;
                }
            }
            else
            {
                filaSeleccionada = dataGridView1.SelectedRows[0].Index;
            }
            if (usuarios != null) {
                new FormDataUsuarios(usuarios[filaSeleccionada]).ShowDialog();
            }
            button4_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int filaSeleccionada;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    filaSeleccionada = dataGridView1.SelectedCells[0].RowIndex;
                }
                else
                {
                    return;
                }
            }
            else
            {
                filaSeleccionada = dataGridView1.SelectedRows[0].Index;
            }
            if (usuarios != null)
            {
                Usuarios.Delete(usuarios[filaSeleccionada]);
            }
                button4_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cargarTabla();
        }

    }
}
