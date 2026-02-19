using System.Drawing.Drawing2D;

namespace ServicioAutomotriz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServicesForm());
        }

        private void btnReplacements_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReplacementsForm());
        }

        private void OpenChildForm(Form child)
        {
            foreach (Control c in panelContent.Controls)
                c.Dispose();
            panelContent.Controls.Clear();

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelContent.Controls.Add(child);
            child.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
