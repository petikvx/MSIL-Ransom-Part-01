using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using ns0;

namespace ns1;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(Assembly.GetEntryAssembly()!.GetName().Name + ".Properties.Resources", typeof(Resources).Assembly);
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

	unsafe static void usudatafewoler0()
	{
		//IL_0021: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0045: Expected I4, but got O
		//IL_0050: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_016a: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected I4, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_01c1: Expected I4, but got O
		//IL_0219: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected I4, but got Unknown
		//IL_0223: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			text = text;
			string s = text;
			NumberStyles numberStyles = numberStyles;
			byte.Parse(s, numberStyles);
		}
		finally
		{
			string text2 = text;
			ResolveEventArgs resolveEventArgs = resolveEventArgs;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
			resolveEventArgs = resolveEventArgs2;
			resolveEventArgs = resolveEventArgs;
			resolveEventArgs = null;
			string obj = Class2.smethod_0(resolveEventArgs) as string;
			char c = '숮';
			object obj2 = ((byte*)162)->Equals(null);
			c = (char)(int)((obj2 is char) ? obj2 : null);
			uint num;
			object obj3;
			checked
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char c2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char c3);
				num = c2 * unchecked(13948u / (uint)c3);
				obj3 = Class2.smethod_0(null);
			}
			c = (char)(int)(num / ((obj3 is char) ? obj3 : null));
			IFormatProvider provider = obj.IndexOf(c, -1839805833) as IFormatProvider;
			string format = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
			object obj4 = byte.TryParse("ALGCHZW", out result) as object;
			object arg = obj4;
			object arg2 = obj4;
			obj4 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg3);
			_ = text2.LastIndexOfAny((char[])(object)string.Format(provider, format, arg, arg2, arg3)) is Class1;
			byte num2 = (byte)((byte*)(byte)Settings.Default)->ToString();
			IFormatProvider formatProvider = null;
			((byte*)(byte)((byte*)num2)->ToString(formatProvider))->ToString(formatProvider);
			string strA = text;
			BindingFlags bindingFlags = default(BindingFlags);
			BindingFlags num3 = bindingFlags;
			MethodBase[] array = array;
			MethodBase[] array2 = array;
			string methodBase_ = text;
			string obj5 = ((byte*)(byte)string.Join(text, (object?[])null))->GetTypeCode() as string;
			byte[] array3 = array3;
			BindingFlags bindingFlags_ = (BindingFlags)Class7.smethod_2(array3, null);
			MethodBase[] methodBase_2 = array;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
			Type[] type_ = array4;
			ParameterModifier[] array5 = array5;
			int num4 = (int)Class7.smethod_1(bindingFlags_, methodBase_2, type_, array5);
			byte b = b;
			byte startIndex = b;
			string obj6 = ((byte*)checked(unchecked((uint)b) + 117u - b))->CompareTo(null) as string;
			string obj7 = text.IsNormalized() as string;
			char[] anyOf = byte.Parse(null, (IFormatProvider)(object)string.Concat((object)null, obj4, obj4, (object)__arglist())) as char[];
			object obj8 = byte.Parse(text, null);
			int num5 = (int)checked(((obj8 is int) ? obj8 : null) - (unchecked((uint)num5) - unchecked((uint)num5) * (unchecked((uint)num5) * 1927765217u)));
			int count = ((byte*)obj6)->CompareTo(obj7.IndexOfAny(anyOf, num5) as object);
			StringComparison stringComparison = (StringComparison)Class9.smethod_2(null, resolveEventArgs);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison2);
			stringComparison = stringComparison2;
			array4 = obj5.IndexOf((string)num4, startIndex, count, default(StringComparison)) as Type[];
			byte num6 = (byte)Class7.smethod_1((BindingFlags)array2, (MethodBase[])(object)methodBase_, array4, array5);
			uint num7;
			BindingFlags bindingFlags_2;
			PropertyInfo[] propertyInfo_;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
			checked
			{
				num7 = unchecked((uint)b) * 236u;
				bindingFlags_2 = bindingFlags;
				propertyInfo_ = (PropertyInfo[])(object)Settings.Default;
				type = type;
			}
			bool num8 = ((byte*)checked(unchecked((uint)num3) - (num6 + (num7 + (10396u + unchecked((uint)(byte)Class3.smethod_2(bindingFlags_2, propertyInfo_, type, array4, null)))))))->Equals(115);
			text = "EQM".ToUpper();
			object strB = 180;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
			object obj9 = text3.LastIndexOf('\0', 839420627);
			_ = string.Compare(strA, (string?)strB, (byte)(num8 / ((obj9 is bool) ? obj9 : null)) != 0) is Class1;
			goto IL_022c;
		}
		IL_022c:
		while (true)
		{
			_ = ((byte*)89)->CompareTo(217) is Struct3;
		}
	}

	unsafe static void odejuw1()
	{
		//IL_002b: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_01af: Expected I4, but got O
		//IL_01c3: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected I4, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got I4
		//IL_0262: Expected Ref, but got Unknown
		//IL_0263: Expected O, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got I4
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Ref, but got Unknown
		//IL_036d: Expected O, but got I4
		//IL_0387: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_03b8: Expected O, but got I4
		//IL_03d3: Expected O, but got I4
		//IL_03e0: Expected I4, but got O
		//IL_03f8: Expected O, but got I4
		//IL_0425: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_0498: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04e7: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		//IL_053d: Expected I4, but got O
		//IL_0596: Expected O, but got I4
		//IL_059f: Expected I4, but got O
		//IL_05a0: Expected O, but got I4
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Ref, but got Unknown
		//IL_062a: Expected O, but got I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Ref, but got Unknown
		//IL_063a: Expected O, but got I4
		//IL_06be: Expected O, but got I4
		//IL_06ca: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
		//IL_0756: Expected O, but got I4
		//IL_0770: Expected O, but got I4
		//IL_0790: Expected O, but got I4
		//IL_0799: Expected I4, but got O
		//IL_079a: Expected O, but got I4
		//IL_07b7: Expected O, but got I4
		//IL_0863: Expected O, but got I4
		//IL_0878: Expected O, but got I4
		//IL_0884: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_08b0: Expected O, but got I4
		//IL_08b5: Expected I4, but got O
		//IL_08ee: Expected O, but got I4
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got I4
		//IL_095b: Expected O, but got I4
		//IL_09a6: Expected O, but got I4
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Ref, but got Unknown
		//IL_09b1: Expected O, but got I4
		//IL_09d1: Expected O, but got I4
		//IL_09e7: Expected O, but got I4
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Ref, but got Unknown
		//IL_09f3: Expected O, but got I4
		//IL_0a31: Expected O, but got I4
		//IL_0a3c: Expected O, but got I4
		//IL_0a62: Expected O, but got I4
		//IL_0a98: Expected O, but got I4
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got I4
		//IL_0ad8: Expected I4, but got O
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected O, but got I4
		//IL_0b56: Expected Ref, but got Unknown
		//IL_0b57: Expected O, but got I4
		//IL_0b70: Expected O, but got I4
		//IL_0b7f: Expected O, but got I4
		//IL_0b8d: Expected O, but got I4
		//IL_0b92: Expected I4, but got O
		//IL_0b9d: Expected O, but got I4
		//IL_0ba2: Expected I4, but got O
		//IL_0baa: Expected O, but got I4
		//IL_0bdc: Expected O, but got I4
		//IL_0bef: Expected O, but got I4
		//IL_0c1b: Expected O, but got I4
		//IL_0c33: Expected O, but got I4
		//IL_0c48: Expected O, but got I4
		//IL_0c8b: Expected O, but got I4
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected I4, but got Unknown
		//IL_0c95: Expected I4, but got O
		//IL_0c96: Expected O, but got I4
		//IL_0cb9: Expected O, but got I4
		//IL_0cc2: Expected I4, but got O
		//IL_0cc3: Expected O, but got I4
		//IL_0cd1: Expected I4, but got O
		//IL_0cf6: Expected O, but got I4
		//IL_0d00: Expected O, but got I4
		//IL_0d0a: Expected O, but got I4
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Expected O, but got I4
		//IL_0d68: Expected O, but got I4
		//IL_0d83: Expected O, but got I4
		//IL_0d91: Expected O, but got I4
		//IL_0d9b: Expected O, but got I4
		//IL_0da4: Expected I4, but got O
		//IL_0da4: Expected O, but got I4
		//IL_0da5: Expected O, but got I4
		//IL_0dc2: Expected I4, but got O
		//IL_0dc3: Expected O, but got I4
		//IL_0dcc: Expected I4, but got O
		//IL_0dcd: Expected O, but got I4
		//IL_0dd6: Expected I4, but got O
		//IL_0dd6: Expected I4, but got O
		//IL_0dd6: Expected O, but got I4
		//IL_0dd6: Expected I4, but got O
		//IL_0dd6: Expected O, but got Unknown
		//IL_0dd7: Expected O, but got I4
		//IL_0df4: Expected I4, but got O
		BindingFlags bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		byte num = b;
		object[] array = array;
		string s = string.Concat(array);
		NumberStyles numberStyles = default(NumberStyles);
		string text = byte.Parse(s, numberStyles, null) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		_ = (object)text2.Normalize();
		object obj = obj;
		_ = ((byte*)num)->Equals(obj) is byte;
		string s2 = text;
		NumberStyles style = numberStyles;
		IFormatProvider formatProvider = formatProvider;
		_ = byte.Parse("TGIKR", formatProvider) is ref byte;
		ref byte reference = ref reference;
		byte[] byte_ = byte.TryParse(s2, style, null, out reference) as byte[];
		byte[] array2 = array2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		array2 = array3;
		BindingFlags bindingFlags_2 = (BindingFlags)Class7.smethod_2(byte_, array2);
		string strA = text;
		string text3 = text;
		NormalizationForm normalizationForm = normalizationForm;
		normalizationForm = default(NormalizationForm);
		MethodBase[] methodBase_ = string.Compare(strA, text3.IsNormalized(normalizationForm) as string) as MethodBase[];
		Type[] type_ = (Type[])(object)((byte*)b)->ToString();
		ParameterModifier[] array4 = null;
		b = (byte)checked(unchecked((byte)Class9.smethod_0(bindingFlags_2, methodBase_, type_, array4)) * b);
		text = ((byte*)checked(37u + (unchecked((uint)b) + 175u)))->GetHashCode() as string;
		string text4 = text;
		char[] array5 = array5;
		MethodBase[] methodBase_2 = (MethodBase[])(object)text4.Trim(array5);
		Type[] array6 = null;
		Type[] type_2 = array6;
		array4 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		BindingFlags bindingFlags_3 = (BindingFlags)Class9.smethod_0(bindingFlags_, methodBase_2, type_2, parameterModifier_);
		array2 = array2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
		MethodBase[] array7 = ((string)(object)Class7.smethod_2(null, byte_2)).LastIndexOfAny(array5, -1190428655) as MethodBase[];
		MethodBase[] methodBase_3 = array7;
		Type[] type_3 = array6;
		array4 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
		_ = (Resources)(object)Class7.smethod_1(bindingFlags_3, methodBase_3, type_3, parameterModifier_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		PropertyInfo[] array8;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c3);
		int num5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		while (true)
		{
			string text5 = text;
			char num2 = c;
			_ = b / (byte)Class7.smethod_2(array2, null);
			b = (byte)(checked(109u - unchecked((uint)b) + 160u) / 133u);
			byte num3 = b;
			BindingFlags bindingFlags_4 = bindingFlags;
			resolveEventArgs = resolveEventArgs;
			resolveEventArgs = resolveEventArgs2;
			array8 = Class2.smethod_0(resolveEventArgs) as PropertyInfo[];
			PropertyInfo[] propertyInfo_ = array8;
			type = type;
			Type type_4 = type;
			Type[] type_5 = array6;
			byte num4 = b;
			text = text;
			object obj2 = Class2.smethod_0(null);
			num5 = (int)((obj2 is int) ? obj2 : null);
			int startIndex = num5;
			int num6 = num5;
			num5 = 1031923221;
			ref _003F reference2 = ref *(_003F*)num4;
			object obj3 = text6.LastIndexOf('䆐', startIndex, (int)checked(unchecked((uint)num6) * unchecked((uint)num7)));
			string s3 = (string)(object)Class7.smethod_2((byte[])(object)string.Join<T>((string)(object)Class3.smethod_2(bindingFlags_4, propertyInfo_, type_4, type_5, byte.Parse(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).CompareTo((byte)checked(((obj3 is byte) ? obj3 : null) - b)) as string, Class2.smethod_0(byte.Parse("QLO", null) as ResolveEventArgs) as IFormatProvider) as ParameterModifier[]), (IEnumerable<T>)null), (byte[])(object)"BLMASJ".PadRight(-1623373209));
			numberStyles = numberStyles;
			object obj4 = byte.TryParse(byte.Parse(s3, style2) as string, numberStyles, formatProvider, out *(byte*)null);
			_003F val = checked(((obj4 is byte) ? obj4 : null) * 47);
			text = text;
			object obj5 = ((byte*)val)->Equals(byte.TryParse(s4, out *(byte*)null) as object);
			_003F val2 = checked(num3 + ((obj5 is byte) ? obj5 : null));
			object obj6 = ((byte*)103)->GetTypeCode();
			object obj7 = ((obj6 is byte) ? obj6 : null);
			b = byte.Parse("TDUZTSI", numberStyles);
			_003F val3;
			_003F val4;
			byte num8;
			checked
			{
				val3 = 45 - (unchecked(obj7 / b2) + b * b);
				object obj8 = unchecked((byte*)174)->Equals(obj);
				val4 = ((obj8 is byte) ? obj8 : null) + b;
				num8 = b;
			}
			object obj9 = ((byte*)checked(unchecked((byte)string.Concat("DEORML".Length as IEnumerable<string>)) + b))->CompareTo(b);
			object obj10 = ((obj9 is byte) ? obj9 : null);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_5 = bindingFlags;
			array8 = array8;
			uint num12;
			checked
			{
				int num9 = num2 * unchecked((char)((byte*)(b3 / checked(val2 + unchecked(val3 / checked(val4 - (234 - unchecked(66 / (checked(num8 * (107 - obj10 * byte.Parse((string)(object)Class3.smethod_2(bindingFlags_5, propertyInfo_2, type, array6, null), numberStyles, formatProvider)) + 12) / 105))))) + b)))->ToString(text));
				c = c;
				uint num10 = unchecked((uint)num9) + unchecked((uint)c2);
				char num11 = c;
				resolveEventArgs = resolveEventArgs;
				num12 = unchecked(num10 / checked(14922u - unchecked((uint)checked(num11 - unchecked((char)Class9.smethod_2(null, resolveEventArgs_)))))) * unchecked((char)Class9.smethod_2(null, resolveEventArgs));
			}
			c = (char)checked(42815u - 46588u);
			c = (char)checked(num12 - c3);
			if (!(text5.LastIndexOf(c) is bool))
			{
				break;
			}
			text = text;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IEnumerable<_0021_00210> enumerable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_3);
		object obj13;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
		do
		{
			try
			{
				object obj12;
				PropertyInfo[] propertyInfo_3;
				Type type_6;
				Type[] type_7;
				do
				{
					flag = false;
					object obj11 = ((byte*)b)->CompareTo(null);
					obj12 = ((obj11 is BindingFlags) ? obj11 : null);
					propertyInfo_3 = byte.Parse(Class2.smethod_0(resolveEventArgs) as string) as PropertyInfo[];
					type_6 = (byte.Parse(text, numberStyles, formatProvider) as string).IndexOf(text) as Type;
					type_7 = array6;
					enumerable = null;
					array4 = string.IsNullOrEmpty(string.Join<T>("KMWITPDI", (IEnumerable<T>)enumerable)) as ParameterModifier[];
				}
				while (checked(0u - ((unchecked((byte)Class3.smethod_2((BindingFlags)obj12, propertyInfo_3, type_6, type_7, parameterModifier_3)) != 0) ? 1u : 0u)) / 0u != 0);
			}
			finally
			{
				_ = "REKT".CompareTo((object?)null) is Class3;
				goto IL_03ff;
			}
			IL_03ff:
			text = "WGXOXZMGI".LastIndexOf((char)((byte*)199)->ToString(text), -482770429, 196823301) as string;
			obj13 = byte.Parse(s5, formatProvider);
		}
		while (checked(unchecked(((obj13 is bool) ? obj13 : null) / ((byte)Class9.smethod_2(null, resolveEventArgs) != 0)) * 1) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] trimChars);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_10);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string a);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
			while ((byte)Settings.Default != 0)
			{
				try
				{
					BindingFlags bindingFlags_6 = bindingFlags;
					IFormatProvider provider = formatProvider;
					string s6 = text;
					NumberStyles style3 = numberStyles;
					uint num13 = checked(93u - 245u);
					string text7 = text;
					array5 = null;
					object obj14 = (byte.TryParse(s6, style3, "M".Equals(((byte*)num13)->CompareTo(text7.TrimEnd(trimChars)) as object) as IFormatProvider, out *(byte*)/*isinst with value type is only supported in some contexts*/) as string).LastIndexOf("YST", (int)checked(1263240548u + (unchecked((uint)(int)"VNU".ToString(formatProvider)) + unchecked((uint)(int)"UTVQRCRLE".ToLower((CultureInfo)(object)((byte*)133)->ToString())))));
					BindingFlags bindingFlags_7 = (BindingFlags)string.Format(provider, ((byte*)((obj14 is byte) ? obj14 : null))->ToString(), obj);
					MethodBase[] methodBase_4 = array7;
					formatProvider = (IFormatProvider)(object)text.ToString(formatProvider);
					b = (byte)checked(byte.Parse("NQKG", provider2) - unchecked((byte)Class7.smethod_2(null, array2)));
					string text8 = text;
					int num14 = num5;
					object obj15 = Class2.smethod_0(resolveEventArgs);
					num5 = (int)((obj15 is int) ? obj15 : null);
					uint totalWidth;
					checked
					{
						totalWidth = unchecked((uint)num14) * unchecked((uint)num15);
					}
					_ = (byte)string.Format("BMP", obj);
					b = (byte)checked(unchecked((uint)b) * 249u);
					string s7 = text;
					numberStyles = default(NumberStyles);
					numberStyles = numberStyles;
					object obj16 = ((byte*)(byte)text8.PadRight((int)totalWidth, (char)((byte*)checked(b4 + 175u * unchecked((uint)byte.Parse(s7, style4))))->ToString(text)))->Equals((byte)(int)/*isinst with value type is only supported in some contexts*/);
					_ = (BindingFlags)Class9.smethod_0((BindingFlags)((byte*)checked(b5 + ((obj16 is byte) ? obj16 : null)))->ToString(), null, array6, null);
					bindingFlags = default(BindingFlags);
					bindingFlags = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = bindingFlags;
					uint num16;
					BindingFlags bindingFlags_9;
					MethodBase[] methodBase_5;
					Type[] type_8;
					byte num17;
					object obj17;
					checked
					{
						num16 = unchecked((byte)string.Concat<T>((IEnumerable<T>)enumerable)) * (17u * unchecked(checked(unchecked((uint)(byte)Class7.smethod_2(array2, array2)) - 63u) / 55u) + b) + 140u;
						bindingFlags = default(BindingFlags);
						bindingFlags_9 = bindingFlags;
						methodBase_5 = array7;
						type_8 = array6;
						num17 = b;
						resolveEventArgs = resolveEventArgs;
						obj17 = Class2.smethod_0(resolveEventArgs_2);
					}
					_ = (IFormatProvider)(object)Class7.smethod_2((byte[])(object)Class9.smethod_0(bindingFlags_9, methodBase_5, type_8, ((byte*)checked(num17 + ((obj17 is byte) ? obj17 : null)))->CompareTo(187) as ParameterModifier[]), array2);
					formatProvider = null;
					bindingFlags = (BindingFlags)((byte*)num16)->ToString(formatProvider2);
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class3.smethod_2(bindingFlags_10, null, type, null, array4);
					text = string.Format(formatProvider, text, array);
					text = (string)(object)Class3.smethod_2(bindingFlags_8, propertyInfo_4, null, null, (ParameterModifier[])(object)text9.Normalize(normalizationForm));
					text = text10;
					stringComparison = default(StringComparison);
					stringComparison = stringComparison;
					Type[] type_9 = (Type[])(object)Class3.smethod_2(default(BindingFlags), byte.TryParse((string.Equals(a, "ODKYCEJ", stringComparison) as string).IndexOfAny(array5) as string, numberStyles, (IFormatProvider)(object)Class7.smethod_2(null, array2), out reference) as PropertyInfo[], type, (Type[])(object)string.IsInterned("FVPMGPKI"), null);
					array4 = (ParameterModifier[])(object)((byte*)(byte)((byte*)b)->ToString())->ToString();
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class9.smethod_0(bindingFlags_7, methodBase_4, type_9, parameterModifier_4);
					byte num18 = b;
					bindingFlags = default(BindingFlags);
					text = (string)(object)Class9.smethod_0(bindingFlags_6, methodBase_6, ((byte*)checked(num18 - unchecked((uint)byte.Parse((string)(object)Class3.smethod_2(bindingFlags, array8, type, null, array4), numberStyles, null)) * 241u))->GetTypeCode() as Type[], array4);
					_ = byte.Parse(s8) is string;
				}
				finally
				{
					ref _003F reference3 = ref *(_003F*)(byte)Class9.smethod_2(null, null);
					object obj18 = "NQUMAWMIL".IndexOfAny(array5);
					_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).CompareTo((byte)(int)((obj18 is byte) ? obj18 : null)) is _003CPrivateImplementationDetails_003E;
					b = 195;
					_ = ((byte*)b6)->Equals(Settings.Default) is byte;
					_ = (_003CPrivateImplementationDetails_003E)(object)((byte*)195)->ToString(formatProvider);
					continue;
				}
			}
		}
		finally
		{
			goto IL_07fd;
		}
		IL_0910:
		Class8 @class = @class;
		@class = @class;
		try
		{
			text = text;
		}
		catch
		{
		}
		byte num19 = b;
		_ = ((byte*)241)->CompareTo(100) is string;
		text = "PMZOQ";
		NumberStyles style5 = numberStyles;
		BindingFlags bindingFlags_11 = (BindingFlags)"DGAWFB".Remove((int)Class3.smethod_2(bindingFlags, array8, type, ((byte*)199)->Equals(b) as Type[], array4));
		BindingFlags bindingFlags_12 = bindingFlags;
		MethodBase[] methodBase_7 = array7;
		Type[] type_10 = array6;
		text = "W";
		char value = c;
		num5 = (int)Settings.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex2);
		object obj20 = text11.LastIndexOf(value, startIndex2, text.GetHashCode());
		array4 = ((byte*)checked(145 + ((obj20 is byte) ? obj20 : null)))->GetTypeCode() as ParameterModifier[];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array9);
		array4 = array9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_5);
		object obj21 = byte.TryParse(s9, style5, (IFormatProvider)Class9.smethod_0(bindingFlags_11, null, (Type[])(object)Class7.smethod_1(bindingFlags_12, methodBase_7, type_10, parameterModifier_5), byte.Parse(text, formatProvider) as ParameterModifier[]), out reference);
		_ = ((byte*)checked(25 + ((obj21 is byte) ? obj21 : null)))->Equals(b) is string;
		text = "SAY";
		BindingFlags bindingFlags_13 = (BindingFlags)"JQC".GetEnumerator();
		ref _003F reference4 = ref *(_003F*)b;
		object obj22 = text.LastIndexOf("MZYJHB", num5, num5, (StringComparison)string.Format(text, array));
		Type[] type_11 = (Type[])(object)System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference4).ToString(((byte*)((obj22 is byte) ? obj22 : null))->Equals(b) as IFormatProvider);
		_ = (ParameterModifier[])(object)Class3.smethod_2(bindingFlags, array8, null, null, null);
		array4 = (ParameterModifier[])(object)string.Concat(Class2.smethod_0(resolveEventArgs) as object);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_6);
		object obj23 = string.Compare(strA2, (int)Class7.smethod_1(bindingFlags_13, null, type_11, parameterModifier_6), text, -934295930, ((byte*)107)->GetHashCode(), flag);
		_003F val5 = num19 / ((obj23 is byte) ? obj23 : null);
		text = "LWE";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA3);
		object obj24 = string.Compare(strA3, (int)((uint)(int)((byte*)46)->ToString(formatProvider) / (uint)num5), text, 1892930213, (int)((uint)num5 / 2445328561u), stringComparison);
		b = (byte)(int)((obj24 is byte) ? obj24 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b7);
		_003F val6 = val5 / checked(198u * unchecked((uint)b7)) / 245;
		string text12 = text;
		BindingFlags bindingFlags_14 = bindingFlags;
		PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Settings.Default;
		Type[] type_12 = array6;
		array4 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array10);
		array4 = array10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_7);
		object obj25 = Class2.smethod_0((ResolveEventArgs)(object)Class3.smethod_2(bindingFlags_14, propertyInfo_5, null, type_12, parameterModifier_7));
		_ = (string[])(object)((byte*)((obj25 is byte) ? obj25 : null))->ToString();
		string[] array11 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array12);
		array11 = array12;
		string[] separator = array11;
		int count = (int)Settings.Default;
		StringSplitOptions stringSplitOptions = default(StringSplitOptions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSplitOptions stringSplitOptions2);
		stringSplitOptions = stringSplitOptions2;
		_ = ((byte*)val6)->Equals((byte)text12.Split(separator, count, default(StringSplitOptions))) is Class5;
		resolveEventArgs = (ResolveEventArgs)(object)Settings.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_3);
		object obj26 = Class2.smethod_0(resolveEventArgs_3);
		object obj27 = ((obj26 is byte) ? obj26 : null);
		string s10 = text;
		string s11 = ((byte*)b)->CompareTo(obj) as string;
		numberStyles = numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style6);
		object obj28 = byte.Parse(s11, style6);
		numberStyles = (NumberStyles)((obj28 is NumberStyles) ? obj28 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style7);
		object obj29 = byte.TryParse(s10, style7, formatProvider, out *(byte*)null);
		b = (byte)(int)((obj29 is byte) ? obj29 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte obj30);
		_ = ((byte*)obj27)->Equals(obj30) is void;
		bindingFlags = bindingFlags;
		MethodBase[] methodBase_8 = (MethodBase[])(object)text.Normalize();
		array6 = array6;
		object object_ = obj;
		string s12 = byte.TryParse(((byte*)114)->ToString(text, formatProvider), out *(byte*)null) as string;
		numberStyles = default(NumberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_13);
		Class9.smethod_0(bindingFlags_15, methodBase_8, type_13, (ParameterModifier[])(object)Class9.smethod_2(object_, byte.Parse(s12, numberStyles) as ResolveEventArgs));
		text = byte.Parse(text, null) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text13);
		_ = ((byte*)135)->Equals(((byte*)149)->ToString(text13)) is string;
		object obj31 = ((byte*)6798)->Equals(null);
		object obj32 = ((obj31 is int) ? obj31 : null);
		string strB = text;
		bindingFlags = default(BindingFlags);
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_16);
		num5 = (int)Class9.smethod_0(bindingFlags_16, null, array6, array4);
		text = "ZBJSKU";
		int indexA = (int)obj32;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text14);
		object obj33 = text14.Equals(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexB);
		object obj34 = string.CompareOrdinal("UBX", indexA, strB, indexB, checked(1819319661 - ((obj33 is int) ? obj33 : null)));
		ref _003F reference5 = ref *(_003F*)((obj34 is byte) ? obj34 : null);
		string s13 = text;
		string text15 = text;
		object obj35 = ((byte*)b)->Equals((byte)(int)/*isinst with value type is only supported in some contexts*/);
		object obj36 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference5).Equals(byte.Parse(s13, text15.StartsWith((string)(object)Class3.smethod_2((BindingFlags)Class9.smethod_0((BindingFlags)((obj35 is BindingFlags) ? obj35 : null), null, array6, array4), array8, (Type)(object)Settings.Default, null, null), stringComparison) as IFormatProvider) as object);
		_003F val7 = ((obj36 is int) ? obj36 : null) / num5;
		string text16 = text;
		NumberStyles num20 = (NumberStyles)Class7.smethod_1(default(BindingFlags), array7, array6, array4);
		IFormatProvider formatProvider3 = formatProvider;
		string provider3 = Class2.smethod_0(resolveEventArgs) as string;
		object s14 = obj;
		obj = obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj37);
		NumberStyles style8 = (NumberStyles)string.Concat(obj37, obj, byte.Parse("NOWJFWEX") as object, (object)__arglist());
		resolveEventArgs = byte.Parse("LAXY", numberStyles, null) as ResolveEventArgs;
		object strA4 = (object)val7;
		int indexA2 = (int)"A";
		object strB2 = -2075368748;
		int indexB2 = (int)text16;
		object obj38 = string.Equals("PEVA", "ZNJKZ", (StringComparison)/*isinst with value type is only supported in some contexts*/);
		object obj39 = string.CompareOrdinal((string?)strA4, indexA2, (string?)strB2, indexB2, (int)((obj38 is int) ? obj38 : null));
		object obj40 = ((obj39 is BindingFlags) ? obj39 : null);
		PropertyInfo[] propertyInfo_6 = array8;
		Type type_14 = (Type)(object)Settings.Default;
		array6 = array6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_15);
		_ = (Class8)(object)Class3.smethod_2((BindingFlags)obj40, propertyInfo_6, type_14, type_15, array4);
		return;
		IL_07fd:
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text18);
			while (0u * unchecked(0u / 0u) != 0)
			{
				string text17 = text;
				text = string.Copy(text);
				_ = (Class3)(object)(text17 + text18 + text);
			}
			BindingFlags bindingFlags_17 = bindingFlags;
			array7 = null;
			_ = (Type[])(object)Class9.smethod_2(obj, resolveEventArgs);
			array6 = array6;
			array4 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array13);
			array4 = array13;
			array4 = array4;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_16);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_8);
			_ = (Struct2)Class9.smethod_0(bindingFlags_17, methodBase_9, type_16, parameterModifier_8);
		}
		while (string.Compare(byte.Parse((string)(object)Settings.Default, (IFormatProvider)(object)"XKLME".GetEnumerator()) as string, ((byte*)(byte)((byte*)b)->ToString())->GetHashCode() as string, Class2.smethod_0(resolveEventArgs) as CultureInfo, default(CompareOptions)) is bool)
		{
			_ = (Class6)(object)Settings.Default;
		}
		try
		{
		}
		catch
		{
			object obj41 = ((byte*)228)->GetHashCode();
			b = (byte)(int)((obj41 is byte) ? obj41 : null);
			BindingFlags bindingFlags_18 = bindingFlags;
			array6 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_17);
			text = (string)(object)Class9.smethod_0(bindingFlags_18, null, type_17, null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text19);
			_ = (byte)text19.ToLower();
			Class0 class2 = null;
			class2 = class2;
		}
		b = b;
		object obj43;
		do
		{
			obj43 = ((byte*)checked(238u + unchecked((uint)b)))->GetTypeCode();
		}
		while (((obj43 is bool) ? obj43 : null) / 0 != 0);
		while (flag || checked((flag ? 1u : 0u) * 0u) != 0)
		{
		}
		try
		{
			while (flag)
			{
			}
		}
		finally
		{
			goto IL_0910;
		}
	}
}
