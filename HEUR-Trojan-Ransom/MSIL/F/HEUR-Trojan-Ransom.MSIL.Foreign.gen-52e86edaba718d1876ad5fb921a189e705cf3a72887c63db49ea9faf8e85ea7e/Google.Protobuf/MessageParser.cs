using System;
using System.IO;

namespace Google.Protobuf;

public class MessageParser
{
	private Func<IMessage> factory;

	internal MessageParser(Func<IMessage> factory)
	{
		this.factory = factory;
	}

	internal IMessage CreateTemplate()
	{
		return factory();
	}

	public IMessage ParseFrom(byte[] data)
	{
		IMessage message = factory();
		message.MergeFrom(data);
		return message;
	}

	public IMessage ParseFrom(byte[] data, int offset, int length)
	{
		IMessage message = factory();
		message.MergeFrom(data, offset, length);
		return message;
	}

	public IMessage ParseFrom(ByteString data)
	{
		IMessage message = factory();
		message.MergeFrom(data);
		return message;
	}

	public IMessage ParseFrom(Stream input)
	{
		IMessage message = factory();
		message.MergeFrom(input);
		return message;
	}

	public IMessage ParseDelimitedFrom(Stream input)
	{
		IMessage message = factory();
		message.MergeDelimitedFrom(input);
		return message;
	}

	public IMessage ParseFrom(CodedInputStream input)
	{
		IMessage message = factory();
		message.MergeFrom(input);
		return message;
	}

	public IMessage ParseJson(string json)
	{
		IMessage message = factory();
		JsonParser.Default.Merge(message, json);
		return message;
	}
}
public sealed class MessageParser<T> : MessageParser where T : IMessage<T>
{
	private readonly Func<T> factory;

	public MessageParser(Func<T> factory)
		: base(() => factory())
	{
		this.factory = factory;
	}

	internal new T CreateTemplate()
	{
		return factory();
	}

	public new T ParseFrom(byte[] data)
	{
		T val = factory();
		val.MergeFrom(data);
		return val;
	}

	public new T ParseFrom(byte[] data, int offset, int length)
	{
		T val = factory();
		val.MergeFrom(data, offset, length);
		return val;
	}

	public new T ParseFrom(ByteString data)
	{
		T val = factory();
		val.MergeFrom(data);
		return val;
	}

	public new T ParseFrom(Stream input)
	{
		T val = factory();
		val.MergeFrom(input);
		return val;
	}

	public new T ParseDelimitedFrom(Stream input)
	{
		T val = factory();
		val.MergeDelimitedFrom(input);
		return val;
	}

	public new T ParseFrom(CodedInputStream input)
	{
		T result = factory();
		result.MergeFrom(input);
		return result;
	}

	public new T ParseJson(string json)
	{
		T val = factory();
		JsonParser.Default.Merge(val, json);
		return val;
	}
}
