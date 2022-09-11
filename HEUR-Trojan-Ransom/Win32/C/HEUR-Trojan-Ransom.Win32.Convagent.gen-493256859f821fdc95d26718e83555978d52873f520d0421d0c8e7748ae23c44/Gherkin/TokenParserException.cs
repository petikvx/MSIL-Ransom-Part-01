using System;
using System.Runtime.Serialization;
using Gherkin.Ast;

namespace Gherkin;

public abstract class TokenParserException : ParserException
{
	protected TokenParserException(string message, Token receivedToken)
		: base(message, GetLocation(receivedToken))
	{
		if (receivedToken == null)
		{
			throw new ArgumentNullException("receivedToken");
		}
	}

	protected TokenParserException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	private static Location GetLocation(Token receivedToken)
	{
		return (receivedToken.IsEOF || receivedToken.Location.Column > 1) ? receivedToken.Location : new Location(receivedToken.Location.Line, receivedToken.Line.Indent + 1);
	}
}
