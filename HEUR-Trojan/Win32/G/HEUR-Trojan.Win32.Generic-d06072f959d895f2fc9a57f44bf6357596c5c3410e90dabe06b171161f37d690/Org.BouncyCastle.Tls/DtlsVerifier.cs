using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class DtlsVerifier
{
	private readonly TlsMac m_cookieMac;

	private readonly TlsMacSink m_cookieMacSink;

	private static TlsMac CreateCookieMac(TlsCrypto crypto)
	{
		TlsHmac tlsHmac = crypto.CreateHmac(3);
		byte[] array = new byte[tlsHmac.MacLength];
		crypto.SecureRandom.NextBytes(array);
		tlsHmac.SetKey(array, 0, array.Length);
		return tlsHmac;
	}

	public DtlsVerifier(TlsCrypto crypto)
	{
		m_cookieMac = CreateCookieMac(crypto);
		m_cookieMacSink = new TlsMacSink(m_cookieMac);
	}

	public virtual DtlsRequest VerifyRequest(byte[] clientID, byte[] data, int dataOff, int dataLen, DatagramSender sender)
	{
		lock (this)
		{
			bool flag = true;
			try
			{
				m_cookieMac.Update(clientID, 0, clientID.Length);
				DtlsRequest dtlsRequest = DtlsReliableHandshake.ReadClientRequest(data, dataOff, dataLen, m_cookieMacSink);
				if (dtlsRequest != null)
				{
					byte[] array = m_cookieMac.CalculateMac();
					flag = false;
					if (Arrays.ConstantTimeAreEqual(array, dtlsRequest.ClientHello.Cookie))
					{
						return dtlsRequest;
					}
					DtlsReliableHandshake.SendHelloVerifyRequest(sender, dtlsRequest.RecordSeq, array);
				}
			}
			catch (IOException)
			{
			}
			finally
			{
				if (flag)
				{
					m_cookieMac.Reset();
				}
			}
			return null;
		}
	}
}
