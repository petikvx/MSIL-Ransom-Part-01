using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using xClient.Core.Compression;

namespace xClient.Core.Utilities;

public class UnsafeStreamCodec : IDisposable
{
	private int _imageQuality;

	private byte[] _encodeBuffer;

	private Bitmap _decodedBitmap;

	private PixelFormat _encodedFormat;

	private int _encodedWidth;

	private int _encodedHeight;

	private readonly object _imageProcessLock = new object();

	private JpgCompression _jpgCompression;

	public int Monitor { get; private set; }

	public string Resolution { get; private set; }

	public Size CheckBlock { get; private set; }

	public int ImageQuality
	{
		get
		{
			return _imageQuality;
		}
		private set
		{
			lock (_imageProcessLock)
			{
				_imageQuality = value;
				if (_jpgCompression != null)
				{
					_jpgCompression.Dispose();
				}
				_jpgCompression = new JpgCompression(_imageQuality);
			}
		}
	}

	public UnsafeStreamCodec(int imageQuality, int monitor, string resolution)
	{
		ImageQuality = imageQuality;
		Monitor = monitor;
		Resolution = resolution;
		CheckBlock = new Size(50, 1);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (_decodedBitmap != null)
			{
				((Image)_decodedBitmap).Dispose();
			}
			if (_jpgCompression != null)
			{
				_jpgCompression.Dispose();
			}
		}
	}

	public unsafe void CodeImage(IntPtr scan0, Rectangle scanArea, Size imageSize, PixelFormat format, Stream outStream)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		lock (_imageProcessLock)
		{
			byte* ptr = (byte*)scan0.ToInt32();
			if (!outStream.CanWrite)
			{
				throw new Exception("Must have access to Write in the Stream");
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((int)format <= 139273)
			{
				if ((int)format != 137224 && (int)format != 139273)
				{
					goto IL_006a;
				}
				num3 = 3;
			}
			else
			{
				if ((int)format != 925707 && (int)format != 2498570)
				{
					goto IL_006a;
				}
				num3 = 4;
			}
			num = imageSize.Width * num3;
			num2 = num * imageSize.Height;
			if (_encodeBuffer == null)
			{
				_encodedFormat = format;
				_encodedWidth = imageSize.Width;
				_encodedHeight = imageSize.Height;
				_encodeBuffer = new byte[num2];
				fixed (byte* value = _encodeBuffer)
				{
					byte[] array = null;
					Bitmap val = new Bitmap(imageSize.Width, imageSize.Height, num, format, scan0);
					try
					{
						array = _jpgCompression.Compress(val);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
					outStream.Write(BitConverter.GetBytes(array.Length), 0, 4);
					outStream.Write(array, 0, array.Length);
					NativeMethods.memcpy(new IntPtr(value), scan0, (uint)num2);
				}
				return;
			}
			if (_encodedFormat != format)
			{
				throw new Exception("PixelFormat is not equal to previous Bitmap");
			}
			if (_encodedWidth == imageSize.Width && _encodedHeight == imageSize.Height)
			{
				long position = outStream.Position;
				outStream.Write(new byte[4], 0, 4);
				long num4 = 0L;
				List<Rectangle> list = new List<Rectangle>();
				Size size = new Size(scanArea.Width, CheckBlock.Height);
				Size size2 = new Size(scanArea.Width % CheckBlock.Width, scanArea.Height % CheckBlock.Height);
				int num5 = scanArea.Height - size2.Height;
				int num6 = scanArea.Width - size2.Width;
				Rectangle item = default(Rectangle);
				List<Rectangle> list2 = new List<Rectangle>();
				size = new Size(scanArea.Width, size.Height);
				fixed (byte* ptr2 = _encodeBuffer)
				{
					int num7 = 0;
					for (int i = scanArea.Y; i != scanArea.Height; i += size.Height)
					{
						if (i == num5)
						{
							size = new Size(scanArea.Width, size2.Height);
						}
						item = new Rectangle(scanArea.X, i, scanArea.Width, size.Height);
						int num8 = i * num + scanArea.X * num3;
						if (NativeMethods.memcmp(ptr2 + num8, ptr + num8, (uint)num) != 0)
						{
							num7 = list.Count - 1;
							if (list.Count != 0 && list[num7].Y + list[num7].Height == item.Y)
							{
								item = (list[num7] = new Rectangle(list[num7].X, list[num7].Y, list[num7].Width, list[num7].Height + item.Height));
							}
							else
							{
								list.Add(item);
							}
						}
					}
					for (int j = 0; j < list.Count; j++)
					{
						size = new Size(CheckBlock.Width, list[j].Height);
						for (int k = scanArea.X; k != scanArea.Width; k += size.Width)
						{
							if (k == num6)
							{
								size = new Size(size2.Width, list[j].Height);
							}
							item = new Rectangle(k, list[j].Y, size.Width, list[j].Height);
							bool flag = false;
							uint count = (uint)(num3 * item.Width);
							for (int l = 0; l < item.Height; l++)
							{
								int num9 = num * (item.Y + l) + num3 * item.X;
								if (NativeMethods.memcmp(ptr2 + num9, ptr + num9, count) != 0)
								{
									flag = true;
								}
								NativeMethods.memcpy(ptr2 + num9, ptr + num9, count);
							}
							if (flag)
							{
								num7 = list2.Count - 1;
								if (list2.Count > 0 && list2[num7].X + list2[num7].Width == item.X)
								{
									Rectangle rectangle2 = list2[num7];
									int width = item.Width + rectangle2.Width;
									item = (list2[num7] = new Rectangle(rectangle2.X, rectangle2.Y, width, rectangle2.Height));
								}
								else
								{
									list2.Add(item);
								}
							}
						}
					}
				}
				for (int m = 0; m < list2.Count; m++)
				{
					Rectangle rectangle4 = list2[m];
					int num10 = num3 * rectangle4.Width;
					Bitmap val2 = null;
					BitmapData val3 = null;
					long num13;
					try
					{
						val2 = new Bitmap(rectangle4.Width, rectangle4.Height, format);
						val3 = val2.LockBits(new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), (ImageLockMode)3, ((Image)val2).get_PixelFormat());
						int n = 0;
						int num11 = 0;
						for (; n < rectangle4.Height; n++)
						{
							int num12 = num * (rectangle4.Y + n) + num3 * rectangle4.X;
							NativeMethods.memcpy((byte*)val3.get_Scan0().ToPointer() + num11, ptr + num12, (uint)num10);
							num11 += num10;
						}
						outStream.Write(BitConverter.GetBytes(rectangle4.X), 0, 4);
						outStream.Write(BitConverter.GetBytes(rectangle4.Y), 0, 4);
						outStream.Write(BitConverter.GetBytes(rectangle4.Width), 0, 4);
						outStream.Write(BitConverter.GetBytes(rectangle4.Height), 0, 4);
						outStream.Write(new byte[4], 0, 4);
						num13 = outStream.Length;
						long position2 = outStream.Position;
						_jpgCompression.Compress(val2, ref outStream);
						num13 = outStream.Position - num13;
						outStream.Position = position2 - 4L;
						outStream.Write(BitConverter.GetBytes(num13), 0, 4);
						outStream.Position += num13;
					}
					finally
					{
						val2.UnlockBits(val3);
						((Image)val2).Dispose();
					}
					num4 += num13 + 20L;
				}
				outStream.Position = position;
				outStream.Write(BitConverter.GetBytes(num4), 0, 4);
				return;
			}
			throw new Exception("Bitmap width/height are not equal to previous bitmap");
			IL_006a:
			throw new NotSupportedException(((object)(PixelFormat)(ref format)).ToString());
		}
	}

	public unsafe Bitmap DecodeData(IntPtr codecBuffer, uint length)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		if (length < 4)
		{
			return _decodedBitmap;
		}
		int num = *(int*)(void*)codecBuffer;
		if (_decodedBitmap == null)
		{
			byte[] array = new byte[num];
			fixed (byte* value = array)
			{
				NativeMethods.memcpy(new IntPtr(value), new IntPtr(codecBuffer.ToInt32() + 4), (uint)num);
			}
			_decodedBitmap = (Bitmap)Image.FromStream((Stream)new MemoryStream(array));
			return _decodedBitmap;
		}
		return _decodedBitmap;
	}

	public Bitmap DecodeData(Stream inStream)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		byte[] array = new byte[4];
		inStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		if (_decodedBitmap == null)
		{
			array = new byte[num];
			inStream.Read(array, 0, array.Length);
			_decodedBitmap = (Bitmap)Image.FromStream((Stream)new MemoryStream(array));
			return _decodedBitmap;
		}
		Graphics val = Graphics.FromImage((Image)(object)_decodedBitmap);
		try
		{
			while (num > 0)
			{
				byte[] array2 = new byte[20];
				inStream.Read(array2, 0, array2.Length);
				Rectangle rectangle = new Rectangle(BitConverter.ToInt32(array2, 0), BitConverter.ToInt32(array2, 4), BitConverter.ToInt32(array2, 8), BitConverter.ToInt32(array2, 12));
				int num2 = BitConverter.ToInt32(array2, 16);
				byte[] array3 = new byte[num2];
				inStream.Read(array3, 0, array3.Length);
				using (MemoryStream memoryStream = new MemoryStream(array3))
				{
					Bitmap val2 = (Bitmap)Image.FromStream((Stream)memoryStream);
					try
					{
						val.DrawImage((Image)(object)val2, rectangle.Location);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				num -= num2 + 20;
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return _decodedBitmap;
	}
}
