using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal sealed class Collection : IMessage<Collection>, IEquatable<Collection>, IDeepCloneable<Collection>, IMessage
{
	private static readonly MessageParser<Collection> _parser = new MessageParser<Collection>((Func<Collection>)(() => new Collection()));

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int SchemaFieldNumber = 2;

	private string schema_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Collection> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[2];

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
	public string Schema
	{
		get
		{
			return schema_;
		}
		set
		{
			schema_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Collection()
	{
	}

	[DebuggerNonUserCode]
	public Collection(Collection other)
		: this()
	{
		name_ = other.name_;
		schema_ = other.schema_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Collection Clone()
	{
		return new Collection(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Collection);
	}

	[DebuggerNonUserCode]
	public bool Equals(Collection other)
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
		if (Schema != other.Schema)
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
		if (Schema.Length != 0)
		{
			num ^= Schema.GetHashCode();
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
		if (Schema.Length != 0)
		{
			output.WriteRawTag((byte)18);
			output.WriteString(Schema);
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
		if (Schema.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Schema);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Collection other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Schema.Length != 0)
			{
				Schema = other.Schema;
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
				Schema = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
