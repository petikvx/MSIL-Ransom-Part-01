using System;
using System.Collections.Generic;

namespace Google.Protobuf.Reflection;

public sealed class CustomOptions
{
	private struct FieldValue
	{
		internal ulong Number { get; }

		internal ByteString ByteString { get; }

		internal FieldValue(ulong number)
		{
			Number = number;
			ByteString = null;
		}

		internal FieldValue(ByteString byteString)
		{
			Number = 0uL;
			ByteString = byteString;
		}
	}

	internal static readonly CustomOptions Empty = new CustomOptions();

	private readonly Dictionary<int, List<FieldValue>> valuesByField = new Dictionary<int, List<FieldValue>>();

	private CustomOptions()
	{
	}

	public bool TryGetBool(int field, out bool value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = lastNumericValue == 1L;
		return lastNumericValue.HasValue;
	}

	public bool TryGetInt32(int field, out int value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = (int)lastNumericValue.GetValueOrDefault();
		return lastNumericValue.HasValue;
	}

	public bool TryGetInt64(int field, out long value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = (long)lastNumericValue.GetValueOrDefault();
		return lastNumericValue.HasValue;
	}

	public bool TryGetFixed32(int field, out uint value)
	{
		return TryGetUInt32(field, out value);
	}

	public bool TryGetFixed64(int field, out ulong value)
	{
		return TryGetUInt64(field, out value);
	}

	public bool TryGetSFixed32(int field, out int value)
	{
		return TryGetInt32(field, out value);
	}

	public bool TryGetSFixed64(int field, out long value)
	{
		return TryGetInt64(field, out value);
	}

	public bool TryGetSInt32(int field, out int value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = CodedInputStream.DecodeZigZag32((uint)lastNumericValue.GetValueOrDefault());
		return lastNumericValue.HasValue;
	}

	public bool TryGetSInt64(int field, out long value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = CodedInputStream.DecodeZigZag64(lastNumericValue.GetValueOrDefault());
		return lastNumericValue.HasValue;
	}

	public bool TryGetUInt32(int field, out uint value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = (uint)lastNumericValue.GetValueOrDefault();
		return lastNumericValue.HasValue;
	}

	public bool TryGetUInt64(int field, out ulong value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = lastNumericValue.GetValueOrDefault();
		return lastNumericValue.HasValue;
	}

	public bool TryGetFloat(int field, out float value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		byte[] bytes = BitConverter.GetBytes((int)lastNumericValue.GetValueOrDefault());
		value = BitConverter.ToSingle(bytes, 0);
		return lastNumericValue.HasValue;
	}

	public bool TryGetDouble(int field, out double value)
	{
		ulong? lastNumericValue = GetLastNumericValue(field);
		value = BitConverter.Int64BitsToDouble((long)lastNumericValue.GetValueOrDefault());
		return lastNumericValue.HasValue;
	}

	public bool TryGetString(int field, out string value)
	{
		ByteString lastByteStringValue = GetLastByteStringValue(field);
		value = lastByteStringValue?.ToStringUtf8();
		return lastByteStringValue != null;
	}

	public bool TryGetBytes(int field, out ByteString value)
	{
		return (value = GetLastByteStringValue(field)) != null;
	}

	public bool TryGetMessage<T>(int field, out T value) where T : class, IMessage, new()
	{
		value = null;
		if (!valuesByField.TryGetValue(field, out var value2))
		{
			return false;
		}
		foreach (FieldValue item in value2)
		{
			if (item.ByteString != null)
			{
				if (value == null)
				{
					value = new T();
				}
				value.MergeFrom(item.ByteString);
			}
		}
		return value != null;
	}

	private ulong? GetLastNumericValue(int field)
	{
		if (!valuesByField.TryGetValue(field, out var value))
		{
			return null;
		}
		int num = value.Count - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (value[num].ByteString == null)
				{
					break;
				}
				num--;
				continue;
			}
			return null;
		}
		return value[num].Number;
	}

	private ByteString GetLastByteStringValue(int field)
	{
		if (!valuesByField.TryGetValue(field, out var value))
		{
			return null;
		}
		int num = value.Count - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (value[num].ByteString != null)
				{
					break;
				}
				num--;
				continue;
			}
			return null;
		}
		return value[num].ByteString;
	}

	internal CustomOptions ReadOrSkipUnknownField(CodedInputStream input)
	{
		uint lastTag = input.LastTag;
		int tagFieldNumber = WireFormat.GetTagFieldNumber(lastTag);
		switch (WireFormat.GetTagWireType(lastTag))
		{
		case WireFormat.WireType.Varint:
			return AddValue(tagFieldNumber, new FieldValue(input.ReadRawVarint64()));
		case WireFormat.WireType.Fixed64:
			return AddValue(tagFieldNumber, new FieldValue(input.ReadFixed64()));
		case WireFormat.WireType.LengthDelimited:
			return AddValue(tagFieldNumber, new FieldValue(input.ReadBytes()));
		default:
			input.SkipLastField();
			return this;
		case WireFormat.WireType.Fixed32:
			return AddValue(tagFieldNumber, new FieldValue(input.ReadFixed32()));
		}
	}

	private CustomOptions AddValue(int field, FieldValue value)
	{
		CustomOptions customOptions = ((valuesByField.Count == 0) ? new CustomOptions() : this);
		if (!customOptions.valuesByField.TryGetValue(field, out var value2))
		{
			value2 = new List<FieldValue>(1);
			customOptions.valuesByField[field] = value2;
		}
		value2.Add(value);
		return customOptions;
	}
}
