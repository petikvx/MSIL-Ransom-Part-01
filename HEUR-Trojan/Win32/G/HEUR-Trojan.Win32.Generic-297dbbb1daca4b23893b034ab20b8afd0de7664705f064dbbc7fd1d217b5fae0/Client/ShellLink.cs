using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Client;

[ComImport]
[Guid("00021401-0000-0000-C000-000000000046")]
internal class ShellLink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ShellLink();
}
