using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip;

public class GZipOutputStream : DeflaterOutputStream
{
	private enum ksjzHfnLatbgtFyiWkthItpZQUOI
	{
		Header,
		Footer,
		Finished,
		Closed
	}

	protected Crc32 crc32_0;

	private ksjzHfnLatbgtFyiWkthItpZQUOI eBQrGNIvKmJXBKvYvbtcGJWjxIGC;

	public GZipOutputStream(Stream baseOutputStream)
		: this(baseOutputStream, 4096)
	{
	}

	public GZipOutputStream(Stream baseOutputStream, int size)
		: base(baseOutputStream, new Deflater(-1, noZlibHeaderOrFooter: true), size)
	{
		crc32_0 = new Crc32();
	}

	public override void Close()
	{
		try
		{
			Finish();
		}
		finally
		{
			if (eBQrGNIvKmJXBKvYvbtcGJWjxIGC != ksjzHfnLatbgtFyiWkthItpZQUOI.Closed)
			{
				eBQrGNIvKmJXBKvYvbtcGJWjxIGC = ksjzHfnLatbgtFyiWkthItpZQUOI.Closed;
				if (base.IsStreamOwner)
				{
					baseOutputStream_.Close();
				}
			}
		}
	}

	public override void Finish()
	{
		if (eBQrGNIvKmJXBKvYvbtcGJWjxIGC == ksjzHfnLatbgtFyiWkthItpZQUOI.Header)
		{
			TXTNqMrltfkDtSzxRaBOINJuRQZd();
		}
		if (eBQrGNIvKmJXBKvYvbtcGJWjxIGC == ksjzHfnLatbgtFyiWkthItpZQUOI.Footer)
		{
			eBQrGNIvKmJXBKvYvbtcGJWjxIGC = ksjzHfnLatbgtFyiWkthItpZQUOI.Finished;
			base.Finish();
			uint num = (uint)((ulong)deflater_.TotalIn & 0xFFFFFFFFuL);
			uint num2 = (uint)((ulong)crc32_0.Value & 0xFFFFFFFFuL);
			byte[] array = new byte[8]
			{
				(byte)num2,
				(byte)(num2 >> 8),
				(byte)(num2 >> 16),
				(byte)(num2 >> 24),
				(byte)num,
				(byte)(num >> 8),
				(byte)(num >> 16),
				(byte)(num >> 24)
			};
			baseOutputStream_.Write(array, 0, array.Length);
		}
	}

	public int GetLevel()
	{
		return deflater_.GetLevel();
	}

	public void SetLevel(int level)
	{
		if (level < 1)
		{
			throw new ArgumentOutOfRangeException("level");
		}
		deflater_.SetLevel(level);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (eBQrGNIvKmJXBKvYvbtcGJWjxIGC == ksjzHfnLatbgtFyiWkthItpZQUOI.Header)
		{
			TXTNqMrltfkDtSzxRaBOINJuRQZd();
		}
		if (eBQrGNIvKmJXBKvYvbtcGJWjxIGC != ksjzHfnLatbgtFyiWkthItpZQUOI.Footer)
		{
			throw new InvalidOperationException("Write not permitted in current state");
		}
		crc32_0.Update(buffer, offset, count);
		base.Write(buffer, offset, count);
	}

	private void TXTNqMrltfkDtSzxRaBOINJuRQZd()
	{
		if (eBQrGNIvKmJXBKvYvbtcGJWjxIGC == ksjzHfnLatbgtFyiWkthItpZQUOI.Header)
		{
			eBQrGNIvKmJXBKvYvbtcGJWjxIGC = ksjzHfnLatbgtFyiWkthItpZQUOI.Footer;
			DateTime dateTime = new DateTime(1970, 1, 1);
			int num = (int)((DateTime.Now.Ticks - dateTime.Ticks) / 10000000L);
			byte[] obj = new byte[10] { 31, 139, 8, 0, 0, 0, 0, 0, 0, 255 };
			obj[4] = (byte)num;
			obj[5] = (byte)(num >> 8);
			obj[6] = (byte)(num >> 16);
			obj[7] = (byte)(num >> 24);
			byte[] array = obj;
			baseOutputStream_.Write(array, 0, array.Length);
		}
	}
}
