using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

internal sealed class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 30)]
	private struct Struct0
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[15];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0()
	{
		Class3.smethod_0();
		Class4.smethod_0();
	}

	public static void smethod_1(AppDomain appDomain_0)
	{
	}

	public static void smethod_2(AppDomain appDomain_0)
	{
		try
		{
			Class5.smethod_0(appDomain_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	static Class0()
	{
		char[] array = new char[8];
		array[3] = 'ᕳ';
		array[0] = '\u0e3e';
		array[1] = '㜉';
		array[5] = '⽔';
		array[7] = 'ℂ';
		array[2] = 'ᠧ';
		array[6] = '┌';
		array[4] = 'क';
		array_1 = new string[2];
		array_0 = array;
	}

	unsafe static void ebinadufayudob1()
	{
		//IL_0050: Expected O, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Ref, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Ref, but got Unknown
		//IL_00a9: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		//IL_019c: Expected I4, but got O
		//IL_01b0: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got I4
		//IL_030d: Expected I4, but got O
		//IL_0337: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_03ad: Expected O, but got I4
		//IL_03cc: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_0407: Expected I4, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		byte b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		uint num4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		ParameterModifier[] parameterModifier_;
		StringComparison stringComparison;
		PropertyInfo[] propertyInfo_2;
		Type type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		Type[] array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		do
		{
			_003CModule_003E obj = (_003CModule_003E)(object)Settings.Default;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E2;
			_003CModule_003E = obj;
			bool num = (flag = flag);
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			PropertyInfo[] propertyInfo_ = null;
			text = text;
			b = (byte)Class3.smethod_2(bindingFlags_, propertyInfo_, (Type)(object)text.ToString(), null, null);
			uint num2 = (uint)b / 39u;
			object obj2 = ((byte*)214)->GetHashCode();
			BindingFlags bindingFlags_2 = (BindingFlags)((byte*)checked(((obj2 is byte) ? obj2 : null) * unchecked((byte)"PSAAVNPV".Split((char[]?)null))))->ToString((IFormatProvider)(object)Settings.Default);
			obj3 = obj3;
			uint num3;
			checked
			{
				num3 = unchecked((uint)(byte)string.Concat(obj3)) - 119u;
				resolveEventArgs = resolveEventArgs;
			}
			ref _003F reference = ref *(_003F*)num2;
			ref _003F reference2 = ref *(_003F*)num3;
			object obj4 = Class2.smethod_0(resolveEventArgs);
			string obj5;
			MethodBase[] methodBase_2;
			checked
			{
				num4 = (num ? 1u : 0u) + ("WZYYAPXU".Equals(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo(unchecked(Class3.smethod_2(bindingFlags_2, null, System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).CompareTo(((byte*)checked(((obj4 is byte) ? obj4 : null) - b))->GetHashCode() as object) as Type, (Type[])(object)Class9.smethod_2(obj3, resolveEventArgs), ((byte*)b)->CompareTo(null) as ParameterModifier[]))) as string) ? 1u : 0u);
				array = array;
				byte[] array2 = array;
				string s = text;
				formatProvider = formatProvider;
				obj5 = (string)(object)Class7.smethod_2(array2, byte.Parse(s, formatProvider) as byte[]);
				bindingFlags = bindingFlags;
				array3 = array3;
				MethodBase[] methodBase_ = array3;
				parameterModifier_ = null;
				methodBase_2 = (MethodBase[])(object)Class9.smethod_2(null, (ResolveEventArgs)(object)Class9.smethod_0(default(BindingFlags), methodBase_, null, parameterModifier_));
				array4 = null;
			}
			uint startIndex = (uint)(int)Class9.smethod_0(default(BindingFlags), methodBase_2, array4, parameterModifier_) / 2120159494u;
			num5 = num5;
			string text2 = obj5.Substring((int)startIndex, num5);
			string obj6 = Class2.smethod_0(resolveEventArgs) as string;
			int startIndex2 = num5;
			stringComparison = default(StringComparison);
			object obj7 = text2 != obj6.LastIndexOf("WINBYWMJM", startIndex2, stringComparison) as string;
			bindingFlags = (BindingFlags)((obj7 is BindingFlags) ? obj7 : null);
			propertyInfo_2 = text.Equals(obj3) as PropertyInfo[];
			_ = (Type)(object)((byte*)(byte)((byte*)b)->ToString((IFormatProvider?)null))->ToString(formatProvider);
			type = null;
		}
		while (num4 / (((byte)Class3.smethod_2(default(BindingFlags), propertyInfo_2, type, array4, parameterModifier_) != 0) ? 1u : 0u) != 0);
		try
		{
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 @class);
			do
			{
				@class = @class;
				@class = @class;
				@class = @class;
				_ = ((byte*)(byte)string.Concat(obj3, obj3, obj3))->Equals(obj3) is byte;
			}
			while ((byte)((byte*)51)->ToString(formatProvider) != 0);
			goto IL_023d;
		}
		IL_0398:
		object obj9;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison comparisonType);
			do
			{
				string text3 = text;
				string value = text;
				stringComparison = stringComparison;
				_ = text3.LastIndexOf(value, 771292708, comparisonType) is Class0;
			}
			while (1u * ((unchecked((byte)((byte*)b)->ToString()) != 0) ? 1u : 0u) != 0);
			object obj8 = string.Equals(text, text);
			obj9 = ((obj8 is byte) ? obj8 : null);
			formatProvider = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		_ = (Class2)(object)((byte*)obj9)->ToString(formatProvider2);
		string text4 = text;
		object obj10 = ((byte*)checked(122u * (unchecked((uint)checked(b + b)) + 112u)))->Equals(55);
		void @void = text4.Remove((int)((obj10 is int) ? obj10 : null));
		@void = @void;
		try
		{
		}
		finally
		{
			goto IL_0417;
		}
		IL_023d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string separator);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value2);
		while (true)
		{
			BindingFlags bindingFlags_3 = bindingFlags;
			Type type_ = type;
			array4 = (Type[])(object)Settings.Default;
			text = "WKKIMVC";
			_ = (ResolveEventArgs)(object)string.Join<T>(separator, (IEnumerable<T>)null);
			resolveEventArgs = null;
			resolveEventArgs = resolveEventArgs2;
			resolveEventArgs = resolveEventArgs3;
			if (0u / checked(unchecked((((byte)Class3.smethod_2(bindingFlags_3, null, type_, type_2, Class2.smethod_0(resolveEventArgs_) as ParameterModifier[]) != 0) ? 1u : 0u) / 0u) * (1u * ((unchecked((byte)"W".Split((char[]?)null)) != 0) ? 1u : 0u))) == 0)
			{
				break;
			}
			checked
			{
				uint num6;
				do
				{
					num6 = (flag ? 1u : 0u) - (flag ? 1u : 0u);
					text = "VSSECCT";
				}
				while (num6 + (string.IsNullOrWhiteSpace(value2) ? 1u : 0u) != 0);
			}
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
			while (true)
			{
				resolveEventArgs = null;
				resolveEventArgs = resolveEventArgs4;
				object obj11 = Class2.smethod_0(resolveEventArgs_2);
				Class9 class2 = (Class9)(object)Class9.smethod_0((BindingFlags)((obj11 is BindingFlags) ? obj11 : null), array3, null, null);
				class2 = class3;
				class2 = class2;
				if (!flag)
				{
					flag = flag;
					bool num7 = flag;
					BindingFlags bindingFlags_4 = bindingFlags;
					type = type;
					string obj12 = (string)(object)Class3.smethod_2(bindingFlags_4, null, type_3, array4, parameterModifier_);
					string value3 = ((byte*)115)->CompareTo((byte)checked(unchecked((uint)b) - 99u)) as string;
					num5 = -1569666517;
					object obj13 = obj12.LastIndexOf(value3, (int)checked(867991504u * unchecked((uint)num8)));
					checked
					{
						if (unchecked(flag2 / (num7 / checked(((obj13 is bool) ? obj13 : null) * flag))) - 1 == 0)
						{
							break;
						}
					}
				}
			}
		}
		finally
		{
			while ((byte)string.IsInterned((string)(object)Settings.Default) != 0)
			{
				try
				{
					_ = byte.Parse((string)(object)Settings.Default) is string;
				}
				finally
				{
					_ = (Struct3)string.Format("X", obj3);
					Settings settings = (Settings)(object)string.Concat(obj3);
					settings = settings;
					string value4 = text;
					stringComparison = default(StringComparison);
					_ = "SWVKDLMIT".EndsWith(value4, stringComparison) is Class3;
					continue;
				}
			}
			goto IL_0398;
		}
		IL_0417:
		while (true)
		{
			if (checked((flag ? 1u : 0u) * (string.IsNullOrEmpty("ZDXPPJ") ? 1u : 0u)) != 0)
			{
			}
		}
	}
}
