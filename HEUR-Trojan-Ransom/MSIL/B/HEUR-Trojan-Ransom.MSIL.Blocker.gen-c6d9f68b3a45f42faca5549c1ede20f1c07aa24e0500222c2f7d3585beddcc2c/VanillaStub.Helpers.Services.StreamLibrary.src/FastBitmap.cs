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
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if ((int)format <= 196865)
		{
			if ((int)format != 137224 && (int)format != 139273 && (int)format != 196865)
			{
				goto IL_0042;
			}
		}
		else if ((int)format != 197634 && (int)format != 198659 && (int)format != 2498570)
		{
			goto IL_0042;
		}
		this.bitmap = bitmap;
		Width = ((Image)this.bitmap).get_Width();
		Height = ((Image)this.bitmap).get_Height();
		this.format = format;
		Lock();
		BitmapCreatedAt = DateTime.Now;
		return;
		IL_0042:
		throw new NotSupportedException(string.Concat(format, " is not supported."));
	}

	public FastBitmap(Bitmap bitmap)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		format = ((Image)bitmap).get_PixelFormat();
		PixelFormat val = format;
		if ((int)val <= 196865)
		{
			if ((int)val != 137224 && (int)val != 139273 && (int)val != 196865)
			{
				goto IL_0053;
			}
		}
		else if ((int)val != 197634 && (int)val != 198659 && (int)val != 2498570)
		{
			goto IL_0053;
		}
		this.bitmap = bitmap;
		Width = ((Image)this.bitmap).get_Width();
		Height = ((Image)this.bitmap).get_Height();
		format = format;
		Lock();
		BitmapCreatedAt = DateTime.Now;
		return;
		IL_0053:
		throw new NotSupportedException(string.Concat(format, " is not supported."));
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
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		PixelFormat val = format;
		if ((int)val <= 196865)
		{
			if ((int)val == 137224 || (int)val == 139273)
			{
				return y * bitmapData.get_Stride() + x * 3;
			}
			if ((int)val == 196865)
			{
				return y * bitmapData.get_Stride() + x * 8;
			}
		}
		else
		{
			if ((int)val == 197634)
			{
				return y * bitmapData.get_Stride() + x / 2;
			}
			if ((int)val == 198659)
			{
				return y * bitmapData.get_Stride() + x;
			}
			if ((int)val == 2498570)
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
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if ((int)format <= 196865)
		{
			if ((int)format == 137224 || (int)format == 139273)
			{
				return y * width * 3 + x * 3;
			}
			if ((int)format == 196865)
			{
				return y * width * 8 + x * 8;
			}
		}
		else
		{
			if ((int)format == 197634)
			{
				return y * (width / 2) + x / 2;
			}
			if ((int)format == 198659)
			{
				return y * width + x;
			}
			if ((int)format == 2498570)
			{
				return y * width * 4 + x * 4;
			}
		}
		throw new NotSupportedException(string.Concat(format, " is not supported."));
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
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Invalid comparison between Unknown and I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		List<ArrayOffset> list = new List<ArrayOffset>();
		for (int i = beginPoint.Y; i < endPoint.Y; i++)
		{
			int begin = CalcImageOffset(beginPoint.X, i, format, ImgSize.Width);
			int num = CalcImageOffset(endPoint.X, i, format, ImgSize.Width);
			if ((int)format <= 196865)
			{
				if ((int)format == 137224 || (int)format == 139273)
				{
					if (num + (endPoint.X - beginPoint.X) * 3 < ImgSize.Width * ImgSize.Height * 3)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) * 3, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
				if ((int)format == 196865)
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
				if ((int)format == 197634)
				{
					if (num + (endPoint.X - beginPoint.X) / 2 < ImgSize.Width * ImgSize.Height / 2)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) / 2, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
				if ((int)format == 198659)
				{
					if (num + (endPoint.X - beginPoint.X) < ImgSize.Width * ImgSize.Height)
					{
						list.Add(new ArrayOffset(begin, num, endPoint.X - beginPoint.X, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
				if ((int)format == 2498570)
				{
					if (num + (endPoint.X - beginPoint.X) * 4 < ImgSize.Width * ImgSize.Height * 4)
					{
						list.Add(new ArrayOffset(begin, num, (endPoint.X - beginPoint.X) * 4, beginPoint.X, i, endPoint.X - beginPoint.X, 1));
					}
					continue;
				}
			}
			throw new NotSupportedException(string.Concat(format, " is not supported."));
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
