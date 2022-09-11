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

internal sealed class Ok : IMessage<Ok>, IEquatable<Ok>, IDeepCloneable<Ok>, IMessage
{
	private static readonly MessageParser<Ok> messageParser_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107396775);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Ok> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class15.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Msg
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391728));
		}
	}

	[DebuggerNonUserCode]
	public Ok()
	{
	}

	[DebuggerNonUserCode]
	public Ok(Ok other)
		: this()
	{
		string_0 = other.string_0;
	}

	[DebuggerNonUserCode]
	public Ok Clone()
	{
		return new Ok(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Ok>)this).Equals(obj as Ok);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Ok>.Equals(Ok other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (Msg.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Msg);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Ok other)
	{
		if (other != null && other.Msg.Length != 0)
		{
			Msg = other.Msg;
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
				Msg = input.ReadString();
			}
		}
	}

	static Ok()
	{
		Strings.CreateGetStringDelegate(typeof(Ok));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396953), getString_0(107396948)).Replace(getString_0(107396911), getString_0(107396906)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396901)))
		{
			throw new SecurityException(getString_0(107396876));
		}
		messageParser_0 = new MessageParser<Ok>(() => new Ok());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
