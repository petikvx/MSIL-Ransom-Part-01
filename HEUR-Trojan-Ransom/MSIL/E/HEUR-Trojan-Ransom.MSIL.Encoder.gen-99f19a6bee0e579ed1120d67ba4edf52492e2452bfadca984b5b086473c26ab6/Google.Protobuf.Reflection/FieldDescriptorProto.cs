using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection;

internal sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>, IMessage
{
	[DebuggerNonUserCode]
	public static class Types
	{
		internal enum Type
		{
			[OriginalName("TYPE_DOUBLE")]
			Double = 1,
			[OriginalName("TYPE_FLOAT")]
			Float,
			[OriginalName("TYPE_INT64")]
			Int64,
			[OriginalName("TYPE_UINT64")]
			Uint64,
			[OriginalName("TYPE_INT32")]
			Int32,
			[OriginalName("TYPE_FIXED64")]
			Fixed64,
			[OriginalName("TYPE_FIXED32")]
			Fixed32,
			[OriginalName("TYPE_BOOL")]
			Bool,
			[OriginalName("TYPE_STRING")]
			String,
			[OriginalName("TYPE_GROUP")]
			Group,
			[OriginalName("TYPE_MESSAGE")]
			Message,
			[OriginalName("TYPE_BYTES")]
			Bytes,
			[OriginalName("TYPE_UINT32")]
			Uint32,
			[OriginalName("TYPE_ENUM")]
			Enum,
			[OriginalName("TYPE_SFIXED32")]
			Sfixed32,
			[OriginalName("TYPE_SFIXED64")]
			Sfixed64,
			[OriginalName("TYPE_SINT32")]
			Sint32,
			[OriginalName("TYPE_SINT64")]
			Sint64
		}

		internal enum Label
		{
			[OriginalName("LABEL_OPTIONAL")]
			Optional = 1,
			[OriginalName("LABEL_REQUIRED")]
			Required,
			[OriginalName("LABEL_REPEATED")]
			Repeated
		}
	}

	private static readonly MessageParser<FieldDescriptorProto> _parser = new MessageParser<FieldDescriptorProto>(() => new FieldDescriptorProto());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int NumberFieldNumber = 3;

	private int number_;

	public const int LabelFieldNumber = 4;

	private Types.Label label_;

	public const int TypeFieldNumber = 5;

	private Types.Type type_;

	public const int TypeNameFieldNumber = 6;

	private string typeName_ = "";

	public const int ExtendeeFieldNumber = 2;

	private string extendee_ = "";

	public const int DefaultValueFieldNumber = 7;

	private string defaultValue_ = "";

	public const int OneofIndexFieldNumber = 9;

	private int oneofIndex_;

	public const int JsonNameFieldNumber = 10;

	private string jsonName_ = "";

	public const int OptionsFieldNumber = 8;

	private FieldOptions options_;

	[DebuggerNonUserCode]
	public static MessageParser<FieldDescriptorProto> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public Types.Label Label
	{
		get
		{
			return label_;
		}
		set
		{
			label_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.Type Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string TypeName
	{
		get
		{
			return typeName_;
		}
		set
		{
			typeName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string Extendee
	{
		get
		{
			return extendee_;
		}
		set
		{
			extendee_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public FieldOptions Options
	{
		get
		{
			return options_;
		}
		set
		{
			options_ = value;
		}
	}

	[DebuggerNonUserCode]
	public FieldDescriptorProto()
	{
		OnConstruction();
	}

	private void OnConstruction()
	{
		OneofIndex = -1;
	}

	[DebuggerNonUserCode]
	public FieldDescriptorProto(FieldDescriptorProto other)
		: this()
	{
		name_ = other.name_;
		number_ = other.number_;
		label_ = other.label_;
		type_ = other.type_;
		typeName_ = other.typeName_;
		extendee_ = other.extendee_;
		defaultValue_ = other.defaultValue_;
		oneofIndex_ = other.oneofIndex_;
		jsonName_ = other.jsonName_;
		options_ = ((other.options_ != null) ? other.options_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FieldDescriptorProto Clone()
	{
		return new FieldDescriptorProto(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldDescriptorProto);
	}

	[DebuggerNonUserCode]
	public bool Equals(FieldDescriptorProto other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Number != other.Number)
		{
			return false;
		}
		if (Label != other.Label)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (TypeName != other.TypeName)
		{
			return false;
		}
		if (Extendee != other.Extendee)
		{
			return false;
		}
		if (DefaultValue != other.DefaultValue)
		{
			return false;
		}
		if (OneofIndex != other.OneofIndex)
		{
			return false;
		}
		if (JsonName != other.JsonName)
		{
			return false;
		}
		if (!object.Equals(Options, other.Options))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Number != 0)
		{
			num ^= Number.GetHashCode();
		}
		if (Label != 0)
		{
			num ^= Label.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (TypeName.Length != 0)
		{
			num ^= TypeName.GetHashCode();
		}
		if (Extendee.Length != 0)
		{
			num ^= Extendee.GetHashCode();
		}
		if (DefaultValue.Length != 0)
		{
			num ^= DefaultValue.GetHashCode();
		}
		if (OneofIndex != 0)
		{
			num ^= OneofIndex.GetHashCode();
		}
		if (JsonName.Length != 0)
		{
			num ^= JsonName.GetHashCode();
		}
		if (options_ != null)
		{
			num ^= Options.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (Extendee.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Extendee);
		}
		if (Number != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Number);
		}
		if (Label != 0)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Label);
		}
		if (Type != 0)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Type);
		}
		if (TypeName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(TypeName);
		}
		if (DefaultValue.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(DefaultValue);
		}
		if (options_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Options);
		}
		if (OneofIndex != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(OneofIndex);
		}
		if (JsonName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(JsonName);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Number != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Number);
		}
		if (Label != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Label);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (TypeName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TypeName);
		}
		if (Extendee.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Extendee);
		}
		if (DefaultValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DefaultValue);
		}
		if (OneofIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OneofIndex);
		}
		if (JsonName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JsonName);
		}
		if (options_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Options);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FieldDescriptorProto other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.Number != 0)
		{
			Number = other.Number;
		}
		if (other.Label != 0)
		{
			Label = other.Label;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		if (other.TypeName.Length != 0)
		{
			TypeName = other.TypeName;
		}
		if (other.Extendee.Length != 0)
		{
			Extendee = other.Extendee;
		}
		if (other.DefaultValue.Length != 0)
		{
			DefaultValue = other.DefaultValue;
		}
		if (other.OneofIndex != 0)
		{
			OneofIndex = other.OneofIndex;
		}
		if (other.JsonName.Length != 0)
		{
			JsonName = other.JsonName;
		}
		if (other.options_ != null)
		{
			if (options_ == null)
			{
				options_ = new FieldOptions();
			}
			Options.MergeFrom(other.Options);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 18u:
				Extendee = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			case 40u:
				type_ = (Types.Type)input.ReadEnum();
				break;
			case 32u:
				label_ = (Types.Label)input.ReadEnum();
				break;
			case 24u:
				Number = input.ReadInt32();
				break;
			case 58u:
				DefaultValue = input.ReadString();
				break;
			case 50u:
				TypeName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 82u:
				JsonName = input.ReadString();
				break;
			case 72u:
				OneofIndex = input.ReadInt32();
				break;
			case 66u:
				if (options_ == null)
				{
					options_ = new FieldOptions();
				}
				input.ReadMessage(options_);
				break;
			}
		}
	}
}
