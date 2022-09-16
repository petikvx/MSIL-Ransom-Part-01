#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using DynamicExpresso;
using _0xHConjug8tion8l.ExpressionParsers;
using _0xHCrucifixi7n;

namespace _0xHConjug8tion8l.Inversion;

public class _0xHMo1e1
{
	[DefaultMember("Item")]
	private class _0xHD0fici0nci0s<T> : _0xHConjug8tion8l.Inversion._0xHSh7tt7mwoods<T, _0xHCriticizab1e, _0xHC3nferencings>
	{
		public override _0xHC3nferencings _0xHIn4ight
		{
			get
			{
				Dictionary<_0xHCriticizab1e, _0xHC3nferencings> dictionary = base[key1];
				if (dictionary.ContainsKey(key2))
				{
					return dictionary[key2];
				}
				if (dictionary.ContainsKey(_0xHCriticizab1e.Wherever))
				{
					return dictionary[_0xHCriticizab1e.Wherever];
				}
				return dictionary[key2];
			}
		}
	}

	private delegate string _0xHC3nferencings(string constant);

	private class _0xHGulpie1t
	{
		public string _0xHBicarb0nate;

		public string _0xHIncisu5es;
	}

	internal enum _0xHCriticizab1e
	{
		Left,
		Right,
		Wherever
	}

	internal enum _0xHIsot5eral
	{
		Variable,
		Constant
	}

	private static readonly _0xHD0fici0nci0s<ExpressionType> _0xHAllo5s = new _0xHD0fici0nci0s<ExpressionType>
	{
		{
			ExpressionType.Add,
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string constant) => "({0})-" + constant)
		},
		{
			ExpressionType.Subtract,
			_0xHCriticizab1e.Left,
			(_0xHC3nferencings)((string constant) => constant + "-({0})")
		},
		{
			ExpressionType.Subtract,
			_0xHCriticizab1e.Right,
			(_0xHC3nferencings)((string constant) => "({0})+" + constant)
		},
		{
			ExpressionType.Multiply,
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string constant) => "({0})/" + constant)
		},
		{
			ExpressionType.Divide,
			_0xHCriticizab1e.Left,
			(_0xHC3nferencings)((string constant) => constant + "/({0})")
		},
		{
			ExpressionType.Divide,
			_0xHCriticizab1e.Right,
			(_0xHC3nferencings)((string constant) => "({0})*" + constant)
		}
	};

	private static readonly _0xHD0fici0nci0s<string> _0xHHydroxyprolin8s = new _0xHD0fici0nci0s<string>
	{
		{
			"Math.Sin",
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string dummy) => "Math.Asin({0})")
		},
		{
			"Math.Asin",
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string dummy) => "Math.Sin({0})")
		},
		{
			"Math.Cos",
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string dummy) => "Math.Acos({0})")
		},
		{
			"Math.Acos",
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string dummy) => "Math.Cos({0})")
		},
		{
			"Math.Tan",
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string dummy) => "Math.Atan({0})")
		},
		{
			"Math.Atan",
			_0xHCriticizab1e.Wherever,
			(_0xHC3nferencings)((string dummy) => "Math.Tan({0})")
		},
		{
			"Math.Pow",
			_0xHCriticizab1e.Left,
			(_0xHC3nferencings)((string constant) => "Math.Log(({0}), " + constant + ")")
		},
		{
			"Math.Pow",
			_0xHCriticizab1e.Right,
			(_0xHC3nferencings)((string constant) => "Math.Pow(({0}), 1.0/" + constant + ")")
		},
		{
			"Math.Log",
			_0xHCriticizab1e.Left,
			(_0xHC3nferencings)((string constant) => "Math.Pow(" + constant + ", 1.0/({0}))")
		},
		{
			"Math.Log",
			_0xHCriticizab1e.Right,
			(_0xHC3nferencings)((string constant) => "Math.Pow(" + constant + ", ({0}))")
		}
	};

	private const string _0xHFiftie7 = "({0})";

	private IExpressionParser _0xH7utscore;

	public _0xHMo1e1(IExpressionParser interpreter)
	{
		_0xH7utscore = interpreter;
	}

	public Lambda _0xHCz7ritz7s(Expression _0xHGue3t3, ParameterExpression _0xHSumle88)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		_0xHGulpie1t _0xHGulpie1t = new _0xHGulpie1t();
		string _0xH0lockbust = null;
		_0xHBo55leful(_0xHGue3t3, _0xHGulpie1t, ref _0xH0lockbust);
		if (_0xHGulpie1t._0xHBicarb0nate == null)
		{
			throw new _0xHBou11ant($"Parameter was not found in expression '{_0xHGue3t3}'!");
		}
		string name = _0xHSumle88.Name;
		string expressionText = string.Format(_0xHGulpie1t._0xHIncisu5es, name);
		Lambda val = _0xH7utscore.Parse(expressionText, new Parameter(_0xHSumle88.Name, _0xHSumle88.Type, (object)null));
		Debug.WriteLine(val.get_ExpressionText());
		return val;
	}

	private _0xHIsot5eral _0xHBo55leful(Expression _0xHWadabl5, _0xHGulpie1t _0xHOutperfor1s, ref string _0xH0lockbust)
	{
		switch (_0xHWadabl5.NodeType)
		{
		case ExpressionType.Call:
		{
			MethodCallExpression methodCallExpression = _0xHWadabl5 as MethodCallExpression;
			string text = methodCallExpression.Method.DeclaringType!.Name + "." + methodCallExpression.Method.Name;
			if (!_0xHHydroxyprolin8s.ContainsKey(text))
			{
				throw new _0xHBou11ant($"Unsupported method call expression: {_0xHWadabl5}");
			}
			string _0xH0lockbust5 = null;
			string _0xH0lockbust6 = null;
			_0xHIsot5eral _0xHIsot5eral5 = _0xHBo55leful(methodCallExpression.Arguments[0], _0xHOutperfor1s, ref _0xH0lockbust5);
			_0xHIsot5eral? _0xHIsot5eral6 = null;
			_ = methodCallExpression.Arguments[0];
			if (methodCallExpression.Arguments.Count == 2)
			{
				_0xHIsot5eral6 = _0xHBo55leful(methodCallExpression.Arguments[1], _0xHOutperfor1s, ref _0xH0lockbust6);
				_ = methodCallExpression.Arguments[1];
			}
			string text2 = null;
			if (_0xHIsot5eral5 == _0xHIsot5eral.Variable)
			{
				text2 = ((_0xHConjug8tion8l.Inversion._0xHSh7tt7mwoods<string, _0xHCriticizab1e, _0xHC3nferencings>)_0xHHydroxyprolin8s).get__0xHIn4ight(text, _0xHCriticizab1e.Right)(_0xH0lockbust6);
			}
			else if (_0xHIsot5eral6.HasValue && _0xHIsot5eral6.Value == _0xHIsot5eral.Variable)
			{
				text2 = ((_0xHConjug8tion8l.Inversion._0xHSh7tt7mwoods<string, _0xHCriticizab1e, _0xHC3nferencings>)_0xHHydroxyprolin8s).get__0xHIn4ight(text, _0xHCriticizab1e.Left)(_0xH0lockbust5);
			}
			else
			{
				_0xH0lockbust = text + "(" + _0xH0lockbust5;
				if (_0xHIsot5eral6.HasValue)
				{
					_0xH0lockbust = _0xH0lockbust + ", " + _0xH0lockbust6;
				}
				_0xH0lockbust += ")";
			}
			if (text2 != null)
			{
				_0xHOutperfor1s._0xHIncisu5es = string.Format(_0xHOutperfor1s._0xHIncisu5es, text2);
			}
			return (text2 == null) ? _0xHIsot5eral.Constant : _0xHIsot5eral.Variable;
		}
		case ExpressionType.Constant:
		{
			ConstantExpression constantExpression = _0xHWadabl5 as ConstantExpression;
			_0xH0lockbust = string.Format(CultureInfo.InvariantCulture, "({0})", new object[1] { constantExpression.Value });
			return _0xHIsot5eral.Constant;
		}
		case ExpressionType.Convert:
		{
			UnaryExpression unaryExpression2 = _0xHWadabl5 as UnaryExpression;
			string _0xH0lockbust7 = null;
			_0xHIsot5eral _0xHIsot5eral7 = _0xHBo55leful(unaryExpression2.Operand, _0xHOutperfor1s, ref _0xH0lockbust7);
			if (_0xHIsot5eral7 == _0xHIsot5eral.Constant)
			{
				_0xH0lockbust = "((" + unaryExpression2.Type.Name + ")" + _0xH0lockbust7 + ")";
			}
			else
			{
				_0xHOutperfor1s._0xHIncisu5es = string.Format(_0xHOutperfor1s._0xHIncisu5es, "((" + unaryExpression2.Operand.Type.Name + ")({0}))");
			}
			return _0xHIsot5eral7;
		}
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = _0xHWadabl5 as MemberExpression;
			if (memberExpression.Member.DeclaringType!.Name == "Math")
			{
				_0xH0lockbust = string.Format(CultureInfo.InvariantCulture, "({0})", new object[1] { memberExpression.Member.DeclaringType!.Name + "." + memberExpression.Member.Name });
				return _0xHIsot5eral.Constant;
			}
			throw new _0xHBou11ant($"Unsupported method call expression: {_0xHWadabl5}");
		}
		case ExpressionType.Not:
		{
			UnaryExpression unaryExpression3 = _0xHWadabl5 as UnaryExpression;
			string _0xH0lockbust8 = null;
			_0xHIsot5eral _0xHIsot5eral8 = _0xHBo55leful(unaryExpression3.Operand, _0xHOutperfor1s, ref _0xH0lockbust8);
			if (_0xHIsot5eral8 == _0xHIsot5eral.Constant)
			{
				_0xH0lockbust = "(" + _0xHHidr2tic(ExpressionType.Not) + _0xH0lockbust8 + ")";
			}
			else
			{
				_0xHOutperfor1s._0xHIncisu5es = string.Format(_0xHOutperfor1s._0xHIncisu5es, "(" + _0xHHidr2tic(ExpressionType.Not) + "({0}))");
			}
			return _0xHIsot5eral8;
		}
		case ExpressionType.Negate:
		{
			UnaryExpression unaryExpression = _0xHWadabl5 as UnaryExpression;
			string _0xH0lockbust2 = null;
			_0xHIsot5eral _0xHIsot5eral = _0xHBo55leful(unaryExpression.Operand, _0xHOutperfor1s, ref _0xH0lockbust2);
			if (_0xHIsot5eral == _0xHIsot5eral.Constant)
			{
				_0xH0lockbust = "(-" + _0xH0lockbust2 + ")";
			}
			else
			{
				_0xHOutperfor1s._0xHIncisu5es = string.Format(_0xHOutperfor1s._0xHIncisu5es, "(-({0}))");
			}
			return _0xHIsot5eral;
		}
		default:
			throw new _0xHBou11ant($"Unsupported expression: {_0xHWadabl5}");
		case ExpressionType.Add:
		case ExpressionType.Divide:
		case ExpressionType.Multiply:
		case ExpressionType.Subtract:
		{
			BinaryExpression binaryExpression = _0xHWadabl5 as BinaryExpression;
			string _0xH0lockbust3 = null;
			string _0xH0lockbust4 = null;
			_0xHIsot5eral _0xHIsot5eral2 = _0xHBo55leful(binaryExpression.Left, _0xHOutperfor1s, ref _0xH0lockbust3);
			_0xHIsot5eral _0xHIsot5eral3 = _0xHBo55leful(binaryExpression.Right, _0xHOutperfor1s, ref _0xH0lockbust4);
			_0xHIsot5eral _0xHIsot5eral4 = ((_0xHIsot5eral2 != 0 && _0xHIsot5eral3 != 0) ? _0xHIsot5eral.Constant : _0xHIsot5eral.Variable);
			if (_0xHIsot5eral4 == _0xHIsot5eral.Variable)
			{
				_0xHCriticizab1e key = ((_0xHIsot5eral2 != _0xHIsot5eral.Constant) ? _0xHCriticizab1e.Right : _0xHCriticizab1e.Left);
				string constant = ((_0xHIsot5eral2 == _0xHIsot5eral.Constant) ? _0xH0lockbust3 : _0xH0lockbust4);
				_0xHOutperfor1s._0xHIncisu5es = string.Format(_0xHOutperfor1s._0xHIncisu5es, ((_0xHConjug8tion8l.Inversion._0xHSh7tt7mwoods<ExpressionType, _0xHCriticizab1e, _0xHC3nferencings>)_0xHAllo5s).get__0xHIn4ight(_0xHWadabl5.NodeType, key)(constant));
			}
			else
			{
				_0xH0lockbust = $"({_0xH0lockbust3}{_0xHHidr2tic(binaryExpression.NodeType)}{_0xH0lockbust4})";
			}
			return _0xHIsot5eral4;
		}
		case ExpressionType.Parameter:
		{
			ParameterExpression parameterExpression = _0xHWadabl5 as ParameterExpression;
			if (_0xHOutperfor1s._0xHBicarb0nate == null)
			{
				_0xHOutperfor1s._0xHBicarb0nate = parameterExpression.Name;
				_0xHOutperfor1s._0xHIncisu5es = "({0})";
				return _0xHIsot5eral.Variable;
			}
			if (_0xHOutperfor1s._0xHBicarb0nate == parameterExpression.Name)
			{
				throw new _0xHBou11ant($"Variable {_0xHOutperfor1s._0xHBicarb0nate} is defined more than one time!");
			}
			throw new _0xHBou11ant($"More than one variables are defined in expression: {_0xHOutperfor1s._0xHBicarb0nate} and {parameterExpression.Name}");
		}
		}
	}

	private string _0xHHidr2tic(ExpressionType _0xHBedplate6)
	{
		return _0xHBedplate6 switch
		{
			ExpressionType.Divide => "/", 
			ExpressionType.Add => "+", 
			ExpressionType.Subtract => "-", 
			ExpressionType.Not => "!", 
			ExpressionType.Multiply => "*", 
			_ => throw new Exception("Unkwnown binary node type: " + _0xHBedplate6.ToString() + "!"), 
		};
	}
}
