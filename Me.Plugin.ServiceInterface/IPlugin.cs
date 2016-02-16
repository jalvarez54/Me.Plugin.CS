using System;
using System.Collections.Generic;
using System.Text;

namespace Me.Plugin.ServiceInterface
{
    public interface IPlugin
    {
        string NomPlugin { get; }
        void Initialisation(IHost host);
    }
}
