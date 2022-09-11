using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using gdi32;
using ns0;
using ns2;

namespace ns1;

public static class GClass0
{
	public static AppDomain appDomain_0;

	public static Assembly assembly_0;

	public static void smethod_0()
	{
		for (int i = 0; i < Settings.Default.Times; i++)
		{
			Thread.Sleep(Settings.Default.Value);
		}
		appDomain_0 = AppDomain.CurrentDomain;
	}

	static GClass0()
	{
		try
		{
			smethod_0();
			Class2.smethod_2();
		}
		catch
		{
		}
	}

	[STAThread]
	public static int Main()
	{
		smethod_1();
		return 0;
	}

	internal static void smethod_1()
	{
		try
		{
			Program.Void();
			char.IsSymbol(0.GetHashCode().ToString(), -1589808012);
		}
		catch
		{
		}
	}

	unsafe static void smethod_2(object object_0, object object_1, object object_2)
	{
		//IL_0020: Expected O, but got I4
		//IL_0025: Expected I8, but got O
		//IL_002c: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		//IL_0036: Expected O, but got I4
		//IL_0041: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected I4, but got Unknown
		//IL_01d4: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_0209: Expected I4, but got O
		//IL_0231: Expected O, but got I4
		//IL_023b: Expected O, but got I4
		//IL_0242: Expected I8, but got O
		//IL_025d: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_0301: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Ref, but got Unknown
		//IL_030d: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_032b: Expected I4, but got O
		//IL_0340: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj16);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj17);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		while (true)
		{
			try
			{
			}
			catch
			{
				try
				{
					object obj = ((long*)(-407754905L))->GetTypeCode();
					num = (long)((obj is long) ? obj : null);
					object obj2 = ((long*)num)->GetTypeCode();
					object obj3 = char.IsSurrogatePair('结', (char)(int)((obj2 is char) ? obj2 : null));
					_ = ((uint*)((obj3 is uint) ? obj3 : null))->Equals(null) is Class4;
					Class4 @class = null;
					@class = class2;
					@class = @class;
					num2 = 1925294703u;
					num2 = 1925294703u;
				}
				finally
				{
					c = c;
					c = c;
					obj4 = obj4;
					object object_3 = obj4;
					object obj5 = ((uint*)567923098)->Equals(null);
					object obj6 = ((obj5 is ulong) ? obj5 : null);
					string text = ((sbyte*)(sbyte)((long*)num)->ToString())->ToString();
					char.IsControl(text, ((Settings)(object)((sbyte*)105)->ToString()).Value);
					object obj7 = Main();
					object obj8 = ((sbyte*)((obj7 is sbyte) ? obj7 : null))->GetHashCode();
					object obj9 = ((obj8 is byte) ? obj8 : null);
					object obj10 = sbyte.Parse(Main() as string);
					Class2 obj11 = (Class2)(object)((byte*)checked(obj9 - ((obj10 is byte) ? obj10 : null)))->ToString(text);
					object object_4 = obj4;
					Type type_ = null;
					bool num3 = (byte)obj11.method_0(object_4, type_, Main() as CultureInfo) != 0;
					object object_5 = obj4;
					byte b = (byte)checked(unchecked((uint)(byte)((sbyte*)(-116))->ToString("UAWMMR")) - 138u);
					b = (byte)checked(unchecked((uint)b2) * 199u - unchecked((byte)Class1.smethod_4(uint.Parse(text, null) as byte[], int.TryParse(text, out *(int*)null) as byte[])));
					ResolveEventArgs resolveEventArgs_ = (((byte*)checked(72u + unchecked((uint)b)))->CompareTo(b) as Settings).Value as ResolveEventArgs;
					text = (string)(object)Class0.smethod_0(object_5, resolveEventArgs_);
					array = array;
					object obj12 = text2.LastIndexOfAny(array, (int)checked(630245975u - 3345882954u));
					flag = (byte)(num3 / checked(0 * (1 + ((obj12 is bool) ? obj12 : null) + flag))) != 0;
					object obj14;
					checked
					{
						uint num4 = ((flag = flag2) ? 1u : 0u) * 1u;
						text = text;
						text = text3;
						array = array;
						array = null;
						settings = settings;
						int times = settings.Times;
						object obj13 = text.IsNormalized();
						uint count = unchecked((uint)times) + unchecked((uint)(int)((short*)((obj13 is short) ? obj13 : null))->ToString(text, ushort.TryParse(text, out *(ushort*)null) as IFormatProvider)) * 630245975u;
						obj14 = char.IsLetterOrDigit('ꚨ');
					}
					StringSplitOptions stringSplitOptions = (StringSplitOptions)((obj14 is StringSplitOptions) ? obj14 : null);
					object obj15 = ((ushort*)/*isinst with value type is only supported in some contexts*/)->GetHashCode();
					ulong num5 = (ulong)(obj6 / ((obj15 is ulong) ? obj15 : null));
					ulong num6 = checked(2387831681067480382uL + num5);
					string text5 = text;
					formatProvider = formatProvider;
					_ = ((ulong*)(ulong)((byte*)214)->ToString((string)((Class2)null).method_0(object_3, Class1.smethod_3((ResolveEventArgs)(object)((ulong*)num6)->ToString(text5, formatProvider)) as Type, (CultureInfo)null)))->Equals(618251609uL) is Class4;
					string s = text;
					numberStyles = numberStyles;
					numberStyles = default(NumberStyles);
					_ = int.Parse(s, numberStyles, null) is _003CModule_003E;
					resolveEventArgs_ = (ResolveEventArgs)(object)Settings.Default;
					uint num7 = (uint)Class0.smethod_0(null, resolveEventArgs_2);
					object object_6 = obj4;
					byte num8 = (byte)Class1.smethod_4(null, null);
					obj4 = obj4;
					obj4 = obj16;
					obj4 = obj17;
					object obj18 = ((byte*)num8)->CompareTo(value);
					object obj19 = ((obj18 is BindingFlags) ? obj18 : null);
					MethodBase[] methodBase_ = char.IsUpper(text, 0) as MethodBase[];
					object obj20 = ((uint*)num2)->CompareTo(obj4);
					Type[] type_2 = ((ulong*)checked(num5 + ((obj20 is ulong) ? obj20 : null)))->Equals(null) as Type[];
					text = text;
					_ = ((uint*)num7)->Equals(Class0.smethod_0(object_6, (ResolveEventArgs)(object)Class2.smethod_3((BindingFlags)obj19, methodBase_, type_2, char.IsSurrogatePair(s2, -1605853199) as ParameterModifier[]))) is Settings;
					goto end_IL_000b;
				}
				end_IL_000b:;
			}
		}
	}
}
