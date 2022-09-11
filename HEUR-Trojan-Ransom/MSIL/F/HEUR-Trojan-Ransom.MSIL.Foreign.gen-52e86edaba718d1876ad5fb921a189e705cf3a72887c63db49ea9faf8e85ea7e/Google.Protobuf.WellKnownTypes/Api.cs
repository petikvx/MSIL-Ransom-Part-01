using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Api : IMessage, IMessage<Api>, IEquatable<Api>, IDeepCloneable<Api>
{
	private static readonly MessageParser<Api> _parser;

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = getString_0(107399709);

	public const int MethodsFieldNumber = 2;

	private static readonly FieldCodec<Method> _repeated_methods_codec;

	private readonly RepeatedField<Method> methods_ = new RepeatedField<Method>();

	public const int OptionsFieldNumber = 3;

	private static readonly FieldCodec<Option> _repeated_options_codec;

	private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

	public const int VersionFieldNumber = 4;

	private string version_ = getString_0(107399709);

	public const int SourceContextFieldNumber = 5;

	private SourceContext sourceContext_;

	public const int MixinsFieldNumber = 6;

	private static readonly FieldCodec<Mixin> _repeated_mixins_codec;

	private readonly RepeatedField<Mixin> mixins_ = new RepeatedField<Mixin>();

	public const int SyntaxFieldNumber = 7;

	private Syntax syntax_;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Api> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ApiReflection.Descriptor.MessageTypes[0];

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
			name_ = ProtoPreconditions.CheckNotNull(value, getString_0(107394662));
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Method> Methods => methods_;

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options => options_;

	[DebuggerNonUserCode]
	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, getString_0(107394662));
		}
	}

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
	public RepeatedField<Mixin> Mixins => mixins_;

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
	public Api()
	{
	}

	[DebuggerNonUserCode]
	public Api(Api other)
		: this()
	{
		name_ = other.name_;
		methods_ = other.methods_.Clone();
		options_ = other.options_.Clone();
		version_ = other.version_;
		SourceContext = ((other.sourceContext_ != null) ? other.SourceContext.Clone() : null);
		mixins_ = other.mixins_.Clone();
		syntax_ = other.syntax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Api Clone()
	{
		return new Api(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Api);
	}

	[DebuggerNonUserCode]
	public bool Equals(Api other)
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
		if (!methods_.Equals(other.methods_))
		{
			return false;
		}
		if (!options_.Equals(other.options_))
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (!object.Equals(SourceContext, other.SourceContext))
		{
			return false;
		}
		if (!mixins_.Equals(other.mixins_))
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
		num ^= methods_.GetHashCode();
		num ^= options_.GetHashCode();
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (sourceContext_ != null)
		{
			num ^= SourceContext.GetHashCode();
		}
		num ^= mixins_.GetHashCode();
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
		methods_.WriteTo(output, _repeated_methods_codec);
		options_.WriteTo(output, _repeated_options_codec);
		if (Version.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Version);
		}
		if (sourceContext_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(SourceContext);
		}
		mixins_.WriteTo(output, _repeated_mixins_codec);
		if (Syntax != 0)
		{
			output.WriteRawTag(56);
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
		num += methods_.CalculateSize(_repeated_methods_codec);
		num += options_.CalculateSize(_repeated_options_codec);
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (sourceContext_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SourceContext);
		}
		num += mixins_.CalculateSize(_repeated_mixins_codec);
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
	public void MergeFrom(Api other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		methods_.Add(other.methods_);
		options_.Add(other.options_);
		if (other.Version.Length != 0)
		{
			Version = other.Version;
		}
		if (other.sourceContext_ != null)
		{
			if (sourceContext_ == null)
			{
				sourceContext_ = new SourceContext();
			}
			SourceContext.MergeFrom(other.SourceContext);
		}
		mixins_.Add(other.mixins_);
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
				options_.AddEntriesFrom(input, _repeated_options_codec);
				break;
			case 18u:
				methods_.AddEntriesFrom(input, _repeated_methods_codec);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			case 42u:
				if (sourceContext_ == null)
				{
					sourceContext_ = new SourceContext();
				}
				input.ReadMessage(sourceContext_);
				break;
			case 34u:
				Version = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 56u:
				syntax_ = (Syntax)input.ReadEnum();
				break;
			case 50u:
				mixins_.AddEntriesFrom(input, _repeated_mixins_codec);
				break;
			}
		}
	}

	static Api()
	{
		Strings.CreateGetStringDelegate(typeof(Api));
		_parser = new MessageParser<Api>(() => new Api());
		_repeated_methods_codec = FieldCodec.ForMessage(18u, Method.Parser);
		_repeated_options_codec = FieldCodec.ForMessage(26u, Option.Parser);
		_repeated_mixins_codec = FieldCodec.ForMessage(50u, Mixin.Parser);
	}
}
