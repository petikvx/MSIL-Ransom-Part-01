using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ns2;

namespace ns1;

internal sealed class Class1 : PictureBox
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 38)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[19];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0(byte[] byte_1, byte[] byte_2, int int_0)
	{
		byte_1[int_0] ^= byte_2[int_0 % byte_2.Length];
	}

	static Class1()
	{
		char[] array = new char[8];
		array[5] = '⢮';
		array[7] = 'ڍ';
		array[3] = 'ਤ';
		array[4] = '╺';
		array[0] = 'Ձ';
		array[6] = '㪀';
		array[1] = '⢸';
		array[2] = '㸛';
		array_2 = new string[5];
		array_0 = array;
	}

	unsafe static void okotenujejik0(object object_0)
	{
		//IL_0055: Expected O, but got I4
		//IL_005a: Expected I4, but got O
		//IL_0067: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_009a: Expected I4, but got O
		//IL_009b: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected I4, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_013c: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01b7: Expected I4, but got O
		//IL_01c3: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected I4, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_024f: Expected I4, but got O
		//IL_0250: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected I4, but got Unknown
		//IL_02ab: Expected O, but got I4
		//IL_0309: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_0367: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_03b7: Expected O, but got I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected I4, but got Unknown
		//IL_03c6: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		//IL_042d: Expected O, but got I4
		//IL_0436: Expected I4, but got O
		//IL_0437: Expected O, but got I4
		//IL_0446: Expected O, but got I4
		//IL_0452: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_049a: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		//IL_0521: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_0550: Expected O, but got I4
		//IL_0594: Expected O, but got I4
		//IL_05a8: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		//IL_05f6: Expected O, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected I4, but got Unknown
		//IL_0613: Expected O, but got I4
		//IL_0624: Expected O, but got I4
		//IL_064c: Expected O, but got I4
		//IL_0672: Expected O, but got I4
		//IL_0680: Expected I4, but got O
		//IL_0687: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06c9: Expected O, but got I4
		//IL_06e5: Expected O, but got I4
		//IL_071b: Expected O, but got I4
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got I4
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected Ref, but got Unknown
		//IL_0755: Expected O, but got I4
		//IL_076e: Expected O, but got I4
		//IL_079b: Expected O, but got I4
		//IL_07dd: Expected O, but got I4
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Ref, but got Unknown
		//IL_0800: Expected O, but got I4
		//IL_080d: Expected O, but got I4
		//IL_0813: Expected I4, but got O
		//IL_0841: Expected O, but got I4
		//IL_0878: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		_ = (string)(object)Class4.smethod_0(((byte*)null)->ToString(), resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		string obj = (string)(object)Class4.smethod_0(null, (ResolveEventArgs)(object)text.GetEnumerator());
		NumberStyles numberStyles = default(NumberStyles);
		text = "MOYWYH";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
		object obj2 = byte.Parse(s, default(NumberStyles));
		numberStyles = (NumberStyles)((obj2 is NumberStyles) ? obj2 : null);
		string obj3 = byte.Parse("IDPBNTDAF", numberStyles, "VVBFHD".StartsWith(text) as IFormatProvider) as string;
		string s2 = text;
		object obj4 = Control1.smethod_0(resolveEventArgs_);
		object obj5 = ((obj4 is NumberStyles) ? obj4 : null);
		IFormatProvider provider = byte.Parse(text) as IFormatProvider;
		object obj6 = byte.Parse(s2, (NumberStyles)obj5, provider);
		_003F val = ((obj6 is int) ? obj6 : null) / -552935042;
		int num = (int)((byte*)104)->ToString();
		object obj7 = "IEHUA".Equals(text);
		_003F val2 = val / (num / ((obj7 is int) ? obj7 : null)) / (int)Settings.Default;
		StringComparison stringComparison = default(StringComparison);
		stringComparison = default(StringComparison);
		byte b = 60;
		stringComparison = (StringComparison)((byte*)60)->ToString(text);
		stringComparison = default(StringComparison);
		string s3 = obj3.IndexOf("DMPWE", (int)val2, stringComparison) as string;
		string format = text;
		object obj8 = null;
		string text2 = string.Format(format, obj8, obj8, obj8);
		string text3 = text;
		string text4 = text;
		char c = c;
		char oldChar = c;
		char num2 = (char)Settings.Default;
		string.Concat(null, null, obj8);
		text = string.IsNullOrWhiteSpace(text) as string;
		text = "BK";
		string text5 = text;
		char[] array = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		NormalizationForm normalizationForm = (NormalizationForm)text6.PadRight((int)text5.Split(array, (int)text.Split(array)), '\ude9c');
		int num3;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
			num3 = num2 - unchecked((char)text7.Normalize(normalizationForm));
		}
		object obj9 = string.Equals(text, ((byte*)1)->CompareTo(((byte*)/*isinst with value type is only supported in some contexts*/)->GetTypeCode() as object) as string, (StringComparison)/*isinst with value type is only supported in some contexts*/);
		string text8 = text4.Replace(oldChar, (char)checked(num3 - 34472 * ((obj9 is char) ? obj9 : null)));
		string text9 = text;
		array = array;
		array = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] trimChars);
		int num4 = (int)text9.TrimStart(trimChars);
		uint startIndex;
		checked
		{
			startIndex = unchecked((uint)num4) + unchecked((uint)(int)Settings.Default);
			provider = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		int totalWidth = text8.IndexOf("MPGFCUOH", (int)startIndex, (int)((byte*)60)->ToString(formatProvider));
		string s4 = text;
		numberStyles = default(NumberStyles);
		string obj10 = byte.Parse(s4, numberStyles, provider) as string;
		string[] separator = (string[])(object)text.ToUpper();
		StringSplitOptions stringSplitOptions = default(StringSplitOptions);
		text = text3.PadRight(totalWidth, (char)checked(unchecked((uint)(char)obj10.Split(separator, default(StringSplitOptions))) - 44034u));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
		text = text10;
		string obj11 = (string)(object)Settings.Default;
		string value = text;
		string text11 = text;
		text = "MTUQO";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value2);
		string strA = text11.StartsWith(value2, stringComparison) as string;
		object obj12 = "TXD" + ((string.Equals("HDUVYQX", text, stringComparison) as string).IsNormalized() as string) + (string.Compare((string)(object)Settings.Default, ((byte*)60)->CompareTo(6), text, (int)checked(2763559705u * unchecked((uint)num4)), (int)((uint)num4 / 2511952741u), null, (CompareOptions)Settings.Default) as string);
		text = "ZHUHUX";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text12);
		obj8 = text12.TrimStart(Control1.smethod_0(resolveEventArgs_) as char[]);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj13);
		obj8 = obj13;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj14);
		text = Control1.smethod_0((ResolveEventArgs)(object)string.Concat(null, obj12, obj14)) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB);
		object obj15 = string.CompareOrdinal(strA, strB);
		b = (byte)checked(60 * ((obj15 is byte) ? obj15 : null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		object obj16 = ((byte*)b2)->GetHashCode();
		stringComparison = (StringComparison)((byte*)((obj16 is byte) ? obj16 : null))->ToString();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
		char[] separator2 = obj11.EndsWith(value, comparisonType) as char[];
		int count = num4;
		object obj17 = Control1.smethod_0(null);
		stringSplitOptions = (StringSplitOptions)((byte*)((obj17 is byte) ? obj17 : null))->ToString(((byte*)b)->ToString((IFormatProvider?)null), provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions2);
		stringSplitOptions = stringSplitOptions2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions options);
		object obj18 = byte.Parse(s3, (IFormatProvider)(object)text2.Replace((char)checked(unchecked((uint)(char)text13.Split(separator2, count, options)) - 14028u), c));
		string obj19 = obj.IndexOf((char)(int)((obj18 is char) ? obj18 : null)) as string;
		string s5 = text;
		numberStyles = numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
		text = (obj19.LastIndexOf(byte.Parse(s5, style) as string, num4) as string).Remove(-1856299146, (int)checked(unchecked((uint)(int)Class4.smethod_0(obj8, resolveEventArgs_)) * 3488794654u));
		string value3 = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		bool ignoreCase = (flag = flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		CultureInfo culture = byte.TryParse("UGTCF", out result) as CultureInfo;
		resolveEventArgs_ = "LXPB".EndsWith(value3, ignoreCase, culture) as ResolveEventArgs;
		_ = (Class2)(object)Class4.smethod_0(null, resolveEventArgs_);
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		_ = (_003CPrivateImplementationDetails_003E)(object)Settings.Default;
		_ = (Class1)(object)Settings.Default;
		_ = "XSOVQJJN".IsNormalized(normalizationForm) is Class1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		while (true)
		{
			if (!flag)
			{
				flag = flag;
				if (checked(1u + (flag2 ? 1u : 0u)) == 0)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		if ("EGKXK"[num4] is bool)
		{
			try
			{
				text = "XUTD";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text14);
				text = text14;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
				text = text15;
			}
			finally
			{
				while (true)
				{
					byte num5 = b;
					array2 = array2;
					_ = ((byte*)(num5 / (byte)Control4.smethod_1(array2)))->Equals((byte)checked(228u * unchecked((uint)b))) is string;
				}
			}
		}
		_ = string.Compare(text, text) is byte;
		text = byte.Parse(text, numberStyles) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] anyOf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] trimChars2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA2);
		while (true)
		{
			object obj20 = "PND".LastIndexOf(text);
			object obj21 = ((obj20 is byte) ? obj20 : null);
			string text16 = text;
			int startIndex2 = (int)text.Trim(null);
			string separator3 = text;
			byte num6 = b;
			string text17 = text;
			array = text.GetHashCode() as char[];
			string text18 = text;
			array2 = array2;
			object obj22 = byte.Parse((string)(object)Control4.smethod_1(array3), provider);
			string obj23 = (text18.Insert((int)((obj22 is int) ? obj22 : null), "YA") == text) as string;
			string value4 = text;
			string text19 = text;
			string obj24 = (string)(object)Settings.Default;
			string value5 = text;
			num4 = -830340709;
			stringComparison = default(StringComparison);
			array = obj24.IndexOf(value5, startIndex3, stringComparison) as char[];
			_ = (string[])(object)((byte*)num6)->ToString("ZGJDGWV", text17.IndexOfAny(anyOf, -1861432190, (int)((uint)(int)Control4.smethod_1(obj23.IndexOf(value4, (int)text19.TrimEnd(trimChars2)) as byte[]) / (uint)((byte*)b)->GetHashCode())) as IFormatProvider);
			_ = (string[])(object)Settings.Default;
			b = 115;
			object obj25 = ((byte*)checked(unchecked((uint)(byte)string.Concat(obj8)) - 115u))->GetHashCode();
			_003F val3 = b3 / ((obj25 is byte) ? obj25 : null);
			object obj26 = ((byte*)79)->Equals(232);
			string[] value6 = (string[])(object)((byte*)(val3 / ((obj26 is byte) ? obj26 : null)))->ToString();
			string separator4 = text16.LastIndexOf("LPUCWTN", startIndex2, (int)string.Join(separator3, value6)) as string;
			IEnumerable<_0021_00210> values = null;
			if (!((byte*)obj21)->Equals(((byte*)114)->Equals((byte)string.Join<T>(separator4, (IEnumerable<T>)values)) as object))
			{
				break;
			}
			string s6 = text;
			numberStyles = default(NumberStyles);
			numberStyles = numberStyles2;
			numberStyles = default(NumberStyles);
			array4 = array4;
			string text20 = string.Concat(array4);
			numberStyles = default(NumberStyles);
			string obj27 = byte.Parse(s6, style2, (IFormatProvider)(object)text20.Split(byte.Parse("IX", numberStyles) as char[])) as string;
			char[] anyOf2 = array;
			string text21 = text;
			char[] separator5 = array;
			text = text;
			int num7 = (int)(string.CompareOrdinal(strA2, 1465652805, text, text.LastIndexOf(text.PadLeft((int)((uint)num4 / 709257434u), '\u0001'), num4), num4) as string).PadRight(num4);
			object obj28 = Control1.smethod_0(resolveEventArgs_);
			_ = obj27.IndexOfAny(anyOf2, -1458101598, (int)((uint)(int)text21.Split(separator5, checked(num7 + ((obj28 is int) ? obj28 : null)), stringSplitOptions) / 2966769616u)) is Control1;
		}
		try
		{
			void @void = @void;
			@void = @void;
			_ = ((byte*)(byte)Control4.smethod_1(array2))->CompareTo(147) is byte;
		}
		catch
		{
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string b5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string separator6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
			while (byte.Parse("PQLULC", numberStyles, provider) is bool)
			{
				text = "TALXMZB";
				string[] value7 = (string[])(object)Class4.smethod_0(obj8, (ResolveEventArgs)(object)Control4.smethod_1(null));
				object obj30 = byte.TryParse(text, out *(byte*)null);
				object obj31 = ((obj30 is byte) ? obj30 : null);
				b = byte.Parse(text);
				object obj32;
				checked
				{
					_ = unchecked((uint)((byte*)checked(obj31 * b4))->GetHashCode()) + unchecked((uint)num4);
					text = Control1.smethod_0(null) as string;
					obj32 = string.Equals("JE", b5);
				}
				num4 = (int)((obj32 is int) ? obj32 : null);
				num4 = num8;
				string.Join(separator6, value7, -930070212, (int)checked(297069155u + unchecked((uint)num9) - unchecked((uint)(int)Control4.smethod_1(array2))));
			}
		}
		finally
		{
			_ = (Control4)(object)Control4.smethod_1(null);
			goto IL_085a;
		}
		IL_085a:
		checked
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture2);
				while (true)
				{
					culture = "GBOUHOAB".IndexOf(text, stringComparison) as CultureInfo;
					if (1u * unchecked((((byte)((byte*)byte.Parse("DGPVDPDCK".ToUpper(culture2)))->ToString((IFormatProvider?)null) != 0) ? 1u : 0u) / 0u) != 0)
					{
						text = "DLEYYB";
						continue;
					}
					break;
				}
			}
			catch
			{
				while (flag)
				{
				}
			}
			text = "EDYTNQB";
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text22);
			_ = (Settings)text22.Clone();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Control3 control);
			while (true)
			{
				if (flag)
				{
					settings = settings;
					settings = null;
					settings = null;
					text = "VD";
					_ = (Control2)(object)"XPHMMUENX".Split((string[]?)null, stringSplitOptions);
					control = control;
					control = null;
				}
				else if ((flag ? 1u : 0u) + 0u == 0)
				{
					break;
				}
			}
			try
			{
				text = "P";
			}
			finally
			{
				do
				{
					b = b;
				}
				while ((flag ? 1u : 0u) * unchecked((flag ? 1u : 0u) / (((byte)string.Format(text, null, obj8, null) != 0) ? 1u : 0u)) != 0);
				goto IL_0916;
			}
		}
		IL_0916:
		while (true)
		{
		}
	}
}
