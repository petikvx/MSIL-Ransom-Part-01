using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expr;

internal sealed class DocumentPathItem : IMessage<DocumentPathItem>, IEquatable<DocumentPathItem>, IDeepCloneable<DocumentPathItem>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Type
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("MEMBER")]
			Member,
			[OriginalName("MEMBER_ASTERISK")]
			MemberAsterisk,
			[OriginalName("ARRAY_INDEX")]
			ArrayIndex,
			[OriginalName("ARRAY_INDEX_ASTERISK")]
			ArrayIndexAsterisk,
			[OriginalName("DOUBLE_ASTERISK")]
			DoubleAsterisk
		}
	}

	private static readonly MessageParser<DocumentPathItem> _parser = new MessageParser<DocumentPathItem>(() => new DocumentPathItem());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Types.Type type_;

	public const int ValueFieldNumber = 2;

	private string value_ = "";

	public const int IndexFieldNumber = 3;

	private uint index_;

	[DebuggerNonUserCode]
	public static MessageParser<DocumentPathItem> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Type Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	public DocumentPathItem()
	{
	}

	[DebuggerNonUserCode]
	public DocumentPathItem(DocumentPathItem other)
		: this()
	{
		type_ = other.type_;
		value_ = other.value_;
		index_ = other.index_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public DocumentPathItem Clone()
	{
		return new DocumentPathItem(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as DocumentPathItem);
	}

	[DebuggerNonUserCode]
	public bool Equals(DocumentPathItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Value.Length != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Value);
		}
		if (Index != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Index);
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
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(DocumentPathItem other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Value.Length != 0)
			{
				Value = other.Value;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
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
				Index = input.ReadUInt32();
				break;
			case 18u:
				Value = input.ReadString();
				break;
			case 8u:
				type_ = (Types.Type)input.ReadEnum();
				break;
			}
		}
	}
}
