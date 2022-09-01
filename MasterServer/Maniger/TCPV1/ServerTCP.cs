using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // 추가
using System.Net; // 추가
using System.Net.Sockets; // 추가
using System.IO; // 추가
using System.Windows.Media.Animation;
using System.ComponentModel;

namespace MasterServer.Maniger.TCPV1
{
    internal class ServerTCP
    {
        Object locker = new object();
        string cilentIP;
        int cilentPort;
        CancellationTokenSource communicationCheck;

        TcpListener tcpListener;

        Task<bool> setCilent;

        public ServerTCP(string _cilentIP, int _cilentPort, CancellationTokenSource _communicationCheck)
        {
            cilentIP = _cilentIP;
            cilentPort = _cilentPort;
            communicationCheck = _communicationCheck;
        }


        internal bool SetTCP()
        {
            try
            {
                TcpListener _tcpListener = new TcpListener(IPAddress.Parse(cilentIP), cilentPort);

            }
            catch
            {
                Console.WriteLine("Failed TCP Setup");
                return false;
            }
            return true;
        }
        internal async Task<bool> SetTCPTask()
        {
            this.setCilent = Task.Run(() => this.SetTCP(this.communicationCheck.Token));
            await this.setCilent;
            return this.setCilent.Result;
        }
        private bool SetTCP(CancellationToken cancellationToken)
        {
            try
            {
                TcpListener _tcpListener = new TcpListener(IPAddress.Parse(cilentIP), cilentPort);
            }
            catch
            {
                Console.WriteLine("Failed TCP Setup");
                return false;
            }
            return true;
        }

    }
}
