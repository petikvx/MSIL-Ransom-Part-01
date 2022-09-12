using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Crud;
using Mysqlx.Sql;

namespace Mysqlx.Prepare;

internal sealed class Prepare : IMessage<Prepare>, IEquatable<Prepare>, IDeepCloneable<Prepare>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		public sealed class OneOfMessage : IMessage<OneOfMessage>, IEquatable<OneOfMessage>, IDeepCloneable<OneOfMessage>, IMessage
		{
			public enum TypePresentOneofCase
			{
				None,
				Type
			}

			[DebuggerNonUserCode]
			public static class Types
			{
				public enum Type
				{
					[OriginalName("FIND")]
					Find = 0,
					[OriginalName("INSERT")]
					Insert = 1,
					[OriginalName("UPDATE")]
					Update = 2,
					[OriginalName("DELETE")]
					Delete = 4,
					[OriginalName("STMT")]
					Stmt = 5
				}
			}

			private static readonly MessageParser<OneOfMessage> _parser = new MessageParser<OneOfMessage>((Func<OneOfMessage>)(() => new OneOfMessage()));

			private UnknownFieldSet _unknownFields;

			public const int TypeFieldNumber = 1;

			public const int FindFieldNumber = 2;

			private Find find_;

			public const int InsertFieldNumber = 3;

			private Insert insert_;

			public const int UpdateFieldNumber = 4;

			private Update update_;

			public const int DeleteFieldNumber = 5;

			private Delete delete_;

			public const int StmtExecuteFieldNumber = 6;

			private StmtExecute stmtExecute_;

			private object typePresent_;

			private TypePresentOneofCase typePresentCase_;

			[DebuggerNonUserCode]
			public static MessageParser<OneOfMessage> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Prepare.Descriptor.get_NestedTypes()[0];

			[DebuggerNonUserCode]
			MessageDescriptor Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public Types.Type Type
			{
				get
				{
					if (typePresentCase_ != TypePresentOneofCase.Type)
					{
						return Types.Type.Find;
					}
					return (Types.Type)typePresent_;
				}
				set
				{
					typePresent_ = value;
					typePresentCase_ = TypePresentOneofCase.Type;
				}
			}

			[DebuggerNonUserCode]
			public Find Find
			{
				get
				{
					return find_;
				}
				set
				{
					find_ = value;
				}
			}

			[DebuggerNonUserCode]
			public Insert Insert
			{
				get
				{
					return insert_;
				}
				set
				{
					insert_ = value;
				}
			}

			[DebuggerNonUserCode]
			public Update Update
			{
				get
				{
					return update_;
				}
				set
				{
					update_ = value;
				}
			}

			[DebuggerNonUserCode]
			public Delete Delete
			{
				get
				{
					return delete_;
				}
				set
				{
					delete_ = value;
				}
			}

			[DebuggerNonUserCode]
			public StmtExecute StmtExecute
			{
				get
				{
					return stmtExecute_;
				}
				set
				{
					stmtExecute_ = value;
				}
			}

			[DebuggerNonUserCode]
			public TypePresentOneofCase TypePresentCase => typePresentCase_;

			[DebuggerNonUserCode]
			public OneOfMessage()
			{
			}

			[DebuggerNonUserCode]
			public OneOfMessage(OneOfMessage other)
				: this()
			{
				find_ = ((other.find_ != null) ? other.find_.Clone() : null);
				insert_ = ((other.insert_ != null) ? other.insert_.Clone() : null);
				update_ = ((other.update_ != null) ? other.update_.Clone() : null);
				delete_ = ((other.delete_ != null) ? other.delete_.Clone() : null);
				stmtExecute_ = ((other.stmtExecute_ != null) ? other.stmtExecute_.Clone() : null);
				if (other.TypePresentCase == TypePresentOneofCase.Type)
				{
					Type = other.Type;
				}
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public OneOfMessage Clone()
			{
				return new OneOfMessage(this);
			}

			[DebuggerNonUserCode]
			public void ClearTypePresent()
			{
				typePresentCase_ = TypePresentOneofCase.None;
				typePresent_ = null;
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as OneOfMessage);
			}

			[DebuggerNonUserCode]
			public bool Equals(OneOfMessage other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Type != other.Type)
				{
					return false;
				}
				if (!object.Equals(Find, other.Find))
				{
					return false;
				}
				if (!object.Equals(Insert, other.Insert))
				{
					return false;
				}
				if (!object.Equals(Update, other.Update))
				{
					return false;
				}
				if (!object.Equals(Delete, other.Delete))
				{
					return false;
				}
				if (!object.Equals(StmtExecute, other.StmtExecute))
				{
					return false;
				}
				if (TypePresentCase != other.TypePresentCase)
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				if (typePresentCase_ == TypePresentOneofCase.Type)
				{
					num ^= Type.GetHashCode();
				}
				if (find_ != null)
				{
					num ^= Find.GetHashCode();
				}
				if (insert_ != null)
				{
					num ^= Insert.GetHashCode();
				}
				if (update_ != null)
				{
					num ^= Update.GetHashCode();
				}
				if (delete_ != null)
				{
					num ^= Delete.GetHashCode();
				}
				if (stmtExecute_ != null)
				{
					num ^= StmtExecute.GetHashCode();
				}
				num ^= (int)typePresentCase_;
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
				if (typePresentCase_ == TypePresentOneofCase.Type)
				{
					output.WriteRawTag((byte)8);
					output.WriteEnum((int)Type);
				}
				if (find_ != null)
				{
					output.WriteRawTag((byte)18);
					output.WriteMessage((IMessage)(object)Find);
				}
				if (insert_ != null)
				{
					output.WriteRawTag((byte)26);
					output.WriteMessage((IMessage)(object)Insert);
				}
				if (update_ != null)
				{
					output.WriteRawTag((byte)34);
					output.WriteMessage((IMessage)(object)Update);
				}
				if (delete_ != null)
				{
					output.WriteRawTag((byte)42);
					output.WriteMessage((IMessage)(object)Delete);
				}
				if (stmtExecute_ != null)
				{
					output.WriteRawTag((byte)50);
					output.WriteMessage((IMessage)(object)StmtExecute);
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
				if (typePresentCase_ == TypePresentOneofCase.Type)
				{
					num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
				}
				if (find_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Find);
				}
				if (insert_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Insert);
				}
				if (update_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Update);
				}
				if (delete_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Delete);
				}
				if (stmtExecute_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)StmtExecute);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(OneOfMessage other)
			{
				if (other == null)
				{
					return;
				}
				if (other.find_ != null)
				{
					if (find_ == null)
					{
						find_ = new Find();
					}
					Find.MergeFrom(other.Find);
				}
				if (other.insert_ != null)
				{
					if (insert_ == null)
					{
						insert_ = new Insert();
					}
					Insert.MergeFrom(other.Insert);
				}
				if (other.update_ != null)
				{
					if (update_ == null)
					{
						update_ = new Update();
					}
					Update.MergeFrom(other.Update);
				}
				if (other.delete_ != null)
				{
					if (delete_ == null)
					{
						delete_ = new Delete();
					}
					Delete.MergeFrom(other.Delete);
				}
				if (other.stmtExecute_ != null)
				{
					if (stmtExecute_ == null)
					{
						stmtExecute_ = new StmtExecute();
					}
					StmtExecute.MergeFrom(other.StmtExecute);
				}
				if (other.TypePresentCase == TypePresentOneofCase.Type)
				{
					Type = other.Type;
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
						if (insert_ == null)
						{
							insert_ = new Insert();
						}
						input.ReadMessage((IMessage)(object)insert_);
						break;
					case 18u:
						if (find_ == null)
						{
							find_ = new Find();
						}
						input.ReadMessage((IMessage)(object)find_);
						break;
					case 8u:
						typePresent_ = input.ReadEnum();
						typePresentCase_ = TypePresentOneofCase.Type;
						break;
					default:
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
						break;
					case 50u:
						if (stmtExecute_ == null)
						{
							stmtExecute_ = new StmtExecute();
						}
						input.ReadMessage((IMessage)(object)stmtExecute_);
						break;
					case 42u:
						if (delete_ == null)
						{
							delete_ = new Delete();
						}
						input.ReadMessage((IMessage)(object)delete_);
						break;
					case 34u:
						if (update_ == null)
						{
							update_ = new Update();
						}
						input.ReadMessage((IMessage)(object)update_);
						break;
					}
				}
			}
		}
	}

	private static readonly MessageParser<Prepare> _parser = new MessageParser<Prepare>((Func<Prepare>)(() => new Prepare()));

	private UnknownFieldSet _unknownFields;

	public const int StmtIdFieldNumber = 1;

	private uint stmtId_;

	public const int StmtFieldNumber = 2;

	private Types.OneOfMessage stmt_;

	[DebuggerNonUserCode]
	public static MessageParser<Prepare> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxPrepareReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint StmtId
	{
		get
		{
			return stmtId_;
		}
		set
		{
			stmtId_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.OneOfMessage Stmt
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
	public Prepare()
	{
	}

	[DebuggerNonUserCode]
	public Prepare(Prepare other)
		: this()
	{
		stmtId_ = other.stmtId_;
		stmt_ = ((other.stmt_ != null) ? other.stmt_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Prepare Clone()
	{
		return new Prepare(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Prepare);
	}

	[DebuggerNonUserCode]
	public bool Equals(Prepare other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StmtId != other.StmtId)
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
		if (StmtId != 0)
		{
			num ^= StmtId.GetHashCode();
		}
		if (stmt_ != null)
		{
			num ^= Stmt.GetHashCode();
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
		if (StmtId != 0)
		{
			output.WriteRawTag((byte)8);
			output.WriteUInt32(StmtId);
		}
		if (stmt_ != null)
		{
			output.WriteRawTag((byte)18);
			output.WriteMessage((IMessage)(object)Stmt);
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
		if (StmtId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StmtId);
		}
		if (stmt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Stmt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Prepare other)
	{
		if (other == null)
		{
			return;
		}
		if (other.StmtId != 0)
		{
			StmtId = other.StmtId;
		}
		if (other.stmt_ != null)
		{
			if (stmt_ == null)
			{
				stmt_ = new Types.OneOfMessage();
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 18u:
				if (stmt_ == null)
				{
					stmt_ = new Types.OneOfMessage();
				}
				input.ReadMessage((IMessage)(object)stmt_);
				break;
			case 8u:
				StmtId = input.ReadUInt32();
				break;
			}
		}
	}
}
