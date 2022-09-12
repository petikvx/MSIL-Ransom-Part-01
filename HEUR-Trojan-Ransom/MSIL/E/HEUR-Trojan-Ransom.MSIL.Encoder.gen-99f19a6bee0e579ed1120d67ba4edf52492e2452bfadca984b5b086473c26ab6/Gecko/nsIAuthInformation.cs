using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0d73639c-2a92-4518-9f92-28f71fea5f20")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAuthInformation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRealmAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRealm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAuthenticationSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAuthenticationScheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUsernameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUsernameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUsername);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPasswordAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPasswordAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDomainAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDomainAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDomain);
}
