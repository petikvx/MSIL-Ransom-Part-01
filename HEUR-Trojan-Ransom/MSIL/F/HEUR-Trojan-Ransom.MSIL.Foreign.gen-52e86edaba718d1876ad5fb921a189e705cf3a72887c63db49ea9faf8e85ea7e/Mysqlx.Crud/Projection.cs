using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace Mysqlx.Crud;

internal sealed class Projection : IMessage, IMessage<Projection>, IEquatable<Projection>, IDeepCloneable<Projection>
{
	private static readonly MessageParser<Projection> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Mysqlx.Expr.Expr expr_0;

	public const int int_1 = 2;

	private string string_0 = getString_0(107397223);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Projection> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Source
	{
		get
		{
			return expr_0;
		}
		set
		{
			expr_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public string Alias
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392176));
		}
	}

	[DebuggerNonUserCode]
	public Projection()
	{
	}

	[DebuggerNonUserCode]
	public Projection(Projection other)
		: this()
	{
		Source = ((other.expr_0 != null) ? other.Source.Clone() : null);
		string_0 = other.string_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Projection Clone()
	{
		return new Projection(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Projection>)this).Equals(obj as Projection);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Projection>.Equals(Projection other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (Alias != other.Alias)
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (expr_0 != null)
		{
			num ^= Source.GetHashCode();
		}
		if (Alias.Length != 0)
		{
			num ^= Alias.GetHashCode();
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
		if (expr_0 != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Source);
		}
		if (Alias.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Alias);
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
		if (expr_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (Alias.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Alias);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Projection other)
	{
		if (other == null)
		{
			return;
		}
		if (other.expr_0 != null)
		{
			if (expr_0 == null)
			{
				expr_0 = new Mysqlx.Expr.Expr();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.Alias.Length != 0)
		{
			Alias = other.Alias;
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
			default:
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 18u:
				Alias = input.ReadString();
				break;
			case 10u:
				if (expr_0 == null)
				{
					expr_0 = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(expr_0);
				break;
			}
		}
	}

	static Projection()
	{
		Strings.CreateGetStringDelegate(typeof(Projection));
		messageParser_0 = new MessageParser<Projection>(() => new Projection());
	}
}
