using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
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

	unsafe static void smethod_5()
	{
		//IL_002a: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_009d: Expected O, but got I8
		//IL_00a6: Expected I4, but got O
		//IL_00a7: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00c9: Expected I4, but got O
		//IL_00ca: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_00d9: Expected I4, but got O
		//IL_00ea: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_00fa: Expected I4, but got O
		//IL_0117: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Ref, but got Unknown
		//IL_01a9: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_01ff: Expected I4, but got O
		//IL_0209: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_0246: Expected I4, but got O
		//IL_0247: Expected O, but got I4
		//IL_024d: Expected I4, but got O
		//IL_0274: Expected O, but got I4
		//IL_028a: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got I4
		//IL_02c4: Expected O, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got I4
		//IL_032f: Expected O, but got I4
		//IL_0346: Expected O, but got I8
		//IL_037a: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Ref, but got Unknown
		//IL_03ac: Expected O, but got I4
		//IL_03c5: Expected O, but got I4
		//IL_03e6: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_03fb: Expected I4, but got O
		//IL_03fc: Expected O, but got I8
		//IL_0406: Expected O, but got I4
		//IL_0415: Expected I4, but got O
		//IL_0432: Expected O, but got I4
		//IL_049a: Expected O, but got I4
		//IL_04a4: Expected O, but got I8
		//IL_04ae: Expected O, but got I4
		//IL_04ce: Expected O, but got I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected I4, but got Unknown
		//IL_04d9: Expected O, but got I4
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected I4, but got Unknown
		//IL_0524: Expected O, but got I4
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected I4, but got Unknown
		//IL_0533: Expected O, but got I4
		//IL_0549: Expected O, but got I4
		//IL_0553: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_05c4: Expected O, but got I4
		//IL_05cd: Expected I4, but got O
		//IL_05ce: Expected O, but got I4
		NumberStyles numberStyles = default(NumberStyles);
		BindingFlags bindingFlags = bindingFlags;
		BindingFlags bindingFlags_ = bindingFlags;
		object obj = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		obj = obj2;
		Type[] type_ = ((long*)(-2065919448L))->CompareTo(obj) as Type[];
		ParameterModifier[] array = array;
		uint num;
		object obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b);
		checked
		{
			num = unchecked(checked(26u * unchecked((uint)(sbyte)Class0.smethod_1(bindingFlags_, null, type_, array))) / (uint)b) + unchecked((uint)b);
			obj3 = GClass0.Main();
		}
		uint num2 = (uint)(int)(((obj3 is uint) ? obj3 : null) / num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num3);
		num2 = num3;
		uint num4 = num2;
		Class2 obj4 = ((short*)(short)Class0.smethod_1(bindingFlags, null, null, array))->GetTypeCode() as Class2;
		object object_ = obj;
		byte b2 = b2;
		Type type = ((byte*)b2)->CompareTo(null) as Type;
		ref _003F reference = ref *(_003F*)num;
		ref _003F reference2 = ref *(_003F*)num4;
		object obj5 = ((ushort*)(ushort)obj4.method_0(object_, type, char.IsHighSurrogate("RTTVQT", (int)/*isinst with value type is only supported in some contexts*/) as CultureInfo))->Equals(7991);
		object obj6 = System.Runtime.CompilerServices.Unsafe.As<_003F, sbyte>(ref reference).Equals(System.Runtime.CompilerServices.Unsafe.As<_003F, uint>(ref reference2).Equals((uint)(int)((obj5 is uint) ? obj5 : null)) as object);
		numberStyles = (NumberStyles)((obj6 is NumberStyles) ? obj6 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
		numberStyles = numberStyles2;
		NumberStyles style = numberStyles;
		IFormatProvider formatProvider = formatProvider;
		object obj7 = int.TryParse("TOVEF", style, formatProvider, out *(int*)null);
		object obj8 = ((ulong*)((obj7 is ulong) ? obj7 : null))->GetHashCode();
		b = (sbyte)(int)((obj8 is sbyte) ? obj8 : null);
		BindingFlags bindingFlags_2 = (BindingFlags)((sbyte*)b)->ToString("CXFFPCKZ");
		MethodBase[] array2 = ((short*)(-21932))->CompareTo(null) as MethodBase[];
		MethodBase[] methodBase_ = array2;
		array = ((uint*)num2)->GetTypeCode() as ParameterModifier[];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		_ = (_003CPrivateImplementationDetails_003E)(object)Class2.smethod_3(bindingFlags_2, methodBase_, type_, parameterModifier_);
		string text = ((uint*)num2)->ToString((IFormatProvider?)null);
		_ = short.TryParse(text, out *(short*)null) is Struct2;
		object obj9 = ((uint*)1643315427)->GetTypeCode();
		object obj10 = ((obj9 is bool) ? obj9 : null);
		text = text;
		int num5 = -1933570209;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
		_ = (Struct3)((bool*)(1 / checked(obj10 - char.IsControl(s, 326220763))))->ToString(formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num7);
		byte[] array3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte reference4);
		Settings settings;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		while (true)
		{
			object obj11 = ((bool*)null)->GetTypeCode();
			object obj12 = ((obj11 is bool) ? obj11 : null);
			_ = (Settings)(object)"GG".Trim(null);
			short num6 = -19623;
			object obj13 = GClass0.Main();
			ref _003F reference3 = ref *(_003F*)((obj13 is uint) ? obj13 : null);
			object obj14 = char.ConvertToUtf32(text, num5);
			object obj15 = System.Runtime.CompilerServices.Unsafe.As<_003F, uint>(ref reference3).Equals((uint)(int)((obj14 is uint) ? obj14 : null));
			num6 = (short)(int)((obj15 is short) ? obj15 : null);
			uint num8;
			byte[] byte_;
			checked
			{
				num8 = 4294947673u * (unchecked((uint)num7) + 4294951841u);
				array3 = null;
				byte_ = array3;
				array3 = array3;
			}
			string s2 = ((short*)checked(num8 * unchecked((uint)(short)smethod_4(byte_, byte_2))))->CompareTo(num6) as string;
			NumberStyles style2 = numberStyles;
			formatProvider = null;
			reference4 = ref reference4;
			settings = sbyte.TryParse(s2, style2, provider, out reference4) as Settings;
			object obj16 = settings.Times;
			if (0 / checked(obj12 + ((obj16 is bool) ? obj16 : null)) == 0)
			{
				break;
			}
			object obj20;
			do
			{
				BindingFlags bindingFlags_3 = bindingFlags;
				array2 = array2;
				object obj17 = ((Settings)(object)((uint*)num2)->ToString(text)).Value;
				_ = (byte)Class2.smethod_3(bindingFlags_3, methodBase_2, type_, (ParameterModifier[])(object)((byte*)((obj17 is byte) ? obj17 : null))->ToString((IFormatProvider?)null));
				string s3 = text;
				uint num9 = num2;
				text = text;
				object obj18 = uint.Parse(s3, (IFormatProvider)(object)((uint*)num9)->ToString(text2, formatProvider));
				object obj19 = uint.Parse(((int*)((int*)((obj18 is int) ? obj18 : null))->GetHashCode())->GetHashCode() as string);
				obj20 = ((obj19 is bool) ? obj19 : null);
				flag = (byte)(int)obj20 != 0;
			}
			while (obj20 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num10);
		try
		{
			try
			{
				object obj22;
				object obj23;
				do
				{
					_ = (Resources)(object)smethod_4(null, null);
					object obj21 = GClass0.Main();
					obj22 = ((obj21 is bool) ? obj21 : null);
					obj23 = GClass0.Main();
				}
				while (checked(obj22 - (1 + ((obj23 is bool) ? obj23 : null))) != 0);
			}
			finally
			{
				goto end_IL_02a4;
			}
			end_IL_02a4:;
		}
		finally
		{
			try
			{
				num10 = 21667;
				num10 = 22140;
			}
			catch
			{
				_ = GClass0.Main() is Struct3;
			}
			goto IL_02f3;
		}
		IL_02f3:
		try
		{
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		while (true)
		{
			resolveEventArgs = resolveEventArgs;
			if (!((byte)Class0.smethod_0(null, resolveEventArgs) != 0))
			{
				break;
			}
			try
			{
			}
			finally
			{
				continue;
			}
		}
		_ = (Class1)(object)string.Concat<T>((IEnumerable<T>)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions);
		bool num12;
		string strA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj32);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num18);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison2);
		object obj38;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		do
		{
			Class2 @class = settings.Times as Class2;
			@class = class2;
			Class2 class3 = @class;
			object object_2 = ulong.Parse("QH") as object;
			type = type;
			CultureInfo cultureInfo_ = null;
			bool num11 = ((ushort*)checked(62083u - unchecked((uint)(ushort)class3.method_0(object_2, type_2, cultureInfo_))))->Equals(num10);
			string s4 = text;
			numberStyles = default(NumberStyles);
			object obj26 = (num11 ? ((bool*)1) : ((bool*)null))->CompareTo(uint.Parse(s4, numberStyles, formatProvider) as object);
			_003CPrivateImplementationDetails_003E obj27 = (_003CPrivateImplementationDetails_003E)(object)((byte*)checked(99 + (((obj26 is byte) ? obj26 : null) + b2)))->ToString(text);
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			_003CPrivateImplementationDetails_003E = obj27;
			string obj28 = ((int*)checked(1823617873u + unchecked((uint)num5)))->GetTypeCode() as string;
			array4 = array4;
			char[] separator = array4;
			obj = null;
			text = ((ushort*)10242)->CompareTo(value) as string;
			text = text3;
			text = text4;
			text = text5;
			object obj29 = long.Parse(((ushort*)16906)->CompareTo(num10) as string, (NumberStyles)/*isinst with value type is only supported in some contexts*/);
			object obj30 = bool.TryParse(value2, out *(bool*)((obj29 is ref bool) ? obj29 : null));
			object obj31 = ((obj30 is int) ? obj30 : null);
			stringSplitOptions = stringSplitOptions;
			num12 = (byte)obj28.Split(separator, (int)obj31, stringSplitOptions) != 0;
			strA = text;
			string s5 = text;
			numberStyles = numberStyles;
			_ = byte.Parse(s5, style3) is uint;
			bool num13 = flag;
			obj = obj;
			obj = obj32;
			BindingFlags bindingFlags_4 = (BindingFlags)((Class2)null).method_0(object_3, type, (CultureInfo)(object)((ushort*)37360)->ToString(formatProvider));
			array = array;
			array = array5;
			array = array6;
			array = null;
			numberStyles = (NumberStyles)Class2.smethod_3(bindingFlags_4, null, type_, parameterModifier_2);
			byte[] byte_3 = array3;
			array3 = null;
			object obj33 = (num13 ? ((bool*)1) : ((bool*)null))->CompareTo(ulong.Parse("AHVC", style4, ((uint*)(uint)smethod_4(byte_3, byte_4))->GetHashCode() as IFormatProvider) as object);
			object obj34 = ((obj33 is uint) ? obj33 : null);
			num10 = 55397;
			object obj35 = ((ushort*)65028)->Equals((ushort)checked(num14 - /*isinst with value type is only supported in some contexts*/));
			num2 = (uint)checked(obj34 * (2088384653 - ((obj35 is uint) ? obj35 : null) + 662137390));
			num2 = 1099396786u;
			uint num16 = 1708666902u / num15;
			uint num17;
			checked
			{
				num17 = 1865112215u - unchecked((uint)smethod_4(array3, null)) - 1099396786u;
				num18 = num18;
			}
			ref _003F reference5 = ref *(_003F*)num19;
			object obj36 = ((ulong*)num18)->Equals(null);
			string s6 = System.Runtime.CompilerServices.Unsafe.As<_003F, uint>(ref reference5).CompareTo((uint)(int)checked(num16 - (num17 + 1099396786 * ((obj36 is uint) ? obj36 : null)) + 0)) as string;
			NumberStyles style5 = numberStyles;
			object obj37 = ((byte*)b2)->Equals((byte)checked(unchecked((uint)b2) - 234u));
			text = int.TryParse(s6, style5, null, out *(int*)((obj37 is ref int) ? obj37 : null)) as string;
			uint startIndex;
			checked
			{
				uint num20 = unchecked((uint)num5) + unchecked((uint)(int)smethod_4(array3, (byte[])(object)Settings.Default));
				bindingFlags = bindingFlags;
				array2 = array2;
				startIndex = num20 + unchecked((uint)(int)Class0.smethod_1(bindingFlags_5, methodBase_3, type_, array));
				stringComparison = stringComparison;
				stringComparison = stringComparison2;
				stringComparison = default(StringComparison);
			}
			obj38 = ((short*)(4294951737u / (uint)(short)(text6.IndexOf("OGRRNA", (int)startIndex, stringComparison) as Class2).method_0(obj, type, cultureInfo_)))->GetTypeCode();
		}
		while (checked((num12 ? 1u : 0u) + ((unchecked((byte)Class0.smethod_0(string.Compare(strA, "VGMNNGZKB", (byte)(int)((obj38 is bool) ? obj38 : null) != 0) as object, resolveEventArgs)) != 0) ? 1u : 0u)) != 0);
	}
}
