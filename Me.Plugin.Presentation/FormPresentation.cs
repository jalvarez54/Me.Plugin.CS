using System.Windows.Forms;

namespace Me.Plugin.Presentation
{
    public partial class FormPluginPresentation : Form
    {
        public FormPluginPresentation()
        {
            InitializeComponent();
        }

        internal ucHost _ucHome;

        private void FormPluginPresentation_Load(System.Object sender, System.EventArgs e)
        {
            //
            // Creation of controls to be added to the window.
            //
            this._ucHome = new ucHost();
            //
            // _UcHome
            //
            this._ucHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucHome.Location = new System.Drawing.Point(0, 0);
            this._ucHome.Name = "_UcHome";
            // Adapting the window size to the dimensions _UcHome.
            this.Width = this._ucHome.Width + 20;
            this.Height = this._ucHome.Height + 60;
            // Adding controls.
            this.Controls.Add(this._ucHome);

        }
    }
}
