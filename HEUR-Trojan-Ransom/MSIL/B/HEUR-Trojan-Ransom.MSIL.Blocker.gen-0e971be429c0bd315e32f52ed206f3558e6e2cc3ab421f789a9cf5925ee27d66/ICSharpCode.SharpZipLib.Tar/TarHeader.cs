using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarHeader : ICloneable
{
	private int hkOvlGyMyaBpITEuUhTVDIqbpZCL;

	public const int CHKSUMLEN = 8;

	public const int CHKSUMOFS = 148;

	private static readonly DateTime ykgEMjbVDtldDvDNvTsQBSFFTxXr = new DateTime(1970, 1, 1, 0, 0, 0, 0);

	internal static int FkAIfOpULIrAGGiOErcxlJRbcMvKA;

	internal static string vvTYIXnIBHIpdeMguMELPOIgbuuu = "None";

	internal static string XcreyYggaPCFvElyhbqpzEoDRZxec;

	internal static int LfEUGwYhkFhlGCQdphVLhybmbpvXA;

	public const int DEVLEN = 8;

	private int gNSECTgPAbMuvABHBAUsMgZLxZAnB;

	private int HsTTfOwBfjRihIRKcJALgbqQauIy;

	public const int GIDLEN = 8;

	public const int GNAMELEN = 32;

	public const string GNU_TMAGIC = "ustar  ";

	private int MxINTEoEEYZGyjioVCoYqFGaunen;

	internal static int rIGLxwzEFLJfUqLTPdTnQwyJkmKq;

	private string ZuNEfYwUlISJWXoPnaHDCAuwDOhl;

	internal static string tQngBjGImrQAIgasbQkSmvNwRlrM = "None";

	private bool xovWNEORykVbmEvMIHvxMHyioxsL;

	public const byte LF_ACL = 65;

	public const byte LF_BLK = 52;

	public const byte LF_CHR = 51;

	public const byte LF_CONTIG = 55;

	public const byte LF_DIR = 53;

	public const byte LF_EXTATTR = 69;

	public const byte LF_FIFO = 54;

	public const byte LF_GHDR = 103;

	public const byte LF_GNU_DUMPDIR = 68;

	public const byte LF_GNU_LONGLINK = 75;

	public const byte LF_GNU_LONGNAME = 76;

	public const byte LF_GNU_MULTIVOL = 77;

	public const byte LF_GNU_NAMES = 78;

	public const byte LF_GNU_SPARSE = 83;

	public const byte LF_GNU_VOLHDR = 86;

	public const byte LF_LINK = 49;

	public const byte LF_META = 73;

	public const byte LF_NORMAL = 48;

	public const byte LF_OLDNORM = 0;

	public const byte LF_SYMLINK = 50;

	public const byte LF_XHDR = 120;

	private string kWygwfKENydNogATXDbeAiWHQMGZA;

	private string WTnVTNVCGilVyGBNPvOgrkzrjQzl;

	public const int MAGICLEN = 6;

	private int LlcDOZFNqyDRAHCCbndwFtARpdUbb;

	public const int MODELEN = 8;

	private DateTime FUrNsBrCJETKVSMhMxGJqcsoncvN;

	public const int MODTIMELEN = 12;

	private string SIjohnLvPJKRsnAyvPeIQEkneQoc;

	public const int NAMELEN = 100;

	private long nNIdigjNWtldYPhvYFfhBELJWnvSb;

	public const int SIZELEN = 12;

	private const long XGxZSZYLnoIJktoJVViSSEOnQkEX = 10000000L;

	public const string TMAGIC = "ustar ";

	private byte HPQqVOycavTMVzgivRiOiLbBAugl;

	public const int UIDLEN = 8;

	public const int UNAMELEN = 32;

	private int bECThAXngRsQNlQJLpbtZlvaEFRIA;

	internal static int BYrUQikfNsWcnwCrzxFjgEdcnubx;

	private string tyOTbgMpTewRdOBuQOHRblUiFlaK;

	internal static string JERxOYZPJQILOkBmIrWZSCjkbvbFA;

	private string dJoMuFUdKNZGlfjSmXPZOuSobPxV;

	public const int VERSIONLEN = 2;

	public int Checksum => hkOvlGyMyaBpITEuUhTVDIqbpZCL;

	public int DevMajor
	{
		get
		{
			return gNSECTgPAbMuvABHBAUsMgZLxZAnB;
		}
		set
		{
			gNSECTgPAbMuvABHBAUsMgZLxZAnB = value;
		}
	}

	public int DevMinor
	{
		get
		{
			return HsTTfOwBfjRihIRKcJALgbqQauIy;
		}
		set
		{
			HsTTfOwBfjRihIRKcJALgbqQauIy = value;
		}
	}

	public int GroupId
	{
		get
		{
			return MxINTEoEEYZGyjioVCoYqFGaunen;
		}
		set
		{
			MxINTEoEEYZGyjioVCoYqFGaunen = value;
		}
	}

	public string GroupName
	{
		get
		{
			return ZuNEfYwUlISJWXoPnaHDCAuwDOhl;
		}
		set
		{
			if (value != null)
			{
				ZuNEfYwUlISJWXoPnaHDCAuwDOhl = value;
			}
			else
			{
				ZuNEfYwUlISJWXoPnaHDCAuwDOhl = "None";
			}
		}
	}

	public bool IsChecksumValid => xovWNEORykVbmEvMIHvxMHyioxsL;

	public string LinkName
	{
		get
		{
			return kWygwfKENydNogATXDbeAiWHQMGZA;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			kWygwfKENydNogATXDbeAiWHQMGZA = value;
		}
	}

	public string Magic
	{
		get
		{
			return WTnVTNVCGilVyGBNPvOgrkzrjQzl;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			WTnVTNVCGilVyGBNPvOgrkzrjQzl = value;
		}
	}

	public int Mode
	{
		get
		{
			return LlcDOZFNqyDRAHCCbndwFtARpdUbb;
		}
		set
		{
			LlcDOZFNqyDRAHCCbndwFtARpdUbb = value;
		}
	}

	public DateTime ModTime
	{
		get
		{
			return FUrNsBrCJETKVSMhMxGJqcsoncvN;
		}
		set
		{
			if (value < ykgEMjbVDtldDvDNvTsQBSFFTxXr)
			{
				throw new ArgumentOutOfRangeException("value", "ModTime cannot be before Jan 1st 1970");
			}
			FUrNsBrCJETKVSMhMxGJqcsoncvN = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
		}
	}

	public string Name
	{
		get
		{
			return SIjohnLvPJKRsnAyvPeIQEkneQoc;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SIjohnLvPJKRsnAyvPeIQEkneQoc = value;
		}
	}

	public long Size
	{
		get
		{
			return nNIdigjNWtldYPhvYFfhBELJWnvSb;
		}
		set
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value", "Cannot be less than zero");
			}
			nNIdigjNWtldYPhvYFfhBELJWnvSb = value;
		}
	}

	public byte TypeFlag
	{
		get
		{
			return HPQqVOycavTMVzgivRiOiLbBAugl;
		}
		set
		{
			HPQqVOycavTMVzgivRiOiLbBAugl = value;
		}
	}

	public int UserId
	{
		get
		{
			return bECThAXngRsQNlQJLpbtZlvaEFRIA;
		}
		set
		{
			bECThAXngRsQNlQJLpbtZlvaEFRIA = value;
		}
	}

	public string UserName
	{
		get
		{
			return tyOTbgMpTewRdOBuQOHRblUiFlaK;
		}
		set
		{
			if (value != null)
			{
				tyOTbgMpTewRdOBuQOHRblUiFlaK = value.Substring(0, Math.Min(32, value.Length));
				return;
			}
			string text = Environment.UserName;
			if (text.Length > 32)
			{
				text = text.Substring(0, 32);
			}
			tyOTbgMpTewRdOBuQOHRblUiFlaK = text;
		}
	}

	public string Version
	{
		get
		{
			return dJoMuFUdKNZGlfjSmXPZOuSobPxV;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			dJoMuFUdKNZGlfjSmXPZOuSobPxV = value;
		}
	}

	public TarHeader()
	{
		Magic = "ustar ";
		Version = " ";
		Name = "";
		LinkName = "";
		UserId = LfEUGwYhkFhlGCQdphVLhybmbpvXA;
		GroupId = FkAIfOpULIrAGGiOErcxlJRbcMvKA;
		UserName = XcreyYggaPCFvElyhbqpzEoDRZxec;
		GroupName = vvTYIXnIBHIpdeMguMELPOIgbuuu;
		Size = 0L;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	private static int pfPMbZzfUhaWSAYaRNyAuwTvsjlMA(byte[] buffer)
	{
		int num = 0;
		for (int i = 0; i < buffer.Length; i++)
		{
			num += buffer[i];
		}
		return num;
	}

	public override bool Equals(object object_0)
	{
		if (!(object_0 is TarHeader tarHeader))
		{
			return false;
		}
		return SIjohnLvPJKRsnAyvPeIQEkneQoc == tarHeader.SIjohnLvPJKRsnAyvPeIQEkneQoc && LlcDOZFNqyDRAHCCbndwFtARpdUbb == tarHeader.LlcDOZFNqyDRAHCCbndwFtARpdUbb && UserId == tarHeader.UserId && GroupId == tarHeader.GroupId && Size == tarHeader.Size && ModTime == tarHeader.ModTime && Checksum == tarHeader.Checksum && TypeFlag == tarHeader.TypeFlag && LinkName == tarHeader.LinkName && Magic == tarHeader.Magic && Version == tarHeader.Version && UserName == tarHeader.UserName && GroupName == tarHeader.GroupName && DevMajor == tarHeader.DevMajor && DevMinor == tarHeader.DevMinor;
	}

	public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (toAdd == null)
		{
			throw new ArgumentNullException("toAdd");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		for (int i = 0; i < length && nameOffset + i < toAdd.Length; i++)
		{
			buffer[bufferOffset + i] = (byte)toAdd[nameOffset + i];
		}
		return bufferOffset + length;
	}

	private static int RYZsTdlhEqeuSLDBiKIDFqYfnMRE(long value, byte[] buffer, int offset, int length)
	{
		GetOctalBytes(value, buffer, offset, length - 1);
		return offset + length;
	}

	private static int arjWrXQevZYWWBpNaDxfPUbXnilW(DateTime dateTime)
	{
		long ticks = dateTime.Ticks;
		DateTime dateTime2 = ykgEMjbVDtldDvDNvTsQBSFFTxXr;
		return (int)((ticks - dateTime2.Ticks) / 10000000L);
	}

	private static DateTime jHjepApskNOBWGeRUcGrOqfjwUmf(long ticks)
	{
		try
		{
			DateTime dateTime = ykgEMjbVDtldDvDNvTsQBSFFTxXr;
			return new DateTime(dateTime.Ticks + ticks * 10000000L);
		}
		catch (ArgumentOutOfRangeException)
		{
			return ykgEMjbVDtldDvDNvTsQBSFFTxXr;
		}
	}

	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	public static int GetLongOctalBytes(long value, byte[] buffer, int offset, int length)
	{
		return GetOctalBytes(value, buffer, offset, length);
	}

	[Obsolete("Use the Name property instead", true)]
	public string GetName()
	{
		return SIjohnLvPJKRsnAyvPeIQEkneQoc;
	}

	public static int GetNameBytes(string name, byte[] buffer, int offset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return GetNameBytes(name, 0, buffer, offset, length);
	}

	public static int GetNameBytes(StringBuilder name, byte[] buffer, int offset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return GetNameBytes(name.ToString(), 0, buffer, offset, length);
	}

	public static int GetNameBytes(string name, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (name != null)
		{
			if (buffer != null)
			{
				int i;
				for (i = 0; i < length - 1 && nameOffset + i < name.Length; i++)
				{
					buffer[bufferOffset + i] = (byte)name[nameOffset + i];
				}
				for (; i < length; i++)
				{
					buffer[bufferOffset + i] = 0;
				}
				return bufferOffset + length;
			}
			throw new ArgumentNullException("buffer");
		}
		throw new ArgumentNullException("name");
	}

	public static int GetNameBytes(StringBuilder name, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return GetNameBytes(name.ToString(), nameOffset, buffer, bufferOffset, length);
	}

	public static int GetOctalBytes(long value, byte[] buffer, int offset, int length)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int num = length - 1;
		buffer[offset + num] = 0;
		num--;
		if (value > 0L)
		{
			long num2 = value;
			while (num >= 0 && num2 > 0L)
			{
				buffer[offset + num] = (byte)(48 + (byte)(num2 & 7L));
				num2 >>= 3;
				num--;
			}
		}
		while (num >= 0)
		{
			buffer[offset + num] = 48;
			num--;
		}
		return offset + length;
	}

	private static int wqBPMgThoQrpklUiBmqsoeRvsNmX(byte[] buffer)
	{
		int num = 0;
		for (int i = 0; i < 148; i++)
		{
			num += buffer[i];
		}
		for (int j = 0; j < 8; j++)
		{
			num += 32;
		}
		for (int k = 156; k < buffer.Length; k++)
		{
			num += buffer[k];
		}
		return num;
	}

	public void ParseBuffer(byte[] header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		SIjohnLvPJKRsnAyvPeIQEkneQoc = ParseName(header, 0, 100).ToString();
		LlcDOZFNqyDRAHCCbndwFtARpdUbb = (int)ParseOctal(header, 100, 8);
		UserId = (int)ParseOctal(header, 108, 8);
		GroupId = (int)ParseOctal(header, 116, 8);
		Size = ParseOctal(header, 124, 12);
		ModTime = jHjepApskNOBWGeRUcGrOqfjwUmf(ParseOctal(header, 136, 12));
		hkOvlGyMyaBpITEuUhTVDIqbpZCL = (int)ParseOctal(header, 148, 8);
		TypeFlag = header[156];
		LinkName = ParseName(header, 157, 100).ToString();
		Magic = ParseName(header, 257, 6).ToString();
		Version = ParseName(header, 263, 2).ToString();
		UserName = ParseName(header, 265, 32).ToString();
		GroupName = ParseName(header, 297, 32).ToString();
		DevMajor = (int)ParseOctal(header, 329, 8);
		DevMinor = (int)ParseOctal(header, 337, 8);
		xovWNEORykVbmEvMIHvxMHyioxsL = Checksum == wqBPMgThoQrpklUiBmqsoeRvsNmX(header);
	}

	public static StringBuilder ParseName(byte[] header, int offset, int length)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "Cannot be less than zero");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "Cannot be less than zero");
		}
		if (offset + length > header.Length)
		{
			throw new ArgumentException("Exceeds header size", "length");
		}
		StringBuilder stringBuilder = new StringBuilder(length);
		for (int i = offset; i < offset + length; i++)
		{
			if (header[i] != 0)
			{
				stringBuilder.Append((char)header[i]);
				continue;
			}
			return stringBuilder;
		}
		return stringBuilder;
	}

	public static long ParseOctal(byte[] header, int offset, int length)
	{
		if (header != null)
		{
			long num = 0L;
			bool flag = true;
			int num2 = offset + length;
			int num3 = offset;
			while (true)
			{
				if (num3 < num2)
				{
					if (header[num3] == 0)
					{
						break;
					}
					if (header[num3] == 32 || header[num3] == 48)
					{
						if (flag)
						{
							goto IL_004f;
						}
						if (header[num3] == 32)
						{
							return num;
						}
					}
					flag = false;
					num = (num << 3) + (header[num3] - 48);
					goto IL_004f;
				}
				return num;
				IL_004f:
				num3++;
			}
			return num;
		}
		throw new ArgumentNullException("header");
	}

	internal static void mowHqEwmPIIyQGjOhDjZZtRNvutA()
	{
		LfEUGwYhkFhlGCQdphVLhybmbpvXA = BYrUQikfNsWcnwCrzxFjgEdcnubx;
		XcreyYggaPCFvElyhbqpzEoDRZxec = JERxOYZPJQILOkBmIrWZSCjkbvbFA;
		FkAIfOpULIrAGGiOErcxlJRbcMvKA = rIGLxwzEFLJfUqLTPdTnQwyJkmKq;
		vvTYIXnIBHIpdeMguMELPOIgbuuu = tQngBjGImrQAIgasbQkSmvNwRlrM;
	}

	internal static void lSEJHlfluaUcwBsZMYMRlyTNSaeb(int userId, string userName, int groupId, string groupName)
	{
		LfEUGwYhkFhlGCQdphVLhybmbpvXA = (BYrUQikfNsWcnwCrzxFjgEdcnubx = userId);
		XcreyYggaPCFvElyhbqpzEoDRZxec = (JERxOYZPJQILOkBmIrWZSCjkbvbFA = userName);
		FkAIfOpULIrAGGiOErcxlJRbcMvKA = (rIGLxwzEFLJfUqLTPdTnQwyJkmKq = groupId);
		vvTYIXnIBHIpdeMguMELPOIgbuuu = (tQngBjGImrQAIgasbQkSmvNwRlrM = groupName);
	}

	public void WriteHeader(byte[] outBuffer)
	{
		if (outBuffer != null)
		{
			int num = 0;
			num = GetNameBytes(Name, outBuffer, 0, 100);
			num = GetOctalBytes(LlcDOZFNqyDRAHCCbndwFtARpdUbb, outBuffer, num, 8);
			num = GetOctalBytes(UserId, outBuffer, num, 8);
			num = GetOctalBytes(GroupId, outBuffer, num, 8);
			num = GetLongOctalBytes(Size, outBuffer, num, 12);
			num = GetLongOctalBytes(arjWrXQevZYWWBpNaDxfPUbXnilW(ModTime), outBuffer, num, 12);
			int offset = num;
			for (int i = 0; i < 8; i++)
			{
				outBuffer[num++] = 32;
			}
			outBuffer[num++] = TypeFlag;
			num = GetNameBytes(LinkName, outBuffer, num, 100);
			num = GetAsciiBytes(Magic, 0, outBuffer, num, 6);
			num = GetNameBytes(Version, outBuffer, num, 2);
			num = GetNameBytes(UserName, outBuffer, num, 32);
			num = GetNameBytes(GroupName, outBuffer, num, 32);
			if (TypeFlag == 51 || TypeFlag == 52)
			{
				num = GetOctalBytes(DevMajor, outBuffer, num, 8);
				num = GetOctalBytes(DevMinor, outBuffer, num, 8);
			}
			while (num < outBuffer.Length)
			{
				outBuffer[num++] = 0;
			}
			hkOvlGyMyaBpITEuUhTVDIqbpZCL = pfPMbZzfUhaWSAYaRNyAuwTvsjlMA(outBuffer);
			RYZsTdlhEqeuSLDBiKIDFqYfnMRE(hkOvlGyMyaBpITEuUhTVDIqbpZCL, outBuffer, offset, 8);
			xovWNEORykVbmEvMIHvxMHyioxsL = true;
			return;
		}
		throw new ArgumentNullException("outBuffer");
	}
}
