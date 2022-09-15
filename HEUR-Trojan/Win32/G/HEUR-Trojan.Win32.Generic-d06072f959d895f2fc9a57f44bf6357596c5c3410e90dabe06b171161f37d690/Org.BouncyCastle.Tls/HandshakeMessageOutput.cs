using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

internal sealed class HandshakeMessageOutput : MemoryStream
{
	internal static int GetLength(int bodyLength)
	{
		return 4 + bodyLength;
	}

	internal static void Send(TlsProtocol protocol, short handshakeType, byte[] body)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(handshakeType, body.Length);
		handshakeMessageOutput.Write(body, 0, body.Length);
		handshakeMessageOutput.Send(protocol);
	}

	internal HandshakeMessageOutput(short handshakeType)
		: this(handshakeType, 60)
	{
	}

	internal HandshakeMessageOutput(short handshakeType, int bodyLength)
		: base(GetLength(bodyLength))
	{
		TlsUtilities.CheckUint8(handshakeType);
		TlsUtilities.WriteUint8(handshakeType, this);
		Seek(3L, SeekOrigin.Current);
	}

	internal void Send(TlsProtocol protocol)
	{
		int i = (int)Length - 4;
		TlsUtilities.CheckUint24(i);
		Seek(1L, SeekOrigin.Begin);
		TlsUtilities.WriteUint24(i, this);
		byte[] buffer = GetBuffer();
		int len = (int)Length;
		protocol.WriteHandshakeMessage(buffer, 0, len);
		Platform.Dispose(this);
	}

	internal void PrepareClientHello(TlsHandshakeHash handshakeHash, int bindersSize)
	{
		int i = (int)Length - 4 + bindersSize;
		TlsUtilities.CheckUint24(i);
		Seek(1L, SeekOrigin.Begin);
		TlsUtilities.WriteUint24(i, this);
		byte[] buffer = GetBuffer();
		int length = (int)Length;
		handshakeHash.Update(buffer, 0, length);
		Seek(0L, SeekOrigin.End);
	}

	internal void SendClientHello(TlsClientProtocol clientProtocol, TlsHandshakeHash handshakeHash, int bindersSize)
	{
		byte[] buffer = GetBuffer();
		int num = (int)Length;
		if (bindersSize > 0)
		{
			handshakeHash.Update(buffer, num - bindersSize, bindersSize);
		}
		clientProtocol.WriteHandshakeMessage(buffer, 0, num);
		Platform.Dispose(this);
	}
}
