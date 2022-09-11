using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns14;

namespace Mysqlx.Connection;

internal sealed class CapabilitiesGet : IMessage, IMessage<CapabilitiesGet>, IEquatable<CapabilitiesGet>, IDeepCloneable<CapabilitiesGet>
{
	private static readonly MessageParser<CapabilitiesGet> messageParser_0 = new MessageParser<CapabilitiesGet>(() => new CapabilitiesGet());

	[DebuggerNonUserCode]
	public static MessageParser<CapabilitiesGet> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class36.Descriptor.MessageTypes[2];

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
	bool object.Equals(object obj)
	{
		return ((IEquatable<CapabilitiesGet>)this).Equals(obj as CapabilitiesGet);
	}

	[DebuggerNonUserCode]
	bool IEquatable<CapabilitiesGet>.Equals(CapabilitiesGet other)
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
