using System;
using _0xH6yplays;
using _0xHBot0ers;
using _0xHD2ves;
using _0xHI3dustriously;
using _0xHOppor4unis4;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHWrathe6;

namespace _0xHOxidasi7;

internal abstract class _0xHMit1genic
{
	private readonly string _0xHT4ari4r;

	private readonly _0xHSov8r8ignti8s _0xHPresidi4;

	private readonly _0xHFire0ots _0xHOve00egulation = (_0xHFire0ots)(-1);

	private readonly _0xHK7z7tsky _0xHPrepp3 = (_0xHK7z7tsky)(-1);

	private readonly _0xHParam0t0riz0 _0xHPri5ers;

	private readonly Type _0xHP6sch6ls;

	public string _0xHSant2ras => _0xHT4ari4r;

	public _0xHFire0ots _0xHI5te5di5g => _0xHOve00egulation;

	public _0xHK7z7tsky _0xHHyp6pneas => _0xHPrepp3;

	public _0xHSov8r8ignti8s _0xHCh8mp => _0xHPresidi4;

	public _0xHParam0t0riz0 _0xHParenta0es => _0xHPri5ers;

	internal Type _0xH1egronis => _0xHP6sch6ls;

	internal _0xHMit1genic(Type dataType)
	{
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		_0xHT4ari4r = dataType.Name;
		_0xHP6sch6ls = dataType;
	}

	internal _0xHMit1genic(Type dataType, string name, _0xHFire0ots level, _0xHK7z7tsky opcode, _0xHSov8r8ignti8s keywords, _0xHParam0t0riz0 tags)
	{
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		if (name == null)
		{
			throw new ArgumentNullException("eventName");
		}
		_0xHHy4ercriticisms._0xH4ancetta(name);
		_0xHT4ari4r = name;
		_0xHPresidi4 = keywords;
		_0xHOve00egulation = level;
		_0xHPrepp3 = opcode;
		_0xHPri5ers = tags;
		_0xHP6sch6ls = dataType;
	}

	public abstract void _0xHMispa4ched(_0xHSignalization1 _0xHHeroi0e, string _0xHYa2ningly, _0xHGri22ery _0xH5ealtor);

	public abstract void _0xHInosin1s(_0xHFlag4llat4s _0xHCost6el, object _0xHCeda8y);

	public virtual object _0xHAm7nd7rs(object _0xHPer4dot4tes)
	{
		return _0xHPer4dot4tes;
	}
}
