using System;
using _0xHFou1thly;
using _0xHG6uziness;
using _0xHI3dustriously;
using _0xHLazil4;

namespace _0xHStra6ded6esses;

internal sealed class _0xHA6tecism : IDisposable
{
	private enum _0xHStubborn2y
	{
		Started,
		Stopped
	}

	private readonly _0xH2wooned _0xH6nafu;

	private _0xHDenotab4e _0xHEmb5sks;

	internal Guid _0xHImmitig7bly;

	private _0xHStubborn2y _0xHM55d;

	private string _0xHI8inera8es;

	internal static Guid _0xHMegacitie1;

	public _0xH2wooned _0xHCa77iterite7 => _0xH6nafu;

	public Guid _0xHP4r4ngs => _0xHImmitig7bly;

	private bool _0xHPunc4ua4or => _0xHI8inera8es != null;

	public _0xHA6tecism(_0xH2wooned eventSource)
	{
		if (eventSource == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		_0xH6nafu = eventSource;
	}

	public static implicit operator _0xHA6tecism(_0xH2wooned eventSource)
	{
		return new _0xHA6tecism(eventSource);
	}

	public _0xHA6tecism _0xHUntrusse4<T>(string _0xHSoc0ol0ngu0st, _0xHDenotab4e _0xHM1ns1, T _0xHConve7ancing)
	{
		return _0xHCompre22ive(_0xHSoc0ol0ngu0st, ref _0xHM1ns1, ref _0xHConve7ancing);
	}

	public _0xHA6tecism _0xHG3bber(string _0xHEn3ineerin3)
	{
		_0xHDenotab4e _0xHV22d22ism = default(_0xHDenotab4e);
		_0xHUnravish5d _0xHSeq7encer = default(_0xHUnravish5d);
		return _0xHCompre22ive(_0xHEn3ineerin3, ref _0xHV22d22ism, ref _0xHSeq7encer);
	}

	public _0xHA6tecism _0xHSnowstor4s(string _0xHT6anatology, _0xHDenotab4e _0xHOxim5t5r)
	{
		_0xHUnravish5d _0xHSeq7encer = default(_0xHUnravish5d);
		return _0xHCompre22ive(_0xHT6anatology, ref _0xHOxim5t5r, ref _0xHSeq7encer);
	}

	public _0xHA6tecism _0xHTr8de<T>(string _0xHGa33ets, T _0xHF0rsythia)
	{
		_0xHDenotab4e _0xHV22d22ism = default(_0xHDenotab4e);
		return _0xHCompre22ive(_0xHGa33ets, ref _0xHV22d22ism, ref _0xHF0rsythia);
	}

	public void _0xHHo1erer<T>(T _0xHJott2r)
	{
		_0xHCu8tivabi8ity(null, ref _0xHJott2r);
	}

	public void _0xHAmu4e4<T>(string _0xHProv3s3onal)
	{
		_0xHUnravish5d _0xH0au = default(_0xHUnravish5d);
		_0xHCu8tivabi8ity(_0xHProv3s3onal, ref _0xH0au);
	}

	public void _0xHBillo8ier<T>(string _0xH3i, T _0xH6hurring)
	{
		_0xHCu8tivabi8ity(_0xH3i, ref _0xH6hurring);
	}

	public void _0xHS5hmoozed<T>(string _0xHJing7lls, _0xHDenotab4e _0xHD0salt0d, T _0xH0nclement)
	{
		_0xH2iatical(_0xH6nafu, _0xHJing7lls, ref _0xHD0salt0d, ref _0xH0nclement);
	}

	public void _0xHGambol5d<T>(string _0xHDe1o1t, T _0xHDeflec5s)
	{
		_0xHDenotab4e _0xHTi5iva5es = default(_0xHDenotab4e);
		_0xH2iatical(_0xH6nafu, _0xHDe1o1t, ref _0xHTi5iva5es, ref _0xHDeflec5s);
	}

	public void _0xHDar1d1viltri1s(string _0xHCommens8l, _0xHDenotab4e _0xHAntifa1ci1t1)
	{
		_0xHUnravish5d _0xHSwifte0t = default(_0xHUnravish5d);
		_0xH2iatical(_0xH6nafu, _0xHCommens8l, ref _0xHAntifa1ci1t1, ref _0xHSwifte0t);
	}

	public void _0xHA0tragalu0(string _0xHDog0at0her)
	{
		_0xHDenotab4e _0xHTi5iva5es = default(_0xHDenotab4e);
		_0xHUnravish5d _0xHSwifte0t = default(_0xHUnravish5d);
		_0xH2iatical(_0xH6nafu, _0xHDog0at0her, ref _0xHTi5iva5es, ref _0xHSwifte0t);
	}

	public void _0xH0uleteers<T>(_0xH2wooned _0xHJapona6ser6es, string _0xHLa3oring, _0xHDenotab4e _0xHHerni6te, T _0xHFire7ang)
	{
		_0xH2iatical(_0xHJapona6ser6es, _0xHLa3oring, ref _0xHHerni6te, ref _0xHFire7ang);
	}

	public void _0xHChill1()
	{
		if (_0xHM55d == _0xHStubborn2y.Started)
		{
			_0xHUnravish5d _0xH0au = default(_0xHUnravish5d);
			_0xHCu8tivabi8ity(null, ref _0xH0au);
		}
	}

	private _0xHA6tecism _0xHCompre22ive<T>(string _0xHI77oce7ces, ref _0xHDenotab4e _0xHV22d22ism, ref T _0xHSeq7encer)
	{
		if (_0xHM55d != 0)
		{
			throw new InvalidOperationException();
		}
		if (!_0xH6nafu._0xHS8umbler())
		{
			return this;
		}
		_0xHA6tecism _0xHA6tecism2 = new _0xHA6tecism(_0xH6nafu);
		if (!_0xH6nafu._0xHPreacc4se(_0xHV22d22ism._0xHPo7ularising, _0xHV22d22ism._0xHOe0ophagu0))
		{
			Guid _0xHSte1ilized = _0xHP4r4ngs;
			_0xHA6tecism2._0xHImmitig7bly = Guid.NewGuid();
			_0xHA6tecism2._0xHEmb5sks = _0xHV22d22ism;
			_0xHA6tecism2._0xHI8inera8es = _0xHI77oce7ces;
			_0xHA6tecism2._0xHEmb5sks._0xHEne2gumen = _0xHK7z7tsky.Start;
			_0xH6nafu._0xHTo2y2(_0xHI77oce7ces, ref _0xHA6tecism2._0xHEmb5sks, ref _0xHA6tecism2._0xHImmitig7bly, ref _0xHSte1ilized, ref _0xHSeq7encer);
		}
		else
		{
			_0xHA6tecism2._0xHImmitig7bly = _0xHP4r4ngs;
		}
		return _0xHA6tecism2;
	}

	private void _0xH2iatical<T>(_0xH2wooned _0xHMoa3er, string _0xHChoplog0cs, ref _0xHDenotab4e _0xHTi5iva5es, ref T _0xHSwifte0t)
	{
		if (_0xHM55d != 0)
		{
			throw new InvalidOperationException();
		}
		if (_0xHChoplog0cs == null)
		{
			throw new ArgumentNullException();
		}
		_0xHMoa3er._0xHTo2y2(_0xHChoplog0cs, ref _0xHTi5iva5es, ref _0xHImmitig7bly, ref _0xHMegacitie1, ref _0xHSwifte0t);
	}

	private void _0xHCu8tivabi8ity<T>(string _0xHFroze2, ref T _0xH0au)
	{
		if (_0xHM55d != 0)
		{
			throw new InvalidOperationException();
		}
		if (!_0xHPunc4ua4or)
		{
			return;
		}
		_0xHM55d = _0xHStubborn2y.Stopped;
		if (_0xHFroze2 == null)
		{
			_0xHFroze2 = _0xHI8inera8es;
			if (_0xHFroze2.EndsWith("Start"))
			{
				_0xHFroze2 = _0xHFroze2.Substring(0, checked(_0xHFroze2.Length - 5));
			}
			_0xHFroze2 += "Stop";
		}
		_0xHEmb5sks._0xHEne2gumen = _0xHK7z7tsky.Stop;
		_0xH6nafu._0xHTo2y2(_0xHFroze2, ref _0xHEmb5sks, ref _0xHImmitig7bly, ref _0xHMegacitie1, ref _0xH0au);
	}
}
