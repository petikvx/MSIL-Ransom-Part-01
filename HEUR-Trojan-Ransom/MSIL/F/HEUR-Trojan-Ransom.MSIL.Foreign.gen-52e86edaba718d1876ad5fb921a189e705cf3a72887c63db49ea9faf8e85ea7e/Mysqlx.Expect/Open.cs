using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;

namespace Mysqlx.Expect;

internal sealed class Open : IMessage, IMessage<Open>, IEquatable<Open>, IDeepCloneable<Open>
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum Enum10
		{
			[OriginalName("EXPECT_CTX_COPY_PREV")]
			const_0,
			[OriginalName("EXPECT_CTX_EMPTY")]
			const_1
		}

		internal sealed class Condition : IMessage, IMessage<Condition>, IEquatable<Condition>, IDeepCloneable<Condition>
		{
			[DebuggerNonUserCode]
			internal static class Class29
			{
				public enum Enum11
				{
					[OriginalName("NONE")]
					const_0,
					[OriginalName("EXPECT_NO_ERROR")]
					const_1,
					[OriginalName("EXPECT_FIELD_EXIST")]
					const_2,
					[OriginalName("EXPECT_DOCID_GENERATED")]
					const_3
				}

				public enum Enum12
				{
					[OriginalName("EXPECT_OP_SET")]
					const_0,
					[OriginalName("EXPECT_OP_UNSET")]
					const_1
				}

				[NonSerialized]
				internal static GetString getString_0;

				static Class29()
				{
					Strings.CreateGetStringDelegate(typeof(Class29));
					bool bool_ = false;
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397267), getString_0(107397262)).Replace(getString_0(107397225), getString_0(107397220)));
					if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397215)))
					{
						throw new SecurityException(getString_0(107397190));
					}
				}

				[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
				[return: MarshalAs(UnmanagedType.Bool)]
				private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
			}

			private static readonly MessageParser<Condition> messageParser_0;

			private UnknownFieldSet unknownFieldSet_0;

			public const int int_0 = 1;

			private uint uint_0;

			public const int int_1 = 2;

			private ByteString byteString_0 = ByteString.Empty;

			public const int int_2 = 3;

			private Class29.Enum12 enum12_0;

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<Condition> Parser => messageParser_0;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Open.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public uint ConditionKey
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
			public ByteString ConditionValue
			{
				get
				{
					return byteString_0;
				}
				set
				{
					byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392041));
				}
			}

			[DebuggerNonUserCode]
			public Class29.Enum12 Op
			{
				get
				{
					return enum12_0;
				}
				set
				{
					enum12_0 = value;
				}
			}

			[DebuggerNonUserCode]
			public Condition()
			{
			}

			[DebuggerNonUserCode]
			public Condition(Condition other)
				: this()
			{
				uint_0 = other.uint_0;
				byteString_0 = other.byteString_0;
				enum12_0 = other.enum12_0;
				unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
			}

			[DebuggerNonUserCode]
			public Condition Clone()
			{
				return new Condition(this);
			}

			[DebuggerNonUserCode]
			bool object.Equals(object obj)
			{
				return ((IEquatable<Condition>)this).Equals(obj as Condition);
			}

			[DebuggerNonUserCode]
			bool IEquatable<Condition>.Equals(Condition other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (ConditionKey != other.ConditionKey)
				{
					return false;
				}
				if (ConditionValue != other.ConditionValue)
				{
					return false;
				}
				if (Op != other.Op)
				{
					return false;
				}
				return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
			}

			[DebuggerNonUserCode]
			int object.GetHashCode()
			{
				int num = 1;
				if (ConditionKey != 0)
				{
					num ^= ConditionKey.GetHashCode();
				}
				if (ConditionValue.Length != 0)
				{
					num ^= ConditionValue.GetHashCode();
				}
				if (Op != 0)
				{
					num ^= Op.GetHashCode();
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
				if (ConditionKey != 0)
				{
					output.WriteRawTag(8);
					output.WriteUInt32(ConditionKey);
				}
				if (ConditionValue.Length != 0)
				{
					output.WriteRawTag(18);
					output.WriteBytes(ConditionValue);
				}
				if (Op != 0)
				{
					output.WriteRawTag(24);
					output.WriteEnum((int)Op);
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
				if (ConditionKey != 0)
				{
					num += 1 + CodedOutputStream.ComputeUInt32Size(ConditionKey);
				}
				if (ConditionValue.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(ConditionValue);
				}
				if (Op != 0)
				{
					num += 1 + CodedOutputStream.ComputeEnumSize((int)Op);
				}
				if (unknownFieldSet_0 != null)
				{
					num += unknownFieldSet_0.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(Condition other)
			{
				if (other != null)
				{
					if (other.ConditionKey != 0)
					{
						ConditionKey = other.ConditionKey;
					}
					if (other.ConditionValue.Length != 0)
					{
						ConditionValue = other.ConditionValue;
					}
					if (other.Op != 0)
					{
						Op = other.Op;
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
					case 24u:
						enum12_0 = (Class29.Enum12)input.ReadEnum();
						break;
					case 18u:
						ConditionValue = input.ReadBytes();
						break;
					case 8u:
						ConditionKey = input.ReadUInt32();
						break;
					}
				}
			}

			static Condition()
			{
				Strings.CreateGetStringDelegate(typeof(Condition));
				messageParser_0 = new MessageParser<Condition>(() => new Condition());
			}
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Types()
		{
			Strings.CreateGetStringDelegate(typeof(Types));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397254), getString_0(107397249)).Replace(getString_0(107397212), getString_0(107397207)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397202)))
			{
				throw new SecurityException(getString_0(107397177));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<Open> messageParser_0 = new MessageParser<Open>(() => new Open());

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Types.Enum10 enum10_0;

	public const int int_1 = 2;

	private static readonly FieldCodec<Types.Condition> fieldCodec_0 = FieldCodec.ForMessage(18u, Types.Condition.Parser);

	private readonly RepeatedField<Types.Condition> repeatedField_0 = new RepeatedField<Types.Condition>();

	[DebuggerNonUserCode]
	public static MessageParser<Open> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class28.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Enum10 Op
	{
		get
		{
			return enum10_0;
		}
		set
		{
			enum10_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Types.Condition> Cond => repeatedField_0;

	[DebuggerNonUserCode]
	public Open()
	{
	}

	[DebuggerNonUserCode]
	public Open(Open other)
		: this()
	{
		enum10_0 = other.enum10_0;
		repeatedField_0 = other.repeatedField_0.Clone();
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Open Clone()
	{
		return new Open(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Open>)this).Equals(obj as Open);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Open>.Equals(Open other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Op != other.Op)
		{
			return false;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Op != 0)
		{
			num ^= Op.GetHashCode();
		}
		num ^= repeatedField_0.GetHashCode();
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
		if (Op != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Op);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Op != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Op);
		}
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Open other)
	{
		if (other != null)
		{
			if (other.Op != 0)
			{
				Op = other.Op;
			}
			repeatedField_0.Add(other.repeatedField_0);
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
			case 18u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 8u:
				enum10_0 = (Types.Enum10)input.ReadEnum();
				break;
			}
		}
	}
}
