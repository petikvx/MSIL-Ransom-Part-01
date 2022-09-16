using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Data;
using DynamicExpresso;
using _0xH1reviced;
using _0xHAdo0tees;
using _0xHAn5vulat5ry.ExpressionParsers;
using _0xHAn5vulat5ry.Inversion;
using _0xHAn5vulat5ry.Trace;

namespace _0xHAn5vulat5ry;

public class _0xHC2n2rd : IMultiValueConverter, IValueConverter
{
	private IExpressionParser _0xHCoura2toes;

	private readonly object _0xHDecon1amina1ed;

	private Lambda _0xHCh55sin5ss;

	private Lambda _0xHVi2oroso;

	private Type[] _0xHSour3st;

	private static readonly _0xHTru8blu8 _0xHK4ne = new _0xHTru8blu8(_0xHOch8rous.CalcConverter);

	public bool _0xH5lank { get; set; }

	public _0xH7verlapping _0xHS1l1nology { get; set; }

	public _0xHC2n2rd(IExpressionParser parser, object fallbackValue, Dictionary<string, Type> enums)
	{
		_0xHGlidin3 = _0xH7verlapping.Collapsed;
		base._002Ector();
		_0xHCoura2toes = parser;
		_0xHDecon1amina1ed = fallbackValue;
		if (parser != null && enums != null && enums.Any())
		{
			parser.SetReference(((IEnumerable<KeyValuePair<string, Type>>)enums).Select((Func<KeyValuePair<string, Type>, ReferenceType>)((KeyValuePair<string, Type> ep) => new ReferenceType(ep.Key, ep.Value))));
		}
	}

	public object _0xHM1ss1on1ng(object _0xHS2robilae, Type _0xHPermu7able, object _0xHRehirin6, CultureInfo _0xHHo6ey)
	{
		return _0xHOl3v3n3c(new object[1] { _0xHS2robilae }, _0xHPermu7able, _0xHRehirin6, _0xHHo6ey);
	}

	public object _0xHVaccinato5(object _0xHAg7uti, Type _0xH2rog, object _0xH6nwove, CultureInfo _0xHC6pr6lites)
	{
		if (_0xHCh55sin5ss == null && (_0xHCh55sin5ss = _0xHP0r0lyse(null, (string)_0xH6nwove, _0xHN7tr7ds: true, new List<Type> { _0xH2rog })) == null)
		{
			return null;
		}
		if (_0xHVi2oroso == null)
		{
			try
			{
				Type type = _0xHCh55sin5ss.get_Expression().Type;
				ParameterExpression _0xHTeno0s = Expression.Parameter(type, "Path");
				_0xHVi2oroso = new _0xHR0wir0(_0xHCoura2toes)._0xHJinrick8ha8(_0xHCh55sin5ss.get_Expression(), _0xHTeno0s);
			}
			catch (Exception ex)
			{
				_0xHK4ne._0xHConf3ated("Can't convert back expression " + _0xH6nwove?.ToString() + ": " + ex.Message);
			}
		}
		if (_0xHVi2oroso != null)
		{
			try
			{
				if (_0xH2rog == typeof(bool) && _0xHAg7uti.GetType() == typeof(Visibility))
				{
					_0xHAg7uti = new _0xHLira2(_0xHS1l1nology)._0xHEuryth7rmal(_0xHAg7uti, _0xH2rog, null, _0xHC6pr6lites);
				}
				if (_0xHAg7uti is string && _0xHCh55sin5ss.get_Expression().Type != _0xHAg7uti.GetType())
				{
					_0xHAg7uti = _0xH7nivels((string)_0xHAg7uti, _0xHCh55sin5ss.get_Expression().Type);
				}
				return _0xHVi2oroso.Invoke(new object[1] { _0xHAg7uti });
			}
			catch (Exception ex2)
			{
				_0xHK4ne._0xHConf3ated("Can't invoke back expression " + _0xH6nwove?.ToString() + ": " + ex2.Message);
			}
		}
		return null;
	}

	private object _0xH7nivels(string _0xHE1onomi1, Type _0xHE5der5y)
	{
		return Convert.ChangeType(_0xHE1onomi1, _0xHE5der5y, CultureInfo.InvariantCulture);
	}

	public object _0xHOl3v3n3c(object[] _0xHP8ywood, Type _0xHGrea4hear4edly, object _0xHUnconfo0mity, CultureInfo _0xHN2onatologi2s)
	{
		if (_0xHP8ywood == null)
		{
			return null;
		}
		if (_0xHSour3st == null)
		{
			_0xHSour3st = _0xHHelici2ies(_0xHP8ywood);
		}
		else
		{
			Type[] second = _0xHHelici2ies(_0xHP8ywood);
			if (!_0xHSour3st.SequenceEqual(second))
			{
				_0xHSour3st = second;
				_0xHCh55sin5ss = null;
				_0xHVi2oroso = null;
			}
		}
		if (_0xHCh55sin5ss == null && (_0xHCh55sin5ss = _0xHP0r0lyse(_0xHP8ywood, (string)_0xHUnconfo0mity)) == null)
		{
			return _0xHDecon1amina1ed;
		}
		try
		{
			object obj = _0xHCh55sin5ss.Invoke(_0xHP8ywood);
			if (!_0xH5lank)
			{
				if (_0xHGrea4hear4edly == typeof(Visibility) && !(obj is Visibility))
				{
					obj = new _0xHLira2(_0xHS1l1nology)._0xHT4torage(obj, _0xHGrea4hear4edly, null, _0xHN2onatologi2s);
				}
				if (_0xHGrea4hear4edly == typeof(string))
				{
					obj = string.Format(CultureInfo.InvariantCulture, "{0}", new object[1] { obj });
				}
			}
			return obj;
		}
		catch (Exception ex)
		{
			_0xHK4ne._0xHConf3ated("Can't invoke expression " + _0xHCh55sin5ss.get_ExpressionText() + ": " + ex.Message);
			return null;
		}
	}

	private Type[] _0xHHelici2ies(object[] _0xHUnlighte0)
	{
		return _0xHUnlighte0.Select((object v) => v?.GetType()).ToArray();
	}

	private Lambda _0xHP0r0lyse(object[] _0xHAoris8, string _0xHT3iplicate, bool _0xHN7tr7ds = false, List<Type> _0xHV7r7l7zed = null)
	{
		try
		{
			Lambda result = null;
			bool flag = false;
			if (_0xHN7tr7ds)
			{
				flag = true;
			}
			else if (_0xHAoris8.Contains(DependencyProperty.UnsetValue))
			{
				_0xHK4ne._0xHConf3ated("One of source fields is Unset");
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				List<Type> _0xHHackbe77ies = (_0xHN7tr7ds ? _0xHV7r7l7zed : _0xHSour3st.Select((Type t) => t ?? typeof(object)).ToList());
				result = _0xH0ab(_0xHHackbe77ies, _0xHT3iplicate);
			}
			return result;
		}
		catch (Exception ex)
		{
			_0xHK4ne._0xHConf3ated("Can't convert expression " + _0xHT3iplicate + ": " + ex.Message);
			return null;
		}
	}

	private Lambda _0xH0ab(List<Type> _0xHHackbe77ies, string _0xHCr8ogens)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		List<Parameter> list = new List<Parameter>();
		for (int i = 0; i < _0xHHackbe77ies.Count(); i++)
		{
			string text = _0xHRa88orteur(i);
			_0xHCr8ogens = _0xHCr8ogens.Replace("{" + i + "}", text);
			list.Add(new Parameter(text, _0xHHackbe77ies[i], (object)null));
		}
		return _0xHCoura2toes.Parse(_0xHCr8ogens, list.ToArray());
	}

	private string _0xHRa88orteur(int _0xHOstensib4y)
	{
		return $"p{++_0xHOstensib4y}";
	}

	public object[] _0xHUns2eetened(object _0xHOxidation0, Type[] _0xHFormid2bly, object _0xHAchond1oplasia, CultureInfo _0xHBul8arked)
	{
		throw new NotSupportedException();
	}
}
