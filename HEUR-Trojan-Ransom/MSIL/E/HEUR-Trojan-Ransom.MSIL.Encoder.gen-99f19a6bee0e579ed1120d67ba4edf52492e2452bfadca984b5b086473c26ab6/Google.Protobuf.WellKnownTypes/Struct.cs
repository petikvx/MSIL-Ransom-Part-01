using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Struct : IMessage<Struct>, IEquatable<Struct>, IDeepCloneable<Struct>, IMessage
{
	private static readonly MessageParser<Struct> _parser = new MessageParser<Struct>(() => new Struct());

	private UnknownFieldSet _unknownFields;

	public const int FieldsFieldNumber = 1;

	private static readonly MapField<string, Value>.Codec _map_fields_codec = new MapField<string, Value>.Codec(FieldCodec.ForString(10u), FieldCodec.ForMessage(18u, Value.Parser), 10u);

	private readonly MapField<string, Value> fields_ = new MapField<string, Value>();

	[DebuggerNonUserCode]
	public static MessageParser<Struct> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => StructReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public MapField<string, Value> Fields => fields_;

	[DebuggerNonUserCode]
	public Struct()
	{
	}

	[DebuggerNonUserCode]
	public Struct(Struct other)
		: this()
	{
		fields_ = other.fields_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Struct Clone()
	{
		return new Struct(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Struct);
	}

	[DebuggerNonUserCode]
	public bool Equals(Struct other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!Fields.Equals(other.Fields))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ Fields.GetHashCode();
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
		fields_.WriteTo(output, _map_fields_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + fields_.CalculateSize(_map_fields_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Struct other)
	{
		if (other != null)
		{
			fields_.Add(other.fields_);
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
				fields_.AddEntriesFrom(input, _map_fields_codec);
			}
		}
	}
}
