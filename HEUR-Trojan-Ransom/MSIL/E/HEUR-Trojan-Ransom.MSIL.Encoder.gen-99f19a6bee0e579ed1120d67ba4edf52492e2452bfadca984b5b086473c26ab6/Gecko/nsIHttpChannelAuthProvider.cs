using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c68f3def-c7c8-4ee8-861c-eef49a48b702")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpChannelAuthProvider : nsICancelable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Cancel(int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel channel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ProcessAuthentication(uint httpStatus, [MarshalAs(UnmanagedType.U1)] bool sslConnectFailed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddAuthorizationHeaders();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForSuperfluousAuth();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Disconnect(int status);
}
