using System;
using System.Runtime.Serialization;

namespace Gherkin;

[Serializable]
public class UnexpectedTokenException : TokenParserException
{
	public string StateComment { get; private set; }

	public Token ReceivedToken { get; private set; }

	public string[] ExpectedTokenTypes { get; private set; }

	public UnexpectedTokenException(Token receivedToken, string[] expectedTokenTypes, string stateComment)
		: base(GetMessage(receivedToken, expectedTokenTypes), receivedToken)
	{
		if (receivedToken == null)
		{
			throw new ArgumentNullException("receivedToken");
		}
		if (expectedTokenTypes == null)
		{
			throw new ArgumentNullException("expectedTokenTypes");
		}
		ReceivedToken = receivedToken;
		ExpectedTokenTypes = expectedTokenTypes;
		StateComment = stateComment;
	}

	protected UnexpectedTokenException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	private static string GetMessage(Token receivedToken, string[] expectedTokenTypes)
	{
		return string.Format("expected: {0}, got '{1}'", string.Join(", ", expectedTokenTypes), receivedToken.GetTokenValue().Trim());
	}
}
