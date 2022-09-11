using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;
using ns2;

namespace ns0;

internal sealed class Class2
{
	internal static string smethod_0(bool bool_0)
	{
		return null;
	}

	internal static string smethod_1(Type[] type_0, CallingConventions callingConventions_0, bool bool_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = "";
		foreach (Type obj in type_0)
		{
			stringBuilder.Append(value);
			string text = smethod_0(bool_0);
			if (obj.IsByRef && !bool_0)
			{
				stringBuilder.Append(text.TrimEnd(new char[1] { '&' }));
				stringBuilder.Append(" ByRef");
			}
			else
			{
				stringBuilder.Append(text);
			}
			value = ", ";
		}
		if ((callingConventions_0 & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			stringBuilder.Append(value);
			stringBuilder.Append("...");
		}
		return stringBuilder.ToString();
	}

	public static void smethod_2()
	{
		Class1.smethod_0();
		GClass0.appDomain_0.AssemblyResolve += Class4.smethod_0();
	}

	public static MethodBase smethod_3(BindingFlags bindingFlags_0, MethodBase[] methodBase_0, Type[] type_0, ParameterModifier[] parameterModifier_0)
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

	public static void smethod_4(AppDomain appDomain_0)
	{
	}

	public object method_0(object object_0, Type type_0, CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			cultureInfo_0 = CultureInfo.CurrentCulture;
		}
		if (type_0.IsByRef)
		{
			type_0 = type_0.GetElementType();
		}
		if (!type_0.IsPrimitive && type_0.IsInstanceOfType(object_0))
		{
			return object_0;
		}
		Type type = object_0.GetType();
		if (type_0.IsEnum && type.IsPrimitive)
		{
			return Enum.Parse(type_0, object_0.ToString());
		}
		if (type == typeof(DBNull))
		{
			if (type_0 == typeof(DBNull))
			{
				return object_0;
			}
			if ((type_0.IsClass && type_0 != typeof(object)) || type_0.IsInterface)
			{
				return null;
			}
		}
		try
		{
		}
		catch (NotSupportedException)
		{
		}
		return null;
	}

	public static void smethod_5(AppDomain appDomain_0)
	{
		try
		{
			string fullName = Assembly.GetCallingAssembly().FullName;
			appDomain_0.CreateInstance(fullName, "");
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	unsafe static void ijamal0()
	{
		//IL_002d: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_008d: Expected I4, but got O
		//IL_00c5: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected I4, but got Unknown
		//IL_01dc: Expected O, but got I4
		//IL_0280: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_0316: Expected O, but got I4
		//IL_032f: Expected O, but got I4
		//IL_0338: Expected I4, but got O
		//IL_035a: Expected O, but got I4
		//IL_036a: Expected O, but got I4
		//IL_03da: Expected O, but got I4
		//IL_0412: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04b6: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		//IL_04e5: Expected O, but got I4
		//IL_0504: Expected O, but got I4
		//IL_052e: Expected O, but got I4
		//IL_0560: Expected O, but got I4
		//IL_058d: Expected O, but got I4
		//IL_0597: Expected O, but got I4
		//IL_05bc: Expected O, but got I4
		//IL_05d0: Expected O, but got I4
		//IL_05f4: Expected I4, but got O
		//IL_0601: Expected O, but got I4
		//IL_0695: Expected O, but got I4
		//IL_06ab: Expected O, but got I4
		//IL_06bc: Expected O, but got I4
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected I4, but got Unknown
		//IL_06c7: Expected O, but got I4
		//IL_06d1: Expected O, but got I4
		//IL_06db: Expected O, but got I4
		//IL_06e1: Expected I4, but got O
		//IL_0709: Expected O, but got I4
		//IL_0713: Expected O, but got I4
		//IL_0731: Expected O, but got I4
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected O, but got I4
		//IL_075c: Expected O, but got I4
		//IL_0766: Expected O, but got I4
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		MethodBase[] array = null;
		MethodBase[] methodBase_ = array;
		Type[] array2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		array2 = array3;
		string obj = (string)(object)Class0.smethod_1(bindingFlags_, methodBase_, array2, null);
		char[] anyOf = null;
		_ = obj.IndexOfAny(anyOf, -337125632, ((Settings)null).Value) is Settings;
		Settings settings = settings;
		int num = num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int indexB);
		string obj2 = string.Compare("ORZGRVZX", -2056075290, "MLI", indexB, num, ignoreCase: false) as string;
		object obj3 = settings.Value;
		object obj4 = ((obj3 is BindingFlags) ? obj3 : null);
		Type type = type;
		Type type_ = type;
		string obj5 = settings.Times as string;
		IFormatProvider formatProvider = formatProvider;
		uint num2;
		int num3;
		byte b;
		uint num4;
		object obj6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		checked
		{
			num2 = unchecked((uint)(int)((byte*)(byte)Class1.smethod_2((BindingFlags)obj4, null, type_, null, (ParameterModifier[])(object)obj5.ToString(formatProvider)))->ToString(text, formatProvider)) * (279745275u - unchecked((uint)(int)((string)(object)smethod_3(bindingFlags, array, "ZDAFS".StartsWith("GBS", default(StringComparison)) as Type[], null)).ToString()));
			bindingFlags = default(BindingFlags);
			num3 = unchecked((int)string.Concat((IEnumerable<string>)smethod_3(bindingFlags, array, array2, settings.Times as ParameterModifier[])));
			b = 0;
			num4 = 0u * (9u + unchecked((uint)(byte)text.GetEnumerator()));
			obj6 = null;
		}
		string s = ((byte*)num4)->CompareTo(obj6) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		_ = byte.TryParse(text, out result) is IFormatProvider;
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		formatProvider = formatProvider2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		formatProvider = formatProvider3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		object obj7 = byte.Parse(s, provider);
		_003F val = num2 / checked(num3 + ((obj7 is int) ? obj7 : null));
		text = text;
		NumberStyles numberStyles = numberStyles;
		numberStyles = default(NumberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		object obj8 = byte.TryParse(s2, numberStyles, formatProvider, out *(byte*)Class0.smethod_0((settings.Value as Class2).method_0(null, type, text.EndsWith(text, ignoreCase: false, null) as CultureInfo), null));
		BindingFlags bindingFlags_2 = (BindingFlags)obj2.PadLeft(checked(val + (((obj8 is int) ? obj8 : null) - num)), '懅');
		array = array;
		ParameterModifier[] parameterModifier_ = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_2);
		_ = (byte)((string)(object)Class0.smethod_1(bindingFlags_2, methodBase_2, null, parameterModifier_) + (((byte*)null)->Equals(104) as string));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array4);
		do
		{
			try
			{
				while (flag)
				{
					Resources resources = (Resources)(object)Settings.Default;
					resources = resources;
				}
			}
			catch
			{
				try
				{
					array4 = array4;
					Class1.smethod_4(null, array4);
				}
				catch
				{
					_ = (GClass0)(object)"NNWRVSST".TrimStart(null);
				}
			}
		}
		while (flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		do
		{
			_ = (Settings)((Class2)null).method_0(obj6, type, cultureInfo);
		}
		while (flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		while (flag)
		{
			do
			{
				try
				{
					obj6 = obj6;
					obj6 = obj11;
					resolveEventArgs_ = (ResolveEventArgs)(object)Class1.smethod_4((byte[])(object)string.Format("FYRE", arg, null, obj6), array4);
					object obj12 = Class1.smethod_3(resolveEventArgs_);
					object obj13 = ((obj12 is Struct3) ? obj12 : null);
					Struct3 @struct = default(Struct3);
					@struct = (Struct3)obj13;
				}
				catch
				{
					b = (byte)checked(b - b);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					byte num5 = b;
					formatProvider = formatProvider;
					array2 = (Type[])(object)((byte*)num5)->ToString(formatProvider4);
					_ = (string)(object)smethod_3(bindingFlags_3, methodBase_3, type_2, parameterModifier_);
				}
				flag = flag;
			}
			while (flag2);
		}
		try
		{
			Struct2 struct2 = default(Struct2);
		}
		finally
		{
			goto IL_02ec;
		}
		IL_02ec:
		try
		{
			while (true)
			{
				b = 198;
			}
		}
		finally
		{
			try
			{
				object obj15 = ((byte.TryParse("R", out result) as string).CompareTo(obj6) as string).Equals("AXZY", default(StringComparison));
				_ = (Struct3)"DF".Substring((int)((obj15 is int) ? obj15 : null));
			}
			finally
			{
				try
				{
					_ = ((byte*)checked(63u - 103u - 193u))->Equals(obj6) is Struct2;
				}
				finally
				{
					_ = (string)(object)Class0.smethod_1(bindingFlags, Class1.smethod_3(resolveEventArgs_) as MethodBase[], null, null);
					goto IL_0381;
				}
			}
		}
		IL_0381:
		try
		{
		}
		catch
		{
			try
			{
				try
				{
					BindingFlags bindingFlags_4 = bindingFlags;
					object object_ = obj6;
					resolveEventArgs_ = null;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
					MethodBase[] methodBase_4 = (MethodBase[])(object)((byte*)(byte)((string)(object)Class0.smethod_0(Class0.smethod_0(object_, resolveEventArgs_2), null)).ToUpper(cultureInfo))->ToString((IFormatProvider?)null);
					array2 = array2;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_3);
					_ = (byte)Class0.smethod_1(bindingFlags_4, methodBase_4, type_3, parameterModifier_);
					_ = (byte)Class0.smethod_0(((byte*)b)->ToString(text, Class1.smethod_3(resolveEventArgs_) as IFormatProvider), resolveEventArgs_);
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
					_ = (Class1)(object)(text2.Contains("NZOZMXC".Replace("ZEFYMUUJ", text)) as string).Remove((int)checked(318530716u + unchecked((uint)((byte*)b)->CompareTo(string.Format("ZC", null)))));
				}
				finally
				{
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string strA);
					_ = string.CompareOrdinal(strA, "TW") is string;
					goto end_IL_0388;
				}
				end_IL_0388:;
			}
			catch
			{
				Class3 @class = (Class3)(object)Class1.smethod_4(array4, array4);
				@class = @class;
			}
		}
		MethodBase[] methodBase_5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj18);
		Type[] type_4;
		BindingFlags bindingFlags_5;
		BindingFlags bindingFlags_6;
		PropertyInfo[] propertyInfo_;
		Type type_5;
		Type[] type_6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value);
		object obj20;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo culture);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_8);
		do
		{
			bindingFlags = default(BindingFlags);
			byte num6 = (byte)string.Copy("BYP").ToUpper(null);
			obj6 = null;
			methodBase_5 = "W".IndexOf(((byte*)num6)->Equals(obj18) as string) as MethodBase[];
			type_4 = array2;
			bindingFlags_5 = bindingFlags;
			bindingFlags_6 = bindingFlags;
			propertyInfo_ = (PropertyInfo[])(object)Class0.smethod_0(obj6, resolveEventArgs_);
			type_5 = type;
			type_6 = settings.Value as Type[];
			text = text;
			object obj19 = string.IsNullOrWhiteSpace(value);
			obj20 = ((obj19 is BindingFlags) ? obj19 : null);
			string value2 = text + "YNPOJEV" + (((byte*)87)->Equals(b) as string) + "DWVRUUPTH";
			num = (int)checked(unchecked((uint)num) * 3320353226u);
			bindingFlags = default(BindingFlags);
			uint count;
			object object_2;
			Type type_7;
			uint indexA;
			string strB;
			int length;
			bool ignoreCase;
			checked
			{
				count = unchecked((uint)(int)Class1.smethod_2(bindingFlags, Class1.smethod_3(null) as PropertyInfo[], type, (Type[])(object)((byte*)b)->ToString(text), parameterModifier_)) - 13707166u;
				object_2 = obj6;
				type_7 = unchecked((byte*)b)->GetHashCode() as Type;
				indexA = unchecked((uint)(int)Settings.Default) + unchecked((uint)num) * 1627784527u;
				BindingFlags bindingFlags_7 = bindingFlags;
				PropertyInfo[] propertyInfo_2 = null;
				strB = (string)(object)Class1.smethod_2(bindingFlags_7, propertyInfo_2, type, null, (settings.Value as Settings).Times as ParameterModifier[]);
				length = num;
				ignoreCase = flag;
				cultureInfo = null;
				cultureInfo = cultureInfo2;
			}
			_ = "ZAQDQPXTV".IndexOf(value2, startIndex, (int)count, (StringComparison)class2.method_0(object_2, type_7, string.Compare("OWLHRZM", (int)indexA, strB, -10757389, length, ignoreCase, culture) as CultureInfo)) is object;
			obj6 = obj6;
			type = type;
		}
		while (checked(((unchecked((byte)Class0.smethod_1(default(BindingFlags), methodBase_5, type_4, (ParameterModifier[])(object)Class1.smethod_2(bindingFlags_5, (PropertyInfo[])(object)Class1.smethod_2(bindingFlags_6, propertyInfo_, type_5, type_6, byte.Parse((string)(object)Class0.smethod_1((BindingFlags)obj20, (MethodBase[])class2.method_0(object_3, type_8, cultureInfo), array2, null), numberStyles) as ParameterModifier[]), type, array2, parameterModifier_))) != 0) ? 1u : 0u) - (flag ? 1u : 0u) + (1u + (flag ? 1u : 0u)) - ((flag ? 1u : 0u) - (flag ? 1u : 0u))) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		while (true)
		{
			byte num7 = (byte)Class0.smethod_0(obj6, resolveEventArgs_);
			string text3 = text;
			text = text;
			object obj21 = ((byte*)/*isinst with value type is only supported in some contexts*/)->Equals((byte)(b / /*isinst with value type is only supported in some contexts*/));
			object obj22 = text3.Equals(((byte*)((obj21 is byte) ? obj21 : null))->GetHashCode() as string);
			numberStyles = (NumberStyles)((obj22 is NumberStyles) ? obj22 : null);
			formatProvider = formatProvider;
			formatProvider = formatProvider5;
			bool num8 = (byte)(((byte*)num7)->Equals(byte.TryParse("IYZ", default(NumberStyles), provider2, out *(byte*)((byte*)b)->ToString(formatProvider)) as object) as Class2).method_0(null, type, cultureInfo) != 0;
			settings = null;
			object obj23 = settings2.Times;
			checked
			{
				_003F val2 = num8 + ((obj23 is bool) ? obj23 : null);
				text = "DUXGKJWG".ToString();
				object obj24 = text5.CompareTo(byte.Parse(byte.Parse("WRSU") as string, numberStyles, null) as object);
				if (val2 - ((obj24 is bool) ? obj24 : null) != 0)
				{
					try
					{
						b = 135;
					}
					finally
					{
						continue;
					}
				}
				break;
			}
		}
	}
}
