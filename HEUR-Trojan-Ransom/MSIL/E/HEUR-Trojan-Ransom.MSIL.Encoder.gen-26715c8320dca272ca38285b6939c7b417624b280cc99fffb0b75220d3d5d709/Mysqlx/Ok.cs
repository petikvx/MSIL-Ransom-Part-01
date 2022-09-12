using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx;

internal sealed class Ok : IMessage<Ok>, IEquatable<Ok>, IDeepCloneable<Ok>, IMessage
{
	private static readonly MessageParser<Ok> _parser = new MessageParser<Ok>((Func<Ok>)(() => new Ok()));

	public const int MsgFieldNumber = 1;

	private string msg_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Ok> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxReflection.Descriptor.get_MessageTypes()[2];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Ok()
	{
	}

	[DebuggerNonUserCode]
	public Ok(Ok other)
		: this()
	{
		msg_ = other.msg_;
	}

	[DebuggerNonUserCode]
	public Ok Clone()
	{
		return new Ok(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Ok);
	}

	[DebuggerNonUserCode]
	public bool Equals(Ok other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
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
		if (Msg.Length != 0)
		{
			output.WriteRawTag((byte)10);
			output.WriteString(Msg);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Ok other)
	{
		if (other != null && other.Msg.Length != 0)
		{
			Msg = other.Msg;
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
				input.SkipLastField();
			}
			else
			{
				Msg = input.ReadString();
			}
		}
	}
}
