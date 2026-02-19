using ServicioAutomotriz.Models;

namespace ServicioAutomotriz
{
    public partial class ServiceDialog : Form
    {
        public Service Result { get; private set; } = new();

        public ServiceDialog(Service? service = null)
        {
            InitializeComponent();

            if (service is not null)
            {
                Result = service;
                txtName.Text          = service.Name;
                txtDescription.Text   = service.Description ?? string.Empty;
                txtCost.Text          = service.Cost.ToString();
                txtEstimatedTime.Text = service.EstimatedTime?.ToString() ?? string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "El nombre es obligatorio.");
                return;
            }
            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost < 0)
            {
                errorProvider.SetError(txtCost, "Ingresa un costo válido.");
                return;
            }

            Result.Name          = txtName.Text.Trim();
            Result.Description   = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim();
            Result.Cost          = cost;
            Result.EstimatedTime = int.TryParse(txtEstimatedTime.Text, out int et) ? et : null;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ValidateDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
                e.Handled = true;
        }

        private void ValidateInteger(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
