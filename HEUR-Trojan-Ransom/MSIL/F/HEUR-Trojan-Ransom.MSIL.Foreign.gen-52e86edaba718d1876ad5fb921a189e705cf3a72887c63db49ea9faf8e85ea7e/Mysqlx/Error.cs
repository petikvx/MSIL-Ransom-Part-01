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

internal sealed class Error : IMessage<Error>, IEquatable<Error>, IDeepCloneable<Error>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Class18
	{
		internal enum Enum2
		{
			[OriginalName("ERROR")]
			const_0,
			[OriginalName("FATAL")]
			const_1
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Class18()
		{
			Strings.CreateGetStringDelegate(typeof(Class18));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396965), getString_0(107396960)).Replace(getString_0(107396923), getString_0(107396918)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396913)))
			{
				throw new SecurityException(getString_0(107396888));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<Error> messageParser_0;

	public const int int_0 = 1;

	private Class18.Enum2 enum2_0;

	public const int int_1 = 2;

	private uint uint_0;

	public const int int_2 = 4;

	private string string_0 = getString_0(107396786);

	public const int int_3 = 3;

	private string string_1 = getString_0(107396786);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Error> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class15.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Class18.Enum2 Severity
	{
		get
		{
			return enum2_0;
		}
		set
		{
			enum2_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Code
	{
		get
		{
			return uint_0;
		}
		set
		{
			uint_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public string SqlState
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391739));
		}
	}

	[DebuggerNonUserCode]
	public string Msg
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = ProtoPreconditions.CheckNotNull(value, getString_0(107391739));
		}
	}

	[DebuggerNonUserCode]
	public Error()
	{
	}

	[DebuggerNonUserCode]
	public Error(Error other)
		: this()
	{
		enum2_0 = other.enum2_0;
		uint_0 = other.uint_0;
		string_0 = other.string_0;
		string_1 = other.string_1;
	}

	[DebuggerNonUserCode]
	public Error Clone()
	{
		return new Error(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Error>)this).Equals(obj as Error);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Error>.Equals(Error other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Severity != other.Severity)
		{
			return false;
		}
		if (Code != other.Code)
		{
			return false;
		}
		if (SqlState != other.SqlState)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Severity != 0)
		{
			num ^= Severity.GetHashCode();
		}
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
		}
		if (SqlState.Length != 0)
		{
			num ^= SqlState.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (Severity != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Severity);
		}
		if (Code != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Code);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Msg);
		}
		if (SqlState.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SqlState);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Severity != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Severity);
		}
		if (Code != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Code);
		}
		if (SqlState.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SqlState);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Error other)
	{
		if (other != null)
		{
			if (other.Severity != 0)
			{
				Severity = other.Severity;
			}
			if (other.Code != 0)
			{
				Code = other.Code;
			}
			if (other.SqlState.Length != 0)
			{
				SqlState = other.SqlState;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
			}
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 16u:
				Code = input.ReadUInt32();
				break;
			case 8u:
				enum2_0 = (Class18.Enum2)input.ReadEnum();
				break;
			default:
				input.SkipLastField();
				break;
			case 34u:
				SqlState = input.ReadString();
				break;
			case 26u:
				Msg = input.ReadString();
				break;
			}
		}
	}

	static Error()
	{
		Strings.CreateGetStringDelegate(typeof(Error));
		messageParser_0 = new MessageParser<Error>(() => new Error());
	}
}
