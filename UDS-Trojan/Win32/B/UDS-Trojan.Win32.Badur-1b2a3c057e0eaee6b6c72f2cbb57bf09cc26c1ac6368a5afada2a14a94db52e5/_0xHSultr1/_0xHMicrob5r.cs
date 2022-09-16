using System;
using System.Collections.Generic;
using System.Threading;
using _0xHA2te22as;
using _0xHFurb0ar0rs;
using _0xHG6uziness;
using _0xHLa7ders;
using _0xHLazil4;
using _0xHS3ar3;
using _0xHSigm1te;
using _0xHW4tans;

namespace _0xHSultr1;

internal class _0xHMicrob5r : IDisposable
{
	private readonly _0xH2wooned _0xHDemast7ng;

	private readonly int _0xHKine6i6;

	private readonly List<_0xHFi3ers> _0xHSmudgi1ess;

	private static _0xHMicrob5r[] _0xHHap6azardnesses;

	private DateTime _0xHMagnanimitie7;

	private int _0xHUn3atc3ed;

	private Timer _0xHW5manp5wer;

	private bool _0xHA11e11e1;

	internal _0xHMicrob5r(_0xH2wooned eventSource, int eventSourceIndex)
	{
		_0xHDemast7ng = eventSource;
		_0xHKine6i6 = eventSourceIndex;
		_0xHSmudgi1ess = new List<_0xHFi3ers>();
		_0xHS7ickered();
	}

	private void _0xH7ubulins(_0xHFi3ers _0xHPaleogeograp2ic)
	{
		_0xHSmudgi1ess.Add(_0xHPaleogeograp2ic);
	}

	private void _0xHS7ickered()
	{
		_0xHDemast7ng._0xH8ateaux += _0xHR8d;
	}

	private void _0xHR8d(object _0xHMisappropria4es, _0xHEcholocat3ons _0xHConstabular1)
	{
		if ((_0xHConstabular1._0xHGno2obio2ic == _0xHNonequa5.Enable || _0xHConstabular1._0xHGno2obio2ic == _0xHNonequa5.Update) && _0xHConstabular1._0xH5btundent.TryGetValue("EventCounterIntervalSec", out var value) && float.TryParse(value, out var result))
		{
			_0xHPropagand2st(result);
		}
	}

	internal static void _0xHSubl3menesses(_0xH2wooned _0xHC3tokine, _0xHFi3ers _0xH3ostponed)
	{
		int _0xHMet4oxyc4lor = _0xHBelletri8t._0xHF0sional(_0xHC3tokine);
		_0xH3onscionable(_0xHMet4oxyc4lor);
		_0xHMicrob5r _0xHMicrob5r2 = _0xHMoulag5(_0xHC3tokine);
		_0xHMicrob5r2._0xH7ubulins(_0xH3ostponed);
	}

	private static void _0xH3onscionable(int _0xHMet4oxyc4lor)
	{
		checked
		{
			if (_0xHHap6azardnesses == null)
			{
				_0xHHap6azardnesses = new _0xHMicrob5r[_0xHMet4oxyc4lor + 1];
			}
			else if (_0xHMet4oxyc4lor >= _0xHHap6azardnesses.Length)
			{
				_0xHMicrob5r[] destinationArray = new _0xHMicrob5r[_0xHMet4oxyc4lor + 1];
				Array.Copy(_0xHHap6azardnesses, destinationArray, _0xHHap6azardnesses.Length);
				_0xHHap6azardnesses = destinationArray;
			}
		}
	}

	private static _0xHMicrob5r _0xHMoulag5(_0xH2wooned _0xHLa11et)
	{
		int num = _0xHBelletri8t._0xHF0sional(_0xHLa11et);
		_0xHMicrob5r _0xHMicrob5r2 = _0xHHap6azardnesses[num];
		if (_0xHMicrob5r2 == null)
		{
			_0xHMicrob5r2 = new _0xHMicrob5r(_0xHLa11et, num);
			_0xHHap6azardnesses[num] = _0xHMicrob5r2;
		}
		return _0xHMicrob5r2;
	}

	private void _0xHPropagand2st(float _0xHWastr7)
	{
		if (_0xHWastr7 == 0f)
		{
			if (_0xHW5manp5wer != null)
			{
				_0xHW5manp5wer.Dispose();
				_0xHW5manp5wer = null;
			}
			_0xHUn3atc3ed = 0;
		}
		else if (_0xHUn3atc3ed == 0 || _0xHWastr7 < (float)_0xHUn3atc3ed)
		{
			_0xHUn3atc3ed = checked((int)(_0xHWastr7 * 1000f));
			if (_0xHW5manp5wer != null)
			{
				_0xHW5manp5wer.Dispose();
				_0xHW5manp5wer = null;
			}
			_0xHMagnanimitie7 = DateTime.Now;
			_0xHW5manp5wer = new Timer(_0xHDiscoin8, null, _0xHUn3atc3ed, _0xHUn3atc3ed);
		}
	}

	private void _0xHDiscoin8(object _0xHOver0ets)
	{
		if (_0xHDemast7ng._0xHS8umbler())
		{
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = now - _0xHMagnanimitie7;
			lock (_0xHW5manp5wer)
			{
				foreach (_0xHFi3ers item in _0xHSmudgi1ess)
				{
					_0xHRecon7erring _0xHRecon7erring = item._0xHMy66hic();
					_0xHRecon7erring._0xHLoami1st = (float)timeSpan.TotalSeconds;
					_0xHDemast7ng._0xHT8icepses("EventCounters", new _0xHDenotab4e
					{
						_0xHPo7ularising = _0xHFire0ots.LogAlways
					}, new
					{
						Payload = _0xHRecon7erring
					});
				}
				_0xHMagnanimitie7 = now;
				return;
			}
		}
		_0xHW5manp5wer.Dispose();
		_0xHW5manp5wer = null;
		_0xHHap6azardnesses[_0xHKine6i6] = null;
	}

	public void _0xHQuarrel4ome()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_0xHA11e11e1)
		{
			if (disposing && _0xHW5manp5wer != null)
			{
				_0xHW5manp5wer.Dispose();
				_0xHW5manp5wer = null;
			}
			_0xHA11e11e1 = true;
		}
	}
}
