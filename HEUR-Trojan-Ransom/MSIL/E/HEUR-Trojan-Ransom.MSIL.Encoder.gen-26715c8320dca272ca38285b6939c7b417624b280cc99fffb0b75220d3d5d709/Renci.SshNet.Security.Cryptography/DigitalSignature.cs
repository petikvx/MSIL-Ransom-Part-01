namespace Renci.SshNet.Security.Cryptography;

public abstract class DigitalSignature
{
	public abstract bool Verify(byte[] input, byte[] signature);

	public abstract byte[] Sign(byte[] input);
}
