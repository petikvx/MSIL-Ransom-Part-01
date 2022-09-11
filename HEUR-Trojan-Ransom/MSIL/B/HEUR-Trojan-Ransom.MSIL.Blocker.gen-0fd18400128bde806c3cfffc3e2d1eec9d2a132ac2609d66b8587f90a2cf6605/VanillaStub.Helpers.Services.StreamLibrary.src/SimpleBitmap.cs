using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class SimpleBitmap
{
	public class SimpleBitmapInfo
	{
		public int Stride { get; protected set; }

		public int PixelSize { get; protected set; }

		public int Width { get; protected set; }

		public int Height { get; protected set; }

		public int TotalSize { get; protected set; }

		public SimpleBitmapInfo()
		{
			Clear();
		}

		public SimpleBitmapInfo(BitmapData data)
		{
			Load(data);
		}

		internal void Clear()
		{
			Stride = 0;
			PixelSize = 0;
			Width = 0;
			Height = 0;
			TotalSize = 0;
		}

		internal void Load(BitmapData data)
		{
			Width = data.get_Width();
			Height = data.get_Height();
			Stride = data.get_Stride();
			PixelSize = Math.Abs(data.get_Stride()) / data.get_Width();
			TotalSize = data.get_Width() * data.get_Height() * PixelSize;
		}
	}

	private readonly object ProcessingLock = new object();

	public SimpleBitmapInfo Info { get; internal set; }

	public bool Locked => (!(Scan0 == IntPtr.Zero)) ? true : false;

	public IntPtr Scan0 { get; internal set; }

	public int Scan0_int { get; internal set; }

	public BitmapData bitmapData { get; internal set; }

	public Bitmap bitMap { get; set; }

	public SimpleBitmap()
	{
		Scan0 = IntPtr.Zero;
		bitmapData = null;
		bitMap = null;
		Info = new SimpleBitmapInfo();
	}

	public SimpleBitmap(Bitmap bmp)
	{
		bitMap = bmp;
	}

	public unsafe static bool Compare(Rectangle block, int ptr1, int ptr2, SimpleBitmapInfo sharedInfo)
	{
		int num = 0;
		int count = block.Width * sharedInfo.PixelSize;
		num = block.Y * sharedInfo.Stride + block.X * sharedInfo.PixelSize;
		int num2 = 0;
		while (true)
		{
			if (num2 < block.Height)
			{
				if (NativeMethods.memcmp((byte*)(ptr1 + num), (byte*)(ptr2 + num), (uint)count) != 0)
				{
					break;
				}
				num += sharedInfo.Stride;
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	public unsafe static bool Compare(int y, int rowsize, int ptr1, int ptr2, SimpleBitmapInfo sharedInfo)
	{
		int num = 0;
		int count = sharedInfo.Width * sharedInfo.PixelSize * rowsize;
		num = y * sharedInfo.Stride;
		if (NativeMethods.memcmp((byte*)(ptr1 + num), (byte*)(ptr2 + num), (uint)count) != 0)
		{
			return false;
		}
		return true;
	}

	public unsafe static bool FastCompare(int offset, int size, int ptr1, int ptr2, SimpleBitmapInfo sharedInfo)
	{
		if (NativeMethods.memcmp((byte*)(ptr1 + offset), (byte*)(ptr2 + offset), (uint)size) != 0)
		{
			return false;
		}
		return true;
	}

	public unsafe void CopyBlock(Rectangle block, ref byte[] dest)
	{
		int num = 0;
		int num2 = block.Width * Info.PixelSize;
		int num3 = 0;
		int num4 = Scan0.ToInt32();
		int num5 = num2 * block.Height;
		if (dest == null || dest.Length != num5)
		{
			dest = new byte[num5];
		}
		num = block.Y * Info.Stride + block.X * Info.PixelSize;
		fixed (byte* ptr = dest)
		{
			for (int i = 0; i < block.Height; i++)
			{
				NativeMethods.memcpy(new IntPtr(ptr + num3), new IntPtr(num4 + num), (uint)num2);
				num += Info.Stride;
				num3 += num2;
			}
		}
	}

	public void Lock()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (Locked)
		{
			throw new Exception("Already locked");
		}
		lock (ProcessingLock)
		{
			bitmapData = bitMap.LockBits(new Rectangle(0, 0, ((Image)bitMap).get_Width(), ((Image)bitMap).get_Height()), (ImageLockMode)3, ((Image)bitMap).get_PixelFormat());
			Info = new SimpleBitmapInfo(bitmapData);
			Scan0 = bitmapData.get_Scan0();
			Scan0_int = Scan0.ToInt32();
		}
	}

	public void Unlock()
	{
		if (!Locked)
		{
			throw new Exception("Nothing to unlock");
		}
		lock (ProcessingLock)
		{
			Scan0 = IntPtr.Zero;
			Scan0_int = 0;
			Info.Clear();
			bitMap.UnlockBits(bitmapData);
			bitmapData = null;
		}
	}

	public unsafe void PlaceBlockAtRectange(byte[] block, Rectangle loc)
	{
		int num = Info.PixelSize * loc.Width;
		int num2 = loc.X * Info.PixelSize;
		int num3 = 0;
		fixed (byte* ptr = block)
		{
			for (int i = 0; i < loc.Height; i++)
			{
				NativeMethods.memcpy(new IntPtr(Scan0_int + (loc.Y + i) * Info.Stride + num2), new IntPtr(ptr + num3), (uint)num);
				num3 += num;
			}
		}
	}

	public void Dispose(bool disposeBitmap = false)
	{
		if (Locked)
		{
			Unlock();
		}
		if (disposeBitmap)
		{
			((Image)bitMap).Dispose();
		}
		bitMap = null;
	}
}
