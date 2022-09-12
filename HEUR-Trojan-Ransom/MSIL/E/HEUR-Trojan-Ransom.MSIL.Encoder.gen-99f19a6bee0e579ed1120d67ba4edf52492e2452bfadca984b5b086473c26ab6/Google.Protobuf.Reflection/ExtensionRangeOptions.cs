using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection;

internal sealed class ExtensionRangeOptions : IMessage<ExtensionRangeOptions>, IEquatable<ExtensionRangeOptions>, IDeepCloneable<ExtensionRangeOptions>, IMessage
{
	private static readonly MessageParser<ExtensionRangeOptions> _parser = new MessageParser<ExtensionRangeOptions>(() => new ExtensionRangeOptions());

	private UnknownFieldSet _unknownFields;

	public const int UninterpretedOptionFieldNumber = 999;

	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

	[DebuggerNonUserCode]
	public static MessageParser<ExtensionRangeOptions> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

	[DebuggerNonUserCode]
	public ExtensionRangeOptions()
	{
	}

	[DebuggerNonUserCode]
	public ExtensionRangeOptions(ExtensionRangeOptions other)
		: this()
	{
		uninterpretedOption_ = other.uninterpretedOption_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public ExtensionRangeOptions Clone()
	{
		return new ExtensionRangeOptions(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ExtensionRangeOptions);
	}

	[DebuggerNonUserCode]
	public bool Equals(ExtensionRangeOptions other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		num = 1 ^ uninterpretedOption_.GetHashCode();
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
		num = 0 + uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ExtensionRangeOptions other)
	{
		if (other != null)
		{
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
			if (num != 7994)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
			}
		}
	}
}
