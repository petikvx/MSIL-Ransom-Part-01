namespace Renci.SshNet.Messages.Transport;

public enum DisconnectReason
{
	None,
	HostNotAllowedToConnect,
	ProtocolError,
	KeyExchangeFailed,
	Reserved,
	MacError,
	CompressionError,
	ServiceNotAvailable,
	ProtocolVersionNotSupported,
	HostKeyNotVerifiable,
	ConnectionLost,
	ByApplication,
	TooManyConnections,
	AuthenticationCanceledByUser,
	NoMoreAuthenticationMethodsAvailable,
	IllegalUserName
}
