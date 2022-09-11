using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace Mysqlx.Connection;

internal sealed class CapabilitiesSet : IMessage, IMessage<CapabilitiesSet>, IEquatable<CapabilitiesSet>, IDeepCloneable<CapabilitiesSet>
{
	private static readonly MessageParser<CapabilitiesSet> messageParser_0;

	public const int int_0 = 1;

	private Capabilities capabilities_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<CapabilitiesSet> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class36.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Capabilities Capabilities
	{
		get
		{
			return capabilities_0;
		}
		set
		{
			capabilities_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public CapabilitiesSet()
	{
	}

	[DebuggerNonUserCode]
	public CapabilitiesSet(CapabilitiesSet other)
		: this()
	{
		Capabilities = ((other.capabilities_0 != null) ? other.Capabilities.Clone() : null);
	}

	[DebuggerNonUserCode]
	public CapabilitiesSet Clone()
	{
		return new CapabilitiesSet(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<CapabilitiesSet>)this).Equals(obj as CapabilitiesSet);
	}

	[DebuggerNonUserCode]
	bool IEquatable<CapabilitiesSet>.Equals(CapabilitiesSet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Capabilities, other.Capabilities))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (capabilities_0 != null)
		{
			num ^= Capabilities.GetHashCode();
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
		if (capabilities_0 != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Capabilities);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (capabilities_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Capabilities);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CapabilitiesSet other)
	{
		if (other != null && other.capabilities_0 != null)
		{
			if (capabilities_0 == null)
			{
				capabilities_0 = new Capabilities();
			}
			Capabilities.MergeFrom(other.Capabilities);
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
				continue;
			}
			if (capabilities_0 == null)
			{
				capabilities_0 = new Capabilities();
			}
			input.ReadMessage(capabilities_0);
		}
	}

	static CapabilitiesSet()
	{
		Strings.CreateGetStringDelegate(typeof(CapabilitiesSet));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397619), getString_0(107397614)).Replace(getString_0(107397577), getString_0(107397572)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397567)))
		{
			throw new SecurityException(getString_0(107397542));
		}
		messageParser_0 = new MessageParser<CapabilitiesSet>(() => new CapabilitiesSet());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
