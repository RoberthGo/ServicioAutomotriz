namespace ServicioAutomotriz
{
    partial class ServiceDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components       = new System.ComponentModel.Container();
            panelHeader      = new Panel();
            lblHeader        = new Label();
            panelBody        = new Panel();
            lblName          = new Label();
            txtName          = new TextBox();
            lblDescription   = new Label();
            txtDescription   = new TextBox();
            lblCost          = new Label();
            txtCost          = new TextBox();
            lblEstimatedTime = new Label();
            txtEstimatedTime = new TextBox();
            btnSave          = new Button();
            btnCancel        = new Button();
            errorProvider    = new ErrorProvider(components);

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
            lblHeader.Text = "Datos del Servicio";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // panelBody
            panelBody.BackColor = Color.FromArgb(13, 17, 23);
            panelBody.Controls.Add(btnCancel);
            panelBody.Controls.Add(btnSave);
            panelBody.Controls.Add(txtEstimatedTime);
            panelBody.Controls.Add(lblEstimatedTime);
            panelBody.Controls.Add(txtCost);
            panelBody.Controls.Add(lblCost);
            panelBody.Controls.Add(txtDescription);
            panelBody.Controls.Add(lblDescription);
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
            lblName.Size = new Size(320, 18);
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
            txtName.Size = new Size(320, 30);
            txtName.TabIndex = 1;

            // lblDescription
            lblDescription.AutoSize = false;
            lblDescription.Font = new Font("Segoe UI", 8.5F);
            lblDescription.ForeColor = Color.FromArgb(139, 148, 158);
            lblDescription.Location = new Point(30, 92);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(320, 18);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Descripción";

            // txtDescription
            txtDescription.BackColor = Color.FromArgb(22, 27, 34);
            txtDescription.ForeColor = Color.FromArgb(230, 237, 243);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtDescription.Location = new Point(30, 112);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(320, 76);
            txtDescription.TabIndex = 3;

            // lblCost
            lblCost.AutoSize = false;
            lblCost.Font = new Font("Segoe UI", 8.5F);
            lblCost.ForeColor = Color.FromArgb(139, 148, 158);
            lblCost.Location = new Point(30, 208);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(320, 18);
            lblCost.TabIndex = 4;
            lblCost.Text = "Costo ($) *";

            // txtCost
            txtCost.BackColor = Color.FromArgb(22, 27, 34);
            txtCost.ForeColor = Color.FromArgb(230, 237, 243);
            txtCost.BorderStyle = BorderStyle.FixedSingle;
            txtCost.Font = new Font("Segoe UI", 11F);
            txtCost.Location = new Point(30, 228);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(320, 30);
            txtCost.TabIndex = 5;
            txtCost.KeyPress += ValidateDecimal;

            // lblEstimatedTime
            lblEstimatedTime.AutoSize = false;
            lblEstimatedTime.Font = new Font("Segoe UI", 8.5F);
            lblEstimatedTime.ForeColor = Color.FromArgb(139, 148, 158);
            lblEstimatedTime.Location = new Point(30, 278);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(320, 18);
            lblEstimatedTime.TabIndex = 6;
            lblEstimatedTime.Text = "Tiempo estimado (min)";

            // txtEstimatedTime
            txtEstimatedTime.BackColor = Color.FromArgb(22, 27, 34);
            txtEstimatedTime.ForeColor = Color.FromArgb(230, 237, 243);
            txtEstimatedTime.BorderStyle = BorderStyle.FixedSingle;
            txtEstimatedTime.Font = new Font("Segoe UI", 11F);
            txtEstimatedTime.Location = new Point(30, 298);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.Size = new Size(320, 30);
            txtEstimatedTime.TabIndex = 7;
            txtEstimatedTime.KeyPress += ValidateInteger;

            // btnSave
            btnSave.BackColor = Color.FromArgb(88, 166, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(13, 17, 23);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(30, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 8;
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
            btnCancel.Location = new Point(164, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // errorProvider
            errorProvider.ContainerControl = this;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // ServiceDialog
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(400, 470);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServiceDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Servicio";
            AcceptButton = btnSave;
            CancelButton = btnCancel;

            panelHeader.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        private Panel panelHeader, panelBody;
        private Label lblHeader, lblName, lblDescription, lblCost, lblEstimatedTime;
        private TextBox txtName, txtDescription, txtCost, txtEstimatedTime;
        private Button btnSave, btnCancel;
        private ErrorProvider errorProvider;
    }
}
