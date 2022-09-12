using System.Security.Cryptography;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.Sec;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.X9;

namespace Renci.SshNet.Security;

internal class KeyExchangeECDH256 : KeyExchangeECDH
{
	public override string Name => "ecdh-sha2-nistp256";

	protected override X9ECParameters CurveParameter => SecNamedCurves.GetByName("P-256");

	protected override int HashSize => 256;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA256 sHA = CryptoAbstraction.CreateSHA256();
		return sHA.ComputeHash(hashData, 0, hashData.Length);
	}
}
