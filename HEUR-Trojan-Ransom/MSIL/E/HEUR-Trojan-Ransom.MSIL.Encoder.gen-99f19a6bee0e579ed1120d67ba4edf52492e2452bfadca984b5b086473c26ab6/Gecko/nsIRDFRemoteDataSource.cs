using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1D297320-27F7-11d3-BE01-000064657374")]
public interface nsIRDFRemoteDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoadedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.LPStr)] string aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Refresh([MarshalAs(UnmanagedType.U1)] bool aBlocking);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Flush();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FlushTo([MarshalAs(UnmanagedType.LPStr)] string aURI);
}
