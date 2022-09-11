using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns1;
using ns2;

namespace ns0;

internal sealed class Class0
{
	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class1.smethod_3(resolveEventArgs_0))
		{
			return null;
		}
		return GClass0.assembly_0;
	}

	public static MethodBase smethod_1(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
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

	internal static void smethod_2()
	{
		GClass0.assembly_0 = GClass0.appDomain_0.Load(Class1.smethod_4(Class3.smethod_0(), Class1.smethod_1("ÆÈ!`~$-.+=")));
	}

	unsafe static void ubewel6(object object_0, object object_1, object object_2)
	{
		//IL_002b: Expected O, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Ref, but got Unknown
		//IL_0038: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got I4
		//IL_00f6: Expected I4, but got O
		//IL_01bd: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_0266: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_02e4: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_030c: Expected I4, but got O
		//IL_030d: Expected O, but got I4
		//IL_0331: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_0353: Expected O, but got I4
		//IL_0373: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out void @void);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
			do
			{
				_ = Settings.Default;
				int num2 = num;
				byte num3 = (byte)string.Copy("UEJGSXJMX");
				obj = null;
				obj = obj2;
				object obj3 = ((byte*)num3)->CompareTo(obj);
				_ = ((byte*)(((obj3 is byte) ? obj3 : null) / b))->Equals(obj) is byte;
				object obj4 = ((byte*)52)->Equals(obj);
				object obj5 = ((obj4 is byte) ? obj4 : null);
				text = text;
				string text2 = text;
				text = "BOOXXP";
				checked
				{
					uint count = 3985865777u - unchecked((uint)num) * unchecked((uint)num);
					stringComparison = stringComparison;
					stringComparison = default(StringComparison);
					stringComparison = stringComparison;
					_ = obj5 - unchecked((byte)Class1.smethod_4(null, text2.IndexOf(value, 1311618550, (int)count, stringComparison) as byte[]));
				}
				b = (byte)checked(b - b);
				b = (byte)checked(unchecked((uint)b2) + 183u);
				num = (int)((uint)num2 / (uint)((byte*)checked(unchecked((uint)b) - 36u))->CompareTo((byte)Settings.Default));
				num = num4;
				object obj6 = ((Settings)(object)"FIY".Remove(num, (int)checked(1959947116u * 3432832206u))).Times;
				object obj7 = ((obj6 is BindingFlags) ? obj6 : null);
				array = array;
				array = array2;
				PropertyInfo[] propertyInfo_ = array;
				type = type;
				Type type_ = type;
				array3 = null;
				@void = Class1.smethod_2((BindingFlags)obj7, propertyInfo_, type_, array3, null);
				@void = default(void);
				@void = @void;
				text = text;
			}
			while (0u / (((byte)string.Format(text3.Remove((int)checked(2809676838u + (811420488u - unchecked((uint)num)))), null) != 0) ? 1u : 0u) != 0);
		}
		finally
		{
			byte num5 = (byte)@class.method_0(obj, null, null);
			array4 = array4;
			byte b = (byte)checked(208u * unchecked((uint)checked(num5 - unchecked((byte)Class1.smethod_4(array4, array4)))) - 83u);
			string text = (string)(object)Settings.Default;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
			string s = ((byte*)(byte)((byte*)b3)->ToString(text4))->ToString("AQEFKPIZ");
			NumberStyles style = (NumberStyles)text.Replace('\uf685', '鸤');
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
			IFormatProvider provider = formatProvider;
			ResolveEventArgs resolveEventArgs = resolveEventArgs;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
			resolveEventArgs = resolveEventArgs2;
			object obj8 = Class1.smethod_3(resolveEventArgs);
			string s2 = byte.TryParse(s, style, provider, out *(byte*)((obj8 is ref byte) ? obj8 : null)) as string;
			uint num6;
			checked
			{
				num6 = unchecked(200u / (uint)b) + 209u;
				text = text;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s3);
			IFormatProvider provider2 = ((byte*)num6)->CompareTo(byte.Parse(s3, formatProvider) as object) as IFormatProvider;
			text = "LZHLI";
			text = text;
			ref _003F reference = ref *(_003F*)130;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
			object obj9 = text5.LastIndexOf(text, num, (int)Settings.Default);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array6);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class2);
			if ((byte)System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).ToString(byte.TryParse(s2, style, provider2, out *(byte*)((obj9 is ref byte) ? obj9 : null)) as string) != 0)
			{
				while (true)
				{
					settings = settings;
					_ = settings.Times is string;
					_ = "YSJQCXKRZ".Replace("LSKZX", "SVYLPCB").LastIndexOf("IXLNY", num, stringComparison) is _003CPrivateImplementationDetails_003E;
					_ = ((byte*)90)->Equals(obj) is _003CModule_003E;
					text = text;
					string text6 = text;
					text = "NO";
					int num7 = num;
					BindingFlags bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_ = bindingFlags;
					array5 = array5;
					array5 = array6;
					MethodBase[] methodBase_ = array5;
					Type[] type_2 = (Type[])(object)((byte*)b)->ToString();
					BindingFlags bindingFlags_2 = bindingFlags;
					MethodBase[] methodBase_2 = array5;
					Type[] type_3 = array3;
					byte num8 = b;
					BindingFlags bindingFlags_3 = bindingFlags;
					array5 = array5;
					string s4 = (string)(object)Class2.smethod_3(bindingFlags_2, methodBase_2, type_3, ((byte*)((uint)checked(num8 + unchecked((byte)smethod_1(bindingFlags_3, methodBase_3, array3, null))) / 240u))->GetHashCode() as ParameterModifier[]);
					object obj10 = ((byte*)66)->GetHashCode();
					object obj11 = ((obj10 is NumberStyles) ? obj10 : null);
					formatProvider = null;
					string value3 = (text6.LastIndexOf(value2, (int)checked(unchecked((uint)num7) - (unchecked((uint)(int)Class2.smethod_3(bindingFlags_, methodBase_, type_2, byte.TryParse(s4, (NumberStyles)obj11, formatProvider, out *(byte*)null) as ParameterModifier[])) - 4017097384u)), (int)checked(2908394018u * unchecked((uint)num) * unchecked((uint)num))) as Settings).Value as string;
					stringComparison = stringComparison;
					PropertyInfo[] propertyInfo_2 = text7.StartsWith(value3, default(StringComparison)) as PropertyInfo[];
					Type type_4 = type;
					Type[] type_5 = array3;
					string s5 = text;
					_ = byte.TryParse(text, (NumberStyles)Settings.Default, formatProvider, out result) is Class2;
					byte num9 = b;
					formatProvider = formatProvider;
					formatProvider = formatProvider;
					@class = (Class2)(object)((byte*)num9)->ToString(formatProvider2);
					@class = class2;
					Class2 class3 = @class;
					object object_3 = obj;
					cultureInfo = cultureInfo;
					result = ref *(byte*)class3.method_0(object_3, null, cultureInfo);
					b = (byte)Class1.smethod_2(default(BindingFlags), propertyInfo_2, type_4, type_5, byte.TryParse(s5, out result) as ParameterModifier[]);
				}
			}
			goto IL_03c7;
		}
		IL_03c7:
		try
		{
			byte b = 213;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array7);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_4);
			do
			{
				try
				{
					BindingFlags bindingFlags = default(BindingFlags);
					bindingFlags = bindingFlags2;
					array7 = array7;
					array7 = array8;
					_ = (byte)smethod_1(bindingFlags_4, null, null, array7);
				}
				catch
				{
					_ = (string)(object)Class1.smethod_4(array4, array4);
				}
				@class = @class;
				obj = obj;
			}
			while ((byte)class4.method_0(object_4, null, cultureInfo) != 0);
			goto IL_042a;
		}
		IL_042a:
		@void = @void;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out void void2);
		@void = void2;
	}
}
