using System;
using System.Reflection;
using System.Runtime.InteropServices;

[Obfuscation(StripAfterObfuscation = false)]
internal sealed class YanoAttribute : Attribute
{
	internal sealed class Class2
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 599588)]
		private struct Struct0
		{
		}

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_0/* Not supported: data(00) */;

		private static bool bool_0;

		static Class2()
		{
			char_1 = new char[299794];
			char[] array = new char[8];
			array[4] = '㩖';
			array[5] = 'Ꭿ';
			array[0] = '❘';
			array[7] = '㲴';
			array[2] = '㛍';
			array[3] = '㾶';
			array[1] = 'ᚳ';
			array[6] = '⸑';
			string_0 = new string[1402];
			char_0 = array;
		}
	}

	internal sealed class Class3
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct1
	{
	}

	public const string Version = "1.0.15.0";

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static YanoAttribute()
	{
		char_1 = new char[43];
		char[] array = new char[8];
		array[4] = 'ᙺ';
		array[1] = '㯧';
		array[2] = '⏩';
		array[6] = '㖓';
		array[3] = 'ω';
		array[0] = '⹁';
		array[7] = '\u06d7';
		array[5] = 'ᴍ';
		string_0 = new string[1];
		char_0 = array;
	}
}
