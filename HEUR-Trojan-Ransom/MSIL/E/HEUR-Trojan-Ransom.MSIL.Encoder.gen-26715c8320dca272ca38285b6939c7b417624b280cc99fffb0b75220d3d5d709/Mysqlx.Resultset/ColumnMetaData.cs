using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal sealed class ColumnMetaData : IMessage<ColumnMetaData>, IEquatable<ColumnMetaData>, IDeepCloneable<ColumnMetaData>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum FieldType
		{
			[OriginalName("NONE")]
			None = 0,
			[OriginalName("SINT")]
			Sint = 1,
			[OriginalName("UINT")]
			Uint = 2,
			[OriginalName("DOUBLE")]
			Double = 5,
			[OriginalName("FLOAT")]
			Float = 6,
			[OriginalName("BYTES")]
			Bytes = 7,
			[OriginalName("TIME")]
			Time = 10,
			[OriginalName("DATETIME")]
			Datetime = 12,
			[OriginalName("SET")]
			Set = 15,
			[OriginalName("ENUM")]
			Enum = 16,
			[OriginalName("BIT")]
			Bit = 17,
			[OriginalName("DECIMAL")]
			Decimal = 18
		}
	}

	private static readonly MessageParser<ColumnMetaData> _parser = new MessageParser<ColumnMetaData>((Func<ColumnMetaData>)(() => new ColumnMetaData()));

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Types.FieldType type_;

	public const int NameFieldNumber = 2;

	private ByteString name_ = ByteString.get_Empty();

	public const int OriginalNameFieldNumber = 3;

	private ByteString originalName_ = ByteString.get_Empty();

	public const int TableFieldNumber = 4;

	private ByteString table_ = ByteString.get_Empty();

	public const int OriginalTableFieldNumber = 5;

	private ByteString originalTable_ = ByteString.get_Empty();

	public const int SchemaFieldNumber = 6;

	private ByteString schema_ = ByteString.get_Empty();

	public const int CatalogFieldNumber = 7;

	private ByteString catalog_ = ByteString.get_Empty();

	public const int CollationFieldNumber = 8;

	private ulong collation_;

	public const int FractionalDigitsFieldNumber = 9;

	private uint fractionalDigits_;

	public const int LengthFieldNumber = 10;

	private uint length_;

	public const int FlagsFieldNumber = 11;

	private uint flags_;

	public const int ContentTypeFieldNumber = 12;

	private uint contentType_;

	[DebuggerNonUserCode]
	public static MessageParser<ColumnMetaData> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxResultsetReflection.Descriptor.get_MessageTypes()[4];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.FieldType Type
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
	public ByteString Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString OriginalName
	{
		get
		{
			return originalName_;
		}
		set
		{
			originalName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString Table
	{
		get
		{
			return table_;
		}
		set
		{
			table_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString OriginalTable
	{
		get
		{
			return originalTable_;
		}
		set
		{
			originalTable_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString Schema
	{
		get
		{
			return schema_;
		}
		set
		{
			schema_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString Catalog
	{
		get
		{
			return catalog_;
		}
		set
		{
			catalog_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ulong Collation
	{
		get
		{
			return collation_;
		}
		set
		{
			collation_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint FractionalDigits
	{
		get
		{
			return fractionalDigits_;
		}
		set
		{
			fractionalDigits_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Length
	{
		get
		{
			return length_;
		}
		set
		{
			length_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Flags
	{
		get
		{
			return flags_;
		}
		set
		{
			flags_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint ContentType
	{
		get
		{
			return contentType_;
		}
		set
		{
			contentType_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ColumnMetaData()
	{
	}

	[DebuggerNonUserCode]
	public ColumnMetaData(ColumnMetaData other)
		: this()
	{
		type_ = other.type_;
		name_ = other.name_;
		originalName_ = other.originalName_;
		table_ = other.table_;
		originalTable_ = other.originalTable_;
		schema_ = other.schema_;
		catalog_ = other.catalog_;
		collation_ = other.collation_;
		fractionalDigits_ = other.fractionalDigits_;
		length_ = other.length_;
		flags_ = other.flags_;
		contentType_ = other.contentType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public ColumnMetaData Clone()
	{
		return new ColumnMetaData(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ColumnMetaData);
	}

	[DebuggerNonUserCode]
	public bool Equals(ColumnMetaData other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (OriginalName != other.OriginalName)
		{
			return false;
		}
		if (Table != other.Table)
		{
			return false;
		}
		if (OriginalTable != other.OriginalTable)
		{
			return false;
		}
		if (Schema != other.Schema)
		{
			return false;
		}
		if (Catalog != other.Catalog)
		{
			return false;
		}
		if (Collation != other.Collation)
		{
			return false;
		}
		if (FractionalDigits != other.FractionalDigits)
		{
			return false;
		}
		if (Length != other.Length)
		{
			return false;
		}
		if (Flags != other.Flags)
		{
			return false;
		}
		if (ContentType != other.ContentType)
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
		if (Name.get_Length() != 0)
		{
			num ^= ((object)Name).GetHashCode();
		}
		if (OriginalName.get_Length() != 0)
		{
			num ^= ((object)OriginalName).GetHashCode();
		}
		if (Table.get_Length() != 0)
		{
			num ^= ((object)Table).GetHashCode();
		}
		if (OriginalTable.get_Length() != 0)
		{
			num ^= ((object)OriginalTable).GetHashCode();
		}
		if (Schema.get_Length() != 0)
		{
			num ^= ((object)Schema).GetHashCode();
		}
		if (Catalog.get_Length() != 0)
		{
			num ^= ((object)Catalog).GetHashCode();
		}
		if (Collation != 0L)
		{
			num ^= Collation.GetHashCode();
		}
		if (FractionalDigits != 0)
		{
			num ^= FractionalDigits.GetHashCode();
		}
		if (Length != 0)
		{
			num ^= Length.GetHashCode();
		}
		if (Flags != 0)
		{
			num ^= Flags.GetHashCode();
		}
		if (ContentType != 0)
		{
			num ^= ContentType.GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag((byte)8);
			output.WriteEnum((int)Type);
		}
		if (Name.get_Length() != 0)
		{
			output.WriteRawTag((byte)18);
			output.WriteBytes(Name);
		}
		if (OriginalName.get_Length() != 0)
		{
			output.WriteRawTag((byte)26);
			output.WriteBytes(OriginalName);
		}
		if (Table.get_Length() != 0)
		{
			output.WriteRawTag((byte)34);
			output.WriteBytes(Table);
		}
		if (OriginalTable.get_Length() != 0)
		{
			output.WriteRawTag((byte)42);
			output.WriteBytes(OriginalTable);
		}
		if (Schema.get_Length() != 0)
		{
			output.WriteRawTag((byte)50);
			output.WriteBytes(Schema);
		}
		if (Catalog.get_Length() != 0)
		{
			output.WriteRawTag((byte)58);
			output.WriteBytes(Catalog);
		}
		if (Collation != 0L)
		{
			output.WriteRawTag((byte)64);
			output.WriteUInt64(Collation);
		}
		if (FractionalDigits != 0)
		{
			output.WriteRawTag((byte)72);
			output.WriteUInt32(FractionalDigits);
		}
		if (Length != 0)
		{
			output.WriteRawTag((byte)80);
			output.WriteUInt32(Length);
		}
		if (Flags != 0)
		{
			output.WriteRawTag((byte)88);
			output.WriteUInt32(Flags);
		}
		if (ContentType != 0)
		{
			output.WriteRawTag((byte)96);
			output.WriteUInt32(ContentType);
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
		if (Name.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Name);
		}
		if (OriginalName.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(OriginalName);
		}
		if (Table.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Table);
		}
		if (OriginalTable.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(OriginalTable);
		}
		if (Schema.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Schema);
		}
		if (Catalog.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Catalog);
		}
		if (Collation != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Collation);
		}
		if (FractionalDigits != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FractionalDigits);
		}
		if (Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Length);
		}
		if (Flags != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Flags);
		}
		if (ContentType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ColumnMetaData other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Name.get_Length() != 0)
			{
				Name = other.Name;
			}
			if (other.OriginalName.get_Length() != 0)
			{
				OriginalName = other.OriginalName;
			}
			if (other.Table.get_Length() != 0)
			{
				Table = other.Table;
			}
			if (other.OriginalTable.get_Length() != 0)
			{
				OriginalTable = other.OriginalTable;
			}
			if (other.Schema.get_Length() != 0)
			{
				Schema = other.Schema;
			}
			if (other.Catalog.get_Length() != 0)
			{
				Catalog = other.Catalog;
			}
			if (other.Collation != 0L)
			{
				Collation = other.Collation;
			}
			if (other.FractionalDigits != 0)
			{
				FractionalDigits = other.FractionalDigits;
			}
			if (other.Length != 0)
			{
				Length = other.Length;
			}
			if (other.Flags != 0)
			{
				Flags = other.Flags;
			}
			if (other.ContentType != 0)
			{
				ContentType = other.ContentType;
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
			case 26u:
				OriginalName = input.ReadBytes();
				break;
			case 18u:
				Name = input.ReadBytes();
				break;
			case 8u:
				type_ = (Types.FieldType)input.ReadEnum();
				break;
			case 50u:
				Schema = input.ReadBytes();
				break;
			case 42u:
				OriginalTable = input.ReadBytes();
				break;
			case 34u:
				Table = input.ReadBytes();
				break;
			case 72u:
				FractionalDigits = input.ReadUInt32();
				break;
			case 64u:
				Collation = input.ReadUInt64();
				break;
			case 58u:
				Catalog = input.ReadBytes();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 96u:
				ContentType = input.ReadUInt32();
				break;
			case 88u:
				Flags = input.ReadUInt32();
				break;
			case 80u:
				Length = input.ReadUInt32();
				break;
			}
		}
	}
}
