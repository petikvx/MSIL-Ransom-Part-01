using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Column : IMessage<Column>, IEquatable<Column>, IDeepCloneable<Column>, IMessage
{
	private static readonly MessageParser<Column> _parser = new MessageParser<Column>((Func<Column>)(() => new Column()));

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int AliasFieldNumber = 2;

	private string alias_ = "";

	public const int DocumentPathFieldNumber = 3;

	private static readonly FieldCodec<DocumentPathItem> _repeated_documentPath_codec = FieldCodec.ForMessage<DocumentPathItem>(26u, DocumentPathItem.Parser);

	private readonly RepeatedField<DocumentPathItem> documentPath_ = new RepeatedField<DocumentPathItem>();

	[DebuggerNonUserCode]
	public static MessageParser<Column> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string Alias
	{
		get
		{
			return alias_;
		}
		set
		{
			alias_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<DocumentPathItem> DocumentPath => documentPath_;

	[DebuggerNonUserCode]
	public Column()
	{
	}

	[DebuggerNonUserCode]
	public Column(Column other)
		: this()
	{
		name_ = other.name_;
		alias_ = other.alias_;
		documentPath_ = other.documentPath_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Column Clone()
	{
		return new Column(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Column);
	}

	[DebuggerNonUserCode]
	public bool Equals(Column other)
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
		if (Alias != other.Alias)
		{
			return false;
		}
		if (!documentPath_.Equals(other.documentPath_))
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
		if (Alias.Length != 0)
		{
			num ^= Alias.GetHashCode();
		}
		num ^= ((object)documentPath_).GetHashCode();
		if (_unknownFields != null)
		{
			num ^= ((object)_unknownFields).GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag((byte)10);
			output.WriteString(Name);
		}
		if (Alias.Length != 0)
		{
			output.WriteRawTag((byte)18);
			output.WriteString(Alias);
		}
		documentPath_.WriteTo(output, _repeated_documentPath_codec);
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
		if (Alias.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Alias);
		}
		num += documentPath_.CalculateSize(_repeated_documentPath_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Column other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Alias.Length != 0)
			{
				Alias = other.Alias;
			}
			documentPath_.Add((IEnumerable<DocumentPathItem>)other.documentPath_);
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
			case 26u:
				documentPath_.AddEntriesFrom(input, _repeated_documentPath_codec);
				break;
			case 18u:
				Alias = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
