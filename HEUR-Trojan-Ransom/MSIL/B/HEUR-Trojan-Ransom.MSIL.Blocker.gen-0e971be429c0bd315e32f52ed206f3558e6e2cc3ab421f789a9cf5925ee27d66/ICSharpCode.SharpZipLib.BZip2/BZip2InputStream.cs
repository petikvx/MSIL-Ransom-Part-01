using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.BZip2;

public class BZip2InputStream : Stream
{
	private const int XeyRudNgqUoIDFaRsMtWTNMoWXVA = 1;

	private const int ZBEfwnILEvIgdJUKoIDEOmhGJwbL = 2;

	private const int rpQrEgTNXhXXprxowJpxgWGSnKNc = 3;

	private const int CUSmrntnXShbqUVRKmveiFynLWVd = 4;

	private const int ESWZrvqPdyKSfzsqRbbRTpgyecTQ = 5;

	private const int dsJEjlJIAGzGXDWkHAiqDegKLEjCB = 6;

	private const int kfaPYYEXqrinLDCOlQoCrgUqjEHl = 7;

	private int pqoHwWUCEGWPpyGzfvhLUfikiJXO;

	private int vXrneFWezTwWWxshcqGMPNMrzeKM;

	private int fuwyPOgeStYLqYkQScYQnHYocDyAA;

	private bool mBzRCENAtMtxcALUkcnzuOROWKpq;

	private int zgyYYWmKacCJPhHaOQHCwZGKHJTJ;

	private int CoeDrwONOFolugwTFEwqBRmYnbbk;

	private IChecksum AYnfmpQafGZCtChcfRpAksXHVLBu = new StrangeCRC();

	private bool[] BuHJgZyyImgmYpHohmGriNggjsfP = new bool[256];

	private int wWdHPAghuZOHyFFiYAwhypiHAJWd;

	private byte[] LlbQaIxdfNtnXkZZqWcKQSoBNwQF = new byte[256];

	private byte[] KKGoLDHsuAdslfqfQAeuTppGpsJTA = new byte[256];

	private byte[] JSeGmkCiGCJzBgFYeeFcmGTbsRIIA = new byte[18002];

	private byte[] OmPcOtIJWJoQwOSIMOCXSscqbbOOA = new byte[18002];

	private int[] MJKWhUrNwzNBdVNFDjpgJckseGKX;

	private byte[] FnNczgeTiwCRfrmMSzVbtHOBuXHF;

	private int[] jaQUlfPSUTKbPGPZrWqRBbDFGCBv = new int[256];

	private int[][] pdDEHZraEZBKzjjEOvdILnsMDYekA = new int[6][];

	private int[][] CybNkmntDAndPvKpRqThgLnNAFwO = new int[6][];

	private int[][] zMEwgPudoZSvEaZZHOiACjLtWhKh = new int[6][];

	private int[] UeFdgfeVJetcdYSCVrucPNGxJDI = new int[6];

	private Stream CupzxnnSjFHrQutmtRwIqUtsocQw;

	private bool IYfePrnptSnlsfVvqRANxBwTPsHT;

	private int LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = -1;

	private int mCcPiRSmFwyOqRhPycDDPPZeGFuO = 1;

	private int rVSrDmpIcGaQchqawxUdeqlkGCEeb;

	private int aqXhNzpGehLPfknzicqPmfADNOrH;

	private int FalsEJAAiJwcYFHtDBVpBJSugPWG;

	private uint BzzaQWzrBBMtxfPYpjrhQhBhrWsS;

	private int FCHiixcpSalUxuyAllpYkyWEsZPH;

	private int vrGCfRNlSZuJWNZfvGchVeInABql;

	private int yctsBImRvXVwxzGHEoZUtliKoFTj;

	private int eKkAfWEuynGBibQocHSpypmcOKsmA;

	private int vBQUobhnSOxVDgoJfsZOSbwHwMEA;

	private int OFRQEsnHErSdEXjGcRAFsaxPfxlDA;

	private int BnEYqwTVzmRLybjFdhAWIHzXOkWL;

	private int vbljBCTPOyvSsaArKaRLwYnbxChM;

	private byte CCHaAldBejhoOFfRFFqyJUokkLsNB;

	private bool tTMSyxFlQfXCQfFhbrPnqimGRjzK = true;

	public bool IsStreamOwner
	{
		get
		{
			return tTMSyxFlQfXCQfFhbrPnqimGRjzK;
		}
		set
		{
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = value;
		}
	}

	public override bool CanRead => CupzxnnSjFHrQutmtRwIqUtsocQw.CanRead;

	public override bool CanSeek => CupzxnnSjFHrQutmtRwIqUtsocQw.CanSeek;

	public override bool CanWrite => false;

	public override long Length => CupzxnnSjFHrQutmtRwIqUtsocQw.Length;

	public override long Position
	{
		get
		{
			return CupzxnnSjFHrQutmtRwIqUtsocQw.Position;
		}
		set
		{
			throw new NotSupportedException("BZip2InputStream position cannot be set");
		}
	}

	public BZip2InputStream(Stream stream)
	{
		for (int i = 0; i < 6; i++)
		{
			pdDEHZraEZBKzjjEOvdILnsMDYekA[i] = new int[258];
			CybNkmntDAndPvKpRqThgLnNAFwO[i] = new int[258];
			zMEwgPudoZSvEaZZHOiACjLtWhKh[i] = new int[258];
		}
		jmeLBDDiHbrLuHZOkKrnzCodawVbA(stream);
		EgsSbMJlpoeuwULFbWfLfdPUwSrN();
		eqUGBVElyrrEWwxgNprZKJKqRYvBA();
		KFXGzWyTxEWjCZsMGeqHAatPdNThA();
	}

	public override void Flush()
	{
		if (CupzxnnSjFHrQutmtRwIqUtsocQw != null)
		{
			CupzxnnSjFHrQutmtRwIqUtsocQw.Flush();
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("BZip2InputStream Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("BZip2InputStream SetLength not supported");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("BZip2InputStream Write not supported");
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException("BZip2InputStream WriteByte not supported");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int num = 0;
		while (true)
		{
			if (num < count)
			{
				int num2 = ReadByte();
				if (num2 == -1)
				{
					break;
				}
				buffer[offset + num] = (byte)num2;
				num++;
				continue;
			}
			return count;
		}
		return num;
	}

	public override void Close()
	{
		if (IsStreamOwner && CupzxnnSjFHrQutmtRwIqUtsocQw != null)
		{
			CupzxnnSjFHrQutmtRwIqUtsocQw.Close();
		}
	}

	public override int ReadByte()
	{
		if (!IYfePrnptSnlsfVvqRANxBwTPsHT)
		{
			int lhdkhDyOSIpzpAwDGWvIQnTTcrOJ = LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			switch (mCcPiRSmFwyOqRhPycDDPPZeGFuO)
			{
			case 3:
				TKtbOUwkyMicGZjHNeDXgHbaWRdOA();
				break;
			case 4:
				FCFJglovAljfpONhFRaHoYnHoCvD();
				break;
			case 6:
				ORoVsfCVihEZXHrDEzztKjLeIlGF();
				break;
			case 7:
				YccrscrJEILypbdKLxneEGcMaxNR();
				break;
			}
			return lhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
		}
		return -1;
	}

	private void oOHhxgkRAltnEdJftRCVfNAykMQB()
	{
		wWdHPAghuZOHyFFiYAwhypiHAJWd = 0;
		for (int i = 0; i < 256; i++)
		{
			if (BuHJgZyyImgmYpHohmGriNggjsfP[i])
			{
				LlbQaIxdfNtnXkZZqWcKQSoBNwQF[wWdHPAghuZOHyFFiYAwhypiHAJWd] = (byte)i;
				KKGoLDHsuAdslfqfQAeuTppGpsJTA[i] = (byte)wWdHPAghuZOHyFFiYAwhypiHAJWd;
				wWdHPAghuZOHyFFiYAwhypiHAJWd++;
			}
		}
	}

	private void EgsSbMJlpoeuwULFbWfLfdPUwSrN()
	{
		char c = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c2 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c3 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c4 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		if (c == 'B' && c2 == 'Z' && c3 == 'h' && c4 >= '1' && c4 <= '9')
		{
			JzOXnQxqgdZUWIoeJEgDWcxsqRCM(c4 - 48);
			BzzaQWzrBBMtxfPYpjrhQhBhrWsS = 0u;
		}
		else
		{
			IYfePrnptSnlsfVvqRANxBwTPsHT = true;
		}
	}

	private void eqUGBVElyrrEWwxgNprZKJKqRYvBA()
	{
		char c = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c2 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c3 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c4 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c5 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		char c6 = OGhrteQRVgliiwpoxjOzwjlMfgRGA();
		if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
		{
			nsADjPnURUHBFbtGAOTvSYDUOrUo();
		}
		else if (c == '1' && c2 == 'A' && c3 == 'Y' && c4 == '&' && c5 == 'S' && c6 == 'Y')
		{
			rVSrDmpIcGaQchqawxUdeqlkGCEeb = LjLHmJgLqVwBnFryyjSLcJeTEYHeA();
			mBzRCENAtMtxcALUkcnzuOROWKpq = oujkYGAiBhhNvucOAPaeCUVgGdTW(1) == 1;
			OEPOjzfadqiEBEjKvGepBXUTpSTG();
			AYnfmpQafGZCtChcfRpAksXHVLBu.Reset();
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 1;
		}
		else
		{
			XTncuBZFUaOSlsmSQvRLkQEGcPzo();
			IYfePrnptSnlsfVvqRANxBwTPsHT = true;
		}
	}

	private void jEvKacTVbHqNqPskyiOHWYkOaXXK()
	{
		FalsEJAAiJwcYFHtDBVpBJSugPWG = (int)AYnfmpQafGZCtChcfRpAksXHVLBu.Value;
		if (rVSrDmpIcGaQchqawxUdeqlkGCEeb != FalsEJAAiJwcYFHtDBVpBJSugPWG)
		{
			dVxxbmdsUkuiwjEoIWqlQxVennFg();
		}
		BzzaQWzrBBMtxfPYpjrhQhBhrWsS = ((BzzaQWzrBBMtxfPYpjrhQhBhrWsS << 1) & 0xFFFFFFFFu) | (BzzaQWzrBBMtxfPYpjrhQhBhrWsS >> 31);
		BzzaQWzrBBMtxfPYpjrhQhBhrWsS ^= (uint)FalsEJAAiJwcYFHtDBVpBJSugPWG;
	}

	private void nsADjPnURUHBFbtGAOTvSYDUOrUo()
	{
		aqXhNzpGehLPfknzicqPmfADNOrH = LjLHmJgLqVwBnFryyjSLcJeTEYHeA();
		if (aqXhNzpGehLPfknzicqPmfADNOrH != (int)BzzaQWzrBBMtxfPYpjrhQhBhrWsS)
		{
			dVxxbmdsUkuiwjEoIWqlQxVennFg();
		}
		IYfePrnptSnlsfVvqRANxBwTPsHT = true;
	}

	private void jmeLBDDiHbrLuHZOkKrnzCodawVbA(Stream stream)
	{
		CupzxnnSjFHrQutmtRwIqUtsocQw = stream;
		CoeDrwONOFolugwTFEwqBRmYnbbk = 0;
		zgyYYWmKacCJPhHaOQHCwZGKHJTJ = 0;
	}

	private void kbfFRMWNCpaCLImvNDTGZZVqFMPMA()
	{
		int num = 0;
		try
		{
			num = CupzxnnSjFHrQutmtRwIqUtsocQw.ReadByte();
		}
		catch (Exception)
		{
			CjvaRZFceNHgIMdmpllCPFbZxgvR();
		}
		if (num == -1)
		{
			CjvaRZFceNHgIMdmpllCPFbZxgvR();
		}
		zgyYYWmKacCJPhHaOQHCwZGKHJTJ = (zgyYYWmKacCJPhHaOQHCwZGKHJTJ << 8) | (num & 0xFF);
		CoeDrwONOFolugwTFEwqBRmYnbbk += 8;
	}

	private int oujkYGAiBhhNvucOAPaeCUVgGdTW(int int_4)
	{
		while (CoeDrwONOFolugwTFEwqBRmYnbbk < int_4)
		{
			kbfFRMWNCpaCLImvNDTGZZVqFMPMA();
		}
		int result = (zgyYYWmKacCJPhHaOQHCwZGKHJTJ >> CoeDrwONOFolugwTFEwqBRmYnbbk - int_4) & ((1 << int_4) - 1);
		CoeDrwONOFolugwTFEwqBRmYnbbk -= int_4;
		return result;
	}

	private char OGhrteQRVgliiwpoxjOzwjlMfgRGA()
	{
		return (char)oujkYGAiBhhNvucOAPaeCUVgGdTW(8);
	}

	private int FiXBAqjYFqjIIznPohMcKhEESaif(int numBits)
	{
		return oujkYGAiBhhNvucOAPaeCUVgGdTW(numBits);
	}

	private int LjLHmJgLqVwBnFryyjSLcJeTEYHeA()
	{
		int num = oujkYGAiBhhNvucOAPaeCUVgGdTW(8);
		num = (num << 8) | oujkYGAiBhhNvucOAPaeCUVgGdTW(8);
		num = (num << 8) | oujkYGAiBhhNvucOAPaeCUVgGdTW(8);
		return (num << 8) | oujkYGAiBhhNvucOAPaeCUVgGdTW(8);
	}

	private void tVkBhwTBygyhhLOnheiaTnbzLIhy()
	{
		char[][] array = new char[6][];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new char[258];
		}
		bool[] array2 = new bool[16];
		for (int j = 0; j < 16; j++)
		{
			array2[j] = oujkYGAiBhhNvucOAPaeCUVgGdTW(1) == 1;
		}
		for (int k = 0; k < 16; k++)
		{
			if (array2[k])
			{
				for (int l = 0; l < 16; l++)
				{
					BuHJgZyyImgmYpHohmGriNggjsfP[k * 16 + l] = oujkYGAiBhhNvucOAPaeCUVgGdTW(1) == 1;
				}
			}
			else
			{
				for (int m = 0; m < 16; m++)
				{
					BuHJgZyyImgmYpHohmGriNggjsfP[k * 16 + m] = false;
				}
			}
		}
		oOHhxgkRAltnEdJftRCVfNAykMQB();
		int num = wWdHPAghuZOHyFFiYAwhypiHAJWd + 2;
		int num2 = oujkYGAiBhhNvucOAPaeCUVgGdTW(3);
		int num3 = oujkYGAiBhhNvucOAPaeCUVgGdTW(15);
		for (int n = 0; n < num3; n++)
		{
			int num4 = 0;
			while (oujkYGAiBhhNvucOAPaeCUVgGdTW(1) == 1)
			{
				num4++;
			}
			OmPcOtIJWJoQwOSIMOCXSscqbbOOA[n] = (byte)num4;
		}
		byte[] array3 = new byte[6];
		for (int num5 = 0; num5 < num2; num5++)
		{
			array3[num5] = (byte)num5;
		}
		for (int num6 = 0; num6 < num3; num6++)
		{
			int num7 = OmPcOtIJWJoQwOSIMOCXSscqbbOOA[num6];
			byte b = array3[num7];
			while (num7 > 0)
			{
				array3[num7] = array3[num7 - 1];
				num7--;
			}
			array3[0] = b;
			JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num6] = b;
		}
		for (int num8 = 0; num8 < num2; num8++)
		{
			int num9 = oujkYGAiBhhNvucOAPaeCUVgGdTW(5);
			for (int num10 = 0; num10 < num; num10++)
			{
				while (oujkYGAiBhhNvucOAPaeCUVgGdTW(1) == 1)
				{
					num9 = ((oujkYGAiBhhNvucOAPaeCUVgGdTW(1) != 0) ? (num9 - 1) : (num9 + 1));
				}
				array[num8][num10] = (char)num9;
			}
		}
		for (int num11 = 0; num11 < num2; num11++)
		{
			int num12 = 32;
			int num13 = 0;
			for (int num14 = 0; num14 < num; num14++)
			{
				num13 = Math.Max(num13, array[num11][num14]);
				num12 = Math.Min(num12, array[num11][num14]);
			}
			MKCYfSeQTGVpkKtZxexrdzzhRHAF(pdDEHZraEZBKzjjEOvdILnsMDYekA[num11], CybNkmntDAndPvKpRqThgLnNAFwO[num11], zMEwgPudoZSvEaZZHOiACjLtWhKh[num11], array[num11], num12, num13, num);
			UeFdgfeVJetcdYSCVrucPNGxJDI[num11] = num12;
		}
	}

	private void OEPOjzfadqiEBEjKvGepBXUTpSTG()
	{
		byte[] array = new byte[256];
		int num = 100000 * fuwyPOgeStYLqYkQScYQnHYocDyAA;
		vXrneFWezTwWWxshcqGMPNMrzeKM = FiXBAqjYFqjIIznPohMcKhEESaif(24);
		tVkBhwTBygyhhLOnheiaTnbzLIhy();
		int num2 = wWdHPAghuZOHyFFiYAwhypiHAJWd + 1;
		int num3 = -1;
		int num4 = 0;
		for (int i = 0; i <= 255; i++)
		{
			jaQUlfPSUTKbPGPZrWqRBbDFGCBv[i] = 0;
		}
		for (int j = 0; j <= 255; j++)
		{
			array[j] = (byte)j;
		}
		pqoHwWUCEGWPpyGzfvhLUfikiJXO = -1;
		if (num4 == 0)
		{
			num3++;
			num4 = 50;
		}
		num4--;
		int num5 = JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num3];
		int num6 = UeFdgfeVJetcdYSCVrucPNGxJDI[num5];
		int num7 = oujkYGAiBhhNvucOAPaeCUVgGdTW(num6);
		while (num7 > pdDEHZraEZBKzjjEOvdILnsMDYekA[num5][num6])
		{
			if (num6 <= 20)
			{
				num6++;
				while (CoeDrwONOFolugwTFEwqBRmYnbbk < 1)
				{
					kbfFRMWNCpaCLImvNDTGZZVqFMPMA();
				}
				int num8 = (zgyYYWmKacCJPhHaOQHCwZGKHJTJ >> CoeDrwONOFolugwTFEwqBRmYnbbk - 1) & 1;
				CoeDrwONOFolugwTFEwqBRmYnbbk--;
				num7 = (num7 << 1) | num8;
				continue;
			}
			throw new BZip2Exception("Bzip data error");
		}
		if (num7 - CybNkmntDAndPvKpRqThgLnNAFwO[num5][num6] < 0 || num7 - CybNkmntDAndPvKpRqThgLnNAFwO[num5][num6] >= 258)
		{
			throw new BZip2Exception("Bzip data error");
		}
		int num9 = zMEwgPudoZSvEaZZHOiACjLtWhKh[num5][num7 - CybNkmntDAndPvKpRqThgLnNAFwO[num5][num6]];
		while (num9 != num2)
		{
			if (num9 != 0 && num9 != 1)
			{
				pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
				if (pqoHwWUCEGWPpyGzfvhLUfikiJXO >= num)
				{
					cMEJQpUWHepoEsfnaiWjrSPfzWbQ();
				}
				byte b = array[num9 - 1];
				jaQUlfPSUTKbPGPZrWqRBbDFGCBv[LlbQaIxdfNtnXkZZqWcKQSoBNwQF[b]]++;
				FnNczgeTiwCRfrmMSzVbtHOBuXHF[pqoHwWUCEGWPpyGzfvhLUfikiJXO] = LlbQaIxdfNtnXkZZqWcKQSoBNwQF[b];
				for (int num10 = num9 - 1; num10 > 0; num10--)
				{
					array[num10] = array[num10 - 1];
				}
				array[0] = b;
				if (num4 == 0)
				{
					num3++;
					num4 = 50;
				}
				num4--;
				num5 = JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num3];
				num6 = UeFdgfeVJetcdYSCVrucPNGxJDI[num5];
				num7 = oujkYGAiBhhNvucOAPaeCUVgGdTW(num6);
				while (num7 > pdDEHZraEZBKzjjEOvdILnsMDYekA[num5][num6])
				{
					num6++;
					while (CoeDrwONOFolugwTFEwqBRmYnbbk < 1)
					{
						kbfFRMWNCpaCLImvNDTGZZVqFMPMA();
					}
					int num8 = (zgyYYWmKacCJPhHaOQHCwZGKHJTJ >> CoeDrwONOFolugwTFEwqBRmYnbbk - 1) & 1;
					CoeDrwONOFolugwTFEwqBRmYnbbk--;
					num7 = (num7 << 1) | num8;
				}
				num9 = zMEwgPudoZSvEaZZHOiACjLtWhKh[num5][num7 - CybNkmntDAndPvKpRqThgLnNAFwO[num5][num6]];
				continue;
			}
			int num11 = -1;
			int num12 = 1;
			do
			{
				if (num9 == 0)
				{
					num11 += num12;
				}
				else if (num9 == 1)
				{
					num11 += 2 * num12;
				}
				num12 <<= 1;
				if (num4 == 0)
				{
					num3++;
					num4 = 50;
				}
				num4--;
				num5 = JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num3];
				num6 = UeFdgfeVJetcdYSCVrucPNGxJDI[num5];
				num7 = oujkYGAiBhhNvucOAPaeCUVgGdTW(num6);
				while (num7 > pdDEHZraEZBKzjjEOvdILnsMDYekA[num5][num6])
				{
					num6++;
					while (CoeDrwONOFolugwTFEwqBRmYnbbk < 1)
					{
						kbfFRMWNCpaCLImvNDTGZZVqFMPMA();
					}
					int num8 = (zgyYYWmKacCJPhHaOQHCwZGKHJTJ >> CoeDrwONOFolugwTFEwqBRmYnbbk - 1) & 1;
					CoeDrwONOFolugwTFEwqBRmYnbbk--;
					num7 = (num7 << 1) | num8;
				}
				num9 = zMEwgPudoZSvEaZZHOiACjLtWhKh[num5][num7 - CybNkmntDAndPvKpRqThgLnNAFwO[num5][num6]];
			}
			while (num9 == 0 || num9 == 1);
			num11++;
			byte b2 = LlbQaIxdfNtnXkZZqWcKQSoBNwQF[array[0]];
			jaQUlfPSUTKbPGPZrWqRBbDFGCBv[b2] += num11;
			while (num11 > 0)
			{
				pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
				FnNczgeTiwCRfrmMSzVbtHOBuXHF[pqoHwWUCEGWPpyGzfvhLUfikiJXO] = b2;
				num11--;
			}
			if (pqoHwWUCEGWPpyGzfvhLUfikiJXO >= num)
			{
				cMEJQpUWHepoEsfnaiWjrSPfzWbQ();
			}
		}
	}

	private void KFXGzWyTxEWjCZsMGeqHAatPdNThA()
	{
		int[] array = new int[257];
		array[0] = 0;
		Array.Copy(jaQUlfPSUTKbPGPZrWqRBbDFGCBv, 0, array, 1, 256);
		for (int i = 1; i <= 256; i++)
		{
			array[i] += array[i - 1];
		}
		for (int j = 0; j <= pqoHwWUCEGWPpyGzfvhLUfikiJXO; j++)
		{
			byte b = FnNczgeTiwCRfrmMSzVbtHOBuXHF[j];
			MJKWhUrNwzNBdVNFDjpgJckseGKX[array[b]] = j;
			array[b]++;
		}
		eKkAfWEuynGBibQocHSpypmcOKsmA = MJKWhUrNwzNBdVNFDjpgJckseGKX[vXrneFWezTwWWxshcqGMPNMrzeKM];
		FCHiixcpSalUxuyAllpYkyWEsZPH = 0;
		BnEYqwTVzmRLybjFdhAWIHzXOkWL = 0;
		yctsBImRvXVwxzGHEoZUtliKoFTj = 256;
		if (mBzRCENAtMtxcALUkcnzuOROWKpq)
		{
			vBQUobhnSOxVDgoJfsZOSbwHwMEA = 0;
			OFRQEsnHErSdEXjGcRAFsaxPfxlDA = 0;
			stwQDtPpLmWJiavYonLqtENFTDXo();
		}
		else
		{
			lIXxzaTqlFJPsyzGipSbCtSLzOOw();
		}
	}

	private void stwQDtPpLmWJiavYonLqtENFTDXo()
	{
		if (BnEYqwTVzmRLybjFdhAWIHzXOkWL <= pqoHwWUCEGWPpyGzfvhLUfikiJXO)
		{
			vrGCfRNlSZuJWNZfvGchVeInABql = yctsBImRvXVwxzGHEoZUtliKoFTj;
			yctsBImRvXVwxzGHEoZUtliKoFTj = FnNczgeTiwCRfrmMSzVbtHOBuXHF[eKkAfWEuynGBibQocHSpypmcOKsmA];
			eKkAfWEuynGBibQocHSpypmcOKsmA = MJKWhUrNwzNBdVNFDjpgJckseGKX[eKkAfWEuynGBibQocHSpypmcOKsmA];
			if (vBQUobhnSOxVDgoJfsZOSbwHwMEA == 0)
			{
				vBQUobhnSOxVDgoJfsZOSbwHwMEA = imyYcTsRjudagyxGvRWoRnuWOcyS.uqdhwAXSfWJnPSrvkAnqGqJkhgdcA[OFRQEsnHErSdEXjGcRAFsaxPfxlDA];
				OFRQEsnHErSdEXjGcRAFsaxPfxlDA++;
				if (OFRQEsnHErSdEXjGcRAFsaxPfxlDA == 512)
				{
					OFRQEsnHErSdEXjGcRAFsaxPfxlDA = 0;
				}
			}
			vBQUobhnSOxVDgoJfsZOSbwHwMEA--;
			yctsBImRvXVwxzGHEoZUtliKoFTj ^= ((vBQUobhnSOxVDgoJfsZOSbwHwMEA == 1) ? 1 : 0);
			BnEYqwTVzmRLybjFdhAWIHzXOkWL++;
			LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = yctsBImRvXVwxzGHEoZUtliKoFTj;
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 3;
			AYnfmpQafGZCtChcfRpAksXHVLBu.Update(yctsBImRvXVwxzGHEoZUtliKoFTj);
		}
		else
		{
			jEvKacTVbHqNqPskyiOHWYkOaXXK();
			eqUGBVElyrrEWwxgNprZKJKqRYvBA();
			KFXGzWyTxEWjCZsMGeqHAatPdNThA();
		}
	}

	private void lIXxzaTqlFJPsyzGipSbCtSLzOOw()
	{
		if (BnEYqwTVzmRLybjFdhAWIHzXOkWL > pqoHwWUCEGWPpyGzfvhLUfikiJXO)
		{
			jEvKacTVbHqNqPskyiOHWYkOaXXK();
			eqUGBVElyrrEWwxgNprZKJKqRYvBA();
			KFXGzWyTxEWjCZsMGeqHAatPdNThA();
			return;
		}
		vrGCfRNlSZuJWNZfvGchVeInABql = yctsBImRvXVwxzGHEoZUtliKoFTj;
		yctsBImRvXVwxzGHEoZUtliKoFTj = FnNczgeTiwCRfrmMSzVbtHOBuXHF[eKkAfWEuynGBibQocHSpypmcOKsmA];
		eKkAfWEuynGBibQocHSpypmcOKsmA = MJKWhUrNwzNBdVNFDjpgJckseGKX[eKkAfWEuynGBibQocHSpypmcOKsmA];
		BnEYqwTVzmRLybjFdhAWIHzXOkWL++;
		LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = yctsBImRvXVwxzGHEoZUtliKoFTj;
		mCcPiRSmFwyOqRhPycDDPPZeGFuO = 6;
		AYnfmpQafGZCtChcfRpAksXHVLBu.Update(yctsBImRvXVwxzGHEoZUtliKoFTj);
	}

	private void TKtbOUwkyMicGZjHNeDXgHbaWRdOA()
	{
		if (yctsBImRvXVwxzGHEoZUtliKoFTj == vrGCfRNlSZuJWNZfvGchVeInABql)
		{
			FCHiixcpSalUxuyAllpYkyWEsZPH++;
			if (FCHiixcpSalUxuyAllpYkyWEsZPH < 4)
			{
				mCcPiRSmFwyOqRhPycDDPPZeGFuO = 2;
				stwQDtPpLmWJiavYonLqtENFTDXo();
				return;
			}
			CCHaAldBejhoOFfRFFqyJUokkLsNB = FnNczgeTiwCRfrmMSzVbtHOBuXHF[eKkAfWEuynGBibQocHSpypmcOKsmA];
			eKkAfWEuynGBibQocHSpypmcOKsmA = MJKWhUrNwzNBdVNFDjpgJckseGKX[eKkAfWEuynGBibQocHSpypmcOKsmA];
			if (vBQUobhnSOxVDgoJfsZOSbwHwMEA == 0)
			{
				vBQUobhnSOxVDgoJfsZOSbwHwMEA = imyYcTsRjudagyxGvRWoRnuWOcyS.uqdhwAXSfWJnPSrvkAnqGqJkhgdcA[OFRQEsnHErSdEXjGcRAFsaxPfxlDA];
				OFRQEsnHErSdEXjGcRAFsaxPfxlDA++;
				if (OFRQEsnHErSdEXjGcRAFsaxPfxlDA == 512)
				{
					OFRQEsnHErSdEXjGcRAFsaxPfxlDA = 0;
				}
			}
			vBQUobhnSOxVDgoJfsZOSbwHwMEA--;
			CCHaAldBejhoOFfRFFqyJUokkLsNB ^= ((vBQUobhnSOxVDgoJfsZOSbwHwMEA == 1) ? ((byte)1) : ((byte)0));
			vbljBCTPOyvSsaArKaRLwYnbxChM = 0;
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 4;
			FCFJglovAljfpONhFRaHoYnHoCvD();
		}
		else
		{
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 2;
			FCHiixcpSalUxuyAllpYkyWEsZPH = 1;
			stwQDtPpLmWJiavYonLqtENFTDXo();
		}
	}

	private void FCFJglovAljfpONhFRaHoYnHoCvD()
	{
		if (vbljBCTPOyvSsaArKaRLwYnbxChM < CCHaAldBejhoOFfRFFqyJUokkLsNB)
		{
			LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = yctsBImRvXVwxzGHEoZUtliKoFTj;
			AYnfmpQafGZCtChcfRpAksXHVLBu.Update(yctsBImRvXVwxzGHEoZUtliKoFTj);
			vbljBCTPOyvSsaArKaRLwYnbxChM++;
		}
		else
		{
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 2;
			BnEYqwTVzmRLybjFdhAWIHzXOkWL++;
			FCHiixcpSalUxuyAllpYkyWEsZPH = 0;
			stwQDtPpLmWJiavYonLqtENFTDXo();
		}
	}

	private void ORoVsfCVihEZXHrDEzztKjLeIlGF()
	{
		if (yctsBImRvXVwxzGHEoZUtliKoFTj == vrGCfRNlSZuJWNZfvGchVeInABql)
		{
			FCHiixcpSalUxuyAllpYkyWEsZPH++;
			if (FCHiixcpSalUxuyAllpYkyWEsZPH >= 4)
			{
				CCHaAldBejhoOFfRFFqyJUokkLsNB = FnNczgeTiwCRfrmMSzVbtHOBuXHF[eKkAfWEuynGBibQocHSpypmcOKsmA];
				eKkAfWEuynGBibQocHSpypmcOKsmA = MJKWhUrNwzNBdVNFDjpgJckseGKX[eKkAfWEuynGBibQocHSpypmcOKsmA];
				mCcPiRSmFwyOqRhPycDDPPZeGFuO = 7;
				vbljBCTPOyvSsaArKaRLwYnbxChM = 0;
				YccrscrJEILypbdKLxneEGcMaxNR();
			}
			else
			{
				mCcPiRSmFwyOqRhPycDDPPZeGFuO = 5;
				lIXxzaTqlFJPsyzGipSbCtSLzOOw();
			}
		}
		else
		{
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 5;
			FCHiixcpSalUxuyAllpYkyWEsZPH = 1;
			lIXxzaTqlFJPsyzGipSbCtSLzOOw();
		}
	}

	private void YccrscrJEILypbdKLxneEGcMaxNR()
	{
		if (vbljBCTPOyvSsaArKaRLwYnbxChM >= CCHaAldBejhoOFfRFFqyJUokkLsNB)
		{
			mCcPiRSmFwyOqRhPycDDPPZeGFuO = 5;
			BnEYqwTVzmRLybjFdhAWIHzXOkWL++;
			FCHiixcpSalUxuyAllpYkyWEsZPH = 0;
			lIXxzaTqlFJPsyzGipSbCtSLzOOw();
		}
		else
		{
			LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = yctsBImRvXVwxzGHEoZUtliKoFTj;
			AYnfmpQafGZCtChcfRpAksXHVLBu.Update(yctsBImRvXVwxzGHEoZUtliKoFTj);
			vbljBCTPOyvSsaArKaRLwYnbxChM++;
		}
	}

	private void JzOXnQxqgdZUWIoeJEgDWcxsqRCM(int newSize100k)
	{
		if (0 <= newSize100k && newSize100k <= 9 && 0 <= fuwyPOgeStYLqYkQScYQnHYocDyAA && fuwyPOgeStYLqYkQScYQnHYocDyAA <= 9)
		{
			fuwyPOgeStYLqYkQScYQnHYocDyAA = newSize100k;
			if (newSize100k != 0)
			{
				int num = 100000 * newSize100k;
				FnNczgeTiwCRfrmMSzVbtHOBuXHF = new byte[num];
				MJKWhUrNwzNBdVNFDjpgJckseGKX = new int[num];
			}
			return;
		}
		throw new BZip2Exception("Invalid block size");
	}

	private static void CjvaRZFceNHgIMdmpllCPFbZxgvR()
	{
		throw new EndOfStreamException("BZip2 input stream end of compressed stream");
	}

	private static void cMEJQpUWHepoEsfnaiWjrSPfzWbQ()
	{
		throw new BZip2Exception("BZip2 input stream block overrun");
	}

	private static void XTncuBZFUaOSlsmSQvRLkQEGcPzo()
	{
		throw new BZip2Exception("BZip2 input stream bad block header");
	}

	private static void dVxxbmdsUkuiwjEoIWqlQxVennFg()
	{
		throw new BZip2Exception("BZip2 input stream crc error");
	}

	private static void MKCYfSeQTGVpkKtZxexrdzzhRHAF(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
	{
		int num = 0;
		for (int i = minLen; i <= maxLen; i++)
		{
			for (int j = 0; j < alphaSize; j++)
			{
				if (length[j] == i)
				{
					perm[num] = j;
					num++;
				}
			}
		}
		for (int k = 0; k < 23; k++)
		{
			baseArray[k] = 0;
		}
		for (int l = 0; l < alphaSize; l++)
		{
			baseArray[length[l] + 1]++;
		}
		for (int m = 1; m < 23; m++)
		{
			baseArray[m] += baseArray[m - 1];
		}
		for (int n = 0; n < 23; n++)
		{
			limit[n] = 0;
		}
		int num2 = 0;
		for (int num3 = minLen; num3 <= maxLen; num3++)
		{
			num2 += baseArray[num3 + 1] - baseArray[num3];
			limit[num3] = num2 - 1;
			num2 <<= 1;
		}
		for (int num4 = minLen + 1; num4 <= maxLen; num4++)
		{
			baseArray[num4] = (limit[num4 - 1] + 1 << 1) - baseArray[num4];
		}
	}
}
