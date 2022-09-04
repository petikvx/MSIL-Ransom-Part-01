using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace ns0;

internal sealed class Class16
{
	internal static string smethod_0<T>(T gparam_0, char char_0, int int_0)
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 7) ^ num) switch
			{
				0 => (string)(IEnumerable)gparam_0.ToString(), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Stream smethod_1<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : Assembly
	{
		int num = 0;
		Stream result;
		do
		{
			result = (((short_0 ^ int_0) - 27) ^ num) switch
			{
				0 => (Stream)(MarshalByRefObject)gparam_0.GetManifestResourceStream(gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string smethod_2<T>(T gparam_0, char char_0, short short_0) where T : ResolveEventArgs
	{
		int num = 0;
		string result = (((char_0 ^ short_0) - 59) ^ 0) switch
		{
			0 => (string)(IEnumerable)gparam_0.Name, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ParameterInfo[] smethod_3<T>(T gparam_0, char char_0, char char_1) where T : MethodBase
	{
		int num = 0;
		ParameterInfo[] result;
		do
		{
			result = (((char_1 ^ char_0) - 44) ^ num) switch
			{
				0 => (ParameterInfo[])(Array)gparam_0.GetParameters(), 
				_ => null, 
			};
			num++;
		}
		while ((char_1 * char_1 + char_1) % 2 != 0);
		return result;
	}

	internal static void smethod_4<T, U, V>(V gparam_0, U gparam_1, T gparam_2, char char_0, int int_0) where U : string where V : AppDomain
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 90) ^ 0)
		{
		case 0:
			gparam_0.SetData(gparam_1, gparam_2);
			break;
		}
		num++;
	}

	internal static byte[] smethod_5<T>(T gparam_0, int int_0, int int_1) where T : MemoryStream
	{
		int num = 0;
		byte[] result = (((int_1 ^ int_0) - 123) ^ 0) switch
		{
			0 => (byte[])(Array)gparam_0.ToArray(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Assembly smethod_6(int int_0, char char_0)
	{
		int num = 0;
		Assembly result = (((int_0 ^ char_0) - 38) ^ 0) switch
		{
			0 => Assembly.GetExecutingAssembly(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_7<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ char_1) - 30) ^ num) switch
			{
				0 => string.Concat(gparam_0, gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_8<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, int int_2) where T : Stream
	{
		int num = 0;
		switch (((short_0 ^ int_2) - 120) ^ 0)
		{
		case 0:
			gparam_0.Write(byte_0, int_0, int_1);
			break;
		}
		num++;
	}
}
