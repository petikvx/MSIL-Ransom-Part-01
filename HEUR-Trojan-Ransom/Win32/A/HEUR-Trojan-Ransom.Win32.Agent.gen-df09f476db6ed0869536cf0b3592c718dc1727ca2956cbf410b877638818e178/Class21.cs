using System.Net;
using System.Net.Sockets;
using System.Threading;

internal class Class21
{
	private class Class22
	{
		private IPEndPoint ipendPoint_0;

		private int int_0;

		private Socket[] socket_0;

		private int int_1;

		public Class22(IPEndPoint ipendPoint_1, int int_2, int int_3)
		{
			Class51.smethod_0();
			base._002Ector();
			ipendPoint_0 = ipendPoint_1;
			int_1 = int_2;
			int_0 = int_3;
		}

		public void method_0()
		{
			//Discarded unreachable code: IL_0006, IL_000c, IL_00bb, IL_00f3, IL_00f9, IL_010a, IL_010c, IL_0115
			/*Error near IL_0001: Could not find block for branch target IL_00f9*/;
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	private static IPEndPoint ipendPoint_0;

	public static ushort ushort_0;

	public static int int_0;

	private static Class22[] class22_0;

	public static int int_1;

	public static int int_2;

	public static void smethod_0()
	{
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).AddressList[0], ushort_0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), ushort_0);
		}
		thread_0 = new Thread[int_1];
		threadStart_0 = new ThreadStart[int_1];
		class22_0 = new Class22[int_1];
		for (int i = 0; i < int_1; i++)
		{
			class22_0[i] = new Class22(ipendPoint_0, int_2, int_0);
			threadStart_0[i] = class22_0[i].method_0;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				thread_0[i].Abort();
				thread_0[i].Join();
			}
			catch
			{
			}
		}
	}

	public Class21()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
