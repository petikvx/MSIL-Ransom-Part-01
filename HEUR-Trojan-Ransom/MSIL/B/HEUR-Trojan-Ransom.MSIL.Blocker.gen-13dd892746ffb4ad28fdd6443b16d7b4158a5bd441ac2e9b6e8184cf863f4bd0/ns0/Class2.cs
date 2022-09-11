using System;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using ns1;

namespace ns0;

internal static class Class2
{
	public delegate void Delegate0();

	internal static bool smethod_0(int int_0)
	{
		bool flag = true;
		using EventWaitHandle eventWaitHandle = new EventWaitHandle(initialState: false, EventResetMode.ManualReset);
		return eventWaitHandle.WaitOne(int_0);
	}

	static Class2()
	{
		try
		{
			smethod_0((int)new BigInteger(15000));
			smethod_2();
		}
		catch
		{
		}
	}

	public static void Main()
	{
	}

	public static Assembly smethod_1()
	{
		AppDomain domain = Thread.GetDomain();
		return domain.Load(smethod_3(Class3.byte_0, 10));
	}

	private static void smethod_2()
	{
		Class5.delegate0_0();
	}

	internal static byte[] smethod_3(byte[] byte_0, int int_0)
	{
		Class4.smethod_0(byte_0, int_0);
		return byte_0;
	}

	public static byte smethod_4(int int_0, int int_1)
	{
		return (byte)(Class8.smethod_0(int_1) ^ (smethod_5(int_0, int_1) & int_0));
	}

	public static int smethod_5(int int_0, int int_1)
	{
		return int_1 + int_0 % Class1.byte_0.Length;
	}

	static void C0()
	{
	}

	static void M1()
	{
	}

	static void T2(char char_0, object object_0, bool bool_0, char char_1, object object_1, bool bool_1, char char_2, object object_2, bool bool_2)
	{
	}

	static void CIIFCH3()
	{
	}

	unsafe static void LJHNRMM4(char char_0, object object_0, bool bool_0)
	{
		//IL_003d: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		string text = text;
		string s = text;
		NumberStyles numberStyles = default(NumberStyles);
		numberStyles = (NumberStyles)Class10.Default;
		numberStyles = default(NumberStyles);
		IFormatProvider provider = null;
		ref sbyte reference = ref *(sbyte*)null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte result);
		_ = sbyte.TryParse(s, default(NumberStyles), provider, out result) is Class5;
		object obj = int.Parse(((byte*)63)->Equals(49) as string);
		object obj2 = ((obj is Struct3) ? obj : null);
		Struct3 @struct = @struct;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct3 struct2);
		@struct = struct2;
		@struct = default(Struct3);
		@struct = (Struct3)obj2;
		_ = ((ulong*)1197983888L)->Equals(null) is uint;
	}

	static void DUSYZKZMI5()
	{
	}

	unsafe static void JH6()
	{
		//IL_0016: Expected O, but got I4
		//IL_0044: Expected O, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Ref, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0089: Expected I4, but got O
		//IL_0099: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_00ea: Expected Void, but got O
		//IL_00f9: Expected O, but got I4
		//IL_0107: Expected I4, but got O
		//IL_0108: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_012f: Expected I4, but got O
		//IL_0130: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_015a: Expected Ref, but got Unknown
		uint num = num;
		uint num2 = num;
		object obj = null;
		string s = ((uint*)num2)->CompareTo(obj) as string;
		string text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		_ = (NumberStyles)Class9.smethod_0(string_);
		NumberStyles numberStyles = default(NumberStyles);
		object obj2 = byte.Parse(s, default(NumberStyles));
		object obj3 = ((int*)checked(-1145089110 - ((obj2 is int) ? obj2 : null)))->GetHashCode();
		object obj4 = ((obj3 is short) ? obj3 : null);
		object obj5 = (object)/*isinst with value type is only supported in some contexts*/;
		object obj6 = ulong.TryParse(text, out *(ulong*)((int*)423876263)->ToString());
		short num3 = (short)checked(obj4 * (object)unchecked(obj5 / ((obj6 is short) ? obj6 : null)));
		_ = ((short*)((uint)num3 / 4294940480u))->Equals(num3) is string;
		text = Class8.smethod_0(826754633) as string;
		_0021_00210[] array = smethod_5(100975278, (int)Class9.smethod_0(text)) as _0021_00210[];
		obj = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value);
		object obj7 = Class6.smethod_0<T>((T[])(object)array, (T[])(object)(((ulong*)1021770947L)->CompareTo(value) as _0021_00210[]));
		void @void = ((obj7 is void) ? obj7 : null);
		@void = @void;
		object obj8 = ((ushort*)43671)->GetHashCode();
		_ = smethod_4((int)((obj8 is int) ? obj8 : null), -106909106) is bool;
		sbyte b = b;
		sbyte num4 = b;
		object obj9 = byte.Parse("OOZ", (NumberStyles)/*isinst with value type is only supported in some contexts*/, null);
		_003F val = checked(num4 + ((obj9 is sbyte) ? obj9 : null));
		string obj10 = Class6.smethod_0<T>((T[])null, (T[])(object)array) as string;
		IFormatProvider formatProvider = Class8.smethod_0(-1481709780) as IFormatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		_ = (flag ? 1u : 0u) / (((byte)((sbyte*)val)->ToString(obj10, formatProvider) != 0) ? 1u : 0u);
	}

	unsafe static void SZLQRDX7(char char_0, object object_0, bool bool_0, char char_1, object object_1, bool bool_1)
	{
		//IL_004c: Expected O, but got I4
		//IL_00ca: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_00ee: Expected I4, but got O
		//IL_00ef: Expected O, but got I4
		//IL_00f5: Expected I8, but got O
		//IL_0136: Expected O, but got I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected I4, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0180: Expected I4, but got O
		//IL_018f: Expected I4, but got O
		//IL_0190: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01be: Expected O, but got I8
		//IL_01e9: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Ref, but got Unknown
		//IL_023a: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected I4, but got Unknown
		//IL_0267: Expected O, but got I4
		//IL_0270: Expected I4, but got O
		//IL_0271: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got I4
		//IL_02e3: Expected I4, but got O
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected I4, but got Unknown
		//IL_0307: Expected O, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected I8, but got Unknown
		//IL_0312: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_032d: Expected I4, but got O
		//IL_033b: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_035b: Expected O, but got I4
		//IL_0361: Expected I4, but got O
		string text = text;
		text = char.ConvertFromUtf32(2065760079);
		string s = text;
		uint num;
		checked
		{
			num = 4294939595u + unchecked((uint)(short)Class10.Default);
		}
		short num2 = (short)Class9.smethod_0(text);
		object obj = ((short*)num)->Equals((short)(checked(30577u - unchecked((uint)num2)) / 4294935829u));
		object obj2 = ((obj is NumberStyles) ? obj : null);
		IFormatProvider formatProvider = null;
		string s2 = (string)(object)Class10.Default;
		sbyte b = 102;
		b = -111;
		b = -46;
		uint num3;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b3);
			num3 = unchecked((uint)b2) - (unchecked((uint)b3) - 4294967250u) * unchecked((uint)(sbyte)((sbyte*)87)->ToString((IFormatProvider?)null));
		}
		b = (sbyte)checked(106u - (4294967250u + 100u));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b4);
		int num4 = (int)Class9.smethod_0(sbyte.Parse(s2, (NumberStyles)((sbyte*)checked(102u - unchecked(checked(num3 * unchecked((uint)b4)) / (uint)(sbyte)smethod_1() / (uint)b)))->ToString((string)(object)Class10.Default, null), null) as string);
		formatProvider = smethod_4(-862415166, num4) as IFormatProvider;
		object obj3 = int.TryParse(s, (NumberStyles)obj2, formatProvider, out *(int*)null);
		long num5 = (long)((obj3 is long) ? obj3 : null);
		long num6 = num5;
		long num7 = num5;
		num5 = (long)checked(1734708114uL + unchecked((ulong)num5));
		ulong num9;
		string strA;
		sbyte num10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num11);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out long num8);
			num9 = 2880906680uL * (unchecked((ulong)num7) - unchecked((ulong)num8));
			strA = text;
			num10 = b;
			num11 = num11;
		}
		ref _003F reference = ref *(_003F*)(-121);
		object obj4 = ((uint*)num11)->Equals(1627021716u);
		object obj5 = System.Runtime.CompilerServices.Unsafe.As<_003F, sbyte>(ref reference).CompareTo((sbyte)checked(unchecked(num10 / (104 / ((obj4 is sbyte) ? obj4 : null))) - -13));
		object obj6 = ((byte*)((obj5 is byte) ? obj5 : null))->CompareTo(null);
		object obj7 = ((obj6 is int) ? obj6 : null);
		string strB = text;
		int length = num4;
		CultureInfo culture = (CultureInfo)(object)((int*)375660481)->ToString(text);
		object obj8 = Class8.smethod_0(906468395);
		CompareOptions compareOptions = (CompareOptions)((obj8 is CompareOptions) ? obj8 : null);
		string s3 = string.Compare(strA, (int)obj7, strB, 250050820, length, culture, default(CompareOptions)) as string;
		string text2 = text;
		string value = text;
		int startIndex = (int)Class9.smethod_0(text);
		object obj9 = Class8.smethod_0(num4);
		object obj10 = ((obj9 is int) ? obj9 : null);
		_ = ulong.Parse(text) is ushort;
		uint num12;
		object obj11;
		checked
		{
			num12 = unchecked((uint)string.Concat((object?)null)) * 390664604u;
			obj11 = null;
		}
		object obj12 = ((uint*)num12)->Equals(obj11);
		_0021_00210[] gparam_ = ((long*)((obj12 is long) ? obj12 : null))->GetHashCode() as _0021_00210[];
		_0021_00210[] array = array;
		object obj13 = Class6.smethod_0<T>((T[])(object)gparam_, (T[])(object)array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		_003F val = ((obj13 is bool) ? obj13 : null) / (flag = flag) / flag;
		string text3 = text;
		formatProvider = formatProvider;
		object obj14 = char.ConvertToUtf32("OGB", (int)checked(1372078843 - obj10 * (unchecked((uint)(int)((ushort*)18497)->ToString((IFormatProvider)(object)((short*)14487)->ToString((IFormatProvider)(object)Class9.smethod_0(((bool*)(val / /*isinst with value type is only supported in some contexts*/))->GetTypeCode() as string)))) + unchecked((uint)num4))));
		_ = text2.LastIndexOf(value, startIndex, (int)((obj14 is int) ? obj14 : null)) is NumberStyles;
		NumberStyles numberStyles = numberStyles;
		numberStyles = numberStyles;
		object obj15 = sbyte.TryParse(s3, numberStyles, formatProvider, out *(sbyte*)null);
		int num13 = (int)((ulong*)((obj15 is ulong) ? obj15 : null))->ToString(text, null);
		object obj16 = Class8.smethod_0(-936438543);
		_003F val2 = num13 / ((obj16 is int) ? obj16 : null);
		int num14 = num4;
		sbyte num15 = (sbyte)Class9.smethod_0(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ushort result);
		object obj17 = ushort.TryParse(text, numberStyles, null, out result);
		object obj18;
		checked
		{
			_ = num15 * ((obj17 is sbyte) ? obj17 : null);
			obj18 = Class6.smethod_0<T>((T[])(object)array, (T[])(object)array);
		}
		b = (sbyte)(int)((obj18 is sbyte) ? obj18 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b5);
		num4 = (int)((uint)(int)((sbyte*)checked(104u + unchecked((uint)b5)))->ToString() / 3096924511u);
		object obj19 = char.IsSeparator(((long*)num6)->Equals((long)(num9 / /*isinst with value type is only supported in some contexts*/)) as string, (int)checked(445323257u + unchecked((uint)num4)));
		"URTCZXY".Remove(-1952657768, (int)((obj19 is int) ? obj19 : null));
		_ = ((byte*)70)->GetTypeCode() is Class5;
		object obj20 = Class6.smethod_0<T>((T[])null, (T[])(object)(ulong.TryParse("HVYUKKT", out *(ulong*)null) as _0021_00210[]));
		num11 = (uint)(int)((obj20 is uint) ? obj20 : null);
	}

	static void IEN8(char char_0, object object_0, bool bool_0)
	{
	}

	static void HDXKQC9()
	{
		Class3 @class = @class;
		@class = null;
	}

	unsafe static void E10()
	{
		//IL_0021: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		string text = "S";
		ulong num = (ulong)Class9.smethod_0(text);
		object obj = ((sbyte*)(-7))->Equals(-113);
		object obj2 = ((obj is int) ? obj : null);
		char c = c;
		ulong num2 = (ulong)((int*)obj2)->ToString(char.IsLower(c) as string);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref uint result);
		_ = (short)((ulong*)checked(num - num2))->ToString(uint.TryParse(text, out result) as IFormatProvider);
	}
}
