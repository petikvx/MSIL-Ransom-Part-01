using System.Security.Cryptography;
using Renci.SshNet.Abstractions;

namespace Renci.SshNet.Security;

internal class KeyExchangeDiffieHellmanGroupExchangeSha256 : KeyExchangeDiffieHellmanGroupExchangeShaBase
{
	public override string Name => "diffie-hellman-group-exchange-sha256";

	protected override int HashSize => 256;

	protected override byte[] Hash(byte[] hashBytes)
	{
		using SHA256 sHA = CryptoAbstraction.CreateSHA256();
		return sHA.ComputeHash(hashBytes);
	}
}
