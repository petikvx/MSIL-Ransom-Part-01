using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotObfuscateAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1704)]
	private struct Struct18
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[852];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static DoNotObfuscateAttribute()
	{
		char[] array = new char[8];
		array[6] = '㐿';
		array[5] = '㏷';
		array[7] = 'ᔵ';
		array[1] = '㲁';
		array[2] = 'ڣ';
		array[3] = '㐴';
		array[4] = '㶰';
		array[0] = '㎘';
		object_0 = new string[39];
		array_0 = array;
	}
}
