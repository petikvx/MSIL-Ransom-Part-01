using System;

namespace X11;

[Flags]
internal enum EventMask
{
	NoEventMask = 0,
	KeyPressMask = 1,
	KeyReleaseMask = 2,
	ButtonPressMask = 4,
	ButtonReleaseMask = 8,
	EnterWindowMask = 0x10,
	LeaveWindowMask = 0x20,
	PointerMotionMask = 0x40,
	PointerMotionHintMask = 0x80,
	Button1MotionMask = 0x100,
	Button2MotionMask = 0x200,
	Button3MotionMask = 0x400,
	Button4MotionMask = 0x800,
	Button5MotionMask = 0x1000,
	ButtonMotionMask = 0x2000,
	KeymapStateMask = 0x4000,
	ExposureMask = 0x8000,
	VisibilityChangeMask = 0x10000,
	StructureNotifyMask = 0x20000,
	ResizeRedirectMask = 0x40000,
	SubstructureNotifyMask = 0x80000,
	SubstructureRedirectMask = 0x100000,
	FocusChangeMask = 0x200000,
	PropertyChangeMask = 0x400000,
	ColormapChangeMask = 0x800000,
	OwnerGrabButtonMask = 0x1000000
}
