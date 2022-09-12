using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection;

internal sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>, IMessage
{
	private static readonly MessageParser<MethodDescriptorProto> _parser = new MessageParser<MethodDescriptorProto>(() => new MethodDescriptorProto());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int InputTypeFieldNumber = 2;

	private string inputType_ = "";

	public const int OutputTypeFieldNumber = 3;

	private string outputType_ = "";

	public const int OptionsFieldNumber = 4;

	private MethodOptions options_;

	public const int ClientStreamingFieldNumber = 5;

	private bool clientStreaming_;

	public const int ServerStreamingFieldNumber = 6;

	private bool serverStreaming_;

	[DebuggerNonUserCode]
	public static MessageParser<MethodDescriptorProto> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[9];

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
	public string InputType
	{
		get
		{
			return inputType_;
		}
		set
		{
			inputType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string OutputType
	{
		get
		{
			return outputType_;
		}
		set
		{
			outputType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public MethodOptions Options
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
	public bool ClientStreaming
	{
		get
		{
			return clientStreaming_;
		}
		set
		{
			clientStreaming_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool ServerStreaming
	{
		get
		{
			return serverStreaming_;
		}
		set
		{
			serverStreaming_ = value;
		}
	}

	[DebuggerNonUserCode]
	public MethodDescriptorProto()
	{
	}

	[DebuggerNonUserCode]
	public MethodDescriptorProto(MethodDescriptorProto other)
		: this()
	{
		name_ = other.name_;
		inputType_ = other.inputType_;
		outputType_ = other.outputType_;
		options_ = ((other.options_ != null) ? other.options_.Clone() : null);
		clientStreaming_ = other.clientStreaming_;
		serverStreaming_ = other.serverStreaming_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public MethodDescriptorProto Clone()
	{
		return new MethodDescriptorProto(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MethodDescriptorProto);
	}

	[DebuggerNonUserCode]
	public bool Equals(MethodDescriptorProto other)
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
		if (InputType != other.InputType)
		{
			return false;
		}
		if (OutputType != other.OutputType)
		{
			return false;
		}
		if (!object.Equals(Options, other.Options))
		{
			return false;
		}
		if (ClientStreaming != other.ClientStreaming)
		{
			return false;
		}
		if (ServerStreaming != other.ServerStreaming)
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
		if (InputType.Length != 0)
		{
			num ^= InputType.GetHashCode();
		}
		if (OutputType.Length != 0)
		{
			num ^= OutputType.GetHashCode();
		}
		if (options_ != null)
		{
			num ^= Options.GetHashCode();
		}
		if (ClientStreaming)
		{
			num ^= ClientStreaming.GetHashCode();
		}
		if (ServerStreaming)
		{
			num ^= ServerStreaming.GetHashCode();
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
		if (InputType.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(InputType);
		}
		if (OutputType.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(OutputType);
		}
		if (options_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Options);
		}
		if (ClientStreaming)
		{
			output.WriteRawTag(40);
			output.WriteBool(ClientStreaming);
		}
		if (ServerStreaming)
		{
			output.WriteRawTag(48);
			output.WriteBool(ServerStreaming);
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
		if (InputType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InputType);
		}
		if (OutputType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OutputType);
		}
		if (options_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Options);
		}
		if (ClientStreaming)
		{
			num += 2;
		}
		if (ServerStreaming)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(MethodDescriptorProto other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.InputType.Length != 0)
		{
			InputType = other.InputType;
		}
		if (other.OutputType.Length != 0)
		{
			OutputType = other.OutputType;
		}
		if (other.options_ != null)
		{
			if (options_ == null)
			{
				options_ = new MethodOptions();
			}
			Options.MergeFrom(other.Options);
		}
		if (other.ClientStreaming)
		{
			ClientStreaming = other.ClientStreaming;
		}
		if (other.ServerStreaming)
		{
			ServerStreaming = other.ServerStreaming;
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
				OutputType = input.ReadString();
				break;
			case 18u:
				InputType = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 48u:
				ServerStreaming = input.ReadBool();
				break;
			case 40u:
				ClientStreaming = input.ReadBool();
				break;
			case 34u:
				if (options_ == null)
				{
					options_ = new MethodOptions();
				}
				input.ReadMessage(options_);
				break;
			}
		}
	}
}
