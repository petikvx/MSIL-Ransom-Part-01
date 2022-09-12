using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection;

internal sealed class FieldOptions : IMessage<FieldOptions>, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>, IMessage
{
	[DebuggerNonUserCode]
	public static class Types
	{
		internal enum CType
		{
			[OriginalName("STRING")]
			String,
			[OriginalName("CORD")]
			Cord,
			[OriginalName("STRING_PIECE")]
			StringPiece
		}

		internal enum JSType
		{
			[OriginalName("JS_NORMAL")]
			JsNormal,
			[OriginalName("JS_STRING")]
			JsString,
			[OriginalName("JS_NUMBER")]
			JsNumber
		}
	}

	private static readonly MessageParser<FieldOptions> _parser = new MessageParser<FieldOptions>(() => new FieldOptions());

	private UnknownFieldSet _unknownFields;

	public const int CtypeFieldNumber = 1;

	private Types.CType ctype_;

	public const int PackedFieldNumber = 2;

	private bool packed_;

	public const int JstypeFieldNumber = 6;

	private Types.JSType jstype_;

	public const int LazyFieldNumber = 5;

	private bool lazy_;

	public const int DeprecatedFieldNumber = 3;

	private bool deprecated_;

	public const int WeakFieldNumber = 10;

	private bool weak_;

	public const int UninterpretedOptionFieldNumber = 999;

	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);

	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

	[DebuggerNonUserCode]
	public static MessageParser<FieldOptions> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[12];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	internal CustomOptions CustomOptions { get; private set; } = CustomOptions.Empty;


	[DebuggerNonUserCode]
	public Types.CType Ctype
	{
		get
		{
			return ctype_;
		}
		set
		{
			ctype_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool Packed
	{
		get
		{
			return packed_;
		}
		set
		{
			packed_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.JSType Jstype
	{
		get
		{
			return jstype_;
		}
		set
		{
			jstype_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool Lazy
	{
		get
		{
			return lazy_;
		}
		set
		{
			lazy_ = value;
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
	public bool Weak
	{
		get
		{
			return weak_;
		}
		set
		{
			weak_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

	[DebuggerNonUserCode]
	public FieldOptions()
	{
		OnConstruction();
	}

	private void OnConstruction()
	{
		Packed = true;
	}

	[DebuggerNonUserCode]
	public FieldOptions(FieldOptions other)
		: this()
	{
		ctype_ = other.ctype_;
		packed_ = other.packed_;
		jstype_ = other.jstype_;
		lazy_ = other.lazy_;
		deprecated_ = other.deprecated_;
		weak_ = other.weak_;
		uninterpretedOption_ = other.uninterpretedOption_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FieldOptions Clone()
	{
		return new FieldOptions(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldOptions);
	}

	[DebuggerNonUserCode]
	public bool Equals(FieldOptions other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Ctype != other.Ctype)
		{
			return false;
		}
		if (Packed != other.Packed)
		{
			return false;
		}
		if (Jstype != other.Jstype)
		{
			return false;
		}
		if (Lazy != other.Lazy)
		{
			return false;
		}
		if (Deprecated != other.Deprecated)
		{
			return false;
		}
		if (Weak != other.Weak)
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
		if (Ctype != 0)
		{
			num ^= Ctype.GetHashCode();
		}
		if (Packed)
		{
			num ^= Packed.GetHashCode();
		}
		if (Jstype != 0)
		{
			num ^= Jstype.GetHashCode();
		}
		if (Lazy)
		{
			num ^= Lazy.GetHashCode();
		}
		if (Deprecated)
		{
			num ^= Deprecated.GetHashCode();
		}
		if (Weak)
		{
			num ^= Weak.GetHashCode();
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
		if (Ctype != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Ctype);
		}
		if (Packed)
		{
			output.WriteRawTag(16);
			output.WriteBool(Packed);
		}
		if (Deprecated)
		{
			output.WriteRawTag(24);
			output.WriteBool(Deprecated);
		}
		if (Lazy)
		{
			output.WriteRawTag(40);
			output.WriteBool(Lazy);
		}
		if (Jstype != 0)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Jstype);
		}
		if (Weak)
		{
			output.WriteRawTag(80);
			output.WriteBool(Weak);
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
		if (Ctype != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Ctype);
		}
		if (Packed)
		{
			num += 2;
		}
		if (Jstype != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Jstype);
		}
		if (Lazy)
		{
			num += 2;
		}
		if (Deprecated)
		{
			num += 2;
		}
		if (Weak)
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
	public void MergeFrom(FieldOptions other)
	{
		if (other != null)
		{
			if (other.Ctype != 0)
			{
				Ctype = other.Ctype;
			}
			if (other.Packed)
			{
				Packed = other.Packed;
			}
			if (other.Jstype != 0)
			{
				Jstype = other.Jstype;
			}
			if (other.Lazy)
			{
				Lazy = other.Lazy;
			}
			if (other.Deprecated)
			{
				Deprecated = other.Deprecated;
			}
			if (other.Weak)
			{
				Weak = other.Weak;
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
			case 24u:
				Deprecated = input.ReadBool();
				break;
			case 16u:
				Packed = input.ReadBool();
				break;
			case 8u:
				ctype_ = (Types.CType)input.ReadEnum();
				break;
			case 48u:
				jstype_ = (Types.JSType)input.ReadEnum();
				break;
			case 40u:
				Lazy = input.ReadBool();
				break;
			default:
				CustomOptions = CustomOptions.ReadOrSkipUnknownField(input);
				break;
			case 7994u:
				uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
				break;
			case 80u:
				Weak = input.ReadBool();
				break;
			}
		}
	}
}
