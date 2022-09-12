using System.Security.Cryptography;
using Renci.SshNet.Abstractions;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellmanGroupSha512 : KeyExchangeDiffieHellmanGroupShaBase
{
	protected override int HashSize => 512;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA512 sHA = CryptoAbstraction.CreateSHA512();
		return sHA.ComputeHash(hashData);
	}
}
