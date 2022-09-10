using System;
using System.Diagnostics;
using System.Reflection;

namespace ns4;

[GAttribute0(28)]
public class GException0 : Exception
{
	internal int int_0;

	internal object[] object_0;

	internal int int_1;

	public static Exception smethod_0(Exception exception_0, int int_2)
	{
		return smethod_11(exception_0, int_2, new object[0]);
	}

	public static Exception smethod_1(Exception exception_0, int int_2, object object_1)
	{
		return smethod_11(exception_0, int_2, new object[1] { object_1 });
	}

	public static Exception smethod_2(Exception exception_0, int int_2, object object_1, object object_2)
	{
		return smethod_11(exception_0, int_2, new object[2] { object_1, object_2 });
	}

	public static Exception smethod_3(Exception exception_0, int int_2, object object_1, object object_2, object object_3)
	{
		return smethod_11(exception_0, int_2, new object[3] { object_1, object_2, object_3 });
	}

	public static Exception smethod_4(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4)
	{
		return smethod_11(exception_0, int_2, new object[4] { object_1, object_2, object_3, object_4 });
	}

	public static Exception smethod_5(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		return smethod_11(exception_0, int_2, new object[5] { object_1, object_2, object_3, object_4, object_5 });
	}

	public static Exception smethod_6(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		return smethod_11(exception_0, int_2, new object[6] { object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	public static Exception smethod_7(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		return smethod_11(exception_0, int_2, new object[7] { object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	public static Exception smethod_8(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		return smethod_11(exception_0, int_2, new object[8] { object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	public static Exception smethod_9(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		return smethod_11(exception_0, int_2, new object[9] { object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	public static Exception smethod_10(Exception exception_0, int int_2, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9, object object_10)
	{
		return smethod_11(exception_0, int_2, new object[10] { object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9, object_10 });
	}

	public static Exception smethod_11(Exception exception_0, int int_2, object[] object_1)
	{
		if (GClass2.bool_0)
		{
			return null;
		}
		int int_3 = -1;
		try
		{
			StackTrace stackTrace = new StackTrace(exception_0);
			if (stackTrace.FrameCount > 0)
			{
				int_3 = stackTrace.GetFrame(stackTrace.FrameCount - 1)!.GetILOffset();
			}
		}
		catch
		{
		}
		GException0 value = new GException0(int_2, object_1, int_3);
		Exception ex = exception_0;
		while (ex.InnerException != null)
		{
			ex = ex.InnerException;
		}
		try
		{
			FieldInfo field = typeof(Exception).GetField("楟湮牥硅散瑰潩", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if ((object)field != null)
			{
				field.SetValue(ex, value);
				return exception_0;
			}
			return exception_0;
		}
		catch
		{
			return exception_0;
		}
	}

	internal GException0(int int_2, object[] object_1, int int_3)
		: base(string.Format("浓牡䕴捸灥楴湯䍳牯\u2e65湕慨摮敬䕤捸灥楴湯䀠笠細\u202c景獦瑥笺紱", int_2, int_3))
	{
		int_0 = int_2;
		object_0 = object_1;
		int_1 = int_3;
	}
}
