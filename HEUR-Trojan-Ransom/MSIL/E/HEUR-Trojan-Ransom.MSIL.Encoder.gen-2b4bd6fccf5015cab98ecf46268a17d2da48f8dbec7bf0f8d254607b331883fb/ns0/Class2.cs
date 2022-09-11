using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace ns0;

internal sealed class Class2
{
	private static Class2 class2_0;

	private List<string> list_0 = new List<string>();

	private string[] string_0;

	internal string string_1;

	internal string string_2;

	public int Int32_0 => list_0.Count;

	public bool Boolean_0 => ((ICollection<string>)list_0).IsReadOnly;

	public string this[int int_0] => list_0[int_0];

	private static Class2 smethod_0()
	{
		if (class2_0 == null)
		{
			Class2 value = new Class2();
			Interlocked.CompareExchange(ref class2_0, value, null);
		}
		return class2_0;
	}

	public static string smethod_1(string string_3, params object[] object_0)
	{
		if (smethod_0() == null)
		{
			return null;
		}
		string text = "";
		if (object_0 != null && object_0.Length != 0)
		{
			for (int i = 0; i < object_0.Length; i++)
			{
				if (object_0[i] is string text2 && text2.Length > 1024)
				{
					object_0[i] = text2.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, text, object_0);
		}
		return text;
	}

	internal static string smethod_2(object object_0, object object_1, object object_2)
	{
		return smethod_1(" ", object_0, object_1, object_2);
	}

	internal static string smethod_3(object object_0, object object_1)
	{
		return smethod_1(" ", object_0, object_1);
	}

	public void method_0(string string_3)
	{
		if (File.Exists(string_3))
		{
			string extension = Path.GetExtension(string_3);
			if (!string_0.Contains<string>(extension, StringComparer.OrdinalIgnoreCase))
			{
				throw new Exception0(smethod_2(extension, string_1, string_2), Class1.Enum0.const_6);
			}
			list_0.Add(string_3);
		}
		else
		{
			if (!Directory.Exists(string_3))
			{
				throw new Exception0(smethod_3(string_3, string_1), Class1.Enum0.const_7);
			}
			list_0.AddRange(Directory.GetFiles(string_3, "*" + string_2, SearchOption.TopDirectoryOnly));
		}
	}

	public void method_1()
	{
		list_0.Clear();
	}

	public bool method_2(string string_3)
	{
		return list_0.Contains(string_3);
	}

	public void method_3(string[] string_3, int int_0)
	{
		list_0.CopyTo(string_3, int_0);
	}

	public bool method_4(string string_3)
	{
		return list_0.Remove(string_3);
	}

	public IEnumerator<string> method_5()
	{
		return list_0.GetEnumerator();
	}
}
