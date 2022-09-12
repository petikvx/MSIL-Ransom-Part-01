using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ax2;
using Bb3;
using Cx7;
using Fz5;
using Hf5i;
using Lc3;
using Ln6;
using Mf0;
using Microsoft.VisualBasic.CompilerServices;
using Pc8;
using Rg9;
using Sk9;
using Wi0;
using c7R0;
using e3F;
using g0G;
using m8T;
using p6H;
using p9B1;
using t2P;

namespace Xs3;

[DesignerGenerated]
public class Pr5 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static f0Q f0Q_0/* Not supported: data(80 6F 49 D1 ED 38 13 4F 90 18 43 85 47 1A B7 B4 90 B4 69 AD F1 B1 09 5E 2A 1D 72 E9 2E 15 89 F6 1E 82 66 DB A4 00 39 CD 55 B5 09 BA E3 7C 68 EA E3 46 9C 05 0C A5 4F CD 65 E9 A7 D0 C5 29 20 7B 8E 4C 67 C4 B3 DA 10 8F 7B 9B 57 3B A7 4E 7A AC B3 86 05 E7 78 83 EA 77 32 97 76 B9 58 68 07 2C 94 8D 2C 96 14 A3 37 09 35 0C 89 6F 4D 13 25 16 6F F9 1C 3F 23 38 03 0A 61 EF 91 1B 63 56 37 12 94 2A A6 1A 22 E2 98 10 4F FB B2 6B F9 7A 29 1F 72 60 4A 5D 4C C7 09 5C 8A 21 35 24 12 1B A4 DE D4 76 DA 23 6B 0A F2 8B 60 0B EE 26 84 97 10 E5 C5 71 A8 02 0B D8 C5 CB 21 4A 8F 01 AD 74 FD 34 57 D3 95 82 9E 06 B3 67 6C BE FC 40 D7 E2 D6 F2 10 4E 5D 9F 72 A1 D2 FB AF 0F 02 21 7A F1 DC EB 0C BA CE B0 01 8C 47 BE BD 40 95 4C DB 85 F2 3D 72 9B EF 5E 16 5E C0 B4 00 99 D2 8F 04 91 EB 7A E0 10 33 1D 13 25 F0 83 07 9E E0 31 0C 85 1F 2A 1B C3 AD DE 02 7D D5 AD F8 1A AF 67 B9 B6 BA 2B 53 1B 6A CA 51 D5 2A 4C AA 6C 57 77 7C 8E A7 79 79 A8 74 40 E3 0D 77 63 3A 85 23 F8 75 89 C8 50 E3 B5 DD F0 1B 54 D7 45 99 60 33 95 26 5E 31 69 72 35 EC 11 42 7A 46 45 A2 07 8F CB B1 30 D6 20 A2 07 93 C6 B0 B5 5E 25 CF 2E A5 83 D8 E1 3D DB 53 B9 86 3F 9B B7 0D 68 6E 97 4E 13 C3 0C 93 68 88 13 F1 1E CA 6A B8 BB D5 C7 40 13 D3 C2 6C BF C9 B3 77 F6 A9 97 84 E9 F8 2A 57 19 67 4B 60 C3 9A 3C F9 C5 EF 1E 11 E8 00 C9 68 D2 77 F8 94 AB 2B 8D 48 10 93 9B BE F0 8D 08 25 9F 12 9F 54 8A 67 7C 78 96 C7 A5 CF AB A1 8E F6 DE 2E B0 72 FE 95 AB EC D8 02 50 2F FD 7D 09 37 E6 F8 70 D5 60 75 DD 6B F9 80 FC E2 84 BD 9C 6D 04 A4 DE C1 DC 94 25 0A 66 B1 7A 87 16 4C 79 19 BD 6E E7 B2 30 B7 95 69 50 44 77 7E 97 C7 68 1B 64 E1 2A 59 9E 46 5A 51 D2 66 6F AE F9 55 54 AD 06 E3 25 16 D4 E9 3C 4C 0E 74 71 97 1D A6 71 9D 48 5F 22 34 21 20 7A 77 14 96 DE C9 48) */;

	internal static byte[] byte_0;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gw2;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			char[] char_ = b4C0.char_0;
			int num = 5;
			EventHandler eventHandler;
			Label label;
			while (true)
			{
				eventHandler = w6B;
				label = _Label7;
				if (label == null)
				{
					switch (char_[100])
					{
					case '嬩':
						goto IL_0056;
					case '嬧':
						goto IL_005d;
					case '嬪':
						goto IL_006b;
					case '嬨':
					case '嬭':
					case '嬮':
						goto end_IL_003d;
					case '嬫':
						return;
					}
					continue;
				}
				num = 2;
				goto IL_0056;
				IL_005d:
				_Label7 = value;
				label = _Label7;
				goto IL_006b;
				IL_006b:
				if (label != null)
				{
					num = 1;
					break;
				}
				num = 4;
				return;
				IL_0056:
				((Control)label).remove_Click(eventHandler);
				goto IL_005d;
				continue;
				end_IL_003d:
				break;
			}
			((Control)label).add_Click(eventHandler);
		}
	}

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRcode")]
	internal virtual TextBox txtRcode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a6Z;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			Button obj = val;
			byte_0[62] = (byte)(byte_0[62] & byte_0[417] & 2);
			if (obj != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnModify
	{
		[CompilerGenerated]
		get
		{
			return _btnModify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			char[] char_ = b4C0.char_0;
			int num = 4;
			while (true)
			{
				EventHandler eventHandler = Mx7;
				Button val = _btnModify;
				if (val == null)
				{
					switch (char_[492] - char_[492])
					{
					case 1:
						goto IL_005c;
					case 0:
					case 6:
						goto IL_0063;
					case 5:
						goto IL_0076;
					case 3:
						return;
					}
					continue;
				}
				num = 1;
				goto IL_005c;
				IL_0063:
				_btnModify = value;
				val = _btnModify;
				if (val == null)
				{
					break;
				}
				num = 5;
				goto IL_0076;
				IL_0076:
				((Control)val).add_Click(eventHandler);
				b4C0.char_0[387] = (char)((b4C0.char_0[387] | b4C0.char_0[206]) & 'ç');
				return;
				IL_005c:
				((Control)val).remove_Click(eventHandler);
				goto IL_0063;
			}
			num = 3;
		}
	}

	[field: AccessedThroughProperty("txtCategory")]
	internal virtual TextBox txtCategory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRName")]
	internal virtual TextBox txtRName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s9W;
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Pr5()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Pp5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Jb1();
	}

	[DebuggerNonUserCode]
	protected override void n9L(bool Lq8)
	{
		char[] char_ = b4C0.char_0;
		try
		{
			int num = 6;
			while (true)
			{
				if (Lq8)
				{
					switch (char_[125])
					{
					default:
						continue;
					case 'שּׂ':
					case 'אָ':
						if (components == null)
						{
							break;
						}
						num = 3;
						goto case 'אַ';
					case 'אַ':
						components.Dispose();
						num = 7;
						return;
					case 'שׂ':
					case 'שּׁ':
						break;
					case 'אּ':
					case 'גּ':
						return;
					}
				}
				else
				{
					num = 0;
				}
				break;
			}
			num = 7;
		}
		finally
		{
			((Form)this).Dispose(Lq8);
		}
	}

	[DebuggerStepThrough]
	private void Jb1()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		char[] char_ = b4C0.char_0;
		int num = 19;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 81;
			while (true)
			{
				txtWeight = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 69;
				while (true)
				{
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					Label5 = new Label();
					num = 45;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						txtRcode = new TextBox();
						while (true)
						{
							num = 39;
							while (true)
							{
								btnDelete = new Button();
								btnModify = new Button();
								txtCategory = new TextBox();
								num = 11;
								while (true)
								{
									txtRName = new TextBox();
									txtAmount = new TextBox();
									Label2 = new Label();
									num = 13;
									while (true)
									{
										btnSave = new Button();
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										num = 67;
										while (true)
										{
											Label3.set_AutoSize(true);
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 53;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(320, 21));
												num = 30;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(123, 17));
													num = 76;
													while (true)
													{
														((Control)Label3).set_TabIndex(9);
														Label3.set_Text("Purchase Detail");
														num = 51;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 24;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 6;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 21));
																	num = 20;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 49;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(10);
																			Label6.set_Text("X");
																			num = 14;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 26;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					switch (char_[276])
																					{
																					case '液':
																						break;
																					case '润':
																						goto end_IL_000e;
																					case '淉':
																						goto end_IL_0190;
																					case '涬':
																						goto end_IL_01b4;
																					case '涞':
																						goto end_IL_01d6;
																					case '涰':
																						goto end_IL_01ff;
																					case '淋':
																						goto end_IL_022b;
																					case '淤':
																						goto end_IL_024c;
																					case '涶':
																						goto end_IL_026d;
																					case '淍':
																						goto end_IL_028f;
																					case '淛':
																						goto end_IL_02b8;
																					case '涥':
																						goto end_IL_02e4;
																					case '涣':
																						goto end_IL_0312;
																					case '涿':
																						goto end_IL_0333;
																					case '淒':
																						goto end_IL_0359;
																					case '淅':
																						goto end_IL_037f;
																					case '淝':
																						goto end_IL_0384;
																					case '淩':
																						goto end_IL_03a7;
																					default:
																						goto end_IL_03cd;
																					case '涭':
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(42, 21));
																						num = 42;
																						goto case '淂';
																					case '淂':
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 40;
																						goto case '淀';
																					case '淀':
																						((Control)Label7).set_TabIndex(9);
																						Label7.set_Text("Go To Main");
																						num = 73;
																						goto case '淡';
																					case '淡':
																						((Control)txtWeight).set_Location(new Point(537, 136));
																						((Control)txtWeight).set_Name("txtWeight");
																						num = 15;
																						goto case '涧';
																					case '涧':
																						((Control)txtWeight).set_Size(new Size(100, 20));
																						((Control)txtWeight).set_TabIndex(5);
																						num = 72;
																						goto case '淠';
																					case '淠':
																						Label10.set_AutoSize(true);
																						((Control)Label10).set_ForeColor(Color.White);
																						num = 56;
																						goto case '淐';
																					case '淐':
																						((Control)Label10).set_Location(new Point(478, 139));
																						((Control)Label10).set_Name("Label10");
																						num = 48;
																						goto case '淈';
																					case '淈':
																						((Control)Label10).set_Size(new Size(47, 13));
																						((Control)Label10).set_TabIndex(99);
																						num = 82;
																						goto case '淪';
																					case '淪':
																						Label10.set_Text("Weight :");
																						DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																						num = 5;
																						goto case '涝';
																					case '涝':
																						((Control)DataGridView1).set_Location(new Point(45, 239));
																						((Control)DataGridView1).set_Name("DataGridView1");
																						num = 1;
																						goto case '涙';
																					case '涙':
																						((Control)DataGridView1).set_Size(new Size(724, 199));
																						((Control)DataGridView1).set_TabIndex(11);
																						num = 23;
																						goto case '涯';
																					case '涯':
																						((Control)DateTimePicker1).set_Location(new Point(537, 64));
																						((Control)DateTimePicker1).set_Name("DateTimePicker1");
																						num = 41;
																						goto case '淁';
																					case '淁':
																						((Control)DateTimePicker1).set_Size(new Size(126, 20));
																						((Control)DateTimePicker1).set_TabIndex(3);
																						num = 57;
																						goto case '淑';
																					case '淑':
																						Label8.set_AutoSize(true);
																						((Control)Label8).set_ForeColor(Color.White);
																						num = 34;
																						goto case '涺';
																					case '涺':
																						((Control)Label8).set_Location(new Point(166, 130));
																						((Control)Label8).set_Name("Label8");
																						num = 37;
																						goto case '涽';
																					case '涽':
																						((Control)Label8).set_Size(new Size(55, 13));
																						((Control)Label8).set_TabIndex(94);
																						num = 3;
																						goto case '涛';
																					case '涛':
																						Label8.set_Text("Category :");
																						Label5.set_AutoSize(true);
																						num = 28;
																						goto case '涴';
																					case '涴':
																						((Control)Label5).set_ForeColor(Color.White);
																						((Control)Label5).set_Location(new Point(156, 101));
																						num = 46;
																						goto case '淆';
																					case '淆':
																						((Control)Label5).set_Name("Label5");
																						((Control)Label5).set_Size(new Size(66, 13));
																						num = 10;
																						goto case '涢';
																					case '涢':
																						((Control)Label5).set_TabIndex(93);
																						Label5.set_Text("Raw Name :");
																						num = 52;
																						goto case '淌';
																					case '淌':
																						Label4.set_AutoSize(true);
																						((Control)Label4).set_ForeColor(Color.White);
																						num = 70;
																						goto case '淞';
																					case '淞':
																						((Control)Label4).set_Location(new Point(466, 106));
																						((Control)Label4).set_Name("Label4");
																						num = 22;
																						goto case '涮';
																					case '涮':
																						((Control)Label4).set_Size(new Size(49, 13));
																						((Control)Label4).set_TabIndex(92);
																						num = 12;
																						goto case '涤';
																					case '涤':
																						Label4.set_Text("Amount :");
																						Label1.set_AutoSize(true);
																						num = 74;
																						goto case '淢';
																					case '淢':
																						((Control)Label1).set_ForeColor(Color.White);
																						((Control)Label1).set_Location(new Point(431, 67));
																						num = 63;
																						goto case '淗';
																					case '淗':
																						((Control)Label1).set_Name("Label1");
																						((Control)Label1).set_Size(new Size(84, 13));
																						num = 4;
																						goto case '涜';
																					case '涜':
																						((Control)Label1).set_TabIndex(91);
																						Label1.set_Text("Purchase Date :");
																						num = 33;
																						goto case '涹';
																					case '涹':
																						((Control)txtRcode).set_Location(new Point(245, 64));
																						((Control)txtRcode).set_Name("txtRcode");
																						num = 75;
																						goto case '淣';
																					case '淣':
																						((Control)txtRcode).set_Size(new Size(100, 20));
																						((Control)txtRcode).set_TabIndex(0);
																						num = 0;
																						goto case '涘';
																					case '涘':
																						((Control)btnDelete).set_Location(new Point(496, 202));
																						((Control)btnDelete).set_Name("btnDelete");
																						num = 27;
																						goto case '涳';
																					case '涳':
																						((Control)btnDelete).set_Size(new Size(75, 31));
																						((Control)btnDelete).set_TabIndex(8);
																						num = 35;
																						goto case '涻';
																					case '涻':
																						((ButtonBase)btnDelete).set_Text("DELETE");
																						((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																						num = 79;
																						goto case '淧';
																					case '淧':
																						((Control)btnModify).set_Location(new Point(378, 202));
																						((Control)btnModify).set_Name("btnModify");
																						num = 18;
																						goto case '涪';
																					case '涪':
																						((Control)btnModify).set_Size(new Size(75, 31));
																						((Control)btnModify).set_TabIndex(7);
																						num = 62;
																						goto case '淖';
																					case '淖':
																						((ButtonBase)btnModify).set_Text("MODIFY");
																						((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																						num = 55;
																						goto case '淏';
																					case '淏':
																						((Control)txtCategory).set_Location(new Point(243, 124));
																						((Control)txtCategory).set_Name("txtCategory");
																						num = 16;
																						goto case '涨';
																					case '涨':
																						((Control)txtCategory).set_Size(new Size(100, 20));
																						((Control)txtCategory).set_TabIndex(2);
																						num = 36;
																						goto case '涼';
																					case '涼':
																						((Control)txtRName).set_Location(new Point(243, 94));
																						((Control)txtRName).set_Name("txtRName");
																						num = 60;
																						goto case '淔';
																					case '淔':
																						((Control)txtRName).set_Size(new Size(100, 20));
																						((Control)txtRName).set_TabIndex(1);
																						num = 78;
																						goto case '淦';
																					case '淦':
																						((Control)txtAmount).set_Location(new Point(537, 99));
																						((Control)txtAmount).set_Name("txtAmount");
																						num = 7;
																						goto case '涟';
																					case '涟':
																						((Control)txtAmount).set_Size(new Size(100, 20));
																						((Control)txtAmount).set_TabIndex(4);
																						num = 71;
																						goto case '淟';
																					case '淟':
																						Label2.set_AutoSize(true);
																						((Control)Label2).set_ForeColor(Color.White);
																						num = 61;
																						goto case '淕';
																					case '淕':
																						((Control)Label2).set_Location(new Point(167, 67));
																						((Control)Label2).set_Name("Label2");
																						num = 31;
																						goto case '涷';
																					case '涷':
																						((Control)Label2).set_Size(new Size(63, 13));
																						((Control)Label2).set_TabIndex(90);
																						num = 80;
																						goto case '淨';
																					case '淨':
																						Label2.set_Text("Row Code :");
																						goto case '淥';
																					case '淥':
																						((Control)btnSave).set_Location(new Point(249, 202));
																						num = 29;
																						goto case '涵';
																					case '涵':
																						((Control)btnSave).set_Name("btnSave");
																						((Control)btnSave).set_Size(new Size(75, 31));
																						num = 68;
																						goto case '淜';
																					case '淜':
																						((Control)btnSave).set_TabIndex(6);
																						((ButtonBase)btnSave).set_Text("SAVE");
																						num = 25;
																						goto case '涱';
																					case '涱':
																						((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																						num = 8;
																						goto case '涠';
																					case '涠':
																						((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																						((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																						num = 50;
																						goto case '淊';
																					case '淊':
																						((Form)this).set_ClientSize(new Size(800, 450));
																						((Control)this).get_Controls().Add((Control)(object)txtWeight);
																						num = 32;
																						goto case '涸';
																					case '涸':
																						((Control)this).get_Controls().Add((Control)(object)Label10);
																						((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																						num = 47;
																						goto case '淇';
																					case '淇':
																						((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																						((Control)this).get_Controls().Add((Control)(object)Label8);
																						num = 59;
																						goto case '淓';
																					case '淓':
																						((Control)this).get_Controls().Add((Control)(object)Label5);
																						((Control)this).get_Controls().Add((Control)(object)Label4);
																						num = 43;
																						goto case '淃';
																					case '淃':
																						((Control)this).get_Controls().Add((Control)(object)Label1);
																						((Control)this).get_Controls().Add((Control)(object)txtRcode);
																						num = 54;
																						goto case '淎';
																					case '淎':
																						((Control)this).get_Controls().Add((Control)(object)btnDelete);
																						((Control)this).get_Controls().Add((Control)(object)btnModify);
																						goto case '淙';
																					case '淙':
																						num = 44;
																						goto case '淄';
																					case '淄':
																						((Control)this).get_Controls().Add((Control)(object)txtCategory);
																						((Control)this).get_Controls().Add((Control)(object)txtRName);
																						num = 9;
																						goto case '涡';
																					case '涡':
																						((Control)this).get_Controls().Add((Control)(object)txtAmount);
																						((Control)this).get_Controls().Add((Control)(object)Label2);
																						num = 2;
																						goto case '涚';
																					case '涚':
																						((Control)this).get_Controls().Add((Control)(object)btnSave);
																						((Control)this).get_Controls().Add((Control)(object)Label6);
																						num = 64;
																						goto case '淘';
																					case '淘':
																						((Control)this).get_Controls().Add((Control)(object)Label7);
																						((Control)this).get_Controls().Add((Control)(object)Label3);
																						num = 17;
																						goto case '涩';
																					case '涩':
																						((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																						((Control)this).set_Name("frmPurchaseDetail");
																						((Form)this).set_StartPosition((FormStartPosition)1);
																						num = 66;
																						goto case '淚';
																					case '淚':
																						((Form)this).set_Text("frmPurchaseDetail");
																						((ISupportInitialize)DataGridView1).EndInit();
																						((Control)this).ResumeLayout(false);
																						num = 38;
																						goto case '涾';
																					case '涾':
																						((Control)this).PerformLayout();
																						return;
																					}
																					continue;
																					end_IL_000e:
																					break;
																				}
																				continue;
																				end_IL_0190:
																				break;
																			}
																			continue;
																			end_IL_01b4:
																			break;
																		}
																		continue;
																		end_IL_01d6:
																		break;
																	}
																	continue;
																	end_IL_01ff:
																	break;
																}
																continue;
																end_IL_022b:
																break;
															}
															continue;
															end_IL_024c:
															break;
														}
														continue;
														end_IL_026d:
														break;
													}
													continue;
													end_IL_028f:
													break;
												}
												continue;
												end_IL_02b8:
												break;
											}
											continue;
											end_IL_02e4:
											break;
										}
										continue;
										end_IL_0312:
										break;
									}
									continue;
									end_IL_0333:
									break;
								}
								continue;
								end_IL_0359:
								break;
							}
							continue;
							end_IL_037f:
							break;
						}
						continue;
						end_IL_0384:
						break;
					}
					continue;
					end_IL_03a7:
					break;
				}
				continue;
				end_IL_03cd:
				break;
			}
		}
	}

	private void w6B(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void Gw2(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Pp5(object sender, EventArgs e)
	{
		Cj6();
	}

	private void s9W(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_purchase_detail values(" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())) + ",'" + txtRName.get_Text() + "','" + txtCategory.get_Text() + "','" + DateTimePicker1.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", " + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " )");
			cmd.ExecuteReader();
			MessageBox.Show("Record Saved");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		Cj6();
		b4C0.char_0[614] = (char)((b4C0.char_0[614] ^ byte_0[296]) & 'Ô');
	}

	public void Cj6()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_purchase_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Raw Code");
			DataGridView1.get_Columns().Add("c2", "Raw Name");
			DataGridView1.get_Columns().Add("c3", "Category");
			DataGridView1.get_Columns().Add("c4", "Purchase Date");
			DataGridView1.get_Columns().Add("c5", "Amount");
			DataGridView1.get_Columns().Add("c6", "Weight");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("rowcode").ToString(),
					rd.get_Item("rowname"),
					rd.get_Item("category"),
					rd.get_Item("purdate"),
					rd.get_Item("amount"),
					rd.get_Item("weight")
				});
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
	}

	internal static byte[] Ja0(int j2S)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		bool num2 = text.Length > 2;
		b4C0.char_0[527] = (char)(b4C0.char_0[527] & b4C0.char_0[55] & '±');
		if (num2)
		{
			return q9X.k5PS(Aw7.No1(), j2S);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void Mx7(object sender, EventArgs e)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_purchase_detail set rowname ='" + txtRName.get_Text() + "',category='" + txtCategory.get_Text() + "',purdate='" + DateTimePicker1.get_Text() + "',amount=" + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", weight=" + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Modified");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		Cj6();
	}

	private void a6Z(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_purchase_detail where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Deleted");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		Cj6();
	}

	static void x1L()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lp5 lp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		try
		{
			do
			{
				lp = (Lp5)(object)j7W.Default;
				lp = lp;
				obj = obj;
			}
			while (obj != null);
		}
		catch
		{
			num = (UIntPtr)j7W.Default;
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (d3R)(object)j7W.Default;
				_ = (d3R)(object)j7W.Default;
				_ = (Pr5)(object)j7W.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 * (num + num)) == 0)
				{
					Bj2 bj = null;
					bj = bj;
				}
			}
			goto IL_009e;
		}
		IL_009e:
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (_003CModule_003E)(object)j7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nk8 nk);
		checked
		{
			if (num + num == 0)
			{
				do
				{
					nk = nk;
					nk = nk;
				}
				while (obj != null || obj != null);
			}
			lp = lp;
			while (obj != null)
			{
				_ = (Cs3)(object)j7W.Default;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					lp = lp;
				}
			}
			if (num + num == 0)
			{
				_ = (f0Q)j7W.Default;
			}
			if (unchecked((nuint)(UIntPtr)j7W.Default) + unchecked((nuint)(UIntPtr)j7W.Default) == 0)
			{
				if (unchecked((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u))
				{
					while (obj != null)
					{
						_ = (Nk8)(object)j7W.Default;
					}
				}
				else
				{
					do
					{
						_ = (b4C0)(object)j7W.Default;
					}
					while (obj != null);
				}
			}
			else
			{
				while (obj != null)
				{
					try
					{
						_ = (f0Q)j7W.Default;
					}
					finally
					{
						_ = (Ca4)(object)j7W.Default;
						_ = (b4C0)(object)j7W.Default;
						continue;
					}
				}
			}
			try
			{
				_ = (Wn2)(object)j7W.Default;
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)j7W.Default;
					_ = (g7A)(object)j7W.Default;
				}
				finally
				{
					_ = (Bj2)(object)j7W.Default;
					goto end_IL_01b7;
				}
				end_IL_01b7:;
			}
			finally
			{
				while ((object)j7W.Default != null)
				{
					num = default(UIntPtr);
					if (unchecked(checked(num - unchecked((nuint)(UIntPtr)j7W.Default)) / num) * num == 0)
					{
						_ = (Fw02)(object)j7W.Default;
						continue;
					}
					i3F i3F = (i3F)(object)j7W.Default;
					i3F = i3F;
				}
				goto IL_023a;
			}
		}
		IL_023a:
		checked
		{
			try
			{
				nk = null;
			}
			catch
			{
				try
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)j7W.Default / (nuint)(UIntPtr)j7W.Default) == 0)
					{
						_ = (i3F)(object)j7W.Default;
					}
					else
					{
						_ = (Cs3)(object)j7W.Default;
					}
				}
				catch
				{
					try
					{
						_ = (We5)j7W.Default;
						goto end_IL_0283;
					}
					finally
					{
						We5 obj4 = (We5)j7W.Default;
						We5 we = we;
						we = obj4;
						goto end_IL_0283;
					}
					end_IL_0283:;
				}
			}
		}
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
			do
			{
				_ = (f6Y)(object)j7W.Default;
				so = so;
				so = so;
				_ = (g7A)(object)j7W.Default;
			}
			while ((object)j7W.Default != null || obj != null);
		}
		while (obj != null)
		{
			UIntPtr num3 = (UIntPtr)j7W.Default;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num3 / num) + num == 0)
				{
				}
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fw02 fw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pr5 pr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9X q9X);
		if (num == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					q9X = null;
					q9X = q9X;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j7W.Default;
					_003CModule_003E = _003CModule_003E;
					Fw02 obj7 = (Fw02)(object)j7W.Default;
					fw = fw;
					fw = obj7;
					pr = pr;
					_ = (Wn2)(object)j7W.Default;
					goto IL_039f;
				}
			}
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Cs3)(object)j7W.Default;
			}
		}
		goto IL_039f;
		IL_039f:
		f6Y f6Y = f6Y;
		f6Y = f6Y;
		_ = (Bj2)(object)j7W.Default;
		pr = null;
		_ = (Bj2)(object)j7W.Default;
		_ = (f6Y)(object)j7W.Default;
		if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			q9X = q9X;
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (g7A)(object)j7W.Default;
				_ = (_003CModule_003E)(object)j7W.Default;
			}
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (i3F)(object)j7W.Default;
			}
			else
			{
				f6Y = null;
				_ = (d3R)(object)j7W.Default;
			}
		}
		finally
		{
			while ((object)j7W.Default != null)
			{
				_ = (k3NH)(object)j7W.Default;
			}
			goto IL_044d;
		}
		IL_044d:
		do
		{
			fw = fw;
			_ = (i3F)(object)j7W.Default;
			_003CModule_003E _003CModule_003E = null;
		}
		while ((object)j7W.Default != null);
		try
		{
			try
			{
				g7A obj9 = (g7A)(object)j7W.Default;
				g7A g7A = g7A;
				g7A = obj9;
				nk = nk;
			}
			catch
			{
				_ = (i3F)(object)j7W.Default;
			}
		}
		catch
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				b4C0 b4C = (b4C0)(object)j7W.Default;
				b4C = b4C;
			}
		}
	}
}
