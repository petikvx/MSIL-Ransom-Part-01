using System;
using System.Collections.Generic;
using System.Reflection;
using _0xH6yplays;
using _0xHBot0ers;
using _0xHD2ves;
using _0xHI3dustriously;
using _0xHIn7eigler;
using _0xHOxidasi7;
using _0xHRolf3rs;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHWrathe6;

namespace _0xH5rivatises;

internal class _0xHOffscouri5gs
{
	internal readonly _0xHMit1genic[] _0xHScruffi7esses;

	internal readonly string _0xHGauz5nesses;

	internal readonly _0xHParam0t0riz0 _0xHBra44les;

	internal readonly byte _0xHBu1dle;

	internal readonly byte _0xHDar1i1g;

	internal readonly _0xHSov8r8ignti8s _0xHUngain4iness;

	internal readonly byte[] _0xHUnabashed3y;

	internal readonly int _0xHUpscalin3;

	internal readonly int _0xHFri6ged;

	internal readonly int _0xHUn8ined;

	private _0xHRolf3rs._0xHDoss1ers<KeyValuePair<string, _0xHParam0t0riz0>, _0xH0yssops> _0xHEr5ditions;

	internal string _0xHL0ngridge => _0xHGauz5nesses;

	internal _0xHFire0ots _0xHBombin4ting => (_0xHFire0ots)_0xHBu1dle;

	internal _0xHK7z7tsky _0xHBrecc8ated => (_0xHK7z7tsky)_0xHDar1i1g;

	internal _0xHSov8r8ignti8s _0xHR0tinit0s => _0xHUngain4iness;

	internal _0xHParam0t0riz0 _0xHC5llulit5s => _0xHBra44les;

	internal _0xHOffscouri5gs(string name, _0xHParam0t0riz0 tags, params Type[] types)
		: this(tags, name, _0xHTransli3era3ion(types))
	{
	}

	internal _0xHOffscouri5gs(string name, _0xHParam0t0riz0 tags, params _0xHMit1genic[] typeInfos)
		: this(tags, name, _0xHPo0iticizes(typeInfos))
	{
	}

	internal _0xHOffscouri5gs(string name, _0xHParam0t0riz0 tags, ParameterInfo[] paramInfos)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		_0xHScruffi7esses = _0xHV5ccini5(paramInfos);
		_0xHGauz5nesses = name;
		_0xHBra44les = tags;
		_0xHBu1dle = 5;
		_0xHSignalization1 _0xHSignalization = new _0xHSignalization1();
		for (int i = 0; i < _0xHScruffi7esses.Length; i = checked(i + 1))
		{
			_0xHMit1genic _0xHMit1genic = _0xHScruffi7esses[i];
			_0xHBu1dle = _0xHHy4ercriticisms._0xHImp1lsion((int)_0xHMit1genic._0xHI5te5di5g, _0xHBu1dle);
			_0xHDar1i1g = _0xHHy4ercriticisms._0xHImp1lsion((int)_0xHMit1genic._0xHHyp6pneas, _0xHDar1i1g);
			_0xHUngain4iness |= _0xHMit1genic._0xHCh8mp;
			string text = paramInfos[i].Name;
			if (_0xHHy4ercriticisms._0xHDo7bt(text))
			{
				text = _0xHMit1genic._0xHSant2ras;
			}
			_0xHMit1genic._0xHMispa4ched(_0xHSignalization, text, _0xHGri22ery.Default);
		}
		_0xHUnabashed3y = _0xHSignalization._0xH3oggia();
		_0xHUpscalin3 = _0xHSignalization._0xH6ocent;
		_0xHFri6ged = _0xHSignalization._0xHTo77ee;
		_0xHUn8ined = _0xHSignalization._0xHE4dleafs;
	}

	private _0xHOffscouri5gs(_0xHParam0t0riz0 tags, string defaultName, _0xHMit1genic[] typeInfos)
	{
		if (defaultName == null)
		{
			throw new ArgumentNullException("defaultName");
		}
		_0xHScruffi7esses = typeInfos;
		_0xHGauz5nesses = defaultName;
		_0xHBra44les = tags;
		_0xHBu1dle = 5;
		_0xHSignalization1 _0xHSignalization = new _0xHSignalization1();
		foreach (_0xHMit1genic _0xHMit1genic in typeInfos)
		{
			_0xHBu1dle = _0xHHy4ercriticisms._0xHImp1lsion((int)_0xHMit1genic._0xHI5te5di5g, _0xHBu1dle);
			_0xHDar1i1g = _0xHHy4ercriticisms._0xHImp1lsion((int)_0xHMit1genic._0xHHyp6pneas, _0xHDar1i1g);
			_0xHUngain4iness |= _0xHMit1genic._0xHCh8mp;
			_0xHMit1genic._0xHMispa4ched(_0xHSignalization, null, _0xHGri22ery.Default);
		}
		_0xHUnabashed3y = _0xHSignalization._0xH3oggia();
		_0xHUpscalin3 = _0xHSignalization._0xH6ocent;
		_0xHFri6ged = _0xHSignalization._0xHTo77ee;
		_0xHUn8ined = _0xHSignalization._0xHE4dleafs;
	}

	internal _0xH0yssops _0xHA22emble(string _0xHRov0, _0xHParam0t0riz0 _0xHWoodr8ffs)
	{
		_0xH0yssops _0xH0yssops = _0xHEr5ditions.TryGet(new KeyValuePair<string, _0xHParam0t0riz0>(_0xHRov0, _0xHWoodr8ffs));
		if (_0xH0yssops == null)
		{
			_0xH0yssops = _0xHEr5ditions.GetOrAdd(new _0xH0yssops(_0xHRov0, _0xHWoodr8ffs, _0xHUnabashed3y.Length));
		}
		return _0xH0yssops;
	}

	private _0xHMit1genic[] _0xHV5ccini5(ParameterInfo[] _0xHP22ves)
	{
		if (_0xHP22ves == null)
		{
			throw new ArgumentNullException("paramInfos");
		}
		List<Type> _0xHTess8turas = new List<Type>(_0xHP22ves.Length);
		_0xHMit1genic[] array = new _0xHMit1genic[_0xHP22ves.Length];
		for (int i = 0; i < _0xHP22ves.Length; i = checked(i + 1))
		{
			array[i] = _0xHHy4ercriticisms._0xHR2viv2r(_0xHP22ves[i].ParameterType, _0xHTess8turas);
		}
		return array;
	}

	private static _0xHMit1genic[] _0xHTransli3era3ion(Type[] _0xH6rae)
	{
		if (_0xH6rae == null)
		{
			throw new ArgumentNullException("types");
		}
		List<Type> _0xHTess8turas = new List<Type>(_0xH6rae.Length);
		_0xHMit1genic[] array = new _0xHMit1genic[_0xH6rae.Length];
		for (int i = 0; i < _0xH6rae.Length; i = checked(i + 1))
		{
			array[i] = _0xHHy4ercriticisms._0xHR2viv2r(_0xH6rae[i], _0xHTess8turas);
		}
		return array;
	}

	private static _0xHMit1genic[] _0xHPo0iticizes(_0xHMit1genic[] _0xHL5pins)
	{
		if (_0xHL5pins == null)
		{
			throw new ArgumentNullException("typeInfos");
		}
		return (_0xHMit1genic[])_0xHL5pins.Clone();
	}
}
