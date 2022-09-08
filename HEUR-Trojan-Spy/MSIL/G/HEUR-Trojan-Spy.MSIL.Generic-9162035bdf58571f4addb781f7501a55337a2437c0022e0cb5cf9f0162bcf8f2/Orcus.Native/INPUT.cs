using System.Runtime.InteropServices;

namespace Orcus.Native;

public struct INPUT
{
	internal InputType type;

	internal InputUnion U;

	internal static int Size => Marshal.SizeOf(typeof(INPUT));
}
