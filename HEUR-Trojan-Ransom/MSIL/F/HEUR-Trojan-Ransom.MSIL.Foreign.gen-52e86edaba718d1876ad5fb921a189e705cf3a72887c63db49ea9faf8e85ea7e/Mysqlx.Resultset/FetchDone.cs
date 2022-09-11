using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns10;

namespace Mysqlx.Resultset;

internal sealed class FetchDone : IMessage, IMessage<FetchDone>, IEquatable<FetchDone>, IDeepCloneable<FetchDone>
{
	private static readonly MessageParser<FetchDone> messageParser_0 = new MessageParser<FetchDone>(() => new FetchDone());

	[DebuggerNonUserCode]
	public static MessageParser<FetchDone> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class21.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public FetchDone()
	{
	}

	[DebuggerNonUserCode]
	public FetchDone(FetchDone other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public FetchDone Clone()
	{
		return new FetchDone(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<FetchDone>)this).Equals(obj as FetchDone);
	}

	[DebuggerNonUserCode]
	bool IEquatable<FetchDone>.Equals(FetchDone other)
	{
		if (other == null)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		return 1;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return 0;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FetchDone other)
	{
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			input.SkipLastField();
		}
	}
}
