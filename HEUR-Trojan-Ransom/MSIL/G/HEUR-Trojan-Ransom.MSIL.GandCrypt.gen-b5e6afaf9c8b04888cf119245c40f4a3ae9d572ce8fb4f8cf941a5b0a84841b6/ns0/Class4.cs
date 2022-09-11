using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using mono;

namespace ns0;

internal static class Class4
{
	static Class4()
	{
		Control3.smethod_0();
		Class0.smethod_0();
	}

	[STAThread]
	public static void Main()
	{
		Program.Main();
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Control2.smethod_0(resolveEventArgs_0))
		{
			return null;
		}
		return Control1.assembly_0;
	}

	unsafe static void imozagajoduqih7()
	{
		//IL_003e: Expected O, but got I4
		//IL_0043: Expected I4, but got O
		//IL_0050: Expected O, but got I4
		//IL_006d: Expected I4, but got O
		//IL_006e: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		string text = "CXY";
		NormalizationForm normalizationForm = default(NormalizationForm);
		uint num;
		object obj;
		checked
		{
			num = unchecked((uint)(byte)text.Normalize(default(NormalizationForm))) * 204u;
			obj = null;
		}
		object obj2 = ((byte*)num)->Equals(obj);
		NumberStyles style = (NumberStyles)((obj2 is NumberStyles) ? obj2 : null);
		IFormatProvider formatProvider = formatProvider;
		object obj3 = byte.Parse("R", style, formatProvider);
		object obj4 = ((obj3 is NumberStyles) ? obj3 : null);
		formatProvider = (IFormatProvider)(object)text.Remove(-1679502997);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		_ = "FC".Equals(byte.Parse(text, (NumberStyles)obj4, provider) as object) is byte;
		while (true)
		{
			ResolveEventArgs resolveEventArgs_ = null;
			_ = Control2.smethod_0(resolveEventArgs_) is Class2;
		}
	}
}
