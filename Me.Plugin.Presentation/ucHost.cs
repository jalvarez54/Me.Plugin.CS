using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Me.Plugin.ServiceInterface;
using System.IO;

namespace Me.Plugin.Presentation
{
    public partial class ucHost : UserControl,IHost
    {
        public ucHost()
        {
            InitializeComponent();
        }

        private const string INTERFACE_PLUGIN = "Me.Plugin.ServiceInterface.IPlugin";
        private ServicesPlugin.PluginPresent[] _plugins;

        private void ucHome_Load(System.Object sender, System.EventArgs e)
        {
            this.GetPlugins();
            this.LoadPlugins();

        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            MessageBox.Show("ucHost button");

        }

        #region IHost properties
        public string SnmpCommunity
        {
            get { return TextBoxCommunauteSnmp.Text; }

            set { }
        }

        public string Domain
        {

            get { return TextBoxDomaine.Text; }

            set { }
        }

        public string PassWord
        {

            get { return TextBoxMotDePasse.Text; }

            set { }
        }

        public string MachineName
        {

            get { return TextBoxMachine.Text; }

            set { }
        }
        public string UserName
        {
            get { return TextBoxUtilisateur.Text; }

            set { }
        }

        #endregion

        public string HostMethod()
        {
            return "Method on Host control";
        }


        private void GetPlugins()
        {
            // Récupérer la liste des plugins.
            _plugins = ServicesPlugin.GetPlugins(Path.GetDirectoryName(Application.ExecutablePath), INTERFACE_PLUGIN);
            if (_plugins == null)
            {
                MessageBox.Show("No plugin found !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        }

        private void LoadPlugins()
        {
            IPlugin plugin = default(IPlugin);
            TabPage tabPage = default(TabPage);

            // Create plugins instances and tabs.
            for (int index = 0; index <= _plugins.Length - 1; index++)
            {
                plugin = (IPlugin)ServicesPlugin.CreatePluginInstance(_plugins[index]);

                // Pass ucHost handle to each uc
                plugin.Initialisation(this);

                tabPage = new TabPage();
                TabControlGestion.TabPages.Add(tabPage);
                tabPage.Text = plugin.NomPlugin;
                tabPage.Controls.Add((Control)plugin);
            }

        }
    }
}
