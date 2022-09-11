using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns15;

namespace Mysqlx.Expr;

internal sealed class DocumentPathItem : IMessage, IMessage<DocumentPathItem>, IEquatable<DocumentPathItem>, IDeepCloneable<DocumentPathItem>
{
	[DebuggerNonUserCode]
	internal static class Class27
	{
		internal enum Enum9
		{
			[OriginalName("NONE")]
			const_0,
			[OriginalName("MEMBER")]
			const_1,
			[OriginalName("MEMBER_ASTERISK")]
			const_2,
			[OriginalName("ARRAY_INDEX")]
			const_3,
			[OriginalName("ARRAY_INDEX_ASTERISK")]
			const_4,
			[OriginalName("DOUBLE_ASTERISK")]
			const_5
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Class27()
		{
			Strings.CreateGetStringDelegate(typeof(Class27));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397190), getString_0(107397185)).Replace(getString_0(107397148), getString_0(107397143)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397138)))
			{
				throw new SecurityException(getString_0(107397113));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<DocumentPathItem> messageParser_0;

	public const int int_0 = 1;

	private Class27.Enum9 enum9_0;

	public const int int_1 = 2;

	private string string_0 = getString_0(107397011);

	public const int int_2 = 3;

	private uint uint_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<DocumentPathItem> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Class27.Enum9 Type
	{
		get
		{
			return enum9_0;
		}
		set
		{
			enum9_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public string Value
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391964));
		}
	}

	[DebuggerNonUserCode]
	public uint Index
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
	public DocumentPathItem()
	{
	}

	[DebuggerNonUserCode]
	public DocumentPathItem(DocumentPathItem other)
		: this()
	{
		enum9_0 = other.enum9_0;
		string_0 = other.string_0;
		uint_0 = other.uint_0;
	}

	[DebuggerNonUserCode]
	public DocumentPathItem Clone()
	{
		return new DocumentPathItem(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<DocumentPathItem>)this).Equals(obj as DocumentPathItem);
	}

	[DebuggerNonUserCode]
	bool IEquatable<DocumentPathItem>.Equals(DocumentPathItem other)
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
		if (Value != other.Value)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Value.Length != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
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
			output.WriteEnum((int)Type);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Value);
		}
		if (Index != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Index);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(DocumentPathItem other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Value.Length != 0)
			{
				Value = other.Value;
			}
			if (other.Index != 0)
			{
				Index = other.Index;
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
			case 24u:
				Index = input.ReadUInt32();
				break;
			case 18u:
				Value = input.ReadString();
				break;
			case 8u:
				enum9_0 = (Class27.Enum9)input.ReadEnum();
				break;
			}
		}
	}

	static DocumentPathItem()
	{
		Strings.CreateGetStringDelegate(typeof(DocumentPathItem));
		messageParser_0 = new MessageParser<DocumentPathItem>(() => new DocumentPathItem());
	}
}
