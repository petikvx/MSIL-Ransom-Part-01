using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json;

[Serializable]
public class JsonSerializationException : JsonException
{
	public int LineNumber { get; }

	public int LinePosition { get; }

	public string? Path { get; }

	public JsonSerializationException()
	{
	}

	public JsonSerializationException(string message)
		: base(message)
	{
	}

	public JsonSerializationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public JsonSerializationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		: base(message, innerException)
	{
		Path = path;
		LineNumber = lineNumber;
		LinePosition = linePosition;
	}
}
