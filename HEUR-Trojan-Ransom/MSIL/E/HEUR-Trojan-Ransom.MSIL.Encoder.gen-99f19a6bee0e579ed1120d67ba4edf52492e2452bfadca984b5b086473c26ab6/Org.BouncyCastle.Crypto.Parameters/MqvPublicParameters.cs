namespace Org.BouncyCastle.Crypto.Parameters;

public class MqvPublicParameters : ICipherParameters
{
	private readonly ECPublicKeyParameters staticPublicKey;

	private readonly ECPublicKeyParameters ephemeralPublicKey;

	public ECPublicKeyParameters StaticPublicKey => staticPublicKey;

	public ECPublicKeyParameters EphemeralPublicKey => ephemeralPublicKey;

	public MqvPublicParameters(ECPublicKeyParameters staticPublicKey, ECPublicKeyParameters ephemeralPublicKey)
	{
		this.staticPublicKey = staticPublicKey;
		this.ephemeralPublicKey = ephemeralPublicKey;
	}
}
