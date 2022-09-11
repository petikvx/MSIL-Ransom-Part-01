using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace Mysqlx.Crud;

internal sealed class Column : IMessage, IMessage<Column>, IEquatable<Column>, IDeepCloneable<Column>
{
	private static readonly MessageParser<Column> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107397215);

	public const int int_1 = 2;

	private string string_1 = getString_0(107397215);

	public const int int_2 = 3;

	private static readonly FieldCodec<DocumentPathItem> fieldCodec_0;

	private readonly RepeatedField<DocumentPathItem> repeatedField_0 = new RepeatedField<DocumentPathItem>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Column> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392168));
		}
	}

	[DebuggerNonUserCode]
	public string Alias
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = ProtoPreconditions.CheckNotNull(value, getString_0(107392168));
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<DocumentPathItem> DocumentPath => repeatedField_0;

	[DebuggerNonUserCode]
	public Column()
	{
	}

	[DebuggerNonUserCode]
	public Column(Column other)
		: this()
	{
		string_0 = other.string_0;
		string_1 = other.string_1;
		repeatedField_0 = other.repeatedField_0.Clone();
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Column Clone()
	{
		return new Column(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Column>)this).Equals(obj as Column);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Column>.Equals(Column other)
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
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
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
		num ^= repeatedField_0.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (Alias.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Alias);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
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
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
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
			repeatedField_0.Add(other.repeatedField_0);
			unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
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
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 26u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
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

	static Column()
	{
		Strings.CreateGetStringDelegate(typeof(Column));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397393), getString_0(107397388)).Replace(getString_0(107397351), getString_0(107397346)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397341)))
		{
			throw new SecurityException(getString_0(107397316));
		}
		messageParser_0 = new MessageParser<Column>(() => new Column());
		fieldCodec_0 = FieldCodec.ForMessage(26u, DocumentPathItem.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
