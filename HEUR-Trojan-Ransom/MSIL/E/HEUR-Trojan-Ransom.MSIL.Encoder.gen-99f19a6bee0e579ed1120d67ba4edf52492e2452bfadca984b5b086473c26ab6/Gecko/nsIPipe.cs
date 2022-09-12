using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("25d0de93-685e-4ea4-95d3-d884e31df63c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPipe
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.U1)] bool nonBlockingInput, [MarshalAs(UnmanagedType.U1)] bool nonBlockingOutput, uint segmentSize, uint segmentCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAsyncInputStream GetInputStreamAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAsyncOutputStream GetOutputStreamAttribute();
}
