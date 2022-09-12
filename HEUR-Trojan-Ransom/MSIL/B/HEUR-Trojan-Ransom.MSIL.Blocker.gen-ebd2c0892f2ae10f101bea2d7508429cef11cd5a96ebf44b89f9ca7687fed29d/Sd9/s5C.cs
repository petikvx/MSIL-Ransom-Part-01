using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Bm4r;
using Cr4;
using Ds3;
using Jo7k;
using Kc9;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Ti18;
using Wf0t;
using Yf06;
using Yn19;
using Yn6o;
using b3YP;
using c9S;
using i1QX;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace Sd9;

[DesignerGenerated]
public class s5C : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static Xj06 xj06_0/* Not supported: data(4B 1E 00 00 AA 05 00 00 DA D2 00 00 41 3F 00 00 37 60 00 00 11 F2 00 00 05 79 00 00 AF 3B 00 00 A8 CB 00 00 09 A7 00 00 B7 23 00 00 04 CD 00 00 BB EA 00 00 22 A0 00 00 2A 75 00 00 46 4A 00 00 25 03 00 00 04 57 00 00 E9 AB 00 00 ED 18 00 00 6D 92 00 00 7E 37 00 00 E0 E6 00 00 43 6D 00 00 ED 89 00 00 7D F2 00 00 4C 5A 00 00 AA 32 00 00 F2 4D 00 00 FF DD 00 00 B8 8C 00 00 27 85 00 00 1D 6B 00 00 F7 9B 00 00 92 D6 00 00 0C 00 00 00 E2 9F 00 00 0A EB 00 00 58 1E 00 00 A5 56 00 00 F8 D4 00 00 B4 9C 00 00 26 1F 00 00 D6 C6 00 00 47 03 00 00 F4 DB 00 00 C5 76 00 00 06 41 00 00 C5 7E 00 00 CE 86 00 00 0E B4 00 00 CE 83 00 00 2D 6A 00 00 B2 8C 00 00 8E E8 00 00 CB E6 00 00 C9 1E 00 00 96 65 00 00 53 B5 00 00 B9 6D 00 00 C5 97 00 00 5B 46 00 00 BB ED 00 00 A7 ED 00 00 51 1A 00 00 8E 9E 00 00 E6 61 00 00 C3 4E 00 00 8F C9 00 00 1D 75 00 00 63 AA 00 00 19 18 00 00 AB 38 00 00 43 55 00 00 F3 43 00 00 B8 F5 00 00 57 18 00 00 09 20 00 00 FB 69 00 00 F7 AD 00 00 B7 7B 00 00 46 19 00 00 E3 B3 00 00 22 C7 00 00 F0 29 00 00 E9 08 00 00 F9 1A 00 00 69 DE 00 00 67 B3 00 00 C5 EF 00 00 42 E1 00 00 4B 3A 00 00 B7 35 00 00 9E B0 00 00 DE BE 00 00 9D 8E 00 00 F7 AE 00 00 7D 31 00 00 84 AC 00 00 B8 64 00 00 0E 7A 00 00 01 28 00 00 75 77 00 00 A8 09 00 00 6A DC 00 00 F5 9B 00 00 23 4B 00 00 E9 14 00 00 BF 48 00 00 D5 F2 00 00 74 CE 00 00 BE FE 00 00 9A FB 00 00 5C 07 00 00 00 F2 00 00 7F 7E 00 00 76 92 00 00 98 26 00 00 B7 C3 00 00 68 11 00 00 95 83 00 00 7B 83 00 00 5B 9B 00 00 C8 D9 00 00 D9 93 00 00 18 70 00 00 61 E2 00 00 0C 88 00 00 64 96 00 00 54 B5 00 00 C0 46 00 00 D9 E6 00 00 83 73 00 00 43 05 00 00 E9 33 00 00 B5 53 00 00 CF A1 00 00 3B AA 00 00 B7 EA 00 00 FA 8D 00 00 C4 BD 00 00 0F 06 00 00 AA 95 00 00 91 C0 00 00 51 21 00 00 82 E2 00 00 AF 3E 00 00 5A 2E 00 00 9C BE 00 00 5F 40 00 00 26 FC 00 00 5E 88 00 00 C5 6D 00 00 1B 9B 00 00 21 E1 00 00 91 F6 00 00 A5 8C 00 00 AC 9D 00 00 CD 75 00 00 51 6C 00 00 92 B9 00 00 15 C3 00 00 84 7E 00 00 69 93 00 00 14 AC 00 00 99 E7 00 00 3B 8B 00 00 57 F6 00 00 71 D3 00 00 4A 9E 00 00 AF DC 00 00 39 E8 00 00 E0 3B 00 00 BC 35 00 00 A2 53 00 00 85 7D 00 00 D0 ED 00 00 C8 DA 00 00 77 B8 00 00 56 B1 00 00 68 31 00 00 06 B4 00 00 6E C9 00 00 04 56 00 00 2D B9 00 00 61 BE 00 00 14 79 00 00 66 D8 00 00 20 24 00 00 57 3D 00 00 0F C7 00 00 23 04 00 00 6E 34 00 00 65 7E 00 00 67 D4 00 00 AE FA 00 00 89 87 00 00 40 02 00 00 7C 14 00 00 B6 39 00 00 47 57 00 00 57 48 00 00 E7 5A 00 00 52 20 00 00 AE 63 00 00 EC 13 00 00 7E 4C 00 00 08 38 00 00 79 47 00 00 9B 63 00 00 C0 08 00 00 DB B1 00 00 33 E5 00 00 76 C4 00 00 E9 3A 00 00 8C 05 00 00 A5 F9 00 00 7F 28 00 00 3B DA 00 00 B2 ED 00 00 85 6E 00 00 D3 B2 00 00 36 D2 00 00 1A 96 00 00 3A D7 00 00 8C D8 00 00 CB B3 00 00 79 BD 00 00 54 61 00 00 F3 58 00 00 FB F5 00 00 90 EB 00 00 4B C6 00 00 C0 7E 00 00 0E 5A 00 00 10 E9 00 00 1E 59 00 00 1C A9 00 00 55 F2 00 00 40 A5 00 00 E2 71 00 00 0B 41 00 00 ED 90 00 00 83 C0 00 00 96 34 00 00 33 15 00 00 EE 1E 00 00 F7 6F 00 00 7C 43 00 00 DA CE 00 00 09 01 00 00 09 5F 00 00 04 28 00 00 C9 26 00 00 30 CB 00 00 72 A4 00 00 1F 76 00 00 CC C4 00 00 16 49 00 00 21 8B 00 00 20 60 00 00 03 8F 00 00 B3 D6 00 00 84 EE 00 00 9F 6D 00 00 2F 1D 00 00 8E EB 00 00 73 66 00 00 67 6A 00 00 D8 51 00 00 6C AC 00 00 88 50 00 00 29 36 00 00 FA 34 00 00 CF 7B 00 00 79 2D 00 00 E5 21 00 00 B2 11 00 00 84 61 00 00 06 C2 00 00 9D B9 00 00 D4 43 00 00 FD 79 00 00 78 92 00 00 EA 57 00 00 F1 96 00 00 8B C3 00 00 82 9F 00 00 8E B3 00 00 9B B5 00 00 F0 72 00 00 51 94 00 00 05 60 00 00 33 67 00 00 20 45 00 00 DD E2 00 00 57 6A 00 00 67 A2 00 00 E4 52 00 00 66 17 00 00 A4 29 00 00 7A B8 00 00 8F 05 00 00 A3 F1 00 00 6E 22 00 00 7F B0 00 00 DF 28 00 00 09 F3 00 00 F9 AA 00 00 B7 9D 00 00 8D 82 00 00 6D 64 00 00 47 63 00 00 0F 87 00 00 82 D1 00 00 4C 1C 00 00 06 15 00 00 3A 44 00 00 9A 96 00 00 AD D6 00 00 A3 59 00 00 0C 4C 00 00 E3 B2 00 00 CB B4 00 00 E6 DE 00 00 1B 18 00 00 81 F0 00 00 F5 CE 00 00 D9 EF 00 00 F0 98 00 00 21 C3 00 00 7D 7F 00 00 CD BE 00 00 1D 4A 00 00 61 98 00 00 23 01 00 00 44 3E 00 00 58 88 00 00 0A 70 00 00 69 A7 00 00 11 6E 00 00 81 D0 00 00 87 F4 00 00 D7 15 00 00 0D 33 00 00 82 0E 00 00 09 31 00 00 F5 D8 00 00 AF 95 00 00 D3 28 00 00 D7 CD 00 00 1C 26 00 00 CD 0B 00 00 35 7C 00 00 C2 BD 00 00 97 DD 00 00 96 05 00 00 C3 50 00 00 BC 12 00 00 52 0A 00 00 FD BF 00 00 E9 59 00 00 30 03 00 00 08 12 00 00 94 DA 00 00 10 03 00 00 9E A5 00 00 29 19 00 00 AC EE 00 00 5F D0 00 00 06 DE 00 00 AC 8C 00 00 2F D4 00 00 30 EF 00 00 9C 68 00 00 20 89 00 00 83 57 00 00 0B 9D 00 00 BD 81 00 00 64 D0 00 00 10 E7 00 00 8C 17 00 00 45 39 00 00 05 C7 00 00 18 CB 00 00 05 9D 00 00 B0 73 00 00 98 42 00 00 5A 8C 00 00 C9 BA 00 00 8B FB 00 00 80 ED 00 00 9C 75 00 00 B7 65 00 00 6B E7 00 00 27 14 00 00 51 CD 00 00 7E E2 00 00 42 3B 00 00 FD 2F 00 00 E3 68 00 00 E0 17 00 00 47 EA 00 00 4F C5 00 00 CC 4A 00 00 2A 41 00 00 EB 51 00 00 9B 1C 00 00 99 13 00 00 A2 34 00 00 13 86 00 00 8A 68 00 00 04 CF 00 00 57 42 00 00 41 23 00 00 70 A8 00 00 A4 20 00 00 2A 3C 00 00 EF 46 00 00 8F 3D 00 00 5E 8F 00 00 06 63 00 00 CE 8C 00 00 E3 33 00 00 D2 D4 00 00 85 F0 00 00 10 17 00 00 77 6E 00 00 C5 07 00 00 74 54 00 00 CE BB 00 00 03 75 00 00 C9 61 00 00 BF 51 00 00 80 67 00 00 2F CF 00 00 44 2D 00 00 F4 73 00 00 38 7C 00 00 ED 89 00 00 19 4B 00 00 14 57 00 00 FE 2E 00 00 B7 57 00 00 B5 34 00 00 01 93 00 00 7B 1E 00 00 44 33 00 00 76 42 00 00 FA 3E 00 00 82 F3 00 00 27 91 00 00 8E 9B 00 00 B1 FD 00 00 9D A0 00 00 DC 05 00 00 10 8B 00 00 63 B6 00 00 7C F0 00 00 45 5A 00 00 1A 2A 00 00 72 E3 00 00 D6 14 00 00 23 BF 00 00 D3 78 00 00 0F 11 00 00 C1 06 00 00 45 7D 00 00 D5 DA 00 00 10 54 00 00 2C 7B 00 00 AF AC 00 00 F0 BF 00 00 01 BD 00 00 74 F2 00 00 4A 38 00 00 07 34 00 00 16 35 00 00) */;

	internal static int[] int_0;

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
			EventHandler eventHandler = Ne7;
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
			EventHandler eventHandler = Rk6;
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
			EventHandler eventHandler = De1;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				int_0[166] = (int_0[166] ^ int_0[409]) & 0xF9;
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
			EventHandler eventHandler = p5T;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGWeight")]
	internal virtual TextBox txtGWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCost")]
	internal virtual TextBox txtPCost
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("txtFGood")]
	internal virtual TextBox txtFGood
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
			EventHandler eventHandler = r1L;
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFinishGoodCode")]
	internal virtual TextBox txtFinishGoodCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public s5C()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Lo0);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		c0D();
	}

	[DebuggerNonUserCode]
	protected override void Rf1(bool Sf8)
	{
		int[] array = int_0;
		try
		{
			int num = 1;
			while (true)
			{
				IL_0069:
				if (!Sf8)
				{
					num = 3;
					break;
				}
				num = 6;
				while (components != null)
				{
					num = 4;
					while (true)
					{
						components.Dispose();
						while (true)
						{
							switch (array[255])
							{
							case 42093:
								break;
							case 42095:
								goto end_IL_0012;
							case 42097:
								goto end_IL_0048;
							default:
								goto IL_0069;
							case 42094:
								goto end_IL_0069;
							case 42091:
							case 42098:
								return;
							}
							continue;
							end_IL_0012:
							break;
						}
						continue;
						end_IL_0048:
						break;
					}
				}
				break;
				continue;
				end_IL_0069:
				break;
			}
			num = 7;
		}
		finally
		{
			((Form)this).Dispose(Sf8);
		}
	}

	[DebuggerStepThrough]
	private void c0D()
	{
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected O, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		char[] char_ = o1W.char_0;
		int num = 5;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 66;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 61;
				while (true)
				{
					txtPId = new TextBox();
					txtGWeight = new TextBox();
					txtPCost = new TextBox();
					num = 15;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 63;
						while (true)
						{
							Label5 = new Label();
							txtFGood = new TextBox();
							btnSave = new Button();
							num = 50;
							while (true)
							{
								Label8 = new Label();
								txtFinishGoodCode = new TextBox();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 70;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 35;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(326, 21));
										num = 33;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											while (true)
											{
												((Control)Label3).set_Size(new Size(125, 17));
												num = 40;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Processing Cost");
													num = 39;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 16;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 32;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(735, 21));
																num = 4;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 7;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(14);
																		Label6.set_Text("X");
																		num = 12;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = 67;
																			while (true)
																			{
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 72;
																				while (true)
																				{
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(43, 21));
																					num = 29;
																					while (true)
																					{
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 60;
																						while (true)
																						{
																							((Control)Label7).set_TabIndex(13);
																							Label7.set_Text("Go To Main");
																							num = 0;
																							while (true)
																							{
																								((Control)btnDelete).set_Location(new Point(404, 183));
																								((Control)btnDelete).set_Name("btnDelete");
																								num = 73;
																								while (true)
																								{
																									((Control)btnDelete).set_Size(new Size(75, 31));
																									((Control)btnDelete).set_TabIndex(7);
																									num = 55;
																									while (true)
																									{
																										((ButtonBase)btnDelete).set_Text("DELETE");
																										((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																										num = 54;
																										while (true)
																										{
																											((Control)btnModify).set_Location(new Point(404, 132));
																											((Control)btnModify).set_Name("btnModify");
																											num = 24;
																											while (true)
																											{
																												((Control)btnModify).set_Size(new Size(75, 31));
																												((Control)btnModify).set_TabIndex(6);
																												num = 74;
																												while (true)
																												{
																													((ButtonBase)btnModify).set_Text("MODIFY");
																													((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																													num = 42;
																													while (true)
																													{
																														DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																														((Control)DataGridView1).set_Location(new Point(87, 232));
																														num = 65;
																														while (true)
																														{
																															((Control)DataGridView1).set_Name("DataGridView1");
																															((Control)DataGridView1).set_Size(new Size(599, 206));
																															num = 51;
																															while (true)
																															{
																																((Control)DataGridView1).set_TabIndex(25);
																																((Control)txtPId).set_Location(new Point(229, 195));
																																num = 48;
																																while (true)
																																{
																																	((Control)txtPId).set_Name("txtPId");
																																	((Control)txtPId).set_Size(new Size(100, 20));
																																	num = 75;
																																	while (true)
																																	{
																																		((Control)txtPId).set_TabIndex(4);
																																		((Control)txtGWeight).set_Location(new Point(229, 162));
																																		num = 17;
																																		while (true)
																																		{
																																			((Control)txtGWeight).set_Name("txtGWeight");
																																			((Control)txtGWeight).set_Size(new Size(100, 20));
																																			num = 64;
																																			while (true)
																																			{
																																				((Control)txtGWeight).set_TabIndex(3);
																																				((Control)txtPCost).set_Location(new Point(229, 135));
																																				num = 38;
																																				while (true)
																																				{
																																					((Control)txtPCost).set_Name("txtPCost");
																																					((Control)txtPCost).set_Size(new Size(100, 20));
																																					num = 68;
																																					while (true)
																																					{
																																						((Control)txtPCost).set_TabIndex(2);
																																						Label4.set_AutoSize(true);
																																						num = 22;
																																						while (true)
																																						{
																																							((Control)Label4).set_ForeColor(Color.White);
																																							((Control)Label4).set_Location(new Point(108, 169));
																																							num = 36;
																																							while (true)
																																							{
																																								((Control)Label4).set_Name("Label4");
																																								((Control)Label4).set_Size(new Size(106, 13));
																																								num = 19;
																																								while (true)
																																								{
																																									((Control)Label4).set_TabIndex(21);
																																									Label4.set_Text("Finish Good Weight :");
																																									num = 57;
																																									while (true)
																																									{
																																										Label1.set_AutoSize(true);
																																										((Control)Label1).set_ForeColor(Color.White);
																																										switch (char_[132])
																																										{
																																										case 'ꈴ':
																																											break;
																																										case 'ꈎ':
																																											goto end_IL_000d;
																																										case 'ꈟ':
																																											goto end_IL_0172;
																																										case 'ꈑ':
																																											goto end_IL_0197;
																																										case 'ꈿ':
																																											goto end_IL_01c0;
																																										case 'ꈡ':
																																											goto end_IL_01ec;
																																										case 'ꈻ':
																																											goto end_IL_0209;
																																										case 'ꈌ':
																																											goto end_IL_0232;
																																										case 'ꉆ':
																																											goto end_IL_025d;
																																										case 'ꈫ':
																																											goto end_IL_0286;
																																										case 'ꈮ':
																																											goto end_IL_02b1;
																																										case 'ꈼ':
																																											goto end_IL_02da;
																																										case 'ꈥ':
																																											goto end_IL_0306;
																																										case 'ꉅ':
																																											goto end_IL_0335;
																																										case 'ꇽ':
																																										case 'ꈓ':
																																											goto end_IL_035d;
																																										case 'ꈱ':
																																											goto end_IL_037e;
																																										case 'ꈲ':
																																											goto end_IL_03a3;
																																										case 'ꉄ':
																																											goto end_IL_03d2;
																																										case 'ꇻ':
																																											goto end_IL_03f3;
																																										case 'ꈷ':
																																											goto end_IL_0418;
																																										case 'ꈘ':
																																											goto end_IL_0447;
																																										case 'ꉃ':
																																											goto end_IL_0468;
																																										case 'ꈾ':
																																											goto end_IL_0491;
																																										case 'ꈇ':
																																										case 'ꈩ':
																																											goto end_IL_04ba;
																																										case 'ꈂ':
																																											goto end_IL_04dc;
																																										case 'ꇿ':
																																											goto end_IL_04fd;
																																										case 'ꈛ':
																																											goto end_IL_051f;
																																										case 'ꈋ':
																																											goto end_IL_0547;
																																										case 'ꈢ':
																																											goto end_IL_0572;
																																										case 'ꈣ':
																																											goto end_IL_0594;
																																										case 'ꈤ':
																																											goto end_IL_05b5;
																																										case 'ꈜ':
																																											goto end_IL_05d7;
																																										case 'ꈞ':
																																											goto end_IL_05f0;
																																										case 'ꉁ':
																																											goto end_IL_0602;
																																										case 'ꈭ':
																																											goto end_IL_062e;
																																										case 'ꈺ':
																																											goto end_IL_0662;
																																										case 'ꈊ':
																																											goto end_IL_0688;
																																										case 'ꈸ':
																																											goto end_IL_06ae;
																																										case 'ꈽ':
																																											goto end_IL_06d4;
																																										default:
																																											goto end_IL_06fa;
																																										case 'ꈄ':
																																											((Control)Label1).set_Location(new Point(104, 108));
																																											((Control)Label1).set_Name("Label1");
																																											num = 44;
																																											goto case 'ꈧ';
																																										case 'ꈧ':
																																											((Control)Label1).set_Size(new Size(110, 13));
																																											((Control)Label1).set_TabIndex(20);
																																											num = 56;
																																											goto case 'ꈳ';
																																										case 'ꈳ':
																																											Label1.set_Text("Finish Process Good :");
																																											Label2.set_AutoSize(true);
																																											num = 21;
																																											goto case 'ꈐ';
																																										case 'ꈐ':
																																											((Control)Label2).set_ForeColor(Color.White);
																																											((Control)Label2).set_Location(new Point(151, 202));
																																											num = 6;
																																											goto case 'ꈁ';
																																										case 'ꈁ':
																																											((Control)Label2).set_Name("Label2");
																																											((Control)Label2).set_Size(new Size(63, 13));
																																											num = 25;
																																											goto case 'ꈔ';
																																										case 'ꈔ':
																																											((Control)Label2).set_TabIndex(19);
																																											Label2.set_Text("Process Id :");
																																											num = 28;
																																											goto case 'ꈗ';
																																										case 'ꈗ':
																																											Label5.set_AutoSize(true);
																																											((Control)Label5).set_ForeColor(Color.White);
																																											num = 47;
																																											goto case 'ꈪ';
																																										case 'ꈪ':
																																											((Control)Label5).set_Location(new Point(139, 138));
																																											((Control)Label5).set_Name("Label5");
																																											num = 69;
																																											goto case 'ꉀ';
																																										case 'ꉀ':
																																											((Control)Label5).set_Size(new Size(75, 13));
																																											((Control)Label5).set_TabIndex(18);
																																											num = 1;
																																											goto case 'ꇼ';
																																										case 'ꇼ':
																																											Label5.set_Text("Process Cost :");
																																											((Control)txtFGood).set_Location(new Point(229, 105));
																																											num = 58;
																																											goto case 'ꈵ';
																																										case 'ꈵ':
																																											((Control)txtFGood).set_Name("txtFGood");
																																											((Control)txtFGood).set_Size(new Size(100, 20));
																																											num = 18;
																																											goto case 'ꈍ';
																																										case 'ꈍ':
																																											((Control)txtFGood).set_TabIndex(1);
																																											((Control)btnSave).set_Location(new Point(404, 72));
																																											num = 71;
																																											goto case 'ꉂ';
																																										case 'ꉂ':
																																											((Control)btnSave).set_Name("btnSave");
																																											((Control)btnSave).set_Size(new Size(75, 31));
																																											num = 26;
																																											goto case 'ꈕ';
																																										case 'ꈕ':
																																											((Control)btnSave).set_TabIndex(5);
																																											((ButtonBase)btnSave).set_Text("SAVE");
																																											num = 3;
																																											goto case 'ꇾ';
																																										case 'ꇾ':
																																											((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																											Label8.set_AutoSize(true);
																																											num = 31;
																																											goto case 'ꈚ';
																																										case 'ꈚ':
																																											((Control)Label8).set_ForeColor(Color.White);
																																											((Control)Label8).set_Location(new Point(117, 75));
																																											num = 53;
																																											goto case 'ꈰ';
																																										case 'ꈰ':
																																											((Control)Label8).set_Name("Label8");
																																											((Control)Label8).set_Size(new Size(97, 13));
																																											num = 49;
																																											goto case 'ꈬ';
																																										case 'ꈬ':
																																											((Control)Label8).set_TabIndex(29);
																																											Label8.set_Text("Finish Good Code :");
																																											num = 62;
																																											goto case 'ꈹ';
																																										case 'ꈹ':
																																											((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
																																											((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
																																											num = 20;
																																											goto case 'ꈏ';
																																										case 'ꈏ':
																																											((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
																																											((Control)txtFinishGoodCode).set_TabIndex(0);
																																											num = 45;
																																											goto case 'ꈨ';
																																										case 'ꈨ':
																																											((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																											((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																											num = 27;
																																											goto case 'ꈖ';
																																										case 'ꈖ':
																																											((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																											((Form)this).set_ClientSize(new Size(800, 450));
																																											num = 10;
																																											goto case 'ꈅ';
																																										case 'ꈅ':
																																											((Control)this).get_Controls().Add((Control)(object)Label8);
																																											((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
																																											num = 59;
																																											goto case 'ꈶ';
																																										case 'ꈶ':
																																											((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																											((Control)this).get_Controls().Add((Control)(object)btnModify);
																																											num = 34;
																																											goto case 'ꈝ';
																																										case 'ꈝ':
																																											((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																											((Control)this).get_Controls().Add((Control)(object)txtPId);
																																											num = 23;
																																											goto case 'ꈒ';
																																										case 'ꈒ':
																																											((Control)this).get_Controls().Add((Control)(object)txtGWeight);
																																											((Control)this).get_Controls().Add((Control)(object)txtPCost);
																																											num = 30;
																																											goto case 'ꈙ';
																																										case 'ꈙ':
																																											((Control)this).get_Controls().Add((Control)(object)Label4);
																																											((Control)this).get_Controls().Add((Control)(object)Label1);
																																											num = 13;
																																											goto case 'ꈈ';
																																										case 'ꈈ':
																																											((Control)this).get_Controls().Add((Control)(object)Label2);
																																											((Control)this).get_Controls().Add((Control)(object)Label5);
																																											num = 43;
																																											goto case 'ꈦ';
																																										case 'ꈦ':
																																											((Control)this).get_Controls().Add((Control)(object)txtFGood);
																																											((Control)this).get_Controls().Add((Control)(object)btnSave);
																																											num = 8;
																																											goto case 'ꈃ';
																																										case 'ꈃ':
																																											((Control)this).get_Controls().Add((Control)(object)Label6);
																																											((Control)this).get_Controls().Add((Control)(object)Label7);
																																											num = 37;
																																											goto case 'ꈠ';
																																										case 'ꈠ':
																																											((Control)this).get_Controls().Add((Control)(object)Label3);
																																											((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																											num = 14;
																																											goto case 'ꈉ';
																																										case 'ꈉ':
																																											((Control)this).set_Name("frmProcessingCost");
																																											((Form)this).set_StartPosition((FormStartPosition)1);
																																											((Form)this).set_Text("frmProcessingCost");
																																											num = 52;
																																											goto case 'ꈯ';
																																										case 'ꈯ':
																																											((ISupportInitialize)DataGridView1).EndInit();
																																											((Control)this).ResumeLayout(false);
																																											((Control)this).PerformLayout();
																																											num = 11;
																																											goto case 'ꈆ';
																																										case 'ꈆ':
																																											o1W.char_0[289] = (char)(o1W.char_0[289] & int_0[361] & '\u008d');
																																											return;
																																										}
																																										continue;
																																										end_IL_000d:
																																										break;
																																									}
																																									continue;
																																									end_IL_0172:
																																									break;
																																								}
																																								continue;
																																								end_IL_0197:
																																								break;
																																							}
																																							continue;
																																							end_IL_01c0:
																																							break;
																																						}
																																						continue;
																																						end_IL_01ec:
																																						break;
																																					}
																																					continue;
																																					end_IL_0209:
																																					break;
																																				}
																																				continue;
																																				end_IL_0232:
																																				break;
																																			}
																																			continue;
																																			end_IL_025d:
																																			break;
																																		}
																																		continue;
																																		end_IL_0286:
																																		break;
																																	}
																																	continue;
																																	end_IL_02b1:
																																	break;
																																}
																																continue;
																																end_IL_02da:
																																break;
																															}
																															continue;
																															end_IL_0306:
																															break;
																														}
																														continue;
																														end_IL_0335:
																														break;
																													}
																													continue;
																													end_IL_035d:
																													break;
																												}
																												continue;
																												end_IL_037e:
																												break;
																											}
																											continue;
																											end_IL_03a3:
																											break;
																										}
																										continue;
																										end_IL_03d2:
																										break;
																									}
																									continue;
																									end_IL_03f3:
																									break;
																								}
																								continue;
																								end_IL_0418:
																								break;
																							}
																							continue;
																							end_IL_0447:
																							break;
																						}
																						continue;
																						end_IL_0468:
																						break;
																					}
																					continue;
																					end_IL_0491:
																					break;
																				}
																				continue;
																				end_IL_04ba:
																				break;
																			}
																			continue;
																			end_IL_04dc:
																			break;
																		}
																		continue;
																		end_IL_04fd:
																		break;
																	}
																	continue;
																	end_IL_051f:
																	break;
																}
																continue;
																end_IL_0547:
																break;
															}
															continue;
															end_IL_0572:
															break;
														}
														continue;
														end_IL_0594:
														break;
													}
													continue;
													end_IL_05b5:
													break;
												}
												continue;
												end_IL_05d7:
												break;
											}
											continue;
											end_IL_05f0:
											break;
										}
										continue;
										end_IL_0602:
										break;
									}
									continue;
									end_IL_062e:
									break;
								}
								continue;
								end_IL_0662:
								break;
							}
							continue;
							end_IL_0688:
							break;
						}
						continue;
						end_IL_06ae:
						break;
					}
					continue;
					end_IL_06d4:
					break;
				}
				continue;
				end_IL_06fa:
				break;
			}
		}
	}

	private void Rk6(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void Ne7(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void r1L(object sender, EventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_cost values(" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())) + ",'" + txtFGood.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtGWeight.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ")");
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
		Eo1();
	}

	public void Eo1()
	{
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_cost");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Finish Good Code");
			DataGridView1.get_Columns().Add("c2", "Finish Good");
			DataGridView1.get_Columns().Add("c3", "Processing Cost");
			DataGridView1.get_Columns().Add("c4", "Finish Good Weight");
			DataGridView1.get_Columns().Add("c5", "Processing Id");
			while (true)
			{
				bool num = rd.Read();
				int_0[301] = (int_0[301] | int_0[205]) & 0x88;
				if (num)
				{
					DataGridView1.get_Rows().Add(new object[5]
					{
						rd.get_Item("finishgoodcode").ToString(),
						rd.get_Item("finishgood"),
						rd.get_Item("procost").ToString(),
						rd.get_Item("finishgoodweight").ToString(),
						rd.get_Item("proid").ToString()
					});
					continue;
				}
				break;
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

	internal static bool Qr3(int Po8)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Po8 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				Po8 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				Po8 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				Po8 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) == 0 && Operators.CompareString(text, "l", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void Lo0(object sender, EventArgs e)
	{
		Eo1();
	}

	private void p5T(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_cost set finishgood ='" + txtFGood.get_Text() + "',procost=" + txtPCost.get_Text() + ",finishgoodweight=" + txtGWeight.get_Text() + " where finishgoodcode=" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())));
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
		Eo1();
		o1W.char_0[85] = (char)((o1W.char_0[85] - o1W.char_0[429]) & 'W');
	}

	private void De1(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_cost where finishgoodcode=" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())));
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
		Eo1();
	}

	internal static byte[] y7R(int j8A, int At6)
	{
		if (j8A <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[At6 + 1];
			for (int i = 0; i <= At6; i++)
			{
				int num = j8A * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return c7G.t5R(array, At6);
		}
	}

	static void o7Q()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		while (true)
		{
			obj = obj;
			if (obj != null)
			{
				num = (UIntPtr)Ns87.Default;
				if (num == 0)
				{
					_ = (o1W)(object)Ns87.Default;
				}
				continue;
			}
			break;
		}
		while (obj != null)
		{
			_ = (q1C3)(object)Ns87.Default;
		}
		_ = (c7G)(object)Ns87.Default;
		Es6d es6d = null;
		es6d = es6d;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		a1HS a1HS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ea3q ea3q);
		checked
		{
			try
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) - (num - unchecked((nuint)(UIntPtr)Ns87.Default / (nuint)(UIntPtr)Ns87.Default)) == 0)
					{
						s5C s5C2 = null;
						s5C2 = s5C2;
					}
					else
					{
						Ea3q obj2 = (Ea3q)(object)Ns87.Default;
						ea3q = (Ea3q)(object)Ns87.Default;
						ea3q = obj2;
						_ = (Cr17)(object)Ns87.Default;
					}
				}
				finally
				{
					_ = (o1W)(object)Ns87.Default;
					goto end_IL_005b;
				}
				end_IL_005b:;
			}
			catch
			{
			}
			a1HS = null;
			a1HS = null;
			ty = ty;
			ty = null;
			_ = (k2GS)(object)Ns87.Default;
			_ = (Cy1)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			g6EQ = g6EQ;
			g6EQ = g6EQ;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (num / (nuint)(UIntPtr)Ns87.Default == 0)
		{
			try
			{
				_ = (Sa53)Ns87.Default;
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				if (num == 0)
				{
					_003CModule_003E = _003CModule_003E;
					_ = (o1W)(object)Ns87.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				q1J = q1J;
				q1J = q1J;
			}
			else
			{
				while (obj != null)
				{
					_ = Ns87.Default;
				}
			}
		}
		if (num == 0)
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Sd5)(object)Ns87.Default;
				}
				while ((object)Ns87.Default != null);
			}
			else
			{
				try
				{
					_ = (o1W)(object)Ns87.Default;
				}
				catch
				{
					a1HS = a1HS;
				}
			}
		}
		else
		{
			_ = (q1C3)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq90 xq);
		try
		{
			do
			{
				xq = null;
				xq = xq;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				_ = (_003CModule_003E)(object)Ns87.Default;
			}
			finally
			{
				_ = (Es6d)(object)Ns87.Default;
				_ = (Xq90)(object)Ns87.Default;
				_ = (k2GS)(object)Ns87.Default;
				goto end_IL_0228;
			}
			end_IL_0228:;
		}
		finally
		{
			q1C3 q1C = q1C;
			q1C = q1C;
			goto IL_026f;
		}
		IL_03c2:
		do
		{
			try
			{
				_ = (Ty3)(object)Ns87.Default;
			}
			catch
			{
				_ = (Sa53)Ns87.Default;
				_ = (Sa53)Ns87.Default;
			}
		}
		while ((object)Ns87.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					a1HS = a1HS;
				}
				else
				{
					_ = (f1D8)(object)Ns87.Default;
				}
			}
			else
			{
				while (obj != null)
				{
					q1J = q1J;
					sd = null;
					ea3q = ea3q;
				}
			}
		}
		try
		{
			try
			{
				_ = (g6EQ)(object)Ns87.Default;
			}
			finally
			{
				ea3q = ea3q;
				goto end_IL_044c;
			}
			end_IL_044c:;
		}
		finally
		{
			g6EQ = g6EQ;
			goto IL_0470;
		}
		IL_02b9:
		while (obj != null)
		{
			do
			{
				try
				{
					g6EQ = g6EQ;
				}
				catch
				{
					_ = (k2GS)(object)Ns87.Default;
				}
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (c7G)(object)Ns87.Default;
			_ = (c7G)(object)Ns87.Default;
		}
		while (obj != null)
		{
			sd = (Sd5)(object)Ns87.Default;
		}
		while (obj != null)
		{
		}
		if (num == 0)
		{
			try
			{
				while (obj != null)
				{
					q1J = null;
				}
			}
			finally
			{
				goto IL_0346;
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (c7G)(object)Ns87.Default;
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			_ = (q4PG)(object)Ns87.Default;
		}
		goto IL_0346;
		IL_04f5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj06 xj);
		do
		{
			try
			{
				xj = xj;
			}
			catch
			{
				_ = Ns87.Default;
			}
			finally
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (f1D8)(object)Ns87.Default;
				}
				continue;
			}
		}
		while (obj != null);
		if (num == (UIntPtr)(nuint)0u && checked(unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default))) == 0)
		{
			while (obj != null)
			{
				_ = (Cr17)(object)Ns87.Default;
			}
		}
		try
		{
			_ = (g6EQ)(object)Ns87.Default;
			_ = (Cr17)(object)Ns87.Default;
			return;
		}
		catch
		{
			while (obj != null)
			{
			}
			return;
		}
		IL_0346:
		checked
		{
			try
			{
				nuint num2 = num - num;
				num = default(UIntPtr);
				if (num2 * num == 0)
				{
					try
					{
						_ = (Xq90)(object)Ns87.Default;
					}
					catch
					{
						_ = (Sa53)Ns87.Default;
					}
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default) + num == 0)
				{
					do
					{
						sd = sd;
					}
					while (obj != null);
				}
				else if (unchecked((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u))
				{
					_ = (a1HS)(object)Ns87.Default;
				}
				else
				{
					es6d = es6d;
				}
				goto IL_03c2;
			}
		}
		IL_026f:
		try
		{
			_ = (q1C3)(object)Ns87.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (f1D8)(object)Ns87.Default;
			}
			goto IL_02b9;
		}
		IL_0470:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Ea3q)(object)Ns87.Default;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			q1J = null;
		}
		k2GS k2GS = k2GS;
		k2GS = k2GS;
		try
		{
			_ = (Cy1)(object)Ns87.Default;
		}
		finally
		{
			while (obj != null)
			{
				xq = xq;
				Cr17 cr = (Cr17)(object)Ns87.Default;
				cr = cr;
				ty = ty;
				_ = (Ea3q)(object)Ns87.Default;
			}
			goto IL_04f5;
		}
	}

	static void Zb8()
	{
		UIntPtr uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (c7G)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			_ = (Cr17)(object)Ns87.Default;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Xj06)Ns87.Default;
			}
			obj = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
		try
		{
			try
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
			catch
			{
				try
				{
					_ = (c7G)(object)Ns87.Default;
				}
				finally
				{
					_ = (Sa53)Ns87.Default;
					_ = (Xq90)(object)Ns87.Default;
					goto end_IL_0059;
				}
				end_IL_0059:;
			}
		}
		catch
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					es6d = null;
					es6d = es6d;
				}
				else
				{
					_ = (Sd5)(object)Ns87.Default;
				}
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Ty3)(object)Ns87.Default;
				}
			}
		}
		q4PG q4PG = null;
		q4PG = null;
		_ = (Xj06)Ns87.Default;
		_ = (k2GS)(object)Ns87.Default;
		_ = (Sd5)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ns87 ns);
		try
		{
			ns = Ns87.Default;
			ns = null;
		}
		catch
		{
			_ = Ns87.Default;
		}
		while (obj != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq90 xq);
		try
		{
			while ((object)Ns87.Default != null)
			{
				do
				{
					xq = xq;
					xq = null;
				}
				while (obj != null);
			}
		}
		finally
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (c7G)(object)Ns87.Default;
				}
			}
			goto IL_0151;
		}
		IL_01b5:
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (k2GS)(object)Ns87.Default;
					s5C s5C2 = null;
					s5C2 = s5C2;
				}
			}
			catch
			{
				try
				{
					_ = (Sa53)Ns87.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Ns87.Default;
					goto end_IL_01da;
				}
				end_IL_01da:;
			}
		}
		catch
		{
		}
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		catch
		{
			UIntPtr num = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num) * uIntPtr * uIntPtr) / checked(unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				_ = (a1HS)(object)Ns87.Default;
				_ = (a1HS)(object)Ns87.Default;
				_ = (Ty3)(object)Ns87.Default;
				_ = (Ty3)(object)Ns87.Default;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (k2GS)(object)Ns87.Default;
			}
		}
		Cy1 cy = (Cy1)(object)Ns87.Default;
		cy = cy;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr17 cr);
		do
		{
			try
			{
				_ = (f1D8)(object)Ns87.Default;
				_ = Ns87.Default;
				cr = cr;
				cr = cr;
				_ = (f1D8)(object)Ns87.Default;
			}
			finally
			{
				while (obj != null)
				{
				}
				continue;
			}
		}
		while ((object)Ns87.Default != null);
		do
		{
			if ((UIntPtr)Ns87.Default != (UIntPtr)(nuint)0u)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
			else
			{
				cr = null;
			}
		}
		while ((object)Ns87.Default != null);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					cr = cr;
				}
				else
				{
					_ = Ns87.Default;
				}
			}
		}
		while (obj != null);
		_ = (Es6d)(object)Ns87.Default;
		_ = (a1HS)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		try
		{
			try
			{
				_ = (a1HS)(object)Ns87.Default;
				k2GS = k2GS;
				k2GS = k2GS;
			}
			finally
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c7G)(object)Ns87.Default;
				}
				else
				{
					es6d = es6d;
				}
				goto end_IL_0384;
			}
			end_IL_0384:;
		}
		catch
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = Ns87.Default;
				}
				else
				{
					sa = sa;
					sa = default(Sa53);
					sa = sa;
				}
			}
			finally
			{
				_ = (Sa53)Ns87.Default;
				goto end_IL_03c7;
			}
			end_IL_03c7:;
		}
		xq = (Xq90)(object)Ns87.Default;
		try
		{
		}
		finally
		{
			goto IL_0418;
		}
		IL_0676:
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (k2GS)(object)Ns87.Default;
				}
				finally
				{
					q4PG = q4PG;
					continue;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
			}
		}
		try
		{
			try
			{
				es6d = es6d;
				_ = (f1D8)(object)Ns87.Default;
				q4PG = q4PG;
				_ = (c7G)(object)Ns87.Default;
			}
			catch
			{
				try
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				catch
				{
					_ = (q1J3)(object)Ns87.Default;
					cy = cy;
				}
			}
		}
		catch
		{
			_ = (Ty3)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		if (uIntPtr == 0)
		{
			while ((object)Ns87.Default != null)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					cr = null;
				}
				else
				{
					q1J = q1J;
				}
			}
		}
		else if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
		{
			if ((nuint)(UIntPtr)Ns87.Default / checked(unchecked((nuint)(UIntPtr)Ns87.Default) * unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
			{
				cy = cy;
			}
			else
			{
				_ = (k2GS)(object)Ns87.Default;
			}
		}
		else
		{
			ty = ty;
			ty = ty;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Ns87.Default != null)
				{
					ty = ty;
				}
			}
			catch
			{
				do
				{
					_ = (q4PG)(object)Ns87.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Cr17)(object)Ns87.Default;
				}
			}
			else if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ty3)(object)Ns87.Default;
				_ = (Es6d)(object)Ns87.Default;
				sa = sa;
				_ = (a1HS)(object)Ns87.Default;
			}
		}
		_ = Ns87.Default;
		return;
		IL_0151:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (c7G)(object)Ns87.Default;
				}
				finally
				{
					_ = (q1C3)(object)Ns87.Default;
					goto end_IL_015d;
				}
				end_IL_015d:;
			}
			finally
			{
				_ = (Cr17)(object)Ns87.Default;
				_ = (o1W)(object)Ns87.Default;
				_ = (k2GS)(object)Ns87.Default;
				_ = (q1J3)(object)Ns87.Default;
				goto IL_01b5;
			}
		}
		q1C3 q1C = q1C;
		q1C = null;
		goto IL_01b5;
		IL_0418:
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Sa53)Ns87.Default;
					}
					else
					{
						q1J = (q1J3)(object)Ns87.Default;
						q1J = q1J;
						o1W o1W = (o1W)(object)Ns87.Default;
					}
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out o1W o1W);
					try
					{
						o1W = o1W;
					}
					catch
					{
						o1W = o1W;
						ns = ns;
						_ = (c7G)(object)Ns87.Default;
					}
				}
			}
			else
			{
				try
				{
					sa = (Sa53)Ns87.Default;
				}
				catch
				{
					q1C = (q1C3)(object)Ns87.Default;
					_ = (s5C)(object)Ns87.Default;
					_ = (q1J3)(object)Ns87.Default;
					es6d = es6d;
				}
			}
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				finally
				{
					_ = (f1D8)(object)Ns87.Default;
					_ = (Xj06)Ns87.Default;
					continue;
				}
			}
			while ((object)Ns87.Default != null);
		}
		else
		{
			UIntPtr num2 = (UIntPtr)Ns87.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num2) + uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						_ = (Ea3q)(object)Ns87.Default;
					}
					else
					{
						_ = (Xq90)(object)Ns87.Default;
					}
				}
				else
				{
					xq = xq;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1D8 f1D);
		while ((object)Ns87.Default != null)
		{
			try
			{
				try
				{
					f1D = f1D;
					f1D = f1D;
				}
				catch
				{
					k2GS = k2GS;
				}
			}
			catch
			{
				try
				{
					_ = (Cy1)(object)Ns87.Default;
				}
				finally
				{
					_ = (c7G)(object)Ns87.Default;
					goto end_IL_05a2;
				}
				end_IL_05a2:;
			}
		}
		do
		{
			_ = (_003CModule_003E)(object)Ns87.Default;
		}
		while (obj != null);
		try
		{
			nuint num3 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num3 / uIntPtr == 0)
			{
				_ = (Ea3q)(object)Ns87.Default;
				_ = (Ty3)(object)Ns87.Default;
				sa = sa;
			}
			else
			{
				_ = (o1W)(object)Ns87.Default;
				q4PG = null;
				Xj06 xj = default(Xj06);
				xj = default(Xj06);
			}
		}
		catch
		{
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
			}
			finally
			{
				Ea3q ea3q = ea3q;
				ea3q = ea3q;
				goto end_IL_0648;
			}
			end_IL_0648:;
		}
		finally
		{
			_ = (f1D8)(object)Ns87.Default;
			goto IL_0676;
		}
	}

	static void Yt7()
	{
		object obj2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		do
		{
			try
			{
				_ = (Sa53)Ns87.Default;
			}
			catch
			{
				_ = (q1J3)(object)Ns87.Default;
			}
			finally
			{
				uIntPtr = uIntPtr;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				goto IL_003a;
			}
			IL_003a:
			obj2 = Ns87.Default;
		}
		while (obj2 != null);
		_ = (s5C)(object)Ns87.Default;
		while (obj2 != null)
		{
			while ((object)Ns87.Default != null)
			{
				_ = (Sa53)Ns87.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj06 xj);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (q4PG)(object)Ns87.Default;
					xj = xj;
					xj = xj;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				nuint num = checked(uIntPtr * uIntPtr);
				UIntPtr num2 = (UIntPtr)Ns87.Default;
				UIntPtr num3 = (UIntPtr)Ns87.Default;
				uIntPtr = default(UIntPtr);
				if (num / ((nuint)num2 / checked(unchecked((nuint)num3) * uIntPtr)) == 0)
				{
					Ns87 ns = Ns87.Default;
					ns = ns;
					g6EQ = (g6EQ)(object)Ns87.Default;
					g6EQ = null;
				}
				else
				{
					_ = (Es6d)(object)Ns87.Default;
				}
			}
		}
		else
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = Ns87.Default;
				}
				finally
				{
					Cr17 cr = null;
					cr = cr;
					goto IL_0175;
				}
			}
			while (obj2 != null)
			{
				_ = (Ty3)(object)Ns87.Default;
			}
		}
		goto IL_0175;
		IL_078f:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
		}
		else
		{
			q1C3 q1C = null;
		}
		a1HS a1HS = a1HS;
		Es6d es6d = (Es6d)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4PG q4PG);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		try
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default)) / uIntPtr == 0)
				{
					xj = (Xj06)Ns87.Default;
				}
				else
				{
					ty = ty;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) - (uIntPtr - uIntPtr) * uIntPtr == 0)
					{
						g6EQ = (g6EQ)(object)Ns87.Default;
					}
					else
					{
						q4PG = q4PG;
					}
					goto end_IL_07cf;
				}
			}
			end_IL_07cf:;
		}
		finally
		{
			do
			{
				try
				{
					_ = (a1HS)(object)Ns87.Default;
				}
				catch
				{
					a1HS = a1HS;
				}
			}
			while (obj2 != null);
			goto IL_086d;
		}
		IL_0175:
		g6EQ = g6EQ;
		_ = (k2GS)(object)Ns87.Default;
		_ = (Sd5)(object)Ns87.Default;
		o1W o1W = o1W;
		o1W = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
		try
		{
			if (uIntPtr / uIntPtr == 0)
			{
				do
				{
					_ = (Ea3q)(object)Ns87.Default;
					sd = sd;
					sd = null;
					q4PG = q4PG;
					q4PG = q4PG;
					es6d = null;
					es6d = es6d;
				}
				while (obj2 != null);
			}
		}
		finally
		{
			while (obj2 != null)
			{
				nuint num4 = uIntPtr / checked(uIntPtr + unchecked((nuint)default(UIntPtr)));
				uIntPtr = default(UIntPtr);
				if (checked(num4 - uIntPtr) == 0)
				{
					_ = (Xj06)Ns87.Default;
					continue;
				}
				_ = (Cy1)(object)Ns87.Default;
				ty = (Ty3)(object)Ns87.Default;
				ty = null;
			}
			goto IL_0247;
		}
		IL_0749:
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		try
		{
			_ = (a1HS)(object)Ns87.Default;
			_ = (Sa53)Ns87.Default;
			_ = (Ea3q)(object)Ns87.Default;
		}
		finally
		{
			try
			{
			}
			catch
			{
				_ = (q1C3)(object)Ns87.Default;
			}
			goto IL_078f;
		}
		IL_0459:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq90 xq);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		if ((nuint)(UIntPtr)Ns87.Default / uIntPtr == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					q1C3 q1C = null;
					q1C = q1C;
					q4PG = (q4PG)(object)Ns87.Default;
				}
				while (obj2 != null);
			}
			else
			{
				xj = (Xj06)Ns87.Default;
			}
		}
		else
		{
			try
			{
				try
				{
					xq = (Xq90)(object)Ns87.Default;
					xq = xq;
				}
				catch
				{
					sa = sa;
				}
			}
			catch
			{
				try
				{
					_ = (Xj06)Ns87.Default;
				}
				finally
				{
					ty = ty;
					goto end_IL_04d4;
				}
				end_IL_04d4:;
			}
		}
		try
		{
			o1W = o1W;
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					sa = default(Sa53);
					sa = sa;
				}
				catch
				{
					_ = (Ty3)(object)Ns87.Default;
				}
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				xq = xq;
				continue;
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				sa = sa;
			}
		}
		while (obj2 != null);
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ea3q)(object)Ns87.Default;
				sd = sd;
				xj = xj;
			}
			else
			{
				_ = (Cy1)(object)Ns87.Default;
			}
		}
		catch
		{
			try
			{
				_ = (q4PG)(object)Ns87.Default;
				_ = (_003CModule_003E)(object)Ns87.Default;
			}
			catch
			{
				_ = (q4PG)(object)Ns87.Default;
				xq = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C2);
		try
		{
			_ = (s5C)(object)Ns87.Default;
			sa = default(Sa53);
			_ = (f1D8)(object)Ns87.Default;
			_ = (s5C)(object)Ns87.Default;
		}
		catch
		{
			try
			{
				while (obj2 != null)
				{
					s5C2 = s5C2;
				}
			}
			finally
			{
				try
				{
					_ = (Sd5)(object)Ns87.Default;
				}
				finally
				{
					_ = Ns87.Default;
					goto end_IL_05fc;
				}
			}
			end_IL_05fc:;
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				try
				{
					while ((object)Ns87.Default != null)
					{
						xj = xj;
						_ = (k2GS)(object)Ns87.Default;
						_ = (s5C)(object)Ns87.Default;
						_ = (f1D8)(object)Ns87.Default;
					}
				}
				finally
				{
					nuint num5 = unchecked((nuint)(UIntPtr)Ns87.Default / unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (num5 + uIntPtr == 0)
					{
						_ = Ns87.Default;
					}
					goto IL_06db;
				}
			}
		}
		while (obj2 != null)
		{
			do
			{
				_ = (Sa53)Ns87.Default;
			}
			while ((object)Ns87.Default != null);
		}
		goto IL_06db;
		IL_06db:
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					xj = (Xj06)Ns87.Default;
				}
				else
				{
					ty = (Ty3)(object)Ns87.Default;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					s5C2 = (s5C)(object)Ns87.Default;
				}
				goto IL_0749;
			}
		}
		try
		{
			try
			{
				xq = xq;
			}
			finally
			{
				q1C3 q1C = (q1C3)(object)Ns87.Default;
				goto end_IL_0721;
			}
			end_IL_0721:;
		}
		catch
		{
			es6d = es6d;
		}
		goto IL_0749;
		IL_086d:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Xj06)Ns87.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			xj = xj;
		}
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					q1C3 q1C = null;
				}
			}
			else
			{
				while (obj2 != null)
				{
					_ = (Cy1)(object)Ns87.Default;
				}
			}
		}
		else
		{
			checked
			{
				try
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				catch
				{
					if (unchecked(uIntPtr / ((nuint)(UIntPtr)Ns87.Default / (nuint)(UIntPtr)Ns87.Default)) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						Cr17 cr = (Cr17)(object)Ns87.Default;
					}
					else
					{
						_ = (Cr17)(object)Ns87.Default;
						a1HS = a1HS;
					}
				}
			}
		}
		_ = (k2GS)(object)Ns87.Default;
		return;
		IL_0247:
		nuint num6;
		checked
		{
			if (unchecked((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u))
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default) * (unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				else
				{
					try
					{
						_ = (q4PG)(object)Ns87.Default;
					}
					catch
					{
						_ = (q4PG)(object)Ns87.Default;
						k2GS k2GS = k2GS;
						k2GS = k2GS;
						a1HS = (a1HS)(object)Ns87.Default;
						a1HS = a1HS;
					}
				}
			}
			while ((object)Ns87.Default != null)
			{
				do
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr - uIntPtr != 0)
					{
						sd = null;
						continue;
					}
					g6EQ = g6EQ;
					_ = (Ea3q)(object)Ns87.Default;
					s5C2 = s5C2;
					s5C2 = s5C2;
					Sa53 obj15 = (Sa53)Ns87.Default;
					sa = sa;
					sa = obj15;
				}
				while ((object)Ns87.Default != null);
			}
			do
			{
				xj = (Xj06)Ns87.Default;
				_ = (k2GS)(object)Ns87.Default;
				a1HS = null;
			}
			while ((object)Ns87.Default != null || (object)Ns87.Default != null);
			xj = xj;
			uIntPtr = default(UIntPtr);
			num6 = unchecked((nuint)default(UIntPtr)) + uIntPtr + uIntPtr;
			uIntPtr = default(UIntPtr);
		}
		if (num6 / uIntPtr != 0 && (UIntPtr)Ns87.Default != (UIntPtr)(nuint)0u)
		{
			do
			{
				a1HS = a1HS;
			}
			while (obj2 != null);
		}
		try
		{
			do
			{
				try
				{
					_ = (f1D8)(object)Ns87.Default;
				}
				finally
				{
					xj = xj;
					_ = (_003CModule_003E)(object)Ns87.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			UIntPtr num7 = (UIntPtr)Ns87.Default;
			nuint num8 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num7) * (num8 * uIntPtr)) / (nuint)(UIntPtr)Ns87.Default == 0)
			{
				ty = ty;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
				else
				{
					_ = (Sa53)Ns87.Default;
				}
			}
			goto IL_0459;
		}
	}
}
