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

internal sealed class Delete : IMessage, IMessage<Delete>, IEquatable<Delete>, IDeepCloneable<Delete>
{
	private static readonly MessageParser<Delete> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Collection collection_0;

	public const int int_1 = 2;

	private Enum15 enum15_0;

	public const int int_2 = 3;

	private Mysqlx.Expr.Expr expr_0;

	public const int int_3 = 6;

	private static readonly FieldCodec<Scalar> fieldCodec_0;

	private readonly RepeatedField<Scalar> repeatedField_0 = new RepeatedField<Scalar>();

	public const int int_4 = 4;

	private Limit limit_0;

	public const int int_5 = 5;

	private static readonly FieldCodec<Order> fieldCodec_1;

	private readonly RepeatedField<Order> repeatedField_1 = new RepeatedField<Order>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Delete> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[9];

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
	public RepeatedField<Scalar> Args => repeatedField_0;

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
	public RepeatedField<Order> Order => repeatedField_1;

	[DebuggerNonUserCode]
	public Delete()
	{
	}

	[DebuggerNonUserCode]
	public Delete(Delete other)
		: this()
	{
		Collection = ((other.collection_0 != null) ? other.Collection.Clone() : null);
		enum15_0 = other.enum15_0;
		Criteria = ((other.expr_0 != null) ? other.Criteria.Clone() : null);
		repeatedField_0 = other.repeatedField_0.Clone();
		Limit = ((other.limit_0 != null) ? other.Limit.Clone() : null);
		repeatedField_1 = other.repeatedField_1.Clone();
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Delete Clone()
	{
		return new Delete(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Delete>)this).Equals(obj as Delete);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Delete>.Equals(Delete other)
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
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		if (!object.Equals(Limit, other.Limit))
		{
			return false;
		}
		if (!repeatedField_1.Equals(other.repeatedField_1))
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
		if (expr_0 != null)
		{
			num ^= Criteria.GetHashCode();
		}
		num ^= repeatedField_0.GetHashCode();
		if (limit_0 != null)
		{
			num ^= Limit.GetHashCode();
		}
		num ^= repeatedField_1.GetHashCode();
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
			output.WriteRawTag(10);
			output.WriteMessage(Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DataModel);
		}
		if (expr_0 != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Criteria);
		}
		if (limit_0 != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Limit);
		}
		repeatedField_1.WriteTo(output, fieldCodec_1);
		repeatedField_0.WriteTo(output, fieldCodec_0);
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
		if (expr_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Criteria);
		}
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (limit_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Limit);
		}
		num += repeatedField_1.CalculateSize(fieldCodec_1);
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
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
		if (other.expr_0 != null)
		{
			if (expr_0 == null)
			{
				expr_0 = new Mysqlx.Expr.Expr();
			}
			Criteria.MergeFrom(other.Criteria);
		}
		repeatedField_0.Add(other.repeatedField_0);
		if (other.limit_0 != null)
		{
			if (limit_0 == null)
			{
				limit_0 = new Limit();
			}
			Limit.MergeFrom(other.Limit);
		}
		repeatedField_1.Add(other.repeatedField_1);
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
			case 26u:
				if (expr_0 == null)
				{
					expr_0 = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(expr_0);
				break;
			case 16u:
				enum15_0 = (Enum15)input.ReadEnum();
				break;
			case 10u:
				if (collection_0 == null)
				{
					collection_0 = new Collection();
				}
				input.ReadMessage(collection_0);
				break;
			default:
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 50u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 42u:
				repeatedField_1.AddEntriesFrom(input, fieldCodec_1);
				break;
			case 34u:
				if (limit_0 == null)
				{
					limit_0 = new Limit();
				}
				input.ReadMessage(limit_0);
				break;
			}
		}
	}

	static Delete()
	{
		Strings.CreateGetStringDelegate(typeof(Delete));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397550), getString_0(107397545)).Replace(getString_0(107397508), getString_0(107397503)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397498)))
		{
			throw new SecurityException(getString_0(107397473));
		}
		messageParser_0 = new MessageParser<Delete>(() => new Delete());
		fieldCodec_0 = FieldCodec.ForMessage(50u, Scalar.Parser);
		fieldCodec_1 = FieldCodec.ForMessage(42u, Mysqlx.Crud.Order.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
