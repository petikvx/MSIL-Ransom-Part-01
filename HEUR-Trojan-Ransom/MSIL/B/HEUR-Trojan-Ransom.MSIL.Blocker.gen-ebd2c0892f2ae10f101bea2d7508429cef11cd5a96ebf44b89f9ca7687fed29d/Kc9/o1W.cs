using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bm4r;
using Cr4;
using Ds3;
using Jo7k;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Sd9;
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

namespace Kc9;

[DesignerGenerated]
public class o1W : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static Sa53 sa53_0/* Not supported: data(1E 97 73 2D 9F EA 88 6A C4 6D A9 95 6F 83 94 3A 8F 5F F6 13 BB C5 AF 85 4E 16 B5 29 48 A0 3B FE 1B B0 CB 61 34 67 81 E8 BC A1 60 F7 50 7C CD 1D 65 41 9C C9 6F B7 E1 72 08 CC CF 36 02 E0 1B 77 5E 3D D7 C9 97 6D 93 80 B9 F4 54 25 7E 95 28 7F 15 B5 90 2F CF 73 1F 87 7A FD 3B 1E 34 78 EF D0 EB 96 5B 64 58 4F D4 5A 7E 3E 95 F4 BA 90 BC 9F 21 B1 D2 CC 23 29 26 A4 38 DE 8E 10 8B 6E BF 28 F3 33 A0 4E 50 48 75 4C 1C BC B4 1F 82 09 C7 8A 4C CC 0A E8 6B 33 2B 72 90 83 30 F5 52 20 2A 23 68 51 7F E6 F4 DB AC 67 76 E7 2E 85 9C 38 C8 48 1D 39 D9 CD 70 CF E6 27 2F FC 56 F1 EF A0 87 A4 03 C1 0F 4B 2C 53 D9 AE E9 D5 BE 2B D2 14 37 77 D8 5A 8F C4 86 8E 72 56 29 C1 8E 1E 2C 1C EF BB 80 AC F9 05 BD 52 B7 F7 99 34 DE 06 48 41 C3 AE 03 16 87 FF 58 13 42 EE 43 50 9B E1 96 8E F5 DA 1B 47 E3 8E 27 B1 80 38 04 A2 77 71 3F 4D AA 25 AD D1 BD 64 D3 0C E6 22 A6 F6 29 E2 9D 87 8F 1A AC B1 80 13 65 7B 36 F6 98 9E 36 A9 ED 6F 24 BA C7 09 67 A4 D6 98 61 D6 66 18 8E 26 F3 26 3C 79 F9 35 90 B3 57 0F 46 32 66 6D AA E3 EB 19 09 3B B8 B8 13 2D 0A 26 DB CF 0A FA 62 1E 1B B8 D9 33 E9 77 C7 F8 95 3C C2 3C 36 66 5E 98 5C 3C E4 9D F5 1E 01 F7 B9 2E 9C FD A0 D8 DC 76 44 0D 1E AB C9 3D 95 93 EB EC 16 43 D1 D2 57 55 28 AD 01 CE 94 F9 5B 40 7D 3D 85 71 2B 83 11 A0 19 C0 63 EB 4A EC FC 64 78 5E 9D 1F F8 E9 30 EA 06 13 99 9D 33 77 72 71 50 13 63 76 F1 B4 4E 1C 67 62 DB 41 CF 1F EB 7A 11 92 74 66 75 31 04 75 06 61 91 22 9F 4B 93 6E 2C 43 DA 25 E1 5A D6 CA B9 1A E3 7E E7 36 54 43 51 11 A3 73 64 18 A5 ED 24 C1 97 53 8E 80 52 4F E2 CB 5F 61 07 42 C4 36 0F 19 46 DD F3 DD A1 FB B5 51 3F 08 FF 0D A4 59 EE B9 45 77 F5 03 E7 3B FD D3 64 7B 03 A7 2B ED B8 42 5B AC B8 56 6B 94 7B 3F 9C 71 FD 0A C2 EE 77 29 28 32 C5 B9 7A 3E E4 E5 21 E2 21 A9 A6 FF 88 E0 DA 14 83 55 E5 65 E5 47 3F 5F 20 79 79 12 E4 70 42 DD 65 89 0A 9A AE 6F 7C DC A8 19 C0 45 93 AC 62 93 9A 0C 86 1F A6 0A 9A AD 48 F7 72 A7 49 D2 2F EF 29 D2 8D 1F 78 4E 84 CF BF 73 CB D7 23 CE 4E 04 5D 5B 23 BF E1 25 1D 41 45 A5 77 E3 3A 33 3F 44 87 23 38 62 35 E8 F1 70 14 7F FA 4C 7F 18 05 74 E5 91 82 52 87 D5 9B 89 00 F5 ED 32 90 1D 0F AE 9B 93 B5 58 14 8D 93 59 00 C4 5E A1 83 69 99 B1 E5 CB 60 6B 1E 81 84 5A DE 1F 75 6B 1B EE 21 29 4A EC 66 C6 13 8A 0F 95 3B BF 57 61 1A 70 2F 85 0D 07 71 DA 9E 3D 3C 21 44 02 88 44 4C 0F 70 28 92 A1 D0 77 81 AD 90 4C 63 56 A6 D9 3E 80 27 82 B4 F8 9C 36 0A A5 B4 13 DA CB FA BD 27 54 70 26 65 64 65 AC 4F 9D 9A 2E D9 A8 80 88 D3 EE 44 32 99 E8 E4 07 85 52 8D E9 C0 63 46 48 55 AF 5D 87 13 5C AE 58 F0 B8 0D A8 F3 BD 8B A1 BC D2 A3 12 27 46 EB 07 5A 9C 9F 88 4B BC 66 5C 54 B9 11 49 4A 86 2D 17 D5 BC DD 55 37 A7 B1 E0 95 7F 12 19 FC 88 3C 7B F5 63 7E 4E 21 87 B0 96 66 1E 6D B0 46 87 AD 1D A0 B7 2B 73 0A 05 18 AC 7C 68 D9 C2 A7 D9 AC 8A 71 E8 ED A0 24 EC 33 66 F8 75 33 8C 8F 4E 73 09 42 63 92 4C 6F 8B 77 59 25 E0 60 7B 17 D9 DE 9F 10 1F B6 42 95 3D 3E 84 80 8B 76 AF 83 E9 EB EB 58 01 9E 9E C4 A4 28 46 07 44 30 DA B0 AE FB F9 34 7C 8B 1C 3F F8 A7 DE EC 2C C8 22 44 05 C0 D7 EE FF AE 7D 6D 33 D3 D1 FE 24 CE 2D 87 3D 3F 3C 13 9A 2A 65 08 8D C6 25 44 85 69 55 2A FF FA 38 68 B7 38 00 DA 64 59 D7 6D E7 66 08 6A C5 10 89 E1 9D 73 91 42 DD 99 C3 20 83 6F FA F1 72 46 FC 71 3D D4 65 4E 84 D2 0D 08 7C B0 17 ED C6 89 D3 16 61 85 68 13 AC DB DE 28 4D EA 88 B6 74 CA 26 60 1D 44 BF 3E 27 B3 2C EC BD EA 2D 51 F0 87 F7 42 B8 5C AA F1 33 89 93 8A 50 EC 79 1E B9 A3 9F 38 F2 C0 90 53 E8 6F 1F 1A D1 57 F1 F0 BC B7 9F 4A 39 50 91 42 76 E8 7E 51 5C 8D E6 E7 3B F7 14 BC 1C 77 B6 39 A6 DA C3 30 D3 3D 46 5A 3E 86 0F 81 75 C5 8C 8E 55 AB D1 BE E3 64 33) */;

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
			EventHandler eventHandler = Rd2;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			Label obj = label;
			char_0[160] = (char)(char_0[160] & char_0[359] & '@');
			if (obj != null)
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
			EventHandler eventHandler = Ym0;
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
			EventHandler eventHandler = i3C8;
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
			EventHandler eventHandler = w1C3;
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
			EventHandler eventHandler = t3A5;
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
				char_0[52] = (char)((char_0[52] - char_0[274]) & '$');
			}
		}
	}

	public o1W()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Xt5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		c2F();
	}

	[DebuggerNonUserCode]
	protected override void Zo3(bool j0X)
	{
		try
		{
			if (j0X && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j0X);
		}
		char_0[278] = (char)((char_0[278] ^ char_0[543]) & 'r');
	}

	[DebuggerStepThrough]
	private void c2F()
	{
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected O, but got Unknown
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected O, but got Unknown
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected O, but got Unknown
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c86: Expected O, but got Unknown
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected O, but got Unknown
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Expected O, but got Unknown
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Expected O, but got Unknown
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected O, but got Unknown
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Expected O, but got Unknown
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdd: Expected O, but got Unknown
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		int[] int_ = s5C.int_0;
		char[] array = char_0;
		int num = 46;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 44;
			while (true)
			{
				txtWeight = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 31;
				while (true)
				{
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					Label5 = new Label();
					num = 28;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						txtRcode = new TextBox();
						num = 49;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							while (true)
							{
								txtCategory = new TextBox();
								num = 41;
								while (true)
								{
									txtRName = new TextBox();
									txtAmount = new TextBox();
									Label2 = new Label();
									num = 65;
									while (true)
									{
										btnSave = new Button();
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										num = 61;
										while (true)
										{
											Label3.set_AutoSize(true);
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 43;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(320, 21));
												num = 82;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(123, 17));
													num = 53;
													while (true)
													{
														((Control)Label3).set_TabIndex(9);
														Label3.set_Text("Purchase Detail");
														num = 48;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 20;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 79;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 21));
																	num = 17;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 14;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(10);
																			Label6.set_Text("X");
																			num = 74;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 62;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 66;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(42, 21));
																						num = 77;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 57;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(9);
																								Label7.set_Text("Go To Main");
																								num = 25;
																								while (true)
																								{
																									((Control)txtWeight).set_Location(new Point(537, 136));
																									((Control)txtWeight).set_Name("txtWeight");
																									num = 69;
																									while (true)
																									{
																										((Control)txtWeight).set_Size(new Size(100, 20));
																										((Control)txtWeight).set_TabIndex(5);
																										num = 56;
																										while (true)
																										{
																											Label10.set_AutoSize(true);
																											((Control)Label10).set_ForeColor(Color.White);
																											num = 30;
																											while (true)
																											{
																												((Control)Label10).set_Location(new Point(478, 139));
																												((Control)Label10).set_Name("Label10");
																												num = 33;
																												while (true)
																												{
																													((Control)Label10).set_Size(new Size(47, 13));
																													((Control)Label10).set_TabIndex(99);
																													num = 32;
																													while (true)
																													{
																														Label10.set_Text("Weight :");
																														DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																														num = 40;
																														while (true)
																														{
																															((Control)DataGridView1).set_Location(new Point(45, 239));
																															((Control)DataGridView1).set_Name("DataGridView1");
																															num = 72;
																															while (true)
																															{
																																((Control)DataGridView1).set_Size(new Size(724, 199));
																																((Control)DataGridView1).set_TabIndex(11);
																																num = int_[298] - 21209;
																																while (true)
																																{
																																	switch (num)
																																	{
																																	case 81:
																																		((Control)btnSave).set_Name("btnSave");
																																		((Control)btnSave).set_Size(new Size(75, 31));
																																		goto case 38;
																																	case 38:
																																		num = 60;
																																		goto case 60;
																																	case 60:
																																		((Control)btnSave).set_TabIndex(6);
																																		((ButtonBase)btnSave).set_Text("SAVE");
																																		num = 27;
																																		goto case 27;
																																	case 27:
																																		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																		num = 50;
																																		goto case 50;
																																	case 50:
																																		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																		num = 12;
																																		goto case 12;
																																	case 12:
																																		((Form)this).set_ClientSize(new Size(800, 450));
																																		((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																		num = 47;
																																		goto case 47;
																																	case 47:
																																		((Control)this).get_Controls().Add((Control)(object)Label10);
																																		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																		num = 4;
																																		goto case 4;
																																	case 4:
																																		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																																		((Control)this).get_Controls().Add((Control)(object)Label8);
																																		num = 21;
																																		goto case 21;
																																	case 21:
																																		((Control)this).get_Controls().Add((Control)(object)Label5);
																																		((Control)this).get_Controls().Add((Control)(object)Label4);
																																		num = 52;
																																		goto case 52;
																																	case 52:
																																		((Control)this).get_Controls().Add((Control)(object)Label1);
																																		((Control)this).get_Controls().Add((Control)(object)txtRcode);
																																		num = array[497] - 15356;
																																		continue;
																																	case 80:
																																		Label8.set_Text("Category :");
																																		Label5.set_AutoSize(true);
																																		num = 15;
																																		goto case 15;
																																	case 15:
																																		((Control)Label5).set_ForeColor(Color.White);
																																		((Control)Label5).set_Location(new Point(156, 101));
																																		num = 5;
																																		goto case 5;
																																	case 5:
																																		((Control)Label5).set_Name("Label5");
																																		((Control)Label5).set_Size(new Size(66, 13));
																																		num = 59;
																																		goto case 59;
																																	case 59:
																																		((Control)Label5).set_TabIndex(93);
																																		Label5.set_Text("Raw Name :");
																																		num = 0;
																																		goto case 0;
																																	case 0:
																																		Label4.set_AutoSize(true);
																																		((Control)Label4).set_ForeColor(Color.White);
																																		num = 24;
																																		goto case 24;
																																	case 24:
																																		((Control)Label4).set_Location(new Point(466, 106));
																																		((Control)Label4).set_Name("Label4");
																																		num = 54;
																																		goto case 54;
																																	case 54:
																																		((Control)Label4).set_Size(new Size(49, 13));
																																		((Control)Label4).set_TabIndex(92);
																																		goto case 1;
																																	case 1:
																																		num = 19;
																																		goto case 19;
																																	case 19:
																																		Label4.set_Text("Amount :");
																																		Label1.set_AutoSize(true);
																																		num = 3;
																																		goto case 3;
																																	case 3:
																																		((Control)Label1).set_ForeColor(Color.White);
																																		((Control)Label1).set_Location(new Point(431, 67));
																																		num = 76;
																																		goto case 76;
																																	case 76:
																																		((Control)Label1).set_Name("Label1");
																																		((Control)Label1).set_Size(new Size(84, 13));
																																		num = 45;
																																		goto case 45;
																																	case 45:
																																		((Control)Label1).set_TabIndex(91);
																																		Label1.set_Text("Purchase Date :");
																																		num = 58;
																																		goto case 58;
																																	case 58:
																																		((Control)txtRcode).set_Location(new Point(245, 64));
																																		((Control)txtRcode).set_Name("txtRcode");
																																		num = 34;
																																		goto case 34;
																																	case 34:
																																		((Control)txtRcode).set_Size(new Size(100, 20));
																																		((Control)txtRcode).set_TabIndex(0);
																																		num = 73;
																																		goto case 73;
																																	case 73:
																																		((Control)btnDelete).set_Location(new Point(496, 202));
																																		((Control)btnDelete).set_Name("btnDelete");
																																		num = 37;
																																		goto case 37;
																																	case 37:
																																		((Control)btnDelete).set_Size(new Size(75, 31));
																																		((Control)btnDelete).set_TabIndex(8);
																																		num = 18;
																																		goto case 18;
																																	case 18:
																																		((ButtonBase)btnDelete).set_Text("DELETE");
																																		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																		num = 75;
																																		goto case 75;
																																	case 75:
																																		((Control)btnModify).set_Location(new Point(378, 202));
																																		((Control)btnModify).set_Name("btnModify");
																																		num = 35;
																																		goto case 35;
																																	case 35:
																																		((Control)btnModify).set_Size(new Size(75, 31));
																																		((Control)btnModify).set_TabIndex(7);
																																		num = 7;
																																		goto case 7;
																																	case 7:
																																		((ButtonBase)btnModify).set_Text("MODIFY");
																																		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																		num = 2;
																																		goto case 2;
																																	case 2:
																																		((Control)txtCategory).set_Location(new Point(243, 124));
																																		((Control)txtCategory).set_Name("txtCategory");
																																		num = 10;
																																		goto case 10;
																																	case 10:
																																		((Control)txtCategory).set_Size(new Size(100, 20));
																																		((Control)txtCategory).set_TabIndex(2);
																																		num = 26;
																																		goto case 26;
																																	case 26:
																																		((Control)txtRName).set_Location(new Point(243, 94));
																																		((Control)txtRName).set_Name("txtRName");
																																		num = 70;
																																		goto case 70;
																																	case 70:
																																		((Control)txtRName).set_Size(new Size(100, 20));
																																		((Control)txtRName).set_TabIndex(1);
																																		num = 68;
																																		goto case 68;
																																	case 68:
																																		((Control)txtAmount).set_Location(new Point(537, 99));
																																		((Control)txtAmount).set_Name("txtAmount");
																																		num = 9;
																																		goto case 9;
																																	case 9:
																																		((Control)txtAmount).set_Size(new Size(100, 20));
																																		((Control)txtAmount).set_TabIndex(4);
																																		num = 6;
																																		goto case 6;
																																	case 6:
																																		Label2.set_AutoSize(true);
																																		((Control)Label2).set_ForeColor(Color.White);
																																		num = 8;
																																		goto case 8;
																																	case 8:
																																		((Control)Label2).set_Location(new Point(167, 67));
																																		((Control)Label2).set_Name("Label2");
																																		num = 39;
																																		goto case 39;
																																	case 39:
																																		((Control)Label2).set_Size(new Size(63, 13));
																																		((Control)Label2).set_TabIndex(90);
																																		num = 23;
																																		goto case 23;
																																	case 23:
																																		Label2.set_Text("Row Code :");
																																		((Control)btnSave).set_Location(new Point(249, 202));
																																		num = 81;
																																		goto case 81;
																																	case 71:
																																		((Control)DateTimePicker1).set_Size(new Size(126, 20));
																																		((Control)DateTimePicker1).set_TabIndex(3);
																																		num = 29;
																																		goto case 29;
																																	case 29:
																																		Label8.set_AutoSize(true);
																																		((Control)Label8).set_ForeColor(Color.White);
																																		num = 64;
																																		goto case 64;
																																	case 64:
																																		((Control)Label8).set_Location(new Point(166, 130));
																																		((Control)Label8).set_Name("Label8");
																																		num = 22;
																																		goto case 22;
																																	case 22:
																																		((Control)Label8).set_Size(new Size(55, 13));
																																		((Control)Label8).set_TabIndex(94);
																																		num = 80;
																																		goto case 80;
																																	case 67:
																																		((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																		((Control)this).get_Controls().Add((Control)(object)btnModify);
																																		num = 13;
																																		goto case 13;
																																	case 13:
																																		((Control)this).get_Controls().Add((Control)(object)txtCategory);
																																		((Control)this).get_Controls().Add((Control)(object)txtRName);
																																		num = 16;
																																		goto case 16;
																																	case 16:
																																		((Control)this).get_Controls().Add((Control)(object)txtAmount);
																																		((Control)this).get_Controls().Add((Control)(object)Label2);
																																		num = 63;
																																		goto case 63;
																																	case 63:
																																		((Control)this).get_Controls().Add((Control)(object)btnSave);
																																		((Control)this).get_Controls().Add((Control)(object)Label6);
																																		num = 51;
																																		goto case 51;
																																	case 51:
																																		((Control)this).get_Controls().Add((Control)(object)Label7);
																																		((Control)this).get_Controls().Add((Control)(object)Label3);
																																		num = 42;
																																		goto case 42;
																																	case 42:
																																		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																		((Control)this).set_Name("frmPurchaseDetail");
																																		((Form)this).set_StartPosition((FormStartPosition)1);
																																		num = array[136] - 53622;
																																		continue;
																																	case 11:
																																		((Control)DateTimePicker1).set_Location(new Point(537, 64));
																																		((Control)DateTimePicker1).set_Name("DateTimePicker1");
																																		num = 71;
																																		goto case 71;
																																	case 72:
																																		break;
																																	case 40:
																																		goto end_IL_089a;
																																	case 32:
																																		goto end_IL_08d4;
																																	case 33:
																																		goto end_IL_0900;
																																	case 30:
																																		goto end_IL_0921;
																																	case 56:
																																		goto end_IL_0947;
																																	case 69:
																																		goto end_IL_0976;
																																	case 25:
																																		goto end_IL_0997;
																																	case 57:
																																		goto end_IL_09bc;
																																	case 77:
																																		goto end_IL_09eb;
																																	case 66:
																																		goto end_IL_0a0d;
																																	case 62:
																																		goto end_IL_0a36;
																																	case 74:
																																		goto end_IL_0a5f;
																																	case 14:
																																		goto end_IL_0a81;
																																	case 17:
																																		goto end_IL_0aa2;
																																	case 79:
																																		goto end_IL_0ac4;
																																	case 20:
																																		goto end_IL_0aed;
																																	case 48:
																																		goto end_IL_0b19;
																																	case 53:
																																		goto end_IL_0b3b;
																																	case 82:
																																		goto end_IL_0b5c;
																																	case 43:
																																		goto end_IL_0b7e;
																																	case 61:
																																		goto end_IL_0ba7;
																																	case 65:
																																		goto end_IL_0bd3;
																																	case 41:
																																		goto end_IL_0c01;
																																	case 78:
																																		goto end_IL_0c22;
																																	case 49:
																																		goto end_IL_0c48;
																																	case 28:
																																		goto end_IL_0c58;
																																	case 31:
																																		goto end_IL_0c70;
																																	case 44:
																																		goto end_IL_0c96;
																																	default:
																																		goto end_IL_0cbc;
																																	case 55:
																																		((Form)this).set_Text("frmPurchaseDetail");
																																		((ISupportInitialize)DataGridView1).EndInit();
																																		((Control)this).ResumeLayout(false);
																																		num = 36;
																																		goto case 36;
																																	case 36:
																																		((Control)this).PerformLayout();
																																		return;
																																	}
																																	break;
																																}
																																continue;
																																end_IL_089a:
																																break;
																															}
																															continue;
																															end_IL_08d4:
																															break;
																														}
																														continue;
																														end_IL_0900:
																														break;
																													}
																													continue;
																													end_IL_0921:
																													break;
																												}
																												continue;
																												end_IL_0947:
																												break;
																											}
																											continue;
																											end_IL_0976:
																											break;
																										}
																										continue;
																										end_IL_0997:
																										break;
																									}
																									continue;
																									end_IL_09bc:
																									break;
																								}
																								continue;
																								end_IL_09eb:
																								break;
																							}
																							continue;
																							end_IL_0a0d:
																							break;
																						}
																						continue;
																						end_IL_0a36:
																						break;
																					}
																					continue;
																					end_IL_0a5f:
																					break;
																				}
																				continue;
																				end_IL_0a81:
																				break;
																			}
																			continue;
																			end_IL_0aa2:
																			break;
																		}
																		continue;
																		end_IL_0ac4:
																		break;
																	}
																	continue;
																	end_IL_0aed:
																	break;
																}
																continue;
																end_IL_0b19:
																break;
															}
															continue;
															end_IL_0b3b:
															break;
														}
														continue;
														end_IL_0b5c:
														break;
													}
													continue;
													end_IL_0b7e:
													break;
												}
												continue;
												end_IL_0ba7:
												break;
											}
											continue;
											end_IL_0bd3:
											break;
										}
										continue;
										end_IL_0c01:
										break;
									}
									continue;
									end_IL_0c22:
									break;
								}
								continue;
								end_IL_0c48:
								break;
							}
							continue;
							end_IL_0c58:
							break;
						}
						continue;
						end_IL_0c70:
						break;
					}
					continue;
					end_IL_0c96:
					break;
				}
				continue;
				end_IL_0cbc:
				break;
			}
		}
	}

	private void Ym0(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void Rd2(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Xt5(object sender, EventArgs e)
	{
		j4M7();
	}

	private void t3A5(object sender, EventArgs e)
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
		j4M7();
	}

	public void j4M7()
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

	internal static byte[] Zb68(int Fq45)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		int length = text.Length;
		s5C.int_0[70] = (s5C.int_0[70] + Fq45) & 0xDD;
		if (length > 2)
		{
			return q1C3.Za2n(Sd5.Wb7(), Fq45);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void w1C3(object sender, EventArgs e)
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
		j4M7();
		s5C.int_0[285] = (s5C.int_0[285] * s5C.int_0[154]) & 0x43;
	}

	private void i3C8(object sender, EventArgs e)
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
		j4M7();
		char_0[262] = (char)((char_0[262] ^ char_0[207]) & 'ù');
	}

	static void m3L1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		o1W o1W2;
		Xq90 xq;
		try
		{
			do
			{
				Xq90 obj = (Xq90)(object)Ns87.Default;
				xq = (Xq90)(object)Ns87.Default;
				xq = obj;
				obj2 = obj2;
			}
			while (obj2 != null);
		}
		finally
		{
			try
			{
				do
				{
					c7G c7G = (c7G)(object)Ns87.Default;
					c7G = c7G;
				}
				while (obj2 != null);
			}
			finally
			{
				o1W2 = (o1W)(object)Ns87.Default;
				o1W2 = o1W2;
				goto IL_0095;
			}
		}
		IL_0095:
		while ((object)Ns87.Default != null)
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				finally
				{
					o1W2 = o1W2;
					_ = (q1C3)(object)Ns87.Default;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		checked
		{
			try
			{
				q1J = q1J;
				q1J = null;
			}
			finally
			{
				try
				{
					_ = (q1C3)(object)Ns87.Default;
				}
				finally
				{
					num = unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Ns87.Default) * unchecked((nuint)(UIntPtr)Ns87.Default);
					if (num * (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
					{
						_ = (_003CModule_003E)(object)Ns87.Default;
					}
					else
					{
						Sd5 obj3 = (Sd5)(object)Ns87.Default;
						sd = null;
						sd = obj3;
					}
					goto IL_0134;
				}
			}
		}
		IL_04e5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
		try
		{
			o1W2 = null;
		}
		finally
		{
			try
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
			finally
			{
				sd = sd;
				_ = (c7G)(object)Ns87.Default;
				es6d = null;
				_ = (q1C3)(object)Ns87.Default;
				goto IL_0522;
			}
		}
		IL_0134:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
		checked
		{
			if (num == 0)
			{
				try
				{
					if (num == 0)
					{
						q4PG q4PG = q4PG;
						q4PG = q4PG;
					}
					else
					{
						_ = (q1C3)(object)Ns87.Default;
					}
				}
				catch
				{
					do
					{
						s5C = (s5C)(object)Ns87.Default;
						s5C = s5C;
					}
					while (obj2 != null);
				}
			}
			else
			{
				try
				{
					nuint num2 = num + num;
					num = default(UIntPtr);
					if (num2 - num == 0)
					{
						_ = (Xq90)(object)Ns87.Default;
						a1HS = null;
						a1HS = null;
						sd = sd;
						_ = (_003CModule_003E)(object)Ns87.Default;
					}
				}
				catch
				{
					if (num == 0)
					{
						g6EQ obj5 = (g6EQ)(object)Ns87.Default;
						g6EQ = g6EQ;
						g6EQ = obj5;
					}
				}
			}
			_ = (q1J3)(object)Ns87.Default;
			es6d = es6d;
			es6d = es6d;
			xq = null;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					g6EQ = g6EQ;
					_ = (Xq90)(object)Ns87.Default;
					_ = (Cr17)(object)Ns87.Default;
				}
				catch
				{
					es6d = (Es6d)(object)Ns87.Default;
				}
			}
			else
			{
				_ = (Es6d)(object)Ns87.Default;
			}
		}
		finally
		{
			goto IL_0255;
		}
		IL_045e:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			UIntPtr num3 = (UIntPtr)Ns87.Default;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)num3 / num) == 0)
				{
					while ((object)Ns87.Default != null)
					{
						_ = (Cr17)(object)Ns87.Default;
					}
				}
				goto IL_04e5;
			}
		}
		try
		{
			while ((object)Ns87.Default != null)
			{
				c7G c7G = (c7G)(object)Ns87.Default;
			}
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (Cy1)(object)Ns87.Default;
			}
			goto IL_04e5;
		}
		IL_0305:
		if (num != 0)
		{
			try
			{
				_ = (q1C3)(object)Ns87.Default;
			}
			catch
			{
				xq = xq;
			}
			finally
			{
				try
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				catch
				{
					s5C = (s5C)(object)Ns87.Default;
				}
				goto IL_0348;
			}
		}
		goto IL_0348;
		IL_07bf:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ea3q ea3q);
		do
		{
			if (checked(num + num) == 0)
			{
				ea3q = ea3q;
			}
		}
		while ((object)Ns87.Default != null);
		UIntPtr num4 = (UIntPtr)Ns87.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj06 xj);
		checked
		{
			if (unchecked((nuint)num4) + num == 0)
			{
				do
				{
					try
					{
						_ = (Xj06)Ns87.Default;
					}
					catch
					{
						_ = (Ty3)(object)Ns87.Default;
						xj = xj;
						_ = (q1C3)(object)Ns87.Default;
						_ = (_003CModule_003E)(object)Ns87.Default;
					}
				}
				while (obj2 != null);
			}
			else
			{
				while ((object)Ns87.Default != null)
				{
					try
					{
						_ = (Es6d)(object)Ns87.Default;
					}
					finally
					{
						_ = (Cr17)(object)Ns87.Default;
						continue;
					}
				}
			}
			_ = (q1C3)(object)Ns87.Default;
			if (num == 0)
			{
				while ((object)Ns87.Default != null)
				{
					while (obj2 != null)
					{
						xj = (Xj06)Ns87.Default;
					}
				}
			}
			_ = (Cr17)(object)Ns87.Default;
			nuint num5 = num;
			num = default(UIntPtr);
			if (unchecked(num5 / num) == 0)
			{
				try
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
					_003CModule_003E = _003CModule_003E;
					return;
				}
				catch
				{
					_ = (q1C3)(object)Ns87.Default;
					q1J = q1J;
					_ = (Cr17)(object)Ns87.Default;
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
					return;
				}
				finally
				{
					a1HS = a1HS;
					return;
				}
			}
			if (num * num == 0)
			{
				try
				{
					_ = (Cy1)(object)Ns87.Default;
					return;
				}
				catch
				{
					_ = (k2GS)(object)Ns87.Default;
					return;
				}
			}
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			o1W2 = o1W2;
		}
		return;
		IL_0255:
		num = default(UIntPtr);
		if (num == 0 && num == 0)
		{
			do
			{
				_ = (Xj06)Ns87.Default;
			}
			while ((object)Ns87.Default != null);
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u && (UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Ea3q)(object)Ns87.Default;
		}
		try
		{
			_ = (q4PG)(object)Ns87.Default;
		}
		finally
		{
			try
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					sd = (Sd5)(object)Ns87.Default;
					_ = (f1D8)(object)Ns87.Default;
					_ = (f1D8)(object)Ns87.Default;
					ea3q = ea3q;
					ea3q = null;
				}
			}
			finally
			{
				if (num == 0)
				{
					s5C = s5C;
				}
				goto IL_0305;
			}
		}
		IL_0348:
		try
		{
			do
			{
				try
				{
					_ = (Ea3q)(object)Ns87.Default;
				}
				finally
				{
					_ = (Cy1)(object)Ns87.Default;
					_ = (Ty3)(object)Ns87.Default;
					xq = (Xq90)(object)Ns87.Default;
					xj = default(Xj06);
					xj = xj;
					xj = default(Xj06);
					xj = xj;
					continue;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			do
			{
				Ns87 ns = null;
				ns = ns;
			}
			while (obj2 != null);
		}
		try
		{
			do
			{
				try
				{
					_ = (k2GS)(object)Ns87.Default;
				}
				catch
				{
					_ = (a1HS)(object)Ns87.Default;
					q4PG q4PG = (q4PG)(object)Ns87.Default;
					_ = (f1D8)(object)Ns87.Default;
				}
			}
			while (obj2 != null);
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Cr17)(object)Ns87.Default;
					_ = (Xj06)Ns87.Default;
					_ = (_003CModule_003E)(object)Ns87.Default;
				}
			}
			finally
			{
				try
				{
					es6d = es6d;
				}
				finally
				{
					_ = (k2GS)(object)Ns87.Default;
					_ = (Xq90)(object)Ns87.Default;
					_ = (Ea3q)(object)Ns87.Default;
					goto IL_045e;
				}
			}
		}
		IL_0522:
		_ = (Ty3)(object)Ns87.Default;
		_ = (Cy1)(object)Ns87.Default;
		_ = (k2GS)(object)Ns87.Default;
		_ = (q4PG)(object)Ns87.Default;
		while (obj2 != null)
		{
			try
			{
				do
				{
					_ = (Sd5)(object)Ns87.Default;
					es6d = es6d;
					_ = (Cy1)(object)Ns87.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					_ = (Ea3q)(object)Ns87.Default;
				}
				finally
				{
					_ = (Ty3)(object)Ns87.Default;
					goto end_IL_0578;
				}
				end_IL_0578:;
			}
		}
		if (num == 0)
		{
			_ = (k2GS)(object)Ns87.Default;
		}
		try
		{
			_ = (g6EQ)(object)Ns87.Default;
		}
		catch
		{
			q1J = q1J;
		}
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				do
				{
					try
					{
					}
					catch
					{
						_ = (k2GS)(object)Ns87.Default;
					}
				}
				while ((object)Ns87.Default != null);
				goto IL_0640;
			}
		}
		try
		{
			while (obj2 != null)
			{
				_ = (Sa53)Ns87.Default;
			}
		}
		finally
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (c7G)(object)Ns87.Default;
			}
			else
			{
				_ = (Sd5)(object)Ns87.Default;
			}
			goto IL_0640;
		}
		IL_0640:
		try
		{
			try
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			catch
			{
				a1HS = (a1HS)(object)Ns87.Default;
			}
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				cy = cy;
				cy = cy;
			}
			while (obj2 != null);
		}
		else
		{
			_ = (q1C3)(object)Ns87.Default;
			_ = (q1C3)(object)Ns87.Default;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					_ = (q1C3)(object)Ns87.Default;
				}
				while (obj2 != null);
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Cr17)(object)Ns87.Default;
				}
			}
		}
		else
		{
			try
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Cy1)(object)Ns87.Default;
				}
			}
			catch
			{
				while ((object)Ns87.Default != null)
				{
					g6EQ = g6EQ;
				}
			}
		}
		_ = Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		do
		{
			if ((UIntPtr)Ns87.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Ns87.Default;
				}
				finally
				{
					ty = ty;
					continue;
				}
			}
			try
			{
				cy = cy;
			}
			finally
			{
				_ = (q1C3)(object)Ns87.Default;
				continue;
			}
		}
		while (obj2 != null);
		try
		{
			while (obj2 != null)
			{
				_ = Ns87.Default;
			}
		}
		finally
		{
			_ = (s5C)(object)Ns87.Default;
			_ = (Es6d)(object)Ns87.Default;
			_ = (Sd5)(object)Ns87.Default;
			goto IL_07bf;
		}
	}
}
