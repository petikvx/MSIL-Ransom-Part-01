using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class IconResource : Resource
{
	private Kernel32.GRPICONDIRENTRY grpicondirentry_0;

	private IconImage iconImage_0 = new IconImage();

	public Kernel32.GRPICONDIRENTRY Header
	{
		get
		{
			return grpicondirentry_0;
		}
		set
		{
			grpicondirentry_0 = value;
		}
	}

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

	public byte Width
	{
		get
		{
			return grpicondirentry_0.bWidth;
		}
		set
		{
			grpicondirentry_0.bWidth = value;
		}
	}

	public byte Height
	{
		get
		{
			return grpicondirentry_0.bHeight;
		}
		set
		{
			grpicondirentry_0.bHeight = value;
		}
	}

	public uint ImageSize => grpicondirentry_0.dwImageSize;

	public PixelFormat PixelFormat => (PixelFormat)(grpicondirentry_0.wBitsPerPixel switch
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

	public IconResource(IntPtr hModule, IntPtr hResource, IntPtr type, IntPtr name, ushort ushort_0, int size)
		: base(hModule, hResource, type, name, ushort_0, size)
	{
		IntPtr intPtr = Kernel32.LockResource(hResource);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		Read(hModule, intPtr);
	}

	public IconResource()
	{
	}

	public override IntPtr Read(IntPtr hModule, IntPtr lpRes)
	{
		grpicondirentry_0 = (Kernel32.GRPICONDIRENTRY)Marshal.PtrToStructure(lpRes, typeof(Kernel32.GRPICONDIRENTRY));
		IntPtr intPtr = Kernel32.FindResource(hModule, (IntPtr)grpicondirentry_0.nID, (IntPtr)3L);
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
		iconImage_0.Read(intPtr3, (uint)Kernel32.SizeofResource(hModule, intPtr2));
		return new IntPtr(lpRes.ToInt32() + Marshal.SizeOf((object)grpicondirentry_0));
	}

	public override string ToString()
	{
		return $"{Width}x{Height} {PixelFormatString}";
	}

	public override void Write(BinaryWriter w)
	{
		w.Write(grpicondirentry_0.bWidth);
		w.Write(grpicondirentry_0.bHeight);
		w.Write(grpicondirentry_0.bColors);
		w.Write(grpicondirentry_0.bReserved);
		w.Write(grpicondirentry_0.wPlanes);
		w.Write(grpicondirentry_0.wBitsPerPixel);
		w.Write(grpicondirentry_0.dwImageSize);
		w.Write(grpicondirentry_0.nID);
		ResourceUtil.smethod_0(w);
	}

	public void SaveIconTo(string filename)
	{
		Resource.SaveTo(filename, new IntPtr(grpicondirentry_0.nID), new IntPtr(3L), base.Language, iconImage_0.Data);
	}
}
