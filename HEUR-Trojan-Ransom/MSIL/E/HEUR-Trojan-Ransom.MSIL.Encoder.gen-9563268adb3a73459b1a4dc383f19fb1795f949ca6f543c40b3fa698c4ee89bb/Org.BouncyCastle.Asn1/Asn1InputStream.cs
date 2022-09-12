using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1;

public class Asn1InputStream : FilterStream
{
	private readonly int limit;

	private readonly byte[][] tmpBuffers;

	internal static int FindLimit(Stream input)
	{
		if (input is LimitedInputStream)
		{
			return ((LimitedInputStream)input).GetRemaining();
		}
		if (input is MemoryStream)
		{
			MemoryStream memoryStream = (MemoryStream)input;
			return (int)(memoryStream.Length - memoryStream.Position);
		}
		return int.MaxValue;
	}

	public Asn1InputStream(Stream inputStream)
		: this(inputStream, FindLimit(inputStream))
	{
	}

	public Asn1InputStream(Stream inputStream, int limit)
		: base(inputStream)
	{
		this.limit = limit;
		tmpBuffers = new byte[16][];
	}

	public Asn1InputStream(byte[] input)
		: this(new MemoryStream(input, writable: false), input.Length)
	{
	}

	private Asn1Object BuildObject(int tag, int tagNo, int length)
	{
		bool flag = (tag & 0x20) != 0;
		DefiniteLengthInputStream definiteLengthInputStream = new DefiniteLengthInputStream(s, length);
		if (((uint)tag & 0x40u) != 0)
		{
			return new DerApplicationSpecific(flag, tagNo, definiteLengthInputStream.ToArray());
		}
		if (((uint)tag & 0x80u) != 0)
		{
			return new Asn1StreamParser(definiteLengthInputStream).ReadTaggedObject(flag, tagNo);
		}
		if (flag)
		{
			return tagNo switch
			{
				16 => CreateDerSequence(definiteLengthInputStream), 
				17 => CreateDerSet(definiteLengthInputStream), 
				8 => new DerExternal(BuildDerEncodableVector(definiteLengthInputStream)), 
				4 => new BerOctetString(BuildDerEncodableVector(definiteLengthInputStream)), 
				_ => throw new IOException("unknown tag " + tagNo + " encountered"), 
			};
		}
		return CreatePrimitiveDerObject(tagNo, definiteLengthInputStream, tmpBuffers);
	}

	internal Asn1EncodableVector BuildEncodableVector()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		Asn1Object asn1Object;
		while ((asn1Object = ReadObject()) != null)
		{
			asn1EncodableVector.Add(asn1Object);
		}
		return asn1EncodableVector;
	}

	internal virtual Asn1EncodableVector BuildDerEncodableVector(DefiniteLengthInputStream dIn)
	{
		return new Asn1InputStream(dIn).BuildEncodableVector();
	}

	internal virtual DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
	{
		return DerSequence.FromVector(BuildDerEncodableVector(dIn));
	}

	internal virtual DerSet CreateDerSet(DefiniteLengthInputStream dIn)
	{
		return DerSet.FromVector(BuildDerEncodableVector(dIn), needsSorting: false);
	}

	public Asn1Object ReadObject()
	{
		int num = ReadByte();
		if (num <= 0)
		{
			if (num == 0)
			{
				throw new IOException("unexpected end-of-contents marker");
			}
			return null;
		}
		int num2 = ReadTagNumber(s, num);
		bool flag = (num & 0x20) != 0;
		int num3 = ReadLength(s, limit);
		if (num3 < 0)
		{
			if (!flag)
			{
				throw new IOException("indefinite length primitive encoding encountered");
			}
			IndefiniteLengthInputStream inStream = new IndefiniteLengthInputStream(s, limit);
			Asn1StreamParser parser = new Asn1StreamParser(inStream, limit);
			if (((uint)num & 0x40u) != 0)
			{
				return new BerApplicationSpecificParser(num2, parser).ToAsn1Object();
			}
			if (((uint)num & 0x80u) != 0)
			{
				return new BerTaggedObjectParser(constructed: true, num2, parser).ToAsn1Object();
			}
			return num2 switch
			{
				16 => new BerSequenceParser(parser).ToAsn1Object(), 
				17 => new BerSetParser(parser).ToAsn1Object(), 
				8 => new DerExternalParser(parser).ToAsn1Object(), 
				4 => new BerOctetStringParser(parser).ToAsn1Object(), 
				_ => throw new IOException("unknown BER object encountered"), 
			};
		}
		try
		{
			return BuildObject(num, num2, num3);
		}
		catch (ArgumentException exception)
		{
			throw new Asn1Exception("corrupted stream detected", exception);
		}
	}

	internal static int ReadTagNumber(Stream s, int tag)
	{
		int num = tag & 0x1F;
		if (num == 31)
		{
			num = 0;
			int num2 = s.ReadByte();
			if ((num2 & 0x7F) == 0)
			{
				throw new IOException("Corrupted stream - invalid high tag number found");
			}
			while (num2 >= 0 && ((uint)num2 & 0x80u) != 0)
			{
				num |= num2 & 0x7F;
				num <<= 7;
				num2 = s.ReadByte();
			}
			if (num2 < 0)
			{
				throw new EndOfStreamException("EOF found inside tag value.");
			}
			num |= num2 & 0x7F;
		}
		return num;
	}

	internal static int ReadLength(Stream s, int limit)
	{
		int num = s.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("EOF found when length expected");
		}
		if (num == 128)
		{
			return -1;
		}
		if (num > 127)
		{
			int num2 = num & 0x7F;
			if (num2 > 4)
			{
				throw new IOException("DER length more than 4 bytes: " + num2);
			}
			num = 0;
			for (int i = 0; i < num2; i++)
			{
				int num3 = s.ReadByte();
				if (num3 >= 0)
				{
					num = (num << 8) + num3;
					continue;
				}
				throw new EndOfStreamException("EOF found reading length");
			}
			if (num < 0)
			{
				throw new IOException("Corrupted stream - negative length found");
			}
			if (num >= limit)
			{
				throw new IOException("Corrupted stream - out of bounds length found");
			}
		}
		return num;
	}

	internal static byte[] GetBuffer(DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		int remaining = defIn.GetRemaining();
		if (remaining >= tmpBuffers.Length)
		{
			return defIn.ToArray();
		}
		byte[] array = tmpBuffers[remaining];
		if (array == null)
		{
			array = (tmpBuffers[remaining] = new byte[remaining]);
		}
		defIn.ReadAllIntoByteArray(array);
		return array;
	}

	internal static Asn1Object CreatePrimitiveDerObject(int tagNo, DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		switch (tagNo)
		{
		default:
		{
			byte[] array = defIn.ToArray();
			return tagNo switch
			{
				2 => new DerInteger(array), 
				3 => DerBitString.FromAsn1Octets(array), 
				4 => new DerOctetString(array), 
				5 => DerNull.Instance, 
				12 => new DerUtf8String(array), 
				18 => new DerNumericString(array), 
				19 => new DerPrintableString(array), 
				20 => new DerT61String(array), 
				21 => new DerVideotexString(array), 
				22 => new DerIA5String(array), 
				23 => new DerUtcTime(array), 
				24 => new DerGeneralizedTime(array), 
				25 => new DerGraphicString(array), 
				26 => new DerVisibleString(array), 
				27 => new DerGeneralString(array), 
				28 => new DerUniversalString(array), 
				30 => new DerBmpString(array), 
				_ => throw new IOException("unknown tag " + tagNo + " encountered"), 
			};
		}
		case 10:
			return DerEnumerated.FromOctetString(GetBuffer(defIn, tmpBuffers));
		case 6:
			return DerObjectIdentifier.FromOctetString(GetBuffer(defIn, tmpBuffers));
		case 1:
			return DerBoolean.FromOctetString(GetBuffer(defIn, tmpBuffers));
		}
	}
}
