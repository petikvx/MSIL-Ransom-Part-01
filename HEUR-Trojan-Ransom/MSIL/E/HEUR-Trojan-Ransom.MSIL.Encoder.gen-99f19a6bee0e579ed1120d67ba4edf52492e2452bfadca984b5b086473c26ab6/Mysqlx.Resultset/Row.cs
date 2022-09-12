using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal sealed class Row : IMessage<Row>, IEquatable<Row>, IDeepCloneable<Row>, IMessage
{
	private static readonly MessageParser<Row> _parser = new MessageParser<Row>(() => new Row());

	private UnknownFieldSet _unknownFields;

	public const int FieldFieldNumber = 1;

	private static readonly FieldCodec<ByteString> _repeated_field_codec = FieldCodec.ForBytes(10u);

	private readonly RepeatedField<ByteString> field_ = new RepeatedField<ByteString>();

	[DebuggerNonUserCode]
	public static MessageParser<Row> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxResultsetReflection.Descriptor.MessageTypes[5];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<ByteString> Field => field_;

	[DebuggerNonUserCode]
	public Row()
	{
	}

	[DebuggerNonUserCode]
	public Row(Row other)
		: this()
	{
		field_ = other.field_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Row Clone()
	{
		return new Row(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Row);
	}

	[DebuggerNonUserCode]
	public bool Equals(Row other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!field_.Equals(other.field_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ field_.GetHashCode();
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
		field_.WriteTo(output, _repeated_field_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + field_.CalculateSize(_repeated_field_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Row other)
	{
		if (other != null)
		{
			field_.Add(other.field_);
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
				field_.AddEntriesFrom(input, _repeated_field_codec);
			}
		}
	}
}
