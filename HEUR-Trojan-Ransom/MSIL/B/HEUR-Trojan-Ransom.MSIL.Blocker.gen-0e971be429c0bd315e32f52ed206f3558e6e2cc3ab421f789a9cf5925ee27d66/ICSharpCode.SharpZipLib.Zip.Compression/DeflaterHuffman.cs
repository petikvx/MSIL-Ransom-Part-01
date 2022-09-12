using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class DeflaterHuffman
{
	private class VNLCPBOBmgpGDScWKkxThigvJVbj
	{
		private int[] wsrFkmVcIYZEupWhZRaFxjufKfBA;

		private short[] pSyboJOuXIIjsNiTaNqfdcpiziYx;

		private DeflaterHuffman gRhbwHoLcAlvOehFTrdkRTKxqGJU;

		public short[] psIRiiJrrULOXTzGomXAzuKeINMy;

		public byte[] aMotYfYPtwHRKMaVsEIezjmhOmiJ;

		private int zLkutNBqjFKZrLChPewJslTnlppj;

		public int FJaRDoIwBKyayjevibGPUdsAOoTA;

		public int LnsErSjSUsmQBMKeeKYymYwFLxxk;

		public VNLCPBOBmgpGDScWKkxThigvJVbj(DeflaterHuffman deflaterHuffman_1, int elems, int minCodes, int maxLength)
		{
			gRhbwHoLcAlvOehFTrdkRTKxqGJU = deflaterHuffman_1;
			FJaRDoIwBKyayjevibGPUdsAOoTA = minCodes;
			zLkutNBqjFKZrLChPewJslTnlppj = maxLength;
			psIRiiJrrULOXTzGomXAzuKeINMy = new short[elems];
			wsrFkmVcIYZEupWhZRaFxjufKfBA = new int[maxLength];
		}

		public void TMLQxtewJhmIEvfRazLqzBcxOSHI()
		{
			int[] array = new int[zLkutNBqjFKZrLChPewJslTnlppj];
			int num = 0;
			pSyboJOuXIIjsNiTaNqfdcpiziYx = new short[psIRiiJrrULOXTzGomXAzuKeINMy.Length];
			for (int i = 0; i < zLkutNBqjFKZrLChPewJslTnlppj; i++)
			{
				array[i] = num;
				num += wsrFkmVcIYZEupWhZRaFxjufKfBA[i] << 15 - i;
			}
			for (int j = 0; j < LnsErSjSUsmQBMKeeKYymYwFLxxk; j++)
			{
				int num2 = aMotYfYPtwHRKMaVsEIezjmhOmiJ[j];
				if (num2 > 0)
				{
					pSyboJOuXIIjsNiTaNqfdcpiziYx[j] = BitReverse(array[num2 - 1]);
					array[num2 - 1] += 1 << 16 - num2;
				}
			}
		}

		private void lwlLprZAUKFmLTjrIHaXEmyQXfBE(int[] childs)
		{
			aMotYfYPtwHRKMaVsEIezjmhOmiJ = new byte[psIRiiJrrULOXTzGomXAzuKeINMy.Length];
			int num = childs.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 0;
			for (int i = 0; i < zLkutNBqjFKZrLChPewJslTnlppj; i++)
			{
				wsrFkmVcIYZEupWhZRaFxjufKfBA[i] = 0;
			}
			int[] array = new int[num];
			array[num - 1] = 0;
			for (int num4 = num - 1; num4 >= 0; num4--)
			{
				if (childs[2 * num4 + 1] != -1)
				{
					int num5 = array[num4] + 1;
					if (num5 > zLkutNBqjFKZrLChPewJslTnlppj)
					{
						num5 = zLkutNBqjFKZrLChPewJslTnlppj;
						num3++;
					}
					array[childs[2 * num4]] = (array[childs[2 * num4 + 1]] = num5);
				}
				else
				{
					int num6 = array[num4];
					wsrFkmVcIYZEupWhZRaFxjufKfBA[num6 - 1]++;
					aMotYfYPtwHRKMaVsEIezjmhOmiJ[childs[2 * num4]] = (byte)array[num4];
				}
			}
			if (num3 == 0)
			{
				return;
			}
			int num7 = zLkutNBqjFKZrLChPewJslTnlppj - 1;
			while (true)
			{
				if (wsrFkmVcIYZEupWhZRaFxjufKfBA[--num7] != 0)
				{
					do
					{
						wsrFkmVcIYZEupWhZRaFxjufKfBA[num7]--;
						wsrFkmVcIYZEupWhZRaFxjufKfBA[++num7]++;
						num3 -= 1 << zLkutNBqjFKZrLChPewJslTnlppj - 1 - num7;
					}
					while (num3 > 0 && num7 < zLkutNBqjFKZrLChPewJslTnlppj - 1);
					if (num3 <= 0)
					{
						break;
					}
				}
			}
			wsrFkmVcIYZEupWhZRaFxjufKfBA[zLkutNBqjFKZrLChPewJslTnlppj - 1] += num3;
			wsrFkmVcIYZEupWhZRaFxjufKfBA[zLkutNBqjFKZrLChPewJslTnlppj - 2] -= num3;
			int num8 = 2 * num2;
			for (int num9 = zLkutNBqjFKZrLChPewJslTnlppj; num9 != 0; num9--)
			{
				int num10 = wsrFkmVcIYZEupWhZRaFxjufKfBA[num9 - 1];
				while (num10 > 0)
				{
					int num11 = 2 * childs[num8++];
					if (childs[num11 + 1] == -1)
					{
						aMotYfYPtwHRKMaVsEIezjmhOmiJ[childs[num11]] = (byte)num9;
						num10--;
					}
				}
			}
		}

		public void SyUenAgxeidcGBhpNIRitOwwvYzEA()
		{
			int num = psIRiiJrrULOXTzGomXAzuKeINMy.Length;
			int[] array = new int[num];
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				int num4 = psIRiiJrrULOXTzGomXAzuKeINMy[i];
				if (num4 != 0)
				{
					int num5 = num2++;
					int num6;
					while (num5 > 0 && psIRiiJrrULOXTzGomXAzuKeINMy[array[num6 = (num5 - 1) / 2]] > num4)
					{
						array[num5] = array[num6];
						num5 = num6;
					}
					array[num5] = i;
					num3 = i;
				}
			}
			while (num2 < 2)
			{
				int num7 = ((num3 < 2) ? (++num3) : 0);
				array[num2++] = num7;
			}
			LnsErSjSUsmQBMKeeKYymYwFLxxk = Math.Max(num3 + 1, FJaRDoIwBKyayjevibGPUdsAOoTA);
			int num8 = num2;
			int[] array2 = new int[4 * num2 - 2];
			int[] array3 = new int[2 * num2 - 1];
			int num9 = num8;
			for (int j = 0; j < num2; j++)
			{
				int num10 = (array2[2 * j] = array[j]);
				array2[2 * j + 1] = -1;
				array3[j] = psIRiiJrrULOXTzGomXAzuKeINMy[num10] << 8;
				array[j] = j;
			}
			do
			{
				int num11 = array[0];
				int num12 = array[--num2];
				int num13 = 0;
				int num14;
				for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				int num15 = array3[num12];
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
				int num16 = array[0];
				num12 = num9++;
				array2[2 * num12] = num11;
				array2[2 * num12 + 1] = num16;
				int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
				num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
				num13 = 0;
				for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
			}
			while (num2 > 1);
			if (array[0] != array2.Length / 2 - 1)
			{
				throw new SharpZipBaseException(_003CModule_003E.smethod_5<string>(1905181503u));
			}
			lwlLprZAUKFmLTjrIHaXEmyQXfBE(array2);
		}

		public void LHifBJJQlLLvqZnnoYQuPGweEEQL(VNLCPBOBmgpGDScWKkxThigvJVbj blTree)
		{
			int num = -1;
			int num2 = 0;
			while (num2 < LnsErSjSUsmQBMKeeKYymYwFLxxk)
			{
				int num3 = 1;
				int num4 = aMotYfYPtwHRKMaVsEIezjmhOmiJ[num2];
				int num5;
				int num6;
				if (num4 != 0)
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						blTree.psIRiiJrrULOXTzGomXAzuKeINMy[num4] = (short)(blTree.psIRiiJrrULOXTzGomXAzuKeINMy[num4] + 1);
						num3 = 0;
					}
				}
				else
				{
					num5 = 138;
					num6 = 3;
				}
				num = num4;
				num2++;
				while (num2 < LnsErSjSUsmQBMKeeKYymYwFLxxk && num == aMotYfYPtwHRKMaVsEIezjmhOmiJ[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					blTree.psIRiiJrrULOXTzGomXAzuKeINMy[num] = (short)(blTree.psIRiiJrrULOXTzGomXAzuKeINMy[num] + (short)num3);
				}
				else if (num == 0)
				{
					if (num3 > 10)
					{
						blTree.psIRiiJrrULOXTzGomXAzuKeINMy[18] = (short)(blTree.psIRiiJrrULOXTzGomXAzuKeINMy[18] + 1);
					}
					else
					{
						blTree.psIRiiJrrULOXTzGomXAzuKeINMy[17] = (short)(blTree.psIRiiJrrULOXTzGomXAzuKeINMy[17] + 1);
					}
				}
				else
				{
					blTree.psIRiiJrrULOXTzGomXAzuKeINMy[16] = (short)(blTree.psIRiiJrrULOXTzGomXAzuKeINMy[16] + 1);
				}
			}
		}

		public void GWPIaOLEpyWcUKRBLlmynOhmMonC()
		{
			bool flag = true;
			for (int i = 0; i < psIRiiJrrULOXTzGomXAzuKeINMy.Length; i++)
			{
				if (psIRiiJrrULOXTzGomXAzuKeINMy[i] != 0)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				throw new SharpZipBaseException(_003CModule_003E.smethod_3<string>(2262995577u));
			}
		}

		public int zTkGGWDeuyEtYTdTEiusHmxmUPHfA()
		{
			int num = 0;
			for (int i = 0; i < psIRiiJrrULOXTzGomXAzuKeINMy.Length; i++)
			{
				num += psIRiiJrrULOXTzGomXAzuKeINMy[i] * aMotYfYPtwHRKMaVsEIezjmhOmiJ[i];
			}
			return num;
		}

		public void QAUcQcqMSxkpfuvnEqzXciYpNlzb()
		{
			for (int i = 0; i < psIRiiJrrULOXTzGomXAzuKeINMy.Length; i++)
			{
				psIRiiJrrULOXTzGomXAzuKeINMy[i] = 0;
			}
			pSyboJOuXIIjsNiTaNqfdcpiziYx = null;
			aMotYfYPtwHRKMaVsEIezjmhOmiJ = null;
		}

		public void JMDhGkPgbjrpgmcbqnKpDfGmbDPN(short[] staticCodes, byte[] staticLengths)
		{
			pSyboJOuXIIjsNiTaNqfdcpiziYx = staticCodes;
			aMotYfYPtwHRKMaVsEIezjmhOmiJ = staticLengths;
		}

		public void oukpDaNfQaTZgCXPoUwTJmtHjdh(int code)
		{
			gRhbwHoLcAlvOehFTrdkRTKxqGJU.pending.WriteBits(pSyboJOuXIIjsNiTaNqfdcpiziYx[code] & 0xFFFF, aMotYfYPtwHRKMaVsEIezjmhOmiJ[code]);
		}

		public void USaIukshQTcsIIwreSopWCvWMANF(VNLCPBOBmgpGDScWKkxThigvJVbj blTree)
		{
			int num = -1;
			int num2 = 0;
			while (num2 < LnsErSjSUsmQBMKeeKYymYwFLxxk)
			{
				int num3 = 1;
				int num4 = aMotYfYPtwHRKMaVsEIezjmhOmiJ[num2];
				int num5;
				int num6;
				if (num4 != 0)
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						blTree.oukpDaNfQaTZgCXPoUwTJmtHjdh(num4);
						num3 = 0;
					}
				}
				else
				{
					num5 = 138;
					num6 = 3;
				}
				num = num4;
				num2++;
				while (num2 < LnsErSjSUsmQBMKeeKYymYwFLxxk && num == aMotYfYPtwHRKMaVsEIezjmhOmiJ[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					while (num3-- > 0)
					{
						blTree.oukpDaNfQaTZgCXPoUwTJmtHjdh(num);
					}
				}
				else if (num == 0)
				{
					if (num3 > 10)
					{
						blTree.oukpDaNfQaTZgCXPoUwTJmtHjdh(18);
						gRhbwHoLcAlvOehFTrdkRTKxqGJU.pending.WriteBits(num3 - 11, 7);
					}
					else
					{
						blTree.oukpDaNfQaTZgCXPoUwTJmtHjdh(17);
						gRhbwHoLcAlvOehFTrdkRTKxqGJU.pending.WriteBits(num3 - 3, 3);
					}
				}
				else
				{
					blTree.oukpDaNfQaTZgCXPoUwTJmtHjdh(16);
					gRhbwHoLcAlvOehFTrdkRTKxqGJU.pending.WriteBits(num3 - 3, 2);
				}
			}
		}
	}

	private static readonly byte[] rPxFdNIqakGTJsRCwrgtDFZFbTAJB;

	private const int KTsJiKKhhmtGEXkKACeekdQghBZib = 19;

	private static readonly int[] mtrbsCshzhAvOJWNePXNdLaQMsIj;

	private VNLCPBOBmgpGDScWKkxThigvJVbj LGsfgafvlzDFCAFeApsvQKotstSwb;

	private const int lvTcpZEommsJfufIkrqzgbEnAQaVA = 16384;

	private short[] zJiqhnEzGQqCvxejNzcNnkjjMWgL;

	private const int MElplEvzgiSnHRrRJvuQDdLakWMI = 30;

	private VNLCPBOBmgpGDScWKkxThigvJVbj dXiKWYsjRQnTcampNCcCFJxaOhEC;

	private const int AougSpbSHpSQPCVByPldUMDxtSvjA = 256;

	private int IJGPTaHjKLXFvBlevoOooJFpnrIx;

	private byte[] kuTxQhNcFVeRTBAXuTpNlQRtQYHm;

	private int BAunsdxHsgBohGrwdWfjViIyeXgKA;

	private const int HDDrJCNKZqHKAihlMefIscdGXYXl = 286;

	private VNLCPBOBmgpGDScWKkxThigvJVbj McupHBOHQCUAQboXbPJDzSnhFVIE;

	public DeflaterPending pending;

	private const int OFJzqMhyFinKCcPSAFGCDalZJDspA = 18;

	private const int xzKEVcCfrUnvmzABoZZmMDdlYdTMA = 17;

	private const int pTHaEZFYZyzplgOwirLJSqZnXprc = 16;

	private static short[] RcrrWkSXgMTetxuXjNgnxxOPMKA;

	private static byte[] SYLGvoDohulubVYUZKoLSNpnejFjA;

	private static short[] LiUZZprBocOBZTWnfmGvqKWLbVOgA;

	private static byte[] NVoZqylGatZPfNDVvkOhWxkZibah;

	static DeflaterHuffman()
	{
		rPxFdNIqakGTJsRCwrgtDFZFbTAJB = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
			5, 13, 3, 11, 7, 15
		};
		mtrbsCshzhAvOJWNePXNdLaQMsIj = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
		LiUZZprBocOBZTWnfmGvqKWLbVOgA = new short[286];
		NVoZqylGatZPfNDVvkOhWxkZibah = new byte[286];
		int num = 0;
		while (num < 144)
		{
			LiUZZprBocOBZTWnfmGvqKWLbVOgA[num] = BitReverse(48 + num << 8);
			NVoZqylGatZPfNDVvkOhWxkZibah[num++] = 8;
		}
		while (num < 256)
		{
			LiUZZprBocOBZTWnfmGvqKWLbVOgA[num] = BitReverse(256 + num << 7);
			NVoZqylGatZPfNDVvkOhWxkZibah[num++] = 9;
		}
		while (num < 280)
		{
			LiUZZprBocOBZTWnfmGvqKWLbVOgA[num] = BitReverse(-256 + num << 9);
			NVoZqylGatZPfNDVvkOhWxkZibah[num++] = 7;
		}
		while (num < 286)
		{
			LiUZZprBocOBZTWnfmGvqKWLbVOgA[num] = BitReverse(-88 + num << 8);
			NVoZqylGatZPfNDVvkOhWxkZibah[num++] = 8;
		}
		RcrrWkSXgMTetxuXjNgnxxOPMKA = new short[30];
		SYLGvoDohulubVYUZKoLSNpnejFjA = new byte[30];
		for (num = 0; num < 30; num++)
		{
			RcrrWkSXgMTetxuXjNgnxxOPMKA[num] = BitReverse(num << 11);
			SYLGvoDohulubVYUZKoLSNpnejFjA[num] = 5;
		}
	}

	public DeflaterHuffman(DeflaterPending pending)
	{
		this.pending = pending;
		McupHBOHQCUAQboXbPJDzSnhFVIE = new VNLCPBOBmgpGDScWKkxThigvJVbj(this, 286, 257, 15);
		dXiKWYsjRQnTcampNCcCFJxaOhEC = new VNLCPBOBmgpGDScWKkxThigvJVbj(this, 30, 1, 15);
		LGsfgafvlzDFCAFeApsvQKotstSwb = new VNLCPBOBmgpGDScWKkxThigvJVbj(this, 19, 4, 7);
		zJiqhnEzGQqCvxejNzcNnkjjMWgL = new short[16384];
		kuTxQhNcFVeRTBAXuTpNlQRtQYHm = new byte[16384];
	}

	public static short BitReverse(int toReverse)
	{
		return (short)((rPxFdNIqakGTJsRCwrgtDFZFbTAJB[toReverse & 0xF] << 12) | (rPxFdNIqakGTJsRCwrgtDFZFbTAJB[(toReverse >> 4) & 0xF] << 8) | (rPxFdNIqakGTJsRCwrgtDFZFbTAJB[(toReverse >> 8) & 0xF] << 4) | rPxFdNIqakGTJsRCwrgtDFZFbTAJB[toReverse >> 12]);
	}

	public void CompressBlock()
	{
		for (int i = 0; i < BAunsdxHsgBohGrwdWfjViIyeXgKA; i++)
		{
			int num = kuTxQhNcFVeRTBAXuTpNlQRtQYHm[i] & 0xFF;
			int num2 = zJiqhnEzGQqCvxejNzcNnkjjMWgL[i];
			if (num2-- == 0)
			{
				McupHBOHQCUAQboXbPJDzSnhFVIE.oukpDaNfQaTZgCXPoUwTJmtHjdh(num);
				continue;
			}
			int num3 = vkEQyEtNLNFoFcasHtKTwDnJAoiP(num);
			McupHBOHQCUAQboXbPJDzSnhFVIE.oukpDaNfQaTZgCXPoUwTJmtHjdh(num3);
			int num4 = (num3 - 261) / 4;
			if (num4 > 0 && num4 <= 5)
			{
				pending.WriteBits(num & ((1 << num4) - 1), num4);
			}
			int num5 = CFQAuIwoFemjjLFUwfCLZthfNeeY(num2);
			dXiKWYsjRQnTcampNCcCFJxaOhEC.oukpDaNfQaTZgCXPoUwTJmtHjdh(num5);
			num4 = num5 / 2 - 1;
			if (num4 > 0)
			{
				pending.WriteBits(num2 & ((1 << num4) - 1), num4);
			}
		}
		McupHBOHQCUAQboXbPJDzSnhFVIE.oukpDaNfQaTZgCXPoUwTJmtHjdh(256);
	}

	private static int CFQAuIwoFemjjLFUwfCLZthfNeeY(int distance)
	{
		int num = 0;
		while (distance >= 4)
		{
			num += 2;
			distance >>= 1;
		}
		return num + distance;
	}

	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
	{
		McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[256] = (short)(McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[256] + 1);
		McupHBOHQCUAQboXbPJDzSnhFVIE.SyUenAgxeidcGBhpNIRitOwwvYzEA();
		dXiKWYsjRQnTcampNCcCFJxaOhEC.SyUenAgxeidcGBhpNIRitOwwvYzEA();
		McupHBOHQCUAQboXbPJDzSnhFVIE.LHifBJJQlLLvqZnnoYQuPGweEEQL(LGsfgafvlzDFCAFeApsvQKotstSwb);
		dXiKWYsjRQnTcampNCcCFJxaOhEC.LHifBJJQlLLvqZnnoYQuPGweEEQL(LGsfgafvlzDFCAFeApsvQKotstSwb);
		LGsfgafvlzDFCAFeApsvQKotstSwb.SyUenAgxeidcGBhpNIRitOwwvYzEA();
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (LGsfgafvlzDFCAFeApsvQKotstSwb.aMotYfYPtwHRKMaVsEIezjmhOmiJ[mtrbsCshzhAvOJWNePXNdLaQMsIj[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + LGsfgafvlzDFCAFeApsvQKotstSwb.zTkGGWDeuyEtYTdTEiusHmxmUPHfA() + McupHBOHQCUAQboXbPJDzSnhFVIE.zTkGGWDeuyEtYTdTEiusHmxmUPHfA() + dXiKWYsjRQnTcampNCcCFJxaOhEC.zTkGGWDeuyEtYTdTEiusHmxmUPHfA() + IJGPTaHjKLXFvBlevoOooJFpnrIx;
		int num4 = IJGPTaHjKLXFvBlevoOooJFpnrIx;
		for (int i = 0; i < 286; i++)
		{
			num4 += McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[i] * NVoZqylGatZPfNDVvkOhWxkZibah[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += dXiKWYsjRQnTcampNCcCFJxaOhEC.psIRiiJrrULOXTzGomXAzuKeINMy[j] * SYLGvoDohulubVYUZKoLSNpnejFjA[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
		{
			FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
		}
		else if (num3 == num4)
		{
			pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
			McupHBOHQCUAQboXbPJDzSnhFVIE.JMDhGkPgbjrpgmcbqnKpDfGmbDPN(LiUZZprBocOBZTWnfmGvqKWLbVOgA, NVoZqylGatZPfNDVvkOhWxkZibah);
			dXiKWYsjRQnTcampNCcCFJxaOhEC.JMDhGkPgbjrpgmcbqnKpDfGmbDPN(RcrrWkSXgMTetxuXjNgnxxOPMKA, SYLGvoDohulubVYUZKoLSNpnejFjA);
			CompressBlock();
			Reset();
		}
		else
		{
			pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
			SendAllTrees(num);
			CompressBlock();
			Reset();
		}
	}

	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
	{
		pending.WriteBits(lastBlock ? 1 : 0, 3);
		pending.AlignToByte();
		pending.WriteShort(storedLength);
		pending.WriteShort(~storedLength);
		pending.WriteBlock(stored, storedOffset, storedLength);
		Reset();
	}

	public bool IsFull()
	{
		return BAunsdxHsgBohGrwdWfjViIyeXgKA >= 16384;
	}

	private static int vkEQyEtNLNFoFcasHtKTwDnJAoiP(int length)
	{
		if (length == 255)
		{
			return 285;
		}
		int num = 257;
		while (length >= 8)
		{
			num += 4;
			length >>= 1;
		}
		return num + length;
	}

	public void Reset()
	{
		BAunsdxHsgBohGrwdWfjViIyeXgKA = 0;
		IJGPTaHjKLXFvBlevoOooJFpnrIx = 0;
		McupHBOHQCUAQboXbPJDzSnhFVIE.QAUcQcqMSxkpfuvnEqzXciYpNlzb();
		dXiKWYsjRQnTcampNCcCFJxaOhEC.QAUcQcqMSxkpfuvnEqzXciYpNlzb();
		LGsfgafvlzDFCAFeApsvQKotstSwb.QAUcQcqMSxkpfuvnEqzXciYpNlzb();
	}

	public void SendAllTrees(int blTreeCodes)
	{
		LGsfgafvlzDFCAFeApsvQKotstSwb.TMLQxtewJhmIEvfRazLqzBcxOSHI();
		McupHBOHQCUAQboXbPJDzSnhFVIE.TMLQxtewJhmIEvfRazLqzBcxOSHI();
		dXiKWYsjRQnTcampNCcCFJxaOhEC.TMLQxtewJhmIEvfRazLqzBcxOSHI();
		pending.WriteBits(McupHBOHQCUAQboXbPJDzSnhFVIE.LnsErSjSUsmQBMKeeKYymYwFLxxk - 257, 5);
		pending.WriteBits(dXiKWYsjRQnTcampNCcCFJxaOhEC.LnsErSjSUsmQBMKeeKYymYwFLxxk - 1, 5);
		pending.WriteBits(blTreeCodes - 4, 4);
		for (int i = 0; i < blTreeCodes; i++)
		{
			pending.WriteBits(LGsfgafvlzDFCAFeApsvQKotstSwb.aMotYfYPtwHRKMaVsEIezjmhOmiJ[mtrbsCshzhAvOJWNePXNdLaQMsIj[i]], 3);
		}
		McupHBOHQCUAQboXbPJDzSnhFVIE.USaIukshQTcsIIwreSopWCvWMANF(LGsfgafvlzDFCAFeApsvQKotstSwb);
		dXiKWYsjRQnTcampNCcCFJxaOhEC.USaIukshQTcsIIwreSopWCvWMANF(LGsfgafvlzDFCAFeApsvQKotstSwb);
	}

	public bool TallyDist(int distance, int length)
	{
		zJiqhnEzGQqCvxejNzcNnkjjMWgL[BAunsdxHsgBohGrwdWfjViIyeXgKA] = (short)distance;
		kuTxQhNcFVeRTBAXuTpNlQRtQYHm[BAunsdxHsgBohGrwdWfjViIyeXgKA++] = (byte)(length - 3);
		int num = vkEQyEtNLNFoFcasHtKTwDnJAoiP(length - 3);
		McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[num] = (short)(McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[num] + 1);
		if (num >= 265 && num < 285)
		{
			IJGPTaHjKLXFvBlevoOooJFpnrIx += (num - 261) / 4;
		}
		int num2 = CFQAuIwoFemjjLFUwfCLZthfNeeY(distance - 1);
		dXiKWYsjRQnTcampNCcCFJxaOhEC.psIRiiJrrULOXTzGomXAzuKeINMy[num2] = (short)(dXiKWYsjRQnTcampNCcCFJxaOhEC.psIRiiJrrULOXTzGomXAzuKeINMy[num2] + 1);
		if (num2 >= 4)
		{
			IJGPTaHjKLXFvBlevoOooJFpnrIx += num2 / 2 - 1;
		}
		return IsFull();
	}

	public bool TallyLit(int literal)
	{
		zJiqhnEzGQqCvxejNzcNnkjjMWgL[BAunsdxHsgBohGrwdWfjViIyeXgKA] = 0;
		kuTxQhNcFVeRTBAXuTpNlQRtQYHm[BAunsdxHsgBohGrwdWfjViIyeXgKA++] = (byte)literal;
		McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[literal] = (short)(McupHBOHQCUAQboXbPJDzSnhFVIE.psIRiiJrrULOXTzGomXAzuKeINMy[literal] + 1);
		return IsFull();
	}
}
