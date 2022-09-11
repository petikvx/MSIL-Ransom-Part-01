using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns2;

namespace Mysqlx.Crud;

internal sealed class DropView : IMessage, IMessage<DropView>, IEquatable<DropView>, IDeepCloneable<DropView>
{
	private static readonly MessageParser<DropView> messageParser_0 = new MessageParser<DropView>(() => new DropView());

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Collection collection_0;

	public const int int_1 = 2;

	private bool bool_0;

	[DebuggerNonUserCode]
	public static MessageParser<DropView> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[12];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Collection Collection
	{
		get
		{
			return collection_0;
		}
		set
		{
			collection_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public bool IfExists
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
	public DropView()
	{
	}

	[DebuggerNonUserCode]
	public DropView(DropView other)
		: this()
	{
		Collection = ((other.collection_0 != null) ? other.Collection.Clone() : null);
		bool_0 = other.bool_0;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public DropView Clone()
	{
		return new DropView(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<DropView>)this).Equals(obj as DropView);
	}

	[DebuggerNonUserCode]
	bool IEquatable<DropView>.Equals(DropView other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Collection, other.Collection))
		{
			return false;
		}
		if (IfExists != other.IfExists)
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (collection_0 != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (IfExists)
		{
			num ^= IfExists.GetHashCode();
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
		if (collection_0 != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Collection);
		}
		if (IfExists)
		{
			output.WriteRawTag(16);
			output.WriteBool(IfExists);
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
		if (collection_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (IfExists)
		{
			num += 2;
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(DropView other)
	{
		if (other == null)
		{
			return;
		}
		if (other.collection_0 != null)
		{
			if (collection_0 == null)
			{
				collection_0 = new Collection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.IfExists)
		{
			IfExists = other.IfExists;
		}
		unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
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
			case 16u:
				IfExists = input.ReadBool();
				break;
			case 10u:
				if (collection_0 == null)
				{
					collection_0 = new Collection();
				}
				input.ReadMessage(collection_0);
				break;
			}
		}
	}
}
