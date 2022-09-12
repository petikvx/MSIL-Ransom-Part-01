using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("826e80c8-d70f-42e2-8aa9-82c05f2a370a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIScreen
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRect(ref int left, ref int top, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAvailRect(ref int left, ref int top, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRectDisplayPix(ref int left, ref int top, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAvailRectDisplayPix(ref int left, ref int top, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LockMinimumBrightness(uint brightness);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnlockMinimumBrightness(uint brightness);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPixelDepthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColorDepthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRotationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRotationAttribute(uint aRotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetContentsScaleFactorAttribute();
}
