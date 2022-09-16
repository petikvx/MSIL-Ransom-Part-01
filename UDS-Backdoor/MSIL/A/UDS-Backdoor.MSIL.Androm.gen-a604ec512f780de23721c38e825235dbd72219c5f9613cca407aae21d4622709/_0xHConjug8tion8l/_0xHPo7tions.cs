using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Data;
using DynamicExpresso;
using _0xHConjug8tion8l.ExpressionParsers;
using _0xHConjug8tion8l.Inversion;
using _0xHConjug8tion8l.Trace;
using _0xHGree4some;
using _0xHRightfulne33e3;

namespace _0xHConjug8tion8l;

public class _0xHPo7tions : IMultiValueConverter, IValueConverter
{
	private IExpressionParser _0xH8leuthhound;

	private readonly object _0xHK4logram;

	private Lambda _0xHF5ontmen;

	private Lambda _0xHSuperm5cho;

	private Type[] _0xHCisc3s;

	private static readonly _0xHLit2ograp2ing _0xHTrapline2 = new _0xHLit2ograp2ing(_0xHCy4oly4ic.CalcConverter);

	public bool _0xHF5eshly { get; set; }

	public _0xHPerman4anate _0xHJass8d { get; set; }

	public _0xHPo7tions(IExpressionParser parser, object fallbackValue, Dictionary<string, Type> enums)
	{
		_0xH3owwowed = _0xHPerman4anate.Collapsed;
		base._002Ector();
		_0xH8leuthhound = parser;
		_0xHK4logram = fallbackValue;
		if (parser != null && enums != null && enums.Any())
		{
			parser.SetReference(((IEnumerable<KeyValuePair<string, Type>>)enums).Select((Func<KeyValuePair<string, Type>, ReferenceType>)((KeyValuePair<string, Type> ep) => new ReferenceType(ep.Key, ep.Value))));
		}
	}

	public object _0xHY8gh(object _0xHBe8oken, Type _0xHDinero5, object _0xHRosel0ke, CultureInfo _0xHO2ioid)
	{
		return _0xHCombustib7e(new object[1] { _0xHBe8oken }, _0xHDinero5, _0xHRosel0ke, _0xHO2ioid);
	}

	public object _0xH1stracodes(object _0xHKlut2y, Type _0xHInvader0, object _0xH6hiefships, CultureInfo _0xHUnd6rl6tting)
	{
		if (_0xHF5ontmen == null && (_0xHF5ontmen = _0xHCo5ottes(null, (string)_0xH6hiefships, _0xHSen4imen4alisms: true, new List<Type> { _0xHInvader0 })) == null)
		{
			return null;
		}
		if (_0xHSuperm5cho == null)
		{
			try
			{
				Type type = _0xHF5ontmen.get_Expression().Type;
				ParameterExpression _0xHSumle = Expression.Parameter(type, "Path");
				_0xHSuperm5cho = new _0xHMo1e1(_0xH8leuthhound)._0xHCz7ritz7s(_0xHF5ontmen.get_Expression(), _0xHSumle);
			}
			catch (Exception ex)
			{
				_0xHTrapline2._0xH7conomized("Can't convert back expression " + _0xH6hiefships?.ToString() + ": " + ex.Message);
			}
		}
		if (_0xHSuperm5cho != null)
		{
			try
			{
				if (_0xHInvader0 == typeof(bool) && _0xHKlut2y.GetType() == typeof(Visibility))
				{
					_0xHKlut2y = new _0xHBipar5i5e(_0xHJass8d)._0xHDysp2ptically(_0xHKlut2y, _0xHInvader0, null, _0xHUnd6rl6tting);
				}
				if (_0xHKlut2y is string && _0xHF5ontmen.get_Expression().Type != _0xHKlut2y.GetType())
				{
					_0xHKlut2y = _0xHQ8e8ed((string)_0xHKlut2y, _0xHF5ontmen.get_Expression().Type);
				}
				return _0xHSuperm5cho.Invoke(new object[1] { _0xHKlut2y });
			}
			catch (Exception ex2)
			{
				_0xHTrapline2._0xH7conomized("Can't invoke back expression " + _0xH6hiefships?.ToString() + ": " + ex2.Message);
			}
		}
		return null;
	}

	private object _0xHQ8e8ed(string _0xHRemarq4e, Type _0xHAzu2ite)
	{
		return Convert.ChangeType(_0xHRemarq4e, _0xHAzu2ite, CultureInfo.InvariantCulture);
	}

	public object _0xHCombustib7e(object[] _0xHFo2malizes, Type _0xH7enses, object _0xH0atchpole, CultureInfo _0xHE4ception)
	{
		if (_0xHFo2malizes == null)
		{
			return null;
		}
		if (_0xHCisc3s == null)
		{
			_0xHCisc3s = _0xHMeta4ize(_0xHFo2malizes);
		}
		else
		{
			Type[] second = _0xHMeta4ize(_0xHFo2malizes);
			if (!_0xHCisc3s.SequenceEqual(second))
			{
				_0xHCisc3s = second;
				_0xHF5ontmen = null;
				_0xHSuperm5cho = null;
			}
		}
		if (_0xHF5ontmen == null && (_0xHF5ontmen = _0xHCo5ottes(_0xHFo2malizes, (string)_0xH0atchpole)) == null)
		{
			return _0xHK4logram;
		}
		try
		{
			object obj = _0xHF5ontmen.Invoke(_0xHFo2malizes);
			if (!_0xHF5eshly)
			{
				if (_0xH7enses == typeof(Visibility) && !(obj is Visibility))
				{
					obj = new _0xHBipar5i5e(_0xHJass8d)._0xH8urgers(obj, _0xH7enses, null, _0xHE4ception);
				}
				if (_0xH7enses == typeof(string))
				{
					obj = string.Format(CultureInfo.InvariantCulture, "{0}", new object[1] { obj });
				}
			}
			return obj;
		}
		catch (Exception ex)
		{
			_0xHTrapline2._0xH7conomized("Can't invoke expression " + _0xHF5ontmen.get_ExpressionText() + ": " + ex.Message);
			return null;
		}
	}

	private Type[] _0xHMeta4ize(object[] _0xHSup3rc3d3)
	{
		return _0xHSup3rc3d3.Select((object v) => v?.GetType()).ToArray();
	}

	private Lambda _0xHCo5ottes(object[] _0xH1uns, string _0xHBacterem3a, bool _0xHSen4imen4alisms = false, List<Type> _0xHSupe7fluidities = null)
	{
		try
		{
			Lambda result = null;
			bool flag = false;
			if (_0xHSen4imen4alisms)
			{
				flag = true;
			}
			else if (_0xH1uns.Contains(DependencyProperty.UnsetValue))
			{
				_0xHTrapline2._0xH7conomized("One of source fields is Unset");
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				List<Type> _0xH8idestepping = (_0xHSen4imen4alisms ? _0xHSupe7fluidities : _0xHCisc3s.Select((Type t) => t ?? typeof(object)).ToList());
				result = _0xHI6tersterility(_0xH8idestepping, _0xHBacterem3a);
			}
			return result;
		}
		catch (Exception ex)
		{
			_0xHTrapline2._0xH7conomized("Can't convert expression " + _0xHBacterem3a + ": " + ex.Message);
			return null;
		}
	}

	private Lambda _0xHI6tersterility(List<Type> _0xH8idestepping, string _0xHVaru2)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		List<Parameter> list = new List<Parameter>();
		for (int i = 0; i < _0xH8idestepping.Count(); i++)
		{
			string text = _0xHRec2lling(i);
			_0xHVaru2 = _0xHVaru2.Replace("{" + i + "}", text);
			list.Add(new Parameter(text, _0xH8idestepping[i], (object)null));
		}
		return _0xH8leuthhound.Parse(_0xHVaru2, list.ToArray());
	}

	private string _0xHRec2lling(int _0xHIn2oherently)
	{
		return $"p{++_0xHIn2oherently}";
	}

	public object[] _0xHA55reciators(object _0xH4widdlers, Type[] _0xHDetox1f1cat1ons, object _0xH2lessing, CultureInfo _0xHImpe4ialistic)
	{
		throw new NotSupportedException();
	}
}
