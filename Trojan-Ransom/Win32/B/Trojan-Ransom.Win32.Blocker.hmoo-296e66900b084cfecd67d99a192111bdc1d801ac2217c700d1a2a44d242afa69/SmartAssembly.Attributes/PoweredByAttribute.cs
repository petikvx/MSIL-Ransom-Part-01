using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 902)]
	private struct Struct1
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public PoweredByAttribute(string string_0)
	{
	}

	static PoweredByAttribute()
	{
		object_0 = new char[451];
		char[] array = new char[8];
		array[7] = 'І';
		array[5] = '⬗';
		array[2] = '⩉';
		array[4] = '❏';
		array[3] = 'ᾒ';
		array[1] = 'ຑ';
		array[0] = '࿐';
		array[6] = '㨯';
		object_1 = new string[23];
		array_0 = array;
	}
}
