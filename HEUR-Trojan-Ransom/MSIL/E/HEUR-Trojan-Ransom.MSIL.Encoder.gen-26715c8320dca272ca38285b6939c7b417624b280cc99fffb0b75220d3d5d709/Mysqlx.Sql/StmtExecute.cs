using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Sql;

internal sealed class StmtExecute : IMessage<StmtExecute>, IEquatable<StmtExecute>, IDeepCloneable<StmtExecute>, IMessage
{
	private static readonly MessageParser<StmtExecute> _parser = new MessageParser<StmtExecute>((Func<StmtExecute>)(() => new StmtExecute()));

	public const int NamespaceFieldNumber = 3;

	private string namespace_ = "";

	public const int StmtFieldNumber = 1;

	private ByteString stmt_ = ByteString.get_Empty();

	public const int ArgsFieldNumber = 2;

	private static readonly FieldCodec<Any> _repeated_args_codec = FieldCodec.ForMessage<Any>(18u, Any.Parser);

	private readonly RepeatedField<Any> args_ = new RepeatedField<Any>();

	public const int CompactMetadataFieldNumber = 4;

	private bool compactMetadata_;

	[DebuggerNonUserCode]
	public static MessageParser<StmtExecute> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxSqlReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Namespace
	{
		get
		{
			return namespace_;
		}
		set
		{
			namespace_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString Stmt
	{
		get
		{
			return stmt_;
		}
		set
		{
			stmt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
	public StmtExecute()
	{
	}

	[DebuggerNonUserCode]
	public StmtExecute(StmtExecute other)
		: this()
	{
		namespace_ = other.namespace_;
		stmt_ = other.stmt_;
		args_ = other.args_.Clone();
		compactMetadata_ = other.compactMetadata_;
	}

	[DebuggerNonUserCode]
	public StmtExecute Clone()
	{
		return new StmtExecute(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as StmtExecute);
	}

	[DebuggerNonUserCode]
	public bool Equals(StmtExecute other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Namespace != other.Namespace)
		{
			return false;
		}
		if (Stmt != other.Stmt)
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
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Namespace.Length != 0)
		{
			num ^= Namespace.GetHashCode();
		}
		if (Stmt.get_Length() != 0)
		{
			num ^= ((object)Stmt).GetHashCode();
		}
		num ^= ((object)args_).GetHashCode();
		if (CompactMetadata)
		{
			num ^= CompactMetadata.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString((IMessage)(object)this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (Stmt.get_Length() != 0)
		{
			output.WriteRawTag((byte)10);
			output.WriteBytes(Stmt);
		}
		args_.WriteTo(output, _repeated_args_codec);
		if (Namespace.Length != 0)
		{
			output.WriteRawTag((byte)26);
			output.WriteString(Namespace);
		}
		if (CompactMetadata)
		{
			output.WriteRawTag((byte)32);
			output.WriteBool(CompactMetadata);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Namespace.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Namespace);
		}
		if (Stmt.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Stmt);
		}
		num += args_.CalculateSize(_repeated_args_codec);
		if (CompactMetadata)
		{
			num += 2;
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(StmtExecute other)
	{
		if (other != null)
		{
			if (other.Namespace.Length != 0)
			{
				Namespace = other.Namespace;
			}
			if (other.Stmt.get_Length() != 0)
			{
				Stmt = other.Stmt;
			}
			args_.Add((IEnumerable<Any>)other.args_);
			if (other.CompactMetadata)
			{
				CompactMetadata = other.CompactMetadata;
			}
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
			case 18u:
				args_.AddEntriesFrom(input, _repeated_args_codec);
				break;
			case 10u:
				Stmt = input.ReadBytes();
				break;
			default:
				input.SkipLastField();
				break;
			case 32u:
				CompactMetadata = input.ReadBool();
				break;
			case 26u:
				Namespace = input.ReadString();
				break;
			}
		}
	}
}
