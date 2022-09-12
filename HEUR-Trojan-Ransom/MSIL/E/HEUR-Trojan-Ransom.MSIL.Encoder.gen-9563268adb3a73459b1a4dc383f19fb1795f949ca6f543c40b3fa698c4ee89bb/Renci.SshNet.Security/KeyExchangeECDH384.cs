using System.Security.Cryptography;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.Sec;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.X9;

namespace Renci.SshNet.Security;

internal class KeyExchangeECDH384 : KeyExchangeECDH
{
	public override string Name => "ecdh-sha2-nistp384";

	protected override X9ECParameters CurveParameter => SecNamedCurves.GetByName("P-384");

	protected override int HashSize => 384;

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA384 sHA = CryptoAbstraction.CreateSHA384();
		return sHA.ComputeHash(hashData, 0, hashData.Length);
	}
}
