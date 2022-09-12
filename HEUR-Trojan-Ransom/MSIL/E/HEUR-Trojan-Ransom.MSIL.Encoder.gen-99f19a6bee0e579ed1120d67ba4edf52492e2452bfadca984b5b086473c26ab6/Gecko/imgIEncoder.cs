using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4baa2d6e-fee7-42df-ae3f-5fbebc0c267c")]
public interface imgIEncoder : nsIInputStream, nsIAsyncInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Available();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Read(IntPtr aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsNonBlocking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CloseWithStatus(int aStatus);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AsyncWait([MarshalAs(UnmanagedType.Interface)] nsIInputStreamCallback aCallback, uint aFlags, uint aRequestedCount, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitFromData([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] data, uint length, uint width, uint height, uint stride, uint inputFormat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase outputOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartImageEncode(uint width, uint height, uint inputFormat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase outputOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddImageFrame([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] data, uint length, uint width, uint height, uint stride, uint frameFormat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase frameOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndImageEncode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetImageBufferUsed();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetImageBuffer();
}
