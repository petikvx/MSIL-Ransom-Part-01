using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Connection;

internal sealed class CapabilitiesGet : IMessage<CapabilitiesGet>, IEquatable<CapabilitiesGet>, IDeepCloneable<CapabilitiesGet>, IMessage
{
	private static readonly MessageParser<CapabilitiesGet> _parser = new MessageParser<CapabilitiesGet>(() => new CapabilitiesGet());

	[DebuggerNonUserCode]
	public static MessageParser<CapabilitiesGet> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxConnectionReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public CapabilitiesGet()
	{
	}

	[DebuggerNonUserCode]
	public CapabilitiesGet(CapabilitiesGet other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public CapabilitiesGet Clone()
	{
		return new CapabilitiesGet(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CapabilitiesGet);
	}

	[DebuggerNonUserCode]
	public bool Equals(CapabilitiesGet other)
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
	public void MergeFrom(CapabilitiesGet other)
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
