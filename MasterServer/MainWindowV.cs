using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MasterServer
{
    internal class MainWindowV
    {
        Socket? mainSock = null;

        public MainWindowV()
        {
            try
            {
                mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
            catch
            {
                mainSock = null;
                return;
            }

            int port = 0000;

            IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, port);

            mainSock.BeginAccept(AcceptCallback, null);
            mainSock.Bind(serverEP);
            mainSock.Listen(10);

        }

        void AcceptCallback(IAsyncResult ar)
        {
            // 클라이언트의 연결 요청을 수락한다.
            Socket client = mainSock.EndAccept(ar);
        }
    }
}
