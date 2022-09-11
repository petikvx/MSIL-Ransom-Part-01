using System;
using System.Runtime.Serialization;
using Gherkin.Ast;

namespace Gherkin;

[Serializable]
public class AstBuilderException : ParserException
{
	public AstBuilderException(string message, Location location)
		: base(message, location)
	{
	}

	protected AstBuilderException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
