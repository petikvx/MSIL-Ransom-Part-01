using System.Collections.Generic;
using System.Linq;

namespace Gherkin;

public class AstNode
{
	private readonly Dictionary<RuleType, IList<object>> subItems = new Dictionary<RuleType, IList<object>>();

	public RuleType RuleType { get; private set; }

	public AstNode(RuleType ruleType)
	{
		RuleType = ruleType;
	}

	public Token GetToken(TokenType tokenType)
	{
		return GetSingle<Token>((RuleType)tokenType);
	}

	public IEnumerable<Token> GetTokens(TokenType tokenType)
	{
		return GetItems<Token>((RuleType)tokenType);
	}

	public T GetSingle<T>(RuleType ruleType)
	{
		return GetItems<T>(ruleType).SingleOrDefault();
	}

	public IEnumerable<T> GetItems<T>(RuleType ruleType)
	{
		if (!subItems.TryGetValue(ruleType, out var value))
		{
			return Enumerable.Empty<T>();
		}
		return value.Cast<T>();
	}

	public void SetSingle<T>(RuleType ruleType, T value)
	{
		subItems[ruleType] = new object[1] { value };
	}

	public void AddRange<T>(RuleType ruleType, IEnumerable<T> values)
	{
		foreach (T value in values)
		{
			Add(ruleType, value);
		}
	}

	public void Add<T>(RuleType ruleType, T obj)
	{
		if (!subItems.TryGetValue(ruleType, out var value))
		{
			value = new List<object>();
			subItems.Add(ruleType, value);
		}
		value.Add(obj);
	}
}
