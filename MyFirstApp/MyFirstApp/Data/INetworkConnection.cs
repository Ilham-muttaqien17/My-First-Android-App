using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    
    }
}
