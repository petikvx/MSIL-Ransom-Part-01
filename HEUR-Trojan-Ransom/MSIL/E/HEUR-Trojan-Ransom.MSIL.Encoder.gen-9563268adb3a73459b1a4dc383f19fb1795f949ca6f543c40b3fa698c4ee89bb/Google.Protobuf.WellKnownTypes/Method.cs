using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Method : IMessage<Method>, IEquatable<Method>, IDeepCloneable<Method>, IMessage
{
	private static readonly MessageParser<Method> _parser = new MessageParser<Method>(() => new Method());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int RequestTypeUrlFieldNumber = 2;

	private string requestTypeUrl_ = "";

	public const int RequestStreamingFieldNumber = 3;

	private bool requestStreaming_;

	public const int ResponseTypeUrlFieldNumber = 4;

	private string responseTypeUrl_ = "";

	public const int ResponseStreamingFieldNumber = 5;

	private bool responseStreaming_;

	public const int OptionsFieldNumber = 6;

	private static readonly FieldCodec<Option> _repeated_options_codec = FieldCodec.ForMessage(50u, Option.Parser);

	private readonly RepeatedField<Option> options_ = new RepeatedField<Option>();

	public const int SyntaxFieldNumber = 7;

	private Syntax syntax_;

	[DebuggerNonUserCode]
	public static MessageParser<Method> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ApiReflection.Descriptor.MessageTypes[1];

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
	public string RequestTypeUrl
	{
		get
		{
			return requestTypeUrl_;
		}
		set
		{
			requestTypeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public bool RequestStreaming
	{
		get
		{
			return requestStreaming_;
		}
		set
		{
			requestStreaming_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string ResponseTypeUrl
	{
		get
		{
			return responseTypeUrl_;
		}
		set
		{
			responseTypeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public bool ResponseStreaming
	{
		get
		{
			return responseStreaming_;
		}
		set
		{
			responseStreaming_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options => options_;

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
	public Method()
	{
	}

	[DebuggerNonUserCode]
	public Method(Method other)
		: this()
	{
		name_ = other.name_;
		requestTypeUrl_ = other.requestTypeUrl_;
		requestStreaming_ = other.requestStreaming_;
		responseTypeUrl_ = other.responseTypeUrl_;
		responseStreaming_ = other.responseStreaming_;
		options_ = other.options_.Clone();
		syntax_ = other.syntax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Method Clone()
	{
		return new Method(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Method);
	}

	[DebuggerNonUserCode]
	public bool Equals(Method other)
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
		if (RequestTypeUrl != other.RequestTypeUrl)
		{
			return false;
		}
		if (RequestStreaming != other.RequestStreaming)
		{
			return false;
		}
		if (ResponseTypeUrl != other.ResponseTypeUrl)
		{
			return false;
		}
		if (ResponseStreaming != other.ResponseStreaming)
		{
			return false;
		}
		if (!options_.Equals(other.options_))
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
		if (RequestTypeUrl.Length != 0)
		{
			num ^= RequestTypeUrl.GetHashCode();
		}
		if (RequestStreaming)
		{
			num ^= RequestStreaming.GetHashCode();
		}
		if (ResponseTypeUrl.Length != 0)
		{
			num ^= ResponseTypeUrl.GetHashCode();
		}
		if (ResponseStreaming)
		{
			num ^= ResponseStreaming.GetHashCode();
		}
		num ^= options_.GetHashCode();
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
		if (RequestTypeUrl.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(RequestTypeUrl);
		}
		if (RequestStreaming)
		{
			output.WriteRawTag(24);
			output.WriteBool(RequestStreaming);
		}
		if (ResponseTypeUrl.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ResponseTypeUrl);
		}
		if (ResponseStreaming)
		{
			output.WriteRawTag(40);
			output.WriteBool(ResponseStreaming);
		}
		options_.WriteTo(output, _repeated_options_codec);
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
		if (RequestTypeUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RequestTypeUrl);
		}
		if (RequestStreaming)
		{
			num += 2;
		}
		if (ResponseTypeUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResponseTypeUrl);
		}
		if (ResponseStreaming)
		{
			num += 2;
		}
		num += options_.CalculateSize(_repeated_options_codec);
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
	public void MergeFrom(Method other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.RequestTypeUrl.Length != 0)
			{
				RequestTypeUrl = other.RequestTypeUrl;
			}
			if (other.RequestStreaming)
			{
				RequestStreaming = other.RequestStreaming;
			}
			if (other.ResponseTypeUrl.Length != 0)
			{
				ResponseTypeUrl = other.ResponseTypeUrl;
			}
			if (other.ResponseStreaming)
			{
				ResponseStreaming = other.ResponseStreaming;
			}
			options_.Add(other.options_);
			if (other.Syntax != 0)
			{
				Syntax = other.Syntax;
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
			case 24u:
				RequestStreaming = input.ReadBool();
				break;
			case 18u:
				RequestTypeUrl = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			case 40u:
				ResponseStreaming = input.ReadBool();
				break;
			case 34u:
				ResponseTypeUrl = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 56u:
				syntax_ = (Syntax)input.ReadEnum();
				break;
			case 50u:
				options_.AddEntriesFrom(input, _repeated_options_codec);
				break;
			}
		}
	}
}
