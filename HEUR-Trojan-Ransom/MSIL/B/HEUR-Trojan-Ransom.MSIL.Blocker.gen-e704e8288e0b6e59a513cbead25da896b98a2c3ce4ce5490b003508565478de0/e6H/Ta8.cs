using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ba50;
using Cd1t;
using Ci75;
using Es0;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Ri5n;
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xo8;
using Xs5;
using a9D;
using c4ZK;
using j3B;
using q8B;
using s1Y;
using t5D;
using x9E1;

namespace e6H;

[DesignerGenerated]
public class Ta8 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static b2H1 b2H1_0/* Not supported: data(55 8F E8 B2 5C 71 E3 A1 EF CA C3 BA E2 13 6F 52 64 3B AD 83 13 88 57 55 4A 02 3F 7A C4 D8 3C 21 0C 11 82 98 16 00 BB FC 00 B2 42 54 0A 38 35 41 48 39 18 01 EC B2 95 7C 8A 98 37 27 AA 76 F9 68 54 45 5B 38 04 04 CC 2D B8 A2 70 7F 25 F3 8D 0E D4 9B B5 80 74 5F 04 E2 69 59 7C 35 2E ED 83 6E E4 17 28 CF 8A 91 1A 8E 83 34 AD 2F 98 41 12 3B DD 7A 26 30 9A 68 D7 C9 D6 07 4B 97 E4 B9 2C 14 03 0D 1A 1F 03 10 EE C9 3B 76 F8 AA 82 7E 9B 91 5C A5 88 F1 E7 60 4A 31 CD F4 05 56 CB E7 CB 03 E8 13 69 44 B1 64 61 C9 AC 95 8E E8 75 34 A6 15 C1 F6 F1 C8 EE B2 91 72 D5 16 4E 29 B6 06 88 04 D0 C6 47 4B 00 D5 4E 3A 79 25 3F 23 47 F8 EA 6C A5 50 EE FF BD E8 FA 42 C5 CE 4D 10 44 46 D7 24 5A 48 CF 64 EE B5 6C C3 9A 32 81 F0 7F 7E 73 24 A4 EA 5B FA 2C D3 49 AD 08 F8 F0 0B C6 7A 0E 7C D1 EA 5E 5C 78 6A 85 A9 03 81 7C AD 51 DE A8 F0 20 4C C5 F7 BC 78 BD 95 D0 FF 7A F1 DF 46 74 E6 AC 82 17 8E 37 2A 05 B2 5E 73 48 43 ED D1 4E D6 C7 CC 8D B0 A9 4F 1C 2B 12 50 FD 4A E1 74 B4 44 28 85 AE 6C 27 58 67 72 D3 A5 BD 9C D2 A3 DC 9A 7C 86 44 C5 4B 77 D3 3A C5 77 C1 E8 A1 24 29 F9 7C B3 B6 EC 9C 2A F1 69 B8 E1 BF C8 AF 08 88 A7 6F 8A 29 94 BC DC 75 D0 D3 5D 34 B3 96 A0 22 01 E4 82 07 34 94 10 22 93 52 99 76 D4 A0 40 EE E5 43 EA 59 8F 88 2B 18 AE FB CB 1A 97 89 5E 05 E4 EB 8B 7F 56 9F 77 5A 63 61 20 EF 0A FB 62 67 BC FF 63 9D B0 F7 E7 AA 11 FF BF 5C D3 09 3D 47 D3 AE 24 29 76 ED B7 BD 43 2C D8 7E 91 D6 5F 04 DF 16 AC AD 44 AD 7F 5E 52 37 9D 95 5A 8C DB 53 F3 9F 35 B6 F8 89 44 54 07 95 3B 3B 3D C0 E0 F5 77 0A D1 2C 54 22 2F B3 E8 7E EC F6 2E EE 25 E6 16 4F 52 3F 58 69 89 D2 55 2B DF CC 1A D8 0B 6C FA A7 F6 99 98 43 B7 B3 DB 41 8B 9D 10 2F 1F 69 09 10 D5 A2 F4 09 DC 47 C7 D3 8E B5 35 B2 97 72 E7 67 95 F8 3F B1 72 FF 83 5B 62 22 77 85 F2 20 7D BE 1E C6 68 0E 00 F7 44 2A D1 B9 85 28 14 D3 1A DE EC 1C 4A AC 10 FA A2 F7 85 0C 05 B3 EC 6D C0 FD 34 B9 25 A3 13 DA F7 EB 52 A5 5E 12 88 9A 1C 8C C0 F6 A1 69 C0 33 9F 19 A8 D8 87 10 98 84 7F 13 A6 23 3A F4 BC 7A 22 8E 10 36 DA 3D 38 57 4F 7A E0 36 C1 68 DA B7 44 09 25 B6 F4 7A 61 5B 90 44 53 43 B2 02 4F A2 3C 7F 63 A9 FA 34 2A 18 C0 B3 E0 73 E3 69 84 34 2F 4E C5 F4 74 B8 72 06 65 0A B2 26 91 E6 FC D4 4B 16 48 38 CA DE AF C5 5A 7B ED 4A C4 60 17 B3 91 3B 84 5B 43 8F F7 D5 CB 7B 40 0E 30 EE 4B D5 F5 D5 38 6E 5B 05 1C 68 AB EE 0F DB FC C6 41 1A 2D CD 55 08 09 08 8A 86 6B 7D 4E 62 75 AB 92 E2 93 CF F7 A6 15 44 48 0A 89 64 02 3C F4) */;

	internal static char[] char_0;

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
			EventHandler eventHandler = Qs7;
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
			EventHandler eventHandler = Jj3;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("txtSNo")]
	internal virtual TextBox txtSNo
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
			EventHandler eventHandler = e0D;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			Button obj = val;
			char_0[263] = (char)((char_0[263] ^ char_0[128]) & 'y');
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
			EventHandler eventHandler = x8R;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRaw")]
	internal virtual TextBox txtSRaw
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
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
			int[] int_ = c0B.int_0;
			int num = 3;
			while (true)
			{
				IL_0064:
				EventHandler eventHandler = n8Q;
				Button val = _btnSave;
				if (val == null)
				{
					num = 2;
					goto IL_004d;
				}
				num = 5;
				goto IL_0046;
				IL_004d:
				while (true)
				{
					_btnSave = value;
					val = _btnSave;
					if (val != null)
					{
						switch (int_[171])
						{
						case 36008:
							break;
						case 36005:
							continue;
						default:
							goto IL_0064;
						case 36003:
						case 36010:
							((Control)val).add_Click(eventHandler);
							char_0[159] = (char)((char_0[159] - char_0[30]) & '\u0011');
							return;
						case 36004:
						case 36007:
						case 36009:
							return;
						}
						break;
					}
					num = 1;
					return;
				}
				goto IL_0046;
				IL_0046:
				((Control)val).remove_Click(eventHandler);
				goto IL_004d;
			}
		}
	}

	public Ta8()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)t8K);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		w1S();
	}

	[DebuggerNonUserCode]
	protected override void Zf0(bool r9W)
	{
		try
		{
			if (r9W && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r9W);
		}
	}

	[DebuggerStepThrough]
	private void w1S()
	{
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		char[] array = char_0;
		int num = 70;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			while (true)
			{
				num = 37;
				while (true)
				{
					DataGridView1 = new DataGridView();
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					num = 72;
					while (true)
					{
						Label5 = new Label();
						Label4 = new Label();
						Label1 = new Label();
						num = 49;
						while (true)
						{
							txtSNo = new TextBox();
							while (true)
							{
								btnDelete = new Button();
								btnModify = new Button();
								num = 67;
								while (true)
								{
									txtAmount = new TextBox();
									txtSRaw = new TextBox();
									txtWeight = new TextBox();
									num = 68;
									while (true)
									{
										Label2 = new Label();
										btnSave = new Button();
										((ISupportInitialize)DataGridView1).BeginInit();
										num = 69;
										while (true)
										{
											((Control)this).SuspendLayout();
											Label3.set_AutoSize(true);
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 55;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(355, 22));
												num = 40;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(95, 17));
													num = 56;
													while (true)
													{
														((Control)Label3).set_TabIndex(9);
														Label3.set_Text("Sales Detail");
														num = 18;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 66;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 34;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(739, 22));
																	num = 4;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 48;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(9);
																			Label6.set_Text("X");
																			num = 6;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 47;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 20;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(47, 22));
																						num = 51;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 7;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(8);
																								Label7.set_Text("Go To Main");
																								num = 14;
																								while (true)
																								{
																									DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																									((Control)DataGridView1).set_Location(new Point(33, 239));
																									num = 19;
																									while (true)
																									{
																										((Control)DataGridView1).set_Name("DataGridView1");
																										((Control)DataGridView1).set_Size(new Size(724, 199));
																										num = 64;
																										while (true)
																										{
																											((Control)DataGridView1).set_TabIndex(10);
																											((Control)DateTimePicker1).set_Location(new Point(525, 64));
																											num = 13;
																											while (true)
																											{
																												((Control)DateTimePicker1).set_Name("DateTimePicker1");
																												((Control)DateTimePicker1).set_Size(new Size(126, 20));
																												num = 73;
																												while (true)
																												{
																													((Control)DateTimePicker1).set_TabIndex(3);
																													Label8.set_AutoSize(true);
																													char num2 = array[127];
																													c0B.int_0[508] = (c0B.int_0[508] + char_0[94]) & 0xF8;
																													switch (num2 - 31700)
																													{
																													case 73:
																														break;
																													case 13:
																														goto end_IL_000e;
																													case 64:
																														goto end_IL_0191;
																													case 19:
																														goto end_IL_01bd;
																													case 14:
																														goto end_IL_01e6;
																													case 7:
																														goto end_IL_0215;
																													case 51:
																														goto end_IL_023d;
																													case 20:
																														goto end_IL_025e;
																													case 47:
																														goto end_IL_0286;
																													case 6:
																														goto end_IL_02af;
																													case 48:
																														goto end_IL_02d1;
																													case 4:
																														goto end_IL_02f2;
																													case 34:
																														goto end_IL_0313;
																													case 66:
																														goto end_IL_033c;
																													case 18:
																														goto end_IL_0367;
																													case 56:
																														goto end_IL_0389;
																													case 40:
																														goto end_IL_03aa;
																													case 55:
																														goto end_IL_03cc;
																													case 69:
																														goto end_IL_03f5;
																													case 68:
																														goto end_IL_0421;
																													case 67:
																														goto end_IL_0455;
																													case 59:
																														goto end_IL_047b;
																													case 49:
																														goto end_IL_04a1;
																													case 72:
																														goto end_IL_04bc;
																													case 37:
																														goto end_IL_04c9;
																													case 65:
																														goto end_IL_04ef;
																													default:
																														goto end_IL_0515;
																													case 58:
																														((Control)Label8).set_ForeColor(Color.White);
																														((Control)Label8).set_Location(new Point(154, 130));
																														num = 52;
																														goto case 52;
																													case 52:
																														((Control)Label8).set_Name("Label8");
																														((Control)Label8).set_Size(new Size(49, 13));
																														num = 54;
																														goto case 54;
																													case 54:
																														((Control)Label8).set_TabIndex(94);
																														Label8.set_Text("Amount :");
																														num = 1;
																														goto case 1;
																													case 1:
																														Label5.set_AutoSize(true);
																														((Control)Label5).set_ForeColor(Color.White);
																														num = 45;
																														goto case 45;
																													case 45:
																														((Control)Label5).set_Location(new Point(144, 101));
																														((Control)Label5).set_Name("Label5");
																														num = 11;
																														goto case 11;
																													case 11:
																														((Control)Label5).set_Size(new Size(66, 13));
																														((Control)Label5).set_TabIndex(93);
																														num = 8;
																														goto case 8;
																													case 8:
																														Label5.set_Text("Raw Name :");
																														Label4.set_AutoSize(true);
																														goto case 30;
																													case 30:
																														num = 31;
																														goto case 31;
																													case 31:
																														((Control)Label4).set_ForeColor(Color.White);
																														((Control)Label4).set_Location(new Point(431, 102));
																														num = 35;
																														goto case 35;
																													case 35:
																														((Control)Label4).set_Name("Label4");
																														((Control)Label4).set_Size(new Size(72, 13));
																														num = 42;
																														goto case 42;
																													case 42:
																														((Control)Label4).set_TabIndex(92);
																														Label4.set_Text("Raw Weight :");
																														num = 25;
																														goto case 25;
																													case 25:
																														Label1.set_AutoSize(true);
																														((Control)Label1).set_ForeColor(Color.White);
																														num = 10;
																														goto case 10;
																													case 10:
																														((Control)Label1).set_Location(new Point(438, 64));
																														((Control)Label1).set_Name("Label1");
																														num = 0;
																														goto case 0;
																													case 0:
																														((Control)Label1).set_Size(new Size(65, 13));
																														((Control)Label1).set_TabIndex(91);
																														num = 32;
																														goto case 32;
																													case 32:
																														Label1.set_Text("Sales Date :");
																														((Control)txtSNo).set_Location(new Point(233, 64));
																														num = 36;
																														goto case 36;
																													case 36:
																														((Control)txtSNo).set_Name("txtSNo");
																														((Control)txtSNo).set_Size(new Size(100, 20));
																														num = 2;
																														goto case 2;
																													case 2:
																														((Control)txtSNo).set_TabIndex(0);
																														((Control)btnDelete).set_Location(new Point(480, 172));
																														num = 26;
																														goto case 26;
																													case 26:
																														((Control)btnDelete).set_Name("btnDelete");
																														((Control)btnDelete).set_Size(new Size(75, 31));
																														num = 23;
																														goto case 23;
																													case 23:
																														((Control)btnDelete).set_TabIndex(7);
																														((ButtonBase)btnDelete).set_Text("DELETE");
																														num = 57;
																														goto case 57;
																													case 57:
																														((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																														((Control)btnModify).set_Location(new Point(362, 172));
																														num = 41;
																														goto case 41;
																													case 41:
																														((Control)btnModify).set_Name("btnModify");
																														((Control)btnModify).set_Size(new Size(75, 31));
																														num = 33;
																														goto case 33;
																													case 33:
																														((Control)btnModify).set_TabIndex(6);
																														((ButtonBase)btnModify).set_Text("MODIFY");
																														num = 12;
																														goto case 12;
																													case 12:
																														((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																														((Control)txtAmount).set_Location(new Point(231, 124));
																														num = 44;
																														goto case 44;
																													case 44:
																														((Control)txtAmount).set_Name("txtAmount");
																														((Control)txtAmount).set_Size(new Size(100, 20));
																														num = 50;
																														goto case 50;
																													case 50:
																														((Control)txtAmount).set_TabIndex(2);
																														((Control)txtSRaw).set_Location(new Point(231, 94));
																														num = 24;
																														goto case 24;
																													case 24:
																														((Control)txtSRaw).set_Name("txtSRaw");
																														((Control)txtSRaw).set_Size(new Size(100, 20));
																														num = 29;
																														goto case 29;
																													case 29:
																														((Control)txtSRaw).set_TabIndex(1);
																														((Control)txtWeight).set_Location(new Point(525, 99));
																														num = 43;
																														goto case 43;
																													case 43:
																														((Control)txtWeight).set_Name("txtWeight");
																														((Control)txtWeight).set_Size(new Size(100, 20));
																														num = 75;
																														goto case 75;
																													case 75:
																														((Control)txtWeight).set_TabIndex(4);
																														Label2.set_AutoSize(true);
																														num = 21;
																														goto case 21;
																													case 21:
																														((Control)Label2).set_ForeColor(Color.White);
																														((Control)Label2).set_Location(new Point(155, 67));
																														num = 38;
																														goto case 38;
																													case 38:
																														((Control)Label2).set_Name("Label2");
																														((Control)Label2).set_Size(new Size(56, 13));
																														num = 71;
																														goto case 71;
																													case 71:
																														((Control)Label2).set_TabIndex(90);
																														Label2.set_Text("Sales No :");
																														num = 9;
																														goto case 9;
																													case 9:
																														((Control)btnSave).set_Location(new Point(233, 172));
																														((Control)btnSave).set_Name("btnSave");
																														num = 62;
																														goto case 62;
																													case 62:
																														((Control)btnSave).set_Size(new Size(75, 31));
																														((Control)btnSave).set_TabIndex(5);
																														num = 60;
																														goto case 60;
																													case 60:
																														((ButtonBase)btnSave).set_Text("SAVE");
																														((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																														num = 15;
																														goto case 15;
																													case 15:
																														((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																														((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																														num = 22;
																														goto case 22;
																													case 22:
																														((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																														((Form)this).set_ClientSize(new Size(800, 450));
																														num = 61;
																														goto case 61;
																													case 61:
																														((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																														((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																														num = 5;
																														goto case 5;
																													case 5:
																														((Control)this).get_Controls().Add((Control)(object)Label8);
																														((Control)this).get_Controls().Add((Control)(object)Label5);
																														num = 53;
																														goto case 53;
																													case 53:
																														((Control)this).get_Controls().Add((Control)(object)Label4);
																														((Control)this).get_Controls().Add((Control)(object)Label1);
																														num = 3;
																														goto case 3;
																													case 3:
																														((Control)this).get_Controls().Add((Control)(object)txtSNo);
																														((Control)this).get_Controls().Add((Control)(object)btnDelete);
																														num = 28;
																														goto case 28;
																													case 28:
																														((Control)this).get_Controls().Add((Control)(object)btnModify);
																														((Control)this).get_Controls().Add((Control)(object)txtAmount);
																														num = 27;
																														goto case 27;
																													case 27:
																														((Control)this).get_Controls().Add((Control)(object)txtSRaw);
																														((Control)this).get_Controls().Add((Control)(object)txtWeight);
																														num = 39;
																														goto case 39;
																													case 39:
																														((Control)this).get_Controls().Add((Control)(object)Label2);
																														((Control)this).get_Controls().Add((Control)(object)btnSave);
																														num = 16;
																														goto case 16;
																													case 16:
																														((Control)this).get_Controls().Add((Control)(object)Label6);
																														((Control)this).get_Controls().Add((Control)(object)Label7);
																														num = 74;
																														goto case 74;
																													case 74:
																														((Control)this).get_Controls().Add((Control)(object)Label3);
																														((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																														num = 63;
																														goto case 63;
																													case 63:
																														((Control)this).set_Name("frmSalesDetail");
																														((Form)this).set_StartPosition((FormStartPosition)1);
																														((Form)this).set_Text("frmSalesDetail");
																														num = 17;
																														goto case 17;
																													case 17:
																														((ISupportInitialize)DataGridView1).EndInit();
																														((Control)this).ResumeLayout(false);
																														((Control)this).PerformLayout();
																														num = 46;
																														return;
																													case 46:
																														return;
																													}
																													continue;
																													end_IL_000e:
																													break;
																												}
																												continue;
																												end_IL_0191:
																												break;
																											}
																											continue;
																											end_IL_01bd:
																											break;
																										}
																										continue;
																										end_IL_01e6:
																										break;
																									}
																									continue;
																									end_IL_0215:
																									break;
																								}
																								continue;
																								end_IL_023d:
																								break;
																							}
																							continue;
																							end_IL_025e:
																							break;
																						}
																						continue;
																						end_IL_0286:
																						break;
																					}
																					continue;
																					end_IL_02af:
																					break;
																				}
																				continue;
																				end_IL_02d1:
																				break;
																			}
																			continue;
																			end_IL_02f2:
																			break;
																		}
																		continue;
																		end_IL_0313:
																		break;
																	}
																	continue;
																	end_IL_033c:
																	break;
																}
																continue;
																end_IL_0367:
																break;
															}
															continue;
															end_IL_0389:
															break;
														}
														continue;
														end_IL_03aa:
														break;
													}
													continue;
													end_IL_03cc:
													break;
												}
												continue;
												end_IL_03f5:
												break;
											}
											continue;
											end_IL_0421:
											break;
										}
										continue;
										end_IL_0455:
										break;
									}
									continue;
									end_IL_047b:
									break;
								}
								continue;
								end_IL_04a1:
								break;
							}
							continue;
							end_IL_04bc:
							break;
						}
						continue;
						end_IL_04c9:
						break;
					}
					continue;
					end_IL_04ef:
					break;
				}
				continue;
				end_IL_0515:
				break;
			}
		}
	}

	private void Jj3(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void Qs7(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void t8K(object sender, EventArgs e)
	{
	}

	private void n8Q(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_sales_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())) + ",'" + DateTimePicker1.get_Text() + "','" + txtSRaw.get_Text() + "','" + txtWeight.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ")");
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
		p5Q();
	}

	public void p5Q()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_sales_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Sales No");
			DataGridView1.get_Columns().Add("c2", "Sales Date");
			DataGridView1.get_Columns().Add("c3", "Raw Name");
			DataGridView1.get_Columns().Add("c4", "Raw Weight");
			DataGridView1.get_Columns().Add("c4", "Amount");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("salesno").ToString(),
					rd.get_Item("salesdate"),
					rd.get_Item("raw"),
					rd.get_Item("rawweight"),
					rd.get_Item("amount").ToString()
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

	private void e0D(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_sales_detail where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		p5Q();
	}

	internal static string[] Sw8()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(Ng67.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				foreach (string item in array2)
				{
					list.Add(item);
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num2 = array3.Length - 1;
				for (num = 0; num <= num2; num++)
				{
					array3[num] = list[num];
				}
				return array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void x8R(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_sales_detail set salesdate ='" + DateTimePicker1.get_Text() + "',raw='" + txtSRaw.get_Text() + "',rawweight='" + txtWeight.get_Text() + "',amount='" + txtAmount.get_Text() + "'  where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		p5Q();
	}

	static void g3X()
	{
		object obj;
		do
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)j5Y1.Default != null)
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					_ = (Ws0)(object)j5Y1.Default;
				}
			}
			obj = j5Y1.Default;
		}
		while (obj != null);
		while ((object)j5Y1.Default != null)
		{
			_ = (Br2)(object)j5Y1.Default;
		}
		_ = (b2H1)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		try
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					ja = null;
					ja = ja;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (t1P)(object)j5Y1.Default;
			}
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					br = br;
				}
				continue;
			}
			try
			{
				_ = (Gw13)(object)j5Y1.Default;
				_ = (t1P)(object)j5Y1.Default;
				t1P = (t1P)(object)j5Y1.Default;
				t1P = t1P;
				_ = (Cd0n)(object)j5Y1.Default;
			}
			finally
			{
				_ = (y9T)(object)j5Y1.Default;
				continue;
			}
		}
		while (obj != null);
		br = (Br2)(object)j5Y1.Default;
		while ((object)j5Y1.Default != null)
		{
			try
			{
				_ = (c0B)(object)j5Y1.Default;
			}
			catch
			{
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					ja = ja;
				}
			}
			while (obj != null);
			goto IL_01b3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		try
		{
		}
		finally
		{
			try
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
			finally
			{
				k8NS = k8NS;
				k8NS = default(k8NS);
				goto IL_01b3;
			}
		}
		IL_01b3:
		UIntPtr num = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		checked
		{
			if (unchecked((nuint)num) * (uIntPtr * uIntPtr) == 0)
			{
				try
				{
					try
					{
						z1J obj4 = (z1J)(object)j5Y1.Default;
						z1J = z1J;
						z1J = obj4;
					}
					catch
					{
						_ = (Ma6)(object)j5Y1.Default;
					}
				}
				catch
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
			}
			try
			{
				try
				{
					Ma6 ma = ma;
					ma = ma;
				}
				finally
				{
					do
					{
						Ta8 ta = (Ta8)(object)j5Y1.Default;
						ta = ta;
					}
					while (obj != null);
					goto end_IL_0205;
				}
				end_IL_0205:;
			}
			catch
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
			try
			{
				while ((object)j5Y1.Default != null)
				{
					if (uIntPtr == 0)
					{
						t1P = null;
						br = br;
						_ = (t1P)(object)j5Y1.Default;
					}
				}
			}
			catch
			{
			}
			Be5 be = null;
			be = be;
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
				}
			}
			catch
			{
				o8W o8W = o8W;
				o8W = null;
				Ws0 ws = ws;
				_ = (c0B)(object)j5Y1.Default;
			}
			ja = (Ja24)(object)j5Y1.Default;
			try
			{
				if (uIntPtr == 0)
				{
					j5Y = j5Y1.Default;
					j5Y = j5Y;
				}
			}
			catch
			{
				Ng67 obj10 = (Ng67)(object)j5Y1.Default;
				ng = ng;
				ng = obj10;
			}
			finally
			{
				goto IL_0306;
			}
		}
		IL_0306:
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				_ = (Cd0n)(object)j5Y1.Default;
				_ = (Cd0n)(object)j5Y1.Default;
			}
			else if (unchecked(uIntPtr / (nuint)(UIntPtr)j5Y1.Default) * (uIntPtr + unchecked((nuint)(UIntPtr)j5Y1.Default)) == 0)
			{
				_ = (c0B)(object)j5Y1.Default;
			}
			do
			{
				try
				{
					try
					{
						_ = (t1P)(object)j5Y1.Default;
					}
					finally
					{
						br = null;
						_ = (c0B)(object)j5Y1.Default;
						_ = (Ta8)(object)j5Y1.Default;
						_ = (n4NE)(object)j5Y1.Default;
						goto end_IL_035c;
					}
					end_IL_035c:;
				}
				finally
				{
					do
					{
						t1P = t1P;
					}
					while (obj != null);
					continue;
				}
			}
			while (obj != null);
			_ = (b2H1)j5Y1.Default;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					j5Y = j5Y;
					_ = (o8W)(object)j5Y1.Default;
					_ = (z1J)(object)j5Y1.Default;
					k8NS = default(k8NS);
					k8NS = k8NS;
				}
				finally
				{
					_ = (o8W)(object)j5Y1.Default;
					goto end_IL_03c8;
				}
				end_IL_03c8:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					ng = (Ng67)(object)j5Y1.Default;
				}
			}
		}
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				finally
				{
					t1P = t1P;
					continue;
				}
			}
		}
		_ = (Gw13)(object)j5Y1.Default;
		_ = (Gw13)(object)j5Y1.Default;
		k8NS = k8NS;
		_ = (Ng67)(object)j5Y1.Default;
		_ = j5Y1.Default;
		t1P = (t1P)(object)j5Y1.Default;
		while (obj != null)
		{
			k8NS = k8NS;
			_ = (c0B)(object)j5Y1.Default;
			_ = (Gw13)(object)j5Y1.Default;
		}
		try
		{
			do
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
				k8NS = k8NS;
			}
			while ((object)j5Y1.Default != null);
		}
		catch
		{
			while (obj != null)
			{
				while (obj != null)
				{
					Ws0 ws = (Ws0)(object)j5Y1.Default;
				}
			}
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					j5Y = j5Y;
					_ = (z1J)(object)j5Y1.Default;
					_ = (Cd0n)(object)j5Y1.Default;
					_ = (Ws0)(object)j5Y1.Default;
				}
				finally
				{
					t1P = t1P;
					_ = (_003CModule_003E)(object)j5Y1.Default;
					continue;
				}
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				Be5 be = null;
			}
			finally
			{
				try
				{
					_ = j5Y1.Default;
				}
				finally
				{
					ja = null;
					goto IL_05cc;
				}
			}
		}
		do
		{
			ng = ng;
		}
		while (obj != null);
		goto IL_05cc;
		IL_05cc:
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
				finally
				{
					_ = (Ta8)(object)j5Y1.Default;
					goto end_IL_058b;
				}
				end_IL_058b:;
			}
			catch
			{
				do
				{
					_ = (Be5)(object)j5Y1.Default;
					z1J = null;
					_ = (b2H1)j5Y1.Default;
				}
				while (obj != null);
			}
		}
		if (uIntPtr / uIntPtr != 0)
		{
			return;
		}
		try
		{
			z1J = z1J;
		}
		catch
		{
			_ = (Ng67)(object)j5Y1.Default;
		}
		finally
		{
			_ = (Ma6)(object)j5Y1.Default;
			return;
		}
	}

	static void Li8()
	{
		Tg0e tg0e = tg0e;
		tg0e = null;
		_ = (Gw13)(object)j5Y1.Default;
		UIntPtr num = (UIntPtr)j5Y1.Default;
		Gw13 gw;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		if (checked(num * num) == 0)
		{
			Gw13 obj = (Gw13)(object)j5Y1.Default;
			gw = null;
			gw = obj;
		}
		else
		{
			gw = (Gw13)(object)j5Y1.Default;
			j5Y = null;
			j5Y = j5Y;
		}
		_ = (Tg0e)(object)j5Y1.Default;
		_ = (Ng67)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		try
		{
			_ = (c0B)(object)j5Y1.Default;
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					w5D = (w5D)(object)j5Y1.Default;
					w5D = w5D;
				}
				else
				{
					_ = (b2H1)j5Y1.Default;
				}
			}
			catch
			{
				o8W = (o8W)(object)j5Y1.Default;
				o8W = null;
			}
		}
		_ = (k8NS)j5Y1.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			finally
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					gw = gw;
				}
				goto IL_0143;
			}
		}
		goto IL_0143;
		IL_0143:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		while ((object)j5Y1.Default != null)
		{
			while (true)
			{
				obj4 = obj4;
				if (obj4 == null)
				{
					break;
				}
				try
				{
					_ = j5Y1.Default;
				}
				finally
				{
					b2H = b2H;
					b2H = b2H;
					continue;
				}
			}
		}
		b2H = b2H;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		checked
		{
			if ((unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)j5Y1.Default)) * unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
			{
				try
				{
					ma = (Ma6)(object)j5Y1.Default;
					ma = null;
					b2H = (b2H1)j5Y1.Default;
					t1P t1P = (t1P)(object)j5Y1.Default;
					t1P = t1P;
				}
				catch
				{
					_ = (Ng67)(object)j5Y1.Default;
					Ng67 ng = (Ng67)(object)j5Y1.Default;
					ng = ng;
				}
				finally
				{
					tg0e = tg0e;
					goto IL_01e7;
				}
			}
			goto IL_01e7;
		}
		IL_01e7:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					ma = null;
				}
			}
			while (obj4 != null);
		}
		c0B obj6 = (c0B)(object)j5Y1.Default;
		c0B c0B = c0B;
		c0B = obj6;
		_ = (Ja24)(object)j5Y1.Default;
		if (num == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				else
				{
					b2H = b2H;
					tg0e = tg0e;
				}
			}
		}
		else
		{
			b2H = (b2H1)j5Y1.Default;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
				_ = (n4NE)(object)j5Y1.Default;
				w5D = w5D;
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					Be5 be = be;
					be = be;
				}
				else
				{
					_ = (Br2)(object)j5Y1.Default;
				}
			}
		}
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					j5Y = j5Y;
				}
				while ((object)j5Y1.Default != null);
			}
		}
		while (obj4 != null);
		while (obj4 != null)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (w5D)(object)j5Y1.Default;
					ma = ma;
					_ = (Tg0e)(object)j5Y1.Default;
					o8W = o8W;
				}
			}
			catch
			{
				while (obj4 != null)
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
		}
		_ = j5Y1.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (w5D)(object)j5Y1.Default;
		}
		else
		{
			b2H = default(b2H1);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				while (obj4 != null)
				{
					_ = (Br2)(object)j5Y1.Default;
				}
			}
		}
		while ((object)j5Y1.Default != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		while (true)
		{
			if (obj4 != null)
			{
				k8NS = k8NS;
				k8NS = k8NS;
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		while ((object)j5Y1.Default != null)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				w5D = null;
			}
		}
		_ = (Ng67)(object)j5Y1.Default;
		_ = (Be5)(object)j5Y1.Default;
		b2H = b2H;
		_ = (k8NS)j5Y1.Default;
		_ = (z1J)(object)j5Y1.Default;
		_ = (b2H1)j5Y1.Default;
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					_ = (k8NS)j5Y1.Default;
				}
			}
		}
		catch
		{
			while (true)
			{
				if (obj4 != null)
				{
					c0B = (c0B)(object)j5Y1.Default;
				}
				else if ((object)j5Y1.Default == null)
				{
					break;
				}
			}
		}
		Ws0 obj11 = (Ws0)(object)j5Y1.Default;
		Ws0 ws = ws;
		ws = obj11;
		_ = (Ta8)(object)j5Y1.Default;
		_ = (z1J)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		try
		{
			while ((object)j5Y1.Default != null)
			{
				ja = ja;
			}
		}
		catch
		{
			o8W = (o8W)(object)j5Y1.Default;
		}
		ja = ja;
		do
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				b2H = b2H;
			}
		}
		while ((object)j5Y1.Default != null);
		_ = (w5D)(object)j5Y1.Default;
		_ = (Ng67)(object)j5Y1.Default;
		while (obj4 != null)
		{
			gw = gw;
		}
	}

	static void My3()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			checked
			{
				num += unchecked(num / unchecked((nuint)default(UIntPtr)));
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				ws = ws;
				ws = null;
			}
		}
		finally
		{
			_ = (Br2)(object)j5Y1.Default;
			_ = (Be5)(object)j5Y1.Default;
			_ = (Ws0)(object)j5Y1.Default;
			goto IL_005e;
		}
		IL_005e:
		_ = (Ta8)(object)j5Y1.Default;
		_ = (Ta8)(object)j5Y1.Default;
		_ = (Be5)(object)j5Y1.Default;
		_ = (n4NE)(object)j5Y1.Default;
		_ = (b2H1)j5Y1.Default;
		if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
		{
		}
		object obj = null;
		if ((nuint)(UIntPtr)j5Y1.Default / checked(unchecked((nuint)(UIntPtr)j5Y1.Default) - unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
			finally
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (y9T)(object)j5Y1.Default;
				}
				goto IL_00fe;
			}
		}
		goto IL_00fe;
		IL_034e:
		_ = (Br2)(object)j5Y1.Default;
		_ = (w5D)(object)j5Y1.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				nuint num2 = num;
				num = default(UIntPtr);
				nuint num3 = num;
				nuint num4;
				checked
				{
					num4 = num * (num + unchecked((nuint)default(UIntPtr)));
					num = default(UIntPtr);
				}
				if (num2 / checked(num3 - (num4 + num + unchecked((nuint)(UIntPtr)j5Y1.Default / num))) == 0)
				{
					Be5 be = be;
					be = be;
					_ = (o8W)(object)j5Y1.Default;
				}
				else
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					ma = ma;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
			finally
			{
				z1J z1J = (z1J)(object)j5Y1.Default;
				goto IL_046c;
			}
		}
		b2H1 b2H = (b2H1)j5Y1.Default;
		Gw13 gw = gw;
		goto IL_046c;
		IL_046c:
		_ = (Gw13)(object)j5Y1.Default;
		while (obj != null)
		{
			try
			{
				w5D w5D = (w5D)(object)j5Y1.Default;
				w5D = w5D;
			}
			catch
			{
				if (num == 0)
				{
					Cd0n cd0n = null;
					cd0n = cd0n;
				}
				else
				{
					ma = null;
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Br2)(object)j5Y1.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					ws = ws;
				}
				catch
				{
					ma = null;
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			catch
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
		}
		y9T y9T = y9T;
		while (true)
		{
			if ((object)j5Y1.Default != null)
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				else
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
			else if ((object)j5Y1.Default == null)
			{
				break;
			}
		}
		c0B c0B = c0B;
		c0B = null;
		b2H = b2H;
		if (num == 0)
		{
			try
			{
				_ = (o8W)(object)j5Y1.Default;
				_ = (Be5)(object)j5Y1.Default;
				b2H = b2H;
				_ = (Be5)(object)j5Y1.Default;
			}
			finally
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
				goto IL_05cb;
			}
		}
		goto IL_05cb;
		IL_00fe:
		y9T = y9T;
		y9T = null;
		try
		{
			try
			{
				_ = (o8W)(object)j5Y1.Default;
			}
			catch
			{
				_ = (n4NE)(object)j5Y1.Default;
			}
		}
		catch
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ws0)(object)j5Y1.Default;
			}
		}
		finally
		{
			try
			{
				try
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
				catch
				{
					gw = (Gw13)(object)j5Y1.Default;
					gw = gw;
				}
			}
			catch
			{
				_ = (Ng67)(object)j5Y1.Default;
			}
			goto IL_0180;
		}
		IL_0180:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (t1P)(object)j5Y1.Default;
					_ = (Ws0)(object)j5Y1.Default;
					_ = (o8W)(object)j5Y1.Default;
					_003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					k8NS k8NS = k8NS;
					k8NS = k8NS;
					goto IL_0271;
				}
			}
		}
		else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				y9T = (y9T)(object)j5Y1.Default;
			}
			catch
			{
				ja = (Ja24)(object)j5Y1.Default;
				ja = null;
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
			while (obj != null)
			{
				ng = ng;
				ng = ng;
			}
		}
		goto IL_0271;
		IL_0271:
		do
		{
			num = default(UIntPtr);
			if (num / (nuint)(UIntPtr)j5Y1.Default != 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
				continue;
			}
			try
			{
				_ = j5Y1.Default;
			}
			finally
			{
				_ = (Ta8)(object)j5Y1.Default;
				continue;
			}
		}
		while (obj != null);
		if (num / num != 0)
		{
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			b2H = b2H;
		}
		_ = (Gw13)(object)j5Y1.Default;
		do
		{
			try
			{
				_ = (Ma6)(object)j5Y1.Default;
			}
			catch
			{
				_ = (Tg0e)(object)j5Y1.Default;
			}
		}
		while (obj != null || (object)j5Y1.Default != null);
		if (num == 0)
		{
			z1J z1J = z1J;
			z1J = null;
		}
		else
		{
			Ma6 obj13 = (Ma6)(object)j5Y1.Default;
			ma = (Ma6)(object)j5Y1.Default;
			ma = obj13;
		}
		try
		{
			_ = (Ja24)(object)j5Y1.Default;
		}
		catch
		{
			b2H = default(b2H1);
			b2H = b2H;
		}
		finally
		{
			_ = (Ma6)(object)j5Y1.Default;
			goto IL_034e;
		}
		IL_0602:
		do
		{
			try
			{
				ja = ja;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		while (obj != null);
		return;
		IL_05cb:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
		}
		finally
		{
			if (num == 0)
			{
				do
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				while (obj != null);
			}
			goto IL_0602;
		}
	}

	static void g3S()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j5Y1 j5Y);
		do
		{
			if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
			{
				br = br;
				br = br;
				j5Y = j5Y;
				j5Y = j5Y;
				_ = (t1P)(object)j5Y1.Default;
			}
			else
			{
				o8W obj = (o8W)(object)j5Y1.Default;
				o8W = null;
				o8W = obj;
			}
			obj2 = obj2;
		}
		while (obj2 != null);
		try
		{
			do
			{
				_ = j5Y1.Default;
			}
			while (obj2 != null);
		}
		catch
		{
			try
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
			finally
			{
				j5Y = null;
				goto end_IL_0076;
			}
			end_IL_0076:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		t1P t1P;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		checked
		{
			do
			{
				num = num;
				nuint num2 = unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)));
				num = default(UIntPtr);
				if (num2 + num != 0)
				{
					try
					{
						ma = (Ma6)(object)j5Y1.Default;
						ma = ma;
					}
					finally
					{
						Tg0e tg0e = (Tg0e)(object)j5Y1.Default;
						tg0e = tg0e;
						continue;
					}
				}
				try
				{
					t1P obj4 = (t1P)(object)j5Y1.Default;
					t1P = null;
					t1P = obj4;
					z1J z1J = null;
					z1J = z1J;
					w5D obj5 = (w5D)(object)j5Y1.Default;
					w5D = null;
					w5D = obj5;
				}
				finally
				{
					be = (Be5)(object)j5Y1.Default;
					be = null;
					n4NE = n4NE;
					n4NE = n4NE;
					continue;
				}
			}
			while (obj2 != null);
			try
			{
				while ((object)j5Y1.Default != null)
				{
					ng = null;
					ng = ng;
				}
			}
			finally
			{
				while ((object)j5Y1.Default != null)
				{
					try
					{
						ma = null;
					}
					catch
					{
						_ = (y9T)(object)j5Y1.Default;
						be = be;
					}
				}
				goto IL_01d1;
			}
		}
		IL_0558:
		_ = (_003CModule_003E)(object)j5Y1.Default;
		Ja24 ja = (Ja24)(object)j5Y1.Default;
		ja = ja;
		_ = (k8NS)j5Y1.Default;
		UIntPtr num3 = num;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		if ((nuint)num3 / checked(unchecked((nuint)default(UIntPtr)) * (num + num - unchecked((nuint)(UIntPtr)j5Y1.Default))) == 0)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				ja = ja;
				o8W = o8W;
			}
			else
			{
				_ = (Ma6)(object)j5Y1.Default;
				br = br;
				ws = (Ws0)(object)j5Y1.Default;
				_ = (n4NE)(object)j5Y1.Default;
			}
		}
		else
		{
			do
			{
				n4NE = (n4NE)(object)j5Y1.Default;
			}
			while ((object)j5Y1.Default != null);
		}
		br = br;
		try
		{
			ws = ws;
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					_ = (Br2)(object)j5Y1.Default;
					_ = (o8W)(object)j5Y1.Default;
					_ = (b2H1)j5Y1.Default;
					o8W = o8W;
				}
				else
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
			}
			catch
			{
				while (true)
				{
					if (obj2 != null)
					{
						w5D = null;
						_ = (_003CModule_003E)(object)j5Y1.Default;
						be = null;
						t1P = t1P;
						continue;
					}
					goto end_IL_066f;
				}
				end_IL_066f:;
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (Tg0e)(object)j5Y1.Default;
					_ = (Ng67)(object)j5Y1.Default;
					_ = (Ta8)(object)j5Y1.Default;
				}
				finally
				{
					_ = (o8W)(object)j5Y1.Default;
					goto end_IL_069b;
				}
				end_IL_069b:;
			}
			finally
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = j5Y1.Default;
				}
				goto end_IL_069a;
			}
			end_IL_069a:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					o8W = o8W;
				}
				while (obj2 != null);
			}
			else if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (t1P)(object)j5Y1.Default;
			}
			goto IL_0722;
		}
		IL_02ab:
		try
		{
			_ = (k8NS)j5Y1.Default;
			_ = (k8NS)j5Y1.Default;
		}
		finally
		{
			w5D = (w5D)(object)j5Y1.Default;
			goto IL_02d4;
		}
		IL_02d4:
		do
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Ta8)(object)j5Y1.Default;
					_ = (Cd0n)(object)j5Y1.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Ng67)(object)j5Y1.Default;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		while (obj2 != null || (object)j5Y1.Default != null)
		{
		}
		_ = (z1J)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			_ = (w5D)(object)j5Y1.Default;
		}
		catch
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (n4NE)(object)j5Y1.Default;
					continue;
				}
				b2H = default(b2H1);
				ng = null;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
			}
			while (obj2 != null);
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				Tg0e tg0e = null;
			}
			else
			{
				_ = (b2H1)j5Y1.Default;
			}
		}
		while (obj2 != null)
		{
			_ = (Br2)(object)j5Y1.Default;
		}
		while ((object)j5Y1.Default != null)
		{
			while ((object)j5Y1.Default != null)
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Cd0n)(object)j5Y1.Default;
					_ = (z1J)(object)j5Y1.Default;
					_ = (Ja24)(object)j5Y1.Default;
				}
			}
		}
		while (true)
		{
			if (obj2 != null)
			{
				try
				{
					_ = (w5D)(object)j5Y1.Default;
				}
				catch
				{
					_ = (y9T)(object)j5Y1.Default;
				}
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		n4NE = (n4NE)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T);
		while ((object)j5Y1.Default != null)
		{
			_ = (Ja24)(object)j5Y1.Default;
			y9T = y9T;
		}
		while (obj2 != null)
		{
			while (obj2 != null)
			{
			}
		}
		try
		{
			try
			{
				ng = ng;
			}
			catch
			{
				j5Y = null;
			}
			finally
			{
				w5D = w5D;
				goto end_IL_0484;
			}
			end_IL_0484:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
				finally
				{
					ws = (Ws0)(object)j5Y1.Default;
					ws = ws;
					goto end_IL_04a7;
				}
				end_IL_04a7:;
			}
			finally
			{
				try
				{
					b2H = b2H;
				}
				finally
				{
					ng = null;
					goto IL_04e5;
				}
			}
		}
		IL_04e5:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (w5D)(object)j5Y1.Default;
			goto IL_051a;
		}
		try
		{
			_ = (Br2)(object)j5Y1.Default;
		}
		finally
		{
			w5D = w5D;
			goto IL_051a;
		}
		IL_026b:
		try
		{
			do
			{
				_ = (w5D)(object)j5Y1.Default;
			}
			while (obj2 != null);
		}
		finally
		{
			t1P = (t1P)(object)j5Y1.Default;
			_ = (Ja24)(object)j5Y1.Default;
			w5D = w5D;
			br = br;
			goto IL_02ab;
		}
		IL_01d1:
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Cd0n)(object)j5Y1.Default;
				y9T = null;
				y9T = y9T;
				_ = (Ja24)(object)j5Y1.Default;
			}
			else
			{
				Ta8 ta = ta;
				ta = ta;
			}
		}
		catch
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (n4NE)(object)j5Y1.Default;
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
		}
		finally
		{
			_ = (Ws0)(object)j5Y1.Default;
			_ = (t1P)(object)j5Y1.Default;
			_ = (Cd0n)(object)j5Y1.Default;
			_ = (c0B)(object)j5Y1.Default;
			goto IL_026b;
		}
		IL_051a:
		try
		{
			while (obj2 != null)
			{
				_ = (Be5)(object)j5Y1.Default;
			}
		}
		finally
		{
			while (obj2 != null)
			{
				try
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				catch
				{
					_ = (y9T)(object)j5Y1.Default;
				}
			}
			goto IL_0558;
		}
		IL_0722:
		do
		{
			t1P = t1P;
		}
		while (obj2 != null);
		_ = (_003CModule_003E)(object)j5Y1.Default;
		be = be;
		try
		{
			do
			{
				ma = ma;
			}
			while (obj2 != null);
		}
		catch
		{
			try
			{
				while (obj2 != null)
				{
					ja = null;
				}
			}
			catch
			{
				try
				{
					n4NE = n4NE;
					Gw13 gw = gw;
					gw = gw;
					br = br;
					goto end_IL_0765;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					y9T = (y9T)(object)j5Y1.Default;
					goto end_IL_0765;
				}
				end_IL_0765:;
			}
		}
		num = default(UIntPtr);
		checked
		{
			if (num + num - unchecked((nuint)(UIntPtr)j5Y1.Default) * num == 0)
			{
				ng = ng;
				return;
			}
			do
			{
				br = br;
				_ = (Ma6)(object)j5Y1.Default;
				_ = (Br2)(object)j5Y1.Default;
				_ = (c0B)(object)j5Y1.Default;
			}
			while ((object)j5Y1.Default != null);
		}
	}
}
