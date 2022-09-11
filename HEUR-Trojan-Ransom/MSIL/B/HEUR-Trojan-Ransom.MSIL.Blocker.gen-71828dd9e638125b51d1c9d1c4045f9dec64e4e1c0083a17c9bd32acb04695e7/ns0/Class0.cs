using System.IO;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class0
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 58)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[29];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] Byte_0
	{
		get
		{
			try
			{
				return File.ReadAllBytes("");
			}
			catch
			{
			}
			return new byte[0];
		}
	}

	static Class0()
	{
		char[] array = new char[8];
		array[5] = 'ᥲ';
		array[4] = '྿';
		array[2] = '⊧';
		array[0] = '∧';
		array[1] = 'ⷒ';
		array[3] = '╗';
		array[7] = '㽚';
		array[6] = '\u0eca';
		object_2 = new string[5];
		object_0 = array;
	}
}
