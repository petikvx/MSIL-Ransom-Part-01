using System;
using System.Collections.Generic;
using System.Threading;
using _0xHD2ves;
using _0xHI3dustriously;
using _0xHOppor4unis4;
using _0xHOxidasi7;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHWrathe6;

namespace _0xHRock7t7d;

internal abstract class _0xH0amplers<DataType> : _0xHMit1genic
{
	private static _0xHRock7t7d._0xH0amplers<DataType> _0xHE3hilarate;

	public static _0xHRock7t7d._0xH0amplers<DataType> _0xHM1l1ng1s => _0xHRock7t7d._0xH0amplers<DataType>.instance ?? _0xHRock7t7d._0xH0amplers<DataType>.InitInstance();

	protected _0xH0amplers()
		: base(typeof(DataType))
	{
	}

	protected _0xH0amplers(string name, _0xHFire0ots level, _0xHK7z7tsky opcode, _0xHSov8r8ignti8s keywords, _0xHParam0t0riz0 tags)
		: base(typeof(DataType), name, level, opcode, keywords, tags)
	{
	}

	public abstract void _0xHBen5(_0xHFlag4llat4s _0xHAuto5ata, ref DataType _0xHGa2of);

	public override void _0xHFili4ustered(_0xHFlag4llat4s _0xHCircumve1ti1g, object _0xHD2gs)
	{
		DataType val = ((_0xHD2gs == null) ? default(DataType) : ((DataType)_0xHD2gs));
		this.WriteData(_0xHCircumve1ti1g, ref val);
	}

	internal static _0xHRock7t7d._0xH0amplers<DataType> _0xHSt4tistic(List<Type> _0xHSqui6ches)
	{
		if (_0xHRock7t7d._0xH0amplers<DataType>.instance == null)
		{
			int count = _0xHSqui6ches.Count;
			_0xHRock7t7d._0xH0amplers<DataType> value = _0xHHy4ercriticisms._0xHPo3ers<DataType>(_0xHSqui6ches);
			Interlocked.CompareExchange(ref _0xHRock7t7d._0xH0amplers<DataType>.instance, value, null);
			_0xHSqui6ches.RemoveRange(count, checked(_0xHSqui6ches.Count - count));
		}
		return _0xHRock7t7d._0xH0amplers<DataType>.instance;
	}

	private static _0xHRock7t7d._0xH0amplers<DataType> _0xH2onventional()
	{
		return _0xHRock7t7d._0xH0amplers<DataType>.GetInstance(new List<Type>());
	}
}
