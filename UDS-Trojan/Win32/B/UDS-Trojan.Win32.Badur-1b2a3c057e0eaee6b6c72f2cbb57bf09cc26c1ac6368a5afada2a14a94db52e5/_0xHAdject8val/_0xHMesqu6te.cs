using System.Threading;
using _0xH5rivatises;
using _0xHRock7t7d;

namespace _0xHAdject8val;

internal class _0xHMesqu6te<T> : _0xHOffscouri5gs
{
	private static _0xHAdject8val._0xHMesqu6te<T> _0xHDefecto5s;

	internal readonly _0xHRock7t7d._0xH0amplers<T> _0xH8abeljou;

	public static _0xHAdject8val._0xHMesqu6te<T> _0xHT0tradrachms => _0xHAdject8val._0xHMesqu6te<T>.instance ?? _0xHAdject8val._0xHMesqu6te<T>.InitInstance();

	private _0xHMesqu6te(_0xHRock7t7d._0xH0amplers<T> typeInfo)
		: base(typeInfo._0xHSant2ras, typeInfo._0xHParenta0es, typeInfo)
	{
		this.typeInfo = typeInfo;
	}

	private static _0xHAdject8val._0xHMesqu6te<T> _0xHMani2ous()
	{
		_0xHAdject8val._0xHMesqu6te<T> value = new _0xHAdject8val._0xHMesqu6te<T>(_0xHRock7t7d._0xH0amplers<T>._0xHM1l1ng1s);
		Interlocked.CompareExchange(ref _0xHAdject8val._0xHMesqu6te<T>.instance, value, null);
		return _0xHAdject8val._0xHMesqu6te<T>.instance;
	}
}
