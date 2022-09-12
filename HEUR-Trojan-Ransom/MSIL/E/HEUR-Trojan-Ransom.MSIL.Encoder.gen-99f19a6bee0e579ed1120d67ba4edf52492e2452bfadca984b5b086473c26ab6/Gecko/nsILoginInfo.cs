using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("c41b7dff-6b9b-42fe-b78d-113051facb05")]
public interface nsILoginInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHostnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFormSubmitURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormSubmitURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFormSubmitURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormSubmitURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHttpRealmAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpRealm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHttpRealmAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpRealm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsernameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUsernameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsernameFieldAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsernameField);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUsernameFieldAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsernameField);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPasswordAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPasswordAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPasswordFieldAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPasswordField);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPasswordFieldAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPasswordField);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormSubmitURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpRealm, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsernameField, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPasswordField);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLoginInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Matches([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLoginInfo, [MarshalAs(UnmanagedType.U1)] bool ignorePassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoginInfo Clone();
}
