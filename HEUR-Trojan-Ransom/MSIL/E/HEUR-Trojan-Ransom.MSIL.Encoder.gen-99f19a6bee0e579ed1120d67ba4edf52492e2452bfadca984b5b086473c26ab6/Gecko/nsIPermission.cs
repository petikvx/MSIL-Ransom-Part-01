using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bb409a51-2371-4fea-9dc9-b7286a458b8c")]
public interface nsIPermission
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCapabilityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetExpireTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetExpireTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Matches([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.U1)] bool exactHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MatchesURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.U1)] bool exactHost);
}
