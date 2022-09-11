using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns15;

namespace Mysqlx.Expr;

internal sealed class Operator : IMessage, IMessage<Operator>, IEquatable<Operator>, IDeepCloneable<Operator>
{
	private static readonly MessageParser<Operator> messageParser_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107397047);

	public const int int_1 = 2;

	private static readonly FieldCodec<Expr> fieldCodec_0;

	private readonly RepeatedField<Expr> repeatedField_0 = new RepeatedField<Expr>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Operator> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[5];

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
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392000));
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Expr> Param => repeatedField_0;

	[DebuggerNonUserCode]
	public Operator()
	{
	}

	[DebuggerNonUserCode]
	public Operator(Operator other)
		: this()
	{
		string_0 = other.string_0;
		repeatedField_0 = other.repeatedField_0.Clone();
	}

	[DebuggerNonUserCode]
	public Operator Clone()
	{
		return new Operator(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Operator>)this).Equals(obj as Operator);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Operator>.Equals(Operator other)
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
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		return num ^ repeatedField_0.GetHashCode();
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
		repeatedField_0.WriteTo(output, fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		return num + repeatedField_0.CalculateSize(fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Operator other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			repeatedField_0.Add(other.repeatedField_0);
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
				input.SkipLastField();
				break;
			case 18u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}

	static Operator()
	{
		Strings.CreateGetStringDelegate(typeof(Operator));
		messageParser_0 = new MessageParser<Operator>(() => new Operator());
		fieldCodec_0 = FieldCodec.ForMessage(18u, Expr.Parser);
	}
}
