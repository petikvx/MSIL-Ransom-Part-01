using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Alphaleonis.Win32.Security;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Crc")]
internal class Crc64 : HashAlgorithm
{
	private static ulong[] Table;

	private const ulong Iso3309Polynomial = 15564440312192434176uL;

	private const ulong DefaultSeed = 0uL;

	private readonly ulong[] m_table;

	private readonly ulong m_seed;

	private ulong m_hash;

	public override int HashSize => 64;

	public Crc64()
		: this(15564440312192434176uL, 0uL)
	{
	}

	private Crc64(ulong polynomial, ulong seed)
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
		m_hash = CalculateHash(m_hash, m_table, array, ibStart, cbSize);
	}

	protected override byte[] HashFinal()
	{
		return HashValue = UInt64ToBigEndianBytes(m_hash);
	}

	private static ulong CalculateHash(ulong seed, ulong[] table, IList<byte> buffer, int start, int size)
	{
		ulong num = seed;
		for (int i = start; i < start + size; i++)
		{
			num = (num >> 8) ^ table[(buffer[i] ^ num) & 0xFFL];
		}
		return num;
	}

	private static byte[] UInt64ToBigEndianBytes(ulong value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)bytes);
		}
		return bytes;
	}

	private static ulong[] InitializeTable(ulong polynomial)
	{
		if (polynomial == 15564440312192434176uL && Table != null)
		{
			return Table;
		}
		ulong[] array = CreateTable(polynomial);
		if (polynomial == 15564440312192434176uL)
		{
			Table = array;
		}
		return array;
	}

	private static ulong[] CreateTable(ulong polynomial)
	{
		ulong[] array = new ulong[256];
		for (int i = 0; i < 256; i++)
		{
			ulong num = (ulong)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1L) == 1L) ? ((num >> 1) ^ polynomial) : (num >> 1));
			}
			array[i] = num;
		}
		return array;
	}
}
