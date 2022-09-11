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
using ns15;

namespace Mysqlx.Expr;

internal sealed class Object : IMessage, IMessage<Object>, IEquatable<Object>, IDeepCloneable<Object>
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class ObjectField : IMessage, IMessage<ObjectField>, IEquatable<ObjectField>, IDeepCloneable<ObjectField>
		{
			private static readonly MessageParser<ObjectField> messageParser_0;

			public const int int_0 = 1;

			private string string_0 = getString_0(107397059);

			public const int int_1 = 2;

			private Expr expr_0;

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<ObjectField> Parser => messageParser_0;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Object.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public string Key
			{
				get
				{
					return string_0;
				}
				set
				{
					string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392012));
				}
			}

			[DebuggerNonUserCode]
			public Expr Value
			{
				get
				{
					return expr_0;
				}
				set
				{
					expr_0 = value;
				}
			}

			[DebuggerNonUserCode]
			public ObjectField()
			{
			}

			[DebuggerNonUserCode]
			public ObjectField(ObjectField other)
				: this()
			{
				string_0 = other.string_0;
				Value = ((other.expr_0 != null) ? other.Value.Clone() : null);
			}

			[DebuggerNonUserCode]
			public ObjectField Clone()
			{
				return new ObjectField(this);
			}

			[DebuggerNonUserCode]
			bool object.Equals(object obj)
			{
				return ((IEquatable<ObjectField>)this).Equals(obj as ObjectField);
			}

			[DebuggerNonUserCode]
			bool IEquatable<ObjectField>.Equals(ObjectField other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Key != other.Key)
				{
					return false;
				}
				if (!object.Equals(Value, other.Value))
				{
					return false;
				}
				return true;
			}

			[DebuggerNonUserCode]
			int object.GetHashCode()
			{
				int num = 1;
				if (Key.Length != 0)
				{
					num ^= Key.GetHashCode();
				}
				if (expr_0 != null)
				{
					num ^= Value.GetHashCode();
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
				if (Key.Length != 0)
				{
					output.WriteRawTag(10);
					output.WriteString(Key);
				}
				if (expr_0 != null)
				{
					output.WriteRawTag(18);
					output.WriteMessage(Value);
				}
			}

			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				if (Key.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(Key);
				}
				if (expr_0 != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize(Value);
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(ObjectField other)
			{
				if (other == null)
				{
					return;
				}
				if (other.Key.Length != 0)
				{
					Key = other.Key;
				}
				if (other.expr_0 != null)
				{
					if (expr_0 == null)
					{
						expr_0 = new Expr();
					}
					Value.MergeFrom(other.Value);
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
					case 18u:
						if (expr_0 == null)
						{
							expr_0 = new Expr();
						}
						input.ReadMessage(expr_0);
						break;
					case 10u:
						Key = input.ReadString();
						break;
					}
				}
			}

			static ObjectField()
			{
				Strings.CreateGetStringDelegate(typeof(ObjectField));
				bool bool_ = false;
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397237), getString_0(107397232)).Replace(getString_0(107397195), getString_0(107397190)));
				if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397185)))
				{
					throw new SecurityException(getString_0(107397160));
				}
				messageParser_0 = new MessageParser<ObjectField>(() => new ObjectField());
			}

			[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
		}
	}

	private static readonly MessageParser<Object> messageParser_0;

	public const int int_0 = 1;

	private static readonly FieldCodec<Types.ObjectField> fieldCodec_0;

	private readonly RepeatedField<Types.ObjectField> repeatedField_0 = new RepeatedField<Types.ObjectField>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Object> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[6];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Types.ObjectField> Fld => repeatedField_0;

	[DebuggerNonUserCode]
	public Object()
	{
	}

	[DebuggerNonUserCode]
	public Object(Object other)
		: this()
	{
		repeatedField_0 = other.repeatedField_0.Clone();
	}

	[DebuggerNonUserCode]
	public Object Clone()
	{
		return new Object(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Object>)this).Equals(obj as Object);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Object>.Equals(Object other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		return 1 ^ repeatedField_0.GetHashCode();
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		repeatedField_0.WriteTo(output, fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return 0 + repeatedField_0.CalculateSize(fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Object other)
	{
		if (other != null)
		{
			repeatedField_0.Add(other.repeatedField_0);
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
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
			}
		}
	}

	static Object()
	{
		Strings.CreateGetStringDelegate(typeof(Object));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397231), getString_0(107397226)).Replace(getString_0(107397189), getString_0(107397184)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397179)))
		{
			throw new SecurityException(getString_0(107397154));
		}
		messageParser_0 = new MessageParser<Object>(() => new Object());
		fieldCodec_0 = FieldCodec.ForMessage(10u, Types.ObjectField.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
