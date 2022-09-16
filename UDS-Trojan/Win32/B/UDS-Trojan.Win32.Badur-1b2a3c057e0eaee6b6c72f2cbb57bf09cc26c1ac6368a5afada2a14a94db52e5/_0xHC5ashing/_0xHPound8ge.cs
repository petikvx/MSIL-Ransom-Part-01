using System;
using System.Collections.Generic;
using _0xH6yplays;
using _0xH7ifty;
using _0xHBot0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;

namespace _0xHC5ashing;

internal sealed class _0xHPound8ge<T> : _0xHRock7t7d._0xH0amplers<T?> where T : struct
{
	private readonly _0xHRock7t7d._0xH0amplers<T> _0xHCynic7;

	public _0xHPound8ge(List<Type> recursionCheck)
	{
		this.valueInfo = _0xHRock7t7d._0xH0amplers<T>.GetInstance(recursionCheck);
	}

	public override void _0xHM0istening(_0xHSignalization1 _0xHT6lu6l, string _0xHParallelepipe3s, _0xHGri22ery _0xH7italizer)
	{
		_0xHSignalization1 _0xHSignalization = _0xHT6lu6l._0xHReceivable6(_0xHParallelepipe3s);
		_0xHSignalization._0xHGruif1rm("HasValue", _0xHKnea0e0.Boolean8);
		this.valueInfo._0xHMispa4ched(_0xHSignalization, "Value", _0xH7italizer);
	}

	public override void _0xHSummerhou5e5(_0xHFlag4llat4s _0xHJu22ive, ref T? _0xHE4ol4ements)
	{
		bool hasValue = _0xHE4ol4ements.HasValue;
		_0xHJu22ive._0xHJapann8ng(hasValue);
		T val = (hasValue ? _0xHE4ol4ements.Value : default(T));
		this.valueInfo.WriteData(_0xHJu22ive, ref val);
	}
}
