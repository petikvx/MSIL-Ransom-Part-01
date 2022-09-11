using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns15;

namespace Mysqlx.Expr;

internal sealed class Expr : IMessage, IMessage<Expr>, IEquatable<Expr>, IDeepCloneable<Expr>
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Type
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("IDENT")]
			Ident,
			[OriginalName("LITERAL")]
			Literal,
			[OriginalName("VARIABLE")]
			Variable,
			[OriginalName("FUNC_CALL")]
			FuncCall,
			[OriginalName("OPERATOR")]
			Operator,
			[OriginalName("PLACEHOLDER")]
			Placeholder,
			[OriginalName("OBJECT")]
			Object,
			[OriginalName("ARRAY")]
			Array
		}
	}

	private static readonly MessageParser<Expr> messageParser_0;

	public const int int_0 = 1;

	private Types.Type type_0;

	public const int int_1 = 2;

	private ColumnIdentifier columnIdentifier_0;

	public const int int_2 = 3;

	private string string_0 = getString_0(107396985);

	public const int int_3 = 4;

	private Scalar scalar_0;

	public const int int_4 = 5;

	private FunctionCall functionCall_0;

	public const int int_5 = 6;

	private Operator operator_0;

	public const int int_6 = 7;

	private uint uint_0;

	public const int int_7 = 8;

	private Object object_0;

	public const int int_8 = 9;

	private Array array_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Expr> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Type Type
	{
		get
		{
			return type_0;
		}
		set
		{
			type_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public ColumnIdentifier Identifier
	{
		get
		{
			return columnIdentifier_0;
		}
		set
		{
			columnIdentifier_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public string Variable
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391938));
		}
	}

	[DebuggerNonUserCode]
	public Scalar Literal
	{
		get
		{
			return scalar_0;
		}
		set
		{
			scalar_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public FunctionCall FunctionCall
	{
		get
		{
			return functionCall_0;
		}
		set
		{
			functionCall_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Operator Operator
	{
		get
		{
			return operator_0;
		}
		set
		{
			operator_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Position
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
	public Object Object
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Array Array
	{
		get
		{
			return array_0;
		}
		set
		{
			array_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Expr()
	{
	}

	[DebuggerNonUserCode]
	public Expr(Expr other)
		: this()
	{
		type_0 = other.type_0;
		Identifier = ((other.columnIdentifier_0 != null) ? other.Identifier.Clone() : null);
		string_0 = other.string_0;
		Literal = ((other.scalar_0 != null) ? other.Literal.Clone() : null);
		FunctionCall = ((other.functionCall_0 != null) ? other.FunctionCall.Clone() : null);
		Operator = ((other.operator_0 != null) ? other.Operator.Clone() : null);
		uint_0 = other.uint_0;
		Object = ((other.object_0 != null) ? other.Object.Clone() : null);
		Array = ((other.array_0 != null) ? other.Array.Clone() : null);
	}

	[DebuggerNonUserCode]
	public Expr Clone()
	{
		return new Expr(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Expr>)this).Equals(obj as Expr);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Expr>.Equals(Expr other)
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
		if (!object.Equals(Identifier, other.Identifier))
		{
			return false;
		}
		if (Variable != other.Variable)
		{
			return false;
		}
		if (!object.Equals(Literal, other.Literal))
		{
			return false;
		}
		if (!object.Equals(FunctionCall, other.FunctionCall))
		{
			return false;
		}
		if (!object.Equals(Operator, other.Operator))
		{
			return false;
		}
		if (Position != other.Position)
		{
			return false;
		}
		if (!object.Equals(Object, other.Object))
		{
			return false;
		}
		if (!object.Equals(Array, other.Array))
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
		if (columnIdentifier_0 != null)
		{
			num ^= Identifier.GetHashCode();
		}
		if (Variable.Length != 0)
		{
			num ^= Variable.GetHashCode();
		}
		if (scalar_0 != null)
		{
			num ^= Literal.GetHashCode();
		}
		if (functionCall_0 != null)
		{
			num ^= FunctionCall.GetHashCode();
		}
		if (operator_0 != null)
		{
			num ^= Operator.GetHashCode();
		}
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
		}
		if (object_0 != null)
		{
			num ^= Object.GetHashCode();
		}
		if (array_0 != null)
		{
			num ^= Array.GetHashCode();
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
		if (columnIdentifier_0 != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Identifier);
		}
		if (Variable.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Variable);
		}
		if (scalar_0 != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Literal);
		}
		if (functionCall_0 != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(FunctionCall);
		}
		if (operator_0 != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Operator);
		}
		if (Position != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Position);
		}
		if (object_0 != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Object);
		}
		if (array_0 != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Array);
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
		if (columnIdentifier_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Identifier);
		}
		if (Variable.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Variable);
		}
		if (scalar_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Literal);
		}
		if (functionCall_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FunctionCall);
		}
		if (operator_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Operator);
		}
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Position);
		}
		if (object_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Object);
		}
		if (array_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Array);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Expr other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		if (other.columnIdentifier_0 != null)
		{
			if (columnIdentifier_0 == null)
			{
				columnIdentifier_0 = new ColumnIdentifier();
			}
			Identifier.MergeFrom(other.Identifier);
		}
		if (other.Variable.Length != 0)
		{
			Variable = other.Variable;
		}
		if (other.scalar_0 != null)
		{
			if (scalar_0 == null)
			{
				scalar_0 = new Scalar();
			}
			Literal.MergeFrom(other.Literal);
		}
		if (other.functionCall_0 != null)
		{
			if (functionCall_0 == null)
			{
				functionCall_0 = new FunctionCall();
			}
			FunctionCall.MergeFrom(other.FunctionCall);
		}
		if (other.operator_0 != null)
		{
			if (operator_0 == null)
			{
				operator_0 = new Operator();
			}
			Operator.MergeFrom(other.Operator);
		}
		if (other.Position != 0)
		{
			Position = other.Position;
		}
		if (other.object_0 != null)
		{
			if (object_0 == null)
			{
				object_0 = new Object();
			}
			Object.MergeFrom(other.Object);
		}
		if (other.array_0 != null)
		{
			if (array_0 == null)
			{
				array_0 = new Array();
			}
			Array.MergeFrom(other.Array);
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
				if (columnIdentifier_0 == null)
				{
					columnIdentifier_0 = new ColumnIdentifier();
				}
				input.ReadMessage(columnIdentifier_0);
				break;
			case 8u:
				type_0 = (Types.Type)input.ReadEnum();
				break;
			case 34u:
				if (scalar_0 == null)
				{
					scalar_0 = new Scalar();
				}
				input.ReadMessage(scalar_0);
				break;
			case 26u:
				Variable = input.ReadString();
				break;
			case 50u:
				if (operator_0 == null)
				{
					operator_0 = new Operator();
				}
				input.ReadMessage(operator_0);
				break;
			case 42u:
				if (functionCall_0 == null)
				{
					functionCall_0 = new FunctionCall();
				}
				input.ReadMessage(functionCall_0);
				break;
			default:
				input.SkipLastField();
				break;
			case 74u:
				if (array_0 == null)
				{
					array_0 = new Array();
				}
				input.ReadMessage(array_0);
				break;
			case 66u:
				if (object_0 == null)
				{
					object_0 = new Object();
				}
				input.ReadMessage(object_0);
				break;
			case 56u:
				Position = input.ReadUInt32();
				break;
			}
		}
	}

	static Expr()
	{
		Strings.CreateGetStringDelegate(typeof(Expr));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397163), getString_0(107397158)).Replace(getString_0(107397121), getString_0(107397116)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397111)))
		{
			throw new SecurityException(getString_0(107397086));
		}
		messageParser_0 = new MessageParser<Expr>(() => new Expr());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
