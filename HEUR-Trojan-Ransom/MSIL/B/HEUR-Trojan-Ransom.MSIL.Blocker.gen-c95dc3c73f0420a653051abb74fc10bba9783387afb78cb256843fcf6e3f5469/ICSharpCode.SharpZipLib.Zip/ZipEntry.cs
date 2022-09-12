using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipEntry : ICloneable
{
	[Flags]
	private enum jXgPVYmdgiBWYcqsqufqvHWmCTzp : byte
	{
		CompressedSize = 2,
		Crc = 4,
		ExternalAttributes = 0x10,
		None = 0,
		Size = 1,
		Time = 8
	}

	private string aurHGpZMxmXLcrxOxhDxbPlTzoIK;

	private ulong BuLbOZizrmgGUyFrOevBAjsAfsbMA;

	private byte fuuqzaINfzvrzkLUYaEHHeinefmab;

	private uint fXEjUWoLtCsdEnBSsJTVYpAaFASV;

	private int OBFzrhIaWlPoFBZgdUziHVvkUHxX;

	private byte[] vZuxZiOTVeCPnJTgDXLmzGLIYrTc;

	private int ZfQfbYuMuaCxyTfkBpaInRkvyljh;

	private bool XBEPueIalnqFxHsiRriinQKEztPl;

	private jXgPVYmdgiBWYcqsqufqvHWmCTzp OJWcglCRGLqxQKkWcyqghIaVGkAGb;

	private CompressionMethod kZXrrxdbdYoJCeUVCbaHIgWGdJcn;

	private string JezDUYHdtwccBoUbxIKFSmHsoNNVA;

	private long oaNXCfsQFPpQxhohoJJQdDfBPubx;

	private ulong gOPGBDvMAQDMSIGaZoAfsWDPWdme;

	private uint WxUhgEidlsxDLxiBkdlVkCMLEBxhb;

	private ushort WvtDsmBQwOBTGStDRrXWMYkRYGpK;

	private ushort jRRkcSjKrNQpJFZYePuQSCKGRQrW;

	private long KbjrNyQoczwZXEOdVmAlcAGqJngv;

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
				return oaNXCfsQFPpQxhohoJJQdDfBPubx >= 4294967295L;
			}
			return true;
		}
	}

	public string Comment
	{
		get
		{
			return aurHGpZMxmXLcrxOxhDxbPlTzoIK;
		}
		set
		{
			if (value != null && value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", "cannot exceed 65535");
			}
			aurHGpZMxmXLcrxOxhDxbPlTzoIK = value;
		}
	}

	public long CompressedSize
	{
		get
		{
			if ((OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.CompressedSize) == 0)
			{
				return -1L;
			}
			return (long)BuLbOZizrmgGUyFrOevBAjsAfsbMA;
		}
		set
		{
			BuLbOZizrmgGUyFrOevBAjsAfsbMA = (ulong)value;
			OJWcglCRGLqxQKkWcyqghIaVGkAGb |= jXgPVYmdgiBWYcqsqufqvHWmCTzp.CompressedSize;
		}
	}

	public CompressionMethod CompressionMethod
	{
		get
		{
			return kZXrrxdbdYoJCeUVCbaHIgWGdJcn;
		}
		set
		{
			if (!IsCompressionMethodSupported(value))
			{
				throw new NotSupportedException("Compression method not supported");
			}
			kZXrrxdbdYoJCeUVCbaHIgWGdJcn = value;
		}
	}

	public long Crc
	{
		get
		{
			if ((OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.Crc) == 0)
			{
				return -1L;
			}
			return (long)WxUhgEidlsxDLxiBkdlVkCMLEBxhb & 0xFFFFFFFFL;
		}
		set
		{
			WxUhgEidlsxDLxiBkdlVkCMLEBxhb = (uint)value;
			OJWcglCRGLqxQKkWcyqghIaVGkAGb |= jXgPVYmdgiBWYcqsqufqvHWmCTzp.Crc;
		}
	}

	internal byte rJZTdarrXDaaoJcowVDHUrDNtOtDA
	{
		get
		{
			return fuuqzaINfzvrzkLUYaEHHeinefmab;
		}
		set
		{
			fuuqzaINfzvrzkLUYaEHHeinefmab = value;
		}
	}

	public DateTime DateTime
	{
		get
		{
			uint second = Math.Min(59u, 2 * (fXEjUWoLtCsdEnBSsJTVYpAaFASV & 0x1F));
			uint minute = Math.Min(59u, (fXEjUWoLtCsdEnBSsJTVYpAaFASV >> 5) & 0x3Fu);
			uint hour = Math.Min(23u, (fXEjUWoLtCsdEnBSsJTVYpAaFASV >> 11) & 0x1Fu);
			uint month = Math.Max(1u, Math.Min(12u, (fXEjUWoLtCsdEnBSsJTVYpAaFASV >> 21) & 0xFu));
			uint year = ((fXEjUWoLtCsdEnBSsJTVYpAaFASV >> 25) & 0x7F) + 1980;
			return new DateTime((int)year, (int)month, Math.Max(1, Math.Min(DateTime.DaysInMonth((int)year, (int)month), (int)((fXEjUWoLtCsdEnBSsJTVYpAaFASV >> 16) & 0x1F))), (int)hour, (int)minute, (int)second);
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
			if ((OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.Time) == 0)
			{
				return 0L;
			}
			return fXEjUWoLtCsdEnBSsJTVYpAaFASV;
		}
		set
		{
			fXEjUWoLtCsdEnBSsJTVYpAaFASV = (uint)value;
			OJWcglCRGLqxQKkWcyqghIaVGkAGb = OJWcglCRGLqxQKkWcyqghIaVGkAGb | jXgPVYmdgiBWYcqsqufqvHWmCTzp.None | jXgPVYmdgiBWYcqsqufqvHWmCTzp.Time;
		}
	}

	public int ExternalFileAttributes
	{
		get
		{
			if ((OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.ExternalAttributes) == 0)
			{
				return -1;
			}
			return OBFzrhIaWlPoFBZgdUziHVvkUHxX;
		}
		set
		{
			OBFzrhIaWlPoFBZgdUziHVvkUHxX = value;
			OJWcglCRGLqxQKkWcyqghIaVGkAGb |= jXgPVYmdgiBWYcqsqufqvHWmCTzp.ExternalAttributes;
		}
	}

	public byte[] ExtraData
	{
		get
		{
			return vZuxZiOTVeCPnJTgDXLmzGLIYrTc;
		}
		set
		{
			if (value == null)
			{
				vZuxZiOTVeCPnJTgDXLmzGLIYrTc = null;
				return;
			}
			if (value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			vZuxZiOTVeCPnJTgDXLmzGLIYrTc = new byte[value.Length];
			Array.Copy(value, 0, vZuxZiOTVeCPnJTgDXLmzGLIYrTc, 0, value.Length);
		}
	}

	public int Flags
	{
		get
		{
			return ZfQfbYuMuaCxyTfkBpaInRkvyljh;
		}
		set
		{
			ZfQfbYuMuaCxyTfkBpaInRkvyljh = value;
		}
	}

	public bool HasCrc => (OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.Crc) != 0;

	public int HostSystem
	{
		get
		{
			return (WvtDsmBQwOBTGStDRrXWMYkRYGpK >> 8) & 0xFF;
		}
		set
		{
			WvtDsmBQwOBTGStDRrXWMYkRYGpK &= 255;
			WvtDsmBQwOBTGStDRrXWMYkRYGpK |= (ushort)((value & 0xFF) << 8);
		}
	}

	public bool IsCrypted
	{
		get
		{
			return (ZfQfbYuMuaCxyTfkBpaInRkvyljh & 1) != 0;
		}
		set
		{
			if (value)
			{
				ZfQfbYuMuaCxyTfkBpaInRkvyljh |= 1;
			}
			else
			{
				ZfQfbYuMuaCxyTfkBpaInRkvyljh &= -2;
			}
		}
	}

	public bool IsDirectory
	{
		get
		{
			int length = JezDUYHdtwccBoUbxIKFSmHsoNNVA.Length;
			if (length > 0 && (JezDUYHdtwccBoUbxIKFSmHsoNNVA[length - 1] == '/' || JezDUYHdtwccBoUbxIKFSmHsoNNVA[length - 1] == '\\'))
			{
				return true;
			}
			return PxeirDsNTlpirBSlvSBxkzZiLXRU(16);
		}
	}

	public bool IsDOSEntry
	{
		get
		{
			if (HostSystem != 0)
			{
				return HostSystem == 10;
			}
			return true;
		}
	}

	public bool IsFile
	{
		get
		{
			if (!IsDirectory)
			{
				return !PxeirDsNTlpirBSlvSBxkzZiLXRU(8);
			}
			return false;
		}
	}

	public bool IsUnicodeText
	{
		get
		{
			return (ZfQfbYuMuaCxyTfkBpaInRkvyljh & 0x800) != 0;
		}
		set
		{
			if (value)
			{
				ZfQfbYuMuaCxyTfkBpaInRkvyljh |= 2048;
			}
			else
			{
				ZfQfbYuMuaCxyTfkBpaInRkvyljh &= -2049;
			}
		}
	}

	public bool LocalHeaderRequiresZip64
	{
		get
		{
			bool xBEPueIalnqFxHsiRriinQKEztPl;
			if (xBEPueIalnqFxHsiRriinQKEztPl = XBEPueIalnqFxHsiRriinQKEztPl)
			{
				return xBEPueIalnqFxHsiRriinQKEztPl;
			}
			ulong num = BuLbOZizrmgGUyFrOevBAjsAfsbMA;
			if (jRRkcSjKrNQpJFZYePuQSCKGRQrW == 0 && IsCrypted)
			{
				num += 12L;
			}
			if (gOPGBDvMAQDMSIGaZoAfsWDPWdme < 4294967295L && num < 4294967295L)
			{
				return false;
			}
			if (jRRkcSjKrNQpJFZYePuQSCKGRQrW == 0)
			{
				return true;
			}
			return jRRkcSjKrNQpJFZYePuQSCKGRQrW >= 45;
		}
	}

	public string Name => JezDUYHdtwccBoUbxIKFSmHsoNNVA;

	public long Offset
	{
		get
		{
			return oaNXCfsQFPpQxhohoJJQdDfBPubx;
		}
		set
		{
			oaNXCfsQFPpQxhohoJJQdDfBPubx = value;
		}
	}

	public long Size
	{
		get
		{
			if ((OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.Size) == 0)
			{
				return -1L;
			}
			return (long)gOPGBDvMAQDMSIGaZoAfsWDPWdme;
		}
		set
		{
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = (ulong)value;
			OJWcglCRGLqxQKkWcyqghIaVGkAGb = OJWcglCRGLqxQKkWcyqghIaVGkAGb | jXgPVYmdgiBWYcqsqufqvHWmCTzp.None | jXgPVYmdgiBWYcqsqufqvHWmCTzp.Size;
		}
	}

	public int Version
	{
		get
		{
			if (jRRkcSjKrNQpJFZYePuQSCKGRQrW != 0)
			{
				return jRRkcSjKrNQpJFZYePuQSCKGRQrW;
			}
			int result = 10;
			if (!CentralHeaderRequiresZip64)
			{
				if (CompressionMethod.Deflated == kZXrrxdbdYoJCeUVCbaHIgWGdJcn)
				{
					return 20;
				}
				if (IsDirectory)
				{
					return 20;
				}
				if (!IsCrypted)
				{
					if (PxeirDsNTlpirBSlvSBxkzZiLXRU(8))
					{
						result = 11;
					}
					return result;
				}
				return 20;
			}
			return 45;
		}
	}

	public int VersionMadeBy => WvtDsmBQwOBTGStDRrXWMYkRYGpK & 0xFF;

	public long ZipFileIndex
	{
		get
		{
			return KbjrNyQoczwZXEOdVmAlcAGqJngv;
		}
		set
		{
			KbjrNyQoczwZXEOdVmAlcAGqJngv = value;
		}
	}

	[Obsolete("Use Clone instead")]
	public ZipEntry(ZipEntry entry)
	{
		OBFzrhIaWlPoFBZgdUziHVvkUHxX = -1;
		kZXrrxdbdYoJCeUVCbaHIgWGdJcn = CompressionMethod.Deflated;
		KbjrNyQoczwZXEOdVmAlcAGqJngv = -1L;
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		OJWcglCRGLqxQKkWcyqghIaVGkAGb = entry.OJWcglCRGLqxQKkWcyqghIaVGkAGb;
		JezDUYHdtwccBoUbxIKFSmHsoNNVA = entry.JezDUYHdtwccBoUbxIKFSmHsoNNVA;
		gOPGBDvMAQDMSIGaZoAfsWDPWdme = entry.gOPGBDvMAQDMSIGaZoAfsWDPWdme;
		BuLbOZizrmgGUyFrOevBAjsAfsbMA = entry.BuLbOZizrmgGUyFrOevBAjsAfsbMA;
		WxUhgEidlsxDLxiBkdlVkCMLEBxhb = entry.WxUhgEidlsxDLxiBkdlVkCMLEBxhb;
		fXEjUWoLtCsdEnBSsJTVYpAaFASV = entry.fXEjUWoLtCsdEnBSsJTVYpAaFASV;
		kZXrrxdbdYoJCeUVCbaHIgWGdJcn = entry.kZXrrxdbdYoJCeUVCbaHIgWGdJcn;
		aurHGpZMxmXLcrxOxhDxbPlTzoIK = entry.aurHGpZMxmXLcrxOxhDxbPlTzoIK;
		jRRkcSjKrNQpJFZYePuQSCKGRQrW = entry.jRRkcSjKrNQpJFZYePuQSCKGRQrW;
		WvtDsmBQwOBTGStDRrXWMYkRYGpK = entry.WvtDsmBQwOBTGStDRrXWMYkRYGpK;
		OBFzrhIaWlPoFBZgdUziHVvkUHxX = entry.OBFzrhIaWlPoFBZgdUziHVvkUHxX;
		ZfQfbYuMuaCxyTfkBpaInRkvyljh = entry.ZfQfbYuMuaCxyTfkBpaInRkvyljh;
		KbjrNyQoczwZXEOdVmAlcAGqJngv = entry.KbjrNyQoczwZXEOdVmAlcAGqJngv;
		oaNXCfsQFPpQxhohoJJQdDfBPubx = entry.oaNXCfsQFPpQxhohoJJQdDfBPubx;
		XBEPueIalnqFxHsiRriinQKEztPl = entry.XBEPueIalnqFxHsiRriinQKEztPl;
		if (entry.vZuxZiOTVeCPnJTgDXLmzGLIYrTc != null)
		{
			vZuxZiOTVeCPnJTgDXLmzGLIYrTc = new byte[entry.vZuxZiOTVeCPnJTgDXLmzGLIYrTc.Length];
			Array.Copy(entry.vZuxZiOTVeCPnJTgDXLmzGLIYrTc, 0, vZuxZiOTVeCPnJTgDXLmzGLIYrTc, 0, entry.vZuxZiOTVeCPnJTgDXLmzGLIYrTc.Length);
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
		OBFzrhIaWlPoFBZgdUziHVvkUHxX = -1;
		kZXrrxdbdYoJCeUVCbaHIgWGdJcn = CompressionMethod.Deflated;
		KbjrNyQoczwZXEOdVmAlcAGqJngv = -1L;
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
		JezDUYHdtwccBoUbxIKFSmHsoNNVA = name;
		WvtDsmBQwOBTGStDRrXWMYkRYGpK = (ushort)madeByInfo;
		jRRkcSjKrNQpJFZYePuQSCKGRQrW = (ushort)versionRequiredToExtract;
		kZXrrxdbdYoJCeUVCbaHIgWGdJcn = method;
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
		while (true)
		{
			if (name.Length > 0)
			{
				if (name[0] != '/')
				{
					break;
				}
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
		if (vZuxZiOTVeCPnJTgDXLmzGLIYrTc != null)
		{
			zipEntry.vZuxZiOTVeCPnJTgDXLmzGLIYrTc = new byte[vZuxZiOTVeCPnJTgDXLmzGLIYrTc.Length];
			Array.Copy(vZuxZiOTVeCPnJTgDXLmzGLIYrTc, 0, zipEntry.vZuxZiOTVeCPnJTgDXLmzGLIYrTc, 0, vZuxZiOTVeCPnJTgDXLmzGLIYrTc.Length);
		}
		return zipEntry;
	}

	public void ForceZip64()
	{
		XBEPueIalnqFxHsiRriinQKEztPl = true;
	}

	private bool PxeirDsNTlpirBSlvSBxkzZiLXRU(int attributes)
	{
		bool result = false;
		if ((OJWcglCRGLqxQKkWcyqghIaVGkAGb & jXgPVYmdgiBWYcqsqufqvHWmCTzp.ExternalAttributes) != 0 && (HostSystem == 0 || HostSystem == 10) && (ExternalFileAttributes & attributes) == attributes)
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
		if (method != CompressionMethod.Deflated)
		{
			return method == CompressionMethod.Stored;
		}
		return true;
	}

	public bool IsZip64Forced()
	{
		return XBEPueIalnqFxHsiRriinQKEztPl;
	}

	internal void FaiEDFBWmsKkhQbvMleyMnUFnRnFA(bool localHeader)
	{
		ZipExtraData zipExtraData = new ZipExtraData(vZuxZiOTVeCPnJTgDXLmzGLIYrTc);
		if (!zipExtraData.Find(1))
		{
			if ((jRRkcSjKrNQpJFZYePuQSCKGRQrW & 0xFF) >= 45 && (gOPGBDvMAQDMSIGaZoAfsWDPWdme == 4294967295L || BuLbOZizrmgGUyFrOevBAjsAfsbMA == 4294967295L))
			{
				throw new ZipException("Zip64 Extended information required but is missing.");
			}
		}
		else
		{
			if ((jRRkcSjKrNQpJFZYePuQSCKGRQrW & 0xFF) < 45)
			{
				throw new ZipException("Zip64 Extended information found but version is not valid");
			}
			XBEPueIalnqFxHsiRriinQKEztPl = true;
			if (zipExtraData.ValueLength < 4)
			{
				throw new ZipException("Extra data extended Zip64 information length is invalid");
			}
			if (localHeader || gOPGBDvMAQDMSIGaZoAfsWDPWdme == 4294967295L)
			{
				gOPGBDvMAQDMSIGaZoAfsWDPWdme = (ulong)zipExtraData.ReadLong();
			}
			if (localHeader || BuLbOZizrmgGUyFrOevBAjsAfsbMA == 4294967295L)
			{
				BuLbOZizrmgGUyFrOevBAjsAfsbMA = (ulong)zipExtraData.ReadLong();
			}
			if (!localHeader && oaNXCfsQFPpQxhohoJJQdDfBPubx == 4294967295L)
			{
				oaNXCfsQFPpQxhohoJJQdDfBPubx = zipExtraData.ReadLong();
			}
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
		return JezDUYHdtwccBoUbxIKFSmHsoNNVA;
	}
}
