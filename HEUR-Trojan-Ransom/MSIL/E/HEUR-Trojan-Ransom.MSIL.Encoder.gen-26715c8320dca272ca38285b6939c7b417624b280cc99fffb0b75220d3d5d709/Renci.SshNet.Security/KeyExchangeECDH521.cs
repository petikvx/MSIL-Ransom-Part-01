using System.Security.Cryptography;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.Sec;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.X9;

namespace Renci.SshNet.Security;

internal class KeyExchangeECDH521 : KeyExchangeECDH
{
	public override string Name => "ecdh-sha2-nistp521";

	protected override X9ECParameters CurveParameter => SecNamedCurves.GetByName("P-521");

	protected override int HashSize => 512;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA512 sHA = CryptoAbstraction.CreateSHA512();
		return sHA.ComputeHash(hashData, 0, hashData.Length);
	}
}
