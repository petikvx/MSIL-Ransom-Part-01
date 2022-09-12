using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Order : IMessage<Order>, IEquatable<Order>, IDeepCloneable<Order>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Direction
		{
			[OriginalName("NONE_Direction")]
			NoneDirection,
			[OriginalName("ASC")]
			Asc,
			[OriginalName("DESC")]
			Desc
		}
	}

	private static readonly MessageParser<Order> _parser = new MessageParser<Order>(() => new Order());

	private UnknownFieldSet _unknownFields;

	public const int ExprFieldNumber = 1;

	private Mysqlx.Expr.Expr expr_;

	public const int DirectionFieldNumber = 2;

	private Types.Direction direction_;

	[DebuggerNonUserCode]
	public static MessageParser<Order> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[5];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Expr
	{
		get
		{
			return expr_;
		}
		set
		{
			expr_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.Direction Direction
	{
		get
		{
			return direction_;
		}
		set
		{
			direction_ = value;
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
		expr_ = ((other.expr_ != null) ? other.expr_.Clone() : null);
		direction_ = other.direction_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Order Clone()
	{
		return new Order(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Order);
	}

	[DebuggerNonUserCode]
	public bool Equals(Order other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (expr_ != null)
		{
			num ^= Expr.GetHashCode();
		}
		if (Direction != 0)
		{
			num ^= Direction.GetHashCode();
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
		if (expr_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Expr);
		}
		if (Direction != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Direction);
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
		if (expr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Expr);
		}
		if (Direction != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Direction);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
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
		if (other.expr_ != null)
		{
			if (expr_ == null)
			{
				expr_ = new Mysqlx.Expr.Expr();
			}
			Expr.MergeFrom(other.Expr);
		}
		if (other.Direction != 0)
		{
			Direction = other.Direction;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 16u:
				direction_ = (Types.Direction)input.ReadEnum();
				break;
			case 10u:
				if (expr_ == null)
				{
					expr_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(expr_);
				break;
			}
		}
	}
}
