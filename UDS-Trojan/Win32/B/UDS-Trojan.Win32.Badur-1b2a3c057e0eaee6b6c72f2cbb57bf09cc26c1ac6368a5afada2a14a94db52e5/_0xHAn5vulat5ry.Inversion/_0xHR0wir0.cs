#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using DynamicExpresso;
using _0xHAn5vulat5ry.ExpressionParsers;
using _0xHDo22house;

namespace _0xHAn5vulat5ry.Inversion;

public class _0xHR0wir0
{
	[DefaultMember("Item")]
	private class _0xHDepoli4hing<T> : _0xHAn5vulat5ry.Inversion._0xHF8llmong8r8d<T, _0xHRemonstrat6ons, _0xHAeroe0astic>
	{
		public override _0xHAeroe0astic _0xHDuke7
		{
			get
			{
				Dictionary<_0xHRemonstrat6ons, _0xHAeroe0astic> dictionary = base[key1];
				if (dictionary.ContainsKey(key2))
				{
					return dictionary[key2];
				}
				if (dictionary.ContainsKey(_0xHRemonstrat6ons.Wherever))
				{
					return dictionary[_0xHRemonstrat6ons.Wherever];
				}
				return dictionary[key2];
			}
		}
	}

	private delegate string _0xHAeroe0astic(string constant);

	private class _0xHGa8goyled
	{
		public string _0xHSear0her;

		public string _0xHH6ngs;
	}

	internal enum _0xHRemonstrat6ons
	{
		Left,
		Right,
		Wherever
	}

	internal enum _0xHRipsno1te1
	{
		Variable,
		Constant
	}

	private static readonly _0xHDepoli4hing<ExpressionType> _0xHD5sart5culated = new _0xHDepoli4hing<ExpressionType>
	{
		{
			ExpressionType.Add,
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string constant) => "({0})-" + constant)
		},
		{
			ExpressionType.Subtract,
			_0xHRemonstrat6ons.Left,
			(_0xHAeroe0astic)((string constant) => constant + "-({0})")
		},
		{
			ExpressionType.Subtract,
			_0xHRemonstrat6ons.Right,
			(_0xHAeroe0astic)((string constant) => "({0})+" + constant)
		},
		{
			ExpressionType.Multiply,
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string constant) => "({0})/" + constant)
		},
		{
			ExpressionType.Divide,
			_0xHRemonstrat6ons.Left,
			(_0xHAeroe0astic)((string constant) => constant + "/({0})")
		},
		{
			ExpressionType.Divide,
			_0xHRemonstrat6ons.Right,
			(_0xHAeroe0astic)((string constant) => "({0})*" + constant)
		}
	};

	private static readonly _0xHDepoli4hing<string> _0xHG6utara6dehydes = new _0xHDepoli4hing<string>
	{
		{
			"Math.Sin",
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string dummy) => "Math.Asin({0})")
		},
		{
			"Math.Asin",
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string dummy) => "Math.Sin({0})")
		},
		{
			"Math.Cos",
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string dummy) => "Math.Acos({0})")
		},
		{
			"Math.Acos",
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string dummy) => "Math.Cos({0})")
		},
		{
			"Math.Tan",
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string dummy) => "Math.Atan({0})")
		},
		{
			"Math.Atan",
			_0xHRemonstrat6ons.Wherever,
			(_0xHAeroe0astic)((string dummy) => "Math.Tan({0})")
		},
		{
			"Math.Pow",
			_0xHRemonstrat6ons.Left,
			(_0xHAeroe0astic)((string constant) => "Math.Log(({0}), " + constant + ")")
		},
		{
			"Math.Pow",
			_0xHRemonstrat6ons.Right,
			(_0xHAeroe0astic)((string constant) => "Math.Pow(({0}), 1.0/" + constant + ")")
		},
		{
			"Math.Log",
			_0xHRemonstrat6ons.Left,
			(_0xHAeroe0astic)((string constant) => "Math.Pow(" + constant + ", 1.0/({0}))")
		},
		{
			"Math.Log",
			_0xHRemonstrat6ons.Right,
			(_0xHAeroe0astic)((string constant) => "Math.Pow(" + constant + ", ({0}))")
		}
	};

	private const string _0xHShad7wer = "({0})";

	private IExpressionParser _0xH0rgues;

	public _0xHR0wir0(IExpressionParser interpreter)
	{
		_0xH0rgues = interpreter;
	}

	public Lambda _0xHJinrick8ha8(Expression _0xHF55dies, ParameterExpression _0xHTeno0s)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		_0xHGa8goyled _0xHGa8goyled = new _0xHGa8goyled();
		string _0xHGr4undless = null;
		_0xHCort4x(_0xHF55dies, _0xHGa8goyled, ref _0xHGr4undless);
		if (_0xHGa8goyled._0xHSear0her == null)
		{
			throw new _0xHVi0rified($"Parameter was not found in expression '{_0xHF55dies}'!");
		}
		string name = _0xHTeno0s.Name;
		string expressionText = string.Format(_0xHGa8goyled._0xHH6ngs, name);
		Lambda val = _0xH0rgues.Parse(expressionText, new Parameter(_0xHTeno0s.Name, _0xHTeno0s.Type, (object)null));
		Debug.WriteLine(val.get_ExpressionText());
		return val;
	}

	private _0xHRipsno1te1 _0xHCort4x(Expression _0xHSh3nleaf, _0xHGa8goyled _0xHSqu4tty, ref string _0xHGr4undless)
	{
		switch (_0xHSh3nleaf.NodeType)
		{
		case ExpressionType.Call:
		{
			MethodCallExpression methodCallExpression = _0xHSh3nleaf as MethodCallExpression;
			string text = methodCallExpression.Method.DeclaringType!.Name + "." + methodCallExpression.Method.Name;
			if (!_0xHG6utara6dehydes.ContainsKey(text))
			{
				throw new _0xHVi0rified($"Unsupported method call expression: {_0xHSh3nleaf}");
			}
			string _0xHGr4undless5 = null;
			string _0xHGr4undless6 = null;
			_0xHRipsno1te1 _0xHRipsno1te5 = _0xHCort4x(methodCallExpression.Arguments[0], _0xHSqu4tty, ref _0xHGr4undless5);
			_0xHRipsno1te1? _0xHRipsno1te6 = null;
			_ = methodCallExpression.Arguments[0];
			if (methodCallExpression.Arguments.Count == 2)
			{
				_0xHRipsno1te6 = _0xHCort4x(methodCallExpression.Arguments[1], _0xHSqu4tty, ref _0xHGr4undless6);
				_ = methodCallExpression.Arguments[1];
			}
			string text2 = null;
			if (_0xHRipsno1te5 == _0xHRipsno1te1.Variable)
			{
				text2 = ((_0xHAn5vulat5ry.Inversion._0xHF8llmong8r8d<string, _0xHRemonstrat6ons, _0xHAeroe0astic>)_0xHG6utara6dehydes).get__0xHDuke7(text, _0xHRemonstrat6ons.Right)(_0xHGr4undless6);
			}
			else if (_0xHRipsno1te6.HasValue && _0xHRipsno1te6.Value == _0xHRipsno1te1.Variable)
			{
				text2 = ((_0xHAn5vulat5ry.Inversion._0xHF8llmong8r8d<string, _0xHRemonstrat6ons, _0xHAeroe0astic>)_0xHG6utara6dehydes).get__0xHDuke7(text, _0xHRemonstrat6ons.Left)(_0xHGr4undless5);
			}
			else
			{
				_0xHGr4undless = text + "(" + _0xHGr4undless5;
				if (_0xHRipsno1te6.HasValue)
				{
					_0xHGr4undless = _0xHGr4undless + ", " + _0xHGr4undless6;
				}
				_0xHGr4undless += ")";
			}
			if (text2 != null)
			{
				_0xHSqu4tty._0xHH6ngs = string.Format(_0xHSqu4tty._0xHH6ngs, text2);
			}
			return (text2 == null) ? _0xHRipsno1te1.Constant : _0xHRipsno1te1.Variable;
		}
		case ExpressionType.Constant:
		{
			ConstantExpression constantExpression = _0xHSh3nleaf as ConstantExpression;
			_0xHGr4undless = string.Format(CultureInfo.InvariantCulture, "({0})", new object[1] { constantExpression.Value });
			return _0xHRipsno1te1.Constant;
		}
		case ExpressionType.Convert:
		{
			UnaryExpression unaryExpression2 = _0xHSh3nleaf as UnaryExpression;
			string _0xHGr4undless7 = null;
			_0xHRipsno1te1 _0xHRipsno1te7 = _0xHCort4x(unaryExpression2.Operand, _0xHSqu4tty, ref _0xHGr4undless7);
			if (_0xHRipsno1te7 == _0xHRipsno1te1.Constant)
			{
				_0xHGr4undless = "((" + unaryExpression2.Type.Name + ")" + _0xHGr4undless7 + ")";
			}
			else
			{
				_0xHSqu4tty._0xHH6ngs = string.Format(_0xHSqu4tty._0xHH6ngs, "((" + unaryExpression2.Operand.Type.Name + ")({0}))");
			}
			return _0xHRipsno1te7;
		}
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = _0xHSh3nleaf as MemberExpression;
			if (memberExpression.Member.DeclaringType!.Name == "Math")
			{
				_0xHGr4undless = string.Format(CultureInfo.InvariantCulture, "({0})", new object[1] { memberExpression.Member.DeclaringType!.Name + "." + memberExpression.Member.Name });
				return _0xHRipsno1te1.Constant;
			}
			throw new _0xHVi0rified($"Unsupported method call expression: {_0xHSh3nleaf}");
		}
		case ExpressionType.Not:
		{
			UnaryExpression unaryExpression3 = _0xHSh3nleaf as UnaryExpression;
			string _0xHGr4undless8 = null;
			_0xHRipsno1te1 _0xHRipsno1te8 = _0xHCort4x(unaryExpression3.Operand, _0xHSqu4tty, ref _0xHGr4undless8);
			if (_0xHRipsno1te8 == _0xHRipsno1te1.Constant)
			{
				_0xHGr4undless = "(" + _0xHKr2ters(ExpressionType.Not) + _0xHGr4undless8 + ")";
			}
			else
			{
				_0xHSqu4tty._0xHH6ngs = string.Format(_0xHSqu4tty._0xHH6ngs, "(" + _0xHKr2ters(ExpressionType.Not) + "({0}))");
			}
			return _0xHRipsno1te8;
		}
		case ExpressionType.Negate:
		{
			UnaryExpression unaryExpression = _0xHSh3nleaf as UnaryExpression;
			string _0xHGr4undless2 = null;
			_0xHRipsno1te1 _0xHRipsno1te = _0xHCort4x(unaryExpression.Operand, _0xHSqu4tty, ref _0xHGr4undless2);
			if (_0xHRipsno1te == _0xHRipsno1te1.Constant)
			{
				_0xHGr4undless = "(-" + _0xHGr4undless2 + ")";
			}
			else
			{
				_0xHSqu4tty._0xHH6ngs = string.Format(_0xHSqu4tty._0xHH6ngs, "(-({0}))");
			}
			return _0xHRipsno1te;
		}
		default:
			throw new _0xHVi0rified($"Unsupported expression: {_0xHSh3nleaf}");
		case ExpressionType.Add:
		case ExpressionType.Divide:
		case ExpressionType.Multiply:
		case ExpressionType.Subtract:
		{
			BinaryExpression binaryExpression = _0xHSh3nleaf as BinaryExpression;
			string _0xHGr4undless3 = null;
			string _0xHGr4undless4 = null;
			_0xHRipsno1te1 _0xHRipsno1te2 = _0xHCort4x(binaryExpression.Left, _0xHSqu4tty, ref _0xHGr4undless3);
			_0xHRipsno1te1 _0xHRipsno1te3 = _0xHCort4x(binaryExpression.Right, _0xHSqu4tty, ref _0xHGr4undless4);
			_0xHRipsno1te1 _0xHRipsno1te4 = ((_0xHRipsno1te2 != 0 && _0xHRipsno1te3 != 0) ? _0xHRipsno1te1.Constant : _0xHRipsno1te1.Variable);
			if (_0xHRipsno1te4 == _0xHRipsno1te1.Variable)
			{
				_0xHRemonstrat6ons key = ((_0xHRipsno1te2 != _0xHRipsno1te1.Constant) ? _0xHRemonstrat6ons.Right : _0xHRemonstrat6ons.Left);
				string constant = ((_0xHRipsno1te2 == _0xHRipsno1te1.Constant) ? _0xHGr4undless3 : _0xHGr4undless4);
				_0xHSqu4tty._0xHH6ngs = string.Format(_0xHSqu4tty._0xHH6ngs, ((_0xHAn5vulat5ry.Inversion._0xHF8llmong8r8d<ExpressionType, _0xHRemonstrat6ons, _0xHAeroe0astic>)_0xHD5sart5culated).get__0xHDuke7(_0xHSh3nleaf.NodeType, key)(constant));
			}
			else
			{
				_0xHGr4undless = $"({_0xHGr4undless3}{_0xHKr2ters(binaryExpression.NodeType)}{_0xHGr4undless4})";
			}
			return _0xHRipsno1te4;
		}
		case ExpressionType.Parameter:
		{
			ParameterExpression parameterExpression = _0xHSh3nleaf as ParameterExpression;
			if (_0xHSqu4tty._0xHSear0her == null)
			{
				_0xHSqu4tty._0xHSear0her = parameterExpression.Name;
				_0xHSqu4tty._0xHH6ngs = "({0})";
				return _0xHRipsno1te1.Variable;
			}
			if (_0xHSqu4tty._0xHSear0her == parameterExpression.Name)
			{
				throw new _0xHVi0rified($"Variable {_0xHSqu4tty._0xHSear0her} is defined more than one time!");
			}
			throw new _0xHVi0rified($"More than one variables are defined in expression: {_0xHSqu4tty._0xHSear0her} and {parameterExpression.Name}");
		}
		}
	}

	private string _0xHKr2ters(ExpressionType _0xHA4forjas)
	{
		return _0xHA4forjas switch
		{
			ExpressionType.Divide => "/", 
			ExpressionType.Add => "+", 
			ExpressionType.Subtract => "-", 
			ExpressionType.Not => "!", 
			ExpressionType.Multiply => "*", 
			_ => throw new Exception("Unkwnown binary node type: " + _0xHA4forjas.ToString() + "!"), 
		};
	}
}
