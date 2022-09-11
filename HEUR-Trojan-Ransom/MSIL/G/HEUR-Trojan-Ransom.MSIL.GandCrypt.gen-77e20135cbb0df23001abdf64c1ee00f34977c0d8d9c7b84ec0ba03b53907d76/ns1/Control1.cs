using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal sealed class Control1 : UserControl
{
	public static bool smethod_0(ResolveEventArgs resolveEventArgs_0)
	{
		return Control3.assembly_0.FullName != resolveEventArgs_0.Name;
	}

	unsafe static void esawasog7()
	{
		//IL_0012: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Ref, but got Unknown
		//IL_00c2: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Ref, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Ref, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_0176: Expected I4, but got O
		//IL_019f: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		//IL_027d: Expected I4, but got O
		//IL_027e: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected I4, but got Unknown
		//IL_02ed: Expected O, but got I4
		//IL_030b: Expected I4, but got Unknown
		//IL_030c: Expected O, but got I4
		//IL_0315: Expected I4, but got O
		//IL_0316: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_03af: Expected O, but got I4
		//IL_03e3: Expected O, but got I4
		//IL_03f5: Expected O, but got I4
		//IL_0479: Expected O, but got I4
		//IL_0489: Expected I4, but got O
		//IL_048a: Expected O, but got I4
		//IL_0490: Expected I4, but got O
		//IL_04bb: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string separator2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
			ref _003F reference4;
			object obj19;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB2);
			do
			{
				obj = null;
				obj = obj2;
				object object_ = obj;
				resolveEventArgs_ = byte.Parse(text) as ResolveEventArgs;
				string s = (string)(object)GClass0.smethod_0(object_, resolveEventArgs_);
				numberStyles = numberStyles;
				numberStyles = default(NumberStyles);
				NumberStyles style = numberStyles;
				_ = smethod_0(resolveEventArgs_) is ref byte;
				object obj3 = smethod_0((ResolveEventArgs)(object)GClass0.smethod_0(obj, null));
				_003F val;
				byte num;
				checked
				{
					val = ((obj3 is byte) ? obj3 : null) + unchecked((byte)text.ToUpper(null));
					string s2 = text;
					NumberStyles style2 = numberStyles;
					formatProvider = formatProvider;
					num = byte.Parse(s2, style2, formatProvider);
				}
				b = (byte)(checked(114u - (b - unchecked((uint)(b / byte.Parse("GMNAOLPO".Insert(-437497521, text), formatProvider))) * 147u)) / 159u);
				b = (byte)checked(unchecked((uint)num) * unchecked((uint)checked(b2 + unchecked((byte)"RD".Normalize()))));
				object obj4 = ((byte*)checked(val + b))->Equals(obj);
				object obj5 = ((byte*)(145 / ((obj4 is byte) ? obj4 : null)))->GetTypeCode();
				object obj6 = ((byte*)((obj5 is byte) ? obj5 : null))->GetTypeCode();
				reference = ref *(byte*)((obj6 is ref byte) ? obj6 : null);
				reference = ref reference2;
				text = byte.TryParse(s, style, null, out reference) as string;
				byte num2 = (byte)((byte*)108)->ToString(text, null);
				text = text;
				text = text;
				text = text;
				object obj7 = ((byte*)b)->GetTypeCode();
				_003F val2 = checked(((obj7 is bool) ? obj7 : null) * 0);
				string text2 = text;
				object object_2 = obj;
				string s3 = smethod_0(null) as string;
				numberStyles = default(NumberStyles);
				string s4 = text;
				string text3 = text;
				obj = null;
				obj = obj8;
				object obj10 = text3.Equals(obj9);
				_ = byte.Parse(s4, (IFormatProvider)(object)((byte*)checked(46 + ((obj10 is byte) ? obj10 : null)))->ToString()) is NumberStyles;
				string s5 = text;
				numberStyles = default(NumberStyles);
				object obj11 = byte.Parse(s5, numberStyles);
				numberStyles = (NumberStyles)((obj11 is NumberStyles) ? obj11 : null);
				byte[] byte_ = null;
				string strB = byte.Parse(s3, style3, (IFormatProvider)(object)((byte*)(byte)Control4.smethod_1(byte_))->ToString("T", formatProvider)) as string;
				uint indexB;
				string separator;
				object obj12;
				checked
				{
					indexB = unchecked((uint)(int)string.Join(string.IsNullOrWhiteSpace(smethod_0(resolveEventArgs_) as string) as string, (string?[])null)) + 3857469775u + unchecked((uint)(int)text.Trim());
					text = text;
					separator = text;
					obj12 = smethod_0(null);
				}
				IEnumerable<_0021_00210> values = (IEnumerable<_0021_00210>)(object)((byte*)((obj12 is byte) ? obj12 : null))->ToString(formatProvider);
				array = (string[])(object)string.Join<T>(separator, (IEnumerable<T>)values);
				string[] value = array;
				array2 = array2;
				object obj13 = (byte.Parse(string.Join(separator2, value, "KJWHRVWSS".IndexOfAny(array2, -267153961), (int)checked(2911546810u * 3857469775u)), formatProvider) as string).LastIndexOf((string)(object)Control4.smethod_1(null), 1327734621);
				object obj14 = ((obj13 is bool) ? obj13 : null);
				numberStyles = default(NumberStyles);
				numberStyles = numberStyles;
				IFormatProvider provider = formatProvider;
				reference = ref reference;
				string value2 = (string)(object)GClass0.smethod_0(object_2, string.Compare("IRKF", -437497521, strB, (int)indexB, 1086441116, (byte)(int)obj14 != 0, byte.TryParse("LDWF", style4, provider, out result) as CultureInfo) as ResolveEventArgs);
				text = text;
				object obj15 = text2.StartsWith(value2, (StringComparison)GClass0.smethod_0(null, byte.TryParse(s6, out reference) as ResolveEventArgs));
				object obj16 = ((obj15 is byte) ? obj15 : null);
				byte num3 = (byte)GClass0.smethod_0(null, resolveEventArgs_);
				b = (byte)checked(25u + (unchecked((uint)b) + 59u));
				ref _003F reference3 = ref *(_003F*)obj16;
				int num4 = num3 / b3;
				object obj17 = ((byte*)b)->CompareTo(null);
				object obj18 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).Equals((byte)(int)checked(num4 * (((obj17 is byte) ? obj17 : null) - unchecked((uint)b / 11u))));
				_ = (CultureInfo)(object)((byte*)((obj18 is byte) ? obj18 : null))->ToString((IFormatProvider?)null);
				CultureInfo cultureInfo = null;
				cultureInfo = cultureInfo2;
				reference4 = ref *(_003F*)num2;
				obj19 = string.Compare(strA, strB2, (byte)(int)val2 != 0, cultureInfo);
			}
			while (System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference4).CompareTo((byte)(int)((obj19 is byte) ? obj19 : null)) is bool);
		}
		finally
		{
			try
			{
				text = "J";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s7);
				_ = byte.TryParse(byte.Parse(s7, formatProvider) as string, numberStyles, formatProvider, out reference) is byte;
			}
			catch
			{
				Struct3 @struct = @struct;
				@struct = @struct;
			}
			finally
			{
				try
				{
					string s8 = text;
					numberStyles = default(NumberStyles);
					_ = byte.TryParse(s8, numberStyles, null, out *(byte*)null) is Control4;
					text = text;
				}
				finally
				{
					b = 83;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
					b = b4;
					goto IL_0385;
				}
			}
		}
		IL_0385:
		formatProvider = (IFormatProvider)text.Clone();
		StringComparison stringComparison = stringComparison;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		_ = (GClass0)(object)string.Format(provider2, "ELLZBGXB".LastIndexOf("WJCY", 472461813, stringComparison) as string, null, obj);
		try
		{
			try
			{
				((byte*)191)->ToString(text);
			}
			finally
			{
				try
				{
					uc uc = uc;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uc uc2);
					uc = uc2;
					uc = uc;
					_ = smethod_0(null) is void;
					_ = byte.TryParse("GDVAFDF", out reference) is void;
					Struct3 @struct = default(Struct3);
				}
				catch
				{
					"HJ".Trim();
				}
				goto end_IL_03c0;
			}
			end_IL_03c0:;
		}
		finally
		{
			goto IL_042b;
		}
		IL_042b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Control0 control);
		while (true)
		{
			try
			{
				string value3 = text;
				string[] separator3 = array;
				byte num5 = b;
				text = "LXN";
				text = text4;
				object obj22 = ((byte*)(byte)"XMEBGGP".TrimStart((char[])(object)"PRDDGPJQ".Split(separator3, (StringSplitOptions)GClass0.smethod_0(((byte*)num5)->ToString(text5), resolveEventArgs_))))->GetTypeCode();
				object obj23 = "HUQGY".IndexOf(value3, (int)((obj22 is int) ? obj22 : null), 2035607642, stringComparison);
				b = (byte)(int)((obj23 is byte) ? obj23 : null);
				_ = (byte[])(object)((byte*)b5)->ToString();
				object obj24 = ((byte*)checked(b * (b + unchecked((uint)(byte)string.Concat((string?[])null) / 53u))))->Equals(b);
				object obj25 = ((obj24 is byte) ? obj24 : null);
				text = "GWSKCB";
				byte[] byte_ = (byte[])(object)((byte*)obj25)->ToString(text6, formatProvider);
				byte.Parse((string)(object)Control4.smethod_1(Control4.smethod_1(byte_2)), numberStyles);
				GClass0 gClass = (GClass0)(object)Control4.smethod_1(null);
				gClass = gClass;
				control = control;
				control = control;
			}
			catch
			{
				text = "FKLXNRWBL";
				text = ((byte*)b)->ToString(text);
			}
		}
	}
}
