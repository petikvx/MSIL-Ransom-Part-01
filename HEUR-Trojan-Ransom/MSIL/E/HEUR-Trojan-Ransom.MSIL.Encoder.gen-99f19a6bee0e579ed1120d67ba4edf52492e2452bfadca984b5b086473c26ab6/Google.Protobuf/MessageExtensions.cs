using System.IO;

namespace Google.Protobuf;

public static class MessageExtensions
{
	public static void MergeFrom(this IMessage message, byte[] data)
	{
		message.MergeFrom(data, discardUnknownFields: false);
	}

	public static void MergeFrom(this IMessage message, byte[] data, int offset, int length)
	{
		message.MergeFrom(data, offset, length, discardUnknownFields: false);
	}

	public static void MergeFrom(this IMessage message, ByteString data)
	{
		message.MergeFrom(data, discardUnknownFields: false);
	}

	public static void MergeFrom(this IMessage message, Stream input)
	{
		message.MergeFrom(input, discardUnknownFields: false);
	}

	public static void MergeDelimitedFrom(this IMessage message, Stream input)
	{
		message.MergeDelimitedFrom(input, discardUnknownFields: false);
	}

	public static byte[] ToByteArray(this IMessage message)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		byte[] array = new byte[message.CalculateSize()];
		CodedOutputStream codedOutputStream = new CodedOutputStream(array);
		message.WriteTo(codedOutputStream);
		codedOutputStream.CheckNoSpaceLeft();
		return array;
	}

	public static void WriteTo(this IMessage message, Stream output)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(output, "output");
		CodedOutputStream codedOutputStream = new CodedOutputStream(output);
		message.WriteTo(codedOutputStream);
		codedOutputStream.Flush();
	}

	public static void WriteDelimitedTo(this IMessage message, Stream output)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(output, "output");
		CodedOutputStream codedOutputStream = new CodedOutputStream(output);
		codedOutputStream.WriteRawVarint32((uint)message.CalculateSize());
		message.WriteTo(codedOutputStream);
		codedOutputStream.Flush();
	}

	public static ByteString ToByteString(this IMessage message)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		return ByteString.AttachBytes(message.ToByteArray());
	}

	internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(data, "data");
		CodedInputStream codedInputStream = new CodedInputStream(data);
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeFrom(this IMessage message, byte[] data, int offset, int length, bool discardUnknownFields)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(data, "data");
		CodedInputStream codedInputStream = new CodedInputStream(data, offset, length);
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(data, "data");
		CodedInputStream codedInputStream = data.CreateCodedInput();
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeFrom(this IMessage message, Stream input, bool discardUnknownFields)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(input, "input");
		CodedInputStream codedInputStream = new CodedInputStream(input);
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeDelimitedFrom(this IMessage message, Stream input, bool discardUnknownFields)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(input, "input");
		int size = (int)CodedInputStream.ReadRawVarint32(input);
		Stream input2 = new LimitedInputStream(input, size);
		message.MergeFrom(input2, discardUnknownFields);
	}
}
