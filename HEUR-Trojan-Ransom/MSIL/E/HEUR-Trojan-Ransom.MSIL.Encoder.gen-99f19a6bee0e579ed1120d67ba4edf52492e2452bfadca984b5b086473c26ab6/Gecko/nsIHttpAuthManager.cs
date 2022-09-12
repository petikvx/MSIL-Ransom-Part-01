using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("54f90444-c52b-4d2d-8916-c59a2bb25938")]
public interface nsIHttpAuthManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAuthIdentity([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAuthType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRealm, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserPassword, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAuthIdentity([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHost, int aPort, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAuthType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRealm, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUserPassword, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearAll();
}
