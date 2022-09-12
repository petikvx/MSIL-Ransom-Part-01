using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class PendingBuffer
{
	private int VwHkNlJOGzdLssZbTGROKODkykxQ;

	private uint PQSECMBrpdKuwQSEAuTLhFzpdMecA;

	private byte[] dBDQqMWitmmPAbOzGDgIDezrgZMY;

	private int HwALclJnmKEhvJkyEQoZKjdhqbRWA;

	private int qhrNPkQWqnNpdjrPEeeUhMXhbxphA;

	public int BitCount => VwHkNlJOGzdLssZbTGROKODkykxQ;

	public bool IsFlushed => HwALclJnmKEhvJkyEQoZKjdhqbRWA == 0;

	public PendingBuffer()
		: this(4096)
	{
	}

	public PendingBuffer(int bufferSize)
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY = new byte[bufferSize];
	}

	public void AlignToByte()
	{
		if (VwHkNlJOGzdLssZbTGROKODkykxQ > 0)
		{
			dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)PQSECMBrpdKuwQSEAuTLhFzpdMecA;
			if (VwHkNlJOGzdLssZbTGROKODkykxQ > 8)
			{
				dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(PQSECMBrpdKuwQSEAuTLhFzpdMecA >> 8);
			}
		}
		PQSECMBrpdKuwQSEAuTLhFzpdMecA = 0u;
		VwHkNlJOGzdLssZbTGROKODkykxQ = 0;
	}

	public int Flush(byte[] output, int offset, int length)
	{
		if (VwHkNlJOGzdLssZbTGROKODkykxQ >= 8)
		{
			dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)PQSECMBrpdKuwQSEAuTLhFzpdMecA;
			PQSECMBrpdKuwQSEAuTLhFzpdMecA >>= 8;
			VwHkNlJOGzdLssZbTGROKODkykxQ -= 8;
		}
		if (length > HwALclJnmKEhvJkyEQoZKjdhqbRWA - qhrNPkQWqnNpdjrPEeeUhMXhbxphA)
		{
			length = HwALclJnmKEhvJkyEQoZKjdhqbRWA - qhrNPkQWqnNpdjrPEeeUhMXhbxphA;
			Array.Copy(dBDQqMWitmmPAbOzGDgIDezrgZMY, qhrNPkQWqnNpdjrPEeeUhMXhbxphA, output, offset, length);
			qhrNPkQWqnNpdjrPEeeUhMXhbxphA = 0;
			HwALclJnmKEhvJkyEQoZKjdhqbRWA = 0;
			return length;
		}
		Array.Copy(dBDQqMWitmmPAbOzGDgIDezrgZMY, qhrNPkQWqnNpdjrPEeeUhMXhbxphA, output, offset, length);
		qhrNPkQWqnNpdjrPEeeUhMXhbxphA += length;
		return length;
	}

	public void Reset()
	{
		VwHkNlJOGzdLssZbTGROKODkykxQ = 0;
		HwALclJnmKEhvJkyEQoZKjdhqbRWA = 0;
		qhrNPkQWqnNpdjrPEeeUhMXhbxphA = 0;
	}

	public byte[] ToByteArray()
	{
		byte[] array = new byte[HwALclJnmKEhvJkyEQoZKjdhqbRWA - qhrNPkQWqnNpdjrPEeeUhMXhbxphA];
		Array.Copy(dBDQqMWitmmPAbOzGDgIDezrgZMY, qhrNPkQWqnNpdjrPEeeUhMXhbxphA, array, 0, array.Length);
		qhrNPkQWqnNpdjrPEeeUhMXhbxphA = 0;
		HwALclJnmKEhvJkyEQoZKjdhqbRWA = 0;
		return array;
	}

	public void WriteBits(int int_1, int count)
	{
		PQSECMBrpdKuwQSEAuTLhFzpdMecA |= (uint)(int_1 << VwHkNlJOGzdLssZbTGROKODkykxQ);
		VwHkNlJOGzdLssZbTGROKODkykxQ += count;
		if (VwHkNlJOGzdLssZbTGROKODkykxQ >= 16)
		{
			dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)PQSECMBrpdKuwQSEAuTLhFzpdMecA;
			dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(PQSECMBrpdKuwQSEAuTLhFzpdMecA >> 8);
			PQSECMBrpdKuwQSEAuTLhFzpdMecA >>= 16;
			VwHkNlJOGzdLssZbTGROKODkykxQ -= 16;
		}
	}

	public void WriteBlock(byte[] block, int offset, int length)
	{
		Array.Copy(block, offset, dBDQqMWitmmPAbOzGDgIDezrgZMY, HwALclJnmKEhvJkyEQoZKjdhqbRWA, length);
		HwALclJnmKEhvJkyEQoZKjdhqbRWA += length;
	}

	public void WriteByte(int value)
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)value;
	}

	public void WriteInt(int value)
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)value;
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(value >> 8);
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(value >> 16);
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(value >> 24);
	}

	public void WriteShort(int value)
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)value;
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(value >> 8);
	}

	public void WriteShortMSB(int int_1)
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)(int_1 >> 8);
		dBDQqMWitmmPAbOzGDgIDezrgZMY[HwALclJnmKEhvJkyEQoZKjdhqbRWA++] = (byte)int_1;
	}
}
