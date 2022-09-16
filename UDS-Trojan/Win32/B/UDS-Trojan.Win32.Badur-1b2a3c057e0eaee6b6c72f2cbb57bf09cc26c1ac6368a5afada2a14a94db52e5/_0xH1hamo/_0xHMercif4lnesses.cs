using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Security;
using _0xHD2ves;
using _0xHDaphn6s;
using _0xHG6uziness;
using _0xHI3dustriously;
using _0xHMisd1er;
using _0xHSigm1te;
using _0xHSnorke7er;

namespace _0xH1hamo;

public class _0xHMercif4lnesses : EventArgs
{
	private string _0xHAff4r4nts;

	private string _0xHAmida8e8;

	private _0xH2wooned _0xHF4rmh4nd;

	private ReadOnlyCollection<string> _0xHInte7individual;

	internal _0xHParam0t0riz0 _0xH5leeker;

	internal _0xHK7z7tsky _0xHT4agi;

	internal _0xHFire0ots _0xHBe3lics;

	internal _0xHSov8r8ignti8s _0xHKera5o5ic;

	public string _0xHSaur5an
	{
		get
		{
			if (_0xHAmida8e8 == null && _0xHL1bs >= 0)
			{
				return _0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHChol3nes;
			}
			return _0xHAmida8e8;
		}
		internal set
		{
			_0xHAmida8e8 = value;
		}
	}

	public int _0xHL1bs { get; internal set; }

	public Guid _0xHGa7enite
	{
		[SecurityCritical]
		get
		{
			return _0xH2wooned._0xHSuper1odels;
		}
	}

	public Guid _0xH2rahma
	{
		[SecurityCritical]
		get;
		internal set; }

	public ReadOnlyCollection<object> _0xHC4mer4men { get; internal set; }

	public ReadOnlyCollection<string> _0xH1etalware
	{
		get
		{
			if (_0xHInte7individual == null)
			{
				List<string> list = new List<string>();
				ParameterInfo[] _0xHP4nst4r = _0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHP4nst4r;
				foreach (ParameterInfo parameterInfo in _0xHP4nst4r)
				{
					list.Add(parameterInfo.Name);
				}
				_0xHInte7individual = new ReadOnlyCollection<string>(list);
			}
			return _0xHInte7individual;
		}
		internal set
		{
			_0xHInte7individual = value;
		}
	}

	public _0xH2wooned _0xHBlar1eyi1g => _0xHF4rmh4nd;

	public _0xHSov8r8ignti8s _0xHBrai11ed
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xHKera5o5ic;
			}
			return (_0xHSov8r8ignti8s)_0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHOmn4vorous._0xHM5rc5tos;
		}
	}

	public _0xHK7z7tsky _0xHSwivin3
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xHT4agi;
			}
			return (_0xHK7z7tsky)_0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHOmn4vorous._0xHS0lfinpyrazone;
		}
	}

	public _0xHIn1lows _0xHR7m7l
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xHIn1lows.None;
			}
			return (_0xHIn1lows)_0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHOmn4vorous._0xHMun6c6pal;
		}
	}

	public _0xHParam0t0riz0 _0xHSearchin3
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xH5leeker;
			}
			return _0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHSepta1ia;
		}
	}

	public string _0xH3rubbiness
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xHAff4r4nts;
			}
			return _0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHDel4e;
		}
		internal set
		{
			_0xHAff4r4nts = value;
		}
	}

	public _0xHSummar4ses _0xHBac8dates
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xHSummar4ses.None;
			}
			return (_0xHSummar4ses)_0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHOmn4vorous._0xHAbste2tio2;
		}
	}

	public byte _0xHFruct0f0ed
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return 0;
			}
			return _0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHOmn4vorous._0xHInland6rs;
		}
	}

	public _0xHFire0ots _0xHMi33etting
	{
		get
		{
			if (_0xHL1bs < 0)
			{
				return _0xHBe3lics;
			}
			return (_0xHFire0ots)_0xHF4rmh4nd._0xHTran3udation3[_0xHL1bs]._0xHOmn4vorous._0xHPu4posefully;
		}
	}

	internal _0xHMercif4lnesses(_0xH2wooned eventSource)
	{
		_0xHF4rmh4nd = eventSource;
	}
}
