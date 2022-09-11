using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal sealed class Class0 : Component
{
	public static void smethod_0()
	{
		Class2.smethod_0();
		Control0.smethod_1();
	}

	public static void smethod_1(AppDomain appDomain_0)
	{
	}

	public static void smethod_2(AppDomain appDomain_0)
	{
		try
		{
			Class3.smethod_0(appDomain_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
		}
	}

	static void imozag1(object object_0, object object_1)
	{
		while (true)
		{
		}
	}

	unsafe static void imozagajoduqih3(object object_0, object object_1, object object_2)
	{
		//IL_0025: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a2: Expected Void, but got O
		//IL_011a: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected I4, but got Unknown
		//IL_0156: Expected O, but got I4
		ResolveEventArgs resolveEventArgs_ = (ResolveEventArgs)(object)Settings.Default;
		string text = (string)(object)Class4.smethod_0(null, resolveEventArgs_);
		_ = string.Compare(text, "WTUMBLEJ", ignoreCase: true) is Control1;
		string[] separator = null;
		StringSplitOptions stringSplitOptions = default(StringSplitOptions);
		_ = ref *(byte*)text.Split(separator, default(StringSplitOptions));
		object obj = null;
		obj = null;
		obj = null;
		obj = null;
		byte[] array = (byte[])(object)string.Concat(null, obj, null);
		_ = ref *(byte*)Control3.smethod_1(Control3.smethod_1(array, array), (byte[])(object)"QE".Normalize());
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		object obj2 = byte.TryParse(text, out result);
		object obj3 = ((obj2 is void) ? obj2 : null);
		void @void = @void;
		@void = obj3;
		object[] array2 = array2;
		string.Concat(array2);
		((byte*)checked(25u * (203u - unchecked((uint)(byte)Class4.smethod_0(null, resolveEventArgs_)))))->ToString(text);
		byte num = (byte)Settings.Default;
		IFormatProvider formatProvider = null;
		IFormatProvider provider = (IFormatProvider)(object)((byte*)66)->ToString("J", formatProvider);
		NumberStyles numberStyles = (NumberStyles)Control3.smethod_1(null, null);
		byte num2 = (byte)string.Format(provider, byte.Parse("BF", default(NumberStyles), formatProvider) as string, null);
		StringComparison stringComparison = stringComparison;
		object obj4 = string.Compare(text, text, default(StringComparison));
		byte b = (byte)checked(num + unchecked(num2 / ((obj4 is byte) ? obj4 : null)) - 88);
		_ = ((byte*)b)->Equals(null) is void;
	}
}
