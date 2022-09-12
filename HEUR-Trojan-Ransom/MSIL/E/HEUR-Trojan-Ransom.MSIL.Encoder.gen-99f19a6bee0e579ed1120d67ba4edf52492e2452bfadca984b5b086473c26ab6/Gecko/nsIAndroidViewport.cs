using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("92ae801d-da9c-4a24-b2b6-344c4af7008b")]
public interface nsIAndroidViewport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetXAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetYAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetPageLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetPageTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetPageRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetPageBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetCssPageLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetCssPageTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetCssPageRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetCssPageBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetZoomAttribute();
}
