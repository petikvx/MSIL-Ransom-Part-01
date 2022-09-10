using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form1 : Form
{
	private string string_0;

	private string string_1;

	private Bitmap bitmap_0;

	private IntPtr intptr_0;

	private Icon icon_0;

	private FileStream fileStream_0;

	private int int_0;

	private Color color_0;

	private IContainer icontainer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolTip1")]
	private ToolTip toolTip_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon notifyIcon_0;

	internal virtual Button cmdopen
	{
		[CompilerGenerated]
		get
		{
			return _cmdopen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			Button val = _cmdopen;
			while (true)
			{
				int num = 1080860814;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D0E82EDu) % 7u)
					{
					case 6u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 348672542;
							num6 = 348672542;
						}
						else
						{
							num5 = 913952833;
							num6 = 913952833;
						}
						num = num5 ^ (int)(num2 * 968830039);
						continue;
					}
					case 4u:
						_cmdopen = value;
						num = 59097391;
						continue;
					case 2u:
						((Control)val).add_Click(eventHandler);
						num = (int)((num2 * 1946706294) ^ 0x15989BEA);
						continue;
					case 1u:
						((Control)val).remove_Click(eventHandler);
						num = ((int)num2 * -2107491201) ^ 0x43E05ECC;
						continue;
					case 0u:
					{
						val = _cmdopen;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1950992383;
							num4 = 1950992383;
						}
						else
						{
							num3 = 1248217482;
							num4 = 1248217482;
						}
						num = num3 ^ ((int)num2 * -36473182);
						continue;
					}
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
	}

	internal virtual Button cmdconvers
	{
		[CompilerGenerated]
		get
		{
			return _cmdconvers;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			Button val = default(Button);
			while (true)
			{
				int num = -1629844435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x956B8294u) % 9u)
					{
					case 8u:
						((Control)val).add_Click(eventHandler);
						num = (int)((num2 * 208437678) ^ 0x3AEA89D4);
						continue;
					case 7u:
						val = _cmdconvers;
						num = (int)(num2 * 893527779) ^ -696432110;
						continue;
					case 6u:
						val = _cmdconvers;
						num = ((int)num2 * -1878053064) ^ 0xA8D7D78;
						continue;
					case 4u:
						((Control)val).remove_Click(eventHandler);
						num = (int)((num2 * 1336938288) ^ 0x5DFD1367);
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1703715709;
							num6 = -1703715709;
						}
						else
						{
							num5 = -598907238;
							num6 = -598907238;
						}
						num = num5 ^ (int)(num2 * 1433901667);
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1612730709;
							num4 = -1612730709;
						}
						else
						{
							num3 = -1779972230;
							num4 = -1779972230;
						}
						num = num3 ^ (int)(num2 * 792380623);
						continue;
					}
					case 1u:
						_cmdconvers = value;
						num = -468289606;
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
	}

	[field: AccessedThroughProperty("Pic")]
	internal virtual PictureBox Pic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton3")]
	internal virtual RadioButton RadioButton3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton2")]
	internal virtual RadioButton RadioButton2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton1")]
	internal virtual RadioButton RadioButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolTip ToolTip_0
	{
		[CompilerGenerated]
		get
		{
			return toolTip_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			toolTip_0 = value;
		}
	}

	internal virtual NotifyIcon NotifyIcon_0
	{
		[CompilerGenerated]
		get
		{
			return notifyIcon_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			notifyIcon_0 = value;
		}
	}

	[field: AccessedThroughProperty("lblinfo")]
	internal virtual Label lblinfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button cmdcolor
	{
		[CompilerGenerated]
		get
		{
			return _cmdcolor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_1;
			Button val = _cmdcolor;
			while (true)
			{
				int num = 918179739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x31F20C0Eu) % 7u)
					{
					case 6u:
					{
						val = _cmdcolor;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1185945653;
							num6 = 1185945653;
						}
						else
						{
							num5 = 1115583954;
							num6 = 1115583954;
						}
						num = num5 ^ ((int)num2 * -624538960);
						continue;
					}
					case 4u:
						_cmdcolor = value;
						num = 1899366731;
						continue;
					case 2u:
						((Control)val).add_Click(eventHandler);
						num = ((int)num2 * -387002290) ^ -1656541907;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -1138290979;
							num4 = -1138290979;
						}
						else
						{
							num3 = -1672570060;
							num4 = -1672570060;
						}
						num = num3 ^ ((int)num2 * -584135806);
						continue;
					}
					case 0u:
						((Control)val).remove_Click(eventHandler);
						num = (int)(num2 * 99236575) ^ -1192494343;
						continue;
					default:
						return;
					case 5u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		color_0 = Color.Green;
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)lblinfo).set_ForeColor(color_0);
		Thread thread = default(Thread);
		while (true)
		{
			int num = -1343921249;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB978FC95u) % 4u)
				{
				case 2u:
					thread = new Thread(method_3);
					num = ((int)num2 * -138052958) ^ -1453067260;
					continue;
				case 1u:
					thread.Start();
					num = ((int)num2 * -947607864) ^ 0x7B1084BA;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Invalid comparison between Unknown and I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val5 = default(Bitmap);
		OpenFileDialog val2 = default(OpenFileDialog);
		Bitmap val3 = default(Bitmap);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		OpenFileDialog val = default(OpenFileDialog);
		bool flag = default(bool);
		while (true)
		{
			int num = -1038092408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBC45AA8u) % 31u)
				{
				case 30u:
					num = (int)(num2 * 216304802) ^ -1325852801;
					continue;
				case 29u:
					num = ((int)num2 * -116705217) ^ 0x2E40074F;
					continue;
				case 28u:
					val5 = new Bitmap(string_0);
					num = (int)((num2 * 2090199875) ^ 0x316B1E89);
					continue;
				case 27u:
					val2 = null;
					num = (int)(num2 * 666648216) ^ -1542097845;
					continue;
				case 26u:
					val3 = new Bitmap(int_0, int_0);
					num = (int)((num2 * 1432188876) ^ 0x252A8A60);
					continue;
				case 25u:
					int_0 = 96;
					num = (int)((num2 * 1843653362) ^ 0x7D2EAAC4);
					continue;
				case 24u:
				{
					int num5;
					if (!(flag2 = flag3 == RadioButton3.get_Checked()))
					{
						num = -120813778;
						num5 = -120813778;
					}
					else
					{
						num = -985800459;
						num5 = -985800459;
					}
					continue;
				}
				case 23u:
					num = (int)((num2 * 1419090316) ^ 0x648BC7E);
					continue;
				case 22u:
				{
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					checked
					{
						val4.DrawImage((Image)(object)val5, 0, 0, ((Image)val3).get_Width() + 1, ((Image)val3).get_Height() + 1);
					}
					num = ((int)num2 * -2071397334) ^ 0x4A4029A1;
					continue;
				}
				case 21u:
					num = -933990292;
					continue;
				case 20u:
					((FileDialog)val2).set_Filter("Images Files (*.bmp,*.png,*.gif)|*.jpg;*.bmp;*.png;*.gif");
					num = (int)(num2 * 215216899) ^ -459569495;
					continue;
				case 19u:
					flag3 = true;
					num = (int)(num2 * 94435468) ^ -1188957595;
					continue;
				case 18u:
					flag2 = flag3 == RadioButton2.get_Checked();
					num = -189953698;
					continue;
				case 17u:
					string_0 = ((FileDialog)val2).get_FileName();
					num = ((int)num2 * -621357764) ^ 0x69272035;
					continue;
				case 16u:
					val = new OpenFileDialog();
					num = (int)(num2 * 1940047048) ^ -1619955406;
					continue;
				case 15u:
					num = ((int)num2 * -1277182849) ^ -1344937236;
					continue;
				case 14u:
					num = (int)((num2 * 1537517901) ^ 0x5EFB59CF);
					continue;
				case 13u:
					((FileDialog)val2).set_DefaultExt(".jpg");
					num = (int)((num2 * 1633246298) ^ 0x6AB2BC40);
					continue;
				case 12u:
					num = ((int)num2 * -979357938) ^ -401483487;
					continue;
				case 11u:
					int_0 = 32;
					num = (int)(num2 * 1310936532) ^ -730327346;
					continue;
				case 9u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -2086713200;
						num9 = -2086713200;
					}
					else
					{
						num8 = -1418219533;
						num9 = -1418219533;
					}
					num = num8 ^ (int)(num2 * 757546623);
					continue;
				}
				case 8u:
					int_0 = 48;
					num = (int)(num2 * 838680273) ^ -661349075;
					continue;
				case 7u:
					((Component)(object)val2).Dispose();
					num = -743056474;
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (flag2 = flag3 == RadioButton1.get_Checked())
					{
						num6 = 501740138;
						num7 = 501740138;
					}
					else
					{
						num6 = 1393026656;
						num7 = 1393026656;
					}
					num = num6 ^ ((int)num2 * -13830422);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1468339429;
						num4 = 1468339429;
					}
					else
					{
						num3 = 1004847456;
						num4 = 1004847456;
					}
					num = num3 ^ ((int)num2 * -785078170);
					continue;
				}
				case 4u:
					((Image)val3).Save(Application.get_StartupPath() + "\\temp.bmp", ImageFormat.get_Bmp());
					Pic.set_Image(Image.FromFile(string_0));
					((Control)cmdconvers).set_Enabled(true);
					num = (int)(num2 * 2122079044) ^ -1547608080;
					continue;
				case 2u:
					((FileDialog)val2).set_FilterIndex(1);
					((FileDialog)val2).set_Title("Choisissez l'image à convertir.");
					flag = (int)((CommonDialog)val2).ShowDialog() == 1;
					num = (int)(num2 * 525531550) ^ -452173917;
					continue;
				case 1u:
					MessageBox.Show("Opération annulée par l'utilisateur!", "Ouverture Image", (MessageBoxButtons)0, (MessageBoxIcon)64);
					num = -1480973773;
					continue;
				case 0u:
					val2 = val;
					num = ((int)num2 * -1941667374) ^ 0x670EC1BE;
					continue;
				default:
					return;
				case 3u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		ColorDialog val = default(ColorDialog);
		bool flag = default(bool);
		while (true)
		{
			int num = 1877825839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D0C7BA5u) % 11u)
				{
				case 10u:
					val.set_AllowFullOpen(true);
					num = ((int)num2 * -720300134) ^ 0x57AC99E6;
					continue;
				case 9u:
					num = ((int)num2 * -1105244186) ^ -95172047;
					continue;
				case 8u:
					val.set_ShowHelp(true);
					num = (int)((num2 * 793283361) ^ 0x2954CD68);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1716664027;
						num4 = 1716664027;
					}
					else
					{
						num3 = 115235901;
						num4 = 115235901;
					}
					num = num3 ^ ((int)num2 * -107348339);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1782497522) ^ -1245513532;
					continue;
				case 3u:
					val.set_Color(color_0);
					flag = (int)((CommonDialog)val).ShowDialog() == 1;
					num = ((int)num2 * -46128827) ^ 0x235A7385;
					continue;
				case 2u:
					((Control)lblinfo).set_ForeColor(color_0);
					num = (int)((num2 * 913212751) ^ 0x6A389ED0);
					continue;
				case 1u:
					val = new ColorDialog();
					num = (int)(num2 * 950895075) ^ -1898725656;
					continue;
				case 0u:
					color_0 = val.get_Color();
					num = (int)((num2 * 1084953245) ^ 0x7199B04C);
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

	private void method_2(object sender, EventArgs e)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Invalid comparison between Unknown and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		SaveFileDialog val2 = default(SaveFileDialog);
		SaveFileDialog val = default(SaveFileDialog);
		while (true)
		{
			int num = -1886192908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2DCC347u) % 37u)
				{
				case 36u:
					num = ((int)num2 * -227216312) ^ 0x49A54C65;
					continue;
				case 35u:
					icon_0.Save((Stream)fileStream_0);
					num = ((int)num2 * -585177314) ^ -767364781;
					continue;
				case 34u:
					((FileDialog)val2).set_FilterIndex(1);
					num = ((int)num2 * -1450610) ^ -747335513;
					continue;
				case 33u:
					num = ((int)num2 * -1409604593) ^ -165694845;
					continue;
				case 32u:
					Pic.set_Image(Image.FromFile(string_1));
					num = (int)((num2 * 677421251) ^ 0x44931F3);
					continue;
				case 31u:
					((Control)cmdconvers).set_Enabled(false);
					((Control)cmdopen).set_Enabled(false);
					num = (int)((num2 * 133719405) ^ 0x1DD16D04);
					continue;
				case 30u:
					((FileDialog)val2).set_RestoreDirectory(true);
					num = (int)(num2 * 1839641566) ^ -1518086203;
					continue;
				case 29u:
					((FileDialog)val2).set_DefaultExt(".ico");
					num = (int)((num2 * 204406265) ^ 0x370D10C);
					continue;
				case 28u:
					((FileDialog)val2).set_FileName("Monicône");
					num = ((int)num2 * -273892117) ^ 0x73CC1ECE;
					continue;
				case 27u:
					num = ((int)num2 * -1964143134) ^ -637747064;
					continue;
				case 26u:
					num = ((int)num2 * -1556658899) ^ 0x4CAFAD52;
					continue;
				case 25u:
					((Component)(object)val2).Dispose();
					val2 = null;
					num = -277180345;
					continue;
				case 24u:
					num = ((int)num2 * -1703540878) ^ -1563223178;
					continue;
				case 23u:
					num = (int)(num2 * 2057222708) ^ -691021799;
					continue;
				case 22u:
					intptr_0 = bitmap_0.GetHicon();
					num = (int)(num2 * 1034866738) ^ -563367668;
					continue;
				case 21u:
					num = (int)((num2 * 1623079276) ^ 0x77A4E1F3);
					continue;
				case 20u:
					((Form)this).set_DialogResult(((CommonDialog)val2).ShowDialog());
					num = ((int)num2 * -2062038617) ^ 0x7D2BF46;
					continue;
				case 19u:
					num = ((int)num2 * -1504225205) ^ 0xBD706E;
					continue;
				case 18u:
					num = ((int)num2 * -442968704) ^ 0x43DF915;
					continue;
				case 17u:
					((FileDialog)val2).set_Title("Sélectionnez le répertoire de destination de l'icône.");
					num = (int)((num2 * 84330976) ^ 0x74A6B31A);
					continue;
				case 16u:
					icon_0 = Icon.FromHandle(intptr_0);
					num = ((int)num2 * -205467896) ^ -1491794059;
					continue;
				case 15u:
					((FileDialog)val2).set_Filter("Icône Files(*.ico)|*.ico");
					num = (int)((num2 * 1799037519) ^ 0x1C068ADC);
					continue;
				case 14u:
					string_1 = ((FileDialog)val2).get_FileName();
					num = (int)(num2 * 877588861) ^ -339548926;
					continue;
				case 13u:
				{
					int num3;
					int num4;
					if ((int)((Form)this).get_DialogResult() != 1)
					{
						num3 = -359673853;
						num4 = -359673853;
					}
					else
					{
						num3 = -120137037;
						num4 = -120137037;
					}
					num = num3 ^ ((int)num2 * -2086752312);
					continue;
				}
				case 12u:
					val = new SaveFileDialog();
					num = ((int)num2 * -606106013) ^ 0x8FDE732;
					continue;
				case 11u:
					((Form)this).set_Icon(icon_0);
					num = (int)(num2 * 1306815495) ^ -344672642;
					continue;
				case 10u:
					MessageBox.Show("Opération annulée par l'utilisateur!", "Convertir icône", (MessageBoxButtons)0, (MessageBoxIcon)64);
					num = -161330800;
					continue;
				case 9u:
					fileStream_0.Close();
					num = (int)((num2 * 1734429412) ^ 0x106CA3B5);
					continue;
				case 8u:
					bitmap_0.SetResolution(72f, 72f);
					num = ((int)num2 * -1983149495) ^ 0x3BD783DB;
					continue;
				case 7u:
					val2 = val;
					num = ((int)num2 * -1558218271) ^ -841234076;
					continue;
				case 6u:
					num = ((int)num2 * -762164329) ^ -1769023275;
					continue;
				case 4u:
					MessageBox.Show("Opération réussie.", "Convertir icône", (MessageBoxButtons)0, (MessageBoxIcon)64);
					num = (int)((num2 * 1037881208) ^ 0x16505972);
					continue;
				case 3u:
					fileStream_0 = new FileStream(string_1, FileMode.CreateNew);
					num = (int)((num2 * 2098995653) ^ 0x418BD3AB);
					continue;
				case 2u:
					bitmap_0 = new Bitmap(Application.get_StartupPath() + "\\temp.bmp");
					bitmap_0.MakeTransparent(color_0);
					num = (int)(num2 * 919740826) ^ -1016627775;
					continue;
				case 1u:
					num = ((int)num2 * -226714236) ^ 0x288149F8;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void method_3()
	{
		Random random = new Random();
		while (true)
		{
			int num = 1495606044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x55148B46u) % 4u)
				{
				default:
					Thread.Sleep(random.Next(20000, 30000));
					num = 982408627;
					continue;
				case 2u:
					num = (int)(num2 * 418813830) ^ -666277713;
					continue;
				case 0u:
					break;
				}
				break;
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		Thread thread = new Thread(Class7.smethod_4);
		while (true)
		{
			int num = 1616916778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E728E33u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1534994555) ^ 0x2DC361BD);
					continue;
				case 1u:
					thread.Start();
					num = (int)(num2 * 452568015) ^ -1389091638;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -726592614;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xA1B34B86u) % 7u)
					{
					case 6u:
						num = -1254846122;
						continue;
					case 4u:
						if (disposing)
						{
							num = ((int)num2 * -724027226) ^ 0x5E7073FE;
							continue;
						}
						num3 = 0;
						goto IL_0021;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1869840748;
							num5 = 1869840748;
						}
						else
						{
							num4 = 1567536394;
							num5 = 1567536394;
						}
						num = num4 ^ ((int)num2 * -706634184);
						continue;
					}
					case 2u:
						icontainer_0.Dispose();
						num = (int)((num2 * 1603920267) ^ 0xFCCBF68);
						continue;
					case 1u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_0021;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
						IL_0021:
						flag = (byte)num3 != 0;
						num = -1988811690;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00dc:
				int num6 = -251072246;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0xA1B34B86u) % 3u)
					{
					case 2u:
						goto IL_00ab;
					default:
						goto end_IL_00bf;
					case 0u:
						break;
					case 1u:
						goto end_IL_00bf;
					}
					goto IL_00dc;
					IL_00ab:
					((Form)this).Dispose(disposing);
					num6 = (int)((num2 * 1949507037) ^ 0x63802621);
					continue;
					end_IL_00bf:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected O, but got Unknown
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num = 738840060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E528DA3u) % 127u)
				{
				case 126u:
					((Control)Pic).set_Size(new Size(130, 130));
					num = ((int)num2 * -1340829523) ^ -807802854;
					continue;
				case 125u:
					num = ((int)num2 * -1026031111) ^ 0x164CE301;
					continue;
				case 124u:
					((Control)RadioButton1).set_Name("RadioButton1");
					num = ((int)num2 * -1586297969) ^ 0x71100F94;
					continue;
				case 123u:
					((Control)RadioButton2).set_TabIndex(1);
					num = (int)(num2 * 397314007) ^ -184106866;
					continue;
				case 122u:
					((Control)RadioButton1).set_Size(new Size(59, 17));
					num = (int)(num2 * 1462958752) ^ -1427885550;
					continue;
				case 121u:
					((Control)RadioButton3).set_Name("RadioButton3");
					num = ((int)num2 * -731838390) ^ -1535200334;
					continue;
				case 120u:
					((ButtonBase)RadioButton2).set_Text("48 * 48");
					num = (int)(num2 * 466594805) ^ -527135505;
					continue;
				case 119u:
					num = ((int)num2 * -754387034) ^ 0x13C8A9BE;
					continue;
				case 118u:
					componentResourceManager = new ComponentResourceManager(typeof(Form1));
					num = ((int)num2 * -1865886730) ^ -2121118941;
					continue;
				case 117u:
					((Control)cmdconvers).set_Enabled(false);
					num = ((int)num2 * -2033448914) ^ 0x623AC357;
					continue;
				case 116u:
					GroupBox1.set_Text("Tailles");
					num = ((int)num2 * -833291569) ^ 0x2EEADDC1;
					continue;
				case 115u:
					Pic = new PictureBox();
					num = (int)((num2 * 2118132010) ^ 0x23774562);
					continue;
				case 114u:
					((Control)RadioButton2).set_Name("RadioButton2");
					((Control)RadioButton2).set_Size(new Size(59, 17));
					num = (int)((num2 * 570090423) ^ 0x24EA86AD);
					continue;
				case 113u:
					num = (int)((num2 * 609534546) ^ 0x3A0336D3);
					continue;
				case 112u:
					((Control)cmdopen).set_Name("cmdopen");
					((Control)cmdopen).set_Size(new Size(75, 23));
					num = ((int)num2 * -1088111501) ^ -1113604325;
					continue;
				case 111u:
					num = (int)((num2 * 1517290245) ^ 0x7115AD85);
					continue;
				case 110u:
					((Control)cmdconvers).set_Size(new Size(75, 23));
					num = (int)(num2 * 620531048) ^ -1443306085;
					continue;
				case 109u:
					((ISupportInitialize)Pic).BeginInit();
					num = ((int)num2 * -1211701763) ^ 0x75734E35;
					continue;
				case 108u:
					num = (int)(num2 * 1376542391) ^ -1072704813;
					continue;
				case 107u:
					num = (int)((num2 * 1007236110) ^ 0x34C5E054);
					continue;
				case 106u:
					((Control)Pic).set_Name("Pic");
					num = ((int)num2 * -19323508) ^ 0x530533B9;
					continue;
				case 105u:
					((Control)cmdcolor).set_TabIndex(5);
					((ButtonBase)cmdcolor).set_Text("Couleur");
					num = ((int)num2 * -37530679) ^ -1854370069;
					continue;
				case 104u:
					Pic.set_SizeMode((PictureBoxSizeMode)4);
					num = ((int)num2 * -548740649) ^ 0x6DACB86F;
					continue;
				case 103u:
					((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
					num = (int)((num2 * 670524088) ^ 0x237FC54B);
					continue;
				case 102u:
					num = (int)((num2 * 198801025) ^ 0x46ECFA79);
					continue;
				case 101u:
					num = (int)(num2 * 1472847145) ^ -416812814;
					continue;
				case 100u:
					num = (int)(num2 * 438688494) ^ -1232347498;
					continue;
				case 99u:
					num = (int)(num2 * 639700849) ^ -2057739595;
					continue;
				case 98u:
					((ButtonBase)RadioButton1).set_Text("32 * 32");
					num = ((int)num2 * -1434848342) ^ -784970139;
					continue;
				case 97u:
					lblinfo = new Label();
					cmdcolor = new Button();
					num = ((int)num2 * -1035496376) ^ 0x6B0D3754;
					continue;
				case 96u:
					icontainer_0 = new Container();
					num = ((int)num2 * -1988805560) ^ -762894348;
					continue;
				case 95u:
					num = ((int)num2 * -953027628) ^ 0x2D116464;
					continue;
				case 94u:
					((ButtonBase)cmdconvers).set_UseVisualStyleBackColor(true);
					num = (int)(num2 * 1667384471) ^ -1909310388;
					continue;
				case 93u:
					((Control)this).get_Controls().Add((Control)(object)cmdopen);
					num = ((int)num2 * -1815534242) ^ -1119405059;
					continue;
				case 92u:
					((Control)cmdconvers).set_Location(new Point(178, 210));
					((Control)cmdconvers).set_Name("cmdconvers");
					num = (int)(num2 * 70361978) ^ -1642641749;
					continue;
				case 91u:
					((ButtonBase)RadioButton2).set_AutoSize(true);
					num = ((int)num2 * -595797172) ^ 0x631EF30C;
					continue;
				case 90u:
					((ButtonBase)cmdconvers).set_Text("Convertir");
					num = ((int)num2 * -1987076910) ^ 0x7E7BE7A1;
					continue;
				case 89u:
					num = (int)(num2 * 2040976380) ^ -1920830286;
					continue;
				case 88u:
					num = (int)(num2 * 352967544) ^ -1591260947;
					continue;
				case 87u:
					num = (int)(num2 * 470625211) ^ -6801644;
					continue;
				case 86u:
					num = ((int)num2 * -1006235873) ^ 0xDC63C77;
					continue;
				case 85u:
					((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
					num = ((int)num2 * -1202961146) ^ 0x58D062E7;
					continue;
				case 84u:
					RadioButton2 = new RadioButton();
					num = (int)((num2 * 1619293034) ^ 0x28C4D058);
					continue;
				case 83u:
					num = (int)((num2 * 1768207673) ^ 0xA4FF086);
					continue;
				case 82u:
					((Control)GroupBox1).PerformLayout();
					num = ((int)num2 * -826812581) ^ -1052920355;
					continue;
				case 81u:
					((Control)GroupBox1).set_Location(new Point(178, 12));
					num = (int)(num2 * 693729033) ^ -1615140152;
					continue;
				case 80u:
					((ButtonBase)RadioButton3).set_Text("96 * 96");
					num = (int)(num2 * 348898528) ^ -567849096;
					continue;
				case 79u:
					RadioButton1 = new RadioButton();
					ToolTip_0 = new ToolTip(icontainer_0);
					NotifyIcon_0 = new NotifyIcon(icontainer_0);
					num = ((int)num2 * -1883789140) ^ 0x1DAA3689;
					continue;
				case 78u:
					RadioButton2.set_TabStop(true);
					num = (int)((num2 * 653360142) ^ 0x3061814D);
					continue;
				case 77u:
					num = ((int)num2 * -1943680529) ^ -2129172684;
					continue;
				case 76u:
					((Form)this).set_Text("Creer Icône");
					num = (int)((num2 * 1605265581) ^ 0x5E8374D7);
					continue;
				case 75u:
					NotifyIcon_0.set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
					num = ((int)num2 * -2061080602) ^ -1453664235;
					continue;
				case 74u:
					((Form)this).set_FormBorderStyle((FormBorderStyle)2);
					num = (int)((num2 * 2100968556) ^ 0x79A53342);
					continue;
				case 73u:
					((Form)this).set_ClientSize(new Size(265, 245));
					((Control)this).get_Controls().Add((Control)(object)cmdcolor);
					num = ((int)num2 * -1556589747) ^ -1481032703;
					continue;
				case 72u:
					((Form)this).set_ShowInTaskbar(false);
					num = ((int)num2 * -877339023) ^ 0x7D281E00;
					continue;
				case 71u:
					ToolTip_0.SetToolTip((Control)(object)GroupBox1, "Choisissez votre taille d'icône avant d'ouvrir une image");
					num = (int)((num2 * 1140191479) ^ 0x4202578F);
					continue;
				case 70u:
					((Control)this).PerformLayout();
					num = ((int)num2 * -1431686640) ^ -1294067250;
					continue;
				case 69u:
					GroupBox1 = new GroupBox();
					num = (int)(num2 * 1199807208) ^ -1870458438;
					continue;
				case 68u:
					Pic.set_TabStop(false);
					((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton3);
					num = ((int)num2 * -428621342) ^ 0x4147EA37;
					continue;
				case 67u:
					((Control)cmdopen).set_Location(new Point(10, 210));
					num = ((int)num2 * -1032785434) ^ -977248860;
					continue;
				case 66u:
					((Control)GroupBox1).set_Size(new Size(75, 133));
					num = ((int)num2 * -1134367082) ^ -434375563;
					continue;
				case 65u:
					((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton1);
					num = (int)(num2 * 2028381679) ^ -313445403;
					continue;
				case 64u:
					num = (int)((num2 * 1467008020) ^ 0x530F0599);
					continue;
				case 63u:
					num = ((int)num2 * -587412621) ^ -1044021228;
					continue;
				case 62u:
					((Form)this).set_TopMost(true);
					num = ((int)num2 * -819537903) ^ -1241148922;
					continue;
				case 61u:
					((Control)this).get_Controls().Add((Control)(object)lblinfo);
					num = ((int)num2 * -1462598818) ^ -1799256259;
					continue;
				case 60u:
					((Control)RadioButton3).set_Location(new Point(6, 93));
					num = ((int)num2 * -880630847) ^ 0x3F6F2588;
					continue;
				case 59u:
					((Control)cmdcolor).set_Size(new Size(75, 23));
					num = (int)((num2 * 232778167) ^ 0x2D743FDA);
					continue;
				case 58u:
					num = (int)((num2 * 2050004091) ^ 0x759554FB);
					continue;
				case 57u:
					((ButtonBase)cmdopen).set_UseVisualStyleBackColor(true);
					num = (int)((num2 * 1487065493) ^ 0x187F5ED7);
					continue;
				case 56u:
					((Control)GroupBox1).set_TabIndex(3);
					num = (int)(num2 * 2106660354) ^ -609441553;
					continue;
				case 55u:
					((Control)cmdcolor).set_Name("cmdcolor");
					num = ((int)num2 * -572499344) ^ -1869335561;
					continue;
				case 54u:
					num = ((int)num2 * -1714777749) ^ 0x4BD36DE2;
					continue;
				case 53u:
					num = (int)((num2 * 1224729219) ^ 0x4163D747);
					continue;
				case 52u:
					((Control)this).get_Controls().Add((Control)(object)GroupBox1);
					num = (int)(num2 * 260985289) ^ -272875902;
					continue;
				case 51u:
					num = (int)((num2 * 1068970291) ^ 0x24194752);
					continue;
				case 50u:
					((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
					((ButtonBase)RadioButton1).set_AutoSize(true);
					((Control)RadioButton1).set_Location(new Point(6, 19));
					num = (int)(num2 * 467306179) ^ -561255695;
					continue;
				case 49u:
					((Control)RadioButton3).set_Size(new Size(59, 17));
					num = (int)(num2 * 1458290809) ^ -1111818690;
					continue;
				case 48u:
					num = ((int)num2 * -1740557488) ^ 0x700E16AA;
					continue;
				case 47u:
					((Control)GroupBox1).SuspendLayout();
					((Control)this).SuspendLayout();
					num = ((int)num2 * -562181329) ^ -1479077400;
					continue;
				case 45u:
					RadioButton3 = new RadioButton();
					num = ((int)num2 * -210395368) ^ 0x54726BA4;
					continue;
				case 44u:
					lblinfo.set_AutoSize(true);
					((Control)lblinfo).set_Location(new Point(32, 164));
					num = (int)((num2 * 1396518758) ^ 0x488CDA7A);
					continue;
				case 43u:
					((Control)this).ResumeLayout(false);
					num = (int)((num2 * 456892510) ^ 0x5315A7DA);
					continue;
				case 42u:
					((Form)this).set_MaximizeBox(false);
					num = (int)((num2 * 2096350398) ^ 0x18562367);
					continue;
				case 41u:
					((Control)Pic).set_Location(new Point(12, 12));
					num = ((int)num2 * -1302296541) ^ -396897041;
					continue;
				case 40u:
					((ButtonBase)cmdcolor).set_UseVisualStyleBackColor(true);
					num = (int)(num2 * 319598409) ^ -689999966;
					continue;
				case 39u:
					NotifyIcon_0.set_Text("Creer icône");
					num = ((int)num2 * -42531374) ^ -787268252;
					continue;
				case 38u:
					((Control)this).get_Controls().Add((Control)(object)Pic);
					num = (int)(num2 * 1892509856) ^ -1348097670;
					continue;
				case 37u:
					num = ((int)num2 * -983705113) ^ -1287128283;
					continue;
				case 36u:
					cmdconvers = new Button();
					num = (int)(num2 * 1815136129) ^ -101641323;
					continue;
				case 35u:
					num = ((int)num2 * -396616445) ^ 0x128E76CD;
					continue;
				case 34u:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					num = ((int)num2 * -1877538418) ^ 0x35BD156A;
					continue;
				case 33u:
					((Control)lblinfo).set_Name("lblinfo");
					num = ((int)num2 * -799974440) ^ -1219022125;
					continue;
				case 32u:
					num = ((int)num2 * -778288828) ^ -1202873235;
					continue;
				case 31u:
					((Control)GroupBox1).ResumeLayout(false);
					num = ((int)num2 * -1755805067) ^ -1412265998;
					continue;
				case 30u:
					((Control)GroupBox1).set_Name("GroupBox1");
					num = (int)((num2 * 424546034) ^ 0x3FE00F58);
					continue;
				case 29u:
					((Control)RadioButton2).set_Location(new Point(6, 55));
					num = (int)(num2 * 743301274) ^ -665213128;
					continue;
				case 28u:
					((ISupportInitialize)Pic).EndInit();
					num = ((int)num2 * -1165587853) ^ -1864168784;
					continue;
				case 27u:
					cmdopen = new Button();
					num = (int)((num2 * 2080775797) ^ 0x6BB1B61);
					continue;
				case 26u:
					((Control)this).set_Name("Form1");
					num = (int)((num2 * 602962222) ^ 0x669AA9AD);
					continue;
				case 25u:
					((Control)cmdopen).set_TabIndex(0);
					((ButtonBase)cmdopen).set_Text("Ouvrir");
					num = (int)(num2 * 2024457639) ^ -386577865;
					continue;
				case 23u:
					((Control)RadioButton1).set_TabIndex(0);
					num = (int)((num2 * 1622984686) ^ 0x7C01CB43);
					continue;
				case 22u:
					num = (int)((num2 * 504274208) ^ 0x8DC3D11);
					continue;
				case 21u:
					num = (int)(num2 * 1166380150) ^ -1730471855;
					continue;
				case 20u:
					num = (int)(num2 * 2048497752) ^ -1403597574;
					continue;
				case 19u:
					num = (int)(num2 * 1816503454) ^ -1132662175;
					continue;
				case 18u:
					((Control)GroupBox1).get_Controls().Add((Control)(object)RadioButton2);
					num = ((int)num2 * -705400074) ^ 0x6F25592A;
					continue;
				case 17u:
					num = (int)(num2 * 1551478868) ^ -1902186530;
					continue;
				case 16u:
					ToolTip_0.SetToolTip((Control)(object)cmdopen, "Choisissez votre image à transformer en icône");
					num = ((int)num2 * -754123621) ^ 0x40B0FB69;
					continue;
				case 15u:
					RadioButton2.set_Checked(true);
					num = ((int)num2 * -99768911) ^ 0x3F0CD18;
					continue;
				case 14u:
					GroupBox1.set_TabStop(false);
					num = ((int)num2 * -1140202694) ^ 0x64780692;
					continue;
				case 13u:
					num = (int)(num2 * 481319018) ^ -1840719145;
					continue;
				case 12u:
					((Control)cmdconvers).set_TabIndex(1);
					num = (int)((num2 * 961668) ^ 0x254C2480);
					continue;
				case 11u:
					((Control)this).get_Controls().Add((Control)(object)cmdconvers);
					num = (int)((num2 * 1901375282) ^ 0x40B17447);
					continue;
				case 10u:
					((ButtonBase)RadioButton3).set_AutoSize(true);
					num = ((int)num2 * -71225865) ^ 0x6106390;
					continue;
				case 9u:
					Pic.set_TabIndex(2);
					num = ((int)num2 * -822838616) ^ 0x30A7146B;
					continue;
				case 8u:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num = (int)((num2 * 1954950354) ^ 0x2F06FA69);
					continue;
				case 7u:
					num = ((int)num2 * -1474335454) ^ 0xF9F33E3;
					continue;
				case 6u:
					((Control)lblinfo).set_Size(new Size(183, 26));
					((Control)lblinfo).set_TabIndex(4);
					lblinfo.set_Text("Choisissez votre taille d'icône et votre\r\n    couleur avant d'ouvir une image");
					((Control)cmdcolor).set_Location(new Point(95, 210));
					num = (int)((num2 * 1779291946) ^ 0x7B8E2DFB);
					continue;
				case 5u:
					((Control)RadioButton3).set_TabIndex(2);
					num = ((int)num2 * -938997946) ^ 0x72AA0035;
					continue;
				case 4u:
					num = (int)((num2 * 58164429) ^ 0x3A605767);
					continue;
				case 3u:
					num = (int)(num2 * 1623952493) ^ -1400955040;
					continue;
				case 2u:
					((Form)this).set_Opacity(0.0);
					num = (int)(num2 * 2000315503) ^ -1218199631;
					continue;
				case 1u:
					((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
					num = (int)(num2 * 343288825) ^ -641423765;
					continue;
				case 0u:
					ToolTip_0.SetToolTip((Control)(object)cmdconvers, "Convertir l'image en icône");
					num = ((int)num2 * -649687832) ^ 0x2607EAC3;
					continue;
				default:
					return;
				case 46u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}
}
