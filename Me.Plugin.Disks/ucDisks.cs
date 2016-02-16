using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Me.Plugin.Base;
using Me.Plugin.ServiceInterface;

namespace Me.Plugin.Disks
{
    public partial class ucDisks : ucBase,IPlugin
    {
        public ucDisks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Call ucHost method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = base.Host.HostMethod();
        }

        /// <summary>
        /// Read ucHost property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucDisks_Load(object sender, EventArgs e)
        {
            label4.Text = "ucDisks_Load: _Host.Domaine = " +  base.Host.Domain;
        }
    }
}
