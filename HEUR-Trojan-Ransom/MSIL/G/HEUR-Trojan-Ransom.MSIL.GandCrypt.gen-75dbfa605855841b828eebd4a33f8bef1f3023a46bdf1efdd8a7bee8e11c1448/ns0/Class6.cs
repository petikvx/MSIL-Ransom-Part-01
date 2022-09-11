using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal sealed class Class6
{
	public static void smethod_0(AppDomain appDomain_0)
	{
		string fullName = typeof(Class1).FullName;
		appDomain_0.CreateInstance(fullName, "");
	}

	unsafe static void evupakoz2()
	{
		//IL_0014: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Ref, but got Unknown
		//IL_00b7: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Ref, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_013f: Expected I4, but got O
		//IL_015b: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		//IL_019f: Expected I4, but got O
		//IL_01c6: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0224: Expected I4, but got O
		//IL_0225: Expected O, but got I4
		//IL_0254: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0327: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_0395: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		//IL_03c5: Expected O, but got I4
		//IL_03d1: Expected O, but got I4
		//IL_03e1: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_0418: Expected I4, but got O
		//IL_0419: Expected O, but got I4
		//IL_0423: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_04d3: Expected I4, but got O
		//IL_04d4: Expected O, but got I4
		//IL_04de: Expected O, but got I4
		//IL_04ea: Expected O, but got I4
		//IL_0504: Expected O, but got I4
		//IL_050f: Expected O, but got I4
		//IL_051f: Expected O, but got I4
		//IL_0525: Expected I4, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		bool flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		while (true)
		{
			string text2 = text;
			string value = "ESYVEAHTD".CompareTo((string)(object)Settings.Default) as string;
			int startIndex = (int)string.Join("EABYDOVDX", (string?[])null);
			StringComparison stringComparison = default(StringComparison);
			stringComparison = stringComparison2;
			object obj = text2.LastIndexOf(value, startIndex, -136261189, default(StringComparison));
			object obj2 = ((obj is bool) ? obj : null);
			flag = (byte)(int)obj2 != 0;
			if (obj2 == null)
			{
				break;
			}
			text = text;
			text = text3;
			string s = text;
			formatProvider = formatProvider;
			object obj3 = byte.Parse(s, formatProvider);
			object obj4 = ((obj3 is BindingFlags) ? obj3 : null);
			BindingFlags bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_ = bindingFlags;
			text = "DVXG";
			text = text4;
			numberStyles = default(NumberStyles);
			object obj5 = byte.TryParse(s2, numberStyles, formatProvider, out *(byte*)null);
			object obj6 = ((obj5 is byte) ? obj5 : null);
			string obj7 = string.Compare(text, string.Copy(text), ignoreCase: false) as string;
			obj8 = obj8;
			obj8 = obj9;
			_ = (byte)((byte*)checked(b * unchecked((byte)Settings.Default)))->ToString(text, ((byte*)(byte)Settings.Default)->GetHashCode() as IFormatProvider);
			b = b;
			object obj10 = ((byte*)b)->Equals(233);
			obj8 = ((byte*)checked(((obj10 is byte) ? obj10 : null) - b))->GetHashCode() as object;
			obj8 = obj7.CompareTo(value2) as object;
			text = ((byte*)159)->Equals(obj8) as string;
			text = text5;
			text = "GB";
			MethodBase[] methodBase_ = (MethodBase[])(object)((byte*)checked(obj6 * unchecked((byte)text6.ToCharArray() / b)))->ToString(text);
			Type[] type_ = array;
			array2 = array2;
			array2 = array3;
			array = (Type[])(object)Class10.smethod_0(bindingFlags_, methodBase_, type_, array2);
			Type[] type_2 = array;
			BindingFlags bindingFlags_2 = bindingFlags;
			MethodBase[] methodBase_2 = null;
			_ = (Class8)(object)Class10.smethod_0((BindingFlags)obj4, null, type_2, (ParameterModifier[])(object)Class10.smethod_0(bindingFlags_2, methodBase_2, (((byte*)b)->ToString() == text) as Type[], array2));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array5);
		try
		{
			string text7 = text;
			uint ignoreCase = 1u / (flag ? 1u : 0u);
			string text8 = text;
			StringSplitOptions stringSplitOptions = stringSplitOptions;
			_ = text7.EndsWith("VFDVWFTH", (byte)ignoreCase != 0, (CultureInfo)(object)text8.Split((char[]?)null, stringSplitOptions)) is object;
			object obj11 = Settings.Default;
			obj8 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj12);
			string text9 = string.Concat(obj11, obj12, (object)null, (object)__arglist());
			array4 = null;
			object obj13 = text9.LastIndexOfAny(array4);
			object obj14 = ((obj13 is byte) ? obj13 : null);
			obj8 = obj8;
			ref _003F reference = ref *(_003F*)obj14;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object value3);
			string obj15 = ((byte*)135)->CompareTo(value3) as string;
			string s3 = text;
			int style = (int)/*isinst with value type is only supported in some contexts*/;
			object obj16 = byte.Parse(text);
			void @void = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).ToString(obj15, byte.TryParse(s3, (NumberStyles)style, null, out *(byte*)((obj16 is ref byte) ? obj16 : null)) as IFormatProvider);
			@void = @void;
			array5 = array5;
			_ = string.Compare("LCRYPAR", (int)Class8.smethod_1(array5, ((byte*)194)->Equals(110) as byte[]), (string)(object)Settings.Default, (int)Settings.Default, 9037388) is string;
		}
		finally
		{
			goto IL_02a2;
		}
		IL_02a2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		while (true)
		{
			flag = (byte)Class8.smethod_1(array5, null) != 0;
			if (flag2)
			{
				try
				{
					_ = text.IsNormalized() is string;
				}
				catch
				{
					text = text;
				}
			}
			else if (!flag)
			{
				break;
			}
		}
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		_ = byte.Parse("V", numberStyles) is Class6;
		_ = (Class6)(object)"UKMJGXEIR".Substring(2128754064, -296681330);
		text.TrimEnd(array4);
		text = text;
		NumberStyles style2 = numberStyles;
		b = 68;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		string obj18 = byte.Parse(s4, style2, ((byte*)b2)->CompareTo(null) as IFormatProvider) as string;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value4);
		Class6 @class = obj18.Contains(value4) as Class6;
		@class = @class;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		try
		{
			string s5 = text;
			numberStyles = default(NumberStyles);
			_ = byte.Parse(byte.TryParse(s5, numberStyles, formatProvider, out *(byte*)null) as string, null) is string;
		}
		finally
		{
			try
			{
				while (flag)
				{
					_ = (string)(object)Settings.Default;
				}
			}
			finally
			{
				try
				{
					Class11 class2 = (Class11)(object)((byte*)(byte)Settings.Default)->ToString(text);
					class2 = class2;
				}
				catch
				{
					resolveEventArgs_ = null;
					string obj19 = Class3.smethod_0(resolveEventArgs_) as string;
					string value5 = text;
					uint ignoreCase2 = checked(1u + (flag ? 1u : 0u)) / checked((flag ? 1u : 0u) + (0u - (flag ? 1u : 0u)));
					CultureInfo cultureInfo = cultureInfo;
					_ = obj19.EndsWith(value5, (byte)ignoreCase2 != 0, cultureInfo) is Class1;
				}
				goto IL_03bd;
			}
		}
		IL_03bd:
		try
		{
			_ = text.GetTypeCode() is string;
			string obj21 = Class3.smethod_0(resolveEventArgs_) as string;
			object obj22 = string.CompareOrdinal("XDBT", text);
			object s6 = ((obj22 is NumberStyles) ? obj22 : null);
			object obj23 = obj8;
			obj8 = obj8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj24);
			obj8 = obj24;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj25);
			obj8 = obj25;
			obj8 = obj8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj26);
			obj8 = obj26;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj27);
			_ = obj21.Contains(byte.Parse((string)s6, (NumberStyles)obj23, (IFormatProvider)(object)string.Concat(obj27, byte.Parse(text) as object, (object)null, (object)__arglist())) as string) is Class11;
			StringComparison stringComparison = default(StringComparison);
			_ = string.Equals("ZOBOEMAN", "CJAS", stringComparison) is _003CPrivateImplementationDetails_003E;
			Struct3 obj28 = (Struct3)((byte*)(byte)Class4.smethod_2((BindingFlags)("MDCRUKV" + "BNZ" + text), null, null, array, array2))->ToString();
			Struct3 @struct = default(Struct3);
			@struct = default(Struct3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct3 struct2);
			@struct = struct2;
			@struct = obj28;
			text = text;
			numberStyles = numberStyles;
			IFormatProvider provider = formatProvider;
			object obj29 = "VAHAQP".EndsWith("FQ", (StringComparison)/*isinst with value type is only supported in some contexts*/);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
			object obj30 = text10.LastIndexOf(byte.TryParse("X", style3, provider, out *(byte*)((obj29 is ref byte) ? obj29 : null)) as string, stringComparison);
			object obj31 = ((byte*)(byte)((byte*)((obj30 is byte) ? obj30 : null))->ToString(formatProvider))->Equals(133);
			_ = ((byte*)((obj31 is byte) ? obj31 : null))->Equals(null) is string;
		}
		catch
		{
			object obj32 = ((byte*)b)->GetHashCode();
			b = (byte)(int)((obj32 is byte) ? obj32 : null);
		}
	}
}
