using System;
using System.Runtime.InteropServices;

namespace ns4;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class GAttribute1 : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2086)]
	private struct Struct7
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static GAttribute1()
	{
		GClass11.smethod_0();
		char_1 = new char[1043];
		char[] array = new char[8];
		array[4] = '㔘';
		array[7] = 'ᘂ';
		array[3] = '\u1dc5';
		array[1] = 'ࢨ';
		array[0] = '㥸';
		array[5] = '㫪';
		array[6] = '༫';
		array[2] = 'ጁ';
		string_0 = new string[46];
		char_0 = array;
	}
}
