using System;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class BigInt
{
	private const int m_maxbytes = 128;

	private const int m_base = 256;

	private byte[] m_elements;

	private int m_size;

	private static readonly char[] decValues = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

	internal int Size
	{
		get
		{
			return m_size;
		}
		set
		{
			m_size = value;
			if (value > 128)
			{
				m_size = 128;
			}
			if (value < 0)
			{
				m_size = 0;
			}
		}
	}

	internal BigInt()
	{
		m_elements = new byte[128];
	}

	internal BigInt(byte[] b)
	{
		m_elements = new byte[128];
		Array.Copy(b, m_elements, b.Length);
		m_size = b.Length;
	}

	internal BigInt(byte b)
	{
		m_elements = new byte[128];
		SetDigit(0, b);
	}

	internal byte GetDigit(int index)
	{
		if (index >= 0 && index < m_size)
		{
			return m_elements[index];
		}
		return 0;
	}

	internal void SetDigit(int index, byte digit)
	{
		if (index >= 0 && index < 128)
		{
			m_elements[index] = digit;
			if (index >= m_size && digit != 0)
			{
				m_size = index + 1;
			}
			if (index == m_size - 1 && digit == 0)
			{
				m_size--;
			}
		}
	}

	internal void SetDigit(int index, byte digit, ref int size)
	{
		if (index >= 0 && index < 128)
		{
			m_elements[index] = digit;
			if (index >= size && digit != 0)
			{
				size = index + 1;
			}
			if (index == size - 1 && digit == 0)
			{
				size--;
			}
		}
	}

	public static bool operator <(BigInt value1, BigInt value2)
	{
		if (value1 == null)
		{
			return true;
		}
		if (value2 == null)
		{
			return false;
		}
		int size = value1.Size;
		int size2 = value2.Size;
		if (size != size2)
		{
			return size < size2;
		}
		do
		{
			if (size-- <= 0)
			{
				return false;
			}
		}
		while (value1.m_elements[size] == value2.m_elements[size]);
		return value1.m_elements[size] < value2.m_elements[size];
	}

	public static bool operator >(BigInt value1, BigInt value2)
	{
		if (value1 == null)
		{
			return false;
		}
		if (value2 == null)
		{
			return true;
		}
		int size = value1.Size;
		int size2 = value2.Size;
		if (size != size2)
		{
			return size > size2;
		}
		do
		{
			if (size-- <= 0)
			{
				return false;
			}
		}
		while (value1.m_elements[size] == value2.m_elements[size]);
		return value1.m_elements[size] > value2.m_elements[size];
	}

	public static bool operator ==(BigInt value1, BigInt value2)
	{
		if ((object)value1 == null)
		{
			return (object)value2 == null;
		}
		if ((object)value2 == null)
		{
			return (object)value1 == null;
		}
		int size = value1.Size;
		int size2 = value2.Size;
		if (size != size2)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < size)
			{
				if (value1.m_elements[num] != value2.m_elements[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool operator !=(BigInt value1, BigInt value2)
	{
		return !(value1 == value2);
	}

	public override bool Equals(object obj)
	{
		BigInt bigInt = obj as BigInt;
		if (null != bigInt)
		{
			return bigInt == this;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = 0;
		for (int i = 0; i < m_size; i++)
		{
			num += GetDigit(i);
		}
		return num;
	}

	internal static void Add(BigInt a, byte b, ref BigInt c)
	{
		byte b2 = b;
		int num = 0;
		int size = a.Size;
		int size2 = 0;
		for (int i = 0; i < size; i++)
		{
			num = a.GetDigit(i) + b2;
			c.SetDigit(i, (byte)((uint)num & 0xFFu), ref size2);
			b2 = (byte)((uint)(num >> 8) & 0xFFu);
		}
		if (b2 != 0)
		{
			c.SetDigit(a.Size, b2, ref size2);
		}
		c.Size = size2;
	}

	internal static void Negate(ref BigInt a)
	{
		int size = 0;
		for (int i = 0; i < 128; i++)
		{
			a.SetDigit(i, (byte)((uint)(~a.GetDigit(i)) & 0xFFu), ref size);
		}
		for (int j = 0; j < 128; j++)
		{
			a.SetDigit(j, (byte)(a.GetDigit(j) + 1), ref size);
			if ((a.GetDigit(j) & 0xFFu) != 0)
			{
				break;
			}
			a.SetDigit(j, (byte)(a.GetDigit(j) & 0xFFu), ref size);
		}
		a.Size = size;
	}

	internal static void Subtract(BigInt a, BigInt b, ref BigInt c)
	{
		byte b2 = 0;
		int num = 0;
		if (a < b)
		{
			Subtract(b, a, ref c);
			Negate(ref c);
			return;
		}
		int num2 = 0;
		int size = a.Size;
		int size2 = 0;
		for (num2 = 0; num2 < size; num2++)
		{
			num = a.GetDigit(num2) - b.GetDigit(num2) - b2;
			b2 = 0;
			if (num < 0)
			{
				num += 256;
				b2 = 1;
			}
			c.SetDigit(num2, (byte)((uint)num & 0xFFu), ref size2);
		}
		c.Size = size2;
	}

	private void Multiply(int b)
	{
		if (b == 0)
		{
			Clear();
			return;
		}
		int num = 0;
		int num2 = 0;
		int size = Size;
		int size2 = 0;
		for (int i = 0; i < size; i++)
		{
			num2 = b * GetDigit(i) + num;
			num = num2 / 256;
			SetDigit(i, (byte)(num2 % 256), ref size2);
		}
		if (num != 0)
		{
			byte[] bytes = BitConverter.GetBytes(num);
			for (int j = 0; j < bytes.Length; j++)
			{
				SetDigit(size + j, bytes[j], ref size2);
			}
		}
		Size = size2;
	}

	private static void Multiply(BigInt a, int b, ref BigInt c)
	{
		if (b == 0)
		{
			c.Clear();
			return;
		}
		int num = 0;
		int num2 = 0;
		int size = a.Size;
		int size2 = 0;
		for (int i = 0; i < size; i++)
		{
			num2 = b * a.GetDigit(i) + num;
			num = num2 / 256;
			c.SetDigit(i, (byte)(num2 % 256), ref size2);
		}
		if (num != 0)
		{
			byte[] bytes = BitConverter.GetBytes(num);
			for (int j = 0; j < bytes.Length; j++)
			{
				c.SetDigit(size + j, bytes[j], ref size2);
			}
		}
		c.Size = size2;
	}

	private void Divide(int b)
	{
		int num = 0;
		int num2 = 0;
		int size = Size;
		int size2 = 0;
		while (size-- > 0)
		{
			num2 = 256 * num + GetDigit(size);
			num = num2 % b;
			SetDigit(size, (byte)(num2 / b), ref size2);
		}
		Size = size2;
	}

	internal static void Divide(BigInt numerator, BigInt denominator, ref BigInt quotient, ref BigInt remainder)
	{
		if (numerator < denominator)
		{
			quotient.Clear();
			remainder.CopyFrom(numerator);
			return;
		}
		if (numerator == denominator)
		{
			quotient.Clear();
			quotient.SetDigit(0, 1);
			remainder.Clear();
			return;
		}
		BigInt c = new BigInt();
		c.CopyFrom(numerator);
		BigInt bigInt = new BigInt();
		bigInt.CopyFrom(denominator);
		uint num = 0u;
		while (bigInt.Size < c.Size)
		{
			bigInt.Multiply(256);
			num++;
		}
		if (bigInt > c)
		{
			bigInt.Divide(256);
			num--;
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		BigInt c2 = new BigInt();
		quotient.Clear();
		for (int i = 0; i <= num; i++)
		{
			num2 = ((c.Size == bigInt.Size) ? c.GetDigit(c.Size - 1) : (256 * c.GetDigit(c.Size - 1) + c.GetDigit(c.Size - 2)));
			num3 = bigInt.GetDigit(bigInt.Size - 1);
			num4 = num2 / num3;
			if (num4 >= 256)
			{
				num4 = 255;
			}
			Multiply(bigInt, num4, ref c2);
			while (c2 > c)
			{
				num4--;
				Multiply(bigInt, num4, ref c2);
			}
			quotient.Multiply(256);
			Add(quotient, (byte)num4, ref quotient);
			Subtract(c, c2, ref c);
			bigInt.Divide(256);
		}
		remainder.CopyFrom(c);
	}

	internal void CopyFrom(BigInt a)
	{
		Array.Copy(a.m_elements, m_elements, 128);
		m_size = a.m_size;
	}

	internal bool IsZero()
	{
		int num = 0;
		while (true)
		{
			if (num < m_size)
			{
				if (m_elements[num] != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	internal byte[] ToByteArray()
	{
		byte[] array = new byte[Size];
		Array.Copy(m_elements, array, Size);
		return array;
	}

	internal void Clear()
	{
		m_size = 0;
	}

	internal void FromDecimal(string decNum)
	{
		BigInt c = new BigInt();
		BigInt c2 = new BigInt();
		int length = decNum.Length;
		for (int i = 0; i < length; i++)
		{
			if (decNum[i] <= '9' && decNum[i] >= '0')
			{
				Multiply(c, 10, ref c2);
				Add(c2, (byte)(decNum[i] - 48), ref c);
				continue;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new FormatException());
		}
		CopyFrom(c);
	}

	internal string ToDecimal()
	{
		BigInt denominator = new BigInt(10);
		BigInt bigInt = new BigInt();
		BigInt quotient = new BigInt();
		BigInt remainder = new BigInt();
		bigInt.CopyFrom(this);
		char[] array = new char[8 * m_size / 3];
		int length = 0;
		do
		{
			Divide(bigInt, denominator, ref quotient, ref remainder);
			array[length++] = decValues[remainder.m_elements[0]];
			bigInt.CopyFrom(quotient);
		}
		while (!quotient.IsZero());
		Array.Reverse((Array)array, 0, length);
		return new string(array, 0, length);
	}
}
