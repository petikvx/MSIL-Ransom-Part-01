using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

internal class LocxVjlCNZghquSrgFvmkfSoMwVu : Stream
{
	private bool WsinwjYrQHcslsKcOitDcjDyMbiT;

	private Stream YquGOfcPzGTQRLqOhLIMmlaYcFID;

	bool Stream.CanRead => YquGOfcPzGTQRLqOhLIMmlaYcFID.CanRead;

	bool Stream.CanSeek => YquGOfcPzGTQRLqOhLIMmlaYcFID.CanSeek;

	bool Stream.CanTimeout => YquGOfcPzGTQRLqOhLIMmlaYcFID.CanTimeout;

	bool Stream.CanWrite => YquGOfcPzGTQRLqOhLIMmlaYcFID.CanWrite;

	public bool MjVEoLBoHsdhPuAYZvVjarfKgyJMA
	{
		get
		{
			return WsinwjYrQHcslsKcOitDcjDyMbiT;
		}
		set
		{
			WsinwjYrQHcslsKcOitDcjDyMbiT = value;
		}
	}

	long Stream.Length => YquGOfcPzGTQRLqOhLIMmlaYcFID.Length;

	long Stream.Position
	{
		get
		{
			return YquGOfcPzGTQRLqOhLIMmlaYcFID.Position;
		}
		set
		{
			YquGOfcPzGTQRLqOhLIMmlaYcFID.Position = value;
		}
	}

	public LocxVjlCNZghquSrgFvmkfSoMwVu(Stream stream)
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID = stream;
	}

	public LocxVjlCNZghquSrgFvmkfSoMwVu(string name)
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID = new FileStream(name, FileMode.Open, FileAccess.ReadWrite);
		WsinwjYrQHcslsKcOitDcjDyMbiT = true;
	}

	public override void zdebThhIbLmIaDlrgliyWnaFMaHzb()
	{
		Stream yquGOfcPzGTQRLqOhLIMmlaYcFID = YquGOfcPzGTQRLqOhLIMmlaYcFID;
		YquGOfcPzGTQRLqOhLIMmlaYcFID = null;
		if (WsinwjYrQHcslsKcOitDcjDyMbiT && yquGOfcPzGTQRLqOhLIMmlaYcFID != null)
		{
			WsinwjYrQHcslsKcOitDcjDyMbiT = false;
			yquGOfcPzGTQRLqOhLIMmlaYcFID.Close();
		}
	}

	public override void THnSEfXDiaoRRUtYFkqYfqwEkNYD()
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID.Flush();
	}

	public long WgTaXlNVHbhKiPlGxOSWomCYaXwq(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
	{
		long num = endLocation - minimumBlockSize;
		if (num >= 0L)
		{
			long num2 = Math.Max(num - maximumVariableData, 0L);
			while (num >= num2)
			{
				num--;
				Seek(num, SeekOrigin.Begin);
				if (zTghKbjLnrybPZXXRNKYIAuaCwjU() == signature)
				{
					return Position;
				}
			}
		}
		return -1L;
	}

	public override int FkobfSfTCZRkGaiBpxAxBcTiTXviA(byte[] buffer, int offset, int count)
	{
		return YquGOfcPzGTQRLqOhLIMmlaYcFID.Read(buffer, offset, count);
	}

	public void GeZBxamwPHYaRwSbMduxiFuicajz(bool zip64, DescriptorData data)
	{
		if (zTghKbjLnrybPZXXRNKYIAuaCwjU() != 134695760)
		{
			throw new ZipException("Data descriptor signature not found");
		}
		data.Crc = zTghKbjLnrybPZXXRNKYIAuaCwjU();
		if (zip64)
		{
			data.CompressedSize = CNqoiQIsdDFiAWRRGzvBviEDffmN();
			data.Size = CNqoiQIsdDFiAWRRGzvBviEDffmN();
		}
		else
		{
			data.CompressedSize = zTghKbjLnrybPZXXRNKYIAuaCwjU();
			data.Size = zTghKbjLnrybPZXXRNKYIAuaCwjU();
		}
	}

	public int zTghKbjLnrybPZXXRNKYIAuaCwjU()
	{
		return mIgBSqdPFvczrfkRIhPZGUdDzdEWC() | (mIgBSqdPFvczrfkRIhPZGUdDzdEWC() << 16);
	}

	public long CNqoiQIsdDFiAWRRGzvBviEDffmN()
	{
		return (long)zTghKbjLnrybPZXXRNKYIAuaCwjU() | (long)zTghKbjLnrybPZXXRNKYIAuaCwjU();
	}

	public int mIgBSqdPFvczrfkRIhPZGUdDzdEWC()
	{
		int num = YquGOfcPzGTQRLqOhLIMmlaYcFID.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		int num2 = YquGOfcPzGTQRLqOhLIMmlaYcFID.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException();
		}
		return num | (num2 << 8);
	}

	public override long qyGcwWUBOOzpOZKJixOcQHCoWYUs(long offset, SeekOrigin origin)
	{
		return YquGOfcPzGTQRLqOhLIMmlaYcFID.Seek(offset, origin);
	}

	public override void KPCDkqqUOjVuLymtiDgOLHHfvudB(long value)
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID.SetLength(value);
	}

	public override void cKylBARGjjaXUVmEnDrJyuQyEqAk(byte[] buffer, int offset, int count)
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID.Write(buffer, offset, count);
	}

	public int cxxYPOBvfRDrWLERoUzWhcAmdYMf(ZipEntry entry)
	{
		if (entry != null)
		{
			int num = 0;
			if ((entry.Flags & 8) == 0)
			{
				return num;
			}
			izRGOUentiyqAkNhkfWOgEFeqnCxb(134695760);
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.Crc);
			num += 8;
			if (entry.LocalHeaderRequiresZip64)
			{
				oYvJtfMPzNFArZAFOTgGFwaIdqGL(entry.CompressedSize);
				oYvJtfMPzNFArZAFOTgGFwaIdqGL(entry.Size);
				return num + 16;
			}
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.CompressedSize);
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.Size);
			return num + 8;
		}
		throw new ArgumentNullException("entry");
	}

	public void VKkbsirOafYYaSurlqVFagoVDczz(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
	{
		if (noOfEntries >= 65535L || startOfCentralDirectory >= 4294967295L || sizeEntries >= 4294967295L)
		{
			uxmjOBOyCiCxpCvLZjfnpJBMfaJfA(noOfEntries, sizeEntries, startOfCentralDirectory);
		}
		izRGOUentiyqAkNhkfWOgEFeqnCxb(101010256);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(0);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(0);
		if (noOfEntries < 65535L)
		{
			WPwBCcZKsWTMxrdsFHKYotnEJfDC((short)noOfEntries);
			WPwBCcZKsWTMxrdsFHKYotnEJfDC((short)noOfEntries);
		}
		else
		{
			QvsWjaMcaHNljSdazCUqdeyKLTYMA(ushort.MaxValue);
			QvsWjaMcaHNljSdazCUqdeyKLTYMA(ushort.MaxValue);
		}
		if (sizeEntries >= 4294967295L)
		{
			CidIExkmOcpNFGSezkMxGqsjoCwc(uint.MaxValue);
		}
		else
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)sizeEntries);
		}
		if (startOfCentralDirectory < 4294967295L)
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)startOfCentralDirectory);
		}
		else
		{
			CidIExkmOcpNFGSezkMxGqsjoCwc(uint.MaxValue);
		}
		int num = ((comment != null) ? comment.Length : 0);
		if (num <= 65535)
		{
			WPwBCcZKsWTMxrdsFHKYotnEJfDC(num);
			if (num > 0)
			{
				Write(comment, 0, comment.Length);
			}
			return;
		}
		throw new ZipException($"Comment length({num}) is too long can only be 64K");
	}

	public void izRGOUentiyqAkNhkfWOgEFeqnCxb(int value)
	{
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(value);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(value >> 16);
	}

	public void oYvJtfMPzNFArZAFOTgGFwaIdqGL(long value)
	{
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)value);
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)(value >> 32));
	}

	public void WPwBCcZKsWTMxrdsFHKYotnEJfDC(int value)
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID.WriteByte((byte)((uint)value & 0xFFu));
		YquGOfcPzGTQRLqOhLIMmlaYcFID.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	public void CidIExkmOcpNFGSezkMxGqsjoCwc(uint value)
	{
		QvsWjaMcaHNljSdazCUqdeyKLTYMA((ushort)(value & 0xFFFFu));
		QvsWjaMcaHNljSdazCUqdeyKLTYMA((ushort)(value >> 16));
	}

	public void OHfGUEbmEKQSkLcuHkBWfcMhNOnP(ulong value)
	{
		CidIExkmOcpNFGSezkMxGqsjoCwc((uint)(value & 0xFFFFFFFFuL));
		CidIExkmOcpNFGSezkMxGqsjoCwc((uint)(value >> 32));
	}

	public void QvsWjaMcaHNljSdazCUqdeyKLTYMA(ushort value)
	{
		YquGOfcPzGTQRLqOhLIMmlaYcFID.WriteByte((byte)(value & 0xFFu));
		YquGOfcPzGTQRLqOhLIMmlaYcFID.WriteByte((byte)(value >> 8));
	}

	private void pBTfksyRoFpyyUkLaDGgPjdQhWoW(ZipEntry entry, GfaJgyImDAIgPZiPXchYDpJriZHx patchData)
	{
		CompressionMethod compressionMethod = entry.CompressionMethod;
		bool flag = true;
		bool flag2 = false;
		izRGOUentiyqAkNhkfWOgEFeqnCxb(67324752);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(entry.Version);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(entry.Flags);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC((byte)compressionMethod);
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.DosTime);
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.Crc);
		if (entry.LocalHeaderRequiresZip64)
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb(-1);
			izRGOUentiyqAkNhkfWOgEFeqnCxb(-1);
		}
		else
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : entry.CompressedSize));
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.Size);
		}
		byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
		if (array.Length > 65535)
		{
			throw new ZipException("Entry name too long.");
		}
		ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
		if (entry.LocalHeaderRequiresZip64 && (flag || flag2))
		{
			zipExtraData.StartNewEntry();
			if (flag)
			{
				zipExtraData.AddLeLong(entry.Size);
				zipExtraData.AddLeLong(entry.CompressedSize);
			}
			else
			{
				zipExtraData.AddLeLong(-1L);
				zipExtraData.AddLeLong(-1L);
			}
			zipExtraData.AddNewEntry(1);
			if (!zipExtraData.Find(1))
			{
				throw new ZipException("Internal error cant find extra data");
			}
			if (patchData != null)
			{
				patchData.kWXcHxqzOtbcDwaBDZwcxSqScTvO = zipExtraData.CurrentReadIndex;
			}
		}
		else
		{
			zipExtraData.Delete(1);
		}
		byte[] entryData = zipExtraData.GetEntryData();
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(array.Length);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(entryData.Length);
		if (array.Length != 0)
		{
			YquGOfcPzGTQRLqOhLIMmlaYcFID.Write(array, 0, array.Length);
		}
		if (entry.LocalHeaderRequiresZip64 && flag2)
		{
			patchData.kWXcHxqzOtbcDwaBDZwcxSqScTvO += YquGOfcPzGTQRLqOhLIMmlaYcFID.Position;
		}
		if (entryData.Length != 0)
		{
			YquGOfcPzGTQRLqOhLIMmlaYcFID.Write(entryData, 0, entryData.Length);
		}
	}

	public void uxmjOBOyCiCxpCvLZjfnpJBMfaJfA(long noOfEntries, long sizeEntries, long centralDirOffset)
	{
		long position = YquGOfcPzGTQRLqOhLIMmlaYcFID.Position;
		izRGOUentiyqAkNhkfWOgEFeqnCxb(101075792);
		oYvJtfMPzNFArZAFOTgGFwaIdqGL(44L);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(45);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(45);
		izRGOUentiyqAkNhkfWOgEFeqnCxb(0);
		izRGOUentiyqAkNhkfWOgEFeqnCxb(0);
		oYvJtfMPzNFArZAFOTgGFwaIdqGL(noOfEntries);
		oYvJtfMPzNFArZAFOTgGFwaIdqGL(noOfEntries);
		oYvJtfMPzNFArZAFOTgGFwaIdqGL(sizeEntries);
		oYvJtfMPzNFArZAFOTgGFwaIdqGL(centralDirOffset);
		izRGOUentiyqAkNhkfWOgEFeqnCxb(117853008);
		izRGOUentiyqAkNhkfWOgEFeqnCxb(0);
		oYvJtfMPzNFArZAFOTgGFwaIdqGL(position);
		izRGOUentiyqAkNhkfWOgEFeqnCxb(1);
	}
}
