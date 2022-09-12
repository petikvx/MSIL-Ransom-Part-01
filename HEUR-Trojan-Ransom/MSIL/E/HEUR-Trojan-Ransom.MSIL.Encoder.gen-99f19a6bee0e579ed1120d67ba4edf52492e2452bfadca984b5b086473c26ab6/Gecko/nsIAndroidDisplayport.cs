using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e1bfbc07-dbae-409d-a5b5-ef57522c1f15")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAndroidDisplayport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLeftAttribute(float aLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTopAttribute(float aTop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRightAttribute(float aRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBottomAttribute(float aBottom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetResolutionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResolutionAttribute(float aResolution);
}
