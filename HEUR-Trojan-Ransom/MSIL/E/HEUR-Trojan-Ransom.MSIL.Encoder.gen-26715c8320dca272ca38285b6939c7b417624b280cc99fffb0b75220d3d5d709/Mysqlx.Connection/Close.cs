using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Connection;

internal sealed class Close : IMessage<Close>, IMessage, IEquatable<Close>, IDeepCloneable<Close>
{
	private static readonly MessageParser<Close> _parser = new MessageParser<Close>((Func<Close>)(() => new Close()));

	[DebuggerNonUserCode]
	public static MessageParser<Close> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxConnectionReflection.Descriptor.get_MessageTypes()[4];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

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
	public override bool Equals(object other)
	{
		return Equals(other as Close);
	}

	[DebuggerNonUserCode]
	public bool Equals(Close other)
	{
		if (other == null)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return 1;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString((IMessage)(object)this);
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
