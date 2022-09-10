using System;
using System.Security.Cryptography;

namespace WY9_Tray.xous.Security.Cryptography;

public class CRC32 : HashAlgorithm
{
	private const int _DefaultPolynomial = -306674912;

	private int[] _Table;

	private int _CRC32;

	private int _Polynomial;

	public CRC32()
	{
		_CRC32 = -1;
		HashSizeValue = 32;
		_Polynomial = -306674912;
		Initialize();
	}

	public CRC32(int Polynomial)
	{
		_CRC32 = -1;
		_Polynomial = Polynomial;
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		int num = checked(cbSize - 1);
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			int num4 = num;
			if (num3 <= num4)
			{
				int num5 = (_CRC32 & 0xFF) ^ array[num2];
				_CRC32 = ((_CRC32 & -256) / 256) & 0xFFFFFF;
				_CRC32 ^= _Table[num5];
				num2 = checked(num2 + 1);
				continue;
			}
			break;
		}
	}

	protected override byte[] HashFinal()
	{
		return BitConverter.GetBytes(~_CRC32);
	}

	public override void Initialize()
	{
		_CRC32 = -1;
		_Table = BuildTable(_Polynomial);
	}

	private static int[] BuildTable(int Polynomial)
	{
		int[] array = new int[256];
		int num = 0;
		do
		{
			int num2 = num;
			int num3 = 0;
			do
			{
				if ((num2 & 1) != 1)
				{
					num2 = Convert.ToInt32(((num2 & -2) / 2L) & 0x7FFFFFFFL);
				}
				else
				{
					num2 = Convert.ToInt32(((num2 & -2) / 2L) & 0x7FFFFFFFL);
					num2 ^= Polynomial;
				}
				num3 = checked(num3 + 1);
			}
			while (num3 <= 7);
			array[num] = num2;
			num = checked(num + 1);
		}
		while (num <= 255);
		return array;
	}
}
