using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal sealed class FetchDoneMoreResultsets : IMessage<FetchDoneMoreResultsets>, IEquatable<FetchDoneMoreResultsets>, IDeepCloneable<FetchDoneMoreResultsets>, IMessage
{
	private static readonly MessageParser<FetchDoneMoreResultsets> _parser = new MessageParser<FetchDoneMoreResultsets>((Func<FetchDoneMoreResultsets>)(() => new FetchDoneMoreResultsets()));

	private UnknownFieldSet _unknownFields;

	[DebuggerNonUserCode]
	public static MessageParser<FetchDoneMoreResultsets> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxResultsetReflection.Descriptor.get_MessageTypes()[1];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public FetchDoneMoreResultsets()
	{
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreResultsets(FetchDoneMoreResultsets other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreResultsets Clone()
	{
		return new FetchDoneMoreResultsets(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FetchDoneMoreResultsets);
	}

	[DebuggerNonUserCode]
	public bool Equals(FetchDoneMoreResultsets other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
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
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FetchDoneMoreResultsets other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
