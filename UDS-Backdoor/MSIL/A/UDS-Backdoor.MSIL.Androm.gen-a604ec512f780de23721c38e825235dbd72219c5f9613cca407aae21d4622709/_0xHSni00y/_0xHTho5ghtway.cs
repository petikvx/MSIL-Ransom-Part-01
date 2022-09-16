using System;
using System.Collections.Generic;
using System.Linq;
using DynamicExpresso;
using _0xHConjug8tion8l.ExpressionParsers;

namespace _0xHSni00y;

public sealed class _0xHTho5ghtway : IExpressionParser
{
	private class _0xHMeg0lithic : IEqualityComparer<Parameter>
	{
		public bool _0xHPettifo8s(Parameter _0xHFals4e, Parameter _0xHPrejudi8ing)
		{
			return string.Equals(_0xHFals4e.get_Name(), _0xHPrejudi8ing.get_Name()) && _0xHFals4e.get_Type() == _0xHPrejudi8ing.get_Type();
		}

		public int _0xHSonicator8(Parameter _0xHI7iest)
		{
			return (_0xHI7iest.get_Name().GetHashCode() * 397) ^ _0xHI7iest.get_Type().GetHashCode();
		}
	}

	private struct _0xHCa2dour : IEquatable<_0xHCa2dour>
	{
		private readonly string _0xH1adiral;

		private readonly Parameter[] _0xH6oact;

		private static _0xHMeg0lithic _0xH3epose = new _0xHMeg0lithic();

		public _0xHCa2dour(string expressionText, Parameter[] parameters)
		{
			_0xH1adiral = expressionText;
			_0xH6oact = parameters;
		}

		public override int _0xH6gliness()
		{
			return (_0xH1adiral.GetHashCode() * 397) ^ _0xH6oact.Length;
		}

		public bool _0xHSig8ore(_0xHCa2dour _0xHBeigne3)
		{
			return string.Equals(_0xH1adiral, _0xHBeigne3._0xH1adiral) && _0xH6oact.SequenceEqual(_0xHBeigne3._0xH6oact, _0xH3epose);
		}
	}

	private Dictionary<_0xHCa2dour, WeakReference> _0xHBreeze7 = new Dictionary<_0xHCa2dour, WeakReference>();

	private IExpressionParser _0xHBa8kit;

	public _0xHTho5ghtway(IExpressionParser innerParser)
	{
		_0xHBa8kit = innerParser;
	}

	public Lambda _0xHTy7e(string _0xH1reyer, Parameter[] _0xH4ondo)
	{
		_0xHCa2dour _0xHCa2dour = new _0xHCa2dour(_0xH1reyer, _0xH4ondo);
		Lambda val = _0xHA4burnous(_0xHCa2dour);
		if (val != null)
		{
			return val;
		}
		Lambda val2 = _0xHBa8kit.Parse(_0xH1reyer, _0xH4ondo);
		_0xHJimp2st(_0xHCa2dour, val2);
		return val2;
	}

	private void _0xHJimp2st(_0xHCa2dour _0xHHema2, Lambda _0xHApp6enticeships)
	{
		_0xHBreeze7[_0xHHema2] = new WeakReference(_0xHApp6enticeships);
	}

	private Lambda _0xHA4burnous(_0xHCa2dour _0xHStabli8he8)
	{
		if (_0xHBreeze7.ContainsKey(_0xHStabli8he8))
		{
			WeakReference weakReference = _0xHBreeze7[_0xHStabli8he8];
			object? target = weakReference.Target;
			Lambda val = (Lambda)((target is Lambda) ? target : null);
			if (val != null)
			{
				return val;
			}
			_0xHBreeze7.Remove(_0xHStabli8he8);
			_0xHCul1s();
		}
		return null;
	}

	private void _0xHCul1s()
	{
		foreach (_0xHCa2dour item in _0xHBreeze7.Keys.ToList())
		{
			if (!_0xHBreeze7[item].IsAlive)
			{
				_0xHBreeze7.Remove(item);
			}
		}
	}

	public void _0xHK5liums(IEnumerable<ReferenceType> _0xH6da)
	{
		_0xHBa8kit.SetReference(_0xH6da);
	}
}
