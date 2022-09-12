using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expect;

internal sealed class Open : IMessage<Open>, IEquatable<Open>, IDeepCloneable<Open>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum CtxOperation
		{
			[OriginalName("EXPECT_CTX_COPY_PREV")]
			ExpectCtxCopyPrev,
			[OriginalName("EXPECT_CTX_EMPTY")]
			ExpectCtxEmpty
		}

		internal sealed class Condition : IMessage<Condition>, IEquatable<Condition>, IDeepCloneable<Condition>, IMessage
		{
			[DebuggerNonUserCode]
			internal static class Types
			{
				public enum Key
				{
					[OriginalName("NONE")]
					None,
					[OriginalName("EXPECT_NO_ERROR")]
					ExpectNoError,
					[OriginalName("EXPECT_FIELD_EXIST")]
					ExpectFieldExist,
					[OriginalName("EXPECT_DOCID_GENERATED")]
					ExpectDocidGenerated
				}

				public enum ConditionOperation
				{
					[OriginalName("EXPECT_OP_SET")]
					ExpectOpSet,
					[OriginalName("EXPECT_OP_UNSET")]
					ExpectOpUnset
				}
			}

			private static readonly MessageParser<Condition> _parser = new MessageParser<Condition>(() => new Condition());

			private UnknownFieldSet _unknownFields;

			public const int ConditionKeyFieldNumber = 1;

			private uint conditionKey_;

			public const int ConditionValueFieldNumber = 2;

			private ByteString conditionValue_ = ByteString.Empty;

			public const int OpFieldNumber = 3;

			private Types.ConditionOperation op_;

			[DebuggerNonUserCode]
			public static MessageParser<Condition> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Open.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public uint ConditionKey
			{
				get
				{
					return conditionKey_;
				}
				set
				{
					conditionKey_ = value;
				}
			}

			[DebuggerNonUserCode]
			public ByteString ConditionValue
			{
				get
				{
					return conditionValue_;
				}
				set
				{
					conditionValue_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			public Types.ConditionOperation Op
			{
				get
				{
					return op_;
				}
				set
				{
					op_ = value;
				}
			}

			[DebuggerNonUserCode]
			public Condition()
			{
			}

			[DebuggerNonUserCode]
			public Condition(Condition other)
				: this()
			{
				conditionKey_ = other.conditionKey_;
				conditionValue_ = other.conditionValue_;
				op_ = other.op_;
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public Condition Clone()
			{
				return new Condition(this);
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as Condition);
			}

			[DebuggerNonUserCode]
			public bool Equals(Condition other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (ConditionKey != other.ConditionKey)
				{
					return false;
				}
				if (ConditionValue != other.ConditionValue)
				{
					return false;
				}
				if (Op != other.Op)
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				if (ConditionKey != 0)
				{
					num ^= ConditionKey.GetHashCode();
				}
				if (ConditionValue.Length != 0)
				{
					num ^= ConditionValue.GetHashCode();
				}
				if (Op != 0)
				{
					num ^= Op.GetHashCode();
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
				if (ConditionKey != 0)
				{
					output.WriteRawTag(8);
					output.WriteUInt32(ConditionKey);
				}
				if (ConditionValue.Length != 0)
				{
					output.WriteRawTag(18);
					output.WriteBytes(ConditionValue);
				}
				if (Op != 0)
				{
					output.WriteRawTag(24);
					output.WriteEnum((int)Op);
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
				if (ConditionKey != 0)
				{
					num += 1 + CodedOutputStream.ComputeUInt32Size(ConditionKey);
				}
				if (ConditionValue.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(ConditionValue);
				}
				if (Op != 0)
				{
					num += 1 + CodedOutputStream.ComputeEnumSize((int)Op);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(Condition other)
			{
				if (other != null)
				{
					if (other.ConditionKey != 0)
					{
						ConditionKey = other.ConditionKey;
					}
					if (other.ConditionValue.Length != 0)
					{
						ConditionValue = other.ConditionValue;
					}
					if (other.Op != 0)
					{
						Op = other.Op;
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
					case 24u:
						op_ = (Types.ConditionOperation)input.ReadEnum();
						break;
					case 18u:
						ConditionValue = input.ReadBytes();
						break;
					case 8u:
						ConditionKey = input.ReadUInt32();
						break;
					}
				}
			}
		}
	}

	private static readonly MessageParser<Open> _parser = new MessageParser<Open>(() => new Open());

	private UnknownFieldSet _unknownFields;

	public const int OpFieldNumber = 1;

	private Types.CtxOperation op_;

	public const int CondFieldNumber = 2;

	private static readonly FieldCodec<Types.Condition> _repeated_cond_codec = FieldCodec.ForMessage(18u, Types.Condition.Parser);

	private readonly RepeatedField<Types.Condition> cond_ = new RepeatedField<Types.Condition>();

	[DebuggerNonUserCode]
	public static MessageParser<Open> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExpectReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.CtxOperation Op
	{
		get
		{
			return op_;
		}
		set
		{
			op_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Types.Condition> Cond => cond_;

	[DebuggerNonUserCode]
	public Open()
	{
	}

	[DebuggerNonUserCode]
	public Open(Open other)
		: this()
	{
		op_ = other.op_;
		cond_ = other.cond_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Open Clone()
	{
		return new Open(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Open);
	}

	[DebuggerNonUserCode]
	public bool Equals(Open other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Op != other.Op)
		{
			return false;
		}
		if (!cond_.Equals(other.cond_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Op != 0)
		{
			num ^= Op.GetHashCode();
		}
		num ^= cond_.GetHashCode();
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
		if (Op != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Op);
		}
		cond_.WriteTo(output, _repeated_cond_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Op != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Op);
		}
		num += cond_.CalculateSize(_repeated_cond_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Open other)
	{
		if (other != null)
		{
			if (other.Op != 0)
			{
				Op = other.Op;
			}
			cond_.Add(other.cond_);
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
			case 18u:
				cond_.AddEntriesFrom(input, _repeated_cond_codec);
				break;
			case 8u:
				op_ = (Types.CtxOperation)input.ReadEnum();
				break;
			}
		}
	}
}
