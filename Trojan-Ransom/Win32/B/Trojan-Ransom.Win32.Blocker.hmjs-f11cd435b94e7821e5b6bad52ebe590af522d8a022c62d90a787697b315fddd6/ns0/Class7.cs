using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class7
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 346)]
	private struct Struct3
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0;

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static int smethod_0<T>(T gparam_0, int int_0, int int_1, int int_2, short short_0) where T : Random
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_0 ^ int_2) - 111) ^ num) switch
			{
				0 => Class8.smethod_1((Random)gparam_0, int_0, int_1, (short)965, (short)989), 
				_ => int_1, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_1<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : string
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 97) ^ num) switch
			{
				1 => (string)(IEquatable<string>)Class12.Class13.smethod_0((string)gparam_0, (string)gparam_1, 877, '\u0378'), 
				0 => (string)(IEquatable<string>)Class12.Class13.smethod_0((string)gparam_0, (string)gparam_1, 103, 'r'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Assembly smethod_2(int int_0, char char_0)
	{
		int num = 0;
		Assembly result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 109) ^ num) switch
			{
				1 => Class8.Class9.Class10.smethod_0('Ƥ', 505), 
				0 => Class8.Class9.Class10.smethod_0('\u0096', 203), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static byte[] smethod_3<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result = (((int_0 ^ char_0) - 1) ^ 0) switch
		{
			0 => (byte[])(IList)Class8.smethod_2((MemoryStream)gparam_0, 255, (short)225), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_4<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		int num = 0;
		string[] result = (((char_0 ^ int_0) - 77) ^ 0) switch
		{
			0 => (string[])(Array)Class12.Class13.smethod_1((Assembly)gparam_0, 'Ȭ', 600), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static RegistryKey smethod_5<T, U>(U gparam_0, T gparam_1, bool bool_0, short short_0, int int_0) where T : string where U : RegistryKey
	{
		int num = 0;
		RegistryKey result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 77) ^ num) switch
			{
				0 => (RegistryKey)(IDisposable)Class12.Class13.smethod_2((RegistryKey)gparam_0, (string)gparam_1, bool_0, '\u0328', (short)862), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static char[] smethod_6<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		char[] result;
		do
		{
			result = (((short_0 ^ int_0) - 61) ^ num) switch
			{
				0 => (char[])(Array)Class8.smethod_3((string)gparam_0, 709, (short)652), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	static Class7()
	{
		array_0 = new char[173];
		char[] array = new char[8];
		array[3] = '㛍';
		array[6] = 'ڰ';
		array[2] = '⯔';
		array[5] = 'Ⱐ';
		array[1] = 'ޅ';
		array[4] = 'ᱢ';
		array[7] = 'ᕮ';
		array[0] = '⥅';
		object_1 = new string[7];
		object_0 = array;
	}
}
