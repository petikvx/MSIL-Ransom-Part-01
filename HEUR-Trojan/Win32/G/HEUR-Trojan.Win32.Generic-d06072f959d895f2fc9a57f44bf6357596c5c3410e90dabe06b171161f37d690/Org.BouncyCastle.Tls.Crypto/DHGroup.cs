using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public class DHGroup
{
	private readonly BigInteger g;

	private readonly BigInteger p;

	private readonly BigInteger q;

	private readonly int l;

	public virtual BigInteger G => g;

	public virtual int L => l;

	public virtual BigInteger P => p;

	public virtual BigInteger Q => q;

	public DHGroup(BigInteger p, BigInteger q, BigInteger g, int l)
	{
		this.p = p;
		this.g = g;
		this.q = q;
		this.l = l;
	}
}
