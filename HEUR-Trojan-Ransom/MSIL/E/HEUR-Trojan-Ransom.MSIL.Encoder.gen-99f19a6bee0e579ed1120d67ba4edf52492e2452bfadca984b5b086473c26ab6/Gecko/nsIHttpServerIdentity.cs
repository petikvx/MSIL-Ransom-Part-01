using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a89de175-ae8e-4c46-91a5-0dba99bbd284")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpServerIdentity
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetPrimarySchemeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetPrimaryHostAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPrimaryPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Add([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Remove([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Has([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetScheme([MarshalAs(UnmanagedType.LPStr)] string host, int port);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrimary([MarshalAs(UnmanagedType.LPStr)] string scheme, [MarshalAs(UnmanagedType.LPStr)] string host, int port);
}
