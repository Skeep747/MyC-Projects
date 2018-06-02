using System.Net.NetworkInformation;
using System.Text;

namespace WindowsFormsApp2
{
    class Logic
    {
        public string Start_ping(string ip)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            string data = "Hello google!";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(ip, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
                return reply.Address.ToString() + " OK! Roundtrip time " + 
                       reply.RoundtripTime.ToString() + " ms. " + 
                       reply.Options.Ttl.ToString() + " Ttl :)";
            else return "Destination host unreachable :(";
        }
    }
}
