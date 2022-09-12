using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class UInt64Value : IMessage<UInt64Value>, IEquatable<UInt64Value>, IDeepCloneable<UInt64Value>, IMessage
{
	private static readonly MessageParser<UInt64Value> _parser = new MessageParser<UInt64Value>(() => new UInt64Value());

	private UnknownFieldSet _unknownFields;

	public const int ValueFieldNumber = 1;

	private ulong value_;

	[DebuggerNonUserCode]
	public static MessageParser<UInt64Value> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ulong Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[DebuggerNonUserCode]
	public UInt64Value()
	{
	}

	[DebuggerNonUserCode]
	public UInt64Value(UInt64Value other)
		: this()
	{
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public UInt64Value Clone()
	{
		return new UInt64Value(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as UInt64Value);
	}

	[DebuggerNonUserCode]
	public bool Equals(UInt64Value other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Value != 0L)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (Value != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Value != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(UInt64Value other)
	{
		if (other != null)
		{
			if (other.Value != 0L)
			{
				Value = other.Value;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Value = input.ReadUInt64();
			}
		}
	}
}
