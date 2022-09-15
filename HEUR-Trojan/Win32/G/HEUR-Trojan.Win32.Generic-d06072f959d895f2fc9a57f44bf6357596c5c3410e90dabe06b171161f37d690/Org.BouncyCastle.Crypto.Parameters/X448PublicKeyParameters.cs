using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters;

public sealed class X448PublicKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize = 56;

	private readonly byte[] data = new byte[KeySize];

	public X448PublicKeyParameters(byte[] buf)
		: this(Validate(buf), 0)
	{
	}

	public X448PublicKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
		Array.Copy(buf, off, data, 0, KeySize);
	}

	public X448PublicKeyParameters(Stream input)
		: base(privateKey: false)
	{
		if (KeySize != Streams.ReadFully(input, data))
		{
			throw new EndOfStreamException("EOF encountered in middle of X448 public key");
		}
	}

	public void Encode(byte[] buf, int off)
	{
		Array.Copy(data, 0, buf, off, KeySize);
	}

	public byte[] GetEncoded()
	{
		return Arrays.Clone(data);
	}

	private static byte[] Validate(byte[] buf)
	{
		if (buf.Length != KeySize)
		{
			int keySize = KeySize;
			throw new ArgumentException("must have length " + keySize, "buf");
		}
		return buf;
	}
}
