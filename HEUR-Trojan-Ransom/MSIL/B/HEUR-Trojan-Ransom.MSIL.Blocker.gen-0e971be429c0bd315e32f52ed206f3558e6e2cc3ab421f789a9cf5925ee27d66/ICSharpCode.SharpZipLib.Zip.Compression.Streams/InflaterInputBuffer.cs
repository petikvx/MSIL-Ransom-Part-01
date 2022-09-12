using System;
using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class InflaterInputBuffer
{
	private int ZaQSwobckqPuaZHhoJShgXZvTnwD;

	private byte[] hwpdlKacMHRdjhAufblyRqzjCkNCA;

	private int puFVnNnMmQKFgzFSkJrslCDRHZIK;

	private ICryptoTransform aBohOhzmbvFIEeNoUOkTzcKAabkZ;

	private Stream udLcDlexjlbgicZToEGmyCZFQFkYA;

	private byte[] MqNNpSSOXKnGNYhQlGEMofruMIqe;

	private byte[] wmNPxBtovOIJYJLsxtSpygPMgNUHA;

	private int hCENCKejjyKtXYBNpShomoemQpUf;

	public int Available
	{
		get
		{
			return ZaQSwobckqPuaZHhoJShgXZvTnwD;
		}
		set
		{
			ZaQSwobckqPuaZHhoJShgXZvTnwD = value;
		}
	}

	public byte[] ClearText => hwpdlKacMHRdjhAufblyRqzjCkNCA;

	public int ClearTextLength => puFVnNnMmQKFgzFSkJrslCDRHZIK;

	public ICryptoTransform CryptoTransform
	{
		set
		{
			aBohOhzmbvFIEeNoUOkTzcKAabkZ = value;
			if (aBohOhzmbvFIEeNoUOkTzcKAabkZ != null)
			{
				if (wmNPxBtovOIJYJLsxtSpygPMgNUHA == hwpdlKacMHRdjhAufblyRqzjCkNCA)
				{
					if (MqNNpSSOXKnGNYhQlGEMofruMIqe == null)
					{
						MqNNpSSOXKnGNYhQlGEMofruMIqe = new byte[wmNPxBtovOIJYJLsxtSpygPMgNUHA.Length];
					}
					hwpdlKacMHRdjhAufblyRqzjCkNCA = MqNNpSSOXKnGNYhQlGEMofruMIqe;
				}
				puFVnNnMmQKFgzFSkJrslCDRHZIK = hCENCKejjyKtXYBNpShomoemQpUf;
				if (ZaQSwobckqPuaZHhoJShgXZvTnwD > 0)
				{
					aBohOhzmbvFIEeNoUOkTzcKAabkZ.TransformBlock(wmNPxBtovOIJYJLsxtSpygPMgNUHA, hCENCKejjyKtXYBNpShomoemQpUf - ZaQSwobckqPuaZHhoJShgXZvTnwD, ZaQSwobckqPuaZHhoJShgXZvTnwD, hwpdlKacMHRdjhAufblyRqzjCkNCA, hCENCKejjyKtXYBNpShomoemQpUf - ZaQSwobckqPuaZHhoJShgXZvTnwD);
				}
			}
			else
			{
				hwpdlKacMHRdjhAufblyRqzjCkNCA = wmNPxBtovOIJYJLsxtSpygPMgNUHA;
				puFVnNnMmQKFgzFSkJrslCDRHZIK = hCENCKejjyKtXYBNpShomoemQpUf;
			}
		}
	}

	public byte[] RawData => wmNPxBtovOIJYJLsxtSpygPMgNUHA;

	public int RawLength => hCENCKejjyKtXYBNpShomoemQpUf;

	public InflaterInputBuffer(Stream stream)
		: this(stream, 4096)
	{
	}

	public InflaterInputBuffer(Stream stream, int bufferSize)
	{
		udLcDlexjlbgicZToEGmyCZFQFkYA = stream;
		if (bufferSize < 1024)
		{
			bufferSize = 1024;
		}
		wmNPxBtovOIJYJLsxtSpygPMgNUHA = new byte[bufferSize];
		hwpdlKacMHRdjhAufblyRqzjCkNCA = wmNPxBtovOIJYJLsxtSpygPMgNUHA;
	}

	public void Fill()
	{
		hCENCKejjyKtXYBNpShomoemQpUf = 0;
		int num = wmNPxBtovOIJYJLsxtSpygPMgNUHA.Length;
		while (num > 0)
		{
			int num2 = udLcDlexjlbgicZToEGmyCZFQFkYA.Read(wmNPxBtovOIJYJLsxtSpygPMgNUHA, hCENCKejjyKtXYBNpShomoemQpUf, num);
			if (num2 > 0)
			{
				hCENCKejjyKtXYBNpShomoemQpUf += num2;
				num -= num2;
				continue;
			}
			if (hCENCKejjyKtXYBNpShomoemQpUf != 0)
			{
				break;
			}
			throw new SharpZipBaseException("Unexpected EOF");
		}
		if (aBohOhzmbvFIEeNoUOkTzcKAabkZ == null)
		{
			puFVnNnMmQKFgzFSkJrslCDRHZIK = hCENCKejjyKtXYBNpShomoemQpUf;
		}
		else
		{
			puFVnNnMmQKFgzFSkJrslCDRHZIK = aBohOhzmbvFIEeNoUOkTzcKAabkZ.TransformBlock(wmNPxBtovOIJYJLsxtSpygPMgNUHA, 0, hCENCKejjyKtXYBNpShomoemQpUf, hwpdlKacMHRdjhAufblyRqzjCkNCA, 0);
		}
		ZaQSwobckqPuaZHhoJShgXZvTnwD = puFVnNnMmQKFgzFSkJrslCDRHZIK;
	}

	public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		int num = offset;
		int num2 = length;
		while (true)
		{
			if (num2 > 0)
			{
				if (ZaQSwobckqPuaZHhoJShgXZvTnwD <= 0)
				{
					Fill();
					if (ZaQSwobckqPuaZHhoJShgXZvTnwD <= 0)
					{
						break;
					}
				}
				int num3 = Math.Min(num2, ZaQSwobckqPuaZHhoJShgXZvTnwD);
				Array.Copy(hwpdlKacMHRdjhAufblyRqzjCkNCA, puFVnNnMmQKFgzFSkJrslCDRHZIK - ZaQSwobckqPuaZHhoJShgXZvTnwD, outBuffer, num, num3);
				num += num3;
				num2 -= num3;
				ZaQSwobckqPuaZHhoJShgXZvTnwD -= num3;
				continue;
			}
			return length;
		}
		return 0;
	}

	public int ReadLeByte()
	{
		if (ZaQSwobckqPuaZHhoJShgXZvTnwD <= 0)
		{
			Fill();
			if (ZaQSwobckqPuaZHhoJShgXZvTnwD <= 0)
			{
				throw new ZipException("EOF in header");
			}
		}
		byte result = wmNPxBtovOIJYJLsxtSpygPMgNUHA[hCENCKejjyKtXYBNpShomoemQpUf - ZaQSwobckqPuaZHhoJShgXZvTnwD];
		ZaQSwobckqPuaZHhoJShgXZvTnwD--;
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
			if (ZaQSwobckqPuaZHhoJShgXZvTnwD <= 0)
			{
				Fill();
				if (ZaQSwobckqPuaZHhoJShgXZvTnwD <= 0)
				{
					return 0;
				}
			}
			int num3 = Math.Min(num2, ZaQSwobckqPuaZHhoJShgXZvTnwD);
			Array.Copy(wmNPxBtovOIJYJLsxtSpygPMgNUHA, hCENCKejjyKtXYBNpShomoemQpUf - ZaQSwobckqPuaZHhoJShgXZvTnwD, outBuffer, num, num3);
			num += num3;
			num2 -= num3;
			ZaQSwobckqPuaZHhoJShgXZvTnwD -= num3;
		}
		return length;
	}

	public void SetInflaterInput(Inflater inflater)
	{
		if (ZaQSwobckqPuaZHhoJShgXZvTnwD > 0)
		{
			inflater.SetInput(hwpdlKacMHRdjhAufblyRqzjCkNCA, puFVnNnMmQKFgzFSkJrslCDRHZIK - ZaQSwobckqPuaZHhoJShgXZvTnwD, ZaQSwobckqPuaZHhoJShgXZvTnwD);
			ZaQSwobckqPuaZHhoJShgXZvTnwD = 0;
		}
	}
}
