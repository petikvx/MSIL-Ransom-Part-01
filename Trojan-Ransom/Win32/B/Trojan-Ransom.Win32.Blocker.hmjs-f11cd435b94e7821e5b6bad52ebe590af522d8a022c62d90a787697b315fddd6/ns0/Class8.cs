using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class8
{
	internal sealed class Class9
	{
		internal sealed class Class10
		{
			internal static Assembly smethod_0(char char_0, int int_0)
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				int num = 0;
				Assembly result;
				do
				{
					result = (((char_0 ^ int_0) - 93) ^ num) switch
					{
						0 => (Assembly)(IEvidenceFactory)Assembly.GetExecutingAssembly(), 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static bool smethod_1<T>(T gparam_0, short short_0, int int_0) where T : string
			{
				int num = 0;
				bool result;
				int num2;
				do
				{
					result = (((int_0 ^ short_0) - 6) ^ num) switch
					{
						0 => File.Exists(gparam_0), 
						_ => true, 
					};
					num++;
					num2 = short_0 * short_0;
					num2 = short_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static void smethod_2<T, U, V>(U gparam_0, V gparam_1, T gparam_2, int int_0, int int_1) where U : AppDomain where V : string
			{
				int num = 0;
				switch (((int_1 ^ int_0) - 107) ^ 0)
				{
				case 0:
					gparam_0.SetData(gparam_1, gparam_2);
					break;
				}
				num++;
			}

			internal static void smethod_3<T>(T gparam_0, char char_0, int int_0)
			{
				int num = 0;
				do
				{
					switch (((char_0 ^ int_0) - 41) ^ num)
					{
					case 1:
						Monitor.Exit(gparam_0);
						break;
					case 0:
						Monitor.Enter(gparam_0);
						break;
					}
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
			}

			internal static void smethod_4<T>(T gparam_0, short short_0, short short_1) where T : Array
			{
				int num = 0;
				switch (((short_1 ^ short_0) - 84) ^ 0)
				{
				case 0:
					Array.Reverse(gparam_0);
					break;
				}
				num++;
			}

			internal static object smethod_5<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where T : string where U : ResourceManager
			{
				int num = 0;
				object result = (((char_1 ^ char_0) - 107) ^ 0) switch
				{
					0 => gparam_0.GetObject(gparam_1), 
					_ => null, 
				};
				num++;
				return result;
			}
		}

		internal static string smethod_0<T>(T gparam_0, char char_0, short short_0)
		{
			int num = 0;
			string result = (((short_0 ^ char_0) - 106) ^ 0) switch
			{
				0 => gparam_0.ToString(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static object smethod_1<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : AppDomain
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((int_0 ^ short_0) - 17) ^ num) switch
				{
					0 => gparam_0.GetData(gparam_1), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static int smethod_2<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, short short_0) where T : Stream
		{
			int num = 0;
			int result;
			do
			{
				result = (((int_2 ^ short_0) - 119) ^ num) switch
				{
					0 => gparam_0.Read(byte_0, int_0, int_1), 
					_ => 10, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static void smethod_3<T>(T gparam_0, short short_0, short short_1) where T : RegistryKey
		{
			int num = 0;
			switch (((short_1 ^ short_0) - 120) ^ 0)
			{
			case 0:
				gparam_0.Close();
				break;
			}
			num++;
		}

		internal static int smethod_4(int int_0, short short_0)
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 67) ^ num) switch
				{
					0 => Environment.TickCount, 
					_ => int_0, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string smethod_5(Environment.SpecialFolder specialFolder_0, short short_0, int int_0)
		{
			int num = 0;
			string result;
			do
			{
				result = (((int_0 ^ short_0) - 10) ^ num) switch
				{
					0 => (string)(ICloneable)Environment.GetFolderPath(specialFolder_0), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static string smethod_6(short short_0, short short_1)
		{
			int num = 0;
			string result;
			do
			{
				result = (((short_1 ^ short_0) - 31) ^ num) switch
				{
					0 => (string)(IEnumerable)Application.get_ExecutablePath(), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static Encoding smethod_7(char char_0, char char_1)
		{
			int num = 0;
			Encoding result = (((char_1 ^ char_0) - 104) ^ 0) switch
			{
				0 => (Encoding)(ICloneable)Encoding.Default, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static byte[] smethod_8<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Encoding where U : string
		{
			int num = 0;
			byte[] result;
			int num2;
			do
			{
				result = (((int_0 ^ short_0) - 2) ^ num) switch
				{
					0 => (byte[])(Array)gparam_0.GetBytes(gparam_1), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static Assembly smethod_9(byte[] byte_0, short short_0, int int_0)
		{
			int num = 0;
			Assembly result = (((int_0 ^ short_0) - 7) ^ 0) switch
			{
				0 => Assembly.Load(byte_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static MethodInfo smethod_10<T>(T gparam_0, short short_0, short short_1) where T : Assembly
		{
			int num = 0;
			MethodInfo result = (((short_0 ^ short_1) - 124) ^ 0) switch
			{
				0 => gparam_0.EntryPoint, 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class11
	{
	}

	internal static StringBuilder smethod_0<T>(T gparam_0, char char_0, char char_1, char char_2) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result;
		int num2;
		do
		{
			result = (((char_2 ^ char_1) - 31) ^ num) switch
			{
				0 => (StringBuilder)(ISerializable)gparam_0.Append(char_0), 
				_ => null, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_1<T>(T gparam_0, int int_0, int int_1, short short_0, short short_1) where T : Random
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 24) ^ num) switch
			{
				0 => gparam_0.Next(int_0, int_1), 
				_ => int_1, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static byte[] smethod_2<T>(T gparam_0, int int_0, short short_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 30) ^ num) switch
			{
				0 => (byte[])(Array)gparam_0.ToArray(), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static char[] smethod_3<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		char[] result;
		do
		{
			result = (((short_0 ^ int_0) - 73) ^ num) switch
			{
				0 => (char[])(Array)gparam_0.ToCharArray(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static string smethod_4<T>(T gparam_0, short short_0, int int_0) where T : ResolveEventArgs
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 107) ^ 0) switch
		{
			0 => (string)(IEquatable<string>)gparam_0.Name, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Evidence smethod_5<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		int num = 0;
		Evidence result;
		do
		{
			result = (((int_0 ^ char_0) - 102) ^ num) switch
			{
				0 => (Evidence)(IEnumerable)((Assembly)gparam_0).get_Evidence(), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static void smethod_6<T, U, V>(U gparam_0, V gparam_1, T gparam_2, char char_0, int int_0) where U : RegistryKey where V : string
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 60) ^ 0)
		{
		case 0:
			gparam_0.SetValue(gparam_1, gparam_2);
			break;
		}
		num++;
	}
}
