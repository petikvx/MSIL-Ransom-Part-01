namespace Org.BouncyCastle.Crypto.Parameters;

public class MqvPrivateParameters : ICipherParameters
{
	private readonly ECPrivateKeyParameters staticPrivateKey;

	private readonly ECPrivateKeyParameters ephemeralPrivateKey;

	private readonly ECPublicKeyParameters ephemeralPublicKey;

	public ECPrivateKeyParameters StaticPrivateKey => staticPrivateKey;

	public ECPrivateKeyParameters EphemeralPrivateKey => ephemeralPrivateKey;

	public ECPublicKeyParameters EphemeralPublicKey => ephemeralPublicKey;

	public MqvPrivateParameters(ECPrivateKeyParameters staticPrivateKey, ECPrivateKeyParameters ephemeralPrivateKey)
		: this(staticPrivateKey, ephemeralPrivateKey, null)
	{
	}

	public MqvPrivateParameters(ECPrivateKeyParameters staticPrivateKey, ECPrivateKeyParameters ephemeralPrivateKey, ECPublicKeyParameters ephemeralPublicKey)
	{
		this.staticPrivateKey = staticPrivateKey;
		this.ephemeralPrivateKey = ephemeralPrivateKey;
		this.ephemeralPublicKey = ephemeralPublicKey;
	}
}
