using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expr;

internal sealed class ColumnIdentifier : IMessage<ColumnIdentifier>, IEquatable<ColumnIdentifier>, IDeepCloneable<ColumnIdentifier>, IMessage
{
	private static readonly MessageParser<ColumnIdentifier> _parser = new MessageParser<ColumnIdentifier>(() => new ColumnIdentifier());

	private UnknownFieldSet _unknownFields;

	public const int DocumentPathFieldNumber = 1;

	private static readonly FieldCodec<DocumentPathItem> _repeated_documentPath_codec = FieldCodec.ForMessage(10u, DocumentPathItem.Parser);

	private readonly RepeatedField<DocumentPathItem> documentPath_ = new RepeatedField<DocumentPathItem>();

	public const int NameFieldNumber = 2;

	private string name_ = "";

	public const int TableNameFieldNumber = 3;

	private string tableName_ = "";

	public const int SchemaNameFieldNumber = 4;

	private string schemaName_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<ColumnIdentifier> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<DocumentPathItem> DocumentPath => documentPath_;

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
	public string TableName
	{
		get
		{
			return tableName_;
		}
		set
		{
			tableName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string SchemaName
	{
		get
		{
			return schemaName_;
		}
		set
		{
			schemaName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ColumnIdentifier()
	{
	}

	[DebuggerNonUserCode]
	public ColumnIdentifier(ColumnIdentifier other)
		: this()
	{
		documentPath_ = other.documentPath_.Clone();
		name_ = other.name_;
		tableName_ = other.tableName_;
		schemaName_ = other.schemaName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public ColumnIdentifier Clone()
	{
		return new ColumnIdentifier(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ColumnIdentifier);
	}

	[DebuggerNonUserCode]
	public bool Equals(ColumnIdentifier other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!documentPath_.Equals(other.documentPath_))
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (TableName != other.TableName)
		{
			return false;
		}
		if (SchemaName != other.SchemaName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ documentPath_.GetHashCode();
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (TableName.Length != 0)
		{
			num ^= TableName.GetHashCode();
		}
		if (SchemaName.Length != 0)
		{
			num ^= SchemaName.GetHashCode();
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
		documentPath_.WriteTo(output, _repeated_documentPath_codec);
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (TableName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TableName);
		}
		if (SchemaName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SchemaName);
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
		num = 0 + documentPath_.CalculateSize(_repeated_documentPath_codec);
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (TableName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TableName);
		}
		if (SchemaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SchemaName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ColumnIdentifier other)
	{
		if (other != null)
		{
			documentPath_.Add(other.documentPath_);
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.TableName.Length != 0)
			{
				TableName = other.TableName;
			}
			if (other.SchemaName.Length != 0)
			{
				SchemaName = other.SchemaName;
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
			case 18u:
				Name = input.ReadString();
				break;
			case 10u:
				documentPath_.AddEntriesFrom(input, _repeated_documentPath_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 34u:
				SchemaName = input.ReadString();
				break;
			case 26u:
				TableName = input.ReadString();
				break;
			}
		}
	}
}
