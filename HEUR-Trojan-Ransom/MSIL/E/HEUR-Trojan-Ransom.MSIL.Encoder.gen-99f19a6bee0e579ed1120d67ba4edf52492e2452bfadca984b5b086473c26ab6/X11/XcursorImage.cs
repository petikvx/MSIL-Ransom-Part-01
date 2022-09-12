using System;

namespace X11;

internal struct XcursorImage
{
	private int version;

	public int size;

	public int width;

	public int height;

	public int xhot;

	public int yhot;

	public int delay;

	public IntPtr pixels;

	public override string ToString()
	{
		return $"XCursorImage (version: {version}, size: {size}, width: {width}, height: {height}, xhot: {xhot}, yhot: {yhot}, delay: {delay}, pixels: {pixels}";
	}
}
