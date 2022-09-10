using System;
using System.Reflection;
using System.Text;

namespace ns0;

internal class Class16
{
	internal static bool bool_0 = true;

	public static bool Boolean_0
	{
		get
		{
			try
			{
				return bool_0;
			}
			catch (Exception exception_)
			{
				Class9.smethod_24(exception_);
				throw;
			}
		}
	}

	public static string smethod_0(Type type_0)
	{
		try
		{
			return smethod_1(type_0, bool_1: true);
		}
		catch (Exception exception_)
		{
			Class9.smethod_25(exception_, type_0);
			throw;
		}
	}

	public static string smethod_1(Type type_0, bool bool_1)
	{
		try
		{
			if ((object)Delegate21.smethod_0(type_0) != null)
			{
				return Delegate58.smethod_0(smethod_1(Delegate21.smethod_0(type_0), bool_1), bool_1 ? "+" : ".", Delegate121.smethod_0(type_0));
			}
			return Delegate58.smethod_0(Delegate100.smethod_0(type_0), ".", Delegate121.smethod_0(type_0));
		}
		catch (Exception exception_)
		{
			Class9.smethod_26(exception_, type_0, bool_1);
			throw;
		}
	}

	public static string smethod_2(FieldInfo fieldInfo_0)
	{
		try
		{
			return Delegate58.smethod_0(smethod_1(Delegate21.smethod_0(fieldInfo_0), bool_1: false), ".", Delegate121.smethod_0(fieldInfo_0));
		}
		catch (Exception exception_)
		{
			Class9.smethod_25(exception_, fieldInfo_0);
			throw;
		}
	}

	public static string smethod_3(MethodInfo methodInfo_0)
	{
		StringBuilder stringBuilder = default(StringBuilder);
		Type[] array = default(Type[]);
		int i = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		int j = default(int);
		string text = default(string);
		try
		{
			stringBuilder = Delegate64.smethod_0();
			Delegate18.smethod_0(stringBuilder, smethod_1(Delegate21.smethod_0(methodInfo_0), bool_1: false));
			Delegate18.smethod_0(stringBuilder, ".");
			Delegate18.smethod_0(stringBuilder, Delegate121.smethod_0(methodInfo_0));
			if (Delegate102.smethod_0(methodInfo_0))
			{
				array = Delegate48.smethod_0(methodInfo_0);
				Delegate18.smethod_0(stringBuilder, "[");
				for (i = 0; i < array.Length; i++)
				{
					if (i > 0)
					{
						Delegate18.smethod_0(stringBuilder, ",");
					}
					Delegate18.smethod_0(stringBuilder, Delegate121.smethod_0(array[i]));
				}
				Delegate18.smethod_0(stringBuilder, "]");
			}
			Delegate18.smethod_0(stringBuilder, "(");
			array2 = Delegate84.smethod_0(methodInfo_0);
			for (j = 0; j < array2.Length; j++)
			{
				if (j > 0)
				{
					Delegate18.smethod_0(stringBuilder, ", ");
				}
				text = "<UnknownType>";
				if ((object)Delegate93.smethod_0(array2[j]) != null)
				{
					text = Delegate121.smethod_0(Delegate93.smethod_0(array2[j]));
				}
				Delegate18.smethod_0(stringBuilder, Delegate58.smethod_0(text, " ", Delegate9.smethod_0(array2[j])));
			}
			Delegate18.smethod_0(stringBuilder, ")");
			return Delegate61.smethod_1(stringBuilder);
		}
		catch (Exception exception_)
		{
			Class9.smethod_31(exception_, methodInfo_0, stringBuilder, array, i, array2, j, text);
			throw;
		}
	}
}
