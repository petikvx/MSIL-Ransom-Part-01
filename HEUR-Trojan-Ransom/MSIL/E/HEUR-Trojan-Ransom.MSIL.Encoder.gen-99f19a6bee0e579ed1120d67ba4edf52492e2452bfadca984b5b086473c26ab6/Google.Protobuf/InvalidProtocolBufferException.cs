using System;
using System.IO;

namespace Google.Protobuf;

public sealed class InvalidProtocolBufferException : IOException
{
	internal InvalidProtocolBufferException(string message)
		: base(message)
	{
	}

	internal InvalidProtocolBufferException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	internal static InvalidProtocolBufferException MoreDataAvailable()
	{
		return new InvalidProtocolBufferException("Completed reading a message while more data was available in the stream.");
	}

	internal static InvalidProtocolBufferException TruncatedMessage()
	{
		return new InvalidProtocolBufferException("While parsing a protocol message, the input ended unexpectedly in the middle of a field.  This could mean either that the input has been truncated or that an embedded message misreported its own length.");
	}

	internal static InvalidProtocolBufferException NegativeSize()
	{
		return new InvalidProtocolBufferException("CodedInputStream encountered an embedded string or message which claimed to have negative size.");
	}

	internal static InvalidProtocolBufferException MalformedVarint()
	{
		return new InvalidProtocolBufferException("CodedInputStream encountered a malformed varint.");
	}

	internal static InvalidProtocolBufferException InvalidTag()
	{
		return new InvalidProtocolBufferException("Protocol message contained an invalid tag (zero).");
	}

	internal static InvalidProtocolBufferException InvalidBase64(Exception innerException)
	{
		return new InvalidProtocolBufferException("Invalid base64 data", innerException);
	}

	internal static InvalidProtocolBufferException InvalidEndTag()
	{
		return new InvalidProtocolBufferException("Protocol message end-group tag did not match expected tag.");
	}

	internal static InvalidProtocolBufferException RecursionLimitExceeded()
	{
		return new InvalidProtocolBufferException("Protocol message had too many levels of nesting.  May be malicious.  Use CodedInputStream.SetRecursionLimit() to increase the depth limit.");
	}

	internal static InvalidProtocolBufferException JsonRecursionLimitExceeded()
	{
		return new InvalidProtocolBufferException("Protocol message had too many levels of nesting.  May be malicious.  Use JsonParser.Settings to increase the depth limit.");
	}

	internal static InvalidProtocolBufferException SizeLimitExceeded()
	{
		return new InvalidProtocolBufferException("Protocol message was too large.  May be malicious.  Use CodedInputStream.SetSizeLimit() to increase the size limit.");
	}

	internal static InvalidProtocolBufferException InvalidMessageStreamTag()
	{
		return new InvalidProtocolBufferException("Stream of protocol messages had invalid tag. Expected tag is length-delimited field 1.");
	}
}
