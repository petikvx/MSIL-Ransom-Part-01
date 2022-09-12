using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Session;

internal sealed class Reset : IMessage<Reset>, IEquatable<Reset>, IDeepCloneable<Reset>, IMessage
{
	private static readonly MessageParser<Reset> _parser = new MessageParser<Reset>((Func<Reset>)(() => new Reset()));

	private UnknownFieldSet _unknownFields;

	public const int KeepOpenFieldNumber = 1;

	private bool keepOpen_;

	[DebuggerNonUserCode]
	public static MessageParser<Reset> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxSessionReflection.Descriptor.get_MessageTypes()[3];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public bool KeepOpen
	{
		get
		{
			return keepOpen_;
		}
		set
		{
			keepOpen_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Reset()
	{
	}

	[DebuggerNonUserCode]
	public Reset(Reset other)
		: this()
	{
		keepOpen_ = other.keepOpen_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Reset Clone()
	{
		return new Reset(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Reset);
	}

	[DebuggerNonUserCode]
	public bool Equals(Reset other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KeepOpen != other.KeepOpen)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (KeepOpen)
		{
			num ^= KeepOpen.GetHashCode();
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
		if (KeepOpen)
		{
			output.WriteRawTag((byte)8);
			output.WriteBool(KeepOpen);
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
		if (KeepOpen)
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
	public void MergeFrom(Reset other)
	{
		if (other != null)
		{
			if (other.KeepOpen)
			{
				KeepOpen = other.KeepOpen;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				KeepOpen = input.ReadBool();
			}
		}
	}
}
