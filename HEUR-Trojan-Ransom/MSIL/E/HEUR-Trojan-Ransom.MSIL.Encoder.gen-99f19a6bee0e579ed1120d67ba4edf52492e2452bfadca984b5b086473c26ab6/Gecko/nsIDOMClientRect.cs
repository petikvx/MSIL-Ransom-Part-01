using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("B2F824C4-D9D3-499B-8D3B-45C8245497C6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMClientRect
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetHeightAttribute();
}
