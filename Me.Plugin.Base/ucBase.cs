using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Me.Plugin.ServiceInterface;

namespace Me.Plugin.Base
{
    public partial class ucBase : UserControl,IPlugin
    {
        public ucBase()
        {
            InitializeComponent();
        }
        private IHost _Host;

        public void Initialisation(IHost host)
        {
            this._Host = host;
        }

        public string NomPlugin
        {
            get { return this.Name; }
        }

        protected IHost Host
        {
            get
            {
                return _Host;
            }

            set
            {
                _Host = value;
            }
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            Label2.Text = this._Host.MachineName;
        }
    }
}
