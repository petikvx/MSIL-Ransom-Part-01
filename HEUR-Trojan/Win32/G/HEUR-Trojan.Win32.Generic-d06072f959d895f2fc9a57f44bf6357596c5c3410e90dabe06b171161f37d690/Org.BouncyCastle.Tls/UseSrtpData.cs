using System;

namespace Org.BouncyCastle.Tls;

public sealed class UseSrtpData
{
	private readonly int[] m_protectionProfiles;

	private readonly byte[] m_mki;

	public int[] ProtectionProfiles => m_protectionProfiles;

	public byte[] Mki => m_mki;

	public UseSrtpData(int[] protectionProfiles, byte[] mki)
	{
		if (!TlsUtilities.IsNullOrEmpty(protectionProfiles) && protectionProfiles.Length < 32768)
		{
			if (mki == null)
			{
				mki = TlsUtilities.EmptyBytes;
			}
			else if (mki.Length > 255)
			{
				throw new ArgumentException("cannot be longer than 255 bytes", "mki");
			}
			m_protectionProfiles = protectionProfiles;
			m_mki = mki;
			return;
		}
		throw new ArgumentException("must have length from 1 to (2^15 - 1)", "protectionProfiles");
	}
}
