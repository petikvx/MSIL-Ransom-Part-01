using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("665c981b-0a0f-4229-ac06-a826e02d4f69")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDomainSet
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Add([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clear();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Contains([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ContainsSuperDomain([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);
}
