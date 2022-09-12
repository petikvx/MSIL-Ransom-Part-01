using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json;

[Serializable]
public class JsonReaderException : JsonException
{
	public int LineNumber { get; }

	public int LinePosition { get; }

	public string? Path { get; }

	public JsonReaderException()
	{
	}

	public JsonReaderException(string message)
		: base(message)
	{
	}

	public JsonReaderException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public JsonReaderException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		: base(message, innerException)
	{
		Path = path;
		LineNumber = lineNumber;
		LinePosition = linePosition;
	}
}
