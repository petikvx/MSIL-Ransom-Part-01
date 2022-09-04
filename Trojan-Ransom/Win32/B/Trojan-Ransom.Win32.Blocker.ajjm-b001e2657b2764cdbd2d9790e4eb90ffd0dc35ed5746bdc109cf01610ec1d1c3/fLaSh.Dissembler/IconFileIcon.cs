using System;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class IconFileIcon
{
	private Kernel32.FILEGRPICONDIRENTRY filegrpicondirentry_0;

	private IconImage iconImage_0 = new IconImage();

	public Kernel32.FILEGRPICONDIRENTRY Header => filegrpicondirentry_0;

	public IconImage Image
	{
		get
		{
			return iconImage_0;
		}
		set
		{
			iconImage_0 = value;
		}
	}

	public byte Width => filegrpicondirentry_0.bWidth;

	public byte Height => filegrpicondirentry_0.bHeight;

	public uint ImageSize => filegrpicondirentry_0.dwImageSize;

	public IntPtr Read(IntPtr lpData, IntPtr lpAllData)
	{
		filegrpicondirentry_0 = (Kernel32.FILEGRPICONDIRENTRY)Marshal.PtrToStructure(lpData, typeof(Kernel32.FILEGRPICONDIRENTRY));
		IntPtr lpData2 = new IntPtr(lpAllData.ToInt32() + filegrpicondirentry_0.dwFileOffset);
		iconImage_0.Read(lpData2, filegrpicondirentry_0.dwImageSize);
		return new IntPtr(lpData.ToInt32() + Marshal.SizeOf((object)filegrpicondirentry_0));
	}

	public override string ToString()
	{
		return $"{Width}x{Height}";
	}

	public IconResource ConvertToIconResource(ushort id)
	{
		IconResource iconResource = new IconResource();
		Kernel32.GRPICONDIRENTRY header = default(Kernel32.GRPICONDIRENTRY);
		header.bColors = filegrpicondirentry_0.bColors;
		header.bHeight = filegrpicondirentry_0.bHeight;
		header.bReserved = filegrpicondirentry_0.bReserved;
		header.bWidth = filegrpicondirentry_0.bWidth;
		header.dwImageSize = filegrpicondirentry_0.dwImageSize;
		header.wBitsPerPixel = filegrpicondirentry_0.wBitsPerPixel;
		header.wPlanes = filegrpicondirentry_0.wPlanes;
		header.nID = id;
		iconResource.Header = header;
		iconResource.Image = iconImage_0;
		return iconResource;
	}
}
