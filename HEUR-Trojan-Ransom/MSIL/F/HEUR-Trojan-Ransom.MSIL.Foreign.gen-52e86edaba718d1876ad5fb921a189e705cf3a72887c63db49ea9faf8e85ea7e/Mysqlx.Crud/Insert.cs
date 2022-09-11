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

internal sealed class Insert : IMessage, IMessage<Insert>, IEquatable<Insert>, IDeepCloneable<Insert>
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class TypedRow : IMessage, IMessage<TypedRow>, IEquatable<TypedRow>, IDeepCloneable<TypedRow>
		{
			private static readonly MessageParser<TypedRow> messageParser_0;

			private UnknownFieldSet unknownFieldSet_0;

			public const int int_0 = 1;

			private static readonly FieldCodec<Mysqlx.Expr.Expr> fieldCodec_0;

			private readonly RepeatedField<Mysqlx.Expr.Expr> repeatedField_0 = new RepeatedField<Mysqlx.Expr.Expr>();

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<TypedRow> Parser => messageParser_0;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Insert.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public RepeatedField<Mysqlx.Expr.Expr> Field => repeatedField_0;

			[DebuggerNonUserCode]
			public TypedRow()
			{
			}

			[DebuggerNonUserCode]
			public TypedRow(TypedRow other)
				: this()
			{
				repeatedField_0 = other.repeatedField_0.Clone();
				unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
			}

			[DebuggerNonUserCode]
			public TypedRow Clone()
			{
				return new TypedRow(this);
			}

			[DebuggerNonUserCode]
			bool object.Equals(object obj)
			{
				return ((IEquatable<TypedRow>)this).Equals(obj as TypedRow);
			}

			[DebuggerNonUserCode]
			bool IEquatable<TypedRow>.Equals(TypedRow other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (!repeatedField_0.Equals(other.repeatedField_0))
				{
					return false;
				}
				return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
			}

			[DebuggerNonUserCode]
			int object.GetHashCode()
			{
				int num = 1;
				num = 1 ^ repeatedField_0.GetHashCode();
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
				num = 0 + repeatedField_0.CalculateSize(fieldCodec_0);
				if (unknownFieldSet_0 != null)
				{
					num += unknownFieldSet_0.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(TypedRow other)
			{
				if (other != null)
				{
					repeatedField_0.Add(other.repeatedField_0);
					unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
				}
			}

			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
				uint num;
				while ((num = input.ReadTag()) != 0)
				{
					if (num != 10)
					{
						unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
					}
					else
					{
						repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
					}
				}
			}

			static TypedRow()
			{
				Strings.CreateGetStringDelegate(typeof(TypedRow));
				bool bool_ = false;
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397511), getString_0(107397506)).Replace(getString_0(107397469), getString_0(107397464)));
				if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397459)))
				{
					throw new SecurityException(getString_0(107397434));
				}
				messageParser_0 = new MessageParser<TypedRow>(() => new TypedRow());
				fieldCodec_0 = FieldCodec.ForMessage(10u, Mysqlx.Expr.Expr.Parser);
			}

			[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
		}
	}

	private static readonly MessageParser<Insert> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Collection collection_0;

	public const int int_1 = 2;

	private Enum15 enum15_0;

	public const int int_2 = 3;

	private static readonly FieldCodec<Column> fieldCodec_0;

	private readonly RepeatedField<Column> repeatedField_0 = new RepeatedField<Column>();

	public const int int_3 = 4;

	private static readonly FieldCodec<Types.TypedRow> fieldCodec_1;

	private readonly RepeatedField<Types.TypedRow> repeatedField_1 = new RepeatedField<Types.TypedRow>();

	public const int int_4 = 5;

	private static readonly FieldCodec<Scalar> fieldCodec_2;

	private readonly RepeatedField<Scalar> repeatedField_2 = new RepeatedField<Scalar>();

	public const int int_5 = 6;

	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Insert> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[7];

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
	public RepeatedField<Column> Projection => repeatedField_0;

	[DebuggerNonUserCode]
	public RepeatedField<Types.TypedRow> Row => repeatedField_1;

	[DebuggerNonUserCode]
	public RepeatedField<Scalar> Args => repeatedField_2;

	[DebuggerNonUserCode]
	public bool Upsert
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Insert()
	{
	}

	[DebuggerNonUserCode]
	public Insert(Insert other)
		: this()
	{
		Collection = ((other.collection_0 != null) ? other.Collection.Clone() : null);
		enum15_0 = other.enum15_0;
		repeatedField_0 = other.repeatedField_0.Clone();
		repeatedField_1 = other.repeatedField_1.Clone();
		repeatedField_2 = other.repeatedField_2.Clone();
		bool_0 = other.bool_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Insert Clone()
	{
		return new Insert(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Insert>)this).Equals(obj as Insert);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Insert>.Equals(Insert other)
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
		if (!repeatedField_1.Equals(other.repeatedField_1))
		{
			return false;
		}
		if (!repeatedField_2.Equals(other.repeatedField_2))
		{
			return false;
		}
		if (Upsert != other.Upsert)
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
		num ^= repeatedField_1.GetHashCode();
		num ^= repeatedField_2.GetHashCode();
		if (Upsert)
		{
			num ^= Upsert.GetHashCode();
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
			output.WriteRawTag(10);
			output.WriteMessage(Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DataModel);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		repeatedField_1.WriteTo(output, fieldCodec_1);
		repeatedField_2.WriteTo(output, fieldCodec_2);
		if (Upsert)
		{
			output.WriteRawTag(48);
			output.WriteBool(Upsert);
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
		num += repeatedField_1.CalculateSize(fieldCodec_1);
		num += repeatedField_2.CalculateSize(fieldCodec_2);
		if (Upsert)
		{
			num += 2;
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Insert other)
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
		repeatedField_1.Add(other.repeatedField_1);
		repeatedField_2.Add(other.repeatedField_2);
		if (other.Upsert)
		{
			Upsert = other.Upsert;
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
			case 26u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
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
			case 48u:
				Upsert = input.ReadBool();
				break;
			case 42u:
				repeatedField_2.AddEntriesFrom(input, fieldCodec_2);
				break;
			case 34u:
				repeatedField_1.AddEntriesFrom(input, fieldCodec_1);
				break;
			}
		}
	}

	static Insert()
	{
		Strings.CreateGetStringDelegate(typeof(Insert));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397505), getString_0(107397500)).Replace(getString_0(107397463), getString_0(107397458)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397453)))
		{
			throw new SecurityException(getString_0(107397428));
		}
		messageParser_0 = new MessageParser<Insert>(() => new Insert());
		fieldCodec_0 = FieldCodec.ForMessage(26u, Column.Parser);
		fieldCodec_1 = FieldCodec.ForMessage(34u, Types.TypedRow.Parser);
		fieldCodec_2 = FieldCodec.ForMessage(42u, Scalar.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
