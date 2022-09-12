using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal sealed class DropView : IMessage<DropView>, IEquatable<DropView>, IDeepCloneable<DropView>, IMessage
{
	private static readonly MessageParser<DropView> _parser = new MessageParser<DropView>(() => new DropView());

	private UnknownFieldSet _unknownFields;

	public const int CollectionFieldNumber = 1;

	private Collection collection_;

	public const int IfExistsFieldNumber = 2;

	private bool ifExists_;

	[DebuggerNonUserCode]
	public static MessageParser<DropView> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[13];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Collection Collection
	{
		get
		{
			return collection_;
		}
		set
		{
			collection_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool IfExists
	{
		get
		{
			return ifExists_;
		}
		set
		{
			ifExists_ = value;
		}
	}

	[DebuggerNonUserCode]
	public DropView()
	{
	}

	[DebuggerNonUserCode]
	public DropView(DropView other)
		: this()
	{
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		ifExists_ = other.ifExists_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public DropView Clone()
	{
		return new DropView(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as DropView);
	}

	[DebuggerNonUserCode]
	public bool Equals(DropView other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Collection, other.Collection))
		{
			return false;
		}
		if (IfExists != other.IfExists)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (collection_ != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (IfExists)
		{
			num ^= IfExists.GetHashCode();
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
		if (collection_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Collection);
		}
		if (IfExists)
		{
			output.WriteRawTag(16);
			output.WriteBool(IfExists);
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
		if (collection_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (IfExists)
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
	public void MergeFrom(DropView other)
	{
		if (other == null)
		{
			return;
		}
		if (other.collection_ != null)
		{
			if (collection_ == null)
			{
				collection_ = new Collection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.IfExists)
		{
			IfExists = other.IfExists;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				IfExists = input.ReadBool();
				break;
			case 10u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage(collection_);
				break;
			}
		}
	}
}
