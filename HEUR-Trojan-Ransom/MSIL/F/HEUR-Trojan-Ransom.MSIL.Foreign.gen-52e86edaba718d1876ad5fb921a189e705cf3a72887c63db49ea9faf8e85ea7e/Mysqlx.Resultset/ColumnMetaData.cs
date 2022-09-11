using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;

namespace Mysqlx.Resultset;

internal sealed class ColumnMetaData : IMessage, IMessage<ColumnMetaData>, IEquatable<ColumnMetaData>, IDeepCloneable<ColumnMetaData>
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

	private static readonly MessageParser<ColumnMetaData> messageParser_0;

	public const int int_0 = 1;

	private Types.FieldType fieldType_0;

	public const int int_1 = 2;

	private ByteString byteString_0 = ByteString.Empty;

	public const int int_2 = 3;

	private ByteString byteString_1 = ByteString.Empty;

	public const int int_3 = 4;

	private ByteString byteString_2 = ByteString.Empty;

	public const int int_4 = 5;

	private ByteString byteString_3 = ByteString.Empty;

	public const int int_5 = 6;

	private ByteString byteString_4 = ByteString.Empty;

	public const int int_6 = 7;

	private ByteString byteString_5 = ByteString.Empty;

	public const int int_7 = 8;

	private ulong ulong_0;

	public const int int_8 = 9;

	private uint uint_0;

	public const int int_9 = 10;

	private uint uint_1;

	public const int int_10 = 11;

	private uint uint_2;

	public const int int_11 = 12;

	private uint uint_3;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<ColumnMetaData> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class21.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.FieldType Type
	{
		get
		{
			return fieldType_0;
		}
		set
		{
			fieldType_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public ByteString Name
	{
		get
		{
			return byteString_0;
		}
		set
		{
			byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391830));
		}
	}

	[DebuggerNonUserCode]
	public ByteString OriginalName
	{
		get
		{
			return byteString_1;
		}
		set
		{
			byteString_1 = ProtoPreconditions.CheckNotNull(value, getString_0(107391830));
		}
	}

	[DebuggerNonUserCode]
	public ByteString Table
	{
		get
		{
			return byteString_2;
		}
		set
		{
			byteString_2 = ProtoPreconditions.CheckNotNull(value, getString_0(107391830));
		}
	}

	[DebuggerNonUserCode]
	public ByteString OriginalTable
	{
		get
		{
			return byteString_3;
		}
		set
		{
			byteString_3 = ProtoPreconditions.CheckNotNull(value, getString_0(107391830));
		}
	}

	[DebuggerNonUserCode]
	public ByteString Schema
	{
		get
		{
			return byteString_4;
		}
		set
		{
			byteString_4 = ProtoPreconditions.CheckNotNull(value, getString_0(107391830));
		}
	}

	[DebuggerNonUserCode]
	public ByteString Catalog
	{
		get
		{
			return byteString_5;
		}
		set
		{
			byteString_5 = ProtoPreconditions.CheckNotNull(value, getString_0(107391830));
		}
	}

	[DebuggerNonUserCode]
	public ulong Collation
	{
		get
		{
			return ulong_0;
		}
		set
		{
			ulong_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public uint FractionalDigits
	{
		get
		{
			return uint_0;
		}
		set
		{
			uint_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Length
	{
		get
		{
			return uint_1;
		}
		set
		{
			uint_1 = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Flags
	{
		get
		{
			return uint_2;
		}
		set
		{
			uint_2 = value;
		}
	}

	[DebuggerNonUserCode]
	public uint ContentType
	{
		get
		{
			return uint_3;
		}
		set
		{
			uint_3 = value;
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
		fieldType_0 = other.fieldType_0;
		byteString_0 = other.byteString_0;
		byteString_1 = other.byteString_1;
		byteString_2 = other.byteString_2;
		byteString_3 = other.byteString_3;
		byteString_4 = other.byteString_4;
		byteString_5 = other.byteString_5;
		ulong_0 = other.ulong_0;
		uint_0 = other.uint_0;
		uint_1 = other.uint_1;
		uint_2 = other.uint_2;
		uint_3 = other.uint_3;
	}

	[DebuggerNonUserCode]
	public ColumnMetaData Clone()
	{
		return new ColumnMetaData(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<ColumnMetaData>)this).Equals(obj as ColumnMetaData);
	}

	[DebuggerNonUserCode]
	bool IEquatable<ColumnMetaData>.Equals(ColumnMetaData other)
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
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (OriginalName.Length != 0)
		{
			num ^= OriginalName.GetHashCode();
		}
		if (Table.Length != 0)
		{
			num ^= Table.GetHashCode();
		}
		if (OriginalTable.Length != 0)
		{
			num ^= OriginalTable.GetHashCode();
		}
		if (Schema.Length != 0)
		{
			num ^= Schema.GetHashCode();
		}
		if (Catalog.Length != 0)
		{
			num ^= Catalog.GetHashCode();
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
		return num;
	}

	[DebuggerNonUserCode]
	string object.ToString()
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(Name);
		}
		if (OriginalName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(OriginalName);
		}
		if (Table.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(Table);
		}
		if (OriginalTable.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteBytes(OriginalTable);
		}
		if (Schema.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteBytes(Schema);
		}
		if (Catalog.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteBytes(Catalog);
		}
		if (Collation != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(Collation);
		}
		if (FractionalDigits != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FractionalDigits);
		}
		if (Length != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Length);
		}
		if (Flags != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Flags);
		}
		if (ContentType != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ContentType);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Name);
		}
		if (OriginalName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(OriginalName);
		}
		if (Table.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Table);
		}
		if (OriginalTable.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(OriginalTable);
		}
		if (Schema.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Schema);
		}
		if (Catalog.Length != 0)
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
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.OriginalName.Length != 0)
			{
				OriginalName = other.OriginalName;
			}
			if (other.Table.Length != 0)
			{
				Table = other.Table;
			}
			if (other.OriginalTable.Length != 0)
			{
				OriginalTable = other.OriginalTable;
			}
			if (other.Schema.Length != 0)
			{
				Schema = other.Schema;
			}
			if (other.Catalog.Length != 0)
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
				fieldType_0 = (Types.FieldType)input.ReadEnum();
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
				input.SkipLastField();
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

	static ColumnMetaData()
	{
		Strings.CreateGetStringDelegate(typeof(ColumnMetaData));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397055), getString_0(107397050)).Replace(getString_0(107397013), getString_0(107397008)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397003)))
		{
			throw new SecurityException(getString_0(107396978));
		}
		messageParser_0 = new MessageParser<ColumnMetaData>(() => new ColumnMetaData());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
