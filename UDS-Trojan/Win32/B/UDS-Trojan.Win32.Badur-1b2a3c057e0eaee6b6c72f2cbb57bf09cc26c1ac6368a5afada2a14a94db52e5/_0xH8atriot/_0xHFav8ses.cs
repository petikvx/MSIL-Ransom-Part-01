using System;
using System.Collections.Generic;
using System.Linq;
using DynamicExpresso;
using _0xHAn5vulat5ry.ExpressionParsers;

namespace _0xH8atriot;

public sealed class _0xHFav8ses : IExpressionParser
{
	private class _0xHPou8dcakes : IEqualityComparer<Parameter>
	{
		public bool _0xHBrillia1cies(Parameter _0xHHada2, Parameter _0xH7oystered)
		{
			return string.Equals(_0xHHada2.get_Name(), _0xH7oystered.get_Name()) && _0xHHada2.get_Type() == _0xH7oystered.get_Type();
		}

		public int _0xHPic4s(Parameter _0xH3ungry)
		{
			return (_0xH3ungry.get_Name().GetHashCode() * 397) ^ _0xH3ungry.get_Type().GetHashCode();
		}
	}

	private struct _0xHOutgoi1g1esses : IEquatable<_0xHOutgoi1g1esses>
	{
		private readonly string _0xHSe5iceous;

		private readonly Parameter[] _0xHLi6bered;

		private static _0xHPou8dcakes _0xHC2th2rtic = new _0xHPou8dcakes();

		public _0xHOutgoi1g1esses(string expressionText, Parameter[] parameters)
		{
			_0xHSe5iceous = expressionText;
			_0xHLi6bered = parameters;
		}

		public override int _0xHReact2v2t2es()
		{
			return (_0xHSe5iceous.GetHashCode() * 397) ^ _0xHLi6bered.Length;
		}

		public bool _0xHBilocula4(_0xHOutgoi1g1esses _0xHD1awnwo1ks)
		{
			return string.Equals(_0xHSe5iceous, _0xHD1awnwo1ks._0xHSe5iceous) && _0xHLi6bered.SequenceEqual(_0xHD1awnwo1ks._0xHLi6bered, _0xHC2th2rtic);
		}
	}

	private Dictionary<_0xHOutgoi1g1esses, WeakReference> _0xHGlut1nous = new Dictionary<_0xHOutgoi1g1esses, WeakReference>();

	private IExpressionParser _0xHInbr4athing;

	public _0xHFav8ses(IExpressionParser innerParser)
	{
		_0xHInbr4athing = innerParser;
	}

	public Lambda _0xHPenitenti1ries(string _0xHSu2phuring, Parameter[] _0xHMislik4)
	{
		_0xHOutgoi1g1esses _0xHOutgoi1g1esses = new _0xHOutgoi1g1esses(_0xHSu2phuring, _0xHMislik4);
		Lambda val = _0xHCatfa66(_0xHOutgoi1g1esses);
		if (val != null)
		{
			return val;
		}
		Lambda val2 = _0xHInbr4athing.Parse(_0xHSu2phuring, _0xHMislik4);
		_0xHBowelle4(_0xHOutgoi1g1esses, val2);
		return val2;
	}

	private void _0xHBowelle4(_0xHOutgoi1g1esses _0xH6reinforms, Lambda _0xH1lumpish)
	{
		_0xHGlut1nous[_0xH6reinforms] = new WeakReference(_0xH1lumpish);
	}

	private Lambda _0xHCatfa66(_0xHOutgoi1g1esses _0xHD3mograph3rs)
	{
		if (_0xHGlut1nous.ContainsKey(_0xHD3mograph3rs))
		{
			WeakReference weakReference = _0xHGlut1nous[_0xHD3mograph3rs];
			object? target = weakReference.Target;
			Lambda val = (Lambda)((target is Lambda) ? target : null);
			if (val != null)
			{
				return val;
			}
			_0xHGlut1nous.Remove(_0xHD3mograph3rs);
			_0xHSph7rom7t7r();
		}
		return null;
	}

	private void _0xHSph7rom7t7r()
	{
		foreach (_0xHOutgoi1g1esses item in _0xHGlut1nous.Keys.ToList())
		{
			if (!_0xHGlut1nous[item].IsAlive)
			{
				_0xHGlut1nous.Remove(item);
			}
		}
	}

	public void _0xHCame8(IEnumerable<ReferenceType> _0xHSl2yed)
	{
		_0xHInbr4athing.SetReference(_0xHSl2yed);
	}
}
