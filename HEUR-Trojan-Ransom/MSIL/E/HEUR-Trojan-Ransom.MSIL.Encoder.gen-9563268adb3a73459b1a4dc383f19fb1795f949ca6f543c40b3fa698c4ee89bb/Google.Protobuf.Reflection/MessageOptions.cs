using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection;

internal sealed class MessageOptions : IMessage<MessageOptions>, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>, IMessage
{
	private static readonly MessageParser<MessageOptions> _parser = new MessageParser<MessageOptions>(() => new MessageOptions());

	private UnknownFieldSet _unknownFields;

	public const int MessageSetWireFormatFieldNumber = 1;

	private bool messageSetWireFormat_;

	public const int NoStandardDescriptorAccessorFieldNumber = 2;

	private bool noStandardDescriptorAccessor_;

	public const int DeprecatedFieldNumber = 3;

	private bool deprecated_;

	public const int MapEntryFieldNumber = 7;

	private bool mapEntry_;

	public const int UninterpretedOptionFieldNumber = 999;

	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

	[DebuggerNonUserCode]
	public static MessageParser<MessageOptions> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[11];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	internal CustomOptions CustomOptions { get; private set; } = CustomOptions.Empty;


	[DebuggerNonUserCode]
	public bool MessageSetWireFormat
	{
		get
		{
			return messageSetWireFormat_;
		}
		set
		{
			messageSetWireFormat_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool NoStandardDescriptorAccessor
	{
		get
		{
			return noStandardDescriptorAccessor_;
		}
		set
		{
			noStandardDescriptorAccessor_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool Deprecated
	{
		get
		{
			return deprecated_;
		}
		set
		{
			deprecated_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool MapEntry
	{
		get
		{
			return mapEntry_;
		}
		set
		{
			mapEntry_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

	[DebuggerNonUserCode]
	public MessageOptions()
	{
	}

	[DebuggerNonUserCode]
	public MessageOptions(MessageOptions other)
		: this()
	{
		messageSetWireFormat_ = other.messageSetWireFormat_;
		noStandardDescriptorAccessor_ = other.noStandardDescriptorAccessor_;
		deprecated_ = other.deprecated_;
		mapEntry_ = other.mapEntry_;
		uninterpretedOption_ = other.uninterpretedOption_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public MessageOptions Clone()
	{
		return new MessageOptions(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MessageOptions);
	}

	[DebuggerNonUserCode]
	public bool Equals(MessageOptions other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MessageSetWireFormat != other.MessageSetWireFormat)
		{
			return false;
		}
		if (NoStandardDescriptorAccessor != other.NoStandardDescriptorAccessor)
		{
			return false;
		}
		if (Deprecated != other.Deprecated)
		{
			return false;
		}
		if (MapEntry != other.MapEntry)
		{
			return false;
		}
		if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (MessageSetWireFormat)
		{
			num ^= MessageSetWireFormat.GetHashCode();
		}
		if (NoStandardDescriptorAccessor)
		{
			num ^= NoStandardDescriptorAccessor.GetHashCode();
		}
		if (Deprecated)
		{
			num ^= Deprecated.GetHashCode();
		}
		if (MapEntry)
		{
			num ^= MapEntry.GetHashCode();
		}
		num ^= uninterpretedOption_.GetHashCode();
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
		if (MessageSetWireFormat)
		{
			output.WriteRawTag(8);
			output.WriteBool(MessageSetWireFormat);
		}
		if (NoStandardDescriptorAccessor)
		{
			output.WriteRawTag(16);
			output.WriteBool(NoStandardDescriptorAccessor);
		}
		if (Deprecated)
		{
			output.WriteRawTag(24);
			output.WriteBool(Deprecated);
		}
		if (MapEntry)
		{
			output.WriteRawTag(56);
			output.WriteBool(MapEntry);
		}
		uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (MessageSetWireFormat)
		{
			num += 2;
		}
		if (NoStandardDescriptorAccessor)
		{
			num += 2;
		}
		if (Deprecated)
		{
			num += 2;
		}
		if (MapEntry)
		{
			num += 2;
		}
		num += uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(MessageOptions other)
	{
		if (other != null)
		{
			if (other.MessageSetWireFormat)
			{
				MessageSetWireFormat = other.MessageSetWireFormat;
			}
			if (other.NoStandardDescriptorAccessor)
			{
				NoStandardDescriptorAccessor = other.NoStandardDescriptorAccessor;
			}
			if (other.Deprecated)
			{
				Deprecated = other.Deprecated;
			}
			if (other.MapEntry)
			{
				MapEntry = other.MapEntry;
			}
			uninterpretedOption_.Add(other.uninterpretedOption_);
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
				NoStandardDescriptorAccessor = input.ReadBool();
				break;
			case 8u:
				MessageSetWireFormat = input.ReadBool();
				break;
			default:
				CustomOptions = CustomOptions.ReadOrSkipUnknownField(input);
				break;
			case 7994u:
				uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
				break;
			case 56u:
				MapEntry = input.ReadBool();
				break;
			case 24u:
				Deprecated = input.ReadBool();
				break;
			}
		}
	}
}
