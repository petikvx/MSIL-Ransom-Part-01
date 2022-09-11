using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns15;

namespace Mysqlx.Expr;

internal sealed class ColumnIdentifier : IMessage, IMessage<ColumnIdentifier>, IEquatable<ColumnIdentifier>, IDeepCloneable<ColumnIdentifier>
{
	private static readonly MessageParser<ColumnIdentifier> messageParser_0;

	public const int int_0 = 1;

	private static readonly FieldCodec<DocumentPathItem> fieldCodec_0;

	private readonly RepeatedField<DocumentPathItem> repeatedField_0 = new RepeatedField<DocumentPathItem>();

	public const int int_1 = 2;

	private string string_0 = getString_0(107397031);

	public const int int_2 = 3;

	private string string_1 = getString_0(107397031);

	public const int int_3 = 4;

	private string string_2 = getString_0(107397031);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<ColumnIdentifier> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<DocumentPathItem> DocumentPath => repeatedField_0;

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391984));
		}
	}

	[DebuggerNonUserCode]
	public string TableName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = ProtoPreconditions.CheckNotNull(value, getString_0(107391984));
		}
	}

	[DebuggerNonUserCode]
	public string SchemaName
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = ProtoPreconditions.CheckNotNull(value, getString_0(107391984));
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
		repeatedField_0 = other.repeatedField_0.Clone();
		string_0 = other.string_0;
		string_1 = other.string_1;
		string_2 = other.string_2;
	}

	[DebuggerNonUserCode]
	public ColumnIdentifier Clone()
	{
		return new ColumnIdentifier(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<ColumnIdentifier>)this).Equals(obj as ColumnIdentifier);
	}

	[DebuggerNonUserCode]
	bool IEquatable<ColumnIdentifier>.Equals(ColumnIdentifier other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
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
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		num = 1 ^ repeatedField_0.GetHashCode();
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
		repeatedField_0.WriteTo(output, fieldCodec_0);
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
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + repeatedField_0.CalculateSize(fieldCodec_0);
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
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ColumnIdentifier other)
	{
		if (other != null)
		{
			repeatedField_0.Add(other.repeatedField_0);
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
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			default:
				input.SkipLastField();
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

	static ColumnIdentifier()
	{
		Strings.CreateGetStringDelegate(typeof(ColumnIdentifier));
		messageParser_0 = new MessageParser<ColumnIdentifier>(() => new ColumnIdentifier());
		fieldCodec_0 = FieldCodec.ForMessage(10u, DocumentPathItem.Parser);
	}
}
