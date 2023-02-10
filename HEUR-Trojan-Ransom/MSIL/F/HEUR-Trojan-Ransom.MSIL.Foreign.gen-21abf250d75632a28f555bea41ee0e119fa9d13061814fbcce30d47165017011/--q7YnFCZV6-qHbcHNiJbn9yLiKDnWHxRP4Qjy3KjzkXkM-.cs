using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

internal static class _0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D
{
	private sealed class _0002_200A_2008_2007_2009_2006_2001_2007_2002_2005_2005_2002_2005_200B_2002
	{
		private Stream _0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2;

		private byte[] _0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V;

		public _0002_200A_2008_2007_2009_2006_2001_2007_2002_2005_2005_2002_2005_200B_2002(Stream _0023_003DzzFTRp_sjNejNiflJWFU_0024_e9BQ6Iw)
		{
			if (7u != 0)
			{
				_0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2 = _0023_003DzzFTRp_sjNejNiflJWFU_0024_e9BQ6Iw;
			}
			byte[] array = new byte[4];
			if (3u != 0)
			{
				_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V = array;
			}
		}

		public Stream _0023_003DzZOSOCkaqt5CSwXhJmmukfSsH878R()
		{
			_ = 8;
			if (2 == 0)
			{
			}
			return _0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2;
		}

		public short _0023_003DzPQkHRPPAAy0yuBY_0024MAA2xosxVWkH()
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DzZFpEcWE7IYep2zxK95UGh_002489BzGb(2);
			}
			return (short)(_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[0] | (_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[1] << 8));
		}

		public int _0023_003Dzpvq6UnmEmdriCm_00246GEq3fx11Magq()
		{
			if (7u != 0)
			{
				_0023_003DzZFpEcWE7IYep2zxK95UGh_002489BzGb(4);
			}
			return _0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[0] | (_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[1] << 8) | (_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[2] << 16) | (_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[3] << 24);
		}

		private void _0023_003DzJUmtlTqMr_0024Nm_rJxsz7qgCY_003D()
		{
			throw new EndOfStreamException();
		}

		private void _0023_003DzZFpEcWE7IYep2zxK95UGh_002489BzGb(int _0023_003DzU6XzpYpvCdjqSAjxjccv_0024neviDdY)
		{
			int num;
			if (5u != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			if (0 == 0)
			{
				num2 = 0;
			}
			if (_0023_003DzU6XzpYpvCdjqSAjxjccv_0024neviDdY == 1)
			{
				int num3 = _0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2.ReadByte();
				if (0 == 0)
				{
					num2 = num3;
				}
				if (num2 == -1)
				{
					_0023_003DzJUmtlTqMr_0024Nm_rJxsz7qgCY_003D();
				}
				_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = _0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2.Read(_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V, num, _0023_003DzU6XzpYpvCdjqSAjxjccv_0024neviDdY - num);
				if (num2 == 0)
				{
					_0023_003DzJUmtlTqMr_0024Nm_rJxsz7qgCY_003D();
				}
				num += num2;
			}
			while (num < _0023_003DzU6XzpYpvCdjqSAjxjccv_0024neviDdY);
		}

		public void _0023_003DzQ2nUoz27rnBR_lnPLxDiBYoJo0Yl()
		{
			Stream stream = _0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2;
			Stream stream2;
			if (4u != 0)
			{
				stream2 = stream;
			}
			if (5u != 0)
			{
				_0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2 = null;
			}
			stream2?.Close();
			if (true)
			{
				_0023_003Dz7LVbvgKnR34c_UhYKbuFAbA68H0V = null;
			}
		}

		public byte[] _0023_003DzFNoEoWzTpDfje34kMmrxK2I_hp9J(int _0023_003DzsVOegKcAwPDtEIiBf8Tqios_003D)
		{
			if (_0023_003DzsVOegKcAwPDtEIiBf8Tqios_003D < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0023_003DzsVOegKcAwPDtEIiBf8Tqios_003D];
			byte[] array2;
			if (uint.MaxValue != 0)
			{
				array2 = array;
			}
			int num;
			if (true)
			{
				num = 0;
			}
			do
			{
				int num2 = _0023_003DzEtY_0024R16h9qwKP_botrTsAFik6if2.Read(array2, num, _0023_003DzsVOegKcAwPDtEIiBf8Tqios_003D);
				int num3;
				if (7u != 0)
				{
					num3 = num2;
				}
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				_0023_003DzsVOegKcAwPDtEIiBf8Tqios_003D -= num3;
			}
			while (_0023_003DzsVOegKcAwPDtEIiBf8Tqios_003D > 0);
			if (num != array2.Length)
			{
				byte[] array3 = new byte[num];
				Buffer.BlockCopy(array2, 0, array3, 0, num);
				array2 = array3;
			}
			return array2;
		}
	}

	private enum _0005_200A_2001_2000_200B_200B_2002_2008_2000_2003_200A_2002_2007_2004_2003_2006_2001_2006
	{

	}

	internal sealed class _0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003
	{
		private struct _0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB
		{
			public int _0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk4;

			public string _0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm;
		}

		private _0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] _0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX;

		private int _0023_003Dz58N59kHPWq2K5zXC0oj3Ce3GHdxL;

		public _0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003()
		{
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array = new _0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[16];
			if (5u != 0)
			{
				_0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX = array;
			}
		}

		public _0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003(int _0023_003DzbSZ93C6VIzHaLjdLsWojeAMDSadX)
		{
			int num;
			if (2u != 0)
			{
				num = 16;
			}
			int num2 = _0023_003DzbSZ93C6VIzHaLjdLsWojeAMDSadX << 1;
			if (4u != 0)
			{
				_0023_003DzbSZ93C6VIzHaLjdLsWojeAMDSadX = num2;
			}
			while (num < _0023_003DzbSZ93C6VIzHaLjdLsWojeAMDSadX && num > 0)
			{
				int num3 = num << 1;
				if (6u != 0)
				{
					num = num3;
				}
			}
			if (num < 0)
			{
				num = 16;
			}
			_0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX = new _0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[num];
		}

		public int _0023_003DzmQ0Lq2hh_0024AY8oSDuym_0024Vitvl5OZn()
		{
			_ = 7;
			if (5 == 0)
			{
			}
			return _0023_003Dz58N59kHPWq2K5zXC0oj3Ce3GHdxL;
		}

		private void _0023_003DzHZBsC4_0024pfrHlNauz7YRVZZ8qloee()
		{
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array = _0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX;
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array2;
			if (3u != 0)
			{
				array2 = array;
			}
			int num = array2.Length;
			int num2;
			if (5u != 0)
			{
				num2 = num;
			}
			int num3 = num2 * 2;
			int num4;
			if (uint.MaxValue != 0)
			{
				num4 = num3;
			}
			if (num4 <= 0)
			{
				return;
			}
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array3 = new _0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[num4];
			int num5 = 0;
			for (int i = 0; i < num2; i++)
			{
				string _0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm = array2[i]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm;
				if (_0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm == null)
				{
					continue;
				}
				int _0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk = array2[i]._0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk4;
				int num6 = _0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk & (num4 - 1);
				while (array3[num6]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm != null)
				{
					num6++;
					if (num6 >= num4)
					{
						num6 = 0;
					}
				}
				array3[num6]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm = _0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm;
				array3[num6]._0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk4 = _0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk;
				num5++;
			}
			_0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX = array3;
			_0023_003Dz58N59kHPWq2K5zXC0oj3Ce3GHdxL = num5;
		}

		public string _0023_003Dzod3Eo1k_003D(int _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn)
		{
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array = _0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX;
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array2;
			if (true)
			{
				array2 = array;
			}
			int num = array2.Length;
			int num2;
			if (5u != 0)
			{
				num2 = num;
			}
			int num3 = _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn & (num2 - 1);
			int num4;
			if (3u != 0)
			{
				num4 = num3;
			}
			string result = null;
			while (true)
			{
				if (array2[num4]._0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk4 == _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn)
				{
					result = array2[num4]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm;
					break;
				}
				if (array2[num4]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm == null)
				{
					break;
				}
				num4++;
				if (num4 >= num2)
				{
					num4 = 0;
				}
			}
			return result;
		}

		public void _0023_003DzqYWbtzA_003D(int _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn, string _0023_003DzukzltnCFw65Dt69f_T_V0aOdGLYt)
		{
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array = _0023_003Dz8PcSQi7drXjZC_nHZa7dwdEnRodX;
			_0023_003Dz39vAzQ_g4wzSsbfvZJoRKMxfMnUB[] array2;
			if (3u != 0)
			{
				array2 = array;
			}
			int num = array2.Length;
			int num2;
			if (3u != 0)
			{
				num2 = num;
			}
			int num3 = num2 >> 1;
			int num4 = default(int);
			if (0 == 0)
			{
				num4 = num3;
			}
			int num5 = _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn & (num2 - 1);
			bool flag;
			while (true)
			{
				int _0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk = array2[num5]._0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk4;
				flag = array2[num5]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm == null;
				if (_0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk == _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn || flag)
				{
					break;
				}
				num5++;
				if (num5 >= num2)
				{
					num5 = 0;
				}
			}
			array2[num5]._0023_003DzxBq2zinBgWkutkklw3nUHjGL8JNm = _0023_003DzukzltnCFw65Dt69f_T_V0aOdGLYt;
			if (flag)
			{
				array2[num5]._0023_003DzL7fA9NkiAxWhnDUhg1UHRwxiNjk4 = _0023_003DztZ3TURMRdgUUbQp6G0t4_DdaXsKn;
				_0023_003Dz58N59kHPWq2K5zXC0oj3Ce3GHdxL++;
				if (_0023_003Dz58N59kHPWq2K5zXC0oj3Ce3GHdxL > num4)
				{
					_0023_003DzHZBsC4_0024pfrHlNauz7YRVZZ8qloee();
				}
			}
		}
	}

	private static _0005_200A_2001_2000_200B_200B_2002_2008_2000_2003_200A_2002_2007_2004_2003_2006_2001_2006 _0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9;

	private static short _0023_003DzkN7_0024qfdPO8XAOA6a3zeli7jfoaar;

	private static byte[] _0023_003Dzxn_JyhtCl9KNaWELQCGaUS271MPM;

	private static int _0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge;

	private static int _0023_003DzMOln3XBtboqKEYQiL_6k__s_003D;

	private static byte[] _0023_003DzvP4_j7yQgSPkEsoClZww_UKFRx1C;

	private static _0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003 _0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm;

	private static _0002_200A_2008_2007_2009_2006_2001_2007_2002_2005_2005_2002_2005_200B_2002 _0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D;

	private static int _0023_003DzBJT4a7tSv_0024wHGFfFEW1IiZab10GT;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D()
	{
		int num = default(int);
		if (0 == 0)
		{
			num = -371427405;
		}
		int num2 = num + -666367684;
		int num3;
		if (2u != 0)
		{
			num3 = num2;
		}
		_0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003 obj = new _0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003((-737736466 ^ num) + num3);
		if (8u != 0)
		{
			_0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm = obj;
		}
		int num4;
		if (8u != 0)
		{
			num4 = 2;
		}
		StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
		StackTrace stackTrace2;
		if (true)
		{
			stackTrace2 = stackTrace;
		}
		int num5 = num4 - 2;
		if (4u != 0)
		{
			num4 = num5;
		}
		StackFrame frame = stackTrace2.GetFrame(num4);
		int num6 = num4;
		if (frame == null)
		{
			stackTrace2 = new StackTrace();
			num6 = 1;
			frame = stackTrace2.GetFrame(num6);
		}
		int num7 = ~(-(~(-(-(~(~(-(~((-1903592725 - num) ^ num3))))))))) ^ -(~(~(-(-(~(~(-(~(-(~(num + 1095018872 + num3)))))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num7 ^= ~(-(~(-(-(~(-(~(~(-(~(-960690014 ^ num ^ num3)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			_0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9 = (_0005_200A_2001_2000_200B_200B_2002_2008_2000_2003_200A_2002_2007_2004_2003_2006_2001_2006)4 | _0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9;
			num7 ^= -1409221687 - num - num3 + num4;
		}
		else if ((object)type == null)
		{
			if (_0023_003Dzi9oKfa7igPwIP2cmkLnZdHxWuBH2(stackTrace2, num6))
			{
				num7 ^= -(~(-(~(~(-(~(-(-(~(~((1409198912 + num) ^ num3))))))))))) - num4;
				_0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9 |= (_0005_200A_2001_2000_200B_200B_2002_2008_2000_2003_200A_2002_2007_2004_2003_2006_2001_2006)16;
			}
			else
			{
				_0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9 |= (_0005_200A_2001_2000_200B_200B_2002_2008_2000_2003_200A_2002_2007_2004_2003_2006_2001_2006)1;
				num7 ^= -(~(-(~(-(~(~(-(~(-1409259539 - num - num3)))))))));
			}
		}
		else
		{
			_0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9 = (_0005_200A_2001_2000_200B_200B_2002_2008_2000_2003_200A_2002_2007_2004_2003_2006_2001_2006)16 | _0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9;
			num7 ^= -(~(~(-(~(-(~(-(~((num + 1409198915) ^ num3))))))))) - num4;
		}
		_0023_003DzMOln3XBtboqKEYQiL_6k__s_003D = num7 + _0023_003DzMOln3XBtboqKEYQiL_6k__s_003D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0023_003DzzgwDXrs_003D(int _0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE)
	{
		_0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003 obj = _0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm;
		_0006_2003_200A_2003_2001_2003_2002_2007_2008_2008_2007_2009_2008_200B_2004_2008_2004_200B_2006_2009_2008_2008_2008_200B_200A_2000_2000_200B_2002_2003 obj2;
		if (2u != 0)
		{
			obj2 = obj;
		}
		if (4u != 0)
		{
			Monitor.Enter(obj2);
		}
		try
		{
			string text = _0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm._0023_003Dzod3Eo1k_003D(_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE);
			string text2 = default(string);
			if (0 == 0)
			{
				text2 = text;
			}
			if (text2 != null)
			{
				return text2;
			}
			return _0023_003DzXm18_00245xEcxw_0024IkSV3_00241kFFw_003D(_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE, _0023_003Dznd0k0JOCTYTYt_0024yGQMGRYjHPJADU: true);
		}
		finally
		{
			Monitor.Exit(obj2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _0023_003DzXm18_00245xEcxw_0024IkSV3_00241kFFw_003D(int _0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE, bool _0023_003Dznd0k0JOCTYTYt_0024yGQMGRYjHPJADU)
	{
		int num;
		if (3u != 0)
		{
			num = 1817122849;
		}
		int num2 = num ^ -2122023770;
		int num3 = default(int);
		if (0 == 0)
		{
			num3 = num2;
		}
		string text;
		if (2u != 0)
		{
			text = null;
		}
		byte[] array;
		int num22;
		while (true)
		{
			int num11;
			if (_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D == null)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly assembly;
				if (uint.MaxValue != 0)
				{
					assembly = executingAssembly;
				}
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				Assembly assembly2;
				if (uint.MaxValue != 0)
				{
					assembly2 = callingAssembly;
				}
				int num4 = _0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge | (num + -2120950040 - num3);
				if (uint.MaxValue != 0)
				{
					_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge = num4;
				}
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2;
				if (4u != 0)
				{
					stringBuilder2 = stringBuilder;
				}
				int num5 = (974609574 - num) ^ num3;
				int num6;
				if (true)
				{
					num6 = num5;
				}
				stringBuilder2.Append((char)(num6 >> 16)).Append((char)num6);
				int num7 = (num ^ 0x61819CAB) - num3;
				if (7u != 0)
				{
					num6 = num7;
				}
				stringBuilder2.Append((char)(num6 >> 16)).Append((char)num6);
				num6 = -974216349 + num + num3;
				stringBuilder2.Append((char)num6).Append((char)(num6 >> 16));
				num6 = 2049219761 - num - num3;
				stringBuilder2.Append((char)num6).Append((char)(num6 >> 16));
				num6 = num ^ -1585029969 ^ num3;
				stringBuilder2.Append((char)num6).Append((char)(num6 >> 16));
				num6 = -1635134566 - num + num3;
				stringBuilder2.Append((char)num6).Append((char)(num6 >> 16));
				num6 = -1585157012 + num - num3;
				stringBuilder2.Append((char)num6).Append((char)(num6 >> 16));
				Stream manifestResourceStream = assembly.GetManifestResourceStream(stringBuilder2.ToString());
				int num8 = 2;
				StackTrace stackTrace = new StackTrace(num8, fNeedFileInfo: false);
				_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge ^= ((1511691746 - num) ^ num3) | num8;
				num8 -= 2;
				StackFrame frame = stackTrace.GetFrame(num8);
				int num9 = num8;
				if (frame == null)
				{
					stackTrace = new StackTrace();
					num9 = 1;
					frame = stackTrace.GetFrame(num9);
				}
				MethodBase methodBase = frame?.GetMethod();
				_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge ^= num8 + (num + -2122560282 - num3);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge ^= (0x7E78EC0D ^ num) + num3;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge ^= (1511685192 - num) ^ num3;
				if (!flag)
				{
					flag = (object)type == null;
					if (flag)
					{
						if (_0023_003Dzi9oKfa7igPwIP2cmkLnZdHxWuBH2(stackTrace, num9))
						{
							flag = false;
						}
						else
						{
							_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge ^= (num ^ 0x7E78EC2D) + num3;
						}
					}
				}
				if (flag == (stackTrace != null))
				{
					_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge = 0x20 ^ _0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge;
				}
				_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge ^= (-2122553908 + num - num3) | (1 + num8);
				_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D = new _0002_200A_2008_2007_2009_2006_2001_2007_2002_2005_2005_2002_2005_200B_2002(manifestResourceStream);
				short num10 = (short)(_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzPQkHRPPAAy0yuBY_0024MAA2xosxVWkH() ^ (short)(~(-(~(-(-(~(~(-(-(~(~((1511668214 - num) ^ num3)))))))))))));
				if (num10 == 0)
				{
					_0023_003DzkN7_0024qfdPO8XAOA6a3zeli7jfoaar = (short)(_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzPQkHRPPAAy0yuBY_0024MAA2xosxVWkH() ^ (short)(~(-(~(-(-(~(~(-(-(~(~(-1511695930 + num + num3)))))))))))));
				}
				else
				{
					_0023_003DzvP4_j7yQgSPkEsoClZww_UKFRx1C = _0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzFNoEoWzTpDfje34kMmrxK2I_hp9J(num10);
				}
				assembly2 = assembly;
				AssemblyName _0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy = _0023_003DzfvyDTnKRJVOREEOqr85yiMG3tpNJ(assembly2);
				_0023_003Dzxn_JyhtCl9KNaWELQCGaUS271MPM = _0023_003DzSIWV_Sc2VI7iGuFk516kX_Mhop4I(_0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy);
				num11 = _0023_003DzMOln3XBtboqKEYQiL_6k__s_003D;
				_0023_003DzMOln3XBtboqKEYQiL_6k__s_003D = 0;
				num11 ^= -1123887284 - num - num3;
				long num12 = _0023_003DqgUBLdu6PsQ4m36jd6Pi6zlyxyOxUGWT9v4z0g_GcrKA_003D._0023_003DzzgwDXrs_003D();
				num11 ^= (int)num12;
				num11 ^= num + -592158251 + num3;
				int num13 = num11;
				int num14 = 0;
				int num15 = num13;
				int _0023_003DzgfHGZnM_003D = num15;
				global::_0023_003DqmoR_QRxuZr5vpAMSwCdU8tl9xDYBHPES1rGppF37ijo_003D<int> _0023_003DqmoR_QRxuZr5vpAMSwCdU8tl9xDYBHPES1rGppF37ijo_003D2 = ((global::_0023_003Dq75X_0024os1mTeER5rrihNE_lD5wCUoY_00244GSTZDKBwuejTY_003D<int>)new _0023_003DquCWDvrk37n4mroZ1kGTpkstmm1TaradZ1XoouB9tF0w_003D._0023_003DzizBjOuE_003D((-2122023772 ^ num) - num3)
				{
					_0023_003DzgfHGZnM_003D = _0023_003DzgfHGZnM_003D
				})._0023_003DzVL8jl5YhnfVGIoniM_0024izGig_00248dZqPAoRkYm8Ce_0024wPI8xYwQXvFNvmMRtUbPc7HmcmHp7DWg_003D();
				try
				{
					while (_0023_003DqmoR_QRxuZr5vpAMSwCdU8tl9xDYBHPES1rGppF37ijo_003D2._0023_003DzQdB07cEcKF1U1mV9dqbaOl4vyQW9MYM0bdgfoJktYD5kxeUHw5RPx1SEGxmdZvcGeg_003D_003D())
					{
						int num16 = _0023_003DqmoR_QRxuZr5vpAMSwCdU8tl9xDYBHPES1rGppF37ijo_003D2._0023_003DzOvEnsVSKl0b7KhzKmkHL2Rh9O8tduzK3G4S3Nk75CEOhJizH7xbq6_0024HOjXktF2j7vCqoba8_003D();
						num15 ^= num14 + num16;
						num14 += num15 >> 3;
					}
				}
				finally
				{
					_0023_003DqmoR_QRxuZr5vpAMSwCdU8tl9xDYBHPES1rGppF37ijo_003D2?._0023_003DzRcgJ4LSkpeeUMVcJJS7A3Z4vqfaL9OKE4ITvRuo3ocSYTsvb_jYKMnfEQI_XdiNjGRC0ZA9TZsUOTW4h6mZqM1w_003D();
				}
				int num17 = num15;
				int num18 = num17 ^ ((num + 622251415) ^ num3);
				num11 ^= ~(-(-(~(~(-(~(-(~(1925683703 - num - num3)))))))));
				int num19 = num18 * (1511690581 - num - num3) % (-1483943611 + num + num3);
				num11 = (_0023_003DzBJT4a7tSv_0024wHGFfFEW1IiZab10GT = num19 + num11);
				_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge = (_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge & (num ^ -1904507948 ^ num3)) ^ (2122567198 - num + num3);
				if (((uint)_0023_003Dz_0024L732Mm5j75PD_qBJVuwsrMJ3CW9 & (uint)(~(-(-(~(-(~(~(-(-(~(~((-1511685290 + num) ^ num3))))))))))))) == 0)
				{
					_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge = 1511729250 - num - num3;
				}
			}
			else
			{
				num11 = _0023_003DzBJT4a7tSv_0024wHGFfFEW1IiZab10GT;
			}
			if (_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge == -1511641326 + num + num3)
			{
				return new string(new char[3]
				{
					(char)(1511685376 - num - num3),
					'0',
					(char)(0x81847CFEu ^ (uint)num ^ (uint)num3)
				});
			}
			int num20 = _0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE ^ (num + 1280114924 + num3) ^ num11;
			num20 ^= -1814298097 - num - num3;
			_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzZOSOCkaqt5CSwXhJmmukfSsH878R().Position = num20;
			if (_0023_003DzvP4_j7yQgSPkEsoClZww_UKFRx1C != null)
			{
				array = _0023_003DzvP4_j7yQgSPkEsoClZww_UKFRx1C;
			}
			else
			{
				short num21 = ((_0023_003DzkN7_0024qfdPO8XAOA6a3zeli7jfoaar != -1) ? _0023_003DzkN7_0024qfdPO8XAOA6a3zeli7jfoaar : ((short)(_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzPQkHRPPAAy0yuBY_0024MAA2xosxVWkH() ^ (num ^ -2122052521 ^ num3) ^ num20)));
				if (num21 == 0)
				{
					array = null;
				}
				else
				{
					array = _0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzFNoEoWzTpDfje34kMmrxK2I_hp9J(num21);
					for (int i = 0; i != array.Length; i++)
					{
						array[i] ^= (byte)(_0023_003DzBJT4a7tSv_0024wHGFfFEW1IiZab10GT >> ((3 & i) << 3));
					}
				}
			}
			num22 = _0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003Dzpvq6UnmEmdriCm_00246GEq3fx11Magq() ^ num20 ^ -(~(-(~(~(-(-(~(~(num + 1806478216 + num3))))))))) ^ num11;
			if (num22 != ((2122560410 - num) ^ num3))
			{
				break;
			}
			byte[] array2 = _0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzFNoEoWzTpDfje34kMmrxK2I_hp9J(4);
			_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE = ((num ^ 0x444B2479) - num3) ^ num11;
			_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE;
			string text2 = _0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm._0023_003Dzod3Eo1k_003D(_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE);
			if (3u != 0)
			{
				text = text2;
			}
			if (text != null)
			{
				return text;
			}
		}
		bool flag2 = (num22 & ((-635798360 - num) ^ num3)) != 0;
		bool flag3 = (num22 & ((0x3E7B8358 ^ num) + num3)) != 0;
		bool flag4 = (num22 & ((974814376 - num) ^ num3)) != 0;
		num22 &= (num ^ -1853588313) - num3;
		byte[] array3 = array;
		byte[] array4 = _0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzFNoEoWzTpDfje34kMmrxK2I_hp9J(num22);
		byte[] array5 = array3;
		byte b = array5[1];
		int num23 = array4.Length;
		byte b2 = (byte)((11 + num23) ^ (b + 7));
		uint num24 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		ushort num25 = 0;
		for (int num26 = 0; num26 < num23; num26 = 1 + num26)
		{
			if ((1 & num26) == 0)
			{
				num24 = (uint)((int)num24 * (-1511471275 + num + num3) + (-2120031643 ^ num ^ num3));
				num25 = (ushort)(num24 >> 16);
			}
			byte b3 = (byte)num25;
			num25 = (ushort)(num25 >> 8);
			byte b4 = array4[num26];
			array4[num26] = (byte)(b4 ^ b ^ (b2 + 3) ^ b3);
			b2 = b4;
		}
		byte[] array6 = array4;
		if (_0023_003Dzxn_JyhtCl9KNaWELQCGaUS271MPM != null != (_0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge != 2124168224 - num + num3))
		{
			for (int num27 = 0; num27 < num22; num27 = 1 + num27)
			{
				byte b5 = _0023_003Dzxn_JyhtCl9KNaWELQCGaUS271MPM[num27 & 7];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[num27] = (byte)(array6[num27] ^ b5);
			}
		}
		int num28 = _0023_003DzYB47RbMtJ9bLuMB4Jpsit6XA8_0024Ge - 12;
		byte[] array7;
		int num29;
		if (!flag3)
		{
			array7 = array6;
			num29 = num22;
		}
		else
		{
			num29 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num29];
			_0023_003DzPwyIVovxJwO_umOXSaGpuKwmDQMJ(array6, 4, array7);
		}
		if (flag2 && num28 == ((num + -2122001188) ^ num3))
		{
			char[] array8 = new char[num29];
			for (int j = 0; j < num29; j++)
			{
				array8[j] = (char)array7[j];
			}
			text = new string(array8);
		}
		else
		{
			text = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num28 += (-2122023641 ^ num) - num3 + (3 & num28) << 5;
		if (num28 != 2124172340 - num + num3)
		{
			int num30 = (num22 + _0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE) ^ ((num ^ -2120829218) - num3) ^ (num28 & ((-2122561175 + num) ^ num3));
			StringBuilder stringBuilder2 = new StringBuilder();
			int num6 = (0x7E7B83F0 ^ num) + num3;
			stringBuilder2.Append((char)(byte)num6);
			text = num30.ToString(stringBuilder2.ToString());
		}
		if (!flag4 && _0023_003Dznd0k0JOCTYTYt_0024yGQMGRYjHPJADU)
		{
			text = string.Intern(text);
			_0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm._0023_003DzqYWbtzA_003D(_0023_003DzrpGNzZAFxA5Y79i5Ul2iu_0024QzHhnE, text);
			if (_0023_003Dzyxro4QehxowtnEomu7dD3tFnNtJm._0023_003DzmQ0Lq2hh_0024AY8oSDuym_0024Vitvl5OZn() == num + -2122560334 - num3)
			{
				_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D._0023_003DzQ2nUoz27rnBR_lnPLxDiBYoJo0Yl();
				_0023_003Dzsu2YyCRRGILOyVSo9CtBbcQ_003D = null;
				_0023_003DzvP4_j7yQgSPkEsoClZww_UKFRx1C = null;
				_0023_003Dzxn_JyhtCl9KNaWELQCGaUS271MPM = null;
			}
		}
		return text;
	}

	private static AssemblyName _0023_003DzfvyDTnKRJVOREEOqr85yiMG3tpNJ(Assembly _0023_003DzQZxxj75s38ieFadVqC3vwCVTIjxa)
	{
		try
		{
			AssemblyName name = _0023_003DzQZxxj75s38ieFadVqC3vwCVTIjxa.GetName();
			if (2u != 0)
			{
				return name;
			}
			AssemblyName result;
			return result;
		}
		catch
		{
			AssemblyName result2 = new AssemblyName(_0023_003DzQZxxj75s38ieFadVqC3vwCVTIjxa.FullName);
			if (6u != 0)
			{
				return result2;
			}
			AssemblyName result;
			return result;
		}
	}

	private static byte[] _0023_003DzSIWV_Sc2VI7iGuFk516kX_Mhop4I(AssemblyName _0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy)
	{
		byte[]? publicKeyToken = _0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy.GetPublicKeyToken();
		byte[] array;
		if (3u != 0)
		{
			array = publicKeyToken;
		}
		if (array != null && array.Length == 0)
		{
			if (3u != 0)
			{
				array = null;
			}
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0023_003Dzi9oKfa7igPwIP2cmkLnZdHxWuBH2(StackTrace _0023_003Dz8gpUxfvEZiatQpV7QO53_0024ZayGvTv, int _0023_003DzPU5OQRHaRk0WD2aIRrynpCQ_003D)
	{
		StackFrame? frame = _0023_003Dz8gpUxfvEZiatQpV7QO53_0024ZayGvTv.GetFrame(_0023_003DzPU5OQRHaRk0WD2aIRrynpCQ_003D + 1);
		StackFrame stackFrame;
		if (7u != 0)
		{
			stackFrame = frame;
		}
		Assembly obj = stackFrame?.GetMethod()?.DeclaringType?.Assembly;
		Assembly assembly;
		if (true)
		{
			assembly = obj;
		}
		if ((object)assembly != null)
		{
			AssemblyName assemblyName = _0023_003DzfvyDTnKRJVOREEOqr85yiMG3tpNJ(assembly);
			AssemblyName _0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy = default(AssemblyName);
			if (0 == 0)
			{
				_0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy = assemblyName;
			}
			byte[] array = _0023_003DzSIWV_Sc2VI7iGuFk516kX_Mhop4I(_0023_003Dzn5ZpS2pL3ZAJE_002423FGT4wc6S0djy);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		return false;
	}

	private static void _0023_003DzPwyIVovxJwO_umOXSaGpuKwmDQMJ(byte[] _0023_003DzdlCV7RpDcgNs2XCYWpv8zVGI6jdu, int _0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_, byte[] _0023_003DzYmQtjhUL_s9Ptg_0024CFOpPjs31l_0024pS)
	{
		int num = default(int);
		if (0 == 0)
		{
			num = 0;
		}
		int num2;
		if (2u != 0)
		{
			num2 = 0;
		}
		int num3;
		if (6u != 0)
		{
			num3 = 128;
		}
		int num4 = _0023_003DzYmQtjhUL_s9Ptg_0024CFOpPjs31l_0024pS.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0023_003DzdlCV7RpDcgNs2XCYWpv8zVGI6jdu[_0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0023_003DzdlCV7RpDcgNs2XCYWpv8zVGI6jdu[_0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_] >> 2) + 3;
				int num6 = ((_0023_003DzdlCV7RpDcgNs2XCYWpv8zVGI6jdu[_0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_] << 8) | _0023_003DzdlCV7RpDcgNs2XCYWpv8zVGI6jdu[_0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_ + 1]) & 0x3FF;
				_0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_ += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0023_003DzYmQtjhUL_s9Ptg_0024CFOpPjs31l_0024pS[num++] = _0023_003DzYmQtjhUL_s9Ptg_0024CFOpPjs31l_0024pS[num7++];
				}
			}
			else
			{
				_0023_003DzYmQtjhUL_s9Ptg_0024CFOpPjs31l_0024pS[num++] = _0023_003DzdlCV7RpDcgNs2XCYWpv8zVGI6jdu[_0023_003DzWGzJpCvtT22Z4317vqd3Uw8fQhW_++];
			}
		}
	}
}
