using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;

namespace Mysqlx;

internal sealed class ServerMessages : IMessage<ServerMessages>, IEquatable<ServerMessages>, IDeepCloneable<ServerMessages>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Class17
	{
		internal enum Enum1
		{
			[OriginalName("OK")]
			const_0 = 0,
			[OriginalName("ERROR")]
			const_1 = 1,
			[OriginalName("CONN_CAPABILITIES")]
			const_2 = 2,
			[OriginalName("SESS_AUTHENTICATE_CONTINUE")]
			const_3 = 3,
			[OriginalName("SESS_AUTHENTICATE_OK")]
			const_4 = 4,
			[OriginalName("NOTICE")]
			const_5 = 11,
			[OriginalName("RESULTSET_COLUMN_META_DATA")]
			const_6 = 12,
			[OriginalName("RESULTSET_ROW")]
			const_7 = 13,
			[OriginalName("RESULTSET_FETCH_DONE")]
			const_8 = 14,
			[OriginalName("RESULTSET_FETCH_SUSPENDED")]
			const_9 = 15,
			[OriginalName("RESULTSET_FETCH_DONE_MORE_RESULTSETS")]
			const_10 = 16,
			[OriginalName("SQL_STMT_EXECUTE_OK")]
			const_11 = 17,
			[OriginalName("RESULTSET_FETCH_DONE_MORE_OUT_PARAMS")]
			const_12 = 18
		}
	}

	private static readonly MessageParser<ServerMessages> messageParser_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<ServerMessages> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class15.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	bool object.Equals(object obj)
	{
		return ((IEquatable<ServerMessages>)this).Equals(obj as ServerMessages);
	}

	[DebuggerNonUserCode]
	bool IEquatable<ServerMessages>.Equals(ServerMessages other)
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

	static ServerMessages()
	{
		Strings.CreateGetStringDelegate(typeof(ServerMessages));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396934), getString_0(107396929)).Replace(getString_0(107396892), getString_0(107396887)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396882)))
		{
			throw new SecurityException(getString_0(107396857));
		}
		messageParser_0 = new MessageParser<ServerMessages>(() => new ServerMessages());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
