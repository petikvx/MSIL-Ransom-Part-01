using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using ns4;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class Class0 : ApplicationBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3040)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public Class0()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			GClass6.smethod_1(exception_, this);
			throw;
		}
	}

	static Class0()
	{
		GClass11.smethod_0();
		char_1 = new char[1520];
		char[] array = new char[8];
		array[3] = '\u1dc5';
		array[5] = '㫪';
		array[4] = '㔘';
		array[1] = 'ࢨ';
		array[2] = 'ጁ';
		array[7] = 'ᘂ';
		array[6] = '༫';
		array[0] = '㥸';
		string_0 = new string[52];
		char_0 = array;
	}
}
