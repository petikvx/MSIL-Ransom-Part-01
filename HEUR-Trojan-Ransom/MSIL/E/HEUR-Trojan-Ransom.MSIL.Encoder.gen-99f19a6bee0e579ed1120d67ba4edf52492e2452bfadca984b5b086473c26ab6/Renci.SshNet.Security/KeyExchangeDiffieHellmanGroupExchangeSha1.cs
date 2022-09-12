namespace Renci.SshNet.Security;

internal class KeyExchangeDiffieHellmanGroupExchangeSha1 : KeyExchangeDiffieHellmanGroupExchangeShaBase
{
	public override string Name => "diffie-hellman-group-exchange-sha1";

	protected override int HashSize => 160;
}
