using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Prepare;

namespace Mysqlx.Cursor;

internal sealed class Open : IMessage<Open>, IEquatable<Open>, IDeepCloneable<Open>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class OneOfMessage : IMessage<OneOfMessage>, IEquatable<OneOfMessage>, IDeepCloneable<OneOfMessage>, IMessage
		{
			[DebuggerNonUserCode]
			internal static class Types
			{
				internal enum Type
				{
					[OriginalName("PREPARE_EXECUTE")]
					PrepareExecute
				}
			}

			private static readonly MessageParser<OneOfMessage> _parser = new MessageParser<OneOfMessage>(() => new OneOfMessage());

			private UnknownFieldSet _unknownFields;

			public const int TypeFieldNumber = 1;

			private Types.Type type_;

			public const int PrepareExecuteFieldNumber = 2;

			private Execute prepareExecute_;

			[DebuggerNonUserCode]
			public static MessageParser<OneOfMessage> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Open.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public Types.Type Type
			{
				get
				{
					return type_;
				}
				set
				{
					type_ = value;
				}
			}

			[DebuggerNonUserCode]
			public Execute PrepareExecute
			{
				get
				{
					return prepareExecute_;
				}
				set
				{
					prepareExecute_ = value;
				}
			}

			[DebuggerNonUserCode]
			public OneOfMessage()
			{
			}

			[DebuggerNonUserCode]
			public OneOfMessage(OneOfMessage other)
				: this()
			{
				type_ = other.type_;
				prepareExecute_ = ((other.prepareExecute_ != null) ? other.prepareExecute_.Clone() : null);
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public OneOfMessage Clone()
			{
				return new OneOfMessage(this);
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
				if (!object.Equals(PrepareExecute, other.PrepareExecute))
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				if (Type != 0)
				{
					num ^= Type.GetHashCode();
				}
				if (prepareExecute_ != null)
				{
					num ^= PrepareExecute.GetHashCode();
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
				if (Type != 0)
				{
					output.WriteRawTag(8);
					output.WriteEnum((int)Type);
				}
				if (prepareExecute_ != null)
				{
					output.WriteRawTag(18);
					output.WriteMessage(PrepareExecute);
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
				if (Type != 0)
				{
					num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
				}
				if (prepareExecute_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize(PrepareExecute);
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
				if (other.Type != 0)
				{
					Type = other.Type;
				}
				if (other.prepareExecute_ != null)
				{
					if (prepareExecute_ == null)
					{
						prepareExecute_ = new Execute();
					}
					PrepareExecute.MergeFrom(other.PrepareExecute);
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
						if (prepareExecute_ == null)
						{
							prepareExecute_ = new Execute();
						}
						input.ReadMessage(prepareExecute_);
						break;
					case 8u:
						type_ = (Types.Type)input.ReadEnum();
						break;
					}
				}
			}
		}
	}

	private static readonly MessageParser<Open> _parser = new MessageParser<Open>(() => new Open());

	private UnknownFieldSet _unknownFields;

	public const int CursorIdFieldNumber = 1;

	private uint cursorId_;

	public const int StmtFieldNumber = 4;

	private Types.OneOfMessage stmt_;

	public const int FetchRowsFieldNumber = 5;

	private ulong fetchRows_;

	[DebuggerNonUserCode]
	public static MessageParser<Open> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCursorReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint CursorId
	{
		get
		{
			return cursorId_;
		}
		set
		{
			cursorId_ = value;
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
	public ulong FetchRows
	{
		get
		{
			return fetchRows_;
		}
		set
		{
			fetchRows_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Open()
	{
	}

	[DebuggerNonUserCode]
	public Open(Open other)
		: this()
	{
		cursorId_ = other.cursorId_;
		stmt_ = ((other.stmt_ != null) ? other.stmt_.Clone() : null);
		fetchRows_ = other.fetchRows_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Open Clone()
	{
		return new Open(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Open);
	}

	[DebuggerNonUserCode]
	public bool Equals(Open other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CursorId != other.CursorId)
		{
			return false;
		}
		if (!object.Equals(Stmt, other.Stmt))
		{
			return false;
		}
		if (FetchRows != other.FetchRows)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (CursorId != 0)
		{
			num ^= CursorId.GetHashCode();
		}
		if (stmt_ != null)
		{
			num ^= Stmt.GetHashCode();
		}
		if (FetchRows != 0L)
		{
			num ^= FetchRows.GetHashCode();
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
		if (CursorId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CursorId);
		}
		if (stmt_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Stmt);
		}
		if (FetchRows != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(FetchRows);
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
		if (CursorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CursorId);
		}
		if (stmt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stmt);
		}
		if (FetchRows != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(FetchRows);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Open other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CursorId != 0)
		{
			CursorId = other.CursorId;
		}
		if (other.stmt_ != null)
		{
			if (stmt_ == null)
			{
				stmt_ = new Types.OneOfMessage();
			}
			Stmt.MergeFrom(other.Stmt);
		}
		if (other.FetchRows != 0L)
		{
			FetchRows = other.FetchRows;
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
			case 40u:
				FetchRows = input.ReadUInt64();
				break;
			case 34u:
				if (stmt_ == null)
				{
					stmt_ = new Types.OneOfMessage();
				}
				input.ReadMessage(stmt_);
				break;
			case 8u:
				CursorId = input.ReadUInt32();
				break;
			}
		}
	}
}
