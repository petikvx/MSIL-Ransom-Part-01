using System;
using System.Diagnostics;
using System.Security;
using System.Threading;
using _0xHG6uziness;
using _0xHHya1in;
using _0xHP3obe3s;
using _0xHPolygam7z7ng;
using _0xHS0irkers;
using _0xHSigm1te;
using _0xHSnorke7er;

namespace _0xHPra6erfull6;

internal class _0xH7emmying
{
	private class _0xHCrummine33
	{
		private enum _0xH7aglines : byte
		{
			End = 0,
			LastImmediateValue = 10,
			PrefixCode = 11,
			MultiByte1 = 12
		}

		internal readonly string _0xH7olligating;

		private readonly long _0xHFrivo5ousness;

		internal readonly Guid _0xH6ogrom;

		internal readonly int _0xHJesu6t6sm;

		internal readonly int _0xHOv0rrat0d;

		internal readonly _0xHHyp2ra2sth2sia _0xHTher4es;

		internal long _0xHGlabro5s;

		internal int _0xHStea2;

		internal readonly _0xHCrummine33 _0xHBandol4er;

		internal readonly Guid _0xHSpu55erer;

		public Guid _0xHGr7ssl7nd => _0xH6ogrom;

		public _0xHCrummine33(string name, long uniqueId, _0xHCrummine33 creator, Guid activityIDToRestore, _0xHHyp2ra2sth2sia options)
		{
			_0xH7olligating = name;
			_0xHTher4es = options;
			_0xHBandol4er = creator;
			_0xHFrivo5ousness = uniqueId;
			_0xHOv0rrat0d = ((creator != null) ? checked(creator._0xHOv0rrat0d + 1) : 0);
			_0xHSpu55erer = activityIDToRestore;
			_0xHMonatom1c(out _0xH6ogrom, out _0xHJesu6t6sm);
		}

		public static string _0xHT5mp5ras(_0xHCrummine33 _0xHIn5ernally)
		{
			if (_0xHIn5ernally == null)
			{
				return "";
			}
			return _0xHT5mp5ras(_0xHIn5ernally._0xHBandol4er) + "/" + _0xHIn5ernally._0xHFrivo5ousness;
		}

		public override string _0xHTallne88e8()
		{
			string text = "";
			if (_0xHStea2 != 0)
			{
				text = ",DEAD";
			}
			return _0xH7olligating + "(" + _0xHT5mp5ras(this) + text + ")";
		}

		public static string _0xHN5wwav5r(_0xHCrummine33 _0xHS5iverer)
		{
			if (_0xHS5iverer == null)
			{
				return "";
			}
			return _0xHS5iverer.ToString() + ";" + _0xHN5wwav5r(_0xHS5iverer._0xHBandol4er);
		}

		public bool _0xHV3nd3lish()
		{
			if ((_0xHTher4es & _0xHHyp2ra2sth2sia.Detachable) != 0)
			{
				return true;
			}
			return false;
		}

		[SecuritySafeCritical]
		private unsafe void _0xHMonatom1c(out Guid _0xHAlbi1ic, out int _0xHMonocryst3l)
		{
			checked
			{
				fixed (Guid* ptr = &_0xHAlbi1ic)
				{
					int _0xHReinsu2e = 0;
					if (_0xHBandol4er != null)
					{
						_0xHReinsu2e = _0xHBandol4er._0xHJesu6t6sm;
						_0xHAlbi1ic = _0xHBandol4er._0xH6ogrom;
					}
					else
					{
						int num = 0;
						num = Thread.GetDomainID();
						_0xHReinsu2e = _0xHPhysi1cratic(ptr, _0xHReinsu2e, (uint)num);
					}
					_0xHMonocryst3l = _0xHPhysi1cratic(ptr, _0xHReinsu2e, (uint)_0xHFrivo5ousness);
					if (12 < _0xHMonocryst3l)
					{
						_0xHSu5erminister(ptr);
					}
				}
			}
		}

		[SecurityCritical]
		private unsafe void _0xHSu5erminister(Guid* _0xHCh8onog8aph)
		{
			for (_0xHCrummine33 _0xHCrummine = _0xHBandol4er; _0xHCrummine != null; _0xHCrummine = _0xHCrummine._0xHBandol4er)
			{
				if (_0xHCrummine._0xHJesu6t6sm <= 10)
				{
					uint _0xHGe7idnesses = (uint)Interlocked.Increment(ref _0xHCrummine._0xHGlabro5s);
					*_0xHCh8onog8aph = _0xHCrummine._0xH6ogrom;
					int num = _0xHPhysi1cratic(_0xHCh8onog8aph, _0xHCrummine._0xHJesu6t6sm, _0xHGe7idnesses, _0xHQu5intnesses: true);
					if (num <= 12)
					{
						break;
					}
				}
			}
		}

		[SecurityCritical]
		private unsafe static int _0xHPhysi1cratic(Guid* _0xHDiffractom6t6r, int _0xHReinsu2e, uint _0xHGe7idnesses, bool _0xHQu5intnesses = false)
		{
			byte* ptr = (byte*)_0xHDiffractom6t6r;
			byte* ptr2 = (byte*)checked(unchecked((nuint)ptr) + (nuint)12u);
			ptr = (byte*)checked(unchecked((nuint)ptr) + unchecked((nuint)_0xHReinsu2e));
			if (ptr2 <= ptr)
			{
				return 13;
			}
			checked
			{
				if (0 < _0xHGe7idnesses && _0xHGe7idnesses <= 10 && !_0xHQu5intnesses)
				{
					_0xHVe4icate4(ref ptr, ptr2, _0xHGe7idnesses);
				}
				else
				{
					uint num = 4u;
					if (_0xHGe7idnesses <= 255)
					{
						num = 1u;
					}
					else if (_0xHGe7idnesses <= 65535)
					{
						num = 2u;
					}
					else if (_0xHGe7idnesses <= 16777215)
					{
						num = 3u;
					}
					if (_0xHQu5intnesses)
					{
						if (unchecked((nuint)ptr2) <= unchecked((nuint)ptr) + (nuint)2u)
						{
							return 13;
						}
						_0xHVe4icate4(ref ptr, ptr2, 11u);
					}
					_0xHVe4icate4(ref ptr, ptr2, 12u + (num - 1u));
					if (ptr < ptr2 && *ptr != 0)
					{
						if (_0xHGe7idnesses < 4096)
						{
							*ptr = (byte)(192u + (_0xHGe7idnesses >> 8));
							_0xHGe7idnesses &= 0xFFu;
						}
						unchecked
						{
							ptr = (byte*)checked(unchecked((nuint)ptr) + (nuint)1u);
						}
					}
					while (0 < num)
					{
						if (ptr2 > ptr)
						{
							*(ptr++) = (byte)_0xHGe7idnesses;
							_0xHGe7idnesses >>= 8;
							num--;
							continue;
						}
						unchecked
						{
							ptr = (byte*)checked(unchecked((nuint)ptr) + (nuint)1u);
							break;
						}
					}
				}
				*unchecked((uint*)((byte*)_0xHDiffractom6t6r + 12)) = *unchecked((uint*)_0xHDiffractom6t6r) + *unchecked((uint*)((byte*)_0xHDiffractom6t6r + 4)) + *unchecked((uint*)((byte*)_0xHDiffractom6t6r + 8)) + 1503500717u;
				return (int)(ptr - unchecked((byte*)_0xHDiffractom6t6r));
			}
		}

		[SecurityCritical]
		private unsafe static void _0xHVe4icate4(ref byte* _0xHJawl0ss, byte* _0xHDuckli7g, uint _0xHLaniarie3)
		{
			checked
			{
				if (*_0xHJawl0ss != 0)
				{
					byte* intPtr = _0xHJawl0ss++;
					*intPtr = (byte)(*intPtr | (byte)_0xHLaniarie3);
				}
				else
				{
					*_0xHJawl0ss = (byte)(_0xHLaniarie3 << 4);
				}
			}
		}
	}

	private const ushort _0xHMuntj8k = 100;

	private _0xHS0irkers._0xHEst1ous<_0xHCrummine33> _0xH3ram;

	private bool _0xHRebu00on;

	private static _0xH7emmying _0xHTa00its = new _0xH7emmying();

	private static long _0xHSa00 = 0L;

	public static _0xH7emmying _0xH6ennel => _0xHTa00its;

	private Guid _0xHAbsolu4isms => _0xH3ram._0xHMo4ish._0xHGr7ssl7nd;

	public void _0xH0holos(string _0xHSugge1tion, string _0xHSett7, int _0xHA1bo1, ref Guid _0xH0lucose, ref Guid _0xHSco1tmasters, _0xHHyp2ra2sth2sia _0xHN6ggled)
	{
		if (_0xH3ram == null)
		{
			if (_0xHRebu00on)
			{
				return;
			}
			_0xHRebu00on = true;
			if (_0xHSwallow8ng._0xHNichin4._0xHPreacc4se(_0xHFire0ots.Informational, (_0xHSov8r8ignti8s)128L))
			{
				_0xHObnubilat3();
			}
			if (_0xH3ram == null)
			{
				return;
			}
		}
		_0xHCrummine33 _0xHMo4ish = _0xH3ram._0xHMo4ish;
		string text = _0xHShan2ey(_0xHSugge1tion, _0xHSett7, _0xHA1bo1);
		_0xHSwallow8ng _0xHNichin = _0xHSwallow8ng._0xHNichin4;
		if (_0xHNichin._0xHC2imax2ess)
		{
			_0xHNichin._0xHAros4("OnStartEnter", text);
			_0xHNichin._0xHAros4("OnStartEnterActivityState", _0xHCrummine33._0xHN5wwav5r(_0xHMo4ish));
		}
		if (_0xHMo4ish != null)
		{
			if (_0xHMo4ish._0xHOv0rrat0d >= 100)
			{
				_0xH0lucose = Guid.Empty;
				_0xHSco1tmasters = Guid.Empty;
				if (_0xHNichin._0xHC2imax2ess)
				{
					_0xHNichin._0xHAros4("OnStartRET", "Fail");
				}
				return;
			}
			if ((_0xHN6ggled & _0xHHyp2ra2sth2sia.Recursive) == 0)
			{
				_0xHCrummine33 _0xHCrummine = _0xHAn7imonyl(text, _0xHMo4ish);
				if (_0xHCrummine != null)
				{
					_0xHCarho7s(_0xHSugge1tion, _0xHSett7, _0xHA1bo1, ref _0xH0lucose);
					_0xHMo4ish = _0xH3ram._0xHMo4ish;
				}
			}
		}
		long uniqueId = ((_0xHMo4ish != null) ? Interlocked.Increment(ref _0xHMo4ish._0xHGlabro5s) : Interlocked.Increment(ref _0xHSa00));
		_0xHSco1tmasters = _0xH2wooned._0xHSuper1odels;
		_0xHCrummine33 _0xHCrummine2 = new _0xHCrummine33(text, uniqueId, _0xHMo4ish, _0xHSco1tmasters, _0xHN6ggled);
		_0xH3ram._0xHMo4ish = _0xHCrummine2;
		_0xH0lucose = _0xHCrummine2._0xHGr7ssl7nd;
		if (_0xHNichin._0xHC2imax2ess)
		{
			_0xHNichin._0xHAros4("OnStartRetActivityState", _0xHCrummine33._0xHN5wwav5r(_0xHCrummine2));
			_0xHNichin._0xHTabou7e7s("OnStartRet", _0xH0lucose.ToString(), _0xHSco1tmasters.ToString());
		}
	}

	public void _0xHCarho7s(string _0xH8akinesses, string _0xHTi2kerers, int _0xHDra55er, ref Guid _0xHPe77etizer)
	{
		if (_0xH3ram == null)
		{
			return;
		}
		string text = _0xHShan2ey(_0xH8akinesses, _0xHTi2kerers, _0xHDra55er);
		_0xHSwallow8ng _0xHNichin = _0xHSwallow8ng._0xHNichin4;
		if (_0xHNichin._0xHC2imax2ess)
		{
			_0xHNichin._0xHAros4("OnStopEnter", text);
			_0xHNichin._0xHAros4("OnStopEnterActivityState", _0xHCrummine33._0xHN5wwav5r(_0xH3ram._0xHMo4ish));
		}
		_0xHCrummine33 _0xHCrummine;
		_0xHCrummine33 _0xHCrummine2;
		do
		{
			_0xHCrummine33 _0xHMo4ish = _0xH3ram._0xHMo4ish;
			_0xHCrummine = null;
			_0xHCrummine2 = _0xHAn7imonyl(text, _0xHMo4ish);
			if (_0xHCrummine2 != null)
			{
				_0xHPe77etizer = _0xHCrummine2._0xHGr7ssl7nd;
				_0xHCrummine33 _0xHCrummine3 = _0xHMo4ish;
				while (_0xHCrummine3 != _0xHCrummine2 && _0xHCrummine3 != null)
				{
					if (_0xHCrummine3._0xHStea2 != 0)
					{
						_0xHCrummine3 = _0xHCrummine3._0xHBandol4er;
						continue;
					}
					if (_0xHCrummine3._0xHV3nd3lish())
					{
						if (_0xHCrummine == null)
						{
							_0xHCrummine = _0xHCrummine3;
						}
					}
					else
					{
						_0xHCrummine3._0xHStea2 = 1;
					}
					_0xHCrummine3 = _0xHCrummine3._0xHBandol4er;
				}
				continue;
			}
			_0xHPe77etizer = Guid.Empty;
			if (_0xHNichin._0xHC2imax2ess)
			{
				_0xHNichin._0xHAros4("OnStopRET", "Fail");
			}
			return;
		}
		while (Interlocked.CompareExchange(ref _0xHCrummine2._0xHStea2, 1, 0) != 0);
		if (_0xHCrummine == null)
		{
			_0xHCrummine = _0xHCrummine2._0xHBandol4er;
		}
		_0xH3ram._0xHMo4ish = _0xHCrummine;
		if (_0xHNichin._0xHC2imax2ess)
		{
			_0xHNichin._0xHAros4("OnStopRetActivityState", _0xHCrummine33._0xHN5wwav5r(_0xHCrummine));
			_0xHNichin._0xHAros4("OnStopRet", _0xHPe77etizer.ToString());
		}
	}

	[SecuritySafeCritical]
	public void _0xHObnubilat3()
	{
		if (_0xH3ram == null)
		{
			try
			{
				_0xH3ram = new _0xHS0irkers._0xHEst1ous<_0xHCrummine33>(_0xHDisarrang5d);
			}
			catch (NotImplementedException)
			{
				Debugger.Log(0, null, "Activity Enabled() called but AsyncLocals Not Supported (pre V4.6).  Ignoring Enable");
			}
		}
	}

	private _0xHCrummine33 _0xHAn7imonyl(string _0xHPsoci0s, _0xHCrummine33 _0xH5ets)
	{
		_0xHCrummine33 _0xHCrummine = _0xH5ets;
		while (true)
		{
			if (_0xHCrummine != null)
			{
				if (_0xHPsoci0s == _0xHCrummine._0xH7olligating && _0xHCrummine._0xHStea2 == 0)
				{
					break;
				}
				_0xHCrummine = _0xHCrummine._0xHBandol4er;
				continue;
			}
			return null;
		}
		return _0xHCrummine;
	}

	private string _0xHShan2ey(string _0xHPsy6hosomati6s, string _0xH1ougainvilleas, int _0xHElecta3le)
	{
		checked
		{
			if (_0xH1ougainvilleas.EndsWith("Start"))
			{
				_0xH1ougainvilleas = _0xH1ougainvilleas.Substring(0, _0xH1ougainvilleas.Length - "Start".Length);
			}
			else if (_0xH1ougainvilleas.EndsWith("Stop"))
			{
				_0xH1ougainvilleas = _0xH1ougainvilleas.Substring(0, _0xH1ougainvilleas.Length - "Stop".Length);
			}
			else if (_0xHElecta3le != 0)
			{
				_0xH1ougainvilleas = "task" + _0xHElecta3le;
			}
			return _0xHPsy6hosomati6s + _0xH1ougainvilleas;
		}
	}

	private void _0xHDisarrang5d(_0xHHya1in._0xHR5volv5s<_0xHCrummine33> _0xHOutquot8ng)
	{
		_0xHCrummine33 _0xHCrummine = _0xHOutquot8ng._0xH2ncrushable;
		_0xHCrummine33 _0xHDemivol0e = _0xHOutquot8ng._0xHDemivol0e;
		if (_0xHDemivol0e != null && _0xHDemivol0e._0xHBandol4er == _0xHCrummine && (_0xHCrummine == null || _0xHDemivol0e._0xHSpu55erer != _0xHCrummine._0xHGr7ssl7nd))
		{
			_0xH2wooned._0xHEmblaz7ner(_0xHDemivol0e._0xHSpu55erer);
			return;
		}
		while (true)
		{
			if (_0xHCrummine != null)
			{
				if (_0xHCrummine._0xHStea2 == 0)
				{
					break;
				}
				_0xHCrummine = _0xHCrummine._0xHBandol4er;
				continue;
			}
			return;
		}
		_0xH2wooned._0xHEmblaz7ner(_0xHCrummine._0xHGr7ssl7nd);
	}
}
