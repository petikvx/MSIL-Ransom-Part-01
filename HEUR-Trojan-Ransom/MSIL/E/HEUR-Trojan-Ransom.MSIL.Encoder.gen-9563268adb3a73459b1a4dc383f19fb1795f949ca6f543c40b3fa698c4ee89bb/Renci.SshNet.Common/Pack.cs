namespace Renci.SshNet.Common;

internal static class Pack
{
	internal static ushort LittleEndianToUInt16(byte[] buffer)
	{
		return (ushort)(buffer[0] | (ushort)(buffer[1] << 8));
	}

	internal static uint LittleEndianToUInt32(byte[] buffer, int offset)
	{
		return (uint)(buffer[offset] | (buffer[offset + 1] << 8) | (buffer[offset + 2] << 16) | (buffer[offset + 3] << 24));
	}

	internal static uint LittleEndianToUInt32(byte[] buffer)
	{
		return (uint)(buffer[0] | (buffer[1] << 8) | (buffer[2] << 16) | (buffer[3] << 24));
	}

	internal static ulong LittleEndianToUInt64(byte[] buffer)
	{
		return buffer[0] | ((ulong)buffer[1] << 8) | ((ulong)buffer[2] << 16) | ((ulong)buffer[3] << 24) | ((ulong)buffer[4] << 32) | ((ulong)buffer[5] << 40) | ((ulong)buffer[6] << 48) | ((ulong)buffer[7] << 56);
	}

	internal static byte[] UInt16ToLittleEndian(ushort value)
	{
		byte[] array = new byte[2];
		UInt16ToLittleEndian(value, array);
		return array;
	}

	internal static void UInt16ToLittleEndian(ushort value, byte[] buffer)
	{
		buffer[0] = (byte)(value & 0xFFu);
		buffer[1] = (byte)((value & 0xFF00) >> 8);
	}

	internal static byte[] UInt32ToLittleEndian(uint value)
	{
		byte[] array = new byte[4];
		UInt32ToLittleEndian(value, array);
		return array;
	}

	internal static void UInt32ToLittleEndian(uint value, byte[] buffer)
	{
		buffer[0] = (byte)(value & 0xFFu);
		buffer[1] = (byte)((value & 0xFF00) >> 8);
		buffer[2] = (byte)((value & 0xFF0000) >> 16);
		buffer[3] = (byte)((value & 0xFF000000u) >> 24);
	}

	internal static void UInt32ToLittleEndian(uint value, byte[] buffer, int offset)
	{
		buffer[offset] = (byte)(value & 0xFFu);
		buffer[offset + 1] = (byte)((value & 0xFF00) >> 8);
		buffer[offset + 2] = (byte)((value & 0xFF0000) >> 16);
		buffer[offset + 3] = (byte)((value & 0xFF000000u) >> 24);
	}

	internal static byte[] UInt64ToLittleEndian(ulong value)
	{
		byte[] array = new byte[8];
		UInt64ToLittleEndian(value, array);
		return array;
	}

	internal static void UInt64ToLittleEndian(ulong value, byte[] buffer)
	{
		buffer[0] = (byte)(value & 0xFFuL);
		buffer[1] = (byte)((value & 0xFF00L) >> 8);
		buffer[2] = (byte)((value & 0xFF0000L) >> 16);
		buffer[3] = (byte)((value & 0xFF000000L) >> 24);
		buffer[4] = (byte)((value & 0xFF00000000L) >> 32);
		buffer[5] = (byte)((value & 0xFF0000000000L) >> 40);
		buffer[6] = (byte)((value & 0xFF000000000000L) >> 48);
		buffer[7] = (byte)((value & 0xFF00000000000000uL) >> 56);
	}

	internal static byte[] UInt16ToBigEndian(ushort value)
	{
		byte[] array = new byte[2];
		UInt16ToBigEndian(value, array);
		return array;
	}

	internal static void UInt16ToBigEndian(ushort value, byte[] buffer)
	{
		buffer[0] = (byte)(value >> 8);
		buffer[1] = (byte)(value & 0xFFu);
	}

	internal static void UInt16ToBigEndian(ushort value, byte[] buffer, int offset)
	{
		buffer[offset] = (byte)(value >> 8);
		buffer[offset + 1] = (byte)(value & 0xFFu);
	}

	internal static void UInt32ToBigEndian(uint value, byte[] buffer)
	{
		buffer[0] = (byte)((value & 0xFF000000u) >> 24);
		buffer[1] = (byte)((value & 0xFF0000) >> 16);
		buffer[2] = (byte)((value & 0xFF00) >> 8);
		buffer[3] = (byte)(value & 0xFFu);
	}

	internal static void UInt32ToBigEndian(uint value, byte[] buffer, int offset)
	{
		buffer[offset++] = (byte)((value & 0xFF000000u) >> 24);
		buffer[offset++] = (byte)((value & 0xFF0000) >> 16);
		buffer[offset++] = (byte)((value & 0xFF00) >> 8);
		buffer[offset] = (byte)(value & 0xFFu);
	}

	internal static byte[] UInt32ToBigEndian(uint value)
	{
		byte[] array = new byte[4];
		UInt32ToBigEndian(value, array);
		return array;
	}

	internal static byte[] UInt64ToBigEndian(ulong value)
	{
		return new byte[8]
		{
			(byte)((value & 0xFF00000000000000uL) >> 56),
			(byte)((value & 0xFF000000000000L) >> 48),
			(byte)((value & 0xFF0000000000L) >> 40),
			(byte)((value & 0xFF00000000L) >> 32),
			(byte)((value & 0xFF000000L) >> 24),
			(byte)((value & 0xFF0000L) >> 16),
			(byte)((value & 0xFF00L) >> 8),
			(byte)(value & 0xFFuL)
		};
	}

	internal static ushort BigEndianToUInt16(byte[] buffer)
	{
		return (ushort)((buffer[0] << 8) | buffer[1]);
	}

	internal static uint BigEndianToUInt32(byte[] buffer, int offset)
	{
		return (uint)((buffer[offset] << 24) | (buffer[offset + 1] << 16) | (buffer[offset + 2] << 8) | buffer[offset + 3]);
	}

	internal static uint BigEndianToUInt32(byte[] buffer)
	{
		return (uint)((buffer[0] << 24) | (buffer[1] << 16) | (buffer[2] << 8) | buffer[3]);
	}

	internal static ulong BigEndianToUInt64(byte[] buffer)
	{
		return ((ulong)buffer[0] << 56) | ((ulong)buffer[1] << 48) | ((ulong)buffer[2] << 40) | ((ulong)buffer[3] << 32) | ((ulong)buffer[4] << 24) | ((ulong)buffer[5] << 16) | ((ulong)buffer[6] << 8) | buffer[7];
	}
}
