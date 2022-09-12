using System;

namespace VanillaStub.Helpers.Services.InputSimulator.Native;

[Flags]
internal enum MouseFlag : uint
{
	Move = 1u,
	LeftDown = 2u,
	LeftUp = 4u,
	RightDown = 8u,
	RightUp = 0x10u,
	MiddleDown = 0x20u,
	MiddleUp = 0x40u,
	XDown = 0x80u,
	XUp = 0x100u,
	VerticalWheel = 0x800u,
	HorizontalWheel = 0x1000u,
	VirtualDesk = 0x4000u,
	Absolute = 0x8000u
}
