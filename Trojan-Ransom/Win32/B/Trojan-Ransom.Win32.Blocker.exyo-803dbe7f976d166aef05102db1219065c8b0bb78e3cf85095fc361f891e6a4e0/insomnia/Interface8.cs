using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[InterfaceType(1)]
[Guid("E7772804-3287-418E-9072-CF2B47238981")]
public interface Interface8
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string Method1();
}
