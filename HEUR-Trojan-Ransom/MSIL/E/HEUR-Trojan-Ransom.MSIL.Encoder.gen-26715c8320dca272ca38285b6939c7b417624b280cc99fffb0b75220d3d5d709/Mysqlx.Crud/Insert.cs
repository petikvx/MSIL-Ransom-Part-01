using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Insert : IMessage<Insert>, IEquatable<Insert>, IDeepCloneable<Insert>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class TypedRow : IMessage<TypedRow>, IEquatable<TypedRow>, IDeepCloneable<TypedRow>, IMessage
		{
			private static readonly MessageParser<TypedRow> _parser = new MessageParser<TypedRow>((Func<TypedRow>)(() => new TypedRow()));

			private UnknownFieldSet _unknownFields;

			public const int FieldFieldNumber = 1;

			private static readonly FieldCodec<Mysqlx.Expr.Expr> _repeated_field_codec = FieldCodec.ForMessage<Mysqlx.Expr.Expr>(10u, Mysqlx.Expr.Expr.Parser);

			private readonly RepeatedField<Mysqlx.Expr.Expr> field_ = new RepeatedField<Mysqlx.Expr.Expr>();

			[DebuggerNonUserCode]
			public static MessageParser<TypedRow> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Insert.Descriptor.get_NestedTypes()[0];

			[DebuggerNonUserCode]
			MessageDescriptor Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public RepeatedField<Mysqlx.Expr.Expr> Field => field_;

			[DebuggerNonUserCode]
			public TypedRow()
			{
			}

			[DebuggerNonUserCode]
			public TypedRow(TypedRow other)
				: this()
			{
				field_ = other.field_.Clone();
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public TypedRow Clone()
			{
				return new TypedRow(this);
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as TypedRow);
			}

			[DebuggerNonUserCode]
			public bool Equals(TypedRow other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (!field_.Equals(other.field_))
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				num = 1 ^ ((object)field_).GetHashCode();
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
				field_.WriteTo(output, _repeated_field_codec);
				if (_unknownFields != null)
				{
					_unknownFields.WriteTo(output);
				}
			}

			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				num = 0 + field_.CalculateSize(_repeated_field_codec);
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(TypedRow other)
			{
				if (other != null)
				{
					field_.Add((IEnumerable<Mysqlx.Expr.Expr>)other.field_);
					_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
					}
					else
					{
						field_.AddEntriesFrom(input, _repeated_field_codec);
					}
				}
			}
		}
	}

	private static readonly MessageParser<Insert> _parser = new MessageParser<Insert>((Func<Insert>)(() => new Insert()));

	private UnknownFieldSet _unknownFields;

	public const int CollectionFieldNumber = 1;

	private Collection collection_;

	public const int DataModelFieldNumber = 2;

	private DataModel dataModel_;

	public const int ProjectionFieldNumber = 3;

	private static readonly FieldCodec<Column> _repeated_projection_codec = FieldCodec.ForMessage<Column>(26u, Column.Parser);

	private readonly RepeatedField<Column> projection_ = new RepeatedField<Column>();

	public const int RowFieldNumber = 4;

	private static readonly FieldCodec<Types.TypedRow> _repeated_row_codec = FieldCodec.ForMessage<Types.TypedRow>(34u, Types.TypedRow.Parser);

	private readonly RepeatedField<Types.TypedRow> row_ = new RepeatedField<Types.TypedRow>();

	public const int ArgsFieldNumber = 5;

	private static readonly FieldCodec<Scalar> _repeated_args_codec = FieldCodec.ForMessage<Scalar>(42u, Scalar.Parser);

	private readonly RepeatedField<Scalar> args_ = new RepeatedField<Scalar>();

	public const int UpsertFieldNumber = 6;

	private bool upsert_;

	[DebuggerNonUserCode]
	public static MessageParser<Insert> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[8];

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
	public RepeatedField<Column> Projection => projection_;

	[DebuggerNonUserCode]
	public RepeatedField<Types.TypedRow> Row => row_;

	[DebuggerNonUserCode]
	public RepeatedField<Scalar> Args => args_;

	[DebuggerNonUserCode]
	public bool Upsert
	{
		get
		{
			return upsert_;
		}
		set
		{
			upsert_ = value;
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
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		dataModel_ = other.dataModel_;
		projection_ = other.projection_.Clone();
		row_ = other.row_.Clone();
		args_ = other.args_.Clone();
		upsert_ = other.upsert_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Insert Clone()
	{
		return new Insert(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Insert);
	}

	[DebuggerNonUserCode]
	public bool Equals(Insert other)
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
		if (!row_.Equals(other.row_))
		{
			return false;
		}
		if (!args_.Equals(other.args_))
		{
			return false;
		}
		if (Upsert != other.Upsert)
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
		num ^= ((object)projection_).GetHashCode();
		num ^= ((object)row_).GetHashCode();
		num ^= ((object)args_).GetHashCode();
		if (Upsert)
		{
			num ^= Upsert.GetHashCode();
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
			output.WriteRawTag((byte)10);
			output.WriteMessage((IMessage)(object)Collection);
		}
		if (DataModel != 0)
		{
			output.WriteRawTag((byte)16);
			output.WriteEnum((int)DataModel);
		}
		projection_.WriteTo(output, _repeated_projection_codec);
		row_.WriteTo(output, _repeated_row_codec);
		args_.WriteTo(output, _repeated_args_codec);
		if (Upsert)
		{
			output.WriteRawTag((byte)48);
			output.WriteBool(Upsert);
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
		num += projection_.CalculateSize(_repeated_projection_codec);
		num += row_.CalculateSize(_repeated_row_codec);
		num += args_.CalculateSize(_repeated_args_codec);
		if (Upsert)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
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
		projection_.Add((IEnumerable<Column>)other.projection_);
		row_.Add((IEnumerable<Types.TypedRow>)other.row_);
		args_.Add((IEnumerable<Scalar>)other.args_);
		if (other.Upsert)
		{
			Upsert = other.Upsert;
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
				projection_.AddEntriesFrom(input, _repeated_projection_codec);
				break;
			case 16u:
				dataModel_ = (DataModel)input.ReadEnum();
				break;
			case 10u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage((IMessage)(object)collection_);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 48u:
				Upsert = input.ReadBool();
				break;
			case 42u:
				args_.AddEntriesFrom(input, _repeated_args_codec);
				break;
			case 34u:
				row_.AddEntriesFrom(input, _repeated_row_codec);
				break;
			}
		}
	}
}
