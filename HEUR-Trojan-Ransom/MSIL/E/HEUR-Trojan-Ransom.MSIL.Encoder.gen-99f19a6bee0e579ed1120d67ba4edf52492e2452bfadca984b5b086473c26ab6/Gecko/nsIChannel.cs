using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2c389865-23db-4aa7-9fe5-60cc7b00697e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIChannel : nsIRequest
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
	nsIURI GetOriginalURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aOriginalURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetOwnerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInterfaceRequestor GetNotificationCallbacksAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetSecurityInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentCharset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetContentLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentLengthAttribute(long aContentLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream Open();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream Open2();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncOpen2([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetContentDispositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentDispositionAttribute(uint aContentDisposition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentDispositionFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContentDispositionFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentDispositionFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContentDispositionFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetContentDispositionHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentDispositionHeader);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsILoadInfo GetLoadInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoadInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);
}
