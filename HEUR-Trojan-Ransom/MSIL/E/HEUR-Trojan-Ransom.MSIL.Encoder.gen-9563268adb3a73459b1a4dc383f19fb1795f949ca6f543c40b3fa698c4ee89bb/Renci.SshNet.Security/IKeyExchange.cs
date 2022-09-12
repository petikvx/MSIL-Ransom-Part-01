using System;
using System.Security.Cryptography;
using Renci.SshNet.Common;
using Renci.SshNet.Compression;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security;

public interface IKeyExchange : IDisposable
{
	string Name { get; }

	byte[] ExchangeHash { get; }

	event EventHandler<HostKeyEventArgs> HostKeyReceived;

	void Start(Session session, KeyExchangeInitMessage message);

	void Finish();

	Cipher CreateClientCipher();

	Cipher CreateServerCipher();

	HashAlgorithm CreateServerHash();

	HashAlgorithm CreateClientHash();

	Compressor CreateCompressor();

	Compressor CreateDecompressor();
}
