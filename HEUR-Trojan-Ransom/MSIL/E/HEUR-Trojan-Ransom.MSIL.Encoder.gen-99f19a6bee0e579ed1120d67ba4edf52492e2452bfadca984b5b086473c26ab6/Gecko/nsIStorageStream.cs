using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("44a200fe-6c2b-4b41-b4e3-63e8c14e7c0d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStorageStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(uint segmentSize, uint maxSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOutputStream GetOutputStream(int startPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream NewInputStream(int startPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLengthAttribute(uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWriteInProgressAttribute();
}
