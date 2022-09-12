using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx;

internal sealed class Error : IMessage<Error>, IEquatable<Error>, IDeepCloneable<Error>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Severity
		{
			[OriginalName("ERROR")]
			Error,
			[OriginalName("FATAL")]
			Fatal
		}
	}

	private static readonly MessageParser<Error> _parser = new MessageParser<Error>(() => new Error());

	public const int SeverityFieldNumber = 1;

	private Types.Severity severity_;

	public const int CodeFieldNumber = 2;

	private uint code_;

	public const int SqlStateFieldNumber = 4;

	private string sqlState_ = "";

	public const int MsgFieldNumber = 3;

	private string msg_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Error> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Severity Severity
	{
		get
		{
			return severity_;
		}
		set
		{
			severity_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Code
	{
		get
		{
			return code_;
		}
		set
		{
			code_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string SqlState
	{
		get
		{
			return sqlState_;
		}
		set
		{
			sqlState_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Error()
	{
	}

	[DebuggerNonUserCode]
	public Error(Error other)
		: this()
	{
		severity_ = other.severity_;
		code_ = other.code_;
		sqlState_ = other.sqlState_;
		msg_ = other.msg_;
	}

	[DebuggerNonUserCode]
	public Error Clone()
	{
		return new Error(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Error);
	}

	[DebuggerNonUserCode]
	public bool Equals(Error other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Severity != other.Severity)
		{
			return false;
		}
		if (Code != other.Code)
		{
			return false;
		}
		if (SqlState != other.SqlState)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Severity != 0)
		{
			num ^= Severity.GetHashCode();
		}
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
		}
		if (SqlState.Length != 0)
		{
			num ^= SqlState.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
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
		if (Severity != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Severity);
		}
		if (Code != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Code);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Msg);
		}
		if (SqlState.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SqlState);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Severity != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Severity);
		}
		if (Code != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Code);
		}
		if (SqlState.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SqlState);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Error other)
	{
		if (other != null)
		{
			if (other.Severity != 0)
			{
				Severity = other.Severity;
			}
			if (other.Code != 0)
			{
				Code = other.Code;
			}
			if (other.SqlState.Length != 0)
			{
				SqlState = other.SqlState;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
			}
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
			case 16u:
				Code = input.ReadUInt32();
				break;
			case 8u:
				severity_ = (Types.Severity)input.ReadEnum();
				break;
			default:
				input.SkipLastField();
				break;
			case 34u:
				SqlState = input.ReadString();
				break;
			case 26u:
				Msg = input.ReadString();
				break;
			}
		}
	}
}
