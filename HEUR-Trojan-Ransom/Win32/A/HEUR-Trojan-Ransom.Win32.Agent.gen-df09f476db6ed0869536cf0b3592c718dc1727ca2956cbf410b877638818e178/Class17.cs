using System.Net;
using System.Net.Sockets;
using System.Threading;

internal class Class17
{
	private class Class18
	{
		private int int_0;

		private IPEndPoint ipendPoint_0;

		private int int_1;

		private Socket[] socket_0;

		public Class18(IPEndPoint ipendPoint_1, int int_2, int int_3)
		{
			Class51.smethod_0();
			base._002Ector();
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_2;
			int_1 = int_3;
		}

		public void method_0()
		{
			//Discarded unreachable code: IL_0006, IL_000f, IL_004d, IL_0053, IL_0107, IL_0118, IL_011d
			/*Error near IL_0001: Could not find block for branch target IL_0107*/;
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	public static int int_0;

	private static IPEndPoint ipendPoint_0;

	public static int int_1;

	private static Class18[] class18_0;

	public static int int_2;

	public static void smethod_0()
	{
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).AddressList[0], 0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), 0);
		}
		thread_0 = new Thread[int_2];
		threadStart_0 = new ThreadStart[int_2];
		class18_0 = new Class18[int_2];
		for (int i = 0; i < int_2; i++)
		{
			class18_0[i] = new Class18(ipendPoint_0, int_0, int_1);
			threadStart_0[i] = class18_0[i].method_0;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < int_2; i++)
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

	public Class17()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
