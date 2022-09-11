using System;
using System.Runtime.Serialization;

namespace Gherkin;

[Serializable]
public class UnexpectedEOFException : TokenParserException
{
	public string StateComment { get; private set; }

	public string[] ExpectedTokenTypes { get; private set; }

	public UnexpectedEOFException(Token receivedToken, string[] expectedTokenTypes, string stateComment)
		: base(GetMessage(expectedTokenTypes), receivedToken)
	{
		if (receivedToken == null)
		{
			throw new ArgumentNullException("receivedToken");
		}
		if (expectedTokenTypes == null)
		{
			throw new ArgumentNullException("expectedTokenTypes");
		}
		ExpectedTokenTypes = expectedTokenTypes;
		StateComment = stateComment;
	}

	protected UnexpectedEOFException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	private static string GetMessage(string[] expectedTokenTypes)
	{
		return string.Format("unexpected end of file, expected: {0}", string.Join(", ", expectedTokenTypes));
	}
}
