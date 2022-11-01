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

	internal static JsonSerializationException Create(JsonReader reader, string message)
	{
		return Create(reader, message, null);
	}

	internal static JsonSerializationException Create(JsonReader reader, string message, Exception? ex)
	{
		return Create(reader as IJsonLineInfo, reader.Path, message, ex);
	}

	internal static JsonSerializationException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
	{
		message = JsonPosition.FormatMessage(lineInfo, path, message);
		int lineNumber;
		int linePosition;
		if (lineInfo != null && lineInfo!.HasLineInfo())
		{
			lineNumber = lineInfo!.LineNumber;
			linePosition = lineInfo!.LinePosition;
		}
		else
		{
			lineNumber = 0;
			linePosition = 0;
		}
		return new JsonSerializationException(message, path, lineNumber, linePosition, ex);
	}
}
