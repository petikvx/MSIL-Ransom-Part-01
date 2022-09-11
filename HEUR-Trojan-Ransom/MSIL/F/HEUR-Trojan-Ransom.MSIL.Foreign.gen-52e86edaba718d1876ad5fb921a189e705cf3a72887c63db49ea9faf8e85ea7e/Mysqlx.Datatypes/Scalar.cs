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

namespace Mysqlx.Datatypes;

internal sealed class Scalar : IMessage, IMessage<Scalar>, IEquatable<Scalar>, IDeepCloneable<Scalar>
{
	public enum Enum13
	{
		const_0 = 0,
		const_1 = 2,
		const_2 = 3,
		const_3 = 5,
		const_4 = 6,
		const_5 = 7,
		const_6 = 8,
		const_7 = 9
	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Type
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("V_SINT")]
			VSint,
			[OriginalName("V_UINT")]
			VUint,
			[OriginalName("V_NULL")]
			VNull,
			[OriginalName("V_OCTETS")]
			VOctets,
			[OriginalName("V_DOUBLE")]
			VDouble,
			[OriginalName("V_FLOAT")]
			VFloat,
			[OriginalName("V_BOOL")]
			VBool,
			[OriginalName("V_STRING")]
			VString
		}

		internal sealed class String : IMessage, IMessage<String>, IEquatable<String>, IDeepCloneable<String>
		{
			private static readonly MessageParser<String> messageParser_0;

			public const int int_0 = 1;

			private ByteString byteString_0 = ByteString.Empty;

			public const int int_1 = 2;

			private ulong ulong_0;

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<String> Parser => messageParser_0;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Scalar.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public ByteString Value
			{
				get
				{
					return byteString_0;
				}
				set
				{
					byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392095));
				}
			}

			[DebuggerNonUserCode]
			public ulong Collation
			{
				get
				{
					return ulong_0;
				}
				set
				{
					ulong_0 = value;
				}
			}

			[DebuggerNonUserCode]
			public String()
			{
			}

			[DebuggerNonUserCode]
			public String(String other)
				: this()
			{
				byteString_0 = other.byteString_0;
				ulong_0 = other.ulong_0;
			}

			[DebuggerNonUserCode]
			public String Clone()
			{
				return new String(this);
			}

			[DebuggerNonUserCode]
			bool object.Equals(object obj)
			{
				return ((IEquatable<String>)this).Equals(obj as String);
			}

			[DebuggerNonUserCode]
			bool IEquatable<String>.Equals(String other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Value != other.Value)
				{
					return false;
				}
				if (Collation != other.Collation)
				{
					return false;
				}
				return true;
			}

			[DebuggerNonUserCode]
			int object.GetHashCode()
			{
				int num = 1;
				if (Value.Length != 0)
				{
					num ^= Value.GetHashCode();
				}
				if (Collation != 0L)
				{
					num ^= Collation.GetHashCode();
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
				if (Value.Length != 0)
				{
					output.WriteRawTag(10);
					output.WriteBytes(Value);
				}
				if (Collation != 0L)
				{
					output.WriteRawTag(16);
					output.WriteUInt64(Collation);
				}
			}

			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				if (Value.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(Value);
				}
				if (Collation != 0L)
				{
					num += 1 + CodedOutputStream.ComputeUInt64Size(Collation);
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(String other)
			{
				if (other != null)
				{
					if (other.Value.Length != 0)
					{
						Value = other.Value;
					}
					if (other.Collation != 0L)
					{
						Collation = other.Collation;
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
					case 16u:
						Collation = input.ReadUInt64();
						break;
					case 10u:
						Value = input.ReadBytes();
						break;
					}
				}
			}

			static String()
			{
				Strings.CreateGetStringDelegate(typeof(String));
				messageParser_0 = new MessageParser<String>(() => new String());
			}
		}

		internal sealed class Octets : IMessage, IMessage<Octets>, IEquatable<Octets>, IDeepCloneable<Octets>
		{
			private static readonly MessageParser<Octets> messageParser_0;

			public const int int_0 = 1;

			private ByteString byteString_0 = ByteString.Empty;

			public const int int_1 = 2;

			private uint uint_0;

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<Octets> Parser => messageParser_0;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Scalar.Descriptor.NestedTypes[1];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public ByteString Value
			{
				get
				{
					return byteString_0;
				}
				set
				{
					byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392102));
				}
			}

			[DebuggerNonUserCode]
			public uint ContentType
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
			public Octets()
			{
			}

			[DebuggerNonUserCode]
			public Octets(Octets other)
				: this()
			{
				byteString_0 = other.byteString_0;
				uint_0 = other.uint_0;
			}

			[DebuggerNonUserCode]
			public Octets Clone()
			{
				return new Octets(this);
			}

			[DebuggerNonUserCode]
			bool object.Equals(object obj)
			{
				return ((IEquatable<Octets>)this).Equals(obj as Octets);
			}

			[DebuggerNonUserCode]
			bool IEquatable<Octets>.Equals(Octets other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Value != other.Value)
				{
					return false;
				}
				if (ContentType != other.ContentType)
				{
					return false;
				}
				return true;
			}

			[DebuggerNonUserCode]
			int object.GetHashCode()
			{
				int num = 1;
				if (Value.Length != 0)
				{
					num ^= Value.GetHashCode();
				}
				if (ContentType != 0)
				{
					num ^= ContentType.GetHashCode();
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
				if (Value.Length != 0)
				{
					output.WriteRawTag(10);
					output.WriteBytes(Value);
				}
				if (ContentType != 0)
				{
					output.WriteRawTag(16);
					output.WriteUInt32(ContentType);
				}
			}

			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				if (Value.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(Value);
				}
				if (ContentType != 0)
				{
					num += 1 + CodedOutputStream.ComputeUInt32Size(ContentType);
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(Octets other)
			{
				if (other != null)
				{
					if (other.Value.Length != 0)
					{
						Value = other.Value;
					}
					if (other.ContentType != 0)
					{
						ContentType = other.ContentType;
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
					case 16u:
						ContentType = input.ReadUInt32();
						break;
					case 10u:
						Value = input.ReadBytes();
						break;
					}
				}
			}

			static Octets()
			{
				Strings.CreateGetStringDelegate(typeof(Octets));
				bool bool_ = false;
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397327), getString_0(107397322)).Replace(getString_0(107397285), getString_0(107397280)));
				if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397275)))
				{
					throw new SecurityException(getString_0(107397250));
				}
				messageParser_0 = new MessageParser<Octets>(() => new Octets());
			}

			[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Types()
		{
			Strings.CreateGetStringDelegate(typeof(Types));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397304), getString_0(107397299)).Replace(getString_0(107397262), getString_0(107397257)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397252)))
			{
				throw new SecurityException(getString_0(107397227));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<Scalar> messageParser_0 = new MessageParser<Scalar>(() => new Scalar());

	public const int int_0 = 1;

	private Types.Type type_0;

	public const int int_1 = 2;

	public const int int_2 = 3;

	public const int int_3 = 5;

	public const int int_4 = 6;

	public const int int_5 = 7;

	public const int int_6 = 8;

	public const int int_7 = 9;

	private object object_0;

	private Enum13 enum13_0;

	[DebuggerNonUserCode]
	public static MessageParser<Scalar> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class30.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Type Type
	{
		get
		{
			return type_0;
		}
		set
		{
			type_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public long VSignedInt
	{
		get
		{
			if (enum13_0 != Enum13.const_1)
			{
				return 0L;
			}
			return (long)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = Enum13.const_1;
		}
	}

	[DebuggerNonUserCode]
	public ulong VUnsignedInt
	{
		get
		{
			if (enum13_0 != Enum13.const_2)
			{
				return 0uL;
			}
			return (ulong)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = Enum13.const_2;
		}
	}

	[DebuggerNonUserCode]
	public Types.Octets VOctets
	{
		get
		{
			if (enum13_0 != Enum13.const_3)
			{
				return null;
			}
			return (Types.Octets)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = ((value != null) ? Enum13.const_3 : Enum13.const_0);
		}
	}

	[DebuggerNonUserCode]
	public double VDouble
	{
		get
		{
			if (enum13_0 != Enum13.const_4)
			{
				return 0.0;
			}
			return (double)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = Enum13.const_4;
		}
	}

	[DebuggerNonUserCode]
	public float VFloat
	{
		get
		{
			if (enum13_0 != Enum13.const_5)
			{
				return 0f;
			}
			return (float)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = Enum13.const_5;
		}
	}

	[DebuggerNonUserCode]
	public bool VBool
	{
		get
		{
			if (enum13_0 != Enum13.const_6)
			{
				return false;
			}
			return (bool)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = Enum13.const_6;
		}
	}

	[DebuggerNonUserCode]
	public Types.String VString
	{
		get
		{
			if (enum13_0 != Enum13.const_7)
			{
				return null;
			}
			return (Types.String)object_0;
		}
		set
		{
			object_0 = value;
			enum13_0 = ((value != null) ? Enum13.const_7 : Enum13.const_0);
		}
	}

	[DebuggerNonUserCode]
	public Enum13 DefaultOneofCase => enum13_0;

	[DebuggerNonUserCode]
	public Scalar()
	{
	}

	[DebuggerNonUserCode]
	public Scalar(Scalar other)
		: this()
	{
		type_0 = other.type_0;
		switch (other.DefaultOneofCase)
		{
		case Enum13.const_1:
			VSignedInt = other.VSignedInt;
			break;
		case Enum13.const_2:
			VUnsignedInt = other.VUnsignedInt;
			break;
		case Enum13.const_3:
			VOctets = other.VOctets.Clone();
			break;
		case Enum13.const_4:
			VDouble = other.VDouble;
			break;
		case Enum13.const_5:
			VFloat = other.VFloat;
			break;
		case Enum13.const_6:
			VBool = other.VBool;
			break;
		case Enum13.const_7:
			VString = other.VString.Clone();
			break;
		case (Enum13)4:
			break;
		}
	}

	[DebuggerNonUserCode]
	public Scalar Clone()
	{
		return new Scalar(this);
	}

	[DebuggerNonUserCode]
	public void method_0()
	{
		enum13_0 = Enum13.const_0;
		object_0 = null;
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Scalar>)this).Equals(obj as Scalar);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Scalar>.Equals(Scalar other)
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
		if (VSignedInt != other.VSignedInt)
		{
			return false;
		}
		if (VUnsignedInt != other.VUnsignedInt)
		{
			return false;
		}
		if (!object.Equals(VOctets, other.VOctets))
		{
			return false;
		}
		if (VDouble != other.VDouble)
		{
			return false;
		}
		if (VFloat != other.VFloat)
		{
			return false;
		}
		if (VBool != other.VBool)
		{
			return false;
		}
		if (!object.Equals(VString, other.VString))
		{
			return false;
		}
		if (DefaultOneofCase != other.DefaultOneofCase)
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
		if (enum13_0 == Enum13.const_1)
		{
			num ^= VSignedInt.GetHashCode();
		}
		if (enum13_0 == Enum13.const_2)
		{
			num ^= VUnsignedInt.GetHashCode();
		}
		if (enum13_0 == Enum13.const_3)
		{
			num ^= VOctets.GetHashCode();
		}
		if (enum13_0 == Enum13.const_4)
		{
			num ^= VDouble.GetHashCode();
		}
		if (enum13_0 == Enum13.const_5)
		{
			num ^= VFloat.GetHashCode();
		}
		if (enum13_0 == Enum13.const_6)
		{
			num ^= VBool.GetHashCode();
		}
		if (enum13_0 == Enum13.const_7)
		{
			num ^= VString.GetHashCode();
		}
		return num ^ (int)enum13_0;
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
		if (enum13_0 == Enum13.const_1)
		{
			output.WriteRawTag(16);
			output.WriteSInt64(VSignedInt);
		}
		if (enum13_0 == Enum13.const_2)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(VUnsignedInt);
		}
		if (enum13_0 == Enum13.const_3)
		{
			output.WriteRawTag(42);
			output.WriteMessage(VOctets);
		}
		if (enum13_0 == Enum13.const_4)
		{
			output.WriteRawTag(49);
			output.WriteDouble(VDouble);
		}
		if (enum13_0 == Enum13.const_5)
		{
			output.WriteRawTag(61);
			output.WriteFloat(VFloat);
		}
		if (enum13_0 == Enum13.const_6)
		{
			output.WriteRawTag(64);
			output.WriteBool(VBool);
		}
		if (enum13_0 == Enum13.const_7)
		{
			output.WriteRawTag(74);
			output.WriteMessage(VString);
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
		if (enum13_0 == Enum13.const_1)
		{
			num += 1 + CodedOutputStream.ComputeSInt64Size(VSignedInt);
		}
		if (enum13_0 == Enum13.const_2)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(VUnsignedInt);
		}
		if (enum13_0 == Enum13.const_3)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(VOctets);
		}
		if (enum13_0 == Enum13.const_4)
		{
			num += 9;
		}
		if (enum13_0 == Enum13.const_5)
		{
			num += 5;
		}
		if (enum13_0 == Enum13.const_6)
		{
			num += 2;
		}
		if (enum13_0 == Enum13.const_7)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(VString);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Scalar other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			switch (other.DefaultOneofCase)
			{
			case Enum13.const_1:
				VSignedInt = other.VSignedInt;
				break;
			case Enum13.const_2:
				VUnsignedInt = other.VUnsignedInt;
				break;
			case Enum13.const_3:
				VOctets = other.VOctets;
				break;
			case Enum13.const_4:
				VDouble = other.VDouble;
				break;
			case Enum13.const_5:
				VFloat = other.VFloat;
				break;
			case Enum13.const_6:
				VBool = other.VBool;
				break;
			case Enum13.const_7:
				VString = other.VString;
				break;
			case (Enum13)4:
				break;
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
				VSignedInt = input.ReadSInt64();
				break;
			case 8u:
				type_0 = (Types.Type)input.ReadEnum();
				break;
			case 42u:
			{
				Types.Octets octets = new Types.Octets();
				if (enum13_0 == Enum13.const_3)
				{
					octets.MergeFrom(VOctets);
				}
				input.ReadMessage(octets);
				VOctets = octets;
				break;
			}
			case 24u:
				VUnsignedInt = input.ReadUInt64();
				break;
			case 61u:
				VFloat = input.ReadFloat();
				break;
			case 49u:
				VDouble = input.ReadDouble();
				break;
			default:
				input.SkipLastField();
				break;
			case 74u:
			{
				Types.String @string = new Types.String();
				if (enum13_0 == Enum13.const_7)
				{
					@string.MergeFrom(VString);
				}
				input.ReadMessage(@string);
				VString = @string;
				break;
			}
			case 64u:
				VBool = input.ReadBool();
				break;
			}
		}
	}
}
