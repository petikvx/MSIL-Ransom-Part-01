using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Explicit, Size = 4)]
public struct nscolor
{
	[FieldOffset(0)]
	private int _value;

	public byte A => (byte)((_value & 0xFF000000L) >> 24);

	public byte R => (byte)((uint)_value & 0xFFu);

	public byte G => (byte)((_value & 0xFF00) >> 8);

	public byte B => (byte)((_value & 0xFF0000) >> 16);

	public nscolor(byte r, byte g, byte b)
		: this(byte.MaxValue, r, g, b)
	{
	}

	public nscolor(byte a, byte r, byte g, byte b)
	{
		_value = MakeNsColor(a, r, g, b);
	}

	public static int MakeNsColor(byte a, byte r, byte g, byte b)
	{
		return (a << 24) | (b << 16) | (g << 8) | r;
	}
}
