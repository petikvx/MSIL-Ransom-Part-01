using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("63fff172-2564-4138-96c6-3ae7d245fbed")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProxyInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetResolveFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFailoverTimeoutAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo GetFailoverProxyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFailoverProxyAttribute([MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aFailoverProxy);
}
