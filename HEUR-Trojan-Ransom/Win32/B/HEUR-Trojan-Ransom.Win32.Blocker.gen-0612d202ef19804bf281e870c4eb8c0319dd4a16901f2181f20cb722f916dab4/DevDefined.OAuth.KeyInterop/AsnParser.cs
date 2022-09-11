using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DevDefined.OAuth.KeyInterop;

internal class AsnParser
{
	private readonly int initialCount;

	private readonly List<byte> octets;

	public AsnParser(byte[] values)
	{
		octets = new List<byte>(values.Length);
		octets.AddRange(values);
		initialCount = octets.Count;
	}

	public int CurrentPosition()
	{
		return initialCount - octets.Count;
	}

	public int RemainingBytes()
	{
		return octets.Count;
	}

	private int GetLength()
	{
		int num = 0;
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (nextOctet == (nextOctet & 0x7F))
			{
				return nextOctet;
			}
			int num2 = nextOctet & 0x7F;
			if (num2 > 4)
			{
				StringBuilder stringBuilder = new StringBuilder("Invalid Length Encoding. ");
				stringBuilder.AppendFormat("Length uses {0} octets", num2.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			while (num2-- != 0)
			{
				num <<= 8;
				num |= GetNextOctet();
			}
			return num;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public byte[] Next()
	{
		int position = CurrentPosition();
		try
		{
			GetNextOctet();
			int length = GetLength();
			if (length > RemainingBytes())
			{
				StringBuilder stringBuilder = new StringBuilder("Incorrect Size. ");
				stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", length.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			return GetOctets(length);
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public byte GetNextOctet()
	{
		int position = CurrentPosition();
		if (RemainingBytes() == 0)
		{
			StringBuilder stringBuilder = new StringBuilder("Incorrect Size. ");
			stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", 1.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder.ToString(), position);
		}
		return GetOctets(1)[0];
	}

	public byte[] GetOctets(int octetCount)
	{
		int position = CurrentPosition();
		if (octetCount > RemainingBytes())
		{
			StringBuilder stringBuilder = new StringBuilder("Incorrect Size. ");
			stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", octetCount.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder.ToString(), position);
		}
		byte[] array = new byte[octetCount];
		try
		{
			octets.CopyTo(0, array, 0, octetCount);
			octets.RemoveRange(0, octetCount);
			return array;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public bool IsNextNull()
	{
		return 5 == octets[0];
	}

	public int NextNull()
	{
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (5 != nextOctet)
			{
				StringBuilder stringBuilder = new StringBuilder("Expected Null. ");
				stringBuilder.AppendFormat("Specified Identifier: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			nextOctet = GetNextOctet();
			if (nextOctet != 0)
			{
				StringBuilder stringBuilder2 = new StringBuilder("Null has non-zero size. ");
				stringBuilder2.AppendFormat("Size: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder2.ToString(), position);
			}
			return 0;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public bool IsNextSequence()
	{
		return 48 == octets[0];
	}

	public int NextSequence()
	{
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (48 != nextOctet)
			{
				StringBuilder stringBuilder = new StringBuilder("Expected Sequence. ");
				stringBuilder.AppendFormat("Specified Identifier: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			int length = GetLength();
			if (length > RemainingBytes())
			{
				StringBuilder stringBuilder2 = new StringBuilder("Incorrect Sequence Size. ");
				stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", length.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder2.ToString(), position);
			}
			return length;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public bool IsNextOctetString()
	{
		return 4 == octets[0];
	}

	public int NextOctetString()
	{
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (4 != nextOctet)
			{
				StringBuilder stringBuilder = new StringBuilder("Expected Octet String. ");
				stringBuilder.AppendFormat("Specified Identifier: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			int length = GetLength();
			if (length > RemainingBytes())
			{
				StringBuilder stringBuilder2 = new StringBuilder("Incorrect Octet String Size. ");
				stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", length.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder2.ToString(), position);
			}
			return length;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public bool IsNextBitString()
	{
		return 3 == octets[0];
	}

	public int NextBitString()
	{
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (3 != nextOctet)
			{
				StringBuilder stringBuilder = new StringBuilder("Expected Bit String. ");
				stringBuilder.AppendFormat("Specified Identifier: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			int length = GetLength();
			nextOctet = octets[0];
			octets.RemoveAt(0);
			length--;
			if (nextOctet != 0)
			{
				throw new BerDecodeException("The first octet of BitString must be 0", position);
			}
			return length;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public bool IsNextInteger()
	{
		return 2 == octets[0];
	}

	public byte[] NextInteger()
	{
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (2 != nextOctet)
			{
				StringBuilder stringBuilder = new StringBuilder("Expected Integer. ");
				stringBuilder.AppendFormat("Specified Identifier: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			int length = GetLength();
			if (length > RemainingBytes())
			{
				StringBuilder stringBuilder2 = new StringBuilder("Incorrect Integer Size. ");
				stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", length.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder2.ToString(), position);
			}
			return GetOctets(length);
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}

	public byte[] NextOID()
	{
		int position = CurrentPosition();
		try
		{
			byte nextOctet = GetNextOctet();
			if (6 != nextOctet)
			{
				StringBuilder stringBuilder = new StringBuilder("Expected Object Identifier. ");
				stringBuilder.AppendFormat("Specified Identifier: {0}", nextOctet.ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder.ToString(), position);
			}
			int length = GetLength();
			if (length > RemainingBytes())
			{
				StringBuilder stringBuilder2 = new StringBuilder("Incorrect Object Identifier Size. ");
				stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", length.ToString(CultureInfo.InvariantCulture), RemainingBytes().ToString(CultureInfo.InvariantCulture));
				throw new BerDecodeException(stringBuilder2.ToString(), position);
			}
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = octets[0];
				octets.RemoveAt(0);
			}
			return array;
		}
		catch (ArgumentOutOfRangeException ex)
		{
			throw new BerDecodeException("Error Parsing Key", position, ex);
		}
	}
}
