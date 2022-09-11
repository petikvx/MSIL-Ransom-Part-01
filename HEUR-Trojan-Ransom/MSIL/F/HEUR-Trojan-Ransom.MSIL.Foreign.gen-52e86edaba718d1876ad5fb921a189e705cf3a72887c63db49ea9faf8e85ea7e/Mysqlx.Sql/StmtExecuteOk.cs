using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns11;

namespace Mysqlx.Sql;

internal sealed class StmtExecuteOk : IMessage<StmtExecuteOk>, IEquatable<StmtExecuteOk>, IDeepCloneable<StmtExecuteOk>, IMessage
{
	private static readonly MessageParser<StmtExecuteOk> messageParser_0 = new MessageParser<StmtExecuteOk>(() => new StmtExecuteOk());

	[DebuggerNonUserCode]
	public static MessageParser<StmtExecuteOk> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class19.Descriptor.MessageTypes[1];

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
	bool object.Equals(object obj)
	{
		return ((IEquatable<StmtExecuteOk>)this).Equals(obj as StmtExecuteOk);
	}

	[DebuggerNonUserCode]
	bool IEquatable<StmtExecuteOk>.Equals(StmtExecuteOk other)
	{
		if (other == null)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		return 1;
	}

	[DebuggerNonUserCode]
	string object.ToString()
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
