namespace ServicioAutomotriz
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelSidebar    = new Panel();
            panelLogo       = new Panel();
            lblAppTitle     = new Label();
            lblAppSubtitle  = new Label();
            panelNav        = new Panel();
            btnServices     = new Button();
            btnReplacements = new Button();
            panelBottom     = new Panel();
            btnExit         = new Button();
            panelContent    = new Panel();
            panelHeader     = new Panel();
            lblHeader       = new Label();

            // Sidebar
            panelSidebar.BackColor = Color.FromArgb(13, 17, 23);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Width = 200;
            panelSidebar.Controls.Add(panelNav);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Controls.Add(panelBottom);

            panelLogo.BackColor = Color.FromArgb(22, 27, 34);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Height = 100;
            panelLogo.Controls.Add(lblAppSubtitle);
            panelLogo.Controls.Add(lblAppTitle);

            lblAppTitle.Text = "AutoRepair";
            lblAppTitle.Font = new Font("Segoe UI", 17f, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.FromArgb(88, 166, 255);
            lblAppTitle.AutoSize = false;
            lblAppTitle.TextAlign = ContentAlignment.BottomCenter;
            lblAppTitle.Size = new Size(200, 58);
            lblAppTitle.Location = new Point(0, 14);

            lblAppSubtitle.Text = "Sistema de Gestión";
            lblAppSubtitle.Font = new Font("Segoe UI", 8f);
            lblAppSubtitle.ForeColor = Color.FromArgb(139, 148, 158);
            lblAppSubtitle.AutoSize = false;
            lblAppSubtitle.TextAlign = ContentAlignment.TopCenter;
            lblAppSubtitle.Size = new Size(200, 20);
            lblAppSubtitle.Location = new Point(0, 74);

            panelNav.BackColor = Color.Transparent;
            panelNav.Dock = DockStyle.Top;
            panelNav.Height = 280;
            panelNav.Controls.Add(btnReplacements);
            panelNav.Controls.Add(btnServices);

            StyleNavButton(btnServices,     "Servicios",   10);
            StyleNavButton(btnReplacements, "Refacciones", 62);
            btnServices.Click     += btnServices_Click;
            btnReplacements.Click += btnReplacements_Click;

            panelBottom.BackColor = Color.FromArgb(22, 27, 34);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Height = 55;
            panelBottom.Controls.Add(btnExit);

            btnExit.Text = "Salir";
            btnExit.Font = new Font("Segoe UI", 10f);
            btnExit.ForeColor = Color.FromArgb(218, 54, 51);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 20, 20);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Size = new Size(200, 55);
            btnExit.Location = new Point(0, 0);
            btnExit.TextAlign = ContentAlignment.MiddleCenter;
            btnExit.Click += btnExit_Click;

            // Header
            panelHeader.BackColor = Color.FromArgb(22, 27, 34);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 48;
            panelHeader.Controls.Add(lblHeader);

            lblHeader.Text = "Sistema de Servicio Automotriz";
            lblHeader.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(88, 166, 255);
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // Content
            panelContent.BackColor = Color.FromArgb(13, 17, 23);
            panelContent.Dock = DockStyle.Fill;

            SuspendLayout();
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 780);
            MinimumSize = new Size(1000, 620);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoRepair — Sistema de Servicio Automotriz";
            BackColor = Color.FromArgb(13, 17, 23);
            ResumeLayout(false);
        }

        private static void StyleNavButton(Button btn, string text, int top)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10.5f);
            btn.ForeColor = Color.FromArgb(139, 148, 158);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 50);
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(200, 48);
            btn.Location = new Point(0, top);
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private Panel panelSidebar, panelLogo, panelNav, panelBottom, panelContent, panelHeader;
        private Label lblAppTitle, lblAppSubtitle, lblHeader;
        private Button btnServices, btnReplacements, btnExit;
    }
}
