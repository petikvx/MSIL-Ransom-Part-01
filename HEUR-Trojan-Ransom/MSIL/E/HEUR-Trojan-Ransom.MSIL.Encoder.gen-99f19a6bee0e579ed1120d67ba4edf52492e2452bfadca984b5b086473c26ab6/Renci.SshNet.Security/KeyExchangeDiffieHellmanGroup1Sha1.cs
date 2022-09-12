using Renci.SshNet.Common;

namespace Renci.SshNet.Security;

internal class KeyExchangeDiffieHellmanGroup1Sha1 : KeyExchangeDiffieHellmanGroupSha1
{
	private static readonly byte[] SecondOkleyGroupReversed = new byte[129]
	{
		255, 255, 255, 255, 255, 255, 255, 255, 129, 83,
		230, 236, 81, 102, 40, 73, 230, 31, 75, 124,
		17, 36, 159, 174, 165, 159, 137, 90, 251, 107,
		56, 238, 237, 183, 6, 244, 182, 92, 255, 11,
		107, 237, 55, 166, 233, 66, 76, 244, 198, 126,
		94, 98, 118, 181, 133, 228, 69, 194, 81, 109,
		109, 53, 225, 79, 55, 20, 95, 242, 109, 10,
		43, 48, 27, 67, 58, 205, 179, 25, 149, 239,
		221, 4, 52, 142, 121, 8, 74, 81, 34, 155,
		19, 59, 166, 190, 11, 2, 116, 204, 103, 138,
		8, 78, 2, 41, 209, 28, 220, 128, 139, 98,
		198, 196, 52, 194, 104, 33, 162, 218, 15, 201,
		255, 255, 255, 255, 255, 255, 255, 255, 0
	};

	public override string Name => "diffie-hellman-group1-sha1";

	public override BigInteger GroupPrime => new BigInteger(SecondOkleyGroupReversed);
}
