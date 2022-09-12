using Renci.SshNet.Security.Org.BouncyCastle.Crypto;

namespace Renci.SshNet.Security.Org.BouncyCastle.Security;

internal sealed class DigestUtilities
{
	private enum DigestAlgorithm
	{
		SHA_256
	}

	private DigestUtilities()
	{
	}

	public static byte[] DoFinal(IDigest digest)
	{
		byte[] array = new byte[digest.GetDigestSize()];
		digest.DoFinal(array, 0);
		return array;
	}

	public static byte[] DoFinal(IDigest digest, byte[] input)
	{
		digest.BlockUpdate(input, 0, input.Length);
		return DoFinal(digest);
	}
}
