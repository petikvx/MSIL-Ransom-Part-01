using System;
using System.IO;
using System.Runtime.InteropServices;

namespace fLaSh.Dissembler;

public class IconImage
{
	private Gdi32.BITMAPINFOHEADER bitmapinfoheader_0 = default(Gdi32.BITMAPINFOHEADER);

	private byte[] byte_0;

	public byte[] Data
	{
		get
		{
			return byte_0;
		}
		set
		{
			byte_0 = value;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)bitmapinfoheader_0));
			try
			{
				Marshal.Copy(byte_0, 0, intPtr, Marshal.SizeOf((object)bitmapinfoheader_0));
				bitmapinfoheader_0 = (Gdi32.BITMAPINFOHEADER)Marshal.PtrToStructure(intPtr, typeof(Gdi32.BITMAPINFOHEADER));
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	public Gdi32.BITMAPINFOHEADER Header => bitmapinfoheader_0;

	public int Size => byte_0.Length;

	public IconImage()
	{
	}

	public IconImage(string filename)
	{
		Data = File.ReadAllBytes(filename);
	}

	public void Read(IntPtr lpData, uint size)
	{
		bitmapinfoheader_0 = (Gdi32.BITMAPINFOHEADER)Marshal.PtrToStructure(lpData, typeof(Gdi32.BITMAPINFOHEADER));
		byte_0 = new byte[size];
		Marshal.Copy(lpData, byte_0, 0, byte_0.Length);
	}
}
