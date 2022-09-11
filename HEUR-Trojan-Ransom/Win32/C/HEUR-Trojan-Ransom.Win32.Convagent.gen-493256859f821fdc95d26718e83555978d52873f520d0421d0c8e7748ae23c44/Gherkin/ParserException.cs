using System;
using System.Runtime.Serialization;
using Gherkin.Ast;

namespace Gherkin;

public abstract class ParserException : Exception
{
	public Location Location { get; private set; }

	protected ParserException(string message, Location location = null)
		: base(GetMessage(message, location))
	{
		Location = location;
	}

	protected ParserException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Location = (Location)info.GetValue("Location", typeof(Location));
	}

	private static string GetMessage(string message, Location location)
	{
		if (location == null)
		{
			return message;
		}
		return $"({location.Line}:{location.Column}): {message}";
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Location", Location);
	}
}
