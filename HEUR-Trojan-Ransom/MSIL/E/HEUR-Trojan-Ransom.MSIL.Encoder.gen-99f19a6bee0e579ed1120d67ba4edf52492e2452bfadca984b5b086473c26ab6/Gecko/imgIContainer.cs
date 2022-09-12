using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a8dbee24-ff86-4755-b40e-51175caf31af")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface imgIContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIntrinsicSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetIntrinsicRatioAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint OptimalImageSizeForDest(gfxSize aDest, uint aWhichFrame, IntPtr aFilter, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAnimatedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetFrame(uint aWhichFrame, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetFrameAtSize(uint aSize, uint aWhichFrame, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsOpaque();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsImageContainerAvailable(IntPtr aManager, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetImageContainer(IntPtr aManager, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr Draw(gfxContext aContext, uint aSize, IntPtr aRegion, uint aWhichFrame, IntPtr aFilter, IntPtr aSVGContext, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartDecoding();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestDecodeForSize(uint aSize, uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LockImage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnlockImage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestDiscard();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RequestRefresh(ulong aTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetAnimationModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAnimationModeAttribute(ushort aAnimationMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetAnimation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetFrameIndex(uint aWhichFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetOrientation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFirstFrameDelay();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAnimationStartTime(ulong aTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetImageSpaceInvalidationRect([MarshalAs(UnmanagedType.Interface)] nsIntRect aRect);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr Unwrap();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PropagateUseCounters(IntPtr aDocument);
}
