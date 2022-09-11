using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Type : IMessage, IMessage<Type>, IEquatable<Type>, IDeepCloneable<Type>
{
	private static readonly MessageParser<Type> _parser;

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = getString_0(107399851);

	public const int FieldsFieldNumber = 2;

	private static readonly FieldCodec<Field> _repeated_fields_codec;

	private readonly RepeatedField<Field> fields_ = new RepeatedField<Field>();

	public const int OneofsFieldNumber = 3;

	private static readonly FieldCodec<string> _repeated_oneofs_codec;

	private readonly RepeatedField<string> oneofs_ = new RepeatedField<string>();

	public const int OptionsFieldNumber = 4;

	private static readonly FieldCodec<Option> _repeated_options_codec;

	private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

	public const int SourceContextFieldNumber = 5;

	private SourceContext sourceContext_;

	public const int SyntaxFieldNumber = 6;

	private Syntax syntax_;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Type> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TypeReflection.Descriptor.MessageTypes[0];

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
			name_ = ProtoPreconditions.CheckNotNull(value, getString_0(107394804));
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Field> Fields => fields_;

	[DebuggerNonUserCode]
	public RepeatedField<string> Oneofs => oneofs_;

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
	public Type()
	{
	}

	[DebuggerNonUserCode]
	public Type(Type other)
		: this()
	{
		name_ = other.name_;
		fields_ = other.fields_.Clone();
		oneofs_ = other.oneofs_.Clone();
		options_ = other.options_.Clone();
		SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
		syntax_ = other.syntax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Type Clone()
	{
		return new Type(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Type);
	}

	[DebuggerNonUserCode]
	public bool Equals(Type other)
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
		if (!fields_.Equals(other.fields_))
		{
			return false;
		}
		if (!oneofs_.Equals(other.oneofs_))
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
		num ^= fields_.GetHashCode();
		num ^= oneofs_.GetHashCode();
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
		fields_.WriteTo(output, _repeated_fields_codec);
		oneofs_.WriteTo(output, _repeated_oneofs_codec);
		options_.WriteTo(output, _repeated_options_codec);
		if (sourceContext_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(SourceContext);
		}
		if (Syntax != 0)
		{
			output.WriteRawTag(48);
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
		num += fields_.CalculateSize(_repeated_fields_codec);
		num += oneofs_.CalculateSize(_repeated_oneofs_codec);
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
	public void MergeFrom(Type other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		fields_.Add(other.fields_);
		oneofs_.Add(other.oneofs_);
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
			case 26u:
				oneofs_.AddEntriesFrom(input, _repeated_oneofs_codec);
				break;
			case 18u:
				fields_.AddEntriesFrom(input, _repeated_fields_codec);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 48u:
				syntax_ = (Syntax)input.ReadEnum();
				break;
			case 42u:
				if (sourceContext_ == null)
				{
					sourceContext_ = new SourceContext();
				}
				input.ReadMessage(sourceContext_);
				break;
			case 34u:
				options_.AddEntriesFrom(input, _repeated_options_codec);
				break;
			}
		}
	}

	static Type()
	{
		Strings.CreateGetStringDelegate(typeof(Type));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400029), getString_0(107400024)).Replace(getString_0(107399987), getString_0(107399982)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399977)))
		{
			throw new SecurityException(getString_0(107399952));
		}
		_parser = new MessageParser<Type>(() => new Type());
		_repeated_fields_codec = FieldCodec.ForMessage(18u, Field.Parser);
		_repeated_oneofs_codec = FieldCodec.ForString(26u);
		_repeated_options_codec = FieldCodec.ForMessage(34u, Option.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
