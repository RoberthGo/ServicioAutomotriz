using ServicioAutomotriz.Models;
using ServicioAutomotriz.Services;

namespace ServicioAutomotriz
{
    public partial class ServicesForm : Form
    {
        private readonly Color _accent  = Color.FromArgb(88, 166, 255);
        private readonly Color _rowAlt  = Color.FromArgb(28, 35, 51);
        private readonly Color _rowBase = Color.FromArgb(22, 27, 34);
        private readonly Color _dark    = Color.FromArgb(18, 42, 76);

        private readonly ServiceService _service = new();

        public ServicesForm()
        {
            InitializeComponent();
            ApplyGridStyle();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _service.GetAll();
                dgvServices.DataSource = null;
                dgvServices.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar servicios:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyGridStyle()
        {
            dgvServices.EnableHeadersVisualStyles = false;
            dgvServices.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 35, 51);
            dgvServices.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(88, 166, 255);
            dgvServices.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvServices.DefaultCellStyle.BackColor = _rowBase;
            dgvServices.DefaultCellStyle.ForeColor = Color.FromArgb(230, 237, 243);
            dgvServices.AlternatingRowsDefaultCellStyle.BackColor = _rowAlt;
            dgvServices.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(230, 237, 243);
            dgvServices.DefaultCellStyle.SelectionBackColor = _accent;
            dgvServices.DefaultCellStyle.SelectionForeColor = Color.FromArgb(13, 17, 23);
            dgvServices.RowHeadersVisible = false;
            dgvServices.GridColor = Color.FromArgb(48, 54, 61);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dlg = new ServiceDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _service.Add(dlg.Result);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un servicio para modificar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Service)dgvServices.SelectedRows[0].DataBoundItem;
            using var dlg = new ServiceDialog(selected);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _service.Update(dlg.Result);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un servicio para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("¿Eliminar el servicio seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var selected = (Service)dgvServices.SelectedRows[0].DataBoundItem;
                try
                {
                    _service.Delete(selected.ServiceID);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
