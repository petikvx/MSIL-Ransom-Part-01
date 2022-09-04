using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace VJJks;

public class scYNh
{
	private struct coQkP
	{
		public long size;

		public long type;
	}

	private struct nGRGD
	{
		public long row_id;

		public string[] content;
	}

	private struct wPMjT
	{
		public long row_id;

		public string item_type;

		public string item_name;

		public string astable_name;

		public long root_num;

		public string sql_statement;
	}

	private byte[] djfrI;

	private ushort JegpN;

	private ulong uXnUa;

	private wPMjT[] tCqWS;

	private byte[] SRWHz;

	private nGRGD[] HlMxO;

	private string[] RUMkO;

	private int GVL(int startIndex)
	{
		if (startIndex > djfrI.Length)
		{
			return 0;
		}
		int num = startIndex + 8;
		int num2 = startIndex;
		while (true)
		{
			if (num2 <= num)
			{
				if (num2 <= djfrI.Length - 1)
				{
					if ((djfrI[num2] & 0x80) != 128)
					{
						break;
					}
					num2++;
					continue;
				}
				return 0;
			}
			return startIndex + 8;
		}
		return num2;
	}

	private long CVL(int startIndex, int endIndex)
	{
		endIndex++;
		byte[] array = new byte[8];
		object obj = endIndex - startIndex;
		bool flag = false;
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj, (object)0, false), Operators.CompareObjectGreater(obj, (object)9, false))))
		{
			return 0L;
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
		{
			array[0] = (byte)(djfrI[startIndex] & 0x7Fu);
			return BitConverter.ToInt64(array, 0);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)9, false))
		{
			flag = true;
		}
		int num = 1;
		int num2 = 7;
		int num3 = 0;
		if (flag)
		{
			array[0] = djfrI[endIndex - 1];
			endIndex--;
			num3 = 1;
		}
		for (int i = endIndex - 1; i >= startIndex; i += -1)
		{
			if (i - 1 >= startIndex)
			{
				array[num3] = (byte)(((byte)((uint)djfrI[i] >> ((num - 1) & 7)) & (255 >> num)) | (byte)(djfrI[i - 1] << (num2 & 7)));
				num++;
				num3++;
				num2--;
			}
			else if (!flag)
			{
				array[num3] = (byte)((byte)((uint)djfrI[i] >> ((num - 1) & 7)) & (255 >> num));
			}
		}
		return BitConverter.ToInt64(array, 0);
	}

	private bool IsOdd(long value)
	{
		return (value & 1L) == 1L;
	}

	private ulong ConvertToInteger(int startIndex, int Size)
	{
		if (Size > 8 || Size == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		int num2 = Size - 1;
		for (int i = 0; i <= num2; i++)
		{
			num = (num << 8) | djfrI[startIndex + i];
		}
		return num;
	}

	private void ReadMasterTable(ulong Offset)
	{
		if (djfrI[(uint)Offset] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
			int num2 = 0;
			if (tCqWS != null)
			{
				num2 = tCqWS.Length;
				tCqWS = (wPMjT[])Utils.CopyArray((Array)tCqWS, (Array)new wPMjT[tCqWS.Length + num + 1]);
			}
			else
			{
				tCqWS = new wPMjT[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(8L)), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(Offset), new decimal(100L)) != 0)
				{
					num4 += Offset;
				}
				object obj = GVL((int)num4);
				CVL((int)num4, Conversions.ToInteger(obj));
				object obj2 = GVL(Conversions.ToInteger(Operators.AddObject(Operators.AddObject((object)num4, Operators.SubtractObject(obj, (object)num4)), (object)1)));
				tCqWS[num2 + i].row_id = CVL(Conversions.ToInteger(Operators.AddObject(Operators.AddObject((object)num4, Operators.SubtractObject(obj, (object)num4)), (object)1)), Conversions.ToInteger(obj2));
				num4 = Conversions.ToULong(Operators.AddObject(Operators.AddObject((object)num4, Operators.SubtractObject(obj2, (object)num4)), (object)1));
				obj = GVL((int)num4);
				obj2 = RuntimeHelpers.GetObjectValue(obj);
				long value = CVL((int)num4, Conversions.ToInteger(obj));
				long[] array = new long[5];
				int num5 = 0;
				do
				{
					obj = Operators.AddObject(obj2, (object)1);
					obj2 = GVL(Conversions.ToInteger(obj));
					array[num5] = CVL(Conversions.ToInteger(obj), Conversions.ToInteger(obj2));
					if (array[num5] <= 9L)
					{
						array[num5] = SRWHz[(int)array[num5]];
					}
					else if (IsOdd(array[num5]))
					{
						array[num5] = (long)Math.Round((double)(array[num5] - 13L) / 2.0);
					}
					else
					{
						array[num5] = (long)Math.Round((double)(array[num5] - 12L) / 2.0);
					}
					num5++;
				}
				while (num5 <= 4);
				if (decimal.Compare(new decimal(uXnUa), 1m) == 0)
				{
					tCqWS[num2 + i].item_type = Encoding.Default.GetString(djfrI, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(uXnUa), new decimal(2L)) == 0)
				{
					tCqWS[num2 + i].item_type = Encoding.Unicode.GetString(djfrI, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(uXnUa), new decimal(3L)) == 0)
				{
					tCqWS[num2 + i].item_type = Encoding.BigEndianUnicode.GetString(djfrI, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				if (decimal.Compare(new decimal(uXnUa), 1m) == 0)
				{
					tCqWS[num2 + i].item_name = Encoding.Default.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(uXnUa), new decimal(2L)) == 0)
				{
					tCqWS[num2 + i].item_name = Encoding.Unicode.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(uXnUa), new decimal(3L)) == 0)
				{
					tCqWS[num2 + i].item_name = Encoding.BigEndianUnicode.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				tCqWS[num2 + i].root_num = (long)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				if (decimal.Compare(new decimal(uXnUa), 1m) == 0)
				{
					tCqWS[num2 + i].sql_statement = Encoding.Default.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(uXnUa), new decimal(2L)) == 0)
				{
					tCqWS[num2 + i].sql_statement = Encoding.Unicode.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(uXnUa), new decimal(3L)) == 0)
				{
					tCqWS[num2 + i].sql_statement = Encoding.BigEndianUnicode.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
			}
		}
		else
		{
			if (djfrI[(uint)Offset] != 5)
			{
				return;
			}
			ushort num6 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
			int num7 = num6;
			for (int j = 0; j <= num7; j++)
			{
				ushort num8 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(12L)), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(Offset), new decimal(100L)) == 0)
				{
					ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(num8, 4)), 1m), new decimal(JegpN))));
				}
				else
				{
					ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num8), 4)), 1m), new decimal(JegpN))));
				}
			}
			ReadMasterTable(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(8L))), 4)), 1m), new decimal(JegpN))));
		}
	}

	private bool ReadTableFromOffset(ulong Offset)
	{
		if (djfrI[(uint)Offset] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
			int num2 = 0;
			if (HlMxO != null)
			{
				num2 = HlMxO.Length;
				HlMxO = (nGRGD[])Utils.CopyArray((Array)HlMxO, (Array)new nGRGD[HlMxO.Length + num + 1]);
			}
			else
			{
				HlMxO = new nGRGD[num + 1];
			}
			int num3 = num;
			coQkP[] array = default(coQkP[]);
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(8L)), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(Offset), new decimal(100L)) != 0)
				{
					num4 += Offset;
				}
				object obj = GVL((int)num4);
				CVL((int)num4, Conversions.ToInteger(obj));
				object obj2 = GVL(Conversions.ToInteger(Operators.AddObject(Operators.AddObject((object)num4, Operators.SubtractObject(obj, (object)num4)), (object)1)));
				HlMxO[num2 + i].row_id = CVL(Conversions.ToInteger(Operators.AddObject(Operators.AddObject((object)num4, Operators.SubtractObject(obj, (object)num4)), (object)1)), Conversions.ToInteger(obj2));
				num4 = Conversions.ToULong(Operators.AddObject(Operators.AddObject((object)num4, Operators.SubtractObject(obj2, (object)num4)), (object)1));
				obj = GVL((int)num4);
				obj2 = RuntimeHelpers.GetObjectValue(obj);
				long num5 = CVL((int)num4, Conversions.ToInteger(obj));
				long num6 = Conversions.ToLong(Operators.AddObject(Operators.SubtractObject((object)num4, obj), (object)1));
				object obj3 = 0;
				while (num6 < num5)
				{
					array = (coQkP[])Utils.CopyArray((Array)array, (Array)new coQkP[Conversions.ToInteger(obj3) + 1]);
					obj = Operators.AddObject(obj2, (object)1);
					obj2 = GVL(Conversions.ToInteger(obj));
					array[Conversions.ToInteger(obj3)].type = CVL(Conversions.ToInteger(obj), Conversions.ToInteger(obj2));
					if (array[Conversions.ToInteger(obj3)].type > 9L)
					{
						if (IsOdd(array[Conversions.ToInteger(obj3)].type))
						{
							array[Conversions.ToInteger(obj3)].size = (long)Math.Round((double)(array[Conversions.ToInteger(obj3)].type - 13L) / 2.0);
						}
						else
						{
							array[Conversions.ToInteger(obj3)].size = (long)Math.Round((double)(array[Conversions.ToInteger(obj3)].type - 12L) / 2.0);
						}
					}
					else
					{
						array[Conversions.ToInteger(obj3)].size = SRWHz[(int)array[Conversions.ToInteger(obj3)].type];
					}
					num6 = Conversions.ToLong(Operators.AddObject(Operators.AddObject((object)num6, Operators.SubtractObject(obj2, obj)), (object)1));
					obj3 = Operators.AddObject(obj3, (object)1);
				}
				HlMxO[num2 + i].content = new string[array.Length - 1 + 1];
				int num7 = 0;
				int num8 = array.Length - 1;
				for (int j = 0; j <= num8; j++)
				{
					if (array[j].type > 9L)
					{
						if (!IsOdd(array[j].type))
						{
							if (decimal.Compare(new decimal(uXnUa), 1m) == 0)
							{
								HlMxO[num2 + i].content[j] = Encoding.Default.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num7))), (int)array[j].size);
							}
							else if (decimal.Compare(new decimal(uXnUa), new decimal(2L)) == 0)
							{
								HlMxO[num2 + i].content[j] = Encoding.Unicode.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num7))), (int)array[j].size);
							}
							else if (decimal.Compare(new decimal(uXnUa), new decimal(3L)) == 0)
							{
								HlMxO[num2 + i].content[j] = Encoding.BigEndianUnicode.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num7))), (int)array[j].size);
							}
						}
						else
						{
							HlMxO[num2 + i].content[j] = Encoding.Default.GetString(djfrI, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num7))), (int)array[j].size);
						}
					}
					else
					{
						HlMxO[num2 + i].content[j] = Conversions.ToString(ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num5)), new decimal(num7))), (int)array[j].size));
					}
					num7 = (int)(num7 + array[j].size);
				}
			}
		}
		else if (djfrI[(uint)Offset] == 5)
		{
			ushort num9 = Convert.ToUInt16(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(3L))), 2)), 1m));
			int num10 = num9;
			for (int k = 0; k <= num10; k++)
			{
				ushort num11 = (ushort)ConvertToInteger(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Offset), new decimal(12L)), new decimal(k * 2))), 2);
				ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger((int)(Offset + num11), 4)), 1m), new decimal(JegpN))));
			}
			ReadTableFromOffset(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(ConvertToInteger(Convert.ToInt32(decimal.Add(new decimal(Offset), new decimal(8L))), 4)), 1m), new decimal(JegpN))));
		}
		return true;
	}

	public bool ReadTable(string TableName)
	{
		int num = -1;
		int num2 = tCqWS.Length;
		for (int i = 0; i <= num2; i++)
		{
			if (tCqWS[i].item_name.ToLower().CompareTo(TableName.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		object[] array = tCqWS[num].sql_statement.Substring(tCqWS[num].sql_statement.IndexOf("(") + 1).Split(new char[1] { ',' });
		int num3 = array.Length - 1;
		for (int j = 0; j <= num3; j++)
		{
			array[j] = Strings.LTrim(Conversions.ToString(array[j]));
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[j], (Type)null, "IndexOf", new object[1] { " " }, (string[])null, (Type[])null, (bool[])null));
			if (Operators.ConditionalCompareObjectGreater(objectValue, (object)0, false))
			{
				int num4 = j;
				object obj = array[j];
				object[] array2 = new object[2]
				{
					0,
					RuntimeHelpers.GetObjectValue(objectValue)
				};
				object[] array3 = array2;
				bool[] array4 = new bool[2] { false, true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Substring", array3, (string[])null, (Type[])null, array4);
				if (array4[1])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array2[1]);
				}
				array[num4] = RuntimeHelpers.GetObjectValue(obj2);
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(array[j], (Type)null, "IndexOf", new object[1] { "UNIQUE" }, (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				break;
			}
			RUMkO = (string[])Utils.CopyArray((Array)RUMkO, (Array)new string[j + 1]);
			RUMkO[j] = Conversions.ToString(array[j]);
		}
		return ReadTableFromOffset((ulong)((tCqWS[num].root_num - 1L) * JegpN));
	}

	public int GetRowCount()
	{
		return HlMxO.Length;
	}

	public string GetValue(int row_num, int field)
	{
		if (row_num >= HlMxO.Length)
		{
			return null;
		}
		if (field >= HlMxO[row_num].content.Length)
		{
			return null;
		}
		return HlMxO[row_num].content[field];
	}

	public string GetValue(int row_num, string field)
	{
		int num = -1;
		int num2 = RUMkO.Length;
		for (int i = 0; i <= num2; i++)
		{
			if (RUMkO[i].ToLower().CompareTo(field.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return GetValue(row_num, num);
	}

	public string[] GetTableNames()
	{
		object obj = 0;
		int num = tCqWS.Length - 1;
		string[] array = default(string[]);
		for (int i = 0; i <= num; i++)
		{
			if (Operators.CompareString(tCqWS[i].item_type, "table", false) == 0)
			{
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[Conversions.ToInteger(obj) + 1]);
				array[Conversions.ToInteger(obj)] = tCqWS[i].item_name;
				obj = Operators.AddObject(obj, (object)1);
			}
		}
		return array;
	}

	public scYNh(string baseName)
	{
		SRWHz = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		if (File.Exists(baseName))
		{
			FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string s = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref s, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			djfrI = Encoding.Default.GetBytes(s);
			if (Encoding.Default.GetString(djfrI, 0, 15).CompareTo("SQLite format 3") != 0)
			{
				throw new Exception("Not a valid SQLite 3 Database File");
			}
			if (djfrI[52] != 0)
			{
				throw new Exception("Auto-vacuum capable database is not supported");
			}
			if (decimal.Compare(new decimal(ConvertToInteger(44, 4)), new decimal(4L)) >= 0)
			{
				throw new Exception("No supported Schema layer file-format");
			}
			JegpN = (ushort)ConvertToInteger(16, 2);
			uXnUa = ConvertToInteger(56, 4);
			if (decimal.Compare(new decimal(uXnUa), 0m) == 0)
			{
				uXnUa = 1uL;
			}
			ReadMasterTable(100uL);
		}
	}

	static void YPcmV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IiWTN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uwGQL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hmXQX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sbdxa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jRiUY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yKbqM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Kpyzx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sSgZK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bDLYz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dNXdZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OUnvl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GVLOG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gQPDD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OIaXt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YFixe()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KRvWI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void riZmx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PTsge()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kGHQa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void trwhb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TElnJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Subsf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NJVlB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fVBJK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MDcrk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mmNWi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HdNXd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hOUnv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GGVLO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void WgQPD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QOIaX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zYFix()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RKRvW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XriZm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cPTsg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VkGHQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void strwh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bTEln()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TSubs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VNJVl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XfVBJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JMDcr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NmmNW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XHdNX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fhOUn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fGGVL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JWgQP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cQOIa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qzYFi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gRKRv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void iXriZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LcPTs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SVkGH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jstrw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MbTEl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wTSub()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wVNJV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SXfVB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FJMDc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yNmmN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FXHdN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CfhOU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ctUTj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fWkud()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dpebV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DFOlS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ptfYf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BwlGv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rZqcg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UgjxT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SxHHG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BZohR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jLhgI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oKibX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Lfksi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DTWZR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void eNazz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZTlUq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VQtvc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
