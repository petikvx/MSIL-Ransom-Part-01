using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ns0;

namespace ns1;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Resources
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct1
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[39];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("gardner.Properties.Resources", typeof(Resources).Assembly);
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

	internal Resources()
	{
	}

	[SecuritySafeCritical]
	static Resources()
	{
		char[] array = new char[8];
		array[5] = 'ᐰ';
		array[1] = 'ⶂ';
		array[2] = '㕝';
		array[3] = '㳌';
		array[7] = '⭑';
		array[6] = '⊿';
		array[0] = '\u1a5b';
		array[4] = 'ᣃ';
		array_1 = new string[5];
		array_0 = array;
	}

	unsafe static void smethod_0(bool bool_0, byte byte_1, IntPtr intptr_0, object object_1, bool bool_1, byte byte_2, IntPtr intptr_1, object object_2, bool bool_2, byte byte_3, IntPtr intptr_2, object object_3)
	{
		//IL_0008: Expected O, but got I8
		//IL_0011: Expected I4, but got O
		//IL_0012: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		//IL_003a: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_004c: Expected I4, but got O
		//IL_0053: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I4, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected I4, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got I4
		//IL_01cd: Expected I4, but got O
		//IL_01ce: Expected O, but got I8
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected I4, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_01f6: Expected O, but got I8
		//IL_0211: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_024d: Expected O, but got I4
		//IL_0263: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected I4, but got Unknown
		//IL_02ed: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_030c: Expected O, but got I4
		//IL_032a: Expected O, but got I4
		//IL_0345: Expected O, but got I4
		//IL_0355: Expected O, but got I4
		//IL_0360: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_03be: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_0405: Expected O, but got I
		//IL_041d: Expected I4, but got O
		//IL_041d: Expected I4, but got O
		//IL_041e: Expected O, but got I4
		//IL_0427: Expected I4, but got O
		//IL_0438: Expected O, but got I4
		//IL_0441: Expected I4, but got O
		//IL_0442: Expected O, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got I
		//IL_0494: Expected O, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected I4, but got Unknown
		//IL_049f: Expected O, but got I4
		//IL_04c3: Expected O, but got I4
		//IL_04cc: Expected I4, but got O
		//IL_04cd: Expected O, but got I4
		//IL_04dc: Expected O, but got I8
		//IL_04fc: Expected O, but got I4
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Ref, but got Unknown
		//IL_0525: Expected O, but got I4
		//IL_0530: Expected O, but got I4
		//IL_053a: Expected O, but got I4
		//IL_0544: Expected O, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Ref, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected Ref, but got Unknown
		//IL_05a9: Expected O, but got I4
		//IL_05bb: Expected O, but got I4
		//IL_05c4: Expected I4, but got O
		//IL_05c5: Expected O, but got I4
		//IL_05d6: Expected I4, but got O
		//IL_05eb: Expected O, but got I4
		//IL_0612: Expected O, but got I
		//IL_061d: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_0658: Expected I4, but got O
		//IL_0659: Expected O, but got I4
		//IL_0679: Expected O, but got I4
		//IL_0687: Expected O, but got I4
		//IL_06a4: Expected O, but got I4
		//IL_06bd: Expected O, but got I4
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got I4
		//IL_06f1: Expected O, but got I
		//IL_074b: Expected Ref, but got Unknown
		//IL_074c: Expected O, but got I4
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected Ref, but got Unknown
		//IL_075b: Expected O, but got I4
		//IL_0796: Expected O, but got I4
		//IL_07a7: Expected O, but got I4
		//IL_07c2: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_07de: Expected I4, but got O
		//IL_07df: Expected O, but got I4
		//IL_07ea: Expected O, but got I8
		//IL_07f4: Expected O, but got I4
		//IL_07fa: Expected I4, but got O
		//IL_0828: Expected O, but got I4
		//IL_082e: Expected I, but got O
		//IL_083e: Expected O, but got I4
		//IL_0862: Expected O, but got I4
		//IL_0872: Expected O, but got I4
		//IL_0897: Expected O, but got I4
		//IL_08a0: Expected I4, but got O
		//IL_08a1: Expected O, but got I4
		//IL_08aa: Expected I4, but got O
		//IL_08ab: Expected O, but got I4
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Ref, but got Unknown
		//IL_08c1: Expected O, but got I4
		//IL_08dd: Expected I4, but got O
		//IL_08de: Expected O, but got I4
		//IL_08f2: Expected O, but got I4
		//IL_091f: Expected O, but got I4
		//IL_0935: Expected O, but got I4
		//IL_0949: Expected O, but got I
		//IL_0968: Expected O, but got I4
		//IL_097c: Expected O, but got I4
		//IL_0995: Expected O, but got I4
		//IL_09ab: Expected O, but got I4
		//IL_09b5: Expected O, but got I4
		//IL_09bf: Expected O, but got I4
		//IL_09cb: Expected O, but got I4
		//IL_09d4: Expected I4, but got O
		//IL_09d5: Expected O, but got I4
		//IL_09ea: Expected O, but got I4
		//IL_09f3: Expected I4, but got O
		//IL_09f4: Expected O, but got I4
		//IL_0a12: Expected O, but got I4
		//IL_0a5d: Expected O, but got I4
		//IL_0a73: Expected O, but got I4
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected I, but got Unknown
		//IL_0a8a: Expected O, but got I8
		//IL_0a93: Expected I4, but got O
		//IL_0a94: Expected O, but got I4
		//IL_0a9e: Expected O, but got I8
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Ref, but got Unknown
		//IL_0b02: Expected O, but got I4
		//IL_0b17: Expected O, but got I8
		//IL_0b4f: Expected O, but got I4
		//IL_0b58: Expected I4, but got O
		//IL_0b59: Expected O, but got I4
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got I4
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected O, but got I4
		//IL_0b9d: Expected O, but got I4
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected I4, but got Unknown
		//IL_0bb7: Expected I4, but got Unknown
		//IL_0bd2: Expected O, but got I4
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected I4, but got Unknown
		//IL_0bfc: Expected O, but got I4
		//IL_0c1b: Expected O, but got I4
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected Ref, but got Unknown
		//IL_0c32: Expected O, but got I4
		//IL_0c4f: Expected O, but got I4
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected O, but got I4
		//IL_0c6e: Expected I4, but got O
		//IL_0c6e: Expected Ref, but got Unknown
		//IL_0c6f: Expected O, but got I4
		//IL_0c79: Expected O, but got I4
		//IL_0c83: Expected O, but got I4
		//IL_0c98: Expected O, but got I4
		//IL_0ca9: Expected O, but got I4
		//IL_0cd4: Expected O, but got I4
		//IL_0ce6: Expected O, but got I4
		//IL_0cf0: Expected O, but got I4
		//IL_0cfa: Expected O, but got I4
		//IL_0d0d: Expected O, but got I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected I4, but got Unknown
		//IL_0d20: Expected I, but got O
		//IL_0d21: Expected O, but got I
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got I4
		//IL_0d70: Expected I8, but got O
		//IL_0d80: Expected O, but got I4
		//IL_0d86: Expected I8, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		string s = text;
		object obj = long.Parse(text);
		text = short.Parse(s, (NumberStyles)((obj is NumberStyles) ? obj : null)) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		object obj2 = int.Parse(text);
		bool num = (byte)((uint*)((obj2 is uint) ? obj2 : null))->ToString() != 0;
		object obj3 = ((byte*)170)->GetTypeCode();
		object obj4 = ((obj3 is byte) ? obj3 : null);
		object obj5 = obj5;
		object obj6 = ((byte*)obj4)->Equals(obj5);
		byte b = (byte)(int)((obj6 is byte) ? obj6 : null);
		object obj7 = ((byte*)b)->GetHashCode();
		_003F val = checked(0 - ((obj7 is bool) ? obj7 : null));
		bool flag = (byte)(int)val != 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		if (num / val == 0)
		{
			try
			{
				Class4 obj8 = ((nint)(IntPtr)(void*)unchecked((nint)null)) as Class4;
				Class4 @class = @class;
				@class = obj8;
			}
			finally
			{
				short num3 = num2;
				num4 = num4;
				ushort num5 = num4;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
				b2 = (sbyte)((ushort*)num5)->ToString(text3, null);
				uint num6;
				checked
				{
					num6 = unchecked((uint)b2) + unchecked((uint)b2);
					formatProvider = formatProvider;
				}
				object obj9 = ((byte*)(byte)((sbyte*)num6)->ToString(formatProvider))->Equals(177);
				num2 = (short)(int)checked(num3 + ((obj9 is short) ? obj9 : null));
				num2 = -4256;
				goto IL_020a;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		Struct3 @struct;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
			while (true)
			{
				sbyte num7 = b2;
				text = text;
				BindingFlags bindingFlags_ = (BindingFlags)((sbyte*)num7)->ToString(text4, byte.TryParse(text, out *(byte*)null) as IFormatProvider);
				PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Settings.Default;
				array = array;
				Type[] type_ = array;
				parameterModifier_ = null;
				if ((((byte)Class0.smethod_5(bindingFlags_, propertyInfo_, null, type_, parameterModifier_) != 0) ? 1u : 0u) / 1u != 0)
				{
					num8 = (int)checked(756591156u + (805494496u - unchecked((uint)num8)));
					num8 = -318908483;
					continue;
				}
				break;
			}
		}
		catch
		{
			if (!flag)
			{
				num8 = num8;
				_ = uint.Parse(text) is byte;
			}
			else
			{
				numberStyles = default(NumberStyles);
				numberStyles = default(NumberStyles);
				NumberStyles style = numberStyles;
				object obj10 = ((sbyte*)checked(unchecked((uint)b2) + unchecked((uint)b2)))->GetTypeCode();
				object obj11 = ((obj10 is ulong) ? obj10 : null);
				formatProvider = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
				num9 = (uint)((ulong*)obj11)->ToString("YCCS2UEoLXg2E/A6o0R83qd1sHtAjN+a9ePfSyZF98KaWIw=", formatProvider2);
				ref _003F reference = ref *(_003F*)714585077;
				uint num10 = num9;
				object obj12 = ((ushort*)28680)->Equals(16668);
				object obj13 = System.Runtime.CompilerServices.Unsafe.As<_003F, uint>(ref reference).CompareTo((uint)(int)checked(num10 - (unchecked(((obj12 is uint) ? obj12 : null) / num9) - 2000370875)));
				_003F val2 = checked(((obj13 is sbyte) ? obj13 : null) + 98);
				sbyte num11 = b2;
				string s2 = text;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
				text = text5;
				object obj14 = long.Parse(s2, (NumberStyles)/*isinst with value type is only supported in some contexts*/);
				b2 = (sbyte)checked(val2 * (num11 - ((obj14 is sbyte) ? obj14 : null)));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b3);
				object obj15 = long.Parse("9YuXS6QgTUTtfi/Cm7ss+jB1x3ftqGsk3n5/2pTewwQ3LHY=", style, ((ulong*)(ulong)((sbyte*)b3)->ToString(text, formatProvider))->CompareTo(null) as IFormatProvider);
				object obj16 = ((obj15 is Struct3) ? obj15 : null);
				@struct = default(Struct3);
				@struct = (Struct3)obj16;
			}
		}
		goto IL_020a;
		IL_020a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num12);
		do
		{
			_ = ((byte*)b)->GetHashCode() is char;
			object obj18 = ((uint*)num9)->GetTypeCode();
			@struct = (Struct3)((obj18 is Struct3) ? obj18 : null);
		}
		while ((byte)((long*)num12)->ToString(formatProvider) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ushort result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		nint num19;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		try
		{
			while (((ulong*)(ulong)Settings.Default)->GetTypeCode() is bool)
			{
				while (((sbyte*)(-3))->GetHashCode() is bool)
				{
					Class2 class2 = null;
					class2 = null;
					class2 = class2;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = uint.Parse(text, numberStyles, null) is ulong;
				}
				while (checked((flag ? 1u : 0u) + 1u) != 0);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num16);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string format);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num17);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char c2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s6);
				while (true)
				{
					Struct4 obj19 = (Struct4)Settings.Default;
					object obj20 = (flag ? ((bool*)1) : ((bool*)null))->GetTypeCode();
					object obj21 = ((obj20 is int) ? obj20 : null);
					bool num13 = flag;
					NumberStyles style2 = numberStyles;
					object obj22 = ((ushort*)32426)->GetHashCode();
					sbyte num14 = (sbyte)((bool*)checked((num13 ? 1u : 0u) - (sbyte.TryParse("fv7slL/7TKn/6ot3qUVsHJJTi4W4itSFdEQHE23aGnbuWus=", style2, null, out *unchecked((sbyte*)((obj22 is ref sbyte) ? obj22 : null))) ? 1u : 0u)))->ToString();
					string s4 = text;
					object obj23 = short.TryParse((string)(object)Settings.Default, out *(short*)null);
					object obj24 = ((obj23 is int) ? obj23 : null);
					num8 = num8;
					text = char.IsSurrogatePair(s4, checked(obj24 - num15)) as string;
					text = text6;
					object obj25 = ushort.TryParse(s5, out result);
					object obj26 = ((obj25 is BindingFlags) ? obj25 : null);
					_ = uint.Parse(text, numberStyles) is int;
					num8 = 693264549;
					object obj27 = ((IntPtr*)(IntPtr)((int*)num16)->ToString())->GetHashCode();
					object obj28 = ((obj27 is ulong) ? obj27 : null);
					ulong value = (ulong)Class0.smethod_3(null, resolveEventArgs_);
					MethodBase[] methodBase_ = ((ulong*)obj28)->CompareTo(value) as MethodBase[];
					object obj29 = "8dCa2FQK/EELgHowzfu+GSQ6WB4FkKJKkIi7HqrGKF6V7Ro=".CompareTo((object?)null);
					Type[] type_2 = ((bool*)((obj29 is bool) ? obj29 : null))->Equals(obj5) as Type[];
					text = text;
					object arg = obj5;
					obj5 = Settings.Default;
					object obj30 = (uint.Parse("NelLhxcUqTerCRwpLceJ8nqBwNJpeeewAQrMjMfo/OArZIdToTOmrNki97ol3qwhqNii6THN7mc7Cw==", (NumberStyles)string.Format(format, arg, arg2, obj5)) as string).IndexOf(((sbyte*)(-47))->ToString((string)(object)Settings.Default, char.ToLowerInvariant((char)(ushort.Parse("E/qTcjz/dhNp5Kp1ZK7yj/+E+UIoQj3W+3aHYrhiKUIqTytoIHrFNbXYgLqIDBJ8OSzSKHp12ClGmQ==") as string).GetEnumerator()) as IFormatProvider), -785571517);
					object obj31 = ((obj30 is uint) ? obj30 : null);
					array2 = array2;
					_ = (void*)Class5.smethod_0(text);
					void* ptr = (void*)((uint*)1041468735)->ToString();
					ptr = ptr;
					object obj32 = (nint)(IntPtr)ptr;
					object obj33 = ((obj32 is int) ? obj32 : null);
					num8 = 693264549;
					char num18 = (char)Class0.smethod_0((BindingFlags)obj26, methodBase_, type_2, Class5.smethod_1((uint)(int)obj31, array3, (int)obj33, (int)checked(693264549u + unchecked((uint)num17))) as ParameterModifier[]);
					object obj34 = char.IsUpper((char)(int)/*isinst with value type is only supported in some contexts*/);
					MethodBase[] methodBase_2;
					Type[] type_3;
					checked
					{
						_ = num18 - unchecked(((obj34 is char) ? obj34 : null) / c);
						methodBase_2 = array4;
						type_3 = array;
						num19 = default(IntPtr);
					}
					c = (char)checked(unchecked((char)Class0.smethod_0(default(BindingFlags), methodBase_2, type_3, (ParameterModifier[])(object)((IntPtr*)checked(unchecked((nuint)num19) + unchecked((nuint)num19)))->ToPointer())) + c);
					c = '굥';
					ref _003F reference2 = ref *(_003F*)(ushort)c2;
					object obj35 = char.IsControl('굥');
					text = System.Runtime.CompilerServices.Unsafe.As<_003F, char>(ref reference2).Equals((char)checked(4 + ((obj35 is char) ? obj35 : null))) as string;
					text = "E8p+xovIWGJEsd8toYH2vrnssg4oLvXJ5vKTOtleEQPEs6KAljvn4RRpyYNw8Tv1ERtDPyl4i00kcA==";
					object obj36 = ((uint*)1751665438)->GetTypeCode();
					object obj37 = text7.IndexOf("5HiI/CR6qIwFX7DTkQzBL6OaWKQIHMTTmcRt+Tqvc9LLPvXX0PNNkNpZ4F/DpfxPCEe910/tljRnvA==", 693264549, (StringComparison)((obj36 is StringComparison) ? obj36 : null));
					object obj38 = ((obj37 is ulong) ? obj37 : null);
					object obj39 = long.Parse("ZZZYgKEJQajNmsmBd+DeiRQDXZDptSEr6UbEFINYWWx9c8it6hGNqb2tC5ZwHuqrwO6Eo1L7qFmQSA==");
					object obj40 = checked(obj38 * ((obj39 is ulong) ? obj39 : null));
					bindingFlags = default(BindingFlags);
					array4 = null;
					object obj41 = ((sbyte*)num14)->Equals(short.TryParse(s6, out *(short*)/*isinst with value type is only supported in some contexts*/) as object);
					_ = (Struct4)((int*)checked(obj21 + unchecked((uint)(int)((IntPtr*)(((obj41 is IntPtr) ? obj41 : null) / num19))->ToString("cUh3QbWlI0BhpmwEqIGvwtPeRqBrc8ZXpZV2KQxJe8FssjhYI+pfLXXHpHQtVUKwI22QqG+leNPOkw==") / 193458739u)))->ToString("K9RXBktUhXqk2F1U4st+Itv/zpny2N/ggxndXPjeqJ4PHGYFxFNUZl2nz1pVY1KUiQJlCoIkZ9QKXg==");
					Struct4 struct2 = default(Struct4);
					struct2 = obj19;
				}
			}
		}
		long num20 = num12;
		num19 = default(IntPtr);
		ref _003F reference3 = ref *(_003F*)num20;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_4);
		object obj44 = (nint)((IntPtr)(nint)checked(unchecked((nuint)num19) + unchecked((nuint)(nint)(IntPtr)Class0.smethod_5(bindingFlags, char.IsNumber((string)(object)Settings.Default, 2090099277) as PropertyInfo[], (Type)(object)Class0.smethod_5((BindingFlags)/*isinst with value type is only supported in some contexts*/, propertyInfo_2, type_4, array, parameterModifier_), (Type[])(object)((ulong*)/*isinst with value type is only supported in some contexts*/)->ToString(text), parameterModifier_))) - 67606632);
		_ = (Class4)(object)System.Runtime.CompilerServices.Unsafe.As<_003F, long>(ref reference3).ToString(((ulong*)((obj44 is ulong) ? obj44 : null))->Equals(null) as string);
		IntPtr intPtr = (IntPtr)((ushort*)3714)->ToString(formatProvider);
		object obj45 = ((long*)num12)->GetHashCode();
		object obj46 = ((obj45 is NumberStyles) ? obj45 : null);
		formatProvider = null;
		ref _003F reference4 = ref *(_003F*)intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		object obj47 = short.Parse("+Nc4QDUY7VqJXAuHb/moVExYqahcoc8JmI/tWCPW0pHsNVhCUEjiSGQhJgPNfcqS9sXDjic7fSCHSw==", (NumberStyles)obj46, provider);
		object obj48 = System.Runtime.CompilerServices.Unsafe.As<_003F, IntPtr>(ref reference4).Equals(((ulong*)(ulong)((uint*)((obj47 is uint) ? obj47 : null))->ToString((IFormatProvider?)null))->ToString(text));
		object obj49 = ((obj48 is int) ? obj48 : null);
		obj5 = obj5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj50);
		_ = ((int*)obj49)->Equals(obj50) is Class3;
		if (flag)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class3);
		try
		{
			string s7 = ((sbyte*)b2)->ToString();
			formatProvider = formatProvider;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
			if (!(int.Parse(s7, provider2) is bool))
			{
				long num21 = num12;
				object obj51 = ((uint*)num9)->GetTypeCode();
				_003F val3;
				string text8;
				char[] separator;
				checked
				{
					val3 = 1 + (((obj51 is bool) ? obj51 : null) + (unchecked((byte)((sbyte*)checked(unchecked((uint)b2) * 106u))->ToString()) != 0));
					text8 = text;
					separator = int.Parse("QMO/5kUHTaqnMr43yPIPH3RDyqzvtkGpgnd9tz54KVz/oyvkLJBJDBISttsA8otS8cDobxWP+eWFWA==") as char[];
					num19 = num19;
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr2);
				_ = (string)(object)((IntPtr*)intPtr2)->ToPointer();
				string text9 = text;
				int count = (int)Settings.Default;
				StringSplitOptions stringSplitOptions = stringSplitOptions;
				text = (string)(object)text9.Split((string[]?)null, count, default(StringSplitOptions));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
				text = text10;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
				_ = (StringSplitOptions)Class5.smethod_0(string_);
				stringSplitOptions = stringSplitOptions;
				object obj52 = ((bool*)val3)->CompareTo((byte)((((byte)text8.Split(separator, default(StringSplitOptions)) != 0) ? 1u : 0u) / (flag ? 1u : 0u)) != 0);
				_003F val4 = checked(num21 - ((obj52 is long) ? obj52 : null));
				obj5 = obj5;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj53);
				object obj54 = ((long*)val4)->Equals(obj53);
				object obj55 = ((obj54 is char) ? obj54 : null);
				string s8 = (string)(object)Class0.smethod_1(array2, (byte[])(object)Settings.Default);
				num8 = -1415415954;
				obj5 = obj5;
				obj5 = obj5;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj56);
				obj5 = obj56;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj57);
				object obj58 = ((ulong*)1464179989L)->Equals(obj57);
				object obj59 = ((obj58 is uint) ? obj58 : null);
				byte[] array5 = array2;
				object obj60 = ((char*)61742)->GetHashCode();
				object obj61 = ((obj60 is IntPtr) ? obj60 : null);
				Class0 class4 = class3;
				BindingFlags bindingFlags_3 = bindingFlags;
				string text11 = text;
				text = char.IsWhiteSpace("JhE37PTtlIoJtdV1hEwtvbgX4cfOG14jlOf3HV9VlMwA+UMP2s6Y4eUJjK6jqPJ3pHwiuZnfeJadWQ==", -2100400351) as string;
				object obj62 = char.IsSurrogatePair(text, -1185248579);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string value2);
				object obj63 = ulong.Parse(text11.IndexOf(value2, (StringComparison)((obj62 is StringComparison) ? obj62 : null)) as string, null);
				object obj64 = ((bool*)((obj63 is bool) ? obj63 : null))->GetTypeCode();
				num9 = (uint)(int)((obj64 is uint) ? obj64 : null);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num22);
				Type type_5 = (Type)(object)((uint*)num22)->ToString();
				Type[] type_6 = array;
				nint num23 = num19;
				num19 = default(IntPtr);
				num19 = num19;
				nuint num25;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num24);
					num25 = unchecked((nuint)num23) * unchecked((nuint)num24);
				}
				object obj65 = ((ulong*)1013161105L)->GetTypeCode();
				num19 = (nint)((obj65 is IntPtr) ? obj65 : null);
				uint num26;
				Class0 class5;
				object obj66;
				checked
				{
					num26 = unchecked((uint)Class0.smethod_5(bindingFlags_3, null, type_5, type_6, ((nint)num25 != default(IntPtr)) as ParameterModifier[])) * 2143691951u;
					class5 = class3;
					obj66 = obj5;
				}
				string s9 = ((bool*)null)->Equals((byte)checked(1u - (flag ? 1u : 0u)) != 0) as string;
				numberStyles = numberStyles;
				ref _003F reference5 = ref *(_003F*)num26;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
				object obj67 = sbyte.Parse((string)class5.method_0(obj66, type_4, short.Parse(s9, style3) as CultureInfo), (NumberStyles)/*isinst with value type is only supported in some contexts*/);
				int int_ = (int)(((IntPtr*)checked(obj61 - unchecked((nuint)(nint)(IntPtr)class4.method_0(null, System.Runtime.CompilerServices.Unsafe.As<_003F, uint>(ref reference5).CompareTo((uint)(int)((obj67 is uint) ? obj67 : null)) as Type, null))))->GetHashCode() as string).ToUpperInvariant();
				num8 = 978769544;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int num27);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int int_2);
					_ = 4294939980u - unchecked((uint)(short)((char*)obj55)->ToString(int.Parse(s8, (IFormatProvider)(object)((int*)num27)->ToString(Class5.smethod_1((uint)(int)obj59, array5, int_, int_2) as string)) as IFormatProvider)) * unchecked((uint)(short)Settings.Default);
					num2 = num2;
				}
			}
			else
			{
				_ = ((sbyte*)68)->Equals(null) is int;
			}
		}
		catch
		{
			try
			{
				object obj68 = char.ToUpperInvariant('덾');
				if (!((int*)((obj68 is int) ? obj68 : null))->Equals(obj5))
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out void* ptr);
					text = ((nint)(IntPtr)ptr) as string;
				}
			}
			catch
			{
				ushort num28 = num4;
				object obj69 = sbyte.TryParse(short.Parse("Q+DIgxYrBt1gEBgJksSaJLu+0d1R5mm/ypsdEuO99Kg/oZXtEqXmWoPVAzsD2p/pze0z9S3pTZzpFg==", formatProvider) as string, out *(sbyte*)Settings.Default);
				text = ((ushort*)58401)->Equals((ushort)((uint)checked(num28 + unchecked((ushort)((ulong*)((obj69 is ulong) ? obj69 : null))->ToString(text))) / (uint)num4)) as string;
				object obj70 = ((sbyte*)/*isinst with value type is only supported in some contexts*/)->Equals(b2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s10);
				_ = char.GetUnicodeCategory(s10, (int)((obj70 is int) ? obj70 : null)) is Struct4;
				Struct4 struct2 = struct2;
				string s11 = text;
				object obj71 = bool.Parse("n23FXPNzCcxOyjCEj9yOQDQaPXXK6ZaK26f4C8MhHttAF2iG68w9UKLmo5mKdK5pv8RFHUJ9QEdZ6Q==");
				_ = char.GetUnicodeCategory(s11, (int)((obj71 is int) ? obj71 : null)) is _003CPrivateImplementationDetails_003E;
			}
		}
		do
		{
			if (checked((flag ? 1u : 0u) - (unchecked((uint*)checked(unchecked((uint)((short*)checked(unchecked((uint)num2) - unchecked((uint)num2)))->ToString()) + 819829720u))->Equals(2008461245u) ? 1u : 0u)) == 0)
			{
				_ = ((bool*)1)->GetTypeCode() is Struct4;
			}
		}
		while ((byte)Settings.Default != 0);
		bool num29 = (byte)Class0.smethod_3(null, null) != 0;
		string s12 = text;
		string s13 = ushort.TryParse("vCYksNvwkd5GyRFrqvzoCN8XM93+Lc8yEQ57bk89T6md6Ffj66xY6iK2N7fUfFEgjvZrXbPmeqb5GQ==", numberStyles, formatProvider, out result) as string;
		nint num30 = num19;
		object obj74 = ((uint*)879734803)->GetHashCode();
		num19 = num30 / ((obj74 is IntPtr) ? obj74 : null);
		object obj75 = ((IntPtr*)default(IntPtr))->ToInt64();
		object obj76 = long.Parse("OKt7k7nX1h++eY97VhuvUg76gUs3Xfz/KvP0hIdIiMhhF4DhhpiGbltIt3f5LUCeJJjMyBpNgtPEAw==", char.GetUnicodeCategory((char)(int)((obj75 is char) ? obj75 : null)) as IFormatProvider);
		NumberStyles style4 = (NumberStyles)((int*)(((obj76 is int) ? obj76 : null) / checked(2916212211u * 2735768400u - 3778821041u)))->ToString((IFormatProvider?)null);
		string s14 = text;
		MethodBase[] methodBase_4 = array4;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text12);
		object obj77 = ((ushort*)(ushort)Class0.smethod_0(default(BindingFlags), methodBase_4, (Type[])(object)((ulong*)(ulong)((ulong*)1620869676L)->ToString(text12, formatProvider))->ToString(text), parameterModifier_))->GetTypeCode();
		IFormatProvider provider3 = ulong.Parse(s14, (NumberStyles)((int*)((obj77 is int) ? obj77 : null))->ToString(text)) as IFormatProvider;
		int num31;
		uint num32;
		_003F val5;
		_003F val6;
		checked
		{
			num31 = unchecked((ushort)Class5.smethod_0("tpdGWhkgaDfMZBJgSoKjUOBJ/tcGgS9x1Bcn9+whzBMEZ/RFNLEvzLOyz0QioesWux9txIPPAGmDCw==")) * num4;
			num32 = num9;
			uint num33 = num9;
			object obj78 = char.IsLetter(unchecked((char)(int)/*isinst with value type is only supported in some contexts*/));
			val5 = 1074550309 - unchecked(num33 / ((obj78 is uint) ? obj78 : null));
			numberStyles = numberStyles;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style5);
			object obj79 = short.Parse("zhkcUi1GT8DdDtr7bYlYtdi5SqZWZJfHx9b7T1VlL0fTWeUidyhQL8bQi4mTBnhndLur6zwY/21e7w==", style5, null);
			val6 = ((obj79 is int) ? obj79 : null) * -1159846316;
		}
		object obj80 = Class5.smethod_1(num9, ((short*)(-4314))->CompareTo(null) as byte[], num8, num8);
		object obj81 = ((obj80 is int) ? obj80 : null);
		num8 = (int)Class5.smethod_0(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num34);
		num9 = Class5.smethod_1(Class5.smethod_1((uint)(int)val5, null, 1940323955, checked(val6 + obj81 * num34)), array2, (int)checked(unchecked((uint)num8) + 3594808488u), num8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint obj82);
		object obj83 = ((uint*)num32)->Equals(obj82);
		b2 = (sbyte)checked(((obj83 is sbyte) ? obj83 : null) * b2);
		object obj84;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b4);
			uint uint_ = 994513498u + (unchecked((uint)((sbyte*)checked(unchecked((uint)b4) * 123u))->ToString()) + num9);
			obj84 = char.IsPunctuation('⑊');
		}
		array2 = ((ushort*)(((obj84 is ushort) ? obj84 : null) / (ushort)((ulong*)95669587L)->ToString("zuP7jufn8qQDSv8z6pMrYbtDtcqE54HLptfHFeRpaLwl7C85Yg5Mjiw0J/SIbbYlXyMuHoNrYtCYyQ==", ((short*)(-22399))->Equals(num2) as IFormatProvider)))->CompareTo(num4) as byte[];
		object obj85 = ((ushort*)(checked(num31 + /*isinst with value type is only supported in some contexts*/) / 57156))->CompareTo((ushort)(int)/*isinst with value type is only supported in some contexts*/);
		string s15 = sbyte.Parse(s12, sbyte.TryParse(s13, style4, provider3, out *(sbyte*)((obj85 is ref sbyte) ? obj85 : null)) as IFormatProvider) as string;
		numberStyles = default(NumberStyles);
		string obj86 = int.Parse(s15, numberStyles, null) as string;
		obj5 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj87);
		obj5 = obj87;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value3);
		object obj88 = obj86.CompareTo(value3);
		object obj89 = ((obj88 is IntPtr) ? obj88 : null);
		num4 = 45595;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num35);
		ref _003F reference6 = ref *(_003F*)(num35 / (ushort)((uint*)num9)->ToString());
		object obj90 = ((short*)(-9228))->Equals(obj5);
		object obj91 = System.Runtime.CompilerServices.Unsafe.As<_003F, ushort>(ref reference6).Equals(((byte*)49)->Equals(byte.Parse(((IntPtr*)((obj90 is IntPtr) ? obj90 : null))->ToString(text), numberStyles) as object) as object);
		object obj92 = ((obj91 is int) ? obj91 : null);
		int num36 = num8;
		int num37 = num8;
		object obj93 = char.IsDigit('❲');
		checked
		{
			num8 = obj92 * (num36 - unchecked(num37 / checked(((obj93 is int) ? obj93 : null) + num8)));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int offset);
			object obj94 = unchecked((nint)IntPtr.Add((IntPtr)obj89, offset));
			_ = ((obj94 is bool) ? obj94 : null) * flag;
			flag = true;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		((bool*)((num29 ? 1u : 0u) / (flag2 ? 1u : 0u)))->GetHashCode();
		int num38 = num8;
		num8 = (int)((uint)num8 / (uint)num8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num39);
		num8 = (int)checked(unchecked((uint)num38) - (586712925u + (unchecked((uint)num39) - 1616014948u)));
		@struct = default(Struct3);
		class3 = null;
		string s16 = text;
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider4);
		object obj95 = ushort.Parse(s16, provider4);
		num12 = (long)((obj95 is long) ? obj95 : null);
		object obj96 = ((ushort*)45595)->CompareTo(45595);
		num12 = (long)((obj96 is long) ? obj96 : null);
	}
}
