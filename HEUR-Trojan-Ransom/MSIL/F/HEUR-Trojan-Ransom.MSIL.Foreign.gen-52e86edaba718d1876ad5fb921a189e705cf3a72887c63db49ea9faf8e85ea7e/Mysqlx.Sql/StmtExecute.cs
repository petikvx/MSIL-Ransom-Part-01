using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace Mysqlx.Sql;

internal sealed class StmtExecute : IMessage<StmtExecute>, IEquatable<StmtExecute>, IDeepCloneable<StmtExecute>, IMessage
{
	private static readonly MessageParser<StmtExecute> messageParser_0;

	public const int int_0 = 3;

	private string string_0 = getString_0(107396804);

	public const int int_1 = 1;

	private ByteString byteString_0 = ByteString.Empty;

	public const int int_2 = 2;

	private static readonly FieldCodec<Any> fieldCodec_0;

	private readonly RepeatedField<Any> repeatedField_0 = new RepeatedField<Any>();

	public const int int_3 = 4;

	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<StmtExecute> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class19.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Namespace
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391757));
		}
	}

	[DebuggerNonUserCode]
	public ByteString Stmt
	{
		get
		{
			return byteString_0;
		}
		set
		{
			byteString_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391757));
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Any> Args => repeatedField_0;

	[DebuggerNonUserCode]
	public bool CompactMetadata
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public StmtExecute()
	{
	}

	[DebuggerNonUserCode]
	public StmtExecute(StmtExecute other)
		: this()
	{
		string_0 = other.string_0;
		byteString_0 = other.byteString_0;
		repeatedField_0 = other.repeatedField_0.Clone();
		bool_0 = other.bool_0;
	}

	[DebuggerNonUserCode]
	public StmtExecute Clone()
	{
		return new StmtExecute(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<StmtExecute>)this).Equals(obj as StmtExecute);
	}

	[DebuggerNonUserCode]
	bool IEquatable<StmtExecute>.Equals(StmtExecute other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Namespace != other.Namespace)
		{
			return false;
		}
		if (Stmt != other.Stmt)
		{
			return false;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		if (CompactMetadata != other.CompactMetadata)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Namespace.Length != 0)
		{
			num ^= Namespace.GetHashCode();
		}
		if (Stmt.Length != 0)
		{
			num ^= Stmt.GetHashCode();
		}
		num ^= repeatedField_0.GetHashCode();
		if (CompactMetadata)
		{
			num ^= CompactMetadata.GetHashCode();
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
		if (Stmt.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(Stmt);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		if (Namespace.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Namespace);
		}
		if (CompactMetadata)
		{
			output.WriteRawTag(32);
			output.WriteBool(CompactMetadata);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Namespace.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Namespace);
		}
		if (Stmt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Stmt);
		}
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (CompactMetadata)
		{
			num += 2;
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(StmtExecute other)
	{
		if (other != null)
		{
			if (other.Namespace.Length != 0)
			{
				Namespace = other.Namespace;
			}
			if (other.Stmt.Length != 0)
			{
				Stmt = other.Stmt;
			}
			repeatedField_0.Add(other.repeatedField_0);
			if (other.CompactMetadata)
			{
				CompactMetadata = other.CompactMetadata;
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
			case 18u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 10u:
				Stmt = input.ReadBytes();
				break;
			default:
				input.SkipLastField();
				break;
			case 32u:
				CompactMetadata = input.ReadBool();
				break;
			case 26u:
				Namespace = input.ReadString();
				break;
			}
		}
	}

	static StmtExecute()
	{
		Strings.CreateGetStringDelegate(typeof(StmtExecute));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396982), getString_0(107396977)).Replace(getString_0(107396940), getString_0(107396935)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396930)))
		{
			throw new SecurityException(getString_0(107396905));
		}
		messageParser_0 = new MessageParser<StmtExecute>(() => new StmtExecute());
		fieldCodec_0 = FieldCodec.ForMessage(18u, Any.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
