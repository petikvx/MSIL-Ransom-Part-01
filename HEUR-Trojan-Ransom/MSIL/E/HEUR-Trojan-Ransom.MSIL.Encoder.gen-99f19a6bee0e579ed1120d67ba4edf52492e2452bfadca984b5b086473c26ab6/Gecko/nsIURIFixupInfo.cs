using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4819f183-b532-4932-ac09-b309cd853be7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIURIFixupInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetConsumerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetConsumerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aConsumer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetPreferredURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetFixedURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeywordProviderNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeywordProviderName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeywordAsSentAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeywordAsSent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFixupChangedProtocolAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetFixupCreatedAlternateURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOriginalInputAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aOriginalInput);
}
