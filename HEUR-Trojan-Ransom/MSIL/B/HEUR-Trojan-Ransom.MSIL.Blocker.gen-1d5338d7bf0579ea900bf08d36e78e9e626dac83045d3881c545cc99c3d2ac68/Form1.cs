using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

public class Form1 : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class0
	{
		public static readonly Class0 class0_0 = new Class0();

		public static ThreadStart threadStart_0;

		internal void method_0()
		{
			byte[] array = BitConverter.GetBytes(195);
			MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
			while (true)
			{
				int num = 1827008876;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B19978Eu) % 6u)
					{
					case 4u:
						array = mD5CryptoServiceProvider.TransformFinalBlock(array, 0, array.Length);
						num = (int)(num2 * 1542669883) ^ -330883006;
						continue;
					case 3u:
						num = 722125569;
						continue;
					case 2u:
						mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
						num = (int)((num2 * 1973360971) ^ 0x15B662D8);
						continue;
					case 0u:
						num = (int)((num2 * 702714652) ^ 0x43EE10CD);
						continue;
					}
					break;
				}
			}
		}
	}

	private bool bool_0 = false;

	private IContainer icontainer_0 = null;

	private Button button1;

	private CheckBox checkBox1;

	private GroupBox groupBox1;

	private PictureBox pictureBox1;

	private Label label1;

	private TextBox textBox1;

	private CheckBox checkBox2;

	public Form1()
	{
		InitializeComponent();
		method_0(4.5);
	}

	private void method_0(double double_0)
	{
		int num = (int)(double_0 * 1000.0 / 500.0);
		ThreadStart start = delegate
		{
			byte[] array = BitConverter.GetBytes(195);
			MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
			while (true)
			{
				int num5 = 1827008876;
				while (true)
				{
					uint num6;
					switch ((num6 = (uint)num5 ^ 0x5B19978Eu) % 6u)
					{
					case 4u:
						array = mD5CryptoServiceProvider.TransformFinalBlock(array, 0, array.Length);
						num5 = (int)(num6 * 1542669883) ^ -330883006;
						continue;
					case 3u:
						num5 = 722125569;
						continue;
					case 2u:
						mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
						num5 = (int)((num6 * 1973360971) ^ 0x15B662D8);
						continue;
					case 0u:
						num5 = (int)((num6 * 702714652) ^ 0x43EE10CD);
						continue;
					}
					break;
				}
			}
		};
		Thread thread = default(Thread);
		while (true)
		{
			int num2 = 1309542779;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3D706B36u) % 11u)
				{
				case 10u:
					num2 = 1353730197;
					continue;
				case 8u:
					thread.Start();
					num2 = (int)((num3 * 262071843) ^ 0xB084B4B);
					continue;
				case 7u:
					num2 = (int)((num3 * 2008884092) ^ 0x7FA78DFB);
					continue;
				case 6u:
					Thread.Sleep(500);
					thread.Abort();
					num2 = (int)((num3 * 769710275) ^ 0x414E2DE7);
					continue;
				case 5u:
				{
					int num4;
					if (num-- <= 0)
					{
						num2 = 958985117;
						num4 = 958985117;
					}
					else
					{
						num2 = 431523796;
						num4 = 431523796;
					}
					continue;
				}
				case 3u:
					num2 = (int)(num3 * 692716460) ^ -1863710085;
					continue;
				case 2u:
					num2 = ((int)num3 * -399651399) ^ -98572701;
					continue;
				case 1u:
					num2 = ((int)num3 * -833548461) ^ -1387831736;
					continue;
				case 0u:
					thread = new Thread(start);
					num2 = ((int)num3 * -810143089) ^ -331004156;
					continue;
				default:
					return;
				case 4u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void method_1()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected I4, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected I4, but got Unknown
		//IL_010a: Incompatible stack heights: 0 vs 1
		//IL_0111: Incompatible stack heights: 0 vs 1
		bool flag = (object)GClass0.type_0 == null;
		while (true)
		{
			int num = 1928217001;
			while (true)
			{
				int num4;
				uint num2;
				switch ((num2 = (uint)num ^ 0x67BBFA0Au) % 4u)
				{
				case 3u:
				{
					int num5;
					if (!flag)
					{
						num4 = 1276783747;
						num5 = 1276783747;
					}
					else
					{
						num4 = 1876796282;
						num5 = 1876796282;
					}
					goto IL_0024;
				}
				case 2u:
					break;
				default:
					try
					{
						Message val = method_2(123);
						while (true)
						{
							int num3 = 1694241745;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x67BBFA0Au) % 5u)
								{
								case 3u:
									num3 = (int)(num2 * 1715580098) ^ -747359885;
									continue;
								case 2u:
									num3 = ((int)num2 * -1100485556) ^ 0x567C0362;
									continue;
								case 1u:
									((Message)(ref val)).GetLParam(GClass0.type_0);
									Environment.Exit(0);
									num3 = ((int)num2 * -979138488) ^ -1854781176;
									continue;
								default:
									return;
								case 0u:
									break;
								case 4u:
									return;
								}
								break;
							}
						}
					}
					catch
					{
						while (true)
						{
							_ = 1502210625;
							while (true)
							{
								_003F val2 = /*Error near IL_00d6: Stack underflow*/^ 0x67BBFA0A;
								num2 = (uint)(int)val2;
								switch (val2 % 3)
								{
								default:
									return;
								case 2:
									((Control)textBox1).set_Text("1");
									_ = ((int)num2 * -1478714087) ^ -162726832;
									continue;
								case 0:
									break;
								case 1:
									return;
								}
								break;
							}
						}
					}
				case 0u:
					return;
				}
				break;
				IL_0024:
				num = num4 ^ ((int)num2 * -2101479620);
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (sender != null)
		{
			goto IL_0039;
		}
		int num = 0;
		goto IL_0080;
		IL_0080:
		bool flag = (byte)num != 0;
		int num2 = -608657165;
		goto IL_0053;
		IL_0039:
		num2 = -761877561;
		goto IL_0053;
		IL_0053:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xD00A6C0Cu) % 6u)
			{
			case 4u:
				num2 = (int)(num3 * 1575325909) ^ -1227065869;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 804728941;
					num5 = 804728941;
				}
				else
				{
					num4 = 217716280;
					num5 = 217716280;
				}
				num2 = num4 ^ (int)(num3 * 1168602005);
				continue;
			}
			case 2u:
				break;
			case 0u:
				method_1();
				num2 = (int)(num3 * 863092368) ^ -808027764;
				continue;
			default:
				return;
			case 5u:
				goto IL_007c;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0039;
		IL_007c:
		num = ((e != null) ? 1 : 0);
		goto IL_0080;
	}

	void Control.OnControlAdded(ControlEventArgs e)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected I4, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected I4, but got Unknown
		//IL_00ec: Incompatible stack heights: 0 vs 1
		//IL_00f3: Incompatible stack heights: 0 vs 1
		bool flag = default(bool);
		while (true)
		{
			int num = -142078138;
			while (true)
			{
				int num4;
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF38F2E3u) % 4u)
				{
				case 3u:
					if (flag)
					{
						num = ((int)num2 * -239322430) ^ 0x3539FB31;
						continue;
					}
					goto IL_00f7;
				case 1u:
					flag = !bool_0;
					num = (int)((num2 * 445229627) ^ 0x371AFFD7);
					continue;
				case 2u:
					break;
				default:
					{
						bool_0 = true;
						try
						{
							while (true)
							{
								IL_00b6:
								int num3 = -1050784890;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0xBF38F2E3u) % 5u)
									{
									case 4u:
										GClass0.smethod_1();
										num3 = (int)((num2 * 322546850) ^ 0xF55F723);
										continue;
									case 1u:
										num3 = ((int)num2 * -632976996) ^ -532783619;
										continue;
									case 0u:
										num3 = ((int)num2 * -1765945755) ^ 0x1343451F;
										continue;
									default:
										goto end_IL_0091;
									case 3u:
										break;
									case 2u:
										goto end_IL_0091;
									}
									goto IL_00b6;
									continue;
									end_IL_0091:
									break;
								}
								break;
							}
						}
						catch
						{
							while (true)
							{
								IL_00ee:
								_ = -1443820730;
								while (true)
								{
									_003F val = /*Error near IL_00c8: Stack underflow*/^ -1086786845;
									num2 = (uint)(int)val;
									switch (val % 3)
									{
									default:
										goto end_IL_00c2;
									case 1:
										_ = ((int)num2 * -993643293) ^ 0x5A3BAB7F;
										continue;
									case 0:
										break;
									case 2:
										goto end_IL_00c2;
									}
									goto IL_00ee;
									continue;
									end_IL_00c2:
									break;
								}
								break;
							}
						}
						goto IL_0120;
					}
					IL_0120:
					num4 = -1024744169;
					goto IL_0103;
					IL_00f7:
					((Control)this).OnControlAdded(e);
					num4 = -266635774;
					goto IL_0103;
					IL_0103:
					switch ((num2 = (uint)num4 ^ 0xBF38F2E3u) % 3u)
					{
					case 1u:
						break;
					default:
						return;
					case 2u:
						goto IL_0120;
					case 0u:
						return;
					}
					goto IL_00f7;
				}
				break;
			}
		}
	}

	private Message method_2(int int_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		Message val = default(Message);
		Random random = default(Random);
		Message result = default(Message);
		while (true)
		{
			int num = -1298011188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x937A9A4Eu) % 7u)
				{
				case 4u:
					val = default(Message);
					num = ((int)num2 * -1717536965) ^ 0x3B80E1B6;
					continue;
				case 3u:
					random = new Random(int_0);
					num = (int)(num2 * 1985057954) ^ -1224260038;
					continue;
				case 2u:
					((Message)(ref val)).set_Msg(random.Next(12, 4095));
					num = (int)(num2 * 1394397339) ^ -898595991;
					continue;
				case 1u:
					((Message)(ref val)).set_HWnd(new IntPtr(random.Next(10, 4095)));
					num = (int)(num2 * 1749860386) ^ -2083378746;
					continue;
				case 0u:
					((Message)(ref val)).set_LParam(new IntPtr(random.Next(222, 4095)));
					result = val;
					num = ((int)num2 * -2014385145) ^ -1768247729;
					continue;
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		pictureBox1.set_Image((Image)new Bitmap(1212, 1212));
		while (true)
		{
			int num = 2104710441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56A021C4u) % 3u)
				{
				case 1u:
					goto IL_001c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_001c:
				num = ((int)num2 * -1694535387) ^ -861809991;
			}
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_004d;
		}
		goto IL_0086;
		IL_004d:
		int num = -1755046805;
		goto IL_0052;
		IL_0052:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x98433030u) % 6u)
			{
			case 5u:
				icontainer_0.Dispose();
				num = (int)((num2 * 1547339762) ^ 0x3BF2F975);
				continue;
			case 2u:
				num = ((int)num2 * -1750366707) ^ -1037791449;
				continue;
			case 1u:
				((Form)this).Dispose(disposing);
				num = -1467285564;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_007b;
			case 4u:
				return;
			}
			break;
			IL_007b:
			if (icontainer_0 != null)
			{
				num = -1039226738;
				num3 = -1039226738;
				continue;
			}
			goto IL_0086;
		}
		goto IL_004d;
		IL_0086:
		num = -412054745;
		num3 = -412054745;
		goto IL_0052;
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected O, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected O, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		button1 = new Button();
		while (true)
		{
			int num = 1860061042;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31BA3200u) % 85u)
				{
				case 84u:
					((Control)button1).add_Click((EventHandler)button1_Click);
					num = (int)((num2 * 362145823) ^ 0x5AB7CB68);
					continue;
				case 83u:
					num = ((int)num2 * -527844607) ^ 0x3E8B5E8F;
					continue;
				case 82u:
					((Control)checkBox1).set_TabIndex(1);
					((Control)checkBox1).set_Text("Slow Motion");
					num = ((int)num2 * -170475359) ^ -156805619;
					continue;
				case 81u:
					((Control)button1).set_Name("button1");
					num = ((int)num2 * -223145907) ^ -2116871144;
					continue;
				case 80u:
					((Control)groupBox1).PerformLayout();
					((ISupportInitialize)pictureBox1).EndInit();
					num = (int)((num2 * 1311570424) ^ 0x5D8BCB99);
					continue;
				case 79u:
					((Control)checkBox1).set_AutoSize(true);
					num = (int)(num2 * 137002056) ^ -1957516215;
					continue;
				case 78u:
					num = (int)((num2 * 2061557071) ^ 0x32D7C17F);
					continue;
				case 77u:
					num = (int)(num2 * 523818822) ^ -909904970;
					continue;
				case 76u:
					((Control)button1).set_Size(new Size(271, 38));
					num = (int)((num2 * 1415610663) ^ 0x1D6C0ED1);
					continue;
				case 75u:
					pictureBox1.set_BorderStyle((BorderStyle)1);
					num = (int)((num2 * 1114447982) ^ 0x1A77042A);
					continue;
				case 74u:
					((Control)textBox1).set_Location(new Point(65, 25));
					num = ((int)num2 * -1488012729) ^ -1511910858;
					continue;
				case 73u:
					((Form)this).add_Load((EventHandler)Form1_Load);
					num = (int)((num2 * 941929745) ^ 0x618DB40);
					continue;
				case 72u:
					((Control)checkBox2).set_TabIndex(5);
					num = ((int)num2 * -1703792236) ^ 0x6F304ADC;
					continue;
				case 71u:
					((Control)checkBox1).set_Name("checkBox1");
					num = ((int)num2 * -617705242) ^ 0x11907CEA;
					continue;
				case 70u:
					num = (int)(num2 * 973004217) ^ -1863883877;
					continue;
				case 69u:
					checkBox2 = new CheckBox();
					num = (int)(num2 * 1020316692) ^ -154626637;
					continue;
				case 68u:
					((Control)label1).set_TabIndex(3);
					((Control)label1).set_Text("Status:");
					num = ((int)num2 * -655761266) ^ -200995556;
					continue;
				case 67u:
					((Control)pictureBox1).set_Name("pictureBox1");
					num = (int)(num2 * 56863970) ^ -1184903493;
					continue;
				case 66u:
					((Control)this).get_Controls().Add((Control)(object)groupBox1);
					((Control)this).get_Controls().Add((Control)(object)checkBox1);
					num = (int)(num2 * 804410562) ^ -1478188665;
					continue;
				case 65u:
					num = ((int)num2 * -1825856731) ^ 0x1CA887C4;
					continue;
				case 64u:
					num = ((int)num2 * -19235388) ^ -1407486509;
					continue;
				case 63u:
					num = ((int)num2 * -1425038205) ^ -1670473794;
					continue;
				case 62u:
					((Control)this).set_Text("ShTepler");
					num = ((int)num2 * -982314805) ^ -412316610;
					continue;
				case 61u:
					((Control)this).ResumeLayout(false);
					num = (int)(num2 * 814555411) ^ -1949866447;
					continue;
				case 60u:
					num = (int)((num2 * 214912134) ^ 0x7AD34AA1);
					continue;
				case 59u:
					((Control)label1).set_AutoSize(true);
					num = ((int)num2 * -531598916) ^ -232502610;
					continue;
				case 58u:
					((ISupportInitialize)pictureBox1).BeginInit();
					num = (int)((num2 * 1812886808) ^ 0x1F26456D);
					continue;
				case 57u:
					((Control)checkBox2).set_Name("checkBox2");
					num = ((int)num2 * -248251794) ^ 0x38726705;
					continue;
				case 56u:
					((Control)pictureBox1).set_Size(new Size(580, 136));
					num = (int)((num2 * 346442306) ^ 0x4E83679D);
					continue;
				case 55u:
					num = (int)(num2 * 1360908221) ^ -180642770;
					continue;
				case 54u:
					num = (int)((num2 * 1963149865) ^ 0x1670795A);
					continue;
				case 53u:
					((Control)button1).set_TabIndex(0);
					((Control)button1).set_Text("Run Simulation");
					num = (int)(num2 * 2108998307) ^ -428148634;
					continue;
				case 52u:
					((Control)this).SuspendLayout();
					num = (int)(num2 * 1747082430) ^ -730937495;
					continue;
				case 51u:
					((Control)groupBox1).set_Name("groupBox1");
					num = ((int)num2 * -1373735451) ^ 0x210AECAD;
					continue;
				case 50u:
					((Control)label1).set_Location(new Point(19, 28));
					num = ((int)num2 * -345672883) ^ 0x10AF2356;
					continue;
				case 49u:
					num = (int)((num2 * 349563316) ^ 0x4AD71FFC);
					continue;
				case 48u:
					num = ((int)num2 * -837793510) ^ 0x303F81D;
					continue;
				case 47u:
					pictureBox1.set_TabStop(false);
					num = ((int)num2 * -936436308) ^ -459679286;
					continue;
				case 46u:
					pictureBox1.set_TabIndex(5);
					num = ((int)num2 * -78071696) ^ -1749783103;
					continue;
				case 45u:
					((ButtonBase)button1).set_UseVisualStyleBackColor(true);
					num = ((int)num2 * -1303089110) ^ 0x597EFD37;
					continue;
				case 44u:
					num = ((int)num2 * -114756040) ^ 0x42D5E0C5;
					continue;
				case 43u:
					((Control)label1).set_Name("label1");
					num = (int)(num2 * 1854599651) ^ -533480264;
					continue;
				case 42u:
					num = ((int)num2 * -721148025) ^ 0x13E80B03;
					continue;
				case 41u:
					((Control)checkBox2).set_Size(new Size(65, 17));
					num = ((int)num2 * -2065390765) ^ 0xA42089F;
					continue;
				case 40u:
					((Control)this).get_Controls().Add((Control)(object)button1);
					num = (int)(num2 * 1719925328) ^ -1535429125;
					continue;
				case 39u:
					((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
					num = ((int)num2 * -1437643715) ^ -999050987;
					continue;
				case 38u:
					((Control)groupBox1).get_Controls().Add((Control)(object)label1);
					num = ((int)num2 * -1528173555) ^ -813198953;
					continue;
				case 37u:
					((Control)checkBox2).set_Text("Verbose");
					num = ((int)num2 * -1015305953) ^ 0x33575E00;
					continue;
				case 36u:
					groupBox1.set_TabStop(false);
					num = (int)(num2 * 1594270546) ^ -1311720553;
					continue;
				case 35u:
					num = (int)(num2 * 950653992) ^ -1368573798;
					continue;
				case 34u:
					((Control)groupBox1).set_Location(new Point(12, 56));
					num = (int)((num2 * 1207601466) ^ 0x1778486);
					continue;
				case 33u:
					((Control)textBox1).set_Name("textBox1");
					num = (int)(num2 * 1611055302) ^ -1310018766;
					continue;
				case 32u:
					num = (int)(num2 * 1234715915) ^ -598280844;
					continue;
				case 31u:
					((Control)checkBox2).set_AutoSize(true);
					((Control)checkBox2).set_Location(new Point(385, 33));
					num = (int)((num2 * 566027260) ^ 0x19512BD7);
					continue;
				case 30u:
					((Control)this).PerformLayout();
					num = (int)((num2 * 264859866) ^ 0x3FEDD2F7);
					continue;
				case 29u:
					textBox1 = new TextBox();
					num = ((int)num2 * -616909537) ^ 0x328F8FCC;
					continue;
				case 28u:
					((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
					num = (int)(num2 * 2110852369) ^ -1089159306;
					continue;
				case 27u:
					((Control)pictureBox1).set_Location(new Point(22, 57));
					num = (int)((num2 * 1891815128) ^ 0x35A43092);
					continue;
				case 26u:
					((Control)groupBox1).ResumeLayout(false);
					num = (int)((num2 * 1710443316) ^ 0x1A0B387E);
					continue;
				case 25u:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					num = (int)((num2 * 2090450136) ^ 0x7D1B286E);
					continue;
				case 24u:
					((Control)checkBox1).set_Size(new Size(84, 17));
					num = (int)(num2 * 344447887) ^ -285937561;
					continue;
				case 23u:
					((Control)textBox1).set_TabIndex(4);
					num = (int)((num2 * 2110647324) ^ 0x1DD5CE4E);
					continue;
				case 22u:
					((Control)groupBox1).get_Controls().Add((Control)(object)pictureBox1);
					num = (int)((num2 * 1408808338) ^ 0x7AED0548);
					continue;
				case 21u:
					((Control)groupBox1).SuspendLayout();
					num = (int)((num2 * 2052722960) ^ 0x54BC5665);
					continue;
				case 20u:
					((Control)this).set_Name("Form1");
					num = ((int)num2 * -52994469) ^ -139610190;
					continue;
				case 19u:
					((Control)checkBox1).set_Location(new Point(299, 33));
					num = (int)(num2 * 1895035704) ^ -791381927;
					continue;
				case 18u:
					((Form)this).set_ClientSize(new Size(651, 274));
					((Control)this).get_Controls().Add((Control)(object)checkBox2);
					num = (int)((num2 * 1567167612) ^ 0x1FB6731);
					continue;
				case 17u:
					((Control)groupBox1).get_Controls().Add((Control)(object)textBox1);
					num = (int)((num2 * 1025327864) ^ 0x2FFFD298);
					continue;
				case 16u:
					num = ((int)num2 * -1209540143) ^ 0x6172585;
					continue;
				case 15u:
					((TextBoxBase)textBox1).set_ReadOnly(true);
					num = ((int)num2 * -1949982497) ^ 0x79689183;
					continue;
				case 13u:
					num = ((int)num2 * -1626706761) ^ -923038870;
					continue;
				case 12u:
					num = (int)((num2 * 1845672946) ^ 0x5389CAE9);
					continue;
				case 11u:
					((Control)groupBox1).set_Size(new Size(627, 206));
					((Control)groupBox1).set_TabIndex(2);
					num = (int)(num2 * 1346869670) ^ -370759184;
					continue;
				case 10u:
					((Control)label1).set_Size(new Size(40, 13));
					num = ((int)num2 * -1782531895) ^ 0x7565A0D6;
					continue;
				case 9u:
					num = ((int)num2 * -118002257) ^ 0x57789B54;
					continue;
				case 8u:
					((Control)textBox1).set_Size(new Size(537, 20));
					num = ((int)num2 * -1312350285) ^ -835336879;
					continue;
				case 7u:
					((Control)groupBox1).set_Text("Simulation Log");
					num = ((int)num2 * -712462319) ^ -269141924;
					continue;
				case 5u:
					((Control)button1).set_Location(new Point(12, 12));
					num = ((int)num2 * -1359150175) ^ 0x2E9F90E2;
					continue;
				case 4u:
					num = (int)((num2 * 1759586766) ^ 0x3DEA1474);
					continue;
				case 3u:
					groupBox1 = new GroupBox();
					pictureBox1 = new PictureBox();
					label1 = new Label();
					num = ((int)num2 * -654446511) ^ 0x70BCDD7A;
					continue;
				case 2u:
					num = ((int)num2 * -230044093) ^ -704874895;
					continue;
				case 1u:
					checkBox1 = new CheckBox();
					num = (int)(num2 * 1353084574) ^ -1531280944;
					continue;
				case 0u:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num = ((int)num2 * -1882087350) ^ 0x3B75F964;
					continue;
				default:
					return;
				case 14u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}
}
