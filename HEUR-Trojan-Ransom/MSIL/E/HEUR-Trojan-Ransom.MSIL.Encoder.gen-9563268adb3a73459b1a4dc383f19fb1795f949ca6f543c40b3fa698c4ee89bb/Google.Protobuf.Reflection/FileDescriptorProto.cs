using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection;

internal sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>, IMessage
{
	private static readonly MessageParser<FileDescriptorProto> _parser = new MessageParser<FileDescriptorProto>(() => new FileDescriptorProto());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int PackageFieldNumber = 2;

	private string package_ = "";

	public const int DependencyFieldNumber = 3;

	private static readonly FieldCodec<string> _repeated_dependency_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> dependency_ = new RepeatedField<string>();

	public const int PublicDependencyFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_publicDependency_codec = FieldCodec.ForInt32(80u);

	private readonly RepeatedField<int> publicDependency_ = new RepeatedField<int>();

	public const int WeakDependencyFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_weakDependency_codec = FieldCodec.ForInt32(88u);

	private readonly RepeatedField<int> weakDependency_ = new RepeatedField<int>();

	public const int MessageTypeFieldNumber = 4;

	private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec = FieldCodec.ForMessage(34u, DescriptorProto.Parser);

	private readonly RepeatedField<DescriptorProto> messageType_ = new RepeatedField<DescriptorProto>();

	public const int EnumTypeFieldNumber = 5;

	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec = FieldCodec.ForMessage(42u, EnumDescriptorProto.Parser);

	private readonly RepeatedField<EnumDescriptorProto> enumType_ = new RepeatedField<EnumDescriptorProto>();

	public const int ServiceFieldNumber = 6;

	private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec = FieldCodec.ForMessage(50u, ServiceDescriptorProto.Parser);

	private readonly RepeatedField<ServiceDescriptorProto> service_ = new RepeatedField<ServiceDescriptorProto>();

	public const int ExtensionFieldNumber = 7;

	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec = FieldCodec.ForMessage(58u, FieldDescriptorProto.Parser);

	private readonly RepeatedField<FieldDescriptorProto> extension_ = new RepeatedField<FieldDescriptorProto>();

	public const int OptionsFieldNumber = 8;

	private FileOptions options_;

	public const int SourceCodeInfoFieldNumber = 9;

	private SourceCodeInfo sourceCodeInfo_;

	public const int SyntaxFieldNumber = 12;

	private string syntax_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<FileDescriptorProto> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[1];

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
	public string Package
	{
		get
		{
			return package_;
		}
		set
		{
			package_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<string> Dependency => dependency_;

	[DebuggerNonUserCode]
	public RepeatedField<int> PublicDependency => publicDependency_;

	[DebuggerNonUserCode]
	public RepeatedField<int> WeakDependency => weakDependency_;

	[DebuggerNonUserCode]
	public RepeatedField<DescriptorProto> MessageType => messageType_;

	[DebuggerNonUserCode]
	public RepeatedField<EnumDescriptorProto> EnumType => enumType_;

	[DebuggerNonUserCode]
	public RepeatedField<ServiceDescriptorProto> Service => service_;

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Extension => extension_;

	[DebuggerNonUserCode]
	public FileOptions Options
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
	public SourceCodeInfo SourceCodeInfo
	{
		get
		{
			return sourceCodeInfo_;
		}
		set
		{
			sourceCodeInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string Syntax
	{
		get
		{
			return syntax_;
		}
		set
		{
			syntax_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public FileDescriptorProto()
	{
	}

	[DebuggerNonUserCode]
	public FileDescriptorProto(FileDescriptorProto other)
		: this()
	{
		name_ = other.name_;
		package_ = other.package_;
		dependency_ = other.dependency_.Clone();
		publicDependency_ = other.publicDependency_.Clone();
		weakDependency_ = other.weakDependency_.Clone();
		messageType_ = other.messageType_.Clone();
		enumType_ = other.enumType_.Clone();
		service_ = other.service_.Clone();
		extension_ = other.extension_.Clone();
		options_ = ((other.options_ != null) ? other.options_.Clone() : null);
		sourceCodeInfo_ = ((other.sourceCodeInfo_ != null) ? other.sourceCodeInfo_.Clone() : null);
		syntax_ = other.syntax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FileDescriptorProto Clone()
	{
		return new FileDescriptorProto(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FileDescriptorProto);
	}

	[DebuggerNonUserCode]
	public bool Equals(FileDescriptorProto other)
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
		if (Package != other.Package)
		{
			return false;
		}
		if (!dependency_.Equals(other.dependency_))
		{
			return false;
		}
		if (!publicDependency_.Equals(other.publicDependency_))
		{
			return false;
		}
		if (!weakDependency_.Equals(other.weakDependency_))
		{
			return false;
		}
		if (!messageType_.Equals(other.messageType_))
		{
			return false;
		}
		if (!enumType_.Equals(other.enumType_))
		{
			return false;
		}
		if (!service_.Equals(other.service_))
		{
			return false;
		}
		if (!extension_.Equals(other.extension_))
		{
			return false;
		}
		if (!object.Equals(Options, other.Options))
		{
			return false;
		}
		if (!object.Equals(SourceCodeInfo, other.SourceCodeInfo))
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
		if (Package.Length != 0)
		{
			num ^= Package.GetHashCode();
		}
		num ^= dependency_.GetHashCode();
		num ^= publicDependency_.GetHashCode();
		num ^= weakDependency_.GetHashCode();
		num ^= messageType_.GetHashCode();
		num ^= enumType_.GetHashCode();
		num ^= service_.GetHashCode();
		num ^= extension_.GetHashCode();
		if (options_ != null)
		{
			num ^= Options.GetHashCode();
		}
		if (sourceCodeInfo_ != null)
		{
			num ^= SourceCodeInfo.GetHashCode();
		}
		if (Syntax.Length != 0)
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
		if (Package.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Package);
		}
		dependency_.WriteTo(output, _repeated_dependency_codec);
		messageType_.WriteTo(output, _repeated_messageType_codec);
		enumType_.WriteTo(output, _repeated_enumType_codec);
		service_.WriteTo(output, _repeated_service_codec);
		extension_.WriteTo(output, _repeated_extension_codec);
		if (options_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Options);
		}
		if (sourceCodeInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(SourceCodeInfo);
		}
		publicDependency_.WriteTo(output, _repeated_publicDependency_codec);
		weakDependency_.WriteTo(output, _repeated_weakDependency_codec);
		if (Syntax.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(Syntax);
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
		if (Package.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Package);
		}
		num += dependency_.CalculateSize(_repeated_dependency_codec);
		num += publicDependency_.CalculateSize(_repeated_publicDependency_codec);
		num += weakDependency_.CalculateSize(_repeated_weakDependency_codec);
		num += messageType_.CalculateSize(_repeated_messageType_codec);
		num += enumType_.CalculateSize(_repeated_enumType_codec);
		num += service_.CalculateSize(_repeated_service_codec);
		num += extension_.CalculateSize(_repeated_extension_codec);
		if (options_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Options);
		}
		if (sourceCodeInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SourceCodeInfo);
		}
		if (Syntax.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Syntax);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FileDescriptorProto other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.Package.Length != 0)
		{
			Package = other.Package;
		}
		dependency_.Add(other.dependency_);
		publicDependency_.Add(other.publicDependency_);
		weakDependency_.Add(other.weakDependency_);
		messageType_.Add(other.messageType_);
		enumType_.Add(other.enumType_);
		service_.Add(other.service_);
		extension_.Add(other.extension_);
		if (other.options_ != null)
		{
			if (options_ == null)
			{
				options_ = new FileOptions();
			}
			Options.MergeFrom(other.Options);
		}
		if (other.sourceCodeInfo_ != null)
		{
			if (sourceCodeInfo_ == null)
			{
				sourceCodeInfo_ = new SourceCodeInfo();
			}
			SourceCodeInfo.MergeFrom(other.SourceCodeInfo);
		}
		if (other.Syntax.Length != 0)
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
				dependency_.AddEntriesFrom(input, _repeated_dependency_codec);
				break;
			case 18u:
				Package = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			case 42u:
				enumType_.AddEntriesFrom(input, _repeated_enumType_codec);
				break;
			case 34u:
				messageType_.AddEntriesFrom(input, _repeated_messageType_codec);
				break;
			case 58u:
				extension_.AddEntriesFrom(input, _repeated_extension_codec);
				break;
			case 50u:
				service_.AddEntriesFrom(input, _repeated_service_codec);
				break;
			case 74u:
				if (sourceCodeInfo_ == null)
				{
					sourceCodeInfo_ = new SourceCodeInfo();
				}
				input.ReadMessage(sourceCodeInfo_);
				break;
			case 66u:
				if (options_ == null)
				{
					options_ = new FileOptions();
				}
				input.ReadMessage(options_);
				break;
			case 80u:
			case 82u:
				publicDependency_.AddEntriesFrom(input, _repeated_publicDependency_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 98u:
				Syntax = input.ReadString();
				break;
			case 88u:
			case 90u:
				weakDependency_.AddEntriesFrom(input, _repeated_weakDependency_codec);
				break;
			}
		}
	}
}
