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

internal sealed class Warning : IMessage, IMessage<Warning>, IEquatable<Warning>, IDeepCloneable<Warning>
{
	[DebuggerNonUserCode]
	internal static class Class24
	{
		public enum Enum7
		{
			[OriginalName("NONE")]
			const_0,
			[OriginalName("NOTE")]
			const_1,
			[OriginalName("WARNING")]
			const_2,
			[OriginalName("ERROR")]
			const_3
		}
	}

	private static readonly MessageParser<Warning> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Class24.Enum7 enum7_0;

	public const int int_1 = 2;

	private uint uint_0;

	public const int int_2 = 3;

	private string string_0 = getString_0(107396927);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Warning> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class22.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Class24.Enum7 Level
	{
		get
		{
			return enum7_0;
		}
		set
		{
			enum7_0 = value;
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
	public string Msg
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391880));
		}
	}

	[DebuggerNonUserCode]
	public Warning()
	{
	}

	[DebuggerNonUserCode]
	public Warning(Warning other)
		: this()
	{
		enum7_0 = other.enum7_0;
		uint_0 = other.uint_0;
		string_0 = other.string_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Warning Clone()
	{
		return new Warning(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Warning>)this).Equals(obj as Warning);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Warning>.Equals(Warning other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Code != other.Code)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Level);
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
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Level);
		}
		if (Code != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Code);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Warning other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Code != 0)
			{
				Code = other.Code;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
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
				Msg = input.ReadString();
				break;
			case 16u:
				Code = input.ReadUInt32();
				break;
			case 8u:
				enum7_0 = (Class24.Enum7)input.ReadEnum();
				break;
			}
		}
	}

	static Warning()
	{
		Strings.CreateGetStringDelegate(typeof(Warning));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397105), getString_0(107397100)).Replace(getString_0(107397063), getString_0(107397058)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397053)))
		{
			throw new SecurityException(getString_0(107397028));
		}
		messageParser_0 = new MessageParser<Warning>(() => new Warning());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
