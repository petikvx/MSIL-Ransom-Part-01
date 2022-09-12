using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class CRC32 : HashAlgorithm
{
	public static readonly uint DefaultPolynomial;

	private static readonly uint _allOnes;

	private static readonly CRC32 _defaultCRC;

	private static readonly Hashtable _crc32TablesCache;

	private readonly uint[] _crc32Table;

	private uint _crc;

	public CRC32()
		: this(DefaultPolynomial)
	{
	}

	public CRC32(uint polynomial)
	{
		HashSizeValue = 32;
		_crc32Table = (uint[])_crc32TablesCache[polynomial];
		if (_crc32Table == null)
		{
			_crc32Table = _buildCRC32Table(polynomial);
			_crc32TablesCache.Add(polynomial, _crc32Table);
		}
		Initialize();
	}

	static CRC32()
	{
		DefaultPolynomial = 3988292384u;
		_allOnes = uint.MaxValue;
		_crc32TablesCache = Hashtable.Synchronized(new Hashtable());
		_defaultCRC = new CRC32();
	}

	public override void Initialize()
	{
		_crc = _allOnes;
	}

	protected override void HashCore(byte[] buffer, int offset, int count)
	{
		for (int i = offset; i < count; i++)
		{
			ulong num = (_crc & 0xFFu) ^ buffer[i];
			_crc >>= 8;
			_crc ^= _crc32Table[num];
		}
	}

	protected override byte[] HashFinal()
	{
		byte[] array = new byte[4];
		ulong num = _crc ^ _allOnes;
		array[0] = (byte)(num & 0xFFuL);
		array[1] = (byte)((num >> 8) & 0xFFuL);
		array[2] = (byte)((num >> 16) & 0xFFuL);
		array[3] = (byte)((num >> 24) & 0xFFuL);
		return array;
	}

	public static int Compute(string asciiString)
	{
		_defaultCRC.Initialize();
		return ToInt32(_defaultCRC.ComputeHash(asciiString));
	}

	public static int Compute(Stream inputStream)
	{
		_defaultCRC.Initialize();
		return ToInt32(_defaultCRC.ComputeHash(inputStream));
	}

	public static int Compute(byte[] buffer)
	{
		_defaultCRC.Initialize();
		return ToInt32(_defaultCRC.ComputeHash(buffer));
	}

	public static int Compute(byte[] buffer, int offset, int count)
	{
		_defaultCRC.Initialize();
		return ToInt32(_defaultCRC.ComputeHash(buffer, offset, count));
	}

	public byte[] ComputeHash(string asciiString)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(asciiString);
		return ComputeHash(bytes);
	}

	public new byte[] ComputeHash(Stream inputStream)
	{
		byte[] array = new byte[4096];
		int cbSize;
		while ((cbSize = inputStream.Read(array, 0, 4096)) > 0)
		{
			HashCore(array, 0, cbSize);
		}
		return HashFinal();
	}

	public new byte[] ComputeHash(byte[] buffer)
	{
		return ComputeHash(buffer, 0, buffer.Length);
	}

	public new byte[] ComputeHash(byte[] buffer, int offset, int count)
	{
		HashCore(buffer, offset, count);
		return HashFinal();
	}

	private static uint[] _buildCRC32Table(uint polynomial)
	{
		uint[] array = new uint[256];
		for (int i = 0; i < 256; i++)
		{
			uint num = (uint)i;
			for (int num2 = 8; num2 > 0; num2--)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ polynomial));
			}
			array[i] = num;
		}
		return array;
	}

	private static int ToInt32(byte[] buffer)
	{
		return BitConverter.ToInt32(buffer, 0);
	}
}
