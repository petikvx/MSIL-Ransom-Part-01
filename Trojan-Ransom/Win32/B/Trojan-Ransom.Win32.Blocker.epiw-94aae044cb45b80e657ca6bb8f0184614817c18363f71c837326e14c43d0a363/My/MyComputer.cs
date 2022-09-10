using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 505552)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	static MyComputer()
	{
		object_1 = new char[252776];
		char[] array = new char[8];
		array[7] = '㇁';
		array[0] = '㷚';
		array[4] = '૩';
		array[1] = '㔺';
		array[6] = '㔬';
		array[2] = 'অ';
		array[3] = '㑐';
		array[5] = '⽃';
		object_2 = new string[89];
		object_0 = array;
	}
}
