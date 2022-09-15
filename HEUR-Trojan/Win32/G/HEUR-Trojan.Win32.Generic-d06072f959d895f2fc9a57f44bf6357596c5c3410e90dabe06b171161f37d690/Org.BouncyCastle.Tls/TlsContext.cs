using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsContext
{
	TlsCrypto Crypto { get; }

	TlsNonceGenerator NonceGenerator { get; }

	SecurityParameters SecurityParameters { get; }

	bool IsServer { get; }

	ProtocolVersion[] ClientSupportedVersions { get; }

	ProtocolVersion ClientVersion { get; }

	ProtocolVersion RsaPreMasterSecretVersion { get; }

	ProtocolVersion ServerVersion { get; }

	TlsSession ResumableSession { get; }

	TlsSession Session { get; }

	object UserObject { get; set; }

	byte[] ExportChannelBinding(int channelBinding);

	byte[] ExportEarlyKeyingMaterial(string asciiLabel, byte[] context_value, int length);

	byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length);
}
