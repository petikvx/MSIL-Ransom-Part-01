using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx;

internal sealed class ServerMessages : IMessage<ServerMessages>, IEquatable<ServerMessages>, IDeepCloneable<ServerMessages>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Type
		{
			[OriginalName("OK")]
			Ok = 0,
			[OriginalName("ERROR")]
			Error = 1,
			[OriginalName("CONN_CAPABILITIES")]
			ConnCapabilities = 2,
			[OriginalName("SESS_AUTHENTICATE_CONTINUE")]
			SessAuthenticateContinue = 3,
			[OriginalName("SESS_AUTHENTICATE_OK")]
			SessAuthenticateOk = 4,
			[OriginalName("NOTICE")]
			Notice = 11,
			[OriginalName("RESULTSET_COLUMN_META_DATA")]
			ResultsetColumnMetaData = 12,
			[OriginalName("RESULTSET_ROW")]
			ResultsetRow = 13,
			[OriginalName("RESULTSET_FETCH_DONE")]
			ResultsetFetchDone = 14,
			[OriginalName("RESULTSET_FETCH_SUSPENDED")]
			ResultsetFetchSuspended = 15,
			[OriginalName("RESULTSET_FETCH_DONE_MORE_RESULTSETS")]
			ResultsetFetchDoneMoreResultsets = 16,
			[OriginalName("SQL_STMT_EXECUTE_OK")]
			SqlStmtExecuteOk = 17,
			[OriginalName("RESULTSET_FETCH_DONE_MORE_OUT_PARAMS")]
			ResultsetFetchDoneMoreOutParams = 18,
			[OriginalName("COMPRESSION")]
			Compression = 19
		}
	}

	private static readonly MessageParser<ServerMessages> _parser = new MessageParser<ServerMessages>((Func<ServerMessages>)(() => new ServerMessages()));

	[DebuggerNonUserCode]
	public static MessageParser<ServerMessages> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxReflection.Descriptor.get_MessageTypes()[1];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ServerMessages()
	{
	}

	[DebuggerNonUserCode]
	public ServerMessages(ServerMessages other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public ServerMessages Clone()
	{
		return new ServerMessages(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ServerMessages);
	}

	[DebuggerNonUserCode]
	public bool Equals(ServerMessages other)
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
		return JsonFormatter.ToDiagnosticString((IMessage)(object)this);
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
	public void MergeFrom(ServerMessages other)
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
