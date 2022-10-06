using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

internal class ZipHelperStream : Stream
{
	private bool isOwner_;

	private Stream stream_;

	public bool IsStreamOwner
	{
		get
		{
			return isOwner_;
		}
		set
		{
			isOwner_ = value;
		}
	}

	public override bool CanRead => stream_.CanRead;

	public override bool CanSeek => stream_.CanSeek;

	public override bool CanTimeout => stream_.CanTimeout;

	public override long Length => stream_.Length;

	public override long Position
	{
		get
		{
			return stream_.Position;
		}
		set
		{
			stream_.Position = value;
		}
	}

	public override bool CanWrite => stream_.CanWrite;

	public ZipHelperStream(string name)
	{
		stream_ = new FileStream(name, FileMode.Open, FileAccess.ReadWrite);
		isOwner_ = true;
	}

	public ZipHelperStream(Stream stream)
	{
		stream_ = stream;
	}

	public override void Flush()
	{
		stream_.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream_.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		stream_.SetLength(value);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return stream_.Read(buffer, offset, count);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		stream_.Write(buffer, offset, count);
	}

	public override void Close()
	{
		Stream stream = stream_;
		stream_ = null;
		if (isOwner_ && stream != null)
		{
			isOwner_ = false;
			stream.Close();
		}
	}

	private void WriteLocalHeader(ZipEntry entry, EntryPatchData patchData)
	{
		CompressionMethod compressionMethod = entry.CompressionMethod;
		bool flag = true;
		bool flag2 = false;
		WriteLEInt(67324752);
		WriteLEShort(entry.Version);
		WriteLEShort(entry.Flags);
		WriteLEShort((byte)compressionMethod);
		WriteLEInt((int)entry.DosTime);
		WriteLEInt((int)entry.Crc);
		if (entry.LocalHeaderRequiresZip64)
		{
			WriteLEInt(-1);
			WriteLEInt(-1);
		}
		else
		{
			WriteLEInt((int)(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : entry.CompressedSize));
			WriteLEInt((int)entry.Size);
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
				patchData.SizePatchOffset = zipExtraData.CurrentReadIndex;
			}
		}
		else
		{
			zipExtraData.Delete(1);
		}
		byte[] entryData = zipExtraData.GetEntryData();
		WriteLEShort(array.Length);
		WriteLEShort(entryData.Length);
		if (array.Length > 0)
		{
			stream_.Write(array, 0, array.Length);
		}
		if (entry.LocalHeaderRequiresZip64 && flag2)
		{
			patchData.SizePatchOffset += stream_.Position;
		}
		if (entryData.Length > 0)
		{
			stream_.Write(entryData, 0, entryData.Length);
		}
	}

	public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
	{
		long num = endLocation - minimumBlockSize;
		if (num < 0L)
		{
			return -1L;
		}
		long num2 = Math.Max(num - maximumVariableData, 0L);
		do
		{
			if (num >= num2)
			{
				Seek(num--, SeekOrigin.Begin);
				continue;
			}
			return -1L;
		}
		while (ReadLEInt() != signature);
		return Position;
	}

	public void WriteZip64EndOfCentralDirectory(long noOfEntries, long sizeEntries, long centralDirOffset)
	{
		long position = stream_.Position;
		WriteLEInt(101075792);
		WriteLELong(44L);
		WriteLEShort(51);
		WriteLEShort(45);
		WriteLEInt(0);
		WriteLEInt(0);
		WriteLELong(noOfEntries);
		WriteLELong(noOfEntries);
		WriteLELong(sizeEntries);
		WriteLELong(centralDirOffset);
		WriteLEInt(117853008);
		WriteLEInt(0);
		WriteLELong(position);
		WriteLEInt(1);
	}

	public void WriteEndOfCentralDirectory(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
	{
		if (noOfEntries >= 65535L || startOfCentralDirectory >= 4294967295L || sizeEntries >= 4294967295L)
		{
			WriteZip64EndOfCentralDirectory(noOfEntries, sizeEntries, startOfCentralDirectory);
		}
		WriteLEInt(101010256);
		WriteLEShort(0);
		WriteLEShort(0);
		if (noOfEntries >= 65535L)
		{
			WriteLEUshort(ushort.MaxValue);
			WriteLEUshort(ushort.MaxValue);
		}
		else
		{
			WriteLEShort((short)noOfEntries);
			WriteLEShort((short)noOfEntries);
		}
		if (sizeEntries >= 4294967295L)
		{
			WriteLEUint(uint.MaxValue);
		}
		else
		{
			WriteLEInt((int)sizeEntries);
		}
		if (startOfCentralDirectory >= 4294967295L)
		{
			WriteLEUint(uint.MaxValue);
		}
		else
		{
			WriteLEInt((int)startOfCentralDirectory);
		}
		int num = ((comment != null) ? comment.Length : 0);
		if (num > 65535)
		{
			throw new ZipException($"Comment length({num}) is too long can only be 64K");
		}
		WriteLEShort(num);
		if (num > 0)
		{
			Write(comment, 0, comment.Length);
		}
	}

	public int ReadLEShort()
	{
		int num = stream_.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		int num2 = stream_.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException();
		}
		return num | (num2 << 8);
	}

	public int ReadLEInt()
	{
		return ReadLEShort() | (ReadLEShort() << 16);
	}

	public long ReadLELong()
	{
		return (uint)ReadLEInt() | ((long)ReadLEInt() << 32);
	}

	public void WriteLEShort(int value)
	{
		stream_.WriteByte((byte)((uint)value & 0xFFu));
		stream_.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	public void WriteLEUshort(ushort value)
	{
		stream_.WriteByte((byte)(value & 0xFFu));
		stream_.WriteByte((byte)(value >> 8));
	}

	public void WriteLEInt(int value)
	{
		WriteLEShort(value);
		WriteLEShort(value >> 16);
	}

	public void WriteLEUint(uint value)
	{
		WriteLEUshort((ushort)(value & 0xFFFFu));
		WriteLEUshort((ushort)(value >> 16));
	}

	public void WriteLELong(long value)
	{
		WriteLEInt((int)value);
		WriteLEInt((int)(value >> 32));
	}

	public void WriteLEUlong(ulong value)
	{
		WriteLEUint((uint)(value & 0xFFFFFFFFuL));
		WriteLEUint((uint)(value >> 32));
	}

	public int WriteDataDescriptor(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		int num = 0;
		if (((uint)entry.Flags & 8u) != 0)
		{
			WriteLEInt(134695760);
			WriteLEInt((int)entry.Crc);
			num += 8;
			if (entry.LocalHeaderRequiresZip64)
			{
				WriteLELong(entry.CompressedSize);
				WriteLELong(entry.Size);
				num += 16;
			}
			else
			{
				WriteLEInt((int)entry.CompressedSize);
				WriteLEInt((int)entry.Size);
				num += 8;
			}
		}
		return num;
	}

	public void ReadDataDescriptor(bool zip64, DescriptorData data)
	{
		int num = ReadLEInt();
		if (num != 134695760)
		{
			throw new ZipException("Data descriptor signature not found");
		}
		data.Crc = ReadLEInt();
		if (zip64)
		{
			data.CompressedSize = ReadLELong();
			data.Size = ReadLELong();
		}
		else
		{
			data.CompressedSize = ReadLEInt();
			data.Size = ReadLEInt();
		}
	}
}
