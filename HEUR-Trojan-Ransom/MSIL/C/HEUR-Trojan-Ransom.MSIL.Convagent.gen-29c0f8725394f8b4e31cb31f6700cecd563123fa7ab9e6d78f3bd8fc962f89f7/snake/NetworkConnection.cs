using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace snake;

public class NetworkConnection : Form
{
	private delegate void packetReceiveDelegate(string TextToDisplay);

	public Socket sock;

	public Thread receiver;

	private IPEndPoint multiep = new IPEndPoint(IPAddress.Any, 9050);

	public string xml;

	private string AddressReceiver;

	private string AddressSender;

	private EventWaitHandle EventStopThreadPlease;

	private void packetReceive(string TextToDisplay)
	{
		xml = TextToDisplay;
	}

	private void ThreadCounterEntryPoint()
	{
		EndPoint remoteEP = multiep;
		byte[] array = new byte[4096];
		while (!EventStopThreadPlease.WaitOne(0))
		{
			array = new byte[4096];
			int count = sock.ReceiveFrom(array, ref remoteEP);
			packetReceive(Encoding.UTF8.GetString(array, 0, count));
		}
	}

	public NetworkConnection(string AddressIPSender, string AddressIPReceiver)
	{
		AddressReceiver = AddressIPReceiver;
		AddressSender = AddressIPSender;
		if (sock == null || !sock.IsBound)
		{
			sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 9050);
			sock.Bind(localEP);
		}
		sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse(AddressReceiver)));
		xml = "";
		EventStopThreadPlease = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
		receiver = new Thread(ThreadCounterEntryPoint);
		receiver.IsBackground = true;
		receiver.Start();
	}

	public void sendInfo(string info)
	{
		sock.SendTo(Encoding.UTF8.GetBytes(info), info.Length, SocketFlags.None, new IPEndPoint(IPAddress.Parse(AddressSender), 9050));
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		EventStopThreadPlease.Set();
		receiver.Join();
	}
}
