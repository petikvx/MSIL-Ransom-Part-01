using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e7570e5a-f1d6-452d-b4f8-b35fdc63aa03")]
public interface nsIDocShellLoadInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetReferrerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetOriginalURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoadReplaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadReplaceAttribute([MarshalAs(UnmanagedType.U1)] bool aLoadReplace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInheritOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInheritOwnerAttribute([MarshalAs(UnmanagedType.U1)] bool aInheritOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOwnerIsExplicitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOwnerIsExplicitAttribute([MarshalAs(UnmanagedType.U1)] bool aOwnerIsExplicit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetLoadTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadTypeAttribute(IntPtr aLoadType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetSHEntryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSHEntryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetPostDataStreamAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPostDataStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostDataStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetHeadersStreamAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeadersStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeadersStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSendReferrerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSendReferrerAttribute([MarshalAs(UnmanagedType.U1)] bool aSendReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetReferrerPolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerPolicyAttribute(IntPtr aReferrerPolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSrcdocLoadAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSrcdocDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrcdocData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDocShell GetSourceDocShellAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSourceDocShellAttribute([MarshalAs(UnmanagedType.Interface)] nsIDocShell aSourceDocShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
}
