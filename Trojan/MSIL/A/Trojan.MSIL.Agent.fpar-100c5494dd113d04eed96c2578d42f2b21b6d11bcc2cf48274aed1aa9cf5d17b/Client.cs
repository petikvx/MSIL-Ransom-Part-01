using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public sealed class Client
{
	public delegate void GDelegate2(Client client_0, byte[] byte_0);

	public delegate void GDelegate3(Client client_0, int int_0);

	internal sealed class Class19
	{
		public int int_0;

		public Client client_0;
	}

	public delegate void GDelegate4(Client client_0);

	public delegate void GDelegate5(Client client_0, int int_0);

	public delegate void GDelegate6(Client client_0, string string_0, IPAddress ipaddress_0);

	public delegate void GDelegate7(Client client_0, bool bool_0);

	public delegate void GDelegate8(Client client_0, int int_0);

	public delegate void GDelegate9(Client client_0, Exception exception_0);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct1
	{
		public int int_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
		public uint[] uint_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct DnsRecord
	{
		public IntPtr intptr_0;

		public string string_0;

		public short short_0;

		public short short_1;

		public int int_0;

		public int int_1;

		public int int_2;

		public uint uint_0;
	}

	private GDelegate6 gdelegate6_0;

	private GDelegate7 gdelegate7_0;

	private GDelegate4 gdelegate4_0;

	private GDelegate2 gdelegate2_0;

	private GDelegate8 gdelegate8_0;

	private GDelegate3 gdelegate3_0;

	private GDelegate5 gdelegate5_0;

	private GDelegate9 gdelegate9_0;

	private bool bool_0;

	private int int_0;

	private int int_1;

	private bool bool_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private GClass0 gclass0_0;

	private IPEndPoint ipendPoint_0;

	private string string_0;

	private ushort ushort_0;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private string string_1;

	private bool bool_5;

	private IPAddress[] ipaddress_0;

	private Socket socket_0;

	private SocketAsyncEventArgs socketAsyncEventArgs_0;

	private SocketAsyncEventArgs socketAsyncEventArgs_1;

	private SocketAsyncEventArgs socketAsyncEventArgs_2;

	private int int_5;

	private int int_6;

	private int int_7;

	private byte[] byte_0;

	private byte[] byte_1;

	private byte[] byte_2;

	private byte[] byte_3;

	private bool bool_6;

	private bool bool_7;

	private object object_0;

	private Queue<byte[]> queue_0;

	public Client()
	{
		bool_0 = true;
		int_0 = 65535;
		int_1 = 10485760;
		int_2 = 10485760;
		int_3 = 2500;
		int_4 = 8000;
		object_0 = RuntimeHelpers.GetObjectValue(new object());
		bool_4 = true;
		string_1 = Guid.NewGuid().ToString();
	}

	public Client(Socket socket_1, bool bool_8, int int_8, int int_9, bool bool_9)
	{
		bool_0 = true;
		int_0 = 65535;
		int_1 = 10485760;
		int_2 = 10485760;
		int_3 = 2500;
		int_4 = 8000;
		object_0 = RuntimeHelpers.GetObjectValue(new object());
		socket_0 = socket_1;
		string_1 = Guid.NewGuid().ToString();
		bool_3 = true;
		ushort_0 = (ushort)((IPEndPoint)socket_1.LocalEndPoint).Port;
		bool_0 = bool_8;
		int_0 = int_8;
		int_1 = int_9;
		bool_1 = bool_9;
		method_43();
		method_50(socket_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate6 gdelegate6_1)
	{
		gdelegate6_0 = (GDelegate6)Delegate.Combine(gdelegate6_0, gdelegate6_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate6 gdelegate6_1)
	{
		gdelegate6_0 = (GDelegate6)Delegate.Remove(gdelegate6_0, gdelegate6_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate7 gdelegate7_1)
	{
		gdelegate7_0 = (GDelegate7)Delegate.Combine(gdelegate7_0, gdelegate7_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate7 gdelegate7_1)
	{
		gdelegate7_0 = (GDelegate7)Delegate.Remove(gdelegate7_0, gdelegate7_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(GDelegate4 gdelegate4_1)
	{
		gdelegate4_0 = (GDelegate4)Delegate.Combine(gdelegate4_0, gdelegate4_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate4 gdelegate4_1)
	{
		gdelegate4_0 = (GDelegate4)Delegate.Remove(gdelegate4_0, gdelegate4_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_6(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Combine(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_7(GDelegate2 gdelegate2_1)
	{
		gdelegate2_0 = (GDelegate2)Delegate.Remove(gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_8(GDelegate8 gdelegate8_1)
	{
		gdelegate8_0 = (GDelegate8)Delegate.Combine(gdelegate8_0, gdelegate8_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_9(GDelegate8 gdelegate8_1)
	{
		gdelegate8_0 = (GDelegate8)Delegate.Remove(gdelegate8_0, gdelegate8_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_10(GDelegate3 gdelegate3_1)
	{
		gdelegate3_0 = (GDelegate3)Delegate.Combine(gdelegate3_0, gdelegate3_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_11(GDelegate3 gdelegate3_1)
	{
		gdelegate3_0 = (GDelegate3)Delegate.Remove(gdelegate3_0, gdelegate3_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_12(GDelegate5 gdelegate5_1)
	{
		gdelegate5_0 = (GDelegate5)Delegate.Combine(gdelegate5_0, gdelegate5_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_13(GDelegate5 gdelegate5_1)
	{
		gdelegate5_0 = (GDelegate5)Delegate.Remove(gdelegate5_0, gdelegate5_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_14(GDelegate9 gdelegate9_1)
	{
		gdelegate9_0 = (GDelegate9)Delegate.Combine(gdelegate9_0, gdelegate9_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_15(GDelegate9 gdelegate9_1)
	{
		gdelegate9_0 = (GDelegate9)Delegate.Remove(gdelegate9_0, gdelegate9_1);
	}

	public bool method_16()
	{
		return bool_0;
	}

	public void method_17(bool bool_8)
	{
		if (method_36())
		{
			throw new Exception("Unable to change this property while socket is in use.");
		}
		bool_0 = bool_8;
	}

	public int method_18()
	{
		return int_0;
	}

	public void method_19(int int_8)
	{
		if (int_8 < 1)
		{
			throw new Exception("Value must be greater than 0.");
		}
		if (method_36())
		{
			throw new Exception("Unable to change this property while socket is in use.");
		}
		int_0 = int_8;
	}

	public int method_20()
	{
		return int_1;
	}

	public void method_21(int int_8)
	{
		if (int_8 < 1)
		{
			throw new Exception("Value must be greater than 0.");
		}
		int_1 = int_8;
	}

	public bool method_22()
	{
		return bool_1;
	}

	public void method_23(bool bool_8)
	{
		bool_1 = bool_8;
	}

	public int method_24()
	{
		return int_2;
	}

	public void method_25(int int_8)
	{
		if (int_8 < 85000)
		{
			throw new Exception("Value must be greater than or equal to 85000.");
		}
		int_2 = int_8;
	}

	public int method_26()
	{
		return int_3;
	}

	public void method_27(int int_8)
	{
		int_3 = int_8;
	}

	public int method_28()
	{
		return int_4;
	}

	public void method_29(int int_8)
	{
		int_4 = int_8;
	}

	public GClass0 method_30()
	{
		return gclass0_0;
	}

	public void method_31(GClass0 gclass0_1)
	{
		gclass0_0 = gclass0_1;
	}

	public IPEndPoint method_32()
	{
		if (ipendPoint_0 != null)
		{
			return ipendPoint_0;
		}
		return new IPEndPoint(IPAddress.None, 0);
	}

	public string method_33()
	{
		return string_0;
	}

	public ushort method_34()
	{
		return ushort_0;
	}

	public bool method_35()
	{
		return bool_2;
	}

	public bool method_36()
	{
		if (!bool_2 && !bool_3)
		{
			return false;
		}
		return true;
	}

	public bool method_37()
	{
		return bool_4;
	}

	public string method_38()
	{
		return string_1;
	}

	public bool method_39()
	{
		return bool_5;
	}

	public void method_40(bool bool_8)
	{
		bool_5 = bool_8;
	}

	public IPAddress[] method_41()
	{
		return ipaddress_0;
	}

	public void method_42(IPAddress[] ipaddress_1)
	{
		ipaddress_0 = ipaddress_1;
	}

	private void method_43()
	{
		byte_2 = new byte[4];
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_3 = new byte[int_0 * 2 - 1 + 1];
		queue_0 = new Queue<byte[]>();
		socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
		socketAsyncEventArgs_1 = new SocketAsyncEventArgs();
		socketAsyncEventArgs_2 = new SocketAsyncEventArgs();
		socketAsyncEventArgs_0.SetBuffer(byte_3, 0, int_0);
		socketAsyncEventArgs_1.SetBuffer(byte_3, int_0, int_0);
		socketAsyncEventArgs_0.Completed += method_52;
		socketAsyncEventArgs_1.Completed += method_52;
		socketAsyncEventArgs_2.Completed += method_52;
	}

	public void method_44(string string_2, ushort ushort_1)
	{
		if (!bool_4)
		{
			return;
		}
		try
		{
			if (method_36())
			{
				return;
			}
			string_0 = string_2;
			ushort_0 = ushort_1;
			bool_3 = true;
			method_43();
			IPAddress address = IPAddress.None;
			if (IPAddress.TryParse(string_0, out address))
			{
				method_47(address, ushort_0);
				return;
			}
			ThreadPool.QueueUserWorkItem(delegate
			{
				((Delegate0)delegate
				{
					method_45(string_0, ushort_0);
				})();
			});
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	private void method_45(string string_2, ushort ushort_1)
	{
		try
		{
			IPAddress[] array = null;
			if (bool_5)
			{
				if (ipaddress_0 != null && ipaddress_0.Length != 0)
				{
					IPAddress[] array2 = ipaddress_0;
					foreach (IPAddress ipaddress_ in array2)
					{
						array = method_57(string_2, ipaddress_);
						if (array.Length != 0)
						{
							break;
						}
					}
				}
				else
				{
					array = method_57(string_2, null);
				}
				if (array.Length == 0)
				{
					array = Dns.GetHostEntry(string_2).AddressList;
				}
			}
			else
			{
				array = Dns.GetHostEntry(string_2).AddressList;
			}
			method_46(string_2, ushort_1, array);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	private void method_46(string string_2, ushort ushort_1, IPAddress[] ipaddress_1)
	{
		try
		{
			if (socket_0 != null)
			{
				return;
			}
			int num = 0;
			IPAddress iPAddress;
			while (true)
			{
				if (num < ipaddress_1.Length)
				{
					iPAddress = ipaddress_1[num];
					if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
					{
						break;
					}
					num++;
					continue;
				}
				throw new Exception("Unable to resolve remote host.");
			}
			gdelegate6_0?.Invoke(this, string_2, iPAddress);
			method_47(iPAddress, ushort_1);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	private void method_47(IPAddress ipaddress_1, ushort ushort_1)
	{
		try
		{
			socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket_0.LingerState = new LingerOption(enable: true, 0);
			socketAsyncEventArgs_2.RemoteEndPoint = new IPEndPoint(ipaddress_1, ushort_1);
			if (Class0.smethod_0(ipaddress_1))
			{
				method_48(int_3);
			}
			else
			{
				method_48(int_4);
			}
			if (!socket_0.ConnectAsync(socketAsyncEventArgs_2))
			{
				method_52(socket_0, socketAsyncEventArgs_2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	private void method_48(int int_8)
	{
		Class19 CS_0024_003C_003E8__locals0 = new Class19();
		CS_0024_003C_003E8__locals0.int_0 = int_8;
		CS_0024_003C_003E8__locals0.client_0 = this;
		ThreadPool.QueueUserWorkItem(delegate
		{
			((Delegate0)delegate
			{
				CS_0024_003C_003E8__locals0.client_0.method_49(CS_0024_003C_003E8__locals0.int_0);
			})();
		});
	}

	private void method_49(int int_8)
	{
		int num = 0;
		while (true)
		{
			if (num <= int_8)
			{
				if (bool_3)
				{
					Thread.Sleep(20);
					num += 20;
					continue;
				}
				break;
			}
			if (bool_3)
			{
				method_56();
			}
			break;
		}
	}

	private void method_50(Socket socket_1)
	{
		try
		{
			socketAsyncEventArgs_2.Dispose();
			socketAsyncEventArgs_2 = null;
			ipendPoint_0 = (IPEndPoint)socket_1.RemoteEndPoint;
			bool_3 = false;
			bool_2 = true;
			if (method_37())
			{
				gdelegate7_0?.Invoke(this, bool_0: true);
				method_51();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	public void method_51()
	{
		if (!socket_0.ReceiveAsync(socketAsyncEventArgs_0))
		{
			method_52(socket_0, socketAsyncEventArgs_0);
		}
	}

	private void method_52(object sender, SocketAsyncEventArgs e)
	{
		try
		{
			if (socket_0 == null || socket_0 != sender)
			{
				return;
			}
			if (e.SocketError == SocketError.Success)
			{
				switch (e.LastOperation)
				{
				case SocketAsyncOperation.Connect:
					method_50(socket_0);
					break;
				case SocketAsyncOperation.Receive:
					if (e.BytesTransferred == 0)
					{
						method_56();
						break;
					}
					if (bool_1)
					{
						gdelegate8_0?.Invoke(this, e.BytesTransferred);
					}
					method_53(e.Buffer, 0, e.BytesTransferred);
					if (!socket_0.ReceiveAsync(e))
					{
						method_52(socket_0, e);
					}
					break;
				case SocketAsyncOperation.Send:
				{
					if (bool_0 && int_6 == 0)
					{
						int_6 = -4;
					}
					int_6 += e.BytesTransferred;
					if (bool_1)
					{
						gdelegate5_0?.Invoke(this, e.BytesTransferred);
					}
					bool flag = default(bool);
					if (int_6 == byte_1.Length)
					{
						flag = true;
						gdelegate3_0?.Invoke(this, byte_1.Length);
					}
					object obj = object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					Monitor.Enter(obj);
					try
					{
						if (queue_0.Count == 0 && flag)
						{
							bool_7 = false;
							Array.Resize(ref byte_1, 0);
							if (int_6 >= int_2)
							{
								GC.Collect();
							}
							int_6 = 0;
						}
						else
						{
							method_55();
						}
						break;
					}
					finally
					{
						Monitor.Exit(obj);
					}
				}
				case SocketAsyncOperation.Disconnect:
				case SocketAsyncOperation.ReceiveFrom:
				case SocketAsyncOperation.ReceiveMessageFrom:
					break;
				}
			}
			else
			{
				gdelegate9_0?.Invoke(this, new SocketException((int)e.SocketError));
				method_56();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	private void method_53(byte[] byte_4, int int_8, int int_9)
	{
		if (bool_0)
		{
			if (bool_6)
			{
				int num = Math.Min(byte_0.Length - int_5, int_9 - int_8);
				Buffer.BlockCopy(byte_4, int_8, byte_0, int_5, num);
				int_5 += num;
				if (int_5 == byte_0.Length)
				{
					gdelegate2_0?.Invoke(this, byte_0);
					bool_6 = false;
					Array.Resize(ref byte_0, 0);
					if (int_5 >= int_2)
					{
						GC.Collect();
					}
				}
				if (num < int_9 - int_8)
				{
					method_53(byte_4, int_8 + num, int_9);
				}
				return;
			}
			int num2 = Math.Min(int_9 - int_8, 4 - int_7);
			Buffer.BlockCopy(byte_4, int_8, byte_2, int_7, num2);
			int_8 += num2;
			int_7 += num2;
			if (int_7 != 4)
			{
				return;
			}
			int num3 = BitConverter.ToInt32(byte_2, 0);
			if (num3 > int_1)
			{
				gdelegate9_0?.Invoke(this, new Exception("Packet size exceeds MaxPacketSize."));
				method_56();
				return;
			}
			if (num3 <= 0)
			{
				gdelegate9_0?.Invoke(this, new Exception("Packet size must be greater than 0."));
				method_56();
				return;
			}
			int_5 = 0;
			int_7 = 0;
			bool_6 = true;
			Array.Resize(ref byte_0, num3);
			if (int_8 < int_9)
			{
				method_53(byte_4, int_8, int_9);
			}
		}
		else
		{
			Array.Resize(ref byte_0, int_9);
			Buffer.BlockCopy(byte_4, 0, byte_0, 0, int_9);
			gdelegate2_0?.Invoke(this, byte_0);
		}
	}

	public void method_54(byte[] byte_4)
	{
		if (!bool_2)
		{
			return;
		}
		try
		{
			object obj = object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			Monitor.Enter(obj);
			try
			{
				queue_0.Enqueue(byte_4);
				if (!bool_7)
				{
					bool_7 = true;
					method_55();
				}
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			gdelegate9_0?.Invoke(this, exception_);
			method_56();
			ProjectData.ClearProjectError();
		}
	}

	private void method_55()
	{
		if (int_6 == byte_1.Length)
		{
			int_6 = 0;
			object obj = object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			Monitor.Enter(obj);
			try
			{
				byte_1 = queue_0.Dequeue();
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}
		int num = default(int);
		if (bool_0 && int_6 == 0)
		{
			num = 4;
			Buffer.BlockCopy(BitConverter.GetBytes(byte_1.Length), 0, byte_3, socketAsyncEventArgs_1.Offset, 4);
		}
		int num2 = Math.Min(byte_1.Length - int_6, int_0 - num);
		Buffer.BlockCopy(byte_1, int_6, byte_3, socketAsyncEventArgs_1.Offset + num, num2);
		socketAsyncEventArgs_1.SetBuffer(socketAsyncEventArgs_1.Offset, num2 + num);
		if (!socket_0.SendAsync(socketAsyncEventArgs_1))
		{
			method_52(socket_0, socketAsyncEventArgs_1);
		}
	}

	public void method_56()
	{
		if (method_36())
		{
			bool flag = bool_2;
			bool flag2 = bool_3;
			bool_2 = false;
			bool_3 = false;
			if (socket_0 != null)
			{
				socket_0.Close();
				socket_0 = null;
			}
			if (socketAsyncEventArgs_0 != null)
			{
				socketAsyncEventArgs_0.Dispose();
				socketAsyncEventArgs_0 = null;
			}
			if (socketAsyncEventArgs_1 != null)
			{
				socketAsyncEventArgs_1.Dispose();
				socketAsyncEventArgs_1 = null;
			}
			if (socketAsyncEventArgs_2 != null)
			{
				socketAsyncEventArgs_2.Dispose();
				socketAsyncEventArgs_2 = null;
			}
			if (queue_0 != null)
			{
				queue_0.Clear();
				queue_0 = null;
			}
			int_6 = 0;
			int_5 = 0;
			byte_2 = null;
			byte_0 = null;
			byte_1 = null;
			byte_3 = null;
			bool_6 = false;
			bool_7 = false;
			if (flag)
			{
				gdelegate7_0?.Invoke(this, bool_0: false);
			}
			else if (flag2)
			{
				gdelegate4_0?.Invoke(this);
			}
		}
	}

	private IPAddress[] method_57(string string_2, IPAddress ipaddress_1)
	{
		List<IPAddress> list = new List<IPAddress>();
		Struct1 struct1_ = method_58(ipaddress_1);
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = default(IntPtr);
		if (DnsQuery_A(string_2, 1, 72, ref struct1_, ref intptr_2, ref intptr_) == 0)
		{
			DnsRecord dnsRecord_ = (DnsRecord)Marshal.PtrToStructure(intptr_2, typeof(DnsRecord));
			IPAddress iPAddress = method_59(dnsRecord_);
			if (iPAddress != IPAddress.None)
			{
				list.Add(iPAddress);
			}
			while (!(dnsRecord_.intptr_0 == IntPtr.Zero))
			{
				dnsRecord_ = (DnsRecord)Marshal.PtrToStructure(dnsRecord_.intptr_0, typeof(DnsRecord));
				iPAddress = method_59(dnsRecord_);
				if (iPAddress != IPAddress.None)
				{
					list.Add(iPAddress);
				}
			}
		}
		return list.ToArray();
	}

	private Struct1 method_58(IPAddress ipaddress_1)
	{
		Struct1 result = default(Struct1);
		if (ipaddress_1 == null)
		{
			return result;
		}
		Struct1 result2 = default(Struct1);
		result2.int_0 = 1;
		result2.uint_0 = new uint[1] { BitConverter.ToUInt32(ipaddress_1.GetAddressBytes(), 0) };
		return result2;
	}

	private IPAddress method_59(DnsRecord dnsRecord_0)
	{
		if (dnsRecord_0.short_0 != 1)
		{
			return IPAddress.None;
		}
		if ((dnsRecord_0.int_0 & 3) >= 2)
		{
			return IPAddress.None;
		}
		return new IPAddress(dnsRecord_0.uint_0);
	}

	[DllImport("dnsapi.dll")]
	private static extern int DnsQuery_A(string string_2, short short_0, int int_8, ref Struct1 struct1_0, ref IntPtr intptr_0, ref IntPtr intptr_1);
}
