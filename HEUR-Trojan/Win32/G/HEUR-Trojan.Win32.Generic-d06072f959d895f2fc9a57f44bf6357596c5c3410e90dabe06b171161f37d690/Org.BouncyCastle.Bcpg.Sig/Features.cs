namespace Org.BouncyCastle.Bcpg.Sig;

public class Features : SignatureSubpacket
{
	public static readonly byte FEATURE_MODIFICATION_DETECTION = 1;

	public static readonly byte FEATURE_AEAD_ENCRYPTED_DATA = 2;

	public static readonly byte FEATURE_VERSION_5_PUBLIC_KEY = 4;

	public bool SupportsModificationDetection => SupportsFeature(FEATURE_MODIFICATION_DETECTION);

	private static byte[] featureToByteArray(byte feature)
	{
		return new byte[1] { feature };
	}

	public Features(bool critical, bool isLongLength, byte[] data)
		: base(SignatureSubpacketTag.Features, critical, isLongLength, data)
	{
	}

	public Features(bool critical, byte features)
		: this(critical, isLongLength: false, featureToByteArray(features))
	{
	}

	public Features(bool critical, int features)
		: this(critical, isLongLength: false, featureToByteArray((byte)features))
	{
	}

	public bool SupportsFeature(byte feature)
	{
		return (data[0] & feature) != 0;
	}
}
