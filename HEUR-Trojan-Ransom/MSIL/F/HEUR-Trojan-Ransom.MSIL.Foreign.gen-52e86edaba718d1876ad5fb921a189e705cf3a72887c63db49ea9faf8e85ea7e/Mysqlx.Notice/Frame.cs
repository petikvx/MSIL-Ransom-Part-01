using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace Mysqlx.Notice;

internal sealed class Frame : IMessage, IMessage<Frame>, IEquatable<Frame>, IDeepCloneable<Frame>
{
	[DebuggerNonUserCode]
	internal static class Class23
	{
		public enum Enum5
		{
			[OriginalName("NONE")]
			const_0,
			[OriginalName("GLOBAL")]
			const_1,
			[OriginalName("LOCAL")]
			const_2
		}

		public enum Enum6
		{
			[OriginalName("NONE_Type")]
			const_0,
			[OriginalName("WARNING")]
			const_1,
			[OriginalName("SESSION_VARIABLE_CHANGED")]
			const_2,
			[OriginalName("SESSION_STATE_CHANGED")]
			const_3
		}
	}

	private static readonly MessageParser<Frame> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private uint uint_0;

	public const int int_1 = 2;

	private Class23.Enum5 enum5_0;

	public const int int_2 = 3;

	private ByteString byteString_0 = ByteString.Empty;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Frame> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class22.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint Type
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
	public Class23.Enum5 Scope
	{
		get
		{
			return enum5_0;
		}
		set
		{
			enum5_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public ByteString Payload
	{
		get
		{
			return byteString_0;
		}
		set
		{
			byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391861));
		}
	}

	[DebuggerNonUserCode]
	public Frame()
	{
	}

	[DebuggerNonUserCode]
	public Frame(Frame other)
		: this()
	{
		uint_0 = other.uint_0;
		enum5_0 = other.enum5_0;
		byteString_0 = other.byteString_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Frame Clone()
	{
		return new Frame(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Frame>)this).Equals(obj as Frame);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Frame>.Equals(Frame other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Scope != other.Scope)
		{
			return false;
		}
		if (Payload != other.Payload)
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Scope != 0)
		{
			num ^= Scope.GetHashCode();
		}
		if (Payload.Length != 0)
		{
			num ^= Payload.GetHashCode();
		}
		if (unknownFieldSet_0 != null)
		{
			num ^= unknownFieldSet_0.GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Type);
		}
		if (Scope != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Scope);
		}
		if (Payload.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(Payload);
		}
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (Scope != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Scope);
		}
		if (Payload.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Payload);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Frame other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Scope != 0)
			{
				Scope = other.Scope;
			}
			if (other.Payload.Length != 0)
			{
				Payload = other.Payload;
			}
			unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
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
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 26u:
				Payload = input.ReadBytes();
				break;
			case 16u:
				enum5_0 = (Class23.Enum5)input.ReadEnum();
				break;
			case 8u:
				Type = input.ReadUInt32();
				break;
			}
		}
	}

	static Frame()
	{
		Strings.CreateGetStringDelegate(typeof(Frame));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397086), getString_0(107397081)).Replace(getString_0(107397044), getString_0(107397039)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397034)))
		{
			throw new SecurityException(getString_0(107397009));
		}
		messageParser_0 = new MessageParser<Frame>(() => new Frame());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
