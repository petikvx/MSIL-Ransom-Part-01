using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json;

[Serializable]
public class JsonWriterException : JsonException
{
	public string? Path { get; }

	public JsonWriterException()
	{
	}

	public JsonWriterException(string message)
		: base(message)
	{
	}

	public JsonWriterException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public JsonWriterException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public JsonWriterException(string message, string path, Exception? innerException)
		: base(message, innerException)
	{
		Path = path;
	}

	internal static JsonWriterException Create(JsonWriter writer, string message, Exception? ex)
	{
		return Create(writer.ContainerPath, message, ex);
	}

	internal static JsonWriterException Create(string path, string message, Exception? ex)
	{
		message = JsonPosition.FormatMessage(null, path, message);
		return new JsonWriterException(message, path, ex);
	}
}
