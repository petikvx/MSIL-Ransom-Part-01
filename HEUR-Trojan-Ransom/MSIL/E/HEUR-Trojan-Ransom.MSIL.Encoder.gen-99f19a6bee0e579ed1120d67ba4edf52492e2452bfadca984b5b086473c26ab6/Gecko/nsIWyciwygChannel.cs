using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8b8f3341-46da-40f5-a16f-41a91f5d25dd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWyciwygChannel : nsIRequest, nsIChannel
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
	void WriteToCacheEntry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseCacheEntry(int reason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSecurityInfo([MarshalAs(UnmanagedType.Interface)] nsISupports aSecurityInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCharsetAndSource(int aSource, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCharsetAndSource(ref int aSource, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
}
