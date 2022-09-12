using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("29c29ce6-8ce4-45e6-8d60-36c8fa3e255b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEncodedChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator GetContentEncodingsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetApplyConversionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetApplyConversionAttribute([MarshalAs(UnmanagedType.U1)] bool aApplyConversion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoApplyContentConversions([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aNextListener, [MarshalAs(UnmanagedType.Interface)] ref nsIStreamListener aNewNextListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
}
