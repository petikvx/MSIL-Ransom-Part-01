using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Sql;

internal sealed class StmtExecuteOk : IMessage<StmtExecuteOk>, IEquatable<StmtExecuteOk>, IDeepCloneable<StmtExecuteOk>, IMessage
{
	private static readonly MessageParser<StmtExecuteOk> _parser = new MessageParser<StmtExecuteOk>(() => new StmtExecuteOk());

	[DebuggerNonUserCode]
	public static MessageParser<StmtExecuteOk> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxSqlReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public StmtExecuteOk()
	{
	}

	[DebuggerNonUserCode]
	public StmtExecuteOk(StmtExecuteOk other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public StmtExecuteOk Clone()
	{
		return new StmtExecuteOk(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as StmtExecuteOk);
	}

	[DebuggerNonUserCode]
	public bool Equals(StmtExecuteOk other)
	{
		if (other == null)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return 1;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return 0;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(StmtExecuteOk other)
	{
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			input.SkipLastField();
		}
	}
}
