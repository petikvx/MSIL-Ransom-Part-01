using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using mono;
using ns0;
using ns2;

namespace ns1;

internal static class Class4
{
	static Class4()
	{
		Control4.smethod_0();
		cc.smethod_0();
	}

	[STAThread]
	private static void Main()
	{
		Random random = new Random();
		int[] array = new int[10];
		int num = random.Next(10);
		for (int i = 0; i < 10; i++)
		{
			array[i] = num;
		}
		if (num >= 10)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new @_());
		}
		else
		{
			Program.Main();
		}
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Control1.smethod_0(resolveEventArgs_0))
		{
			return null;
		}
		return Control3.assembly_0;
	}

	unsafe static void abufim5()
	{
		//IL_0007: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_0076: Expected I4, but got O
		//IL_0095: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Ref, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got I4
		//IL_0132: Expected Ref, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected I4, but got Unknown
		//IL_01b1: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		//IL_01f9: Expected I4, but got O
		//IL_01fa: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Ref, but got Unknown
		//IL_0254: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_027e: Expected I4, but got O
		//IL_02b9: Expected O, but got I4
		//IL_02d6: Expected O, but got I4
		//IL_02ed: Expected O, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_0338: Expected I4, but got O
		//IL_034f: Expected O, but got I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected I4, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_036e: Expected O, but got I4
		//IL_039e: Expected O, but got I4
		//IL_03d3: Expected O, but got I4
		//IL_03dd: Expected O, but got I4
		//IL_0418: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_043f: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_048f: Expected O, but got I4
		//IL_04a9: Expected O, but got I4
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected I4, but got Unknown
		//IL_04c5: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_04e1: Expected I4, but got O
		//IL_04e2: Expected O, but got I4
		//IL_04ec: Expected I4, but got O
		//IL_04ed: Expected O, but got I4
		//IL_0502: Expected O, but got I4
		//IL_0520: Expected O, but got I4
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected I4, but got Unknown
		//IL_0569: Expected O, but got I4
		//IL_0572: Expected I4, but got O
		//IL_0573: Expected O, but got I4
		//IL_058a: Expected O, but got I4
		//IL_0594: Expected O, but got I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got I4
		//IL_05f7: Expected Ref, but got Unknown
		//IL_061f: Expected O, but got I4
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got I4
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Ref, but got Unknown
		//IL_0656: Expected O, but got I4
		//IL_0661: Expected I4, but got O
		//IL_0662: Expected O, but got I4
		//IL_067c: Expected O, but got I4
		//IL_0686: Expected O, but got I4
		//IL_06cb: Expected O, but got I4
		//IL_06ec: Expected O, but got I4
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got I4
		//IL_070d: Expected O, but got I4
		//IL_0767: Expected O, but got I4
		//IL_077b: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_079f: Expected O, but got I4
		//IL_07cf: Expected O, but got I4
		//IL_07ec: Expected O, but got I4
		//IL_07f8: Expected O, but got I4
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected I4, but got Unknown
		//IL_0804: Expected O, but got I4
		//IL_0810: Expected O, but got I4
		//IL_081a: Expected O, but got I4
		//IL_0824: Expected O, but got I4
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got I4
		//IL_083b: Expected Ref, but got Unknown
		//IL_084b: Expected O, but got I4
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected I4, but got Unknown
		//IL_0858: Expected O, but got I4
		//IL_0864: Expected O, but got I4
		//IL_087a: Expected O, but got I4
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected I4, but got Unknown
		//IL_089e: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		_ = string.IsNullOrWhiteSpace(text) is string;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		text = "WF";
		_ = Control1.smethod_0(null) is Class2;
		_ = (@_)(object)(text + text + text);
		c c = c;
		c = c;
		byte b = 135;
		string strA = ((byte*)135)->ToString();
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB);
		Control2 control = string.CompareOrdinal(strA, strB) as Control2;
		control = control;
		try
		{
		}
		catch
		{
			try
			{
			}
			finally
			{
				goto end_IL_005a;
			}
			end_IL_005a:;
		}
		ResolveEventArgs resolveEventArgs = resolveEventArgs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		resolveEventArgs = resolveEventArgs2;
		object obj2 = Control1.smethod_0(resolveEventArgs);
		b = (byte)(int)((obj2 is byte) ? obj2 : null);
		string text3 = ((byte*)b)->ToString();
		char[] array = (char[])text.Clone();
		object obj3 = Control1.smethod_0(resolveEventArgs);
		int startIndex;
		string b2;
		object obj4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		checked
		{
			_ = ((obj3 is int) ? obj3 : null) * -802475406;
			num = num;
			startIndex = num;
			b2 = text;
			obj4 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
			obj4 = obj5;
		}
		string obj6 = string.Equals("TBAK", b2, (StringComparison)smethod_0(obj4, (ResolveEventArgs)(object)text.PadLeft(-1250570148))) as string;
		byte num2 = b;
		object obj7 = Control1.smethod_0(resolveEventArgs);
		object obj8 = ((byte*)checked(num2 - ((obj7 is byte) ? obj7 : null)))->GetHashCode();
		object obj9 = ((obj8 is byte) ? obj8 : null);
		string s = text;
		NumberStyles numberStyles = numberStyles;
		object obj10 = ((byte*)byte.Parse(s, numberStyles))->GetTypeCode();
		object obj11 = obj6.CompareTo(((byte*)checked((obj9 + ((obj10 is byte) ? obj10 : null) + 253) * 37))->ToString("FBSHDJ".IndexOf("TLGRKAQD") as IFormatProvider).IndexOfAny((char[])(object)"RCE".GetEnumerator(), num) as object);
		object obj12 = ((obj11 is NumberStyles) ? obj11 : null);
		string obj13 = Control1.smethod_0(resolveEventArgs) as string;
		string value = text;
		byte num3 = (byte)string.Format(string.Copy(text), obj4);
		string text4 = text;
		char c2 = c2;
		int num4 = checked(c2 - c2);
		string text5 = text;
		c2 = '\ue141';
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char value2);
		object obj14 = text5.IndexOf(value2);
		IFormatProvider formatProvider = "GNIF".LastIndexOf((char)(checked(num4 * ((obj14 is char) ? obj14 : null)) / 44798), 70642038) as IFormatProvider;
		StringComparison comparisonType = (StringComparison)((byte*)num3)->ToString(text4, formatProvider);
		int style = (int)obj12;
		object obj15 = "FXXQBIBE".LastIndexOf(value, comparisonType);
		_ = byte.TryParse("XS", (NumberStyles)style, null, out *(byte*)obj13.TrimEnd(((byte*)((obj15 is byte) ? obj15 : null))->CompareTo((byte)((byte*)58)->ToString()) as char[])) is int;
		_ = ((byte*)b)->Equals(obj4) is int;
		object obj16 = byte.Parse(text);
		object obj17;
		checked
		{
			_ = ((obj16 is int) ? obj16 : null) * unchecked((byte*)245)->CompareTo(null);
			num = num;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int count);
			obj17 = text3.IndexOfAny(array, startIndex, count);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		_003F val = b3 / ((obj17 is byte) ? obj17 : null);
		object obj18 = "TR".ToUpperInvariant().LastIndexOf(text);
		_ = ((byte*)checked(val * ((obj18 is byte) ? obj18 : null)))->CompareTo(obj4) is Control1;
		c = (c)(object)Settings.Default;
		uint num5;
		bool flag;
		do
		{
			string text6 = text;
			object obj19 = string.IsNullOrWhiteSpace("UGZHF");
			num5 = (((byte)text6.Replace('ﰻ', (char)(int)((obj19 is char) ? obj19 : null)) != 0) ? 1u : 0u) / (((byte)Settings.Default != 0) ? 1u : 0u);
			flag = (byte)num5 != 0;
		}
		while (num5 != 0);
		try
		{
		}
		catch
		{
		}
		control = control;
		text = text;
		byte num6 = b;
		string s2 = text;
		NumberStyles style2 = numberStyles;
		string s3 = text;
		ref byte result = ref *(byte*)Settings.Default;
		_ = byte.TryParse(s3, out result) is string;
		text = "SBHDX";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
		text = text7;
		NumberStyles style3 = numberStyles;
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		object obj21 = byte.TryParse(s2, style2, (IFormatProvider)smethod_0(byte.Parse(s4, style3, provider) as object, resolveEventArgs), out *(byte*)null);
		_003F val2 = checked(((obj21 is byte) ? obj21 : null) * 216);
		string s5 = text;
		NumberStyles style4 = numberStyles;
		object object_ = smethod_0(text.IndexOf("DTI") as object, resolveEventArgs);
		resolveEventArgs = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		_ = (IFormatProvider)smethod_0(object_, resolveEventArgs_);
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		object obj22 = byte.TryParse(s5, style4, provider2, out result);
		b = (byte)(int)((obj22 is byte) ? obj22 : null);
		ref _003F reference = ref *(_003F*)num6;
		byte num7 = b;
		object obj23 = ((byte*)checked(unchecked((uint)b) * 175u))->Equals(obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		char[] separator = (System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo((byte)checked(val2 + (b4 + 59 * (num7 * (((obj23 is byte) ? obj23 : null) + 245))))) as string== text) as char[];
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s6);
		b = byte.Parse(s6, formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
		string strA2 = ((byte*)checked(unchecked((byte)text8.Split(separator, ((byte*)b5)->GetHashCode())) + b))->Equals((byte)checked(unchecked((uint)b) - 7613u)) as string;
		num = (int)checked(unchecked((uint)((byte*)b)->GetHashCode()) * unchecked((uint)num / checked(unchecked((uint)num) + unchecked((uint)num))));
		string strB2 = text;
		string text9 = text;
		CultureInfo cultureInfo = cultureInfo;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexA);
		object obj24 = string.Compare(strA2, indexA, strB2, -981783487, (int)text9.ToUpper(cultureInfo), ignoreCase: false);
		_ = ((byte*)((obj24 is byte) ? obj24 : null))->GetHashCode() is string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		try
		{
			try
			{
			}
			catch
			{
				try
				{
					byte_ = (byte[])(object)"PVWZIC".ToLower(null);
					Control4.smethod_1(byte_);
				}
				finally
				{
					text = "A";
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
					text = text10;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
					string s7 = text11.GetHashCode() as string;
					numberStyles = default(NumberStyles);
					numberStyles = numberStyles;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style5);
					_ = byte.Parse(s7, style5, ((byte*)106)->GetHashCode() as IFormatProvider) is void;
					goto end_IL_03e5;
				}
				end_IL_03e5:;
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj32);
			while (true)
			{
				flag = (byte)smethod_0(((byte*)checked(b + (unchecked((uint)b) - 120u)))->CompareTo(obj4) as object, (ResolveEventArgs)(object)Control4.smethod_1(byte_)) != 0;
				if (flag2)
				{
					text = text;
					string s8 = ((byte*)64)->GetTypeCode() as string;
					text = "GAZCB";
					object obj26 = byte.TryParse(string.Compare(strA3, 0, "CRRIY", checked(/*isinst with value type is only supported in some contexts*/ - num), (int)((byte*)152)->ToString()) as string, (NumberStyles)/*isinst with value type is only supported in some contexts*/, formatProvider, out result);
					text = byte.Parse(s8, (NumberStyles)((obj26 is NumberStyles) ? obj26 : null), null) as string;
					string format = text;
					object arg = obj4;
					string text12 = text;
					string value3 = text;
					string s9 = string.Compare(text, text, flag, null) as string;
					numberStyles = default(NumberStyles);
					object obj27 = text.Equals((object?)null);
					_ = (NumberStyles)"CVVIMLWU".PadLeft(529945037 / ((obj27 is int) ? obj27 : null));
					numberStyles = numberStyles;
					numberStyles = numberStyles2;
					formatProvider = (IFormatProvider)(object)((byte*)checked(63u * unchecked((uint)b) + unchecked((byte)Settings.Default)))->ToString(string.Concat(obj4), null);
					object obj28 = byte.TryParse(s9, style6, provider3, out *(byte*)null);
					string format2 = string.Format(format, arg, text12.EndsWith(value3, (StringComparison)((obj28 is StringComparison) ? obj28 : null)) as object, obj4);
					byte num8 = b;
					resolveEventArgs = null;
					object obj29 = Control1.smethod_0(resolveEventArgs_2);
					object obj30 = ((byte*)((obj29 is byte) ? obj29 : null))->GetTypeCode();
					object obj31 = ((obj30 is byte) ? obj30 : null);
					byte num9 = b;
					string separator2 = ((byte*)(90u / (uint)(byte)text.TrimEnd(array)))->ToString(formatProvider);
					object[] array2 = null;
					array2 = array3;
					_003F val3;
					string text13;
					checked
					{
						val3 = obj31 + unchecked((uint)checked(num9 + unchecked((byte)string.Join(separator2, array2)))) * unchecked((uint)b) - 3;
						text13 = text.Normalize();
						_ = (object)text.ToString();
						obj4 = obj4;
					}
					text = string.Format(format2, ((byte*)num8)->ToString((IFormatProvider)(object)((byte*)val3)->ToString(text13.Equals(obj32) as IFormatProvider)), null);
					continue;
				}
				break;
			}
		}
		checked
		{
			object obj34;
			do
			{
				obj34 = byte.Parse(text, numberStyles);
			}
			while (1 * unchecked(((obj34 is bool) ? obj34 : null) / 0) != 0);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Control3 control2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
			do
			{
				object obj35 = ((byte*)b)->Equals(b);
				object obj36 = ((obj35 is byte) ? obj35 : null);
				byte num10 = b;
				b = 65;
				object obj37 = ((byte*)checked(obj36 - (unchecked((uint)checked(num10 - b6)) * 1u + 115u + 65u)))->GetHashCode();
				_ = byte.Parse("KCGGH", (NumberStyles)((obj37 is NumberStyles) ? obj37 : null), formatProvider) is void;
				_ = Control1.smethod_0(((string)(object)Settings.Default).StartsWith("Z") as ResolveEventArgs) is string;
				text = text;
				control2 = control2;
				control2 = control2;
				flag = flag;
			}
			while (flag3);
		}
		catch
		{
			void @void = smethod_0(null, resolveEventArgs);
			void void2 = void2;
			void2 = @void;
		}
		control2 = null;
		control2 = (Control3)(object)string.Join(text, byte.Parse("NELIXEYFE".Trim(), formatProvider) as string[]);
		try
		{
		}
		catch
		{
			object obj39 = byte.TryParse("I", out result);
			_ = ((obj39 is byte) ? obj39 : null) / 155;
			cultureInfo = byte.Parse(text.Equals(text) as string) as CultureInfo;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture);
			b = (byte)"RNWC".ToUpper(culture);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
			b = b7;
		}
		finally
		{
			while (flag)
			{
			}
			goto IL_072f;
		}
		IL_072f:
		c2 = (char)((byte*)b)->ToString();
		byte num11 = b;
		object obj41 = ("TDGZYBL".LastIndexOf(text, 1271380549, (int)Control4.smethod_1(byte.Parse("BWWZMYS", numberStyles, null) as byte[])) as string).CompareTo(text);
		object obj42 = ((obj41 is byte) ? obj41 : null);
		byte num12 = (byte)Control4.smethod_1(byte_);
		text = text.IndexOf(c2) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text14);
		text = text14;
		string strA4 = text;
		string strB3 = text;
		string text15 = text;
		text = text;
		numberStyles = default(NumberStyles);
		object obj43 = ((byte*)checked(num11 * (189u - unchecked((uint)(byte)((byte*)checked(27 + obj42 * (object)/*isinst with value type is only supported in some contexts*/))->ToString(((byte*)b)->CompareTo(b) as IFormatProvider)) + 5u)))->CompareTo(null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c3);
		_ = "OWPMC".IndexOf((char)checked(c3 * ((obj43 is char) ? obj43 : null)), num) is Class0;
		string obj44 = Control1.smethod_0(resolveEventArgs) as string;
		int totalWidth = (int)Settings.Default;
		object obj45 = Control1.smethod_0(resolveEventArgs);
		_ = ((string)(object)smethod_0(obj44.PadLeft(totalWidth, (char)(int)checked(((obj45 is char) ? obj45 : null) + c2)), resolveEventArgs)).IndexOf(text) is Class0;
	}
}
