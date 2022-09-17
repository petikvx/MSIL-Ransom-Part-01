using System;
using System.IO;

namespace _0023fb;

internal static class _0023nb
{
	internal sealed class _0023rb
	{
		internal static readonly int[] _0023a;

		internal static readonly int[] _0023b;

		internal static readonly int[] _0023c;

		internal static readonly int[] _0023d;

		private const int _0023e = 0;

		private const int _0023f = 1;

		private const int _0023g = 2;

		private const int _0023h = 3;

		private const int _0023i = 4;

		private const int _0023j = 5;

		private const int _0023k = 6;

		private const int _0023l = 7;

		private const int _0023m = 8;

		private const int _0023n = 9;

		private const int _0023o = 10;

		private const int _0023p = 11;

		private const int _0023q = 12;

		internal int _0023r;

		internal int _0023s;

		internal int _0023t;

		internal int _0023u;

		internal int _0023v;

		internal bool _0023w;

		internal _0023Ab _0023x;

		internal _0023Gb _0023y;

		internal _0023Jb _0023z;

		internal _0023Ib _0023A;

		internal _0023Ib _0023B;

		public _0023rb(byte[] _0023sb)
		{
			try
			{
				_0023x = new _0023Ab();
				_0023y = new _0023Gb();
				_0023r = 2;
				_0023_0023._0023Hg(_0023sb, 0, _0023sb.Length, _0023x);
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00235h(_0023hd, (object)this, (object)_0023sb);
				throw;
			}
		}

		static _0023rb()
		{
			try
			{
				_0023a = new int[29]
				{
					3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
					15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
					67, 83, 99, 115, 131, 163, 195, 227, 258
				};
				_0023b = new int[29]
				{
					0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
					1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
					4, 4, 4, 4, 5, 5, 5, 5, 0
				};
				_0023c = new int[30]
				{
					1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
					33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
					1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
				};
				_0023d = new int[30]
				{
					0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
					4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
					9, 9, 10, 10, 11, 11, 12, 12, 13, 13
				};
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00238g(_0023hd);
				throw;
			}
		}
	}

	internal sealed class _0023Ab
	{
		internal byte[] _0023a;

		internal int _0023b;

		internal int _0023c;

		internal uint _0023d;

		internal int _0023e;

		public int AvailableBits
		{
			get
			{
				try
				{
					return _0023e;
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}

		public int AvailableBytes
		{
			get
			{
				try
				{
					return _0023c - _0023b + (_0023e >> 3);
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}

		public bool IsNeedingInput
		{
			get
			{
				try
				{
					return _0023b == _0023c;
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}
	}

	internal sealed class _0023Gb
	{
		private const int _0023a = 32768;

		private const int _0023b = 32767;

		internal byte[] _0023c = new byte[32768];

		internal int _0023d;

		internal int _0023e;
	}

	internal sealed class _0023Ib
	{
		private const int _0023a = 15;

		internal short[] _0023b;

		public static readonly _0023Ib _0023c;

		public static readonly _0023Ib _0023d;

		static _0023Ib()
		{
			byte[] array = default(byte[]);
			int num = default(int);
			try
			{
				array = new byte[288];
				num = 0;
				while (num < 144)
				{
					array[num++] = 8;
				}
				while (num < 256)
				{
					array[num++] = 9;
				}
				while (num < 280)
				{
					array[num++] = 7;
				}
				while (num < 288)
				{
					array[num++] = 8;
				}
				_0023c = new _0023Ib(array);
				array = new byte[32];
				num = 0;
				while (num < 32)
				{
					array[num++] = 5;
				}
				_0023d = new _0023Ib(array);
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00235h(_0023hd, (object)array, (object)num);
				throw;
			}
		}

		public _0023Ib(byte[] _0023Hb)
		{
			try
			{
				_0023_0023._0023Dh(_0023Hb, this);
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00235h(_0023hd, (object)this, (object)_0023Hb);
				throw;
			}
		}
	}

	internal sealed class _0023Jb
	{
		private const int _0023a = 0;

		private const int _0023b = 1;

		private const int _0023c = 2;

		private const int _0023d = 3;

		private const int _0023e = 4;

		private const int _0023f = 5;

		internal static readonly int[] _0023g;

		internal static readonly int[] _0023h;

		internal byte[] _0023i;

		internal byte[] _0023j;

		internal _0023Ib _0023k;

		internal int _0023l;

		internal int _0023m;

		internal int _0023n;

		internal int _0023o;

		internal int _0023p;

		internal int _0023q;

		internal byte _0023r;

		internal int _0023s;

		internal static readonly int[] _0023t;

		static _0023Jb()
		{
			try
			{
				_0023g = new int[3] { 3, 3, 11 };
				_0023h = new int[3] { 2, 3, 7 };
				_0023t = new int[19]
				{
					16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
					11, 4, 12, 3, 13, 2, 14, 1, 15
				};
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00238g(_0023hd);
				throw;
			}
		}
	}

	internal sealed class _0023Mb
	{
		private const int _0023a = 4;

		private const int _0023b = 8;

		private const int _0023c = 16;

		private const int _0023d = 20;

		private const int _0023e = 28;

		private const int _0023f = 30;

		internal int _0023g = 16;

		internal long _0023h;

		internal _0023hc _0023i;

		internal _0023ac _0023j;

		public long TotalOut
		{
			get
			{
				try
				{
					return _0023h;
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}

		public bool IsFinished
		{
			get
			{
				try
				{
					if (_0023g == 30)
					{
						return _0023i.IsFlushed;
					}
					return false;
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}

		public bool IsNeedingInput
		{
			get
			{
				try
				{
					return _0023_0023._0023tg(_0023j);
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}

		public _0023Mb()
		{
			try
			{
				_0023i = new _0023hc();
				_0023j = new _0023ac(_0023i);
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00232f(_0023hd, (object)this);
				throw;
			}
		}
	}

	internal sealed class _0023Vb
	{
		public sealed class _00232b
		{
			public short[] _0023a;

			public byte[] _0023b;

			public int _0023c;

			public int _0023d;

			internal short[] _0023e;

			internal int[] _0023f;

			internal int _0023g;

			internal _0023Vb _0023h;

			public _00232b(_0023Vb _00233b, int _00234b, int _00235b, int _00236b)
			{
				try
				{
					_0023h = _00233b;
					_0023c = _00235b;
					_0023g = _00236b;
					_0023a = new short[_00234b];
					_0023f = new int[_00236b];
				}
				catch (Exception _0023hd)
				{
					_0023_0023._0023Dg(_0023hd, (object)this, (object)_00233b, (object)_00234b, (object)_00235b, (object)_00236b);
					throw;
				}
			}
		}

		private const int _0023a = 16384;

		private const int _0023b = 286;

		private const int _0023c = 30;

		private const int _0023d = 19;

		private const int _0023e = 16;

		private const int _0023f = 17;

		private const int _0023g = 18;

		private const int _0023h = 256;

		internal static readonly int[] _0023i;

		internal static readonly byte[] _0023j;

		internal _0023hc _0023k;

		internal _00232b _0023l;

		internal _00232b _0023m;

		internal _00232b _0023n;

		internal short[] _0023o;

		internal byte[] _0023p;

		internal int _0023q;

		internal int _0023r;

		internal static readonly short[] _0023s;

		internal static readonly byte[] _0023t;

		internal static readonly short[] _0023u;

		internal static readonly byte[] _0023v;

		static _0023Vb()
		{
			int i = default(int);
			try
			{
				_0023i = new int[19]
				{
					16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
					11, 4, 12, 3, 13, 2, 14, 1, 15
				};
				_0023j = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				_0023s = new short[286];
				_0023t = new byte[286];
				i = 0;
				while (i < 144)
				{
					_0023s[i] = _0023_0023._00233h(48 + i << 8);
					_0023t[i++] = 8;
				}
				while (i < 256)
				{
					_0023s[i] = _0023_0023._00233h(256 + i << 7);
					_0023t[i++] = 9;
				}
				while (i < 280)
				{
					_0023s[i] = _0023_0023._00233h(-256 + i << 9);
					_0023t[i++] = 7;
				}
				while (i < 286)
				{
					_0023s[i] = _0023_0023._00233h(-88 + i << 8);
					_0023t[i++] = 8;
				}
				_0023u = new short[30];
				_0023v = new byte[30];
				for (i = 0; i < 30; i++)
				{
					_0023u[i] = _0023_0023._00233h(i << 11);
					_0023v[i] = 5;
				}
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00232f(_0023hd, (object)i);
				throw;
			}
		}

		public _0023Vb(_0023hc _0023Wb)
		{
			try
			{
				_0023k = _0023Wb;
				_0023l = new _00232b(this, 286, 257, 15);
				_0023m = new _00232b(this, 30, 1, 15);
				_0023n = new _00232b(this, 19, 4, 7);
				_0023o = new short[16384];
				_0023p = new byte[16384];
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00235h(_0023hd, (object)this, (object)_0023Wb);
				throw;
			}
		}
	}

	internal sealed class _0023ac
	{
		private const int _0023a = 258;

		private const int _0023b = 3;

		private const int _0023c = 32768;

		private const int _0023d = 32767;

		private const int _0023e = 32768;

		private const int _0023f = 32767;

		private const int _0023g = 5;

		private const int _0023h = 262;

		private const int _0023i = 32506;

		private const int _0023j = 4096;

		internal int _0023k;

		internal short[] _0023l;

		internal short[] _0023m;

		internal int _0023n;

		internal int _0023o;

		internal bool _0023p;

		internal int _0023q;

		internal int _0023r;

		internal int _0023s;

		internal byte[] _0023t;

		internal byte[] _0023u;

		internal int _0023v;

		internal int _0023w;

		internal int _0023x;

		internal _0023hc _0023y;

		internal _0023Vb _0023z;

		public _0023ac(_0023hc _0023Wb)
		{
			int num = default(int);
			try
			{
				_0023y = _0023Wb;
				_0023z = new _0023Vb(_0023Wb);
				_0023t = new byte[65536];
				_0023l = new short[32768];
				_0023m = new short[32768];
				num = (_0023q = (_0023r = 1));
			}
			catch (Exception _0023hd)
			{
				_0023_0023._0023fg(_0023hd, (object)num, (object)this, (object)_0023Wb);
				throw;
			}
		}
	}

	internal sealed class _0023hc
	{
		protected internal byte[] _0023a = new byte[65536];

		internal int _0023b;

		internal int _0023c;

		internal uint _0023d;

		internal int _0023e;

		public int BitCount
		{
			get
			{
				try
				{
					return _0023e;
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}

		public bool IsFlushed
		{
			get
			{
				try
				{
					return _0023c == 0;
				}
				catch (Exception _0023hd)
				{
					_0023_0023._00232f(_0023hd, (object)this);
					throw;
				}
			}
		}
	}

	internal sealed class _0023ic : MemoryStream
	{
		public _0023ic()
		{
		}

		public _0023ic(byte[] _0023lb)
			: base(_0023lb, writable: false)
		{
		}
	}

	public static string _0023a;
}
