using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class OutputWindow
{
	private byte[] yyMPVNbjbaIYihnijTTdjerIlbbHA = new byte[32768];

	private int BBImdAesgNiJerQhHLWUOynsdWfS;

	private int QNcrXTvRLksIoUPokAHBUineZUXw;

	private const int YOPSMVwcdmPZLAdwdbEyGFZRlvIAb = 32767;

	private const int iOPeqjejsFnGjsmHChnMqFmWhmqdA = 32768;

	public void CopyDict(byte[] dictionary, int offset, int length)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		if (QNcrXTvRLksIoUPokAHBUineZUXw <= 0)
		{
			if (length > 32768)
			{
				offset += length - 32768;
				length = 32768;
			}
			Array.Copy(dictionary, offset, yyMPVNbjbaIYihnijTTdjerIlbbHA, 0, length);
			BBImdAesgNiJerQhHLWUOynsdWfS = length & 0x7FFF;
			return;
		}
		throw new InvalidOperationException();
	}

	public int CopyOutput(byte[] output, int offset, int int_0)
	{
		int num = BBImdAesgNiJerQhHLWUOynsdWfS;
		if (int_0 <= QNcrXTvRLksIoUPokAHBUineZUXw)
		{
			num = (BBImdAesgNiJerQhHLWUOynsdWfS - QNcrXTvRLksIoUPokAHBUineZUXw + int_0) & 0x7FFF;
		}
		else
		{
			int_0 = QNcrXTvRLksIoUPokAHBUineZUXw;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(yyMPVNbjbaIYihnijTTdjerIlbbHA, 32768 - num3, output, offset, num3);
			offset += num3;
			int_0 = num;
		}
		Array.Copy(yyMPVNbjbaIYihnijTTdjerIlbbHA, num - int_0, output, offset, int_0);
		QNcrXTvRLksIoUPokAHBUineZUXw -= num2;
		if (QNcrXTvRLksIoUPokAHBUineZUXw < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	public int CopyStored(StreamManipulator input, int length)
	{
		length = Math.Min(Math.Min(length, 32768 - QNcrXTvRLksIoUPokAHBUineZUXw), input.AvailableBytes);
		int num = 32768 - BBImdAesgNiJerQhHLWUOynsdWfS;
		int num2;
		if (length <= num)
		{
			num2 = input.CopyBytes(yyMPVNbjbaIYihnijTTdjerIlbbHA, BBImdAesgNiJerQhHLWUOynsdWfS, length);
		}
		else
		{
			num2 = input.CopyBytes(yyMPVNbjbaIYihnijTTdjerIlbbHA, BBImdAesgNiJerQhHLWUOynsdWfS, num);
			if (num2 == num)
			{
				num2 += input.CopyBytes(yyMPVNbjbaIYihnijTTdjerIlbbHA, 0, length - num);
			}
		}
		BBImdAesgNiJerQhHLWUOynsdWfS = (BBImdAesgNiJerQhHLWUOynsdWfS + num2) & 0x7FFF;
		QNcrXTvRLksIoUPokAHBUineZUXw += num2;
		return num2;
	}

	public int GetAvailable()
	{
		return QNcrXTvRLksIoUPokAHBUineZUXw;
	}

	public int GetFreeSpace()
	{
		return 32768 - QNcrXTvRLksIoUPokAHBUineZUXw;
	}

	public void Repeat(int length, int distance)
	{
		QNcrXTvRLksIoUPokAHBUineZUXw += length;
		if (QNcrXTvRLksIoUPokAHBUineZUXw > 32768)
		{
			throw new InvalidOperationException("Window full");
		}
		int num = (BBImdAesgNiJerQhHLWUOynsdWfS - distance) & 0x7FFF;
		int num2 = 32768 - length;
		if (num <= num2 && BBImdAesgNiJerQhHLWUOynsdWfS < num2)
		{
			if (length > distance)
			{
				while (length-- > 0)
				{
					yyMPVNbjbaIYihnijTTdjerIlbbHA[BBImdAesgNiJerQhHLWUOynsdWfS++] = yyMPVNbjbaIYihnijTTdjerIlbbHA[num++];
				}
			}
			else
			{
				Array.Copy(yyMPVNbjbaIYihnijTTdjerIlbbHA, num, yyMPVNbjbaIYihnijTTdjerIlbbHA, BBImdAesgNiJerQhHLWUOynsdWfS, length);
				BBImdAesgNiJerQhHLWUOynsdWfS += length;
			}
		}
		else
		{
			HfxIrPHVObAYONdnItObTnHyISIfA(num, length, distance);
		}
	}

	public void Reset()
	{
		BBImdAesgNiJerQhHLWUOynsdWfS = 0;
		QNcrXTvRLksIoUPokAHBUineZUXw = 0;
	}

	private void HfxIrPHVObAYONdnItObTnHyISIfA(int repStart, int length, int distance)
	{
		while (length-- > 0)
		{
			yyMPVNbjbaIYihnijTTdjerIlbbHA[BBImdAesgNiJerQhHLWUOynsdWfS++] = yyMPVNbjbaIYihnijTTdjerIlbbHA[repStart++];
			BBImdAesgNiJerQhHLWUOynsdWfS &= 32767;
			repStart &= 0x7FFF;
		}
	}

	public void Write(int value)
	{
		if (QNcrXTvRLksIoUPokAHBUineZUXw++ == 32768)
		{
			throw new InvalidOperationException("Window full");
		}
		yyMPVNbjbaIYihnijTTdjerIlbbHA[BBImdAesgNiJerQhHLWUOynsdWfS++] = (byte)value;
		BBImdAesgNiJerQhHLWUOynsdWfS &= 32767;
	}
}
