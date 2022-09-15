using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public class Srp6Group
{
	private readonly BigInteger n;

	private readonly BigInteger g;

	public virtual BigInteger G => g;

	public virtual BigInteger N => n;

	public Srp6Group(BigInteger n, BigInteger g)
	{
		this.n = n;
		this.g = g;
	}
}
