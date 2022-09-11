using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace Mysqlx.Crud;

internal sealed class Order : IMessage, IMessage<Order>, IEquatable<Order>, IDeepCloneable<Order>
{
	[DebuggerNonUserCode]
	internal static class Class33
	{
		internal enum Enum19
		{
			[OriginalName("NONE_Direction")]
			const_0,
			[OriginalName("ASC")]
			const_1,
			[OriginalName("DESC")]
			const_2
		}
	}

	private static readonly MessageParser<Order> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Mysqlx.Expr.Expr expr_0;

	public const int int_1 = 2;

	private Class33.Enum19 enum19_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Order> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Expr
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
	public Class33.Enum19 Direction
	{
		get
		{
			return enum19_0;
		}
		set
		{
			enum19_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Order()
	{
	}

	[DebuggerNonUserCode]
	public Order(Order other)
		: this()
	{
		Expr = ((other.expr_0 != null) ? other.Expr.Clone() : null);
		enum19_0 = other.enum19_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Order Clone()
	{
		return new Order(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Order>)this).Equals(obj as Order);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Order>.Equals(Order other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Expr, other.Expr))
		{
			return false;
		}
		if (Direction != other.Direction)
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
			num ^= Expr.GetHashCode();
		}
		if (Direction != 0)
		{
			num ^= Direction.GetHashCode();
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
			output.WriteMessage(Expr);
		}
		if (Direction != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Direction);
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
			num += 1 + CodedOutputStream.ComputeMessageSize(Expr);
		}
		if (Direction != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Direction);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Order other)
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
			Expr.MergeFrom(other.Expr);
		}
		if (other.Direction != 0)
		{
			Direction = other.Direction;
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
			case 16u:
				enum19_0 = (Class33.Enum19)input.ReadEnum();
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

	static Order()
	{
		Strings.CreateGetStringDelegate(typeof(Order));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397424), getString_0(107397419)).Replace(getString_0(107397382), getString_0(107397377)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397372)))
		{
			throw new SecurityException(getString_0(107397347));
		}
		messageParser_0 = new MessageParser<Order>(() => new Order());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
