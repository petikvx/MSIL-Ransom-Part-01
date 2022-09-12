using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipInputStream : InflaterInputStream
{
	private delegate int HeiZUQaeUMEWLgIfyGNwvOIBLryBA(byte[] byte_0, int offset, int length);

	private Crc32 XggeanKkgjbXaSerhmRXCjwfRXMZA;

	private ZipEntry sWjEKfJIGLSiDxUGkrGzNYLEVtVb;

	private int KRSLLhSGmTTumqjBSeofDNbovNowA;

	private HeiZUQaeUMEWLgIfyGNwvOIBLryBA yDmSkpomHAcwYzoYbKBWmePdHpNs;

	private int nuBXHKVgvjUSARpsRIyuszNFgDxH;

	private string fadWAETvizZSRUgCkkNTYgaYtAWl;

	private long nNIdigjNWtldYPhvYFfhBELJWnvSb;

	public override int ICSharpCode_002ESharpZipLib_002EZip_002ECompression_002EStreams_002EInflaterInputStream_002EAvailable
	{
		get
		{
			if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb != null)
			{
				return 1;
			}
			return 0;
		}
	}

	public bool CanDecompressEntry => sWjEKfJIGLSiDxUGkrGzNYLEVtVb != null && sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CanDecompress;

	public override long Length
	{
		get
		{
			if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb != null)
			{
				if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size < 0L)
				{
					throw new ZipException("Length not available for the current entry");
				}
				return sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size;
			}
			throw new InvalidOperationException("No current entry");
		}
	}

	public string Password
	{
		get
		{
			return fadWAETvizZSRUgCkkNTYgaYtAWl;
		}
		set
		{
			fadWAETvizZSRUgCkkNTYgaYtAWl = value;
		}
	}

	public ZipInputStream(Stream baseInputStream)
		: base(baseInputStream, new Inflater(noHeader: true))
	{
		XggeanKkgjbXaSerhmRXCjwfRXMZA = new Crc32();
		yDmSkpomHAcwYzoYbKBWmePdHpNs = ImUsAohehFYefOPdWjkUrebQYjKD;
	}

	private int FdDfsIQqdKJpeMGHLVxYPePWnnjT(byte[] buffer, int offset, int count)
	{
		if (XggeanKkgjbXaSerhmRXCjwfRXMZA != null)
		{
			if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb != null && count > 0)
			{
				if (offset + count <= buffer.Length)
				{
					bool flag = false;
					switch (nuBXHKVgvjUSARpsRIyuszNFgDxH)
					{
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
								nNIdigjNWtldYPhvYFfhBELJWnvSb -= count;
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
					case 8:
						count = base.Read(buffer, offset, count);
						if (count <= 0)
						{
							if (!inflater_0.IsFinished)
							{
								throw new ZipException("Inflater not finished!");
							}
							inputBuffer.Available = inflater_0.RemainingInput;
							if ((KRSLLhSGmTTumqjBSeofDNbovNowA & 8) == 0 && (inflater_0.TotalIn != csize || inflater_0.TotalOut != nNIdigjNWtldYPhvYFfhBELJWnvSb))
							{
								throw new ZipException("Size mismatch: " + csize + ";" + nNIdigjNWtldYPhvYFfhBELJWnvSb + " <-> " + inflater_0.TotalIn + ";" + inflater_0.TotalOut);
							}
							inflater_0.Reset();
							flag = true;
						}
						break;
					}
					if (count > 0)
					{
						XggeanKkgjbXaSerhmRXCjwfRXMZA.Update(buffer, offset, count);
					}
					if (flag)
					{
						AWLGZSAKPJILwCsHYSEoxswCicXLA(testCrc: true);
					}
					return count;
				}
				throw new ArgumentException("Offset + count exceeds buffer size");
			}
			return 0;
		}
		throw new InvalidOperationException("Closed");
	}

	public override void Close()
	{
		yDmSkpomHAcwYzoYbKBWmePdHpNs = ImUsAohehFYefOPdWjkUrebQYjKD;
		XggeanKkgjbXaSerhmRXCjwfRXMZA = null;
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb = null;
		base.Close();
	}

	public void CloseEntry()
	{
		if (XggeanKkgjbXaSerhmRXCjwfRXMZA != null)
		{
			if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb == null)
			{
				return;
			}
			if (nuBXHKVgvjUSARpsRIyuszNFgDxH == 8)
			{
				if (((uint)KRSLLhSGmTTumqjBSeofDNbovNowA & 8u) != 0)
				{
					byte[] array = new byte[4096];
					while (Read(array, 0, array.Length) > 0)
					{
					}
					return;
				}
				csize -= inflater_0.TotalIn;
				inputBuffer.Available += inflater_0.RemainingInput;
			}
			if (inputBuffer.Available > csize && csize >= 0L)
			{
				inputBuffer.Available -= (int)csize;
			}
			else
			{
				csize -= inputBuffer.Available;
				inputBuffer.Available = 0;
				while ((ulong)csize > 0uL)
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
			AWLGZSAKPJILwCsHYSEoxswCicXLA(testCrc: false);
			return;
		}
		throw new InvalidOperationException("Closed");
	}

	private void AWLGZSAKPJILwCsHYSEoxswCicXLA(bool testCrc)
	{
		StopDecrypting();
		if (((uint)KRSLLhSGmTTumqjBSeofDNbovNowA & 8u) != 0)
		{
			GeZBxamwPHYaRwSbMduxiFuicajz();
		}
		nNIdigjNWtldYPhvYFfhBELJWnvSb = 0L;
		if (testCrc && (XggeanKkgjbXaSerhmRXCjwfRXMZA.Value & 0xFFFFFFFFL) != sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Crc && sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Crc != -1L)
		{
			throw new ZipException("CRC mismatch");
		}
		XggeanKkgjbXaSerhmRXCjwfRXMZA.Reset();
		if (nuBXHKVgvjUSARpsRIyuszNFgDxH == 8)
		{
			inflater_0.Reset();
		}
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb = null;
	}

	public ZipEntry GetNextEntry()
	{
		if (XggeanKkgjbXaSerhmRXCjwfRXMZA == null)
		{
			throw new InvalidOperationException("Closed.");
		}
		if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb != null)
		{
			CloseEntry();
		}
		int num = inputBuffer.ReadLeInt();
		int num2 = num;
		int num3 = num2;
		if (num3 > 101010256)
		{
			if (num3 <= 117853008)
			{
				if (num3 == 101075792 || num3 == 117853008)
				{
					goto IL_03f0;
				}
			}
			else if (num3 == 134695760 || num3 == 808471376)
			{
				num = inputBuffer.ReadLeInt();
			}
		}
		else if (num3 == 33639248 || num3 == 84233040 || num3 == 101010256)
		{
			goto IL_03f0;
		}
		if (num != 67324752)
		{
			throw new ZipException("Wrong Local header signature: 0x" + $"{num:X}");
		}
		short versionRequiredToExtract = (short)inputBuffer.ReadLeShort();
		KRSLLhSGmTTumqjBSeofDNbovNowA = inputBuffer.ReadLeShort();
		nuBXHKVgvjUSARpsRIyuszNFgDxH = inputBuffer.ReadLeShort();
		uint num4 = (uint)inputBuffer.ReadLeInt();
		int num5 = inputBuffer.ReadLeInt();
		csize = inputBuffer.ReadLeInt();
		nNIdigjNWtldYPhvYFfhBELJWnvSb = inputBuffer.ReadLeInt();
		int num6 = inputBuffer.ReadLeShort();
		int num7 = inputBuffer.ReadLeShort();
		bool flag = (KRSLLhSGmTTumqjBSeofDNbovNowA & 1) == 1;
		byte[] array = new byte[num6];
		inputBuffer.ReadRawBuffer(array);
		string name = ZipConstants.ConvertToStringExt(KRSLLhSGmTTumqjBSeofDNbovNowA, array);
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb = new ZipEntry(name, versionRequiredToExtract);
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Flags = KRSLLhSGmTTumqjBSeofDNbovNowA;
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CompressionMethod = (CompressionMethod)nuBXHKVgvjUSARpsRIyuszNFgDxH;
		if (((uint)KRSLLhSGmTTumqjBSeofDNbovNowA & 8u) != 0)
		{
			if (num5 != 0)
			{
				sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Crc = num5 & 0xFFFFFFFFL;
			}
			if ((ulong)nNIdigjNWtldYPhvYFfhBELJWnvSb > 0uL)
			{
				sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size = nNIdigjNWtldYPhvYFfhBELJWnvSb & 0xFFFFFFFFL;
			}
			if ((ulong)csize > 0uL)
			{
				sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CompressedSize = csize & 0xFFFFFFFFL;
			}
			sWjEKfJIGLSiDxUGkrGzNYLEVtVb.uPXHpDLLHuKQqXZtvUAcFYLSdRod = (byte)((num4 >> 8) & 0xFFu);
		}
		else
		{
			sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Crc = num5 & 0xFFFFFFFFL;
			sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size = nNIdigjNWtldYPhvYFfhBELJWnvSb & 0xFFFFFFFFL;
			sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CompressedSize = csize & 0xFFFFFFFFL;
			sWjEKfJIGLSiDxUGkrGzNYLEVtVb.uPXHpDLLHuKQqXZtvUAcFYLSdRod = (byte)((uint)(num5 >> 24) & 0xFFu);
		}
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.DosTime = num4;
		if (num7 > 0)
		{
			byte[] array2 = new byte[num7];
			inputBuffer.ReadRawBuffer(array2);
			sWjEKfJIGLSiDxUGkrGzNYLEVtVb.ExtraData = array2;
		}
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.AeqxguekIVMcjGFKBbGLRoJAaXqg(localHeader: true);
		if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CompressedSize >= 0L)
		{
			csize = sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CompressedSize;
		}
		if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size >= 0L)
		{
			nNIdigjNWtldYPhvYFfhBELJWnvSb = sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size;
		}
		if (nuBXHKVgvjUSARpsRIyuszNFgDxH == 0 && ((!flag && csize != nNIdigjNWtldYPhvYFfhBELJWnvSb) || (flag && csize - 12L != nNIdigjNWtldYPhvYFfhBELJWnvSb)))
		{
			throw new ZipException("Stored, but compressed != uncompressed");
		}
		if (!sWjEKfJIGLSiDxUGkrGzNYLEVtVb.IsCompressionMethodSupported())
		{
			yDmSkpomHAcwYzoYbKBWmePdHpNs = EwrCzXLRmpgkmisgUaFRhdMnKXvw;
		}
		else
		{
			yDmSkpomHAcwYzoYbKBWmePdHpNs = RmeoyeYjoDNsvAnmzqNiHOXGcGPZ;
		}
		return sWjEKfJIGLSiDxUGkrGzNYLEVtVb;
		IL_03f0:
		Close();
		return null;
	}

	private int RmeoyeYjoDNsvAnmzqNiHOXGcGPZ(byte[] destination, int offset, int count)
	{
		if (CanDecompressEntry)
		{
			if (!sWjEKfJIGLSiDxUGkrGzNYLEVtVb.IsCrypted)
			{
				inputBuffer.CryptoTransform = null;
			}
			else
			{
				if (fadWAETvizZSRUgCkkNTYgaYtAWl == null)
				{
					throw new ZipException("No password set.");
				}
				PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
				byte[] rgbKey = PkzipClassic.GenerateKeys(ZipConstants.ConvertToArray(fadWAETvizZSRUgCkkNTYgaYtAWl));
				inputBuffer.CryptoTransform = pkzipClassicManaged.CreateDecryptor(rgbKey, null);
				byte[] array = new byte[12];
				inputBuffer.ReadClearTextBuffer(array, 0, 12);
				if (array[11] != sWjEKfJIGLSiDxUGkrGzNYLEVtVb.uPXHpDLLHuKQqXZtvUAcFYLSdRod)
				{
					throw new ZipException("Invalid password");
				}
				if (csize < 12L)
				{
					if ((sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Flags & 8) == 0)
					{
						throw new ZipException($"Entry compressed size {csize} too small for encryption");
					}
				}
				else
				{
					csize -= 12L;
				}
			}
			if (csize <= 0L && (KRSLLhSGmTTumqjBSeofDNbovNowA & 8) == 0)
			{
				yDmSkpomHAcwYzoYbKBWmePdHpNs = ImUsAohehFYefOPdWjkUrebQYjKD;
				return 0;
			}
			if (nuBXHKVgvjUSARpsRIyuszNFgDxH == 8 && inputBuffer.Available > 0)
			{
				inputBuffer.SetInflaterInput(inflater_0);
			}
			yDmSkpomHAcwYzoYbKBWmePdHpNs = FdDfsIQqdKJpeMGHLVxYPePWnnjT;
			return FdDfsIQqdKJpeMGHLVxYPePWnnjT(destination, offset, count);
		}
		throw new ZipException("Library cannot extract this entry. Version required is (" + sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Version + ")");
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
		return yDmSkpomHAcwYzoYbKBWmePdHpNs(buffer, offset, count);
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

	private void GeZBxamwPHYaRwSbMduxiFuicajz()
	{
		if (inputBuffer.ReadLeInt() != 134695760)
		{
			throw new ZipException("Data descriptor signature not found");
		}
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Crc = inputBuffer.ReadLeInt() & 0xFFFFFFFFL;
		if (sWjEKfJIGLSiDxUGkrGzNYLEVtVb.LocalHeaderRequiresZip64)
		{
			csize = inputBuffer.ReadLeLong();
			nNIdigjNWtldYPhvYFfhBELJWnvSb = inputBuffer.ReadLeLong();
		}
		else
		{
			csize = inputBuffer.ReadLeInt();
			nNIdigjNWtldYPhvYFfhBELJWnvSb = inputBuffer.ReadLeInt();
		}
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.CompressedSize = csize;
		sWjEKfJIGLSiDxUGkrGzNYLEVtVb.Size = nNIdigjNWtldYPhvYFfhBELJWnvSb;
	}

	private int ImUsAohehFYefOPdWjkUrebQYjKD(byte[] destination, int offset, int count)
	{
		throw new InvalidOperationException("Unable to read from this stream");
	}

	private int EwrCzXLRmpgkmisgUaFRhdMnKXvw(byte[] destination, int offset, int count)
	{
		throw new ZipException("The compression method for this entry is not supported");
	}
}
