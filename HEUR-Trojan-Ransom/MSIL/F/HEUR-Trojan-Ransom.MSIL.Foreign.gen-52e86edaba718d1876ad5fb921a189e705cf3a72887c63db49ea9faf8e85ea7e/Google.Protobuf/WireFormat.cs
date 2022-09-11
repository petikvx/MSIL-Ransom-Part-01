namespace Google.Protobuf;

public static class WireFormat
{
	public enum WireType : uint
	{
		Varint,
		Fixed64,
		LengthDelimited,
		StartGroup,
		EndGroup,
		Fixed32
	}

	private const int TagTypeBits = 3;

	private const uint TagTypeMask = 7u;

	public static WireType GetTagWireType(uint tag)
	{
		return (WireType)(tag & 7u);
	}

	public static int GetTagFieldNumber(uint tag)
	{
		return (int)tag >> 3;
	}

	public static uint MakeTag(int fieldNumber, WireType wireType)
	{
		return (uint)(fieldNumber << 3) | (uint)wireType;
	}
}
