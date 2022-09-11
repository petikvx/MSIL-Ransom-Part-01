using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
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
	public static void Main()
	{
		smethod_1();
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

	unsafe static void acoyep1()
	{
		//IL_0024: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Ref, but got Unknown
		//IL_0141: Expected O, but got I4
		//IL_014a: Expected I4, but got O
		//IL_014b: Expected O, but got I4
		//IL_0180: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_02b2: Expected O, but got I4
		//IL_02be: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_02e6: Expected O, but got I4
		//IL_0341: Expected O, but got I4
		//IL_034d: Expected O, but got I4
		//IL_036e: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected I4, but got Unknown
		//IL_0418: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_0456: Expected O, but got I4
		//IL_0478: Expected O, but got I4
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected I4, but got Unknown
		//IL_04b9: Expected O, but got I4
		//IL_04d8: Expected O, but got I4
		//IL_0506: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_0521: Expected O, but got I4
		//IL_052a: Expected I4, but got O
		//IL_052a: Expected I4, but got O
		//IL_052b: Expected O, but got I4
		//IL_0541: Expected O, but got I4
		//IL_0556: Expected O, but got I4
		//IL_056b: Expected O, but got I4
		//IL_05d2: Expected O, but got I4
		//IL_05fc: Expected O, but got I4
		//IL_0639: Expected O, but got I4
		//IL_065d: Expected O, but got I4
		//IL_0692: Expected O, but got I4
		//IL_06c0: Expected O, but got I4
		//IL_06e0: Expected O, but got I4
		//IL_06ea: Expected O, but got I4
		//IL_0756: Expected O, but got I4
		//IL_0774: Expected O, but got I4
		//IL_077d: Expected I4, but got O
		//IL_077e: Expected O, but got I4
		//IL_0790: Expected O, but got I4
		//IL_079c: Expected O, but got I4
		//IL_07aa: Expected O, but got I4
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected I4, but got Unknown
		//IL_07ba: Expected O, but got I4
		//IL_083f: Expected O, but got I4
		//IL_084e: Expected O, but got I4
		//IL_0876: Expected O, but got I4
		//IL_088c: Expected O, but got I4
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected I4, but got Unknown
		//IL_089c: Expected O, but got I4
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got I4
		//IL_08c5: Expected O, but got I4
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected Ref, but got Unknown
		//IL_08d7: Expected O, but got I4
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Ref, but got Unknown
		//IL_08fd: Expected O, but got I4
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected I4, but got Unknown
		//IL_0919: Expected O, but got I4
		//IL_0928: Expected I4, but got O
		//IL_0929: Expected O, but got I4
		//IL_0934: Expected I4, but got O
		//IL_0935: Expected O, but got I4
		//IL_094d: Expected O, but got I4
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got I4
		//IL_09e4: Expected O, but got I4
		//IL_09ed: Expected I4, but got O
		//IL_0a0a: Expected O, but got I4
		//IL_0a21: Expected I4, but got Unknown
		//IL_0a22: Expected O, but got I4
		//IL_0a2e: Expected O, but got I4
		Struct2 @struct = default(Struct2);
		Struct2 struct2 = default(Struct2);
		byte b = (byte)Settings.Default;
		object obj = ((byte*)b)->GetTypeCode();
		@struct = (Struct2)((obj is Struct2) ? obj : null);
		@struct = @struct;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		NumberStyles numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			text = text;
			text = string.Concat((string[])(object)string.Concat((string?[])null).Normalize());
			resolveEventArgs = resolveEventArgs;
			array = Class1.smethod_3(resolveEventArgs) as byte[];
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
			array = array2;
			StringComparison stringComparison = (StringComparison)Class1.smethod_4(array, null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison2);
			stringComparison = stringComparison2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string a);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string b2);
			text = string.Equals(a, b2, stringComparison) as string;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
			text = text2;
			bindingFlags = default(BindingFlags);
			bindingFlags = default(BindingFlags);
			bindingFlags = bindingFlags;
			bindingFlags = default(BindingFlags);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_ = bindingFlags;
			array3 = null;
			BindingFlags bindingFlags_2 = bindingFlags;
			MethodBase[] methodBase_ = array3;
			array4 = null;
			text = (string)(object)Class2.smethod_3(bindingFlags_2, methodBase_, array4, null);
			uint length;
			CultureInfo culture;
			object obj2;
			checked
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
				uint num = unchecked((uint)(int)text3.ToLower(null)) - 499855111u;
				num2 = num2;
				length = unchecked(num / checked(300694661u * unchecked((uint)num2))) + unchecked((uint)((byte*)192)->GetHashCode());
				CultureInfo cultureInfo = (text == "WBCGCO") as CultureInfo;
				cultureInfo = cultureInfo;
				culture = cultureInfo;
				obj2 = Class1.smethod_3(null);
			}
			_003F val = checked(((obj2 is byte) ? obj2 : null) - 113) / 6;
			obj3 = obj3;
			object obj4 = ((byte*)val)->CompareTo(obj3);
			array3 = string.Compare("WTENT", -935515169, "OBWZGQYM", 334782523, (int)length, culture, (CompareOptions)((obj4 is CompareOptions) ? obj4 : null)) as MethodBase[];
			MethodBase[] methodBase_2 = array3;
			Type[] type_ = array4;
			array5 = array5;
			string s = (string)(object)Class2.smethod_3(bindingFlags_, methodBase_2, type_, array5);
			formatProvider = formatProvider;
			text = byte.Parse(s, (IFormatProvider)(object)((byte*)194)->ToString(formatProvider)) as string;
			_ = (byte)((byte*)186)->ToString(text);
		}
		catch
		{
			try
			{
				byte num3 = b;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
				b = (byte)((byte*)num3)->ToString(text4);
			}
			catch
			{
				try
				{
					resources = resources;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources2);
					resources = resources2;
					resources = resources;
					goto end_IL_01a6;
				}
				finally
				{
					string s2 = text;
					numberStyles = default(NumberStyles);
					_ = byte.Parse(s2, default(NumberStyles)) is string;
					goto end_IL_01a6;
				}
				end_IL_01a6:;
			}
		}
		string s3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_);
		ref byte result;
		do
		{
			s3 = text;
			obj3 = null;
			obj3 = obj7;
			_ = ref *(byte*)Class0.smethod_0(object_, null);
			result = ref *(byte*)null;
		}
		while (checked((byte.TryParse(s3, out result) ? 1u : 0u) - 1u) != 0);
		_ = ((byte*)checked((unchecked((uint)b) + 202u) * b))->CompareTo(obj3) is Settings;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct3 struct3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out void @void);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		try
		{
			try
			{
				while (true)
				{
					_ = byte.Parse("GJ") is _003CPrivateImplementationDetails_003E;
					flag = true;
				}
			}
			finally
			{
				try
				{
					struct3 = default(Struct3);
					struct3 = struct3;
					struct3 = struct3;
					byte num4 = b;
					BindingFlags bindingFlags_3 = bindingFlags;
					array4 = array4;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_2);
					b = (byte)Class0.smethod_1(bindingFlags_3, null, type_2, array5);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte value);
					IEnumerable<_0021_00210> enumerable = ((byte*)num4)->CompareTo(value) as IEnumerable<_0021_00210>;
					string.Concat<T>((IEnumerable<T>)enumerable);
					text = "XKSA";
				}
				finally
				{
					@void = @void;
					@void = @void;
					bindingFlags = default(BindingFlags);
					numberStyles = (NumberStyles)Class2.smethod_3(bindingFlags, null, array4, null);
					_ = ("KQWBDLL" == byte.Parse(byte.Parse("J", default(NumberStyles), formatProvider) as string, formatProvider) as string) is Struct3;
					goto end_IL_0217;
				}
			}
			end_IL_0217:;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_3);
			while (true)
			{
				_ = (string)(object)Class0.smethod_0(obj3, ((byte*)32)->ToString().IsNormalized() as ResolveEventArgs);
				MethodBase[] methodBase_3 = array3;
				array4 = array4;
				if ((byte)Class2.smethod_3(default(BindingFlags), methodBase_3, type_3, array5) != 0)
				{
				}
			}
		}
		BindingFlags bindingFlags_4 = bindingFlags;
		Type type_4 = null;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_5 = bindingFlags;
		string text5 = text;
		object obj9 = byte.TryParse(byte.Parse("PDLFCYSXE") as string, out result);
		object obj10 = ((obj9 is int) ? obj9 : null);
		string obj11 = text.StartsWith(string.Join("KJBWCAPPQ", (string?[])null), default(StringComparison)) as string;
		string value2 = text;
		num2 = (int)checked(4132137188u - 3348657986u * 3012399019u - 3570789916u);
		Settings settings = settings;
		int value3 = settings.Value;
		BindingFlags bindingFlags_6 = bindingFlags;
		array4 = null;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_5);
			uint num5 = unchecked((uint)value3) + (3967608684u + unchecked((uint)(int)Class2.smethod_3(bindingFlags_6, null, type_5, null)));
			uint num6 = 176u + unchecked((uint)b) + b;
			Class2 @class = @class;
			Class2 class2 = @class;
			Type type_6 = (Type)(object)unchecked((byte*)128)->ToString((IFormatProvider?)null);
			CultureInfo cultureInfo = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
			num2 = obj10 + unchecked((int)Class0.smethod_0(null, obj11.IndexOf(value2, startIndex, (int)checked(num5 - unchecked((uint)(int)((byte*)num6)->ToString((string)class2.method_0(null, type_6, cultureInfo_))))) as ResolveEventArgs));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		MethodBase[] methodBase_4 = text5.IndexOfAny(null, -1535292441, (int)checked(unchecked((uint)num7) * 2012546101u + 2488520805u)) as MethodBase[];
		array4 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_7);
		char[] separator = (char[])(object)Class1.smethod_2(bindingFlags_4, null, type_4, (Type[])(object)Class2.smethod_3(bindingFlags_5, methodBase_4, type_7, ((byte*)b)->Equals(b) as ParameterModifier[]), array5);
		byte[] byte_ = array;
		array = ((byte*)101)->GetTypeCode() as byte[];
		uint num8;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
			num8 = 220105526u - unchecked((uint)(int)Class1.smethod_4(byte_, byte_2));
		}
		object obj12 = byte.TryParse("CLWN", numberStyles, null, out *(byte*)null);
		GClass0 gClass = (GClass0)(object)"ZHN".Split(separator, (int)checked((num8 + ((obj12 is int) ? obj12 : null) - num2) * num2));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		gClass = gClass2;
		gClass = gClass;
		text = ((byte*)b)->ToString(text, formatProvider);
		try
		{
			settings = settings;
		}
		finally
		{
			BindingFlags bindingFlags_7;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int count2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object value5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
			do
			{
				bindingFlags_7 = (BindingFlags)Class0.smethod_0(((byte*)62)->GetTypeCode() as object, resolveEventArgs);
				char[] anyOf = settings.Value as char[];
				string a2 = (string)"NNXG".Clone();
				string text6 = text;
				settings = settings;
				string value4 = settings2.Times as string;
				int startIndex2 = num2;
				int count = (int)/*isinst with value type is only supported in some contexts*/;
				object obj13 = settings.Value;
				num2 = (int)checked(3863471195u - unchecked((uint)(string.Equals(a2, text6.LastIndexOf(value4, startIndex2, count, (StringComparison)((obj13 is StringComparison) ? obj13 : null)) as string, (StringComparison)text.TrimStart(null)) as string).IndexOf(text)));
				_ = "UHNLEITOE".IndexOfAny(anyOf, 1672982860, count2) is ParameterModifier[];
				obj3 = obj3;
				_ = ((byte*)136)->CompareTo(value5) is ParameterModifier[];
				array5 = null;
				array5 = array6;
			}
			while ((byte)Class0.smethod_0(Class0.smethod_1(bindingFlags_7, null, null, parameterModifier_), resolveEventArgs) != 0);
			goto IL_0597;
		}
		IL_06b9:
		_ = ((Settings)null).Times is Class3;
		Class3 class3 = null;
		class3 = class3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out void void2);
		do
		{
			@void = @void;
			@void = void2;
		}
		while ((byte.Parse("VRTMGOGMT", null) as string).GetHashCode() is bool);
		while (flag)
		{
			try
			{
				struct3 = struct3;
			}
			catch
			{
				@void = default(void);
			}
		}
		bool num9 = flag;
		flag = false;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
			uint num10 = 0u - (num9 ? 1u : 0u) * (flag2 ? 1u : 0u);
			flag = true;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj24);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] args);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj33);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj34);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int count4);
			if (num10 + (flag3 ? 1u : 0u) != 0)
			{
				while (true)
				{
					_ = (Struct2)Class0.smethod_1(default(BindingFlags), null, array4, array5);
					@struct = @struct;
					resources = resources;
					uint num11 = unchecked((uint)(byte)string.Concat(((byte*)checked(b * unchecked((byte)((byte*)b)->ToString())))->Equals(obj3) as IEnumerable<string>)) + unchecked((uint)checked(b * b));
					object obj15 = ((Settings)null).Times;
					string format;
					object arg;
					unchecked
					{
						text = "SZHR".IsNormalized((NormalizationForm)((obj15 is NormalizationForm) ? obj15 : null)) as string;
						string s4 = string.Compare(strA, "VVTANHYGH") as string;
						object obj16 = settings.Value;
						result = ref *(byte*)((obj16 is ref byte) ? obj16 : null);
						ref _003F reference = ref *(_003F*)num11;
						object obj17 = byte.TryParse(s4, out result2);
						_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).Equals((byte)checked(((obj17 is byte) ? obj17 : null) - 237)) is string;
						format = text;
						arg = obj3;
						obj3 = obj3;
					}
					uint num12 = unchecked(177u / (uint)(byte)string.Format(format, arg, arg2)) * 195u;
					string obj18;
					int num13;
					string s5;
					string s6;
					object obj20;
					unchecked
					{
						BindingFlags bindingFlags_8 = (BindingFlags)Settings.Default;
						PropertyInfo[] propertyInfo_ = null;
						bindingFlags = (BindingFlags)((byte*)num12)->ToString("FLVUG", (IFormatProvider)Class1.smethod_2(bindingFlags_8, propertyInfo_, null, null, array5));
						bindingFlags = bindingFlags2;
						obj18 = (byte.Parse("ZCL", (NumberStyles)Class0.smethod_1(default(BindingFlags), null, null, null), (IFormatProvider)Class0.smethod_0(null, resolveEventArgs)) as string).StartsWith("QPTDLB") as string;
						num13 = num2;
						s5 = text;
						s6 = text;
						text = string.Equals("YAN", text, default(StringComparison)) as string;
						byte num14 = b;
						byte num15 = b;
						object obj19 = ((byte*)b)->Equals(null);
						b = (byte)(num14 / (num15 / ((obj19 is byte) ? obj19 : null)));
						obj20 = ((byte*)b)->GetHashCode();
					}
					_003F val2 = b3 * ((obj20 is byte) ? obj20 : null);
					byte num16 = b;
					object obj21 = byte.TryParse("P", numberStyles, formatProvider, out result);
					object obj22 = ((obj21 is byte) ? obj21 : null);
					object obj23 = byte.TryParse(text, out result);
					_003F val3 = obj22 * (178 - ((obj23 is byte) ? obj23 : null));
					obj3 = obj3;
					int num17;
					object obj26;
					unchecked
					{
						object obj25 = ((byte*)val3)->Equals(obj24);
						num17 = ((byte*)checked(unchecked(val2 / checked(num16 - ((obj25 is byte) ? obj25 : null))) * unchecked((byte)Settings.Default)))->CompareTo(253);
						obj26 = "BMQHZGY".GetTypeCode();
					}
					_003F val4 = unchecked(num17 / ((obj26 is int) ? obj26 : null)) - num2;
					StringComparison stringComparison = default(StringComparison);
					object obj31;
					unchecked
					{
						object obj27 = text7.IndexOf("UBCW", (int)val4, comparisonType);
						object obj28 = ((obj27 is NumberStyles) ? obj27 : null);
						formatProvider = formatProvider;
						object obj29 = byte.Parse(s6, (NumberStyles)obj28, provider);
						object obj30 = byte.Parse(s5, (NumberStyles)((obj29 is NumberStyles) ? obj29 : null), formatProvider);
						obj31 = ((obj30 is int) ? obj30 : null);
						text = ((byte*)b)->Equals(obj3) as string;
					}
					_003F val5 = num13 * (obj31 - unchecked((int)("SKMRR" + string.Format(null, ((byte*)98)->ToString(text8, null), args) + (string)text.Clone() + text)));
					unchecked
					{
						string s7 = (string)(object)Class2.smethod_3((BindingFlags)Class1.smethod_4(array, array), null, array4, array5);
						NumberStyles style = numberStyles;
						obj3 = obj3;
						object obj32 = obj3;
						obj3 = obj3;
						text = byte.TryParse(s7, style, (IFormatProvider)(object)string.Concat(obj33, obj32, obj34), out result) as string;
						string text9 = text;
						text = text;
						int count3 = "QEWEK".IndexOfAny(null);
						stringComparison = default(StringComparison);
						object obj35 = text9.LastIndexOf(value6, 1174210131, count3, stringComparison);
						num2 = (int)((byte*)(byte)text10.Normalize((NormalizationForm)((obj35 is NormalizationForm) ? obj35 : null)))->ToString(((byte*)142)->Equals(string.Format(text, obj3)) as string);
						(obj18.StartsWith("UPQXQP".LastIndexOf('剎', (int)val5, count4) as string, stringComparison) as string).ToUpper((CultureInfo)(object)"DKQHQ".TrimEnd(null));
					}
				}
			}
			return;
		}
		IL_0597:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions);
		do
		{
			stringSplitOptions = stringSplitOptions;
			_ = (Class3)(object)"PBCU".Split((char[]?)null, -773709203, stringSplitOptions);
		}
		while (checked(1u * ((flag ? 1u : 0u) * 0u)) != 0);
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class4);
				while (true)
				{
					Class2 @class = null;
					if ((byte)class4.method_0(((Settings)null).Value as object, null, "GS".Equals((string)(object)Class2.smethod_3(default(BindingFlags), array3, array4, array5)) as CultureInfo) != 0)
					{
						_003CModule_003E _003CModule_003E = null;
						_003CModule_003E = _003CModule_003E;
						continue;
					}
					break;
				}
			}
			finally
			{
				goto end_IL_05bb;
			}
			end_IL_05bb:;
		}
		catch
		{
		}
		@struct = @struct;
		try
		{
			IEnumerable<string> values;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string separator2);
			do
			{
				settings = (Settings)(object)Class0.smethod_0(obj3, resolveEventArgs);
				text = text;
				values = byte.Parse("SXY", numberStyles) as IEnumerable<string>;
			}
			while ((byte)string.Join(separator2, values) != 0);
		}
		finally
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexA);
				while (true)
				{
					Class1 class5 = byte.TryParse("TABOCOH", out *(byte*)null) as Class1;
					class5 = class5;
					_ = Settings.Default;
					byte num18 = b;
					num2 = -831291191;
					_ = (_003CPrivateImplementationDetails_003E)(object)((byte*)num18)->ToString(string.Compare("GTJQEME", indexA, "N", -1014731645, -831291191, ignoreCase: false) as string);
				}
			}
			catch
			{
				try
				{
					b = (byte)checked(unchecked((uint)b) + 193u);
				}
				catch
				{
					resources = resources;
				}
			}
			goto IL_06b9;
		}
	}
}
