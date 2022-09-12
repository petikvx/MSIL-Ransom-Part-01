using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0;

public sealed class GForm2 : Form
{
	[CompilerGenerated]
	private sealed class Class0
	{
		public GForm2 gform2_0;

		public string string_0;

		internal void method_0()
		{
			gform2_0.gform1_0.method_1(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class1
	{
		public GForm2 gform2_0;

		public string string_0;

		internal void method_0()
		{
			gform2_0.gform1_1.method_1(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public GForm2 gform2_0;

		public string string_0;

		internal void method_0()
		{
			gform2_0.gform1_2.method_1(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class3
	{
		public GForm2 gform2_0;

		public string string_0;

		internal void method_0()
		{
			gform2_0.gform0_0.method_1(string_0);
		}
	}

	private TcpListener tcpListener_0;

	private TcpListener tcpListener_1;

	private TcpListener tcpListener_2;

	private TcpListener tcpListener_3;

	private GForm1 gform1_0;

	private GForm1 gform1_1;

	private GForm1 gform1_2;

	private GForm0 gform0_0;

	private IContainer icontainer_0;

	private Label label_0;

	public GForm2()
	{
		method_17();
		Delegate52.smethod_0(this, bool_0: true);
		Delegate67.smethod_0(label_0, "Elevator Monitoring System - GRAHA BANK BUKOPIN SURABAYA");
		gform1_0 = new GForm1();
		Delegate74.smethod_0(gform1_0, (Form)(object)this);
		Delegate20.smethod_0(gform1_0, 45);
		Delegate33.smethod_0(gform1_0, 60);
		Delegate2.smethod_0(gform1_0);
		gform1_0.method_0("#01");
		gform1_1 = new GForm1();
		Delegate74.smethod_0(gform1_1, (Form)(object)this);
		Delegate20.smethod_0(gform1_1, 345);
		Delegate33.smethod_0(gform1_1, 60);
		Delegate2.smethod_0(gform1_1);
		gform1_1.method_0("#02");
		gform1_2 = new GForm1();
		Delegate74.smethod_0(gform1_2, (Form)(object)this);
		Delegate20.smethod_0(gform1_2, 645);
		Delegate33.smethod_0(gform1_2, 60);
		Delegate2.smethod_0(gform1_2);
		gform1_2.method_0("#03");
		gform0_0 = new GForm0();
		Delegate74.smethod_0(gform0_0, (Form)(object)this);
		Delegate20.smethod_0(gform0_0, 945);
		Delegate33.smethod_0(gform0_0, 60);
		Delegate2.smethod_0(gform0_0);
		gform0_0.method_0("#04");
		method_1(10001);
		method_5(10002);
		method_9(10003);
		method_13(10004);
	}

	private void method_0(object sender, EventArgs e)
	{
		Delegate128.smethod_0(((IEnumerable)Delegate13.smethod_1(this)).OfType<MdiClient>().FirstOrDefault(), Delegate100.smethod_0());
	}

	public void method_1(int int_0)
	{
		tcpListener_0 = Delegate47.smethod_0(IPAddress.Any, int_0);
		Delegate42.smethod_0(tcpListener_0);
		method_2();
	}

	private void method_2()
	{
		Delegate77.smethod_0(tcpListener_0, method_3, null);
	}

	private void method_3(IAsyncResult iasyncResult_0)
	{
		try
		{
			TcpClient tcpClient = Delegate63.smethod_0(tcpListener_0, iasyncResult_0);
			if (tcpClient != null)
			{
				method_4(tcpClient);
			}
		}
		catch
		{
		}
		method_2();
	}

	private void method_4(TcpClient tcpClient_0)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		List<byte> object_ = Delegate27.smethod_0();
		byte[] array = new byte[Delegate85.smethod_0(tcpClient_0)];
		NetworkStream networkStream = Delegate134.smethod_0(tcpClient_0);
		try
		{
			if (Delegate94.smethod_0(networkStream))
			{
				while (true)
				{
					int num = Delegate108.smethod_0(networkStream, array, 0, Delegate85.smethod_0(tcpClient_0));
					if (num <= 0)
					{
						break;
					}
					byte[] array2 = new byte[num];
					Delegate5.smethod_0(array, 0, array2, 0, num);
					Delegate125.smethod_0(object_, array2);
				}
			}
			Delegate116.smethod_0(networkStream);
			Delegate14.smethod_0(tcpClient_0);
		}
		finally
		{
			if (networkStream != null)
			{
				Delegate17.smethod_0(networkStream);
			}
		}
		string string_0 = Delegate36.smethod_0(Delegate129.smethod_0(), Delegate59.smethod_0(object_));
		Delegate55.smethod_0(this, (Delegate)(MethodInvoker)delegate
		{
			gform1_0.method_1(string_0);
		});
	}

	public void method_5(int int_0)
	{
		tcpListener_1 = Delegate47.smethod_0(IPAddress.Any, int_0);
		Delegate42.smethod_0(tcpListener_1);
		method_6();
	}

	private void method_6()
	{
		Delegate77.smethod_0(tcpListener_1, method_7, null);
	}

	private void method_7(IAsyncResult iasyncResult_0)
	{
		try
		{
			TcpClient tcpClient = Delegate63.smethod_0(tcpListener_1, iasyncResult_0);
			if (tcpClient != null)
			{
				method_8(tcpClient);
			}
		}
		catch
		{
		}
		method_6();
	}

	private void method_8(TcpClient tcpClient_0)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		List<byte> object_ = Delegate27.smethod_0();
		byte[] array = new byte[Delegate85.smethod_0(tcpClient_0)];
		NetworkStream networkStream = Delegate134.smethod_0(tcpClient_0);
		try
		{
			if (Delegate94.smethod_0(networkStream))
			{
				while (true)
				{
					int num = Delegate108.smethod_0(networkStream, array, 0, Delegate85.smethod_0(tcpClient_0));
					if (num <= 0)
					{
						break;
					}
					byte[] array2 = new byte[num];
					Delegate5.smethod_0(array, 0, array2, 0, num);
					Delegate125.smethod_0(object_, array2);
				}
			}
			Delegate116.smethod_0(networkStream);
			Delegate14.smethod_0(tcpClient_0);
		}
		finally
		{
			if (networkStream != null)
			{
				Delegate17.smethod_0(networkStream);
			}
		}
		string string_0 = Delegate36.smethod_0(Delegate129.smethod_0(), Delegate59.smethod_0(object_));
		Delegate55.smethod_0(this, (Delegate)(MethodInvoker)delegate
		{
			gform1_1.method_1(string_0);
		});
	}

	public void method_9(int int_0)
	{
		tcpListener_2 = Delegate47.smethod_0(IPAddress.Any, int_0);
		Delegate42.smethod_0(tcpListener_2);
		method_10();
	}

	private void method_10()
	{
		Delegate77.smethod_0(tcpListener_2, method_11, null);
	}

	private void method_11(IAsyncResult iasyncResult_0)
	{
		try
		{
			TcpClient tcpClient = Delegate63.smethod_0(tcpListener_1, iasyncResult_0);
			if (tcpClient != null)
			{
				method_12(tcpClient);
			}
		}
		catch
		{
		}
		method_10();
	}

	private void method_12(TcpClient tcpClient_0)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		List<byte> object_ = Delegate27.smethod_0();
		byte[] array = new byte[Delegate85.smethod_0(tcpClient_0)];
		NetworkStream networkStream = Delegate134.smethod_0(tcpClient_0);
		try
		{
			if (Delegate94.smethod_0(networkStream))
			{
				while (true)
				{
					int num = Delegate108.smethod_0(networkStream, array, 0, Delegate85.smethod_0(tcpClient_0));
					if (num <= 0)
					{
						break;
					}
					byte[] array2 = new byte[num];
					Delegate5.smethod_0(array, 0, array2, 0, num);
					Delegate125.smethod_0(object_, array2);
				}
			}
			Delegate116.smethod_0(networkStream);
			Delegate14.smethod_0(tcpClient_0);
		}
		finally
		{
			if (networkStream != null)
			{
				Delegate17.smethod_0(networkStream);
			}
		}
		string string_0 = Delegate36.smethod_0(Delegate129.smethod_0(), Delegate59.smethod_0(object_));
		Delegate55.smethod_0(this, (Delegate)(MethodInvoker)delegate
		{
			gform1_2.method_1(string_0);
		});
	}

	public void method_13(int int_0)
	{
		tcpListener_3 = Delegate47.smethod_0(IPAddress.Any, int_0);
		Delegate42.smethod_0(tcpListener_3);
		method_14();
	}

	private void method_14()
	{
		Delegate77.smethod_0(tcpListener_3, method_15, null);
	}

	private void method_15(IAsyncResult iasyncResult_0)
	{
		try
		{
			TcpClient tcpClient = Delegate63.smethod_0(tcpListener_1, iasyncResult_0);
			if (tcpClient != null)
			{
				method_16(tcpClient);
			}
		}
		catch
		{
		}
		method_14();
	}

	private void method_16(TcpClient tcpClient_0)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		List<byte> object_ = Delegate27.smethod_0();
		byte[] array = new byte[Delegate85.smethod_0(tcpClient_0)];
		NetworkStream networkStream = Delegate134.smethod_0(tcpClient_0);
		try
		{
			if (Delegate94.smethod_0(networkStream))
			{
				while (true)
				{
					int num = Delegate108.smethod_0(networkStream, array, 0, Delegate85.smethod_0(tcpClient_0));
					if (num <= 0)
					{
						break;
					}
					byte[] array2 = new byte[num];
					Delegate5.smethod_0(array, 0, array2, 0, num);
					Delegate125.smethod_0(object_, array2);
				}
			}
			Delegate116.smethod_0(networkStream);
			Delegate14.smethod_0(tcpClient_0);
		}
		finally
		{
			if (networkStream != null)
			{
				Delegate17.smethod_0(networkStream);
			}
		}
		string string_0 = Delegate36.smethod_0(Delegate129.smethod_0(), Delegate59.smethod_0(object_));
		Delegate55.smethod_0(this, (Delegate)(MethodInvoker)delegate
		{
			gform0_0.method_1(string_0);
		});
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate17.smethod_0(icontainer_0);
		}
		Delegate35.smethod_0(this, disposing);
	}

	private void method_17()
	{
		label_0 = Delegate140.smethod_0();
		Delegate11.smethod_0(this);
		Delegate128.smethod_0(label_0, Delegate88.smethod_0());
		Delegate126.smethod_0(label_0, Delegate6.smethod_0("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate111.smethod_0(label_0, Delegate97.smethod_0());
		Delegate117.smethod_0(label_0, new Point(0, 0));
		Delegate44.smethod_1(label_0, "Building");
		Delegate15.smethod_0(label_0, new Size(1280, 40));
		Delegate130.smethod_0(label_0, 0);
		Delegate67.smethod_0(label_0, "Building Name");
		Delegate28.smethod_0(label_0, (ContentAlignment)32);
		Delegate60.smethod_0(this, new SizeF(6f, 13f));
		Delegate37.smethod_0(this, (AutoScaleMode)1);
		Delegate128.smethod_0(this, Delegate100.smethod_0());
		Delegate64.smethod_0(this, new Size(1280, 800));
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)label_0);
		Delegate49.smethod_0(this, (FormBorderStyle)0);
		Delegate44.smethod_0(this, "MainForm");
		Delegate67.smethod_0(this, "Elevator Monitoring");
		Delegate81.smethod_0(this, (FormWindowState)2);
		Delegate23.smethod_0(this, method_0);
		Delegate22.smethod_0(this, bool_0: false);
	}
}
