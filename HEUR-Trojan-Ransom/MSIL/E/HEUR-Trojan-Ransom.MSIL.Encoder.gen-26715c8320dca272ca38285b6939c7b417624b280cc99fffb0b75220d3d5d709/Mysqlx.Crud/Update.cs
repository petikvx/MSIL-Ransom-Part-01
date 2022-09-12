using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Update : IMessage<Update>, IEquatable<Update>, IDeepCloneable<Update>, IMessage
{
	private static readonly MessageParser<Update> _parser = new MessageParser<Update>((Func<Update>)(() => new Update()));

	private UnknownFieldSet _unknownFields;

	public const int CollectionFieldNumber = 2;

	private Collection collection_;

	public const int DataModelFieldNumber = 3;

	private DataModel dataModel_;

	public const int CriteriaFieldNumber = 4;

	private Mysqlx.Expr.Expr criteria_;

	public const int ArgsFieldNumber = 8;

	private static readonly FieldCodec<Scalar> _repeated_args_codec = FieldCodec.ForMessage<Scalar>(66u, Scalar.Parser);

	private readonly RepeatedField<Scalar> args_ = new RepeatedField<Scalar>();

	public const int OrderFieldNumber = 6;

	private static readonly FieldCodec<Order> _repeated_order_codec = FieldCodec.ForMessage<Order>(50u, Mysqlx.Crud.Order.Parser);

	private readonly RepeatedField<Order> order_ = new RepeatedField<Order>();

	public const int OperationFieldNumber = 7;

	private static readonly FieldCodec<UpdateOperation> _repeated_operation_codec = FieldCodec.ForMessage<UpdateOperation>(58u, UpdateOperation.Parser);

	private readonly RepeatedField<UpdateOperation> operation_ = new RepeatedField<UpdateOperation>();

	public const int LimitFieldNumber = 5;

	private Limit limit_;

	public const int LimitExprFieldNumber = 9;

	private LimitExpr limitExpr_;

	[DebuggerNonUserCode]
	public static MessageParser<Update> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[9];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

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
	public RepeatedField<UpdateOperation> Operation => operation_;

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
	public Update()
	{
	}

	[DebuggerNonUserCode]
	public Update(Update other)
		: this()
	{
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		dataModel_ = other.dataModel_;
		criteria_ = ((other.criteria_ != null) ? other.criteria_.Clone() : null);
		args_ = other.args_.Clone();
		order_ = other.order_.Clone();
		operation_ = other.operation_.Clone();
		limit_ = ((other.limit_ != null) ? other.limit_.Clone() : null);
		limitExpr_ = ((other.limitExpr_ != null) ? other.limitExpr_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Update Clone()
	{
		return new Update(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Update);
	}

	[DebuggerNonUserCode]
	public bool Equals(Update other)
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
		if (!operation_.Equals(other.operation_))
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
		num ^= ((object)args_).GetHashCode();
		num ^= ((object)order_).GetHashCode();
		num ^= ((object)operation_).GetHashCode();
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
		if (collection_ != null)
		{
			output.WriteRawTag((byte)18);
			output.WriteMessage((IMessage)(object)Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag((byte)24);
			output.WriteEnum((int)DataModel);
		}
		if (criteria_ != null)
		{
			output.WriteRawTag((byte)34);
			output.WriteMessage((IMessage)(object)Criteria);
		}
		if (limit_ != null)
		{
			output.WriteRawTag((byte)42);
			output.WriteMessage((IMessage)(object)Limit);
		}
		order_.WriteTo(output, _repeated_order_codec);
		operation_.WriteTo(output, _repeated_operation_codec);
		args_.WriteTo(output, _repeated_args_codec);
		if (limitExpr_ != null)
		{
			output.WriteRawTag((byte)74);
			output.WriteMessage((IMessage)(object)LimitExpr);
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
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Collection);
		}
		if (DataModel != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DataModel);
		}
		if (criteria_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Criteria);
		}
		num += args_.CalculateSize(_repeated_args_codec);
		num += order_.CalculateSize(_repeated_order_codec);
		num += operation_.CalculateSize(_repeated_operation_codec);
		if (limit_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Limit);
		}
		if (limitExpr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)LimitExpr);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Update other)
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
		args_.Add((IEnumerable<Scalar>)other.args_);
		order_.Add((IEnumerable<Order>)other.order_);
		operation_.Add((IEnumerable<UpdateOperation>)other.operation_);
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
			case 24u:
				dataModel_ = (DataModel)input.ReadEnum();
				break;
			case 18u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage((IMessage)(object)collection_);
				break;
			case 42u:
				if (limit_ == null)
				{
					limit_ = new Limit();
				}
				input.ReadMessage((IMessage)(object)limit_);
				break;
			case 34u:
				if (criteria_ == null)
				{
					criteria_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage((IMessage)(object)criteria_);
				break;
			case 58u:
				operation_.AddEntriesFrom(input, _repeated_operation_codec);
				break;
			case 50u:
				order_.AddEntriesFrom(input, _repeated_order_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 74u:
				if (limitExpr_ == null)
				{
					limitExpr_ = new LimitExpr();
				}
				input.ReadMessage((IMessage)(object)limitExpr_);
				break;
			case 66u:
				args_.AddEntriesFrom(input, _repeated_args_codec);
				break;
			}
		}
	}
}
