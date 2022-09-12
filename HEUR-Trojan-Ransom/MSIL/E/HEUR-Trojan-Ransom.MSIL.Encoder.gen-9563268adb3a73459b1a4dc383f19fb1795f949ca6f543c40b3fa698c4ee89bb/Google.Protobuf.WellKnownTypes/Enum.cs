using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Enum : IMessage<Enum>, IEquatable<Enum>, IDeepCloneable<Enum>, IMessage
{
	private static readonly MessageParser<Enum> _parser = new MessageParser<Enum>(() => new Enum());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int EnumvalueFieldNumber = 2;

	private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec = FieldCodec.ForMessage(18u, EnumValue.Parser);

	private readonly RepeatedField<EnumValue> enumvalue_ = new RepeatedField<EnumValue>();

	public const int OptionsFieldNumber = 3;

	private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(26u, Option.Parser);

	private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

	public const int SourceContextFieldNumber = 4;

	private SourceContext sourceContext_;

	public const int SyntaxFieldNumber = 5;

	private Syntax syntax_;

	[DebuggerNonUserCode]
	public static MessageParser<Enum> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[2];

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
	public RepeatedField<EnumValue> Enumvalue => enumvalue_;

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options => options_;

	[DebuggerNonUserCode]
	public SourceContext SourceContext
	{
		get
		{
			return sourceContext_;
		}
		set
		{
			sourceContext_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Syntax Syntax
	{
		get
		{
			return syntax_;
		}
		set
		{
			syntax_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Enum()
	{
	}

	[DebuggerNonUserCode]
	public Enum(Enum other)
		: this()
	{
		name_ = other.name_;
		enumvalue_ = other.enumvalue_.Clone();
		options_ = other.options_.Clone();
		sourceContext_ = ((other.sourceContext_ != null) ? other.sourceContext_.Clone() : null);
		syntax_ = other.syntax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Enum Clone()
	{
		return new Enum(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Enum);
	}

	[DebuggerNonUserCode]
	public bool Equals(Enum other)
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
		if (!enumvalue_.Equals(other.enumvalue_))
		{
			return false;
		}
		if (!options_.Equals(other.options_))
		{
			return false;
		}
		if (!object.Equals(SourceContext, other.SourceContext))
		{
			return false;
		}
		if (Syntax != other.Syntax)
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
		num ^= enumvalue_.GetHashCode();
		num ^= options_.GetHashCode();
		if (sourceContext_ != null)
		{
			num ^= SourceContext.GetHashCode();
		}
		if (Syntax != 0)
		{
			num ^= Syntax.GetHashCode();
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
		enumvalue_.WriteTo(output, _repeated_enumvalue_codec);
		options_.WriteTo(output, _repeated_options_codec);
		if (sourceContext_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(SourceContext);
		}
		if (Syntax != 0)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Syntax);
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
		num += enumvalue_.CalculateSize(_repeated_enumvalue_codec);
		num += options_.CalculateSize(_repeated_options_codec);
		if (sourceContext_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SourceContext);
		}
		if (Syntax != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Syntax);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Enum other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		enumvalue_.Add(other.enumvalue_);
		options_.Add(other.options_);
		if (other.sourceContext_ != null)
		{
			if (sourceContext_ == null)
			{
				sourceContext_ = new SourceContext();
			}
			SourceContext.MergeFrom(other.SourceContext);
		}
		if (other.Syntax != 0)
		{
			Syntax = other.Syntax;
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
				enumvalue_.AddEntriesFrom(input, _repeated_enumvalue_codec);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 40u:
				syntax_ = (Syntax)input.ReadEnum();
				break;
			case 34u:
				if (sourceContext_ == null)
				{
					sourceContext_ = new SourceContext();
				}
				input.ReadMessage(sourceContext_);
				break;
			case 26u:
				options_.AddEntriesFrom(input, _repeated_options_codec);
				break;
			}
		}
	}
}
