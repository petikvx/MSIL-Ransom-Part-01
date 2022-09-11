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

internal sealed class Identifier : IMessage, IMessage<Identifier>, IEquatable<Identifier>, IDeepCloneable<Identifier>
{
	private static readonly MessageParser<Identifier> messageParser_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107397002);

	public const int int_1 = 2;

	private string string_1 = getString_0(107397002);

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Identifier> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391955));
		}
	}

	[DebuggerNonUserCode]
	public string SchemaName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = ProtoPreconditions.CheckNotNull(value, getString_0(107391955));
		}
	}

	[DebuggerNonUserCode]
	public Identifier()
	{
	}

	[DebuggerNonUserCode]
	public Identifier(Identifier other)
		: this()
	{
		string_0 = other.string_0;
		string_1 = other.string_1;
	}

	[DebuggerNonUserCode]
	public Identifier Clone()
	{
		return new Identifier(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Identifier>)this).Equals(obj as Identifier);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Identifier>.Equals(Identifier other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (SchemaName != other.SchemaName)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (SchemaName.Length != 0)
		{
			num ^= SchemaName.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (SchemaName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SchemaName);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (SchemaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SchemaName);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Identifier other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.SchemaName.Length != 0)
			{
				SchemaName = other.SchemaName;
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
			case 18u:
				SchemaName = input.ReadString();
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}

	static Identifier()
	{
		Strings.CreateGetStringDelegate(typeof(Identifier));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397180), getString_0(107397175)).Replace(getString_0(107397138), getString_0(107397133)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397128)))
		{
			throw new SecurityException(getString_0(107397103));
		}
		messageParser_0 = new MessageParser<Identifier>(() => new Identifier());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
