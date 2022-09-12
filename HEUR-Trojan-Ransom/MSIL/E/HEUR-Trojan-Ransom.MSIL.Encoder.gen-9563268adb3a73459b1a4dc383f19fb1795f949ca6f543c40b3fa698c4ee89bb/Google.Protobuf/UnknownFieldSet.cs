using System;
using System.Collections.Generic;

namespace Google.Protobuf;

public sealed class UnknownFieldSet
{
	private readonly IDictionary<int, UnknownField> fields;

	private int lastFieldNumber;

	private UnknownField lastField;

	internal UnknownFieldSet()
	{
		fields = new Dictionary<int, UnknownField>();
	}

	internal bool HasField(int field)
	{
		return fields.ContainsKey(field);
	}

	public void WriteTo(CodedOutputStream output)
	{
		foreach (KeyValuePair<int, UnknownField> field in fields)
		{
			field.Value.WriteTo(field.Key, output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		foreach (KeyValuePair<int, UnknownField> field in fields)
		{
			num += field.Value.GetSerializedSize(field.Key);
		}
		return num;
	}

	public override bool Equals(object other)
	{
		if (this == other)
		{
			return true;
		}
		IDictionary<int, UnknownField> dictionary = (other as UnknownFieldSet).fields;
		if (fields.Count != dictionary.Count)
		{
			return false;
		}
		foreach (KeyValuePair<int, UnknownField> field in fields)
		{
			if (dictionary.TryGetValue(field.Key, out var value))
			{
				if (!field.Value.Equals(value))
				{
					return false;
				}
				continue;
			}
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		int num = 1;
		foreach (KeyValuePair<int, UnknownField> field in fields)
		{
			int num2 = field.Key.GetHashCode() ^ field.Value.GetHashCode();
			num ^= num2;
		}
		return num;
	}

	private UnknownField GetOrAddField(int number)
	{
		if (lastField != null && number == lastFieldNumber)
		{
			return lastField;
		}
		if (number == 0)
		{
			return null;
		}
		if (fields.TryGetValue(number, out var value))
		{
			return value;
		}
		lastField = new UnknownField();
		AddOrReplaceField(number, lastField);
		lastFieldNumber = number;
		return lastField;
	}

	internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field)
	{
		if (number == 0)
		{
			throw new ArgumentOutOfRangeException("number", "Zero is not a valid field number.");
		}
		fields[number] = field;
		return this;
	}

	private void MergeFieldFrom(CodedInputStream input)
	{
		uint lastTag = input.LastTag;
		int tagFieldNumber = WireFormat.GetTagFieldNumber(lastTag);
		switch (WireFormat.GetTagWireType(lastTag))
		{
		default:
			throw new InvalidOperationException("Wire Type is invalid.");
		case WireFormat.WireType.Varint:
		{
			ulong value4 = input.ReadUInt64();
			GetOrAddField(tagFieldNumber).AddVarint(value4);
			break;
		}
		case WireFormat.WireType.Fixed64:
		{
			ulong value3 = input.ReadFixed64();
			GetOrAddField(tagFieldNumber).AddFixed64(value3);
			break;
		}
		case WireFormat.WireType.LengthDelimited:
		{
			ByteString value2 = input.ReadBytes();
			GetOrAddField(tagFieldNumber).AddLengthDelimited(value2);
			break;
		}
		case WireFormat.WireType.StartGroup:
			input.SkipGroup(lastTag);
			break;
		case WireFormat.WireType.EndGroup:
			throw new InvalidProtocolBufferException("Merge an unknown field of end-group tag, indicating that the corresponding start-group was missing.");
		case WireFormat.WireType.Fixed32:
		{
			uint value = input.ReadFixed32();
			GetOrAddField(tagFieldNumber).AddFixed32(value);
			break;
		}
		}
	}

	public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input)
	{
		if (input.DiscardUnknownFields)
		{
			input.SkipLastField();
			return unknownFields;
		}
		if (unknownFields == null)
		{
			unknownFields = new UnknownFieldSet();
		}
		unknownFields.MergeFieldFrom(input);
		return unknownFields;
	}

	private UnknownFieldSet MergeFrom(UnknownFieldSet other)
	{
		if (other != null)
		{
			foreach (KeyValuePair<int, UnknownField> field in other.fields)
			{
				MergeField(field.Key, field.Value);
			}
			return this;
		}
		return this;
	}

	public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other)
	{
		if (other == null)
		{
			return unknownFields;
		}
		if (unknownFields == null)
		{
			unknownFields = new UnknownFieldSet();
		}
		unknownFields.MergeFrom(other);
		return unknownFields;
	}

	private UnknownFieldSet MergeField(int number, UnknownField field)
	{
		if (number == 0)
		{
			throw new ArgumentOutOfRangeException("number", "Zero is not a valid field number.");
		}
		if (HasField(number))
		{
			GetOrAddField(number).MergeFrom(field);
		}
		else
		{
			AddOrReplaceField(number, field);
		}
		return this;
	}

	public static UnknownFieldSet Clone(UnknownFieldSet other)
	{
		if (other == null)
		{
			return null;
		}
		UnknownFieldSet unknownFieldSet = new UnknownFieldSet();
		unknownFieldSet.MergeFrom(other);
		return unknownFieldSet;
	}
}
