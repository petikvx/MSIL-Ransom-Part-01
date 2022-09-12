using System;

namespace VanillaStub.Helpers.Services.InputSimulator.Native;

[Flags]
internal enum KeyboardFlag : uint
{
	ExtendedKey = 1u,
	KeyUp = 2u,
	Unicode = 4u,
	ScanCode = 8u
}
