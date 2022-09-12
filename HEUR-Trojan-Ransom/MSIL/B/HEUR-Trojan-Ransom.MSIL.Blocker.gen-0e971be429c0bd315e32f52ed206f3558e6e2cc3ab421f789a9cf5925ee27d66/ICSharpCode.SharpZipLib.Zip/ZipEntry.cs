using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipEntry : ICloneable
{
	[Flags]
	private enum mHekfjAMgDwkSPKRhJkBJbJppusp : byte
	{
		CompressedSize = 2,
		Crc = 4,
		ExternalAttributes = 0x10,
		None = 0,
		Size = 1,
		Time = 8
	}

	private string lCpciUfpxHqxgSrreoyCNhuITMHM;

	private ulong IlXkaaAFtXOuKZdCXtcuJIdPWFqo;

	private byte ebcXSFabfUdFpTmnPPNcQIlyiApeA;

	private uint oqEsHdOutdOMQUptdGYgcwHjCzJS;

	private int NhRFHQiEWUCvBipLscJFtskdqNqL;

	private byte[] wuwwFVwLTNnubaByIpSRBpFDJxqp;

	private int KRSLLhSGmTTumqjBSeofDNbovNowA;

	private bool SJEOiVyQtKtOtoHJIpvBRmRJKmEh;

	private mHekfjAMgDwkSPKRhJkBJbJppusp HCzMSLbMmAJKqTnzJhBEurDWLVhB;

	private CompressionMethod nuBXHKVgvjUSARpsRIyuszNFgDxH;

	private string SIjohnLvPJKRsnAyvPeIQEkneQoc;

	private long tgJiTAKRvcmDbAhYbCUlPocYXOqH;

	private ulong nNIdigjNWtldYPhvYFfhBELJWnvSb;

	private uint NGSBQrESjFRrBWFgppgucwTCLewW;

	private ushort XkrQONhAsrifMhXwYMgbaetCfrqY;

	private ushort gbDDMhHSxqADZuxfrBphglHBiviu;

	private long HnloPFySyIEgJdGQODxOKcZrGKlFA;

	public bool CanDecompress
	{
		get
		{
			if (Version <= 45 && (Version == 10 || Version == 11 || Version == 20 || Version == 45))
			{
				return IsCompressionMethodSupported();
			}
			return false;
		}
	}

	public bool CentralHeaderRequiresZip64
	{
		get
		{
			if (!LocalHeaderRequiresZip64)
			{
				return tgJiTAKRvcmDbAhYbCUlPocYXOqH >= 4294967295L;
			}
			return true;
		}
	}

	public string Comment
	{
		get
		{
			return lCpciUfpxHqxgSrreoyCNhuITMHM;
		}
		set
		{
			if (value != null && value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", "cannot exceed 65535");
			}
			lCpciUfpxHqxgSrreoyCNhuITMHM = value;
		}
	}

	public long CompressedSize
	{
		get
		{
			if ((HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.CompressedSize) == 0)
			{
				return -1L;
			}
			return (long)IlXkaaAFtXOuKZdCXtcuJIdPWFqo;
		}
		set
		{
			IlXkaaAFtXOuKZdCXtcuJIdPWFqo = (ulong)value;
			HCzMSLbMmAJKqTnzJhBEurDWLVhB |= mHekfjAMgDwkSPKRhJkBJbJppusp.CompressedSize;
		}
	}

	public CompressionMethod CompressionMethod
	{
		get
		{
			return nuBXHKVgvjUSARpsRIyuszNFgDxH;
		}
		set
		{
			if (!IsCompressionMethodSupported(value))
			{
				throw new NotSupportedException("Compression method not supported");
			}
			nuBXHKVgvjUSARpsRIyuszNFgDxH = value;
		}
	}

	public long Crc
	{
		get
		{
			if ((HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.Crc) == 0)
			{
				return -1L;
			}
			return (long)NGSBQrESjFRrBWFgppgucwTCLewW & 0xFFFFFFFFL;
		}
		set
		{
			NGSBQrESjFRrBWFgppgucwTCLewW = (uint)value;
			HCzMSLbMmAJKqTnzJhBEurDWLVhB |= mHekfjAMgDwkSPKRhJkBJbJppusp.Crc;
		}
	}

	internal byte uPXHpDLLHuKQqXZtvUAcFYLSdRod
	{
		get
		{
			return ebcXSFabfUdFpTmnPPNcQIlyiApeA;
		}
		set
		{
			ebcXSFabfUdFpTmnPPNcQIlyiApeA = value;
		}
	}

	public DateTime DateTime
	{
		get
		{
			uint second = Math.Min(59u, 2 * (oqEsHdOutdOMQUptdGYgcwHjCzJS & 0x1F));
			uint minute = Math.Min(59u, (oqEsHdOutdOMQUptdGYgcwHjCzJS >> 5) & 0x3Fu);
			uint hour = Math.Min(23u, (oqEsHdOutdOMQUptdGYgcwHjCzJS >> 11) & 0x1Fu);
			uint month = Math.Max(1u, Math.Min(12u, (oqEsHdOutdOMQUptdGYgcwHjCzJS >> 21) & 0xFu));
			uint year = ((oqEsHdOutdOMQUptdGYgcwHjCzJS >> 25) & 0x7F) + 1980;
			return new DateTime((int)year, (int)month, Math.Max(1, Math.Min(DateTime.DaysInMonth((int)year, (int)month), (int)((oqEsHdOutdOMQUptdGYgcwHjCzJS >> 16) & 0x1F))), (int)hour, (int)minute, (int)second);
		}
		set
		{
			uint num = (uint)value.Year;
			uint num2 = (uint)value.Month;
			uint num3 = (uint)value.Day;
			uint num4 = (uint)value.Hour;
			uint num5 = (uint)value.Minute;
			uint num6 = (uint)value.Second;
			if (num < 1980)
			{
				num = 1980u;
				num2 = 1u;
				num3 = 1u;
				num4 = 0u;
				num5 = 0u;
				num6 = 0u;
			}
			else if (num > 2107)
			{
				num = 2107u;
				num2 = 12u;
				num3 = 31u;
				num4 = 23u;
				num5 = 59u;
				num6 = 59u;
			}
			DosTime = (((num - 1980) & 0x7F) << 25) | (num2 << 21) | (num3 << 16) | (num4 << 11) | (num5 << 5) | (num6 >> 1);
		}
	}

	public long DosTime
	{
		get
		{
			if ((HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.Time) != 0)
			{
				return oqEsHdOutdOMQUptdGYgcwHjCzJS;
			}
			return 0L;
		}
		set
		{
			oqEsHdOutdOMQUptdGYgcwHjCzJS = (uint)value;
			HCzMSLbMmAJKqTnzJhBEurDWLVhB = HCzMSLbMmAJKqTnzJhBEurDWLVhB | mHekfjAMgDwkSPKRhJkBJbJppusp.None | mHekfjAMgDwkSPKRhJkBJbJppusp.Time;
		}
	}

	public int ExternalFileAttributes
	{
		get
		{
			if ((HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.ExternalAttributes) != 0)
			{
				return NhRFHQiEWUCvBipLscJFtskdqNqL;
			}
			return -1;
		}
		set
		{
			NhRFHQiEWUCvBipLscJFtskdqNqL = value;
			HCzMSLbMmAJKqTnzJhBEurDWLVhB |= mHekfjAMgDwkSPKRhJkBJbJppusp.ExternalAttributes;
		}
	}

	public byte[] ExtraData
	{
		get
		{
			return wuwwFVwLTNnubaByIpSRBpFDJxqp;
		}
		set
		{
			if (value != null)
			{
				if (value.Length > 65535)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				wuwwFVwLTNnubaByIpSRBpFDJxqp = new byte[value.Length];
				Array.Copy(value, 0, wuwwFVwLTNnubaByIpSRBpFDJxqp, 0, value.Length);
			}
			else
			{
				wuwwFVwLTNnubaByIpSRBpFDJxqp = null;
			}
		}
	}

	public int Flags
	{
		get
		{
			return KRSLLhSGmTTumqjBSeofDNbovNowA;
		}
		set
		{
			KRSLLhSGmTTumqjBSeofDNbovNowA = value;
		}
	}

	public bool HasCrc => (HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.Crc) != 0;

	public int HostSystem
	{
		get
		{
			return (XkrQONhAsrifMhXwYMgbaetCfrqY >> 8) & 0xFF;
		}
		set
		{
			XkrQONhAsrifMhXwYMgbaetCfrqY &= 255;
			XkrQONhAsrifMhXwYMgbaetCfrqY |= (ushort)((value & 0xFF) << 8);
		}
	}

	public bool IsCrypted
	{
		get
		{
			return (KRSLLhSGmTTumqjBSeofDNbovNowA & 1) != 0;
		}
		set
		{
			if (value)
			{
				KRSLLhSGmTTumqjBSeofDNbovNowA |= 1;
			}
			else
			{
				KRSLLhSGmTTumqjBSeofDNbovNowA &= -2;
			}
		}
	}

	public bool IsDirectory
	{
		get
		{
			int length = SIjohnLvPJKRsnAyvPeIQEkneQoc.Length;
			return (length > 0 && (SIjohnLvPJKRsnAyvPeIQEkneQoc[length - 1] == '/' || SIjohnLvPJKRsnAyvPeIQEkneQoc[length - 1] == '\\')) || UGqbHoYINIEUnAkCaOCOUSOdgkOUA(16);
		}
	}

	public bool IsDOSEntry
	{
		get
		{
			if (HostSystem == 0)
			{
				return true;
			}
			return HostSystem == 10;
		}
	}

	public bool IsFile => !IsDirectory && !UGqbHoYINIEUnAkCaOCOUSOdgkOUA(8);

	public bool IsUnicodeText
	{
		get
		{
			return (KRSLLhSGmTTumqjBSeofDNbovNowA & 0x800) != 0;
		}
		set
		{
			if (!value)
			{
				KRSLLhSGmTTumqjBSeofDNbovNowA &= -2049;
			}
			else
			{
				KRSLLhSGmTTumqjBSeofDNbovNowA |= 2048;
			}
		}
	}

	public bool LocalHeaderRequiresZip64
	{
		get
		{
			bool sJEOiVyQtKtOtoHJIpvBRmRJKmEh;
			if (!(sJEOiVyQtKtOtoHJIpvBRmRJKmEh = SJEOiVyQtKtOtoHJIpvBRmRJKmEh))
			{
				ulong num = IlXkaaAFtXOuKZdCXtcuJIdPWFqo;
				if (gbDDMhHSxqADZuxfrBphglHBiviu == 0 && IsCrypted)
				{
					num += 12L;
				}
				return (nNIdigjNWtldYPhvYFfhBELJWnvSb >= 4294967295L || num >= 4294967295L) && (gbDDMhHSxqADZuxfrBphglHBiviu == 0 || gbDDMhHSxqADZuxfrBphglHBiviu >= 45);
			}
			return sJEOiVyQtKtOtoHJIpvBRmRJKmEh;
		}
	}

	public string Name => SIjohnLvPJKRsnAyvPeIQEkneQoc;

	public long Offset
	{
		get
		{
			return tgJiTAKRvcmDbAhYbCUlPocYXOqH;
		}
		set
		{
			tgJiTAKRvcmDbAhYbCUlPocYXOqH = value;
		}
	}

	public long Size
	{
		get
		{
			if ((HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.Size) != 0)
			{
				return (long)nNIdigjNWtldYPhvYFfhBELJWnvSb;
			}
			return -1L;
		}
		set
		{
			nNIdigjNWtldYPhvYFfhBELJWnvSb = (ulong)value;
			HCzMSLbMmAJKqTnzJhBEurDWLVhB = HCzMSLbMmAJKqTnzJhBEurDWLVhB | mHekfjAMgDwkSPKRhJkBJbJppusp.None | mHekfjAMgDwkSPKRhJkBJbJppusp.Size;
		}
	}

	public int Version
	{
		get
		{
			if (gbDDMhHSxqADZuxfrBphglHBiviu != 0)
			{
				return gbDDMhHSxqADZuxfrBphglHBiviu;
			}
			int result = 10;
			if (CentralHeaderRequiresZip64)
			{
				return 45;
			}
			if (CompressionMethod.Deflated == nuBXHKVgvjUSARpsRIyuszNFgDxH)
			{
				return 20;
			}
			if (IsDirectory)
			{
				return 20;
			}
			if (IsCrypted)
			{
				return 20;
			}
			if (UGqbHoYINIEUnAkCaOCOUSOdgkOUA(8))
			{
				result = 11;
			}
			return result;
		}
	}

	public int VersionMadeBy => XkrQONhAsrifMhXwYMgbaetCfrqY & 0xFF;

	public long ZipFileIndex
	{
		get
		{
			return HnloPFySyIEgJdGQODxOKcZrGKlFA;
		}
		set
		{
			HnloPFySyIEgJdGQODxOKcZrGKlFA = value;
		}
	}

	[Obsolete("Use Clone instead")]
	public ZipEntry(ZipEntry entry)
	{
		NhRFHQiEWUCvBipLscJFtskdqNqL = -1;
		nuBXHKVgvjUSARpsRIyuszNFgDxH = CompressionMethod.Deflated;
		HnloPFySyIEgJdGQODxOKcZrGKlFA = -1L;
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		HCzMSLbMmAJKqTnzJhBEurDWLVhB = entry.HCzMSLbMmAJKqTnzJhBEurDWLVhB;
		SIjohnLvPJKRsnAyvPeIQEkneQoc = entry.SIjohnLvPJKRsnAyvPeIQEkneQoc;
		nNIdigjNWtldYPhvYFfhBELJWnvSb = entry.nNIdigjNWtldYPhvYFfhBELJWnvSb;
		IlXkaaAFtXOuKZdCXtcuJIdPWFqo = entry.IlXkaaAFtXOuKZdCXtcuJIdPWFqo;
		NGSBQrESjFRrBWFgppgucwTCLewW = entry.NGSBQrESjFRrBWFgppgucwTCLewW;
		oqEsHdOutdOMQUptdGYgcwHjCzJS = entry.oqEsHdOutdOMQUptdGYgcwHjCzJS;
		nuBXHKVgvjUSARpsRIyuszNFgDxH = entry.nuBXHKVgvjUSARpsRIyuszNFgDxH;
		lCpciUfpxHqxgSrreoyCNhuITMHM = entry.lCpciUfpxHqxgSrreoyCNhuITMHM;
		gbDDMhHSxqADZuxfrBphglHBiviu = entry.gbDDMhHSxqADZuxfrBphglHBiviu;
		XkrQONhAsrifMhXwYMgbaetCfrqY = entry.XkrQONhAsrifMhXwYMgbaetCfrqY;
		NhRFHQiEWUCvBipLscJFtskdqNqL = entry.NhRFHQiEWUCvBipLscJFtskdqNqL;
		KRSLLhSGmTTumqjBSeofDNbovNowA = entry.KRSLLhSGmTTumqjBSeofDNbovNowA;
		HnloPFySyIEgJdGQODxOKcZrGKlFA = entry.HnloPFySyIEgJdGQODxOKcZrGKlFA;
		tgJiTAKRvcmDbAhYbCUlPocYXOqH = entry.tgJiTAKRvcmDbAhYbCUlPocYXOqH;
		SJEOiVyQtKtOtoHJIpvBRmRJKmEh = entry.SJEOiVyQtKtOtoHJIpvBRmRJKmEh;
		if (entry.wuwwFVwLTNnubaByIpSRBpFDJxqp != null)
		{
			wuwwFVwLTNnubaByIpSRBpFDJxqp = new byte[entry.wuwwFVwLTNnubaByIpSRBpFDJxqp.Length];
			Array.Copy(entry.wuwwFVwLTNnubaByIpSRBpFDJxqp, 0, wuwwFVwLTNnubaByIpSRBpFDJxqp, 0, entry.wuwwFVwLTNnubaByIpSRBpFDJxqp.Length);
		}
	}

	public ZipEntry(string name)
		: this(name, 0, 45, CompressionMethod.Deflated)
	{
	}

	internal ZipEntry(string name, int versionRequiredToExtract)
		: this(name, versionRequiredToExtract, 45, CompressionMethod.Deflated)
	{
	}

	internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method)
	{
		NhRFHQiEWUCvBipLscJFtskdqNqL = -1;
		nuBXHKVgvjUSARpsRIyuszNFgDxH = CompressionMethod.Deflated;
		HnloPFySyIEgJdGQODxOKcZrGKlFA = -1L;
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length > 65535)
		{
			throw new ArgumentException("Name is too long", "name");
		}
		if (versionRequiredToExtract != 0 && versionRequiredToExtract < 10)
		{
			throw new ArgumentOutOfRangeException("versionRequiredToExtract");
		}
		DateTime = DateTime.Now;
		SIjohnLvPJKRsnAyvPeIQEkneQoc = name;
		XkrQONhAsrifMhXwYMgbaetCfrqY = (ushort)madeByInfo;
		gbDDMhHSxqADZuxfrBphglHBiviu = (ushort)versionRequiredToExtract;
		nuBXHKVgvjUSARpsRIyuszNFgDxH = method;
	}

	public static string CleanName(string name)
	{
		if (name == null)
		{
			return string.Empty;
		}
		if (Path.IsPathRooted(name))
		{
			name = name.Substring(Path.GetPathRoot(name)!.Length);
		}
		name = name.Replace("\\", "/");
		while (name.Length > 0)
		{
			if (name[0] == '/')
			{
				name = name.Remove(0, 1);
				continue;
			}
			return name;
		}
		return name;
	}

	public object Clone()
	{
		ZipEntry zipEntry = (ZipEntry)MemberwiseClone();
		if (wuwwFVwLTNnubaByIpSRBpFDJxqp != null)
		{
			zipEntry.wuwwFVwLTNnubaByIpSRBpFDJxqp = new byte[wuwwFVwLTNnubaByIpSRBpFDJxqp.Length];
			Array.Copy(wuwwFVwLTNnubaByIpSRBpFDJxqp, 0, zipEntry.wuwwFVwLTNnubaByIpSRBpFDJxqp, 0, wuwwFVwLTNnubaByIpSRBpFDJxqp.Length);
		}
		return zipEntry;
	}

	public void ForceZip64()
	{
		SJEOiVyQtKtOtoHJIpvBRmRJKmEh = true;
	}

	private bool UGqbHoYINIEUnAkCaOCOUSOdgkOUA(int attributes)
	{
		bool result = false;
		if ((HCzMSLbMmAJKqTnzJhBEurDWLVhB & mHekfjAMgDwkSPKRhJkBJbJppusp.ExternalAttributes) != 0 && (HostSystem == 0 || HostSystem == 10) && (ExternalFileAttributes & attributes) == attributes)
		{
			result = true;
		}
		return result;
	}

	public bool IsCompressionMethodSupported()
	{
		return IsCompressionMethodSupported(CompressionMethod);
	}

	public static bool IsCompressionMethodSupported(CompressionMethod method)
	{
		if (method == CompressionMethod.Deflated)
		{
			return true;
		}
		return method == CompressionMethod.Stored;
	}

	public bool IsZip64Forced()
	{
		return SJEOiVyQtKtOtoHJIpvBRmRJKmEh;
	}

	internal void AeqxguekIVMcjGFKBbGLRoJAaXqg(bool localHeader)
	{
		ZipExtraData zipExtraData = new ZipExtraData(wuwwFVwLTNnubaByIpSRBpFDJxqp);
		if (zipExtraData.Find(1))
		{
			if ((gbDDMhHSxqADZuxfrBphglHBiviu & 0xFF) < 45)
			{
				throw new ZipException("Zip64 Extended information found but version is not valid");
			}
			SJEOiVyQtKtOtoHJIpvBRmRJKmEh = true;
			if (zipExtraData.ValueLength < 4)
			{
				throw new ZipException("Extra data extended Zip64 information length is invalid");
			}
			if (localHeader || nNIdigjNWtldYPhvYFfhBELJWnvSb == 4294967295L)
			{
				nNIdigjNWtldYPhvYFfhBELJWnvSb = (ulong)zipExtraData.ReadLong();
			}
			if (localHeader || IlXkaaAFtXOuKZdCXtcuJIdPWFqo == 4294967295L)
			{
				IlXkaaAFtXOuKZdCXtcuJIdPWFqo = (ulong)zipExtraData.ReadLong();
			}
			if (!localHeader && tgJiTAKRvcmDbAhYbCUlPocYXOqH == 4294967295L)
			{
				tgJiTAKRvcmDbAhYbCUlPocYXOqH = zipExtraData.ReadLong();
			}
		}
		else if ((gbDDMhHSxqADZuxfrBphglHBiviu & 0xFF) >= 45 && (nNIdigjNWtldYPhvYFfhBELJWnvSb == 4294967295L || IlXkaaAFtXOuKZdCXtcuJIdPWFqo == 4294967295L))
		{
			throw new ZipException("Zip64 Extended information required but is missing.");
		}
		if (!zipExtraData.Find(10))
		{
			if (zipExtraData.Find(21589))
			{
				int valueLength = zipExtraData.ValueLength;
				if (((uint)zipExtraData.ReadByte() & (true ? 1u : 0u)) != 0 && valueLength >= 5)
				{
					int seconds = zipExtraData.ReadInt();
					DateTime = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime();
				}
			}
			return;
		}
		if (zipExtraData.ValueLength < 8)
		{
			throw new ZipException("NTFS Extra data invalid");
		}
		zipExtraData.ReadInt();
		while (zipExtraData.UnreadCount >= 4)
		{
			int num = zipExtraData.ReadShort();
			int num2 = zipExtraData.ReadShort();
			if (num != 1)
			{
				zipExtraData.Skip(num2);
				continue;
			}
			if (num2 >= 24)
			{
				long fileTime = zipExtraData.ReadLong();
				zipExtraData.ReadLong();
				zipExtraData.ReadLong();
				DateTime = DateTime.FromFileTime(fileTime);
			}
			break;
		}
	}

	public override string ToString()
	{
		return SIjohnLvPJKRsnAyvPeIQEkneQoc;
	}
}
