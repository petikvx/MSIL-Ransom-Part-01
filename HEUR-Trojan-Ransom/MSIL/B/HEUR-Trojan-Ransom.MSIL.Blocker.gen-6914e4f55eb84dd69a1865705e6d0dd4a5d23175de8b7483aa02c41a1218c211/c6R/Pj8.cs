using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Gb1;
using Microsoft.VisualBasic.CompilerServices;
using c5E;
using o8Z;

namespace c6R;

[DesignerGenerated]
public class Pj8 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static Gj4 gj4_0/* Not supported: data(10 F1 BA E3 4D FA 59 28 89 8D 61 45 39 8A 7B AA F5 7C 66 A9 18 5A F0 34 E9 82 29 5D 7B A5 BE 54 C2 14 CE 34 E0 B2 CF D9 8C F9 23 D8 D8 2A 59 53 30 F4 B2 3D 76 1A CC B4 00 86 F9 CA D1 FB AC E2 CD 0C 82 24 BA 47 C8 42 AB 8C 1D 1E 36 18 5B BF 28 D4 2C 85 F2 81 DD A8 47 19 33 5A B8 05 07 90 4C 40 0A CC A6 34 97 E7 2B 70 90 E8 FC AD 7D E7 2A 3A A1 FB CE 26 EF 4C 2D D9 DC A1 14 6E 89 A6 84 8B D0 F5 0D 8D 18 F3 3D 43 5A 82 EF F3 AB 98 9B 4A 2F 7E 62 0A C0 26 50 BD 9E CC 57 F5 D3 BC E6 E9 64 70 DB 87 D9 9B 22 AD BE 8A CB 6C 5B 39 2D 43 06 C8 3E 0A 43 79 C9 AA A4 4F EE 4A 9B 47 6F 9D 9B 05 8F 3A BB 13 6F 92 5B B4 4B 36 59 E2 61 64 9E 14 EE 0A 7D DB A6 E9 A5 31 E1 8A AC D6 11 76 1B 2D D0 55 A9 F2 86 F1 59 AB AE 8D 2E 93 50 C1 EC 89 AB 87 57 64 1F BF 5E A4 94 8A 30 E4 E5 84 A2 D3 1B 2B 11 0B BA AB 8C FC B0 D1 2D 18 BB 12 DF 20 9C 22 2B 89 1F B5 0E 11 F6 04 5D FB C0 74 C4 29 EA 59 77 25 AF E0 CD FE F9 5A B2 4D 91 46 E8 81 AA 10 47 C2 59 18 B4 64 1D 00 14 B6 4D 90 3B 3C 0C 03 2D 61 99 BA 70 BA 53 2B 8F C4 03 BF 7E B0 1B DB 50 B0 2C 02 CF D1 A4 13 07 AF CC 17 B0 69 1E 76 41 8E 19 86 E7 EF 9F 8B 6E 2D 88 EE 61 5D 80 63 9B 71 3F 8A 0F 09 33 5A BB 86 B2 C0 ED 3C 7A 25 A5 8B 7E EF 97 93 F2 60 10 A0 92 A1 49 B5 B0 A9 2E 69 7B 3F 29 93 66 37 5A BD C9 61 3C DE 9D 32 B2 62 48 D4 DE 90 CA 07 7D DD 79 6E 76 90 11 06 D4 09 91 83 BF 3A FA 12 25 46 94 D8 C8 91 24 31 02 5F EE E5 6C DB C9 9D 9D 73 C0 4B 1A F6 BF C9 AC C2 8C 32 4C 19 71 77 66 36 AF 97 FA F1 3D EA B9 47 6B 17 A0 2A 99 F7 3E F3 E5 4C 78 AF F7 2D) */;

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
			EventHandler eventHandler = Qw3;
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
			EventHandler eventHandler = Xi8;
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
			byte[] array = byte_0;
			int num = 6;
			while (true)
			{
				EventHandler eventHandler = Ac1;
				while (true)
				{
					Button val = _btnDelete;
					if (val != null)
					{
						switch (array[262] - array[0])
						{
						case 0:
							break;
						default:
							goto end_IL_0041;
						case 1:
							((Control)val).remove_Click(eventHandler);
							goto IL_0067;
						case 4:
							goto IL_0067;
						case 2:
						case 7:
							goto IL_0075;
						case 3:
							goto IL_00a2;
						case 5:
							return;
						}
						continue;
					}
					num = 4;
					goto IL_0067;
					IL_0075:
					Button obj = val;
					byte_0[493] = (byte)((byte_0[493] - byte_0[282]) & 0xA6);
					if (obj != null)
					{
						num = 3;
						goto IL_00a2;
					}
					num = 5;
					return;
					IL_00a2:
					((Control)val).add_Click(eventHandler);
					return;
					IL_0067:
					_btnDelete = value;
					val = _btnDelete;
					goto IL_0075;
					continue;
					end_IL_0041:
					break;
				}
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
			EventHandler eventHandler = w5B;
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
			EventHandler eventHandler = Yg2;
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

	public Pj8()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)z1B);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Rn0();
	}

	[DebuggerNonUserCode]
	protected override void Mf7(bool g4P)
	{
		try
		{
			if (g4P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g4P);
		}
	}

	[DebuggerStepThrough]
	private void Rn0()
	{
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected O, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected O, but got Unknown
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected O, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected O, but got Unknown
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a39: Expected O, but got Unknown
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected O, but got Unknown
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected O, but got Unknown
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected O, but got Unknown
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected O, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected O, but got Unknown
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		char[] char_ = Mb5.char_0;
		byte[] array = byte_0;
		int num = 27;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 12;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 68;
				while (true)
				{
					txtPId = new TextBox();
					txtGWeight = new TextBox();
					txtPCost = new TextBox();
					num = 1;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 23;
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
								while (true)
								{
									num = 59;
									while (true)
									{
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = char_[72] - 25469;
										while (true)
										{
											switch (num)
											{
											case 75:
												((Control)btnDelete).set_Size(new Size(75, 31));
												((Control)btnDelete).set_TabIndex(7);
												num = 53;
												goto case 53;
											case 53:
												((ButtonBase)btnDelete).set_Text("DELETE");
												((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
												num = 21;
												goto case 21;
											case 21:
												((Control)btnModify).set_Location(new Point(404, 132));
												((Control)btnModify).set_Name("btnModify");
												num = 73;
												goto case 73;
											case 73:
												((Control)btnModify).set_Size(new Size(75, 31));
												((Control)btnModify).set_TabIndex(6);
												num = 51;
												goto case 51;
											case 51:
												((ButtonBase)btnModify).set_Text("MODIFY");
												((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
												num = 34;
												goto case 34;
											case 34:
												DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
												((Control)DataGridView1).set_Location(new Point(87, 232));
												goto case 3;
											case 3:
												num = 22;
												goto case 22;
											case 22:
												((Control)DataGridView1).set_Name("DataGridView1");
												((Control)DataGridView1).set_Size(new Size(599, 206));
												num = 0;
												goto case 0;
											case 0:
												((Control)DataGridView1).set_TabIndex(25);
												((Control)txtPId).set_Location(new Point(229, 195));
												num = 46;
												goto case 46;
											case 46:
												((Control)txtPId).set_Name("txtPId");
												((Control)txtPId).set_Size(new Size(100, 20));
												num = 44;
												goto case 44;
											case 44:
												((Control)txtPId).set_TabIndex(4);
												((Control)txtGWeight).set_Location(new Point(229, 162));
												num = 35;
												goto case 35;
											case 35:
												((Control)txtGWeight).set_Name("txtGWeight");
												((Control)txtGWeight).set_Size(new Size(100, 20));
												num = 57;
												goto case 57;
											case 57:
												((Control)txtGWeight).set_TabIndex(3);
												((Control)txtPCost).set_Location(new Point(229, 135));
												num = 58;
												goto case 58;
											case 58:
												((Control)txtPCost).set_Name("txtPCost");
												((Control)txtPCost).set_Size(new Size(100, 20));
												num = 25;
												goto case 25;
											case 25:
												((Control)txtPCost).set_TabIndex(2);
												Label4.set_AutoSize(true);
												num = 30;
												goto case 30;
											case 30:
												((Control)Label4).set_ForeColor(Color.White);
												((Control)Label4).set_Location(new Point(108, 169));
												num = 7;
												goto case 7;
											case 7:
												((Control)Label4).set_Name("Label4");
												((Control)Label4).set_Size(new Size(106, 13));
												num = 20;
												goto case 20;
											case 20:
												((Control)Label4).set_TabIndex(21);
												Label4.set_Text("Finish Good Weight :");
												num = 48;
												goto case 48;
											case 48:
												Label1.set_AutoSize(true);
												((Control)Label1).set_ForeColor(Color.White);
												num = 32;
												goto case 32;
											case 32:
												((Control)Label1).set_Location(new Point(104, 108));
												((Control)Label1).set_Name("Label1");
												num = 61;
												goto case 61;
											case 61:
												((Control)Label1).set_Size(new Size(110, 13));
												((Control)Label1).set_TabIndex(20);
												num = 4;
												goto case 4;
											case 4:
												Label1.set_Text("Finish Process Good :");
												Label2.set_AutoSize(true);
												num = 66;
												goto case 66;
											case 66:
												((Control)Label2).set_ForeColor(Color.White);
												((Control)Label2).set_Location(new Point(151, 202));
												num = 38;
												goto case 38;
											case 38:
												((Control)Label2).set_Name("Label2");
												((Control)Label2).set_Size(new Size(63, 13));
												num = 16;
												goto case 16;
											case 16:
												((Control)Label2).set_TabIndex(19);
												Label2.set_Text("Process Id :");
												num = 28;
												goto case 28;
											case 28:
												Label5.set_AutoSize(true);
												((Control)Label5).set_ForeColor(Color.White);
												num = 63;
												goto case 63;
											case 63:
												((Control)Label5).set_Location(new Point(139, 138));
												((Control)Label5).set_Name("Label5");
												num = 55;
												goto case 55;
											case 55:
												((Control)Label5).set_Size(new Size(75, 13));
												((Control)Label5).set_TabIndex(18);
												num = array[358] - 63;
												continue;
											case 26:
											case 71:
												((Control)this).get_Controls().Add((Control)(object)Label8);
												((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
												num = char_[56] - 13705;
												continue;
											case 70:
												((Control)Label6).set_Name("Label6");
												((Control)Label6).set_Size(new Size(18, 17));
												num = 29;
												goto case 29;
											case 29:
												((Control)Label6).set_TabIndex(14);
												Label6.set_Text("X");
												num = 36;
												goto case 36;
											case 36:
												Label7.set_AutoSize(true);
												((Control)Label7).set_BackColor(Color.Blue);
												num = 42;
												goto case 42;
											case 42:
												((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
												num = 45;
												goto case 45;
											case 45:
												((Control)Label7).set_ForeColor(Color.White);
												((Control)Label7).set_Location(new Point(43, 21));
												num = 67;
												goto case 67;
											case 67:
												((Control)Label7).set_Name("Label7");
												((Control)Label7).set_Size(new Size(92, 17));
												num = 39;
												goto case 39;
											case 39:
												((Control)Label7).set_TabIndex(13);
												Label7.set_Text("Go To Main");
												num = 13;
												goto case 13;
											case 13:
												((Control)btnDelete).set_Location(new Point(404, 183));
												((Control)btnDelete).set_Name("btnDelete");
												num = 75;
												goto case 75;
											case 69:
												((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
												num = 64;
												goto case 64;
											case 64:
												((Control)Label6).set_ForeColor(Color.White);
												((Control)Label6).set_Location(new Point(735, 21));
												num = 70;
												goto case 70;
											case 62:
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(326, 21));
												num = char_[159] - 27678;
												continue;
											case 56:
												((Control)txtFGood).set_TabIndex(1);
												((Control)btnSave).set_Location(new Point(404, 72));
												num = 49;
												goto case 49;
											case 49:
												((Control)btnSave).set_Name("btnSave");
												((Control)btnSave).set_Size(new Size(75, 31));
												num = 17;
												goto case 17;
											case 17:
												((Control)btnSave).set_TabIndex(5);
												((ButtonBase)btnSave).set_Text("SAVE");
												num = 11;
												goto case 11;
											case 11:
												((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
												Label8.set_AutoSize(true);
												num = 40;
												goto case 40;
											case 40:
												((Control)Label8).set_ForeColor(Color.White);
												((Control)Label8).set_Location(new Point(117, 75));
												num = 9;
												goto case 9;
											case 9:
												((Control)Label8).set_Name("Label8");
												((Control)Label8).set_Size(new Size(97, 13));
												num = 5;
												goto case 5;
											case 5:
												((Control)Label8).set_TabIndex(29);
												Label8.set_Text("Finish Good Code :");
												num = 19;
												goto case 19;
											case 19:
												((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
												((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
												num = 52;
												goto case 52;
											case 52:
												((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
												((Control)txtFinishGoodCode).set_TabIndex(0);
												num = 10;
												goto case 10;
											case 10:
												((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
												((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
												num = 47;
												goto case 47;
											case 47:
												((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
												((Form)this).set_ClientSize(new Size(800, 450));
												num = 71;
												goto case 26;
											case 33:
												((Control)txtFGood).set_Name("txtFGood");
												((Control)txtFGood).set_Size(new Size(100, 20));
												num = 56;
												goto case 56;
											case 24:
												Label6.set_AutoSize(true);
												((Control)Label6).set_BackColor(Color.Blue);
												num = 69;
												goto case 69;
											case 14:
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(125, 17));
												num = 6;
												goto case 6;
											case 6:
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Processing Cost");
												num = 24;
												goto case 24;
											case 2:
												Label5.set_Text("Process Cost :");
												((Control)txtFGood).set_Location(new Point(229, 105));
												num = 33;
												goto case 33;
											case 59:
												break;
											case 15:
												goto end_IL_097b;
											case 50:
												goto end_IL_09ba;
											case 23:
												goto end_IL_09bf;
											case 1:
												goto end_IL_09e2;
											case 68:
												goto end_IL_0a08;
											case 12:
												goto end_IL_0a2e;
											default:
												goto end_IL_0a53;
											case 60:
												((Control)this).get_Controls().Add((Control)(object)btnDelete);
												((Control)this).get_Controls().Add((Control)(object)btnModify);
												num = 43;
												goto case 43;
											case 43:
												((Control)this).get_Controls().Add((Control)(object)DataGridView1);
												((Control)this).get_Controls().Add((Control)(object)txtPId);
												num = 31;
												goto case 31;
											case 31:
												((Control)this).get_Controls().Add((Control)(object)txtGWeight);
												((Control)this).get_Controls().Add((Control)(object)txtPCost);
												num = 41;
												goto case 41;
											case 41:
												((Control)this).get_Controls().Add((Control)(object)Label4);
												((Control)this).get_Controls().Add((Control)(object)Label1);
												num = 18;
												goto case 18;
											case 18:
												((Control)this).get_Controls().Add((Control)(object)Label2);
												((Control)this).get_Controls().Add((Control)(object)Label5);
												num = 37;
												goto case 37;
											case 37:
												((Control)this).get_Controls().Add((Control)(object)txtFGood);
												((Control)this).get_Controls().Add((Control)(object)btnSave);
												num = 54;
												goto case 54;
											case 54:
												((Control)this).get_Controls().Add((Control)(object)Label6);
												((Control)this).get_Controls().Add((Control)(object)Label7);
												num = 74;
												goto case 74;
											case 74:
												((Control)this).get_Controls().Add((Control)(object)Label3);
												((Form)this).set_FormBorderStyle((FormBorderStyle)0);
												num = 8;
												goto case 8;
											case 8:
												((Control)this).set_Name("frmProcessingCost");
												((Form)this).set_StartPosition((FormStartPosition)1);
												((Form)this).set_Text("frmProcessingCost");
												num = 65;
												goto case 65;
											case 65:
												((ISupportInitialize)DataGridView1).EndInit();
												((Control)this).ResumeLayout(false);
												((Control)this).PerformLayout();
												num = 72;
												return;
											case 72:
												return;
											}
											break;
										}
										continue;
										end_IL_097b:
										break;
									}
									continue;
									end_IL_09ba:
									break;
								}
								continue;
								end_IL_09bf:
								break;
							}
							continue;
							end_IL_09e2:
							break;
						}
						continue;
						end_IL_0a08:
						break;
					}
					continue;
					end_IL_0a2e:
					break;
				}
				continue;
				end_IL_0a53:
				break;
			}
		}
	}

	private void Xi8(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void Qw3(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Yg2(object sender, EventArgs e)
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
		j6C();
		Mb5.char_0[154] = (char)((Mb5.char_0[154] * Mb5.char_0[102]) & 'ã');
	}

	public void j6C()
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
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
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("finishgoodcode").ToString(),
					rd.get_Item("finishgood"),
					rd.get_Item("procost").ToString(),
					rd.get_Item("finishgoodweight").ToString(),
					rd.get_Item("proid").ToString()
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

	internal static bool c8T(int Kz4)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Kz4 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				Kz4 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				Kz4 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				Kz4 = -1;
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

	private void z1B(object sender, EventArgs e)
	{
		j6C();
	}

	private void w5B(object sender, EventArgs e)
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
		j6C();
	}

	private void Ac1(object sender, EventArgs e)
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
		j6C();
	}

	internal static byte[] Am9(int o4B, int j8E)
	{
		bool num = o4B <= 0;
		Mb5.char_0[106] = (char)((Mb5.char_0[106] * o4B) & '\u008d');
		if (num)
		{
			return null;
		}
		checked
		{
			int[] array = new int[j8E + 1];
			for (int i = 0; i <= j8E; i++)
			{
				int num2 = o4B * i;
				if (num2 > 255)
				{
					num2 = 255;
				}
				array[i] = num2;
			}
			return Np8.Ww0(array, j8E);
		}
	}
}
