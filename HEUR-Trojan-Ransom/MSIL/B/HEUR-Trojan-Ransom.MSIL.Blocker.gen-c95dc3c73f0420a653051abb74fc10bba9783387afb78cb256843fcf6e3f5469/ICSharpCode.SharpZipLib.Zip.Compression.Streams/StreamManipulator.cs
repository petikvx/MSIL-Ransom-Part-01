using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class StreamManipulator
{
	private int CDVIbmiuNYbVbAjCBjumFRFZVedZB;

	private uint dBDQqMWitmmPAbOzGDgIDezrgZMY;

	private byte[] pHuctMMfPlvQcAsYoUOpwgoeZPoq;

	private int eCTfyiLYePnxaIgvugFtiapXxLkVA;

	private int DJLPNuflaAdBTrPNYNRivsXXTDNO;

	public int AvailableBits => CDVIbmiuNYbVbAjCBjumFRFZVedZB;

	public int AvailableBytes => eCTfyiLYePnxaIgvugFtiapXxLkVA - DJLPNuflaAdBTrPNYNRivsXXTDNO + (CDVIbmiuNYbVbAjCBjumFRFZVedZB >> 3);

	public bool IsNeedingInput => DJLPNuflaAdBTrPNYNRivsXXTDNO == eCTfyiLYePnxaIgvugFtiapXxLkVA;

	public int CopyBytes(byte[] output, int offset, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (((uint)CDVIbmiuNYbVbAjCBjumFRFZVedZB & 7u) != 0)
		{
			throw new InvalidOperationException("Bit buffer is not byte aligned!");
		}
		int num = 0;
		while (CDVIbmiuNYbVbAjCBjumFRFZVedZB > 0 && length > 0)
		{
			output[offset++] = (byte)dBDQqMWitmmPAbOzGDgIDezrgZMY;
			dBDQqMWitmmPAbOzGDgIDezrgZMY >>= 8;
			CDVIbmiuNYbVbAjCBjumFRFZVedZB -= 8;
			length--;
			num++;
		}
		if (length != 0)
		{
			int num2 = eCTfyiLYePnxaIgvugFtiapXxLkVA - DJLPNuflaAdBTrPNYNRivsXXTDNO;
			if (length > num2)
			{
				length = num2;
			}
			Array.Copy(pHuctMMfPlvQcAsYoUOpwgoeZPoq, DJLPNuflaAdBTrPNYNRivsXXTDNO, output, offset, length);
			DJLPNuflaAdBTrPNYNRivsXXTDNO += length;
			if (((uint)(DJLPNuflaAdBTrPNYNRivsXXTDNO - eCTfyiLYePnxaIgvugFtiapXxLkVA) & (true ? 1u : 0u)) != 0)
			{
				dBDQqMWitmmPAbOzGDgIDezrgZMY = pHuctMMfPlvQcAsYoUOpwgoeZPoq[DJLPNuflaAdBTrPNYNRivsXXTDNO++] & 0xFFu;
				CDVIbmiuNYbVbAjCBjumFRFZVedZB = 8;
			}
			return num + length;
		}
		return num;
	}

	public void DropBits(int bitCount)
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY >>= bitCount;
		CDVIbmiuNYbVbAjCBjumFRFZVedZB -= bitCount;
	}

	public int GetBits(int bitCount)
	{
		int num = PeekBits(bitCount);
		if (num >= 0)
		{
			DropBits(bitCount);
		}
		return num;
	}

	public int PeekBits(int bitCount)
	{
		if (CDVIbmiuNYbVbAjCBjumFRFZVedZB < bitCount)
		{
			if (DJLPNuflaAdBTrPNYNRivsXXTDNO == eCTfyiLYePnxaIgvugFtiapXxLkVA)
			{
				return -1;
			}
			dBDQqMWitmmPAbOzGDgIDezrgZMY |= (uint)(((pHuctMMfPlvQcAsYoUOpwgoeZPoq[DJLPNuflaAdBTrPNYNRivsXXTDNO++] & 0xFF) | ((pHuctMMfPlvQcAsYoUOpwgoeZPoq[DJLPNuflaAdBTrPNYNRivsXXTDNO++] & 0xFF) << 8)) << CDVIbmiuNYbVbAjCBjumFRFZVedZB);
			CDVIbmiuNYbVbAjCBjumFRFZVedZB += 16;
		}
		return (int)dBDQqMWitmmPAbOzGDgIDezrgZMY & ((1 << bitCount) - 1);
	}

	public void Reset()
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY = 0u;
		CDVIbmiuNYbVbAjCBjumFRFZVedZB = 0;
		eCTfyiLYePnxaIgvugFtiapXxLkVA = 0;
		DJLPNuflaAdBTrPNYNRivsXXTDNO = 0;
	}

	public void SetInput(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset >= 0)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (DJLPNuflaAdBTrPNYNRivsXXTDNO >= eCTfyiLYePnxaIgvugFtiapXxLkVA)
			{
				int num = offset + count;
				if (offset <= num && num <= buffer.Length)
				{
					if (((uint)count & (true ? 1u : 0u)) != 0)
					{
						dBDQqMWitmmPAbOzGDgIDezrgZMY |= (uint)((buffer[offset++] & 0xFF) << CDVIbmiuNYbVbAjCBjumFRFZVedZB);
						CDVIbmiuNYbVbAjCBjumFRFZVedZB += 8;
					}
					pHuctMMfPlvQcAsYoUOpwgoeZPoq = buffer;
					DJLPNuflaAdBTrPNYNRivsXXTDNO = offset;
					eCTfyiLYePnxaIgvugFtiapXxLkVA = num;
					return;
				}
				throw new ArgumentOutOfRangeException("count");
			}
			throw new InvalidOperationException("Old input was not completely processed");
		}
		throw new ArgumentOutOfRangeException("offset", "Cannot be negative");
	}

	public void SkipToByteBoundary()
	{
		dBDQqMWitmmPAbOzGDgIDezrgZMY >>= CDVIbmiuNYbVbAjCBjumFRFZVedZB & 7;
		CDVIbmiuNYbVbAjCBjumFRFZVedZB &= -8;
	}
}
