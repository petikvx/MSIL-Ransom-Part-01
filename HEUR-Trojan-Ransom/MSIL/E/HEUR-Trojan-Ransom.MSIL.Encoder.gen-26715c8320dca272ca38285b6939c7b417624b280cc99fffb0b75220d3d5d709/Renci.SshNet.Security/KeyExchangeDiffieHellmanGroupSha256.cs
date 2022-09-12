using System.Security.Cryptography;
using Renci.SshNet.Abstractions;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellmanGroupSha256 : KeyExchangeDiffieHellmanGroupShaBase
{
	protected override int HashSize => 256;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA256 sHA = CryptoAbstraction.CreateSHA256();
		return sHA.ComputeHash(hashData);
	}
}
