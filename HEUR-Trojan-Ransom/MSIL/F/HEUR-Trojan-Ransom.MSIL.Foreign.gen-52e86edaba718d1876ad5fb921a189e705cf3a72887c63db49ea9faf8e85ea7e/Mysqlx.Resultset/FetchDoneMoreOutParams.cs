using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns10;

namespace Mysqlx.Resultset;

internal sealed class FetchDoneMoreOutParams : IMessage, IMessage<FetchDoneMoreOutParams>, IEquatable<FetchDoneMoreOutParams>, IDeepCloneable<FetchDoneMoreOutParams>
{
	private static readonly MessageParser<FetchDoneMoreOutParams> messageParser_0 = new MessageParser<FetchDoneMoreOutParams>(() => new FetchDoneMoreOutParams());

	[DebuggerNonUserCode]
	public static MessageParser<FetchDoneMoreOutParams> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class21.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public FetchDoneMoreOutParams()
	{
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreOutParams(FetchDoneMoreOutParams other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreOutParams Clone()
	{
		return new FetchDoneMoreOutParams(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<FetchDoneMoreOutParams>)this).Equals(obj as FetchDoneMoreOutParams);
	}

	[DebuggerNonUserCode]
	bool IEquatable<FetchDoneMoreOutParams>.Equals(FetchDoneMoreOutParams other)
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
	public void MergeFrom(FetchDoneMoreOutParams other)
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
