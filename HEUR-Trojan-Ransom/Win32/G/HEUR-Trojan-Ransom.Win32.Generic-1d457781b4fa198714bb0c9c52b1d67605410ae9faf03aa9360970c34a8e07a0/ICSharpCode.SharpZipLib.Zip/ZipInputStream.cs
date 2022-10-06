using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipInputStream : InflaterInputStream
{
	private delegate int ReadDataHandler(byte[] b, int offset, int length);

	private ReadDataHandler internalReader;

	private Crc32 crc = new Crc32();

	private ZipEntry entry;

	private long size;

	private int method;

	private int flags;

	private string password;

	public string Password
	{
		get
		{
			return password;
		}
		set
		{
			password = value;
		}
	}

	public bool CanDecompressEntry
	{
		get
		{
			if (entry != null)
			{
				return entry.CanDecompress;
			}
			return false;
		}
	}

	public override int Available
	{
		get
		{
			if (entry == null)
			{
				return 0;
			}
			return 1;
		}
	}

	public override long Length
	{
		get
		{
			if (entry != null)
			{
				if (entry.Size < 0L)
				{
					throw new ZipException("Length not available for the current entry");
				}
				return entry.Size;
			}
			throw new InvalidOperationException("No current entry");
		}
	}

	public ZipInputStream(Stream baseInputStream)
		: base(baseInputStream, new Inflater(noHeader: true))
	{
		internalReader = ReadingNotAvailable;
	}

	public ZipInputStream(Stream baseInputStream, int bufferSize)
		: base(baseInputStream, new Inflater(noHeader: true), bufferSize)
	{
		internalReader = ReadingNotAvailable;
	}

	public ZipEntry GetNextEntry()
	{
		if (crc == null)
		{
			throw new InvalidOperationException("Closed.");
		}
		if (entry != null)
		{
			CloseEntry();
		}
		int num = inputBuffer.ReadLeInt();
		if (num != 33639248 && num != 101010256 && num != 84233040 && num != 117853008 && num != 101075792)
		{
			if (num == 808471376 || num == 134695760)
			{
				num = inputBuffer.ReadLeInt();
			}
			if (num != 67324752)
			{
				throw new ZipException("Wrong Local header signature: 0x" + $"{num:X}");
			}
			short versionRequiredToExtract = (short)inputBuffer.ReadLeShort();
			flags = inputBuffer.ReadLeShort();
			method = inputBuffer.ReadLeShort();
			uint num2 = (uint)inputBuffer.ReadLeInt();
			int num3 = inputBuffer.ReadLeInt();
			csize = inputBuffer.ReadLeInt();
			size = inputBuffer.ReadLeInt();
			int num4 = inputBuffer.ReadLeShort();
			int num5 = inputBuffer.ReadLeShort();
			bool flag = (flags & 1) == 1;
			byte[] array = new byte[num4];
			inputBuffer.ReadRawBuffer(array);
			string name = ZipConstants.ConvertToStringExt(flags, array);
			entry = new ZipEntry(name, versionRequiredToExtract);
			entry.Flags = flags;
			entry.CompressionMethod = (CompressionMethod)method;
			if ((flags & 8) == 0)
			{
				entry.Crc = num3 & 0xFFFFFFFFL;
				entry.Size = size & 0xFFFFFFFFL;
				entry.CompressedSize = csize & 0xFFFFFFFFL;
				entry.CryptoCheckValue = (byte)((uint)(num3 >> 24) & 0xFFu);
			}
			else
			{
				if (num3 != 0)
				{
					entry.Crc = num3 & 0xFFFFFFFFL;
				}
				if (size != 0L)
				{
					entry.Size = size & 0xFFFFFFFFL;
				}
				if (csize != 0L)
				{
					entry.CompressedSize = csize & 0xFFFFFFFFL;
				}
				entry.CryptoCheckValue = (byte)((num2 >> 8) & 0xFFu);
			}
			entry.DosTime = num2;
			if (num5 > 0)
			{
				byte[] array2 = new byte[num5];
				inputBuffer.ReadRawBuffer(array2);
				entry.ExtraData = array2;
			}
			entry.ProcessExtraData(localHeader: true);
			if (entry.CompressedSize >= 0L)
			{
				csize = entry.CompressedSize;
			}
			if (entry.Size >= 0L)
			{
				size = entry.Size;
			}
			if (method == 0 && ((!flag && csize != size) || (flag && csize - 12L != size)))
			{
				throw new ZipException("Stored, but compressed != uncompressed");
			}
			if (entry.IsCompressionMethodSupported())
			{
				internalReader = InitialRead;
			}
			else
			{
				internalReader = ReadingNotSupported;
			}
			return entry;
		}
		Close();
		return null;
	}

	private void ReadDataDescriptor()
	{
		if (inputBuffer.ReadLeInt() != 134695760)
		{
			throw new ZipException("Data descriptor signature not found");
		}
		entry.Crc = inputBuffer.ReadLeInt() & 0xFFFFFFFFL;
		if (entry.LocalHeaderRequiresZip64)
		{
			csize = inputBuffer.ReadLeLong();
			size = inputBuffer.ReadLeLong();
		}
		else
		{
			csize = inputBuffer.ReadLeInt();
			size = inputBuffer.ReadLeInt();
		}
		entry.CompressedSize = csize;
		entry.Size = size;
	}

	private void CompleteCloseEntry(bool testCrc)
	{
		StopDecrypting();
		if (((uint)flags & 8u) != 0)
		{
			ReadDataDescriptor();
		}
		size = 0L;
		if (testCrc && (crc.Value & 0xFFFFFFFFL) != entry.Crc && entry.Crc != -1L)
		{
			throw new ZipException("CRC mismatch");
		}
		crc.Reset();
		if (method == 8)
		{
			inf.Reset();
		}
		entry = null;
	}

	public void CloseEntry()
	{
		if (crc == null)
		{
			throw new InvalidOperationException("Closed");
		}
		if (entry == null)
		{
			return;
		}
		if (method == 8)
		{
			if (((uint)flags & 8u) != 0)
			{
				byte[] array = new byte[4096];
				while (Read(array, 0, array.Length) > 0)
				{
				}
				return;
			}
			csize -= inf.TotalIn;
			inputBuffer.Available += inf.RemainingInput;
		}
		if (inputBuffer.Available > csize && csize >= 0L)
		{
			inputBuffer.Available = (int)(inputBuffer.Available - csize);
		}
		else
		{
			csize -= inputBuffer.Available;
			inputBuffer.Available = 0;
			while (csize != 0L)
			{
				long num = Skip(csize);
				if (num > 0L)
				{
					csize -= num;
					continue;
				}
				throw new ZipException("Zip archive ends early.");
			}
		}
		CompleteCloseEntry(testCrc: false);
	}

	public override int ReadByte()
	{
		byte[] array = new byte[1];
		if (Read(array, 0, 1) <= 0)
		{
			return -1;
		}
		return array[0] & 0xFF;
	}

	private int ReadingNotAvailable(byte[] destination, int offset, int count)
	{
		throw new InvalidOperationException("Unable to read from this stream");
	}

	private int ReadingNotSupported(byte[] destination, int offset, int count)
	{
		throw new ZipException("The compression method for this entry is not supported");
	}

	private int InitialRead(byte[] destination, int offset, int count)
	{
		if (!CanDecompressEntry)
		{
			throw new ZipException("Library cannot extract this entry. Version required is (" + entry.Version + ")");
		}
		if (entry.IsCrypted)
		{
			if (password == null)
			{
				throw new ZipException("No password set.");
			}
			PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
			byte[] rgbKey = PkzipClassic.GenerateKeys(ZipConstants.ConvertToArray(password));
			inputBuffer.CryptoTransform = pkzipClassicManaged.CreateDecryptor(rgbKey, null);
			byte[] array = new byte[12];
			inputBuffer.ReadClearTextBuffer(array, 0, 12);
			if (array[11] != entry.CryptoCheckValue)
			{
				throw new ZipException("Invalid password");
			}
			if (csize >= 12L)
			{
				csize -= 12L;
			}
			else if ((entry.Flags & 8) == 0)
			{
				throw new ZipException($"Entry compressed size {csize} too small for encryption");
			}
		}
		else
		{
			inputBuffer.CryptoTransform = null;
		}
		if (csize <= 0L && (flags & 8) == 0)
		{
			internalReader = ReadingNotAvailable;
			return 0;
		}
		if (method == 8 && inputBuffer.Available > 0)
		{
			inputBuffer.SetInflaterInput(inf);
		}
		internalReader = BodyRead;
		return BodyRead(destination, offset, count);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "Cannot be negative");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Invalid offset/count combination");
		}
		return internalReader(buffer, offset, count);
	}

	private int BodyRead(byte[] buffer, int offset, int count)
	{
		if (crc == null)
		{
			throw new InvalidOperationException("Closed");
		}
		if (entry != null && count > 0)
		{
			if (offset + count > buffer.Length)
			{
				throw new ArgumentException("Offset + count exceeds buffer size");
			}
			bool flag = false;
			switch (method)
			{
			case 8:
				count = base.Read(buffer, offset, count);
				if (count <= 0)
				{
					if (!inf.IsFinished)
					{
						throw new ZipException("Inflater not finished!");
					}
					inputBuffer.Available = inf.RemainingInput;
					if ((flags & 8) == 0 && ((inf.TotalIn != csize && csize != 4294967295L && csize != -1L) || inf.TotalOut != size))
					{
						throw new ZipException("Size mismatch: " + csize + ";" + size + " <-> " + inf.TotalIn + ";" + inf.TotalOut);
					}
					inf.Reset();
					flag = true;
				}
				break;
			case 0:
				if (count > csize && csize >= 0L)
				{
					count = (int)csize;
				}
				if (count > 0)
				{
					count = inputBuffer.ReadClearTextBuffer(buffer, offset, count);
					if (count > 0)
					{
						csize -= count;
						size -= count;
					}
				}
				if (csize == 0L)
				{
					flag = true;
				}
				else if (count < 0)
				{
					throw new ZipException("EOF in stored block");
				}
				break;
			}
			if (count > 0)
			{
				crc.Update(buffer, offset, count);
			}
			if (flag)
			{
				CompleteCloseEntry(testCrc: true);
			}
			return count;
		}
		return 0;
	}

	public override void Close()
	{
		internalReader = ReadingNotAvailable;
		crc = null;
		entry = null;
		base.Close();
	}
}
