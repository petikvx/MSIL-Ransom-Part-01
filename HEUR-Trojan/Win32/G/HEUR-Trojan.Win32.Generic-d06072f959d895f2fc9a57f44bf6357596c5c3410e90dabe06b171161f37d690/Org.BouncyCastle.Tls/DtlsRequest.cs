namespace Org.BouncyCastle.Tls;

public sealed class DtlsRequest
{
	private readonly long m_recordSeq;

	private readonly byte[] m_message;

	private readonly ClientHello m_clientHello;

	internal ClientHello ClientHello => m_clientHello;

	internal byte[] Message => m_message;

	internal int MessageSeq => TlsUtilities.ReadUint16(m_message, 4);

	internal long RecordSeq => m_recordSeq;

	internal DtlsRequest(long recordSeq, byte[] message, ClientHello clientHello)
	{
		m_recordSeq = recordSeq;
		m_message = message;
		m_clientHello = clientHello;
	}
}
