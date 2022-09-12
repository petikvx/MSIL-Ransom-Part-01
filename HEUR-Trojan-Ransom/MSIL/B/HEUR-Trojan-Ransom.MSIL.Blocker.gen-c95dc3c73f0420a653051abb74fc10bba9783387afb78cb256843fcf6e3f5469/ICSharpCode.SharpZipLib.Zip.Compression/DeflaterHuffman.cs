using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class DeflaterHuffman
{
	private class GiNTqawiHTPVJnbjJOxuBwriqeuQ
	{
		private int[] vOuAfPejghsnUoGvehSRBdmJbrwYb;

		private short[] gDinIigHXrDTsJoydwhAQZyxUBVKA;

		private DeflaterHuffman rcrMQeINcrgHIARaAMgLJrVkanQcb;

		public short[] ozUExVnIrtgqJeovjGKvLbBhmlBL;

		public byte[] vYcRDWibjHdtYHncllDVjJhwrrbfA;

		private int kykRUqtifsjezqVQEDjyJMUgdCywA;

		public int SlLZfimpokWUeEeFqaytyZohrzjJ;

		public int ICsXixXGSZDcFpDVnFRDbMvATqmeA;

		public GiNTqawiHTPVJnbjJOxuBwriqeuQ(DeflaterHuffman deflaterHuffman_1, int elems, int minCodes, int maxLength)
		{
			rcrMQeINcrgHIARaAMgLJrVkanQcb = deflaterHuffman_1;
			SlLZfimpokWUeEeFqaytyZohrzjJ = minCodes;
			kykRUqtifsjezqVQEDjyJMUgdCywA = maxLength;
			ozUExVnIrtgqJeovjGKvLbBhmlBL = new short[elems];
			vOuAfPejghsnUoGvehSRBdmJbrwYb = new int[maxLength];
		}

		public void QgZWwMUXiOjUWEPexaoRJctmdzWdA()
		{
			int[] array = new int[kykRUqtifsjezqVQEDjyJMUgdCywA];
			int num = 0;
			gDinIigHXrDTsJoydwhAQZyxUBVKA = new short[ozUExVnIrtgqJeovjGKvLbBhmlBL.Length];
			for (int i = 0; i < kykRUqtifsjezqVQEDjyJMUgdCywA; i++)
			{
				array[i] = num;
				num += vOuAfPejghsnUoGvehSRBdmJbrwYb[i] << 15 - i;
			}
			for (int j = 0; j < ICsXixXGSZDcFpDVnFRDbMvATqmeA; j++)
			{
				int num2 = vYcRDWibjHdtYHncllDVjJhwrrbfA[j];
				if (num2 > 0)
				{
					gDinIigHXrDTsJoydwhAQZyxUBVKA[j] = BitReverse(array[num2 - 1]);
					array[num2 - 1] += 1 << 16 - num2;
				}
			}
		}

		private void aJlwzOluYrrtFepOXYEscplBhqAkA(int[] childs)
		{
			vYcRDWibjHdtYHncllDVjJhwrrbfA = new byte[ozUExVnIrtgqJeovjGKvLbBhmlBL.Length];
			int num = childs.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 0;
			for (int i = 0; i < kykRUqtifsjezqVQEDjyJMUgdCywA; i++)
			{
				vOuAfPejghsnUoGvehSRBdmJbrwYb[i] = 0;
			}
			int[] array = new int[num];
			array[num - 1] = 0;
			for (int num4 = num - 1; num4 >= 0; num4--)
			{
				if (childs[2 * num4 + 1] == -1)
				{
					int num5 = array[num4];
					vOuAfPejghsnUoGvehSRBdmJbrwYb[num5 - 1]++;
					vYcRDWibjHdtYHncllDVjJhwrrbfA[childs[2 * num4]] = (byte)array[num4];
				}
				else
				{
					int num6 = array[num4] + 1;
					if (num6 > kykRUqtifsjezqVQEDjyJMUgdCywA)
					{
						num6 = kykRUqtifsjezqVQEDjyJMUgdCywA;
						num3++;
					}
					array[childs[2 * num4]] = (array[childs[2 * num4 + 1]] = num6);
				}
			}
			if (num3 == 0)
			{
				return;
			}
			int num7 = kykRUqtifsjezqVQEDjyJMUgdCywA - 1;
			while (true)
			{
				if (vOuAfPejghsnUoGvehSRBdmJbrwYb[--num7] != 0)
				{
					do
					{
						vOuAfPejghsnUoGvehSRBdmJbrwYb[num7]--;
						vOuAfPejghsnUoGvehSRBdmJbrwYb[++num7]++;
						num3 -= 1 << kykRUqtifsjezqVQEDjyJMUgdCywA - 1 - num7;
					}
					while (num3 > 0 && num7 < kykRUqtifsjezqVQEDjyJMUgdCywA - 1);
					if (num3 <= 0)
					{
						break;
					}
				}
			}
			vOuAfPejghsnUoGvehSRBdmJbrwYb[kykRUqtifsjezqVQEDjyJMUgdCywA - 1] += num3;
			vOuAfPejghsnUoGvehSRBdmJbrwYb[kykRUqtifsjezqVQEDjyJMUgdCywA - 2] -= num3;
			int num8 = 2 * num2;
			for (int num9 = kykRUqtifsjezqVQEDjyJMUgdCywA; num9 != 0; num9--)
			{
				int num10 = vOuAfPejghsnUoGvehSRBdmJbrwYb[num9 - 1];
				while (num10 > 0)
				{
					int num11 = 2 * childs[num8++];
					if (childs[num11 + 1] == -1)
					{
						vYcRDWibjHdtYHncllDVjJhwrrbfA[childs[num11]] = (byte)num9;
						num10--;
					}
				}
			}
		}

		public void TdQTbUAcXZCEeQMESSEDcjhjhgeh()
		{
			int num = ozUExVnIrtgqJeovjGKvLbBhmlBL.Length;
			int[] array = new int[num];
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				int num4 = ozUExVnIrtgqJeovjGKvLbBhmlBL[i];
				if (num4 != 0)
				{
					int num5 = num2++;
					int num6;
					while (num5 > 0 && ozUExVnIrtgqJeovjGKvLbBhmlBL[array[num6 = (num5 - 1) / 2]] > num4)
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
			ICsXixXGSZDcFpDVnFRDbMvATqmeA = Math.Max(num3 + 1, SlLZfimpokWUeEeFqaytyZohrzjJ);
			int num8 = num2;
			int[] array2 = new int[4 * num2 - 2];
			int[] array3 = new int[2 * num2 - 1];
			int num9 = num8;
			for (int j = 0; j < num2; j++)
			{
				int num10 = (array2[2 * j] = array[j]);
				array2[2 * j + 1] = -1;
				array3[j] = ozUExVnIrtgqJeovjGKvLbBhmlBL[num10] << 8;
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
				throw new SharpZipBaseException("Heap invariant violated");
			}
			aJlwzOluYrrtFepOXYEscplBhqAkA(array2);
		}

		public void UukLBazafomxukbMlyHBnYptJpFo(GiNTqawiHTPVJnbjJOxuBwriqeuQ blTree)
		{
			int num = -1;
			int num2 = 0;
			while (num2 < ICsXixXGSZDcFpDVnFRDbMvATqmeA)
			{
				int num3 = 1;
				int num4 = vYcRDWibjHdtYHncllDVjJhwrrbfA[num2];
				int num5;
				int num6;
				if (num4 != 0)
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[num4] = (short)(blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[num4] + 1);
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
				while (num2 < ICsXixXGSZDcFpDVnFRDbMvATqmeA && num == vYcRDWibjHdtYHncllDVjJhwrrbfA[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[num] = (short)(blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[num] + (short)num3);
				}
				else if (num == 0)
				{
					if (num3 > 10)
					{
						blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[18] = (short)(blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[18] + 1);
					}
					else
					{
						blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[17] = (short)(blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[17] + 1);
					}
				}
				else
				{
					blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[16] = (short)(blTree.ozUExVnIrtgqJeovjGKvLbBhmlBL[16] + 1);
				}
			}
		}

		public void VsRGunirYZScQapiQnqPgJNdNtuoA()
		{
			bool flag = true;
			for (int i = 0; i < ozUExVnIrtgqJeovjGKvLbBhmlBL.Length; i++)
			{
				if (ozUExVnIrtgqJeovjGKvLbBhmlBL[i] != 0)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				throw new SharpZipBaseException("!Empty");
			}
		}

		public int qYiopSKoiDTOuIefPthFKmwhikYe()
		{
			int num = 0;
			for (int i = 0; i < ozUExVnIrtgqJeovjGKvLbBhmlBL.Length; i++)
			{
				num += ozUExVnIrtgqJeovjGKvLbBhmlBL[i] * vYcRDWibjHdtYHncllDVjJhwrrbfA[i];
			}
			return num;
		}

		public void DpKtQTONKAKCvHfYHRdYQzfeGqip()
		{
			for (int i = 0; i < ozUExVnIrtgqJeovjGKvLbBhmlBL.Length; i++)
			{
				ozUExVnIrtgqJeovjGKvLbBhmlBL[i] = 0;
			}
			gDinIigHXrDTsJoydwhAQZyxUBVKA = null;
			vYcRDWibjHdtYHncllDVjJhwrrbfA = null;
		}

		public void EGTVPPdYzSqDgJNAfjcIjnTzzwUAA(short[] staticCodes, byte[] staticLengths)
		{
			gDinIigHXrDTsJoydwhAQZyxUBVKA = staticCodes;
			vYcRDWibjHdtYHncllDVjJhwrrbfA = staticLengths;
		}

		public void vtmAGshMtjDKZDHabUjVLjhvayirB(int code)
		{
			rcrMQeINcrgHIARaAMgLJrVkanQcb.pending.WriteBits(gDinIigHXrDTsJoydwhAQZyxUBVKA[code] & 0xFFFF, vYcRDWibjHdtYHncllDVjJhwrrbfA[code]);
		}

		public void TmeXcTSYSkCMQbICrnLOoZNBvnEp(GiNTqawiHTPVJnbjJOxuBwriqeuQ blTree)
		{
			int num = -1;
			int num2 = 0;
			while (num2 < ICsXixXGSZDcFpDVnFRDbMvATqmeA)
			{
				int num3 = 1;
				int num4 = vYcRDWibjHdtYHncllDVjJhwrrbfA[num2];
				int num5;
				int num6;
				if (num4 == 0)
				{
					num5 = 138;
					num6 = 3;
				}
				else
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						blTree.vtmAGshMtjDKZDHabUjVLjhvayirB(num4);
						num3 = 0;
					}
				}
				num = num4;
				num2++;
				while (num2 < ICsXixXGSZDcFpDVnFRDbMvATqmeA && num == vYcRDWibjHdtYHncllDVjJhwrrbfA[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 >= num6)
				{
					if (num == 0)
					{
						if (num3 <= 10)
						{
							blTree.vtmAGshMtjDKZDHabUjVLjhvayirB(17);
							rcrMQeINcrgHIARaAMgLJrVkanQcb.pending.WriteBits(num3 - 3, 3);
						}
						else
						{
							blTree.vtmAGshMtjDKZDHabUjVLjhvayirB(18);
							rcrMQeINcrgHIARaAMgLJrVkanQcb.pending.WriteBits(num3 - 11, 7);
						}
					}
					else
					{
						blTree.vtmAGshMtjDKZDHabUjVLjhvayirB(16);
						rcrMQeINcrgHIARaAMgLJrVkanQcb.pending.WriteBits(num3 - 3, 2);
					}
				}
				else
				{
					while (num3-- > 0)
					{
						blTree.vtmAGshMtjDKZDHabUjVLjhvayirB(num);
					}
				}
			}
		}
	}

	private static readonly byte[] suhPCaWsOTtENmdvpzIUjASuyVTE;

	private const int LCqeQrwJhLAuYkCjJTbFDwFfQeSy = 19;

	private static readonly int[] jnvxNnCMbYEmEcVmlsKuDpvBErPo;

	private GiNTqawiHTPVJnbjJOxuBwriqeuQ MrqUZgFxQWnCEyNsorEOovGzQLHb;

	private const int gzBRcpWswBnzvIjUlzGYDXouffqB = 16384;

	private short[] uXuVrYiQOhqptOHIYlMeBGoslHvG;

	private const int ROlfNlJCwDfwReuyYHqnAjCfaVBhb = 30;

	private GiNTqawiHTPVJnbjJOxuBwriqeuQ oLkvcbWXfxQJuTSVADRhrRGzHnTU;

	private const int VseiDEiZLAoeTubqbaPUqoYmpYeH = 256;

	private int PxIpxLfjMcxpbqTJeZrJSuUqUqLf;

	private byte[] dfDKLAhaZyudLymalhsoGBYyobCCA;

	private int IHeYQCNWuPCXpYQHqkmAOvVvkOpl;

	private const int SRDlQvnuDDbcQDzITeefUasNjTSL = 286;

	private GiNTqawiHTPVJnbjJOxuBwriqeuQ JyocZyHuXplyUcGHufOwGTTgkmBmB;

	public DeflaterPending pending;

	private const int JsXWwdHFDHkAGZrSLJHjKDcSeslG = 18;

	private const int mKSfgNPxybVaydczlWLlzmtyGOwB = 17;

	private const int epXgAszQSFePdcXdrOisMevipkez = 16;

	private static short[] KPRaVMfuOyWyNJKMxkkcITycqkLEB;

	private static byte[] LHVcTJnlhXFGtcgnShfgSyuoOWQSA;

	private static short[] EELzYTIoXInTowAmzBKEuFMPoJx;

	private static byte[] YJcVvTBQKWzRbaDewCvGqzcINDtv;

	static DeflaterHuffman()
	{
		suhPCaWsOTtENmdvpzIUjASuyVTE = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
			5, 13, 3, 11, 7, 15
		};
		jnvxNnCMbYEmEcVmlsKuDpvBErPo = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
		EELzYTIoXInTowAmzBKEuFMPoJx = new short[286];
		YJcVvTBQKWzRbaDewCvGqzcINDtv = new byte[286];
		int num = 0;
		while (num < 144)
		{
			EELzYTIoXInTowAmzBKEuFMPoJx[num] = BitReverse(48 + num << 8);
			YJcVvTBQKWzRbaDewCvGqzcINDtv[num++] = 8;
		}
		while (num < 256)
		{
			EELzYTIoXInTowAmzBKEuFMPoJx[num] = BitReverse(256 + num << 7);
			YJcVvTBQKWzRbaDewCvGqzcINDtv[num++] = 9;
		}
		while (num < 280)
		{
			EELzYTIoXInTowAmzBKEuFMPoJx[num] = BitReverse(-256 + num << 9);
			YJcVvTBQKWzRbaDewCvGqzcINDtv[num++] = 7;
		}
		while (num < 286)
		{
			EELzYTIoXInTowAmzBKEuFMPoJx[num] = BitReverse(-88 + num << 8);
			YJcVvTBQKWzRbaDewCvGqzcINDtv[num++] = 8;
		}
		KPRaVMfuOyWyNJKMxkkcITycqkLEB = new short[30];
		LHVcTJnlhXFGtcgnShfgSyuoOWQSA = new byte[30];
		for (num = 0; num < 30; num++)
		{
			KPRaVMfuOyWyNJKMxkkcITycqkLEB[num] = BitReverse(num << 11);
			LHVcTJnlhXFGtcgnShfgSyuoOWQSA[num] = 5;
		}
	}

	public DeflaterHuffman(DeflaterPending pending)
	{
		this.pending = pending;
		JyocZyHuXplyUcGHufOwGTTgkmBmB = new GiNTqawiHTPVJnbjJOxuBwriqeuQ(this, 286, 257, 15);
		oLkvcbWXfxQJuTSVADRhrRGzHnTU = new GiNTqawiHTPVJnbjJOxuBwriqeuQ(this, 30, 1, 15);
		MrqUZgFxQWnCEyNsorEOovGzQLHb = new GiNTqawiHTPVJnbjJOxuBwriqeuQ(this, 19, 4, 7);
		uXuVrYiQOhqptOHIYlMeBGoslHvG = new short[16384];
		dfDKLAhaZyudLymalhsoGBYyobCCA = new byte[16384];
	}

	public static short BitReverse(int toReverse)
	{
		return (short)((suhPCaWsOTtENmdvpzIUjASuyVTE[toReverse & 0xF] << 12) | (suhPCaWsOTtENmdvpzIUjASuyVTE[(toReverse >> 4) & 0xF] << 8) | (suhPCaWsOTtENmdvpzIUjASuyVTE[(toReverse >> 8) & 0xF] << 4) | suhPCaWsOTtENmdvpzIUjASuyVTE[toReverse >> 12]);
	}

	public void CompressBlock()
	{
		for (int i = 0; i < IHeYQCNWuPCXpYQHqkmAOvVvkOpl; i++)
		{
			int num = dfDKLAhaZyudLymalhsoGBYyobCCA[i] & 0xFF;
			int num2 = uXuVrYiQOhqptOHIYlMeBGoslHvG[i];
			if (num2-- != 0)
			{
				int num3 = awSruvBKHkGpXCPPUSimISwQTVpNA(num);
				JyocZyHuXplyUcGHufOwGTTgkmBmB.vtmAGshMtjDKZDHabUjVLjhvayirB(num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					pending.WriteBits(num & ((1 << num4) - 1), num4);
				}
				int num5 = DYSpojYbDNeIfEstxaDqiheJiVtQB(num2);
				oLkvcbWXfxQJuTSVADRhrRGzHnTU.vtmAGshMtjDKZDHabUjVLjhvayirB(num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					pending.WriteBits(num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				JyocZyHuXplyUcGHufOwGTTgkmBmB.vtmAGshMtjDKZDHabUjVLjhvayirB(num);
			}
		}
		JyocZyHuXplyUcGHufOwGTTgkmBmB.vtmAGshMtjDKZDHabUjVLjhvayirB(256);
	}

	private static int DYSpojYbDNeIfEstxaDqiheJiVtQB(int distance)
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
		JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[256] = (short)(JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[256] + 1);
		JyocZyHuXplyUcGHufOwGTTgkmBmB.TdQTbUAcXZCEeQMESSEDcjhjhgeh();
		oLkvcbWXfxQJuTSVADRhrRGzHnTU.TdQTbUAcXZCEeQMESSEDcjhjhgeh();
		JyocZyHuXplyUcGHufOwGTTgkmBmB.UukLBazafomxukbMlyHBnYptJpFo(MrqUZgFxQWnCEyNsorEOovGzQLHb);
		oLkvcbWXfxQJuTSVADRhrRGzHnTU.UukLBazafomxukbMlyHBnYptJpFo(MrqUZgFxQWnCEyNsorEOovGzQLHb);
		MrqUZgFxQWnCEyNsorEOovGzQLHb.TdQTbUAcXZCEeQMESSEDcjhjhgeh();
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (MrqUZgFxQWnCEyNsorEOovGzQLHb.vYcRDWibjHdtYHncllDVjJhwrrbfA[jnvxNnCMbYEmEcVmlsKuDpvBErPo[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + MrqUZgFxQWnCEyNsorEOovGzQLHb.qYiopSKoiDTOuIefPthFKmwhikYe() + JyocZyHuXplyUcGHufOwGTTgkmBmB.qYiopSKoiDTOuIefPthFKmwhikYe() + oLkvcbWXfxQJuTSVADRhrRGzHnTU.qYiopSKoiDTOuIefPthFKmwhikYe() + PxIpxLfjMcxpbqTJeZrJSuUqUqLf;
		int num4 = PxIpxLfjMcxpbqTJeZrJSuUqUqLf;
		for (int i = 0; i < 286; i++)
		{
			num4 += JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[i] * YJcVvTBQKWzRbaDewCvGqzcINDtv[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += oLkvcbWXfxQJuTSVADRhrRGzHnTU.ozUExVnIrtgqJeovjGKvLbBhmlBL[j] * LHVcTJnlhXFGtcgnShfgSyuoOWQSA[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
		{
			FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
		}
		else if (num3 != num4)
		{
			pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
			SendAllTrees(num);
			CompressBlock();
			Reset();
		}
		else
		{
			pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
			JyocZyHuXplyUcGHufOwGTTgkmBmB.EGTVPPdYzSqDgJNAfjcIjnTzzwUAA(EELzYTIoXInTowAmzBKEuFMPoJx, YJcVvTBQKWzRbaDewCvGqzcINDtv);
			oLkvcbWXfxQJuTSVADRhrRGzHnTU.EGTVPPdYzSqDgJNAfjcIjnTzzwUAA(KPRaVMfuOyWyNJKMxkkcITycqkLEB, LHVcTJnlhXFGtcgnShfgSyuoOWQSA);
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
		return IHeYQCNWuPCXpYQHqkmAOvVvkOpl >= 16384;
	}

	private static int awSruvBKHkGpXCPPUSimISwQTVpNA(int length)
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
		IHeYQCNWuPCXpYQHqkmAOvVvkOpl = 0;
		PxIpxLfjMcxpbqTJeZrJSuUqUqLf = 0;
		JyocZyHuXplyUcGHufOwGTTgkmBmB.DpKtQTONKAKCvHfYHRdYQzfeGqip();
		oLkvcbWXfxQJuTSVADRhrRGzHnTU.DpKtQTONKAKCvHfYHRdYQzfeGqip();
		MrqUZgFxQWnCEyNsorEOovGzQLHb.DpKtQTONKAKCvHfYHRdYQzfeGqip();
	}

	public void SendAllTrees(int blTreeCodes)
	{
		MrqUZgFxQWnCEyNsorEOovGzQLHb.QgZWwMUXiOjUWEPexaoRJctmdzWdA();
		JyocZyHuXplyUcGHufOwGTTgkmBmB.QgZWwMUXiOjUWEPexaoRJctmdzWdA();
		oLkvcbWXfxQJuTSVADRhrRGzHnTU.QgZWwMUXiOjUWEPexaoRJctmdzWdA();
		pending.WriteBits(JyocZyHuXplyUcGHufOwGTTgkmBmB.ICsXixXGSZDcFpDVnFRDbMvATqmeA - 257, 5);
		pending.WriteBits(oLkvcbWXfxQJuTSVADRhrRGzHnTU.ICsXixXGSZDcFpDVnFRDbMvATqmeA - 1, 5);
		pending.WriteBits(blTreeCodes - 4, 4);
		for (int i = 0; i < blTreeCodes; i++)
		{
			pending.WriteBits(MrqUZgFxQWnCEyNsorEOovGzQLHb.vYcRDWibjHdtYHncllDVjJhwrrbfA[jnvxNnCMbYEmEcVmlsKuDpvBErPo[i]], 3);
		}
		JyocZyHuXplyUcGHufOwGTTgkmBmB.TmeXcTSYSkCMQbICrnLOoZNBvnEp(MrqUZgFxQWnCEyNsorEOovGzQLHb);
		oLkvcbWXfxQJuTSVADRhrRGzHnTU.TmeXcTSYSkCMQbICrnLOoZNBvnEp(MrqUZgFxQWnCEyNsorEOovGzQLHb);
	}

	public bool TallyDist(int distance, int length)
	{
		uXuVrYiQOhqptOHIYlMeBGoslHvG[IHeYQCNWuPCXpYQHqkmAOvVvkOpl] = (short)distance;
		dfDKLAhaZyudLymalhsoGBYyobCCA[IHeYQCNWuPCXpYQHqkmAOvVvkOpl++] = (byte)(length - 3);
		int num = awSruvBKHkGpXCPPUSimISwQTVpNA(length - 3);
		JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[num] = (short)(JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[num] + 1);
		if (num >= 265 && num < 285)
		{
			PxIpxLfjMcxpbqTJeZrJSuUqUqLf += (num - 261) / 4;
		}
		int num2 = DYSpojYbDNeIfEstxaDqiheJiVtQB(distance - 1);
		oLkvcbWXfxQJuTSVADRhrRGzHnTU.ozUExVnIrtgqJeovjGKvLbBhmlBL[num2] = (short)(oLkvcbWXfxQJuTSVADRhrRGzHnTU.ozUExVnIrtgqJeovjGKvLbBhmlBL[num2] + 1);
		if (num2 >= 4)
		{
			PxIpxLfjMcxpbqTJeZrJSuUqUqLf += num2 / 2 - 1;
		}
		return IsFull();
	}

	public bool TallyLit(int literal)
	{
		uXuVrYiQOhqptOHIYlMeBGoslHvG[IHeYQCNWuPCXpYQHqkmAOvVvkOpl] = 0;
		dfDKLAhaZyudLymalhsoGBYyobCCA[IHeYQCNWuPCXpYQHqkmAOvVvkOpl++] = (byte)literal;
		JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[literal] = (short)(JyocZyHuXplyUcGHufOwGTTgkmBmB.ozUExVnIrtgqJeovjGKvLbBhmlBL[literal] + 1);
		return IsFull();
	}
}
