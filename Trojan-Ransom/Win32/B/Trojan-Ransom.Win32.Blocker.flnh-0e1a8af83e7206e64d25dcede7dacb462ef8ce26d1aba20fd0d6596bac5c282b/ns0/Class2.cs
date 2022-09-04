using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal sealed class Class2
{
	internal sealed class Class3
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 233527)]
		private struct Struct2
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 176)]
		private struct Struct3
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;

		private static bool bool_0;

		private static readonly object object_0;

		private static readonly object object_1;

		private static readonly object object_2;

		internal static byte byte_1/* Not supported: data(00) */;

		internal static void smethod_0<T>(T gparam_0, char char_0, int int_0) where T : ResourceManager
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 46) ^ 0)
			{
			case 0:
				gparam_0.ReleaseAllResources();
				break;
			}
			num++;
		}

		internal static Encoding smethod_1(char char_0, char char_1)
		{
			int num = 0;
			Encoding result = (((char_1 ^ char_0) - 38) ^ 0) switch
			{
				0 => Encoding.Default, 
				_ => null, 
			};
			num++;
			return result;
		}

		static Class3()
		{
			object_1 = new char[88];
			char[] array = new char[8];
			array[3] = 'ע';
			array[6] = '⦫';
			array[0] = '㪘';
			array[4] = 'Ƃ';
			array[7] = '㿑';
			array[5] = 'ⴠ';
			array[2] = 'ຳ';
			array[1] = 'ᅎ';
			object_2 = new string[4];
			object_0 = array;
		}
	}

	internal sealed class Class4
	{
		internal static int smethod_0<T>(T gparam_0, int int_0, int int_1, char char_0, short short_0) where T : Random
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 102) ^ num) switch
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
	}

	internal static int smethod_0(short short_0, char char_0)
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((char_0 ^ short_0) - 44) ^ num) switch
			{
				0 => Environment.TickCount, 
				_ => 7, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Assembly smethod_1(byte[] byte_0, int int_0, short short_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		int num = 0;
		Assembly result;
		do
		{
			result = (((int_0 ^ short_0) - 81) ^ num) switch
			{
				0 => (Assembly)(_Assembly)Assembly.Load(byte_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static MethodInfo smethod_2<T>(T gparam_0, short short_0, char char_0) where T : Assembly
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		int num = 0;
		MethodInfo result = (((char_0 ^ short_0) - 100) ^ 0) switch
		{
			0 => (MethodInfo)(_MethodInfo)gparam_0.EntryPoint, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_3<T>(T gparam_0, int int_0, short short_0, char char_0) where T : Array
	{
		int num = 0;
		int result = (((char_0 ^ short_0) - 108) ^ 0) switch
		{
			0 => gparam_0.GetLength(int_0), 
			_ => 5, 
		};
		num++;
		return result;
	}
}
