using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Gherkin;

[Serializable]
public class CompositeParserException : ParserException
{
	public IEnumerable<ParserException> Errors { get; private set; }

	public CompositeParserException(ParserException[] errors)
		: base(GetMessage(errors))
	{
		if (errors == null)
		{
			throw new ArgumentNullException("errors");
		}
		Errors = errors;
	}

	protected CompositeParserException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Errors = (ParserException[])info.GetValue("Errors", typeof(ParserException[]));
	}

	private static string GetMessage(ParserException[] errors)
	{
		return "Parser errors:" + Environment.NewLine + string.Join(Environment.NewLine, errors.Select((ParserException e) => e.Message));
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Errors", Errors.ToArray());
	}
}
