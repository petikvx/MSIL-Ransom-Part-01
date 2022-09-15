using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1;

public class Asn1InputStream : FilterStream
{
	private readonly int limit;

	private readonly byte[][] tmpBuffers;

	internal virtual int Limit => limit;

	internal static int FindLimit(Stream input)
	{
		if (input is LimitedInputStream)
		{
			return ((LimitedInputStream)input).Limit;
		}
		if (input is Asn1InputStream)
		{
			return ((Asn1InputStream)input).Limit;
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
		DefiniteLengthInputStream definiteLengthInputStream = new DefiniteLengthInputStream(s, length, limit);
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
			switch (tagNo)
			{
			case 8:
				return new DerExternal(ReadVector(definiteLengthInputStream));
			case 4:
			{
				Asn1EncodableVector asn1EncodableVector = ReadVector(definiteLengthInputStream);
				Asn1OctetString[] array = new Asn1OctetString[asn1EncodableVector.Count];
				int num = 0;
				Asn1Encodable asn1Encodable;
				while (true)
				{
					if (num == array.Length)
					{
						return new BerOctetString(array);
					}
					asn1Encodable = asn1EncodableVector[num];
					if (!(asn1Encodable is Asn1OctetString))
					{
						break;
					}
					array[num] = (Asn1OctetString)asn1Encodable;
					num++;
				}
				throw new Asn1Exception("unknown object encountered in constructed OCTET STRING: " + Platform.GetTypeName(asn1Encodable));
			}
			default:
				throw new IOException("unknown tag " + tagNo + " encountered");
			case 17:
				return CreateDerSet(definiteLengthInputStream);
			case 16:
				return CreateDerSequence(definiteLengthInputStream);
			}
		}
		return CreatePrimitiveDerObject(tagNo, definiteLengthInputStream, tmpBuffers);
	}

	internal virtual Asn1EncodableVector ReadVector()
	{
		Asn1Object asn1Object = ReadObject();
		if (asn1Object == null)
		{
			return new Asn1EncodableVector(0);
		}
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		do
		{
			asn1EncodableVector.Add(asn1Object);
		}
		while ((asn1Object = ReadObject()) != null);
		return asn1EncodableVector;
	}

	internal virtual Asn1EncodableVector ReadVector(DefiniteLengthInputStream dIn)
	{
		if (dIn.Remaining < 1)
		{
			return new Asn1EncodableVector(0);
		}
		return new Asn1InputStream(dIn).ReadVector();
	}

	internal virtual DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
	{
		return DerSequence.FromVector(ReadVector(dIn));
	}

	internal virtual DerSet CreateDerSet(DefiniteLengthInputStream dIn)
	{
		return DerSet.FromVector(ReadVector(dIn), needsSorting: false);
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
		int num3 = ReadLength(s, limit, isParsing: false);
		if (num3 < 0)
		{
			if (!flag)
			{
				throw new IOException("indefinite-length primitive encoding encountered");
			}
			Asn1StreamParser parser = new Asn1StreamParser(new IndefiniteLengthInputStream(s, limit), limit);
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
				8 => new DerExternalParser(parser).ToAsn1Object(), 
				4 => new BerOctetStringParser(parser).ToAsn1Object(), 
				17 => new BerSetParser(parser).ToAsn1Object(), 
				16 => new BerSequenceParser(parser).ToAsn1Object(), 
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
				throw new IOException("corrupted stream - invalid high tag number found");
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

	internal static int ReadLength(Stream s, int limit, bool isParsing)
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
				throw new IOException("corrupted stream - negative length found");
			}
			if (num >= limit && !isParsing)
			{
				throw new IOException("corrupted stream - out of bounds length found: " + num + " >= " + limit);
			}
		}
		return num;
	}

	private static byte[] GetBuffer(DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		int remaining = defIn.Remaining;
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

	private static char[] GetBmpCharBuffer(DefiniteLengthInputStream defIn)
	{
		int num = defIn.Remaining;
		if (((uint)num & (true ? 1u : 0u)) != 0)
		{
			throw new IOException("malformed BMPString encoding encountered");
		}
		char[] array = new char[num / 2];
		int num2 = 0;
		byte[] array2 = new byte[8];
		while (true)
		{
			if (num >= 8)
			{
				if (Streams.ReadFully(defIn, array2, 0, 8) == 8)
				{
					array[num2] = (char)((uint)(array2[0] << 8) | (array2[1] & 0xFFu));
					array[num2 + 1] = (char)((uint)(array2[2] << 8) | (array2[3] & 0xFFu));
					array[num2 + 2] = (char)((uint)(array2[4] << 8) | (array2[5] & 0xFFu));
					array[num2 + 3] = (char)((uint)(array2[6] << 8) | (array2[7] & 0xFFu));
					num2 += 4;
					num -= 8;
					continue;
				}
				throw new EndOfStreamException("EOF encountered in middle of BMPString");
			}
			if (num > 0)
			{
				if (Streams.ReadFully(defIn, array2, 0, num) != num)
				{
					throw new EndOfStreamException("EOF encountered in middle of BMPString");
				}
				int num3 = 0;
				do
				{
					int num4 = array2[num3++] << 8;
					int num5 = array2[num3++] & 0xFF;
					array[num2++] = (char)(num4 | num5);
				}
				while (num3 < num);
			}
			if (defIn.Remaining == 0 && array.Length == num2)
			{
				break;
			}
			throw new InvalidOperationException();
		}
		return array;
	}

	internal static Asn1Object CreatePrimitiveDerObject(int tagNo, DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		switch (tagNo)
		{
		case 6:
			return DerObjectIdentifier.FromOctetString(GetBuffer(defIn, tmpBuffers));
		case 1:
			return DerBoolean.FromOctetString(GetBuffer(defIn, tmpBuffers));
		case 30:
			return new DerBmpString(GetBmpCharBuffer(defIn));
		default:
		{
			byte[] array = defIn.ToArray();
			switch (tagNo)
			{
			case 2:
				return new DerInteger(array, clone: false);
			case 3:
				return DerBitString.FromAsn1Octets(array);
			case 4:
				return new DerOctetString(array);
			case 5:
				if (array.Length != 0)
				{
					throw new InvalidOperationException("malformed NULL encoding encountered");
				}
				return DerNull.Instance;
			case 12:
				return new DerUtf8String(array);
			default:
				throw new IOException("unknown tag " + tagNo + " encountered");
			case 18:
				return new DerNumericString(array);
			case 19:
				return new DerPrintableString(array);
			case 20:
				return new DerT61String(array);
			case 21:
				return new DerVideotexString(array);
			case 22:
				return new DerIA5String(array);
			case 23:
				return new DerUtcTime(array);
			case 24:
				return new DerGeneralizedTime(array);
			case 25:
				return new DerGraphicString(array);
			case 26:
				return new DerVisibleString(array);
			case 27:
				return new DerGeneralString(array);
			case 28:
				return new DerUniversalString(array);
			}
		}
		case 10:
			return DerEnumerated.FromOctetString(GetBuffer(defIn, tmpBuffers));
		}
	}
}
