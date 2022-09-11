using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Collections;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal sealed class UninterpretedOption : IMessage, IMessage<UninterpretedOption>, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
{
	[DebuggerNonUserCode]
	public static class Types
	{
		internal sealed class NamePart : IMessage, IMessage<NamePart>, IEquatable<NamePart>, IDeepCloneable<NamePart>
		{
			private static readonly MessageParser<NamePart> _parser;

			private UnknownFieldSet _unknownFields;

			public const int NamePart_FieldNumber = 1;

			private string namePart_ = getString_0(107400384);

			public const int IsExtensionFieldNumber = 2;

			private bool isExtension_;

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<NamePart> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => UninterpretedOption.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public string NamePart_
			{
				get
				{
					return namePart_;
				}
				set
				{
					namePart_ = ProtoPreconditions.CheckNotNull(value, getString_0(107395337));
				}
			}

			[DebuggerNonUserCode]
			public bool IsExtension
			{
				get
				{
					return isExtension_;
				}
				set
				{
					isExtension_ = value;
				}
			}

			[DebuggerNonUserCode]
			public NamePart()
			{
			}

			[DebuggerNonUserCode]
			public NamePart(NamePart other)
				: this()
			{
				namePart_ = other.namePart_;
				isExtension_ = other.isExtension_;
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public NamePart Clone()
			{
				return new NamePart(this);
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as NamePart);
			}

			[DebuggerNonUserCode]
			public bool Equals(NamePart other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (NamePart_ != other.NamePart_)
				{
					return false;
				}
				if (IsExtension != other.IsExtension)
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				if (NamePart_.Length != 0)
				{
					num ^= NamePart_.GetHashCode();
				}
				if (IsExtension)
				{
					num ^= IsExtension.GetHashCode();
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
				if (NamePart_.Length != 0)
				{
					output.WriteRawTag(10);
					output.WriteString(NamePart_);
				}
				if (IsExtension)
				{
					output.WriteRawTag(16);
					output.WriteBool(IsExtension);
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
				if (NamePart_.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(NamePart_);
				}
				if (IsExtension)
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
			public void MergeFrom(NamePart other)
			{
				if (other != null)
				{
					if (other.NamePart_.Length != 0)
					{
						NamePart_ = other.NamePart_;
					}
					if (other.IsExtension)
					{
						IsExtension = other.IsExtension;
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
					default:
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
						break;
					case 16u:
						IsExtension = input.ReadBool();
						break;
					case 10u:
						NamePart_ = input.ReadString();
						break;
					}
				}
			}

			static NamePart()
			{
				Strings.CreateGetStringDelegate(typeof(NamePart));
				bool bool_ = false;
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400562), getString_0(107400557)).Replace(getString_0(107400520), getString_0(107400515)));
				if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400510)))
				{
					throw new SecurityException(getString_0(107400485));
				}
				_parser = new MessageParser<NamePart>(() => new NamePart());
			}

			[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
		}
	}

	private static readonly MessageParser<UninterpretedOption> _parser;

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 2;

	private static readonly FieldCodec<Types.NamePart> _repeated_name_codec;

	private readonly RepeatedField<Types.NamePart> name_ = new RepeatedField<Types.NamePart>();

	public const int IdentifierValueFieldNumber = 3;

	private string identifierValue_ = getString_0(107400377);

	public const int PositiveIntValueFieldNumber = 4;

	private ulong positiveIntValue_;

	public const int NegativeIntValueFieldNumber = 5;

	private long negativeIntValue_;

	public const int DoubleValueFieldNumber = 6;

	private double doubleValue_;

	public const int StringValueFieldNumber = 7;

	private ByteString stringValue_ = ByteString.Empty;

	public const int AggregateValueFieldNumber = 8;

	private string aggregateValue_ = getString_0(107400377);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<UninterpretedOption> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[18];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Types.NamePart> Name => name_;

	[DebuggerNonUserCode]
	public string IdentifierValue
	{
		get
		{
			return identifierValue_;
		}
		set
		{
			identifierValue_ = ProtoPreconditions.CheckNotNull(value, getString_0(107395330));
		}
	}

	[DebuggerNonUserCode]
	public ulong PositiveIntValue
	{
		get
		{
			return positiveIntValue_;
		}
		set
		{
			positiveIntValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	public long NegativeIntValue
	{
		get
		{
			return negativeIntValue_;
		}
		set
		{
			negativeIntValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	public double DoubleValue
	{
		get
		{
			return doubleValue_;
		}
		set
		{
			doubleValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ByteString StringValue
	{
		get
		{
			return stringValue_;
		}
		set
		{
			stringValue_ = ProtoPreconditions.CheckNotNull(value, getString_0(107395330));
		}
	}

	[DebuggerNonUserCode]
	public string AggregateValue
	{
		get
		{
			return aggregateValue_;
		}
		set
		{
			aggregateValue_ = ProtoPreconditions.CheckNotNull(value, getString_0(107395330));
		}
	}

	[DebuggerNonUserCode]
	public UninterpretedOption()
	{
	}

	[DebuggerNonUserCode]
	public UninterpretedOption(UninterpretedOption other)
		: this()
	{
		name_ = other.name_.Clone();
		identifierValue_ = other.identifierValue_;
		positiveIntValue_ = other.positiveIntValue_;
		negativeIntValue_ = other.negativeIntValue_;
		doubleValue_ = other.doubleValue_;
		stringValue_ = other.stringValue_;
		aggregateValue_ = other.aggregateValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public UninterpretedOption Clone()
	{
		return new UninterpretedOption(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as UninterpretedOption);
	}

	[DebuggerNonUserCode]
	public bool Equals(UninterpretedOption other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!name_.Equals(other.name_))
		{
			return false;
		}
		if (IdentifierValue != other.IdentifierValue)
		{
			return false;
		}
		if (PositiveIntValue != other.PositiveIntValue)
		{
			return false;
		}
		if (NegativeIntValue != other.NegativeIntValue)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleValue, other.DoubleValue))
		{
			return false;
		}
		if (StringValue != other.StringValue)
		{
			return false;
		}
		if (AggregateValue != other.AggregateValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ name_.GetHashCode();
		if (IdentifierValue.Length != 0)
		{
			num ^= IdentifierValue.GetHashCode();
		}
		if (PositiveIntValue != 0L)
		{
			num ^= PositiveIntValue.GetHashCode();
		}
		if (NegativeIntValue != 0L)
		{
			num ^= NegativeIntValue.GetHashCode();
		}
		if (DoubleValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleValue);
		}
		if (StringValue.Length != 0)
		{
			num ^= StringValue.GetHashCode();
		}
		if (AggregateValue.Length != 0)
		{
			num ^= AggregateValue.GetHashCode();
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
		name_.WriteTo(output, _repeated_name_codec);
		if (IdentifierValue.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(IdentifierValue);
		}
		if (PositiveIntValue != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(PositiveIntValue);
		}
		if (NegativeIntValue != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(NegativeIntValue);
		}
		if (DoubleValue != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(DoubleValue);
		}
		if (StringValue.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteBytes(StringValue);
		}
		if (AggregateValue.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(AggregateValue);
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
		num = 0 + name_.CalculateSize(_repeated_name_codec);
		if (IdentifierValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IdentifierValue);
		}
		if (PositiveIntValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PositiveIntValue);
		}
		if (NegativeIntValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NegativeIntValue);
		}
		if (DoubleValue != 0.0)
		{
			num += 9;
		}
		if (StringValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(StringValue);
		}
		if (AggregateValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AggregateValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(UninterpretedOption other)
	{
		if (other != null)
		{
			name_.Add(other.name_);
			if (other.IdentifierValue.Length != 0)
			{
				IdentifierValue = other.IdentifierValue;
			}
			if (other.PositiveIntValue != 0L)
			{
				PositiveIntValue = other.PositiveIntValue;
			}
			if (other.NegativeIntValue != 0L)
			{
				NegativeIntValue = other.NegativeIntValue;
			}
			if (other.DoubleValue != 0.0)
			{
				DoubleValue = other.DoubleValue;
			}
			if (other.StringValue.Length != 0)
			{
				StringValue = other.StringValue;
			}
			if (other.AggregateValue.Length != 0)
			{
				AggregateValue = other.AggregateValue;
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
			case 32u:
				PositiveIntValue = input.ReadUInt64();
				break;
			case 26u:
				IdentifierValue = input.ReadString();
				break;
			case 18u:
				name_.AddEntriesFrom(input, _repeated_name_codec);
				break;
			case 49u:
				DoubleValue = input.ReadDouble();
				break;
			case 40u:
				NegativeIntValue = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 66u:
				AggregateValue = input.ReadString();
				break;
			case 58u:
				StringValue = input.ReadBytes();
				break;
			}
		}
	}

	static UninterpretedOption()
	{
		Strings.CreateGetStringDelegate(typeof(UninterpretedOption));
		_parser = new MessageParser<UninterpretedOption>(() => new UninterpretedOption());
		_repeated_name_codec = FieldCodec.ForMessage(18u, Types.NamePart.Parser);
	}
}
