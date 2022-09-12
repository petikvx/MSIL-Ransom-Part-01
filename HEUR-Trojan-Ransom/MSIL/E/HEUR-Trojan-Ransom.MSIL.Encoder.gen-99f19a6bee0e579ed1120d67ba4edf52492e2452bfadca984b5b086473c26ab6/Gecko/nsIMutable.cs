using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("321578d0-03c1-4d95-8821-021ac612d18d")]
public interface nsIMutable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMutableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMutableAttribute([MarshalAs(UnmanagedType.U1)] bool aMutable);
}
