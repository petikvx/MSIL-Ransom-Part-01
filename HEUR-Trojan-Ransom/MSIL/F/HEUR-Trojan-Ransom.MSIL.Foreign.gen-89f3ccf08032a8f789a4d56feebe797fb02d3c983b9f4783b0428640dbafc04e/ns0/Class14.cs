using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class14
{
	public enum Enum3
	{
		const_0 = 15,
		const_1 = 0,
		const_2 = 1,
		const_3 = 2,
		const_4 = 3,
		const_5 = 4,
		const_6 = 5,
		const_7 = 6,
		const_8 = 7,
		const_9 = 8,
		const_10 = 9,
		const_11 = 16,
		const_12 = 17,
		const_13 = 18,
		const_14 = 19,
		const_15 = 20,
		const_16 = 21,
		const_17 = 22,
		const_18 = 23,
		const_19 = 24,
		const_20 = 25
	}

	private Socket socket_0;

	private bool bool_0;

	private Thread thread_0;

	private Thread thread_1;

	private Thread thread_2;

	private string string_0;

	private int int_0;

	private string string_1;

	private bool bool_1;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler<EventArgs0> eventHandler_2;

	private EventHandler<EventArgs2> eventHandler_3;

	public Socket Socket_0 => socket_0;

	public bool Boolean_0 => bool_0;

	public string String_0 => string_0;

	public int Int32_0 => int_0;

	public string String_1 => string_1;

	private byte[] Byte_0 => Encoding.ASCII.GetBytes("\n");

	public event EventHandler ConnectionAccepted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler Disconnected
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public event EventHandler<EventArgs0> Sent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler<EventArgs0>)Delegate.Remove(eventHandler_2, value);
		}
	}

	public event EventHandler<EventArgs2> Received
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler<EventArgs2>)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler<EventArgs2>)Delegate.Remove(eventHandler_3, value);
		}
	}

	public Class14(string Host, int Port, string Password)
	{
		string_0 = Host;
		int_0 = Port;
		string_1 = Password;
		bool_0 = false;
		bool_1 = false;
	}

	public void method_0()
	{
		method_1();
	}

	private void method_1()
	{
		if (bool_0)
		{
			return;
		}
		ThreadStart start = delegate
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			while (!socket_0.Connected)
			{
				try
				{
					socket_0.Connect(string_0, int_0);
				}
				catch
				{
					Thread.Sleep(TimeSpan.FromSeconds(Class3.int_0));
				}
			}
			method_2();
		};
		thread_2 = new Thread(start);
		thread_2.Start();
	}

	private void method_2()
	{
		if (!bool_0)
		{
			bool_0 = true;
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, null);
			}
		}
	}

	public void method_3()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		thread_0 = new Thread(method_4);
		thread_0.Start();
		thread_1 = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				Thread.Sleep(TimeSpan.FromSeconds(45.0));
				if (!bool_1)
				{
					break;
				}
				bool_1 = false;
			}
			method_10(bool_2: true);
		});
		thread_1.Start();
	}

	private void method_4()
	{
		try
		{
			MemoryStream ms = new MemoryStream();
			byte[] array;
			do
			{
				array = new byte[socket_0.ReceiveBufferSize];
				int num = socket_0.Receive(array, 0, array.Length, SocketFlags.Partial);
				if (num > 0)
				{
					Array.Resize(ref array, num);
					ms.Write(array, 0, num);
					continue;
				}
				throw new SocketException();
			}
			while (!(char.ConvertFromUtf32(array[^1]) == "\n"));
			ms.Close();
			ThreadStart start = delegate
			{
				method_5(ms.ToArray());
				ms.Dispose();
				ms = null;
			};
			new Thread(start).Start();
		}
		catch (SocketException)
		{
			method_10(bool_2: true);
			return;
		}
		catch (Exception ex2)
		{
			method_10(bool_2: true);
			Console.WriteLine(ex2.Message);
		}
		method_4();
	}

	private void method_5(byte[] byte_0)
	{
		List<byte> list = new List<byte>();
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (char.ConvertFromUtf32(byte_0[i]) != "\n")
			{
				list.Add(byte_0[i]);
				continue;
			}
			method_6(list.ToArray());
			list.Clear();
		}
	}

	private void method_6(byte[] byte_0)
	{
		try
		{
			byte[] buffer = Class0.smethod_1(byte_0, bool_0: true);
			MemoryStream memoryStream = new MemoryStream(buffer);
			byte[] array = new byte[4];
			memoryStream.Read(array, 0, array.Length);
			Enum3 @enum = (Enum3)BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[memoryStream.Length - 4L];
			memoryStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			memoryStream.Dispose();
			if (@enum != Enum3.const_14)
			{
				if (eventHandler_3 != null)
				{
					eventHandler_3(this, new EventArgs2(array2, array2.Length, @enum));
				}
			}
			else
			{
				bool_1 = true;
				method_8();
			}
			array2 = null;
			byte_0 = null;
			buffer = null;
			memoryStream = null;
		}
		catch
		{
			Class11 @class = new Class11();
			@class.Write("Broken Packet");
			method_7(new Class6(Enum3.const_16, @class.method_0()).method_0());
		}
	}

	public int method_7(byte[] byte_0)
	{
		int num = 0;
		try
		{
			num = socket_0.Send(byte_0, 0, byte_0.Length, SocketFlags.Partial);
			num += socket_0.Send(Byte_0, 0, 1, SocketFlags.Partial);
			if (eventHandler_2 != null && num != 0)
			{
				eventHandler_2(this, new EventArgs0(num));
			}
			return num;
		}
		catch
		{
			return 0;
		}
	}

	private void method_8()
	{
		method_7(new Class6(Enum3.const_14, new byte[0]).method_0());
	}

	public void method_9(string string_2)
	{
		Class11 @class = new Class11();
		@class.Write(string_2);
		method_7(new Class6(Enum3.const_16, @class.method_0()).method_0());
	}

	public bool method_10(bool bool_2)
	{
		if (!bool_0)
		{
			return false;
		}
		method_11();
		bool_0 = false;
		if (bool_2 && eventHandler_1 != null)
		{
			eventHandler_1(this, null);
		}
		return true;
	}

	public void method_11()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			socket_0.Close();
			socket_0 = null;
		}
		catch
		{
		}
		try
		{
			thread_0.Abort();
			thread_0 = null;
		}
		catch
		{
		}
		try
		{
			thread_1.Abort();
			thread_1 = null;
		}
		catch
		{
		}
	}
}
