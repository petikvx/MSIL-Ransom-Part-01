using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns17;
using ns2;
using ns3;

namespace Mysqlx.Crud;

internal sealed class CreateView : IMessage, IMessage<CreateView>, IEquatable<CreateView>, IDeepCloneable<CreateView>
{
	private static readonly MessageParser<CreateView> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Collection collection_0;

	public const int int_1 = 2;

	private string string_0 = getString_0(107397393);

	public const int int_2 = 3;

	private Enum16 enum16_0;

	public const int int_3 = 4;

	private Enum17 enum17_0;

	public const int int_4 = 5;

	private Enum18 enum18_0;

	public const int int_5 = 6;

	private static readonly FieldCodec<string> fieldCodec_0;

	private readonly RepeatedField<string> repeatedField_0 = new RepeatedField<string>();

	public const int int_6 = 7;

	private Find find_0;

	public const int int_7 = 8;

	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<CreateView> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[10];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Collection Collection
	{
		get
		{
			return collection_0;
		}
		set
		{
			collection_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public string Definer
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392346));
		}
	}

	[DebuggerNonUserCode]
	public Enum16 Algorithm
	{
		get
		{
			return enum16_0;
		}
		set
		{
			enum16_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Enum17 Security
	{
		get
		{
			return enum17_0;
		}
		set
		{
			enum17_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Enum18 Check
	{
		get
		{
			return enum18_0;
		}
		set
		{
			enum18_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<string> Column => repeatedField_0;

	[DebuggerNonUserCode]
	public Find Stmt
	{
		get
		{
			return find_0;
		}
		set
		{
			find_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public bool ReplaceExisting
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public CreateView()
	{
	}

	[DebuggerNonUserCode]
	public CreateView(CreateView other)
		: this()
	{
		Collection = ((other.collection_0 != null) ? other.Collection.Clone() : null);
		string_0 = other.string_0;
		enum16_0 = other.enum16_0;
		enum17_0 = other.enum17_0;
		enum18_0 = other.enum18_0;
		repeatedField_0 = other.repeatedField_0.Clone();
		Stmt = ((other.find_0 != null) ? other.Stmt.Clone() : null);
		bool_0 = other.bool_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public CreateView Clone()
	{
		return new CreateView(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<CreateView>)this).Equals(obj as CreateView);
	}

	[DebuggerNonUserCode]
	bool IEquatable<CreateView>.Equals(CreateView other)
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
		if (Definer != other.Definer)
		{
			return false;
		}
		if (Algorithm != other.Algorithm)
		{
			return false;
		}
		if (Security != other.Security)
		{
			return false;
		}
		if (Check != other.Check)
		{
			return false;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		if (!object.Equals(Stmt, other.Stmt))
		{
			return false;
		}
		if (ReplaceExisting != other.ReplaceExisting)
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (collection_0 != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (Definer.Length != 0)
		{
			num ^= Definer.GetHashCode();
		}
		if (Algorithm != 0)
		{
			num ^= Algorithm.GetHashCode();
		}
		if (Security != 0)
		{
			num ^= Security.GetHashCode();
		}
		if (Check != 0)
		{
			num ^= Check.GetHashCode();
		}
		num ^= repeatedField_0.GetHashCode();
		if (find_0 != null)
		{
			num ^= Stmt.GetHashCode();
		}
		if (ReplaceExisting)
		{
			num ^= ReplaceExisting.GetHashCode();
		}
		if (unknownFieldSet_0 != null)
		{
			num ^= unknownFieldSet_0.GetHashCode();
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
		if (collection_0 != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Collection);
		}
		if (Definer.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Definer);
		}
		if (Algorithm != 0)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Algorithm);
		}
		if (Security != 0)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Security);
		}
		if (Check != 0)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Check);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		if (find_0 != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Stmt);
		}
		if (ReplaceExisting)
		{
			output.WriteRawTag(64);
			output.WriteBool(ReplaceExisting);
		}
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (collection_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (Definer.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Definer);
		}
		if (Algorithm != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Algorithm);
		}
		if (Security != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Security);
		}
		if (Check != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Check);
		}
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (find_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stmt);
		}
		if (ReplaceExisting)
		{
			num += 2;
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CreateView other)
	{
		if (other == null)
		{
			return;
		}
		if (other.collection_0 != null)
		{
			if (collection_0 == null)
			{
				collection_0 = new Collection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.Definer.Length != 0)
		{
			Definer = other.Definer;
		}
		if (other.Algorithm != 0)
		{
			Algorithm = other.Algorithm;
		}
		if (other.Security != 0)
		{
			Security = other.Security;
		}
		if (other.Check != 0)
		{
			Check = other.Check;
		}
		repeatedField_0.Add(other.repeatedField_0);
		if (other.find_0 != null)
		{
			if (find_0 == null)
			{
				find_0 = new Find();
			}
			Stmt.MergeFrom(other.Stmt);
		}
		if (other.ReplaceExisting)
		{
			ReplaceExisting = other.ReplaceExisting;
		}
		unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
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
				Definer = input.ReadString();
				break;
			case 10u:
				if (collection_0 == null)
				{
					collection_0 = new Collection();
				}
				input.ReadMessage(collection_0);
				break;
			case 32u:
				enum17_0 = (Enum17)input.ReadEnum();
				break;
			case 24u:
				enum16_0 = (Enum16)input.ReadEnum();
				break;
			case 50u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 40u:
				enum18_0 = (Enum18)input.ReadEnum();
				break;
			default:
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 64u:
				ReplaceExisting = input.ReadBool();
				break;
			case 58u:
				if (find_0 == null)
				{
					find_0 = new Find();
				}
				input.ReadMessage(find_0);
				break;
			}
		}
	}

	static CreateView()
	{
		Strings.CreateGetStringDelegate(typeof(CreateView));
		messageParser_0 = new MessageParser<CreateView>(() => new CreateView());
		fieldCodec_0 = FieldCodec.ForString(50u);
	}
}
