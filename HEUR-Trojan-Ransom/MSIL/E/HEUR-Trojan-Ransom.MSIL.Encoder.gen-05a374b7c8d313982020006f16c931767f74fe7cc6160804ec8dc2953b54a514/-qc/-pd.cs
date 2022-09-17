using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using _0023ab;

namespace _0023qc;

internal class _0023pd
{
	internal class _0023if
	{
		private readonly _0023pd _0023a;

		private readonly byte[] _0023b;

		private readonly _0023je _0023c;

		private readonly _0023rf _0023d;

		public bool _0023e = true;

		public _0023if(_0023pd _0023gd, byte[] _0023jf, _0023je _0023kf, _0023rf _0023jd)
		{
			_0023a = _0023gd;
			_0023d = _0023jd;
			_0023c = _0023kf;
			_0023b = _0023jf;
		}

		public void _0023gf(string _0023hf)
		{
			if (_0023hf == _0023ab._00239._00237(107392638))
			{
				_0023_0023._0023Af(_0023a, _0023Hd._0023c);
				byte[] bytes = Encoding.UTF8.GetBytes(_0023ab._00239._00237(107394995));
				byte[] array = new byte[bytes.Length + _0023b.Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy(_0023b, 0, array, bytes.Length, _0023b.Length);
				_0023nf _0023nf = new _0023nf(_0023a);
				_0023je _0023fe = _0023c;
				string _0023ge = _0023d._0023b;
				string _0023ie = _0023d._0023c;
				string text = _0023d._0023d;
				_0023Vd _0023he = _0023nf._0023lf;
				_0023_0023._0023Eg(array, _0023ge, _0023he, _0023ie, _0023fe, text);
				_0023e = _0023nf._0023b;
			}
			else
			{
				if (_0023a._0023e != null)
				{
					_0023a._0023e(this, new _0023Gd(_0023Hd._0023b, _0023hf));
				}
				_0023e = false;
			}
		}
	}

	private class _0023nf
	{
		private readonly _0023pd _0023a;

		public bool _0023b;

		public _0023nf(_0023pd _0023gd)
		{
			_0023a = _0023gd;
		}

		public void _0023lf(string _0023mf)
		{
			if (_0023mf.StartsWith(_0023ab._00239._00237(107392633)))
			{
				_0023_0023._0023Af(_0023a, _0023Hd._0023c, _0023mf);
				_0023b = false;
			}
			else
			{
				_0023_0023._0023Af(_0023a, _0023Hd._0023d, string.Empty, _0023mf);
				_0023b = true;
			}
		}
	}

	internal class _0023rf
	{
		public static _0023rf _0023a = new _0023rf(null, null, null);

		internal readonly string _0023b;

		internal readonly string _0023c;

		internal readonly string _0023d;

		public string BuildFriendlyNumber => _0023d;

		public string AppFriendlyName => _0023c;

		public string EmailAddress => _0023b;

		public _0023rf(string _0023sf, string _0023he, string _0023ie)
		{
			_0023b = _0023sf;
			_0023d = _0023ie;
			_0023c = _0023he;
		}
	}

	protected const string _0023a = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private const string _0023b = "{be78a0c5-c47c-4127-a428-52bdc580a02f}";

	private const string _0023c = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	internal IWebProxy _0023d;

	[CompilerGenerated]
	internal _0023Bd _0023e;

	public event _0023Bd SendingReportFeedback
	{
		[CompilerGenerated]
		add
		{
			_0023Bd _0023Bd2 = _0023e;
			_0023Bd _0023Bd3;
			do
			{
				_0023Bd3 = _0023Bd2;
				_0023Bd value2 = (_0023Bd)Delegate.Combine(_0023Bd3, value);
				_0023Bd2 = Interlocked.CompareExchange(ref _0023e, value2, _0023Bd3);
			}
			while ((object)_0023Bd2 != _0023Bd3);
		}
		[CompilerGenerated]
		remove
		{
			_0023Bd _0023Bd2 = _0023e;
			_0023Bd _0023Bd3;
			do
			{
				_0023Bd3 = _0023Bd2;
				_0023Bd value2 = (_0023Bd)Delegate.Remove(_0023Bd3, value);
				_0023Bd2 = Interlocked.CompareExchange(ref _0023e, value2, _0023Bd3);
			}
			while ((object)_0023Bd2 != _0023Bd3);
		}
	}
}
