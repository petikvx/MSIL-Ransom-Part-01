using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52204)]
	private struct Struct0
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 902)]
	private struct Struct1
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly object object_0;

	private static readonly Array array_0;

	private static readonly object object_1;

	internal static byte byte_1/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	static MyComputer()
	{
		array_0 = new char[451];
		char[] array = new char[8];
		array[1] = 'ᅍ';
		array[2] = 'ᾍ';
		array[7] = 'ᅩ';
		array[6] = '㩲';
		array[3] = 'ὶ';
		array[5] = 'ஶ';
		array[4] = '\u05ac';
		array[0] = 'ͺ';
		object_1 = new string[23];
		object_0 = array;
	}
}
