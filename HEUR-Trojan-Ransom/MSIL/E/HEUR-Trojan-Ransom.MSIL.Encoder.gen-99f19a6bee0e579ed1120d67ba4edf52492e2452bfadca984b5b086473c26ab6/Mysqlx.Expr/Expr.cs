using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Expr;

internal sealed class Expr : IMessage<Expr>, IEquatable<Expr>, IDeepCloneable<Expr>, IMessage
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

	private static readonly MessageParser<Expr> _parser = new MessageParser<Expr>(() => new Expr());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Types.Type type_;

	public const int IdentifierFieldNumber = 2;

	private ColumnIdentifier identifier_;

	public const int VariableFieldNumber = 3;

	private string variable_ = "";

	public const int LiteralFieldNumber = 4;

	private Scalar literal_;

	public const int FunctionCallFieldNumber = 5;

	private FunctionCall functionCall_;

	public const int OperatorFieldNumber = 6;

	private Operator operator_;

	public const int PositionFieldNumber = 7;

	private uint position_;

	public const int ObjectFieldNumber = 8;

	private Object object_;

	public const int ArrayFieldNumber = 9;

	private Array array_;

	[DebuggerNonUserCode]
	public static MessageParser<Expr> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.MessageTypes[0];

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
	public ColumnIdentifier Identifier
	{
		get
		{
			return identifier_;
		}
		set
		{
			identifier_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string Variable
	{
		get
		{
			return variable_;
		}
		set
		{
			variable_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Scalar Literal
	{
		get
		{
			return literal_;
		}
		set
		{
			literal_ = value;
		}
	}

	[DebuggerNonUserCode]
	public FunctionCall FunctionCall
	{
		get
		{
			return functionCall_;
		}
		set
		{
			functionCall_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Operator Operator
	{
		get
		{
			return operator_;
		}
		set
		{
			operator_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Object Object
	{
		get
		{
			return object_;
		}
		set
		{
			object_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Array Array
	{
		get
		{
			return array_;
		}
		set
		{
			array_ = value;
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
		type_ = other.type_;
		identifier_ = ((other.identifier_ != null) ? other.identifier_.Clone() : null);
		variable_ = other.variable_;
		literal_ = ((other.literal_ != null) ? other.literal_.Clone() : null);
		functionCall_ = ((other.functionCall_ != null) ? other.functionCall_.Clone() : null);
		operator_ = ((other.operator_ != null) ? other.operator_.Clone() : null);
		position_ = other.position_;
		object_ = ((other.object_ != null) ? other.object_.Clone() : null);
		array_ = ((other.array_ != null) ? other.array_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Expr Clone()
	{
		return new Expr(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Expr);
	}

	[DebuggerNonUserCode]
	public bool Equals(Expr other)
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
		if (identifier_ != null)
		{
			num ^= Identifier.GetHashCode();
		}
		if (Variable.Length != 0)
		{
			num ^= Variable.GetHashCode();
		}
		if (literal_ != null)
		{
			num ^= Literal.GetHashCode();
		}
		if (functionCall_ != null)
		{
			num ^= FunctionCall.GetHashCode();
		}
		if (operator_ != null)
		{
			num ^= Operator.GetHashCode();
		}
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
		}
		if (object_ != null)
		{
			num ^= Object.GetHashCode();
		}
		if (array_ != null)
		{
			num ^= Array.GetHashCode();
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
		if (identifier_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Identifier);
		}
		if (Variable.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Variable);
		}
		if (literal_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Literal);
		}
		if (functionCall_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(FunctionCall);
		}
		if (operator_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Operator);
		}
		if (Position != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Position);
		}
		if (object_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Object);
		}
		if (array_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Array);
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
		if (identifier_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Identifier);
		}
		if (Variable.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Variable);
		}
		if (literal_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Literal);
		}
		if (functionCall_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FunctionCall);
		}
		if (operator_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Operator);
		}
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Position);
		}
		if (object_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Object);
		}
		if (array_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Array);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
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
		if (other.identifier_ != null)
		{
			if (identifier_ == null)
			{
				identifier_ = new ColumnIdentifier();
			}
			Identifier.MergeFrom(other.Identifier);
		}
		if (other.Variable.Length != 0)
		{
			Variable = other.Variable;
		}
		if (other.literal_ != null)
		{
			if (literal_ == null)
			{
				literal_ = new Scalar();
			}
			Literal.MergeFrom(other.Literal);
		}
		if (other.functionCall_ != null)
		{
			if (functionCall_ == null)
			{
				functionCall_ = new FunctionCall();
			}
			FunctionCall.MergeFrom(other.FunctionCall);
		}
		if (other.operator_ != null)
		{
			if (operator_ == null)
			{
				operator_ = new Operator();
			}
			Operator.MergeFrom(other.Operator);
		}
		if (other.Position != 0)
		{
			Position = other.Position;
		}
		if (other.object_ != null)
		{
			if (object_ == null)
			{
				object_ = new Object();
			}
			Object.MergeFrom(other.Object);
		}
		if (other.array_ != null)
		{
			if (array_ == null)
			{
				array_ = new Array();
			}
			Array.MergeFrom(other.Array);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (identifier_ == null)
				{
					identifier_ = new ColumnIdentifier();
				}
				input.ReadMessage(identifier_);
				break;
			case 8u:
				type_ = (Types.Type)input.ReadEnum();
				break;
			case 34u:
				if (literal_ == null)
				{
					literal_ = new Scalar();
				}
				input.ReadMessage(literal_);
				break;
			case 26u:
				Variable = input.ReadString();
				break;
			case 50u:
				if (operator_ == null)
				{
					operator_ = new Operator();
				}
				input.ReadMessage(operator_);
				break;
			case 42u:
				if (functionCall_ == null)
				{
					functionCall_ = new FunctionCall();
				}
				input.ReadMessage(functionCall_);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 74u:
				if (array_ == null)
				{
					array_ = new Array();
				}
				input.ReadMessage(array_);
				break;
			case 66u:
				if (object_ == null)
				{
					object_ = new Object();
				}
				input.ReadMessage(object_);
				break;
			case 56u:
				Position = input.ReadUInt32();
				break;
			}
		}
	}
}
