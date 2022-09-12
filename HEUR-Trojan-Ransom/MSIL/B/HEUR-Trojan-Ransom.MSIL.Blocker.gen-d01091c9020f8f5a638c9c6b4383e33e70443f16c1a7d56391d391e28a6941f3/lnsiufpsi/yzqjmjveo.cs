using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace lnsiufpsi;

internal sealed class yzqjmjveo
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 404)]
	private struct cmddyklcc
	{
	}

	private static readonly object O;

	private static readonly object s = new char[202];

	private static readonly Array I;

	internal static byte m/* Not supported: data(00) */;

	internal static void e(Type[] type_0, int int_0, TypeInfo[] typeInfo_0)
	{
		TypeInfo typeInfo = type_0[int_0].GetTypeInfo();
		if (typeInfo == null)
		{
			throw new NotSupportedException(type_0[int_0].FullName);
		}
		typeInfo_0[int_0] = typeInfo;
	}

	static yzqjmjveo()
	{
		char[] array = new char[8];
		array[5] = '\u0593';
		array[7] = '\u0318';
		array[0] = '\u0a43';
		array[6] = '▶';
		array[4] = '㼑';
		array[3] = '㪾';
		array[1] = '᭢';
		array[2] = '㩴';
		I = new string[11];
		O = array;
	}
}
