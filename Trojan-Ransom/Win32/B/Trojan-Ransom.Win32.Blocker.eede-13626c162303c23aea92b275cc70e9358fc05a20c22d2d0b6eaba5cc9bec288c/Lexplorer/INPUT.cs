using System.Runtime.InteropServices;

namespace Lexplorer;

public struct INPUT
{
	internal uint type;

	internal InputUnion U;

	internal static int Size => Marshal.SizeOf(typeof(INPUT));
}
