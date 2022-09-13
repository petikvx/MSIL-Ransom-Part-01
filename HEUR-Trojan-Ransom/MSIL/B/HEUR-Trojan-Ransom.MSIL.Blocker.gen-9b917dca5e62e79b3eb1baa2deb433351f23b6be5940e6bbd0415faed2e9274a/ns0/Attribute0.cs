using System;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Timers;
using Microsoft.VisualBasic;

namespace ns0;

internal sealed class Attribute0 : Attribute
{
	public Attribute0(string string_0)
	{
	}

	static Attribute0()
	{
		Class6.smethod_0();
	}

	internal static SettingsBase smethod_0<T>(T gparam_0, short short_0, short short_1) where T : SettingsBase
	{
		int num = 0;
		SettingsBase result = (SettingsBase)((((short_0 ^ short_1) - 88) ^ 0) switch
		{
			0 => Class12.Class13.smethod_0<SettingsBase>((SettingsBase)(object)gparam_0, '\u0014', (short)73), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static void smethod_1<T>(T gparam_0, char char_0, short short_0) where T : Exception
	{
		int num = 0;
		switch (((char_0 ^ short_0) - 107) ^ 0)
		{
		case 0:
			Class9.smethod_3((Exception)gparam_0, 'ô', 203);
			break;
		}
		num++;
	}

	internal static int smethod_2<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : Stream
	{
		int num = 0;
		int result = (((short_0 ^ char_0) - 30) ^ 0) switch
		{
			0 => Class9.smethod_5((Stream)gparam_0, byte_0, int_0, int_1, '\u02df', 649), 
			_ => 9, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_3<T>(T gparam_0, short short_0, char char_0) where T : Assembly
	{
		int num = 0;
		string[] result = (((char_0 ^ short_0) - 50) ^ 0) switch
		{
			0 => (string[])(ICollection)Class12.Class13.smethod_1((Assembly)gparam_0, (short)294, 'Ł'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_4<T>(T gparam_0, char char_0, short short_0) where T : TcpClient
	{
		int num = 0;
		int result;
		do
		{
			result = (((char_0 ^ short_0) - 26) ^ num) switch
			{
				0 => Class9.Class10.smethod_3((TcpClient)gparam_0, 'ɻ', 534), 
				_ => 8, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static bool smethod_5<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : string where U : string
	{
		int num = 0;
		bool result = (((int_1 ^ int_0) - 95) ^ 0) switch
		{
			0 => Class9.Class10.smethod_4((string)gparam_0, (string)gparam_1, '\n', 127), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static void smethod_6<T>(T gparam_0, char char_0, char char_1) where T : Stream
	{
		int num = 0;
		switch (((char_1 ^ char_0) - 82) ^ 0)
		{
		case 0:
			Class12.smethod_3((Stream)gparam_0, 'ɇ', (short)547);
			break;
		}
		num++;
	}

	internal static int smethod_7<T>(T gparam_0, int int_0, short short_0) where T : Array
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((int_0 ^ short_0) - 58) ^ num) switch
			{
				0 => Class9.Class10.smethod_8((Array)gparam_0, (short)563, (short)572), 
				_ => int_0, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_8(char char_0, int int_0)
	{
		int num = 0;
		string result;
		do
		{
			result = (((int_0 ^ char_0) - 63) ^ num) switch
			{
				4 => (string)(IEquatable<string>)Class12.Class13.smethod_2('Þ', 204), 
				3 => (string)(IEquatable<string>)Class12.Class13.smethod_2('Ċ', 283), 
				2 => (string)(IEquatable<string>)Class12.Class13.smethod_2('\u034a', 858), 
				1 => (string)(IEquatable<string>)Class12.Class13.smethod_2('Ǳ', 510), 
				0 => (string)(IEquatable<string>)Class12.Class13.smethod_2('ʎ', 640), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_9<T>(T gparam_0, short short_0, char char_0) where T : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ short_0) - 70) ^ num) switch
			{
				3 => Class9.Class11.smethod_6((string)gparam_0, 251, (short)172), 
				2 => Class9.Class11.smethod_6((string)gparam_0, 618, (short)572), 
				1 => Class9.Class11.smethod_6((string)gparam_0, 71, (short)18), 
				0 => Class9.Class11.smethod_6((string)gparam_0, 637, (short)553), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Process smethod_10<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		Process result = (((int_0 ^ short_0) - 44) ^ 0) switch
		{
			0 => Class12.smethod_9((string)gparam_0, 'Ϟ', 908), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_11<T>(T gparam_0, double double_0, char char_0, short short_0) where T : Timer
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 99) ^ 0)
		{
		case 0:
			Class9.smethod_11((Timer)gparam_0, double_0, 217, '\u008b');
			break;
		}
		num++;
	}

	internal static string smethod_12<T, U, V, W>(W gparam_0, U gparam_1, V gparam_2, T gparam_3, int int_0, char char_0) where T : string where U : string where V : string where W : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ int_0) - 10) ^ num) switch
			{
				0 => Class9.Class10.smethod_10((string)gparam_0, (string)gparam_1, (string)gparam_2, (string)gparam_3, 535, (short)526), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_13<T>(T gparam_0, FileAttributes fileAttributes_0, int int_0, char char_0) where T : string
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ int_0) - 75) ^ num)
			{
			case 0:
				Class9.smethod_13((string)gparam_0, fileAttributes_0, (short)951, (short)1001);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static OperatingSystem smethod_14(char char_0, short short_0)
	{
		int num = 0;
		OperatingSystem result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 17) ^ num) switch
			{
				0 => Class9.Class10.smethod_11(490, 'ƨ'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_15<T>(T gparam_0, WindowsBuiltInRole windowsBuiltInRole_0, int int_0, short short_0) where T : WindowsPrincipal
	{
		int num = 0;
		bool result = (((short_0 ^ int_0) - 91) ^ 0) switch
		{
			0 => Class9.smethod_15((WindowsPrincipal)gparam_0, windowsBuiltInRole_0, 'ͷ', '\u0375'), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static void smethod_16<T>(T gparam_0, byte[] byte_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		switch (((short_0 ^ short_1) - 102) ^ 0)
		{
		case 0:
			Class12.Class13.smethod_8((string)gparam_0, byte_0, 'ˁ', (short)762);
			break;
		}
		num++;
	}

	internal static string smethod_17<T>(T gparam_0, short short_0, short short_1) where T : StringBuilder
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 11) ^ num) switch
			{
				0 => (string)(IEnumerable)Class12.smethod_11((StringBuilder)gparam_0, 351, (short)353), 
				_ => null, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_18<T>(T gparam_0, int int_0, int int_1) where T : string
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 95) ^ 0)
		{
		case 0:
			Class9.Class10.smethod_14((string)gparam_0, (short)30, 81);
			break;
		}
		num++;
	}

	internal static string smethod_19<T>(T gparam_0, short short_0, char char_0)
	{
		int num = 0;
		string result = (((short_0 ^ char_0) - 47) ^ 0) switch
		{
			0 => (string)(ICloneable)Class12.smethod_10((object)gparam_0, (short)995, 898), 
			1 => (string)(ICloneable)Class12.smethod_10((object)gparam_0, (short)17, 115), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_20<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : string where U : string
	{
		int num = 0;
		string[] result;
		int num2;
		do
		{
			result = (((short_0 ^ short_1) - 109) ^ num) switch
			{
				0 => (string[])(IEnumerable)Class12.Class13.smethod_13((string)gparam_0, (string)gparam_1, (short)692, 'ʲ'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static object smethod_21<T, U, V>(T gparam_0, V gparam_1, U gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, short short_0, int int_0) where U : string where V : Type
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ int_0) - 68) ^ num) switch
			{
				0 => Class9.Class10.smethod_6((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, (short)574, (short)568), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_22<T, U, V>(U gparam_0, T gparam_1, V gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool bool_0, bool bool_1, int int_0, int int_1) where T : Type where V : string
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 60) ^ 0)
		{
		case 0:
			Class9.smethod_18((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1, 'ˍ', 'ʠ');
			break;
		}
		num++;
	}

	internal static int smethod_23<T>(T gparam_0, int int_0, char char_0, int int_1) where T : Array
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_0 ^ int_1) - 32) ^ num) switch
			{
				0 => Class12.Class13.smethod_15((Array)gparam_0, int_0, (short)377, (short)322), 
				_ => int_0, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static object smethod_24<T, U>(T gparam_0, U gparam_1, char char_0, char char_1)
	{
		int num = 0;
		object result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 113) ^ num) switch
			{
				0 => Class9.Class10.smethod_17((object)gparam_0, (object)gparam_1, (short)666, 688), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_25<T, U>(U gparam_0, T gparam_1, CompareMethod compareMethod_0, int int_0, short short_0) where T : string where U : string
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int result;
		do
		{
			result = (((short_0 ^ int_0) - 39) ^ num) switch
			{
				0 => Class12.Class13.smethod_16((string)gparam_0, (string)gparam_1, compareMethod_0, (short)267, 'Ť'), 
				_ => int_0, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}
}
