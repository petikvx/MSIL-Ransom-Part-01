using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx;

internal sealed class ClientMessages : IMessage<ClientMessages>, IEquatable<ClientMessages>, IDeepCloneable<ClientMessages>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Type
		{
			[OriginalName("NONE")]
			None = 0,
			[OriginalName("CON_CAPABILITIES_GET")]
			ConCapabilitiesGet = 1,
			[OriginalName("CON_CAPABILITIES_SET")]
			ConCapabilitiesSet = 2,
			[OriginalName("CON_CLOSE")]
			ConClose = 3,
			[OriginalName("SESS_AUTHENTICATE_START")]
			SessAuthenticateStart = 4,
			[OriginalName("SESS_AUTHENTICATE_CONTINUE")]
			SessAuthenticateContinue = 5,
			[OriginalName("SESS_RESET")]
			SessReset = 6,
			[OriginalName("SESS_CLOSE")]
			SessClose = 7,
			[OriginalName("SQL_STMT_EXECUTE")]
			SqlStmtExecute = 12,
			[OriginalName("CRUD_FIND")]
			CrudFind = 17,
			[OriginalName("CRUD_INSERT")]
			CrudInsert = 18,
			[OriginalName("CRUD_UPDATE")]
			CrudUpdate = 19,
			[OriginalName("CRUD_DELETE")]
			CrudDelete = 20,
			[OriginalName("EXPECT_OPEN")]
			ExpectOpen = 24,
			[OriginalName("EXPECT_CLOSE")]
			ExpectClose = 25,
			[OriginalName("CRUD_CREATE_VIEW")]
			CrudCreateView = 30,
			[OriginalName("CRUD_MODIFY_VIEW")]
			CrudModifyView = 31,
			[OriginalName("CRUD_DROP_VIEW")]
			CrudDropView = 32,
			[OriginalName("PREPARE_PREPARE")]
			PreparePrepare = 40,
			[OriginalName("PREPARE_EXECUTE")]
			PrepareExecute = 41,
			[OriginalName("PREPARE_DEALLOCATE")]
			PrepareDeallocate = 42,
			[OriginalName("CURSOR_OPEN")]
			CursorOpen = 43,
			[OriginalName("CURSOR_CLOSE")]
			CursorClose = 44,
			[OriginalName("CURSOR_FETCH")]
			CursorFetch = 45,
			[OriginalName("COMPRESSION")]
			Compression = 46
		}
	}

	private static readonly MessageParser<ClientMessages> _parser = new MessageParser<ClientMessages>((Func<ClientMessages>)(() => new ClientMessages()));

	[DebuggerNonUserCode]
	public static MessageParser<ClientMessages> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ClientMessages()
	{
	}

	[DebuggerNonUserCode]
	public ClientMessages(ClientMessages other)
		: this()
	{
	}

	[DebuggerNonUserCode]
	public ClientMessages Clone()
	{
		return new ClientMessages(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ClientMessages);
	}

	[DebuggerNonUserCode]
	public bool Equals(ClientMessages other)
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
	public void MergeFrom(ClientMessages other)
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
