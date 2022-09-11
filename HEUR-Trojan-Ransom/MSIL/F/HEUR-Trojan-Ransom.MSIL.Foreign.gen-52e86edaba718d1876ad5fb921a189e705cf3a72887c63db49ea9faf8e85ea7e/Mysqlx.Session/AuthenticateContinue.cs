using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;

namespace Mysqlx.Session;

internal sealed class AuthenticateContinue : IMessage<AuthenticateContinue>, IEquatable<AuthenticateContinue>, IDeepCloneable<AuthenticateContinue>, IMessage
{
	private static readonly MessageParser<AuthenticateContinue> messageParser_0;

	public const int int_0 = 1;

	private ByteString byteString_0 = ByteString.Empty;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<AuthenticateContinue> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class20.Descriptor.MessageTypes[1];

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
			byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391775));
		}
	}

	[DebuggerNonUserCode]
	public AuthenticateContinue()
	{
	}

	[DebuggerNonUserCode]
	public AuthenticateContinue(AuthenticateContinue other)
		: this()
	{
		byteString_0 = other.byteString_0;
	}

	[DebuggerNonUserCode]
	public AuthenticateContinue Clone()
	{
		return new AuthenticateContinue(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<AuthenticateContinue>)this).Equals(obj as AuthenticateContinue);
	}

	[DebuggerNonUserCode]
	bool IEquatable<AuthenticateContinue>.Equals(AuthenticateContinue other)
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
	public void MergeFrom(AuthenticateContinue other)
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

	static AuthenticateContinue()
	{
		Strings.CreateGetStringDelegate(typeof(AuthenticateContinue));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397000), getString_0(107396995)).Replace(getString_0(107396958), getString_0(107396953)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396948)))
		{
			throw new SecurityException(getString_0(107396923));
		}
		messageParser_0 = new MessageParser<AuthenticateContinue>(() => new AuthenticateContinue());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
