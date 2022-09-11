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

	unsafe static void alasug7(object object_0, object object_1)
	{
		//IL_0026: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_00ce: Expected I4, but got O
		//IL_00eb: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		//IL_019c: Expected I4, but got O
		//IL_01c5: Expected O, but got I4
		//IL_01ce: Expected I4, but got O
		//IL_01e5: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0262: Expected O, but got I4
		//IL_0268: Expected I4, but got O
		//IL_0270: Expected O, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected I4, but got Unknown
		//IL_02a0: Expected O, but got I4
		//IL_0367: Expected O, but got I4
		//IL_0397: Expected O, but got I4
		//IL_03b6: Expected O, but got I4
		//IL_03da: Expected O, but got I4
		//IL_03e3: Expected I4, but got O
		//IL_03e4: Expected O, but got I4
		//IL_0411: Expected O, but got I4
		//IL_0433: Expected O, but got I4
		//IL_04b3: Expected O, but got I4
		//IL_04f2: Expected O, but got I4
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Ref, but got Unknown
		//IL_0522: Expected O, but got I4
		//IL_052e: Expected O, but got I4
		//IL_0545: Expected O, but got I4
		//IL_055a: Expected O, but got I4
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Ref, but got Unknown
		//IL_0576: Expected O, but got I4
		//IL_0589: Expected O, but got I4
		//IL_0597: Expected O, but got I4
		//IL_05a2: Expected O, but got I4
		//IL_05c7: Expected O, but got I4
		//IL_05db: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_05fc: Expected O, but got I4
		//IL_0605: Expected I4, but got O
		//IL_0606: Expected O, but got I4
		//IL_065c: Expected O, but got I4
		//IL_0661: Expected I4, but got O
		//IL_0688: Expected O, but got I4
		//IL_0692: Expected O, but got I4
		//IL_069b: Expected I4, but got O
		//IL_069c: Expected O, but got I4
		//IL_06bf: Expected O, but got I4
		//IL_06da: Expected O, but got I4
		//IL_070e: Expected O, but got I4
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected I4, but got Unknown
		//IL_074c: Expected O, but got I4
		//IL_0758: Expected O, but got I4
		//IL_0775: Expected O, but got I4
		//IL_078e: Expected O, but got I4
		//IL_0797: Expected I4, but got O
		//IL_0798: Expected O, but got I4
		//IL_07a6: Expected O, but got I4
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected I4, but got Unknown
		//IL_07cb: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_07de: Expected I4, but got O
		//IL_07e9: Expected O, but got I4
		try
		{
		}
		finally
		{
			Class2 @class = @class;
			@class = @class;
			goto IL_0008;
		}
		IL_0008:
		BindingFlags bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		MethodBase[] array = (MethodBase[])(object)Settings.Default;
		MethodBase[] methodBase_ = array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		BindingFlags bindingFlags_2 = (BindingFlags)(((byte*)b)->GetHashCode() as string).Substring(-454077530);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		Type[] type_ = array2;
		ParameterModifier[] array3 = array3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		array3 = array4;
		array2 = (Type[])(object)Class9.smethod_0(bindingFlags_2, null, type_, array3);
		array2 = array2;
		string s = (string)(object)Class9.smethod_0(bindingFlags_, methodBase_, array2, array3);
		string[] value = null;
		string value2 = string.Join("GL", value);
		uint startIndex = (uint)(int)Class9.smethod_2(null, (ResolveEventArgs)(object)Settings.Default) / 2071496165u;
		StringComparison stringComparison = stringComparison;
		stringComparison = default(StringComparison);
		_ = "TWTGI".IndexOf(value2, (int)startIndex, stringComparison) is ref byte;
		ref byte reference = ref *(byte*)null;
		ResolveEventArgs resolveEventArgs = byte.TryParse(s, out reference) as ResolveEventArgs;
		object obj = Class2.smethod_0(resolveEventArgs);
		b = (byte)(int)((obj is byte) ? obj : null);
		byte num = b;
		byte num2 = (byte)Settings.Default;
		string text = text;
		string text2 = text;
		IFormatProvider formatProvider = Class2.smethod_0(null) as IFormatProvider;
		string obj2 = ((byte*)num)->Equals((byte)checked(unchecked((uint)checked(num2 * unchecked((byte)((byte*)209)->ToString(text2, formatProvider)))) * 35u)) as string;
		_ = Class2.smethod_0(resolveEventArgs) is object;
		object obj3 = obj3;
		obj3 = obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		obj3 = obj4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		obj3 = obj5;
		string value3 = ((byte*)132)->Equals(obj3) as string;
		string s2 = text;
		bindingFlags = bindingFlags;
		bindingFlags = bindingFlags;
		BindingFlags bindingFlags_3 = bindingFlags;
		Type type = type;
		Type type_2 = type;
		Type[] type_3 = (Type[])(object)Settings.Default;
		string text3 = string.Format("DJAIIDR", null, obj3, null);
		char[] anyOf = (char[])(object)((byte*)b)->ToString();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		int num4 = num3;
		num3 = (int)checked(unchecked((uint)(int)Class9.smethod_2(obj3, null)) - 3443670295u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		object obj6 = text3.LastIndexOfAny(anyOf, (int)checked(unchecked((uint)num4) - unchecked((uint)num5)));
		bindingFlags = (BindingFlags)((obj6 is BindingFlags) ? obj6 : null);
		text = "QON";
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		object obj7 = text4.Equals("GFRDPV");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		byte num6 = (byte)Class3.smethod_2(default(BindingFlags), (PropertyInfo[])(object)Class3.smethod_2(bindingFlags_3, null, type_2, type_3, Class2.smethod_0((ResolveEventArgs)(object)Class7.smethod_1(default(BindingFlags), (MethodBase[])(object)text5.Substring(-1602446596, (int)((obj7 is int) ? obj7 : null)), null, null)) as ParameterModifier[]), type, array2, ((byte*)b)->GetHashCode() as ParameterModifier[]);
		formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		string text6 = ((byte*)num6)->ToString(formatProvider2);
		string value4 = text;
		PropertyInfo[] array5 = null;
		PropertyInfo[] propertyInfo_ = array5;
		Type type_4 = type;
		string text7 = text;
		bindingFlags = default(BindingFlags);
		object obj8 = text6.LastIndexOf(value4, (int)Class3.smethod_2(default(BindingFlags), propertyInfo_, type_4, (Type[])(object)(text7 + (string)(object)Class3.smethod_2(bindingFlags, array5, type, array2, null) + text), array3));
		NumberStyles style = (NumberStyles)((obj8 is NumberStyles) ? obj8 : null);
		object obj9 = byte.Parse(s2, style);
		num3 = ((obj9 is int) ? obj9 : null) / -1085604486;
		uint startIndex2;
		checked
		{
			startIndex2 = unchecked((uint)num3) - 3306011123u;
			stringComparison = stringComparison;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison2);
			stringComparison = stringComparison2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison3);
			stringComparison = stringComparison3;
		}
		_ = obj2.IndexOf(value3, (int)startIndex2, default(StringComparison)) is string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		uint num7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		do
		{
			BindingFlags bindingFlags_4 = bindingFlags;
			array = (MethodBase[])(object)Settings.Default;
			array3 = array3;
			_ = (Class0)(object)Class7.smethod_1(bindingFlags_4, methodBase_2, null, parameterModifier_);
			checked
			{
				num7 = (Class2.smethod_0((ResolveEventArgs)(object)string.Concat((string?[])null)) ? 1u : 0u) * (((unchecked((byte)string.Concat(obj3)) != 0) ? 1u : 0u) - unchecked((flag ? 1u : 0u) / (((byte)text.ToLower() != 0) ? 1u : 0u)));
			}
			flag = (byte)num7 != 0;
		}
		while (num7 != 0);
		try
		{
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_5 = bindingFlags;
			array5 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
			array5 = array6;
			Type type_5 = type;
			Type[] type_6 = (Type[])(object)Class7.smethod_1(bindingFlags, array, null, null);
			string value5 = text;
			BindingFlags bindingFlags_6 = (BindingFlags)Class9.smethod_2(null, resolveEventArgs);
			formatProvider = null;
			BindingFlags bindingFlags_7 = bindingFlags;
			PropertyInfo[] propertyInfo_2 = array5;
			Type type_7 = (Type)(object)Class9.smethod_2(obj3, resolveEventArgs);
			text = "I";
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
			array2 = (Type[])(object)text8.ToString();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_8);
			string format = (string)(object)Class3.smethod_2((BindingFlags)Class3.smethod_2(bindingFlags_7, propertyInfo_2, type_7, type_8, ((byte*)b)->GetHashCode() as ParameterModifier[]), array5, type, array2, null);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			_ = Class2.smethod_0(resolveEventArgs) is MethodBase[];
			array = null;
			array3 = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
			obj3 = ((string)(object)Class9.smethod_0(bindingFlags_8, methodBase_3, null, parameterModifier_2)).GetHashCode() as object;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg);
			MethodBase[] methodBase_4 = (MethodBase[])(object)string.Format(provider, format, arg, null);
			Type[] type_9 = array2;
			string strA = text;
			object obj10 = Class2.smethod_0(resolveEventArgs);
			uint startIndex3 = (uint)(int)Class7.smethod_1(bindingFlags_6, methodBase_4, type_9, string.Compare(strA, "LAXKULFNU", (StringComparison)((obj10 is StringComparison) ? obj10 : null)) as ParameterModifier[]) / (uint)(int)((byte*)b)->ToString("SW".Normalize().Contains((string)(object)Class9.smethod_2(obj3, resolveEventArgs)) as string);
			int num8 = num3;
			resolveEventArgs = resolveEventArgs;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
			string obj11 = Class2.smethod_0(resolveEventArgs_) as string;
			uint startIndex4 = 3632339073u / checked(unchecked((uint)num3) - 1914027368u * unchecked((uint)(int)Class9.smethod_2(obj3, null)));
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value6);
			num3 = (int)checked(unchecked((uint)(int)obj11.Insert((int)startIndex4, value6)) - unchecked((uint)num3));
			BindingFlags bindingFlags_9 = bindingFlags;
			PropertyInfo[] propertyInfo_3 = array5;
			type = (Type)(object)((byte*)checked(unchecked((uint)b) + unchecked((uint)(b / b))))->ToString(formatProvider);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
			type = type2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_10);
			string strA2 = "MYHPISTA".LastIndexOf(value5, (int)startIndex3, (int)checked(unchecked((uint)num8) - unchecked(972262834u / checked(unchecked((uint)num9) + unchecked((uint)(int)Class3.smethod_2(bindingFlags_9, propertyInfo_3, type_10, array2, (ParameterModifier[])(object)text.ToCharArray(-1805861539, 1414825281)))))), stringComparison) as string;
			uint indexA;
			string strB;
			MethodBase[] methodBase_5;
			byte num10;
			_003F val;
			object obj13;
			checked
			{
				indexA = unchecked(685947627u / (uint)(int)Settings.Default) * 1427630296u;
				strB = text;
				methodBase_5 = array;
				num10 = b;
				byte num11 = unchecked((byte)string.IsInterned(text));
				object obj12 = Class2.smethod_0(null);
				val = num11 - ((obj12 is byte) ? obj12 : null);
				_ = (string)(object)Settings.Default;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s3);
				obj13 = byte.TryParse(s3, out reference);
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_4);
			byte num12 = (byte)Class3.smethod_2(bindingFlags_5, propertyInfo_4, type_5, type_6, string.CompareOrdinal(strA2, (int)indexA, strB, (int)(4051964263u / (uint)(int)Class7.smethod_1(default(BindingFlags), methodBase_5, ((byte*)checked(num10 * (val * (((obj13 is byte) ? obj13 : null) - 127))))->GetTypeCode() as Type[], Class2.smethod_0(resolveEventArgs) as ParameterModifier[])), num3) as ParameterModifier[]);
			object obj14 = ((byte*)b)->GetHashCode();
			byte.Parse(((byte*)(num12 / ((obj14 is byte) ? obj14 : null)))->ToString(), formatProvider);
		}
		_ = Class2.smethod_0(resolveEventArgs) is Class9;
		b = 211;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		object obj16 = ((byte*)b2)->GetTypeCode();
		object obj17 = ((obj16 is byte) ? obj16 : null);
		object obj18 = byte.TryParse(text, out reference);
		Class1 obj19 = (Class1)(object)Class9.smethod_2(((byte*)checked(obj17 + ((obj18 is byte) ? obj18 : null)))->GetTypeCode() as object, resolveEventArgs);
		Class1 class2 = class2;
		class2 = obj19;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object value8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NormalizationForm normalizationForm);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int count);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string str);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexA2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB3);
			while (true)
			{
				string obj20 = ((byte*)b)->GetTypeCode() as string;
				text = text;
				reference = ref reference;
				int startIndex5 = (int)(byte.TryParse("LAQFGYJD", out result) as string).Substring(num3, num3);
				string text9 = text;
				string value7 = text;
				byte num13 = b;
				obj3 = obj3;
				uint startIndex6;
				NumberStyles style2;
				byte num15;
				object obj23;
				checked
				{
					uint num14 = unchecked((uint)((byte*)num13)->CompareTo(value8)) * 2697659424u;
					object obj21 = byte.Parse("ONQFGZKD", null);
					num3 = text9.LastIndexOf(value7, unchecked((int)(num14 / ((obj21 is int) ? obj21 : null))), 1833409025);
					startIndex6 = 3594352463u + unchecked((uint)num3);
					style = default(NumberStyles);
					style2 = style;
					num15 = b;
					object obj22 = byte.TryParse("BPS", out reference);
					obj23 = ((obj22 is byte) ? obj22 : null);
				}
				object obj24 = ((byte*)b)->CompareTo(b);
				object obj25 = ((obj24 is byte) ? obj24 : null);
				uint num16 = 16u / (uint)b;
				string text10 = text;
				resolveEventArgs = null;
				_ = Class2.smethod_0(resolveEventArgs_2) is NormalizationForm;
				normalizationForm = normalizationForm;
				normalizationForm = default(NormalizationForm);
				ref _003F reference2 = ref *(_003F*)num16;
				object obj26 = (object)/*isinst with value type is only supported in some contexts*/;
				object obj27 = string.Compare(text, text);
				b = (byte)System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).ToString((IFormatProvider)(object)((byte*)checked(obj26 + ((obj27 is byte) ? obj27 : null)))->ToString((IFormatProvider?)null));
				object obj28 = byte.Parse("FDHSYLRL", style2, ((byte*)num15)->Equals((byte)checked(obj23 + unchecked(obj25 / b3))) as IFormatProvider);
				if (obj20.LastIndexOf(value9, startIndex5, count, (StringComparison)string.Join("JPKXUWPYR", null, (int)startIndex6, (int)((obj28 is int) ? obj28 : null))) is bool)
				{
					try
					{
						object obj29 = Class2.smethod_0(resolveEventArgs);
						_ = ((byte*)((obj29 is byte) ? obj29 : null))->Equals(Settings.Default) is Class5;
						string strA3 = text;
						byte num17 = b;
						string text11 = text;
						text = byte.Parse(text, style) as string;
						ref _003F reference3 = ref *(_003F*)num17;
						object obj30 = text11.CompareTo(strB2);
						_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).Equals((byte)(int)((obj30 is byte) ? obj30 : null)) is int;
						num3 = 2123681261;
						text = text;
						byte num18 = b;
						b = 242;
						text = "BD";
						uint num19;
						checked
						{
							num19 = unchecked((uint)checked(b4 * unchecked((byte)string.IsInterned(str)))) - 242u;
						}
						object obj31 = string.Compare(text, text, (byte)checked((flag ? 1u : 0u) + (flag ? 1u : 0u)) != 0, null);
						b = (byte)(int)((obj31 is byte) ? obj31 : null);
						uint length = 2123681261u / checked(unchecked((uint)((byte*)num18)->CompareTo((byte)checked(num19 * unchecked(242u / (uint)b5)))) * 184465229u);
						CultureInfo cultureInfo = null;
						cultureInfo = cultureInfo2;
						CultureInfo culture = cultureInfo;
						string s4 = text;
						resolveEventArgs = resolveEventArgs;
						object obj32 = byte.TryParse(s4, out *(byte*)/*isinst with value type is only supported in some contexts*/);
						_ = string.Compare(strA3, indexA2, strB3, -1087234128, (int)length, culture, (CompareOptions)((obj32 is CompareOptions) ? obj32 : null)) is Class5;
					}
					finally
					{
						_ = (byte)"EQVHSWZVB".ToString(formatProvider);
						continue;
					}
				}
				break;
			}
		}
		catch
		{
			try
			{
			}
			catch
			{
			}
		}
	}

	unsafe static void alasugosum8()
	{
		//IL_0020: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_031f: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_0354: Expected Void, but got O
		//IL_0398: Expected O, but got I4
		//IL_03a1: Expected I4, but got O
		//IL_03a2: Expected O, but got I4
		//IL_03af: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_03e4: Expected I4, but got O
		//IL_03ec: Expected O, but got I4
		//IL_0417: Expected O, but got I4
		//IL_0431: Expected O, but got I4
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Ref, but got Unknown
		//IL_048c: Expected O, but got I4
		//IL_04e5: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_050a: Expected O, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Ref, but got Unknown
		//IL_0541: Expected O, but got I4
		//IL_0574: Expected O, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Ref, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Ref, but got Unknown
		//IL_0595: Expected O, but got I4
		//IL_05b4: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_05ce: Expected I4, but got O
		//IL_05fc: Expected O, but got I4
		//IL_060e: Expected O, but got I4
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected I4, but got Unknown
		//IL_064f: Expected I4, but got O
		//IL_0660: Expected O, but got I4
		//IL_0666: Expected I4, but got O
		//IL_0690: Expected O, but got I4
		//IL_06ea: Expected O, but got I4
		//IL_0703: Expected O, but got I4
		//IL_0709: Expected I4, but got O
		//IL_0711: Expected O, but got I4
		//IL_072d: Expected I4, but got O
		//IL_072e: Expected O, but got I4
		//IL_0768: Expected O, but got I4
		//IL_077e: Expected O, but got I4
		//IL_07c8: Expected O, but got I4
		//IL_07d1: Expected I4, but got O
		//IL_07d8: Expected O, but got I4
		//IL_07f3: Expected O, but got I4
		//IL_0807: Expected O, but got I4
		//IL_085d: Expected O, but got I4
		//IL_0869: Expected O, but got I4
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected I4, but got Unknown
		//IL_0874: Expected O, but got I4
		//IL_087e: Expected O, but got I4
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected I4, but got Unknown
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		try
		{
			try
			{
			}
			finally
			{
				void @void = @void;
				@void = default(void);
				text = "WWCHPY";
				resolveEventArgs_ = text.StartsWith("HIXKZSHGN") as ResolveEventArgs;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
				resolveEventArgs_ = resolveEventArgs;
				@void = Class9.smethod_2(null, resolveEventArgs_);
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			try
			{
				formatProvider = null;
				IFormatProvider provider = formatProvider;
				string format = text;
				obj = obj;
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_ = bindingFlags;
				array = null;
				MethodBase[] methodBase_ = array;
				b = (byte)checked(19u - unchecked((uint)checked(unchecked((byte)Settings.Default) + b)));
				byte num = b;
				array2 = array2;
				object object_ = Class7.smethod_2(null, array2);
				string text2 = text;
				text = text;
				string text3 = text;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
				object obj2 = ((byte*)num)->CompareTo((byte)checked(unchecked(51u / (uint)(byte)Class9.smethod_2(object_, (ResolveEventArgs)(object)(text2 + text4 + text3 + text5))) + 9u));
				array3 = (Type[])(object)((byte*)((obj2 is byte) ? obj2 : null))->ToString(text);
				Type[] type_ = array3;
				_ = (ParameterModifier[])(object)Settings.Default;
				array4 = array4;
				text = (string)(object)Class9.smethod_0(bindingFlags_, methodBase_, type_, array4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
				obj = text6.PadLeft(1864124226);
				_ = (Class4)(object)string.Format(provider, format, null, obj);
			}
			catch
			{
				text = "SPKVSBS";
			}
			finally
			{
				_ = (Class8)(object)Class7.smethod_2(array2, array2);
				_ = ((byte*)b)->Equals(38) is _003CPrivateImplementationDetails_003E;
				_ = ((byte*)65)->CompareTo(string.CompareOrdinal("S", string.Concat((object?)null)) as object) is Class5;
				goto IL_014d;
			}
		}
		IL_014d:
		try
		{
		}
		catch
		{
			char[] anyOf = null;
			text = "YIMHJWU".IndexOfAny(anyOf) as string;
		}
		bool num3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
		bool ignoreCase;
		do
		{
			void @void = default(void);
			_ = Class2.smethod_0(resolveEventArgs_) is void;
			@void = Settings.Default;
			void void2 = default(void);
			@void = @void;
			@void = default(void);
			int num2 = checked(b * b);
			text = ((byte*)153)->GetTypeCode() as string;
			num3 = (byte)((byte*)num2)->ToString(text7, formatProvider) != 0;
			ignoreCase = num3;
		}
		while (checked((num3 ? 1u : 0u) - 1u) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		try
		{
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
			try
			{
				text = "JRCNZRRQ";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text8);
				text = text8;
				text = "YGLS";
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_2 = bindingFlags;
				array5 = Class2.smethod_0((ResolveEventArgs)(object)Class9.smethod_2(Class7.smethod_2(array2, array2), resolveEventArgs_)) as PropertyInfo[];
				PropertyInfo[] propertyInfo_ = array5;
				Type type_2 = string.Compare("ZS", text, ignoreCase) as Type;
				Type[] type_3 = array3;
				array4 = array4;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
				byte[] byte_ = (byte[])(object)Class3.smethod_2(bindingFlags_2, propertyInfo_, type_2, type_3, parameterModifier_);
				string s = (string)(object)Settings.Default;
				b = 190;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
				_ = (string)(object)Class7.smethod_2(byte_, byte.TryParse(s, (NumberStyles)((byte*)b2)->ToString(formatProvider), formatProvider, out *(byte*)text.TrimStart(null)) as byte[]);
			}
			catch
			{
				try
				{
					Class7.smethod_2(null, null);
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
					IFormatProvider provider2 = (IFormatProvider)(object)("NZALEINKK" + "DNYZZ" + text9 + "SMIEEPA");
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text10);
					text = text10;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text11);
					text = text11;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string format2);
					string s2 = string.Format(provider2, format2, obj, obj);
					formatProvider = null;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
					byte num4 = (byte)((byte*)byte.Parse(s2, provider3))->ToString(text, formatProvider);
					obj = obj;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out object value);
					_ = ((byte*)num4)->CompareTo(value) is void;
					string text12 = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
					checked
					{
						_ = c + unchecked((uint)(c / (char)((byte*)b)->ToString()) / checked(16869u + unchecked((uint)c)));
						text = "ORE";
					}
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text13);
					_ = (char)((Class2.smethod_0(text13.LastIndexOfAny(null, 545541449) as ResolveEventArgs) as string) + text + text);
					c = (char)((uint)c / 59997u);
					object obj5 = text12.LastIndexOf((char)checked(unchecked(27239u / (uint)c) + 36812u), -2016133529);
					void @void = ((obj5 is void) ? obj5 : null);
					goto end_IL_027b;
				}
				finally
				{
					string s3 = text;
					NumberStyles numberStyles = numberStyles;
					byte num5 = byte.Parse(s3, numberStyles, formatProvider);
					uint num6;
					string s4;
					NumberStyles style;
					uint num7;
					string s5;
					checked
					{
						num6 = 224u + unchecked((uint)b);
						s4 = text;
						style = numberStyles;
						num7 = unchecked((uint)(byte)"YVFXFVVWV".Trim()) + 169u;
						s5 = text;
					}
					object obj6 = ((byte*)(byte)Class7.smethod_2(((byte*)229)->CompareTo((byte)(int)/*isinst with value type is only supported in some contexts*/) as byte[], ((byte*)b)->Equals(null) as byte[]))->Equals(71);
					object obj7 = byte.TryParse(s5, out *(byte*)((obj6 is ref byte) ? obj6 : null));
					object obj8 = ((byte*)((obj7 is byte) ? obj7 : null))->CompareTo(obj);
					b = (byte)(int)((obj8 is byte) ? obj8 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte value2);
					string strA = ((byte*)num7)->CompareTo(value2) as string;
					string text14 = text;
					string[] value3 = null;
					object obj9 = text14.Equals((string)(object)Class7.smethod_2((byte[])(object)string.Join("JZOUBB", value3), array2));
					int hashCode = ((byte*)((obj9 is byte) ? obj9 : null))->GetHashCode();
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text15);
					text = text15;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text16);
					text = text16;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text17);
					object obj10 = text17 == text;
					_003F val = ((obj10 is byte) ? obj10 : null) / 187;
					byte num8 = b;
					b = b;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
					num9 = (int)checked(unchecked((uint)hashCode) * unchecked((uint)((byte*)checked(unchecked(val / checked(num8 * b3)) * b))->CompareTo(216)));
					int indexA = num9;
					BindingFlags bindingFlags_3 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = array5;
					text = "DR";
					_ = (string)(object)Class3.smethod_2((BindingFlags)((byte*)b)->ToString(text), null, null, array3, array4);
					_ = ((byte*)241)->GetTypeCode() is BindingFlags;
					bindingFlags = default(BindingFlags);
					string strA2 = text;
					b = (byte)((byte*)117)->ToString(((byte*)checked(unchecked(179u / (uint)(byte)((byte*)b)->ToString(formatProvider)) * 111u))->ToString(), null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
					object obj11 = ((byte*)b4)->ToString((IFormatProvider?)null).IsNormalized();
					object obj12 = ((obj11 is int) ? obj11 : null);
					object obj13 = Class2.smethod_0(null);
					object obj14 = ((obj13 is int) ? obj13 : null);
					bindingFlags = bindingFlags;
					PropertyInfo[] propertyInfo_3 = array5;
					string text18 = text;
					string text19 = text;
					object obj15 = Class2.smethod_0(resolveEventArgs_);
					_003F val2 = checked(((obj15 is byte) ? obj15 : null) * 111);
					object obj16 = obj;
					object obj17 = obj;
					obj = null;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj18);
					char[] anyOf2 = (char[])(object)(text19 + ((byte*)val2)->ToString((IFormatProvider)(object)string.Concat(obj16, obj17, obj18)));
					object obj19 = byte.TryParse(text, numberStyles, null, out *(byte*)null);
					object obj20 = ((obj19 is byte) ? obj19 : null);
					uint num10;
					object obj21;
					checked
					{
						num10 = unchecked((byte)Class9.smethod_0(bindingFlags, array, null, array4)) + (unchecked((uint)b) - 151u);
						obj21 = "CSMVJWNU".Length;
					}
					b = (byte)((byte*)checked(num10 * (243 - ((obj21 is byte) ? obj21 : null)) + b))->ToString(formatProvider);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
					array2 = ((byte*)checked(obj20 - 252u * unchecked((uint)b5)))->GetHashCode() as byte[];
					System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_2);
					BindingFlags bindingFlags_4 = (BindingFlags)Class7.smethod_2(byte_2, null);
					PropertyInfo[] propertyInfo_4 = array5;
					Type type_4 = type;
					object obj22 = byte.TryParse(text, out *(byte*)null);
					int startIndex = (int)Class3.smethod_2(bindingFlags_4, propertyInfo_4, type_4, (Type[])(object)Class3.smethod_2((BindingFlags)((obj22 is BindingFlags) ? obj22 : null), byte.Parse(text, null) as PropertyInfo[], type, array3, null), null);
					BindingFlags bindingFlags_5 = bindingFlags;
					MethodBase[] methodBase_2 = array;
					array4 = array4;
					array4 = null;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
					Type type_5 = text18.IndexOfAny(anyOf2, startIndex, (int)Class7.smethod_1(bindingFlags_5, methodBase_2, null, parameterModifier_2)) as Type;
					object obj23 = ((byte*)checked(236u + unchecked((uint)b)))->GetHashCode();
					checked
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_6);
						num9 = unchecked(obj14 / (int)Class3.smethod_2(bindingFlags_6, propertyInfo_3, type_5, (Type[])(object)((byte*)((obj23 is byte) ? obj23 : null))->ToString(formatProvider), null)) * unchecked((int)Class7.smethod_2(array2, array2));
					}
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
					byte num12 = (byte)"BOHF".Substring((int)obj12, (int)checked((1466111244u + unchecked((uint)num11) * 4156185302u * unchecked((uint)num9)) * unchecked((uint)num9)));
					obj = obj;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj24);
					object obj25 = ((byte*)num12)->Equals(obj24);
					num9 = (int)((obj25 is int) ? obj25 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_7);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexA2);
					text = (string)(object)Class3.smethod_2(bindingFlags_7, null, string.Compare(strA2, indexA2, text, (int)Class3.smethod_2(bindingFlags, array5, null, array3, null), 737812926, (byte)Settings.Default != 0) as Type, null, null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text20);
					int hashCode2 = text20.GetHashCode();
					StringSplitOptions stringSplitOptions = stringSplitOptions;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text21);
					_ = (Type)(object)text21.Split((string[]?)null, hashCode2, stringSplitOptions);
					obj = obj;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_2);
					type = (Type)(object)Class9.smethod_2(object_2, null);
					type = null;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
					type = type2;
					string strB = ((string)(object)Class3.smethod_2(bindingFlags_3, propertyInfo_2, type, null, null)).CompareTo(obj) as string;
					text = "IPJ";
					object obj26 = text != text;
					StringComparison stringComparison = (StringComparison)((obj26 is StringComparison) ? obj26 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string value4);
					object obj27 = "IHAEXA".EndsWith(value4, stringComparison);
					object obj28 = ((obj27 is int) ? obj27 : null);
					stringComparison = stringComparison;
					_ = string.Compare(strA, indexA, strB, (int)obj28, -1168270147, default(StringComparison)) is string;
					text = "XIWMWBAC";
					CultureInfo cultureInfo = cultureInfo;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
					cultureInfo = cultureInfo2;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text22);
					text22.ToUpper(cultureInfo);
					string strA3 = text;
					text = (string)(object)"JTRANDHEM".GetEnumerator();
					stringComparison = stringComparison;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB2);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
					text = string.Compare(strA3, strB2, comparisonType) as string;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text23);
					_ = (Struct3)((byte*)checked(num5 * (num6 * byte.Parse(s4, style, text23.IndexOf("AJL", stringComparison) as IFormatProvider))))->ToString(text);
					goto end_IL_027b;
				}
				end_IL_027b:;
			}
		}
		uint num13 = 204u / (uint)b;
		b = (byte)checked(unchecked((uint)(byte)Class7.smethod_2(array2, array2)) * 152u);
		ref _003F reference = ref *(_003F*)num13;
		object obj31 = byte.Parse(text, null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
		_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo((byte)checked(b6 * byte.Parse("GMTB", unchecked((NumberStyles)((obj31 is NumberStyles) ? obj31 : null))))) is Class9;
		text = text;
		b = 219;
		_ = byte.TryParse(text, out *(byte*)(((byte*)byte.Parse(text))->GetHashCode() as string).GetEnumerator()) is Class6;
		try
		{
			try
			{
				b = byte.Parse(text, default(NumberStyles));
			}
			finally
			{
				try
				{
					b = byte.Parse(text, formatProvider);
				}
				catch
				{
					BindingFlags bindingFlags_8 = bindingFlags;
					int num14 = num9;
					object obj32 = ((byte*)/*isinst with value type is only supported in some contexts*/)->GetTypeCode();
					_003F val3 = checked(num14 - ((obj32 is int) ? obj32 : null));
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string value5);
					PropertyInfo[] array5 = (PropertyInfo[])(object)"O".Insert((int)val3, value5);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_5);
					_ = (Class7)(object)string.Copy((string)(object)Class3.smethod_2(bindingFlags_8, propertyInfo_5, type, null, null));
				}
				goto end_IL_080c;
			}
			end_IL_080c:;
		}
		finally
		{
			goto IL_08b6;
		}
		IL_08b6:
		_ = (Class4)(object)string.Join(text, (IEnumerable<string?>)null);
		text.PadLeft((int)checked(unchecked((uint)num9) * (2685417885u * 3148390706u)));
	}
}
