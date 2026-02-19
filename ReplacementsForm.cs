namespace ServicioAutomotriz
{
    public partial class ReplacementsForm : Form
    {
        private readonly Color _accent  = Color.FromArgb(88, 166, 255);
        private readonly Color _rowAlt  = Color.FromArgb(28, 35, 51);
        private readonly Color _rowBase = Color.FromArgb(22, 27, 34);
        private readonly Color _dark   = Color.FromArgb(18, 42, 76);

        public ReplacementsForm()
        {
            InitializeComponent();
            ApplyGridStyle();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dlg = new ReplacementDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReplacements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una refacción para modificar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using var dlg = new ReplacementDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { }
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
            if (result == DialogResult.Yes) { }
        }
    }
}
