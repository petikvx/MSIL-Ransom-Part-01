using System;

namespace Orcus.Native;

[Flags]
public enum SetWindowPosFlags : uint
{
	AsynchronousWindowPosition = 0x4000u,
	DeferErase = 0x2000u,
	DrawFrame = 0x20u,
	FrameChanged = 0x20u,
	HideWindow = 0x80u,
	DoNotActivate = 0x10u,
	DoNotCopyBits = 0x100u,
	IgnoreMove = 2u,
	DoNotChangeOwnerZOrder = 0x200u,
	DoNotRedraw = 8u,
	DoNotReposition = 0x200u,
	DoNotSendChangingEvent = 0x400u,
	IgnoreResize = 1u,
	IgnoreZOrder = 4u,
	ShowWindow = 0x40u
}
