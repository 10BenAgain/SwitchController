
using System.Net.Sockets;

namespace SwitchController.Switch
{
    public class SysbotBase
    {
        public Socket Socket { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public bool IsConnected { get { return Socket.Connected; } }

        public SysbotBase(string address, int port = 6000)
        {
            Address = address;
            Port = port;
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            try
            {
                Socket.Connect(Address, Port);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (Socket.Connected)
                    Socket.Disconnect(true);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
