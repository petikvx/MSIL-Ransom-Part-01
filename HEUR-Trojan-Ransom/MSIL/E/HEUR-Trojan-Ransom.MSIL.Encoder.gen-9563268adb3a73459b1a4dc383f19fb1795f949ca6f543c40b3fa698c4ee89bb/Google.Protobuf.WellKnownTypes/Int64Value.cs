using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Int64Value : IMessage<Int64Value>, IEquatable<Int64Value>, IDeepCloneable<Int64Value>, IMessage
{
	private static readonly MessageParser<Int64Value> _parser = new MessageParser<Int64Value>(() => new Int64Value());

	private UnknownFieldSet _unknownFields;

	public const int ValueFieldNumber = 1;

	private long value_;

	[DebuggerNonUserCode]
	public static MessageParser<Int64Value> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => WrappersReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public long Value
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
	public Int64Value()
	{
	}

	[DebuggerNonUserCode]
	public Int64Value(Int64Value other)
		: this()
	{
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Int64Value Clone()
	{
		return new Int64Value(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Int64Value);
	}

	[DebuggerNonUserCode]
	public bool Equals(Int64Value other)
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
			output.WriteInt64(Value);
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
			num += 1 + CodedOutputStream.ComputeInt64Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Int64Value other)
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
				Value = input.ReadInt64();
			}
		}
	}
}
