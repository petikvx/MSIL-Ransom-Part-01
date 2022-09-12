using System;
using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class InflaterInputBuffer
{
	private int WVKfsHGFiByhkpgmxaQGaIYisgbFB;

	private byte[] aQdZPhMNEqylfAQLkCePxyomQBQt;

	private int kgFQlcPFgbpgqCMjjaGBRIOURcFp;

	private ICryptoTransform tkoqTSXdxMGuCZkTLapujDLBzWjY;

	private Stream viTxStDvqASejgqgxHTMyORUexkB;

	private byte[] HKPThhkASlZXJfcUcfVjMsqjdntaA;

	private byte[] jANBKgTNbjrBGoBReKNCUAIXIiNfA;

	private int cQUvnhKyjTGaBpReyTNPAOtjZxXp;

	public int Available
	{
		get
		{
			return WVKfsHGFiByhkpgmxaQGaIYisgbFB;
		}
		set
		{
			WVKfsHGFiByhkpgmxaQGaIYisgbFB = value;
		}
	}

	public byte[] ClearText => aQdZPhMNEqylfAQLkCePxyomQBQt;

	public int ClearTextLength => kgFQlcPFgbpgqCMjjaGBRIOURcFp;

	public ICryptoTransform CryptoTransform
	{
		set
		{
			tkoqTSXdxMGuCZkTLapujDLBzWjY = value;
			if (tkoqTSXdxMGuCZkTLapujDLBzWjY != null)
			{
				if (jANBKgTNbjrBGoBReKNCUAIXIiNfA == aQdZPhMNEqylfAQLkCePxyomQBQt)
				{
					if (HKPThhkASlZXJfcUcfVjMsqjdntaA == null)
					{
						HKPThhkASlZXJfcUcfVjMsqjdntaA = new byte[jANBKgTNbjrBGoBReKNCUAIXIiNfA.Length];
					}
					aQdZPhMNEqylfAQLkCePxyomQBQt = HKPThhkASlZXJfcUcfVjMsqjdntaA;
				}
				kgFQlcPFgbpgqCMjjaGBRIOURcFp = cQUvnhKyjTGaBpReyTNPAOtjZxXp;
				if (WVKfsHGFiByhkpgmxaQGaIYisgbFB > 0)
				{
					tkoqTSXdxMGuCZkTLapujDLBzWjY.TransformBlock(jANBKgTNbjrBGoBReKNCUAIXIiNfA, cQUvnhKyjTGaBpReyTNPAOtjZxXp - WVKfsHGFiByhkpgmxaQGaIYisgbFB, WVKfsHGFiByhkpgmxaQGaIYisgbFB, aQdZPhMNEqylfAQLkCePxyomQBQt, cQUvnhKyjTGaBpReyTNPAOtjZxXp - WVKfsHGFiByhkpgmxaQGaIYisgbFB);
				}
			}
			else
			{
				aQdZPhMNEqylfAQLkCePxyomQBQt = jANBKgTNbjrBGoBReKNCUAIXIiNfA;
				kgFQlcPFgbpgqCMjjaGBRIOURcFp = cQUvnhKyjTGaBpReyTNPAOtjZxXp;
			}
		}
	}

	public byte[] RawData => jANBKgTNbjrBGoBReKNCUAIXIiNfA;

	public int RawLength => cQUvnhKyjTGaBpReyTNPAOtjZxXp;

	public InflaterInputBuffer(Stream stream)
		: this(stream, 4096)
	{
	}

	public InflaterInputBuffer(Stream stream, int bufferSize)
	{
		viTxStDvqASejgqgxHTMyORUexkB = stream;
		if (bufferSize < 1024)
		{
			bufferSize = 1024;
		}
		jANBKgTNbjrBGoBReKNCUAIXIiNfA = new byte[bufferSize];
		aQdZPhMNEqylfAQLkCePxyomQBQt = jANBKgTNbjrBGoBReKNCUAIXIiNfA;
	}

	public void Fill()
	{
		cQUvnhKyjTGaBpReyTNPAOtjZxXp = 0;
		int num = jANBKgTNbjrBGoBReKNCUAIXIiNfA.Length;
		while (num > 0)
		{
			int num2 = viTxStDvqASejgqgxHTMyORUexkB.Read(jANBKgTNbjrBGoBReKNCUAIXIiNfA, cQUvnhKyjTGaBpReyTNPAOtjZxXp, num);
			if (num2 > 0)
			{
				cQUvnhKyjTGaBpReyTNPAOtjZxXp += num2;
				num -= num2;
				continue;
			}
			if (cQUvnhKyjTGaBpReyTNPAOtjZxXp != 0)
			{
				break;
			}
			throw new SharpZipBaseException("Unexpected EOF");
		}
		if (tkoqTSXdxMGuCZkTLapujDLBzWjY == null)
		{
			kgFQlcPFgbpgqCMjjaGBRIOURcFp = cQUvnhKyjTGaBpReyTNPAOtjZxXp;
		}
		else
		{
			kgFQlcPFgbpgqCMjjaGBRIOURcFp = tkoqTSXdxMGuCZkTLapujDLBzWjY.TransformBlock(jANBKgTNbjrBGoBReKNCUAIXIiNfA, 0, cQUvnhKyjTGaBpReyTNPAOtjZxXp, aQdZPhMNEqylfAQLkCePxyomQBQt, 0);
		}
		WVKfsHGFiByhkpgmxaQGaIYisgbFB = kgFQlcPFgbpgqCMjjaGBRIOURcFp;
	}

	public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		int num = offset;
		int num2 = length;
		while (num2 > 0)
		{
			if (WVKfsHGFiByhkpgmxaQGaIYisgbFB <= 0)
			{
				Fill();
				if (WVKfsHGFiByhkpgmxaQGaIYisgbFB <= 0)
				{
					return 0;
				}
			}
			int num3 = Math.Min(num2, WVKfsHGFiByhkpgmxaQGaIYisgbFB);
			Array.Copy(aQdZPhMNEqylfAQLkCePxyomQBQt, kgFQlcPFgbpgqCMjjaGBRIOURcFp - WVKfsHGFiByhkpgmxaQGaIYisgbFB, outBuffer, num, num3);
			num += num3;
			num2 -= num3;
			WVKfsHGFiByhkpgmxaQGaIYisgbFB -= num3;
		}
		return length;
	}

	public int ReadLeByte()
	{
		if (WVKfsHGFiByhkpgmxaQGaIYisgbFB <= 0)
		{
			Fill();
			if (WVKfsHGFiByhkpgmxaQGaIYisgbFB <= 0)
			{
				throw new ZipException("EOF in header");
			}
		}
		byte result = jANBKgTNbjrBGoBReKNCUAIXIiNfA[cQUvnhKyjTGaBpReyTNPAOtjZxXp - WVKfsHGFiByhkpgmxaQGaIYisgbFB];
		WVKfsHGFiByhkpgmxaQGaIYisgbFB--;
		return result;
	}

	public int ReadLeInt()
	{
		return ReadLeShort() | (ReadLeShort() << 16);
	}

	public long ReadLeLong()
	{
		return (long)ReadLeInt() | (long)ReadLeInt();
	}

	public int ReadLeShort()
	{
		return ReadLeByte() | (ReadLeByte() << 8);
	}

	public int ReadRawBuffer(byte[] buffer)
	{
		return ReadRawBuffer(buffer, 0, buffer.Length);
	}

	public int ReadRawBuffer(byte[] outBuffer, int offset, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		int num = offset;
		int num2 = length;
		while (num2 > 0)
		{
			if (WVKfsHGFiByhkpgmxaQGaIYisgbFB <= 0)
			{
				Fill();
				if (WVKfsHGFiByhkpgmxaQGaIYisgbFB <= 0)
				{
					return 0;
				}
			}
			int num3 = Math.Min(num2, WVKfsHGFiByhkpgmxaQGaIYisgbFB);
			Array.Copy(jANBKgTNbjrBGoBReKNCUAIXIiNfA, cQUvnhKyjTGaBpReyTNPAOtjZxXp - WVKfsHGFiByhkpgmxaQGaIYisgbFB, outBuffer, num, num3);
			num += num3;
			num2 -= num3;
			WVKfsHGFiByhkpgmxaQGaIYisgbFB -= num3;
		}
		return length;
	}

	public void SetInflaterInput(Inflater inflater)
	{
		if (WVKfsHGFiByhkpgmxaQGaIYisgbFB > 0)
		{
			inflater.SetInput(aQdZPhMNEqylfAQLkCePxyomQBQt, kgFQlcPFgbpgqCMjjaGBRIOURcFp - WVKfsHGFiByhkpgmxaQGaIYisgbFB, WVKfsHGFiByhkpgmxaQGaIYisgbFB);
			WVKfsHGFiByhkpgmxaQGaIYisgbFB = 0;
		}
	}
}
