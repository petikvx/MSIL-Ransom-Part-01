using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class ServerSrpParams
{
	private BigInteger m_N;

	private BigInteger m_g;

	private BigInteger m_B;

	private byte[] m_s;

	public BigInteger B => m_B;

	public BigInteger G => m_g;

	public BigInteger N => m_N;

	public byte[] S => m_s;

	public ServerSrpParams(BigInteger N, BigInteger g, byte[] s, BigInteger B)
	{
		m_N = N;
		m_g = g;
		m_s = Arrays.Clone(s);
		m_B = B;
	}

	public void Encode(Stream output)
	{
		TlsSrpUtilities.WriteSrpParameter(m_N, output);
		TlsSrpUtilities.WriteSrpParameter(m_g, output);
		TlsUtilities.WriteOpaque8(m_s, output);
		TlsSrpUtilities.WriteSrpParameter(m_B, output);
	}

	public static ServerSrpParams Parse(Stream input)
	{
		BigInteger n = TlsSrpUtilities.ReadSrpParameter(input);
		BigInteger g = TlsSrpUtilities.ReadSrpParameter(input);
		byte[] s = TlsUtilities.ReadOpaque8(input, 1);
		BigInteger b = TlsSrpUtilities.ReadSrpParameter(input);
		return new ServerSrpParams(n, g, s, b);
	}
}
