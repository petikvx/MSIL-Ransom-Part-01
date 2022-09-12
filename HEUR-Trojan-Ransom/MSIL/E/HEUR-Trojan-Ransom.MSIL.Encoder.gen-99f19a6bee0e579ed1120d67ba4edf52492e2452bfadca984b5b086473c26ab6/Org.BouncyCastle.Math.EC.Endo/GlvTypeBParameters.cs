namespace Org.BouncyCastle.Math.EC.Endo;

public class GlvTypeBParameters
{
	protected readonly BigInteger m_beta;

	protected readonly BigInteger m_lambda;

	protected readonly BigInteger[] m_v1;

	protected readonly BigInteger[] m_v2;

	protected readonly BigInteger m_g1;

	protected readonly BigInteger m_g2;

	protected readonly int m_bits;

	public virtual BigInteger Beta => m_beta;

	public virtual BigInteger Lambda => m_lambda;

	public virtual BigInteger[] V1 => m_v1;

	public virtual BigInteger[] V2 => m_v2;

	public virtual BigInteger G1 => m_g1;

	public virtual BigInteger G2 => m_g2;

	public virtual int Bits => m_bits;

	public GlvTypeBParameters(BigInteger beta, BigInteger lambda, BigInteger[] v1, BigInteger[] v2, BigInteger g1, BigInteger g2, int bits)
	{
		m_beta = beta;
		m_lambda = lambda;
		m_v1 = v1;
		m_v2 = v2;
		m_g1 = g1;
		m_g2 = g2;
		m_bits = bits;
	}
}
