using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.Attributes;

public sealed class DoNotDistributeAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2416)]
	private struct Struct39
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public DoNotDistributeAttribute(string string_1)
	{
	}

	static DoNotDistributeAttribute()
	{
		char_1 = new char[1208];
		char[] array = new char[8];
		array[0] = '㏞';
		array[4] = '\u05f5';
		array[1] = '\u073c';
		array[5] = 'Ս';
		array[2] = '\u0ad1';
		array[6] = '\u0873';
		array[7] = '㐠';
		array[3] = 'Ƽ';
		string_0 = new string[31];
		char_0 = array;
	}
}
