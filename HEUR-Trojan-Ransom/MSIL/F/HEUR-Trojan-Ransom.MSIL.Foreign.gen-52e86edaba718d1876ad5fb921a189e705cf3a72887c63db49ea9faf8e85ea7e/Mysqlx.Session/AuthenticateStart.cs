using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;

namespace Mysqlx.Session;

internal sealed class AuthenticateStart : IMessage<AuthenticateStart>, IEquatable<AuthenticateStart>, IDeepCloneable<AuthenticateStart>, IMessage
{
	private static readonly MessageParser<AuthenticateStart> messageParser_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107396817);

	public const int int_1 = 2;

	private ByteString byteString_0 = ByteString.Empty;

	public const int int_2 = 3;

	private ByteString byteString_1 = ByteString.Empty;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<AuthenticateStart> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class20.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string MechName
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391770));
		}
	}

	[DebuggerNonUserCode]
	public ByteString AuthData
	{
		get
		{
			return byteString_0;
		}
		set
		{
			byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391770));
		}
	}

	[DebuggerNonUserCode]
	public ByteString InitialResponse
	{
		get
		{
			return byteString_1;
		}
		set
		{
			byteString_1 = ProtoPreconditions.CheckNotNull(value, getString_0(107391770));
		}
	}

	[DebuggerNonUserCode]
	public AuthenticateStart()
	{
	}

	[DebuggerNonUserCode]
	public AuthenticateStart(AuthenticateStart other)
		: this()
	{
		string_0 = other.string_0;
		byteString_0 = other.byteString_0;
		byteString_1 = other.byteString_1;
	}

	[DebuggerNonUserCode]
	public AuthenticateStart Clone()
	{
		return new AuthenticateStart(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<AuthenticateStart>)this).Equals(obj as AuthenticateStart);
	}

	[DebuggerNonUserCode]
	bool IEquatable<AuthenticateStart>.Equals(AuthenticateStart other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MechName != other.MechName)
		{
			return false;
		}
		if (AuthData != other.AuthData)
		{
			return false;
		}
		if (InitialResponse != other.InitialResponse)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (MechName.Length != 0)
		{
			num ^= MechName.GetHashCode();
		}
		if (AuthData.Length != 0)
		{
			num ^= AuthData.GetHashCode();
		}
		if (InitialResponse.Length != 0)
		{
			num ^= InitialResponse.GetHashCode();
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
		if (MechName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MechName);
		}
		if (AuthData.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(AuthData);
		}
		if (InitialResponse.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(InitialResponse);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (MechName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MechName);
		}
		if (AuthData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(AuthData);
		}
		if (InitialResponse.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(InitialResponse);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(AuthenticateStart other)
	{
		if (other != null)
		{
			if (other.MechName.Length != 0)
			{
				MechName = other.MechName;
			}
			if (other.AuthData.Length != 0)
			{
				AuthData = other.AuthData;
			}
			if (other.InitialResponse.Length != 0)
			{
				InitialResponse = other.InitialResponse;
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
			default:
				input.SkipLastField();
				break;
			case 26u:
				InitialResponse = input.ReadBytes();
				break;
			case 18u:
				AuthData = input.ReadBytes();
				break;
			case 10u:
				MechName = input.ReadString();
				break;
			}
		}
	}

	static AuthenticateStart()
	{
		Strings.CreateGetStringDelegate(typeof(AuthenticateStart));
		messageParser_0 = new MessageParser<AuthenticateStart>(() => new AuthenticateStart());
	}
}
