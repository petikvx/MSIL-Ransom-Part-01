using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace Google.Protobuf;

internal sealed class UnknownField
{
	private List<ulong> varintList;

	private List<uint> fixed32List;

	private List<ulong> fixed64List;

	private List<ByteString> lengthDelimitedList;

	public override bool Equals(object other)
	{
		if (this == other)
		{
			return true;
		}
		if (other is UnknownField unknownField && Lists.Equals(varintList, unknownField.varintList) && Lists.Equals(fixed32List, unknownField.fixed32List) && Lists.Equals(fixed64List, unknownField.fixed64List))
		{
			return Lists.Equals(lengthDelimitedList, unknownField.lengthDelimitedList);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((2021 + Lists.GetHashCode(varintList)) * 47 + Lists.GetHashCode(fixed32List)) * 47 + Lists.GetHashCode(fixed64List)) * 47 + Lists.GetHashCode(lengthDelimitedList);
	}

	internal void WriteTo(int fieldNumber, CodedOutputStream output)
	{
		if (varintList != null)
		{
			foreach (ulong varint in varintList)
			{
				output.WriteTag(fieldNumber, WireFormat.WireType.Varint);
				output.WriteUInt64(varint);
			}
		}
		if (fixed32List != null)
		{
			foreach (uint @fixed in fixed32List)
			{
				output.WriteTag(fieldNumber, WireFormat.WireType.Fixed32);
				output.WriteFixed32(@fixed);
			}
		}
		if (fixed64List != null)
		{
			foreach (ulong fixed2 in fixed64List)
			{
				output.WriteTag(fieldNumber, WireFormat.WireType.Fixed64);
				output.WriteFixed64(fixed2);
			}
		}
		if (lengthDelimitedList == null)
		{
			return;
		}
		foreach (ByteString lengthDelimited in lengthDelimitedList)
		{
			output.WriteTag(fieldNumber, WireFormat.WireType.LengthDelimited);
			output.WriteBytes(lengthDelimited);
		}
	}

	internal int GetSerializedSize(int fieldNumber)
	{
		int num = 0;
		if (varintList != null)
		{
			num += CodedOutputStream.ComputeTagSize(fieldNumber) * varintList.Count;
			foreach (ulong varint in varintList)
			{
				num += CodedOutputStream.ComputeUInt64Size(varint);
			}
		}
		if (fixed32List != null)
		{
			num += CodedOutputStream.ComputeTagSize(fieldNumber) * fixed32List.Count;
			num += CodedOutputStream.ComputeFixed32Size(1u) * fixed32List.Count;
		}
		if (fixed64List != null)
		{
			num += CodedOutputStream.ComputeTagSize(fieldNumber) * fixed64List.Count;
			num += CodedOutputStream.ComputeFixed64Size(1uL) * fixed64List.Count;
		}
		if (lengthDelimitedList != null)
		{
			num += CodedOutputStream.ComputeTagSize(fieldNumber) * lengthDelimitedList.Count;
			{
				foreach (ByteString lengthDelimited in lengthDelimitedList)
				{
					num += CodedOutputStream.ComputeBytesSize(lengthDelimited);
				}
				return num;
			}
		}
		return num;
	}

	internal UnknownField MergeFrom(UnknownField other)
	{
		varintList = AddAll(varintList, other.varintList);
		fixed32List = AddAll(fixed32List, other.fixed32List);
		fixed64List = AddAll(fixed64List, other.fixed64List);
		lengthDelimitedList = AddAll(lengthDelimitedList, other.lengthDelimitedList);
		return this;
	}

	private static List<T> AddAll<T>(List<T> current, IList<T> extras)
	{
		if (extras.Count == 0)
		{
			return current;
		}
		if (current == null)
		{
			current = new List<T>(extras);
		}
		else
		{
			current.AddRange(extras);
		}
		return current;
	}

	internal UnknownField AddVarint(ulong value)
	{
		varintList = Add(varintList, value);
		return this;
	}

	internal UnknownField AddFixed32(uint value)
	{
		fixed32List = Add(fixed32List, value);
		return this;
	}

	internal UnknownField AddFixed64(ulong value)
	{
		fixed64List = Add(fixed64List, value);
		return this;
	}

	internal UnknownField AddLengthDelimited(ByteString value)
	{
		lengthDelimitedList = Add(lengthDelimitedList, value);
		return this;
	}

	private static List<T> Add<T>(List<T> list, T value)
	{
		if (list == null)
		{
			list = new List<T>();
		}
		list.Add(value);
		return list;
	}
}
