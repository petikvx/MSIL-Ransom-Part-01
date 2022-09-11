using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

public sealed class UnknownFieldSet
{
	private readonly IDictionary<int, UnknownField> fields;

	private int lastFieldNumber;

	private UnknownField lastField;

	[NonSerialized]
	internal static GetString getString_0;

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
			throw new ArgumentOutOfRangeException(getString_0(107463072), getString_0(107463031));
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
			throw new InvalidOperationException(getString_0(107462372));
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
			throw new InvalidProtocolBufferException(getString_0(107463018));
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
			throw new ArgumentOutOfRangeException(getString_0(107463072), getString_0(107463031));
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

	static UnknownFieldSet()
	{
		Strings.CreateGetStringDelegate(typeof(UnknownFieldSet));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399845), getString_0(107399840)).Replace(getString_0(107399803), getString_0(107399798)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399793)))
		{
			throw new SecurityException(getString_0(107399768));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
