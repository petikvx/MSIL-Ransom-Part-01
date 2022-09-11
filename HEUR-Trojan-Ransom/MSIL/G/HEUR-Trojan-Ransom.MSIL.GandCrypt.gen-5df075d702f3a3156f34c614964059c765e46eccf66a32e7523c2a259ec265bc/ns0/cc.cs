using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns1;
using ns2;

namespace ns0;

public class cc : Control
{
	internal IContainer icontainer_0;

	public cc()
	{
		method_0();
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaint(paintEventArgs_0);
	}

	protected override void vmethod_1(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Control)this).Dispose(bool_0);
	}

	public static void smethod_0()
	{
		Class0.smethod_0();
		Control2.smethod_0();
	}

	public static void smethod_1(AppDomain appDomain_0)
	{
	}

	public static void smethod_2(AppDomain appDomain_0)
	{
		try
		{
			Class2.smethod_0(appDomain_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	private void method_0()
	{
		IContainer container = (icontainer_0 = new Container());
	}

	unsafe static void abufimak11()
	{
		//IL_00b3: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_01db: Expected I4, but got O
		//IL_01f8: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Ref, but got Unknown
		//IL_0293: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_02c4: Expected I4, but got O
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected I4, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_02db: Expected O, but got I4
		//IL_0302: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected I4, but got Unknown
		//IL_0371: Expected I4, but got O
		//IL_0371: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_0380: Expected O, but got I4
		//IL_040f: Expected O, but got I4
		//IL_041a: Expected O, but got I4
		//IL_0423: Expected I4, but got O
		//IL_046a: Expected O, but got I4
		//IL_0470: Expected I4, but got O
		//IL_0495: Expected O, but got I4
		//IL_04ba: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_04fb: Expected O, but got I4
		//IL_055f: Expected O, but got I4
		//IL_0578: Expected O, but got I4
		//IL_0582: Expected O, but got I4
		//IL_05c8: Expected O, but got I4
		//IL_05d1: Expected I4, but got O
		//IL_05d2: Expected O, but got I4
		//IL_05ef: Expected O, but got I4
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected I4, but got Unknown
		//IL_063c: Expected O, but got I4
		//IL_0646: Expected O, but got I4
		//IL_064f: Expected I4, but got O
		//IL_0650: Expected O, but got I4
		//IL_0659: Expected I4, but got O
		//IL_066e: Expected O, but got I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got I4
		//IL_06b9: Expected I4, but got O
		//IL_06ba: Expected O, but got I4
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Incompatible stack heights: 2 vs 0
		//IL_06e9: Expected O, but got I4
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got I4
		//IL_0716: Expected Ref, but got Unknown
		//IL_0746: Expected O, but got I4
		//IL_0773: Expected O, but got I4
		//IL_07a6: Expected O, but got I4
		//IL_07ed: Expected O, but got I4
		//IL_07f7: Expected O, but got I4
		//IL_0805: Expected I4, but got O
		//IL_0806: Expected O, but got I4
		//IL_0811: Expected O, but got I4
		//IL_0872: Expected O, but got I4
		//IL_0899: Expected O, but got I4
		//IL_08a3: Expected O, but got I4
		//IL_08ad: Expected O, but got I4
		//IL_08c7: Expected O, but got I4
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Ref, but got Unknown
		//IL_08dd: Expected O, but got I4
		//IL_08e8: Expected O, but got I4
		//IL_08fc: Expected O, but got I4
		//IL_0910: Expected O, but got I4
		//IL_091b: Expected I4, but got O
		//IL_091c: Expected O, but got I4
		//IL_092b: Expected O, but got I4
		//IL_0937: Expected O, but got I4
		//IL_0942: Expected O, but got I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Ref, but got Unknown
		//IL_0952: Expected O, but got I4
		//IL_096d: Incompatible stack heights: 2 vs 0
		//IL_096f: Incompatible stack heights: 2 vs 0
		//IL_0989: Incompatible stack heights: 0 vs 2
		//IL_09be: Expected O, but got I4
		//IL_09d8: Expected O, but got I4
		//IL_0a23: Expected O, but got I4
		//IL_0a3b: Expected O, but got I4
		//IL_0a4e: Expected O, but got I4
		//IL_0a6b: Expected O, but got I4
		//IL_0a84: Expected O, but got I4
		//IL_0a8e: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		try
		{
		}
		catch
		{
			array = null;
			_ = (byte)Control4.smethod_1(array);
		}
		bool flag;
		do
		{
			flag = false;
		}
		while (1u / 0u != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		byte b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		do
		{
			string text2 = text;
			formatProvider = formatProvider;
			text = ((byte*)183)->ToString(text2, formatProvider);
			string format = text;
			_ = (object[])(object)Settings.Default;
			array2 = array2;
			array2 = array3;
			Settings settings = (Settings)(object)Control4.smethod_1((byte[])(object)string.Format(null, format, array2));
			settings = settings2;
			settings = settings;
			bool num = (byte)((byte*)28)->ToString(formatProvider) != 0;
			numberStyles = numberStyles;
			numberStyles = default(NumberStyles);
			NumberStyles style = numberStyles;
			numberStyles = numberStyles;
			b = (byte)checked(166u + unchecked((uint)byte.Parse("EA", default(NumberStyles))));
			object obj2 = Control1.smethod_0(byte.Parse("CLIFJHGBS", style, ((byte*)b)->CompareTo(199) as IFormatProvider) as ResolveEventArgs);
			flag = (byte)((num ? 1u : 0u) / (byte.TryParse("DEWMZIXT", out *(byte*)((obj2 is ref byte) ? obj2 : null)) ? 1u : 0u)) != 0;
		}
		while (flag2);
		while ((byte)Class4.smethod_0(Control1.smethod_0((ResolveEventArgs)(object)Settings.Default) as object, null) != 0)
		{
			while (flag)
			{
			}
		}
		char c2 = c2;
		string text3 = text;
		string text4 = text;
		string text5 = text;
		string s = (Control1.smethod_0(text.ToUpper().GetTypeCode() as ResolveEventArgs) as string).IndexOfAny(null) as string;
		uint num2 = checked(3299595165u + 1678625633u);
		object obj3 = obj3;
		object object_ = obj3;
		ResolveEventArgs resolveEventArgs = resolveEventArgs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		int num3 = (int)Class4.smethod_0(object_, (ResolveEventArgs)(object)Class4.smethod_0(Control1.smethod_0(resolveEventArgs) as object, byte.TryParse(Control1.smethod_0(null) as string, out result) as ResolveEventArgs));
		int num4 = (int)((byte*)b)->ToString();
		int num5 = 1120884704;
		uint num6;
		string text6;
		char num7;
		object obj4;
		int num8;
		string obj7;
		string separator;
		string text7;
		object obj8;
		checked
		{
			num6 = num2 * (unchecked((uint)num3) + (unchecked((uint)num4) + 1120884704u - 487489749u));
			text6 = text;
			num7 = c2;
			obj4 = obj3;
			object obj5 = obj3;
			obj3 = obj3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj6);
			num8 = unchecked((char)string.Concat(obj5, obj6, (object)null, (object)__arglist())) - c2;
			obj7 = (string)(object)Settings.Default;
			separator = text;
			text7 = text;
			obj8 = "G".StartsWith("ASQBOOT");
		}
		string[] value = (string[])(object)text7.PadRight((int)((obj8 is int) ? obj8 : null));
		resolveEventArgs = (ResolveEventArgs)(object)string.Join(separator, value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		string s2 = Control1.smethod_0(resolveEventArgs_) as string;
		string s3 = ((byte*)(byte)string.Format((IFormatProvider)(object)string.Join(text, (IEnumerable<string?>)null), text, null, obj3))->ToString("TEU", byte.Parse(text, default(NumberStyles), "XDWMBCRK".Contains("TLXX") as IFormatProvider) as IFormatProvider);
		numberStyles = default(NumberStyles);
		byte num9 = byte.Parse(s3, numberStyles);
		b = 44;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		int num10 = checked(num9 + b2);
		object obj9 = ((byte*)206)->GetHashCode();
		object obj10 = ((byte*)checked(num10 + unchecked(checked(((obj9 is byte) ? obj9 : null) * 219 * unchecked((byte)Class4.smethod_0(obj3, null))) / 44) - 44))->Equals(null);
		result = ref *(byte*)((obj10 is ref byte) ? obj10 : null);
		object obj11 = num7;
		object obj12 = (object)/*isinst with value type is only supported in some contexts*/;
		object obj13 = ((byte*)(byte)"QIFV".ToUpperInvariant())->GetTypeCode();
		string obj14 = ((string)obj11).IndexOf((char)(int)checked(obj4 * (unchecked((uint)num8) - unchecked((uint)(char)obj7.PadRight(checked(obj12 * ((obj13 is int) ? obj13 : null)))))), -1543662077, 1120884704) as string;
		object arg = obj3;
		string value2 = text;
		StringComparison stringComparison = stringComparison;
		object obj15 = "M".EndsWith("B", stringComparison);
		string[] separator2 = (string[])(object)string.Format("FQVCUM", arg, "JTXK".EndsWith(value2, (byte)((byte*)((obj15 is byte) ? obj15 : null))->ToString("FFJTQ") != 0, null) as object, obj3);
		object obj16 = byte.Parse(text);
		_003F val = ((obj16 is int) ? obj16 : null) / 1120884704;
		StringSplitOptions stringSplitOptions = default(StringSplitOptions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions2);
		stringSplitOptions = stringSplitOptions2;
		object obj17 = string.Compare((string?)num6, (int)text6, (string)(object)obj14.Split(separator2, (int)val, stringSplitOptions), (int)checked(3192329078u * 1120884704u), 1120884704, (byte)checked(1u - (flag ? 1u : 0u)) != 0);
		result = ref *(byte*)((obj17 is ref byte) ? obj17 : null);
		byte oldChar = (byte)(text4 + text5 + (byte.TryParse(s, out result) as string) + text);
		uint num11 = checked(65u - 180u);
		byte num12 = (byte)Control4.smethod_1(null);
		uint num13;
		checked
		{
			num13 = 0u + unchecked((uint)(byte)"PQTJWC".ToCharArray());
		}
		_ = (byte)Control4.smethod_1(null);
		b = 51;
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		object obj18 = ((byte*)233)->ToString("TXUIKYM", formatProvider2);
		uint totalWidth;
		checked
		{
			totalWidth = unchecked((uint)(int)string.Concat((object?[])null)) + 1120884704u;
		}
		object obj19 = ((byte*)/*isinst with value type is only supported in some contexts*/)->CompareTo(null);
		obj3 = "WKQYJ".PadRight((int)totalWidth, (char)(int)((obj19 is char) ? obj19 : null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj20);
		obj3 = obj20;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj21);
		b = (byte)string.Concat(obj18, obj21, null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		uint num14 = checked(num13 * unchecked((uint)checked(b3 * b))) / b;
		array = array;
		uint num15;
		object obj22;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
			num15 = num12 + (84u + num14 * unchecked((byte)Control4.smethod_1(byte_)));
			obj22 = text.CompareTo((string)(object)Control4.smethod_1(array));
		}
		b = (byte)(int)((obj22 is byte) ? obj22 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		object obj23 = ((byte*)(object)((byte*)(num11 / checked(num15 - b4)))->ToString(formatProvider))->CompareTo(string.Concat(obj3, obj3, (object)("TV".IndexOf("XEQV", stringComparison) as string).Replace(c2, '墾'), (object)__arglist()));
		object obj24 = ((obj23 is byte) ? obj23 : null);
		object arg2 = obj3;
		obj3 = byte.TryParse(text, out result) as object;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg3);
		char[] separator3 = (char[])(object)string.Format(null, "W", arg2, arg3).Trim();
		string text8 = text;
		text = "XXO";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		char[] anyOf = byte.Parse(s4, null) as char[];
		array = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array4);
		array = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
		IFormatProvider provider = (IFormatProvider)(object)string.Concat(Control4.smethod_1(byte_2), obj3);
		string format2 = text;
		object arg4 = obj3;
		string strA = text;
		char[] separator4 = null;
		string text9 = string.Format(provider, format2, null, arg4, string.Compare(strA, -2042994326, "ITJPZ", 2000517051, (int)checked(unchecked((uint)(int)"EZZY".Split(separator4, 1120884704)) + unchecked((uint)(int)"EAWO".ToLower()))) as object);
		string? text10 = string.IsInterned(byte.Parse(((byte*)27)->GetHashCode() as string) as string);
		c2 = 'ᴚ';
		string text11;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char value3);
			uint num16 = unchecked((uint)text10!.IndexOf(value3, -880717154)) - 1120884704u;
			text11 = text;
		}
		object obj25 = ((byte*)checked(40u - (17u - 87u)))->Equals(obj3);
		text = (string)(object)Control4.smethod_1(text11.EndsWith("OZU", (StringComparison)((obj25 is StringComparison) ? obj25 : null)) as byte[]);
		bool ignoreCase = flag;
		CultureInfo culture = null;
		object obj26 = ((byte*)obj24)->Equals((byte)(int)/*isinst with value type is only supported in some contexts*/);
		_ = (Class4)(object)text3.Replace((char)oldChar, (char)(int)((obj26 is char) ? obj26 : null));
		b = b;
		object obj28;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
		do
		{
			object obj27 = byte.Parse("BUG");
			obj28 = ((obj27 is bool) ? obj27 : null);
			flag = flag;
		}
		while (checked(obj28 - flag3) != 0);
		_003F val2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture2);
		object obj32;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		do
		{
			try
			{
			}
			finally
			{
				goto IL_067e;
			}
			IL_067e:
			object obj29 = byte.Parse(text);
			val2 = checked(0 + ((obj29 is bool) ? obj29 : null));
			string strB = text;
			culture = null;
			object obj30 = string.Compare("WGFANYMG", strB, ignoreCase: true, culture2);
			object obj31 = ((obj30 is NumberStyles) ? obj30 : null);
			formatProvider = (IFormatProvider)(object)Control4.smethod_1(array);
			obj32 = byte.Parse("UBSTBSJV", (NumberStyles)obj31, provider2);
		}
		while ((int)checked(val2 * (unchecked(((obj32 is bool) ? obj32 : null) / 1) + unchecked((flag ? 1u : 0u) / (((byte)Settings.Default != 0) ? 1u : 0u))) - 0) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out cc cc2);
		while ((byte)Class4.smethod_0(null, (ResolveEventArgs)(object)((byte*)b)->ToString(formatProvider)) != 0)
		{
			try
			{
				try
				{
					object obj33 = ((byte*)165)->GetTypeCode();
					_003F val3 = checked(((obj33 is byte) ? obj33 : null) - b);
					text = text;
					formatProvider = formatProvider;
					NumberStyles style2 = (NumberStyles)((byte*)val3)->ToString(byte.TryParse(s5, out *(byte*)((byte*)23)->ToString(formatProvider3)) as IFormatProvider);
					string s6 = text;
					NumberStyles style3 = (NumberStyles)((byte*)136)->ToString("JGBCQAUWX", null);
					((byte*)b)->ToString("W", formatProvider);
					string s7 = Control1.smethod_0(resolveEventArgs) as string;
					text = "VVWQROWH";
					object obj34 = Control1.smethod_0(resolveEventArgs);
					object obj35 = ((obj34 is byte) ? obj34 : null);
					byte num17 = (byte)string.Concat((object[])(object)((byte*)11776)->ToString("BEJ"));
					string text12 = text;
					object obj36 = ((byte*)90)->GetHashCode();
					((byte*)((obj36 is byte) ? obj36 : null))->CompareTo((byte)((uint)(byte)Control4.smethod_1(null) / 202u));
					text = text;
					string text13 = ((byte*)141)->ToString();
					c2 = c2;
					uint value5;
					checked
					{
						value5 = unchecked((uint)c3) + 52477u;
					}
					object obj37 = ((byte*)checked(unchecked((uint)b) * 15u))->Equals(((byte*)b)->GetHashCode() as object);
					text = byte.Parse(text13.LastIndexOf((char)value5, (int)((obj37 is int) ? obj37 : null), 61627109) as string, formatProvider) as string;
					obj3 = obj3;
					string value6 = (string)(object)Class4.smethod_0(object_2, resolveEventArgs);
					bool num18 = (byte)string.Concat(obj3, obj3, obj3) != 0;
					text = "Z";
					num5 = (int)(597238132u / (uint)(int)string.Copy(text14.Equals("Q".StartsWith(value6, (byte)checked((num18 ? 1u : 0u) - ((unchecked((byte)string.Concat(((byte*)(byte)((byte*)(byte)string.IsInterned(str))->ToString((string)(object)Control4.smethod_1(array), null))->CompareTo(203) as object)) != 0) ? 1u : 0u)) != 0, byte.Parse(text, numberStyles, (IFormatProvider)(object)"DIJ".ToLower()) as CultureInfo) as string) as string));
					object obj38 = text12.IndexOf('鐠', startIndex);
					text = "XUJDFVPM".LastIndexOf(value7, (StringComparison)Class4.smethod_0(string.CompareOrdinal("YFGGZT", -1357688548, "QUKRD", -1382515775, ((byte*)checked((obj35 + (num17 - ((obj38 is byte) ? obj38 : null))) * b))->CompareTo(obj3)) as object, Control1.smethod_0(null) as ResolveEventArgs)) as string;
					object obj39 = text15.IndexOf(c2, 900331992);
					text = byte.TryParse(s7, (NumberStyles)((obj39 is NumberStyles) ? obj39 : null), null, out *(byte*)null) as string;
					object obj40 = byte.TryParse("S", style2, byte.TryParse(s6, style3, byte.Parse(s8, formatProvider) as IFormatProvider, out result) as IFormatProvider, out *(byte*)null);
					_ = (Settings)(object)Class4.smethod_0(((byte*)(((obj40 is byte) ? obj40 : null) / 90))->GetTypeCode() as object, null);
				}
				finally
				{
					cc2 = cc2;
					cc2 = null;
					goto end_IL_06d8;
				}
				end_IL_06d8:;
			}
			finally
			{
				continue;
			}
		}
		_ = (string)(object)Control4.smethod_1(array);
		string text16 = text;
		num5 = num5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num19);
		num5 = (int)checked(unchecked((uint)num19) - unchecked((uint)(int)string.Join(text, array2)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex2);
		_ = text16.LastIndexOf("DHH", startIndex2) is @_;
		try
		{
			string.Format(text, null);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text17);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text18);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string newValue);
			string text19;
			string value8;
			object object_3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			do
			{
				_ = ((byte*)b)->Equals(b) is string;
				text = text;
				text = text17;
				text = "YFEL";
				_ = (uc)(object)text18.Replace("WXUDVYBYF", newValue);
				text19 = ((byte*)98)->ToString((IFormatProvider?)null);
				value8 = text;
				object_3 = obj3;
				formatProvider = formatProvider;
				resolveEventArgs = byte.Parse("IHF", default(NumberStyles), provider3) as ResolveEventArgs;
			}
			while (text19.IndexOf(value8, (int)Class4.smethod_0(object_3, resolveEventArgs_2)) is bool);
			goto IL_0a43;
		}
		IL_0a43:
		do
		{
			_ = ((byte*)31)->GetHashCode() is Control0;
			_ = (Control0)(object)Settings.Default;
		}
		while (byte.TryParse(((byte*)218)->Equals(obj3) as string, out *(byte*)null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s9);
		while (true)
		{
			if (flag)
			{
				text = text;
				_ = byte.Parse(byte.TryParse(s9, out *(byte*)null) as string) is Class1;
			}
		}
	}
}
