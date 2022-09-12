using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Notice;

internal sealed class SessionStateChanged : IMessage<SessionStateChanged>, IEquatable<SessionStateChanged>, IDeepCloneable<SessionStateChanged>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum Parameter
		{
			[OriginalName("NONE")]
			None = 0,
			[OriginalName("CURRENT_SCHEMA")]
			CurrentSchema = 1,
			[OriginalName("ACCOUNT_EXPIRED")]
			AccountExpired = 2,
			[OriginalName("GENERATED_INSERT_ID")]
			GeneratedInsertId = 3,
			[OriginalName("ROWS_AFFECTED")]
			RowsAffected = 4,
			[OriginalName("ROWS_FOUND")]
			RowsFound = 5,
			[OriginalName("ROWS_MATCHED")]
			RowsMatched = 6,
			[OriginalName("TRX_COMMITTED")]
			TrxCommitted = 7,
			[OriginalName("TRX_ROLLEDBACK")]
			TrxRolledback = 9,
			[OriginalName("PRODUCED_MESSAGE")]
			ProducedMessage = 10,
			[OriginalName("CLIENT_ID_ASSIGNED")]
			ClientIdAssigned = 11,
			[OriginalName("GENERATED_DOCUMENT_IDS")]
			GeneratedDocumentIds = 12
		}
	}

	private static readonly MessageParser<SessionStateChanged> _parser = new MessageParser<SessionStateChanged>(() => new SessionStateChanged());

	private UnknownFieldSet _unknownFields;

	public const int ParamFieldNumber = 1;

	private Types.Parameter param_;

	public const int ValueFieldNumber = 2;

	private static readonly FieldCodec<Scalar> _repeated_value_codec = FieldCodec.ForMessage(18u, Scalar.Parser);

	private readonly RepeatedField<Scalar> value_ = new RepeatedField<Scalar>();

	[DebuggerNonUserCode]
	public static MessageParser<SessionStateChanged> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxNoticeReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Parameter Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Scalar> Value => value_;

	[DebuggerNonUserCode]
	public SessionStateChanged()
	{
	}

	[DebuggerNonUserCode]
	public SessionStateChanged(SessionStateChanged other)
		: this()
	{
		param_ = other.param_;
		value_ = other.value_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public SessionStateChanged Clone()
	{
		return new SessionStateChanged(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SessionStateChanged);
	}

	[DebuggerNonUserCode]
	public bool Equals(SessionStateChanged other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Param != other.Param)
		{
			return false;
		}
		if (!value_.Equals(other.value_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Param != 0)
		{
			num ^= Param.GetHashCode();
		}
		num ^= value_.GetHashCode();
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
		if (Param != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Param);
		}
		value_.WriteTo(output, _repeated_value_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Param != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Param);
		}
		num += value_.CalculateSize(_repeated_value_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SessionStateChanged other)
	{
		if (other != null)
		{
			if (other.Param != 0)
			{
				Param = other.Param;
			}
			value_.Add(other.value_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				value_.AddEntriesFrom(input, _repeated_value_codec);
				break;
			case 8u:
				param_ = (Types.Parameter)input.ReadEnum();
				break;
			}
		}
	}
}
