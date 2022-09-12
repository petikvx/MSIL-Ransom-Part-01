using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5a19ca27-e041-4aca-8287-eb248d4c50c0")]
public interface nsIAsyncStreamCopier : nsIRequest
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
	void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream aSource, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream aSink, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aTarget, [MarshalAs(UnmanagedType.U1)] bool aSourceBuffered, [MarshalAs(UnmanagedType.U1)] bool aSinkBuffered, uint aChunkSize, [MarshalAs(UnmanagedType.U1)] bool aCloseSource, [MarshalAs(UnmanagedType.U1)] bool aCloseSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncCopy([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports aObserverContext);
}
