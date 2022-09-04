using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public abstract class Gdi32
{
	public enum BitmapCompression
	{
		BI_RGB,
		BI_RLE8,
		BI_RLE4,
		BI_BITFIELDS,
		BI_JPEG,
		BI_PNG
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct BITMAPINFOHEADER
	{
		public uint biSize;

		public int biWidth;

		public int biHeight;

		public ushort biPlanes;

		public ushort biBitCount;

		public uint biCompression;

		public uint biSizeImage;

		public int biXPelsPerMeter;

		public int biYPelsPerMeter;

		public uint biClrUsed;

		public uint biClrImportant;

		public BitmapCompression BitmapCompression => (BitmapCompression)biCompression;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RGBQUAD
	{
		public byte rgbBlue;

		public byte rgbGreen;

		public byte rgbRed;

		public byte rgbReserved;
	}
}
