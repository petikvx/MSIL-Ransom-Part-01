using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection;

internal sealed class EnumOptions : IMessage<EnumOptions>, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>, IMessage
{
	private static readonly MessageParser<EnumOptions> _parser = new MessageParser<EnumOptions>(() => new EnumOptions());

	private UnknownFieldSet _unknownFields;

	public const int AllowAliasFieldNumber = 2;

	private bool allowAlias_;

	public const int DeprecatedFieldNumber = 3;

	private bool deprecated_;

	public const int UninterpretedOptionFieldNumber = 999;

	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

	[DebuggerNonUserCode]
	public static MessageParser<EnumOptions> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[14];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	internal CustomOptions CustomOptions { get; private set; } = CustomOptions.Empty;


	[DebuggerNonUserCode]
	public bool AllowAlias
	{
		get
		{
			return allowAlias_;
		}
		set
		{
			allowAlias_ = value;
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
	public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

	[DebuggerNonUserCode]
	public EnumOptions()
	{
	}

	[DebuggerNonUserCode]
	public EnumOptions(EnumOptions other)
		: this()
	{
		allowAlias_ = other.allowAlias_;
		deprecated_ = other.deprecated_;
		uninterpretedOption_ = other.uninterpretedOption_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public EnumOptions Clone()
	{
		return new EnumOptions(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EnumOptions);
	}

	[DebuggerNonUserCode]
	public bool Equals(EnumOptions other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AllowAlias != other.AllowAlias)
		{
			return false;
		}
		if (Deprecated != other.Deprecated)
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
		if (AllowAlias)
		{
			num ^= AllowAlias.GetHashCode();
		}
		if (Deprecated)
		{
			num ^= Deprecated.GetHashCode();
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
		if (AllowAlias)
		{
			output.WriteRawTag(16);
			output.WriteBool(AllowAlias);
		}
		if (Deprecated)
		{
			output.WriteRawTag(24);
			output.WriteBool(Deprecated);
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
		if (AllowAlias)
		{
			num += 2;
		}
		if (Deprecated)
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
	public void MergeFrom(EnumOptions other)
	{
		if (other != null)
		{
			if (other.AllowAlias)
			{
				AllowAlias = other.AllowAlias;
			}
			if (other.Deprecated)
			{
				Deprecated = other.Deprecated;
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
			default:
				CustomOptions = CustomOptions.ReadOrSkipUnknownField(input);
				break;
			case 7994u:
				uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
				break;
			case 24u:
				Deprecated = input.ReadBool();
				break;
			case 16u:
				AllowAlias = input.ReadBool();
				break;
			}
		}
	}
}
