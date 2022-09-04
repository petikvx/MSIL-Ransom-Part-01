using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class IszHXyxOEGx
{
	public delegate object ToNFCNesOCL(string s);

	public delegate object jdHJpKPXNsC(string s);

	public delegate object CBGcjqVihxB(int s);

	public delegate object EvUjcMtwRtx(string o);

	public delegate object MJrFeeGOaDW();

	public delegate char CarSrDwPyVF(int data);

	public delegate int QWSduJRSczu(char data);

	public delegate string[] YZGMfndJEFD(string data, string delimiter, int arg1, CompareMethod arg2);

	internal static CarSrDwPyVF carSrDwPyVF_0 = (CarSrDwPyVF)wjkh();

	internal static QWSduJRSczu qwsduJRSczu_0 = (QWSduJRSczu)wjkh2();

	internal static YZGMfndJEFD yzgmfndJEFD_0 = (YZGMfndJEFD)splet();

	public static object Decopp(string string_0)
	{
		int num = 0;
		object objectValue = RuntimeHelpers.GetObjectValue(gtLeni(string_0));
		int num2 = Conversions.ToInteger(objectValue);
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				num += qwsduJRSczu_0(string_0[i]);
			}
			return num;
		}
	}

	public static object gtLeni(string o)
	{
		return checked(Strings.Len(o) - 1);
	}

	public static string smethod_0(string string_0, string string_1)
	{
		EvUjcMtwRtx evUjcMtwRtx = gtLeni;
		object objectValue = RuntimeHelpers.GetObjectValue(evUjcMtwRtx(string_0));
		List<string> list = new List<string>();
		ToNFCNesOCL toNFCNesOCL = Decopp;
		CBGcjqVihxB cBGcjqVihxB = IuuWerTmSqI.mxErn;
		object obj = Operators.SubtractObject(trmDta(string_0, 0, 0), (object)Conversions.ToInteger(toNFCNesOCL(string_1)));
		int num = Conversions.ToInteger(objectValue);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj2 = Operators.SubtractObject(Fix9(string_0, i), obj);
			list.Add(Conversions.ToString(cBGcjqVihxB(Conversions.ToInteger(obj2))));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(rLTIojjinYR.TRan9(string.Join("", list.ToArray())));
		return Conversions.ToString(objectValue2);
	}

	public static object trmDta(object arg1, object arg2, object arg3)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arg1, new object[1] { 0 }, (string[])null));
		return rLTIojjinYR.NthM(RuntimeHelpers.GetObjectValue(objectValue));
	}

	private static object Fix9(object s, object I)
	{
		return RuntimeHelpers.GetObjectValue(rLTIojjinYR.NthM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(s, new object[1] { RuntimeHelpers.GetObjectValue(I) }, (string[])null))));
	}

	public static object smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(rLTIojjinYR.Penny9());
		object obj = yzgmfndJEFD_0(Conversions.ToString(objectValue), "@", -1, (CompareMethod)0)[4];
		return Strings.Replace(Conversions.ToString(obj), rLTIojjinYR.string_0, "@", 1, -1, (CompareMethod)0);
	}

	public static object smethod_2()
	{
		return OqvJUoCpbDZ.turt9();
	}

	public static object wjkh()
	{
		return (CarSrDwPyVF)Delegate.CreateDelegate(typeof(CarSrDwPyVF), Type.GetType("System.Convert")!.GetMethod("ToChar", new Type[1] { typeof(int) }));
	}

	public static object wjkh2()
	{
		return (QWSduJRSczu)Delegate.CreateDelegate(typeof(QWSduJRSczu), typeof(Convert).GetMethod("ToInt32", new Type[1] { typeof(char) }));
	}

	public static object splet()
	{
		return (YZGMfndJEFD)Delegate.CreateDelegate(typeof(YZGMfndJEFD), typeof(Strings).GetMethod("Split", new Type[4]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(CompareMethod)
		}));
	}

	static void smethod_3()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
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
}
