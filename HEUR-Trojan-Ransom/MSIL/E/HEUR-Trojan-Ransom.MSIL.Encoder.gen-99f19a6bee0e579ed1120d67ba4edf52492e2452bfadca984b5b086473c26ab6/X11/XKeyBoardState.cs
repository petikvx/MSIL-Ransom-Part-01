using System;
using System.Runtime.InteropServices;

namespace X11;

internal struct XKeyBoardState
{
	[StructLayout(LayoutKind.Explicit)]
	public struct AutoRepeats
	{
		[FieldOffset(0)]
		public byte first;

		[FieldOffset(31)]
		public byte last;
	}

	public int key_click_percent;

	public int bell_percent;

	public uint bell_pitch;

	public uint bell_duration;

	public IntPtr led_mask;

	public int global_auto_repeat;

	public AutoRepeats auto_repeats;
}
