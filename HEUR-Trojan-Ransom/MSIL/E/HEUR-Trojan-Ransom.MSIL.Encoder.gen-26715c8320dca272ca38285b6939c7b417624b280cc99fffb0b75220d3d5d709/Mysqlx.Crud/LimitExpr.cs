using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class LimitExpr : IMessage<LimitExpr>, IEquatable<LimitExpr>, IDeepCloneable<LimitExpr>, IMessage
{
	private static readonly MessageParser<LimitExpr> _parser = new MessageParser<LimitExpr>((Func<LimitExpr>)(() => new LimitExpr()));

	private UnknownFieldSet _unknownFields;

	public const int RowCountFieldNumber = 1;

	private Mysqlx.Expr.Expr rowCount_;

	public const int OffsetFieldNumber = 2;

	private Mysqlx.Expr.Expr offset_;

	[DebuggerNonUserCode]
	public static MessageParser<LimitExpr> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[4];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr RowCount
	{
		get
		{
			return rowCount_;
		}
		set
		{
			rowCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Offset
	{
		get
		{
			return offset_;
		}
		set
		{
			offset_ = value;
		}
	}

	[DebuggerNonUserCode]
	public LimitExpr()
	{
	}

	[DebuggerNonUserCode]
	public LimitExpr(LimitExpr other)
		: this()
	{
		rowCount_ = ((other.rowCount_ != null) ? other.rowCount_.Clone() : null);
		offset_ = ((other.offset_ != null) ? other.offset_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public LimitExpr Clone()
	{
		return new LimitExpr(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as LimitExpr);
	}

	[DebuggerNonUserCode]
	public bool Equals(LimitExpr other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RowCount, other.RowCount))
		{
			return false;
		}
		if (!object.Equals(Offset, other.Offset))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (rowCount_ != null)
		{
			num ^= RowCount.GetHashCode();
		}
		if (offset_ != null)
		{
			num ^= Offset.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= ((object)_unknownFields).GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString((IMessage)(object)this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (rowCount_ != null)
		{
			output.WriteRawTag((byte)10);
			output.WriteMessage((IMessage)(object)RowCount);
		}
		if (offset_ != null)
		{
			output.WriteRawTag((byte)18);
			output.WriteMessage((IMessage)(object)Offset);
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
		if (rowCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)RowCount);
		}
		if (offset_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Offset);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(LimitExpr other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rowCount_ != null)
		{
			if (rowCount_ == null)
			{
				rowCount_ = new Mysqlx.Expr.Expr();
			}
			RowCount.MergeFrom(other.RowCount);
		}
		if (other.offset_ != null)
		{
			if (offset_ == null)
			{
				offset_ = new Mysqlx.Expr.Expr();
			}
			Offset.MergeFrom(other.Offset);
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
			case 18u:
				if (offset_ == null)
				{
					offset_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage((IMessage)(object)offset_);
				break;
			case 10u:
				if (rowCount_ == null)
				{
					rowCount_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage((IMessage)(object)rowCount_);
				break;
			}
		}
	}
}
