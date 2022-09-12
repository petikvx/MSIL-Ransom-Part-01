using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expr;

internal sealed class Array : IMessage<Array>, IEquatable<Array>, IDeepCloneable<Array>, IMessage
{
	private static readonly MessageParser<Array> _parser = new MessageParser<Array>(() => new Array());

	private UnknownFieldSet _unknownFields;

	public const int ValueFieldNumber = 1;

	private static readonly FieldCodec<Expr> _repeated_value_codec = FieldCodec.ForMessage(10u, Expr.Parser);

	private readonly RepeatedField<Expr> value_ = new RepeatedField<Expr>();

	[DebuggerNonUserCode]
	public static MessageParser<Array> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.MessageTypes[7];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Expr> Value => value_;

	[DebuggerNonUserCode]
	public Array()
	{
	}

	[DebuggerNonUserCode]
	public Array(Array other)
		: this()
	{
		value_ = other.value_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Array Clone()
	{
		return new Array(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Array);
	}

	[DebuggerNonUserCode]
	public bool Equals(Array other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!value_.Equals(other.value_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ value_.GetHashCode();
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
		value_.WriteTo(output, _repeated_value_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + value_.CalculateSize(_repeated_value_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Array other)
	{
		if (other != null)
		{
			value_.Add(other.value_);
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
				value_.AddEntriesFrom(input, _repeated_value_codec);
			}
		}
	}
}
