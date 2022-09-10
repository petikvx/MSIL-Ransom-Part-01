using System;
using System.Runtime.InteropServices;

public sealed class BabelAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct0
	{
	}

	public const string Version = "4.0.0.0";

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static BabelAttribute()
	{
		char_1 = new char[43];
		char[] array = new char[8];
		array[4] = '㽢';
		array[3] = '϶';
		array[7] = '✸';
		array[0] = '\u0e3a';
		array[1] = '㌬';
		array[2] = '◹';
		array[5] = '㇆';
		array[6] = 'ţ';
		string_0 = new string[1];
		char_0 = array;
	}
}
