using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Aether2Svc.Properties;

public class MatPlot : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class0
	{
		public static readonly Class0 class0_0 = new Class0();

		public static Action<Class5> action_0;

		public static Action<Class5> action_1;

		public static Action<Class5> action_2;

		public static Action<Class5> action_3;

		public static Action<Class5> action_4;

		internal void method_0(Class5 class5_0)
		{
			class5_0.method_7();
		}

		internal void method_1(Class5 class5_0)
		{
			class5_0.method_6();
		}

		internal void method_2(Class5 class5_0)
		{
			IEnumerator<byte[]> enumerator = Class7.smethod_1<byte[]>(Resources.ResourceManager_0, CultureInfo.CurrentCulture).GetEnumerator();
			try
			{
				while (true)
				{
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = 1582363837;
						num2 = 1582363837;
					}
					else
					{
						num = -235055406;
						num2 = -235055406;
					}
					while (true)
					{
						int num3 = num;
						uint num4;
						switch ((num4 = (uint)((-(-(~num3)) + -413563482) * 219314621 * -1152241433) ^ 0x6E49F658u) % 4u)
						{
						case 3u:
							num = -235055406;
							continue;
						case 1u:
						{
							byte[] current = enumerator.Current;
							class5_0.list_0.Add(new MemoryStream(current));
							num = 1183324823;
							continue;
						}
						default:
							return;
						case 2u:
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
						IL_00e5:
						int num5 = -1356753992;
						while (true)
						{
							int num3 = num5;
							uint num4;
							switch ((num4 = (uint)((-(-(~num3)) + -413563482) * 219314621 * -1152241433) ^ 0x6E49F658u) % 3u)
							{
							case 2u:
								goto IL_009e;
							default:
								goto end_IL_00b1;
							case 0u:
								break;
							case 1u:
								goto end_IL_00b1;
							}
							goto IL_00e5;
							IL_009e:
							enumerator.Dispose();
							num5 = (int)(num4 * 2066640211) ^ -2124551690;
							continue;
							end_IL_00b1:
							break;
						}
						break;
					}
				}
			}
		}

		internal void method_3(Class5 class5_0)
		{
			int int_ = default(int);
			while (true)
			{
				int num = -325430957;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(((num2 - 1599435998) * -1854835361 * -767635265) ^ -411866978) * 1291712993)) % 4u)
					{
					case 3u:
						class5_0.method_0(int_, -1647652487);
						num = ((int)num3 * -705074610) ^ 0x7318DB94;
						continue;
					case 1u:
						int_ = -23743328;
						num = ((int)num3 * -903518693) ^ 0x386A207E;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		internal void method_4(Class5 class5_0)
		{
			foreach (Stream item in class5_0.list_0)
			{
				try
				{
					byte[] array = new byte[Class7.smethod_3(item, 1) ^ Class7.smethod_3(item, 5)];
					while (true)
					{
						IL_00b1:
						int num = -1776126808;
						while (true)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(~((num2 ^ -464637133) - -145305099)))) % 5u)
							{
							case 3u:
								item.Read(array, 0, array.Length);
								class5_0.method_1();
								num = (int)(num3 * 930620654) ^ -2046099763;
								continue;
							case 1u:
							{
								int num4;
								int num5;
								if (!class5_0.method_4(array))
								{
									num4 = -808544638;
									num5 = -808544638;
								}
								else
								{
									num4 = -1431699373;
									num5 = -1431699373;
								}
								num = num4 ^ ((int)num3 * -1164604155);
								continue;
							}
							default:
								goto end_IL_0081;
							case 0u:
								break;
							case 2u:
								return;
							case 4u:
								goto end_IL_0081;
							}
							goto IL_00b1;
							continue;
							end_IL_0081:
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
		public Action<Class5>[] action_0;

		internal bool method_0(Action<Class5>[] action_1)
		{
			int num = 0;
			while (true)
			{
				int num2;
				int num3;
				if (num < action_1.Length)
				{
					num2 = 805595592;
					num3 = 805595592;
				}
				else
				{
					num2 = 1792247305;
					num3 = 1792247305;
				}
				while (true)
				{
					int num4 = num2;
					switch ((uint)(~(-475994511 - (-(-(~(num4 ^ 0x1397792))) - -1716478080))) % 6u)
					{
					case 5u:
					{
						int num5;
						if (!(action_1[num] != action_0[num]))
						{
							num2 = 1938501518;
							num5 = 1938501518;
						}
						else
						{
							num2 = 1064023840;
							num5 = 1064023840;
						}
						continue;
					}
					case 4u:
						num2 = 805595592;
						continue;
					case 1u:
						num++;
						num2 = 839454301;
						continue;
					case 0u:
						break;
					default:
						return true;
					case 3u:
						return false;
					}
					break;
				}
			}
		}
	}

	private IList<Control0> ilist_0 = new List<Control0>();

	private Dictionary<Control0, Control1> dictionary_0 = new Dictionary<Control0, Control1>();

	private float float_0;

	private float float_1;

	private long long_0;

	private Image image_0;

	private Graphics graphics_0;

	private IContainer icontainer_0;

	private Panel panel1;

	private Button button3;

	private Button button2;

	private Button button1;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	public MatPlot()
	{
		InitializeComponent();
	}

	private void MatPlot_Load(object sender, EventArgs e)
	{
		method_1();
	}

	private Action<Class5>[] method_0()
	{
		return new Action<Class5>[5]
		{
			delegate(Class5 class5_0)
			{
				class5_0.method_7();
			},
			delegate(Class5 class5_0)
			{
				class5_0.method_6();
			},
			delegate(Class5 class5_0)
			{
				IEnumerator<byte[]> enumerator2 = Class7.smethod_1<byte[]>(Resources.ResourceManager_0, CultureInfo.CurrentCulture).GetEnumerator();
				try
				{
					while (true)
					{
						int num9;
						int num10;
						if (!enumerator2.MoveNext())
						{
							num9 = 1582363837;
							num10 = 1582363837;
						}
						else
						{
							num9 = -235055406;
							num10 = -235055406;
						}
						while (true)
						{
							int num11 = num9;
							uint num12;
							switch ((num12 = (uint)((-(-(~num11)) + -413563482) * 219314621 * -1152241433) ^ 0x6E49F658u) % 4u)
							{
							case 3u:
								num9 = -235055406;
								continue;
							case 1u:
							{
								byte[] current = enumerator2.Current;
								class5_0.list_0.Add(new MemoryStream(current));
								num9 = 1183324823;
								continue;
							}
							default:
								return;
							case 2u:
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
							IL_00e5:
							int num13 = -1356753992;
							while (true)
							{
								int num11 = num13;
								uint num12;
								switch ((num12 = (uint)((-(-(~num11)) + -413563482) * 219314621 * -1152241433) ^ 0x6E49F658u) % 3u)
								{
								case 2u:
									goto IL_009e;
								default:
									goto end_IL_00b1;
								case 0u:
									break;
								case 1u:
									goto end_IL_00b1;
								}
								goto IL_00e5;
								IL_009e:
								enumerator2.Dispose();
								num13 = (int)(num12 * 2066640211) ^ -2124551690;
								continue;
								end_IL_00b1:
								break;
							}
							break;
						}
					}
				}
			},
			delegate(Class5 class5_0)
			{
				int int_ = default(int);
				while (true)
				{
					int num6 = -325430957;
					while (true)
					{
						int num7 = num6;
						uint num8;
						switch ((num8 = (uint)(-(((num7 - 1599435998) * -1854835361 * -767635265) ^ -411866978) * 1291712993)) % 4u)
						{
						case 3u:
							class5_0.method_0(int_, -1647652487);
							num6 = ((int)num8 * -705074610) ^ 0x7318DB94;
							continue;
						case 1u:
							int_ = -23743328;
							num6 = ((int)num8 * -903518693) ^ 0x386A207E;
							continue;
						default:
							return;
						case 0u:
							break;
						case 2u:
							return;
						}
						break;
					}
				}
			},
			delegate(Class5 class5_0)
			{
				foreach (Stream item in class5_0.list_0)
				{
					try
					{
						byte[] array = new byte[Class7.smethod_3(item, 1) ^ Class7.smethod_3(item, 5)];
						while (true)
						{
							IL_00b1:
							int num = -1776126808;
							while (true)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(-(~((num2 ^ -464637133) - -145305099)))) % 5u)
								{
								case 3u:
									item.Read(array, 0, array.Length);
									class5_0.method_1();
									num = (int)(num3 * 930620654) ^ -2046099763;
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (!class5_0.method_4(array))
									{
										num4 = -808544638;
										num5 = -808544638;
									}
									else
									{
										num4 = -1431699373;
										num5 = -1431699373;
									}
									num = num4 ^ ((int)num3 * -1164604155);
									continue;
								}
								default:
									goto end_IL_0081;
								case 0u:
									break;
								case 2u:
									return;
								case 4u:
									goto end_IL_0081;
								}
								goto IL_00b1;
								continue;
								end_IL_0081:
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

	private static void smethod_0(Action<Class5>[] action_0)
	{
		Class5 obj = new Class5();
		int num4 = default(int);
		Action<Class5>[] array = default(Action<Class5>[]);
		while (true)
		{
			int num = -1394587039;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(~(~num2) - -2038438248 - -1375165840)))) % 9u)
				{
				case 8u:
				{
					int num6;
					if (num4 >= array.Length)
					{
						num = 1595126503;
						num6 = 1595126503;
					}
					else
					{
						num = -1440920832;
						num6 = -1440920832;
					}
					continue;
				}
				case 6u:
					array = action_0;
					num4 = 0;
					num = ((int)num3 * -1086384387) ^ 0xF0D406B;
					continue;
				case 5u:
					num = ((int)num3 * -306349721) ^ 0x64C7B1CE;
					continue;
				case 4u:
					array[num4](obj);
					num4++;
					num = -1735467131;
					continue;
				case 3u:
				{
					int num5;
					if (num4 < array.Length)
					{
						num = 892334885;
						num5 = 892334885;
					}
					else
					{
						num = 965552359;
						num5 = 965552359;
					}
					continue;
				}
				case 2u:
					array[num4](obj);
					num4++;
					num = -1364252524;
					continue;
				case 1u:
					obj = new Class5();
					Array.Reverse((Array)action_0);
					array = action_0;
					num4 = 0;
					num = (int)((num3 * 273757855) ^ 0x5A98A04);
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void method_1()
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		float_1 = 112.2f;
		float_0 = float_1 * 98f;
		long_0 = (int)float_0 + 21;
		Action<Class5>[] array = method_0();
		Action<Class5> action = default(Action<Class5>);
		int num4 = default(int);
		Control0 current2 = default(Control0);
		Control1 control = default(Control1);
		int num13 = default(int);
		Class4 class4_ = default(Class4);
		while (true)
		{
			int num = 1344168851;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~(-(num2 * -1071822121)) ^ 0x5B211B68))) % 5u)
				{
				case 3u:
					Array.Resize(ref array, array.Length - 1);
					num = ((int)num3 * -1463336884) ^ -703066516;
					continue;
				case 1u:
					action = array[^1];
					num = ((int)num3 * -1671540075) ^ 0x45337819;
					continue;
				case 0u:
					break;
				case 2u:
					num4 = 1;
					goto IL_00d4;
				default:
					{
						foreach (Action<Class5>[] item in method_2(array))
						{
							try
							{
								smethod_0(item);
							}
							catch
							{
							}
						}
						goto IL_00d4;
					}
					IL_00d4:
					if (num4-- <= 0)
					{
						while (true)
						{
							int num5 = -428717003;
							while (true)
							{
								num2 = num5;
								switch ((num3 = (uint)(~(~(-(num2 * -1071822121)) ^ 0x5B211B68))) % 4u)
								{
								case 2u:
									array[^1] = action;
									num5 = ((int)num3 * -1467282599) ^ 0x296B76F1;
									continue;
								case 1u:
									Array.Resize(ref array, array.Length + 1);
									num5 = ((int)num3 * -1802682008) ^ 0x63AB0F6;
									continue;
								case 0u:
									break;
								default:
								{
									foreach (Action<Class5>[] item2 in method_2(array))
									{
										try
										{
											smethod_0(item2);
										}
										catch
										{
										}
									}
									float num6 = 0f;
									if (graphics_0 == null)
									{
										while (true)
										{
											int num7 = 1266299554;
											while (true)
											{
												num2 = num7;
												switch ((num3 = (uint)(~(~(-(num2 * -1071822121)) ^ 0x5B211B68))) % 3u)
												{
												case 2u:
													image_0 = (Image)new Bitmap((int)((float)((Control)this).get_Width() * float_1), ((Control)this).get_Height());
													graphics_0 = Graphics.FromImage(image_0);
													num7 = ((int)num3 * -1175511215) ^ -1159329774;
													continue;
												case 0u:
													break;
												default:
													goto end_IL_0206;
												}
												break;
											}
											continue;
											end_IL_0206:
											break;
										}
									}
									float num8 = 90f;
									IEnumerator<Control0> enumerator2 = ilist_0.GetEnumerator();
									try
									{
										while (true)
										{
											IL_036b:
											int num9;
											int num10;
											if (!enumerator2.MoveNext())
											{
												num9 = -1033639757;
												num10 = -1033639757;
											}
											else
											{
												num9 = 666223049;
												num10 = 666223049;
											}
											while (true)
											{
												num2 = num9;
												switch ((num3 = (uint)(~(~(-(num2 * -1071822121)) ^ 0x5B211B68))) % 5u)
												{
												case 4u:
													num9 = 666223049;
													continue;
												case 3u:
													num6 += current2.unUGplMUvENKMrhpSucPiASyOwiV() * current2.XLxxMXUdScRZLKVoesUWzfDpPlIj() + current2.xQnXvaDECdjzLlvuotATECydEEufA();
													graphics_0.DrawBezier(Pens.get_Black(), num8, current2.unUGplMUvENKMrhpSucPiASyOwiV(), num6, num6 * float_1, num6 + float_1, num6 * float_1, num6 / 2f + num8, (float)((int)(num6 / 3f) ^ (int)num8));
													graphics_0.DrawBezier(Pens.get_White(), num8, current2.unUGplMUvENKMrhpSucPiASyOwiV(), num6, num6 * float_1, num6 + float_1, num6 * float_1, num6 / 2f + num8, (float)((int)(num6 / 3f) ^ (int)num8));
													num8 += 90f;
													num8 %= 360f;
													num9 = ((int)num3 * -1196338539) ^ -1145784012;
													continue;
												case 2u:
													current2 = enumerator2.Current;
													num9 = 859980319;
													continue;
												default:
													goto end_IL_032c;
												case 1u:
													break;
												case 0u:
													goto end_IL_032c;
												}
												goto IL_036b;
												continue;
												end_IL_032c:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											while (true)
											{
												IL_03bd:
												int num11 = 996787364;
												while (true)
												{
													num2 = num11;
													switch ((num3 = (uint)(~(~(-(num2 * -1071822121)) ^ 0x5B211B68))) % 3u)
													{
													case 2u:
														goto IL_0381;
													default:
														goto end_IL_0395;
													case 0u:
														break;
													case 1u:
														goto end_IL_0395;
													}
													goto IL_03bd;
													IL_0381:
													enumerator2.Dispose();
													num11 = (int)((num3 * 89051747) ^ 0x64A96C56);
													continue;
													end_IL_0395:
													break;
												}
												break;
											}
										}
									}
									((Control)this).set_BackgroundImage(image_0);
									while (true)
									{
										int num12 = 730825528;
										while (true)
										{
											num2 = num12;
											switch ((num3 = (uint)(~(~(-(num2 * -1071822121)) ^ 0x5B211B68))) % 11u)
											{
											case 10u:
												dictionary_0.Add(control, new Control2(null));
												num12 = -859270084;
												continue;
											case 9u:
												num13++;
												num12 = -1346707843;
												continue;
											case 8u:
												ilist_0.Add(control);
												num12 = (int)(num3 * 1744966814) ^ -288349085;
												continue;
											case 7u:
												class4_ = new Class4((int)float_0, (int)float_0 * 3);
												num12 = 1286862694;
												continue;
											case 5u:
											{
												control = new Control1();
												control.method_0(class4_);
												int num15;
												int num16;
												if (!dictionary_0.ContainsKey(control))
												{
													num15 = 478761401;
													num16 = 478761401;
												}
												else
												{
													num15 = 960567318;
													num16 = 960567318;
												}
												num12 = num15 ^ (int)(num3 * 1875761981);
												continue;
											}
											case 3u:
											{
												int num14;
												if (num13 < long_0)
												{
													num12 = -368317629;
													num14 = -368317629;
												}
												else
												{
													num12 = 1095378873;
													num14 = 1095378873;
												}
												continue;
											}
											case 2u:
												num13 = 0;
												num12 = (int)(num3 * 541496915) ^ -1667700663;
												continue;
											case 1u:
												num12 = ((int)num3 * -655795782) ^ 0x655280F7;
												continue;
											default:
												return;
											case 6u:
												break;
											case 0u:
												return;
											case 4u:
												return;
											}
											break;
										}
									}
								}
								}
								break;
							}
						}
					}
					goto default;
				}
				break;
			}
		}
	}

	private List<Action<Class5>[]> method_2(Action<Class5>[] action_0)
	{
		int num6 = default(int);
		int num4 = default(int);
		List<Action<Class5>[]> list = default(List<Action<Class5>[]>);
		Action<Class5>[] action_2 = default(Action<Class5>[]);
		while (true)
		{
			int num = -1261972872;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((num2 * -1635838213 - -1886849591) * 907102499 - -38185022 - -2053441285) * 816543347)) % 14u)
				{
				case 12u:
				{
					int num9;
					if (num6-- <= 0)
					{
						num = 944392560;
						num9 = 944392560;
					}
					else
					{
						num = -470184131;
						num9 = -470184131;
					}
					continue;
				}
				case 11u:
					num = ((int)num3 * -1673702140) ^ -943866699;
					continue;
				case 9u:
					num = ((int)num3 * -1033285408) ^ 0x60F21488;
					continue;
				case 8u:
					num6 *= num4;
					num4--;
					num = -1084777560;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (list.Exists(delegate(Action<Class5>[] action_1)
					{
						int num10 = 0;
						while (true)
						{
							int num11;
							int num12;
							if (num10 < action_1.Length)
							{
								num11 = 805595592;
								num12 = 805595592;
							}
							else
							{
								num11 = 1792247305;
								num12 = 1792247305;
							}
							while (true)
							{
								int num13 = num11;
								switch ((uint)(~(-475994511 - (-(-(~(num13 ^ 0x1397792))) - -1716478080))) % 6u)
								{
								case 5u:
								{
									int num14;
									if (!(action_1[num10] != action_2[num10]))
									{
										num11 = 1938501518;
										num14 = 1938501518;
									}
									else
									{
										num11 = 1064023840;
										num14 = 1064023840;
									}
									continue;
								}
								case 4u:
									num11 = 805595592;
									continue;
								case 1u:
									num10++;
									num11 = 839454301;
									continue;
								case 0u:
									break;
								default:
									return true;
								case 3u:
									return false;
								}
								break;
							}
						}
					}))
					{
						num7 = 545343140;
						num8 = 545343140;
					}
					else
					{
						num7 = 1776359896;
						num8 = 1776359896;
					}
					num = num7 ^ ((int)num3 * -735050351);
					continue;
				}
				case 6u:
					list.Add((Action<Class5>[])action_2.Clone());
					num = ((int)num3 * -771853796) ^ 0x585EBF51;
					continue;
				case 5u:
					num4 = action_2.Length;
					num = ((int)num3 * -2124318692) ^ -425377914;
					continue;
				case 4u:
					num6 = 1;
					num = ((int)num3 * -749833679) ^ -1503901502;
					continue;
				case 3u:
				{
					int num5;
					if (num4 <= 0)
					{
						num = 1074242362;
						num5 = 1074242362;
					}
					else
					{
						num = 1630985777;
						num5 = 1630985777;
					}
					continue;
				}
				case 2u:
					Class7.smethod_0(action_2);
					num = -1930047004;
					continue;
				case 1u:
					list = new List<Action<Class5>[]>();
					num = (int)((num3 * 1293763368) ^ 0x44115723);
					continue;
				case 0u:
					action_2 = Class7.smethod_0(action_0);
					num = ((int)num3 * -1583960030) ^ 0x715A19B3;
					continue;
				case 10u:
					break;
				default:
					return list;
				}
				break;
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		graphics_0.Clear(Color.Wheat);
		float num = 90f;
		float num2 = 0f;
		IEnumerator<Control0> enumerator = ilist_0.GetEnumerator();
		try
		{
			Control0 current = default(Control0);
			while (true)
			{
				int num3;
				int num4;
				if (enumerator.MoveNext())
				{
					num3 = 742886476;
					num4 = 742886476;
				}
				else
				{
					num3 = -427714910;
					num4 = -427714910;
				}
				while (true)
				{
					int num5 = num3;
					uint num6;
					switch ((num6 = (uint)(~((-((num5 - 610604423) * 1054050851) - -527711665) * 1721917117) + 121025026)) % 6u)
					{
					case 4u:
						num += 90f;
						num3 = (int)(num6 * 265087969) ^ -676150954;
						continue;
					case 3u:
						current = enumerator.Current;
						num3 = -663706609;
						continue;
					case 2u:
						num2 += current.unUGplMUvENKMrhpSucPiASyOwiV() * current.XLxxMXUdScRZLKVoesUWzfDpPlIj() + current.xQnXvaDECdjzLlvuotATECydEEufA();
						graphics_0.DrawBezier(Pens.get_White(), num, current.unUGplMUvENKMrhpSucPiASyOwiV(), num2, num2 * float_1, num2 + float_1, num2 * float_1, num2 / 2f + num, (float)((int)(num2 / 3f) ^ (int)num));
						num3 = ((int)num6 * -787868977) ^ 0x6BB49A87;
						continue;
					case 0u:
						num3 = 742886476;
						continue;
					default:
						return;
					case 1u:
						break;
					case 5u:
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
					IL_0194:
					int num7 = 1391469135;
					while (true)
					{
						int num5 = num7;
						uint num6;
						switch ((num6 = (uint)(~((-((num5 - 610604423) * 1054050851) - -527711665) * 1721917117) + 121025026)) % 3u)
						{
						case 1u:
							goto IL_0146;
						default:
							goto end_IL_015a;
						case 0u:
							break;
						case 2u:
							goto end_IL_015a;
						}
						goto IL_0194;
						IL_0146:
						enumerator.Dispose();
						num7 = (int)((num6 * 1936531832) ^ 0x328CFDC0);
						continue;
						end_IL_015a:
						break;
					}
					break;
				}
			}
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		using Dictionary<Control0, Control1>.Enumerator enumerator = dictionary_0.GetEnumerator();
		KeyValuePair<Control0, Control1> current = default(KeyValuePair<Control0, Control1>);
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1279683261;
				num2 = 1279683261;
			}
			else
			{
				num = -1830833867;
				num2 = -1830833867;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				switch ((num4 = (uint)(-(-(-(num3 * 1514211191) - -1977320118)) * 139252217 * 768541791)) % 5u)
				{
				case 3u:
					current = enumerator.Current;
					num = -882613246;
					continue;
				case 2u:
					listView1.get_Items().Add(new ListViewItem(current.ToString()));
					num = (int)((num4 * 263404753) ^ 0x72D27CCF);
					continue;
				case 0u:
					num = 1279683261;
					continue;
				default:
					return;
				case 1u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		listView1.Clear();
	}

	protected override void DMnQTnxxdTfFtwBXCNEcXgACSVsc(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = 310602151;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((733391043 - num2 - -1047854985) * -623867473)) % 4u)
					{
					case 3u:
					{
						int num4;
						int num5;
						if (icontainer_0 != null)
						{
							num4 = -2109874957;
							num5 = -2109874957;
						}
						else
						{
							num4 = 594104504;
							num5 = 594104504;
						}
						num = num4 ^ (int)(num3 * 1970961530);
						continue;
					}
					case 1u:
						Environment.Exit(0);
						icontainer_0.Dispose();
						num = ((int)num3 * -900510557) ^ 0x51F31195;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_007b;
					}
					break;
				}
				continue;
				end_IL_007b:
				break;
			}
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		panel1 = new Panel();
		while (true)
		{
			int num = 53986856;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((-num2 ^ -1869360008) - 301345223) * -1836198531)) % 34u)
				{
				case 33u:
					((Control)button1).add_Click((EventHandler)button1_Click);
					num = ((int)num3 * -57593236) ^ -988226929;
					continue;
				case 32u:
					((Control)panel1).set_Dock((DockStyle)5);
					((Control)panel1).set_Location(new Point(15, 15));
					((Control)panel1).set_Name("panel1");
					((Control)panel1).set_Padding(new Padding(10));
					num = ((int)num3 * -1497170395) ^ 0x1E5AFED4;
					continue;
				case 31u:
					((Form)this).set_ClientSize(new Size(685, 572));
					num = (int)(num3 * 1902626921) ^ -2122827179;
					continue;
				case 30u:
					listView1.set_UseCompatibleStateImageBehavior(false);
					num = ((int)num3 * -362165935) ^ 0x2167B8F0;
					continue;
				case 29u:
					((Control)button1).set_TabIndex(0);
					num = ((int)num3 * -1298092448) ^ 0x6B3C67;
					continue;
				case 28u:
					((Control)button2).set_Location(new Point(167, 13));
					num = (int)(num3 * 1767613993) ^ -659491172;
					continue;
				case 27u:
					listView1.set_View((View)1);
					num = ((int)num3 * -1618689857) ^ 0x6DE1D306;
					continue;
				case 26u:
					columnHeader_0.set_Width(34);
					columnHeader_1.set_Text("Message");
					columnHeader_1.set_Width(469);
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 14f));
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num = ((int)num3 * -105325770) ^ -2065254900;
					continue;
				case 25u:
					((Control)panel1).set_Size(new Size(655, 542));
					((Control)panel1).set_TabIndex(0);
					num = ((int)num3 * -566550144) ^ 0x547E0F12;
					continue;
				case 24u:
					((Control)this).set_Padding(new Padding(15));
					((Control)this).set_Text("Rest");
					num = ((int)num3 * -1185963988) ^ 0x37C4AA27;
					continue;
				case 23u:
					((Control)panel1).get_Controls().Add((Control)(object)button2);
					((Control)panel1).get_Controls().Add((Control)(object)button1);
					num = ((int)num3 * -916664402) ^ -921825253;
					continue;
				case 22u:
					((Control)button2).set_Text("Insert DOM");
					((ButtonBase)button2).set_UseVisualStyleBackColor(true);
					((Control)button2).add_Click((EventHandler)button2_Click);
					((Control)button3).set_Location(new Point(321, 13));
					num = ((int)num3 * -1008216105) ^ 0x63ED4B24;
					continue;
				case 21u:
					((Control)button2).set_TabIndex(1);
					num = (int)((num3 * 247018851) ^ 0x19D1FB7E);
					continue;
				case 20u:
					columnHeader_0.set_Text("Id");
					num = ((int)num3 * -1777713002) ^ -1012281333;
					continue;
				case 19u:
					((Control)button1).set_Location(new Point(13, 13));
					num = ((int)num3 * -380013532) ^ -1122438459;
					continue;
				case 18u:
					((Form)this).add_Load((EventHandler)MatPlot_Load);
					num = (int)(num3 * 1707810510) ^ -2144800328;
					continue;
				case 17u:
					((Control)button3).set_Name("button3");
					num = (int)((num3 * 1753867250) ^ 0x54593490);
					continue;
				case 16u:
					((Control)this).set_Name("MatPlot");
					num = ((int)num3 * -1195309758) ^ 0x38672B43;
					continue;
				case 15u:
					((Control)this).SuspendLayout();
					num = (int)(num3 * 1852691588) ^ -1171279668;
					continue;
				case 14u:
					listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader_0, columnHeader_1 });
					((Control)listView1).set_Location(new Point(13, 67));
					((Control)listView1).set_Name("listView1");
					num = (int)((num3 * 703567517) ^ 0x75B0A9A9);
					continue;
				case 13u:
					((Control)button2).set_Name("button2");
					((Control)button2).set_Size(new Size(148, 48));
					num = (int)((num3 * 385607817) ^ 0x611CEFE7);
					continue;
				case 12u:
					((Control)button3).set_TabIndex(2);
					((Control)button3).set_Text("Clear State");
					((ButtonBase)button3).set_UseVisualStyleBackColor(true);
					((Control)button3).add_Click((EventHandler)button3_Click);
					num = (int)((num3 * 1830257418) ^ 0x76634AA3);
					continue;
				case 11u:
					((Control)button3).set_Size(new Size(148, 48));
					num = ((int)num3 * -1358443753) ^ -612799248;
					continue;
				case 10u:
					listView1 = new ListView();
					num = (int)((num3 * 1985853778) ^ 0x6E0912E1);
					continue;
				case 9u:
					((Control)this).get_Controls().Add((Control)(object)panel1);
					((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					((Form)this).set_Margin(new Padding(2, 3, 2, 3));
					num = (int)((num3 * 1370691057) ^ 0xB308A92);
					continue;
				case 8u:
					((Control)button1).set_Name("button1");
					((Control)button1).set_Size(new Size(148, 48));
					num = (int)(num3 * 168243775) ^ -624836050;
					continue;
				case 6u:
					columnHeader_1 = new ColumnHeader();
					((Control)panel1).SuspendLayout();
					num = ((int)num3 * -791304332) ^ 0x2DDF3C1E;
					continue;
				case 4u:
					((Control)listView1).set_Size(new Size(627, 460));
					((Control)listView1).set_TabIndex(3);
					num = ((int)num3 * -430468191) ^ 0x3BFF251D;
					continue;
				case 3u:
					panel1.set_BorderStyle((BorderStyle)1);
					((Control)panel1).get_Controls().Add((Control)(object)listView1);
					((Control)panel1).get_Controls().Add((Control)(object)button3);
					num = ((int)num3 * -2049848039) ^ 0x1B11139F;
					continue;
				case 2u:
					columnHeader_0 = new ColumnHeader();
					num = ((int)num3 * -1232452928) ^ 0x18916D25;
					continue;
				case 1u:
					button1 = new Button();
					button2 = new Button();
					button3 = new Button();
					num = ((int)num3 * -240994042) ^ 0x2D049A87;
					continue;
				case 0u:
					((Control)button1).set_Text("Find DOM");
					((ButtonBase)button1).set_UseVisualStyleBackColor(true);
					num = (int)(num3 * 1369186830) ^ -2050907946;
					continue;
				case 7u:
					break;
				default:
					((Control)panel1).ResumeLayout(false);
					((Control)this).ResumeLayout(false);
					return;
				}
				break;
			}
		}
	}
}
