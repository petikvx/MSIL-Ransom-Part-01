using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct q
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public static Assembly smethod_0(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class2.smethod_0(resolveEventArgs_0))
		{
			return DomNameTable.assembly_0;
		}
		return null;
	}

	static Class4()
	{
		char[] array_ = new char[18];
		Class4.lmHwvEpClotoTJgPxCeocAmOTQwKA((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		object_0 = array_;
		char[] array = new char[8];
		array[6] = 'Ᏽ';
		array[7] = '㛓';
		array[5] = '⮀';
		array[2] = '⎶';
		array[3] = '㾕';
		array[1] = 'Ⴡ';
		array[4] = '\u0c4a';
		array[0] = '⡼';
		array_1 = new string[4];
		array_0 = array;
	}

	static StringBuilder YVtKPscfiTuvBLRGPUwNaCwrlBef()
	{
		return new StringBuilder();
	}

	static StringBuilder xwKvYxjeVsWceNgRkFnISfMrtVDV(StringBuilder stringBuilder_0, char char_0)
	{
		return stringBuilder_0.Append(char_0);
	}

	static string cGUzEbNgLPYCffDoKEXWmSzAMafm(object object_1)
	{
		return object_1.ToString();
	}

	static void lmHwvEpClotoTJgPxCeocAmOTQwKA(Array array_2, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_2, runtimeFieldHandle_0);
	}
}
