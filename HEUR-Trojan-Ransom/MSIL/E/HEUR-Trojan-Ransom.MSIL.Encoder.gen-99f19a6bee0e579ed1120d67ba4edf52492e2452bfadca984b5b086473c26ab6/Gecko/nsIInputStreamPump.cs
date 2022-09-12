using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("400F5468-97E7-4d2b-9C65-A82AECC7AE82")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIInputStreamPump : nsIRequest
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
	void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, long aStreamPos, long aStreamLen, uint aSegmentSize, uint aSegmentCount, [MarshalAs(UnmanagedType.U1)] bool aCloseWhenDone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncRead([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aListenerContext);
}
