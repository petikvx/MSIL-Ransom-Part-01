using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class UpdateOperation : IMessage<UpdateOperation>, IEquatable<UpdateOperation>, IDeepCloneable<UpdateOperation>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum UpdateType
		{
			[OriginalName("NONE_UpdateType")]
			NoneUpdateType,
			[OriginalName("SET")]
			Set,
			[OriginalName("ITEM_REMOVE")]
			ItemRemove,
			[OriginalName("ITEM_SET")]
			ItemSet,
			[OriginalName("ITEM_REPLACE")]
			ItemReplace,
			[OriginalName("ITEM_MERGE")]
			ItemMerge,
			[OriginalName("ARRAY_INSERT")]
			ArrayInsert,
			[OriginalName("ARRAY_APPEND")]
			ArrayAppend,
			[OriginalName("MERGE_PATCH")]
			MergePatch
		}
	}

	private static readonly MessageParser<UpdateOperation> _parser = new MessageParser<UpdateOperation>((Func<UpdateOperation>)(() => new UpdateOperation()));

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 1;

	private ColumnIdentifier source_;

	public const int OperationFieldNumber = 2;

	private Types.UpdateType operation_;

	public const int ValueFieldNumber = 3;

	private Mysqlx.Expr.Expr value_;

	[DebuggerNonUserCode]
	public static MessageParser<UpdateOperation> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.get_MessageTypes()[6];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ColumnIdentifier Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.UpdateType Operation
	{
		get
		{
			return operation_;
		}
		set
		{
			operation_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[DebuggerNonUserCode]
	public UpdateOperation()
	{
	}

	[DebuggerNonUserCode]
	public UpdateOperation(UpdateOperation other)
		: this()
	{
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		operation_ = other.operation_;
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public UpdateOperation Clone()
	{
		return new UpdateOperation(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateOperation);
	}

	[DebuggerNonUserCode]
	public bool Equals(UpdateOperation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (Operation != other.Operation)
		{
			return false;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (Operation != 0)
		{
			num ^= Operation.GetHashCode();
		}
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
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
		if (source_ != null)
		{
			output.WriteRawTag((byte)10);
			output.WriteMessage((IMessage)(object)Source);
		}
		if (Operation != 0)
		{
			output.WriteRawTag((byte)16);
			output.WriteEnum((int)Operation);
		}
		if (value_ != null)
		{
			output.WriteRawTag((byte)26);
			output.WriteMessage((IMessage)(object)Value);
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
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Source);
		}
		if (Operation != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Operation);
		}
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(UpdateOperation other)
	{
		if (other == null)
		{
			return;
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				source_ = new ColumnIdentifier();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.Operation != 0)
		{
			Operation = other.Operation;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				value_ = new Mysqlx.Expr.Expr();
			}
			Value.MergeFrom(other.Value);
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
			case 26u:
				if (value_ == null)
				{
					value_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage((IMessage)(object)value_);
				break;
			case 16u:
				operation_ = (Types.UpdateType)input.ReadEnum();
				break;
			case 10u:
				if (source_ == null)
				{
					source_ = new ColumnIdentifier();
				}
				input.ReadMessage((IMessage)(object)source_);
				break;
			}
		}
	}
}
