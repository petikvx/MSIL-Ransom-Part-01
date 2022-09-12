using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b2596105-3d0d-4e6a-824f-0539713bb879")]
public interface nsIHttpChannel : nsIRequest, nsIChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsPending();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Cancel(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Suspend();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Resume();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsILoadGroup GetLoadGroupAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLoadFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLoadFlagsAttribute(uint aLoadFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetOriginalURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports GetOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIInterfaceRequestor GetNotificationCallbacksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetContentLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContentLengthAttribute(long aContentLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIInputStream Open();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIInputStream Open2();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncOpen2([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetContentDispositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContentDispositionAttribute(uint aContentDisposition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetContentDispositionFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContentDispositionFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetContentDispositionFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContentDispositionFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetContentDispositionHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentDispositionHeader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsILoadInfo GetLoadInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetLoadInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRequestMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetReferrerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetReferrerPolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReferrerWithPolicy([MarshalAs(UnmanagedType.Interface)] nsIURI referrer, uint referrerPolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProtocolVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocolVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetTransferSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetDecodedBodySizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetEncodedBodySizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aValue, [MarshalAs(UnmanagedType.U1)] bool aMerge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEmptyRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitRequestHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitNonDefaultRequestHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowPipeliningAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowPipeliningAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowPipelining);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowSTSAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAllowSTSAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowSTS);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRedirectionLimitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRedirectionLimitAttribute(uint aRedirectionLimit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetResponseStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResponseStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aResponseStatusText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRequestSucceededAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsMainDocumentChannelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsMainDocumentChannelAttribute([MarshalAs(UnmanagedType.U1)] bool aIsMainDocumentChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase header, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase header, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase value, [MarshalAs(UnmanagedType.U1)] bool merge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitResponseHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsNoStoreResponse();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsNoCacheResponse();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsPrivateResponse();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RedirectTo([MarshalAs(UnmanagedType.Interface)] nsIURI aNewURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSchedulingContextIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSchedulingContextIDAttribute(IntPtr aSchedulingContextID);
}
