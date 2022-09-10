using System;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public class IconFileIcon
{
	private Kernel32.FILEGRPICONDIRENTRY _header;

	private DeviceIndependentBitmap _image = new DeviceIndependentBitmap();

	public Kernel32.FILEGRPICONDIRENTRY Header => _header;

	public DeviceIndependentBitmap Image
	{
		get
		{
			return _image;
		}
		set
		{
			_image = value;
		}
	}

	public byte Width => _header.bWidth;

	public byte Height => _header.bHeight;

	public uint ImageSize => _header.dwImageSize;

	internal IntPtr Read(IntPtr lpData, IntPtr lpAllData)
	{
		_header = (Kernel32.FILEGRPICONDIRENTRY)Marshal.PtrToStructure(lpData, typeof(Kernel32.FILEGRPICONDIRENTRY));
		IntPtr lpData2 = new IntPtr(lpAllData.ToInt32() + _header.dwFileOffset);
		_image.Read(lpData2, _header.dwImageSize);
		return new IntPtr(lpData.ToInt32() + Marshal.SizeOf((object)_header));
	}

	public override string ToString()
	{
		return $"{Width}x{Height}";
	}
}
