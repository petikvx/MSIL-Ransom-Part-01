using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns1;

namespace ns0;

internal sealed class Control3 : Control
{
	public static void smethod_0()
	{
		new AutoResetEvent(initialState: false).WaitOne(10000, exitContext: false);
		Control1.appDomain_0 = AppDomain.CurrentDomain;
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
		}
		return byte_0;
	}

	unsafe static void imozag2()
	{
		//IL_0010: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Ref, but got Unknown
		//IL_004b: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected I4, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Ref, but got Unknown
		//IL_0196: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Ref, but got Unknown
		//IL_01e2: Expected O, but got I4
		//IL_01e7: Expected I4, but got O
		//IL_01f5: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_0298: Expected I4, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			try
			{
			}
			finally
			{
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			text = text;
			_ = string.IsNullOrWhiteSpace(text) is Control2;
			goto IL_0017;
		}
		IL_0017:
		byte b = 29;
		b = 103;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		try
		{
			try
			{
				while (true)
				{
					byte num = b;
					object obj = byte.TryParse(text, out *(byte*)null);
					_ = ((byte*)(byte)((byte*)(num / checked(unchecked(((obj is byte) ? obj : null) / b) * 49)))->ToString())->GetHashCode() is Class2;
				}
			}
			finally
			{
				byte[] array = null;
				string s = "UVF".Trim();
				object obj2 = obj2;
				object object_ = obj2;
				resolveEventArgs_ = null;
				text = "TTBNBZH";
				ref byte reference = ref *(byte*)string.Copy(Control2.smethod_0(null) as string);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
				_ = byte.TryParse(s2, out reference) is ResolveEventArgs;
				resolveEventArgs_ = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
				resolveEventArgs_ = resolveEventArgs;
				_ = (NumberStyles)Class4.smethod_0(object_, resolveEventArgs_);
				NumberStyles numberStyles = numberStyles;
				NumberStyles style = numberStyles;
				IFormatProvider provider = (IFormatProvider)(object)smethod_1(null, array);
				reference = ref reference;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference2);
				reference = ref reference2;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
				_ = (Control2)(object)smethod_1(array, byte.TryParse(s, style, provider, out result) as byte[]);
				object obj3 = Control2.smethod_0(resolveEventArgs_);
				string.Concat(((byte*)((obj3 is byte) ? obj3 : null))->GetHashCode() as object, null, obj2);
				checked
				{
					_ = 168u + unchecked((uint)byte.Parse("CRBWWUJ", ((byte*)161)->GetHashCode() as IFormatProvider));
					text = text;
				}
				b = (byte)string.Concat((IEnumerable<string>)(object)Settings.Default);
				ref _003F reference3 = ref *(_003F*)181;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
				object obj4 = ((byte*)b2)->GetHashCode();
				string format = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).Equals((byte)checked(((obj4 is byte) ? obj4 : null) - 210)) as string;
				_ = Control2.smethod_0(resolveEventArgs_) is object;
				object obj5 = string.IsNullOrEmpty("HONNRBLOJ");
				object obj6 = ((obj5 is byte) ? obj5 : null);
				object obj7 = ((byte*)b)->Equals(obj2);
				obj2 = ((byte*)(obj6 / checked(((obj7 is byte) ? obj7 : null) - unchecked(130u / (uint)(byte)Settings.Default))))->Equals(b) as object;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg);
				_ = "BBXCT".EndsWith(value, (StringComparison)string.Format(format, arg, null)) is byte;
				object obj8 = ((byte*)161)->GetHashCode();
				object obj9 = ((byte*)checked(((obj8 is byte) ? obj8 : null) * (unchecked((uint)byte.Parse(text, numberStyles)) + 117u) * 169))->Equals(177);
				b = (byte)(int)((obj9 is byte) ? obj9 : null);
				string separator = text;
				string[] value2 = ((byte*)212)->GetTypeCode() as string[];
				string text2 = text;
				int num2 = num2;
				int startIndex = (int)text2.Insert(num2, "FLTFI");
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
				_ = (byte)string.Join(separator, value2, startIndex, (int)text3.Replace("RILVQZ", text));
				b = 246;
				goto end_IL_0023;
			}
			end_IL_0023:;
		}
		finally
		{
			try
			{
			}
			catch
			{
				try
				{
					_ = (Class3)(object)Settings.Default;
				}
				catch
				{
					_ = (Control2)(object)Settings.Default;
				}
			}
			goto IL_025b;
		}
		IL_025b:
		Struct2 @struct = @struct;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		@struct = struct2;
		@struct = default(Struct2);
		object obj12 = Control2.smethod_0(Control2.smethod_0(resolveEventArgs_) as ResolveEventArgs);
		@struct = (Struct2)((obj12 is Struct2) ? obj12 : null);
		string text4 = text;
		object obj13 = byte.Parse(text);
		text4.PadLeft((int)((obj13 is int) ? obj13 : null));
		text = "FFNHTDAVF";
		while (true)
		{
			try
			{
				try
				{
					text = text;
				}
				finally
				{
					_ = (string)(object)Settings.Default;
					goto end_IL_02a6;
				}
				end_IL_02a6:;
			}
			catch
			{
			}
		}
	}

	unsafe static void imozagajod6(object object_0, object object_1, object object_2)
	{
		//IL_001e: Expected O, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got I4
		//IL_00da: Expected Ref, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_0188: Expected I4, but got O
		//IL_0188: Expected I4, but got O
		//IL_0189: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01bd: Expected I4, but got O
		//IL_01e9: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected I4, but got Unknown
		//IL_0298: Expected I4, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Ref, but got Unknown
		//IL_0319: Incompatible stack heights: 0 vs 1
		//IL_0361: Expected O, but got I4
		//IL_038e: Expected O, but got I4
		//IL_0394: Expected I4, but got O
		//IL_03ac: Expected O, but got I4
		//IL_03e0: Expected O, but got I4
		//IL_03fc: Expected O, but got I4
		//IL_0418: Expected O, but got I4
		//IL_0488: Expected O, but got I4
		//IL_04fd: Expected O, but got I4
		//IL_0550: Expected O, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Ref, but got Unknown
		//IL_0561: Expected O, but got I4
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Ref, but got Unknown
		//IL_0585: Expected O, but got I4
		//IL_05c0: Expected I4, but got O
		//IL_05c1: Expected O, but got I4
		//IL_05cc: Expected O, but got I4
		//IL_061e: Expected O, but got I4
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Ref, but got Unknown
		//IL_063a: Expected O, but got I4
		//IL_0644: Expected O, but got I4
		//IL_0693: Expected O, but got I4
		//IL_0699: Expected I4, but got O
		//IL_06a1: Expected O, but got I4
		//IL_06e6: Expected O, but got I4
		//IL_06fd: Expected O, but got I4
		//IL_072f: Expected O, but got I4
		//IL_074c: Expected O, but got I4
		//IL_0768: Expected O, but got I4
		//IL_0783: Expected O, but got I4
		//IL_079a: Expected O, but got I4
		//IL_07a4: Expected O, but got I4
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got I4
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected I4, but got Unknown
		//IL_07c1: Expected O, but got I4
		//IL_07e2: Expected O, but got I4
		//IL_07eb: Expected I4, but got O
		//IL_07ec: Expected O, but got I4
		//IL_07f8: Expected O, but got I4
		//IL_0802: Expected O, but got I4
		//IL_0819: Expected O, but got I4
		//IL_0827: Expected O, but got I4
		//IL_082d: Expected I4, but got O
		//IL_0881: Expected O, but got I4
		//IL_08d3: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
		NumberStyles numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		int num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string format);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		byte b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out void @void);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		while (true)
		{
			text = text;
			formatProvider = formatProvider;
			object obj = byte.Parse(s, formatProvider) as object;
			text = text;
			text = text;
			int num = (int)text2.Trim(null);
			num2 = 461497677;
			object obj2 = text3.LastIndexOfAny(null, (int)((uint)num / 461497677u / 461497677u), 1218619624) as object;
			obj3 = obj3;
			object obj4 = obj3;
			text = (string)(object)Settings.Default;
			string strA = text;
			b = 65;
			resolveEventArgs = resolveEventArgs;
			resolveEventArgs = resolveEventArgs2;
			object obj5 = Control2.smethod_0(resolveEventArgs);
			_003F val = checked(65 * ((obj5 is byte) ? obj5 : null));
			text = "PBBJH";
			numberStyles = default(NumberStyles);
			numberStyles = default(NumberStyles);
			object obj6 = byte.Parse(((byte*)val)->ToString(byte.Parse(s2, numberStyles, null) as string));
			object obj7 = ((obj6 is int) ? obj6 : null);
			string strB = text;
			string s3 = text;
			obj3 = obj3;
			b = 65;
			obj3 = obj3;
			string s4 = ((byte*)(b2 / (byte)Class4.smethod_0(object_3, resolveEventArgs)))->ToString("EL", formatProvider);
			text = "PAJ";
			text = text4;
			numberStyles = numberStyles;
			_ = ((string)(object)Class4.smethod_0(object_4, byte.Parse(s4, byte.TryParse(s5, default(NumberStyles), byte.Parse(text, numberStyles, formatProvider) as IFormatProvider, out *(byte*)null) as IFormatProvider) as ResolveEventArgs)).CompareTo("RILQICM") is NumberStyles;
			numberStyles = numberStyles;
			numberStyles = numberStyles2;
			int indexA = (int)obj7;
			object obj8 = byte.Parse(s3, style, formatProvider);
			text = string.Concat(obj2, obj4, text5.LastIndexOfAny(string.Compare(strA, indexA, strB, 823239631, (int)((obj8 is int) ? obj8 : null)) as char[]) as object, (object)__arglist());
			string value = text;
			string s6 = text;
			array = array;
			array = array2;
			object obj9 = byte.Parse(text);
			_ = (byte[])(object)((byte*)byte.Parse("LXJHQX", (NumberStyles)((obj9 is NumberStyles) ? obj9 : null)))->ToString();
			array = array;
			array = array3;
			NumberStyles style2 = (NumberStyles)smethod_1(null, array);
			IFormatProvider provider = byte.Parse("N", formatProvider) as IFormatProvider;
			reference = ref reference;
			reference = ref reference2;
			object obj10 = byte.TryParse(s6, style2, provider, out reference);
			_003F val2 = checked(((obj10 is int) ? obj10 : null) + 461497677);
			formatProvider = ((byte*)13975)->CompareTo(obj3) as IFormatProvider;
			formatProvider = ((byte*)65)->GetHashCode() as IFormatProvider;
			formatProvider = formatProvider;
			formatProvider = formatProvider2;
			num2 = (int)checked(461497677u + (unchecked((uint)(int)((byte*)65)->ToString(formatProvider3)) + unchecked((uint)(int)Settings.Default)));
			string a = "BZ".Trim();
			string b3 = text;
			StringComparison stringComparison = default(StringComparison);
			int startIndex = (int)val2;
			object obj11 = byte.Parse(string.Equals(a, b3, default(StringComparison)) as string);
			object obj12 = ((string)obj).LastIndexOf(value, startIndex, checked(-390772431 + (num3 + ((obj11 is int) ? obj11 : null))));
			byte num4 = (byte)((byte*)(checked(unchecked(((obj12 is byte) ? obj12 : null) / 65) * 65) / 65))->ToString((IFormatProvider?)null);
			formatProvider = null;
			uint num5;
			IFormatProvider provider2;
			object arg;
			checked
			{
				num5 = ((unchecked((byte)((byte*)num4)->ToString(formatProvider4)) != 0) ? 1u : 0u) + (flag ? 1u : 0u);
				provider2 = formatProvider;
				text = text;
				text = "WGUAWH";
				arg = obj3;
			}
			b = (byte)checked(107u - 163u * unchecked((uint)(byte)smethod_1(array, array)));
			checked
			{
				if (num5 - ((unchecked((byte)string.Format(provider2, format, arg, null, ((byte*)(byte)((byte*)b4)->ToString("VWOXZHY", null))->ToString("HJIGB"))) != 0) ? 1u : 0u) == 0)
				{
					break;
				}
				try
				{
					object obj14;
					do
					{
						@void = @void;
						@void = @void;
						object obj13 = byte.Parse("A", unchecked((NumberStyles)Settings.Default));
						obj14 = ((obj13 is bool) ? obj13 : null);
						flag = true;
					}
					while (obj14 - 1 != 0);
				}
				finally
				{
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Control0 control);
		try
		{
			try
			{
				@class = null;
				@class = null;
				_ = Settings.Default;
				text = text;
				byte num6 = b;
				IFormatProvider provider3 = formatProvider;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
				char num7 = c;
				formatProvider = formatProvider;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider5);
				formatProvider = formatProvider5;
				string strA2 = byte.Parse("OLMXM") as string;
				int indexA2 = num2;
				string text6 = text;
				string[] array4 = array4;
				string[] separator = array4;
				StringSplitOptions stringSplitOptions = stringSplitOptions;
				byte num8 = (byte)text6.Split(separator, stringSplitOptions);
				object obj15 = ((byte*)16)->GetTypeCode();
				b = (byte)(int)((obj15 is byte) ? obj15 : null);
				byte num9 = byte.Parse(text, string.Compare("CNFNLLBK", "RHTOR") as IFormatProvider);
				byte num10 = (byte)smethod_1(null, array);
				formatProvider = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider6);
				text = ((byte*)num8)->Equals((byte)(b5 / checked(90u - (unchecked((uint)num9) - unchecked((uint)(num10 / (byte)((byte*)21)->ToString(formatProvider6))))))) as string;
				b = (byte)smethod_1(text.StartsWith((string)(object)Class4.smethod_0(obj3, resolveEventArgs)) as byte[], array);
				uint num11;
				uint num12;
				string text8;
				string value2;
				StringComparison stringComparison;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
					num11 = unchecked((uint)text7.IndexOf(((byte*)b6)->CompareTo(obj3) as string, -1493969386, -880853399)) - unchecked((uint)(int)((byte*)161)->ToString("VORWF", formatProvider));
					num12 = unchecked((uint)num2) - unchecked((uint)num2);
					text8 = text;
					value2 = text;
					stringComparison = default(StringComparison);
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider4);
				c = (char)checked(num7 - unchecked((char)string.Format(provider4, "SPFD", string.CompareOrdinal(strA2, indexA2, "PFEIZZLDN", (int)(num11 / checked(num12 - unchecked((uint)text8.LastIndexOf(value2, 983208631, stringComparison) / (uint)num2)) / checked((3793784752u + 1470991217u - (515384472u + unchecked((uint)num2))) * 1128688882u)), 1720554100) as object, obj3)));
				string format2 = "TKPSEV".PadRight(-939607818, (char)((uint)c / 38330u));
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
				text = text9;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string format3);
				_ = (object[])(object)string.Format(format3, obj3, obj3, null);
				object[] array5 = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array6);
				array5 = array6;
				byte num13 = (byte)((byte*)num6)->ToString(string.Format(provider3, format2, array5));
				obj3 = obj3;
				uint num15;
				byte num16;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_5);
					int num14 = num13 + unchecked((byte)Class4.smethod_0(object_5, resolveEventArgs));
					text = "FCVO";
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
					text = text10;
					_ = unchecked((byte*)b)->GetHashCode() is NumberStyles;
					numberStyles = numberStyles;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string s7);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
					num15 = 52u * (unchecked((uint)num14) + unchecked((uint)byte.Parse(s7, style3, null)));
					num16 = b;
				}
				object obj16 = ((byte*)checked(b + (unchecked((byte)((byte*)140)->ToString(text, (IFormatProvider)(object)Settings.Default)) - (unchecked((byte)Settings.Default) - /*isinst with value type is only supported in some contexts*/)) - b))->Equals(null);
				_003F val3 = num15 / checked(num16 * ((obj16 is byte) ? obj16 : null));
				byte num17 = b;
				formatProvider = formatProvider;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider7);
				object obj17 = ((byte*)val3)->Equals((byte)((uint)(byte)((byte*)num17)->ToString(formatProvider7) / 189u));
				object obj18 = ((obj17 is int) ? obj17 : null);
				text = "NNMJ";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB2);
				object obj19 = string.Compare("VNRFC", (int)obj18, strB2, (int)checked(2466032664u - unchecked((uint)(int)smethod_1((byte[])(object)((byte*)b)->ToString("QXPPCN", formatProvider), array))), 870712321);
				object obj20 = ((obj19 is byte) ? obj19 : null);
				array = Control2.smethod_0(null) as byte[];
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
				byte[] byte_2 = smethod_1(byte_, (byte[])(object)Settings.Default);
				array = array;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_3);
				string obj21 = (string)(object)smethod_1(byte_2, byte_3);
				string value3 = text;
				byte num18 = b;
				text = "LBLHXJ";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
				text = text11;
				object obj22 = (obj21.IndexOf(value3, (int)((byte*)checked(num18 - unchecked(/*isinst with value type is only supported in some contexts*/ / b)))->ToString(formatProvider), stringComparison) as string).Length;
				array = (byte[])(object)((byte*)checked(obj20 - ((obj22 is byte) ? obj22 : null)))->ToString();
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_4);
				_ = (Class1)(object)smethod_1(byte_4, (byte[])(object)Settings.Default);
			}
			finally
			{
				goto end_IL_031e;
			}
			end_IL_031e:;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA3);
			while (flag)
			{
				string text13 = text;
				string text14 = text;
				string value4 = (string)(object)Class4.smethod_0(obj3, resolveEventArgs);
				object obj23 = ((byte*)b)->GetTypeCode();
				StringComparison stringComparison = (StringComparison)((obj23 is StringComparison) ? obj23 : null);
				_ = text14.EndsWith(value4, comparisonType) is char[];
				array7 = null;
				array7 = array8;
				array7 = array9;
				char[] separator2 = array7;
				int count = num2;
				StringSplitOptions stringSplitOptions = default(StringSplitOptions);
				stringSplitOptions = stringSplitOptions2;
				_ = (Control1)(object)text13.Split(separator2, count, default(StringSplitOptions));
				int num19;
				byte[] byte_5;
				checked
				{
					num19 = unchecked((byte)string.Concat(((byte*)43)->CompareTo(null) as string[])) + unchecked((byte)((byte*)b)->ToString((IFormatProvider)(object)string.Concat<T>((IEnumerable<T>)(Control2.smethod_0(null) as IEnumerable<_0021_00210>))));
					byte_5 = array;
					text = "OBQT";
					resolveEventArgs = null;
					resolveEventArgs = resolveEventArgs3;
					object obj24 = Control2.smethod_0(resolveEventArgs_);
					object obj25 = ((obj24 is byte) ? obj24 : null);
					NumberStyles style4 = numberStyles;
				}
				IFormatProvider provider5 = ((byte*)203)->CompareTo(obj3) as IFormatProvider;
				b = 49;
				ref _003F reference3 = ref *(_003F*)num19;
				object obj26 = string.Compare(strA3, ((byte*)/*isinst with value type is only supported in some contexts*/)->ToString("AI", null), (CultureInfo)(object)Settings.Default, (CompareOptions)/*isinst with value type is only supported in some contexts*/);
				_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).CompareTo((byte)checked(unchecked((uint)(byte)smethod_1(byte_5, Control2.smethod_0(((byte*)((obj26 is byte) ? obj26 : null))->CompareTo(49) as ResolveEventArgs) as byte[])) + 49u)) is void;
				@void = @void;
				object obj27 = Control2.smethod_0(null);
				b = (byte)(int)((obj27 is byte) ? obj27 : null);
				Control0 obj28 = (Control0)(object)string.Format((IFormatProvider)(object)string.Join((string)(object)Settings.Default, (string[])(object)Settings.Default), text, null, obj3);
				control = control;
				control = obj28;
			}
			goto IL_0867;
		}
		IL_0867:
		@void = default(void);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
		do
		{
			try
			{
				@class = @class;
			}
			catch
			{
				_ = Control2.smethod_0(null) is string;
				text = "C";
				text = text15;
			}
			finally
			{
				do
				{
					control = control;
					string separator3 = text;
					IEnumerable<_0021_00210> values = null;
					string.Join<T>(separator3, (IEnumerable<T>)values);
				}
				while (flag);
				continue;
			}
		}
		while ((byte)"DHWVRPIBT".TrimStart(array7) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text16);
		while (true)
		{
			byte[] byte_6 = array;
			text = "DDBZRDFOG";
			text = (string)(object)smethod_1(byte_6, text16.IndexOf('녨', num2) as byte[]);
		}
	}
}
