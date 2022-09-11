using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns14;

namespace Mysqlx.Connection;

internal sealed class Close : IMessage, IMessage<Close>, IEquatable<Close>, IDeepCloneable<Close>
{
	private static readonly MessageParser<Close> messageParser_0 = new MessageParser<Close>(() => new Close());

	[DebuggerNonUserCode]
	public static MessageParser<Close> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class36.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Close()
	{
	}

	[DebuggerNonUserCode]
	public Close(Close other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public Close Clone()
	{
		return new Close(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Close>)this).Equals(obj as Close);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Close>.Equals(Close other)
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
	public void MergeFrom(Close other)
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
