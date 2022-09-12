using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar;

public class TarHeader : ICloneable
{
	private int qWMVVzMgrDxRAuZpXWMsbpXmuSTe;

	public const int CHKSUMLEN = 8;

	public const int CHKSUMOFS = 148;

	private static readonly DateTime fusmNMJjHWhPLMzmuUnfpNKGsCGU = new DateTime(1970, 1, 1, 0, 0, 0, 0);

	internal static int WYAATdNFNlXmCjvzNqxOXgOsOxav;

	internal static string abPyzqNgHsJnjBrVpNMebJWvDcbF = "None";

	internal static string YGpErtIukStlzEZsPtQAahClkoZ;

	internal static int IKQgmTkgZqRtMdAomShuQunzQcuf;

	public const int DEVLEN = 8;

	private int dRAskmrKhGSjfqheLZrXCcOeaHNI;

	private int UFVxplMQzWhtblKhlqSoEebRzRPv;

	public const int GIDLEN = 8;

	public const int GNAMELEN = 32;

	public const string GNU_TMAGIC = "ustar  ";

	private int VeQzdrAYMnenkAGZObvjYaLneMzY;

	internal static int szIfrTVtBwNRATSkGoMAsrtAnBVt;

	private string QlZfcjQEjrTaKkCTwCzwckfhdccZA;

	internal static string kZlAzCsisMAmCZzDeUrdEOErgOmz = "None";

	private bool gbhzyzoeSBNJutviZkEKunxbHdqb;

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

	private string jgudAIyVTVldmxdwUtaXURJGnVLl;

	private string RavxOkfcMNdBozBoAHVRLbuiJAuQ;

	public const int MAGICLEN = 6;

	private int IUaiPypAyJprEbBfufyZPnRGIEHt;

	public const int MODELEN = 8;

	private DateTime KczQccHAJleuRjBQNaByKjbhaZqo;

	public const int MODTIMELEN = 12;

	private string JezDUYHdtwccBoUbxIKFSmHsoNNVA;

	public const int NAMELEN = 100;

	private long gOPGBDvMAQDMSIGaZoAfsWDPWdme;

	public const int SIZELEN = 12;

	private const long QneewcidPZtijWuCtbzgvZiCZJiA = 10000000L;

	public const string TMAGIC = "ustar ";

	private byte WWAxejMZcEeJPKiJunXfSTwWxknh;

	public const int UIDLEN = 8;

	public const int UNAMELEN = 32;

	private int yRQJUhpOiecrXGgpCiYUfintoeKF;

	internal static int WelwrDOTwPCazDKocGEESdsdPSsf;

	private string clOonDuBLTPKdhoVLDVkfFHdPqnvA;

	internal static string UQPsfvzbJpnCGXpNBRVweNafETij;

	private string qroYUcqAticFjGjztScssDRzcZwg;

	public const int VERSIONLEN = 2;

	public int Checksum => qWMVVzMgrDxRAuZpXWMsbpXmuSTe;

	public int DevMajor
	{
		get
		{
			return dRAskmrKhGSjfqheLZrXCcOeaHNI;
		}
		set
		{
			dRAskmrKhGSjfqheLZrXCcOeaHNI = value;
		}
	}

	public int DevMinor
	{
		get
		{
			return UFVxplMQzWhtblKhlqSoEebRzRPv;
		}
		set
		{
			UFVxplMQzWhtblKhlqSoEebRzRPv = value;
		}
	}

	public int GroupId
	{
		get
		{
			return VeQzdrAYMnenkAGZObvjYaLneMzY;
		}
		set
		{
			VeQzdrAYMnenkAGZObvjYaLneMzY = value;
		}
	}

	public string GroupName
	{
		get
		{
			return QlZfcjQEjrTaKkCTwCzwckfhdccZA;
		}
		set
		{
			if (value == null)
			{
				QlZfcjQEjrTaKkCTwCzwckfhdccZA = "None";
			}
			else
			{
				QlZfcjQEjrTaKkCTwCzwckfhdccZA = value;
			}
		}
	}

	public bool IsChecksumValid => gbhzyzoeSBNJutviZkEKunxbHdqb;

	public string LinkName
	{
		get
		{
			return jgudAIyVTVldmxdwUtaXURJGnVLl;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			jgudAIyVTVldmxdwUtaXURJGnVLl = value;
		}
	}

	public string Magic
	{
		get
		{
			return RavxOkfcMNdBozBoAHVRLbuiJAuQ;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			RavxOkfcMNdBozBoAHVRLbuiJAuQ = value;
		}
	}

	public int Mode
	{
		get
		{
			return IUaiPypAyJprEbBfufyZPnRGIEHt;
		}
		set
		{
			IUaiPypAyJprEbBfufyZPnRGIEHt = value;
		}
	}

	public DateTime ModTime
	{
		get
		{
			return KczQccHAJleuRjBQNaByKjbhaZqo;
		}
		set
		{
			if (value < fusmNMJjHWhPLMzmuUnfpNKGsCGU)
			{
				throw new ArgumentOutOfRangeException("value", "ModTime cannot be before Jan 1st 1970");
			}
			KczQccHAJleuRjBQNaByKjbhaZqo = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
		}
	}

	public string Name
	{
		get
		{
			return JezDUYHdtwccBoUbxIKFSmHsoNNVA;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			JezDUYHdtwccBoUbxIKFSmHsoNNVA = value;
		}
	}

	public long Size
	{
		get
		{
			return gOPGBDvMAQDMSIGaZoAfsWDPWdme;
		}
		set
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value", "Cannot be less than zero");
			}
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = value;
		}
	}

	public byte TypeFlag
	{
		get
		{
			return WWAxejMZcEeJPKiJunXfSTwWxknh;
		}
		set
		{
			WWAxejMZcEeJPKiJunXfSTwWxknh = value;
		}
	}

	public int UserId
	{
		get
		{
			return yRQJUhpOiecrXGgpCiYUfintoeKF;
		}
		set
		{
			yRQJUhpOiecrXGgpCiYUfintoeKF = value;
		}
	}

	public string UserName
	{
		get
		{
			return clOonDuBLTPKdhoVLDVkfFHdPqnvA;
		}
		set
		{
			if (value != null)
			{
				clOonDuBLTPKdhoVLDVkfFHdPqnvA = value.Substring(0, Math.Min(32, value.Length));
				return;
			}
			string text = Environment.UserName;
			if (text.Length > 32)
			{
				text = text.Substring(0, 32);
			}
			clOonDuBLTPKdhoVLDVkfFHdPqnvA = text;
		}
	}

	public string Version
	{
		get
		{
			return qroYUcqAticFjGjztScssDRzcZwg;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			qroYUcqAticFjGjztScssDRzcZwg = value;
		}
	}

	public TarHeader()
	{
		Magic = "ustar ";
		Version = " ";
		Name = "";
		LinkName = "";
		UserId = IKQgmTkgZqRtMdAomShuQunzQcuf;
		GroupId = WYAATdNFNlXmCjvzNqxOXgOsOxav;
		UserName = YGpErtIukStlzEZsPtQAahClkoZ;
		GroupName = abPyzqNgHsJnjBrVpNMebJWvDcbF;
		Size = 0L;
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	private static int cnPJviXkWGgbUhXJUrdrWYSwSJuG(byte[] buffer)
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
		if (JezDUYHdtwccBoUbxIKFSmHsoNNVA == tarHeader.JezDUYHdtwccBoUbxIKFSmHsoNNVA && IUaiPypAyJprEbBfufyZPnRGIEHt == tarHeader.IUaiPypAyJprEbBfufyZPnRGIEHt && UserId == tarHeader.UserId && GroupId == tarHeader.GroupId && Size == tarHeader.Size && ModTime == tarHeader.ModTime && Checksum == tarHeader.Checksum && TypeFlag == tarHeader.TypeFlag && LinkName == tarHeader.LinkName && Magic == tarHeader.Magic && Version == tarHeader.Version && UserName == tarHeader.UserName && GroupName == tarHeader.GroupName && DevMajor == tarHeader.DevMajor)
		{
			return DevMinor == tarHeader.DevMinor;
		}
		return false;
	}

	public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length)
	{
		if (toAdd == null)
		{
			throw new ArgumentNullException("toAdd");
		}
		if (buffer != null)
		{
			for (int i = 0; i < length && nameOffset + i < toAdd.Length; i++)
			{
				buffer[bufferOffset + i] = (byte)toAdd[nameOffset + i];
			}
			return bufferOffset + length;
		}
		throw new ArgumentNullException("buffer");
	}

	private static int OuBeMkkXrJRGgemanrLcandbiYSLB(long value, byte[] buffer, int offset, int length)
	{
		GetOctalBytes(value, buffer, offset, length - 1);
		return offset + length;
	}

	private static int vdvNwaujnyywGeaolmOEfeyWZpkd(DateTime dateTime)
	{
		long ticks = dateTime.Ticks;
		DateTime dateTime2 = fusmNMJjHWhPLMzmuUnfpNKGsCGU;
		return (int)((ticks - dateTime2.Ticks) / 10000000L);
	}

	private static DateTime mVlTExJguqGoQBpaRrhGlmosxXteA(long ticks)
	{
		try
		{
			DateTime dateTime = fusmNMJjHWhPLMzmuUnfpNKGsCGU;
			return new DateTime(dateTime.Ticks + ticks * 10000000L);
		}
		catch (ArgumentOutOfRangeException)
		{
			return fusmNMJjHWhPLMzmuUnfpNKGsCGU;
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
		return JezDUYHdtwccBoUbxIKFSmHsoNNVA;
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
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
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

	private static int deBmIZjlwhHkgGkTUjrPMbOemltL(byte[] buffer)
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
		JezDUYHdtwccBoUbxIKFSmHsoNNVA = ParseName(header, 0, 100).ToString();
		IUaiPypAyJprEbBfufyZPnRGIEHt = (int)ParseOctal(header, 100, 8);
		UserId = (int)ParseOctal(header, 108, 8);
		GroupId = (int)ParseOctal(header, 116, 8);
		Size = ParseOctal(header, 124, 12);
		ModTime = mVlTExJguqGoQBpaRrhGlmosxXteA(ParseOctal(header, 136, 12));
		qWMVVzMgrDxRAuZpXWMsbpXmuSTe = (int)ParseOctal(header, 148, 8);
		TypeFlag = header[156];
		LinkName = ParseName(header, 157, 100).ToString();
		Magic = ParseName(header, 257, 6).ToString();
		Version = ParseName(header, 263, 2).ToString();
		UserName = ParseName(header, 265, 32).ToString();
		GroupName = ParseName(header, 297, 32).ToString();
		DevMajor = (int)ParseOctal(header, 329, 8);
		DevMinor = (int)ParseOctal(header, 337, 8);
		gbhzyzoeSBNJutviZkEKunxbHdqb = Checksum == deBmIZjlwhHkgGkTUjrPMbOemltL(header);
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
		if (length >= 0)
		{
			if (offset + length > header.Length)
			{
				throw new ArgumentException("Exceeds header size", "length");
			}
			StringBuilder stringBuilder = new StringBuilder(length);
			int num = offset;
			while (true)
			{
				if (num < offset + length)
				{
					if (header[num] == 0)
					{
						break;
					}
					stringBuilder.Append((char)header[num]);
					num++;
					continue;
				}
				return stringBuilder;
			}
			return stringBuilder;
		}
		throw new ArgumentOutOfRangeException("length", "Cannot be less than zero");
	}

	public static long ParseOctal(byte[] header, int offset, int length)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		long num = 0L;
		bool flag = true;
		int num2 = offset + length;
		for (int i = offset; i < num2; i++)
		{
			if (header[i] != 0)
			{
				if (header[i] == 32 || header[i] == 48)
				{
					if (flag)
					{
						continue;
					}
					if (header[i] == 32)
					{
						return num;
					}
				}
				flag = false;
				num = (num << 3) + (header[i] - 48);
				continue;
			}
			return num;
		}
		return num;
	}

	internal static void vkyBfTATocEymbMSPwOYzaoKqMlw()
	{
		IKQgmTkgZqRtMdAomShuQunzQcuf = WelwrDOTwPCazDKocGEESdsdPSsf;
		YGpErtIukStlzEZsPtQAahClkoZ = UQPsfvzbJpnCGXpNBRVweNafETij;
		WYAATdNFNlXmCjvzNqxOXgOsOxav = szIfrTVtBwNRATSkGoMAsrtAnBVt;
		abPyzqNgHsJnjBrVpNMebJWvDcbF = kZlAzCsisMAmCZzDeUrdEOErgOmz;
	}

	internal static void gMKAbiFNvDLksecPIHDnHTrEOprOB(int userId, string userName, int groupId, string groupName)
	{
		IKQgmTkgZqRtMdAomShuQunzQcuf = (WelwrDOTwPCazDKocGEESdsdPSsf = userId);
		YGpErtIukStlzEZsPtQAahClkoZ = (UQPsfvzbJpnCGXpNBRVweNafETij = userName);
		WYAATdNFNlXmCjvzNqxOXgOsOxav = (szIfrTVtBwNRATSkGoMAsrtAnBVt = groupId);
		abPyzqNgHsJnjBrVpNMebJWvDcbF = (kZlAzCsisMAmCZzDeUrdEOErgOmz = groupName);
	}

	public void WriteHeader(byte[] outBuffer)
	{
		if (outBuffer == null)
		{
			throw new ArgumentNullException("outBuffer");
		}
		int num = 0;
		num = GetNameBytes(Name, outBuffer, 0, 100);
		num = GetOctalBytes(IUaiPypAyJprEbBfufyZPnRGIEHt, outBuffer, num, 8);
		num = GetOctalBytes(UserId, outBuffer, num, 8);
		num = GetOctalBytes(GroupId, outBuffer, num, 8);
		num = GetOctalBytes(Size, outBuffer, num, 12);
		num = GetOctalBytes(vdvNwaujnyywGeaolmOEfeyWZpkd(ModTime), outBuffer, num, 12);
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
		qWMVVzMgrDxRAuZpXWMsbpXmuSTe = cnPJviXkWGgbUhXJUrdrWYSwSJuG(outBuffer);
		OuBeMkkXrJRGgemanrLcandbiYSLB(qWMVVzMgrDxRAuZpXWMsbpXmuSTe, outBuffer, offset, 8);
		gbhzyzoeSBNJutviZkEKunxbHdqb = true;
	}
}
