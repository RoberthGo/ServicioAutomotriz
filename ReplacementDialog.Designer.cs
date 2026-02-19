namespace ServicioAutomotriz
{
    partial class ReplacementDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components      = new System.ComponentModel.Container();
            panelHeader     = new Panel();
            lblHeader       = new Label();
            panelBody       = new Panel();
            lblName         = new Label();
            txtName         = new TextBox();
            lblBrand        = new Label();
            txtBrand        = new TextBox();
            lblUnitPrice    = new Label();
            txtUnitPrice    = new TextBox();
            lblCurrentStock = new Label();
            txtCurrentStock = new TextBox();
            lblMinimumStock = new Label();
            txtMinimumStock = new TextBox();
            lblSupplier     = new Label();
            txtSupplier     = new TextBox();
            btnSave         = new Button();
            btnCancel       = new Button();
            errorProvider   = new ErrorProvider(components);

            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(22, 27, 34);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 56;
            panelHeader.Name = "panelHeader";
            panelHeader.TabIndex = 1;

            // lblHeader
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(88, 166, 255);
            lblHeader.Name = "lblHeader";
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Datos de la Refacción";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // panelBody
            panelBody.BackColor = Color.FromArgb(13, 17, 23);
            panelBody.Controls.Add(btnCancel);
            panelBody.Controls.Add(btnSave);
            panelBody.Controls.Add(txtSupplier);
            panelBody.Controls.Add(lblSupplier);
            panelBody.Controls.Add(txtMinimumStock);
            panelBody.Controls.Add(lblMinimumStock);
            panelBody.Controls.Add(txtCurrentStock);
            panelBody.Controls.Add(lblCurrentStock);
            panelBody.Controls.Add(txtUnitPrice);
            panelBody.Controls.Add(lblUnitPrice);
            panelBody.Controls.Add(txtBrand);
            panelBody.Controls.Add(lblBrand);
            panelBody.Controls.Add(txtName);
            panelBody.Controls.Add(lblName);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Name = "panelBody";
            panelBody.TabIndex = 0;

            // lblName
            lblName.AutoSize = false;
            lblName.Font = new Font("Segoe UI", 8.5F);
            lblName.ForeColor = Color.FromArgb(139, 148, 158);
            lblName.Location = new Point(30, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(360, 18);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre *";

            // txtName
            txtName.BackColor = Color.FromArgb(22, 27, 34);
            txtName.ForeColor = Color.FromArgb(230, 237, 243);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(30, 42);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 30);
            txtName.TabIndex = 1;

            // lblBrand
            lblBrand.AutoSize = false;
            lblBrand.Font = new Font("Segoe UI", 8.5F);
            lblBrand.ForeColor = Color.FromArgb(139, 148, 158);
            lblBrand.Location = new Point(30, 90);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(360, 18);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Marca *";

            // txtBrand
            txtBrand.BackColor = Color.FromArgb(22, 27, 34);
            txtBrand.ForeColor = Color.FromArgb(230, 237, 243);
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Font = new Font("Segoe UI", 11F);
            txtBrand.Location = new Point(30, 110);
            txtBrand.MaxLength = 50;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(360, 30);
            txtBrand.TabIndex = 3;

            // lblUnitPrice
            lblUnitPrice.AutoSize = false;
            lblUnitPrice.Font = new Font("Segoe UI", 8.5F);
            lblUnitPrice.ForeColor = Color.FromArgb(139, 148, 158);
            lblUnitPrice.Location = new Point(30, 158);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(360, 18);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Precio unitario ($) *";

            // txtUnitPrice
            txtUnitPrice.BackColor = Color.FromArgb(22, 27, 34);
            txtUnitPrice.ForeColor = Color.FromArgb(230, 237, 243);
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Segoe UI", 11F);
            txtUnitPrice.Location = new Point(30, 178);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(360, 30);
            txtUnitPrice.TabIndex = 5;
            txtUnitPrice.KeyPress += ValidateDecimal;

            // lblCurrentStock
            lblCurrentStock.AutoSize = false;
            lblCurrentStock.Font = new Font("Segoe UI", 8.5F);
            lblCurrentStock.ForeColor = Color.FromArgb(139, 148, 158);
            lblCurrentStock.Location = new Point(30, 226);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(360, 18);
            lblCurrentStock.TabIndex = 6;
            lblCurrentStock.Text = "Stock actual";

            // txtCurrentStock
            txtCurrentStock.BackColor = Color.FromArgb(22, 27, 34);
            txtCurrentStock.ForeColor = Color.FromArgb(230, 237, 243);
            txtCurrentStock.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentStock.Font = new Font("Segoe UI", 11F);
            txtCurrentStock.Location = new Point(30, 246);
            txtCurrentStock.Name = "txtCurrentStock";
            txtCurrentStock.Size = new Size(360, 30);
            txtCurrentStock.TabIndex = 7;
            txtCurrentStock.KeyPress += ValidateInteger;

            // lblMinimumStock
            lblMinimumStock.AutoSize = false;
            lblMinimumStock.Font = new Font("Segoe UI", 8.5F);
            lblMinimumStock.ForeColor = Color.FromArgb(139, 148, 158);
            lblMinimumStock.Location = new Point(30, 294);
            lblMinimumStock.Name = "lblMinimumStock";
            lblMinimumStock.Size = new Size(360, 18);
            lblMinimumStock.TabIndex = 8;
            lblMinimumStock.Text = "Stock mínimo";

            // txtMinimumStock
            txtMinimumStock.BackColor = Color.FromArgb(22, 27, 34);
            txtMinimumStock.ForeColor = Color.FromArgb(230, 237, 243);
            txtMinimumStock.BorderStyle = BorderStyle.FixedSingle;
            txtMinimumStock.Font = new Font("Segoe UI", 11F);
            txtMinimumStock.Location = new Point(30, 314);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.Size = new Size(360, 30);
            txtMinimumStock.TabIndex = 9;
            txtMinimumStock.KeyPress += ValidateInteger;

            // lblSupplier
            lblSupplier.AutoSize = false;
            lblSupplier.Font = new Font("Segoe UI", 8.5F);
            lblSupplier.ForeColor = Color.FromArgb(139, 148, 158);
            lblSupplier.Location = new Point(30, 362);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(360, 18);
            lblSupplier.TabIndex = 10;
            lblSupplier.Text = "Proveedor";

            // txtSupplier
            txtSupplier.BackColor = Color.FromArgb(22, 27, 34);
            txtSupplier.ForeColor = Color.FromArgb(230, 237, 243);
            txtSupplier.BorderStyle = BorderStyle.FixedSingle;
            txtSupplier.Font = new Font("Segoe UI", 11F);
            txtSupplier.Location = new Point(30, 382);
            txtSupplier.MaxLength = 100;
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(360, 30);
            txtSupplier.TabIndex = 11;

            // btnSave
            btnSave.BackColor = Color.FromArgb(88, 166, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(13, 17, 23);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(30, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.BackColor = Color.FromArgb(48, 54, 61);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(230, 237, 243);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(164, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // errorProvider
            errorProvider.ContainerControl = this;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // ReplacementDialog
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(440, 548);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReplacementDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Refacción";
            AcceptButton = btnSave;
            CancelButton = btnCancel;

            panelHeader.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        private Panel panelHeader, panelBody;
        private Label lblHeader, lblName, lblBrand, lblUnitPrice, lblCurrentStock, lblMinimumStock, lblSupplier;
        private TextBox txtName, txtBrand, txtUnitPrice, txtCurrentStock, txtMinimumStock, txtSupplier;
        private Button btnSave, btnCancel;
        private ErrorProvider errorProvider;
    }
}
