using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;

namespace Mysqlx.Session;

internal sealed class AuthenticateOk : IMessage<AuthenticateOk>, IEquatable<AuthenticateOk>, IDeepCloneable<AuthenticateOk>, IMessage
{
	private static readonly MessageParser<AuthenticateOk> messageParser_0;

	public const int int_0 = 1;

	private ByteString byteString_0 = ByteString.Empty;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<AuthenticateOk> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class20.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ByteString AuthData
	{
		get
		{
			return byteString_0;
		}
		set
		{
			byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391780));
		}
	}

	[DebuggerNonUserCode]
	public AuthenticateOk()
	{
	}

	[DebuggerNonUserCode]
	public AuthenticateOk(AuthenticateOk other)
		: this()
	{
		byteString_0 = other.byteString_0;
	}

	[DebuggerNonUserCode]
	public AuthenticateOk Clone()
	{
		return new AuthenticateOk(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<AuthenticateOk>)this).Equals(obj as AuthenticateOk);
	}

	[DebuggerNonUserCode]
	bool IEquatable<AuthenticateOk>.Equals(AuthenticateOk other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AuthData != other.AuthData)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (AuthData.Length != 0)
		{
			num ^= AuthData.GetHashCode();
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
		if (AuthData.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(AuthData);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (AuthData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(AuthData);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(AuthenticateOk other)
	{
		if (other != null && other.AuthData.Length != 0)
		{
			AuthData = other.AuthData;
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				input.SkipLastField();
			}
			else
			{
				AuthData = input.ReadBytes();
			}
		}
	}

	static AuthenticateOk()
	{
		Strings.CreateGetStringDelegate(typeof(AuthenticateOk));
		messageParser_0 = new MessageParser<AuthenticateOk>(() => new AuthenticateOk());
	}
}
