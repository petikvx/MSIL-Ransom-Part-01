using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns16;
using ns2;

namespace Mysqlx.Crud;

internal sealed class Find : IMessage, IMessage<Find>, IEquatable<Find>, IDeepCloneable<Find>
{
	[DebuggerNonUserCode]
	internal static class Class35
	{
		internal enum Enum21
		{
			[OriginalName("NONE_RowLock")]
			const_0,
			[OriginalName("SHARED_LOCK")]
			const_1,
			[OriginalName("EXCLUSIVE_LOCK")]
			const_2
		}

		internal enum Enum22
		{
			[OriginalName("NONE_RowLockOptions")]
			const_0,
			[OriginalName("NOWAIT")]
			const_1,
			[OriginalName("SKIP_LOCKED")]
			const_2
		}
	}

	private static readonly MessageParser<Find> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 2;

	private Collection collection_0;

	public const int int_1 = 3;

	private Enum15 enum15_0;

	public const int int_2 = 4;

	private static readonly FieldCodec<Projection> fieldCodec_0;

	private readonly RepeatedField<Projection> repeatedField_0 = new RepeatedField<Projection>();

	public const int int_3 = 5;

	private Mysqlx.Expr.Expr expr_0;

	public const int int_4 = 11;

	private static readonly FieldCodec<Scalar> fieldCodec_1;

	private readonly RepeatedField<Scalar> repeatedField_1 = new RepeatedField<Scalar>();

	public const int int_5 = 6;

	private Limit limit_0;

	public const int int_6 = 7;

	private static readonly FieldCodec<Order> fieldCodec_2;

	private readonly RepeatedField<Order> repeatedField_2 = new RepeatedField<Order>();

	public const int int_7 = 8;

	private static readonly FieldCodec<Mysqlx.Expr.Expr> fieldCodec_3;

	private readonly RepeatedField<Mysqlx.Expr.Expr> repeatedField_3 = new RepeatedField<Mysqlx.Expr.Expr>();

	public const int int_8 = 9;

	private Mysqlx.Expr.Expr expr_1;

	public const int int_9 = 12;

	private Class35.Enum21 enum21_0;

	public const int int_10 = 13;

	private Class35.Enum22 enum22_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Find> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[6];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Collection Collection
	{
		get
		{
			return collection_0;
		}
		set
		{
			collection_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Enum15 DataModel
	{
		get
		{
			return enum15_0;
		}
		set
		{
			enum15_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Projection> Projection => repeatedField_0;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Criteria
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
	public RepeatedField<Scalar> Args => repeatedField_1;

	[DebuggerNonUserCode]
	public Limit Limit
	{
		get
		{
			return limit_0;
		}
		set
		{
			limit_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Order> Order => repeatedField_2;

	[DebuggerNonUserCode]
	public RepeatedField<Mysqlx.Expr.Expr> Grouping => repeatedField_3;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr GroupingCriteria
	{
		get
		{
			return expr_1;
		}
		set
		{
			expr_1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Class35.Enum21 Locking
	{
		get
		{
			return enum21_0;
		}
		set
		{
			enum21_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Class35.Enum22 LockingOptions
	{
		get
		{
			return enum22_0;
		}
		set
		{
			enum22_0 = value;
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
		Collection = ((other.collection_0 != null) ? other.Collection.Clone() : null);
		enum15_0 = other.enum15_0;
		repeatedField_0 = other.repeatedField_0.Clone();
		Criteria = ((other.expr_0 != null) ? other.Criteria.Clone() : null);
		repeatedField_1 = other.repeatedField_1.Clone();
		Limit = ((other.limit_0 != null) ? other.Limit.Clone() : null);
		repeatedField_2 = other.repeatedField_2.Clone();
		repeatedField_3 = other.repeatedField_3.Clone();
		GroupingCriteria = ((other.expr_1 != null) ? other.GroupingCriteria.Clone() : null);
		enum21_0 = other.enum21_0;
		enum22_0 = other.enum22_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Find Clone()
	{
		return new Find(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Find>)this).Equals(obj as Find);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Find>.Equals(Find other)
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
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		if (!object.Equals(Criteria, other.Criteria))
		{
			return false;
		}
		if (!repeatedField_1.Equals(other.repeatedField_1))
		{
			return false;
		}
		if (!object.Equals(Limit, other.Limit))
		{
			return false;
		}
		if (!repeatedField_2.Equals(other.repeatedField_2))
		{
			return false;
		}
		if (!repeatedField_3.Equals(other.repeatedField_3))
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
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (collection_0 != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (DataModel != 0)
		{
			num ^= DataModel.GetHashCode();
		}
		num ^= repeatedField_0.GetHashCode();
		if (expr_0 != null)
		{
			num ^= Criteria.GetHashCode();
		}
		num ^= repeatedField_1.GetHashCode();
		if (limit_0 != null)
		{
			num ^= Limit.GetHashCode();
		}
		num ^= repeatedField_2.GetHashCode();
		num ^= repeatedField_3.GetHashCode();
		if (expr_1 != null)
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
		if (collection_0 != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)DataModel);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		if (expr_0 != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Criteria);
		}
		if (limit_0 != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Limit);
		}
		repeatedField_2.WriteTo(output, fieldCodec_2);
		repeatedField_3.WriteTo(output, fieldCodec_3);
		if (expr_1 != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GroupingCriteria);
		}
		repeatedField_1.WriteTo(output, fieldCodec_1);
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
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (collection_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (DataModel != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DataModel);
		}
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (expr_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Criteria);
		}
		num += repeatedField_1.CalculateSize(fieldCodec_1);
		if (limit_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Limit);
		}
		num += repeatedField_2.CalculateSize(fieldCodec_2);
		num += repeatedField_3.CalculateSize(fieldCodec_3);
		if (expr_1 != null)
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
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
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
		if (other.collection_0 != null)
		{
			if (collection_0 == null)
			{
				collection_0 = new Collection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.DataModel != 0)
		{
			DataModel = other.DataModel;
		}
		repeatedField_0.Add(other.repeatedField_0);
		if (other.expr_0 != null)
		{
			if (expr_0 == null)
			{
				expr_0 = new Mysqlx.Expr.Expr();
			}
			Criteria.MergeFrom(other.Criteria);
		}
		repeatedField_1.Add(other.repeatedField_1);
		if (other.limit_0 != null)
		{
			if (limit_0 == null)
			{
				limit_0 = new Limit();
			}
			Limit.MergeFrom(other.Limit);
		}
		repeatedField_2.Add(other.repeatedField_2);
		repeatedField_3.Add(other.repeatedField_3);
		if (other.expr_1 != null)
		{
			if (expr_1 == null)
			{
				expr_1 = new Mysqlx.Expr.Expr();
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
			case 24u:
				enum15_0 = (Enum15)input.ReadEnum();
				break;
			case 18u:
				if (collection_0 == null)
				{
					collection_0 = new Collection();
				}
				input.ReadMessage(collection_0);
				break;
			case 50u:
				if (limit_0 == null)
				{
					limit_0 = new Limit();
				}
				input.ReadMessage(limit_0);
				break;
			case 42u:
				if (expr_0 == null)
				{
					expr_0 = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(expr_0);
				break;
			case 34u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 74u:
				if (expr_1 == null)
				{
					expr_1 = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(expr_1);
				break;
			case 66u:
				repeatedField_3.AddEntriesFrom(input, fieldCodec_3);
				break;
			case 58u:
				repeatedField_2.AddEntriesFrom(input, fieldCodec_2);
				break;
			default:
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 104u:
				enum22_0 = (Class35.Enum22)input.ReadEnum();
				break;
			case 96u:
				enum21_0 = (Class35.Enum21)input.ReadEnum();
				break;
			case 90u:
				repeatedField_1.AddEntriesFrom(input, fieldCodec_1);
				break;
			}
		}
	}

	static Find()
	{
		Strings.CreateGetStringDelegate(typeof(Find));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397478), getString_0(107397473)).Replace(getString_0(107397436), getString_0(107397431)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397426)))
		{
			throw new SecurityException(getString_0(107397401));
		}
		messageParser_0 = new MessageParser<Find>(() => new Find());
		fieldCodec_0 = FieldCodec.ForMessage(34u, Mysqlx.Crud.Projection.Parser);
		fieldCodec_1 = FieldCodec.ForMessage(90u, Scalar.Parser);
		fieldCodec_2 = FieldCodec.ForMessage(58u, Mysqlx.Crud.Order.Parser);
		fieldCodec_3 = FieldCodec.ForMessage(66u, Mysqlx.Expr.Expr.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
