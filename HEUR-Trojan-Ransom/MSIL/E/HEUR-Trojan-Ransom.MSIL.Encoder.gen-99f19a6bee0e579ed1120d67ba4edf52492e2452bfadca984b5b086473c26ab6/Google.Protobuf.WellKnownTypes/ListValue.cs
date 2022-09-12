using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class ListValue : IMessage<ListValue>, IEquatable<ListValue>, IDeepCloneable<ListValue>, IMessage
{
	private static readonly MessageParser<ListValue> _parser = new MessageParser<ListValue>(() => new ListValue());

	private UnknownFieldSet _unknownFields;

	public const int ValuesFieldNumber = 1;

	private static readonly FieldCodec<Value> _repeated_values_codec = FieldCodec.ForMessage(10u, Value.Parser);

	private readonly RepeatedField<Value> values_ = new RepeatedField<Value>();

	[DebuggerNonUserCode]
	public static MessageParser<ListValue> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => StructReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Value> Values => values_;

	[DebuggerNonUserCode]
	public ListValue()
	{
	}

	[DebuggerNonUserCode]
	public ListValue(ListValue other)
		: this()
	{
		values_ = other.values_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public ListValue Clone()
	{
		return new ListValue(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ListValue);
	}

	[DebuggerNonUserCode]
	public bool Equals(ListValue other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!values_.Equals(other.values_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ values_.GetHashCode();
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
		values_.WriteTo(output, _repeated_values_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + values_.CalculateSize(_repeated_values_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ListValue other)
	{
		if (other != null)
		{
			values_.Add(other.values_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				values_.AddEntriesFrom(input, _repeated_values_codec);
			}
		}
	}
}
