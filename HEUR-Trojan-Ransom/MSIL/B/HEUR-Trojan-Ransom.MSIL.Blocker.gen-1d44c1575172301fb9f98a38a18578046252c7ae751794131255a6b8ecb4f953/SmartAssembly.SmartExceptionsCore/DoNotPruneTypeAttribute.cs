using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class DoNotPruneTypeAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1026)]
	private struct Struct6
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[513];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	static DoNotPruneTypeAttribute()
	{
		char[] array = new char[8];
		array[0] = '㎘';
		array[5] = '㏷';
		array[3] = '㐴';
		array[4] = '㶰';
		array[7] = 'ᔵ';
		array[2] = 'ڣ';
		array[6] = '㐿';
		array[1] = '㲁';
		object_2 = new string[34];
		object_0 = array;
	}
}
