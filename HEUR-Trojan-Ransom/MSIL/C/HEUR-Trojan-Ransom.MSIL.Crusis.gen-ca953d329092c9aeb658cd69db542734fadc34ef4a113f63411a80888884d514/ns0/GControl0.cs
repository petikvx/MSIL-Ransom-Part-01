using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns1;
using ns2;

namespace ns0;

public class GControl0 : Control
{
	internal IContainer icontainer_0;

	public GControl0()
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

	unsafe static void odayof0(object object_0, object object_1, object object_2)
	{
		//IL_0016: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_006c: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected I4, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected I4, but got Unknown
		//IL_01f2: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0241: Expected I4, but got O
		//IL_02c1: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Ref, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_030b: Expected O, but got I4
		//IL_0318: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_0336: Expected O, but got I4
		//IL_0341: Expected O, but got I4
		//IL_035a: Expected I4, but got O
		//IL_035a: Expected I4, but got O
		//IL_035b: Expected O, but got I4
		//IL_03bb: Expected O, but got I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected I4, but got Unknown
		//IL_03c6: Expected O, but got I4
		//IL_03d0: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_043a: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_045a: Expected I4, but got O
		//IL_045b: Expected O, but got I4
		//IL_0478: Expected I4, but got O
		//IL_0479: Expected O, but got I4
		//IL_049c: Expected O, but got I4
		//IL_04b3: Expected O, but got I4
		//IL_04c2: Expected O, but got I4
		//IL_04da: Expected O, but got I4
		//IL_050a: Expected O, but got I4
		//IL_0514: Expected O, but got I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got I4
		//IL_0569: Expected Ref, but got Unknown
		//IL_0594: Expected O, but got I4
		//IL_059e: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_05f1: Expected O, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected I4, but got Unknown
		//IL_0641: Expected O, but got I4
		//IL_064a: Expected I4, but got O
		//IL_0665: Expected O, but got I4
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected I4, but got Unknown
		//IL_0670: Expected O, but got I4
		//IL_068e: Expected O, but got I4
		//IL_069b: Expected O, but got I4
		//IL_06a4: Expected I4, but got O
		//IL_06a5: Expected O, but got I4
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected O, but got I4
		//IL_06ce: Expected O, but got I4
		//IL_06d7: Expected I4, but got O
		//IL_06d7: Expected I4, but got Unknown
		//IL_06d8: Expected O, but got I4
		//IL_06e1: Expected I4, but got O
		//IL_06e2: Expected O, but got I4
		//IL_06eb: Expected I4, but got O
		//IL_06ec: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_0728: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		//IL_0740: Expected O, but got I4
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected I4, but got Unknown
		//IL_074b: Expected O, but got I4
		//IL_0772: Expected O, but got I4
		//IL_0787: Expected O, but got I4
		//IL_07a3: Expected O, but got I4
		//IL_0823: Expected O, but got I4
		//IL_085f: Expected O, but got I4
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got I4
		//IL_0898: Expected O, but got I4
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected I4, but got Unknown
		//IL_08d9: Expected O, but got I4
		try
		{
		}
		finally
		{
			goto IL_0004;
		}
		IL_0004:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array);
		StringComparison comparisonType;
		int num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out void @void);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			Resources resources = resources;
			array = null;
			char[] separator = array;
			object obj = Control1.smethod_0(Control1.smethod_0(null) as ResolveEventArgs);
			StringSplitOptions stringSplitOptions = (StringSplitOptions)((obj is StringSplitOptions) ? obj : null);
			_ = (Resources)(object)"ZNQKM".Split(separator, default(StringSplitOptions));
			resources = null;
		}
		finally
		{
			try
			{
				string text2 = text;
				string text3 = text;
				string value = text;
				comparisonType = default(StringComparison);
				num = (int)checked(2656022747u * unchecked(3243382881u / (uint)(int)string.Concat(text3.IndexOf(value, 629367916, comparisonType) as object[])) * 3850529413u);
				text2.Remove((int)checked(1254617020u * unchecked((uint)num)), num);
				text = text;
				string s = text;
				numberStyles = numberStyles;
				numberStyles = default(NumberStyles);
				Class0 @class = byte.Parse(s, numberStyles) as Class0;
				@class = @class;
			}
			catch
			{
				while (true)
				{
					flag = true;
					@void = @void;
					@void = default(void);
				}
			}
			goto IL_00ce;
		}
		IL_00ce:
		Class4.smethod_0(Settings.Default, (ResolveEventArgs)(object)Settings.Default);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		do
		{
			try
			{
			}
			catch
			{
				text = text;
				text = text4;
				_ = byte.Parse(s2) is Struct2;
			}
		}
		while (flag);
		int startIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		ResolveEventArgs resolveEventArgs_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<string> enumerable2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<string> enumerable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<string> enumerable3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		uint count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj22);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
		object obj25;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		do
		{
			try
			{
				do
				{
					_ = text.LastIndexOf("QOKT", comparisonType) is void;
				}
				while (flag);
			}
			finally
			{
				goto IL_0126;
			}
			IL_0126:
			text = text;
			startIndex = num;
			string obj4 = (string)(object)Settings.Default;
			formatProvider = formatProvider;
			_ = (int)((byte*)184)->ToString(obj4, formatProvider);
			byte num2 = b;
			enumerable = enumerable;
			b = b;
			_ = ((byte*)b2)->GetTypeCode() is IEnumerable<string>;
			object object_3 = obj5;
			resolveEventArgs_ = null;
			_ = (IEnumerable<string>)Class4.smethod_0(object_3, resolveEventArgs_);
			enumerable = enumerable;
			enumerable = enumerable2;
			enumerable = enumerable;
			enumerable = enumerable3;
			_ = (object)string.Concat(enumerable);
			obj5 = obj5;
			object obj6 = ((byte*)num2)->Equals(obj5);
			b = (byte)(224 / ((obj6 is byte) ? obj6 : null));
			ref _003F reference = ref *(_003F*)(b / (byte)Settings.Default);
			object obj7 = Control1.smethod_0("WTACFKR".IndexOf(text, -759728183) as ResolveEventArgs);
			num = (int)System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).ToString("HBOGZSE", "TNCU".LastIndexOf('\ue957', checked(((obj7 is int) ? obj7 : null) - num)) as IFormatProvider);
			object obj8;
			checked
			{
				count = unchecked((uint)num3) * 3690021285u;
				text = "TXTCRWNXF";
				text = text5;
				string text6 = text;
				string value2 = text;
				string s3 = text;
				text = text;
				formatProvider = formatProvider;
				obj8 = byte.Parse("PKIKWM", provider);
			}
			NumberStyles style = (NumberStyles)text7.ToCharArray((int)((obj8 is int) ? obj8 : null), -1832719559);
			byte num4 = (byte)((byte*)218)->ToString((string)(object)Settings.Default);
			byte num5 = (byte)string.Concat(obj5, obj5, obj5);
			uint num6 = 232u / (uint)b;
			array2 = array2;
			array2 = array3;
			uint num7 = num5 / (num6 / (byte)Control4.smethod_1(array2)) / (byte)Settings.Default;
			string s4;
			string strA;
			checked
			{
				uint num8 = 87u + unchecked((uint)b);
				b = 220;
				s4 = text;
				strA = text;
			}
			string separator2 = string.CompareOrdinal(((byte*)(byte)text.GetEnumerator())->GetHashCode() as string, "LUIJTHTU") as string;
			object obj9 = byte.TryParse(text, out *(byte*)null);
			object obj10 = ((byte*)checked(173 + ((obj9 is byte) ? obj9 : null)))->Equals(220);
			object obj11 = ((obj10 is byte) ? obj10 : null);
			text = text;
			text = text8;
			text = text9;
			int indexA = (int)/*isinst with value type is only supported in some contexts*/;
			string strB = text;
			int indexB = (int)/*isinst with value type is only supported in some contexts*/;
			string text10 = text;
			string oldValue = text;
			object obj12 = text.IndexOfAny(array);
			object obj13 = string.Compare(strA2, indexA, strB, indexB, (int)checked(1851204615u + unchecked((uint)(int)text10.Replace(oldValue, ((byte*)((obj12 is byte) ? obj12 : null))->Equals(null) as string)) + unchecked((uint)num)), comparisonType);
			byte num9 = (byte)((byte*)((obj13 is byte) ? obj13 : null))->ToString();
			object object_4 = obj5;
			string text11 = text;
			text = text;
			string s5 = (string)(object)Class4.smethod_0(object_4, (ResolveEventArgs)(object)(text11 + text12 + text));
			string s6 = (string)(object)Class4.smethod_0(null, null);
			b = 0;
			ref _003F reference2 = ref *(_003F*)checked(19u * unchecked((uint)b3));
			object obj14 = byte.TryParse(text, numberStyles, (IFormatProvider)(object)Control4.smethod_1(null), out *(byte*)null);
			object obj15 = byte.Parse(s6, System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).Equals((byte)checked(247 + ((obj14 is byte) ? obj14 : null))) as IFormatProvider);
			object obj16 = ((obj15 is NumberStyles) ? obj15 : null);
			byte num10 = (byte)Control4.smethod_1(null);
			text = text;
			b = 185;
			string separator3 = ((byte*)(num10 / ((uint)(byte)((byte*)null)->ToString(text13, (IFormatProvider)(object)((byte*)checked(178u * unchecked((uint)b4)))->ToString()) / 185u)))->Equals(null) as string;
			string s7 = text;
			string s8 = (string)(object)"PBEP".ToCharArray();
			numberStyles = default(NumberStyles);
			object obj17 = byte.Parse(s8, numberStyles, null);
			object obj18 = ((obj17 is NumberStyles) ? obj17 : null);
			formatProvider = formatProvider;
			int style2 = (int)obj16;
			int style3 = (int)obj18;
			object obj19 = byte.Parse("TSFW", numberStyles);
			string s9 = byte.Parse(s5, (NumberStyles)style2, (IFormatProvider)(object)Control4.smethod_1((byte[])(object)string.Join(separator3, byte.TryParse(s7, (NumberStyles)style3, provider2, out *(byte*)((obj19 is ref byte) ? obj19 : null)) as IEnumerable<string>))) as string;
			numberStyles = default(NumberStyles);
			NumberStyles style4 = numberStyles;
			string s10 = Control1.smethod_0((ResolveEventArgs)(object)Settings.Default) as string;
			NumberStyles style5 = numberStyles;
			formatProvider = ((byte*)(byte)Control4.smethod_1(null))->GetTypeCode() as IFormatProvider;
			text = byte.TryParse(s10, style5, provider3, out *(byte*)null) as string;
			formatProvider = (IFormatProvider)(object)Control4.smethod_1((byte[])(object)string.Intern(string.Copy(string.Concat("XCBCRA".LastIndexOf(value3, (StringComparison)text.ToUpper()) as object, obj5, obj5))));
			object obj20 = ((byte*)220)->CompareTo(byte.Parse(s9, style4, provider4) as object);
			_003F val = checked(obj11 * (num9 - ((obj20 is byte) ? obj20 : null)));
			_ = ((byte*)551)->CompareTo(obj5) is string;
			text = text;
			_ = (string)(object)Settings.Default;
			text = string.Concat((string[])(object)((byte*)67)->ToString("Y", formatProvider));
			string[] value4 = (string[])(object)((byte*)val)->ToString(text14 + text15 + "G", null);
			string text16 = text;
			string s11 = text;
			string strA3 = text;
			text = text;
			cultureInfo = cultureInfo;
			object obj21 = string.Compare(strA3, strB2, cultureInfo, default(CompareOptions));
			string s12 = byte.TryParse(s11, out *(byte*)((obj21 is ref byte) ? obj21 : null)) as string;
			obj5 = obj5;
			text = byte.TryParse(s12, out *(byte*)string.Concat(obj22)) as string;
			text = "IHNEPEMI";
			object obj23 = ((byte*)(byte)string.Join(separator2, value4, 657706158, text16.IndexOf(value5, 1115883217, (StringComparison)Class4.smethod_0(obj5, null))))->Equals(185);
			_003F val2 = ((obj23 is int) ? obj23 : null) / -642620619;
			string strB3 = text;
			string text17 = text;
			int startIndex2 = (int)Control4.smethod_1((byte[])(object)string.Format(formatProvider, text, null));
			int count2 = num;
			comparisonType = default(StringComparison);
			object obj24 = string.Compare(strA, (int)val2, strB3, text17.LastIndexOf("PGOEOI", startIndex2, count2, comparisonType), (int)Class4.smethod_0(obj5, resolveEventArgs_), comparisonType);
			b = byte.Parse(s4, (NumberStyles)((obj24 is NumberStyles) ? obj24 : null));
			b = b5;
			obj25 = byte.Parse(s13, (NumberStyles)/*isinst with value type is only supported in some contexts*/);
		}
		while ("QNOEFXIA".LastIndexOf(value6, startIndex, (int)count, (StringComparison)((obj25 is StringComparison) ? obj25 : null)) is bool);
		numberStyles = default(NumberStyles);
		_ = byte.Parse("XOS", numberStyles, null) is void;
		_ = (GControl1)(object)((byte*)247)->ToString();
		object obj26 = Control1.smethod_0(resolveEventArgs_);
		ref _003F reference3 = ref *(_003F*)((obj26 is byte) ? obj26 : null);
		byte num11 = b;
		object obj27 = Control1.smethod_0(Control1.smethod_0(resolveEventArgs_) as ResolveEventArgs);
		_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).CompareTo((byte)(int)checked(num11 + ((obj27 is byte) ? obj27 : null))) is void;
		text = (string)(object)((byte*)b)->ToString((IFormatProvider?)null).ToCharArray();
		try
		{
			try
			{
				@_ obj28 = ((byte*)b)->CompareTo(33) as @_;
				@_ _2 = _2;
				_2 = obj28;
			}
			catch
			{
				_ = text.IndexOfAny(array) is string;
				Control1 control = control;
				control = null;
				control = control;
				_ = text.IndexOf('ꤍ') is Class0;
			}
			finally
			{
				try
				{
					string separator4 = text;
					string[] value7 = null;
					Control0 obj30 = (Control0)(object)string.Join(separator4, value7);
					Control0 control2 = control2;
					control2 = obj30;
					Control4 control3 = control3;
					control3 = null;
					control3 = control3;
				}
				catch
				{
					_ = (Class3)(object)Settings.Default;
					@_ _2 = null;
					byte num12 = b;
					byte num13 = b;
					b = 2;
					uint num14;
					checked
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b8);
						num14 = num12 * (num13 + (unchecked((uint)b8) + 106u));
					}
					b = (byte)checked(18u * (118u + unchecked((uint)(byte)Class4.smethod_0(Control4.smethod_1(null), null))));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b9);
					uint num15 = checked(num14 + b9);
					b = b;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte obj31);
					_ = (byte)string.Format(((byte*)num15)->Equals(obj31) as IFormatProvider, "X", null, obj5);
					@void = @void;
					@void = @void;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out void void2);
					@void = void2;
				}
				goto end_IL_0763;
			}
			end_IL_0763:;
		}
		catch
		{
			try
			{
			}
			finally
			{
				try
				{
					object obj33 = text.IndexOfAny(null, num, -498808991);
					object obj34 = ((obj33 is byte) ? obj33 : null);
					b = b;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b10);
					_003F val3 = obj34 / b10;
					uint num16;
					string s14;
					checked
					{
						num16 = 65u * unchecked((uint)b);
						s14 = text;
						numberStyles = default(NumberStyles);
						numberStyles = numberStyles;
					}
					System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style6);
					object obj35 = byte.TryParse(byte.Parse(s14, style6, null) as string, out *(byte*)null);
					b = (byte)(int)checked(val3 * (num16 + (49 + ((obj35 is byte) ? obj35 : null))));
				}
				finally
				{
					b = 232;
					goto end_IL_084c;
				}
			}
			end_IL_084c:;
		}
		try
		{
			while (flag)
			{
				@_ _2 = (@_)(object)Settings.Default;
			}
		}
		finally
		{
			text = "LSMUC";
			NumberStyles style7 = numberStyles;
			text = byte.Parse(text, numberStyles) as string;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text18);
			text = text18;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s15);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text19);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string oldValue2);
			byte.Parse(s15, style7, (IFormatProvider)(object)text19.Replace(oldValue2, text));
			goto IL_08fa;
		}
		IL_08fa:
		_ = (GControl1)(object)text.Split(array);
	}

	unsafe static void awejudorak1()
	{
		//IL_000c: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_0106: Expected I4, but got O
		//IL_0107: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_021d: Expected I4, but got O
		//IL_021e: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected I4, but got Unknown
		//IL_0255: Expected O, but got I4
		//IL_0266: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		try
		{
		}
		catch
		{
			b = b;
			_ = ((byte*)b)->GetTypeCode() is void;
			Control0 control = null;
			control = control;
			b = b;
			b = (byte)Control4.smethod_1(null);
		}
		object obj2;
		try
		{
		}
		finally
		{
			ResolveEventArgs resolveEventArgs_;
			do
			{
				obj2 = Settings.Default;
				resolveEventArgs_ = null;
			}
			while (((byte*)checked(unchecked(69u / (uint)(byte)((byte*)(byte)Class4.smethod_0(obj2, resolveEventArgs_))->ToString()) - b))->Equals(obj2));
			goto IL_005e;
		}
		IL_005e:
		byte[] byte_ = null;
		_ = (string)(object)Control4.smethod_1(byte_);
		string s;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		do
		{
			s = (string)(object)"SQOGT".GetEnumerator();
			byte num = b;
			string text = ((byte*)63)->ToString();
			string text2 = byte.Parse(Control1.smethod_0(null) as string) as string;
			string text3 = text2;
			text2 = ((byte*)37)->GetTypeCode() as string;
			string value = text2;
			object obj3 = ((byte*)190)->GetHashCode();
			text2 = ((byte*)((obj3 is byte) ? obj3 : null))->ToString(text2);
			object obj4 = byte.Parse(s2, style);
			char value2 = (char)((byte*)checked(124u * (unchecked((uint)checked(num - unchecked((byte)"SYY".TrimEnd((char[])(object)(text + text3 + (text4.IndexOf(value, (int)((obj4 is int) ? obj4 : null), (int)checked((unchecked((uint)(int)Settings.Default) + 3115027903u) * 3115027903u)) as string)))))) + 207u)))->ToString();
			string obj5 = "JM".LastIndexOf(value2) as string;
			string value3 = text2;
			int startIndex = (int)string.Concat(obj2, null);
			uint num2 = checked(375331095u * 2813948965u);
			string text5 = text2;
			string s3 = text2;
			style = (NumberStyles)"EDW".ToUpperInvariant();
			style = style;
			string obj6 = (string)(object)text2.PadLeft((int)checked((1755351944u + 1378520211u * 3283207617u) * 22u)).Split((char[]?)null);
			string s4 = text2;
			style = style;
			style = numberStyles;
			string[] array = byte.Parse(s4, style2) as string[];
			array = array2;
			string s5 = (string)(object)obj6.Split(array, -1179939393, default(StringSplitOptions));
			ref byte reference = ref *(byte*)null;
			object obj7 = text5.Equals("KQPSMAKL", (StringComparison)/*isinst with value type is only supported in some contexts*/);
			_ = obj5.LastIndexOf(value3, startIndex, (int)checked(num2 + (unchecked(((obj7 is int) ? obj7 : null) / -298222738) * (2984341437u + (unchecked((uint)(int)string.Concat<T>((IEnumerable<T>)null)) + 3463668796u)) - num3) * unchecked((int)Settings.Default))) is NumberStyles;
			style = style;
		}
		while (byte.Parse(s, style) is bool);
	}
}
