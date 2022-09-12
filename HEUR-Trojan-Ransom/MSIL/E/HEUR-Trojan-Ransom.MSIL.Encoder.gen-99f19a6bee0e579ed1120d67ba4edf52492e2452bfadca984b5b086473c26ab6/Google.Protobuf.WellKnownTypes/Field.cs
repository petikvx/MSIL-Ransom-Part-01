using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Field : IMessage<Field>, IEquatable<Field>, IDeepCloneable<Field>, IMessage
{
	[DebuggerNonUserCode]
	public static class Types
	{
		public enum Kind
		{
			[OriginalName("TYPE_UNKNOWN")]
			TypeUnknown,
			[OriginalName("TYPE_DOUBLE")]
			TypeDouble,
			[OriginalName("TYPE_FLOAT")]
			TypeFloat,
			[OriginalName("TYPE_INT64")]
			TypeInt64,
			[OriginalName("TYPE_UINT64")]
			TypeUint64,
			[OriginalName("TYPE_INT32")]
			TypeInt32,
			[OriginalName("TYPE_FIXED64")]
			TypeFixed64,
			[OriginalName("TYPE_FIXED32")]
			TypeFixed32,
			[OriginalName("TYPE_BOOL")]
			TypeBool,
			[OriginalName("TYPE_STRING")]
			TypeString,
			[OriginalName("TYPE_GROUP")]
			TypeGroup,
			[OriginalName("TYPE_MESSAGE")]
			TypeMessage,
			[OriginalName("TYPE_BYTES")]
			TypeBytes,
			[OriginalName("TYPE_UINT32")]
			TypeUint32,
			[OriginalName("TYPE_ENUM")]
			TypeEnum,
			[OriginalName("TYPE_SFIXED32")]
			TypeSfixed32,
			[OriginalName("TYPE_SFIXED64")]
			TypeSfixed64,
			[OriginalName("TYPE_SINT32")]
			TypeSint32,
			[OriginalName("TYPE_SINT64")]
			TypeSint64
		}

		public enum Cardinality
		{
			[OriginalName("CARDINALITY_UNKNOWN")]
			Unknown,
			[OriginalName("CARDINALITY_OPTIONAL")]
			Optional,
			[OriginalName("CARDINALITY_REQUIRED")]
			Required,
			[OriginalName("CARDINALITY_REPEATED")]
			Repeated
		}
	}

	private static readonly MessageParser<Field> _parser = new MessageParser<Field>(() => new Field());

	private UnknownFieldSet _unknownFields;

	public const int KindFieldNumber = 1;

	private Types.Kind kind_;

	public const int CardinalityFieldNumber = 2;

	private Types.Cardinality cardinality_;

	public const int NumberFieldNumber = 3;

	private int number_;

	public const int NameFieldNumber = 4;

	private string name_ = "";

	public const int TypeUrlFieldNumber = 6;

	private string typeUrl_ = "";

	public const int OneofIndexFieldNumber = 7;

	private int oneofIndex_;

	public const int PackedFieldNumber = 8;

	private bool packed_;

	public const int OptionsFieldNumber = 9;

	private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(74u, Option.Parser);

	private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

	public const int JsonNameFieldNumber = 10;

	private string jsonName_ = "";

	public const int DefaultValueFieldNumber = 11;

	private string defaultValue_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Field> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Kind Kind
	{
		get
		{
			return kind_;
		}
		set
		{
			kind_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.Cardinality Cardinality
	{
		get
		{
			return cardinality_;
		}
		set
		{
			cardinality_ = value;
		}
	}

	[DebuggerNonUserCode]
	public int Number
	{
		get
		{
			return number_;
		}
		set
		{
			number_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string TypeUrl
	{
		get
		{
			return typeUrl_;
		}
		set
		{
			typeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public int OneofIndex
	{
		get
		{
			return oneofIndex_;
		}
		set
		{
			oneofIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool Packed
	{
		get
		{
			return packed_;
		}
		set
		{
			packed_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options => options_;

	[DebuggerNonUserCode]
	public string JsonName
	{
		get
		{
			return jsonName_;
		}
		set
		{
			jsonName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string DefaultValue
	{
		get
		{
			return defaultValue_;
		}
		set
		{
			defaultValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Field()
	{
	}

	[DebuggerNonUserCode]
	public Field(Field other)
		: this()
	{
		kind_ = other.kind_;
		cardinality_ = other.cardinality_;
		number_ = other.number_;
		name_ = other.name_;
		typeUrl_ = other.typeUrl_;
		oneofIndex_ = other.oneofIndex_;
		packed_ = other.packed_;
		options_ = other.options_.Clone();
		jsonName_ = other.jsonName_;
		defaultValue_ = other.defaultValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Field Clone()
	{
		return new Field(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Field);
	}

	[DebuggerNonUserCode]
	public bool Equals(Field other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Kind != other.Kind)
		{
			return false;
		}
		if (Cardinality != other.Cardinality)
		{
			return false;
		}
		if (Number != other.Number)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (TypeUrl != other.TypeUrl)
		{
			return false;
		}
		if (OneofIndex != other.OneofIndex)
		{
			return false;
		}
		if (Packed != other.Packed)
		{
			return false;
		}
		if (!options_.Equals(other.options_))
		{
			return false;
		}
		if (JsonName != other.JsonName)
		{
			return false;
		}
		if (DefaultValue != other.DefaultValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Kind != 0)
		{
			num ^= Kind.GetHashCode();
		}
		if (Cardinality != 0)
		{
			num ^= Cardinality.GetHashCode();
		}
		if (Number != 0)
		{
			num ^= Number.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (TypeUrl.Length != 0)
		{
			num ^= TypeUrl.GetHashCode();
		}
		if (OneofIndex != 0)
		{
			num ^= OneofIndex.GetHashCode();
		}
		if (Packed)
		{
			num ^= Packed.GetHashCode();
		}
		num ^= options_.GetHashCode();
		if (JsonName.Length != 0)
		{
			num ^= JsonName.GetHashCode();
		}
		if (DefaultValue.Length != 0)
		{
			num ^= DefaultValue.GetHashCode();
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
		if (Kind != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Kind);
		}
		if (Cardinality != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Cardinality);
		}
		if (Number != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Number);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Name);
		}
		if (TypeUrl.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(TypeUrl);
		}
		if (OneofIndex != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(OneofIndex);
		}
		if (Packed)
		{
			output.WriteRawTag(64);
			output.WriteBool(Packed);
		}
		options_.WriteTo(output, _repeated_options_codec);
		if (JsonName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(JsonName);
		}
		if (DefaultValue.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(DefaultValue);
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
		if (Kind != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Kind);
		}
		if (Cardinality != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Cardinality);
		}
		if (Number != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Number);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (TypeUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TypeUrl);
		}
		if (OneofIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OneofIndex);
		}
		if (Packed)
		{
			num += 2;
		}
		num += options_.CalculateSize(_repeated_options_codec);
		if (JsonName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JsonName);
		}
		if (DefaultValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DefaultValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Field other)
	{
		if (other != null)
		{
			if (other.Kind != 0)
			{
				Kind = other.Kind;
			}
			if (other.Cardinality != 0)
			{
				Cardinality = other.Cardinality;
			}
			if (other.Number != 0)
			{
				Number = other.Number;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.TypeUrl.Length != 0)
			{
				TypeUrl = other.TypeUrl;
			}
			if (other.OneofIndex != 0)
			{
				OneofIndex = other.OneofIndex;
			}
			if (other.Packed)
			{
				Packed = other.Packed;
			}
			options_.Add(other.options_);
			if (other.JsonName.Length != 0)
			{
				JsonName = other.JsonName;
			}
			if (other.DefaultValue.Length != 0)
			{
				DefaultValue = other.DefaultValue;
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
			switch (num)
			{
			case 16u:
				cardinality_ = (Types.Cardinality)input.ReadEnum();
				break;
			case 8u:
				kind_ = (Types.Kind)input.ReadEnum();
				break;
			case 50u:
				TypeUrl = input.ReadString();
				break;
			case 34u:
				Name = input.ReadString();
				break;
			case 24u:
				Number = input.ReadInt32();
				break;
			case 64u:
				Packed = input.ReadBool();
				break;
			case 56u:
				OneofIndex = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 90u:
				DefaultValue = input.ReadString();
				break;
			case 82u:
				JsonName = input.ReadString();
				break;
			case 74u:
				options_.AddEntriesFrom(input, _repeated_options_codec);
				break;
			}
		}
	}
}
