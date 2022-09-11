using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class FastBitmap
{
	public DateTime BitmapCreatedAt;

	public Bitmap bitmap { get; set; }

	public BitmapData bitmapData { get; private set; }

	public int Width { get; }

	public int Height { get; }

	public PixelFormat format { get; }

	public bool IsLocked { get; private set; }

	public int Stride => bitmapData.get_Stride();

	public FastBitmap(Bitmap bitmap, PixelFormat format)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		PixelFormat val = format;
		PixelFormat val2 = val;
		if ((int)val2 <= 196865)
		{
			if ((int)val2 != 137224 && (int)val2 != 139273 && (int)val2 != 196865)
			{
				goto IL_0044;
			}
		}
		else if ((int)val2 != 197634 && (int)val2 != 198659 && (int)val2 != 2498570)
		{
			goto IL_0044;
		}
		this.bitmap = bitmap;
		Width = ((Image)this.bitmap).get_Width();
		Height = ((Image)this.bitmap).get_Height();
		this.format = format;
		Lock();
		BitmapCreatedAt = DateTime.Now;
		return;
		IL_0044:
		throw new NotSupportedException(((object)(PixelFormat)(ref format)).ToString() + " is not supported.");
	}

	public FastBitmap(Bitmap bitmap)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		format = ((Image)bitmap).get_PixelFormat();
		PixelFormat val = format;
		PixelFormat val2 = val;
		if ((int)val2 <= 196865)
		{
			if ((int)val2 != 137224 && (int)val2 != 139273 && (int)val2 != 196865)
			{
				goto IL_0055;
			}
		}
		else if ((int)val2 != 197634 && (int)val2 != 198659 && (int)val2 != 2498570)
		{
			goto IL_0055;
		}
		this.bitmap = bitmap;
		Width = ((Image)this.bitmap).get_Width();
		Height = ((Image)this.bitmap).get_Height();
		format = format;
		Lock();
		BitmapCreatedAt = DateTime.Now;
		return;
		IL_0055:
		PixelFormat val3 = format;
		throw new NotSupportedException(((object)(PixelFormat)(ref val3)).ToString() + " is not supported.");
	}

	public unsafe Color GetPixel(int x, int y)
	{
		byte* ptr = (byte*)bitmapData.get_Scan0().ToPointer();
		ptr += CalcOffset(x, y);
		byte alpha = ptr[3];
		byte red = ptr[2];
		byte green = ptr[1];
		byte blue = *ptr;
		return Color.FromArgb(alpha, red, green, blue);
	}

	public unsafe void SetPixel(int x, int y, Color color)
	{
		byte* ptr = (byte*)bitmapData.get_Scan0().ToPointer();
		ptr += CalcOffset(x, y);
		ptr[3] = color.A;
		ptr[2] = color.R;
		ptr[1] = color.G;
		*ptr = color.B;
	}

	public Color GetPixel(int x, int y, byte[] ImgData)
	{
		long num = CalcOffset(x, y) + 4L;
		if (num + 4L < ImgData.Length)
		{
			byte red = ImgData[num];
			byte green = ImgData[num + 1L];
			byte blue = ImgData[num + 2L];
			return Color.FromArgb(255, red, green, blue);
		}
		return Color.FromArgb(255, 0, 0, 0);
	}

	public void SetPixel(int x, int y, Color color, byte[] ImgData)
	{
		long num = CalcOffset(x, y) + 4L;
		if (num + 4L < ImgData.Length)
		{
			ImgData[num] = color.R;
			ImgData[num + 1L] = color.G;
			ImgData[num + 2L] = color.B;
			ByteArrayToBitmap(ImgData);
		}
	}

	public void DrawRectangle(Point begin, Point end, Color color)
	{
		for (int i = begin.X; i < end.X; i++)
		{
			for (int j = begin.Y; j < end.Y; j++)
			{
				SetPixel(i, j, color);
			}
		}
	}

	public long CalcOffset(int x, int y)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		PixelFormat val = format;
		PixelFormat val2 = val;
		if ((int)val2 <= 196865)
		{
			if ((int)val2 == 137224 || (int)val2 == 139273)
			{
				return y * bitmapData.get_Stride() + x * 3;
			}
			if ((int)val2 == 196865)
			{
				return y * bitmapData.get_Stride() + x * 8;
			}
		}
		else
		{
			if ((int)val2 == 197634)
			{
				return y * bitmapData.get_Stride() + x / 2;
			}
			if ((int)val2 == 198659)
			{
				return y * bitmapData.get_Stride() + x;
			}
			if ((int)val2 == 2498570)
			{
				return y * bitmapData.get_Stride() + x * 4;
			}
		}
		return 0L;
	}

	public static int CalcImageOffset(int x, int y, PixelFormat format, int width)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		PixelFormat val = format;
		PixelFormat val2 = val;
		if ((int)val2 <= 196865)
		{
			if ((int)val2 == 137224 || (int)val2 == 139273)
			{
				return y * width * 3 + x * 3;
			}
			if ((int)val2 == 196865)
			{
				return y * width * 8 + x * 8;
			}
		}
		else
		{
			if ((int)val2 == 197634)
			{
				return y * (width / 2) + x / 2;
			}
			if ((int)val2 == 198659)
			{
				return y * width + x;
			}
			if ((int)val2 == 2498570)
			{
				return y * width * 4 + x * 4;
			}
		}
		throw new NotSupportedException(((object)(PixelFormat)(ref format)).ToString() + " is not supported.");
	}

	public void ScanPixelDuplicates(Point BeginPoint, ref Point EndPoint, ref Color RetColor)
	{
		Color pixel = GetPixel(BeginPoint.X, BeginPoint.Y);
		int num = BeginPoint.X;
		while (true)
		{
			if (num < Width)
			{
				Color pixel2 = GetPixel(num, BeginPoint.Y);
				if (pixel.R != pixel2.R || pixel.G != pixel2.G || pixel.B != pixel2.B)
				{
					break;
				}
				num++;
				continue;
			}
			EndPoint = new Point(Width, BeginPoint.Y);
			RetColor = pixel;
			return;
		}
		EndPoint = new Point(num, BeginPoint.Y);
		RetColor = pixel;
	}

	public void Unlock()
	{
		if (IsLocked)
		{
			bitmap.UnlockBits(bitmapData);
			IsLocked = false;
		}
	}

	public void Lock()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!IsLocked)
		{
			bitmapData = bitmap.LockBits(new Rectangle(0, 0, Width, Height), (ImageLockMode)3, format);
			IsLocked = true;
		}
	}

	public byte[] ToByteArray()
	{
		int num = Math.Abs(bitmapData.get_Stride()) * Height;
		byte[] array = new byte[num];
		Marshal.Copy(new IntPtr(bitmapData.get_Scan0().ToInt32()), array, 0, num);
		return array;
	}

	public void ByteArrayToBitmap(byte[] data)
	{
		Marshal.Copy(data, 0, bitmapData.get_Scan0(), data.Length);
	}

	public void Dispose()
	{
		if (bitmap != null)
		{
			try
			{
				bitmap.UnlockBits(bitmapData);
			}
			catch
			{
			}
			try
			{
				((Image)bitmap).Dispose();
			}
			catch
			{
			}
			try
			{
				bitmap = null;
				bitmapData = null;
			}
			catch
			{
			}
		}
	}

	public static ArrayOffset[] GetBytePoints(Point beginPoint, Point endPoint, Size ImgSize, PixelFormat format)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between Unknown and I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		List<ArrayOffset> list = new List<ArrayOffset>();
		for (int i = beginPoint.Y; i < endPoint.Y; i++)
		{
			int begin = CalcImageOffset(beginPoint.X, i, format, ImgSize.Width);
			int num = CalcImageOffset(endPoint.X, i, format, ImgSize.Width);
			PixelFormat val = format;
			PixelFormat val2 = val;
			if ((int)val2 <= 196865)
			{
				if ((int)val2 == 137224 || (int)val2 == 139273)
				{
					if (num + (endPoint.X - beginPoint.X) * 3 < ImgSize.Width * ImgSize.Height * 3)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) * 3, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
				if ((int)val2 == 196865)
				{
					if (num + (endPoint.X - beginPoint.X) * 8 < ImgSize.Width * ImgSize.Height * 8)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) * 8, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
			}
			else
			{
				if ((int)val2 == 197634)
				{
					if (num + (endPoint.X - beginPoint.X) / 2 < ImgSize.Width * ImgSize.Height / 2)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) / 2, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
				if ((int)val2 == 198659)
				{
					if (num + (endPoint.X - beginPoint.X) < ImgSize.Width * ImgSize.Height)
					{
						list.Add(new ArrayOffset(begin, num, endPoint.X - beginPoint.X, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
				if ((int)val2 == 2498570)
				{
					if (num + (endPoint.X - beginPoint.X) * 4 < ImgSize.Width * ImgSize.Height * 4)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) * 4, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
			}
			throw new NotSupportedException(((object)(PixelFormat)(ref format)).ToString() + " is not supported.");
		}
		return list.ToArray();
	}

	public static ArrayOffset[,][] Get2DBytePoints(Point beginPoint, Point endPoint, Size ImgSize, int SlicePieces, PixelFormat format)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		int num = endPoint.X - beginPoint.X;
		int num2 = endPoint.Y - beginPoint.Y;
		float num3 = (float)num / (float)SlicePieces;
		float num4 = (float)num2 / (float)SlicePieces;
		if (num3 - (float)(int)num3 > 0f)
		{
			num3 += 1f;
		}
		if (num4 - (float)(int)num4 > 0f)
		{
			num4 += 1f;
		}
		ArrayOffset[,][] array = new ArrayOffset[(int)num4, (int)num3][];
		Point point = new Point(0, 0);
		for (int i = beginPoint.Y; i < num2; i += SlicePieces)
		{
			for (int j = beginPoint.X; j < num; j += SlicePieces)
			{
				array[point.Y, point.X] = GetBytePoints(new Point(j, i), new Point(j + SlicePieces, i + SlicePieces), ImgSize, format);
				point.X++;
			}
			point.X = 0;
			point.Y++;
		}
		return array;
	}
}
