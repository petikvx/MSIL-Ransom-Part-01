using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public class IconImageResource : Resource
{
	protected Kernel32.GRPICONDIRENTRY _header;

	protected DeviceIndependentBitmap _image = new DeviceIndependentBitmap();

	public Kernel32.GRPICONDIRENTRY Header
	{
		get
		{
			return _header;
		}
		set
		{
			_header = value;
		}
	}

	public ushort Id
	{
		get
		{
			return _header.nID;
		}
		set
		{
			_header.nID = value;
		}
	}

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

	public byte Width
	{
		get
		{
			return _header.bWidth;
		}
		set
		{
			_header.bWidth = value;
		}
	}

	public byte Height
	{
		get
		{
			return _header.bHeight;
		}
		set
		{
			_header.bHeight = value;
		}
	}

	public uint ImageSize
	{
		get
		{
			return _header.dwImageSize;
		}
		set
		{
			_header.dwImageSize = value;
		}
	}

	public PixelFormat PixelFormat => (PixelFormat)(_header.wBitsPerPixel switch
	{
		8 => 198659, 
		4 => 197634, 
		1 => 196865, 
		32 => 2498570, 
		24 => 137224, 
		16 => 135174, 
		_ => 0, 
	});

	public string PixelFormatString
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Invalid comparison between Unknown and I4
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Invalid comparison between Unknown and I4
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Invalid comparison between Unknown and I4
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			PixelFormat pixelFormat = PixelFormat;
			if ((int)pixelFormat <= 196865)
			{
				if ((int)pixelFormat == 137224)
				{
					return "24-bit True Colors";
				}
				if ((int)pixelFormat != 139273)
				{
					if ((int)pixelFormat != 196865)
					{
						goto IL_004d;
					}
					return "1-bit B/W";
				}
			}
			else
			{
				if ((int)pixelFormat == 197634)
				{
					return "4-bit 16 Colors";
				}
				if ((int)pixelFormat == 198659)
				{
					return "8-bit 256 Colors";
				}
				if ((int)pixelFormat != 2498570)
				{
					goto IL_004d;
				}
			}
			return "32-bit Alpha Channel";
			IL_004d:
			return "Unknown";
		}
	}

	internal IconImageResource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
		: base(hModule, hResource, type, name, language, size)
	{
	}

	public IconImageResource(ResourceId type)
		: base(IntPtr.Zero, IntPtr.Zero, type, new ResourceId(IntPtr.Zero), ResourceUtil.NEUTRALLANGID, Marshal.SizeOf(typeof(Kernel32.GRPICONDIRENTRY)))
	{
	}

	public IconImageResource(IconFileIcon icon, ResourceId type, ResourceId name, ushort language)
	{
		_name = name;
		_type = type;
		_language = language;
		_header.bColors = icon.Header.bColors;
		_header.bHeight = icon.Header.bHeight;
		_header.bReserved = icon.Header.bReserved;
		_header.bWidth = icon.Header.bWidth;
		_header.dwImageSize = icon.Header.dwImageSize;
		_header.wBitsPerPixel = icon.Header.wBitsPerPixel;
		_header.wPlanes = icon.Header.wPlanes;
		_header.nID = (ushort)(int)name.Id;
		_image = new DeviceIndependentBitmap(icon.Image);
	}

	internal override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		_header = (Kernel32.GRPICONDIRENTRY)Marshal.PtrToStructure(lpRes, typeof(Kernel32.GRPICONDIRENTRY));
		IntPtr intPtr = Kernel32.FindResourceExW(hModule, _type.Id, (IntPtr)_header.nID, _language);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr2 = Kernel32.LoadResource(hModule, intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr3 = Kernel32.LockResource(intPtr2);
		if (intPtr3 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		ReadImage(intPtr3, (uint)Kernel32.SizeofResource(hModule, intPtr));
		return new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)_header));
	}

	internal virtual void ReadImage(IntPtr dibBits, uint size)
	{
		_image.Read(dibBits, size);
	}

	public override string ToString()
	{
		return $"{Width}x{Height} {PixelFormatString}";
	}

	internal override void Write(BinaryWriter w)
	{
		w.Write(_header.bWidth);
		w.Write(_header.bHeight);
		w.Write(_header.bColors);
		w.Write(_header.bReserved);
		w.Write(_header.wPlanes);
		w.Write(_header.wBitsPerPixel);
		w.Write(_header.dwImageSize);
		w.Write(_header.nID);
		ResourceUtil.PadToWORD(w);
	}

	public virtual void SaveIconTo(string filename)
	{
		Resource.SaveTo(filename, _type, new ResourceId(_header.nID), _language, _image.Data);
	}
}
