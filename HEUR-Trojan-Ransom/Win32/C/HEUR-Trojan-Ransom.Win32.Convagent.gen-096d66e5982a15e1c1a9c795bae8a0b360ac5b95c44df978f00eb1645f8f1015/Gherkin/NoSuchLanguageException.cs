using System;
using System.Runtime.Serialization;
using Gherkin.Ast;

namespace Gherkin;

[Serializable]
public class NoSuchLanguageException : ParserException
{
	public NoSuchLanguageException(string language, Location location = null)
		: base("Language not supported: " + language, location)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
	}

	protected NoSuchLanguageException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
