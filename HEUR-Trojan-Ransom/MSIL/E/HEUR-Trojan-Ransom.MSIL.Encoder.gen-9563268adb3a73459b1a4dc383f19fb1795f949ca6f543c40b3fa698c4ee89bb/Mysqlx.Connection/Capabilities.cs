using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Connection;

internal sealed class Capabilities : IMessage<Capabilities>, IEquatable<Capabilities>, IDeepCloneable<Capabilities>, IMessage
{
	private static readonly MessageParser<Capabilities> _parser = new MessageParser<Capabilities>(() => new Capabilities());

	public const int Capabilities_FieldNumber = 1;

	private static readonly FieldCodec<Capability> _repeated_capabilities_codec = FieldCodec.ForMessage(10u, Capability.Parser);

	private readonly RepeatedField<Capability> capabilities_ = new RepeatedField<Capability>();

	[DebuggerNonUserCode]
	public static MessageParser<Capabilities> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxConnectionReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Capability> Capabilities_ => capabilities_;

	[DebuggerNonUserCode]
	public Capabilities()
	{
	}

	[DebuggerNonUserCode]
	public Capabilities(Capabilities other)
		: this()
	{
		capabilities_ = other.capabilities_.Clone();
	}

	[DebuggerNonUserCode]
	public Capabilities Clone()
	{
		return new Capabilities(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Capabilities);
	}

	[DebuggerNonUserCode]
	public bool Equals(Capabilities other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!capabilities_.Equals(other.capabilities_))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return 1 ^ capabilities_.GetHashCode();
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		capabilities_.WriteTo(output, _repeated_capabilities_codec);
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return 0 + capabilities_.CalculateSize(_repeated_capabilities_codec);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Capabilities other)
	{
		if (other != null)
		{
			capabilities_.Add(other.capabilities_);
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				input.SkipLastField();
			}
			else
			{
				capabilities_.AddEntriesFrom(input, _repeated_capabilities_codec);
			}
		}
	}
}
