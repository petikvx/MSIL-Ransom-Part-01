using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;
using p;

namespace ns0;

internal static class Class9
{
	public static MethodBase smethod_0(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
	{
		Type[] array = new Type[type_0.Length];
		for (int i = 0; i < type_0.Length; i++)
		{
			array[i] = type_0[i].UnderlyingSystemType;
		}
		type_0 = array;
		int num = 0;
		for (int j = 0; j < methodBase_0.Length; j++)
		{
			ParameterInfo[] parameters = methodBase_0[j].GetParameters();
			if (parameters.Length != type_0.Length)
			{
				continue;
			}
			int k;
			for (k = 0; k < type_0.Length; k++)
			{
				Type parameterType = parameters[k].ParameterType;
				if (parameterType != type_0[k] && parameterType != typeof(object) && !parameterType.IsPrimitive && !parameterType.IsAssignableFrom(type_0[k]))
				{
					break;
				}
			}
			if (k == type_0.Length)
			{
				methodBase_0[num++] = methodBase_0[j];
			}
		}
		switch (num)
		{
		case 0:
			return null;
		case 1:
			return methodBase_0[0];
		default:
		{
			int num2 = 0;
			int[] array2 = new int[type_0.Length];
			for (int l = 0; l < type_0.Length; l++)
			{
				array2[l] = l;
			}
			for (int m = 1; m < num; m++)
			{
			}
			return methodBase_0[num2];
		}
		}
	}

	static Class9()
	{
		Class7.smethod_0();
		Class0.smethod_0();
	}

	[STAThread]
	public static void Main()
	{
		smethod_1();
	}

	internal static void smethod_1()
	{
		Program.Main();
		char.IsSymbol(0.GetHashCode().ToString(), -1589808012);
	}

	public static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class2.smethod_0(resolveEventArgs_0))
		{
			return null;
		}
		return Class6.assembly_0;
	}

	unsafe static void avitawutahiqit3(object object_0, object object_1)
	{
		//IL_002d: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_01b1: Expected I4, but got O
		//IL_01ee: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected I4, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got I4
		//IL_027a: Expected Ref, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_02d3: Expected I4, but got O
		//IL_02e6: Expected O, but got I4
		//IL_033c: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_0395: Expected O, but got I4
		//IL_03c6: Expected O, but got I4
		//IL_03d0: Expected O, but got I4
		//IL_03d6: Expected I4, but got O
		//IL_0442: Expected O, but got I4
		//IL_044c: Expected I4, but got O
		//IL_044d: Expected O, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected I4, but got Unknown
		//IL_0478: Expected O, but got I4
		//IL_04bf: Expected O, but got I4
		//IL_0509: Expected O, but got I4
		//IL_0513: Expected O, but got I4
		//IL_051c: Expected I4, but got O
		//IL_051d: Expected O, but got I4
		//IL_0526: Expected I4, but got O
		//IL_0526: Expected I4, but got O
		//IL_0527: Expected O, but got I4
		//IL_052d: Expected I4, but got O
		//IL_053d: Expected O, but got I4
		//IL_0562: Expected O, but got I4
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Ref, but got Unknown
		//IL_0574: Expected O, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got I4
		//IL_0589: Expected I4, but got O
		//IL_0589: Expected I4, but got Unknown
		//IL_0589: Expected I4, but got O
		//IL_058a: Expected O, but got I4
		//IL_0593: Expected I4, but got O
		//IL_0594: Expected O, but got I4
		//IL_05a5: Expected O, but got I4
		//IL_05c5: Expected O, but got I4
		//IL_05cf: Expected O, but got I4
		//IL_064f: Expected O, but got I4
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected I4, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Ref, but got Unknown
		//IL_0687: Expected O, but got I4
		//IL_06c8: Expected O, but got I4
		//IL_06f3: Expected O, but got I4
		//IL_0743: Expected O, but got I4
		//IL_0769: Expected O, but got I4
		//IL_0798: Expected O, but got I4
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got I4
		//IL_0819: Expected O, but got I4
		//IL_0883: Expected O, but got I4
		//IL_088c: Expected I4, but got O
		//IL_088d: Expected O, but got I4
		//IL_0896: Expected I4, but got O
		//IL_08a0: Expected I4, but got O
		//IL_08be: Expected O, but got I4
		//IL_08ea: Expected O, but got I4
		//IL_0910: Expected O, but got I4
		//IL_091a: Expected O, but got I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got I4
		//IL_094e: Expected O, but got I4
		//IL_096c: Expected O, but got I4
		//IL_0987: Expected I4, but got O
		//IL_09b2: Expected O, but got I4
		//IL_09c2: Expected O, but got I4
		//IL_09d6: Expected O, but got I4
		//IL_09e0: Expected O, but got I4
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected O, but got I4
		//IL_0a2a: Expected O, but got I4
		//IL_0a34: Expected O, but got I4
		//IL_0a5d: Expected O, but got I4
		//IL_0a81: Expected O, but got I4
		//IL_0abf: Expected I4, but got O
		//IL_0ac9: Expected O, but got I4
		//IL_0af4: Expected Ref, but got Unknown
		//IL_0af5: Expected O, but got I4
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected Ref, but got Unknown
		//IL_0b05: Expected O, but got I4
		//IL_0b10: Expected O, but got I4
		//IL_0bb4: Expected O, but got I4
		//IL_0bca: Expected O, but got I4
		//IL_0bef: Expected O, but got I4
		//IL_0c07: Expected O, but got I4
		//IL_0c59: Expected O, but got I4
		//IL_0c75: Expected O, but got I4
		//IL_0c95: Expected O, but got I4
		//IL_0c9f: Expected O, but got I4
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected Ref, but got Unknown
		//IL_0cb4: Expected O, but got I4
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Expected O, but got I4
		//IL_0d6b: Expected O, but got I4
		//IL_0d75: Expected O, but got I4
		//IL_0d85: Expected I4, but got O
		//IL_0d90: Expected I4, but got Unknown
		//IL_0d9b: Expected O, but got I4
		//IL_0da5: Expected O, but got I4
		//IL_0dd1: Expected O, but got I4
		//IL_0dd6: Expected I4, but got O
		//IL_0e0f: Expected O, but got I4
		//IL_0e5f: Expected O, but got I4
		//IL_0e69: Expected O, but got I4
		//IL_0ece: Expected O, but got I4
		//IL_0ed9: Expected I4, but got O
		//IL_0eda: Expected O, but got I4
		//IL_0ee5: Expected O, but got I4
		//IL_0eef: Expected O, but got I4
		//IL_0ef9: Expected O, but got I4
		//IL_0f4c: Expected O, but got I4
		//IL_0f6e: Expected O, but got I4
		//IL_0f7c: Expected O, but got I4
		//IL_0fb5: Expected O, but got I4
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected I4, but got Unknown
		//IL_0fe1: Expected O, but got I4
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Expected Ref, but got Unknown
		//IL_0fed: Expected O, but got I4
		//IL_0ffa: Expected I4, but got O
		//IL_100f: Expected O, but got I4
		//IL_102a: Expected O, but got I4
		//IL_1040: Expected O, but got I4
		//IL_104a: Expected O, but got I4
		//IL_105c: Expected O, but got I4
		//IL_1067: Expected I4, but got O
		//IL_1072: Expected O, but got I4
		//IL_108f: Expected O, but got I4
		//IL_1099: Expected O, but got I4
		//IL_10c3: Expected O, but got I4
		//IL_1101: Expected O, but got I4
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1112: Expected Ref, but got Unknown
		//IL_1113: Expected O, but got I4
		//IL_111f: Expected O, but got I4
		//IL_1129: Expected O, but got I4
		//IL_1133: Expected O, but got I4
		//IL_1159: Expected O, but got I4
		//IL_1169: Expected O, but got I4
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1173: Unknown result type (might be due to invalid IL or missing references)
		//IL_117e: Expected Ref, but got Unknown
		//IL_117f: Expected O, but got I4
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected Ref, but got Unknown
		//IL_11ae: Expected O, but got I4
		//IL_11b8: Expected O, but got I4
		//IL_11ea: Expected O, but got I4
		//IL_1226: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Expected Ref, but got Unknown
		//IL_1247: Expected O, but got I4
		IFormatProvider formatProvider = formatProvider;
		IFormatProvider provider = formatProvider;
		string text = text;
		string format = text;
		IFormatProvider provider2 = formatProvider;
		BindingFlags bindingFlags = (BindingFlags)"NAXEDUBK".TrimEnd(null).ToUpper(null);
		BindingFlags bindingFlags_ = bindingFlags;
		ref byte reference = ref reference;
		PropertyInfo[] propertyInfo_ = byte.TryParse("K", out reference) as PropertyInfo[];
		Type type = type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
		type = type2;
		Type type_ = type;
		string text2 = text;
		BindingFlags bindingFlags_2 = bindingFlags;
		byte[] array = array;
		PropertyInfo[] array2 = (PropertyInfo[])(object)Class7.smethod_2(null, array);
		PropertyInfo[] propertyInfo_2 = array2;
		Type type_2 = type;
		Type[] type_3 = ((byte*)132)->CompareTo(null) as Type[];
		byte b = 57;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		byte num = (byte)Class3.smethod_2(bindingFlags_2, propertyInfo_2, type_2, type_3, (((byte*)57)->Equals(obj) as string).LastIndexOf((char)Settings.Default, 132851956) as ParameterModifier[]);
		string s = text;
		NumberStyles numberStyles = default(NumberStyles);
		numberStyles = default(NumberStyles);
		BindingFlags bindingFlags_3 = (BindingFlags)((byte*)num)->ToString(byte.Parse(s, numberStyles, formatProvider) as string);
		PropertyInfo[] propertyInfo_3 = array2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		Type[] type_4 = array3;
		ParameterModifier[] array4 = array4;
		int startIndex = (int)Class3.smethod_2(bindingFlags_3, propertyInfo_3, null, type_4, array4);
		uint num2;
		BindingFlags bindingFlags_4;
		PropertyInfo[] propertyInfo_4;
		checked
		{
			num2 = unchecked((uint)(byte)Settings.Default) - 122u;
			bindingFlags_4 = bindingFlags;
			propertyInfo_4 = array2;
			b = 1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		Type type_5 = ((byte*)b2)->CompareTo(null) as Type;
		array3 = array3;
		ResolveEventArgs resolveEventArgs = resolveEventArgs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		resolveEventArgs = resolveEventArgs2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_6);
		int count = (int)((byte*)num2)->ToString((IFormatProvider)Class3.smethod_2(bindingFlags_4, propertyInfo_4, type_5, type_6, Class2.smethod_0(resolveEventArgs) as ParameterModifier[]));
		_ = (StringComparison)((byte*)(byte)((byte*)1)->ToString(text))->ToString(formatProvider);
		StringComparison comparisonType = default(StringComparison);
		array3 = text2.LastIndexOf("CKUVPXTHI", startIndex, count, comparisonType) as Type[];
		Type[] type_7 = array3;
		array4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		string format2 = (string)(object)Class3.smethod_2(bindingFlags_, propertyInfo_, type_, type_7, parameterModifier_);
		obj = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg);
		obj = string.Format(provider2, format2, arg, obj);
		object obj2 = string.Compare(string.Format(provider, format, obj, null, obj), text, (byte)((byte*)12416)->ToString(text) != 0);
		b = (byte)(int)((obj2 is byte) ? obj2 : null);
		int num3 = 1029867058;
		text = text;
		text = "M";
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_5 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = array2;
		string text3 = text;
		num3 = 1029867058;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex2);
		byte[] byte_ = text3.LastIndexOf("JARREOCGH", startIndex2, comparisonType) as byte[];
		byte num4 = b;
		BindingFlags bindingFlags_6 = bindingFlags;
		PropertyInfo[] propertyInfo_6 = array2;
		Type type_8 = type;
		object obj3 = ((byte*)(byte)string.Format(text, obj, obj, Class2.smethod_0(null) as object))->GetHashCode();
		object obj4 = ((byte*)37)->CompareTo((byte)(10143 / ((obj3 is byte) ? obj3 : null)));
		_003F val = checked(((obj4 is byte) ? obj4 : null) - 42 + b);
		b = (byte)Class3.smethod_2(bindingFlags, ((byte*)85)->CompareTo(null) as PropertyInfo[], type, (Type[])(object)((byte*)checked(unchecked((byte)Settings.Default) - b))->ToString(), array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte value);
		byte num5 = (byte)Class7.smethod_2(byte_, (byte[])(object)((byte*)num4)->ToString((string)(object)Class3.smethod_2(bindingFlags_6, propertyInfo_6, type_8, ((byte*)val)->CompareTo(value) as Type[], null)));
		byte num6 = b;
		string text4 = text;
		string value2 = text;
		string strA = text;
		string text5 = text;
		object obj5 = (Class2.smethod_0(resolveEventArgs) as string).Equals("NV");
		object obj6 = byte.Parse(text5.Remove((int)((obj5 is int) ? obj5 : null), 588772189), (NumberStyles)((byte*)b)->ToString(text));
		object obj7 = ((obj6 is int) ? obj6 : null);
		text = text;
		byte num7 = b;
		text = "NMILNU";
		BindingFlags bindingFlags_7 = bindingFlags;
		string text6 = text;
		char num8 = (char)Class3.smethod_2(default(BindingFlags), array2, type, array3, array4);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_8 = bindingFlags;
		PropertyInfo[] propertyInfo_7 = array2;
		Type[] type_9 = array3;
		string s2 = text;
		_ = ((byte*)b)->GetHashCode() is NumberStyles;
		numberStyles = numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
		string s3 = byte.TryParse(s2, style, formatProvider, out reference) as string;
		byte num9 = (byte)smethod_2(obj, resolveEventArgs);
		string text7 = text;
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		formatProvider = (IFormatProvider)(object)((byte*)num9)->ToString(text7, formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
		array = (byte[])(object)((byte*)byte.Parse(s3, provider3))->ToString();
		bindingFlags = bindingFlags;
		text = string.Join(((byte*)231)->Equals(b) as string, (IEnumerable<string?>)null);
		char[] trimChars = null;
		NumberStyles style2 = (NumberStyles)"I".Trim(trimChars);
		formatProvider = null;
		object obj8 = text.StartsWith("APJFCYRK");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider4);
		object obj9 = byte.TryParse(s4, style2, provider4, out *(byte*)((obj8 is ref byte) ? obj8 : null));
		b = (byte)(int)((obj9 is byte) ? obj9 : null);
		object[] array5 = array5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		bindingFlags = (BindingFlags)((byte*)checked(unchecked((uint)b3) + unchecked((uint)checked(unchecked((byte)string.Concat(array5)) * b))))->ToString("IKAGWBGPX", null);
		Type type_10 = type;
		array3 = array3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array6);
		array3 = array6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
		object obj10 = text8.StartsWith(ignoreCase: (byte)(int)/*isinst with value type is only supported in some contexts*/ != 0, value: (string)(object)Settings.Default, culture: null);
		_003F val2 = checked(num8 + ((obj10 is char) ? obj10 : null));
		char c = '뢽';
		Type type_12 = (Type)(object)text6.PadLeft(1029867058, (char)checked(val2 - 47293));
		string format3 = ((byte*)13)->CompareTo(b) as string;
		array5 = (object[])(object)string.Intern("STCOKZ");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] values);
		string value3 = (string)(object)Class3.smethod_2(bindingFlags_7, null, type_12, null, (ParameterModifier[])(object)string.Format(null, format3, (object[])(object)string.Join("ZXIHEVC", values)));
		object obj11 = "WXOYOJ".Equals(obj);
		object obj12 = ((obj11 is int) ? obj11 : null);
		_ = (string)(object)Class7.smethod_2((byte[])(object)"VATOKR".ToCharArray(), array);
		text = "NU";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
		string text10 = text9 + "DVPD";
		string s5 = ((byte*)checked(0u * unchecked((uint)b)))->ToString(text);
		NumberStyles style3 = numberStyles;
		resolveEventArgs = resolveEventArgs;
		int startIndex3 = (int)obj12;
		object obj13 = text10.IndexOf((char)(int)/*isinst with value type is only supported in some contexts*/);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
		object obj14 = text11.LastIndexOf(value3, startIndex3, (StringComparison)((obj13 is StringComparison) ? obj13 : null));
		numberStyles = (NumberStyles)((obj14 is NumberStyles) ? obj14 : null);
		text = "YHUZF";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s6);
		formatProvider = byte.Parse(s6) as IFormatProvider;
		bindingFlags = bindingFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_10);
		reference = ref *(byte*)Class3.smethod_2(bindingFlags_10, array2, type, null, array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB);
		object obj15 = string.Compare(strA, (int)obj7, strB, (int)checked(1029867058u * unchecked((uint)((byte*)checked(num7 + /*isinst with value type is only supported in some contexts*/))->GetHashCode()) + /*isinst with value type is only supported in some contexts*/), (int)/*isinst with value type is only supported in some contexts*/);
		b = (byte)((uint)byte.Parse((text4.LastIndexOf(value2, 1117160109, (StringComparison)((obj15 is StringComparison) ? obj15 : null)) as string).LastIndexOf("JAHGA", comparisonType) as string) / 158u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		uint num10 = num6 / (79u / (uint)b4);
		string s7 = text;
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider6);
		object obj16 = ((byte*)num10)->CompareTo(byte.Parse(s7, provider6) as object);
		object obj17 = ((obj16 is byte) ? obj16 : null);
		BindingFlags bindingFlags_11 = bindingFlags;
		MethodBase[] array7 = null;
		IFormatProvider provider7 = (IFormatProvider)Class7.smethod_1(bindingFlags_11, array7, null, null);
		bindingFlags = default(BindingFlags);
		byte num11 = (byte)string.Format(provider7, (string)(object)smethod_0(bindingFlags, null, array3, null), obj);
		BindingFlags bindingFlags_12 = bindingFlags;
		MethodBase[] methodBase_ = (MethodBase[])(object)"TPNMXTH".PadLeft(1029867058, '㟂');
		Type[] type_13 = array3;
		array4 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
		object obj18 = ((byte*)47)->Equals((byte)checked(num11 - unchecked((byte)((byte*)200)->ToString((string)(object)smethod_0(bindingFlags_12, methodBase_, type_13, parameterModifier_2)))));
		b = (byte)checked(((obj18 is byte) ? obj18 : null) - b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
		text = string.Concat(Class3.smethod_2(bindingFlags_5, propertyInfo_5, (Type)(object)((byte*)(checked(num5 * (obj17 + b5)) / checked(unchecked((uint)checked(b * b)) - unchecked((uint)(byte)Settings.Default) - 18u)))->ToString(text, null), Class2.smethod_0(resolveEventArgs) as Type[], null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text12);
		string separator = text12 + text + "OOAGMNYL";
		string[] value4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s8);
		string strB2 = ((byte*)byte.Parse(s8, (NumberStyles)string.Join(separator, value4)))->Equals(245) as string;
		string strA2 = text;
		text = "JTC";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA3);
		int indexA = string.Compare(strA3, "LXBN", ignoreCase: false);
		string strB3 = ((byte*)b)->ToString("Z".LastIndexOf(text, -746150115) as IFormatProvider);
		uint length;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		CultureInfo culture;
		CompareOptions options;
		checked
		{
			length = 1029867058u * (1029867058u * (1029867058u * unchecked((uint)(int)"DH".TrimEnd(trimChars))));
			resolveEventArgs = (ResolveEventArgs)(object)Class3.smethod_2(bindingFlags, array2, type, null, null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs3);
			resolveEventArgs = resolveEventArgs3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			_ = Class2.smethod_0(resolveEventArgs_2) is CultureInfo;
			cultureInfo = cultureInfo;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
			cultureInfo = cultureInfo2;
			cultureInfo = null;
			culture = cultureInfo;
			options = default(CompareOptions);
		}
		object obj19 = string.Compare(strA2, indexA, strB3, 1233005507, (int)length, culture, options);
		int indexB = ((byte*)((obj19 is byte) ? obj19 : null))->CompareTo(obj);
		_003F val3;
		checked
		{
			uint num12 = 1856563590u * 2884990211u;
			object obj20 = byte.Parse("ACRZOEPYA", numberStyles);
			val3 = num12 * ((obj20 is int) ? obj20 : null);
		}
		byte num13 = (byte)smethod_0(bindingFlags, array7, array3, array4);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_13 = bindingFlags;
		array2 = null;
		bindingFlags = (BindingFlags)smethod_0(bindingFlags, null, array3, string.Equals(text, "TDCRKNNF", comparisonType) as ParameterModifier[]);
		Type[] type_14 = (Type[])(object)Class7.smethod_1(default(BindingFlags), array7, array3, array4);
		array4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_3);
		object obj21 = byte.TryParse((string)(object)Class3.smethod_2(bindingFlags_13, propertyInfo_8, null, type_14, parameterModifier_3), default(NumberStyles), null, out *(byte*)null);
		object obj22 = ((obj21 is BindingFlags) ? obj21 : null);
		PropertyInfo[] propertyInfo_9 = array2;
		Type type_15 = (Type)(object)Settings.Default;
		Type[] type_16 = array3;
		string text13 = text;
		string s9 = text;
		string s10 = text;
		BindingFlags bindingFlags_14 = bindingFlags;
		PropertyInfo[] propertyInfo_10 = array2;
		Type[] type_17 = array3;
		array4 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_4);
		_ = (NumberStyles)smethod_2(Class3.smethod_2(bindingFlags_14, propertyInfo_10, null, type_17, parameterModifier_4), resolveEventArgs);
		object object_2 = obj;
		resolveEventArgs = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_3);
		numberStyles = (NumberStyles)smethod_2(object_2, resolveEventArgs_3);
		int bindingFlags_15 = (int)obj22;
		object obj23 = byte.Parse(s9, (NumberStyles)/*isinst with value type is only supported in some contexts*/);
		int num14;
		string s11;
		NumberStyles style5;
		_003F val4;
		string text14;
		IFormatProvider provider8;
		checked
		{
			num14 = unchecked((byte)string.Concat((object[])(object)Class3.smethod_2((BindingFlags)bindingFlags_15, propertyInfo_9, type_15, type_16, (ParameterModifier[])(object)text13.Remove((int)((obj23 is int) ? obj23 : null))))) + b;
			resolveEventArgs = resolveEventArgs;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_4);
			s11 = Class2.smethod_0(resolveEventArgs_4) as string;
			numberStyles = default(NumberStyles);
			style5 = numberStyles;
			numberStyles = numberStyles;
			obj = byte.Parse("BY", default(NumberStyles)) as object;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
			uint num15 = 244u - unchecked((uint)(byte)smethod_2(object_3, null));
			object obj24 = unchecked(((byte*)b)->Equals(((byte*)116)->Equals(100) as object));
			val4 = num15 - ((obj24 is byte) ? obj24 : null);
			text14 = text;
			string s12 = text;
			numberStyles = default(NumberStyles);
			provider8 = byte.Parse(s12, numberStyles, formatProvider) as IFormatProvider;
			obj = byte.Parse(text, numberStyles) as object;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj25);
			obj = obj25;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
		byte num16 = (byte)string.Format(provider8, "RNFBU", arg2);
		object obj26 = Class2.smethod_0(resolveEventArgs);
		object obj27 = ((obj26 is BindingFlags) ? obj26 : null);
		MethodBase[] methodBase_2 = array7;
		Type[] type_18 = (Type[])(object)Settings.Default;
		array4 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_5);
		b = (byte)smethod_0((BindingFlags)obj27, methodBase_2, type_18, parameterModifier_5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
		object obj28 = (text14.CompareTo(((byte*)checked(num16 * unchecked(b6 / checked(unchecked((uint)(byte)((byte*)b)->ToString(text, formatProvider)) - 121u))))->ToString(((byte*)147)->CompareTo(null) as string, null)) as string).Contains("DINIRGPCG".Contains("WRIRSWNV") as string);
		_003F val5;
		byte num17;
		BindingFlags bindingFlags_16;
		MethodBase[] methodBase_3;
		Type[] type_19;
		uint indexB2;
		string strA4;
		uint indexA2;
		checked
		{
			val5 = 143 * (133 - ((obj28 is byte) ? obj28 : null));
			num17 = b;
			bindingFlags_16 = bindingFlags;
			methodBase_3 = array7;
			type_19 = array3;
			indexB2 = 70464480u + unchecked((uint)(int)Class7.smethod_2(array, array));
			strA4 = text;
			indexA2 = unchecked((uint)(int)smethod_2(byte.Parse(text) as object, ((byte*)232)->CompareTo(((byte*)180)->CompareTo(obj) as object) as ResolveEventArgs)) + unchecked((uint)(int)Settings.Default);
		}
		object obj29 = ((byte*)49)->GetTypeCode();
		object obj30 = ((obj29 is int) ? obj29 : null);
		int startIndex4 = ((byte*)checked(56u + unchecked((uint)b)))->CompareTo((byte)((byte*)b)->ToString(((byte*)238)->Equals(null) as string));
		comparisonType = default(StringComparison);
		text = string.Compare("TOJB", 1, "A", (int)indexB2, string.Compare(strA4, (int)indexA2, "BEV", (int)obj30, (int)checked(unchecked((uint)"QNED".LastIndexOf("FZYTJMAMM", startIndex4, comparisonType)) - unchecked((uint)((byte*)b)->CompareTo(180))), (byte)Settings.Default != 0), cultureInfo, options) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
		object obj31 = ((byte*)val5)->Equals((byte)((byte*)num17)->ToString((string)(object)Class7.smethod_1(bindingFlags_16, methodBase_3, type_19, (ParameterModifier[])(object)text15.TrimEnd(null))));
		text = byte.TryParse(s11, style5, ((byte*)checked(val4 - ((obj31 is byte) ? obj31 : null)))->Equals(62) as IFormatProvider, out *(byte*)null) as string;
		c = (char)checked(73396u * (46814u * unchecked((uint)(char)((byte*)(byte)((byte*)checked(unchecked((uint)checked(b * unchecked((byte)Settings.Default))) * 105u))->ToString("Y", formatProvider))->ToString(formatProvider)) * 47293u * 16616u));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text16);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c2);
		byte num18 = (byte)text16.Replace('뢽', (char)checked(21628u + unchecked((uint)c2)));
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_17 = bindingFlags;
		PropertyInfo[] propertyInfo_11 = array2;
		Type type_20 = (Type)(object)text.TrimEnd(null);
		Type[] type_21 = array3;
		BindingFlags bindingFlags_18 = bindingFlags;
		PropertyInfo[] propertyInfo_12 = array2;
		Type type_22 = type;
		b = b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
		b = b7;
		object obj32 = text.IndexOf('鳗');
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b8);
		string s13 = ((string)(object)Class3.smethod_2(bindingFlags_17, propertyInfo_11, type_20, type_21, (ParameterModifier[])(object)Class3.smethod_2(bindingFlags_18, propertyInfo_12, type_22, ((byte*)checked(b8 * unchecked((byte)((byte*)((obj32 is byte) ? obj32 : null))->ToString(formatProvider))))->GetHashCode() as Type[], array4))).StartsWith("VKE") as string;
		numberStyles = (NumberStyles)Settings.Default;
		string text17;
		string value5;
		uint num20;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style6);
			uint num19 = unchecked((uint)num14 / checked(num18 + (unchecked(11u / (129u / (uint)(byte)(byte.Parse(s13, style6) as string).Trim())) - (unchecked((uint)b) - 102u)))) - b;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_19 = bindingFlags;
			text17 = text;
			value5 = text;
			num20 = 21u + unchecked((uint)(b / b));
			formatProvider = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		PropertyInfo[] propertyInfo_13 = text17.IndexOf(value5, 1029867058, (int)((byte*)num20)->ToString(formatProvider3)) as PropertyInfo[];
		Type type_23 = type;
		Type[] type_24 = array3;
		b = 244;
		object obj33 = ((byte*)checked(/*isinst with value type is only supported in some contexts*/ * 198))->Equals(244);
		_003F val6 = val3 / ((obj33 is int) ? obj33 : null);
		string text18 = text;
		NormalizationForm normalizationForm = (NormalizationForm)Class7.smethod_1(bindingFlags, null, array3, array4);
		byte num21 = (byte)text18.Normalize(normalizationForm);
		array = array;
		_003F val7;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_3);
			val7 = val6 * unchecked(((byte*)48)->CompareTo(((byte*)num21)->ToString((IFormatProvider)(object)Class7.smethod_2(byte_3, null))));
		}
		int num22 = (char)string.Format(text, "GRJLUEQ".IndexOf(c, -85578188, 1029867058) as object[]) / (char)((string)(object)Class3.smethod_2((BindingFlags)string.Copy("GQ"), null, type, array3, array4)).TrimEnd(null);
		string s14 = text;
		numberStyles = numberStyles;
		int totalWidth = (int)val7;
		object obj34 = byte.TryParse(s14, default(NumberStyles), formatProvider, out *(byte*)/*isinst with value type is only supported in some contexts*/);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool ignoreCase2);
		_ = (string.Compare("RASFU", 1029867058, strB2, indexB, 1029867058, ignoreCase2, (CultureInfo)(object)"KKRBCENCC".PadRight(totalWidth, (char)checked(unchecked((uint)num22) - unchecked((uint)(char)Class3.smethod_2((BindingFlags)((obj34 is BindingFlags) ? obj34 : null), array2, type, null, array4))))) as string).GetHashCode() is byte;
		_ = (Class6)text.Clone();
		Class6 @class = @class;
		object obj35 = ((byte*)(byte)string.Concat(array5))->CompareTo(113);
		bindingFlags = (BindingFlags)((obj35 is BindingFlags) ? obj35 : null);
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_20 = bindingFlags;
		array7 = array7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_4);
		_ = (Type)(object)Class7.smethod_1(bindingFlags_20, methodBase_4, array3, null);
		type = null;
		type = type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_21);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_25);
		@class = (Class6)(object)Class3.smethod_2(bindingFlags_21, null, type_25, ((byte*)177)->Equals(23) as Type[], array4);
		b = 53;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value6);
		while (byte.TryParse("NUMYZWBXB", default(NumberStyles), null, out *(byte*)null))
		{
			uint num23;
			checked
			{
				num23 = 32u - unchecked((uint)(byte)((byte*)(byte)Class7.smethod_1((BindingFlags)smethod_2(null, resolveEventArgs), array7, null, null))->ToString((IFormatProvider?)null));
				obj = obj;
			}
			_ = (((byte*)num23)->CompareTo(value6) as string).GetHashCode() is void;
		}
		try
		{
		}
		catch
		{
			try
			{
				Class3 class2 = class2;
				class2 = class2;
			}
			finally
			{
				BindingFlags bindingFlags_22 = bindingFlags;
				array7 = array7;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_5);
				Class7.smethod_1(bindingFlags_22, methodBase_5, array3, array4);
				goto end_IL_0e89;
			}
			end_IL_0e89:;
		}
		finally
		{
			numberStyles = default(NumberStyles);
			NumberStyles style7 = numberStyles;
			IFormatProvider provider9 = formatProvider;
			string s15 = text;
			NumberStyles style8 = numberStyles;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s16);
			object obj37 = byte.Parse(byte.TryParse(s15, style8, byte.TryParse(s16, (NumberStyles)/*isinst with value type is only supported in some contexts*/, formatProvider, out reference) as IFormatProvider, out reference) as string);
			_ = byte.TryParse("EQLS", style7, provider9, out *(byte*)((obj37 is ref byte) ? obj37 : null)) is void;
			goto IL_0f01;
		}
		IL_0f01:
		BindingFlags bindingFlags_23;
		string value7;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
			do
			{
				_ = (flag ? 1u : 0u) * (1u - (byte.TryParse(text, out reference) ? 1u : 0u));
			}
			while (flag2);
			_ = (Struct2)smethod_2(null, null);
			bindingFlags_23 = bindingFlags;
			value7 = text;
			formatProvider = formatProvider;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider10);
		bool ignoreCase3 = (byte)string.Format(provider10, text, null) != 0;
		BindingFlags bindingFlags_24 = bindingFlags;
		array7 = (MethodBase[])(object)Settings.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_6);
		string s17 = (string)(object)smethod_0(bindingFlags_24, methodBase_6, byte.Parse(text) as Type[], null);
		numberStyles = numberStyles;
		object obj38 = ((byte*)89)->CompareTo(obj);
		object obj39 = ((obj38 is BindingFlags) ? obj38 : null);
		object object_4 = ((byte*)b)->CompareTo(b) as object;
		resolveEventArgs = resolveEventArgs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_5);
		_ = (byte)smethod_2(object_4, resolveEventArgs_5);
		b = 93;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b10);
		uint num24 = (uint)b10 / 116u;
		object obj40 = ((byte*)63)->CompareTo(7);
		b = (byte)checked(151 * ((obj40 is byte) ? obj40 : null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b11);
		uint num25 = checked((num24 - b11 - 193u) * b);
		b = 218;
		int bindingFlags_25 = (int)obj39;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b12);
		uint num26 = checked(num25 - b12);
		object obj41 = byte.TryParse("GV", numberStyles, formatProvider, out reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style9);
		string text19 = (byte.Parse(s17, style9, (IFormatProvider)(object)((string)(object)Class7.smethod_1((BindingFlags)bindingFlags_25, ((byte*)(num26 / ((obj41 is byte) ? obj41 : null)))->Equals(null) as MethodBase[], array3, array4)).Normalize()) as string).Remove(-1408588805);
		string value8 = text;
		object obj42 = Class2.smethod_0(null);
		ref _003F reference2 = ref *(_003F*)((obj42 is byte) ? obj42 : null);
		object obj43 = byte.TryParse(text.ToString(), out *(byte*)/*isinst with value type is only supported in some contexts*/);
		int num27 = (System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).Equals(smethod_0((BindingFlags)((obj43 is BindingFlags) ? obj43 : null), array7, byte.Parse("KURN", formatProvider) as Type[], array4)) as string).Remove(num3).LastIndexOf(byte.Parse("AZZJAGA", byte.Parse("YEXOCDBR", numberStyles) as IFormatProvider) as string, (int)Settings.Default, 1558633759, comparisonType);
		string format4 = text;
		text = "YAKWC";
		uint num28;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s18);
			num28 = unchecked((uint)num27) - unchecked((uint)(int)string.Format(format4, string.Format(byte.TryParse(s18, out reference) as string, null, obj, obj)));
		}
		num3 = (int)(614067317u / (uint)(int)((byte*)30302)->ToString());
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num29);
		object obj44 = text19.LastIndexOf(value8, -293477660, (int)(num28 / (uint)num29));
		string s19 = (string)(object)Class7.smethod_1(bindingFlags_23, "UY".EndsWith(value7, ignoreCase3, byte.Parse(byte.Parse(((byte*)checked(unchecked(((obj44 is byte) ? obj44 : null) / 1) + 21100656))->GetTypeCode() as string, numberStyles) as string) as CultureInfo) as MethodBase[], array3, array4);
		object obj45 = "GORUZOKG".GetTypeCode();
		object obj46 = ((obj45 is byte) ? obj45 : null);
		object obj47 = ((byte*)39022)->CompareTo(null);
		object obj48 = ((byte*)checked(obj46 + unchecked(((obj47 is byte) ? obj47 : null) / 218)))->CompareTo(218);
		object obj49 = ((obj48 is byte) ? obj48 : null);
		byte num30 = byte.Parse(text, null);
		text = "PGFCDH";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text20);
		MethodBase[] methodBase_7 = Class2.smethod_0(((byte*)checked(obj49 * unchecked((byte)((byte*)num30)->ToString(text20, formatProvider)) + unchecked(218u / 0u)))->CompareTo(obj) as ResolveEventArgs) as MethodBase[];
		array3 = array3;
		string text21 = text;
		trimChars = null;
		StringSplitOptions stringSplitOptions = stringSplitOptions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_26);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] separator2);
		object obj50 = ((byte*)(byte)Class7.smethod_1(default(BindingFlags), methodBase_7, type_26, (ParameterModifier[])(object)text21.Split(separator2, stringSplitOptions)))->CompareTo(obj);
		object obj51 = ((obj50 is byte) ? obj50 : null);
		c = (char)checked(c - unchecked((char)"DNZJTQD".Substring(num3)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char paddingChar);
		NumberStyles style10 = (NumberStyles)((byte*)checked(obj51 + (218u - (115u - unchecked((uint)(byte)"ARTWDJ".PadLeft(-563667485, paddingChar)))) + 436))->ToString("UQD");
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider11);
		_ = byte.TryParse(s19, style10, provider11, out reference) is Class7;
		while (true)
		{
		}
	}

	unsafe static void avitawutahiqit6(object object_0, object object_1)
	{
		//IL_0016: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0059: Expected I4, but got O
		//IL_006b: Expected O, but got I4
		//IL_0070: Expected I4, but got O
		//IL_009c: Expected O, but got I4
		//IL_00aa: Expected I4, but got O
		//IL_00c3: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_00f7: Expected O, but got I4
		//IL_0100: Expected I4, but got O
		//IL_0101: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_01e5: Incompatible stack heights: 0 vs 1
		//IL_01f1: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_0254: Expected I4, but got O
		//IL_0255: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got I4
		//IL_02c9: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_0307: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_036a: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03c9: Expected O, but got I4
		//IL_03f1: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_0418: Expected I4, but got O
		//IL_0433: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_044d: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		//IL_045e: Expected I4, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value);
		BindingFlags bindingFlags_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		byte[] array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		string[] value2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		IFormatProvider formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		BindingFlags bindingFlags;
		do
		{
			obj = obj;
			object obj2 = obj;
			obj = null;
			bindingFlags = (BindingFlags)string.Concat(obj2, (((byte*)58)->CompareTo(value) as string).ToLower());
			bindingFlags = default(BindingFlags);
			bindingFlags_ = bindingFlags;
			BindingFlags bindingFlags_2 = bindingFlags;
			BindingFlags bindingFlags_3 = bindingFlags;
			string s = text;
			string text2 = text;
			text = text;
			object obj3 = text2 == text3;
			NumberStyles numberStyles = (NumberStyles)((obj3 is NumberStyles) ? obj3 : null);
			numberStyles = numberStyles2;
			NumberStyles style = numberStyles;
			resolveEventArgs = resolveEventArgs;
			object obj4 = Class2.smethod_0(resolveEventArgs);
			bindingFlags = (BindingFlags)((obj4 is BindingFlags) ? obj4 : null);
			array = null;
			_ = (IFormatProvider)smethod_0(bindingFlags_4, (MethodBase[])(object)Class7.smethod_2(array, array), null, parameterModifier_);
			formatProvider = null;
			object obj5 = byte.Parse(s, style, formatProvider);
			text = (string)(object)smethod_0((BindingFlags)((obj5 is BindingFlags) ? obj5 : null), array2, null, parameterModifier_);
			text = text4;
			string separator = text;
			string s2 = text;
			NumberStyles style2 = numberStyles;
			formatProvider = formatProvider;
			value2 = byte.Parse(s2, style2, provider) as string[];
			string text5 = string.Join(separator, value2);
			_ = Class2.smethod_0((ResolveEventArgs)(object)((byte*)b)->ToString()) is string;
			text = "XCINAGUV";
			object obj6 = Class2.smethod_0(resolveEventArgs);
			formatProvider = text6.IsNormalized((NormalizationForm)((obj6 is NormalizationForm) ? obj6 : null)) as IFormatProvider;
			formatProvider = formatProvider2;
			array2 = (MethodBase[])(object)((byte*)54)->ToString(text5, formatProvider3);
			array2 = array3;
			array4 = (Type[])(object)smethod_0(bindingFlags_3, array2, array4, null);
			_ = (byte)Class7.smethod_1(bindingFlags_2, null, array4, ((byte*)b)->GetTypeCode() as ParameterModifier[]);
			b = (byte)text.ToString(null);
			b = 154;
			parameterModifier_ = ((byte*)37490)->CompareTo(154) as ParameterModifier[];
		}
		while ((byte)smethod_2(null, (ResolveEventArgs)(object)smethod_0(bindingFlags_, null, null, parameterModifier_)) != 0);
		text = text;
		try
		{
		}
		catch
		{
			string strA = text;
			text = ((byte*)(byte)Class7.smethod_1(bindingFlags, array2, array4, parameterModifier_))->Equals(150) as string;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB);
			_003CPrivateImplementationDetails_003E obj7 = string.CompareOrdinal(strA, strB) as _003CPrivateImplementationDetails_003E;
			_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			_003CPrivateImplementationDetails_003E = obj7;
		}
		Class0 @class = @class;
		@class = @class;
		try
		{
		}
		catch
		{
			while (true)
			{
				b = (byte)Settings.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		bool flag;
		while (true)
		{
			string text7 = text;
			string s3 = text;
			string obj10 = ((byte*)b)->Equals(null) as string;
			array5 = array5;
			char[] anyOf = array5;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_5 = bindingFlags;
			PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Settings.Default;
			Type[] type_ = array4;
			parameterModifier_ = null;
			text = (string)(object)Class3.smethod_2(bindingFlags_5, propertyInfo_, null, type_, parameterModifier_2);
			formatProvider = obj10.LastIndexOfAny(anyOf, -288817925, (int)text8.ToLowerInvariant()) as IFormatProvider;
			object obj11 = byte.Parse(s3, provider2);
			object obj12 = text7.LastIndexOf((char)(int)((obj11 is char) ? obj11 : null), 534389872);
			object obj13 = ((obj12 is bool) ? obj12 : null);
			uint num = 0u / 0u;
			flag = (byte)num != 0;
			if ((int)(obj13 / num) == 0)
			{
				break;
			}
			string.Concat(obj, (object)null, obj, (object)__arglist());
		}
		try
		{
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string format);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CompareOptions compareOptions2);
		while (true)
		{
			text = text;
			object[] args = null;
			byte num2 = (byte)string.Format(format, args);
			obj = obj;
			string obj15 = ((byte*)num2)->CompareTo(value3) as string;
			char[] separator2 = array5;
			b = 166;
			byte num3 = (byte)string.Format(formatProvider, string.Join("TWSGIUBAR", value2), obj);
			array = array;
			BindingFlags bindingFlags_6 = bindingFlags;
			array2 = array2;
			Type[] type_2 = array4;
			parameterModifier_ = ((byte*)194)->GetHashCode() as ParameterModifier[];
			object obj16 = Class2.smethod_0(((byte*)checked(unchecked((uint)b2) - unchecked((uint)(num3 / (byte)((byte*)checked(89u * unchecked((uint)(byte)Class7.smethod_2(byte_, Class2.smethod_0((ResolveEventArgs)(object)smethod_0(bindingFlags_6, methodBase_, type_2, parameterModifier_3)) as byte[]))))->ToString(formatProvider)))))->Equals(191) as ResolveEventArgs);
			object obj17 = ((obj16 is BindingFlags) ? obj16 : null);
			PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Settings.Default;
			array4 = array4;
			int count = (int)Class3.smethod_2((BindingFlags)obj17, propertyInfo_2, type_3, type_4, parameterModifier_);
			stringSplitOptions = stringSplitOptions;
			object obj18 = "RB".IndexOfAny(array5, -445389388);
			_ = ((byte*)((obj18 is byte) ? obj18 : null))->CompareTo(237) is StringSplitOptions;
			object obj19 = text.GetTypeCode();
			object obj20 = ((byte*)((obj19 is byte) ? obj19 : null))->CompareTo(obj);
			stringSplitOptions = (StringSplitOptions)((obj20 is StringSplitOptions) ? obj20 : null);
			stringSplitOptions = stringSplitOptions2;
			checked
			{
				if (((unchecked((byte)obj15.Split(separator2, count, stringSplitOptions)) != 0) ? 1u : 0u) + (flag ? 1u : 0u) == 0)
				{
					break;
				}
				while (true)
				{
					bindingFlags = bindingFlags;
					bindingFlags = bindingFlags2;
					array6 = array6;
					array6 = array7;
					if (((unchecked((byte)Class3.smethod_2(bindingFlags_7, propertyInfo_3, type_3, null, null)) != 0) ? 1u : 0u) + ((unchecked((byte)text.ToString(formatProvider)) != 0) ? 1u : 0u) == 0)
					{
						break;
					}
					unchecked
					{
						try
						{
							b = b;
							b = b3;
							_ = ((byte*)b4)->CompareTo(b) is Struct3;
						}
						catch
						{
							string strA2 = byte.TryParse("OQFDGW", (NumberStyles)smethod_2(null, resolveEventArgs), byte.Parse("ANVE", (IFormatProvider)(object)"TY".Replace((char)Settings.Default, '烥')) as IFormatProvider, out *(byte*)null) as string;
							string strB2 = text;
							cultureInfo = cultureInfo;
							CultureInfo culture = cultureInfo;
							CompareOptions compareOptions = default(CompareOptions);
							compareOptions = default(CompareOptions);
							compareOptions = compareOptions2;
							_ = string.Compare(strA2, strB2, culture, default(CompareOptions)) is Resources;
							_ = string.Compare(text, text) is Resources;
						}
					}
				}
			}
		}
	}
}
