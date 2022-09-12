using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal sealed class ModifyView : IMessage<ModifyView>, IEquatable<ModifyView>, IDeepCloneable<ModifyView>, IMessage
{
	private static readonly MessageParser<ModifyView> _parser = new MessageParser<ModifyView>(() => new ModifyView());

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

	[DebuggerNonUserCode]
	public static MessageParser<ModifyView> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[12];

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
	public string Definer
	{
		get
		{
			return definer_;
		}
		set
		{
			definer_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public ModifyView()
	{
	}

	[DebuggerNonUserCode]
	public ModifyView(ModifyView other)
		: this()
	{
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		definer_ = other.definer_;
		algorithm_ = other.algorithm_;
		security_ = other.security_;
		check_ = other.check_;
		column_ = other.column_.Clone();
		stmt_ = ((other.stmt_ != null) ? other.stmt_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public ModifyView Clone()
	{
		return new ModifyView(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ModifyView);
	}

	[DebuggerNonUserCode]
	public bool Equals(ModifyView other)
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
		num ^= column_.GetHashCode();
		if (stmt_ != null)
		{
			num ^= Stmt.GetHashCode();
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
		if (Definer.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Definer);
		}
		if (Algorithm != 0)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Algorithm);
		}
		if (Security != 0)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Security);
		}
		if (Check != 0)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Check);
		}
		column_.WriteTo(output, _repeated_column_codec);
		if (stmt_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Stmt);
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
			num += 1 + CodedOutputStream.ComputeMessageSize(Stmt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(ModifyView other)
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
		column_.Add(other.column_);
		if (other.stmt_ != null)
		{
			if (stmt_ == null)
			{
				stmt_ = new Find();
			}
			Stmt.MergeFrom(other.Stmt);
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
				algorithm_ = (ViewAlgorithm)input.ReadEnum();
				break;
			case 18u:
				Definer = input.ReadString();
				break;
			case 10u:
				if (collection_ == null)
				{
					collection_ = new Collection();
				}
				input.ReadMessage(collection_);
				break;
			case 40u:
				check_ = (ViewCheckOption)input.ReadEnum();
				break;
			case 32u:
				security_ = (ViewSqlSecurity)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 58u:
				if (stmt_ == null)
				{
					stmt_ = new Find();
				}
				input.ReadMessage(stmt_);
				break;
			case 50u:
				column_.AddEntriesFrom(input, _repeated_column_codec);
				break;
			}
		}
	}
}
