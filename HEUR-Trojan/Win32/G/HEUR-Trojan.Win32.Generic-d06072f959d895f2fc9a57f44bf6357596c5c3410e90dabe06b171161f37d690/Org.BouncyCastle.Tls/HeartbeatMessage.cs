using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class HeartbeatMessage
{
	private readonly short m_type;

	private readonly byte[] m_payload;

	private readonly byte[] m_padding;

	public int PaddingLength => m_padding.Length;

	public byte[] Payload => m_payload;

	public short Type => m_type;

	public static HeartbeatMessage Create(TlsContext context, short type, byte[] payload)
	{
		return Create(context, type, payload, 16);
	}

	public static HeartbeatMessage Create(TlsContext context, short type, byte[] payload, int paddingLength)
	{
		byte[] padding = context.NonceGenerator.GenerateNonce(paddingLength);
		return new HeartbeatMessage(type, payload, padding);
	}

	public HeartbeatMessage(short type, byte[] payload, byte[] padding)
	{
		if (!HeartbeatMessageType.IsValid(type))
		{
			throw new ArgumentException("not a valid HeartbeatMessageType value", "type");
		}
		if (payload != null && payload.Length < 65536)
		{
			if (padding == null || padding.Length < 16)
			{
				throw new ArgumentException("must have length >= 16", "padding");
			}
			m_type = type;
			m_payload = payload;
			m_padding = padding;
			return;
		}
		throw new ArgumentException("must have length < 2^16", "payload");
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_type, output);
		TlsUtilities.CheckUint16(m_payload.Length);
		TlsUtilities.WriteUint16(m_payload.Length, output);
		output.Write(m_payload, 0, m_payload.Length);
		output.Write(m_padding, 0, m_padding.Length);
	}

	public static HeartbeatMessage Parse(Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		if (!HeartbeatMessageType.IsValid(num))
		{
			throw new TlsFatalAlert(47);
		}
		int payloadLength = TlsUtilities.ReadUint16(input);
		byte[] payloadBuffer = Streams.ReadAll(input);
		byte[] payload = GetPayload(payloadBuffer, payloadLength);
		if (payload == null)
		{
			return null;
		}
		byte[] padding = GetPadding(payloadBuffer, payloadLength);
		return new HeartbeatMessage(num, payload, padding);
	}

	private static byte[] GetPayload(byte[] payloadBuffer, int payloadLength)
	{
		int num = payloadBuffer.Length - 16;
		if (payloadLength > num)
		{
			return null;
		}
		return Arrays.CopyOf(payloadBuffer, payloadLength);
	}

	private static byte[] GetPadding(byte[] payloadBuffer, int payloadLength)
	{
		return TlsUtilities.CopyOfRangeExact(payloadBuffer, payloadLength, payloadBuffer.Length);
	}
}
