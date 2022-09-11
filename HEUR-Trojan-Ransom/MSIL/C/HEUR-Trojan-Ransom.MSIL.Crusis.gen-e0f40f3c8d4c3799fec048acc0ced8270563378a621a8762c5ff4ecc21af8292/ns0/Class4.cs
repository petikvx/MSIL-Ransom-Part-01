using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;

namespace ns0;

internal sealed class Class4
{
	public static byte[] byte_0;

	public static AppDomain appDomain_0;

	public static Assembly assembly_0;

	internal static string smethod_0(bool bool_0)
	{
		return null;
	}

	internal static string smethod_1(Type[] type_0, CallingConventions callingConventions_0, bool bool_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = "";
		foreach (Type obj in type_0)
		{
			stringBuilder.Append(value);
			string text = smethod_0(bool_0);
			if (obj.IsByRef && !bool_0)
			{
				stringBuilder.Append(text.TrimEnd(new char[1] { '&' }));
				stringBuilder.Append("");
			}
			else
			{
				stringBuilder.Append(text);
			}
			value = ", ";
		}
		if ((callingConventions_0 & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			stringBuilder.Append(value);
			stringBuilder.Append("...");
		}
		return stringBuilder.ToString();
	}

	unsafe static void smethod_2()
	{
		//IL_0018: Expected O, but got I4
		//IL_001d: Expected I, but got O
		//IL_002e: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Ref, but got Unknown
		//IL_00e3: Expected O, but got I8
		//IL_00f6: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected I, but got Unknown
		//IL_012d: Expected O, but got I8
		//IL_0136: Expected I, but got O
		//IL_0137: Expected O, but got I8
		//IL_0146: Expected O, but got I4
		//IL_014c: Expected I8, but got O
		//IL_016b: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected I4, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_023a: Expected O, but got I8
		//IL_0260: Expected O, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected I4, but got Unknown
		//IL_0277: Expected O, but got I4
		//IL_029f: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0332: Expected I8, but got O
		//IL_0340: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_0358: Expected I4, but got O
		//IL_0359: Expected O, but got I4
		//IL_0375: Expected O, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected I8, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected I8, but got Unknown
		//IL_0389: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_03a6: Expected I4, but got O
		//IL_03a6: Expected Ref, but got Unknown
		//IL_03b5: Expected I4, but got O
		//IL_03b6: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_03e2: Expected O, but got I8
		//IL_03ed: Expected O, but got I4
		//IL_03f7: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_043f: Expected O, but got I4
		//IL_0449: Expected O, but got I4
		//IL_0460: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		//IL_04c8: Expected O, but got I4
		//IL_0551: Expected O, but got I4
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected I4, but got Unknown
		//IL_0562: Expected O, but got I4
		//IL_0598: Expected O, but got I4
		//IL_05eb: Expected O, but got I
		//IL_0604: Expected O, but got I4
		//IL_0626: Expected O, but got I4
		//IL_0639: Expected O, but got I4
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected I8, but got Unknown
		//IL_0646: Expected O, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Ref, but got Unknown
		//IL_065c: Expected O, but got I4
		//IL_0662: Expected I4, but got O
		//IL_066c: Expected O, but got I4
		//IL_067b: Expected O, but got I4
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Ref, but got Unknown
		//IL_068b: Expected O, but got I4
		//IL_06c3: Expected O, but got I4
		//IL_06c9: Expected I4, but got O
		//IL_06d9: Expected O, but got I4
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected I4, but got Unknown
		//IL_0704: Expected O, but got I4
		//IL_070a: Expected I4, but got O
		//IL_071f: Expected O, but got I4
		//IL_072d: Expected I4, but got O
		//IL_072e: Expected O, but got I4
		//IL_073a: Expected O, but got I4
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected I4, but got Unknown
		//IL_0746: Expected O, but got I4
		//IL_074c: Expected I4, but got O
		//IL_0758: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected O, but got I4
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected O, but got I4
		//IL_07e3: Expected O, but got I4
		//IL_080a: Expected O, but got I4
		//IL_0814: Expected O, but got I4
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected I8, but got Unknown
		//IL_0824: Expected O, but got I4
		//IL_082f: Expected O, but got I4
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected O, but got I4
		//IL_0883: Expected O, but got I4
		//IL_08be: Expected O, but got I4
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected I4, but got Unknown
		//IL_08ce: Expected O, but got I4
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected I4, but got Unknown
		//IL_08dc: Expected O, but got I4
		//IL_08e5: Expected I4, but got O
		//IL_08ea: Expected Ref, but got Unknown
		//IL_08eb: Expected O, but got I4
		//IL_08f9: Expected O, but got I8
		//IL_0921: Expected O, but got I4
		//IL_092c: Expected I4, but got O
		//IL_092d: Expected O, but got I4
		//IL_093d: Expected O, but got I8
		//IL_0943: Expected I4, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int int_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int int_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num20);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num21);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		while ("bvWAxVDoMP2eHVct".GetTypeCode() is bool)
		{
			b = (byte)Settings.Default;
			object obj = ((byte*)b)->GetTypeCode();
			num = (nint)((obj is IntPtr) ? obj : null);
			num = default(IntPtr);
			object obj2 = (int)num;
			object obj3 = ((obj2 is short) ? obj2 : null);
			obj4 = null;
			_ = ((short*)obj3)->Equals(obj4) is string;
			IntPtr intPtr = num;
			IntPtr intPtr2 = num;
			num2 = num2;
			num2 = (ushort)((uint)(ushort)Settings.Default / 61606u);
			object obj5 = ((ushort*)num2)->GetTypeCode();
			object obj6 = ((obj5 is IntPtr) ? obj5 : null);
			text = text;
			c = 'ꌰ';
			uint uint_ = uint.Parse(text2.LastIndexOf('ꌰ') as string);
			object obj7 = sbyte.Parse("eXMtGydMfRmd354/");
			byte[] obj8 = (byte[])(object)((char*)checked(((obj7 is char) ? obj7 : null) * 22131))->ToString();
			num3 = num3;
			int int_ = num3;
			num3 = -1155704934;
			num3 = (int)Settings.Default;
			num3 = (int)checked(unchecked((uint)num4) - 3299098267u);
			uint num6;
			checked
			{
				num6 = unchecked((uint)num5) + 605095927u;
				num3 = -1659926190;
			}
			num3 = ((int*)checked(num6 - unchecked((uint)num7)))->CompareTo(long.Parse("EgpVCbYXLsA8QEkR") as object);
			_ = Class5.smethod_1(uint_, obj8, int_, int_2) is IntPtr;
			num = default(IntPtr);
			IntPtr intPtr3 = default(IntPtr);
			num = num;
			num = default(IntPtr);
			num = intPtr4;
			num = intPtr5;
			object obj9 = (long)(IntPtr)(nint)checked(unchecked((nuint)(nint)intPtr / ((nuint)(nint)intPtr2 / checked(obj6 - unchecked((nuint)(nint)intPtr6)))) + unchecked((nuint)(nint)num));
			text = ((long)(IntPtr)((obj9 is IntPtr) ? obj9 : null)) as string;
			object obj10 = text.Length;
			num8 = (long)((obj10 is long) ? obj10 : null);
			long num9 = num8;
			object obj11 = ((long*)(-1760007099L))->CompareTo(-955186724L);
			object obj12 = ((obj11 is uint) ? obj11 : null);
			num = default(IntPtr);
			text = ((uint*)1109218080)->CompareTo((uint)(int)checked(obj12 - unchecked((uint)(object)((IntPtr*)num)->ToPointer()) * 538432039u)) as string;
			uint num10;
			checked
			{
				num10 = 29482u * unchecked((uint)num2) + 43533369u;
				object obj13 = string.Compare(text, 550846439, "DobWauSxe2KBrGlu", num3, 2017032611);
				_ = 4579 + ((obj13 is short) ? obj13 : null);
				num11 = num11;
				num11 = num12;
			}
			uint uint_2 = (uint)Class5.smethod_0(((short*)num11)->GetHashCode() as string);
			array = array;
			byte[] array2 = array;
			b2 = (sbyte)Class5.smethod_0(text);
			sbyte num13 = b2;
			resolveEventArgs = resolveEventArgs;
			string s = Class0.smethod_2(resolveEventArgs) as string;
			resolveEventArgs = resolveEventArgs;
			resolveEventArgs = resolveEventArgs2;
			object obj14 = Class0.smethod_2(resolveEventArgs_);
			object object_ = ((short*)((obj14 is short) ? obj14 : null))->Equals(num11) as object;
			text = "FwB/Eky3YrYFKSCQ";
			_ = (IFormatProvider)Class0.smethod_3(object_, long.Parse(s2) as ResolveEventArgs);
			formatProvider = formatProvider;
			formatProvider = formatProvider2;
			object obj15 = ((long*)long.Parse(s, formatProvider))->CompareTo(num8);
			b2 = (sbyte)checked(((obj15 is sbyte) ? obj15 : null) + 16);
			object obj16 = ((sbyte*)checked(unchecked((uint)num13) * unchecked((uint)b3)))->Equals(b2);
			object obj17 = ((obj16 is int) ? obj16 : null);
			num3 = num3;
			object obj18 = ((int*)(423200412u / checked(2718379096u + unchecked((uint)num14))))->Equals(Class5.smethod_0(text));
			object obj19 = obj17 / ((obj18 is int) ? obj18 : null);
			int num15 = num3;
			bool num16 = (byte)((sbyte*)b2)->ToString() != 0;
			object obj20 = char.ToLowerInvariant((char)checked(unchecked((uint)(char)Settings.Default) * 45489u));
			_003F val = checked(num16 - ((obj20 is bool) ? obj20 : null));
			string[] value = null;
			bool num17 = Class0.smethod_2((ResolveEventArgs)(object)string.Join("gSkykH6uN70dtHDI", value));
			ulong num18 = 1889162958uL / (ulong)(long)"aOW0sqKFFdl8ecx5".ToCharArray();
			ulong num19;
			object obj22;
			object obj23;
			checked
			{
				num19 = 18446744072337861852uL - unchecked((ulong)num8);
				object obj21 = bool.Parse("dFKXtyTdKOVF12hF");
				obj22 = ((obj21 is long) ? obj21 : null);
				string s3 = text;
				formatProvider = null;
				obj23 = int.Parse(s3, provider);
			}
			num8 = (long)((obj23 is long) ? obj23 : null);
			object obj24 = (((int*)(-350372344))->GetHashCode() as string).Length;
			byte[] obj25 = char.ConvertToUtf32((char)(int)((obj24 is char) ? obj24 : null), '먿') as byte[];
			num3 = text.CompareTo(text);
			object obj26 = Class5.smethod_1(0u, obj25, int_3, 1332314115);
			num8 = checked(num20 + ((obj26 is long) ? obj26 : null));
			ref _003F reference = ref *(_003F*)num10;
			int int_4 = (int)obj19;
			ref _003F reference2 = ref *(_003F*)val;
			object obj27 = (num17 ? ((bool*)1) : ((bool*)null))->CompareTo(((short*)24412)->ToString(((long*)num18)->Equals((long)checked(num19 * unchecked(obj22 / num21 / num8))) as string));
			text = System.Runtime.CompilerServices.Unsafe.As<_003F, ushort>(ref reference).ToString(Class5.smethod_1(uint_2, array2, int_4, (int)((uint)num15 / checked(unchecked((uint)System.Runtime.CompilerServices.Unsafe.As<_003F, bool>(ref reference2).CompareTo((byte)(int)((obj27 is bool) ? obj27 : null) != 0)) - unchecked((uint)num3) - 2821435720u))) as string);
			text = text;
			text = text3;
			numberStyles = numberStyles;
			object obj28 = uint.Parse(s4, numberStyles, null);
			object obj29 = ((IntPtr*)((obj28 is IntPtr) ? obj28 : null))->ToInt64();
			text = sbyte.Parse(((byte*)((obj29 is byte) ? obj29 : null))->CompareTo(null) as string) as string;
			_ = (ulong)((long*)num9)->ToString(text4);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num24);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num26);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong reference4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num31);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num34);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long value2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int utf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj45);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num37);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj57);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s10);
		while (true)
		{
			object obj30 = ulong.Parse(text, null);
			bool flag = (byte)(int)((obj30 is bool) ? obj30 : null) != 0;
			if (checked((flag2 ? 1u : 0u) - 1u) != 0)
			{
				try
				{
					settings = settings;
				}
				finally
				{
					_ = ((short*)num11)->Equals(((sbyte*)36)->CompareTo(-90) as object) is int;
					continue;
				}
			}
			try
			{
				object obj31 = string.CompareOrdinal(text, "pRjOvAWvU2i49d/G");
				object obj32 = ((obj31 is short) ? obj31 : null);
				long num22 = num8;
				c = '⥩';
				object obj33 = ((long*)num22)->CompareTo((long)((char*)(ushort)c2)->ToString(formatProvider));
				ushort num23 = (ushort)((short*)(obj32 / ((obj33 is short) ? obj33 : null)))->ToString(((ulong*)642945921L)->GetTypeCode() as string, null);
				num2 = num2;
				uint num25;
				checked
				{
					num25 = unchecked((uint)num23) + unchecked((uint)checked(num24 - num2));
					num26 = num26;
				}
				text = (((uint*)num26)->GetTypeCode() as string).ToString(formatProvider);
				ref _003F reference3 = ref *(_003F*)num25;
				uint num27 = checked(22785u * unchecked((uint)(ushort)((ulong*)1388513226723930252L)->ToString(text5)) + 27819u) / (ushort)((byte*)((byte)((ushort*)num2)->ToString("aMOgygy2E1QFPAlD") / checked(112u * unchecked((byte)Settings.Default / ((uint)(byte)Settings.Default / 140u / 154u)) + unchecked((byte)Settings.Default))))->ToString(text);
				object obj34 = ((long*)(-1357659288L))->CompareTo(-794244931L);
				Class0 obj35 = System.Runtime.CompilerServices.Unsafe.As<_003F, ushort>(ref reference3).CompareTo((ushort)(int)checked(num27 - unchecked(((obj34 is ushort) ? obj34 : null) / num2 / num2))) as Class0;
				object object_2 = obj4;
				type = type;
				string s5 = (string)obj35.method_0(object_2, type, null);
				flag = (byte)Settings.Default != 0;
				uint num28;
				checked
				{
					num28 = (flag3 ? 1u : 0u) * (unchecked((ushort*)52849)->Equals(Class0.smethod_2(resolveEventArgs) as object) ? 1u : 0u);
					bool num29 = flag;
					string s6 = text;
					NumberStyles style = numberStyles;
					num = default(IntPtr);
				}
				IFormatProvider provider2 = ((nint)(num - ((int*)checked(1054950292u + unchecked((uint)(int)((ulong*)2027108607L)->ToString((string)(object)Settings.Default, formatProvider))))->CompareTo(null))) as IFormatProvider;
				text = "ftzBLKriGNjMQo2O";
				reference4 = ref reference4;
				object obj36 = ulong.TryParse(s7, out reference4);
				object obj37 = ((obj36 is ushort) ? obj36 : null);
				num2 = (ushort)checked(unchecked((uint)num2) - 39280u);
				object obj38 = ((long*)(-1816628614L))->CompareTo(checked(/*isinst with value type is only supported in some contexts*/ * num8));
				object obj39 = "pA5Pb4cCABFXvOw+".CompareTo(((bool*)checked(num28 * ((obj38 is bool) ? obj38 : null) - 1 - 1))->ToString(formatProvider));
				numberStyles = (NumberStyles)((obj39 is NumberStyles) ? obj39 : null);
				object obj40 = char.IsDigit(int.Parse(s5, style2, formatProvider) as string, -1245199012);
				Class1 @class = ((ushort*)checked(((obj40 is ushort) ? obj40 : null) - 13145))->GetTypeCode() as Class1;
				@class = @class;
			}
			catch
			{
				string text6 = text;
				num11 = 13163;
				bool num32 = ((short*)num31)->Equals(obj4);
				sbyte num33 = b2;
				object obj41 = ((uint*)num26)->GetTypeCode();
				b2 = (sbyte)(int)((obj41 is sbyte) ? obj41 : null);
				object obj42 = ((sbyte*)checked(unchecked((uint)num33) - unchecked((uint)b4 / 91u)))->Equals(null);
				object obj43 = ((obj42 is int) ? obj42 : null);
				num2 = 27261;
				long num35 = (long)((ushort*)num34)->ToString(formatProvider);
				num8 = num8;
				object obj44;
				checked
				{
					obj44 = Class5.smethod_1(3u, null, 1933236364, obj43 - unchecked((long*)num35)->CompareTo(value2));
				}
				num3 = (int)((obj44 is int) ? obj44 : null);
				obj4 = char.ConvertFromUtf32(utf);
				object obj46 = (num32 ? ((bool*)1) : ((bool*)null))->Equals(obj45);
				object obj47 = Class5.smethod_1(1087723983u, null, (int)((obj46 is int) ? obj46 : null), -818378999);
				object obj48 = ((obj47 is char) ? obj47 : null);
				char num36 = c;
				object obj49 = IntPtr.Size;
				object obj50 = char.IsNumber((char)checked(obj48 + unchecked(num36 / ((obj49 is char) ? obj49 : null))));
				BindingFlags bindingFlags_ = (BindingFlags)((obj50 is BindingFlags) ? obj50 : null);
				object obj51 = ((bool*)checked(1u + (flag ? 1u : 0u)))->GetTypeCode();
				object obj52 = ((obj51 is ulong) ? obj51 : null);
				num37 = num37;
				ulong num38 = checked(507174969uL - (1111788603uL + num37));
				object obj53 = ((short*)(-15844))->Equals(10619);
				_003F val2 = obj52 / checked(num38 + ((obj53 is ulong) ? obj53 : null));
				object obj54 = ((ulong*)660846580L)->GetTypeCode();
				_003F val3 = checked(val2 + ((obj54 is ulong) ? obj54 : null));
				object obj55 = ((byte*)b)->Equals((byte)checked(b * b));
				object obj56 = ((obj55 is ulong) ? obj55 : null);
				ulong num39;
				ulong num40;
				IntPtr intPtr7;
				checked
				{
					num39 = num37 - 607310961uL;
					num40 = 1674695421uL * unchecked(ulong.Parse(text, (NumberStyles)((int*)num3)->ToString(text), ((IntPtr*)num)->GetHashCode() as IFormatProvider) / 1338540884uL);
					num = default(IntPtr);
					intPtr7 = num;
					obj4 = null;
				}
				object obj58 = Class0.smethod_2(((IntPtr*)intPtr7)->Equals(obj57) as ResolveEventArgs);
				num37 = (ulong)(long)checked(num39 - unchecked(num40 / ((obj58 is ulong) ? obj58 : null)));
				object obj59 = ((bool*)/*isinst with value type is only supported in some contexts*/)->CompareTo(value: true);
				_003F val4 = checked(val3 * (763927819L * (obj56 + ((obj59 is ulong) ? obj59 : null) * (562129964uL + (num37 + 24243251uL * num37))) * num37));
				string s8 = text;
				obj4 = obj4;
				string s9 = byte.TryParse(s8, out *(byte*)Class0.smethod_3(object_3, null)) as string;
				object obj60 = ulong.TryParse("804Bcs7KmbS6DG6k", out *(ulong*)Settings.Default);
				object obj61 = ((obj60 is byte) ? obj60 : null);
				byte num42 = b;
				uint num43;
				byte num44;
				checked
				{
					num43 = 164u - 225u * unchecked((uint)b);
					num44 = b;
					b = 49;
					b = 174;
				}
				ref _003F reference5 = ref *(_003F*)val4;
				object obj62 = ((byte*)obj61)->CompareTo((byte)(int)(num42 / checked(num43 - (num44 - (b5 * b6 + /*isinst with value type is only supported in some contexts*/)))));
				text = System.Runtime.CompilerServices.Unsafe.As<_003F, ulong>(ref reference5).Equals(ulong.Parse(s9, (NumberStyles)((obj62 is NumberStyles) ? obj62 : null))) as string;
				_ = ulong.Parse(s10) is MethodBase[];
				MethodBase[] methodBase_ = null;
				string s11 = text6.Substring((int)Class0.smethod_0(bindingFlags_, methodBase_, null, null));
				object obj63 = char.IsSurrogatePair('줅', c);
				_ = sbyte.TryParse(s11, (NumberStyles)((obj63 is NumberStyles) ? obj63 : null), null, out *(sbyte*)null) is ulong;
			}
		}
	}
}
