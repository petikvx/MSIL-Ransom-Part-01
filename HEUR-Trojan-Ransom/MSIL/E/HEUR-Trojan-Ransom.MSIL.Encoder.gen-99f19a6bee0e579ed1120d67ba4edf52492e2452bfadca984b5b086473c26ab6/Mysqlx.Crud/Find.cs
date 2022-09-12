using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Find : IMessage<Find>, IEquatable<Find>, IDeepCloneable<Find>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum RowLock
		{
			[OriginalName("NONE_RowLock")]
			NoneRowLock,
			[OriginalName("SHARED_LOCK")]
			SharedLock,
			[OriginalName("EXCLUSIVE_LOCK")]
			ExclusiveLock
		}

		internal enum RowLockOptions
		{
			[OriginalName("NONE_RowLockOptions")]
			NoneRowLockOptions,
			[OriginalName("NOWAIT")]
			Nowait,
			[OriginalName("SKIP_LOCKED")]
			SkipLocked
		}
	}

	private static readonly MessageParser<Find> _parser = new MessageParser<Find>(() => new Find());

	private UnknownFieldSet _unknownFields;

	public const int CollectionFieldNumber = 2;

	private Collection collection_;

	public const int DataModelFieldNumber = 3;

	private DataModel dataModel_;

	public const int ProjectionFieldNumber = 4;

	private static readonly FieldCodec<Projection> _repeated_projection_codec = FieldCodec.ForMessage(34u, Mysqlx.Crud.Projection.Parser);

	private readonly RepeatedField<Projection> projection_ = new RepeatedField<Projection>();

	public const int CriteriaFieldNumber = 5;

	private Mysqlx.Expr.Expr criteria_;

	public const int ArgsFieldNumber = 11;

	private static readonly FieldCodec<Scalar> _repeated_args_codec = FieldCodec.ForMessage(90u, Scalar.Parser);

	private readonly RepeatedField<Scalar> args_ = new RepeatedField<Scalar>();

	public const int OrderFieldNumber = 7;

	private static readonly FieldCodec<Order> _repeated_order_codec = FieldCodec.ForMessage(58u, Mysqlx.Crud.Order.Parser);

	private readonly RepeatedField<Order> order_ = new RepeatedField<Order>();

	public const int GroupingFieldNumber = 8;

	private static readonly FieldCodec<Mysqlx.Expr.Expr> _repeated_grouping_codec = FieldCodec.ForMessage(66u, Mysqlx.Expr.Expr.Parser);

	private readonly RepeatedField<Mysqlx.Expr.Expr> grouping_ = new RepeatedField<Mysqlx.Expr.Expr>();

	public const int GroupingCriteriaFieldNumber = 9;

	private Mysqlx.Expr.Expr groupingCriteria_;

	public const int LockingFieldNumber = 12;

	private Types.RowLock locking_;

	public const int LockingOptionsFieldNumber = 13;

	private Types.RowLockOptions lockingOptions_;

	public const int LimitFieldNumber = 6;

	private Limit limit_;

	public const int LimitExprFieldNumber = 14;

	private LimitExpr limitExpr_;

	[DebuggerNonUserCode]
	public static MessageParser<Find> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[7];

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
	public RepeatedField<Projection> Projection => projection_;

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
	public RepeatedField<Mysqlx.Expr.Expr> Grouping => grouping_;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr GroupingCriteria
	{
		get
		{
			return groupingCriteria_;
		}
		set
		{
			groupingCriteria_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.RowLock Locking
	{
		get
		{
			return locking_;
		}
		set
		{
			locking_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.RowLockOptions LockingOptions
	{
		get
		{
			return lockingOptions_;
		}
		set
		{
			lockingOptions_ = value;
		}
	}

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
	public Find()
	{
	}

	[DebuggerNonUserCode]
	public Find(Find other)
		: this()
	{
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		dataModel_ = other.dataModel_;
		projection_ = other.projection_.Clone();
		criteria_ = ((other.criteria_ != null) ? other.criteria_.Clone() : null);
		args_ = other.args_.Clone();
		order_ = other.order_.Clone();
		grouping_ = other.grouping_.Clone();
		groupingCriteria_ = ((other.groupingCriteria_ != null) ? other.groupingCriteria_.Clone() : null);
		locking_ = other.locking_;
		lockingOptions_ = other.lockingOptions_;
		limit_ = ((other.limit_ != null) ? other.limit_.Clone() : null);
		limitExpr_ = ((other.limitExpr_ != null) ? other.limitExpr_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Find Clone()
	{
		return new Find(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Find);
	}

	[DebuggerNonUserCode]
	public bool Equals(Find other)
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
		if (!projection_.Equals(other.projection_))
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
		if (!grouping_.Equals(other.grouping_))
		{
			return false;
		}
		if (!object.Equals(GroupingCriteria, other.GroupingCriteria))
		{
			return false;
		}
		if (Locking != other.Locking)
		{
			return false;
		}
		if (LockingOptions != other.LockingOptions)
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
		num ^= projection_.GetHashCode();
		if (criteria_ != null)
		{
			num ^= Criteria.GetHashCode();
		}
		num ^= args_.GetHashCode();
		num ^= order_.GetHashCode();
		num ^= grouping_.GetHashCode();
		if (groupingCriteria_ != null)
		{
			num ^= GroupingCriteria.GetHashCode();
		}
		if (Locking != 0)
		{
			num ^= Locking.GetHashCode();
		}
		if (LockingOptions != 0)
		{
			num ^= LockingOptions.GetHashCode();
		}
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
			output.WriteRawTag(18);
			output.WriteMessage(Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)DataModel);
		}
		projection_.WriteTo(output, _repeated_projection_codec);
		if (criteria_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Criteria);
		}
		if (limit_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Limit);
		}
		order_.WriteTo(output, _repeated_order_codec);
		grouping_.WriteTo(output, _repeated_grouping_codec);
		if (groupingCriteria_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GroupingCriteria);
		}
		args_.WriteTo(output, _repeated_args_codec);
		if (Locking != 0)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Locking);
		}
		if (LockingOptions != 0)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)LockingOptions);
		}
		if (limitExpr_ != null)
		{
			output.WriteRawTag(114);
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
		num += projection_.CalculateSize(_repeated_projection_codec);
		if (criteria_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Criteria);
		}
		num += args_.CalculateSize(_repeated_args_codec);
		num += order_.CalculateSize(_repeated_order_codec);
		num += grouping_.CalculateSize(_repeated_grouping_codec);
		if (groupingCriteria_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GroupingCriteria);
		}
		if (Locking != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Locking);
		}
		if (LockingOptions != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockingOptions);
		}
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
	public void MergeFrom(Find other)
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
		projection_.Add(other.projection_);
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
		grouping_.Add(other.grouping_);
		if (other.groupingCriteria_ != null)
		{
			if (groupingCriteria_ == null)
			{
				groupingCriteria_ = new Mysqlx.Expr.Expr();
			}
			GroupingCriteria.MergeFrom(other.GroupingCriteria);
		}
		if (other.Locking != 0)
		{
			Locking = other.Locking;
		}
		if (other.LockingOptions != 0)
		{
			LockingOptions = other.LockingOptions;
		}
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
			case 34u:
				projection_.AddEntriesFrom(input, _repeated_projection_codec);
				break;
			case 24u:
				dataModel_ = (DataModel)input.ReadEnum();
				break;
			case 18u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage(collection_);
				break;
			case 58u:
				order_.AddEntriesFrom(input, _repeated_order_codec);
				break;
			case 50u:
				if (limit_ == null)
				{
					limit_ = new Limit();
				}
				input.ReadMessage(limit_);
				break;
			case 42u:
				if (criteria_ == null)
				{
					criteria_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(criteria_);
				break;
			case 90u:
				args_.AddEntriesFrom(input, _repeated_args_codec);
				break;
			case 74u:
				if (groupingCriteria_ == null)
				{
					groupingCriteria_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(groupingCriteria_);
				break;
			case 66u:
				grouping_.AddEntriesFrom(input, _repeated_grouping_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 114u:
				if (limitExpr_ == null)
				{
					limitExpr_ = new LimitExpr();
				}
				input.ReadMessage(limitExpr_);
				break;
			case 104u:
				lockingOptions_ = (Types.RowLockOptions)input.ReadEnum();
				break;
			case 96u:
				locking_ = (Types.RowLock)input.ReadEnum();
				break;
			}
		}
	}
}
