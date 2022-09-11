using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;
using ns2;

namespace ns0;

internal sealed class Class1
{
	public static void smethod_0()
	{
		Class0.smethod_2();
	}

	internal static byte[] smethod_1(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	public static PropertyInfo smethod_2(BindingFlags bindingFlags_0, PropertyInfo[] propertyInfo_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
	{
		int i = 0;
		int num = 0;
		int num2 = ((type_1 != null) ? type_1.Length : 0);
		for (int j = 0; j < propertyInfo_0.Length; j++)
		{
			if (type_1 != null)
			{
				ParameterInfo[] indexParameters = propertyInfo_0[j].GetIndexParameters();
				if (indexParameters.Length != num2)
				{
					continue;
				}
				for (i = 0; i < num2; i++)
				{
					Type parameterType = indexParameters[i].ParameterType;
					if (parameterType != type_1[i] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_1[i]))
					{
						break;
					}
				}
			}
			if (i == num2 && (!(type_0 != null) || propertyInfo_0[j].PropertyType.IsPrimitive || propertyInfo_0[j].PropertyType.IsAssignableFrom(type_0)))
			{
				propertyInfo_0[num++] = propertyInfo_0[j];
			}
		}
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return propertyInfo_0[0];
		default:
		{
			int num3 = 0;
			int[] array = new int[num2];
			for (int j = 0; j < num2; j++)
			{
				array[j] = j;
			}
			for (int j = 1; j < num; j++)
			{
			}
			return propertyInfo_0[num3];
		}
		}
	}

	public static bool smethod_3(ResolveEventArgs resolveEventArgs_0)
	{
		return GClass0.assembly_0.FullName != resolveEventArgs_0.Name;
	}

	public static byte[] smethod_4(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= byte_1[i % byte_1.Length];
		}
		return byte_0;
	}

	unsafe static void acoyeput2()
	{
		//IL_0065: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_0184: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected I4, but got Unknown
		//IL_01d4: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Ref, but got Unknown
		//IL_0222: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_029c: Expected O, but got I4
		//IL_02c2: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_02df: Expected I4, but got O
		//IL_02fa: Expected O, but got I4
		//IL_030c: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_0374: Expected I4, but got O
		//IL_0375: Expected O, but got I4
		//IL_037b: Expected I4, but got O
		//IL_0392: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got I4
		//IL_044a: Expected I4, but got O
		//IL_046e: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04b6: Expected O, but got I4
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Ref, but got Unknown
		//IL_04e2: Expected O, but got I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected I4, but got Unknown
		//IL_04fb: Expected O, but got I4
		//IL_0530: Expected O, but got I4
		//IL_055b: Expected O, but got I4
		//IL_0567: Expected O, but got I4
		//IL_057e: Expected O, but got I4
		//IL_058d: Expected O, but got I4
		//IL_05a6: Expected O, but got I4
		//IL_05b1: Expected O, but got I4
		//IL_062a: Expected O, but got I4
		//IL_064e: Expected O, but got I4
		//IL_06b7: Expected O, but got I4
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected I4, but got Unknown
		//IL_06c3: Expected O, but got I4
		//IL_06d9: Expected O, but got I4
		//IL_0707: Expected Ref, but got Unknown
		//IL_0708: Expected O, but got I4
		//IL_0721: Expected O, but got I4
		//IL_0731: Expected O, but got I4
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected I4, but got Unknown
		//IL_074c: Expected I4, but got O
		//IL_074d: Expected O, but got I4
		//IL_0757: Expected O, but got I4
		//IL_0799: Expected O, but got I4
		//IL_07a4: Expected O, but got I4
		//IL_07aa: Expected I4, but got O
		//IL_07df: Expected O, but got I4
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got I4
		//IL_084c: Expected O, but got I4
		//IL_0875: Expected O, but got I4
		//IL_08b3: Expected O, but got I4
		//IL_08cd: Expected I4, but got Unknown
		//IL_08ce: Expected O, but got I4
		//IL_08fc: Expected O, but got I4
		//IL_0954: Expected O, but got I4
		//IL_095e: Expected O, but got I4
		//IL_09be: Expected O, but got I4
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected Ref, but got Unknown
		//IL_09da: Expected O, but got I4
		//IL_09e0: Expected I4, but got O
		//IL_09f1: Expected O, but got I4
		//IL_0a06: Expected O, but got I4
		//IL_0a14: Expected O, but got I4
		//IL_0a2b: Expected O, but got I4
		//IL_0a5e: Expected O, but got I4
		//IL_0aca: Expected O, but got I4
		//IL_0ae0: Expected O, but got I4
		//IL_0b02: Expected O, but got I4
		//IL_0b13: Expected O, but got I4
		//IL_0b26: Expected I4, but got O
		//IL_0b27: Expected O, but got I4
		//IL_0b46: Expected O, but got I4
		//IL_0b73: Expected O, but got I4
		//IL_0b99: Expected O, but got I4
		//IL_0ba2: Expected I4, but got O
		//IL_0ba3: Expected O, but got I4
		//IL_0bc9: Expected O, but got I4
		//IL_0bcf: Expected I4, but got O
		//IL_0bd7: Expected O, but got I4
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected Ref, but got Unknown
		//IL_0bfe: Expected O, but got I4
		//IL_0c20: Expected O, but got I4
		//IL_0c32: Expected I4, but got O
		//IL_0c45: Expected O, but got I4
		//IL_0c68: Expected O, but got I4
		//IL_0c7b: Expected O, but got I4
		//IL_0c86: Expected O, but got I4
		//IL_0c92: Expected O, but got I4
		//IL_0c9b: Expected I4, but got O
		//IL_0c9c: Expected O, but got I4
		//IL_0cb5: Expected O, but got I4
		//IL_0cbf: Expected O, but got I4
		//IL_0cff: Expected O, but got I4
		//IL_0d4e: Expected O, but got I4
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got I4
		//IL_0d82: Expected I4, but got O
		//IL_0d9c: Expected O, but got I4
		//IL_0db4: Expected O, but got I4
		//IL_0dc0: Expected O, but got I4
		//IL_0e66: Expected O, but got I4
		//IL_0ea8: Expected O, but got I4
		//IL_0eb1: Expected I4, but got O
		//IL_0ebc: Expected O, but got I4
		//IL_0ee2: Expected O, but got I4
		//IL_0f00: Expected O, but got I4
		//IL_0f3c: Expected O, but got I4
		//IL_0f5c: Expected O, but got I4
		//IL_0f6a: Expected O, but got I4
		//IL_0f76: Expected I4, but got O
		//IL_0f8b: Expected O, but got I4
		//IL_0fe5: Expected O, but got I4
		//IL_0feb: Expected I4, but got O
		//IL_0ff3: Expected O, but got I4
		//IL_0ff9: Expected I4, but got O
		//IL_1017: Expected O, but got I4
		//IL_1029: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CompareOptions compareOptions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		try
		{
			try
			{
				text = "IYRCQVBO";
				@class = (Class2)(object)text.GetEnumerator();
				Class2 class2 = @class;
				type = type;
				Type type_ = type;
				cultureInfo = null;
				class2.method_0(null, type_, cultureInfo);
			}
			catch
			{
				string text2 = text.ToUpper(null);
				string value = text;
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_ = bindingFlags;
				text = "X".Trim();
				string text3 = text;
				string strB = ((byte*)1)->GetTypeCode() as string;
				CultureInfo culture = cultureInfo;
				compareOptions = compareOptions;
				resolveEventArgs = string.Compare("MY", strB, culture, default(CompareOptions)) as ResolveEventArgs;
				string obj = "QD".CompareTo((string)(object)Class0.smethod_0(null, resolveEventArgs)) as string;
				char[] array = (char[])(object)(text + text + text + text);
				array = array;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array2);
				array = array2;
				char[] anyOf = array;
				byte num = (byte)((byte*)b)->ToString("PNTPOE", null);
				obj2 = obj2;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
				obj2 = obj3;
				uint num3;
				string strA2;
				string text4;
				char[] anyOf2;
				checked
				{
					num3 = unchecked(checked(unchecked((uint)(int)((byte*)num)->ToString(string.IsNullOrWhiteSpace(((byte*)50)->CompareTo(obj2) as string) as string, (IFormatProvider)(object)text.ToUpper())) - 2414489511u) / checked(unchecked((uint)"NIAKT".LastIndexOfAny(array, num2)) - unchecked((uint)num2))) * 2108818578u;
					string strA = text;
					string strB2 = text;
					stringComparison = stringComparison;
					strA2 = string.Compare(strA, strB2, default(StringComparison)) as string;
					text4 = text;
					anyOf2 = array;
				}
				int num4 = (int)Class0.smethod_0(obj2, null);
				num2 = 49057681;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
				stringComparison = (StringComparison)text4.ToCharArray("JNCHPWR".LastIndexOfAny(anyOf2, (int)checked(unchecked((uint)num4) + unchecked((uint)num5) + 2657661270u)), -192880081);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
				object obj4 = obj.LastIndexOfAny(anyOf, (int)(num3 / (uint)string.Compare(strA2, "VMEHVFL", comparisonType)));
				_003F val = checked(56 - ((obj4 is byte) ? obj4 : null));
				string text5 = text;
				num2 = 49057681;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int totalWidth);
				b = (byte)checked(val * unchecked((byte)text5.PadRight(totalWidth)));
				string text6 = ((byte*)b)->ToString((IFormatProvider)((Class2)null).method_0(obj2, type, cultureInfo));
				text = text;
				string strB3 = byte.TryParse("AA", out *(byte*)Settings.Default) as string;
				@class = @class;
				BindingFlags bindingFlags_2 = bindingFlags;
				BindingFlags bindingFlags_3 = bindingFlags;
				array3 = array3;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array4);
				array3 = array4;
				MethodBase[] methodBase_ = array3;
				array5 = null;
				MethodBase[] methodBase_2 = (MethodBase[])(object)Class0.smethod_1(bindingFlags_3, methodBase_, null, array5);
				Type[] type_2 = null;
				object obj5 = ((Settings)(object)Class2.smethod_3(bindingFlags_2, methodBase_2, type_2, array5)).Value;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class3);
				string obj6 = string.Compare(strA3, strB3, (CultureInfo)class3.method_0((((byte*)checked(186 - ((obj5 is byte) ? obj5 : null)))->Equals(null) as string).ToCharArray(), null, cultureInfo), default(CompareOptions)) as string;
				BindingFlags bindingFlags_4 = bindingFlags;
				MethodBase[] methodBase_3 = array3;
				@class = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class4);
				_ = (byte)class4.method_0(obj2, type, text.GetTypeCode() as CultureInfo);
				b = 184;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
				object obj7 = ((byte*)checked(unchecked((uint)b2) + 184u))->CompareTo(obj2);
				Class2 obj8 = (Class2)(object)Class2.smethod_3(bindingFlags_4, methodBase_3, ((byte*)((obj7 is byte) ? obj7 : null))->Equals(184) as Type[], array5);
				type = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_3);
				object obj9 = ((byte*)(byte)obj8.method_0(null, type_3, null))->GetHashCode();
				object obj10 = ((obj9 is BindingFlags) ? obj9 : null);
				PropertyInfo[] propertyInfo_ = array6;
				Settings settings = null;
				byte num6 = (byte)smethod_2((BindingFlags)obj10, propertyInfo_, null, settings.Times as Type[], array5);
				b = 124;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
				b = b3;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
				object obj11 = ((byte*)checked(72u + unchecked((uint)checked(num6 - b4))))->CompareTo(null);
				char value2 = (char)checked(29114u + unchecked((uint)(char)obj6.Split(((byte*)((obj11 is byte) ? obj11 : null))->Equals((byte)checked(100u - unchecked((uint)b))) as char[], 49057681) / 4952u));
				string text7 = text;
				int num7;
				checked
				{
					num7 = unchecked((byte)Settings.Default) * b;
					_ = unchecked((uint)(byte)Settings.Default) - 173u - 6u;
				}
				b = (byte)Class0.smethod_0(obj2, resolveEventArgs);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				object obj12 = ((byte*)checked(unchecked((uint)num7) * unchecked((uint)checked(b5 - b))))->GetTypeCode();
				object obj13 = text7.IndexOf((char)(int)((obj12 is char) ? obj12 : null));
				b = (byte)(int)((obj13 is byte) ? obj13 : null);
				object obj14 = string.Equals(((byte*)checked(unchecked((uint)b) * 220u))->CompareTo(obj2) as string, text);
				object object_ = byte.TryParse("DBFWCW", out *(byte*)((obj14 is ref byte) ? obj14 : null)) as object;
				resolveEventArgs = resolveEventArgs;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
				string format = (string)(object)Class0.smethod_0(object_, resolveEventArgs_);
				object obj15 = settings.Value;
				byte num8 = (byte)((byte*)((obj15 is byte) ? obj15 : null))->ToString();
				object obj16 = smethod_3(resolveEventArgs);
				_003F val2 = checked(num8 - ((obj16 is byte) ? obj16 : null));
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_5 = bindingFlags;
				string text8 = text;
				num2 = 49057681;
				string text9 = text;
				string text10 = ((byte*)checked(b + unchecked((byte)string.Format(text, obj2))))->ToString(text);
				text = "YEL";
				string strA4 = text;
				text = text;
				char[] separator = array;
				object obj17 = byte.Parse("OO");
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string format2);
				int indexB = (int)string.Format(format2, "W".Split(separator, (int)((obj17 is int) ? obj17 : null)));
				flag = false;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
				uint num9 = checked((flag2 ? 1u : 0u) - 0u);
				flag = (byte)num9 != 0;
				char[] anyOf3 = string.Compare(strA4, 49057681, "OIY", indexB, 49057681, (byte)num9 != 0) as char[];
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_6 = bindingFlags;
				bindingFlags = bindingFlags;
				string text11 = text;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string value3);
				string obj18 = (string)(object)Class2.smethod_3(bindingFlags_7, text11.LastIndexOf(value3) as MethodBase[], null, array5);
				string s = text;
				object obj19 = text.IndexOfAny(null);
				_003F val3 = checked(((obj19 is byte) ? obj19 : null) - 195);
				formatProvider = formatProvider;
				object obj20 = byte.TryParse(s, (NumberStyles)((byte*)val3)->ToString(formatProvider), (IFormatProvider)(object)string.Intern(text), out *(byte*)null);
				_003F val4 = checked(49057681 - ((obj20 is int) ? obj20 : null));
				stringComparison = default(StringComparison);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType2);
				text = "OR".LastIndexOfAny(anyOf3, (int)Class0.smethod_1(bindingFlags_6, obj18.IndexOf("M", 1326572576, (int)val4, comparisonType2) as MethodBase[], null, null), (int)((uint)((byte*)(byte)((byte*)(byte)Settings.Default)->ToString())->GetHashCode() / 49057681u)) as string;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text12);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text13);
				int num10 = (int)(text9 + text10 + text12 + text13);
				BindingFlags bindingFlags_8 = bindingFlags;
				type_2 = null;
				type_2 = type_2;
				BindingFlags bindingFlags_9 = bindingFlags;
				MethodBase[] methodBase_4 = array3;
				string text14 = text;
				object obj21 = settings.Times;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_4);
				num2 = (int)((uint)(int)Class0.smethod_1(bindingFlags_8, null, type_4, (((byte*)(byte)Class0.smethod_1(bindingFlags_9, methodBase_4, null, text14.LastIndexOfAny((((byte*)((obj21 is byte) ? obj21 : null))->Equals(b) as string).LastIndexOf(text, 49057681, 577777615, stringComparison) as char[], 1573908393) as ParameterModifier[]))->Equals(236) as string).CompareTo(text) as ParameterModifier[]) / (uint)(int)((byte*)b)->ToString(text));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
				num2 = (int)checked(unchecked((uint)num10) * unchecked((uint)num11));
				BindingFlags bindingFlags_10 = bindingFlags;
				bindingFlags = default(BindingFlags);
				bindingFlags = bindingFlags;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
				bindingFlags = bindingFlags2;
				type_2 = type_2;
				string strA5 = text;
				num2 = (int)Class0.smethod_0(null, null);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
				string format3 = string.Compare(strA5, (int)checked(2627746153u * unchecked((uint)num12)), "Q", (int)checked(1821641852u * unchecked((uint)(int)string.Concat(obj2, obj2))), num2) as string;
				object[] array7 = array7;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_11);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_5);
				string format4 = ((Settings)(object)Class0.smethod_1(bindingFlags_11, null, type_5, (ParameterModifier[])(object)string.Format(null, format3, array7))).Value as string;
				array7 = (object[])(object)((byte*)b)->ToString(formatProvider);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] args);
				int num13 = (int)Class0.smethod_0(smethod_2(bindingFlags_10, (PropertyInfo[])(object)string.Format(format4, args), type, null, null), resolveEventArgs);
				text = text;
				uint num15;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string str);
					num15 = 3288040357u * (unchecked((uint)num14) - unchecked((uint)num13) * unchecked((uint)(int)string.Copy(str))) * unchecked((uint)num2);
				}
				int num16 = (int)text.TrimEnd(null);
				object obj22 = "HGJHPK".Equals("YGL");
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex);
				object obj23 = text8.LastIndexOf('竨', startIndex, (int)checked(num15 - unchecked(num16 / ((obj22 is int) ? obj22 : null))));
				MethodBase[] methodBase_5 = ((Settings)(object)((byte*)((obj23 is byte) ? obj23 : null))->ToString(formatProvider)).Times as MethodBase[];
				Type[] type_6 = type_2;
				array8 = array8;
				b = (byte)Class0.smethod_1(bindingFlags_5, methodBase_5, type_6, (ParameterModifier[])(object)string.Join("LCLGNGOU", array8));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte value4);
				object obj24 = ((byte*)b6)->Equals((byte)string.Format(format, ((byte*)val2)->CompareTo(value4) as object).Trim());
				object obj25 = ((obj24 is int) ? obj24 : null);
				text = text;
				int startIndex2 = (int)obj25;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
				object obj26 = byte.Parse(s2, formatProvider);
				object obj27 = (text6.LastIndexOf(value2, startIndex2, (int)checked(((obj26 is int) ? obj26 : null) - unchecked(checked(2827644194u + 3310320072u) / 313785092u))) as string).GetTypeCode();
				string value5 = ((byte*)((obj27 is byte) ? obj27 : null))->ToString();
				num2 = 1451357006;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num17);
				num2 = num17;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num18);
				num2 = (int)((uint)num18 / (uint)num2);
				num2 = num2;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num19);
				num2 = num19;
				bindingFlags = default(BindingFlags);
				object obj28 = byte.Parse(((byte*)(byte)((byte*)b)->ToString((IFormatProvider?)null))->CompareTo(obj2) as string, null);
				bindingFlags = (BindingFlags)((obj28 is BindingFlags) ? obj28 : null);
				uint indexA;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex3);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_12);
					indexA = 2448812142u * unchecked((uint)text3.IndexOf(value5, startIndex3, (int)Class2.smethod_3(bindingFlags_12, null, type_2, array5)));
					text = (string)(object)Class0.smethod_0(null, null);
					text = "X";
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s3);
				object obj29 = byte.TryParse(s3, out *(byte*)null);
				_003F val5 = ((obj29 is int) ? obj29 : null) / 1692390905;
				byte num20 = (byte)string.Format(text, null);
				b = 191;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
				int num21 = checked(num20 * b7);
				BindingFlags bindingFlags_13 = (BindingFlags)string.Format(formatProvider, "UHJV", array7);
				BindingFlags bindingFlags_14 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = array6;
				text = "KBCWXIWO";
				obj2 = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object value6);
				_ = (NumberStyles)Class2.smethod_3(bindingFlags_13, (MethodBase[])(object)smethod_2(bindingFlags_14, propertyInfo_2, null, text15.CompareTo(value6) as Type[], array5), null, ((byte*)87)->Equals(null) as ParameterModifier[]);
				numberStyles = numberStyles;
				numberStyles = default(NumberStyles);
				NumberStyles style = numberStyles;
				result = ref *(byte*)null;
				formatProvider = byte.TryParse("COA", style, null, out result) as IFormatProvider;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
				BindingFlags bindingFlags_15 = (BindingFlags)((byte*)num21)->ToString(formatProvider2);
				string text16 = text;
				NormalizationForm normalizationForm = normalizationForm;
				uint num22;
				byte[] byte_;
				checked
				{
					num22 = unchecked((uint)(int)smethod_2(bindingFlags_15, null, (Type)(object)text16.Normalize(normalizationForm), type_2, array5)) * unchecked((uint)num2);
					byte_ = text.CompareTo(obj2) as byte[];
					array9 = array9;
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB4);
				object obj30 = string.CompareOrdinal(strA6, (int)indexA, strB4, (int)val5, (int)checked(num22 * unchecked((uint)(int)smethod_4(byte_, array9))));
				array6 = (PropertyInfo[])(object)((byte*)((obj30 is byte) ? obj30 : null))->ToString("BPTJDEZ", formatProvider);
				PropertyInfo[] propertyInfo_3 = array6;
				text = "R";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text17);
				text = text17;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
				type = byte.Parse(s4, numberStyles, formatProvider) as Type;
				type_2 = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_8);
				num2 = (int)smethod_2(bindingFlags_, propertyInfo_3, type_7, type_8, array5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num23);
				num2 = num23;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num24);
				num2 = num24;
				uint startIndex4;
				int count;
				checked
				{
					startIndex4 = unchecked((uint)num2) - unchecked((uint)(int)((byte*)1372)->ToString((IFormatProvider)(object)((byte*)((uint)(byte)Class0.smethod_1(bindingFlags, null, type_2, array5) / 225u))->ToString((byte.TryParse("WXMQM", default(NumberStyles), null, out result) as Settings).Times as string)) / 8107746u);
					count = num2;
				}
				_ = (StringComparison)string.Join(text, (string[])(object)(text + text + text), num2, -1102042165);
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_6 = array3;
				array5 = array5;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
				object obj31 = ((byte*)(byte)Class0.smethod_1(bindingFlags_16, methodBase_6, null, parameterModifier_))->GetTypeCode();
				_003F val6 = checked(191 + ((obj31 is byte) ? obj31 : null));
				b = (byte)Class0.smethod_0(null, resolveEventArgs);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte obj32);
				object obj33 = ((byte*)val6)->Equals(obj32);
				stringComparison = (StringComparison)((obj33 is StringComparison) ? obj33 : null);
				_ = text2.IndexOf(value, (int)startIndex4, count, default(StringComparison)) is string;
				text = text;
				string text18 = text;
				settings = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings2);
				obj2 = settings2.Times as object;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text19);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj34);
				_ = text19.LastIndexOf(text18.Equals(obj34) as string, (int)checked(unchecked((uint)num2) * 3956637775u), -658879828) is Resources;
			}
			finally
			{
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			string strA7 = text;
			int indexA2 = (int)text.ToString(formatProvider);
			Class2 class5 = @class;
			object object_2 = obj2;
			string text20 = text.ToLowerInvariant();
			obj2 = ((byte*)234)->GetTypeCode() as object;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj36);
			obj2 = obj36;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj37);
			obj2 = obj37;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
			byte num25 = (byte)text20.ToUpper((CultureInfo)((Class2)null).method_0(object_3, type, (CultureInfo)null));
			object object_4 = text.ToLower();
			Class2 obj38 = (Class2)(object)string.Copy(text);
			type = (Type)(object)Settings.Default;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_9);
			text = (string)((Class2)null).method_0(object_4, (Type)null, (CultureInfo)obj38.method_0(null, type_9, null));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
			string s6 = byte.TryParse(s5, out result) as string;
			numberStyles = default(NumberStyles);
			string obj39 = byte.Parse(s6, numberStyles, formatProvider) as string;
			string strA8 = text;
			int hashCode = ((byte*)b)->GetHashCode();
			string strB5 = text;
			uint indexB2 = checked(2338730929u * 2217088446u);
			string strA9 = text;
			BindingFlags bindingFlags_17 = bindingFlags;
			string obj40 = ((Settings)null).Times as string;
			object obj41 = ((byte*)254)->Equals(b);
			string strB6 = (string)(object)Class0.smethod_1(bindingFlags_17, obj40.IndexOf((char)(int)((obj41 is char) ? obj41 : null), -1003081152, -621185620) as MethodBase[], null, null);
			CultureInfo culture2 = (CultureInfo)(object)Class2.smethod_3(bindingFlags, array3, (Type[])(object)Class0.smethod_1(bindingFlags, array3, ((Settings)null).Value as Type[], (ParameterModifier[])(object)text.TrimStart(null)), array5);
			compareOptions = (CompareOptions)Class0.smethod_0(smethod_3(null) as object, null);
			object obj42 = string.Compare(strA8, hashCode, strB5, (int)indexB2, string.Compare(strA9, strB6, culture2, default(CompareOptions)));
			string obj43 = obj39.IsNormalized((NormalizationForm)((obj42 is NormalizationForm) ? obj42 : null)) as string;
			string value7 = text;
			int count2 = (int)((byte*)241)->ToString();
			object obj44 = ((byte*)b)->CompareTo(200);
			stringComparison = (StringComparison)((obj44 is StringComparison) ? obj44 : null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType3);
			object obj45 = obj43.LastIndexOf(value7, 1814292635, count2, comparisonType3);
			Type type_10 = ((byte*)checked(num25 + unchecked(((obj45 is byte) ? obj45 : null) / b)))->Equals((byte)Class0.smethod_1(default(BindingFlags), array3, null, array5)) as Type;
			cultureInfo = cultureInfo;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
			object obj46 = string.CompareOrdinal(strA7, indexA2, (string)class5.method_0(object_2, type_10, cultureInfo_), 1382272956, 1920443868);
			object obj47 = ((obj46 is BindingFlags) ? obj46 : null);
			array6 = array6;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_4);
			smethod_2((BindingFlags)obj47, propertyInfo_4, type, null, null);
			goto IL_0d24;
		}
		IL_0d24:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj51);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		while (flag)
		{
			do
			{
				try
				{
					_ = byte.Parse(text) is void;
				}
				finally
				{
					text = text;
					string s7 = ((byte*)60)->Equals(obj2) as string;
					numberStyles = numberStyles;
					ref _003F reference = ref *(_003F*)163;
					object obj48 = "CMYFX".StartsWith((byte.TryParse(s7, style2, null, out result) as string).Contains(text) as string, stringComparison);
					object obj49 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo((byte)(int)((obj48 is byte) ? obj48 : null));
					Class2 obj50 = (Class2)(object)((byte*)((obj49 is byte) ? obj49 : null))->ToString(formatProvider);
					_ = text.IndexOf(((byte*)b)->GetTypeCode() as string) is object;
					obj2 = null;
					obj2 = obj51;
					_ = (Struct2)obj50.method_0(object_5, type, cultureInfo);
					@struct = default(Struct2);
					@struct = struct2;
					@struct = default(Struct2);
					object obj52 = byte.TryParse(text, out result);
					@struct = (Struct2)((obj52 is Struct2) ? obj52 : null);
					@struct = default(Struct2);
					resources = resources;
					resources = resources;
					text = text;
					continue;
				}
			}
			while (flag);
		}
		while (flag)
		{
		}
		bool num26;
		object obj53;
		do
		{
			num26 = flag;
			obj53 = ((string)(object)Class0.smethod_0(obj2, resolveEventArgs)).IndexOf('芍');
		}
		while (checked((num26 - (1 - ((obj53 is bool) ? obj53 : null) + 0)) * 1) != 0);
		do
		{
			text = text;
		}
		while (checked(1u + (flag ? 1u : 0u)) / 1u != 0 || (byte)Settings.Default != 0);
		object obj54 = ((byte*)b)->GetTypeCode();
		b = (byte)(int)((obj54 is byte) ? obj54 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<string> enumerable);
		do
		{
			try
			{
				_ = string.CompareOrdinal("PDKTYX", 1476990740, text, num2, ((Settings)null).Times) is void;
				_ = (byte)Class0.smethod_0(obj2, string.Compare("QBTATOFRH", text, byte.Parse("CSDY") as CultureInfo, compareOptions) as ResolveEventArgs);
				b = 24;
				string separator2 = text;
				enumerable = enumerable;
				_ = (Resources)(object)string.Join(separator2, enumerable);
				text = "NC";
			}
			catch
			{
				_ = (Class0)(object)((byte*)b)->ToString("EBK");
			}
		}
		while (checked((flag ? 1u : 0u) * (flag ? 1u : 0u) != 0 || 0u + (((unchecked((byte)((byte*)(byte)smethod_4(array9, array9))->ToString()) != 0) ? 1u : 0u) + unchecked(0u / (string.IsNullOrWhiteSpace("QMHNXBTG") ? 1u : 0u))) + (flag ? 1u : 0u) != 0));
		byte num27 = b;
		byte num28 = b;
		byte num29 = b;
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		b = (byte)checked(unchecked((uint)num28) - unchecked((uint)checked(unchecked((byte)((byte*)num29)->ToString(formatProvider3)) + b)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte obj56);
		_ = ((byte*)num27)->Equals(obj56) is _003CPrivateImplementationDetails_003E;
		try
		{
		}
		catch
		{
			b = b;
		}
		resources = resources;
		byte num30 = b;
		b = 101;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b8);
		int num31 = checked(num30 * b8);
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider4);
		_ = (byte)((byte*)num31)->ToString(formatProvider4);
		string[] separator3 = array8;
		object obj58 = ((Settings)null).Times;
		_ = ((byte*)222)->CompareTo("FSXM".Split(separator3, (StringSplitOptions)((obj58 is StringSplitOptions) ? obj58 : null))) is Struct2;
		@struct = @struct;
		try
		{
			try
			{
				try
				{
					b = 122;
				}
				catch
				{
					Class2 class6 = @class;
					type = ((Settings)null).Times as Type;
					string value8 = text.IndexOfAny(null, (int)checked(unchecked((uint)num2) + unchecked((uint)num2)), 1597530902) as string;
					int startIndex5 = num2;
					int count3 = (int)Class2.smethod_3((BindingFlags)Class0.smethod_0(obj2, null), null, (Type[])(object)text.PadRight(-486015268), array5);
					object object_6 = string.Compare(text, text, flag, cultureInfo) as object;
					Type type_11 = (Type)(object)string.Concat(obj2);
					object obj59 = ((byte*)(byte.Parse(text, null) / b))->GetTypeCode();
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_12);
					int indexA3 = (int)class6.method_0(null, type_12, (CultureInfo)(object)smethod_4("CFA".LastIndexOf(value8, startIndex5, count3, (StringComparison)((Class2)null).method_0(object_6, type_11, (CultureInfo)(object)Class2.smethod_3((BindingFlags)((obj59 is BindingFlags) ? obj59 : null), ((byte*)b)->Equals(b) as MethodBase[], null, array5))) as byte[], null));
					string strB7 = text;
					int num32 = num2;
					int num33 = (int)string.IsInterned(text)!.Normalize(default(NormalizationForm));
					int num34 = num2;
					num2 = 1503927879;
					uint num36;
					checked
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out int num35);
						num36 = unchecked((uint)num34) * (unchecked((uint)num35) + 3554831788u);
					}
					object obj60 = ((byte*)b)->GetTypeCode();
					numberStyles = (NumberStyles)((obj60 is NumberStyles) ? obj60 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
					object obj61 = byte.Parse("NQW", style3);
					num2 = (int)((obj61 is int) ? obj61 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int num37);
					object obj62 = string.Compare("VQUAE", indexA3, strB7, 1512899687, (int)checked(unchecked((uint)num32) * (unchecked(checked(unchecked((uint)num33) - (num36 - unchecked((uint)num37))) / 1369331888u) * unchecked((uint)num2))), default(StringComparison));
					_ = ((byte*)((obj62 is byte) ? obj62 : null))->Equals((byte)checked(unchecked((uint)checked(b + b)) + unchecked((uint)b))) is void;
				}
			}
			catch
			{
			}
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
					_ = (byte)text.ToString(null);
					b = b;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b9);
					b = b9;
					return;
				}
				catch
				{
					Class3 class7 = class7;
					class7 = null;
					return;
				}
			}
		}
	}

	unsafe static void ivukip7()
	{
		//IL_0044: Expected O, but got I4
		//IL_004a: Expected I4, but got O
		//IL_006a: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_00c2: Expected I4, but got O
		//IL_00cb: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected I4, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected I4, but got Unknown
		//IL_0145: Expected O, but got I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected I4, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_01b4: Expected I4, but got O
		//IL_01c3: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_0226: Expected I4, but got O
		//IL_0227: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		//IL_0293: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_031d: Expected O, but got I4
		//IL_0322: Expected I4, but got O
		//IL_032e: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_034d: Expected O, but got I4
		//IL_03e4: Expected O, but got I4
		//IL_03fd: Expected O, but got I4
		//IL_0430: Expected O, but got I4
		//IL_0450: Expected O, but got I4
		//IL_045a: Expected O, but got I4
		//IL_04e3: Expected O, but got I4
		//IL_04fd: Expected O, but got I4
		//IL_0522: Expected O, but got I4
		//IL_052b: Expected I4, but got O
		//IL_052c: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		//IL_0579: Expected I4, but got O
		//IL_05dd: Expected O, but got I4
		//IL_05e7: Expected O, but got I4
		//IL_05f3: Expected I4, but got O
		//IL_0638: Expected O, but got I4
		//IL_0644: Expected O, but got I4
		//IL_066e: Expected O, but got I4
		//IL_0673: Expected I4, but got O
		//IL_0680: Expected O, but got I4
		//IL_068a: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int length);
		object obj2;
		byte b;
		int num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		NumberStyles numberStyles;
		do
		{
			try
			{
			}
			catch
			{
			}
			b = 16;
			text = text;
			string text2 = text;
			obj2 = null;
			obj2 = obj3;
			obj2 = obj4;
			int num = (int)((Class2)null).method_0(object_, (Type)null, (CultureInfo)null);
			string s = text;
			numberStyles = default(NumberStyles);
			numberStyles = default(NumberStyles);
			object obj5 = byte.Parse(s, numberStyles);
			num2 = (int)((obj5 is int) ? obj5 : null);
			uint startIndex;
			checked
			{
				startIndex = unchecked((uint)num) + unchecked((uint)num2);
				num2 = -2012038745;
			}
			_ = (object)text2.Substring((int)startIndex, length);
			obj2 = null;
		}
		while (((byte*)80)->CompareTo(obj2) is bool);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		try
		{
			try
			{
				Settings settings = ((byte*)127)->Equals(obj2) as Settings;
				_ = settings.Value is Resources;
				b = 185;
				uint num3;
				object obj6;
				ResolveEventArgs resolveEventArgs;
				checked
				{
					num3 = 185u - unchecked((uint)(byte)Settings.Default);
					resolveEventArgs = null;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
					resolveEventArgs = resolveEventArgs2;
					obj6 = smethod_3(resolveEventArgs);
				}
				b = (byte)(int)((obj6 is byte) ? obj6 : null);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
				ref _003F reference = ref *(_003F*)b2;
				object obj7 = ((byte*)b)->GetHashCode();
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
				_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).Equals((byte)(int)(num3 / (b3 / ((obj7 is byte) ? obj7 : null)))) is Resources;
				b = 206;
				string text3 = text;
				char c = c;
				object obj8 = text3.LastIndexOf(c, (int)checked(3508225855u * 1872689776u));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
				b = (byte)checked(b4 - ((obj8 is byte) ? obj8 : null));
				b = 196;
				byte num4 = (byte)Settings.Default;
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_ = bindingFlags;
				array = array;
				MethodBase[] methodBase_ = array;
				array2 = (Type[])(object)Settings.Default;
				string s2 = (string)(object)Class2.smethod_3(bindingFlags_, methodBase_, array2, null);
				object obj9 = settings.Value;
				b = (byte)checked(((obj9 is byte) ? obj9 : null) * 151);
				string s3 = text;
				NumberStyles style = numberStyles;
				resolveEventArgs = resolveEventArgs;
				resolveEventArgs = (ResolveEventArgs)(object)string.Join(text, byte.Parse(text, null) as object[]);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
				object obj10 = smethod_3(resolveEventArgs_);
				object obj11 = ((obj10 is BindingFlags) ? obj10 : null);
				MethodBase[] methodBase_2 = array;
				array2 = settings.Times as Type[];
				b = b;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				parameterModifier_ = (ParameterModifier[])(object)((byte*)((uint)b5 / 127u))->ToString("DC", null);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_);
				formatProvider = (IFormatProvider)Class0.smethod_1((BindingFlags)obj11, methodBase_2, type_, parameterModifier_);
				string obj12 = (string)(object)Class0.smethod_0(null, byte.Parse(s3, style, formatProvider) as ResolveEventArgs);
				BindingFlags bindingFlags_2 = bindingFlags;
				string text4 = text;
				@class = @class;
				Class2 class2 = @class;
				type = null;
				Type type_2 = type;
				array3 = array3;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
				array3 = smethod_4(byte_, array3);
				ref _003F reference2 = ref *(_003F*)num4;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
				ref _003F reference3 = ref *(_003F*)b6;
				string obj13 = (string)(object)Class0.smethod_1(bindingFlags_2, null, ((byte*)6)->Equals((byte)(int)/*isinst with value type is only supported in some contexts*/) as Type[], byte.Parse(text) as ParameterModifier[]);
				object obj14 = ((byte*)checked(unchecked((uint)b) + 231u))->Equals(b);
				byte num5 = (byte)System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).ToString("QGIVAT", (byte.Parse(s2, ((Settings)(object)System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).ToString(obj12, byte.TryParse("HXVR", out *(byte*)(obj13.StartsWith((byte.Parse((string)(object)"DXIJAPKM".Split((char[])(object)((byte*)((obj14 is byte) ? obj14 : null))->ToString()), numberStyles) as Settings).Times as string, (byte)((byte*)b)->ToString() != 0, null) as string).ToString(null)) as IFormatProvider)).Value as IFormatProvider) as string).IsNormalized() as IFormatProvider);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_3 = bindingFlags;
				MethodBase[] methodBase_3 = array;
				array2 = array2;
				checked
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_3);
					_ = num5 * unchecked((byte)Class2.smethod_3(bindingFlags_3, methodBase_3, type_3, null));
				}
				object obj15 = ((Settings)(object)Class2.smethod_3(bindingFlags, array, array2, (ParameterModifier[])(object)((byte*)b)->ToString())).Value;
				b = (byte)(int)((obj15 is byte) ? obj15 : null);
			}
			finally
			{
				try
				{
					_ = text.CompareTo(obj2) is byte;
					_ = byte.Parse("FUU", numberStyles) is Class3;
					string separator = text;
					_ = smethod_3(null) is string[];
					string[] array4 = array4;
					string.Join(separator, array4);
				}
				catch
				{
					byte.Parse("LIZEPY", (IFormatProvider)(object)((byte*)43)->ToString());
				}
				goto end_IL_0077;
			}
			end_IL_0077:;
		}
		finally
		{
			goto IL_0388;
		}
		IL_0699:
		b = b;
		return;
		IL_0675:
		_ = byte.Parse(((byte*)17)->GetHashCode() as string) is void;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		if (0u / (flag ? 1u : 0u) != 0)
		{
			goto IL_0675;
		}
		goto IL_0695;
		IL_0388:
		try
		{
			bool num6;
			do
			{
				Class2 class3 = @class;
				object object_2 = obj2;
				CultureInfo cultureInfo_ = null;
				_ = (Struct2)class3.method_0(object_2, null, cultureInfo_);
				num6 = (byte)string.IsInterned("XOCXU") != 0;
				flag = num6;
			}
			while (num6);
		}
		finally
		{
			Class1 obj17 = (Class1)(object)"MMS".PadLeft(343636383, '윉');
			Class1 class4 = class4;
			class4 = obj17;
			goto IL_03d5;
		}
		IL_03d5:
		try
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class0.smethod_0(obj2, byte.Parse("KB") as ResolveEventArgs);
				}
				catch
				{
					_ = ((byte*)b)->GetTypeCode() is byte;
				}
			}
			catch
			{
				BindingFlags bindingFlags_4 = bindingFlags;
				MethodBase[] methodBase_4 = array;
				Type[] type_4 = array2;
				parameterModifier_ = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
				_ = (byte)Class0.smethod_1(bindingFlags_4, methodBase_4, type_4, parameterModifier_2);
			}
		}
		catch
		{
		}
		string obj21 = "MQYKPTQV".CompareTo(text) as string;
		string s4 = text;
		numberStyles = numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		_ = obj21.StartsWith(byte.TryParse(s4, default(NumberStyles), null, out result) as string) is GClass0;
		try
		{
			try
			{
			}
			finally
			{
				while (true)
				{
					((byte*)b)->ToString(formatProvider);
				}
			}
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
			while (true)
			{
				text = text;
				if (byte.TryParse(s5, out *(byte*)null))
				{
					text.Split((string[]?)null, num2, default(StringSplitOptions));
					continue;
				}
				break;
			}
			goto IL_049e;
		}
		IL_0695:
		if (flag)
		{
			goto IL_0675;
		}
		goto IL_0699;
		IL_049e:
		try
		{
		}
		finally
		{
			BindingFlags bindingFlags_5 = bindingFlags;
			PropertyInfo[] propertyInfo_ = null;
			string obj22 = (string)(object)smethod_4(array3, null);
			int startIndex2 = num2;
			string text5 = text;
			char[] anyOf = null;
			BindingFlags bindingFlags_6 = bindingFlags;
			Type[] type_5 = array2;
			BindingFlags bindingFlags_7 = bindingFlags;
			string text6 = text;
			num2 = -1234847920;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
			ResolveEventArgs resolveEventArgs = (ResolveEventArgs)(object)Class0.smethod_1(bindingFlags_7, null, text6[(int)checked(unchecked((uint)num7) * 3060119376u)] as Type[], parameterModifier_);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			object obj23 = text5.IndexOfAny(anyOf, (int)((string)(object)Class2.smethod_3(bindingFlags_6, null, type_5, smethod_3(resolveEventArgs_2) as ParameterModifier[]) + text + text), 171633843);
			void @void = smethod_2(bindingFlags_5, propertyInfo_, obj22.LastIndexOf("MZIM", startIndex2, (StringComparison)((obj23 is StringComparison) ? obj23 : null)) as Type, array2, null);
			@void = @void;
			goto IL_0545;
		}
		IL_0545:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		do
		{
			bindingFlags = default(BindingFlags);
			Class2 class5 = @class;
			Type type_6 = type;
			BindingFlags bindingFlags_8 = bindingFlags;
			text = text;
			object obj24 = byte.Parse(s6, (NumberStyles)Class0.smethod_0(obj2, null), null);
			MethodBase[] methodBase_5 = (MethodBase[])(object)((byte*)byte.Parse("VSHZBMXV", (NumberStyles)((obj24 is NumberStyles) ? obj24 : null)))->ToString();
			Type[] type_7 = (Type[])(object)Class0.smethod_0(obj2, null);
			parameterModifier_ = null;
			_ = (BindingFlags)string.Join<T>((string)class5.method_0(null, type_6, (CultureInfo)(object)Class0.smethod_1(bindingFlags_8, methodBase_5, type_7, parameterModifier_3)), (IEnumerable<T>)null);
			text = ((byte*)107)->ToString();
			string s7 = text;
			numberStyles = default(NumberStyles);
			object obj25 = byte.Parse(s7, default(NumberStyles));
			object obj26 = byte.TryParse(s8, out *(byte*)((obj25 is ref byte) ? obj25 : null));
			_ = (BindingFlags)Class0.smethod_1((BindingFlags)((obj26 is BindingFlags) ? obj26 : null), null, null, null);
			bindingFlags = bindingFlags;
			MethodBase[] methodBase_6 = array;
			array2 = null;
			Class0.smethod_1(default(BindingFlags), methodBase_6, type_8, parameterModifier_);
			flag = flag;
		}
		while (flag2);
		while ("ATZAW".Contains(string.Copy(byte.Parse(((byte*)b)->Equals(115) as string, numberStyles) as string)))
		{
		}
		try
		{
		}
		finally
		{
			while (true)
			{
			}
		}
	}
}
