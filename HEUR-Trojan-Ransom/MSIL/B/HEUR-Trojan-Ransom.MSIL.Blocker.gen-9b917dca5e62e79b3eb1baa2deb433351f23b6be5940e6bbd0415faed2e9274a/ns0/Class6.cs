using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Timers;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class6
{
	internal sealed class Class7
	{
		internal static string smethod_0<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : string where U : string
		{
			int num = 0;
			string result = (((int_0 ^ int_1) - 55) ^ 0) switch
			{
				0 => (string)(IEnumerable<char>)Class9.smethod_2((string)gparam_0, (string)gparam_1, 'ɘ', 601), 
				1 => (string)(IEnumerable<char>)Class9.smethod_2((string)gparam_0, (string)gparam_1, 'Ϟ', 991), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Evidence smethod_1<T>(T gparam_0, char char_0, int int_0) where T : Assembly
		{
			int num = 0;
			Evidence result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 39) ^ num) switch
				{
					0 => (Evidence)(IEnumerable)Class9.smethod_4((Assembly)gparam_0, 'Ə', 425), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static Socket smethod_2<T>(T gparam_0, short short_0, short short_1) where T : TcpClient
		{
			int num = 0;
			Socket result;
			do
			{
				result = (((short_0 ^ short_1) - 39) ^ num) switch
				{
					0 => (Socket)(IDisposable)Class9.Class11.smethod_0((TcpClient)gparam_0, (short)87, 124), 
					_ => null, 
				};
				num++;
			}
			while ((short_1 * short_1 + short_1) % 2 != 0);
			return result;
		}

		internal static RegistryProxy smethod_3<T>(T gparam_0, short short_0, char char_0) where T : ServerComputer
		{
			int num = 0;
			RegistryProxy result;
			int num2;
			do
			{
				result = (RegistryProxy)((((char_0 ^ short_0) - 47) ^ num) switch
				{
					0 => Class9.Class10.smethod_2<ServerComputer>((ServerComputer)(object)gparam_0, '\u02f3', (short)746), 
					_ => null, 
				});
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static double smethod_4<T>(T gparam_0, short short_0, char char_0) where T : string
		{
			int num = 0;
			double result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 84) ^ num) switch
				{
					0 => Class12.smethod_1((string)gparam_0, (short)129, (short)244), 
					_ => 0.3316456505837963, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string[] smethod_5<T, U>(U gparam_0, T gparam_1, int int_0, CompareMethod compareMethod_0, int int_1, char char_0) where T : string where U : string
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			string[] result = (((char_0 ^ int_1) - 62) ^ 0) switch
			{
				0 => Class9.Class11.smethod_1((string)gparam_0, (string)gparam_1, int_0, compareMethod_0, '\u0366', '\u0330'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string smethod_6<T>(T gparam_0, int int_0, int int_1) where T : OperatingSystem
		{
			int num = 0;
			string result = (((int_0 ^ int_1) - 125) ^ 0) switch
			{
				0 => Class12.smethod_4((OperatingSystem)gparam_0, 'Æ', (short)230), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string smethod_7(string[] string_0, short short_0, short short_1)
		{
			int num = 0;
			string result = (((short_1 ^ short_0) - 100) ^ 0) switch
			{
				0 => (string)(IEnumerable<char>)Class9.smethod_8(string_0, 803, 802), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static int smethod_8<T>(T gparam_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0, short short_0, char char_0) where T : string
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result;
			do
			{
				result = (((char_0 ^ short_0) - 10) ^ num) switch
				{
					0 => Class9.Class10.smethod_9((string)gparam_0, appWinStyle_0, bool_0, int_0, (short)433, 'ƍ'), 
					_ => int_0, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static string[] smethod_9<T>(T gparam_0, char[] char_0, short short_0, char char_1) where T : string
		{
			int num = 0;
			string[] result = (((short_0 ^ char_1) - 46) ^ 0) switch
			{
				0 => Class9.Class11.smethod_3((string)gparam_0, char_0, (short)183, (short)132), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_10<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : TextWriter where U : string
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 118) ^ num)
				{
				case 0:
					Class9.smethod_9((TextWriter)gparam_0, (string)gparam_1, (short)586, 566);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		internal static void smethod_11<T>(T gparam_0, short short_0, short short_1) where T : StreamWriter
		{
			int num = 0;
			do
			{
				switch (((short_1 ^ short_0) - 0) ^ num)
				{
				case 0:
					Class9.Class11.smethod_4((StreamWriter)gparam_0, 950, (short)950);
					break;
				}
				num++;
			}
			while ((short_1 * short_1 + short_1) % 2 != 0);
		}

		internal static object smethod_12<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : ManagementBaseObject where U : string
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 11) ^ num) switch
				{
					0 => Class12.Class13.smethod_4<ManagementBaseObject, string>((ManagementBaseObject)(object)gparam_0, (string)gparam_1, 'ȉ', 609), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static IPAddress smethod_13<T>(T gparam_0, short short_0, short short_1) where T : string
		{
			int num = 0;
			IPAddress result = (((short_1 ^ short_0) - 61) ^ 0) switch
			{
				0 => Class12.Class13.smethod_5((string)gparam_0, 143, (short)164), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_14<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Socket where U : EndPoint
		{
			int num = 0;
			switch (((short_0 ^ int_0) - 113) ^ 0)
			{
			case 0:
				Class9.Class11.smethod_8((Socket)gparam_0, (EndPoint)gparam_1, 'Ĳ', 278);
				break;
			}
			num++;
		}

		internal static object smethod_15<T, U, V>(U gparam_0, V gparam_1, T gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, bool bool_1, short short_0, int int_0) where T : string where V : Type
		{
			int num = 0;
			object result = (((int_0 ^ short_0) - 24) ^ 0) switch
			{
				0 => Class9.Class11.smethod_9((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1, (short)924, 'μ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_16<T>(T gparam_0, short short_0, char char_0) where T : string
		{
			int num = 0;
			string[] result = (((short_0 ^ char_0) - 42) ^ 0) switch
			{
				0 => (string[])(Array)Class9.smethod_10((string)gparam_0, 'Ó', 183), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static bool bool_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (smethod_1<object, object>(resourceManager_0, null, 191, 131))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Ⴐ.ႨႤ", MyComputer.smethod_2(typeof(Class6), 'ë', 'ô')));
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

	static Class6()
	{
		smethod_0();
	}

	internal static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		Type gparam_;
		Class9.Class10.smethod_0((object)(gparam_ = (Type)(IReflect)typeof(Class6)), 426, 'Ǵ');
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class9.Class11.smethod_11<AppDomain, ResolveEventHandler>(Class9.smethod_12(164, 215), MyComputer.smethod_0, 939, 928);
			}
		}
		finally
		{
			Class9.Class10.smethod_0((object)gparam_, 231, '\u00b8');
		}
	}

	internal static bool smethod_1<T, U>(U gparam_0, T gparam_1, short short_0, short short_1)
	{
		int num = 0;
		bool result;
		do
		{
			result = (((short_0 ^ short_1) - 60) ^ num) switch
			{
				0 => Class9.Class11.smethod_13((object)gparam_0, (object)gparam_1, '\u0302', (short)829), 
				_ => true, 
			};
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
		return result;
	}

	internal static Assembly smethod_2(int int_0, short short_0)
	{
		int num = 0;
		Assembly result = (((int_0 ^ short_0) - 123) ^ 0) switch
		{
			0 => (Assembly)(ICustomAttributeProvider)Class9.Class10.smethod_12(785, 846), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static AppDomain smethod_3(int int_0, char char_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		int num = 0;
		AppDomain result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 20) ^ num) switch
			{
				0 => (AppDomain)(_AppDomain)Class9.smethod_12(551, 596), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_4<T, U, V>(T gparam_0, V gparam_1, U gparam_2, short short_0, short short_1) where T : AppDomain where V : string
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ short_1) - 21) ^ num)
			{
			case 0:
				Class9.Class11.smethod_14((AppDomain)gparam_0, (string)gparam_1, (object)gparam_2, 'ȝ', 597);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static byte[] smethod_5<T>(T gparam_0, short short_0, short short_1) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((short_0 ^ short_1) - 9) ^ num) switch
			{
				1 => Class9.Class10.smethod_13((MemoryStream)gparam_0, 'å', '·'), 
				0 => Class9.Class10.smethod_13((MemoryStream)gparam_0, '\u02f9', 'ʫ'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Assembly smethod_6<T>(byte[] byte_0, byte[] byte_1, T gparam_0, int int_0, short short_0) where T : Evidence
	{
		int num = 0;
		Assembly result = (((short_0 ^ int_0) - 110) ^ 0) switch
		{
			0 => Class9.Class10.smethod_15(byte_0, byte_1, (Evidence)gparam_0, (short)768, '\u034d'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_7(int int_0, char char_0, short short_0)
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ char_0) - 32) ^ num)
			{
			case 0:
				Class12.Class13.smethod_3(int_0, 'Å', 153);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static int smethod_8<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		int result = (((int_0 ^ char_0) - 109) ^ 0) switch
		{
			0 => Class9.Class11.smethod_15((string)gparam_0, (short)198, 233), 
			1 => Class9.Class11.smethod_15((string)gparam_0, (short)1017, 983), 
			2 => Class9.Class11.smethod_15((string)gparam_0, (short)873, 857), 
			_ => 0, 
		};
		num++;
		return result;
	}

	internal static int smethod_9<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, SocketFlags socketFlags_0, short short_0, int int_2) where T : Socket
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_0 ^ int_2) - 53) ^ num) switch
			{
				0 => Class9.smethod_6((Socket)gparam_0, byte_0, int_0, int_1, socketFlags_0, '1', '<'), 
				_ => 8, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static object smethod_10<T>(T gparam_0, object[] object_0, string[] string_0, int int_0, int int_1)
	{
		int num = 0;
		object result = (((int_0 ^ int_1) - 73) ^ 0) switch
		{
			0 => Class12.smethod_0((object)gparam_0, object_0, string_0, 'Ǿ', 'Ǘ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_11(Environment.SpecialFolder specialFolder_0, short short_0, char char_0)
	{
		int num = 0;
		string result = (((short_0 ^ char_0) - 50) ^ 0) switch
		{
			0 => (string)(IEquatable<string>)Class12.smethod_12(specialFolder_0, 'Ɔ', 422), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_12<T, U, V>(V gparam_0, U gparam_1, T gparam_2, int int_0, char char_0) where T : string where U : string where V : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((int_0 ^ char_0) - 69) ^ num) switch
			{
				1 => (string)(IEquatable<string>)Class9.Class11.smethod_16((string)gparam_0, (string)gparam_1, (string)gparam_2, 1023, 946), 
				0 => (string)(IEquatable<string>)Class9.Class11.smethod_16((string)gparam_0, (string)gparam_1, (string)gparam_2, 964, 904), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_13<T, U, V>(U gparam_0, T gparam_1, V gparam_2, int int_0, short short_0) where T : string where U : RegistryKey
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 68) ^ 0)
		{
		case 0:
			Class12.smethod_13((RegistryKey)gparam_0, (string)gparam_1, (object)gparam_2, 1013, '·');
			break;
		}
		num++;
	}

	internal static void smethod_14<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Timer where U : ElapsedEventHandler
	{
		int num = 0;
		switch (((int_0 ^ int_1) - 37) ^ 0)
		{
		case 0:
			Class9.Class11.smethod_18((Timer)gparam_0, (ElapsedEventHandler)gparam_1, 358, 320);
			break;
		}
		num++;
	}

	internal static WindowsIdentity smethod_15(char char_0, char char_1)
	{
		int num = 0;
		WindowsIdentity result;
		do
		{
			result = (((char_1 ^ char_0) - 88) ^ num) switch
			{
				0 => (WindowsIdentity)(ISerializable)Class12.smethod_16(164, 161), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static int smethod_16<T>(T gparam_0, int int_0, int int_1, short short_0, short short_1) where T : Random
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_0 ^ short_1) - 98) ^ num) switch
			{
				0 => Class12.smethod_17((Random)gparam_0, int_0, int_1, 404, 'Ơ'), 
				_ => 14, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static StringBuilder smethod_17<T>(T gparam_0, char char_0, short short_0, int int_0) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result = (((short_0 ^ int_0) - 10) ^ 0) switch
		{
			0 => Class9.smethod_14((StringBuilder)gparam_0, char_0, (short)723, '\u02dd'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_18<T, U, V>(U gparam_0, V gparam_1, T gparam_2, int int_0, short short_0) where T : string where U : WebClient where V : string
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ short_0) - 75) ^ num)
			{
			case 0:
				Class12.Class13.smethod_17((WebClient)gparam_0, (string)gparam_1, (string)gparam_2, '\'', 'C');
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static void smethod_19<T, U>(T gparam_0, U gparam_1, bool bool_1, char char_0, short short_0) where T : RegistryKey where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ char_0) - 93) ^ num)
			{
			case 0:
				Class9.Class11.smethod_20((RegistryKey)gparam_0, (string)gparam_1, bool_1, (short)645, '\u02db');
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static object smethod_20<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where T : string where U : string
	{
		int num = 0;
		object result = (((char_0 ^ int_0) - 67) ^ 0) switch
		{
			0 => Class9.Class11.smethod_21((string)gparam_0, (string)gparam_1, 'ɻ', (short)565), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_21<T, U>(bool bool_1, T gparam_0, U gparam_1, short short_0, int int_0)
	{
		int num = 0;
		object result = (((int_0 ^ short_0) - 18) ^ 0) switch
		{
			0 => Class9.smethod_23(bool_1, (object)gparam_0, (object)gparam_1, (short)352, 269), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ManagementObjectEnumerator smethod_22<T>(T gparam_0, char char_0, char char_1) where T : ManagementObjectCollection
	{
		int num = 0;
		ManagementObjectEnumerator result;
		int num2;
		do
		{
			result = (ManagementObjectEnumerator)((((char_0 ^ char_1) - 56) ^ num) switch
			{
				0 => (IEnumerator)Class9.smethod_24<ManagementObjectCollection>((ManagementObjectCollection)(object)gparam_0, 292, 'ő'), 
				_ => null, 
			});
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_23<T>(T gparam_0, byte[] byte_0, short short_0, short short_1) where T : Encoding
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 5) ^ num) switch
			{
				0 => (string)(IEnumerable)Class12.smethod_19((Encoding)gparam_0, byte_0, (short)917, 'ϣ'), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_24<T>(T gparam_0, char char_0, char char_1) where T : DriveInfo
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 2) ^ num) switch
			{
				0 => Class12.smethod_20((DriveInfo)gparam_0, '\u0315', 864), 
				_ => true, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_25<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : FileSystemProxy where U : string
	{
		int num = 0;
		bool result = (((int_0 ^ char_0) - 101) ^ 0) switch
		{
			0 => Class9.smethod_25<string, FileSystemProxy>((FileSystemProxy)(object)gparam_0, (string)gparam_1, 621, 608), 
			_ => true, 
		};
		num++;
		return result;
	}
}
