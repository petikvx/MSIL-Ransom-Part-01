using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace ns0;

internal sealed class Class12
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct6
	{
	}

	internal sealed class Class13
	{
		internal sealed class Class14
		{
			internal static void smethod_0<T>(T gparam_0, char char_0, char char_1)
			{
				int num = 0;
				int num2;
				do
				{
					switch (((char_1 ^ char_0) - 90) ^ num)
					{
					case 1:
						Monitor.Exit(gparam_0);
						break;
					case 0:
						Monitor.Enter(gparam_0);
						break;
					}
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
			}

			internal static AppDomain smethod_1(char char_0, char char_1)
			{
				int num = 0;
				AppDomain result = (((char_0 ^ char_1) - 109) ^ 0) switch
				{
					0 => (AppDomain)(MarshalByRefObject)AppDomain.CurrentDomain, 
					_ => null, 
				};
				num++;
				return result;
			}

			internal static Encoding smethod_2(char char_0, int int_0)
			{
				int num = 0;
				Encoding result;
				do
				{
					result = (((int_0 ^ char_0) - 106) ^ num) switch
					{
						0 => Encoding.Default, 
						_ => null, 
					};
					num++;
				}
				while ((char_0 * char_0 + char_0) % 2 != 0);
				return result;
			}

			internal static byte[] smethod_3<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Encoding where U : string
			{
				int num = 0;
				byte[] result;
				int num2;
				do
				{
					result = (((int_0 ^ char_0) - 87) ^ num) switch
					{
						0 => (byte[])(Array)gparam_0.GetBytes(gparam_1), 
						_ => null, 
					};
					num++;
					num2 = char_0 * char_0;
					num2 = char_0 + num2;
				}
				while (num2 % 2 != 0);
				return result;
			}

			internal static int smethod_4(int int_0, short short_0)
			{
				int num = 0;
				int result;
				do
				{
					result = (((int_0 ^ short_0) - 98) ^ num) switch
					{
						0 => Environment.TickCount, 
						_ => 6, 
					};
					num++;
				}
				while ((short_0 * short_0 + short_0) % 2 != 0);
				return result;
			}
		}

		internal static DateTime smethod_0(short short_0, int int_0)
		{
			int num = 0;
			DateTime result;
			do
			{
				result = (((short_0 ^ int_0) - 74) ^ num) switch
				{
					0 => DateTime.Now, 
					_ => default(DateTime), 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static char[] smethod_1<T>(T gparam_0, char char_0, short short_0) where T : string
		{
			int num = 0;
			char[] result;
			do
			{
				result = (((char_0 ^ short_0) - 115) ^ num) switch
				{
					0 => (char[])(Array)gparam_0.ToCharArray(), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static void smethod_2<T>(T gparam_0, short short_0, char char_0) where T : ResourceManager
		{
			int num = 0;
			switch (((char_0 ^ short_0) - 51) ^ 0)
			{
			case 0:
				gparam_0.ReleaseAllResources();
				break;
			}
			num++;
		}

		internal static Assembly smethod_3(byte[] byte_0, char char_0, short short_0)
		{
			int num = 0;
			Assembly result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 25) ^ num) switch
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

		internal static MethodInfo smethod_4<T>(T gparam_0, int int_0, int int_1) where T : Assembly
		{
			int num = 0;
			MethodInfo result = (((int_1 ^ int_0) - 32) ^ 0) switch
			{
				0 => (MethodInfo)(MethodBase)gparam_0.EntryPoint, 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static bool smethod_5(DateTime dateTime_0, DateTime dateTime_1, char char_0, char char_1)
		{
			int num = 0;
			bool result;
			do
			{
				result = (((char_0 ^ char_1) - 99) ^ num) switch
				{
					0 => dateTime_0 > dateTime_1, 
					_ => true, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}
	}

	internal sealed class Class15
	{
		internal static int smethod_0<T>(T gparam_0, int int_0, int int_1, char char_0, char char_1) where T : Random
		{
			int num = 0;
			int result = (((char_1 ^ char_0) - 10) ^ 0) switch
			{
				0 => gparam_0.Next(int_0, int_1), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static void smethod_1<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : ResolveEventHandler where U : AppDomain
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 77) ^ 0)
			{
			case 0:
				gparam_0.ResourceResolve += gparam_1;
				break;
			}
			num++;
		}

		internal static object smethod_2<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : ResourceManager where U : string
		{
			int num = 0;
			object result = (((int_0 ^ int_1) - 71) ^ 0) switch
			{
				0 => gparam_0.GetObject(gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static int smethod_3<T>(T gparam_0, int int_0, int int_1, char char_0) where T : Array
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((int_1 ^ char_0) - 32) ^ num) switch
				{
					0 => gparam_0.GetLength(int_0), 
					_ => 4, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static Assembly smethod_4<T>(byte[] byte_0, byte[] byte_1, T gparam_0, char char_0, char char_1) where T : Evidence
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			int num = 0;
			Assembly result = (((char_1 ^ char_0) - 115) ^ 0) switch
			{
				0 => (Assembly)(IEvidenceFactory)Assembly.Load(byte_0, byte_1, (Evidence)gparam_0), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	private static readonly object object_0;

	private static readonly Array array_0;

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static int smethod_0<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, int int_2, int int_3) where T : Stream
	{
		int num = 0;
		int result = (((int_2 ^ int_3) - 46) ^ 0) switch
		{
			0 => gparam_0.Read(byte_1, int_0, int_1), 
			_ => int_1, 
		};
		num++;
		return result;
	}

	internal static string smethod_1<T>(T gparam_0, short short_0, char char_0) where T : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ char_0) - 45) ^ num) switch
			{
				0 => (string)(IComparable)string.Intern(gparam_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static StringBuilder smethod_2<T>(T gparam_0, char char_0, char char_1, int int_0) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result;
		int num2;
		do
		{
			result = (((int_0 ^ char_1) - 64) ^ num) switch
			{
				0 => gparam_0.Append(char_0), 
				_ => null, 
			};
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static int smethod_3<T>(T gparam_0, int int_0, int int_1) where T : string
	{
		int num = 0;
		int result = (((int_1 ^ int_0) - 24) ^ 0) switch
		{
			0 => gparam_0.Length, 
			_ => 10, 
		};
		num++;
		return result;
	}

	internal static object smethod_4<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : AppDomain
	{
		int num = 0;
		object result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 89) ^ num) switch
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

	internal static string[] smethod_5<T>(T gparam_0, char char_0, char char_1) where T : Assembly
	{
		int num = 0;
		string[] result = (((char_1 ^ char_0) - 113) ^ 0) switch
		{
			0 => gparam_0.GetManifestResourceNames(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Evidence smethod_6<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		int num = 0;
		Evidence result;
		do
		{
			result = (((char_0 ^ int_0) - 114) ^ num) switch
			{
				0 => ((Assembly)gparam_0).get_Evidence(), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	static Class12()
	{
		array_0 = new char[39];
		char[] array = new char[8];
		array[7] = 'ᴘ';
		array[2] = 'ή';
		array[3] = 'ᅔ';
		array[0] = 'Ǣ';
		array[1] = '⾁';
		array[6] = 'Џ';
		array[5] = '\u3103';
		array[4] = 'ѫ';
		array_1 = new string[1];
		object_0 = array;
	}
}
