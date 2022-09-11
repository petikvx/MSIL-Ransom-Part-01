using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns1;

namespace ns2;

[GeneratedCode(" ", " ")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Resources
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 14)]
	private struct Struct0
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[7];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(Assembly.GetEntryAssembly()!.GetName().Name + ".Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static byte[] Byte_0 => (byte[])ResourceManager_0.GetObject("Ⴍ", cultureInfo_0);

	internal Resources()
	{
	}

	static Resources()
	{
		char[] array = new char[8];
		array[3] = '㫪';
		array[0] = 'ᣅ';
		array[7] = '┇';
		array[6] = '\u0a60';
		array[5] = 'ᠡ';
		array[4] = '㭷';
		array[2] = 'ᛅ';
		array[1] = '㡟';
		object_1 = new string[2];
		array_0 = array;
	}

	unsafe static void esawas3()
	{
		//IL_0009: Expected O, but got I4
		//IL_001e: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00d0: Expected Void, but got O
		//IL_00f5: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_0126: Expected I4, but got O
		//IL_013b: Expected O, but got I4
		//IL_0141: Expected I4, but got O
		//IL_0165: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_01d8: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected I4, but got Unknown
		//IL_023c: Expected O, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got I4
		//IL_026f: Expected I4, but got O
		//IL_0270: Expected O, but got I4
		//IL_02e6: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got I4
		//IL_0326: Expected Ref, but got Unknown
		//IL_0331: Expected O, but got I4
		//IL_0356: Expected O, but got I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected I4, but got Unknown
		//IL_0366: Expected O, but got I4
		//IL_03a0: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected I4, but got Unknown
		//IL_03dd: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_0429: Expected O, but got I4
		//IL_0467: Expected O, but got I4
		//IL_0486: Expected O, but got I4
		//IL_049d: Expected O, but got I4
		//IL_04ab: Expected O, but got I4
		//IL_04e3: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			resolveEventArgs = resolveEventArgs;
			_ = Control1.smethod_0(resolveEventArgs) is void;
			_ = "VYNGO".IndexOf('\u16fb') is void;
			obj = obj;
			_ = byte.TryParse((string)(object)GClass0.smethod_0(obj, resolveEventArgs), out *(byte*)null) is Resources;
		}
		catch
		{
			object obj2 = byte.Parse("WOGPQSBJ");
			object obj3 = ((obj2 is Struct2) ? obj2 : null);
			Struct2 @struct = @struct;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
			@struct = struct2;
			@struct = (Struct2)obj3;
		}
		IEnumerable<string> enumerable = null;
		object obj5 = ((byte*)(byte)string.Concat(enumerable))->GetTypeCode() as object;
		string text = (string)(object)GClass0.smethod_0(((byte*)160)->CompareTo(null) as object, null);
		_ = (string)(object)GClass0.smethod_0(obj5, (ResolveEventArgs)text.Clone());
		text = text;
		try
		{
			Struct3 struct3 = struct3;
			struct3 = struct3;
		}
		catch
		{
			try
			{
				try
				{
					object obj6 = string.IsNullOrEmpty("PAIQOCDZE");
					object obj7 = ((obj6 is void) ? obj6 : null);
					void @void = default(void);
					@void = obj7;
				}
				catch
				{
					text = text;
				}
			}
			catch
			{
			}
		}
		string obj11 = (string)text.Clone();
		text = byte.TryParse(text, out *(byte*)null) as string;
		NumberStyles numberStyles = (NumberStyles)Control4.smethod_1(null);
		numberStyles = default(NumberStyles);
		NumberStyles style = numberStyles;
		object obj12 = Control1.smethod_0(resolveEventArgs);
		byte b = (byte)(int)((obj12 is byte) ? obj12 : null);
		int num = checked(-b);
		string text2 = text;
		object obj13 = byte.Parse(text, numberStyles);
		NormalizationForm normalizationForm = (NormalizationForm)((obj13 is NormalizationForm) ? obj13 : null);
		char[] array = Control1.smethod_0((ResolveEventArgs)(object)GClass0.smethod_0(null, (ResolveEventArgs)(object)"NY".Normalize(default(NormalizationForm)))) as char[];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
		_ = (obj11 != byte.Parse(s, style, ((byte*)num)->CompareTo(text2.Trim(array)) as IFormatProvider) as string) is GClass0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		try
		{
			try
			{
				try
				{
					Class0 @class = @class;
					@class = @class;
				}
				finally
				{
					string text3 = text;
					object obj14 = ((byte*)238)->Equals(b);
					object obj15 = ((byte*)((obj14 is byte) ? obj14 : null))->CompareTo(obj);
					array = ((byte*)((obj15 is byte) ? obj15 : null))->Equals(obj) as char[];
					System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] anyOf);
					_ = text3.IndexOfAny(anyOf) is void;
					array2 = (byte[])(object)GClass0.smethod_0(obj, resolveEventArgs);
					byte num2 = (byte)Control4.smethod_1((byte[])(object)((byte*)(byte)Control4.smethod_1(array2))->ToString(text, null));
					byte num3 = byte.Parse("VQN", numberStyles);
					object obj16 = text.CompareTo("AJESIUGCE");
					object obj17 = ((obj16 is byte) ? obj16 : null);
					b = 210;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
					object obj18 = ((byte*)num2)->Equals((byte)(num3 / (obj17 / b2)));
					object obj19 = ((obj18 is byte) ? obj18 : null);
					b = 17;
					checked
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
						_ = obj19 - unchecked(242u / (uint)b3);
						b = 67;
						goto end_IL_0197;
					}
				}
				end_IL_0197:;
			}
			catch
			{
				do
				{
					string a = text;
					string b4 = text;
					object obj20 = byte.Parse(text);
					_ = string.Equals(a, b4, (StringComparison)((obj20 is StringComparison) ? obj20 : null)) is Class1;
				}
				while (flag = flag);
			}
		}
		catch
		{
		}
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
				do
				{
					string[] separator = null;
					stringSplitOptions = stringSplitOptions;
					stringSplitOptions = default(StringSplitOptions);
					_ = (Control0)(object)"EKYPJHRQV".Split(separator, stringSplitOptions);
					string text4 = text;
					string value = text;
					b = b;
					uint num4;
					byte num5;
					checked
					{
						num4 = 165u + unchecked((uint)b);
						num5 = b;
						b = byte.Parse("ZWUP");
					}
					char value2 = (char)(text4.LastIndexOf(value, (StringComparison)((byte*)checked(b5 * (251 * (109 + unchecked(num4 / checked(num5 - /*isinst with value type is only supported in some contexts*/+ 190) / /*isinst with value type is only supported in some contexts*/)))))->ToString(byte.Parse(text) as IFormatProvider)) as string).Normalize();
					object obj23 = Control1.smethod_0((ResolveEventArgs)(object)"EX".Split(array));
					array2 = "SWP".IndexOf(value2, checked(((obj23 is int) ? obj23 : null) + -1323753894)) as byte[];
				}
				while ((byte)Control4.smethod_1(array3) != 0);
			}
			finally
			{
				goto end_IL_0284;
			}
			end_IL_0284:;
		}
		finally
		{
			c c = c;
			c = c;
			goto IL_038d;
		}
		IL_04c7:
		try
		{
		}
		finally
		{
			goto IL_04cb;
		}
		IL_04b9:
		if ((byte)Control4.smethod_1(array2) != 0)
		{
			goto IL_04b9;
		}
		goto IL_04c7;
		IL_04cb:
		try
		{
			string text5 = text;
			StringComparison stringComparison = stringComparison;
			StringComparison stringComparison2;
			stringComparison = stringComparison2;
			StringComparison comparisonType;
			_ = text5.LastIndexOf("ZBSTKJ", comparisonType) is void;
			uc uc = uc;
			uc = uc;
			text = text;
			return;
		}
		catch
		{
			return;
		}
		IL_038d:
		do
		{
			try
			{
				try
				{
					b = b;
				}
				finally
				{
					_ = byte.Parse("HLLTTFQQ", null) is Control3;
					goto end_IL_038d;
				}
				end_IL_038d:;
			}
			finally
			{
				continue;
			}
		}
		while (flag);
		try
		{
			Control1 control = control;
			byte num6 = b;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
			text = text6;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value3);
			object obj25 = string.IsNullOrWhiteSpace(value3);
			b = (byte)checked(num6 * ((obj25 is byte) ? obj25 : null));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
			control = ((byte*)(98u / (uint)b7))->GetHashCode() as Control1;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<string> enumerable2);
			while (true)
			{
				try
				{
					text = text;
					_ = byte.Parse(s2, null) is string;
					_ = byte.Parse("GCINZNLCY", text.IndexOfAny(null, -877546253, (int)Control4.smethod_1(array2)) as IFormatProvider) is string;
				}
				catch
				{
					string text7 = text;
					int num8 = num7;
					array2 = null;
					num7 = (int)checked(unchecked((uint)num8) - unchecked((uint)(int)Control4.smethod_1(array4)));
					enumerable = (IEnumerable<string>)(object)text7.Remove(num7);
					_ = ((byte*)(byte)string.Concat(enumerable2))->GetHashCode() is Control0;
				}
			}
		}
	}
}
