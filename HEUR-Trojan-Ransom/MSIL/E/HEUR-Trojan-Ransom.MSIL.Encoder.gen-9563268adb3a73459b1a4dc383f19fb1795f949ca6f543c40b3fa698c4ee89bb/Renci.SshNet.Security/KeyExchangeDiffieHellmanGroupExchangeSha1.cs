using System.Security.Cryptography;
using Renci.SshNet.Abstractions;

namespace Renci.SshNet.Security;

internal class KeyExchangeDiffieHellmanGroupExchangeSha1 : KeyExchangeDiffieHellmanGroupExchangeShaBase
{
	public override string Name => "diffie-hellman-group-exchange-sha1";

	protected override int HashSize => 160;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA1 sHA = CryptoAbstraction.CreateSHA1();
		return sHA.ComputeHash(hashData, 0, hashData.Length);
	}
}
