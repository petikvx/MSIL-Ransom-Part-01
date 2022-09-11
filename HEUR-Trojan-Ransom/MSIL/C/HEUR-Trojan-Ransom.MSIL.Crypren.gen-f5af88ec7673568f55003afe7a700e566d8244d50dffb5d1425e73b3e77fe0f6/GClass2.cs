using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Business;
using Entity;
using Entity.Attribute;

[CanExecute]
public class GClass2
{
	public struct GStruct0
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;

		public int int_1;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_4;

		public IntPtr intptr_2;

		public uint uint_2;

		public IntPtr intptr_3;

		public uint uint_3;
	}

	[CompilerGenerated]
	private sealed class Class6
	{
		private sealed class Class7
		{
			public Class6 class6_0;

			public WindowWrapper windowWrapper_0;

			public bool method_0(WindowWrapper windowWrapper_1)
			{
				return (bool)Class29.smethod_0(7514438, this, windowWrapper_1);
			}
		}

		public List<WindowWrapper> list_0;

		public bool method_0(WindowWrapper windowWrapper_0)
		{
			return (bool)Class29.smethod_0(7514806, this, windowWrapper_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class8
	{
		private sealed class Class9
		{
			public Class8 class8_0;

			public WindowWrapper windowWrapper_0;

			public bool method_0(WindowWrapper windowWrapper_1)
			{
				return (bool)Class29.smethod_0(7517844, this, windowWrapper_1);
			}
		}

		public List<WindowWrapper> list_0;

		public bool method_0(WindowWrapper windowWrapper_0)
		{
			return (bool)Class29.smethod_0(7514240, this, windowWrapper_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class10
	{
		public StatusInfo statusInfo_0;

		public bool method_0(StatusInfo statusInfo_1)
		{
			return (bool)Class29.smethod_0(7517918, this, statusInfo_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class11
	{
		public Alert alert_0;

		public bool method_0(StatusInfo statusInfo_0)
		{
			return (bool)Class29.smethod_0(7517575, this, statusInfo_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class12
	{
		public string string_0;

		public bool method_0(Type type_0)
		{
			return (bool)Class29.smethod_0(7517641, this, type_0);
		}
	}

	public const string string_0 = "LSCTaskService";

	public static uint uint_0;

	public static uint uint_1;

	public static uint uint_2;

	public static uint uint_3;

	public static uint uint_4;

	public static int int_0;

	public static int int_1;

	public static uint uint_5;

	public static uint uint_6;

	public static uint uint_7;

	public static uint uint_8;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_2);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool ShellExecuteEx(ref GStruct0 gstruct0_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern uint WaitForSingleObject(uint uint_9, uint uint_10);

	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(IntPtr intptr_0, IntPtr intptr_1);

	public static string smethod_0()
	{
		return (string)Class29.smethod_0(7591788, null, null);
	}

	[CanExecute]
	public void method_0()
	{
		Class29.smethod_0(7591759, this, null);
	}

	[CanExecute]
	public void method_1()
	{
		Class29.smethod_0(7591054, this, null);
	}

	[CanExecute]
	public void method_2()
	{
		Class29.smethod_0(7590660, this, null);
	}

	[CanExecute]
	public void method_3()
	{
		Class29.smethod_0(7590299, this, null);
	}

	[CanExecute]
	public static List<Dictionary<string, string>> smethod_1()
	{
		return (List<Dictionary<string, string>>)Class29.smethod_0(7593894, null, null);
	}

	[CanExecute]
	public static List<Dictionary<string, string>> smethod_2()
	{
		return (List<Dictionary<string, string>>)Class29.smethod_0(7592458, null, null);
	}

	[CanExecute]
	public static List<Dictionary<string, string>> smethod_3(string string_4)
	{
		return (List<Dictionary<string, string>>)Class29.smethod_0(7544947, null, string_4);
	}

	[CanExecute]
	public static List<Dictionary<string, string>> smethod_4(string string_4)
	{
		return (List<Dictionary<string, string>>)Class29.smethod_0(7547744, null, string_4);
	}

	[CanExecute]
	public static List<Dictionary<string, string>> smethod_5()
	{
		return (List<Dictionary<string, string>>)Class29.smethod_0(7550296, null, null);
	}

	[CanExecute]
	public static void smethod_6()
	{
		Class29.smethod_0(7549451, null, null);
	}

	[CanExecute]
	public static void smethod_7()
	{
		Class29.smethod_0(7549163, null, null);
	}

	[CanExecute]
	public static void smethod_8()
	{
		Class29.smethod_0(7548980, null, null);
	}

	[CanExecute]
	public static void smethod_9()
	{
		Class29.smethod_0(7552758, null, null);
	}

	[CanExecute]
	public static void smethod_10()
	{
		Class29.smethod_0(7552365, null, null);
	}

	[CanExecute]
	public static void smethod_11()
	{
		Class29.smethod_0(7551982, null, null);
	}

	[CanExecute]
	public static void smethod_12()
	{
		Class29.smethod_0(7551601, null, null);
	}

	[CanExecute]
	private bool method_4(int int_2)
	{
		return (bool)Class29.smethod_0(7538544, this, int_2);
	}

	[CanExecute]
	private void method_5(string string_4)
	{
		Class29.smethod_0(7537722, this, string_4);
	}

	[CanExecute]
	public void method_6()
	{
		Class29.smethod_0(7536771, this, null);
	}

	[CanExecute]
	public void method_7()
	{
		Class29.smethod_0(7536875, this, null);
	}

	[CanExecute]
	public void method_8(params string[] string_4)
	{
		Class29.smethod_0(7536691, this, new object[1] { string_4 });
	}

	[CanExecute]
	private bool method_9(int int_2)
	{
		return (bool)Class29.smethod_0(7540209, this, int_2);
	}

	[CanExecute]
	public void method_10()
	{
		Class29.smethod_0(7539379, this, null);
	}

	[CanExecute]
	public static void smethod_13()
	{
		Class29.smethod_0(7538860, null, null);
	}

	[CanExecute]
	public static void smethod_14()
	{
		Class29.smethod_0(7542614, null, null);
	}

	[CanExecute]
	public static void smethod_15()
	{
		Class29.smethod_0(7542217, null, null);
	}

	[CanExecute]
	public static void smethod_16()
	{
		Class29.smethod_0(7541691, null, null);
	}

	[CanExecute]
	private static void smethod_17(string string_4, string string_5)
	{
		Class29.smethod_0(7541333, null, string_4, string_5);
	}

	[CanExecute]
	public static void smethod_18()
	{
		Class29.smethod_0(7540853, null, null);
	}

	[CanExecute]
	public static void smethod_19()
	{
		Class29.smethod_0(7544574, null, null);
	}

	[CanExecute]
	[UacMethod]
	public void method_11()
	{
		Class29.smethod_0(7544143, this, null);
	}

	[CanExecute]
	public static void smethod_20()
	{
		Class29.smethod_0(7543645, null, null);
	}

	[CanExecute]
	public static void smethod_21()
	{
		Class29.smethod_0(7543627, null, null);
	}

	[CanExecute]
	public static void smethod_22()
	{
		Class29.smethod_0(7543154, null, null);
	}

	[CanExecute]
	public void method_12()
	{
		Class29.smethod_0(7563226, this, null);
	}

	[CanExecute]
	public static void smethod_23()
	{
		Class29.smethod_0(7562551, null, null);
	}

	[CanExecute]
	public static void smethod_24()
	{
		Class29.smethod_0(7562159, null, null);
	}

	public static void smethod_25()
	{
		Class29.smethod_0(7561753, null, null);
	}

	[UacMethod]
	[CanExecute]
	public static void smethod_26(string string_4)
	{
		Class29.smethod_0(7561372, null, string_4);
	}

	[CanExecute]
	public static void smethod_27()
	{
		Class29.smethod_0(7565046, null, null);
	}

	[CanExecute]
	public static void smethod_28()
	{
		Class29.smethod_0(7564550, null, null);
	}

	[CanExecute]
	private static string smethod_29()
	{
		return (string)Class29.smethod_0(7564074, null, null);
	}

	[CanExecute]
	public static void smethod_30()
	{
		Class29.smethod_0(7563490, null, null);
	}

	[CanExecute]
	public static void smethod_31(string string_4)
	{
		Class29.smethod_0(7567085, null, string_4);
	}

	[CanExecute]
	public void method_13(string string_4)
	{
		Class29.smethod_0(7566552, this, string_4);
	}

	public List<IAlertBusiness> method_14()
	{
		return (List<IAlertBusiness>)Class29.smethod_0(7566079, this, null);
	}

	[CanExecute]
	public void method_15(List<StatusInfo> list_0, Alert alert_0)
	{
		Class29.smethod_0(7569137, this, list_0, alert_0);
	}

	[CanExecute]
	public void method_16()
	{
		Class29.smethod_0(7568436, this, null);
	}

	private void method_17()
	{
		Class29.smethod_0(7553971, this, null);
	}

	[CanExecute]
	public void method_18(string string_4)
	{
		Class29.smethod_0(7553117, this, string_4);
	}

	[CanExecute]
	public bool method_19()
	{
		return (bool)Class29.smethod_0(7556623, this, null);
	}

	[CanExecute]
	public void method_20()
	{
		Class29.smethod_0(7556174, this, null);
	}

	[CanExecute]
	public void method_21()
	{
		Class29.smethod_0(7555514, this, null);
	}

	[CanExecute]
	public void method_22()
	{
		Class29.smethod_0(7559086, this, null);
	}

	[CanExecute]
	public void method_23()
	{
		Class29.smethod_0(7558356, this, null);
	}

	[CanExecute]
	public void method_24()
	{
		Class29.smethod_0(7557860, this, null);
	}

	[CanExecute]
	public void method_25(List<StatusInfo> list_0, Alert alert_0)
	{
		Class29.smethod_0(7560458, this, list_0, alert_0);
	}

	[CanExecute]
	public static bool smethod_32(string string_4)
	{
		return (bool)Class29.smethod_0(7559839, null, string_4);
	}

	[CanExecute]
	public void method_26()
	{
		Class29.smethod_0(7559279, this, null);
	}

	[CanExecute]
	public void method_27(string string_4, string string_5)
	{
		Class29.smethod_0(7559245, this, string_4, string_5);
	}

	[CanExecute]
	public static void smethod_33(RequestInformation requestInformation_0)
	{
		Class29.smethod_0(7514090, null, requestInformation_0);
	}

	[CanExecute]
	public static void smethod_34()
	{
		Class29.smethod_0(7514059, null, null);
	}

	[CanExecute]
	public object method_28(string string_4)
	{
		return Class29.smethod_0(7513900, this, string_4);
	}

	[CanExecute]
	public void method_29(string string_4)
	{
		Class29.smethod_0(7512968, this, string_4);
	}

	private static bool smethod_35(Type type_0)
	{
		return (bool)Class29.smethod_0(7512498, null, type_0);
	}

	private static bool smethod_36(MethodInfo methodInfo_0)
	{
		return (bool)Class29.smethod_0(7516072, null, methodInfo_0);
	}

	static GClass2()
	{
		Class29.smethod_0(7515606, null, null);
	}
}
