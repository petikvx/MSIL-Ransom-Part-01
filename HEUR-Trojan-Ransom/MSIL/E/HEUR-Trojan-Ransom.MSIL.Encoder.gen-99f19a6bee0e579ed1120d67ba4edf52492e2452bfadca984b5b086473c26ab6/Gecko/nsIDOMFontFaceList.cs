using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2538579c-9472-4fd9-8dc1-d44ce4c1b7ba")]
public interface nsIDOMFontFaceList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMFontFace Item(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();
}
