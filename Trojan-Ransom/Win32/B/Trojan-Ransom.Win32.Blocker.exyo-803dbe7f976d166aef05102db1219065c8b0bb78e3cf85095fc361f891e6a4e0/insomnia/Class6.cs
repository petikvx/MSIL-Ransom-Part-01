using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace insomnia;

public class Class6
{
	private struct Struct5
	{
		public long Field2;

		public long Field1;
	}

	private struct Struct6
	{
		public long Field6;

		public string Field5;

		public string Field4;

		public string Field3;

		public long Field2;

		public string Field1;
	}

	private struct Struct7
	{
		public long Field2;

		public string[] Field1;
	}

	private byte[] Field7;

	private ushort Field6;

	private ulong Field5;

	private Struct6[] Field4;

	private byte[] Field3;

	private Struct7[] Field2;

	private string[] Field1;

	public Class6(string baseName)
	{
		Field3 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		checked
		{
			if (File.Exists(baseName))
			{
				FileSystem.FileOpen(1, baseName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string s = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref s, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				Field7 = Encoding.Default.GetBytes(s);
				if (Encoding.Default.GetString(Field7, 0, 15).CompareTo("SQLite format 3") != 0)
				{
					throw new Exception("Not a valid SQLite 3 Database File");
				}
				if (Field7[52] != 0)
				{
					throw new Exception("Auto-vacuum capable database is not supported");
				}
				if (decimal.Compare(new decimal(Method8(44, 4)), new decimal(4L)) >= 0)
				{
					throw new Exception("No supported Schema layer file-format");
				}
				Field6 = (ushort)Method8(16, 2);
				Field5 = Method8(56, 4);
				if (decimal.Compare(new decimal(Field5), 0m) == 0)
				{
					Field5 = 1uL;
				}
				Method7(100uL);
			}
		}
	}

	private int Method11(int A_1)
	{
		if (A_1 > Field7.Length)
		{
			return 0;
		}
		checked
		{
			int num = A_1 + 8;
			int num2 = A_1;
			while (true)
			{
				if (num2 <= num)
				{
					if (num2 <= Field7.Length - 1)
					{
						if ((Field7[num2] & 0x80) != 128)
						{
							break;
						}
						num2++;
						continue;
					}
					return 0;
				}
				return A_1 + 8;
			}
			return num2;
		}
	}

	private long Method10(int A_1, int A_2)
	{
		checked
		{
			A_2++;
			byte[] array = new byte[8];
			int num = A_2 - A_1;
			bool flag = false;
			if (unchecked(num == 0 || num > 9))
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(Field7[A_1] & 0x7F);
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
				array[0] = Field7[A_2 - 1];
				A_2--;
				num4 = 1;
			}
			for (int i = A_2 - 1; i >= A_1; i += -1)
			{
				if (i - 1 >= A_1)
				{
					array[num4] = (byte)unchecked(((byte)((uint)Field7[i] >> (checked(num2 - 1) & 7)) & (255 >> num2)) | (byte)(Field7[checked(i - 1)] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)(unchecked((byte)((uint)Field7[i] >> (checked(num2 - 1) & 7))) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
	}

	private bool Method9(long A_1)
	{
		return (A_1 & 1L) == 1L;
	}

	private ulong Method8(int A_1, int A_2)
	{
		if (A_2 > 8 || A_2 == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		checked
		{
			int num2 = A_2 - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = (num << 8) | Field7[A_1 + i];
			}
			return num;
		}
	}

	private void Method7(ulong A_1)
	{
		checked
		{
			if (Field7[(int)A_1] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(Method8(Convert.ToInt32(decimal.Add(new decimal(A_1), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (Field4 != null)
				{
					num2 = Field4.Length;
					Field4 = (Struct6[])Utils.CopyArray((Array)Field4, (Array)new Struct6[Field4.Length + unchecked((int)num) + 1]);
				}
				else
				{
					Field4 = new Struct6[unchecked((int)num) + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = Method8(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(A_1), new decimal(8L)), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(A_1), new decimal(100L)) != 0)
					{
						num4 += A_1;
					}
					int num5 = Method11((int)num4);
					Method10((int)num4, num5);
					int num6 = Method11(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					Field4[num2 + i].Field6 = Method10(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = Method11((int)num4);
					num6 = num5;
					long value = Method10((int)num4, num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = Method11(num5);
						array[num7] = Method10(num5, num6);
						if (array[num7] <= 9L)
						{
							array[num7] = Field3[(int)array[num7]];
						}
						else if (Method9(array[num7]))
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
						}
						else
						{
							array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
						}
						num7++;
					}
					while (num7 <= 4);
					if (decimal.Compare(new decimal(Field5), 1m) == 0)
					{
						Field4[num2 + i].Field5 = Encoding.Default.GetString(Field7, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(Field5), new decimal(2L)) == 0)
					{
						Field4[num2 + i].Field5 = Encoding.Unicode.GetString(Field7, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(Field5), new decimal(3L)) == 0)
					{
						Field4[num2 + i].Field5 = Encoding.BigEndianUnicode.GetString(Field7, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(Field5), 1m) == 0)
					{
						Field4[num2 + i].Field4 = Encoding.Default.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(Field5), new decimal(2L)) == 0)
					{
						Field4[num2 + i].Field4 = Encoding.Unicode.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(Field5), new decimal(3L)) == 0)
					{
						Field4[num2 + i].Field4 = Encoding.BigEndianUnicode.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					Field4[num2 + i].Field2 = (long)Method8(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(Field5), 1m) == 0)
					{
						Field4[num2 + i].Field1 = Encoding.Default.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(Field5), new decimal(2L)) == 0)
					{
						Field4[num2 + i].Field1 = Encoding.Unicode.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(Field5), new decimal(3L)) == 0)
					{
						Field4[num2 + i].Field1 = Encoding.BigEndianUnicode.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (Field7[(int)A_1] != 5)
				{
					return;
				}
				ushort num8 = Convert.ToUInt16(decimal.Subtract(new decimal(Method8(Convert.ToInt32(decimal.Add(new decimal(A_1), new decimal(3L))), 2)), 1m));
				int num9 = num8;
				for (int j = 0; j <= num9; j++)
				{
					ushort num10 = (ushort)Method8(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(A_1), new decimal(12L)), new decimal(j * 2))), 2);
					if (decimal.Compare(new decimal(A_1), new decimal(100L)) == 0)
					{
						Method7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Method8(num10, 4)), 1m), new decimal(Field6))));
					}
					else
					{
						Method7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Method8((int)(A_1 + num10), 4)), 1m), new decimal(Field6))));
					}
				}
				Method7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Method8(Convert.ToInt32(decimal.Add(new decimal(A_1), new decimal(8L))), 4)), 1m), new decimal(Field6))));
			}
		}
	}

	private bool Method6(ulong A_1)
	{
		checked
		{
			if (Field7[(int)A_1] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(Method8(Convert.ToInt32(decimal.Add(new decimal(A_1), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (Field2 != null)
				{
					num2 = Field2.Length;
					Field2 = (Struct7[])Utils.CopyArray((Array)Field2, (Array)new Struct7[Field2.Length + unchecked((int)num) + 1]);
				}
				else
				{
					Field2 = new Struct7[unchecked((int)num) + 1];
				}
				int num3 = num;
				Struct5[] array = default(Struct5[]);
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = Method8(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(A_1), new decimal(8L)), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(A_1), new decimal(100L)) != 0)
					{
						num4 += A_1;
					}
					int num5 = Method11((int)num4);
					Method10((int)num4, num5);
					int num6 = Method11(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					Field2[num2 + i].Field2 = Method10(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = Method11((int)num4);
					num6 = num5;
					long num7 = Method10((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (Struct5[])Utils.CopyArray((Array)array, (Array)new Struct5[num9 + 1]);
						num5 = num6 + 1;
						num6 = Method11(num5);
						array[num9].Field1 = Method10(num5, num6);
						if (array[num9].Field1 > 9L)
						{
							if (Method9(array[num9].Field1))
							{
								array[num9].Field2 = (long)Math.Round((double)(array[num9].Field1 - 13L) / 2.0);
							}
							else
							{
								array[num9].Field2 = (long)Math.Round((double)(array[num9].Field1 - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].Field2 = Field3[(int)array[num9].Field1];
						}
						num8 = num8 + (num6 - num5) + 1L;
						num9++;
					}
					Field2[num2 + i].Field1 = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].Field1 > 9L)
						{
							if (!Method9(array[j].Field1))
							{
								if (decimal.Compare(new decimal(Field5), 1m) == 0)
								{
									Field2[num2 + i].Field1[j] = Encoding.Default.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Field2);
								}
								else if (decimal.Compare(new decimal(Field5), new decimal(2L)) == 0)
								{
									Field2[num2 + i].Field1[j] = Encoding.Unicode.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Field2);
								}
								else if (decimal.Compare(new decimal(Field5), new decimal(3L)) == 0)
								{
									Field2[num2 + i].Field1[j] = Encoding.BigEndianUnicode.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Field2);
								}
							}
							else
							{
								Field2[num2 + i].Field1[j] = Encoding.Default.GetString(Field7, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Field2);
							}
						}
						else
						{
							Field2[num2 + i].Field1[j] = Conversions.ToString(Method8(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Field2));
						}
						num10 = (int)(num10 + array[j].Field2);
					}
				}
			}
			else if (Field7[(int)A_1] == 5)
			{
				ushort num12 = Convert.ToUInt16(decimal.Subtract(new decimal(Method8(Convert.ToInt32(decimal.Add(new decimal(A_1), new decimal(3L))), 2)), 1m));
				int num13 = num12;
				for (int k = 0; k <= num13; k++)
				{
					ushort num14 = (ushort)Method8(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(A_1), new decimal(12L)), new decimal(k * 2))), 2);
					Method6(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Method8((int)(A_1 + num14), 4)), 1m), new decimal(Field6))));
				}
				Method6(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Method8(Convert.ToInt32(decimal.Add(new decimal(A_1), new decimal(8L))), 4)), 1m), new decimal(Field6))));
			}
			return true;
		}
	}

	public bool Method5(string A_1)
	{
		int num = -1;
		int num2 = Field4.Length;
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				if (Field4[i].Field4.ToLower().CompareTo(A_1.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = Field4[num].Field1.Substring(Field4[num].Field1.IndexOf("(") + 1).Split(new char[1] { ',' });
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = Strings.LTrim(array[j]);
				int num4 = array[j].IndexOf(" ");
				if (num4 > 0)
				{
					array[j] = array[j].Substring(0, num4);
				}
				if (array[j].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				Field1 = (string[])Utils.CopyArray((Array)Field1, (Array)new string[j + 1]);
				Field1[j] = array[j];
			}
			return Method6((ulong)((Field4[num].Field2 - 1L) * unchecked((long)Field6)));
		}
	}

	public int Method4()
	{
		return Field2.Length;
	}

	public string Method3(int A_1, int A_2)
	{
		if (A_1 >= Field2.Length)
		{
			return null;
		}
		if (A_2 >= Field2[A_1].Field1.Length)
		{
			return null;
		}
		return Field2[A_1].Field1[A_2];
	}

	public string Method2(int A_1, string A_2)
	{
		int num = -1;
		int num2 = Field1.Length;
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			if (Field1[i].ToLower().CompareTo(A_2.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return Method3(A_1, num);
	}

	public string[] Method1()
	{
		int num = 0;
		checked
		{
			int num2 = Field4.Length - 1;
			string[] array = default(string[]);
			for (int i = 0; i <= num2; i++)
			{
				if (Operators.CompareString(Field4[i].Field5, "table", false) == 0)
				{
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
					array[num] = Field4[i].Field4;
					num++;
				}
			}
			return array;
		}
	}
}
