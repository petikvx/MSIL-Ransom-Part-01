using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace zwIZa;

public class pJRGl
{
	private struct KaegY
	{
		public long long_0;

		public long long_1;
	}

	private struct xNFpX
	{
		public long long_0;

		public string[] string_0;
	}

	private struct ZtWbo
	{
		public long long_0;

		public string string_0;

		public string string_1;

		private readonly string string_2;

		public long long_1;

		public string string_3;
	}

	private readonly byte[] lUhHH;

	private readonly byte[] irEfz;

	private string[] eDVuV;

	private xNFpX[] gasby;

	private ZtWbo[] isyuH;

	private readonly uint XmtvF;

	private readonly ulong cXBDj;

	public pJRGl(byte[] database)
	{
		irEfz = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		if (database != null && database.Length != 0)
		{
			lUhHH = database;
			if (string.Compare(Encoding.Default.GetString(lUhHH, 0, 15), "SQLite format 3", StringComparison.Ordinal) != 0)
			{
				Environment.Exit(0);
			}
			if (lUhHH[52] != 0)
			{
				Environment.Exit(0);
			}
			XmtvF = ReadTable(16u, 2u);
			cXBDj = ReadTable(56u, 4u);
			if (decimal.Compare(new decimal(cXBDj), 0m) == 0)
			{
				cXBDj = 1uL;
			}
			ReadRow(100uL);
		}
	}

	private int GetPointerLength(int ptr)
	{
		if (ptr > lUhHH.Length)
		{
			return 0;
		}
		int num = ptr;
		while (true)
		{
			if (num <= ptr + 8)
			{
				if (num <= lUhHH.Length - 1)
				{
					if ((lUhHH[num] & 0x80) != 128)
					{
						break;
					}
					num++;
					continue;
				}
				return 0;
			}
			return ptr + 8;
		}
		return num;
	}

	private long GetDatabaseSize(int int0, int int1)
	{
		int1++;
		byte[] array = new byte[8];
		int num = int1 - int0;
		bool flag = false;
		if (num == 0 || num > 9)
		{
			return 0L;
		}
		switch (num)
		{
		case 1:
			array[0] = (byte)(lUhHH[int0] & 0x7Fu);
			return BitConverter.ToInt64(array, 0);
		case 9:
			flag = true;
			break;
		}
		int num2 = 1;
		int num3 = 7;
		int num4 = 0;
		if (flag)
		{
			array[0] = lUhHH[int1 - 1];
			int1--;
			num4 = 1;
		}
		for (int i = int1 - 1; i >= int0; i += -1)
		{
			if (i - 1 >= int0)
			{
				array[num4] = (byte)(((byte)((uint)lUhHH[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(lUhHH[i - 1] << (num3 & 7)));
				num2++;
				num4++;
				num3--;
			}
			else if (!flag)
			{
				array[num4] = (byte)((byte)((uint)lUhHH[i] >> ((num2 - 1) & 7)) & (255 >> num2));
			}
		}
		return BitConverter.ToInt64(array, 0);
	}

	public string[] GetTable()
	{
		string[] array = new string[0];
		int num = 0;
		for (int i = 0; i <= isyuH.Length - 1; i++)
		{
			if (Operators.CompareString(isyuH[i].string_0, "table", false) == 0)
			{
				Array.Resize(ref array, num + 1);
				array[num] = isyuH[i].string_1;
				num++;
			}
		}
		return array;
	}

	private bool IsTrue(long long0)
	{
		return (long0 & 1L) == 1L;
	}

	private uint ReadTable(uint uint1, uint uint2)
	{
		if ((long)uint2 > 8L || (long)uint2 == 0L)
		{
			return 0u;
		}
		uint num = 0u;
		for (int i = 0; i <= (long)uint2 - 1L; i++)
		{
			num = (num << 8) | lUhHH[(int)(uint1 + i)];
		}
		if ((long)num == 0L)
		{
			num = (uint)((ulong)num + 1uL);
		}
		return num;
	}

	private void ReadRow(ulong row)
	{
		if (lUhHH[Convert.ToInt32(row)] == 13)
		{
			uint num = (uint)((ulong)ReadTable(Convert.ToUInt32(decimal.Add(new decimal(row), new decimal(3L))), 2u) - 1uL);
			int num2 = 0;
			if (isyuH != null)
			{
				num2 = isyuH.Length;
				Array.Resize(ref isyuH, Convert.ToInt32(decimal.Add(new decimal(isyuH.Length + num), 1m)));
			}
			else
			{
				isyuH = new ZtWbo[(int)((long)num + 1L - 1L) + 1];
			}
			for (int i = 0; i <= num; i++)
			{
				ulong num3 = ReadTable(Convert.ToUInt32(decimal.Add(decimal.Add(new decimal(row), new decimal(8L)), new decimal(i * 2))), 2u);
				if (decimal.Compare(new decimal(row), new decimal(100L)) != 0)
				{
					num3 += row;
				}
				int pointerLength = GetPointerLength(Convert.ToInt32(num3));
				GetDatabaseSize(Convert.ToInt32(num3), pointerLength);
				int pointerLength2 = GetPointerLength(Convert.ToInt32((int)num3 + (pointerLength - (int)num3) + 1));
				isyuH[num2 + i].long_0 = GetDatabaseSize(Convert.ToInt32((int)num3 + (pointerLength - (int)num3) + 1), pointerLength2);
				num3 = Convert.ToUInt64((int)num3 + (pointerLength2 - (int)num3) + 1);
				pointerLength = GetPointerLength(Convert.ToInt32(num3));
				pointerLength2 = pointerLength;
				long databaseSize = GetDatabaseSize((int)num3, pointerLength);
				long[] array = new long[5];
				for (int j = 0; j <= 4; j++)
				{
					pointerLength = pointerLength2 + 1;
					pointerLength2 = GetPointerLength(pointerLength);
					array[j] = GetDatabaseSize(pointerLength, pointerLength2);
					if (array[j] > 9L)
					{
						if (IsTrue(array[j]))
						{
							array[j] = (long)Math.Round((double)(array[j] - 13L) / 2.0);
						}
						else
						{
							array[j] = (long)Math.Round((double)(array[j] - 12L) / 2.0);
						}
					}
					else
					{
						array[j] = irEfz[(int)array[j]];
					}
				}
				if (decimal.Compare(new decimal(cXBDj), 1m) == 0)
				{
					isyuH[num2 + i].string_0 = Encoding.Default.GetString(lUhHH, (int)((long)num3 + databaseSize), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(cXBDj), new decimal(2L)) == 0)
				{
					isyuH[num2 + i].string_0 = Encoding.Unicode.GetString(lUhHH, (int)((long)num3 + databaseSize), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(cXBDj), new decimal(3L)) == 0)
				{
					isyuH[num2 + i].string_0 = Encoding.BigEndianUnicode.GetString(lUhHH, (int)((long)num3 + databaseSize), (int)array[0]);
				}
				if (decimal.Compare(new decimal(cXBDj), 1m) == 0)
				{
					isyuH[num2 + i].string_1 = Encoding.Default.GetString(lUhHH, (int)((long)num3 + databaseSize + array[0]), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(cXBDj), new decimal(2L)) == 0)
				{
					isyuH[num2 + i].string_1 = Encoding.Unicode.GetString(lUhHH, (int)((long)num3 + databaseSize + array[0]), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(cXBDj), new decimal(3L)) == 0)
				{
					isyuH[num2 + i].string_1 = Encoding.BigEndianUnicode.GetString(lUhHH, (int)((long)num3 + databaseSize + array[0]), (int)array[1]);
				}
				isyuH[num2 + i].long_1 = ReadTable((uint)((long)num3 + databaseSize + array[0] + array[1] + array[2]), (uint)array[3]);
				if (decimal.Compare(new decimal(cXBDj), 1m) == 0)
				{
					isyuH[num2 + i].string_3 = Encoding.Default.GetString(lUhHH, (int)((long)num3 + databaseSize + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(cXBDj), new decimal(2L)) == 0)
				{
					isyuH[num2 + i].string_3 = Encoding.Unicode.GetString(lUhHH, (int)((long)num3 + databaseSize + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(cXBDj), new decimal(3L)) == 0)
				{
					isyuH[num2 + i].string_3 = Encoding.BigEndianUnicode.GetString(lUhHH, (int)((long)num3 + databaseSize + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
				}
			}
		}
		else
		{
			if (lUhHH[(uint)row] != 5)
			{
				return;
			}
			uint num4 = (uint)((ulong)ReadTable((uint)((int)row + 3), 2u) - 1uL);
			for (int k = 0; k <= num4; k++)
			{
				uint num5 = ReadTable((uint)((int)row + 12 + k * 2), 2u);
				if (decimal.Compare(new decimal(row), new decimal(100L)) == 0)
				{
					ReadRow((ulong)(((long)ReadTable(num5, 4u) - 1L) * XmtvF));
				}
				else
				{
					ReadRow((ulong)(((long)ReadTable((uint)((int)row + num5), 4u) - 1L) * XmtvF));
				}
			}
			ReadRow((ulong)(((long)ReadTable((uint)((int)row + 8), 4u) - 1L) * XmtvF));
		}
	}

	private bool ReadRow2(ulong ulong1)
	{
		if (lUhHH[(uint)ulong1] == 13)
		{
			uint num = (uint)((ulong)ReadTable(Convert.ToUInt32(decimal.Add(new decimal(ulong1), new decimal(3L))), 2u) - 1uL);
			int num2 = 0;
			if (gasby != null)
			{
				num2 = gasby.Length;
				Array.Resize(ref gasby, Convert.ToInt32(decimal.Add(new decimal(gasby.Length + num), 1m)));
			}
			else
			{
				gasby = new xNFpX[(int)((long)num + 1L - 1L) + 1];
			}
			for (uint num3 = 0u; num3 <= num; num3 = (uint)((ulong)num3 + 1uL))
			{
				ulong num4 = ReadTable(Convert.ToUInt32(decimal.Add(decimal.Add(new decimal(ulong1), new decimal(8L)), new decimal((long)num3 * 2L))), 2u);
				if (decimal.Compare(new decimal(ulong1), new decimal(100L)) != 0)
				{
					num4 += ulong1;
				}
				int pointerLength = GetPointerLength((int)num4);
				GetDatabaseSize((int)num4, pointerLength);
				int pointerLength2 = GetPointerLength((int)num4 + (pointerLength - (int)num4) + 1);
				gasby[(int)(num2 + num3)].long_0 = GetDatabaseSize((int)num4 + (pointerLength - (int)num4) + 1, pointerLength2);
				num4 = (ulong)((int)num4 + (pointerLength2 - (int)num4) + 1);
				pointerLength = GetPointerLength((int)num4);
				pointerLength2 = pointerLength;
				long databaseSize = GetDatabaseSize((int)num4, pointerLength);
				KaegY[] array = new KaegY[0];
				long num5 = (int)num4 - pointerLength + 1;
				int num6 = 0;
				while (num5 < databaseSize)
				{
					Array.Resize(ref array, num6 + 1);
					pointerLength = pointerLength2 + 1;
					pointerLength2 = GetPointerLength(pointerLength);
					array[num6].long_1 = GetDatabaseSize(pointerLength, pointerLength2);
					if (array[num6].long_1 > 9L)
					{
						if (IsTrue(array[num6].long_1))
						{
							array[num6].long_0 = (long)Math.Round((double)(array[num6].long_1 - 13L) / 2.0);
						}
						else
						{
							array[num6].long_0 = (long)Math.Round((double)(array[num6].long_1 - 12L) / 2.0);
						}
					}
					else
					{
						array[num6].long_0 = irEfz[(int)array[num6].long_1];
					}
					num5 = num5 + (pointerLength2 - pointerLength) + 1L;
					num6++;
				}
				Array.Resize(ref gasby[num2 + (int)num3].string_0, array.Length);
				int num7 = 0;
				for (int i = 0; i <= array.Length - 1; i++)
				{
					if (array[i].long_1 > 9L)
					{
						if (!IsTrue(array[i].long_1))
						{
							if (decimal.Compare(new decimal(cXBDj), 1m) == 0)
							{
								gasby[(int)(num2 + num3)].string_0[i] = Encoding.Default.GetString(lUhHH, (int)((long)num4 + databaseSize) + num7, (int)array[i].long_0);
							}
							else if (decimal.Compare(new decimal(cXBDj), new decimal(2L)) == 0)
							{
								gasby[(int)(num2 + num3)].string_0[i] = Encoding.Unicode.GetString(lUhHH, (int)((long)num4 + databaseSize) + num7, (int)array[i].long_0);
							}
							else if (decimal.Compare(new decimal(cXBDj), new decimal(3L)) == 0)
							{
								gasby[(int)(num2 + num3)].string_0[i] = Encoding.BigEndianUnicode.GetString(lUhHH, (int)((long)num4 + databaseSize) + num7, (int)array[i].long_0);
							}
						}
						else
						{
							gasby[(int)(num2 + num3)].string_0[i] = Encoding.Default.GetString(lUhHH, (int)((long)num4 + databaseSize) + num7, (int)array[i].long_0);
						}
					}
					else
					{
						gasby[(int)(num2 + num3)].string_0[i] = Convert.ToString(ReadTable(Convert.ToUInt32(decimal.Add(new decimal(num4 + (ulong)databaseSize), new decimal(num7))), (uint)array[i].long_0));
					}
					num7 += (int)array[i].long_0;
				}
			}
		}
		else if (lUhHH[(uint)ulong1] == 5)
		{
			uint num8 = (uint)((ulong)ReadTable((uint)((int)ulong1 + 3), 2u) - 1uL);
			for (int j = 0; j <= num8; j++)
			{
				uint num9 = ReadTable((uint)((int)ulong1 + 12 + j * 2), 2u);
				ReadRow2((ulong)(((long)ReadTable((uint)((int)ulong1 + num9), 4u) - 1L) * XmtvF));
			}
			ReadRow2((ulong)(((long)ReadTable((uint)((int)ulong1 + 8), 4u) - 1L) * XmtvF));
		}
		return true;
	}

	public bool CompareRows(string string1)
	{
		int num = -1;
		for (int i = 0; i <= isyuH.Length; i++)
		{
			if (string.Compare(isyuH[i].string_1.ToLower(), string1.ToLower(), StringComparison.Ordinal) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		string[] array = isyuH[num].string_3.Substring(isyuH[num].string_3.IndexOf("(", StringComparison.Ordinal) + 1).Split(new char[1] { char.Parse(",") });
		for (int j = 0; j <= array.Length - 1; j++)
		{
			array[j] = array[j].TrimEnd(new char[1] { char.Parse(" ") });
			int num2 = array[j].IndexOf(" ", StringComparison.Ordinal);
			if (num2 > 0)
			{
				array[j] = array[j].Substring(0, num2);
			}
			if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) == 0)
			{
				break;
			}
			Array.Resize(ref eDVuV, j + 1);
			eDVuV[j] = array[j];
		}
		return ReadRow2((ulong)((isyuH[num].long_1 - 1L) * XmtvF));
	}

	public int GetLength()
	{
		return gasby.Length;
	}

	public string CheckIfEmpty(int int0, int int1)
	{
		if (int0 >= gasby.Length)
		{
			return null;
		}
		if (int1 >= gasby[int0].string_0.Length)
		{
			return null;
		}
		if (!string.IsNullOrEmpty(gasby[int0].string_0[int1]) | gasby[int0].string_0[int1].Contains('\0'.ToString()))
		{
			return gasby[int0].string_0[int1];
		}
		return string.Empty;
	}

	public string CheckIfContains(int int0, string string1)
	{
		int num = -1;
		int num2 = 0;
		string[] array = eDVuV;
		foreach (string text in array)
		{
			if (!text.ToLower().Contains(string1.ToLower()))
			{
				num2++;
				continue;
			}
			num = num2;
			break;
		}
		if (num == -1)
		{
			return string.Empty;
		}
		return CheckIfEmpty(int0, num);
	}

	static void hhglW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rCkkX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PLXno()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fmRrd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void aCYky()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bclvq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KNQIh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wOzEe()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kmTms()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NFpXZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Vgasb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RGlhh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wndrC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PyJPL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wCmfm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BBoaC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nqFbc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hutKN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void onPwO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CaUxz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void umLaT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RiIit()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wDWeU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TCpLB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qJGcM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QLMKP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IWgPP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ntpBF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RKRvI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SFgCB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jFsCa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Yorum()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tNsRi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lOQwD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OqVTC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LywqJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mukQL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HbRIW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HZWsP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xnTcc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UXrUY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dXpmK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GOEjs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DknIk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void itnGp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DWeUz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VTCpL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LywqJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NUmuk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HmWSH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CbQNH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xQkEx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uKDmU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OSrSd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xzgBG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mLaTD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sRiIi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lOQwD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void woOqV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dJhyL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HnRgN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LOFeH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NuMxC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zJEhx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XbeWu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BdLcO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sCaUx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void iyDFw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PcEYD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SUdBv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zyPFI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XgsUo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NiktR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pQCSV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yawJX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PdyBK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bGTSi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dPqNM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OfuQD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void krWji()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
