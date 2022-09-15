using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class ProtocolVersion
{
	public static readonly ProtocolVersion SSLv3 = new ProtocolVersion(768, "SSL 3.0");

	public static readonly ProtocolVersion TLSv10 = new ProtocolVersion(769, "TLS 1.0");

	public static readonly ProtocolVersion TLSv11 = new ProtocolVersion(770, "TLS 1.1");

	public static readonly ProtocolVersion TLSv12 = new ProtocolVersion(771, "TLS 1.2");

	public static readonly ProtocolVersion TLSv13 = new ProtocolVersion(772, "TLS 1.3");

	public static readonly ProtocolVersion DTLSv10 = new ProtocolVersion(65279, "DTLS 1.0");

	public static readonly ProtocolVersion DTLSv12 = new ProtocolVersion(65277, "DTLS 1.2");

	internal static readonly ProtocolVersion CLIENT_EARLIEST_SUPPORTED_DTLS = DTLSv10;

	internal static readonly ProtocolVersion CLIENT_EARLIEST_SUPPORTED_TLS = SSLv3;

	internal static readonly ProtocolVersion CLIENT_LATEST_SUPPORTED_DTLS = DTLSv12;

	internal static readonly ProtocolVersion CLIENT_LATEST_SUPPORTED_TLS = TLSv13;

	internal static readonly ProtocolVersion SERVER_EARLIEST_SUPPORTED_DTLS = DTLSv10;

	internal static readonly ProtocolVersion SERVER_EARLIEST_SUPPORTED_TLS = SSLv3;

	internal static readonly ProtocolVersion SERVER_LATEST_SUPPORTED_DTLS = DTLSv12;

	internal static readonly ProtocolVersion SERVER_LATEST_SUPPORTED_TLS = TLSv13;

	private readonly int version;

	private readonly string name;

	public int FullVersion => version;

	public int MajorVersion => version >> 8;

	public int MinorVersion => version & 0xFF;

	public string Name => name;

	public bool IsDtls => MajorVersion == 254;

	public bool IsSsl => this == SSLv3;

	public bool IsTls => MajorVersion == 3;

	public static bool Contains(ProtocolVersion[] versions, ProtocolVersion version)
	{
		if (versions != null && version != null)
		{
			for (int i = 0; i < versions.Length; i++)
			{
				if (version.Equals(versions[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static ProtocolVersion GetEarliestDtls(ProtocolVersion[] versions)
	{
		ProtocolVersion protocolVersion = null;
		if (versions != null)
		{
			foreach (ProtocolVersion protocolVersion2 in versions)
			{
				if (protocolVersion2 != null && protocolVersion2.IsDtls && (protocolVersion == null || protocolVersion2.MinorVersion > protocolVersion.MinorVersion))
				{
					protocolVersion = protocolVersion2;
				}
			}
		}
		return protocolVersion;
	}

	public static ProtocolVersion GetEarliestTls(ProtocolVersion[] versions)
	{
		ProtocolVersion protocolVersion = null;
		if (versions != null)
		{
			foreach (ProtocolVersion protocolVersion2 in versions)
			{
				if (protocolVersion2 != null && protocolVersion2.IsTls && (protocolVersion == null || protocolVersion2.MinorVersion < protocolVersion.MinorVersion))
				{
					protocolVersion = protocolVersion2;
				}
			}
		}
		return protocolVersion;
	}

	public static ProtocolVersion GetLatestDtls(ProtocolVersion[] versions)
	{
		ProtocolVersion protocolVersion = null;
		if (versions != null)
		{
			foreach (ProtocolVersion protocolVersion2 in versions)
			{
				if (protocolVersion2 != null && protocolVersion2.IsDtls && (protocolVersion == null || protocolVersion2.MinorVersion < protocolVersion.MinorVersion))
				{
					protocolVersion = protocolVersion2;
				}
			}
		}
		return protocolVersion;
	}

	public static ProtocolVersion GetLatestTls(ProtocolVersion[] versions)
	{
		ProtocolVersion protocolVersion = null;
		if (versions != null)
		{
			foreach (ProtocolVersion protocolVersion2 in versions)
			{
				if (protocolVersion2 != null && protocolVersion2.IsTls && (protocolVersion == null || protocolVersion2.MinorVersion > protocolVersion.MinorVersion))
				{
					protocolVersion = protocolVersion2;
				}
			}
		}
		return protocolVersion;
	}

	internal static bool IsSupportedDtlsVersionClient(ProtocolVersion version)
	{
		if (version != null && version.IsEqualOrLaterVersionOf(CLIENT_EARLIEST_SUPPORTED_DTLS))
		{
			return version.IsEqualOrEarlierVersionOf(CLIENT_LATEST_SUPPORTED_DTLS);
		}
		return false;
	}

	internal static bool IsSupportedDtlsVersionServer(ProtocolVersion version)
	{
		if (version != null && version.IsEqualOrLaterVersionOf(SERVER_EARLIEST_SUPPORTED_DTLS))
		{
			return version.IsEqualOrEarlierVersionOf(SERVER_LATEST_SUPPORTED_DTLS);
		}
		return false;
	}

	internal static bool IsSupportedTlsVersionClient(ProtocolVersion version)
	{
		if (version == null)
		{
			return false;
		}
		int fullVersion = version.FullVersion;
		if (fullVersion >= CLIENT_EARLIEST_SUPPORTED_TLS.FullVersion)
		{
			return fullVersion <= CLIENT_LATEST_SUPPORTED_TLS.FullVersion;
		}
		return false;
	}

	internal static bool IsSupportedTlsVersionServer(ProtocolVersion version)
	{
		if (version == null)
		{
			return false;
		}
		int fullVersion = version.FullVersion;
		if (fullVersion >= SERVER_EARLIEST_SUPPORTED_TLS.FullVersion)
		{
			return fullVersion <= SERVER_LATEST_SUPPORTED_TLS.FullVersion;
		}
		return false;
	}

	private ProtocolVersion(int v, string name)
	{
		version = v & 0xFFFF;
		this.name = name;
	}

	public ProtocolVersion[] DownTo(ProtocolVersion min)
	{
		if (!IsEqualOrLaterVersionOf(min))
		{
			throw new ArgumentException("must be an equal or earlier version of this one", "min");
		}
		IList list = Platform.CreateArrayList();
		list.Add(this);
		ProtocolVersion protocolVersion = this;
		while (!protocolVersion.Equals(min))
		{
			protocolVersion = protocolVersion.GetPreviousVersion();
			list.Add(protocolVersion);
		}
		ProtocolVersion[] array = new ProtocolVersion[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = (ProtocolVersion)list[i];
		}
		return array;
	}

	public ProtocolVersion GetEquivalentTlsVersion()
	{
		return MajorVersion switch
		{
			254 => MinorVersion switch
			{
				255 => TLSv11, 
				253 => TLSv12, 
				_ => null, 
			}, 
			3 => this, 
			_ => null, 
		};
	}

	public ProtocolVersion GetNextVersion()
	{
		int majorVersion = MajorVersion;
		int minorVersion = MinorVersion;
		switch (majorVersion)
		{
		default:
			return null;
		case 254:
			return minorVersion switch
			{
				255 => DTLSv12, 
				0 => null, 
				_ => Get(majorVersion, minorVersion - 1), 
			};
		case 3:
			if (minorVersion == 255)
			{
				return null;
			}
			return Get(majorVersion, minorVersion + 1);
		}
	}

	public ProtocolVersion GetPreviousVersion()
	{
		int majorVersion = MajorVersion;
		int minorVersion = MinorVersion;
		switch (majorVersion)
		{
		default:
			return null;
		case 254:
			return minorVersion switch
			{
				255 => null, 
				253 => DTLSv10, 
				_ => Get(majorVersion, minorVersion + 1), 
			};
		case 3:
			if (minorVersion == 0)
			{
				return null;
			}
			return Get(majorVersion, minorVersion - 1);
		}
	}

	public bool IsEarlierVersionOf(ProtocolVersion version)
	{
		if (version != null && MajorVersion == version.MajorVersion)
		{
			int num = MinorVersion - version.MinorVersion;
			if (!IsDtls)
			{
				return num < 0;
			}
			return num > 0;
		}
		return false;
	}

	public bool IsEqualOrEarlierVersionOf(ProtocolVersion version)
	{
		if (version != null && MajorVersion == version.MajorVersion)
		{
			int num = MinorVersion - version.MinorVersion;
			if (!IsDtls)
			{
				return num <= 0;
			}
			return num >= 0;
		}
		return false;
	}

	public bool IsEqualOrLaterVersionOf(ProtocolVersion version)
	{
		if (version != null && MajorVersion == version.MajorVersion)
		{
			int num = MinorVersion - version.MinorVersion;
			if (!IsDtls)
			{
				return num >= 0;
			}
			return num <= 0;
		}
		return false;
	}

	public bool IsLaterVersionOf(ProtocolVersion version)
	{
		if (version != null && MajorVersion == version.MajorVersion)
		{
			int num = MinorVersion - version.MinorVersion;
			if (!IsDtls)
			{
				return num > 0;
			}
			return num < 0;
		}
		return false;
	}

	public override bool Equals(object other)
	{
		if (this != other)
		{
			if (other is ProtocolVersion)
			{
				return Equals((ProtocolVersion)other);
			}
			return false;
		}
		return true;
	}

	public bool Equals(ProtocolVersion other)
	{
		if (other != null)
		{
			return version == other.version;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return version;
	}

	public static ProtocolVersion Get(int major, int minor)
	{
		return major switch
		{
			254 => minor switch
			{
				253 => DTLSv12, 
				254 => throw new ArgumentException("{0xFE, 0xFE} is a reserved protocol version"), 
				255 => DTLSv10, 
				_ => GetUnknownVersion(major, minor, "DTLS"), 
			}, 
			3 => minor switch
			{
				0 => SSLv3, 
				1 => TLSv10, 
				2 => TLSv11, 
				3 => TLSv12, 
				4 => TLSv13, 
				_ => GetUnknownVersion(major, minor, "TLS"), 
			}, 
			_ => GetUnknownVersion(major, minor, "UNKNOWN"), 
		};
	}

	public ProtocolVersion[] Only()
	{
		return new ProtocolVersion[1] { this };
	}

	public override string ToString()
	{
		return name;
	}

	private static void CheckUint8(int versionOctet)
	{
		if (!TlsUtilities.IsValidUint8(versionOctet))
		{
			throw new ArgumentException("not a valid octet", "versionOctet");
		}
	}

	private static ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
	{
		CheckUint8(major);
		CheckUint8(minor);
		int num = (major << 8) | minor;
		string text = Platform.ToUpperInvariant(Convert.ToString(0x10000 | num, 16).Substring(1));
		return new ProtocolVersion(num, prefix + " 0x" + text);
	}
}
