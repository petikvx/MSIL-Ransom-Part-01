using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

internal sealed class Class23 : GClass0, IEquatable<Class23>
{
	private class Class30
	{
		internal byte[] byte_0;

		internal ManualResetEvent manualResetEvent_0;

		internal GClass2 gclass2_0;

		internal bool bool_0;

		public Class30()
		{
			Class51.smethod_0();
			manualResetEvent_0 = new ManualResetEvent(initialState: false);
			base._002Ector();
		}
	}

	private class Class31
	{
		internal volatile bool bool_0;

		internal GClass2 gclass2_0;

		internal UdpClient udpClient_0;

		internal ManualResetEvent manualResetEvent_0;

		internal Class31(Class30 class30_0, UdpClient udpClient_1)
		{
			Class51.smethod_0();
			base._002Ector();
			gclass2_0 = class30_0.gclass2_0;
			udpClient_0 = udpClient_1;
			manualResetEvent_0 = new ManualResetEvent(initialState: false);
		}
	}

	private Class24 class24_0;

	private bool bool_0;

	private IPAddress ipaddress_0;

	private IPAddress ipaddress_1;

	internal Class23(IPAddress ipaddress_2, IPAddress ipaddress_3)
	{
		Class51.smethod_0();
		base._002Ector();
		ipaddress_0 = ipaddress_2;
		ipaddress_1 = ipaddress_3;
	}

	[SpecialName]
	internal IPAddress method_0()
	{
		return ipaddress_0;
	}

	public override IPAddress imethod_3()
	{
		return ipaddress_1;
	}

	public override IAsyncResult imethod_5(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0)
	{
		_003C_003Ec__DisplayClass1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.pmar = new Class25(gclass2_0.method_0(), gclass2_0.method_4(), 3600, asyncCallback_0, object_0);
		ThreadPool.QueueUserWorkItem(delegate
		{
			try
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.method_3(CS_0024_003C_003E8__locals0.pmar.method_6(), bool_1: true);
				CS_0024_003C_003E8__locals0.pmar.method_4();
			}
			catch (Exception exception_)
			{
				CS_0024_003C_003E8__locals0.pmar.method_5(exception_);
			}
		});
		return CS_0024_003C_003E8__locals0.pmar;
	}

	public override IAsyncResult imethod_6(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0)
	{
		_003C_003Ec__DisplayClass4 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.pmar = new Class25(gclass2_0, asyncCallback_0, object_0);
		ThreadPool.QueueUserWorkItem(delegate
		{
			try
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.method_3(CS_0024_003C_003E8__locals0.pmar.method_6(), bool_1: false);
				CS_0024_003C_003E8__locals0.pmar.method_4();
			}
			catch (Exception exception_)
			{
				CS_0024_003C_003E8__locals0.pmar.method_5(exception_);
			}
		});
		return CS_0024_003C_003E8__locals0.pmar;
	}

	public override void imethod_10(IAsyncResult iasyncResult_0)
	{
		Class25 @class = iasyncResult_0 as Class25;
		@class.method_0().WaitOne();
	}

	public override void imethod_11(IAsyncResult iasyncResult_0)
	{
		Class25 @class = iasyncResult_0 as Class25;
		@class.method_0().WaitOne();
	}

	public override IAsyncResult imethod_7(AsyncCallback asyncCallback_0, object object_0)
	{
		throw new NotSupportedException();
	}

	public override IAsyncResult imethod_8(AsyncCallback asyncCallback_0, object object_0)
	{
		method_1(ref class24_0, asyncCallback_0, object_0);
		Class24 @class = class24_0;
		@class.method_4();
		return @class;
	}

	public override IAsyncResult imethod_9(GEnum1 genum1_0, int int_0, AsyncCallback asyncCallback_0, object object_0)
	{
		throw new NotSupportedException();
	}

	public override GClass2[] imethod_12(IAsyncResult iasyncResult_0)
	{
		throw new NotSupportedException();
	}

	public override IPAddress imethod_13(IAsyncResult iasyncResult_0)
	{
		method_2(iasyncResult_0, ref class24_0);
		return ipaddress_1;
	}

	private void method_1(ref Class24 class24_1, AsyncCallback asyncCallback_0, object object_0)
	{
		if (bool_0)
		{
			throw new InvalidOperationException("Can only have one simultaenous async operation");
		}
		bool_0 = true;
		class24_1 = new Class24(asyncCallback_0, object_0);
	}

	private void method_2(IAsyncResult iasyncResult_0, ref Class24 class24_1)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("result");
		}
		if (iasyncResult_0 != class24_1)
		{
			throw new ArgumentException("Supplied IAsyncResult does not match the stored result");
		}
		if (!iasyncResult_0.IsCompleted)
		{
			iasyncResult_0.AsyncWaitHandle.WaitOne();
		}
		if (class24_1.method_3() != null)
		{
			throw class24_1.method_3();
		}
		bool_0 = false;
		class24_1 = null;
	}

	public override GClass2 imethod_14(IAsyncResult iasyncResult_0)
	{
		throw new NotSupportedException();
	}

	public override bool Equals(object obj)
	{
		if (obj is Class23 other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ipaddress_1.GetHashCode();
	}

	public bool Equals(Class23 other)
	{
		if (other != null)
		{
			return ipaddress_1.Equals(other.ipaddress_1);
		}
		return false;
	}

	private GClass2 method_3(GClass2 gclass2_0, bool bool_1)
	{
		List<byte> list = new List<byte>();
		list.Add(0);
		list.Add((byte)((gclass2_0.method_0() != 0) ? 1 : 2));
		list.Add(0);
		list.Add(0);
		list.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)gclass2_0.method_2())));
		list.AddRange(BitConverter.GetBytes((short)(bool_1 ? IPAddress.HostToNetworkOrder((short)gclass2_0.method_4()) : 0)));
		list.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(gclass2_0.method_6())));
		Class30 @class = new Class30();
		@class.byte_0 = list.ToArray();
		@class.gclass2_0 = gclass2_0;
		ThreadPool.QueueUserWorkItem(method_4, @class);
		WaitHandle.WaitAll(new WaitHandle[1] { @class.manualResetEvent_0 });
		if (!@class.bool_0)
		{
			string arg = (bool_1 ? "create" : "delete");
			throw new GException0($"Failed to {arg} portmap (protocol={gclass2_0.method_0()}, private port={gclass2_0.method_2()}");
		}
		return @class.gclass2_0;
	}

	private void method_4(object object_0)
	{
		Class30 @class = object_0 as Class30;
		UdpClient udpClient = new UdpClient();
		Class31 class2 = new Class31(@class, udpClient);
		int num = 0;
		int num2 = 250;
		ThreadPool.QueueUserWorkItem(method_5, class2);
		while (num < 9 && !class2.bool_0)
		{
			udpClient.Send(@class.byte_0, @class.byte_0.Length, new IPEndPoint(ipaddress_0, 5351));
			class2.manualResetEvent_0.Set();
			num++;
			num2 *= 2;
			Thread.Sleep(num2);
		}
		@class.bool_0 = class2.bool_0;
		udpClient.Close();
		@class.manualResetEvent_0.Set();
	}

	private void method_5(object object_0)
	{
		Class31 @class = object_0 as Class31;
		UdpClient udpClient_ = @class.udpClient_0;
		@class.manualResetEvent_0.WaitOne();
		IPEndPoint remoteEP = new IPEndPoint(ipaddress_0, 5351);
		while (true)
		{
			if (@class.bool_0)
			{
				return;
			}
			byte[] array;
			try
			{
				array = udpClient_.Receive(ref remoteEP);
			}
			catch (SocketException)
			{
				@class.bool_0 = false;
				return;
			}
			if (array.Length >= 16 && array[0] == 0)
			{
				byte b = (byte)(array[1] & 0x7Fu);
				GEnum1 genum1_ = (GEnum1)0;
				if (b == 1)
				{
					genum1_ = (GEnum1)1;
				}
				short num = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 2));
				IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array, 4));
				IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 8));
				int int_ = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 10));
				uint num2 = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array, 12));
				if (num != 0)
				{
					@class.bool_0 = false;
					return;
				}
				if (num2 == 0)
				{
					break;
				}
				GClass2 gclass2_ = @class.gclass2_0;
				gclass2_.method_5(int_);
				gclass2_.method_1(genum1_);
				gclass2_.method_9(DateTime.Now.AddSeconds(num2));
				@class.bool_0 = true;
			}
		}
		@class.bool_0 = true;
		@class.gclass2_0 = null;
	}

	public override string ToString()
	{
		return $"PmpNatDevice - Local Address: {ipaddress_0}, Public IP: {ipaddress_1}, Last Seen: {imethod_15()}";
	}
}
