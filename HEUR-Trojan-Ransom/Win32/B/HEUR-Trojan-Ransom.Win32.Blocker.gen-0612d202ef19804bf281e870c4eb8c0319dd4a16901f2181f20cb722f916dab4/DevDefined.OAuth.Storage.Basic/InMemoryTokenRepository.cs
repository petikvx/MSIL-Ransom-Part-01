using System.Collections.Generic;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage.Basic;

public class InMemoryTokenRepository<T> : ITokenRepository<T> where T : TokenBase
{
	private readonly Dictionary<string, T> _tokens = new Dictionary<string, T>();

	public T GetToken(string token)
	{
		return _tokens[token];
	}

	public void SaveToken(T token)
	{
		_tokens[token.Token] = token;
	}
}
