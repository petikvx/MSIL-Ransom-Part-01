using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expr;

internal sealed class Identifier : IMessage<Identifier>, IEquatable<Identifier>, IDeepCloneable<Identifier>, IMessage
{
	private static readonly MessageParser<Identifier> _parser = new MessageParser<Identifier>((Func<Identifier>)(() => new Identifier()));

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int SchemaNameFieldNumber = 2;

	private string schemaName_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Identifier> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.get_MessageTypes()[1];

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
	public string SchemaName
	{
		get
		{
			return schemaName_;
		}
		set
		{
			schemaName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Identifier()
	{
	}

	[DebuggerNonUserCode]
	public Identifier(Identifier other)
		: this()
	{
		name_ = other.name_;
		schemaName_ = other.schemaName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Identifier Clone()
	{
		return new Identifier(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Identifier);
	}

	[DebuggerNonUserCode]
	public bool Equals(Identifier other)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (SchemaName.Length != 0)
		{
			num ^= SchemaName.GetHashCode();
		}
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
		if (SchemaName.Length != 0)
		{
			output.WriteRawTag((byte)18);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
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
	public void MergeFrom(Identifier other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 18u:
				SchemaName = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
