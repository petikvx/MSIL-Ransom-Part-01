using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class ServerHello
{
	private static readonly byte[] HelloRetryRequestMagic = new byte[32]
	{
		207, 33, 173, 116, 229, 154, 97, 17, 190, 29,
		140, 2, 30, 101, 184, 145, 194, 162, 17, 22,
		122, 187, 140, 94, 7, 158, 9, 226, 200, 168,
		51, 156
	};

	private readonly ProtocolVersion m_version;

	private readonly byte[] m_random;

	private readonly byte[] m_sessionID;

	private readonly int m_cipherSuite;

	private readonly IDictionary m_extensions;

	public int CipherSuite => m_cipherSuite;

	public IDictionary Extensions => m_extensions;

	public byte[] Random => m_random;

	public byte[] SessionID => m_sessionID;

	public ProtocolVersion Version => m_version;

	public ServerHello(byte[] sessionID, int cipherSuite, IDictionary extensions)
		: this(ProtocolVersion.TLSv12, Arrays.Clone(HelloRetryRequestMagic), sessionID, cipherSuite, extensions)
	{
	}

	public ServerHello(ProtocolVersion version, byte[] random, byte[] sessionID, int cipherSuite, IDictionary extensions)
	{
		m_version = version;
		m_random = random;
		m_sessionID = sessionID;
		m_cipherSuite = cipherSuite;
		m_extensions = extensions;
	}

	public bool IsHelloRetryRequest()
	{
		return Arrays.AreEqual(HelloRetryRequestMagic, m_random);
	}

	public void Encode(TlsContext context, Stream output)
	{
		TlsUtilities.WriteVersion(m_version, output);
		output.Write(m_random, 0, m_random.Length);
		TlsUtilities.WriteOpaque8(m_sessionID, output);
		TlsUtilities.WriteUint16(m_cipherSuite, output);
		TlsUtilities.WriteUint8((short)0, output);
		TlsProtocol.WriteExtensions(output, m_extensions);
	}

	public static ServerHello Parse(MemoryStream input)
	{
		ProtocolVersion version = TlsUtilities.ReadVersion(input);
		byte[] random = TlsUtilities.ReadFully(32, input);
		byte[] sessionID = TlsUtilities.ReadOpaque8(input, 0, 32);
		int cipherSuite = TlsUtilities.ReadUint16(input);
		if (TlsUtilities.ReadUint8(input) != 0)
		{
			throw new TlsFatalAlert(47);
		}
		IDictionary extensions = TlsProtocol.ReadExtensions(input);
		return new ServerHello(version, random, sessionID, cipherSuite, extensions);
	}
}
