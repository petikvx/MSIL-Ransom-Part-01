using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Delete : IMessage<Delete>, IEquatable<Delete>, IDeepCloneable<Delete>, IMessage
{
	private static readonly MessageParser<Delete> _parser = new MessageParser<Delete>(() => new Delete());

	private UnknownFieldSet _unknownFields;

	public const int CollectionFieldNumber = 1;

	private Collection collection_;

	public const int DataModelFieldNumber = 2;

	private DataModel dataModel_;

	public const int CriteriaFieldNumber = 3;

	private Mysqlx.Expr.Expr criteria_;

	public const int ArgsFieldNumber = 6;

	private static readonly FieldCodec<Scalar> _repeated_args_codec = FieldCodec.ForMessage(50u, Scalar.Parser);

	private readonly RepeatedField<Scalar> args_ = new RepeatedField<Scalar>();

	public const int OrderFieldNumber = 5;

	private static readonly FieldCodec<Order> _repeated_order_codec = FieldCodec.ForMessage(42u, Mysqlx.Crud.Order.Parser);

	private readonly RepeatedField<Order> order_ = new RepeatedField<Order>();

	public const int LimitFieldNumber = 4;

	private Limit limit_;

	public const int LimitExprFieldNumber = 7;

	private LimitExpr limitExpr_;

	[DebuggerNonUserCode]
	public static MessageParser<Delete> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[10];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Collection Collection
	{
		get
		{
			return collection_;
		}
		set
		{
			collection_ = value;
		}
	}

	[DebuggerNonUserCode]
	public DataModel DataModel
	{
		get
		{
			return dataModel_;
		}
		set
		{
			dataModel_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Criteria
	{
		get
		{
			return criteria_;
		}
		set
		{
			criteria_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Scalar> Args => args_;

	[DebuggerNonUserCode]
	public RepeatedField<Order> Order => order_;

	[DebuggerNonUserCode]
	public Limit Limit
	{
		get
		{
			return limit_;
		}
		set
		{
			limit_ = value;
		}
	}

	[DebuggerNonUserCode]
	public LimitExpr LimitExpr
	{
		get
		{
			return limitExpr_;
		}
		set
		{
			limitExpr_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Delete()
	{
	}

	[DebuggerNonUserCode]
	public Delete(Delete other)
		: this()
	{
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		dataModel_ = other.dataModel_;
		criteria_ = ((other.criteria_ != null) ? other.criteria_.Clone() : null);
		args_ = other.args_.Clone();
		order_ = other.order_.Clone();
		limit_ = ((other.limit_ != null) ? other.limit_.Clone() : null);
		limitExpr_ = ((other.limitExpr_ != null) ? other.limitExpr_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Delete Clone()
	{
		return new Delete(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Delete);
	}

	[DebuggerNonUserCode]
	public bool Equals(Delete other)
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
		if (DataModel != other.DataModel)
		{
			return false;
		}
		if (!object.Equals(Criteria, other.Criteria))
		{
			return false;
		}
		if (!args_.Equals(other.args_))
		{
			return false;
		}
		if (!order_.Equals(other.order_))
		{
			return false;
		}
		if (!object.Equals(Limit, other.Limit))
		{
			return false;
		}
		if (!object.Equals(LimitExpr, other.LimitExpr))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (collection_ != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (DataModel != 0)
		{
			num ^= DataModel.GetHashCode();
		}
		if (criteria_ != null)
		{
			num ^= Criteria.GetHashCode();
		}
		num ^= args_.GetHashCode();
		num ^= order_.GetHashCode();
		if (limit_ != null)
		{
			num ^= Limit.GetHashCode();
		}
		if (limitExpr_ != null)
		{
			num ^= LimitExpr.GetHashCode();
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
		if (collection_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DataModel);
		}
		if (criteria_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Criteria);
		}
		if (limit_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Limit);
		}
		order_.WriteTo(output, _repeated_order_codec);
		args_.WriteTo(output, _repeated_args_codec);
		if (limitExpr_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LimitExpr);
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
		if (collection_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (DataModel != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DataModel);
		}
		if (criteria_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Criteria);
		}
		num += args_.CalculateSize(_repeated_args_codec);
		num += order_.CalculateSize(_repeated_order_codec);
		if (limit_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Limit);
		}
		if (limitExpr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LimitExpr);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Delete other)
	{
		if (other == null)
		{
			return;
		}
		if (other.collection_ != null)
		{
			if (collection_ == null)
			{
				collection_ = new Collection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.DataModel != 0)
		{
			DataModel = other.DataModel;
		}
		if (other.criteria_ != null)
		{
			if (criteria_ == null)
			{
				criteria_ = new Mysqlx.Expr.Expr();
			}
			Criteria.MergeFrom(other.Criteria);
		}
		args_.Add(other.args_);
		order_.Add(other.order_);
		if (other.limit_ != null)
		{
			if (limit_ == null)
			{
				limit_ = new Limit();
			}
			Limit.MergeFrom(other.Limit);
		}
		if (other.limitExpr_ != null)
		{
			if (limitExpr_ == null)
			{
				limitExpr_ = new LimitExpr();
			}
			LimitExpr.MergeFrom(other.LimitExpr);
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
			case 26u:
				if (criteria_ == null)
				{
					criteria_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(criteria_);
				break;
			case 16u:
				dataModel_ = (DataModel)input.ReadEnum();
				break;
			case 10u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage(collection_);
				break;
			case 42u:
				order_.AddEntriesFrom(input, _repeated_order_codec);
				break;
			case 34u:
				if (limit_ == null)
				{
					limit_ = new Limit();
				}
				input.ReadMessage(limit_);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 58u:
				if (limitExpr_ == null)
				{
					limitExpr_ = new LimitExpr();
				}
				input.ReadMessage(limitExpr_);
				break;
			case 50u:
				args_.AddEntriesFrom(input, _repeated_args_codec);
				break;
			}
		}
	}
}
