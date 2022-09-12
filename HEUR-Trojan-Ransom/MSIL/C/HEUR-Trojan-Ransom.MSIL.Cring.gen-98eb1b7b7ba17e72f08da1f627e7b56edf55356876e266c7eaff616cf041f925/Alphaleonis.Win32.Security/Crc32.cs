using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Alphaleonis.Win32.Security;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Crc")]
internal sealed class Crc32 : HashAlgorithm
{
	private const uint DefaultPolynomial = 3988292384u;

	private const uint DefaultSeed = uint.MaxValue;

	private uint m_hash;

	private static uint[] s_defaultTable;

	private readonly uint m_seed;

	private readonly uint[] m_table;

	public override int HashSize => 32;

	public Crc32()
		: this(3988292384u, uint.MaxValue)
	{
	}

	private Crc32(uint polynomial, uint seed)
	{
		m_table = InitializeTable(polynomial);
		m_seed = (m_hash = seed);
	}

	public override void Initialize()
	{
		m_hash = m_seed;
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		m_hash = CalculateHash(m_table, m_hash, array, ibStart, cbSize);
	}

	protected override byte[] HashFinal()
	{
		return HashValue = UInt32ToBigEndianBytes(~m_hash);
	}

	private static uint[] InitializeTable(uint polynomial)
	{
		if (polynomial == 3988292384u && s_defaultTable != null)
		{
			return s_defaultTable;
		}
		uint[] array = new uint[256];
		for (int i = 0; i < 256; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ polynomial));
			}
			array[i] = num;
		}
		if (polynomial == 3988292384u)
		{
			s_defaultTable = array;
		}
		return array;
	}

	private static uint CalculateHash(uint[] table, uint seed, IList<byte> buffer, int start, int size)
	{
		uint num = seed;
		for (int i = start; i < start + size; i++)
		{
			num = (num >> 8) ^ table[buffer[i] ^ (num & 0xFF)];
		}
		return num;
	}

	private static byte[] UInt32ToBigEndianBytes(uint uint32)
	{
		byte[] bytes = BitConverter.GetBytes(uint32);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)bytes);
		}
		return bytes;
	}
}
