using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6
	{
		internal sealed class Class7
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
			private struct Struct4
			{
			}

			private static readonly Array array_0;

			private static readonly object object_0;

			private static readonly Array array_1;

			internal static byte byte_0/* Not supported: data(00) */;

			static Class7()
			{
				object_0 = new char[39];
				char[] array = new char[8];
				array[0] = '\u0cc9';
				array[7] = '\u0ad4';
				array[1] = 'პ';
				array[6] = 'ử';
				array[3] = 'ଽ';
				array[2] = '⁜';
				array[5] = '㈄';
				array[4] = 'މ';
				array_1 = new string[1];
				array_0 = array;
			}
		}

		internal static Assembly smethod_0(int int_0, int int_1)
		{
			int num = 0;
			Assembly result = (((int_0 ^ int_1) - 3) ^ 0) switch
			{
				0 => (Assembly)(ISerializable)Assembly.GetExecutingAssembly(), 
				1 => (Assembly)(ISerializable)Assembly.GetExecutingAssembly(), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	internal sealed class Class8
	{
		internal sealed class Class9
		{
		}
	}

	internal static object smethod_0<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : ResourceManager where U : string
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ int_0) - 36) ^ num) switch
			{
				0 => gparam_0.GetObject(gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static byte[] smethod_1<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Encoding where U : string
	{
		int num = 0;
		byte[] result = (((short_0 ^ short_1) - 99) ^ 0) switch
		{
			0 => (byte[])(Array)gparam_0.GetBytes(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}
}
