using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using mono;
using ns1;
using ns2;

namespace ns0;

public class GClass0
{
	static GClass0()
	{
		Control4.smethod_0();
		cc.smethod_0();
	}

	[STAThread]
	public static void Main()
	{
		Random random = new Random();
		int[] array = new int[10];
		for (int i = 0; i < 10; i++)
		{
			int num = (array[i] = random.Next(10));
		}
		Program.Main();
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Control1.smethod_0(resolveEventArgs_0))
		{
			return null;
		}
		return Control3.assembly_0;
	}

	unsafe static void esawasogil1()
	{
		//IL_006a: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		//IL_00c1: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_011e: Expected I4, but got O
		//IL_012d: Expected O, but got I4
		//IL_0136: Expected I4, but got O
		//IL_0137: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Ref, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_01bd: Expected O, but got I4
		//IL_0206: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_02bf: Expected O, but got I4
		//IL_02c8: Expected I4, but got O
		//IL_02c9: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_0307: Expected O, but got I4
		//IL_030d: Expected I4, but got O
		//IL_0321: Expected O, but got I4
		//IL_0330: Expected O, but got I4
		//IL_033f: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_0350: Expected I4, but got O
		//IL_0358: Expected I4, but got O
		//IL_0359: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_03c2: Expected O, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got I4
		//IL_03fc: Expected O, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected I4, but got Unknown
		//IL_0407: Expected O, but got I4
		//IL_041a: Expected O, but got I4
		//IL_0445: Expected Ref, but got Unknown
		//IL_0446: Expected O, but got I4
		//IL_0452: Expected O, but got I4
		//IL_0461: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_049d: Expected O, but got I4
		//IL_04a7: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		//IL_04f6: Expected O, but got I4
		//IL_0502: Expected O, but got I4
		//IL_0536: Expected O, but got I4
		//IL_053f: Expected I4, but got O
		//IL_0577: Expected O, but got I4
		//IL_0582: Expected I4, but got O
		//IL_0583: Expected O, but got I4
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected I4, but got Unknown
		//IL_05a7: Expected O, but got I4
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Ref, but got Unknown
		//IL_05da: Expected O, but got I4
		//IL_05ed: Expected I4, but got O
		//IL_05ee: Expected O, but got I4
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Ref, but got Unknown
		//IL_0613: Expected O, but got I4
		//IL_0644: Expected O, but got I4
		//IL_064f: Expected O, but got I4
		//IL_0668: Expected O, but got I4
		//IL_0679: Expected O, but got I4
		//IL_0689: Expected O, but got I4
		//IL_06d4: Expected O, but got I4
		//IL_06e0: Expected O, but got I4
		//IL_0713: Expected O, but got I4
		//IL_072b: Expected I4, but got O
		//IL_074f: Expected O, but got I4
		//IL_075a: Expected O, but got I4
		//IL_077c: Expected O, but got I4
		//IL_0782: Expected I4, but got O
		//IL_07ae: Expected O, but got I4
		//IL_0802: Expected O, but got I4
		//IL_084d: Expected O, but got I4
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected O, but got I4
		//IL_0887: Expected O, but got I4
		//IL_0890: Expected Ref, but got Unknown
		//IL_08d7: Expected O, but got I4
		//IL_08e9: Expected O, but got I4
		//IL_08f3: Expected O, but got I4
		//IL_08f9: Expected I4, but got O
		//IL_0903: Expected O, but got I4
		//IL_0923: Expected O, but got I4
		//IL_0932: Expected O, but got I4
		//IL_0941: Expected O, but got I4
		//IL_09b7: Expected O, but got I4
		//IL_09c0: Expected I4, but got O
		//IL_09cd: Expected O, but got I4
		//IL_09d8: Expected O, but got I4
		//IL_0a02: Expected O, but got I4
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected I4, but got Unknown
		//IL_0a1a: Expected O, but got I4
		//IL_0a2b: Expected O, but got I4
		//IL_0a31: Expected I4, but got O
		//IL_0a48: Expected O, but got I4
		//IL_0a6e: Expected O, but got I4
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected I4, but got Unknown
		//IL_0a88: Expected O, but got I4
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected I4, but got Unknown
		//IL_0ad6: Expected O, but got I4
		//IL_0aed: Expected O, but got I4
		//IL_0b0d: Expected O, but got I4
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected Ref, but got Unknown
		//IL_0b2e: Expected O, but got I4
		//IL_0b3a: Expected O, but got I4
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got I4
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected O, but got I4
		//IL_0b87: Expected I4, but got O
		//IL_0b87: Expected I4, but got Unknown
		//IL_0b99: Expected O, but got I4
		//IL_0ba8: Expected O, but got I4
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Expected I4, but got Unknown
		//IL_0bb4: Expected O, but got I4
		//IL_0bf6: Expected O, but got I4
		//IL_0c0a: Expected O, but got I4
		//IL_0c1d: Expected O, but got I4
		//IL_0c91: Expected O, but got I4
		void @void = @void;
		@void = default(void);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string format);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexB);
			while (true)
			{
				text = text.ToLowerInvariant();
				string s = text;
				string strA = (string)(object)text.GetEnumerator();
				num = -924608000;
				uint num2 = checked(1750756178u * 3370359296u);
				string separator = text;
				array = array;
				string obj = (string)(object)Control4.smethod_1((byte[])(object)string.Join(separator, array));
				string value = text;
				b = 37;
				object obj2 = ((byte*)37)->GetTypeCode();
				object obj3 = ((obj2 is byte) ? obj2 : null);
				text = text;
				formatProvider = null;
				comparisonType = (StringComparison)((byte*)obj3)->ToString(text2, formatProvider);
				object obj4 = obj.Equals(value, comparisonType);
				num = -1271552413 / ((obj4 is int) ? obj4 : null);
				uint indexA;
				NumberStyles style;
				IFormatProvider provider;
				checked
				{
					indexA = num2 + unchecked((uint)num3);
					numberStyles = default(NumberStyles);
					style = numberStyles;
					provider = formatProvider;
					b = 41;
					b = b2;
				}
				IFormatProvider provider2 = ((byte*)checked(unchecked((uint)b3) * 113u))->CompareTo(byte.Parse(text, numberStyles) as object) as IFormatProvider;
				text = "RDJYXY";
				reference = ref *(byte*)string.Format(provider2, format, array);
				string strB = byte.TryParse("II", style, provider, out reference) as string;
				formatProvider = null;
				num = (int)((byte*)40)->ToString(formatProvider2);
				num = num4;
				num = num5;
				object obj5 = string.Compare(strA, (int)indexA, strB, indexB, -1566483724);
				numberStyles = (NumberStyles)((obj5 is NumberStyles) ? obj5 : null);
				NumberStyles style2 = numberStyles;
				string text3 = text;
				object obj6 = ((byte*)148)->Equals(null);
				byte num6 = byte.Parse(s, style2, text3.IsNormalized((NormalizationForm)((obj6 is NormalizationForm) ? obj6 : null)) as IFormatProvider);
				string format2 = text;
				IEnumerable<string> enumerable = null;
				uint num7;
				object obj7;
				checked
				{
					num7 = 71u - unchecked((uint)(byte)((byte*)checked(180u * unchecked((uint)(byte)string.Format(format2, (object[])(object)string.Concat(enumerable)))))->ToString(formatProvider) / 11u);
					obj7 = text.LastIndexOf(text, comparisonType);
				}
				if (((byte*)checked(num6 + (num7 + ((obj7 is byte) ? obj7 : null))))->GetHashCode() is bool)
				{
					@void = default(void);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		bool num8 = flag;
		ResolveEventArgs resolveEventArgs = null;
		uint num9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj9);
		checked
		{
			_ = (num8 ? 1u : 0u) - (Control1.smethod_0(resolveEventArgs) ? 1u : 0u);
			num9 = unchecked((uint)b) + 38u;
			obj9 = obj9;
		}
		_ = ((byte*)num9)->CompareTo(obj9) is bool;
		flag = false;
		Control4.smethod_1((byte[])(object)smethod_0(obj9, resolveEventArgs));
		string strA2 = text;
		string strB2 = text;
		text = "SSUOLX";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		text = text4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		object obj10 = string.IsNullOrEmpty((string)(object)text5.ToCharArray());
		object obj11 = ((obj10 is int) ? obj10 : null);
		text = "WJDT";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		text = text6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
		string strA3 = text7.Remove((int)((uint)num / (uint)num / (uint)num));
		b = 76;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		_ = string.Compare(strA3, (int)((byte*)b4)->ToString(text), string.Format(text, byte.TryParse("MDMB", out reference) as object), -69557992, -1921536415, comparisonType) is CompareOptions;
		obj9 = obj9;
		string[] array2 = array2;
		string[] separator2 = array2;
		uint count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions);
		checked
		{
			count = unchecked((uint)num) - (unchecked((uint)num) - 801360926u);
			stringSplitOptions = stringSplitOptions;
			stringSplitOptions = default(StringSplitOptions);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj12);
		text = string.Concat(obj12, "OBNLED".Split(separator2, (int)count, stringSplitOptions));
		string strB3 = (string)(object)smethod_0(null, resolveEventArgs);
		b = 233;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
		ref _003F reference2 = ref *(_003F*)checked(unchecked((uint)b5) - 233u);
		object obj13 = text.GetTypeCode();
		_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).CompareTo((byte)(int)((obj13 is byte) ? obj13 : null)) is CultureInfo;
		byte num10 = byte.Parse(text, numberStyles);
		obj9 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value2);
		_ = ((byte*)num10)->CompareTo(value2) is ref byte;
		reference = ref reference;
		object obj14 = ((byte*)(byte)"LKTD".ToUpperInvariant())->GetTypeCode();
		numberStyles = (NumberStyles)((obj14 is NumberStyles) ? obj14 : null);
		object obj15 = byte.TryParse("K", default(NumberStyles), formatProvider, out reference);
		reference = ref *(byte*)((obj15 is ref byte) ? obj15 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		CultureInfo cultureInfo = byte.TryParse("UHMZD", out result) as CultureInfo;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA4);
		object obj16 = string.Compare(strA4, strB3, ignoreCase: false, cultureInfo);
		object obj17 = ((byte*)((obj16 is byte) ? obj16 : null))->Equals(null);
		CompareOptions options = (CompareOptions)((obj17 is CompareOptions) ? obj17 : null);
		Control4 control = string.Compare(strA2, 1315707527, strB2, -1779607216, (int)obj11, null, options) as Control4;
		control = control;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		try
		{
			b = b;
			string strA5 = text;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB4);
			_ = string.Compare(strA5, strB4) is string;
			byte num11 = (byte)((byte*)168)->ToString(text, formatProvider);
			array3 = array3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array4);
			array3 = array4;
			uint num12 = (uint)(byte)Control4.smethod_1(array3) / 67u;
			string text8 = text;
			string value3 = text;
			_003F val;
			checked
			{
				uint num13 = 47u * unchecked((uint)b);
				object obj18 = unchecked((byte*)163)->GetTypeCode();
				val = unchecked(num13 / ((obj18 is byte) ? obj18 : null)) + 108;
			}
			b = (byte)string.Format(formatProvider, byte.Parse(text) as string, obj9, null, null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
			ref _003F reference3 = ref *(_003F*)b6;
			object obj19 = "MB".GetHashCode();
			object obj20 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).Equals((byte)checked(37 - ((obj19 is byte) ? obj19 : null)));
			object obj21 = ((obj20 is byte) ? obj20 : null);
			obj9 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj22);
			obj9 = obj22;
			ref _003F reference4 = ref *(_003F*)val;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object value4);
			object obj23 = ((byte*)obj21)->CompareTo(value4);
			object obj24 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference4).Equals(string.Format((IFormatProvider)(object)((byte*)((obj23 is byte) ? obj23 : null))->ToString("XU", formatProvider), text, obj9, obj9, obj9));
			object obj25 = ((obj24 is byte) ? obj24 : null);
			object obj26 = (Control1.smethod_0(resolveEventArgs) as string).LastIndexOf("CQHEAYNY");
			object obj27 = ((obj26 is byte) ? obj26 : null);
			byte num14 = (byte)Control4.smethod_1(array3);
			obj9 = ((byte*)3068)->Equals(160) as object;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_);
			text = Control1.smethod_0(byte.TryParse((string)(object)smethod_0(object_, resolveEventArgs), out reference) as ResolveEventArgs) as string;
			byte num15 = b;
			string text9 = text;
			uint startIndex;
			int num16;
			object arg;
			checked
			{
				startIndex = unchecked((uint)num) * 1443660360u + (unchecked((uint)num) + (unchecked((uint)num) + 4013833608u));
				num16 = num;
				text = byte.Parse(text, null) as string;
				arg = obj9;
				obj9 = obj9;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string format3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
			string s2 = byte.Parse("SSFU".IndexOf("BFMJE", (int)checked(unchecked((uint)num16) + unchecked((uint)(int)string.Format(format3, arg, arg2, null)))) as string, numberStyles) as string;
			numberStyles = default(NumberStyles);
			numberStyles = default(NumberStyles);
			numberStyles = (NumberStyles)Control4.smethod_1((byte[])(object)((byte*)b)->ToString());
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
			object obj28 = byte.Parse(s2, style3);
			string separator3;
			IEnumerable<_0021_00210> values;
			checked
			{
				_ = unchecked((uint)(byte)text9.Substring((int)startIndex, (int)((obj28 is int) ? obj28 : null))) - 242u;
				separator3 = text;
				values = null;
			}
			_ = (byte)smethod_0(string.Join<T>(separator3, (IEnumerable<T>)values), null);
			b = b;
			ref _003F reference5 = ref *(_003F*)num15;
			object obj29 = text.StartsWith(text, (byte)(int)/*isinst with value type is only supported in some contexts*/ != 0, cultureInfo);
			int num17;
			byte num18;
			checked
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
				num17 = num14 + unchecked((byte)text10.PadLeft(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference5).CompareTo((byte)(int)checked(b7 + ((obj29 is byte) ? obj29 : null)))));
				num18 = b;
				text = unchecked((byte*)169)->CompareTo(obj9) as string;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
				_ = unchecked((uint)(byte)text11.Trim()) * 162u;
				b = b;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b8);
			object obj30 = ((byte*)(obj25 / checked(unchecked(obj27 / checked(unchecked((uint)num17) * unchecked((uint)checked(num18 * b8)) * 232u)) + b)))->CompareTo(obj9);
			object obj31 = ((obj30 is bool) ? obj30 : null);
			cultureInfo = cultureInfo;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
			cultureInfo = cultureInfo2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture);
			object obj32 = text8.StartsWith(value3, (byte)(int)obj31 != 0, culture);
			string obj33 = byte.Parse(((byte*)checked(num11 + (29 - (num12 - ((obj32 is byte) ? obj32 : null)))))->ToString(formatProvider), (NumberStyles)string.Concat(array2).ToUpper()) as string;
			string text12 = text;
			numberStyles = default(NumberStyles);
			numberStyles = numberStyles;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
			numberStyles = numberStyles2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style4);
			string s3 = byte.Parse("RW", style4) as string;
			object object_2 = text.IsNormalized() as object;
			resolveEventArgs = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
			byte num19 = (byte)smethod_0(byte.TryParse("GGVRST".LastIndexOf(byte.Parse(s3, (IFormatProvider)smethod_0(object_2, resolveEventArgs_)) as string, 413593021, comparisonType) as string, numberStyles, formatProvider, out reference) as object, null);
			b = (byte)checked(26448u + unchecked((uint)b) * 88u);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b9);
			b = (byte)((uint)num19 / (uint)checked(b9 + unchecked((byte)((byte*)(byte)Control4.smethod_1(array3))->ToString(text))));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b10);
			object obj34 = ((byte*)101)->Equals((byte)checked(213u - unchecked((uint)b10) * 111u));
			string[] separator4 = ((byte*)((obj34 is byte) ? obj34 : null))->CompareTo(b) as string[];
			stringSplitOptions = default(StringSplitOptions);
			string text13 = string.Concat<T>((IEnumerable<T>)(IEnumerable<_0021_00210>)(object)text12.Split(separator4, stringSplitOptions));
			string[] separator5 = array2;
			text = text;
			ref _003F reference6 = ref *(_003F*)200;
			string strB5 = text;
			object obj35 = ((byte*)b)->Equals(obj9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA6);
			System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference6).ToString(obj33, (IFormatProvider)(object)text13.Split(separator5, (int)checked(unchecked((uint)string.Compare(strA6, -913289800, strB5, (int)((obj35 is int) ? obj35 : null), num, cultureInfo, (CompareOptions)text.ToUpper(null))) * 2436867380u), stringSplitOptions));
		}
		finally
		{
			IEnumerable<_0021_00210> values = (IEnumerable<_0021_00210>)smethod_0(obj9, byte.Parse(Control1.smethod_0(resolveEventArgs) as string, null) as ResolveEventArgs);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<_0021_00210> enumerable2);
			object obj36 = ((byte*)(byte)string.Concat<T>((IEnumerable<T>)enumerable2))->GetTypeCode();
			b = (byte)(int)((obj36 is byte) ? obj36 : null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b11);
			b = b11;
			goto IL_0788;
		}
		IL_0788:
		try
		{
			string text14 = text;
			string[] separator6 = (string[])(object)string.Format((IFormatProvider)smethod_0(obj9, resolveEventArgs), text, null, text.IndexOf(text, (int)string.Concat(array2)) as object, obj9);
			num = -1771981598;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num20);
			_ = (c)(object)text14.Split(separator6, (int)((uint)num20 / 2522985698u / (uint)((byte*)b)->CompareTo(b) / 3278922479u / 2522985698u), stringSplitOptions);
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num22);
			do
			{
				resolveEventArgs = resolveEventArgs;
				_ = Control1.smethod_0(resolveEventArgs_2) is Resources;
				resources = resources;
				resources = null;
				uint num21 = 76u / (uint)(b / b);
				string strA7 = text;
				text = text;
				text = text15;
				int hashCode = ((byte*)b)->GetHashCode();
				num = num;
				object obj37 = string.Compare(strA7, -1983430488, strB6, (int)checked(unchecked((uint)hashCode) - unchecked((uint)num22)), "IEIY".CompareTo("AVLDV"), flag);
				_003F val2 = checked(num21 + (190 - (((obj37 is byte) ? obj37 : null) - 14)));
				string s4 = Control1.smethod_0(null) as string;
				numberStyles = default(NumberStyles);
				Class2 @class = (Class2)(object)((byte*)val2)->ToString(((byte*)byte.Parse(s4, default(NumberStyles), formatProvider))->GetHashCode() as IFormatProvider);
				@class = @class;
			}
			while (flag);
		}
		control = null;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string separator7);
		string.Join(separator7, (IEnumerable<string?>)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char value6);
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object value5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text16);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text17);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b12);
				while (true)
				{
					flag = true;
					obj9 = obj9;
					object obj39 = string.Format(null, ((byte*)91)->CompareTo(value5) as string, string.Intern("ZQHVBF")).IndexOf(text, (int)checked(/*isinst with value type is only supported in some contexts*/ - unchecked(checked(2566932018u + 1740447908u) / checked(unchecked((uint)num) * unchecked((uint)num)))));
					flag = (byte)(int)checked(flag2 + ((obj39 is bool) ? obj39 : null)) != 0;
					if (flag3)
					{
						text = "JF";
						_ = byte.TryParse(text, numberStyles, null, out reference) is string;
						text = text;
						text = text16;
						object obj40 = Control1.smethod_0(text17.Length as ResolveEventArgs);
						numberStyles = (NumberStyles)((obj40 is NumberStyles) ? obj40 : null);
						cultureInfo = byte.Parse(s5, style5, formatProvider) as CultureInfo;
						NumberStyles style6 = (NumberStyles)"BKWYYDF".ToUpper(culture2);
						object obj41 = string.Compare(text, "ZCUMRAPJ", comparisonType);
						formatProvider = ((byte*)((obj41 is byte) ? obj41 : null))->Equals(79) as IFormatProvider;
						string obj42 = byte.TryParse("VDACZ", style6, provider3, out *(byte*)null) as string;
						uint num23;
						string text18;
						string text19;
						string obj43;
						string[] separator8;
						string text20;
						char[] anyOf;
						checked
						{
							num23 = unchecked((uint)b / 238u) + 120u;
							b = b;
							text18 = text;
							text19 = text;
							obj43 = (string)(object)Control4.smethod_1(array3);
							separator8 = array2;
							text20 = text;
							array5 = array5;
							anyOf = array5;
						}
						int startIndex2 = (int)((byte*)61)->ToString();
						string text21 = ((byte*)b)->ToString();
						value6 = '\ued8e';
						ref _003F reference7 = ref *(_003F*)checked(num23 + unchecked((uint)checked(b12 * unchecked((byte)("HWTJKVNH" + text18 + text19 + (byte.Parse(byte.Parse((string)(object)obj43.Split(separator8, text20.LastIndexOfAny(anyOf, startIndex2, (int)checked(4141216022u + unchecked((uint)(int)text21.PadRight(1812334188, '\ued8e')) + unchecked((uint)num))), (StringSplitOptions)/*isinst with value type is only supported in some contexts*/), formatProvider) as string, null) as string))))));
						int indexA2 = (int)Control4.smethod_1(null);
						string strB7 = text;
						int num24 = num;
						object obj44 = Control1.smethod_0(resolveEventArgs);
						object obj45;
						checked
						{
							obj45 = obj42.LastIndexOf(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference7).ToString(string.Compare("DWQNCOXLK", indexA2, strB7, num24 + unchecked(((obj44 is int) ? obj44 : null) / -5206027) - num, -270233047) as string, formatProvider));
						}
						b = (byte)(int)((obj45 is byte) ? obj45 : null);
						continue;
					}
					break;
				}
			}
			catch
			{
				GClass0 gClass = gClass;
				gClass = gClass;
			}
		}
		catch
		{
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text22);
			text = text22;
			int startIndex3 = num;
			int num25 = num;
			char[] anyOf2 = array5;
			int hashCode2 = ((byte*)(byte)text.Normalize())->GetHashCode();
			num = (Control1.smethod_0(resolveEventArgs) as string).GetHashCode();
			uint num27;
			checked
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num26);
				num27 = unchecked((uint)hashCode2) - unchecked((uint)num26);
			}
			object obj47 = ((byte*)b)->CompareTo(obj9);
			object obj48 = ((obj47 is byte) ? obj47 : null);
			IFormatProvider provider4 = formatProvider;
			reference = ref *(byte*)null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result2);
			object obj49 = byte.TryParse("J", default(NumberStyles), provider4, out result2);
			object obj50 = ((obj49 is byte) ? obj49 : null);
			b = (byte)text.Substring(1903617393);
			object obj51 = ((byte*)/*isinst with value type is only supported in some contexts*/)->Equals(obj9);
			_003F val3 = num27 / ((obj51 is int) ? obj51 : null);
			string s6 = text;
			numberStyles = (NumberStyles)Control4.smethod_1(null);
			formatProvider = (IFormatProvider)(object)((byte*)173)->ToString();
			int num28 = "Q".IndexOfAny(anyOf2, checked(val3 - /*isinst with value type is only supported in some contexts*/), (int)/*isinst with value type is only supported in some contexts*/);
			object obj52 = ((byte*)/*isinst with value type is only supported in some contexts*/)->Equals(58);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text23);
			_ = (byte)string.Format(text23.IndexOf("ZIDYGDNH", startIndex3, checked(num25 * (num28 - ((obj52 is int) ? obj52 : null)))) as string, null);
			string text24 = text;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value7);
			text = text24.IndexOf(value7, (int)smethod_0(Control4.smethod_1(array3), null), (StringComparison)string.Format(text, obj9, "CFO".LastIndexOf(value6, -231756863, num) as object)) as string;
			text = text;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text25);
			_ = text25.LastIndexOfAny(array5) is Struct3;
			Class1 class2 = class2;
			class2 = (Class1)(object)Control4.smethod_1(array3);
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture3);
			do
			{
				cultureInfo = cultureInfo;
			}
			while ((byte)"FMMGE".ToLower(culture3) != 0);
		}
		finally
		{
			_ = (byte)smethod_0(obj9, null);
			byte num29 = b;
			obj9 = obj9;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
			_ = (Control2)(object)((byte*)checked(53u - unchecked((uint)(num29 / (byte)smethod_0(object_3, null)))))->ToString();
			_ = "NVQSJNJU".IndexOfAny(array5, num) is Control2;
			text = text;
			return;
		}
	}
}
