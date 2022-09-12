using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Prepare;

internal sealed class Execute : IMessage<Execute>, IEquatable<Execute>, IDeepCloneable<Execute>, IMessage
{
	private static readonly MessageParser<Execute> _parser = new MessageParser<Execute>(() => new Execute());

	private UnknownFieldSet _unknownFields;

	public const int StmtIdFieldNumber = 1;

	private uint stmtId_;

	public const int ArgsFieldNumber = 2;

	private static readonly FieldCodec<Any> _repeated_args_codec = FieldCodec.ForMessage(18u, Any.Parser);

	private readonly RepeatedField<Any> args_ = new RepeatedField<Any>();

	public const int CompactMetadataFieldNumber = 3;

	private bool compactMetadata_;

	[DebuggerNonUserCode]
	public static MessageParser<Execute> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxPrepareReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint StmtId
	{
		get
		{
			return stmtId_;
		}
		set
		{
			stmtId_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Any> Args => args_;

	[DebuggerNonUserCode]
	public bool CompactMetadata
	{
		get
		{
			return compactMetadata_;
		}
		set
		{
			compactMetadata_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Execute()
	{
	}

	[DebuggerNonUserCode]
	public Execute(Execute other)
		: this()
	{
		stmtId_ = other.stmtId_;
		args_ = other.args_.Clone();
		compactMetadata_ = other.compactMetadata_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Execute Clone()
	{
		return new Execute(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Execute);
	}

	[DebuggerNonUserCode]
	public bool Equals(Execute other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StmtId != other.StmtId)
		{
			return false;
		}
		if (!args_.Equals(other.args_))
		{
			return false;
		}
		if (CompactMetadata != other.CompactMetadata)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (StmtId != 0)
		{
			num ^= StmtId.GetHashCode();
		}
		num ^= args_.GetHashCode();
		if (CompactMetadata)
		{
			num ^= CompactMetadata.GetHashCode();
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
		if (StmtId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(StmtId);
		}
		args_.WriteTo(output, _repeated_args_codec);
		if (CompactMetadata)
		{
			output.WriteRawTag(24);
			output.WriteBool(CompactMetadata);
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
		if (StmtId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StmtId);
		}
		num += args_.CalculateSize(_repeated_args_codec);
		if (CompactMetadata)
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
	public void MergeFrom(Execute other)
	{
		if (other != null)
		{
			if (other.StmtId != 0)
			{
				StmtId = other.StmtId;
			}
			args_.Add(other.args_);
			if (other.CompactMetadata)
			{
				CompactMetadata = other.CompactMetadata;
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
				CompactMetadata = input.ReadBool();
				break;
			case 18u:
				args_.AddEntriesFrom(input, _repeated_args_codec);
				break;
			case 8u:
				StmtId = input.ReadUInt32();
				break;
			}
		}
	}
}
