using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip;

public class GZipOutputStream : DeflaterOutputStream
{
	private enum llzlLSLRaARXbiVLNfdOkwkEelBO
	{
		Header,
		Footer,
		Finished,
		Closed
	}

	protected Crc32 crc32_0;

	private llzlLSLRaARXbiVLNfdOkwkEelBO jXKcZymSzJwhPdzOwVcHoRYqcEPn;

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
			if (jXKcZymSzJwhPdzOwVcHoRYqcEPn != llzlLSLRaARXbiVLNfdOkwkEelBO.Closed)
			{
				jXKcZymSzJwhPdzOwVcHoRYqcEPn = llzlLSLRaARXbiVLNfdOkwkEelBO.Closed;
				if (base.IsStreamOwner)
				{
					baseOutputStream_.Close();
				}
			}
		}
	}

	public override void Finish()
	{
		if (jXKcZymSzJwhPdzOwVcHoRYqcEPn == llzlLSLRaARXbiVLNfdOkwkEelBO.Header)
		{
			YlHVhrLehMpSfvoUKsbrygUlsqCp();
		}
		if (jXKcZymSzJwhPdzOwVcHoRYqcEPn == llzlLSLRaARXbiVLNfdOkwkEelBO.Footer)
		{
			jXKcZymSzJwhPdzOwVcHoRYqcEPn = llzlLSLRaARXbiVLNfdOkwkEelBO.Finished;
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
		if (jXKcZymSzJwhPdzOwVcHoRYqcEPn == llzlLSLRaARXbiVLNfdOkwkEelBO.Header)
		{
			YlHVhrLehMpSfvoUKsbrygUlsqCp();
		}
		if (jXKcZymSzJwhPdzOwVcHoRYqcEPn != llzlLSLRaARXbiVLNfdOkwkEelBO.Footer)
		{
			throw new InvalidOperationException("Write not permitted in current state");
		}
		crc32_0.Update(buffer, offset, count);
		base.Write(buffer, offset, count);
	}

	private void YlHVhrLehMpSfvoUKsbrygUlsqCp()
	{
		if (jXKcZymSzJwhPdzOwVcHoRYqcEPn == llzlLSLRaARXbiVLNfdOkwkEelBO.Header)
		{
			jXKcZymSzJwhPdzOwVcHoRYqcEPn = llzlLSLRaARXbiVLNfdOkwkEelBO.Footer;
			DateTime dateTime = new DateTime(1970, 1, 1);
			int num = (int)((DateTime.Now.Ticks - dateTime.Ticks) / 10000000L);
			byte[] array = new byte[10] { 31, 139, 8, 0, 0, 0, 0, 0, 0, 255 };
			array[4] = (byte)num;
			array[5] = (byte)(num >> 8);
			array[6] = (byte)(num >> 16);
			array[7] = (byte)(num >> 24);
			byte[] array2 = array;
			baseOutputStream_.Write(array2, 0, array2.Length);
		}
	}
}
