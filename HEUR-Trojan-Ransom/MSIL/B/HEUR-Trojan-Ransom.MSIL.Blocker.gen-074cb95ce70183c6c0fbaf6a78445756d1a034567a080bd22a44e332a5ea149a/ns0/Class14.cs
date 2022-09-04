using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal sealed class Class14
{
	internal sealed class Class15
	{
		internal static Encoding smethod_0(short short_0, char char_0)
		{
			int num = 0;
			Encoding result;
			do
			{
				result = (((char_0 ^ short_0) - 38) ^ num) switch
				{
					0 => (Encoding)(ICloneable)Encoding.Default, 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static int smethod_1<T>(T gparam_0, int int_0, int int_1, char char_0, char char_1) where T : Random
		{
			int num = 0;
			int result = (((char_0 ^ char_1) - 40) ^ 0) switch
			{
				0 => gparam_0.Next(int_0, int_1), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static Assembly smethod_2(byte[] byte_0, char char_0, char char_1)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			int num = 0;
			Assembly result = (((char_0 ^ char_1) - 46) ^ 0) switch
			{
				0 => (Assembly)(_Assembly)Assembly.Load(byte_0), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static byte[] smethod_3<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : Encoding
		{
			int num = 0;
			byte[] result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 98) ^ num) switch
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

		internal static int smethod_4<T>(T gparam_0, short short_0, char char_0) where T : string
		{
			int num = 0;
			int result;
			do
			{
				result = (((short_0 ^ char_0) - 81) ^ num) switch
				{
					0 => gparam_0.Length, 
					_ => 8, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static string smethod_5<T>(T gparam_0, char char_0, char char_1) where T : ResolveEventArgs
		{
			int num = 0;
			string result = (((char_0 ^ char_1) - 45) ^ 0) switch
			{
				0 => (string)(IComparable)gparam_0.Name, 
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

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static string smethod_0<T>(T gparam_0, short short_0, short short_1) where T : string
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 34) ^ num) switch
			{
				0 => (string)(IEnumerable<char>)string.Intern(gparam_0), 
				_ => null, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static bool smethod_1(DateTime dateTime_0, DateTime dateTime_1, char char_0, char char_1)
	{
		int num = 0;
		bool result = (((char_1 ^ char_0) - 51) ^ 0) switch
		{
			0 => dateTime_0 > dateTime_1, 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static Stream smethod_2<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : Assembly
	{
		int num = 0;
		Stream result = (((short_0 ^ int_0) - 41) ^ 0) switch
		{
			0 => (Stream)(MarshalByRefObject)gparam_0.GetManifestResourceStream(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static byte[] smethod_3<T>(T gparam_0, char char_0, short short_0) where T : MemoryStream
	{
		int num = 0;
		byte[] result = (((char_0 ^ short_0) - 22) ^ 0) switch
		{
			0 => (byte[])(Array)gparam_0.ToArray(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_4(int int_0, int int_1)
	{
		int num = 0;
		int result = (((int_0 ^ int_1) - 59) ^ 0) switch
		{
			0 => Environment.TickCount, 
			_ => 15, 
		};
		num++;
		return result;
	}

	static Class14()
	{
		object_1 = new char[39];
		char[] array = new char[8];
		array[0] = '\u09c4';
		array[5] = 'ᆕ';
		array[7] = '㕒';
		array[6] = 'ፆ';
		array[4] = 'ೡ';
		array[3] = 'え';
		array[2] = '\u0883';
		array[1] = '\u0350';
		array_0 = new string[1];
		object_0 = array;
	}
}
