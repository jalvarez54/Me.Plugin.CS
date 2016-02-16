using System;
using System.Collections.Generic;
using System.Text;

namespace Me.Plugin.ServiceInterface
{
    public interface IHost
    {
        string Domain { get; set; }
        string MachineName { get; set; }
        string UserName { get; set; }
        string PassWord { get; set; }
        string SnmpCommunity { get; set; }
        string HostMethod();
    }
}
