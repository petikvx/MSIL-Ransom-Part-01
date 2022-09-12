using System;
using System.Collections.Generic;
using System.Globalization;
using Renci.SshNet.Abstractions;

namespace Renci.SshNet.Common;

public struct BigInteger : IComparable, IFormattable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	private static readonly BigInteger ZeroSingleton = new BigInteger(0);

	private static readonly BigInteger OneSingleton = new BigInteger(1);

	private static readonly BigInteger MinusOneSingleton = new BigInteger(-1);

	private const ulong Base = 4294967296uL;

	private const int Bias = 1075;

	private const int DecimalSignMask = int.MinValue;

	private readonly uint[] _data;

	private readonly short _sign;

	public int BitLength
	{
		get
		{
			if (_sign == 0)
			{
				return 0;
			}
			int num = _data.Length - 1;
			while (_data[num] == 0)
			{
				num--;
			}
			int num2 = BitScanBackward(_data[num]) + 1;
			return num * 4 * 8 + num2 + ((_sign <= 0) ? 1 : 0);
		}
	}

	public bool IsEven
	{
		get
		{
			if (_sign != 0)
			{
				return (_data[0] & 1) == 0;
			}
			return true;
		}
	}

	public bool IsOne
	{
		get
		{
			if (_sign == 1 && _data.Length == 1)
			{
				return _data[0] == 1;
			}
			return false;
		}
	}

	public bool IsPowerOfTwo
	{
		get
		{
			bool flag = false;
			if (_sign != 1)
			{
				return false;
			}
			uint[] data = _data;
			int num = 0;
			while (true)
			{
				if (num < data.Length)
				{
					int num2 = PopulationCount(data[num]);
					if (num2 > 0)
					{
						if (num2 > 1 || flag)
						{
							break;
						}
						flag = true;
					}
					num++;
					continue;
				}
				return flag;
			}
			return false;
		}
	}

	public bool IsZero => _sign == 0;

	public int Sign => _sign;

	public static BigInteger MinusOne => MinusOneSingleton;

	public static BigInteger One => OneSingleton;

	public static BigInteger Zero => ZeroSingleton;

	public static BigInteger ModInverse(BigInteger bi, BigInteger modulus)
	{
		BigInteger bigInteger = modulus;
		BigInteger bigInteger2 = bi % modulus;
		BigInteger bigInteger3 = 0;
		BigInteger bigInteger4 = 1;
		while (!bigInteger2.IsZero)
		{
			if (!bigInteger2.IsOne)
			{
				bigInteger3 += bigInteger / bigInteger2 * bigInteger4;
				bigInteger %= bigInteger2;
				if (bigInteger.IsZero)
				{
					break;
				}
				if (!bigInteger.IsOne)
				{
					bigInteger4 += bigInteger2 / bigInteger * bigInteger3;
					bigInteger2 %= bigInteger;
					continue;
				}
				return modulus - bigInteger3;
			}
			return bigInteger4;
		}
		return 0;
	}

	public static BigInteger PositiveMod(BigInteger dividend, BigInteger divisor)
	{
		BigInteger bigInteger = dividend % divisor;
		if (bigInteger < 0L)
		{
			bigInteger += divisor;
		}
		return bigInteger;
	}

	public static BigInteger Random(int bitLength)
	{
		byte[] array = new byte[bitLength / 8 + ((bitLength % 8 > 0) ? 1 : 0)];
		CryptoAbstraction.GenerateRandom(array);
		array[^1] = (byte)(array[^1] & 0x7Fu);
		return new BigInteger(array);
	}

	private BigInteger(short sign, uint[] data)
	{
		_sign = sign;
		_data = data;
	}

	public BigInteger(int value)
	{
		if (value == 0)
		{
			_sign = 0;
			_data = null;
		}
		else if (value > 0)
		{
			_sign = 1;
			_data = new uint[1] { (uint)value };
		}
		else
		{
			_sign = -1;
			_data = new uint[1] { (uint)(-value) };
		}
	}

	[CLSCompliant(false)]
	public BigInteger(uint value)
	{
		if (value == 0)
		{
			_sign = 0;
			_data = null;
		}
		else
		{
			_sign = 1;
			_data = new uint[1] { value };
		}
	}

	public BigInteger(long value)
	{
		if (value == 0L)
		{
			_sign = 0;
			_data = null;
			return;
		}
		if (value > 0L)
		{
			_sign = 1;
			uint num = (uint)value;
			uint num2 = (uint)(value >> 32);
			_data = new uint[(num2 == 0) ? 1 : 2];
			_data[0] = num;
			if (num2 != 0)
			{
				_data[1] = num2;
			}
			return;
		}
		_sign = -1;
		value = -value;
		uint num3 = (uint)value;
		uint num4 = (uint)((ulong)value >> 32);
		_data = new uint[(num4 == 0) ? 1 : 2];
		_data[0] = num3;
		if (num4 != 0)
		{
			_data[1] = num4;
		}
	}

	[CLSCompliant(false)]
	public BigInteger(ulong value)
	{
		if (value == 0L)
		{
			_sign = 0;
			_data = null;
			return;
		}
		_sign = 1;
		uint num = (uint)value;
		uint num2 = (uint)(value >> 32);
		_data = new uint[(num2 == 0) ? 1 : 2];
		_data[0] = num;
		if (num2 != 0)
		{
			_data[1] = num2;
		}
	}

	private static bool Negative(byte[] v)
	{
		return (v[7] & 0x80) != 0;
	}

	private static ushort Exponent(byte[] v)
	{
		return (ushort)(((ushort)(v[7] & 0x7F) << 4) | ((ushort)(v[6] & 0xF0) >> 4));
	}

	private static ulong Mantissa(byte[] v)
	{
		int num = v[0] | (v[1] << 8) | (v[2] << 16) | (v[3] << 24);
		uint num2 = (uint)(v[4] | (v[5] << 8) | ((v[6] & 0xF) << 16));
		return (uint)num | ((ulong)num2 << 32);
	}

	public BigInteger(double value)
	{
		if (!double.IsNaN(value) && !double.IsInfinity(value))
		{
			byte[] bytes = BitConverter.GetBytes(value);
			ulong num = Mantissa(bytes);
			if (num == 0L)
			{
				int num2 = Exponent(bytes);
				if (num2 == 0)
				{
					_sign = 0;
					_data = null;
					return;
				}
				BigInteger bigInteger = (Negative(bytes) ? MinusOne : One);
				bigInteger <<= num2 - 1023;
				_sign = bigInteger._sign;
				_data = bigInteger._data;
			}
			else
			{
				int num3 = Exponent(bytes);
				num |= 0x10000000000000uL;
				BigInteger bigInteger2 = num;
				bigInteger2 = ((num3 > 1075) ? (bigInteger2 << num3 - 1075) : (bigInteger2 >> 1075 - num3));
				_sign = (short)((!Negative(bytes)) ? 1 : (-1));
				_data = bigInteger2._data;
			}
			return;
		}
		throw new OverflowException();
	}

	public BigInteger(float value)
		: this((double)value)
	{
	}

	public BigInteger(decimal value)
	{
		int[] bits = decimal.GetBits(decimal.Truncate(value));
		int num = 3;
		while (num > 0 && bits[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			_sign = 0;
			_data = null;
			return;
		}
		_sign = (short)(((bits[3] & int.MinValue) == 0) ? 1 : (-1));
		_data = new uint[num];
		_data[0] = (uint)bits[0];
		if (num > 1)
		{
			_data[1] = (uint)bits[1];
		}
		if (num > 2)
		{
			_data[2] = (uint)bits[2];
		}
	}

	[CLSCompliant(false)]
	public BigInteger(byte[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = value.Length;
		if (num != 0 && (num != 1 || value[0] != 0))
		{
			if ((value[num - 1] & 0x80u) != 0)
			{
				_sign = -1;
			}
			else
			{
				_sign = 1;
			}
			if (_sign == 1)
			{
				while (true)
				{
					if (value[num - 1] == 0)
					{
						if (--num == 0)
						{
							_sign = 0;
							_data = null;
							break;
						}
						continue;
					}
					int num2;
					int num3 = (num2 = num / 4);
					if (((uint)num & 3u) != 0)
					{
						num2++;
					}
					_data = new uint[num2];
					int num4 = 0;
					for (int i = 0; i < num3; i++)
					{
						_data[i] = (uint)(value[num4++] | (value[num4++] << 8) | (value[num4++] << 16) | (value[num4++] << 24));
					}
					num2 = num & 3;
					if (num2 > 0)
					{
						int num5 = _data.Length - 1;
						for (int j = 0; j < num2; j++)
						{
							_data[num5] |= (uint)(value[num4++] << j * 8);
						}
					}
					break;
				}
				return;
			}
			int num6;
			int num7 = (num6 = num / 4);
			if (((uint)num & 3u) != 0)
			{
				num6++;
			}
			_data = new uint[num6];
			uint num8 = 1u;
			int num9 = 0;
			for (int k = 0; k < num7; k++)
			{
				uint num10 = (uint)(value[num9++] | (value[num9++] << 8) | (value[num9++] << 16) | (value[num9++] << 24));
				long num11 = (long)num10 - (long)num8;
				num10 = (uint)num11;
				num8 = (uint)(int)((ulong)num11 >> 32) & 1u;
				_data[k] = ~num10;
			}
			num6 = num & 3;
			if (num6 > 0)
			{
				uint num10 = 0u;
				uint num12 = 0u;
				for (int l = 0; l < num6; l++)
				{
					num10 |= (uint)(value[num9++] << l * 8);
					num12 = (num12 << 8) | 0xFFu;
				}
				long num13 = num10 - num8;
				num10 = (uint)num13;
				_ = (ulong)num13 >> 32;
				num8 = 0u;
				if ((~num10 & num12) == 0)
				{
					Array.Resize(ref _data, _data.Length - 1);
				}
				else
				{
					_data[_data.Length - 1] = ~num10 & num12;
				}
			}
			if (num8 != 0)
			{
				throw new Exception("non zero final carry");
			}
		}
		else
		{
			_sign = 0;
			_data = null;
		}
	}

	private static int PopulationCount(uint x)
	{
		x -= (x >> 1) & 0x55555555;
		x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
		x = (x + (x >> 4)) & 0xF0F0F0Fu;
		x += x >> 8;
		x += x >> 16;
		return (int)(x & 0x3F);
	}

	private static int PopulationCount(ulong x)
	{
		x -= (x >> 1) & 0x5555555555555555L;
		x = (x & 0x3333333333333333L) + ((x >> 2) & 0x3333333333333333L);
		x = (x + (x >> 4)) & 0xF0F0F0F0F0F0F0FuL;
		return (int)(x * 72340172838076673L >> 56);
	}

	private static int LeadingZeroCount(uint value)
	{
		value |= value >> 1;
		value |= value >> 2;
		value |= value >> 4;
		value |= value >> 8;
		value |= value >> 16;
		return 32 - PopulationCount(value);
	}

	private static int LeadingZeroCount(ulong value)
	{
		value |= value >> 1;
		value |= value >> 2;
		value |= value >> 4;
		value |= value >> 8;
		value |= value >> 16;
		value |= value >> 32;
		return 64 - PopulationCount(value);
	}

	private static double BuildDouble(int sign, ulong mantissa, int exponent)
	{
		if (sign != 0 && mantissa != 0L)
		{
			exponent += 1075;
			int num = LeadingZeroCount(mantissa) - 11;
			if (exponent - num > 2046)
			{
				if (sign <= 0)
				{
					return double.NegativeInfinity;
				}
				return double.PositiveInfinity;
			}
			if (num < 0)
			{
				mantissa >>= -num;
				exponent += -num;
			}
			else if (num >= exponent)
			{
				mantissa <<= exponent - 1;
				exponent = 0;
			}
			else
			{
				mantissa <<= num;
				exponent -= num;
			}
			mantissa &= 0xFFFFFFFFFFFFFuL;
			if ((exponent & 0x7FFL) == exponent)
			{
				ulong num2 = mantissa | (ulong)((long)exponent << 52);
				if (sign < 0)
				{
					num2 |= 0x8000000000000000uL;
				}
				return BitConverter.Int64BitsToDouble((long)num2);
			}
			if (sign <= 0)
			{
				return double.NegativeInfinity;
			}
			return double.PositiveInfinity;
		}
		return 0.0;
	}

	public static explicit operator int(BigInteger value)
	{
		if (value._data == null)
		{
			return 0;
		}
		if (value._data.Length > 1)
		{
			throw new OverflowException();
		}
		uint num = value._data[0];
		if (value._sign == 1)
		{
			if (num > int.MaxValue)
			{
				throw new OverflowException();
			}
			return (int)num;
		}
		if (value._sign == -1)
		{
			if (num > 2147483648u)
			{
				throw new OverflowException();
			}
			return (int)(0 - num);
		}
		return 0;
	}

	[CLSCompliant(false)]
	public static explicit operator uint(BigInteger value)
	{
		if (value._data == null)
		{
			return 0u;
		}
		if (value._data.Length > 1 || value._sign == -1)
		{
			throw new OverflowException();
		}
		return value._data[0];
	}

	public static explicit operator short(BigInteger value)
	{
		int num = (int)value;
		if (num < -32768 || num > 32767)
		{
			throw new OverflowException();
		}
		return (short)num;
	}

	[CLSCompliant(false)]
	public static explicit operator ushort(BigInteger value)
	{
		uint num = (uint)value;
		if (num > 65535)
		{
			throw new OverflowException();
		}
		return (ushort)num;
	}

	public static explicit operator byte(BigInteger value)
	{
		uint num = (uint)value;
		if (num > 255)
		{
			throw new OverflowException();
		}
		return (byte)num;
	}

	[CLSCompliant(false)]
	public static explicit operator sbyte(BigInteger value)
	{
		int num = (int)value;
		if (num < -128 || num > 127)
		{
			throw new OverflowException();
		}
		return (sbyte)num;
	}

	public static explicit operator long(BigInteger value)
	{
		if (value._data == null)
		{
			return 0L;
		}
		if (value._data.Length > 2)
		{
			throw new OverflowException();
		}
		uint num = value._data[0];
		if (value._data.Length == 1)
		{
			if (value._sign == 1)
			{
				return num;
			}
			return 0L - (long)num;
		}
		uint num2 = value._data[1];
		if (value._sign == 1)
		{
			if (num2 >= 2147483648u)
			{
				throw new OverflowException();
			}
			return (long)(((ulong)num2 << 32) | num);
		}
		ulong num3 = 0L - (((ulong)num2 << 32) | num);
		if ((long)num3 > 0L)
		{
			throw new OverflowException();
		}
		return (long)num3;
	}

	[CLSCompliant(false)]
	public static explicit operator ulong(BigInteger value)
	{
		if (value._data == null)
		{
			return 0uL;
		}
		if (value._data.Length <= 2 && value._sign != -1)
		{
			uint num = value._data[0];
			if (value._data.Length == 1)
			{
				return num;
			}
			return ((ulong)value._data[1] << 32) | num;
		}
		throw new OverflowException();
	}

	public static explicit operator double(BigInteger value)
	{
		if (value._data == null)
		{
			return 0.0;
		}
		switch (value._data.Length)
		{
		default:
		{
			int num = value._data.Length - 1;
			uint num2 = value._data[num];
			ulong num3 = ((ulong)num2 << 32) | value._data[num - 1];
			int num4 = LeadingZeroCount(num2) - 11;
			return BuildDouble(mantissa: (num4 <= 0) ? (num3 >> -num4) : ((num3 << num4) | (value._data[num - 2] >> 32 - num4)), sign: value._sign, exponent: (value._data.Length - 2) * 32 - num4);
		}
		case 2:
			return BuildDouble(value._sign, ((ulong)value._data[1] << 32) | value._data[0], 0);
		case 1:
			return BuildDouble(value._sign, value._data[0], 0);
		}
	}

	public static explicit operator float(BigInteger value)
	{
		return (float)(double)value;
	}

	public static explicit operator decimal(BigInteger value)
	{
		if (value._data == null)
		{
			return 0m;
		}
		uint[] data = value._data;
		if (data.Length > 3)
		{
			throw new OverflowException();
		}
		int lo = 0;
		int mid = 0;
		int hi = 0;
		if (data.Length > 2)
		{
			hi = (int)data[2];
		}
		if (data.Length > 1)
		{
			mid = (int)data[1];
		}
		if (data.Length != 0)
		{
			lo = (int)data[0];
		}
		return new decimal(lo, mid, hi, value._sign < 0, 0);
	}

	public static implicit operator BigInteger(int value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(uint value)
	{
		return new BigInteger(value);
	}

	public static implicit operator BigInteger(short value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(ushort value)
	{
		return new BigInteger(value);
	}

	public static implicit operator BigInteger(byte value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(sbyte value)
	{
		return new BigInteger(value);
	}

	public static implicit operator BigInteger(long value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(ulong value)
	{
		return new BigInteger(value);
	}

	public static explicit operator BigInteger(double value)
	{
		return new BigInteger(value);
	}

	public static explicit operator BigInteger(float value)
	{
		return new BigInteger(value);
	}

	public static explicit operator BigInteger(decimal value)
	{
		return new BigInteger(value);
	}

	public static BigInteger operator +(BigInteger left, BigInteger right)
	{
		if (left._sign == 0)
		{
			return right;
		}
		if (right._sign == 0)
		{
			return left;
		}
		if (left._sign == right._sign)
		{
			return new BigInteger(left._sign, CoreAdd(left._data, right._data));
		}
		int num = CoreCompare(left._data, right._data);
		if (num == 0)
		{
			return Zero;
		}
		if (num > 0)
		{
			return new BigInteger(left._sign, CoreSub(left._data, right._data));
		}
		return new BigInteger(right._sign, CoreSub(right._data, left._data));
	}

	public static BigInteger operator -(BigInteger left, BigInteger right)
	{
		if (right._sign == 0)
		{
			return left;
		}
		if (left._sign == 0)
		{
			return new BigInteger((short)(-right._sign), right._data);
		}
		if (left._sign == right._sign)
		{
			int num = CoreCompare(left._data, right._data);
			if (num == 0)
			{
				return Zero;
			}
			if (num > 0)
			{
				return new BigInteger(left._sign, CoreSub(left._data, right._data));
			}
			return new BigInteger((short)(-right._sign), CoreSub(right._data, left._data));
		}
		return new BigInteger(left._sign, CoreAdd(left._data, right._data));
	}

	public static BigInteger operator *(BigInteger left, BigInteger right)
	{
		if (left._sign != 0 && right._sign != 0)
		{
			if (left._data[0] == 1 && left._data.Length == 1)
			{
				if (left._sign == 1)
				{
					return right;
				}
				return new BigInteger((short)(-right._sign), right._data);
			}
			if (right._data[0] == 1 && right._data.Length == 1)
			{
				if (right._sign == 1)
				{
					return left;
				}
				return new BigInteger((short)(-left._sign), left._data);
			}
			uint[] data = left._data;
			uint[] data2 = right._data;
			uint[] array = new uint[data.Length + data2.Length];
			for (int i = 0; i < data.Length; i++)
			{
				uint num = data[i];
				int num2 = i;
				ulong num3 = 0uL;
				for (int j = 0; j < data2.Length; j++)
				{
					num3 = (ulong)((long)num3 + (long)num * (long)data2[j] + array[num2]);
					array[num2++] = (uint)num3;
					num3 >>= 32;
				}
				while (num3 != 0L)
				{
					num3 += array[num2];
					array[num2++] = (uint)num3;
					num3 >>= 32;
				}
			}
			int num4 = array.Length - 1;
			while (num4 >= 0 && array[num4] == 0)
			{
				num4--;
			}
			if (num4 < array.Length - 1)
			{
				Array.Resize(ref array, num4 + 1);
			}
			return new BigInteger((short)(left._sign * right._sign), array);
		}
		return Zero;
	}

	public static BigInteger operator /(BigInteger dividend, BigInteger divisor)
	{
		if (divisor._sign == 0)
		{
			throw new DivideByZeroException();
		}
		if (dividend._sign == 0)
		{
			return dividend;
		}
		DivModUnsigned(dividend._data, divisor._data, out var q, out var _);
		int num = q.Length - 1;
		while (num >= 0 && q[num] == 0)
		{
			num--;
		}
		if (num == -1)
		{
			return Zero;
		}
		if (num < q.Length - 1)
		{
			Array.Resize(ref q, num + 1);
		}
		return new BigInteger((short)(dividend._sign * divisor._sign), q);
	}

	public static BigInteger operator %(BigInteger dividend, BigInteger divisor)
	{
		if (divisor._sign == 0)
		{
			throw new DivideByZeroException();
		}
		if (dividend._sign == 0)
		{
			return dividend;
		}
		DivModUnsigned(dividend._data, divisor._data, out var _, out var r);
		int num = r.Length - 1;
		while (num >= 0 && r[num] == 0)
		{
			num--;
		}
		if (num == -1)
		{
			return Zero;
		}
		if (num < r.Length - 1)
		{
			Array.Resize(ref r, num + 1);
		}
		return new BigInteger(dividend._sign, r);
	}

	public static BigInteger operator -(BigInteger value)
	{
		if (value._data == null)
		{
			return value;
		}
		return new BigInteger((short)(-value._sign), value._data);
	}

	public static BigInteger operator +(BigInteger value)
	{
		return value;
	}

	public static BigInteger operator ++(BigInteger value)
	{
		if (value._data == null)
		{
			return One;
		}
		short sign = value._sign;
		uint[] data = value._data;
		if (data.Length == 1)
		{
			if (sign == -1 && data[0] == 1)
			{
				return Zero;
			}
			if (sign == 0)
			{
				return One;
			}
		}
		data = ((sign == -1) ? CoreSub(data, 1u) : CoreAdd(data, 1u));
		return new BigInteger(sign, data);
	}

	public static BigInteger operator --(BigInteger value)
	{
		if (value._data == null)
		{
			return MinusOne;
		}
		short sign = value._sign;
		uint[] data = value._data;
		if (data.Length == 1)
		{
			if (sign == 1 && data[0] == 1)
			{
				return Zero;
			}
			if (sign == 0)
			{
				return MinusOne;
			}
		}
		data = ((sign == -1) ? CoreAdd(data, 1u) : CoreSub(data, 1u));
		return new BigInteger(sign, data);
	}

	public static BigInteger operator &(BigInteger left, BigInteger right)
	{
		if (left._sign == 0)
		{
			return left;
		}
		if (right._sign == 0)
		{
			return right;
		}
		uint[] data = left._data;
		uint[] data2 = right._data;
		int sign = left._sign;
		int sign2 = right._sign;
		bool flag = sign == sign2 && sign == -1;
		uint[] array = new uint[Math.Max(data.Length, data2.Length)];
		ulong num = 1uL;
		ulong num2 = 1uL;
		ulong num3 = 1uL;
		int i;
		for (i = 0; i < array.Length; i++)
		{
			uint num4 = 0u;
			if (i < data.Length)
			{
				num4 = data[i];
			}
			if (sign == -1)
			{
				num = ~num4 + num;
				num4 = (uint)num;
				num = (uint)(num >> 32);
			}
			uint num5 = 0u;
			if (i < data2.Length)
			{
				num5 = data2[i];
			}
			if (sign2 == -1)
			{
				num2 = ~num5 + num2;
				num5 = (uint)num2;
				num2 = (uint)(num2 >> 32);
			}
			uint num6 = num4 & num5;
			if (flag)
			{
				num3 = num6 - num3;
				num6 = (uint)(~num3);
				num3 = (uint)(int)(num3 >> 32) & 1u;
			}
			array[i] = num6;
		}
		i = array.Length - 1;
		while (i >= 0 && array[i] == 0)
		{
			i--;
		}
		if (i == -1)
		{
			return Zero;
		}
		if (i < array.Length - 1)
		{
			Array.Resize(ref array, i + 1);
		}
		return new BigInteger((short)((!flag) ? 1 : (-1)), array);
	}

	public static BigInteger operator |(BigInteger left, BigInteger right)
	{
		if (left._sign == 0)
		{
			return right;
		}
		if (right._sign == 0)
		{
			return left;
		}
		uint[] data = left._data;
		uint[] data2 = right._data;
		int sign = left._sign;
		int sign2 = right._sign;
		bool flag = sign == -1 || sign2 == -1;
		uint[] array = new uint[Math.Max(data.Length, data2.Length)];
		ulong num = 1uL;
		ulong num2 = 1uL;
		ulong num3 = 1uL;
		int i;
		for (i = 0; i < array.Length; i++)
		{
			uint num4 = 0u;
			if (i < data.Length)
			{
				num4 = data[i];
			}
			if (sign == -1)
			{
				num = ~num4 + num;
				num4 = (uint)num;
				num = (uint)(num >> 32);
			}
			uint num5 = 0u;
			if (i < data2.Length)
			{
				num5 = data2[i];
			}
			if (sign2 == -1)
			{
				num2 = ~num5 + num2;
				num5 = (uint)num2;
				num2 = (uint)(num2 >> 32);
			}
			uint num6 = num4 | num5;
			if (flag)
			{
				num3 = num6 - num3;
				num6 = (uint)(~num3);
				num3 = (uint)(int)(num3 >> 32) & 1u;
			}
			array[i] = num6;
		}
		i = array.Length - 1;
		while (i >= 0 && array[i] == 0)
		{
			i--;
		}
		if (i == -1)
		{
			return Zero;
		}
		if (i < array.Length - 1)
		{
			Array.Resize(ref array, i + 1);
		}
		return new BigInteger((short)((!flag) ? 1 : (-1)), array);
	}

	public static BigInteger operator ^(BigInteger left, BigInteger right)
	{
		if (left._sign == 0)
		{
			return right;
		}
		if (right._sign == 0)
		{
			return left;
		}
		uint[] data = left._data;
		uint[] data2 = right._data;
		int sign = left._sign;
		int sign2 = right._sign;
		bool flag = (sign == -1) ^ (sign2 == -1);
		uint[] array = new uint[Math.Max(data.Length, data2.Length)];
		ulong num = 1uL;
		ulong num2 = 1uL;
		ulong num3 = 1uL;
		int i;
		for (i = 0; i < array.Length; i++)
		{
			uint num4 = 0u;
			if (i < data.Length)
			{
				num4 = data[i];
			}
			if (sign == -1)
			{
				num = ~num4 + num;
				num4 = (uint)num;
				num = (uint)(num >> 32);
			}
			uint num5 = 0u;
			if (i < data2.Length)
			{
				num5 = data2[i];
			}
			if (sign2 == -1)
			{
				num2 = ~num5 + num2;
				num5 = (uint)num2;
				num2 = (uint)(num2 >> 32);
			}
			uint num6 = num4 ^ num5;
			if (flag)
			{
				num3 = num6 - num3;
				num6 = (uint)(~num3);
				num3 = (uint)(int)(num3 >> 32) & 1u;
			}
			array[i] = num6;
		}
		i = array.Length - 1;
		while (i >= 0 && array[i] == 0)
		{
			i--;
		}
		if (i == -1)
		{
			return Zero;
		}
		if (i < array.Length - 1)
		{
			Array.Resize(ref array, i + 1);
		}
		return new BigInteger((short)((!flag) ? 1 : (-1)), array);
	}

	public static BigInteger operator ~(BigInteger value)
	{
		if (value._data == null)
		{
			return MinusOne;
		}
		uint[] data = value._data;
		int sign = value._sign;
		bool flag = sign == 1;
		uint[] array = new uint[data.Length];
		ulong num = 1uL;
		ulong num2 = 1uL;
		int i;
		for (i = 0; i < array.Length; i++)
		{
			uint num3 = data[i];
			if (sign == -1)
			{
				num = ~num3 + num;
				num3 = (uint)num;
				num = (uint)(num >> 32);
			}
			num3 = ~num3;
			if (flag)
			{
				num2 = num3 - num2;
				num3 = (uint)(~num2);
				num2 = (uint)(int)(num2 >> 32) & 1u;
			}
			array[i] = num3;
		}
		i = array.Length - 1;
		while (i >= 0 && array[i] == 0)
		{
			i--;
		}
		if (i == -1)
		{
			return Zero;
		}
		if (i < array.Length - 1)
		{
			Array.Resize(ref array, i + 1);
		}
		return new BigInteger((short)((!flag) ? 1 : (-1)), array);
	}

	private static int BitScanBackward(uint word)
	{
		int num = 31;
		while (true)
		{
			if (num >= 0)
			{
				uint num2 = (uint)(1 << num);
				if ((word & num2) == num2)
				{
					break;
				}
				num--;
				continue;
			}
			return 0;
		}
		return num;
	}

	public static BigInteger operator <<(BigInteger value, int shift)
	{
		if (shift != 0 && value._data != null)
		{
			if (shift < 0)
			{
				return value >> -shift;
			}
			uint[] data = value._data;
			int sign = value._sign;
			int num = BitScanBackward(data[^1]);
			int num2 = shift - (31 - num);
			int num3 = (num2 >> 5) + ((((uint)num2 & 0x1Fu) != 0) ? 1 : 0);
			uint[] array = new uint[data.Length + num3];
			int num4 = shift >> 5;
			int num5 = shift & 0x1F;
			int num6 = 32 - num5;
			if (num6 == 32)
			{
				for (int i = 0; i < data.Length; i++)
				{
					uint num7 = data[i];
					array[i + num4] |= num7 << num5;
				}
			}
			else
			{
				for (int j = 0; j < data.Length; j++)
				{
					uint num8 = data[j];
					array[j + num4] |= num8 << num5;
					if (j + num4 + 1 < array.Length)
					{
						array[j + num4 + 1] = num8 >> num6;
					}
				}
			}
			return new BigInteger((short)sign, array);
		}
		return value;
	}

	public static BigInteger operator >>(BigInteger value, int shift)
	{
		if (shift != 0 && value._sign != 0)
		{
			if (shift < 0)
			{
				return value << -shift;
			}
			uint[] data = value._data;
			int sign = value._sign;
			int num = BitScanBackward(data[^1]);
			int num2 = shift >> 5;
			int num3 = shift & 0x1F;
			int num4 = num2;
			if (num3 > num)
			{
				num4++;
			}
			int num5 = data.Length - num4;
			if (num5 <= 0)
			{
				if (sign == 1)
				{
					return Zero;
				}
				return MinusOne;
			}
			uint[] array = new uint[num5];
			int num6 = 32 - num3;
			if (num6 == 32)
			{
				for (int num7 = data.Length - 1; num7 >= num2; num7--)
				{
					uint num8 = data[num7];
					if (num7 - num2 < array.Length)
					{
						array[num7 - num2] |= num8 >> num3;
					}
				}
			}
			else
			{
				for (int num9 = data.Length - 1; num9 >= num2; num9--)
				{
					uint num10 = data[num9];
					if (num9 - num2 < array.Length)
					{
						array[num9 - num2] |= num10 >> num3;
					}
					if (num9 - num2 - 1 >= 0)
					{
						array[num9 - num2 - 1] = num10 << num6;
					}
				}
			}
			if (sign == -1)
			{
				for (int i = 0; i < num2; i++)
				{
					if (data[i] != 0)
					{
						BigInteger bigInteger = new BigInteger((short)sign, array);
						return --bigInteger;
					}
				}
				if (num3 > 0 && data[num2] << num6 != 0)
				{
					BigInteger bigInteger2 = new BigInteger((short)sign, array);
					return --bigInteger2;
				}
			}
			return new BigInteger((short)sign, array);
		}
		return value;
	}

	public static bool operator <(BigInteger left, BigInteger right)
	{
		return Compare(left, right) < 0;
	}

	public static bool operator <(BigInteger left, long right)
	{
		return left.CompareTo(right) < 0;
	}

	public static bool operator <(long left, BigInteger right)
	{
		return right.CompareTo(left) > 0;
	}

	[CLSCompliant(false)]
	public static bool operator <(BigInteger left, ulong right)
	{
		return left.CompareTo(right) < 0;
	}

	[CLSCompliant(false)]
	public static bool operator <(ulong left, BigInteger right)
	{
		return right.CompareTo(left) > 0;
	}

	public static bool operator <=(BigInteger left, BigInteger right)
	{
		return Compare(left, right) <= 0;
	}

	public static bool operator <=(BigInteger left, long right)
	{
		return left.CompareTo(right) <= 0;
	}

	public static bool operator <=(long left, BigInteger right)
	{
		return right.CompareTo(left) >= 0;
	}

	[CLSCompliant(false)]
	public static bool operator <=(BigInteger left, ulong right)
	{
		return left.CompareTo(right) <= 0;
	}

	[CLSCompliant(false)]
	public static bool operator <=(ulong left, BigInteger right)
	{
		return right.CompareTo(left) >= 0;
	}

	public static bool operator >(BigInteger left, BigInteger right)
	{
		return Compare(left, right) > 0;
	}

	public static bool operator >(BigInteger left, long right)
	{
		return left.CompareTo(right) > 0;
	}

	public static bool operator >(long left, BigInteger right)
	{
		return right.CompareTo(left) < 0;
	}

	[CLSCompliant(false)]
	public static bool operator >(BigInteger left, ulong right)
	{
		return left.CompareTo(right) > 0;
	}

	[CLSCompliant(false)]
	public static bool operator >(ulong left, BigInteger right)
	{
		return right.CompareTo(left) < 0;
	}

	public static bool operator >=(BigInteger left, BigInteger right)
	{
		return Compare(left, right) >= 0;
	}

	public static bool operator >=(BigInteger left, long right)
	{
		return left.CompareTo(right) >= 0;
	}

	public static bool operator >=(long left, BigInteger right)
	{
		return right.CompareTo(left) <= 0;
	}

	[CLSCompliant(false)]
	public static bool operator >=(BigInteger left, ulong right)
	{
		return left.CompareTo(right) >= 0;
	}

	[CLSCompliant(false)]
	public static bool operator >=(ulong left, BigInteger right)
	{
		return right.CompareTo(left) <= 0;
	}

	public static bool operator ==(BigInteger left, BigInteger right)
	{
		return Compare(left, right) == 0;
	}

	public static bool operator ==(BigInteger left, long right)
	{
		return left.CompareTo(right) == 0;
	}

	public static bool operator ==(long left, BigInteger right)
	{
		return right.CompareTo(left) == 0;
	}

	[CLSCompliant(false)]
	public static bool operator ==(BigInteger left, ulong right)
	{
		return left.CompareTo(right) == 0;
	}

	[CLSCompliant(false)]
	public static bool operator ==(ulong left, BigInteger right)
	{
		return right.CompareTo(left) == 0;
	}

	public static bool operator !=(BigInteger left, BigInteger right)
	{
		return Compare(left, right) != 0;
	}

	public static bool operator !=(BigInteger left, long right)
	{
		return left.CompareTo(right) != 0;
	}

	public static bool operator !=(long left, BigInteger right)
	{
		return right.CompareTo(left) != 0;
	}

	[CLSCompliant(false)]
	public static bool operator !=(BigInteger left, ulong right)
	{
		return left.CompareTo(right) != 0;
	}

	[CLSCompliant(false)]
	public static bool operator !=(ulong left, BigInteger right)
	{
		return right.CompareTo(left) != 0;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is BigInteger))
		{
			return false;
		}
		return Equals((BigInteger)obj);
	}

	public bool Equals(BigInteger other)
	{
		if (_sign != other._sign)
		{
			return false;
		}
		int num = ((_data != null) ? _data.Length : 0);
		int num2 = ((other._data != null) ? other._data.Length : 0);
		if (num != num2)
		{
			return false;
		}
		int num3 = 0;
		while (true)
		{
			if (num3 < num)
			{
				if (_data[num3] != other._data[num3])
				{
					break;
				}
				num3++;
				continue;
			}
			return true;
		}
		return false;
	}

	public bool Equals(long other)
	{
		return CompareTo(other) == 0;
	}

	public override string ToString()
	{
		return ToString(10u, null);
	}

	private string ToStringWithPadding(string format, uint radix, IFormatProvider provider)
	{
		if (format.Length > 1)
		{
			int num = Convert.ToInt32(format.Substring(1), CultureInfo.InvariantCulture.NumberFormat);
			string text = ToString(radix, provider);
			if (text.Length < num)
			{
				string text2 = new string('0', num - text.Length);
				if (text[0] != '-')
				{
					return text2 + text;
				}
				return "-" + text2 + text.Substring(1);
			}
			return text;
		}
		return ToString(radix, provider);
	}

	public string ToString(string format)
	{
		return ToString(format, null);
	}

	public string ToString(IFormatProvider provider)
	{
		return ToString(null, provider);
	}

	public string ToString(string format, IFormatProvider provider)
	{
		if (string.IsNullOrEmpty(format))
		{
			return ToString(10u, provider);
		}
		switch (format[0])
		{
		default:
			throw new FormatException($"format '{format}' not implemented");
		case 'X':
		case 'x':
			return ToStringWithPadding(format, 16u, null);
		case 'D':
		case 'G':
		case 'R':
		case 'd':
		case 'g':
		case 'r':
			return ToStringWithPadding(format, 10u, provider);
		}
	}

	private static uint[] MakeTwoComplement(uint[] v)
	{
		uint[] array = new uint[v.Length];
		ulong num = 1uL;
		for (int i = 0; i < v.Length; i++)
		{
			uint num2 = v[i];
			num = ~num2 + num;
			num2 = (uint)num;
			num = (uint)(num >> 32);
			array[i] = num2;
		}
		uint num3 = array[^1];
		int num4 = FirstNonFfByte(num3);
		uint num5 = 255u;
		for (int j = 1; j < num4; j++)
		{
			num5 = (num5 << 8) | 0xFFu;
		}
		array[^1] = num3 & num5;
		return array;
	}

	private string ToString(uint radix, IFormatProvider provider)
	{
		if ("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length < radix)
		{
			throw new ArgumentException("charSet length less than radix", "characterSet");
		}
		if (radix == 1)
		{
			throw new ArgumentException("There is no such thing as radix one notation", "radix");
		}
		if (_sign == 0)
		{
			return "0";
		}
		if (_data.Length == 1 && _data[0] == 1)
		{
			if (_sign != 1)
			{
				return "-1";
			}
			return "1";
		}
		List<char> list = new List<char>(1 + _data.Length * 3 / 10);
		BigInteger bigInteger;
		if (_sign == 1)
		{
			bigInteger = this;
		}
		else
		{
			uint[] array = _data;
			if (radix > 10)
			{
				array = MakeTwoComplement(array);
			}
			bigInteger = new BigInteger(1, array);
		}
		while (bigInteger != 0L)
		{
			bigInteger = DivRem(bigInteger, radix, out var remainder);
			list.Add("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"[(int)remainder]);
		}
		if (_sign == -1 && radix == 10)
		{
			NumberFormatInfo numberFormatInfo = null;
			if (provider != null)
			{
				numberFormatInfo = provider.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo;
			}
			if (numberFormatInfo != null)
			{
				string negativeSign = numberFormatInfo.NegativeSign;
				for (int num = negativeSign.Length - 1; num >= 0; num--)
				{
					list.Add(negativeSign[num]);
				}
			}
			else
			{
				list.Add('-');
			}
		}
		char c = list[list.Count - 1];
		if (_sign == 1 && radix > 10 && (c < '0' || c > '9'))
		{
			list.Add('0');
		}
		list.Reverse();
		return new string(list.ToArray());
	}

	public static BigInteger Parse(string value)
	{
		if (!Parse(value, tryParse: false, out var result, out var exc))
		{
			throw exc;
		}
		return result;
	}

	public static BigInteger Parse(string value, NumberStyles style)
	{
		return Parse(value, style, null);
	}

	public static BigInteger Parse(string value, IFormatProvider provider)
	{
		return Parse(value, NumberStyles.Integer, provider);
	}

	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider)
	{
		if (!Parse(value, style, provider, tryParse: false, out var result, out var exc))
		{
			throw exc;
		}
		return result;
	}

	public static bool TryParse(string value, out BigInteger result)
	{
		Exception exc;
		return Parse(value, tryParse: true, out result, out exc);
	}

	public static bool TryParse(string value, NumberStyles style, IFormatProvider provider, out BigInteger result)
	{
		if (!Parse(value, style, provider, tryParse: true, out result, out var _))
		{
			result = Zero;
			return false;
		}
		return true;
	}

	private static bool Parse(string value, NumberStyles style, IFormatProvider fp, bool tryParse, out BigInteger result, out Exception exc)
	{
		result = Zero;
		exc = null;
		if (value == null)
		{
			if (!tryParse)
			{
				exc = new ArgumentNullException("value");
			}
			return false;
		}
		if (value.Length == 0)
		{
			if (!tryParse)
			{
				exc = GetFormatException();
			}
			return false;
		}
		NumberFormatInfo numberFormatInfo = null;
		if (fp != null)
		{
			Type typeFromHandle = typeof(NumberFormatInfo);
			numberFormatInfo = (NumberFormatInfo)fp.GetFormat(typeFromHandle);
		}
		if (numberFormatInfo == null)
		{
			numberFormatInfo = NumberFormatInfo.CurrentInfo;
		}
		if (!CheckStyle(style, tryParse, ref exc))
		{
			return false;
		}
		bool flag = (style & NumberStyles.AllowCurrencySymbol) != 0;
		bool flag2 = (style & NumberStyles.AllowHexSpecifier) != 0;
		bool flag3 = (style & NumberStyles.AllowThousands) != 0;
		bool flag4 = (style & NumberStyles.AllowDecimalPoint) != 0;
		bool flag5 = (style & NumberStyles.AllowParentheses) != 0;
		bool flag6 = (style & NumberStyles.AllowTrailingSign) != 0;
		bool flag7 = (style & NumberStyles.AllowLeadingSign) != 0;
		bool flag8 = (style & NumberStyles.AllowTrailingWhite) != 0;
		bool flag9 = (style & NumberStyles.AllowLeadingWhite) != 0;
		bool flag10 = (style & NumberStyles.AllowExponent) != 0;
		int pos = 0;
		if (flag9 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
		{
			return false;
		}
		bool flag11 = false;
		bool negative = false;
		bool foundSign = false;
		bool foundCurrency = false;
		if (flag5 && value[pos] == '(')
		{
			flag11 = true;
			foundSign = true;
			negative = true;
			pos++;
			if (flag9 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
			{
				return false;
			}
			if (value.Substring(pos, numberFormatInfo.NegativeSign.Length) == numberFormatInfo.NegativeSign)
			{
				if (!tryParse)
				{
					exc = GetFormatException();
				}
				return false;
			}
			if (value.Substring(pos, numberFormatInfo.PositiveSign.Length) == numberFormatInfo.PositiveSign)
			{
				if (!tryParse)
				{
					exc = GetFormatException();
				}
				return false;
			}
		}
		if (flag7 && !foundSign)
		{
			FindSign(ref pos, value, numberFormatInfo, ref foundSign, ref negative);
			if (foundSign)
			{
				if (flag9 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
				{
					return false;
				}
				if (flag)
				{
					FindCurrency(ref pos, value, numberFormatInfo, ref foundCurrency);
					if (foundCurrency && flag9 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
					{
						return false;
					}
				}
			}
		}
		if (flag && !foundCurrency)
		{
			FindCurrency(ref pos, value, numberFormatInfo, ref foundCurrency);
			if (foundCurrency)
			{
				if (flag9 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
				{
					return false;
				}
				if (foundCurrency && !foundSign && flag7)
				{
					FindSign(ref pos, value, numberFormatInfo, ref foundSign, ref negative);
					if (foundSign && flag9 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
					{
						return false;
					}
				}
			}
		}
		BigInteger bigInteger = Zero;
		int num = 0;
		int num2 = -1;
		bool flag12 = true;
		while (pos < value.Length)
		{
			if (!ValidDigit(value[pos], flag2))
			{
				if (!flag3 || (!FindOther(ref pos, value, numberFormatInfo.NumberGroupSeparator) && !FindOther(ref pos, value, numberFormatInfo.CurrencyGroupSeparator)))
				{
					if (!flag4 || num2 >= 0 || (!FindOther(ref pos, value, numberFormatInfo.NumberDecimalSeparator) && !FindOther(ref pos, value, numberFormatInfo.CurrencyDecimalSeparator)))
					{
						break;
					}
					num2 = num;
				}
				continue;
			}
			num++;
			if (flag2)
			{
				char c = value[pos++];
				byte b = (char.IsDigit(c) ? ((byte)(c - 48)) : ((!char.IsLower(c)) ? ((byte)(c - 65 + 10)) : ((byte)(c - 97 + 10))));
				if (flag12 && b >= 8)
				{
					negative = true;
				}
				bigInteger = bigInteger * 16 + b;
				flag12 = false;
			}
			else
			{
				bigInteger = bigInteger * 10 + (byte)(value[pos++] - 48);
			}
		}
		if (num == 0)
		{
			if (!tryParse)
			{
				exc = GetFormatException();
			}
			return false;
		}
		if (flag2 && negative)
		{
			BigInteger bigInteger2 = Pow(16, num) - 1;
			bigInteger = (bigInteger ^ bigInteger2) + 1;
		}
		int exponent = 0;
		if (flag10 && FindExponent(ref pos, value, ref exponent, tryParse, ref exc) && exc != null)
		{
			return false;
		}
		if (flag6 && !foundSign)
		{
			FindSign(ref pos, value, numberFormatInfo, ref foundSign, ref negative);
			if (foundSign && pos < value.Length && flag8 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
			{
				return false;
			}
		}
		if (flag && !foundCurrency)
		{
			if (flag8 && pos < value.Length && !JumpOverWhitespace(ref pos, value, reportError: false, tryParse, ref exc))
			{
				return false;
			}
			FindCurrency(ref pos, value, numberFormatInfo, ref foundCurrency);
			if (foundCurrency && pos < value.Length)
			{
				if (flag8 && !JumpOverWhitespace(ref pos, value, reportError: true, tryParse, ref exc))
				{
					return false;
				}
				if (!foundSign && flag6)
				{
					FindSign(ref pos, value, numberFormatInfo, ref foundSign, ref negative);
				}
			}
		}
		if (flag8 && pos < value.Length && !JumpOverWhitespace(ref pos, value, reportError: false, tryParse, ref exc))
		{
			return false;
		}
		if (flag11)
		{
			if (pos >= value.Length || value[pos++] != ')')
			{
				if (!tryParse)
				{
					exc = GetFormatException();
				}
				return false;
			}
			if (flag8 && pos < value.Length && !JumpOverWhitespace(ref pos, value, reportError: false, tryParse, ref exc))
			{
				return false;
			}
		}
		if (pos < value.Length && value[pos] != 0)
		{
			if (!tryParse)
			{
				exc = GetFormatException();
			}
			return false;
		}
		if (num2 >= 0)
		{
			exponent = exponent - num + num2;
		}
		if (exponent < 0)
		{
			bigInteger = DivRem(bigInteger, Pow(10, -exponent), out var remainder);
			if (!remainder.IsZero)
			{
				if (!tryParse)
				{
					exc = new OverflowException(string.Concat("Value too large or too small. exp=", exponent, " rem = ", remainder, " pow = ", Pow(10, -exponent)));
				}
				return false;
			}
		}
		else if (exponent > 0)
		{
			bigInteger = Pow(10, exponent) * bigInteger;
		}
		if (bigInteger._sign == 0)
		{
			result = bigInteger;
		}
		else if (negative)
		{
			result = new BigInteger(-1, bigInteger._data);
		}
		else
		{
			result = new BigInteger(1, bigInteger._data);
		}
		return true;
	}

	private static bool CheckStyle(NumberStyles style, bool tryParse, ref Exception exc)
	{
		if ((style & NumberStyles.AllowHexSpecifier) != 0)
		{
			NumberStyles numberStyles = style ^ NumberStyles.AllowHexSpecifier;
			if ((numberStyles & NumberStyles.AllowLeadingWhite) != 0)
			{
				numberStyles ^= NumberStyles.AllowLeadingWhite;
			}
			if ((numberStyles & NumberStyles.AllowTrailingWhite) != 0)
			{
				numberStyles ^= NumberStyles.AllowTrailingWhite;
			}
			if (numberStyles != 0)
			{
				if (!tryParse)
				{
					exc = new ArgumentException("With AllowHexSpecifier only AllowLeadingWhite and AllowTrailingWhite are permitted.");
				}
				return false;
			}
		}
		else if ((uint)style > 511u)
		{
			if (!tryParse)
			{
				exc = new ArgumentException("Not a valid number style");
			}
			return false;
		}
		return true;
	}

	private static bool JumpOverWhitespace(ref int pos, string s, bool reportError, bool tryParse, ref Exception exc)
	{
		while (pos < s.Length && char.IsWhiteSpace(s[pos]))
		{
			pos++;
		}
		if (reportError && pos >= s.Length)
		{
			if (!tryParse)
			{
				exc = GetFormatException();
			}
			return false;
		}
		return true;
	}

	private static void FindSign(ref int pos, string s, NumberFormatInfo nfi, ref bool foundSign, ref bool negative)
	{
		if (pos + nfi.NegativeSign.Length <= s.Length && string.CompareOrdinal(s, pos, nfi.NegativeSign, 0, nfi.NegativeSign.Length) == 0)
		{
			negative = true;
			foundSign = true;
			pos += nfi.NegativeSign.Length;
		}
		else if (pos + nfi.PositiveSign.Length <= s.Length && string.CompareOrdinal(s, pos, nfi.PositiveSign, 0, nfi.PositiveSign.Length) == 0)
		{
			negative = false;
			pos += nfi.PositiveSign.Length;
			foundSign = true;
		}
	}

	private static void FindCurrency(ref int pos, string s, NumberFormatInfo nfi, ref bool foundCurrency)
	{
		if (pos + nfi.CurrencySymbol.Length <= s.Length && s.Substring(pos, nfi.CurrencySymbol.Length) == nfi.CurrencySymbol)
		{
			foundCurrency = true;
			pos += nfi.CurrencySymbol.Length;
		}
	}

	private static bool FindExponent(ref int pos, string s, ref int exponent, bool tryParse, ref Exception exc)
	{
		exponent = 0;
		if (pos < s.Length && (s[pos] == 'e' || s[pos] == 'E'))
		{
			int num = pos + 1;
			if (num == s.Length)
			{
				exc = (tryParse ? null : GetFormatException());
				return true;
			}
			bool flag = false;
			if (s[num] == '-')
			{
				flag = true;
				if (++num == s.Length)
				{
					exc = (tryParse ? null : GetFormatException());
					return true;
				}
			}
			if (s[num] == '+' && ++num == s.Length)
			{
				exc = (tryParse ? null : GetFormatException());
				return true;
			}
			long num2 = 0L;
			while (true)
			{
				if (num < s.Length)
				{
					if (char.IsDigit(s[num]))
					{
						checked
						{
							num2 = num2 * 10L - (unchecked((int)s[num]) - 48);
							if (num2 < -2147483648L || num2 > 2147483647L)
							{
								break;
							}
						}
						num++;
						continue;
					}
					exc = (tryParse ? null : GetFormatException());
					return true;
				}
				if (!flag)
				{
					num2 = -num2;
				}
				exc = null;
				exponent = (int)num2;
				pos = num;
				return true;
			}
			exc = (tryParse ? null : new OverflowException("Value too large or too small."));
			return true;
		}
		exc = null;
		return false;
	}

	private static bool FindOther(ref int pos, string s, string other)
	{
		if (pos + other.Length <= s.Length && s.Substring(pos, other.Length) == other)
		{
			pos += other.Length;
			return true;
		}
		return false;
	}

	private static bool ValidDigit(char e, bool allowHex)
	{
		if (allowHex)
		{
			if (!char.IsDigit(e) && (e < 'A' || e > 'F'))
			{
				if (e >= 'a')
				{
					return e <= 'f';
				}
				return false;
			}
			return true;
		}
		return char.IsDigit(e);
	}

	private static Exception GetFormatException()
	{
		return new FormatException("Input string was not in the correct format");
	}

	private static bool ProcessTrailingWhitespace(bool tryParse, string s, int position, ref Exception exc)
	{
		int length = s.Length;
		int num = position;
		while (true)
		{
			if (num < length)
			{
				char c = s[num];
				if (c != 0 && !char.IsWhiteSpace(c))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		if (!tryParse)
		{
			exc = GetFormatException();
		}
		return false;
	}

	private static bool Parse(string value, bool tryParse, out BigInteger result, out Exception exc)
	{
		int num = 1;
		bool flag = false;
		result = Zero;
		exc = null;
		if (value == null)
		{
			if (!tryParse)
			{
				exc = new ArgumentNullException("value");
			}
			return false;
		}
		int length = value.Length;
		int i;
		for (i = 0; i < length; i++)
		{
			char c = value[i];
			if (!char.IsWhiteSpace(c))
			{
				break;
			}
		}
		if (i == length)
		{
			if (!tryParse)
			{
				exc = GetFormatException();
			}
			return false;
		}
		NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
		string negativeSign = currentInfo.NegativeSign;
		string positiveSign = currentInfo.PositiveSign;
		if (string.CompareOrdinal(value, i, positiveSign, 0, positiveSign.Length) == 0)
		{
			i += positiveSign.Length;
		}
		else if (string.CompareOrdinal(value, i, negativeSign, 0, negativeSign.Length) == 0)
		{
			num = -1;
			i += negativeSign.Length;
		}
		BigInteger bigInteger = Zero;
		for (; i < length; i++)
		{
			char c = value[i];
			switch (c)
			{
			case '\0':
				i = length;
				break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			{
				byte b = (byte)(c - 48);
				bigInteger = bigInteger * 10 + b;
				flag = true;
				break;
			}
			default:
				if (!ProcessTrailingWhitespace(tryParse, value, i, ref exc))
				{
					return false;
				}
				break;
			}
		}
		if (!flag)
		{
			if (!tryParse)
			{
				exc = GetFormatException();
			}
			return false;
		}
		if (bigInteger._sign == 0)
		{
			result = bigInteger;
		}
		else if (num == -1)
		{
			result = new BigInteger(-1, bigInteger._data);
		}
		else
		{
			result = new BigInteger(1, bigInteger._data);
		}
		return true;
	}

	public static BigInteger Min(BigInteger left, BigInteger right)
	{
		int sign = left._sign;
		int sign2 = right._sign;
		if (sign < sign2)
		{
			return left;
		}
		if (sign2 < sign)
		{
			return right;
		}
		int num = CoreCompare(left._data, right._data);
		if (sign == -1)
		{
			num = -num;
		}
		if (num <= 0)
		{
			return left;
		}
		return right;
	}

	public static BigInteger Max(BigInteger left, BigInteger right)
	{
		int sign = left._sign;
		int sign2 = right._sign;
		if (sign > sign2)
		{
			return left;
		}
		if (sign2 > sign)
		{
			return right;
		}
		int num = CoreCompare(left._data, right._data);
		if (sign == -1)
		{
			num = -num;
		}
		if (num >= 0)
		{
			return left;
		}
		return right;
	}

	public static BigInteger Abs(BigInteger value)
	{
		return new BigInteger(Math.Abs(value._sign), value._data);
	}

	public static BigInteger DivRem(BigInteger dividend, BigInteger divisor, out BigInteger remainder)
	{
		if (divisor._sign == 0)
		{
			throw new DivideByZeroException();
		}
		if (dividend._sign == 0)
		{
			remainder = dividend;
			return dividend;
		}
		DivModUnsigned(dividend._data, divisor._data, out var q, out var r);
		int num = r.Length - 1;
		while (num >= 0 && r[num] == 0)
		{
			num--;
		}
		if (num == -1)
		{
			remainder = Zero;
		}
		else
		{
			if (num < r.Length - 1)
			{
				Array.Resize(ref r, num + 1);
			}
			remainder = new BigInteger(dividend._sign, r);
		}
		num = q.Length - 1;
		while (num >= 0 && q[num] == 0)
		{
			num--;
		}
		if (num == -1)
		{
			return Zero;
		}
		if (num < q.Length - 1)
		{
			Array.Resize(ref q, num + 1);
		}
		return new BigInteger((short)(dividend._sign * divisor._sign), q);
	}

	public static BigInteger Pow(BigInteger value, int exponent)
	{
		if (exponent < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "exp must be >= 0");
		}
		switch (exponent)
		{
		case 0:
			return One;
		case 1:
			return value;
		default:
		{
			BigInteger one = One;
			while (exponent != 0)
			{
				if (((uint)exponent & (true ? 1u : 0u)) != 0)
				{
					one *= value;
				}
				if (exponent == 1)
				{
					break;
				}
				value *= value;
				exponent >>= 1;
			}
			return one;
		}
		}
	}

	public static BigInteger ModPow(BigInteger value, BigInteger exponent, BigInteger modulus)
	{
		if (exponent._sign == -1)
		{
			throw new ArgumentOutOfRangeException("exponent", "power must be >= 0");
		}
		if (modulus._sign == 0)
		{
			throw new DivideByZeroException();
		}
		BigInteger result = One % modulus;
		while (exponent._sign != 0)
		{
			if (!exponent.IsEven)
			{
				result *= value;
				result %= modulus;
			}
			if (exponent.IsOne)
			{
				break;
			}
			value *= value;
			value %= modulus;
			exponent >>= 1;
		}
		return result;
	}

	public static BigInteger GreatestCommonDivisor(BigInteger left, BigInteger right)
	{
		if (left._sign != 0 && left._data.Length == 1 && left._data[0] == 1)
		{
			return One;
		}
		if (right._sign != 0 && right._data.Length == 1 && right._data[0] == 1)
		{
			return One;
		}
		if (left.IsZero)
		{
			return Abs(right);
		}
		if (right.IsZero)
		{
			return Abs(left);
		}
		BigInteger bigInteger = new BigInteger(1, left._data);
		BigInteger bigInteger2 = new BigInteger(1, right._data);
		BigInteger bigInteger3 = bigInteger2;
		while (bigInteger._data.Length > 1)
		{
			bigInteger3 = bigInteger;
			bigInteger = bigInteger2 % bigInteger;
			bigInteger2 = bigInteger3;
		}
		if (bigInteger.IsZero)
		{
			return bigInteger3;
		}
		uint num = bigInteger._data[0];
		uint num2 = (uint)(bigInteger2 % num);
		int num3 = 0;
		while (((num2 | num) & 1) == 0)
		{
			num2 >>= 1;
			num >>= 1;
			num3++;
		}
		while (num2 != 0)
		{
			while ((num2 & 1) == 0)
			{
				num2 >>= 1;
			}
			while ((num & 1) == 0)
			{
				num >>= 1;
			}
			if (num2 >= num)
			{
				num2 = num2 - num >> 1;
			}
			else
			{
				num = num - num2 >> 1;
			}
		}
		return num << num3;
	}

	public static double Log(BigInteger value, double baseValue)
	{
		if (value._sign != -1 && baseValue != 1.0 && baseValue != -1.0 && baseValue != double.NegativeInfinity && !double.IsNaN(baseValue))
		{
			if (baseValue != 0.0 && baseValue != double.PositiveInfinity)
			{
				if (value._data == null)
				{
					return double.NegativeInfinity;
				}
				int num = value._data.Length - 1;
				int num2 = -1;
				int num3 = 31;
				while (num3 >= 0)
				{
					if ((value._data[num] & (1 << num3)) == 0L)
					{
						num3--;
						continue;
					}
					num2 = num3 + num * 32;
					break;
				}
				long num4 = num2;
				double num5 = 0.0;
				double num6 = 1.0;
				BigInteger one = One;
				long num7;
				for (num7 = num4; num7 > 2147483647L; num7 -= 2147483647L)
				{
					one <<= int.MaxValue;
				}
				one <<= (int)num7;
				for (long num8 = num4; num8 >= 0L; num8--)
				{
					if ((value & one)._sign != 0)
					{
						num5 += num6;
					}
					num6 *= 0.5;
					one >>= 1;
				}
				return (Math.Log(num5) + Math.Log(2.0) * (double)num4) / Math.Log(baseValue);
			}
			if (!value.IsOne)
			{
				return double.NaN;
			}
			return 0.0;
		}
		return double.NaN;
	}

	public static double Log(BigInteger value)
	{
		return Log(value, Math.E);
	}

	public static double Log10(BigInteger value)
	{
		return Log(value, 10.0);
	}

	[CLSCompliant(false)]
	public bool Equals(ulong other)
	{
		return CompareTo(other) == 0;
	}

	public override int GetHashCode()
	{
		uint num = (uint)(_sign * 16843009L);
		if (_data != null)
		{
			uint[] data = _data;
			foreach (uint num2 in data)
			{
				num ^= num2;
			}
		}
		return (int)num;
	}

	public static BigInteger Add(BigInteger left, BigInteger right)
	{
		return left + right;
	}

	public static BigInteger Subtract(BigInteger left, BigInteger right)
	{
		return left - right;
	}

	public static BigInteger Multiply(BigInteger left, BigInteger right)
	{
		return left * right;
	}

	public static BigInteger Divide(BigInteger dividend, BigInteger divisor)
	{
		return dividend / divisor;
	}

	public static BigInteger Remainder(BigInteger dividend, BigInteger divisor)
	{
		return dividend % divisor;
	}

	public static BigInteger Negate(BigInteger value)
	{
		return -value;
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		if (!(obj is BigInteger))
		{
			return -1;
		}
		return Compare(this, (BigInteger)obj);
	}

	public int CompareTo(BigInteger other)
	{
		return Compare(this, other);
	}

	[CLSCompliant(false)]
	public int CompareTo(ulong other)
	{
		if (_sign < 0)
		{
			return -1;
		}
		if (_sign == 0)
		{
			if (other != 0L)
			{
				return -1;
			}
			return 0;
		}
		if (_data.Length > 2)
		{
			return 1;
		}
		uint high = (uint)(other >> 32);
		uint low = (uint)other;
		return LongCompare(low, high);
	}

	private int LongCompare(uint low, uint high)
	{
		uint num = 0u;
		if (_data.Length > 1)
		{
			num = _data[1];
		}
		if (num > high)
		{
			return 1;
		}
		if (num < high)
		{
			return -1;
		}
		uint num2 = _data[0];
		if (num2 > low)
		{
			return 1;
		}
		if (num2 < low)
		{
			return -1;
		}
		return 0;
	}

	public int CompareTo(long other)
	{
		int sign = _sign;
		int num = Math.Sign(other);
		if (sign != num)
		{
			if (sign <= num)
			{
				return -1;
			}
			return 1;
		}
		if (sign == 0)
		{
			return 0;
		}
		if (_data.Length > 2)
		{
			return _sign;
		}
		if (other < 0L)
		{
			other = -other;
		}
		uint low = (uint)other;
		uint high = (uint)((ulong)other >> 32);
		int num2 = LongCompare(low, high);
		if (sign == -1)
		{
			num2 = -num2;
		}
		return num2;
	}

	public static int Compare(BigInteger left, BigInteger right)
	{
		int sign = left._sign;
		int sign2 = right._sign;
		if (sign != sign2)
		{
			if (sign <= sign2)
			{
				return -1;
			}
			return 1;
		}
		int num = CoreCompare(left._data, right._data);
		if (sign < 0)
		{
			num = -num;
		}
		return num;
	}

	private static int TopByte(uint x)
	{
		if ((x & 0xFFFF0000u) != 0)
		{
			if ((x & 0xFF000000u) != 0)
			{
				return 4;
			}
			return 3;
		}
		if ((x & 0xFF00u) != 0)
		{
			return 2;
		}
		return 1;
	}

	private static int FirstNonFfByte(uint word)
	{
		if ((word & 0xFF000000u) != 4278190080u)
		{
			return 4;
		}
		if ((word & 0xFF0000) != 16711680)
		{
			return 3;
		}
		if ((word & 0xFF00) != 65280)
		{
			return 2;
		}
		return 1;
	}

	public byte[] ToByteArray()
	{
		if (_sign == 0)
		{
			return new byte[1];
		}
		int num = (_data.Length - 1) * 4;
		bool flag = false;
		uint num2 = _data[_data.Length - 1];
		int num3;
		if (_sign == 1)
		{
			num3 = TopByte(num2);
			uint num4 = (uint)(128 << (num3 - 1) * 8);
			if ((num2 & num4) != 0)
			{
				flag = true;
			}
		}
		else
		{
			num3 = TopByte(num2);
		}
		byte[] array = new byte[num + num3 + (flag ? 1 : 0)];
		if (_sign == 1)
		{
			int num5 = 0;
			int num6 = _data.Length - 1;
			for (int i = 0; i < num6; i++)
			{
				uint num7 = _data[i];
				array[num5++] = (byte)num7;
				array[num5++] = (byte)(num7 >> 8);
				array[num5++] = (byte)(num7 >> 16);
				array[num5++] = (byte)(num7 >> 24);
			}
			while (num3-- > 0)
			{
				array[num5++] = (byte)num2;
				num2 >>= 8;
			}
		}
		else
		{
			int num8 = 0;
			int num9 = _data.Length - 1;
			uint num10 = 1u;
			uint num11;
			for (int j = 0; j < num9; j++)
			{
				num11 = _data[j];
				long num12 = (long)(~num11) + (long)num10;
				num11 = (uint)num12;
				num10 = (uint)((ulong)num12 >> 32);
				array[num8++] = (byte)num11;
				array[num8++] = (byte)(num11 >> 8);
				array[num8++] = (byte)(num11 >> 16);
				array[num8++] = (byte)(num11 >> 24);
			}
			long num13 = (long)(~num2) + (long)num10;
			num11 = (uint)num13;
			if ((int)((ulong)num13 >> 32) == 0)
			{
				int num14 = FirstNonFfByte(num11);
				bool flag2 = (num11 & (1 << num14 * 8 - 1)) == 0L;
				int num15 = num14 + (flag2 ? 1 : 0);
				if (num15 != num3)
				{
					Array.Resize(ref array, num + num15);
				}
				while (num14-- > 0)
				{
					array[num8++] = (byte)num11;
					num11 >>= 8;
				}
				if (flag2)
				{
					array[num8++] = byte.MaxValue;
				}
			}
			else
			{
				Array.Resize(ref array, num + 5);
				array[num8++] = (byte)num11;
				array[num8++] = (byte)(num11 >> 8);
				array[num8++] = (byte)(num11 >> 16);
				array[num8++] = (byte)(num11 >> 24);
				array[num8++] = byte.MaxValue;
			}
		}
		return array;
	}

	private static uint[] CoreAdd(uint[] a, uint[] b)
	{
		if (a.Length < b.Length)
		{
			uint[] array = a;
			a = b;
			b = array;
		}
		int num = a.Length;
		int num2 = b.Length;
		uint[] array2 = new uint[num];
		ulong num3 = 0uL;
		int i;
		for (i = 0; i < num2; i++)
		{
			num3 = num3 + a[i] + b[i];
			array2[i] = (uint)num3;
			num3 >>= 32;
		}
		for (; i < num; i++)
		{
			num3 += a[i];
			array2[i] = (uint)num3;
			num3 >>= 32;
		}
		if (num3 != 0L)
		{
			Array.Resize(ref array2, num + 1);
			array2[i] = (uint)num3;
		}
		return array2;
	}

	private static uint[] CoreSub(uint[] a, uint[] b)
	{
		int num = a.Length;
		int num2 = b.Length;
		uint[] array = new uint[num];
		ulong num3 = 0uL;
		int i;
		for (i = 0; i < num2; i++)
		{
			num3 = (ulong)((long)a[i] - (long)b[i]) - num3;
			array[i] = (uint)num3;
			num3 = (num3 >> 32) & 1uL;
		}
		for (; i < num; i++)
		{
			num3 = a[i] - num3;
			array[i] = (uint)num3;
			num3 = (num3 >> 32) & 1uL;
		}
		i = num - 1;
		while (i >= 0 && array[i] == 0)
		{
			i--;
		}
		if (i < num - 1)
		{
			Array.Resize(ref array, i + 1);
		}
		return array;
	}

	private static uint[] CoreAdd(uint[] a, uint b)
	{
		int num = a.Length;
		uint[] array = new uint[num];
		ulong num2 = b;
		int i;
		for (i = 0; i < num; i++)
		{
			num2 += a[i];
			array[i] = (uint)num2;
			num2 >>= 32;
		}
		if (num2 != 0L)
		{
			Array.Resize(ref array, num + 1);
			array[i] = (uint)num2;
		}
		return array;
	}

	private static uint[] CoreSub(uint[] a, uint b)
	{
		int num = a.Length;
		uint[] array = new uint[num];
		ulong num2 = b;
		int i;
		for (i = 0; i < num; i++)
		{
			num2 = a[i] - num2;
			array[i] = (uint)num2;
			num2 = (num2 >> 32) & 1uL;
		}
		i = num - 1;
		while (i >= 0 && array[i] == 0)
		{
			i--;
		}
		if (i < num - 1)
		{
			Array.Resize(ref array, i + 1);
		}
		return array;
	}

	private static int CoreCompare(uint[] a, uint[] b)
	{
		int num = ((a != null) ? a.Length : 0);
		int num2 = ((b != null) ? b.Length : 0);
		if (num > num2)
		{
			return 1;
		}
		if (num2 > num)
		{
			return -1;
		}
		int num3 = num - 1;
		while (true)
		{
			if (num3 >= 0)
			{
				uint num4 = a[num3];
				uint num5 = b[num3];
				if (num4 <= num5)
				{
					if (num4 < num5)
					{
						break;
					}
					num3--;
					continue;
				}
				return 1;
			}
			return 0;
		}
		return -1;
	}

	private static int GetNormalizeShift(uint value)
	{
		int num = 0;
		if ((value & 0xFFFF0000u) == 0)
		{
			value <<= 16;
			num += 16;
		}
		if ((value & 0xFF000000u) == 0)
		{
			value <<= 8;
			num += 8;
		}
		if ((value & 0xF0000000u) == 0)
		{
			value <<= 4;
			num += 4;
		}
		if ((value & 0xC0000000u) == 0)
		{
			value <<= 2;
			num += 2;
		}
		if ((value & 0x80000000u) == 0)
		{
			value <<= 1;
			num++;
		}
		return num;
	}

	private static void Normalize(uint[] u, int l, uint[] un, int shift)
	{
		uint num = 0u;
		int i;
		if (shift > 0)
		{
			int num2 = 32 - shift;
			for (i = 0; i < l; i++)
			{
				uint num3 = u[i];
				un[i] = (num3 << shift) | num;
				num = num3 >> num2;
			}
		}
		else
		{
			for (i = 0; i < l; i++)
			{
				un[i] = u[i];
			}
		}
		while (i < un.Length)
		{
			un[i++] = 0u;
		}
		if (num != 0)
		{
			un[l] = num;
		}
	}

	private static void Unnormalize(uint[] un, out uint[] r, int shift)
	{
		int num = un.Length;
		r = new uint[num];
		if (shift > 0)
		{
			int num2 = 32 - shift;
			uint num3 = 0u;
			for (int num4 = num - 1; num4 >= 0; num4--)
			{
				uint num5 = un[num4];
				r[num4] = (num5 >> shift) | num3;
				num3 = num5 << num2;
			}
		}
		else
		{
			for (int i = 0; i < num; i++)
			{
				r[i] = un[i];
			}
		}
	}

	private static void DivModUnsigned(uint[] u, uint[] v, out uint[] q, out uint[] r)
	{
		int num = u.Length;
		int num2 = v.Length;
		if (num2 <= 1)
		{
			ulong num3 = 0uL;
			uint num4 = v[0];
			q = new uint[num];
			r = new uint[1];
			for (int num5 = num - 1; num5 >= 0; num5--)
			{
				num3 *= 4294967296L;
				num3 += u[num5];
				ulong num6 = num3 / num4;
				num3 -= num6 * num4;
				q[num5] = (uint)num6;
			}
			r[0] = (uint)num3;
		}
		else if (num >= num2)
		{
			int normalizeShift = GetNormalizeShift(v[num2 - 1]);
			uint[] array = new uint[num + 1];
			uint[] array2 = new uint[num2];
			Normalize(u, num, array, normalizeShift);
			Normalize(v, num2, array2, normalizeShift);
			q = new uint[num - num2 + 1];
			r = null;
			for (int num7 = num - num2; num7 >= 0; num7--)
			{
				ulong num8 = (ulong)(4294967296L * (long)array[num7 + num2] + array[num7 + num2 - 1]);
				ulong num9 = num8 / array2[num2 - 1];
				num8 -= num9 * array2[num2 - 1];
				while (num9 >= 4294967296L || num9 * array2[num2 - 2] > num8 * 4294967296L + array[num7 + num2 - 2])
				{
					num9--;
					num8 += array2[num2 - 1];
					if (num8 >= 4294967296L)
					{
						break;
					}
				}
				long num10 = 0L;
				long num11 = 0L;
				for (int i = 0; i < num2; i++)
				{
					ulong num12 = array2[i] * num9;
					num11 = (long)array[i + num7] - (long)(uint)num12 - num10;
					array[i + num7] = (uint)num11;
					num12 >>= 32;
					num11 >>= 32;
					num10 = (long)num12 - num11;
				}
				num11 = array[num7 + num2] - num10;
				array[num7 + num2] = (uint)num11;
				q[num7] = (uint)num9;
				if (num11 < 0L)
				{
					q[num7]--;
					ulong num13 = 0uL;
					for (int i = 0; i < num2; i++)
					{
						num13 = (ulong)((long)array2[i] + (long)array[num7 + i]) + num13;
						array[num7 + i] = (uint)num13;
						num13 >>= 32;
					}
					num13 += array[num7 + num2];
					array[num7 + num2] = (uint)num13;
				}
			}
			Unnormalize(array, out r, normalizeShift);
		}
		else
		{
			q = new uint[1];
			r = u;
		}
	}
}
