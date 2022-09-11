using System;
using System.IO;
using System.Reflection;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns12;

internal sealed class Class182
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string smethod_0(string string_0)
	{
		string text = smethod_1(string_0);
		if (text != null)
		{
			return text;
		}
		return smethod_1(getString_0(107371562) + string_0);
	}

	public static string smethod_1(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name = executingAssembly.GetName().Name + getString_0(107399061) + string_0.Replace(getString_0(107397564), getString_0(107410727)).Replace(getString_0(107397610), getString_0(107399061)).Replace(getString_0(107411027), getString_0(107399061));
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
		if (manifestResourceStream == null)
		{
			return null;
		}
		using StreamReader streamReader = new StreamReader(manifestResourceStream, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	static Class182()
	{
		Strings.CreateGetStringDelegate(typeof(Class182));
	}
}
