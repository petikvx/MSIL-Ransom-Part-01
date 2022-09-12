using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipInputStream : InflaterInputStream
{
	private delegate int KqwqYjGGnjoGThKgpYYTeLxYOQtC(byte[] byte_0, int offset, int length);

	private Crc32 SkeCOrQuISdaMVSOmQcRThNecFnb;

	private ZipEntry xiKagfrwOnfksCutzZyptMNZbiss;

	private int ZfQfbYuMuaCxyTfkBpaInRkvyljh;

	private KqwqYjGGnjoGThKgpYYTeLxYOQtC bQmPoUEqBvmQSSqhoIJdCwOkWKYT;

	private int kZXrrxdbdYoJCeUVCbaHIgWGdJcn;

	private string sTvXijzjgItpZvUbxdpsaHrJeABiA;

	private long gOPGBDvMAQDMSIGaZoAfsWDPWdme;

	public override int ICSharpCode_002ESharpZipLib_002EZip_002ECompression_002EStreams_002EInflaterInputStream_002EAvailable
	{
		get
		{
			if (xiKagfrwOnfksCutzZyptMNZbiss == null)
			{
				return 0;
			}
			return 1;
		}
	}

	public bool CanDecompressEntry
	{
		get
		{
			if (xiKagfrwOnfksCutzZyptMNZbiss != null)
			{
				return xiKagfrwOnfksCutzZyptMNZbiss.CanDecompress;
			}
			return false;
		}
	}

	public override long Length
	{
		get
		{
			if (xiKagfrwOnfksCutzZyptMNZbiss == null)
			{
				throw new InvalidOperationException("No current entry");
			}
			if (xiKagfrwOnfksCutzZyptMNZbiss.Size < 0L)
			{
				throw new ZipException("Length not available for the current entry");
			}
			return xiKagfrwOnfksCutzZyptMNZbiss.Size;
		}
	}

	public string Password
	{
		get
		{
			return sTvXijzjgItpZvUbxdpsaHrJeABiA;
		}
		set
		{
			sTvXijzjgItpZvUbxdpsaHrJeABiA = value;
		}
	}

	public ZipInputStream(Stream baseInputStream)
		: base(baseInputStream, new Inflater(noHeader: true))
	{
		SkeCOrQuISdaMVSOmQcRThNecFnb = new Crc32();
		bQmPoUEqBvmQSSqhoIJdCwOkWKYT = NiWeWvTeseFyoEpwDleXDLxTPnXdA;
	}

	private int KMDUJbqAhfeByvgyCGoflVQNAKqhA(byte[] buffer, int offset, int count)
	{
		if (SkeCOrQuISdaMVSOmQcRThNecFnb == null)
		{
			throw new InvalidOperationException("Closed");
		}
		if (xiKagfrwOnfksCutzZyptMNZbiss != null && count > 0)
		{
			if (offset + count <= buffer.Length)
			{
				bool flag = false;
				switch (kZXrrxdbdYoJCeUVCbaHIgWGdJcn)
				{
				case 8:
					count = base.Read(buffer, offset, count);
					if (count <= 0)
					{
						if (!inflater_0.IsFinished)
						{
							throw new ZipException("Inflater not finished!");
						}
						inputBuffer.Available = inflater_0.RemainingInput;
						if ((ZfQfbYuMuaCxyTfkBpaInRkvyljh & 8) == 0 && (inflater_0.TotalIn != csize || inflater_0.TotalOut != gOPGBDvMAQDMSIGaZoAfsWDPWdme))
						{
							throw new ZipException("Size mismatch: " + csize + ";" + gOPGBDvMAQDMSIGaZoAfsWDPWdme + " <-> " + inflater_0.TotalIn + ";" + inflater_0.TotalOut);
						}
						inflater_0.Reset();
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
							gOPGBDvMAQDMSIGaZoAfsWDPWdme -= count;
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
					SkeCOrQuISdaMVSOmQcRThNecFnb.Update(buffer, offset, count);
				}
				if (flag)
				{
					BHJxvtmTBgjDkLeNPNoNAxsVPqMC(testCrc: true);
				}
				return count;
			}
			throw new ArgumentException("Offset + count exceeds buffer size");
		}
		return 0;
	}

	public override void Close()
	{
		bQmPoUEqBvmQSSqhoIJdCwOkWKYT = NiWeWvTeseFyoEpwDleXDLxTPnXdA;
		SkeCOrQuISdaMVSOmQcRThNecFnb = null;
		xiKagfrwOnfksCutzZyptMNZbiss = null;
		base.Close();
	}

	public void CloseEntry()
	{
		if (SkeCOrQuISdaMVSOmQcRThNecFnb == null)
		{
			throw new InvalidOperationException("Closed");
		}
		if (xiKagfrwOnfksCutzZyptMNZbiss == null)
		{
			return;
		}
		if (kZXrrxdbdYoJCeUVCbaHIgWGdJcn == 8)
		{
			if (((uint)ZfQfbYuMuaCxyTfkBpaInRkvyljh & 8u) != 0)
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
		BHJxvtmTBgjDkLeNPNoNAxsVPqMC(testCrc: false);
	}

	private void BHJxvtmTBgjDkLeNPNoNAxsVPqMC(bool testCrc)
	{
		StopDecrypting();
		if (((uint)ZfQfbYuMuaCxyTfkBpaInRkvyljh & 8u) != 0)
		{
			VPNVkTYFRgWjVXjCBrNWSFxnHlgi();
		}
		gOPGBDvMAQDMSIGaZoAfsWDPWdme = 0L;
		if (testCrc && (SkeCOrQuISdaMVSOmQcRThNecFnb.Value & 0xFFFFFFFFL) != xiKagfrwOnfksCutzZyptMNZbiss.Crc && xiKagfrwOnfksCutzZyptMNZbiss.Crc != -1L)
		{
			throw new ZipException("CRC mismatch");
		}
		SkeCOrQuISdaMVSOmQcRThNecFnb.Reset();
		if (kZXrrxdbdYoJCeUVCbaHIgWGdJcn == 8)
		{
			inflater_0.Reset();
		}
		xiKagfrwOnfksCutzZyptMNZbiss = null;
	}

	public ZipEntry GetNextEntry()
	{
		if (SkeCOrQuISdaMVSOmQcRThNecFnb == null)
		{
			throw new InvalidOperationException("Closed.");
		}
		if (xiKagfrwOnfksCutzZyptMNZbiss != null)
		{
			CloseEntry();
		}
		int num = inputBuffer.ReadLeInt();
		switch (num)
		{
		case 33639248:
		case 84233040:
		case 101010256:
		case 101075792:
		case 117853008:
			Close();
			return null;
		case 134695760:
		case 808471376:
			num = inputBuffer.ReadLeInt();
			break;
		}
		if (num != 67324752)
		{
			throw new ZipException("Wrong Local header signature: 0x" + $"{num:X}");
		}
		short versionRequiredToExtract = (short)inputBuffer.ReadLeShort();
		ZfQfbYuMuaCxyTfkBpaInRkvyljh = inputBuffer.ReadLeShort();
		kZXrrxdbdYoJCeUVCbaHIgWGdJcn = inputBuffer.ReadLeShort();
		uint num2 = (uint)inputBuffer.ReadLeInt();
		int num3 = inputBuffer.ReadLeInt();
		csize = inputBuffer.ReadLeInt();
		gOPGBDvMAQDMSIGaZoAfsWDPWdme = inputBuffer.ReadLeInt();
		int num4 = inputBuffer.ReadLeShort();
		int num5 = inputBuffer.ReadLeShort();
		bool flag = (ZfQfbYuMuaCxyTfkBpaInRkvyljh & 1) == 1;
		byte[] array = new byte[num4];
		inputBuffer.ReadRawBuffer(array);
		string name = ZipConstants.ConvertToStringExt(ZfQfbYuMuaCxyTfkBpaInRkvyljh, array);
		xiKagfrwOnfksCutzZyptMNZbiss = new ZipEntry(name, versionRequiredToExtract);
		xiKagfrwOnfksCutzZyptMNZbiss.Flags = ZfQfbYuMuaCxyTfkBpaInRkvyljh;
		xiKagfrwOnfksCutzZyptMNZbiss.CompressionMethod = (CompressionMethod)kZXrrxdbdYoJCeUVCbaHIgWGdJcn;
		if (((uint)ZfQfbYuMuaCxyTfkBpaInRkvyljh & 8u) != 0)
		{
			if (num3 != 0)
			{
				xiKagfrwOnfksCutzZyptMNZbiss.Crc = num3 & 0xFFFFFFFFL;
			}
			if (gOPGBDvMAQDMSIGaZoAfsWDPWdme != 0L)
			{
				xiKagfrwOnfksCutzZyptMNZbiss.Size = gOPGBDvMAQDMSIGaZoAfsWDPWdme & 0xFFFFFFFFL;
			}
			if (csize != 0L)
			{
				xiKagfrwOnfksCutzZyptMNZbiss.CompressedSize = csize & 0xFFFFFFFFL;
			}
			xiKagfrwOnfksCutzZyptMNZbiss.rJZTdarrXDaaoJcowVDHUrDNtOtDA = (byte)((num2 >> 8) & 0xFFu);
		}
		else
		{
			xiKagfrwOnfksCutzZyptMNZbiss.Crc = num3 & 0xFFFFFFFFL;
			xiKagfrwOnfksCutzZyptMNZbiss.Size = gOPGBDvMAQDMSIGaZoAfsWDPWdme & 0xFFFFFFFFL;
			xiKagfrwOnfksCutzZyptMNZbiss.CompressedSize = csize & 0xFFFFFFFFL;
			xiKagfrwOnfksCutzZyptMNZbiss.rJZTdarrXDaaoJcowVDHUrDNtOtDA = (byte)((uint)(num3 >> 24) & 0xFFu);
		}
		xiKagfrwOnfksCutzZyptMNZbiss.DosTime = num2;
		if (num5 > 0)
		{
			byte[] array2 = new byte[num5];
			inputBuffer.ReadRawBuffer(array2);
			xiKagfrwOnfksCutzZyptMNZbiss.ExtraData = array2;
		}
		xiKagfrwOnfksCutzZyptMNZbiss.FaiEDFBWmsKkhQbvMleyMnUFnRnFA(localHeader: true);
		if (xiKagfrwOnfksCutzZyptMNZbiss.CompressedSize >= 0L)
		{
			csize = xiKagfrwOnfksCutzZyptMNZbiss.CompressedSize;
		}
		if (xiKagfrwOnfksCutzZyptMNZbiss.Size >= 0L)
		{
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = xiKagfrwOnfksCutzZyptMNZbiss.Size;
		}
		if (kZXrrxdbdYoJCeUVCbaHIgWGdJcn == 0 && ((!flag && csize != gOPGBDvMAQDMSIGaZoAfsWDPWdme) || (flag && csize - 12L != gOPGBDvMAQDMSIGaZoAfsWDPWdme)))
		{
			throw new ZipException("Stored, but compressed != uncompressed");
		}
		if (xiKagfrwOnfksCutzZyptMNZbiss.IsCompressionMethodSupported())
		{
			bQmPoUEqBvmQSSqhoIJdCwOkWKYT = KAcUpJsvuoSLzvCLmiGZlvEROtWm;
		}
		else
		{
			bQmPoUEqBvmQSSqhoIJdCwOkWKYT = HAlTekdgpCMYeTPfBSjaNNVcqXaD;
		}
		return xiKagfrwOnfksCutzZyptMNZbiss;
	}

	private int KAcUpJsvuoSLzvCLmiGZlvEROtWm(byte[] destination, int offset, int count)
	{
		if (!CanDecompressEntry)
		{
			throw new ZipException("Library cannot extract this entry. Version required is (" + xiKagfrwOnfksCutzZyptMNZbiss.Version + ")");
		}
		if (xiKagfrwOnfksCutzZyptMNZbiss.IsCrypted)
		{
			if (sTvXijzjgItpZvUbxdpsaHrJeABiA == null)
			{
				throw new ZipException("No password set.");
			}
			PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
			byte[] rgbKey = PkzipClassic.GenerateKeys(ZipConstants.ConvertToArray(sTvXijzjgItpZvUbxdpsaHrJeABiA));
			inputBuffer.CryptoTransform = pkzipClassicManaged.CreateDecryptor(rgbKey, null);
			byte[] array = new byte[12];
			inputBuffer.ReadClearTextBuffer(array, 0, 12);
			if (array[11] != xiKagfrwOnfksCutzZyptMNZbiss.rJZTdarrXDaaoJcowVDHUrDNtOtDA)
			{
				throw new ZipException("Invalid password");
			}
			if (csize < 12L)
			{
				if ((xiKagfrwOnfksCutzZyptMNZbiss.Flags & 8) == 0)
				{
					throw new ZipException($"Entry compressed size {csize} too small for encryption");
				}
			}
			else
			{
				csize -= 12L;
			}
		}
		else
		{
			inputBuffer.CryptoTransform = null;
		}
		if (csize <= 0L && (ZfQfbYuMuaCxyTfkBpaInRkvyljh & 8) == 0)
		{
			bQmPoUEqBvmQSSqhoIJdCwOkWKYT = NiWeWvTeseFyoEpwDleXDLxTPnXdA;
			return 0;
		}
		if (kZXrrxdbdYoJCeUVCbaHIgWGdJcn == 8 && inputBuffer.Available > 0)
		{
			inputBuffer.SetInflaterInput(inflater_0);
		}
		bQmPoUEqBvmQSSqhoIJdCwOkWKYT = KMDUJbqAhfeByvgyCGoflVQNAKqhA;
		return KMDUJbqAhfeByvgyCGoflVQNAKqhA(destination, offset, count);
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
		if (count >= 0)
		{
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Invalid offset/count combination");
			}
			return bQmPoUEqBvmQSSqhoIJdCwOkWKYT(buffer, offset, count);
		}
		throw new ArgumentOutOfRangeException("count", "Cannot be negative");
	}

	public override int ReadByte()
	{
		byte[] array = new byte[1];
		if (Read(array, 0, 1) > 0)
		{
			return array[0] & 0xFF;
		}
		return -1;
	}

	private void VPNVkTYFRgWjVXjCBrNWSFxnHlgi()
	{
		if (inputBuffer.ReadLeInt() != 134695760)
		{
			throw new ZipException("Data descriptor signature not found");
		}
		xiKagfrwOnfksCutzZyptMNZbiss.Crc = inputBuffer.ReadLeInt() & 0xFFFFFFFFL;
		if (!xiKagfrwOnfksCutzZyptMNZbiss.LocalHeaderRequiresZip64)
		{
			csize = inputBuffer.ReadLeInt();
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = inputBuffer.ReadLeInt();
		}
		else
		{
			csize = inputBuffer.ReadLeLong();
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = inputBuffer.ReadLeLong();
		}
		xiKagfrwOnfksCutzZyptMNZbiss.CompressedSize = csize;
		xiKagfrwOnfksCutzZyptMNZbiss.Size = gOPGBDvMAQDMSIGaZoAfsWDPWdme;
	}

	private int NiWeWvTeseFyoEpwDleXDLxTPnXdA(byte[] destination, int offset, int count)
	{
		throw new InvalidOperationException("Unable to read from this stream");
	}

	private int HAlTekdgpCMYeTPfBSjaNNVcqXaD(byte[] destination, int offset, int count)
	{
		throw new ZipException("The compression method for this entry is not supported");
	}
}
