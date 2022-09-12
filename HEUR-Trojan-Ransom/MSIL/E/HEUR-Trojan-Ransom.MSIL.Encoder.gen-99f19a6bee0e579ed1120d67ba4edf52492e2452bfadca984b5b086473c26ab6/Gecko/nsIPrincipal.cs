using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("188fc4a2-3157-4956-a7a2-d674991770da")]
public interface nsIPrincipal : nsISerializable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool EqualsConsideringDomain([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetHashValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetDomainAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDomainAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Subsumes([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SubsumesConsideringDomain([MarshalAs(UnmanagedType.Interface)] nsIPrincipal other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckMayLoad([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.U1)] bool report, [MarshalAs(UnmanagedType.U1)] bool allowIfInheritsPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetCspAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCspAttribute(IntPtr aCsp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPreloadCspAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreloadCspAttribute(IntPtr aPreloadCsp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCspJSONAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCspJSON);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetJarPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aJarPrefix);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOriginAttributesAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOrigin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginNoSuffixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginNoSuffix);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginSuffixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aOriginSuffix);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBaseDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aBaseDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetAppStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAppIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetUserContextIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInBrowserElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUnknownAppIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsNullPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsCodebasePrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsExpandedPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSystemPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsOnCSSUnprefixingWhitelist();
}
