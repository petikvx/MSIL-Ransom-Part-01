using System;
using System.IO;
using System.Runtime.CompilerServices;

internal static class _0023_003Dqhnburg5a7k29DlsumE4_t4I3wibteH7BSVWTifsa7F8_003D
{
	private static readonly uint[] _0023_003DzizBjOuE_003D;

	static _0023_003Dqhnburg5a7k29DlsumE4_t4I3wibteH7BSVWTifsa7F8_003D()
	{
		uint[] array = new uint[5];
		if (7u != 0)
		{
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		}
		if (2u != 0)
		{
			_0023_003DzizBjOuE_003D = array;
		}
	}

	public static byte[] _0023_003Dz1sZ_inu3P54N3j4CYi4kLr6vacTSbEInvcHzPz4_003D(string _0023_003DzizBjOuE_003D)
	{
		if (_0023_003DzizBjOuE_003D == null)
		{
			throw new Exception();
		}
		MemoryStream memoryStream = new MemoryStream(_0023_003DzizBjOuE_003D.Length * 4 / 5);
		MemoryStream memoryStream2;
		if (2u != 0)
		{
			memoryStream2 = memoryStream;
		}
		try
		{
			int num;
			if (4u != 0)
			{
				num = 0;
			}
			uint num2;
			if (uint.MaxValue != 0)
			{
				num2 = 0u;
			}
			foreach (char c in _0023_003DzizBjOuE_003D)
			{
				if (c == 'z' && num == 0)
				{
					_0023_003Dz3j3xya9_d815WvCSBKcuafY_003D(memoryStream2, num2, 0);
					continue;
				}
				if (c < '!' || c > 'u')
				{
					throw new Exception();
				}
				checked
				{
					num2 += (uint)(unchecked((long)_0023_003Dqhnburg5a7k29DlsumE4_t4I3wibteH7BSVWTifsa7F8_003D._0023_003DzizBjOuE_003D[num]) * unchecked((long)checked(unchecked((int)c) - 33)));
				}
				num++;
				if (num == 5)
				{
					_0023_003Dz3j3xya9_d815WvCSBKcuafY_003D(memoryStream2, num2, 0);
					num = 0;
					num2 = 0u;
				}
			}
			if (num == 1)
			{
				throw new Exception();
			}
			if (num > 1)
			{
				for (int j = num; j < 5; j++)
				{
					num2 = checked(num2 + 84u * _0023_003Dqhnburg5a7k29DlsumE4_t4I3wibteH7BSVWTifsa7F8_003D._0023_003DzizBjOuE_003D[j]);
				}
				_0023_003Dz3j3xya9_d815WvCSBKcuafY_003D(memoryStream2, num2, 5 - num);
			}
			return memoryStream2.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream2).Dispose();
		}
	}

	private static void _0023_003Dz3j3xya9_d815WvCSBKcuafY_003D(Stream _0023_003DzizBjOuE_003D, uint _0023_003DzYtBeqWc_003D, int _0023_003Dzfze_RqI_003D)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		_ = 5;
		if (false)
		{
		}
		_0023_003DzizBjOuE_003D.WriteByte((byte)(_0023_003DzYtBeqWc_003D >> 24));
		_ = 7;
		if (8 == 0)
		{
		}
		if (_0023_003Dzfze_RqI_003D == 3)
		{
			return;
		}
		_0023_003DzizBjOuE_003D.WriteByte((byte)((_0023_003DzYtBeqWc_003D >> 16) & 0xFFu));
		if (_0023_003Dzfze_RqI_003D != 2)
		{
			_0023_003DzizBjOuE_003D.WriteByte((byte)((_0023_003DzYtBeqWc_003D >> 8) & 0xFFu));
			if (_0023_003Dzfze_RqI_003D != 1)
			{
				_0023_003DzizBjOuE_003D.WriteByte((byte)(_0023_003DzYtBeqWc_003D & 0xFFu));
			}
		}
	}
}
