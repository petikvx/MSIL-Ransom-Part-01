using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using XZ2Studio.Properties;

public class Simulator : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class0
	{
		public static readonly Class0 class0_0 = new Class0();

		public static Action<Class6> action_0;

		public static Action<Class6> action_1;

		public static Action<Class6> action_2;

		public static Action<Class6> action_3;

		internal void method_0(Class6 class6_0)
		{
			class6_0.method_6();
		}

		internal void method_1(Class6 class6_0)
		{
			IEnumerator<byte[]> enumerator = Class8.smethod_1<byte[]>(Resources.smethod_0(), CultureInfo.CurrentCulture).GetEnumerator();
			try
			{
				while (true)
				{
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = -529560178;
						num2 = -529560178;
					}
					else
					{
						num = 235857281;
						num2 = 235857281;
					}
					while (true)
					{
						int num3 = num;
						uint num4;
						switch ((num4 = (uint)(1649968579 - ((-(((159049782 - num3) ^ 0x4B8E7347) - -1527946865) ^ 0x3BB30449) - -2012809322))) % 4u)
						{
						case 2u:
							num = 235857281;
							continue;
						case 1u:
						{
							byte[] current = enumerator.Current;
							class6_0.list_0.Add(new MemoryStream(current));
							num = 1399531051;
							continue;
						}
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
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						IL_00fc:
						int num5 = -528261985;
						while (true)
						{
							int num3 = num5;
							uint num4;
							switch ((num4 = (uint)(1649968579 - ((-(((159049782 - num3) ^ 0x4B8E7347) - -1527946865) ^ 0x3BB30449) - -2012809322))) % 3u)
							{
							case 1u:
								goto IL_00ab;
							default:
								goto end_IL_00be;
							case 0u:
								break;
							case 2u:
								goto end_IL_00be;
							}
							goto IL_00fc;
							IL_00ab:
							enumerator.Dispose();
							num5 = ((int)num4 * -2127877137) ^ 0x394E7B4C;
							continue;
							end_IL_00be:
							break;
						}
						break;
					}
				}
			}
		}

		internal void method_2(Class6 class6_0)
		{
			int num = 0;
			int int_ = 146282101;
			num = -472594914;
			while (true)
			{
				int num2 = -1521454709;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(((-(~num3) ^ 0x3BC36108) - -517011595) * 1245113091 * 852757133 - 1689138289)) % 3u)
					{
					case 1u:
						goto IL_0010;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0010:
					class6_0.method_0(int_, num);
					num2 = ((int)num4 * -1830602643) ^ 0x7FDA63C7;
				}
			}
		}

		internal void method_3(Class6 class6_0)
		{
			foreach (Stream item in class6_0.list_0)
			{
				try
				{
					byte[] array = new byte[Class8.smethod_3(item, 1) ^ Class8.smethod_3(item, 5)];
					item.Read(array, 0, array.Length);
					class6_0.method_1();
					while (true)
					{
						IL_00af:
						int num = 1728272292;
						while (true)
						{
							int num2 = num;
							uint num3;
							int num4;
							switch ((num3 = (uint)(-(-((num2 - 333722415) * 465919919 - -450861108 - 1966294310) * -757790479))) % 4u)
							{
							case 1u:
							{
								int num5;
								if (!class6_0.method_4(array))
								{
									num4 = -2084027652;
									num5 = -2084027652;
								}
								else
								{
									num4 = -324198785;
									num5 = -324198785;
								}
								goto IL_0067;
							}
							default:
								goto end_IL_0071;
							case 2u:
								break;
							case 0u:
								goto end_IL_0071;
							case 3u:
								return;
							}
							goto IL_00af;
							IL_0067:
							num = num4 ^ (int)(num3 * 625113);
							continue;
							end_IL_0071:
							break;
						}
						break;
					}
				}
				catch
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class1
	{
		public Action<Class6>[] action_0;

		internal bool method_0(Action<Class6>[] action_1)
		{
			int num = 0;
			while (true)
			{
				int num2;
				int num3;
				if (num >= action_1.Length)
				{
					num2 = -428051100;
					num3 = -428051100;
				}
				else
				{
					num2 = -71295125;
					num3 = -71295125;
				}
				while (true)
				{
					int num4 = num2;
					switch ((uint)(1646632993 - -(-(~((-1820403434 - num4 - 1561919557) ^ -1774273780)))) % 6u)
					{
					case 4u:
					{
						int num5;
						if (!(action_1[num] != action_0[num]))
						{
							num2 = -1093089463;
							num5 = -1093089463;
						}
						else
						{
							num2 = -372770770;
							num5 = -372770770;
						}
						continue;
					}
					case 2u:
						num++;
						num2 = -1456566312;
						continue;
					case 0u:
						num2 = -71295125;
						continue;
					case 1u:
						break;
					case 3u:
						return false;
					default:
						return true;
					}
					break;
				}
			}
		}
	}

	private Class2 class2_0;

	private int int_0;

	private IContainer icontainer_0;

	private Button runBtn;

	private Button button1;

	private NumericUpDown numericUpDown1;

	private Label label1;

	private ListView listView1;

	public Simulator()
	{
		InitializeComponent();
	}

	private void Simulator_Load(object sender, EventArgs e)
	{
		method_1();
	}

	private Action<Class6>[] method_0()
	{
		return new Action<Class6>[4]
		{
			delegate(Class6 class6_0)
			{
				class6_0.method_6();
			},
			delegate(Class6 class6_0)
			{
				IEnumerator<byte[]> enumerator2 = Class8.smethod_1<byte[]>(Resources.smethod_0(), CultureInfo.CurrentCulture).GetEnumerator();
				try
				{
					while (true)
					{
						int num11;
						int num12;
						if (!enumerator2.MoveNext())
						{
							num11 = -529560178;
							num12 = -529560178;
						}
						else
						{
							num11 = 235857281;
							num12 = 235857281;
						}
						while (true)
						{
							int num13 = num11;
							uint num14;
							switch ((num14 = (uint)(1649968579 - ((-(((159049782 - num13) ^ 0x4B8E7347) - -1527946865) ^ 0x3BB30449) - -2012809322))) % 4u)
							{
							case 2u:
								num11 = 235857281;
								continue;
							case 1u:
							{
								byte[] current = enumerator2.Current;
								class6_0.list_0.Add(new MemoryStream(current));
								num11 = 1399531051;
								continue;
							}
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
				finally
				{
					if (enumerator2 != null)
					{
						while (true)
						{
							IL_00fc:
							int num15 = -528261985;
							while (true)
							{
								int num13 = num15;
								uint num14;
								switch ((num14 = (uint)(1649968579 - ((-(((159049782 - num13) ^ 0x4B8E7347) - -1527946865) ^ 0x3BB30449) - -2012809322))) % 3u)
								{
								case 1u:
									goto IL_00ab;
								default:
									goto end_IL_00be;
								case 0u:
									break;
								case 2u:
									goto end_IL_00be;
								}
								goto IL_00fc;
								IL_00ab:
								enumerator2.Dispose();
								num15 = ((int)num14 * -2127877137) ^ 0x394E7B4C;
								continue;
								end_IL_00be:
								break;
							}
							break;
						}
					}
				}
			},
			delegate(Class6 class6_0)
			{
				int num6 = 0;
				int num7 = 146282101;
				num6 = -472594914;
				while (true)
				{
					int num8 = -1521454709;
					while (true)
					{
						int num9 = num8;
						uint num10;
						switch ((num10 = (uint)(((-(~num9) ^ 0x3BC36108) - -517011595) * 1245113091 * 852757133 - 1689138289)) % 3u)
						{
						case 1u:
							goto IL_0010;
						default:
							return;
						case 2u:
							break;
						case 0u:
							return;
						}
						break;
						IL_0010:
						class6_0.method_0(num7, num6);
						num8 = ((int)num10 * -1830602643) ^ 0x7FDA63C7;
					}
				}
			},
			delegate(Class6 class6_0)
			{
				foreach (Stream item in class6_0.list_0)
				{
					try
					{
						byte[] array = new byte[Class8.smethod_3(item, 1) ^ Class8.smethod_3(item, 5)];
						item.Read(array, 0, array.Length);
						class6_0.method_1();
						while (true)
						{
							IL_00af:
							int num = 1728272292;
							while (true)
							{
								int num2 = num;
								uint num3;
								int num4;
								switch ((num3 = (uint)(-(-((num2 - 333722415) * 465919919 - -450861108 - 1966294310) * -757790479))) % 4u)
								{
								case 1u:
								{
									int num5;
									if (!class6_0.method_4(array))
									{
										num4 = -2084027652;
										num5 = -2084027652;
									}
									else
									{
										num4 = -324198785;
										num5 = -324198785;
									}
									goto IL_0067;
								}
								default:
									goto end_IL_0071;
								case 2u:
									break;
								case 0u:
									goto end_IL_0071;
								case 3u:
									return;
								}
								goto IL_00af;
								IL_0067:
								num = num4 ^ (int)(num3 * 625113);
								continue;
								end_IL_0071:
								break;
							}
							break;
						}
					}
					catch
					{
					}
				}
			}
		};
	}

	private static void smethod_0(Action<Class6>[] action_0)
	{
		Class6 obj = new Class6();
		int num = 0;
		while (true)
		{
			int num2;
			int num3;
			if (num >= action_0.Length)
			{
				num2 = -553226515;
				num3 = -553226515;
			}
			else
			{
				num2 = -1711910242;
				num3 = -1711910242;
			}
			while (true)
			{
				int num4 = num2;
				switch ((uint)((num4 ^ -1798594299 ^ -528775604) + 1576295886) % 4u)
				{
				case 1u:
					action_0[num](obj);
					num++;
					num2 = -1287540064;
					continue;
				case 0u:
					num2 = -1711910242;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_1()
	{
		Action<Class6>[] array = method_0();
		Action<Class6> action = default(Action<Class6>);
		int num4 = default(int);
		while (true)
		{
			int num = -1681984776;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(131097499 - (~(~(~num2)) + 873347491) - -181963924)) % 5u)
				{
				case 3u:
					action = array[^1];
					num = ((int)num3 * -236827613) ^ -1412073708;
					continue;
				case 0u:
					Array.Resize(ref array, array.Length - 1);
					num4 = 1;
					num = (int)((num3 * 257306699) ^ 0xD85B047);
					continue;
				case 4u:
					break;
				case 1u:
					if (num4-- <= 0)
					{
						while (true)
						{
							int num5 = 1338214913;
							while (true)
							{
								num2 = num5;
								switch ((num3 = (uint)(131097499 - (~(~(~num2)) + 873347491) - -181963924)) % 3u)
								{
								case 1u:
									goto IL_00c4;
								case 2u:
									break;
								default:
									array[^1] = action;
									{
										foreach (Action<Class6>[] item in method_2(array))
										{
											try
											{
												smethod_0(item);
											}
											catch
											{
											}
										}
										return;
									}
								}
								break;
								IL_00c4:
								Array.Resize(ref array, array.Length + 1);
								num5 = ((int)num3 * -819887578) ^ -1383771439;
							}
						}
					}
					goto default;
				default:
					foreach (Action<Class6>[] item2 in method_2(array))
					{
						try
						{
							smethod_0(item2);
						}
						catch
						{
						}
					}
					goto case 1u;
				}
				break;
			}
		}
	}

	private List<Action<Class6>[]> method_2(Action<Class6>[] action_0)
	{
		List<Action<Class6>[]> list = new List<Action<Class6>[]>();
		Action<Class6>[] action_2 = default(Action<Class6>[]);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -1701629751;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((~(334946101 - (1783685890 - num2 + -345398822)) * 67921645) ^ -597418889) + -1993373797)) % 11u)
				{
				case 10u:
					num = (int)(num3 * 197667304) ^ -1997643073;
					continue;
				case 8u:
				{
					Class8.smethod_0(action_2);
					int num7;
					if (list.Exists(delegate(Action<Class6>[] action_1)
					{
						int num9 = 0;
						while (true)
						{
							int num10;
							int num11;
							if (num9 >= action_1.Length)
							{
								num10 = -428051100;
								num11 = -428051100;
							}
							else
							{
								num10 = -71295125;
								num11 = -71295125;
							}
							while (true)
							{
								int num12 = num10;
								switch ((uint)(1646632993 - -(-(~((-1820403434 - num12 - 1561919557) ^ -1774273780)))) % 6u)
								{
								case 4u:
								{
									int num13;
									if (!(action_1[num9] != action_2[num9]))
									{
										num10 = -1093089463;
										num13 = -1093089463;
									}
									else
									{
										num10 = -372770770;
										num13 = -372770770;
									}
									continue;
								}
								case 2u:
									num9++;
									num10 = -1456566312;
									continue;
								case 0u:
									num10 = -71295125;
									continue;
								case 1u:
									break;
								case 3u:
									return false;
								default:
									return true;
								}
								break;
							}
						}
					}))
					{
						num = 1869079034;
						num7 = 1869079034;
					}
					else
					{
						num = -946079919;
						num7 = -946079919;
					}
					continue;
				}
				case 6u:
				{
					int num8;
					if (num4-- <= 0)
					{
						num = -2027951114;
						num8 = -2027951114;
					}
					else
					{
						num = 1869079034;
						num8 = 1869079034;
					}
					continue;
				}
				case 5u:
					num5 = action_2.Length;
					num = (int)((num3 * 492470408) ^ 0x6EA46481);
					continue;
				case 4u:
					num = (int)((num3 * 522312386) ^ 0xB0A472F);
					continue;
				case 3u:
					num4 *= num5;
					num5--;
					num = 932596045;
					continue;
				case 2u:
				{
					int num6;
					if (num5 > 0)
					{
						num = -1812367047;
						num6 = -1812367047;
					}
					else
					{
						num = 1182921121;
						num6 = 1182921121;
					}
					continue;
				}
				case 1u:
					action_2 = Class8.smethod_0(action_0);
					num4 = 1;
					num = ((int)num3 * -1294479621) ^ -1006494081;
					continue;
				case 0u:
					list.Add((Action<Class6>[])action_2.Clone());
					num = ((int)num3 * -1657039615) ^ -931825994;
					continue;
				case 7u:
					break;
				default:
					return list;
				}
				break;
			}
		}
	}

	private void runBtn_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		IEnumerator<Stream> enumerator = class2_0.ilist_0.GetEnumerator();
		try
		{
			Label val = default(Label);
			Stream current = default(Stream);
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1966091883;
					num2 = 1966091883;
				}
				else
				{
					num = -602843310;
					num2 = -602843310;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)(~(~(-(~(~num3) ^ -580544002))) * 1341305363)) % 6u)
					{
					case 4u:
						num = 1966091883;
						continue;
					case 3u:
					{
						ListViewItem val2 = new ListViewItem();
						val2.set_Tag((object)val);
						listView1.get_Items().Add(val2);
						num = (int)((num4 * 32724370) ^ 0x4B31E533);
						continue;
					}
					case 2u:
						((Control)val).set_Text(class2_0.idictionary_0[current]);
						num = (int)(num4 * 709011893) ^ -861510911;
						continue;
					case 1u:
						current = enumerator.Current;
						val = new Label();
						num = 712503700;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_012c:
					int num5 = 1800499123;
					while (true)
					{
						int num3 = num5;
						uint num4;
						switch ((num4 = (uint)(~(~(-(~(~num3) ^ -580544002))) * 1341305363)) % 3u)
						{
						case 2u:
							goto IL_00ef;
						default:
							goto end_IL_0102;
						case 0u:
							break;
						case 1u:
							goto end_IL_0102;
						}
						goto IL_012c;
						IL_00ef:
						enumerator.Dispose();
						num5 = (int)((num4 * 824187107) ^ 0x53BDBCF9);
						continue;
						end_IL_0102:
						break;
					}
					break;
				}
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Stream item = class2_0.ilist_0[class2_0.ilist_0.Count - 1];
		class2_0.ilist_0.Clear();
		class2_0.ilist_0.Add((Stream)(object)numericUpDown1.get_Value().ToString());
		class2_0.ilist_0.Add(item);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		class2_0 = new Class2();
		int_0++;
	}

	private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	{
		class2_0.decimal_0 = numericUpDown1.get_Value() + (decimal)int_0;
	}

	protected override void gnmZWzxOFrfAMLuofvxTSSbJLMPG(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = 15460731;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(-(num2 - 921687295) - 697519249)))) % 5u)
					{
					case 3u:
						icontainer_0.Dispose();
						num = ((int)num3 * -2102868954) ^ 0x3D0D0878;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (icontainer_0 != null)
						{
							num4 = -1442094283;
							num5 = -1442094283;
						}
						else
						{
							num4 = -2017175460;
							num5 = -2017175460;
						}
						num = num4 ^ ((int)num3 * -2046784323);
						continue;
					}
					case 0u:
						Environment.Exit(0);
						num = (int)((num3 * 1354954994) ^ 0x52B9DFB3);
						continue;
					case 2u:
						break;
					default:
						goto end_IL_0091;
					}
					break;
				}
				continue;
				end_IL_0091:
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		runBtn = new Button();
		button1 = new Button();
		while (true)
		{
			int num = 390316449;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(897101267 - ((((num2 + -1351503950) ^ 0x568E1F1C) - -276873362) ^ 0x59CE5E92)) - -1321283487)) % 30u)
				{
				case 29u:
					numericUpDown1 = new NumericUpDown();
					label1 = new Label();
					num = ((int)num3 * -1579559529) ^ 0x4219C9DD;
					continue;
				case 28u:
					((Control)runBtn).set_Name("runBtn");
					num = ((int)num3 * -1105784166) ^ -1543575438;
					continue;
				case 27u:
					((Control)label1).set_Name("label1");
					num = ((int)num3 * -1752506495) ^ -1892275649;
					continue;
				case 26u:
					((Control)button1).set_Location(new Point(349, 12));
					((Control)button1).set_Margin(new Padding(2, 3, 2, 3));
					((Control)button1).set_Name("button1");
					num = (int)(num3 * 496282911) ^ -1971649101;
					continue;
				case 25u:
					((Control)button1).set_Size(new Size(251, 25));
					((Control)button1).set_TabIndex(8);
					((Control)button1).set_Text("Init");
					((ButtonBase)button1).set_UseVisualStyleBackColor(true);
					((Control)button1).add_Click((EventHandler)button1_Click);
					((Control)numericUpDown1).set_Location(new Point(56, 43));
					num = ((int)num3 * -36185125) ^ 0xE5941C7;
					continue;
				case 24u:
					((Control)runBtn).set_Size(new Size(332, 25));
					num = ((int)num3 * -615259214) ^ -648424972;
					continue;
				case 23u:
					((Control)listView1).set_Name("listView1");
					((Control)listView1).set_Size(new Size(586, 162));
					num = (int)((num3 * 618792460) ^ 0x689898DD);
					continue;
				case 22u:
					((Control)label1).set_Size(new Size(38, 14));
					((Control)label1).set_TabIndex(10);
					((Control)label1).set_Text("Steps:");
					num = (int)((num3 * 1542404983) ^ 0x26625AB7);
					continue;
				case 21u:
					((Form)this).set_Margin(new Padding(2, 3, 2, 3));
					((Control)this).set_Name("Simulator");
					num = ((int)num3 * -886375388) ^ 0x3516C815;
					continue;
				case 20u:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 14f));
					num = ((int)num3 * -1393029620) ^ 0x6C45D3B1;
					continue;
				case 19u:
					((Form)this).set_ClientSize(new Size(611, 243));
					num = (int)((num3 * 1374275558) ^ 0x28DBA172);
					continue;
				case 18u:
					((ISupportInitialize)numericUpDown1).BeginInit();
					((Control)this).SuspendLayout();
					((Control)runBtn).set_Location(new Point(13, 12));
					((Control)runBtn).set_Margin(new Padding(2, 3, 2, 3));
					num = ((int)num3 * -1009669629) ^ 0x328BA99A;
					continue;
				case 17u:
					((Control)label1).set_Location(new Point(15, 45));
					num = (int)(num3 * 2099660833) ^ -1869508914;
					continue;
				case 16u:
					((Form)this).add_Load((EventHandler)Simulator_Load);
					num = ((int)num3 * -1303589210) ^ 0x717B425E;
					continue;
				case 15u:
					((Control)this).get_Controls().Add((Control)(object)button1);
					num = ((int)num3 * -372251847) ^ 0xAD6C19B;
					continue;
				case 14u:
					((Control)numericUpDown1).set_Name("numericUpDown1");
					num = (int)((num3 * 1494359405) ^ 0x41DBD5F3);
					continue;
				case 12u:
					((Control)runBtn).set_Text("Simulate");
					((ButtonBase)runBtn).set_UseVisualStyleBackColor(true);
					((Control)runBtn).add_Click((EventHandler)runBtn_Click);
					num = ((int)num3 * -374791157) ^ -353709788;
					continue;
				case 11u:
					((Control)numericUpDown1).set_Size(new Size(543, 20));
					((Control)numericUpDown1).set_TabIndex(9);
					numericUpDown1.add_ValueChanged((EventHandler)numericUpDown1_ValueChanged);
					((Control)label1).set_AutoSize(true);
					num = ((int)num3 * -722320351) ^ -315573482;
					continue;
				case 10u:
					((Control)this).get_Controls().Add((Control)(object)listView1);
					((Control)this).get_Controls().Add((Control)(object)label1);
					((Control)this).get_Controls().Add((Control)(object)numericUpDown1);
					num = ((int)num3 * -2049286612) ^ 0xBD91C4F;
					continue;
				case 9u:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num = (int)((num3 * 761795250) ^ 0x211A4955);
					continue;
				case 8u:
					((ISupportInitialize)numericUpDown1).EndInit();
					num = (int)((num3 * 1920152011) ^ 0x3E527740);
					continue;
				case 7u:
					((Control)listView1).set_TabIndex(13);
					listView1.set_UseCompatibleStateImageBehavior(false);
					num = ((int)num3 * -651190608) ^ -1564392346;
					continue;
				case 6u:
					((Control)this).ResumeLayout(false);
					((Control)this).PerformLayout();
					num = (int)(num3 * 385483244) ^ -1588265591;
					continue;
				case 4u:
					((Control)this).get_Controls().Add((Control)(object)runBtn);
					((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num3 * -1627442317) ^ -1964836709;
					continue;
				case 3u:
					((Control)this).set_Text("X11 Runner");
					num = (int)((num3 * 1154502155) ^ 0x34BF5017);
					continue;
				case 2u:
					((Control)runBtn).set_TabIndex(6);
					num = ((int)num3 * -1967507169) ^ -1321398134;
					continue;
				case 1u:
					((Control)listView1).set_Location(new Point(13, 69));
					num = (int)(num3 * 91085414) ^ -561341275;
					continue;
				case 0u:
					listView1 = new ListView();
					num = (int)((num3 * 1222952436) ^ 0x23A87F4C);
					continue;
				default:
					return;
				case 13u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}
}
