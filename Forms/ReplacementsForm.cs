using ServicioAutomotriz.Models;
using ServicioAutomotriz.Services;

namespace ServicioAutomotriz
{
    public partial class ReplacementsForm : Form
    {
        private readonly Color _accent  = Color.FromArgb(88, 166, 255);
        private readonly Color _rowAlt  = Color.FromArgb(28, 35, 51);
        private readonly Color _rowBase = Color.FromArgb(22, 27, 34);
        private readonly Color _dark    = Color.FromArgb(18, 42, 76);

        private readonly ReplacementService _service = new();

        public ReplacementsForm()
        {
            InitializeComponent();
            ApplyGridStyle();
            LoadData();
        }

        private void ApplyGridStyle()
        {
            dgvReplacements.EnableHeadersVisualStyles = false;
            dgvReplacements.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 35, 51);
            dgvReplacements.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(88, 166, 255);
            dgvReplacements.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvReplacements.DefaultCellStyle.BackColor = _rowBase;
            dgvReplacements.DefaultCellStyle.ForeColor = Color.FromArgb(230, 237, 243);
            dgvReplacements.AlternatingRowsDefaultCellStyle.BackColor = _rowAlt;
            dgvReplacements.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(230, 237, 243);
            dgvReplacements.DefaultCellStyle.SelectionBackColor = _accent;
            dgvReplacements.DefaultCellStyle.SelectionForeColor = Color.FromArgb(13, 17, 23);
            dgvReplacements.RowHeadersVisible = false;
            dgvReplacements.GridColor = Color.FromArgb(48, 54, 61);
        }

        private void LoadData()
        {
            try
            {
                var list = _service.GetAll();
                dgvReplacements.DataSource = null;
                dgvReplacements.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar refacciones:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dlg = new ReplacementDialog();
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
            if (dgvReplacements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una refacción para modificar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Replacement)dgvReplacements.SelectedRows[0].DataBoundItem;
            using var dlg = new ReplacementDialog(selected);
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
            if (dgvReplacements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una refacción para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("¿Eliminar la refacción seleccionada?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var selected = (Replacement)dgvReplacements.SelectedRows[0].DataBoundItem;
                try
                {
                    _service.Delete(selected.ReplacementID);
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
