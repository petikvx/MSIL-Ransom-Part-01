using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Resultset;

internal sealed class FetchDoneMoreOutParams : IMessage<FetchDoneMoreOutParams>, IEquatable<FetchDoneMoreOutParams>, IDeepCloneable<FetchDoneMoreOutParams>, IMessage
{
	private static readonly MessageParser<FetchDoneMoreOutParams> _parser = new MessageParser<FetchDoneMoreOutParams>((Func<FetchDoneMoreOutParams>)(() => new FetchDoneMoreOutParams()));

	private UnknownFieldSet _unknownFields;

	[DebuggerNonUserCode]
	public static MessageParser<FetchDoneMoreOutParams> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxResultsetReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public FetchDoneMoreOutParams()
	{
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreOutParams(FetchDoneMoreOutParams other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FetchDoneMoreOutParams Clone()
	{
		return new FetchDoneMoreOutParams(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FetchDoneMoreOutParams);
	}

	[DebuggerNonUserCode]
	public bool Equals(FetchDoneMoreOutParams other)
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
	public void MergeFrom(FetchDoneMoreOutParams other)
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
