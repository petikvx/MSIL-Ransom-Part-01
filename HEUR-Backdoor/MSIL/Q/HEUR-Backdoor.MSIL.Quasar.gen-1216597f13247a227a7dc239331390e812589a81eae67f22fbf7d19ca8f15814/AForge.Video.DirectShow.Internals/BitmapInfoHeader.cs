using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[ComVisible(false)]
internal struct BitmapInfoHeader
{
	public int Size;

	public int Width;

	public int Height;

	public short Planes;

	public short BitCount;

	public int Compression;

	public int ImageSize;

	public int XPelsPerMeter;

	public int YPelsPerMeter;

	public int ColorsUsed;

	public int ColorsImportant;
}
