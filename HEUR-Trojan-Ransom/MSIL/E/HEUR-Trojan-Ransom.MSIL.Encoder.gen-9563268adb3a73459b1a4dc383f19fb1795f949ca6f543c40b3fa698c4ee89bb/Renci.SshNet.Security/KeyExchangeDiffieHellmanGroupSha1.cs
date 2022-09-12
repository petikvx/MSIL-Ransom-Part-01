using System.Security.Cryptography;
using Renci.SshNet.Abstractions;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellmanGroupSha1 : KeyExchangeDiffieHellmanGroupShaBase
{
	protected override int HashSize => 160;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA1 sHA = CryptoAbstraction.CreateSHA1();
		return sHA.ComputeHash(hashData, 0, hashData.Length);
	}
}
