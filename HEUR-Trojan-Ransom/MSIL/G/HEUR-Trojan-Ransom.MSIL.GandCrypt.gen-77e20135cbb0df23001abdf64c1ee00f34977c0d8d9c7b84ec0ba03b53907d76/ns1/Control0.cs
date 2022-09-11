using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal sealed class Control0 : UserControl
{
	public static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			Class1.smethod_0(byte_0, byte_1, i);
		}
	}

	unsafe static void egalir0()
	{
		//IL_0010: Expected O, but got I4
		//IL_001e: Expected O, but got I4
		//IL_003a: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got I4
		//IL_0101: Expected I4, but got O
		//IL_0102: Expected O, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected I4, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_0126: Expected O, but got I4
		//IL_012f: Expected I4, but got O
		//IL_0138: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0207: Expected I4, but got O
		//IL_0207: Expected I4, but got O
		//IL_021d: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_027c: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_02d1: Expected O, but got I4
		//IL_02db: Expected O, but got I4
		//IL_02e1: Expected I4, but got O
		//IL_02ea: Expected O, but got I4
		//IL_0309: Expected O, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected I4, but got Unknown
		//IL_0316: Expected O, but got I4
		string text = text;
		byte b = b;
		byte num = b;
		ResolveEventArgs resolveEventArgs = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		resolveEventArgs = resolveEventArgs2;
		object obj = Control1.smethod_0(resolveEventArgs) as object;
		_ = ((byte*)num)->Equals(obj) is string;
		text = text;
		try
		{
		}
		finally
		{
			goto IL_0029;
		}
		IL_0029:
		string s = text;
		obj = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_);
		NumberStyles numberStyles = (NumberStyles)GClass0.smethod_0(object_, byte.Parse("OSTE") as ResolveEventArgs);
		NumberStyles style = numberStyles;
		IFormatProvider formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		formatProvider = formatProvider2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		formatProvider = formatProvider3;
		void @void = GClass0.smethod_0(byte.TryParse(s, style, formatProvider, out *(byte*)null) as object, resolveEventArgs);
		void void2 = default(void);
		void2 = @void;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style5);
		while ((string)(object)GClass0.smethod_0(null, resolveEventArgs) == text)
		{
			do
			{
				string s2 = ((byte*)185)->ToString();
				NumberStyles style2 = numberStyles;
				string text2 = text;
				string[] separator = null;
				string s3 = text.StartsWith(Control1.smethod_0(null) as string) as string;
				string s4 = text;
				numberStyles = numberStyles;
				IFormatProvider provider = formatProvider;
				object obj2 = ((byte*)b)->CompareTo(188);
				_003F val = checked(((obj2 is byte) ? obj2 : null) * 176);
				string text3 = ((byte*)(byte)GClass0.smethod_0(null, resolveEventArgs))->ToString(text, null);
				num2 = -859406402;
				text = text;
				object obj3 = text3.IndexOf("EFL", -859406402, (StringComparison)/*isinst with value type is only supported in some contexts*/);
				b = (byte)checked(val * ((obj3 is byte) ? obj3 : null));
				object obj4 = byte.TryParse(s4, style3, provider, out *(byte*)((byte*)b2)->ToString(text));
				object obj5 = ((byte*)checked(byte.Parse(s3, unchecked((NumberStyles)((obj4 is NumberStyles) ? obj4 : null)), Control1.smethod_0(resolveEventArgs) as IFormatProvider) - b))->Equals(b);
				object obj6 = ((obj5 is int) ? obj5 : null);
				char oldChar = (char)string.Intern("G");
				numberStyles = default(NumberStyles);
				NumberStyles style4 = numberStyles;
				object obj7 = ((byte*)207)->GetTypeCode();
				checked
				{
					_ = unchecked((char)"VRVSDOIU".PadRight((int)GClass0.smethod_0(string.IsInterned(byte.TryParse("M", style4, null, out *(byte*)((obj7 is ref byte) ? obj7 : null)) as string), resolveEventArgs), c)) * c;
					string s6 = text;
					numberStyles = numberStyles;
					numberStyles = default(NumberStyles);
					_ = byte.Parse(s6, style5) is char;
					c = '觅';
				}
				int count = (int)obj6;
				object obj8 = string.Compare("IUI".Replace(oldChar, (char)(35269u / checked(unchecked((uint)(char)((byte*)106)->ToString()) + 45758u))), text, (byte)Control4.smethod_1(null) != 0);
				byte.Parse(s2, style2, (IFormatProvider)(object)text2.Split(separator, count, (StringSplitOptions)((obj8 is StringSplitOptions) ? obj8 : null)));
			}
			while (((byte*)220)->GetTypeCode() is bool);
		}
		try
		{
			text = ((byte*)181)->Equals(obj) as string;
		}
		finally
		{
			_ = (byte)((string)(object)text.ToCharArray((int)Control4.smethod_1(null), (int)checked(unchecked((uint)num2) - 3929804166u))).Split(byte.Parse("T", numberStyles) as char[]);
			goto IL_028d;
		}
		IL_028d:
		object obj9 = Control1.smethod_0(resolveEventArgs);
		((byte*)((obj9 is byte) ? obj9 : null))->ToString(text);
		b = 119;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		object obj10 = ((byte*)b3)->GetTypeCode();
		((byte*)((obj10 is byte) ? obj10 : null))->ToString("RLG");
		object obj11 = byte.Parse(text, ((byte*)119)->CompareTo(obj) as IFormatProvider);
		numberStyles = (NumberStyles)((obj11 is NumberStyles) ? obj11 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style6);
		text = byte.Parse("NE", style6, null) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string separator2);
		_ = (Control0)(object)string.Join(separator2, (string?[])null);
		object obj12 = Control1.smethod_0(resolveEventArgs);
		_ = ((byte*)68)->CompareTo((byte)checked(((obj12 is byte) ? obj12 : null) + 119)) is Class2;
	}

	static void esawasogileb2(object object_0, object object_1)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		do
		{
			text = text;
		}
		while ((byte)("YA" + text) != 0);
		while (true)
		{
		}
	}
}
