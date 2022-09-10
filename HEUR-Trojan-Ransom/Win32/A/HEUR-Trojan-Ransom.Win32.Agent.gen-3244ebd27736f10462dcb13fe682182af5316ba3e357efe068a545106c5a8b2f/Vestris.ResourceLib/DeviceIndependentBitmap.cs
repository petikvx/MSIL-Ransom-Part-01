using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public class DeviceIndependentBitmap
{
	private Gdi32.BITMAPINFOHEADER _header = default(Gdi32.BITMAPINFOHEADER);

	private byte[] _data;

	private Bitmap _mask;

	private Bitmap _color;

	private Bitmap _image;

	public byte[] Data
	{
		get
		{
			return _data;
		}
		set
		{
			_data = value;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)_header));
			try
			{
				Marshal.Copy(_data, 0, intPtr, Marshal.SizeOf((object)_header));
				_header = (Gdi32.BITMAPINFOHEADER)Marshal.PtrToStructure(intPtr, typeof(Gdi32.BITMAPINFOHEADER));
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	public Gdi32.BITMAPINFOHEADER Header => _header;

	public int Size => _data.Length;

	private int MaskImageSize => _header.biHeight / 2 * GetDIBRowWidth(_header.biWidth);

	private int XorImageSize => _header.biHeight / 2 * GetDIBRowWidth(_header.biWidth * _header.biBitCount * _header.biPlanes);

	private int XorImageIndex => (int)(Marshal.SizeOf((object)_header) + ColorCount * Marshal.SizeOf((object)default(Gdi32.RGBQUAD)));

	private uint ColorCount
	{
		get
		{
			if (_header.biClrUsed != 0)
			{
				return _header.biClrUsed;
			}
			if (_header.biBitCount <= 8)
			{
				return (uint)(1 << (int)_header.biBitCount);
			}
			return 0u;
		}
	}

	private int MaskImageIndex => XorImageIndex + XorImageSize;

	public Bitmap Mask
	{
		get
		{
			if (_mask == null)
			{
				IntPtr intPtr = IntPtr.Zero;
				IntPtr zero = IntPtr.Zero;
				IntPtr hgdiobj = IntPtr.Zero;
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				try
				{
					intPtr = Gdi32.CreateCompatibleDC(IntPtr.Zero);
					zero = Gdi32.CreateCompatibleBitmap(intPtr, _header.biWidth, _header.biHeight / 2);
					hgdiobj = Gdi32.SelectObject(intPtr, zero);
					int cb = (int)_header.biSize + Marshal.SizeOf((object)default(Gdi32.RGBQUAD)) * 2;
					intPtr2 = Marshal.AllocCoTaskMem(cb);
					Marshal.WriteInt32(intPtr2, Marshal.SizeOf((object)_header));
					Marshal.WriteInt32(intPtr2, 4, _header.biWidth);
					Marshal.WriteInt32(intPtr2, 8, _header.biHeight / 2);
					Marshal.WriteInt16(intPtr2, 12, 1);
					Marshal.WriteInt16(intPtr2, 14, 1);
					Marshal.WriteInt32(intPtr2, 16, 0);
					Marshal.WriteInt32(intPtr2, 20, 0);
					Marshal.WriteInt32(intPtr2, 24, 0);
					Marshal.WriteInt32(intPtr2, 28, 0);
					Marshal.WriteInt32(intPtr2, 32, 0);
					Marshal.WriteInt32(intPtr2, 36, 0);
					Marshal.WriteInt32(intPtr2, 40, 0);
					Marshal.WriteByte(intPtr2, 44, byte.MaxValue);
					Marshal.WriteByte(intPtr2, 45, byte.MaxValue);
					Marshal.WriteByte(intPtr2, 46, byte.MaxValue);
					Marshal.WriteByte(intPtr2, 47, 0);
					intPtr3 = Marshal.AllocCoTaskMem(MaskImageSize);
					Marshal.Copy(_data, MaskImageIndex, intPtr3, MaskImageSize);
					if (Gdi32.SetDIBitsToDevice(intPtr, 0, 0, (uint)_header.biWidth, (uint)_header.biHeight / 2u, 0, 0, 0u, (uint)_header.biHeight / 2u, intPtr3, intPtr2, 0u) == 0)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
					_mask = Image.FromHbitmap(zero);
				}
				finally
				{
					if (intPtr3 != IntPtr.Zero)
					{
						Marshal.FreeCoTaskMem(intPtr3);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						Marshal.FreeCoTaskMem(intPtr2);
					}
					if (intPtr != IntPtr.Zero)
					{
						Gdi32.SelectObject(intPtr, hgdiobj);
					}
					if (intPtr != IntPtr.Zero)
					{
						Gdi32.DeleteObject(intPtr);
					}
				}
			}
			return _mask;
		}
	}

	public Bitmap Color
	{
		get
		{
			if (_color == null)
			{
				IntPtr intPtr = IntPtr.Zero;
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr zero = IntPtr.Zero;
				IntPtr hgdiobj = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				IntPtr intPtr4 = IntPtr.Zero;
				try
				{
					intPtr = User32.GetDC(IntPtr.Zero);
					intPtr2 = Gdi32.CreateCompatibleDC(intPtr);
					zero = Gdi32.CreateCompatibleBitmap(intPtr, _header.biWidth, _header.biHeight / 2);
					hgdiobj = Gdi32.SelectObject(intPtr2, zero);
					intPtr3 = Marshal.AllocCoTaskMem(XorImageIndex);
					Marshal.Copy(_data, 0, intPtr3, XorImageIndex);
					Marshal.WriteInt32(intPtr3, 8, _header.biHeight / 2);
					intPtr4 = Marshal.AllocCoTaskMem(XorImageSize);
					Marshal.Copy(_data, XorImageIndex, intPtr4, XorImageSize);
					if (Gdi32.SetDIBitsToDevice(intPtr2, 0, 0, (uint)_header.biWidth, (uint)_header.biHeight / 2u, 0, 0, 0u, (uint)(_header.biHeight / 2), intPtr4, intPtr3, 0u) == 0)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
					_color = Image.FromHbitmap(zero);
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						Gdi32.DeleteDC(intPtr);
					}
					if (intPtr4 != IntPtr.Zero)
					{
						Marshal.FreeCoTaskMem(intPtr4);
					}
					if (intPtr3 != IntPtr.Zero)
					{
						Marshal.FreeCoTaskMem(intPtr3);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						Gdi32.SelectObject(intPtr2, hgdiobj);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						Gdi32.DeleteObject(intPtr2);
					}
				}
			}
			return _color;
		}
	}

	public Bitmap Image
	{
		get
		{
			if (_image == null)
			{
				IntPtr intPtr = IntPtr.Zero;
				IntPtr ppvBits = IntPtr.Zero;
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				try
				{
					intPtr = User32.GetDC(IntPtr.Zero);
					if (intPtr == IntPtr.Zero)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
					Gdi32.BITMAPINFO pbmi = default(Gdi32.BITMAPINFO);
					pbmi.bmiHeader = _header;
					pbmi.bmiHeader.biHeight /= 2;
					intPtr2 = Gdi32.CreateCompatibleDC(intPtr);
					intPtr3 = Gdi32.CreateDIBSection(intPtr2, ref pbmi, 0u, out ppvBits, IntPtr.Zero, 0u);
					Marshal.Copy(_data, XorImageIndex, ppvBits, XorImageSize);
					_image = Image.FromHbitmap(intPtr3);
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						User32.ReleaseDC(IntPtr.Zero, intPtr);
					}
					if (intPtr3 != IntPtr.Zero)
					{
						Gdi32.DeleteObject(intPtr3);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						Gdi32.DeleteDC(intPtr2);
					}
				}
			}
			return _image;
		}
	}

	public DeviceIndependentBitmap()
	{
	}

	public DeviceIndependentBitmap(byte[] data)
	{
		Data = data;
	}

	public DeviceIndependentBitmap(DeviceIndependentBitmap image)
	{
		_data = new byte[image._data.Length];
		Buffer.BlockCopy(image._data, 0, _data, 0, image._data.Length);
		_header = image._header;
	}

	internal void Read(IntPtr lpData, uint size)
	{
		_header = (Gdi32.BITMAPINFOHEADER)Marshal.PtrToStructure(lpData, typeof(Gdi32.BITMAPINFOHEADER));
		_data = new byte[size];
		Marshal.Copy(lpData, _data, 0, _data.Length);
	}

	private int GetDIBRowWidth(int width)
	{
		return (width + 31) / 32 * 4;
	}
}
