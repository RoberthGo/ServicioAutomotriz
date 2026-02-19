namespace ServicioAutomotriz
{
    partial class ServicesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop         = new Panel();
            lblTitle         = new Label();
            panelToolbar     = new Panel();
            btnAdd           = new Button();
            btnEdit          = new Button();
            btnDelete        = new Button();
            panelGrid        = new Panel();
            dgvServices      = new DataGridView();
            colID            = new DataGridViewTextBoxColumn();
            colName          = new DataGridViewTextBoxColumn();
            colDescription   = new DataGridViewTextBoxColumn();
            colCost          = new DataGridViewTextBoxColumn();
            colEstimatedTime = new DataGridViewTextBoxColumn();
            lblGrid          = new Label();

            panelTop.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = Color.FromArgb(22, 27, 34);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 56;
            panelTop.Name = "panelTop";
            panelTop.TabIndex = 2;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 237, 243);
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Servicios";

            // panelToolbar
            panelToolbar.BackColor = Color.FromArgb(28, 35, 51);
            panelToolbar.Controls.Add(btnDelete);
            panelToolbar.Controls.Add(btnEdit);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Height = 52;
            panelToolbar.Name = "panelToolbar";
            panelToolbar.TabIndex = 1;

            // btnAdd
            btnAdd.BackColor = Color.FromArgb(88, 166, 255);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(13, 17, 23);
            btnAdd.Location = new Point(14, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // btnEdit
            btnEdit.BackColor = Color.FromArgb(35, 134, 54);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(126, 9);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Modificar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;

            // btnDelete
            btnDelete.BackColor = Color.FromArgb(218, 54, 51);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(238, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // panelGrid
            panelGrid.BackColor = Color.FromArgb(22, 27, 34);
            panelGrid.Controls.Add(dgvServices);
            panelGrid.Controls.Add(lblGrid);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 10, 16, 16);
            panelGrid.TabIndex = 0;

            // lblGrid
            lblGrid.Dock = DockStyle.Top;
            lblGrid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGrid.ForeColor = Color.FromArgb(88, 166, 255);
            lblGrid.Height = 28;
            lblGrid.Name = "lblGrid";
            lblGrid.TabIndex = 1;
            lblGrid.Text = "Listado de Servicios";
            lblGrid.TextAlign = ContentAlignment.MiddleLeft;

            // dgvServices
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.BackgroundColor = Color.FromArgb(22, 27, 34);
            dgvServices.BorderStyle = BorderStyle.None;
            dgvServices.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colDescription, colCost, colEstimatedTime });
            dgvServices.Dock = DockStyle.Fill;
            dgvServices.Font = new Font("Segoe UI", 10F);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowTemplate.Height = 34;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.TabIndex = 0;

            // columns
            colID.FillWeight = 40F;            colID.HeaderText = "ID";           colID.Name = "colID";           colID.ReadOnly = true;
            colName.HeaderText = "Nombre";     colName.Name = "colName";          colName.ReadOnly = true;
            colDescription.HeaderText = "Descripción"; colDescription.Name = "colDescription"; colDescription.ReadOnly = true;
            colCost.FillWeight = 70F;          colCost.HeaderText = "Costo ($)";  colCost.Name = "colCost";       colCost.ReadOnly = true;
            colEstimatedTime.FillWeight = 70F; colEstimatedTime.HeaderText = "Tiempo (min)"; colEstimatedTime.Name = "colEstimatedTime"; colEstimatedTime.ReadOnly = true;

            // ServicesForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            Controls.Add(panelGrid);
            Controls.Add(panelToolbar);
            Controls.Add(panelTop);
            Name = "ServicesForm";

            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        private Panel panelTop, panelToolbar, panelGrid;
        private Label lblTitle, lblGrid;
        private DataGridView dgvServices;
        private Button btnAdd, btnEdit, btnDelete;
        private DataGridViewTextBoxColumn colID, colName, colDescription, colCost, colEstimatedTime;
    }
}
