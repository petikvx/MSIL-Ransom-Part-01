using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1acd16c2-dc59-42fa-9160-4f26c43c1c21")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHttpResponse
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStatusLine([MarshalAs(UnmanagedType.LPStr)] string httpVersion, ushort statusCode, [MarshalAs(UnmanagedType.LPStr)] string description);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeader([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value, [MarshalAs(UnmanagedType.U1)] bool merge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIOutputStream GetBodyOutputStreamAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Write([MarshalAs(UnmanagedType.LPStr)] string data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ProcessAsync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SeizePower();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finish();
}
