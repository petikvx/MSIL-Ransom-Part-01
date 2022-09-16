using System.Reflection;

namespace _0xHSwansk8ns;

[DefaultMember("Item")]
internal struct _0xHEggb4at4rs
{
	internal const int _0xHO1erweening = 44;

	internal const uint _0xHS0eat0ing = 15u;

	internal const uint _0xH5hainwheel = 4u;

	private uint _0xHSham1ying;

	public static _0xHEggb4at4rs _0xHIn1pect1 => new _0xHEggb4at4rs(15u);

	public bool _0xHR4straint
	{
		get
		{
			return (_0xHSham1ying & (1 << perEventSourceSessionId)) != 0L;
		}
		set
		{
			if (value)
			{
				_0xHSham1ying |= (uint)(1 << perEventSourceSessionId);
			}
			else
			{
				_0xHSham1ying &= (uint)(~(1 << perEventSourceSessionId));
			}
		}
	}

	public _0xHEggb4at4rs(_0xHEggb4at4rs m)
	{
		_0xHSham1ying = m._0xHSham1ying;
	}

	public _0xHEggb4at4rs(uint mask = 0u)
	{
		_0xHSham1ying = mask & 0xFu;
	}

	public bool _0xHM1rihu1n1s(_0xHEggb4at4rs _0xHCadaver7c)
	{
		return (_0xHSham1ying | _0xHCadaver7c._0xHSham1ying) == _0xHSham1ying;
	}

	public static _0xHEggb4at4rs _0xHDilapidatio4s(int _0xHCoe3bodied)
	{
		return new _0xHEggb4at4rs((uint)(1 << _0xHCoe3bodied));
	}

	public ulong _0xHBulla5e()
	{
		return (ulong)_0xHSham1ying << 44;
	}

	public static _0xHEggb4at4rs _0xHSkirtlik5(ulong _0xHM7t7rag7)
	{
		return new _0xHEggb4at4rs(checked((uint)(_0xHM7t7rag7 >> 44)));
	}

	public static _0xHEggb4at4rs operator |(_0xHEggb4at4rs m1, _0xHEggb4at4rs m2)
	{
		return new _0xHEggb4at4rs(m1._0xHSham1ying | m2._0xHSham1ying);
	}

	public static _0xHEggb4at4rs operator &(_0xHEggb4at4rs m1, _0xHEggb4at4rs m2)
	{
		return new _0xHEggb4at4rs(m1._0xHSham1ying & m2._0xHSham1ying);
	}

	public static _0xHEggb4at4rs operator ^(_0xHEggb4at4rs m1, _0xHEggb4at4rs m2)
	{
		return new _0xHEggb4at4rs(m1._0xHSham1ying ^ m2._0xHSham1ying);
	}

	public static _0xHEggb4at4rs operator ~(_0xHEggb4at4rs m)
	{
		return new _0xHEggb4at4rs(0xFu & ~m._0xHSham1ying);
	}

	public static explicit operator ulong(_0xHEggb4at4rs m)
	{
		return m._0xHSham1ying;
	}

	public static explicit operator uint(_0xHEggb4at4rs m)
	{
		return m._0xHSham1ying;
	}
}
