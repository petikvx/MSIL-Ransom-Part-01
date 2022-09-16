using System;

namespace _0xHAn5vulat5ry.PathAnalysis;

public class _0xH4ignory : _0xHD8et8t8ans
{
	private _0xHArboresce4ce _0xHHumdi2ger;

	public Type _0xHAls2kes { get; private set; }

	public string _0xH6thephons { get; private set; }

	public string _0xHP8stif8rous { get; private set; }

	public override _0xHArboresce4ce _0xHAntic2lt => _0xHHumdi2ger;

	public _0xH4ignory(int start, int end, string @namespace, Type @enum, string enumMember)
		: base(start, end)
	{
		_0xHAls2kes = @enum;
		_0xH6thephons = enumMember;
		_0xHP8stif8rous = @namespace;
		_0xHHumdi2ger = new _0xHArboresce4ce(_0xH5heath.Enum, $"{_0xHP8stif8rous}:{@enum.Name}.{_0xH6thephons}");
	}
}
