using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("C4BC4050-6178-4BD1-A4B8-6398321F3247")]
[InterfaceType(1)]
public interface Interface9
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string Method1();
}
