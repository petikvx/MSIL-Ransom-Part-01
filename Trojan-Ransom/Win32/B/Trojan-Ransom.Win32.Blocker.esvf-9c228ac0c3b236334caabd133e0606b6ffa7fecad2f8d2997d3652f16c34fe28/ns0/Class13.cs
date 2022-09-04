using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class13 : Interface0
{
	private static readonly uint uint_0 = 65521u;

	private uint uint_1;

	public Class13()
	{
		imethod_1();
	}

	[SpecialName]
	public long imethod_0()
	{
		try
		{
			return uint_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public void imethod_1()
	{
		try
		{
			uint_1 = 1u;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public void imethod_2(int int_0)
	{
		uint num = default(uint);
		uint num2 = default(uint);
		try
		{
			num = uint_1 & 0xFFFFu;
			num2 = uint_1 >> 16;
			num = (uint)((int)num + (int_0 & 0xFF)) % uint_0;
			num2 = (num + num2) % uint_0;
			uint_1 = (num2 << 16) + num;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, int_0, num, num2);
			throw;
		}
	}

	public void imethod_3(byte[] byte_0)
	{
		try
		{
			imethod_4(byte_0, 0, byte_0.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_0);
			throw;
		}
	}

	public void imethod_4(byte[] byte_0, int int_0, int int_1)
	{
		uint num = default(uint);
		uint num2 = default(uint);
		int num3 = default(int);
		try
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException(Class40.smethod_0(792944037, 1417940916, 1342547230));
			}
			if (int_0 >= 0 && int_1 >= 0 && int_0 + int_1 <= byte_0.Length)
			{
				num = uint_1 & 0xFFFFu;
				num2 = uint_1 >> 16;
				while (int_1 > 0)
				{
					num3 = 3800;
					if (num3 > int_1)
					{
						num3 = int_1;
					}
					int_1 -= num3;
					while (--num3 >= 0)
					{
						num += (uint)(byte_0[int_0++] & 0xFF);
						num2 += num;
					}
					num %= uint_0;
					num2 %= uint_0;
				}
				uint_1 = (num2 << 16) | num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, this, byte_0, int_0, int_1, num, num2, num3);
			throw;
		}
	}
}
