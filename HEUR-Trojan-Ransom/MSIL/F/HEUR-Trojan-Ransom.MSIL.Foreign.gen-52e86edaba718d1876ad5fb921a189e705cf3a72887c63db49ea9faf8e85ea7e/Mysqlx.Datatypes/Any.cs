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

internal sealed class Any : IMessage, IMessage<Any>, IEquatable<Any>, IDeepCloneable<Any>
{
	[DebuggerNonUserCode]
	internal static class Class31
	{
		internal enum Enum14
		{
			[OriginalName("NONE")]
			const_0,
			[OriginalName("SCALAR")]
			const_1,
			[OriginalName("OBJECT")]
			const_2,
			[OriginalName("ARRAY")]
			const_3
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Class31()
		{
			Strings.CreateGetStringDelegate(typeof(Class31));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397358), getString_0(107397353)).Replace(getString_0(107397316), getString_0(107397311)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397306)))
			{
				throw new SecurityException(getString_0(107397281));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<Any> messageParser_0 = new MessageParser<Any>(() => new Any());

	public const int int_0 = 1;

	private Class31.Enum14 enum14_0;

	public const int int_1 = 2;

	private Scalar scalar_0;

	public const int int_2 = 3;

	private Object object_0;

	public const int int_3 = 4;

	private Array array_0;

	[DebuggerNonUserCode]
	public static MessageParser<Any> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class30.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Class31.Enum14 Type
	{
		get
		{
			return enum14_0;
		}
		set
		{
			enum14_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Scalar Scalar
	{
		get
		{
			return scalar_0;
		}
		set
		{
			scalar_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Object Obj
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Array Array
	{
		get
		{
			return array_0;
		}
		set
		{
			array_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public Any()
	{
	}

	[DebuggerNonUserCode]
	public Any(Any other)
		: this()
	{
		enum14_0 = other.enum14_0;
		Scalar = ((other.scalar_0 != null) ? other.Scalar.Clone() : null);
		Obj = ((other.object_0 != null) ? other.Obj.Clone() : null);
		Array = ((other.array_0 != null) ? other.Array.Clone() : null);
	}

	[DebuggerNonUserCode]
	public Any Clone()
	{
		return new Any(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Any>)this).Equals(obj as Any);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Any>.Equals(Any other)
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
		if (!object.Equals(Scalar, other.Scalar))
		{
			return false;
		}
		if (!object.Equals(Obj, other.Obj))
		{
			return false;
		}
		if (!object.Equals(Array, other.Array))
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
		if (scalar_0 != null)
		{
			num ^= Scalar.GetHashCode();
		}
		if (object_0 != null)
		{
			num ^= Obj.GetHashCode();
		}
		if (array_0 != null)
		{
			num ^= Array.GetHashCode();
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
		if (scalar_0 != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Scalar);
		}
		if (object_0 != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Obj);
		}
		if (array_0 != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Array);
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
		if (scalar_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scalar);
		}
		if (object_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Obj);
		}
		if (array_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Array);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Any other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		if (other.scalar_0 != null)
		{
			if (scalar_0 == null)
			{
				scalar_0 = new Scalar();
			}
			Scalar.MergeFrom(other.Scalar);
		}
		if (other.object_0 != null)
		{
			if (object_0 == null)
			{
				object_0 = new Object();
			}
			Obj.MergeFrom(other.Obj);
		}
		if (other.array_0 != null)
		{
			if (array_0 == null)
			{
				array_0 = new Array();
			}
			Array.MergeFrom(other.Array);
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
				if (scalar_0 == null)
				{
					scalar_0 = new Scalar();
				}
				input.ReadMessage(scalar_0);
				break;
			case 8u:
				enum14_0 = (Class31.Enum14)input.ReadEnum();
				break;
			default:
				input.SkipLastField();
				break;
			case 34u:
				if (array_0 == null)
				{
					array_0 = new Array();
				}
				input.ReadMessage(array_0);
				break;
			case 26u:
				if (object_0 == null)
				{
					object_0 = new Object();
				}
				input.ReadMessage(object_0);
				break;
			}
		}
	}
}
