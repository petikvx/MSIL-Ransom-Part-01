using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal sealed class CreateView : IMessage<CreateView>, IEquatable<CreateView>, IDeepCloneable<CreateView>, IMessage
{
	private static readonly MessageParser<CreateView> _parser = new MessageParser<CreateView>((Func<CreateView>)(() => new CreateView()));

	private UnknownFieldSet _unknownFields;

	public const int CollectionFieldNumber = 1;

	private Collection collection_;

	public const int DefinerFieldNumber = 2;

	private string definer_ = "";

	public const int AlgorithmFieldNumber = 3;

	private ViewAlgorithm algorithm_;

	public const int SecurityFieldNumber = 4;

	private ViewSqlSecurity security_;

	public const int CheckFieldNumber = 5;

	private ViewCheckOption check_;

	public const int ColumnFieldNumber = 6;

	private static readonly FieldCodec<string> _repeated_column_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> column_ = new RepeatedField<string>();

	public const int StmtFieldNumber = 7;

	private Find stmt_;

	public const int ReplaceExistingFieldNumber = 8;

	private bool replaceExisting_;

	[DebuggerNonUserCode]
	public static MessageParser<CreateView> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[11];

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
	public string Definer
	{
		get
		{
			return definer_;
		}
		set
		{
			definer_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ViewAlgorithm Algorithm
	{
		get
		{
			return algorithm_;
		}
		set
		{
			algorithm_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ViewSqlSecurity Security
	{
		get
		{
			return security_;
		}
		set
		{
			security_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ViewCheckOption Check
	{
		get
		{
			return check_;
		}
		set
		{
			check_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<string> Column => column_;

	[DebuggerNonUserCode]
	public Find Stmt
	{
		get
		{
			return stmt_;
		}
		set
		{
			stmt_ = value;
		}
	}

	[DebuggerNonUserCode]
	public bool ReplaceExisting
	{
		get
		{
			return replaceExisting_;
		}
		set
		{
			replaceExisting_ = value;
		}
	}

	[DebuggerNonUserCode]
	public CreateView()
	{
	}

	[DebuggerNonUserCode]
	public CreateView(CreateView other)
		: this()
	{
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		definer_ = other.definer_;
		algorithm_ = other.algorithm_;
		security_ = other.security_;
		check_ = other.check_;
		column_ = other.column_.Clone();
		stmt_ = ((other.stmt_ != null) ? other.stmt_.Clone() : null);
		replaceExisting_ = other.replaceExisting_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public CreateView Clone()
	{
		return new CreateView(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CreateView);
	}

	[DebuggerNonUserCode]
	public bool Equals(CreateView other)
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
		if (Definer != other.Definer)
		{
			return false;
		}
		if (Algorithm != other.Algorithm)
		{
			return false;
		}
		if (Security != other.Security)
		{
			return false;
		}
		if (Check != other.Check)
		{
			return false;
		}
		if (!column_.Equals(other.column_))
		{
			return false;
		}
		if (!object.Equals(Stmt, other.Stmt))
		{
			return false;
		}
		if (ReplaceExisting != other.ReplaceExisting)
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
		if (Definer.Length != 0)
		{
			num ^= Definer.GetHashCode();
		}
		if (Algorithm != 0)
		{
			num ^= Algorithm.GetHashCode();
		}
		if (Security != 0)
		{
			num ^= Security.GetHashCode();
		}
		if (Check != 0)
		{
			num ^= Check.GetHashCode();
		}
		num ^= ((object)column_).GetHashCode();
		if (stmt_ != null)
		{
			num ^= Stmt.GetHashCode();
		}
		if (ReplaceExisting)
		{
			num ^= ReplaceExisting.GetHashCode();
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
		if (Definer.Length != 0)
		{
			output.WriteRawTag((byte)18);
			output.WriteString(Definer);
		}
		if (Algorithm != 0)
		{
			output.WriteRawTag((byte)24);
			output.WriteEnum((int)Algorithm);
		}
		if (Security != 0)
		{
			output.WriteRawTag((byte)32);
			output.WriteEnum((int)Security);
		}
		if (Check != 0)
		{
			output.WriteRawTag((byte)40);
			output.WriteEnum((int)Check);
		}
		column_.WriteTo(output, _repeated_column_codec);
		if (stmt_ != null)
		{
			output.WriteRawTag((byte)58);
			output.WriteMessage((IMessage)(object)Stmt);
		}
		if (ReplaceExisting)
		{
			output.WriteRawTag((byte)64);
			output.WriteBool(ReplaceExisting);
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
		if (Definer.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Definer);
		}
		if (Algorithm != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Algorithm);
		}
		if (Security != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Security);
		}
		if (Check != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Check);
		}
		num += column_.CalculateSize(_repeated_column_codec);
		if (stmt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Stmt);
		}
		if (ReplaceExisting)
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
	public void MergeFrom(CreateView other)
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
		if (other.Definer.Length != 0)
		{
			Definer = other.Definer;
		}
		if (other.Algorithm != 0)
		{
			Algorithm = other.Algorithm;
		}
		if (other.Security != 0)
		{
			Security = other.Security;
		}
		if (other.Check != 0)
		{
			Check = other.Check;
		}
		column_.Add((IEnumerable<string>)other.column_);
		if (other.stmt_ != null)
		{
			if (stmt_ == null)
			{
				stmt_ = new Find();
			}
			Stmt.MergeFrom(other.Stmt);
		}
		if (other.ReplaceExisting)
		{
			ReplaceExisting = other.ReplaceExisting;
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
				Definer = input.ReadString();
				break;
			case 10u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage((IMessage)(object)collection_);
				break;
			case 32u:
				security_ = (ViewSqlSecurity)input.ReadEnum();
				break;
			case 24u:
				algorithm_ = (ViewAlgorithm)input.ReadEnum();
				break;
			case 50u:
				column_.AddEntriesFrom(input, _repeated_column_codec);
				break;
			case 40u:
				check_ = (ViewCheckOption)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 64u:
				ReplaceExisting = input.ReadBool();
				break;
			case 58u:
				if (stmt_ == null)
				{
					stmt_ = new Find();
				}
				input.ReadMessage((IMessage)(object)stmt_);
				break;
			}
		}
	}
}
