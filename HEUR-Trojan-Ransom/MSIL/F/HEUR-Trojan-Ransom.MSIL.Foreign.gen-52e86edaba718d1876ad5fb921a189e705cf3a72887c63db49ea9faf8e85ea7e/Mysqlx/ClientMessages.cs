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

internal sealed class ClientMessages : IMessage<ClientMessages>, IEquatable<ClientMessages>, IDeepCloneable<ClientMessages>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Class16
	{
		internal enum Enum0
		{
			[OriginalName("NONE")]
			const_0 = 0,
			[OriginalName("CON_CAPABILITIES_GET")]
			const_1 = 1,
			[OriginalName("CON_CAPABILITIES_SET")]
			const_2 = 2,
			[OriginalName("CON_CLOSE")]
			const_3 = 3,
			[OriginalName("SESS_AUTHENTICATE_START")]
			const_4 = 4,
			[OriginalName("SESS_AUTHENTICATE_CONTINUE")]
			const_5 = 5,
			[OriginalName("SESS_RESET")]
			const_6 = 6,
			[OriginalName("SESS_CLOSE")]
			const_7 = 7,
			[OriginalName("SQL_STMT_EXECUTE")]
			const_8 = 12,
			[OriginalName("CRUD_FIND")]
			const_9 = 17,
			[OriginalName("CRUD_INSERT")]
			const_10 = 18,
			[OriginalName("CRUD_UPDATE")]
			const_11 = 19,
			[OriginalName("CRUD_DELETE")]
			const_12 = 20,
			[OriginalName("EXPECT_OPEN")]
			const_13 = 24,
			[OriginalName("EXPECT_CLOSE")]
			const_14 = 25,
			[OriginalName("CRUD_CREATE_VIEW")]
			const_15 = 30,
			[OriginalName("CRUD_MODIFY_VIEW")]
			const_16 = 31,
			[OriginalName("CRUD_DROP_VIEW")]
			const_17 = 32
		}
	}

	private static readonly MessageParser<ClientMessages> messageParser_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<ClientMessages> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class15.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	bool object.Equals(object obj)
	{
		return ((IEquatable<ClientMessages>)this).Equals(obj as ClientMessages);
	}

	[DebuggerNonUserCode]
	bool IEquatable<ClientMessages>.Equals(ClientMessages other)
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

	static ClientMessages()
	{
		Strings.CreateGetStringDelegate(typeof(ClientMessages));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396912), getString_0(107396907)).Replace(getString_0(107396870), getString_0(107396865)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396860)))
		{
			throw new SecurityException(getString_0(107396835));
		}
		messageParser_0 = new MessageParser<ClientMessages>(() => new ClientMessages());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
