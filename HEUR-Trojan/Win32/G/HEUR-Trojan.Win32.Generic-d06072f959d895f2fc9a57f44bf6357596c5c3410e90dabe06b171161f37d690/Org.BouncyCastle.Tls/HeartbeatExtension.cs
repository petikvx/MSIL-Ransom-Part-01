using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class HeartbeatExtension
{
	private readonly short m_mode;

	public short Mode => m_mode;

	public HeartbeatExtension(short mode)
	{
		if (!HeartbeatMode.IsValid(mode))
		{
			throw new ArgumentException("not a valid HeartbeatMode value", "mode");
		}
		m_mode = mode;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_mode, output);
	}

	public static HeartbeatExtension Parse(Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		if (!HeartbeatMode.IsValid(num))
		{
			throw new TlsFatalAlert(47);
		}
		return new HeartbeatExtension(num);
	}
}
