using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class JPath
{
	private static readonly char[] FloatCharacters = new char[3] { '.', 'E', 'e' };

	private readonly string _expression;

	private int _currentIndex;

	public List<PathFilter> Filters { get; }

	public JPath(string expression)
	{
		ValidationUtils.ArgumentNotNull(expression, "expression");
		_expression = expression;
		Filters = new List<PathFilter>();
		ParseMain();
	}

	private void ParseMain()
	{
		int currentIndex = _currentIndex;
		EatWhitespace();
		if (_expression.Length == _currentIndex)
		{
			return;
		}
		if (_expression[_currentIndex] == '$')
		{
			if (_expression.Length == 1)
			{
				return;
			}
			char c = _expression[_currentIndex + 1];
			if (c == '.' || c == '[')
			{
				_currentIndex++;
				currentIndex = _currentIndex;
			}
		}
		if (!ParsePath(Filters, currentIndex, query: false))
		{
			int currentIndex2 = _currentIndex;
			EatWhitespace();
			if (_currentIndex < _expression.Length)
			{
				throw new JsonException("Unexpected character while parsing path: " + _expression[currentIndex2]);
			}
		}
	}

	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
	{
		bool scan = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		while (_currentIndex < _expression.Length && !flag3)
		{
			char c = _expression[_currentIndex];
			switch (c)
			{
			case ' ':
				if (_currentIndex < _expression.Length)
				{
					flag3 = true;
				}
				break;
			default:
				if (query && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
				{
					flag3 = true;
					break;
				}
				if (!flag)
				{
					_currentIndex++;
					break;
				}
				throw new JsonException("Unexpected character following indexer: " + c);
			case ')':
			case ']':
				flag3 = true;
				break;
			case '(':
			case '[':
				if (_currentIndex > currentPartStartIndex)
				{
					string text2 = _expression.Substring(currentPartStartIndex, _currentIndex - currentPartStartIndex);
					if (text2 == "*")
					{
						text2 = null;
					}
					filters.Add(CreatePathFilter(text2, scan));
					scan = false;
				}
				filters.Add(ParseIndexer(c, scan));
				scan = false;
				_currentIndex++;
				currentPartStartIndex = _currentIndex;
				flag = true;
				flag2 = false;
				break;
			case '.':
				if (_currentIndex > currentPartStartIndex)
				{
					string text = _expression.Substring(currentPartStartIndex, _currentIndex - currentPartStartIndex);
					if (text == "*")
					{
						text = null;
					}
					filters.Add(CreatePathFilter(text, scan));
					scan = false;
				}
				if (_currentIndex + 1 < _expression.Length && _expression[_currentIndex + 1] == '.')
				{
					scan = true;
					_currentIndex++;
				}
				_currentIndex++;
				currentPartStartIndex = _currentIndex;
				flag = false;
				flag2 = true;
				break;
			}
		}
		bool flag4 = _currentIndex == _expression.Length;
		if (_currentIndex > currentPartStartIndex)
		{
			string text3 = _expression.Substring(currentPartStartIndex, _currentIndex - currentPartStartIndex).TrimEnd(new char[0]);
			if (text3 == "*")
			{
				text3 = null;
			}
			filters.Add(CreatePathFilter(text3, scan));
		}
		else if (flag2 && (flag4 || query))
		{
			throw new JsonException("Unexpected end while parsing path.");
		}
		return flag4;
	}

	private static PathFilter CreatePathFilter(string? member, bool scan)
	{
		if (!scan)
		{
			return new FieldFilter(member);
		}
		return new ScanFilter(member);
	}

	private PathFilter ParseIndexer(char indexerOpenChar, bool scan)
	{
		_currentIndex++;
		char indexerCloseChar = ((indexerOpenChar == '[') ? ']' : ')');
		EnsureLength("Path ended with open indexer.");
		EatWhitespace();
		if (_expression[_currentIndex] == '\'')
		{
			return ParseQuotedField(indexerCloseChar, scan);
		}
		if (_expression[_currentIndex] == '?')
		{
			return ParseQuery(indexerCloseChar, scan);
		}
		return ParseArrayIndexer(indexerCloseChar);
	}

	private PathFilter ParseArrayIndexer(char indexerCloseChar)
	{
		int currentIndex = _currentIndex;
		int? num = null;
		List<int> list = null;
		int num2 = 0;
		int? start = null;
		int? end = null;
		int? step = null;
		while (true)
		{
			if (_currentIndex < _expression.Length)
			{
				char c = _expression[_currentIndex];
				if (c == ' ')
				{
					num = _currentIndex;
					EatWhitespace();
					continue;
				}
				if (c == indexerCloseChar)
				{
					break;
				}
				switch (c)
				{
				case ',':
				{
					int num4 = (num ?? _currentIndex) - currentIndex;
					if (num4 != 0)
					{
						if (list == null)
						{
							list = new List<int>();
						}
						string value2 = _expression.Substring(currentIndex, num4);
						list.Add(Convert.ToInt32(value2, CultureInfo.InvariantCulture));
						_currentIndex++;
						EatWhitespace();
						currentIndex = _currentIndex;
						num = null;
						continue;
					}
					throw new JsonException("Array index expected.");
				}
				case ':':
				{
					int num3 = (num ?? _currentIndex) - currentIndex;
					if (num3 > 0)
					{
						int value = Convert.ToInt32(_expression.Substring(currentIndex, num3), CultureInfo.InvariantCulture);
						switch (num2)
						{
						case 0:
							start = value;
							break;
						case 1:
							end = value;
							break;
						default:
							step = value;
							break;
						}
					}
					num2++;
					_currentIndex++;
					EatWhitespace();
					currentIndex = _currentIndex;
					num = null;
					continue;
				}
				case '*':
					_currentIndex++;
					EnsureLength("Path ended with open indexer.");
					EatWhitespace();
					if (_expression[_currentIndex] != indexerCloseChar)
					{
						throw new JsonException("Unexpected character while parsing path indexer: " + c);
					}
					return new ArrayIndexFilter();
				}
				if (char.IsDigit(c) || c == '-')
				{
					if (!num.HasValue)
					{
						_currentIndex++;
						continue;
					}
					throw new JsonException("Unexpected character while parsing path indexer: " + c);
				}
				throw new JsonException("Unexpected character while parsing path indexer: " + c);
			}
			throw new JsonException("Path ended with open indexer.");
		}
		int num5 = (num ?? _currentIndex) - currentIndex;
		if (list != null)
		{
			if (num5 == 0)
			{
				throw new JsonException("Array index expected.");
			}
			int item = Convert.ToInt32(_expression.Substring(currentIndex, num5), CultureInfo.InvariantCulture);
			list.Add(item);
			return new ArrayMultipleIndexFilter(list);
		}
		if (num2 > 0)
		{
			if (num5 > 0)
			{
				int value3 = Convert.ToInt32(_expression.Substring(currentIndex, num5), CultureInfo.InvariantCulture);
				if (num2 == 1)
				{
					end = value3;
				}
				else
				{
					step = value3;
				}
			}
			return new ArraySliceFilter
			{
				Start = start,
				End = end,
				Step = step
			};
		}
		if (num5 == 0)
		{
			throw new JsonException("Array index expected.");
		}
		int value4 = Convert.ToInt32(_expression.Substring(currentIndex, num5), CultureInfo.InvariantCulture);
		return new ArrayIndexFilter
		{
			Index = value4
		};
	}

	private void EatWhitespace()
	{
		while (_currentIndex < _expression.Length && _expression[_currentIndex] == ' ')
		{
			_currentIndex++;
		}
	}

	private PathFilter ParseQuery(char indexerCloseChar, bool scan)
	{
		_currentIndex++;
		EnsureLength("Path ended with open indexer.");
		if (_expression[_currentIndex] != '(')
		{
			throw new JsonException("Unexpected character while parsing path indexer: " + _expression[_currentIndex]);
		}
		_currentIndex++;
		QueryExpression expression = ParseExpression();
		_currentIndex++;
		EnsureLength("Path ended with open indexer.");
		EatWhitespace();
		if (_expression[_currentIndex] != indexerCloseChar)
		{
			throw new JsonException("Unexpected character while parsing path indexer: " + _expression[_currentIndex]);
		}
		if (!scan)
		{
			return new QueryFilter(expression);
		}
		return new QueryScanFilter(expression);
	}

	private bool TryParseExpression(out List<PathFilter>? expressionPath)
	{
		if (_expression[_currentIndex] == '$')
		{
			expressionPath = new List<PathFilter> { RootFilter.Instance };
		}
		else
		{
			if (_expression[_currentIndex] != '@')
			{
				expressionPath = null;
				return false;
			}
			expressionPath = new List<PathFilter>();
		}
		_currentIndex++;
		if (ParsePath(expressionPath, _currentIndex, query: true))
		{
			throw new JsonException("Path ended with open query.");
		}
		return true;
	}

	private JsonException CreateUnexpectedCharacterException()
	{
		return new JsonException("Unexpected character while parsing path query: " + _expression[_currentIndex]);
	}

	private object ParseSide()
	{
		EatWhitespace();
		if (TryParseExpression(out var expressionPath))
		{
			EatWhitespace();
			EnsureLength("Path ended with open query.");
			return expressionPath;
		}
		if (!TryParseValue(out var value))
		{
			throw CreateUnexpectedCharacterException();
		}
		EatWhitespace();
		EnsureLength("Path ended with open query.");
		return new JValue(value);
	}

	private QueryExpression ParseExpression()
	{
		QueryExpression queryExpression = null;
		CompositeExpression compositeExpression = null;
		BooleanQueryExpression booleanQueryExpression;
		while (true)
		{
			if (_currentIndex < _expression.Length)
			{
				object left = ParseSide();
				object right = null;
				QueryOperator @operator;
				if (_expression[_currentIndex] != ')' && _expression[_currentIndex] != '|' && _expression[_currentIndex] != '&')
				{
					@operator = ParseOperator();
					right = ParseSide();
				}
				else
				{
					@operator = QueryOperator.Exists;
				}
				booleanQueryExpression = new BooleanQueryExpression(@operator, left, right);
				if (_expression[_currentIndex] != ')')
				{
					if (_expression[_currentIndex] == '&')
					{
						if (!Match("&&"))
						{
							throw CreateUnexpectedCharacterException();
						}
						if (compositeExpression == null || compositeExpression.Operator != QueryOperator.And)
						{
							CompositeExpression compositeExpression2 = new CompositeExpression(QueryOperator.And);
							compositeExpression?.Expressions.Add(compositeExpression2);
							compositeExpression = compositeExpression2;
							if (queryExpression == null)
							{
								queryExpression = compositeExpression;
							}
						}
						compositeExpression.Expressions.Add(booleanQueryExpression);
					}
					if (_expression[_currentIndex] != '|')
					{
						continue;
					}
					if (Match("||"))
					{
						if (compositeExpression == null || compositeExpression.Operator != QueryOperator.Or)
						{
							CompositeExpression compositeExpression3 = new CompositeExpression(QueryOperator.Or);
							compositeExpression?.Expressions.Add(compositeExpression3);
							compositeExpression = compositeExpression3;
							if (queryExpression == null)
							{
								queryExpression = compositeExpression;
							}
						}
						compositeExpression.Expressions.Add(booleanQueryExpression);
						continue;
					}
					throw CreateUnexpectedCharacterException();
				}
				if (compositeExpression == null)
				{
					break;
				}
				compositeExpression.Expressions.Add(booleanQueryExpression);
				return queryExpression;
			}
			throw new JsonException("Path ended with open query.");
		}
		return booleanQueryExpression;
	}

	private bool TryParseValue(out object? value)
	{
		char c = _expression[_currentIndex];
		if (c == '\'')
		{
			value = ReadQuotedString();
			return true;
		}
		if (!char.IsDigit(c) && c != '-')
		{
			switch (c)
			{
			case 't':
				if (Match("true"))
				{
					value = true;
					return true;
				}
				break;
			case 'f':
				if (Match("false"))
				{
					value = false;
					return true;
				}
				break;
			case 'n':
				if (Match("null"))
				{
					value = null;
					return true;
				}
				break;
			case '/':
				value = ReadRegexString();
				return true;
			}
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(c);
			_currentIndex++;
			while (_currentIndex < _expression.Length)
			{
				c = _expression[_currentIndex];
				if (c != ' ' && c != ')')
				{
					stringBuilder.Append(c);
					_currentIndex++;
					continue;
				}
				string text = stringBuilder.ToString();
				if (text.IndexOfAny(FloatCharacters) != -1)
				{
					double result;
					bool result2 = double.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out result);
					value = result;
					return result2;
				}
				long result3;
				bool result4 = long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out result3);
				value = result3;
				return result4;
			}
		}
		value = null;
		return false;
	}

	private string ReadQuotedString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		_currentIndex++;
		while (true)
		{
			char c;
			char value;
			if (_currentIndex < _expression.Length)
			{
				c = _expression[_currentIndex];
				if (c == '\\' && _currentIndex + 1 < _expression.Length)
				{
					_currentIndex++;
					c = _expression[_currentIndex];
					if ((uint)c <= 92u)
					{
						if ((uint)c <= 39u)
						{
							if (c == '"' || c == '\'')
							{
								goto IL_0093;
							}
						}
						else if (c == '/' || c == '\\')
						{
							goto IL_0093;
						}
						goto IL_0125;
					}
					if ((uint)c <= 102u)
					{
						if (c != 'b')
						{
							if (c != 'f')
							{
								goto IL_0125;
							}
							value = '\f';
						}
						else
						{
							value = '\b';
						}
					}
					else if (c != 'n')
					{
						if (c != 'r')
						{
							if (c != 't')
							{
								goto IL_0125;
							}
							value = '\t';
						}
						else
						{
							value = '\r';
						}
					}
					else
					{
						value = '\n';
					}
					goto IL_00cf;
				}
				if (c == '\'')
				{
					break;
				}
				_currentIndex++;
				stringBuilder.Append(c);
				continue;
			}
			throw new JsonException("Path ended with an open string.");
			IL_00cf:
			stringBuilder.Append(value);
			_currentIndex++;
			continue;
			IL_0125:
			throw new JsonException("Unknown escape character: \\" + c);
			IL_0093:
			value = c;
			goto IL_00cf;
		}
		_currentIndex++;
		return stringBuilder.ToString();
	}

	private string ReadRegexString()
	{
		int currentIndex = _currentIndex;
		_currentIndex++;
		while (true)
		{
			if (_currentIndex < _expression.Length)
			{
				char c = _expression[_currentIndex];
				if (c == '\\' && _currentIndex + 1 < _expression.Length)
				{
					_currentIndex += 2;
					continue;
				}
				if (c == '/')
				{
					break;
				}
				_currentIndex++;
				continue;
			}
			throw new JsonException("Path ended with an open regex.");
		}
		_currentIndex++;
		while (_currentIndex < _expression.Length)
		{
			char c = _expression[_currentIndex];
			if (!char.IsLetter(c))
			{
				break;
			}
			_currentIndex++;
		}
		return _expression.Substring(currentIndex, _currentIndex - currentIndex);
	}

	private bool Match(string s)
	{
		int num = _currentIndex;
		int num2 = 0;
		while (true)
		{
			if (num2 < s.Length)
			{
				if (num >= _expression.Length || _expression[num] != s[num2])
				{
					break;
				}
				num++;
				num2++;
				continue;
			}
			_currentIndex = num;
			return true;
		}
		return false;
	}

	private QueryOperator ParseOperator()
	{
		if (_currentIndex + 1 >= _expression.Length)
		{
			throw new JsonException("Path ended with open query.");
		}
		if (Match("==="))
		{
			return QueryOperator.StrictEquals;
		}
		if (Match("=="))
		{
			return QueryOperator.Equals;
		}
		if (Match("=~"))
		{
			return QueryOperator.RegexEquals;
		}
		if (Match("!=="))
		{
			return QueryOperator.StrictNotEquals;
		}
		if (!Match("!=") && !Match("<>"))
		{
			if (Match("<="))
			{
				return QueryOperator.LessThanOrEquals;
			}
			if (Match("<"))
			{
				return QueryOperator.LessThan;
			}
			if (Match(">="))
			{
				return QueryOperator.GreaterThanOrEquals;
			}
			if (Match(">"))
			{
				return QueryOperator.GreaterThan;
			}
			throw new JsonException("Could not read query operator.");
		}
		return QueryOperator.NotEquals;
	}

	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan)
	{
		List<string> list = null;
		string text;
		while (true)
		{
			if (_currentIndex < _expression.Length)
			{
				text = ReadQuotedString();
				EatWhitespace();
				EnsureLength("Path ended with open indexer.");
				if (_expression[_currentIndex] != indexerCloseChar)
				{
					if (_expression[_currentIndex] == ',')
					{
						_currentIndex++;
						EatWhitespace();
						if (list == null)
						{
							list = new List<string>();
						}
						list.Add(text);
						continue;
					}
					throw new JsonException("Unexpected character while parsing path indexer: " + _expression[_currentIndex]);
				}
				if (list == null)
				{
					break;
				}
				list.Add(text);
				if (!scan)
				{
					return new FieldMultipleFilter(list);
				}
				return new ScanMultipleFilter(list);
			}
			throw new JsonException("Path ended with open indexer.");
		}
		return CreatePathFilter(text, scan);
	}

	private void EnsureLength(string message)
	{
		if (_currentIndex >= _expression.Length)
		{
			throw new JsonException(message);
		}
	}

	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings? settings)
	{
		return Evaluate(Filters, root, t, settings);
	}

	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings? settings)
	{
		IEnumerable<JToken> enumerable = new JToken[1] { t };
		foreach (PathFilter filter in filters)
		{
			enumerable = filter.ExecuteFilter(root, enumerable, settings);
		}
		return enumerable;
	}
}
