using ServicioAutomotriz.Models;

namespace ServicioAutomotriz
{
    public partial class ReplacementDialog : Form
    {
        public Replacement Result { get; private set; } = new();

        // Si se recibe una refacción existente, precarga los campos para edición
        public ReplacementDialog(Replacement? replacement = null)
        {
            InitializeComponent();

            if (replacement is not null)
            {
                Result = replacement;
                txtName.Text         = replacement.Name;
                txtBrand.Text        = replacement.Brand;
                txtUnitPrice.Text    = replacement.UnitPrice.ToString();
                txtCurrentStock.Text = replacement.CurrentStock.ToString();
                txtMinimumStock.Text = replacement.MinimumStock.ToString();
                txtSupplier.Text     = replacement.Supplier ?? string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // Valida que los campos obligatorios y el precio sean correctos
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "El nombre es obligatorio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                errorProvider.SetError(txtBrand, "La marca es obligatoria.");
                return;
            }
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0)
            {
                errorProvider.SetError(txtUnitPrice, "Ingresa un precio válido.");
                return;
            }

            // Asigna los valores validados al resultado
            Result.Name         = txtName.Text.Trim();
            Result.Brand        = txtBrand.Text.Trim();
            Result.UnitPrice    = price;
            Result.CurrentStock = int.TryParse(txtCurrentStock.Text, out int cs) ? cs : 0;
            Result.MinimumStock = int.TryParse(txtMinimumStock.Text, out int ms) ? ms : 0;
            Result.Supplier     = string.IsNullOrWhiteSpace(txtSupplier.Text) ? null : txtSupplier.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Permite solo dígitos y un único punto decimal
        private void ValidateDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
                e.Handled = true;
        }

        // Permite solo dígitos enteros
        private void ValidateInteger(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
