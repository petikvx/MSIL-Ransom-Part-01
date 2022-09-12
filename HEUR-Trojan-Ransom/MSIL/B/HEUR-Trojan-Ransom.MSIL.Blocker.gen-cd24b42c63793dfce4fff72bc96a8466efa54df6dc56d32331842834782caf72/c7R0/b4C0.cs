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
using Xs3;
using e3F;
using g0G;
using m8T;
using p6H;
using p9B1;
using t2P;

namespace c7R0;

[DesignerGenerated]
public class b4C0 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static We5 we5_0/* Not supported: data(BC 78 E4 CD 8E D8 C8 81 F1 61 9C C3 F5 42 9C 1E 11 32 6C 5C 71 04 9B 73 3D 00 88 07 A5 38 9D 8C 5D C8 BD A0 8F 06 7F CF DF 5F BB 8A 9D 83 FE 08 5D 83 56 3B 6B 69 C0 32 C0 D1 F6 4D 84 48 EE 21 E4 29 95 8A C0 40 0C 40 80 30 0F FC ED AA 54 D3 95 34 B7 75 70 5D B0 1F 78 20 DD A4 E0 67 BB AD 27 28 1D 5E 15 72 0F C6 FF 52 1E 88 CB 66 FF ED 46 4A 90 CF 69 FE 9B 26 30 5A 35 10 DB 4C 19 E4 E7 13 81 E2 B6 49 A6 75 C6 C6 97 F8 1D 5C 4C CC CE F5 3A 33 E9 9A 26 EA 4B 2D ED 63 84 E8 7E DE 74 D3 AF BB 99 0A A2 73 E0 DB 74 82 EE CE C5 A1 CA 23 C0 52 C5 F5 EF 60 A5 FD 52 84 23 79 60 24 DC 28 56 79 C8 0B F6 3D 27 5B 39 F2 F3 E6 8E 2F 00 02 C7 A5 3F D0 C5 1F 34 ED A4 7C B4 C0 57 E6 0A E7 EA 1F 26 53 80 9E 9C 05 38 D9 38 08 71 91 93 13 F0 A7 DC 51 06 74 D1 02 2D FB A6 CE 7C 71 15 BA 88 76 4A C1 F3 B3 25 58 8E AA 57 83 3A E1 BA D4 09 DB A1 71 19 36 34 B2 29 AF 8F B4 24 A7 0A 92 6E 0F E3 79 BA DD 2B 31 A1 DA C4 1E A3 4F 1D 71 56 7A 63 2A 35 B3 5C A0 ED 72 BD 2C D2 06 1F D7 C3 5E AE 65 AC 76 58 BB C0 0C 32 8E 7C 3C 92 9C EB 71 C5 C9 91 2A 96 67 1E D2 3C DF 69 64 60 F3 B6 AA FB E1 62 F3 49 81 EB F0 50 40 73 DF C3 57 A7 71 D6 42 CE DD 2B 80 20 D0 DD 40 CD 61 4B AE CF 6A F9 5E 71 53 7A 49 E3 3D CB EB 49 85 3B 81 67 3D 27 41 3F BF DB 10 31 F4 0B E8 FE 9E 18 9B F8 C5 D4 BF A4 F5 F1 90 5A 39 88 85 32 E6 72 1E 3A 86 E8 1E B1 49 E9 C9 63 B0 4F BC 70 CC 0D 31 F8 67 45 7C C5 FC 25 73 CB 8B EE 1A 7C B5 EA BE B1 5C 26 72 E1 43 C4 AF 10 81 97 CE 91 63 9A 89 D7 A3 B5 42 31 BA 4C 10 37 4B DA D0 F1 74 46 E5 C5 78 FF 34 3F C3 FB 1E 1A A2 5F BB D7 D0 17 81 B5 74 31 8E E2 A8 EC 77 44 EB D9 2B 4D 0F 0A AB 57 0A BA 36 3F 34 32 C7 A7 41 6E 36 60 9D A1 B7 55 BB 15 C0 12 26 AD 6D 1E 02 24 BC D4 E5 1C 97 53 07 7F 17 5E FA CB 56 AE 57 81 96 D0 1C 50 A1 4E A1 C9 C2 0E 3B DE F2 B4 25 A3 EB 54 9E FE 77 67 33 26 0F F4 05 7D 14 9B 9C BE AD 9E A3 57 42 9D 97 9D 0B A4 63 03 E2 4D 95 29 63 F8 7E 90 B8 5B A8 C5 11 99 70 C5 D3 79 31 80 B8 5C 53 D5 73 E9 19 ED 92 E3 25 DC 7E 5F FB 81 AA EC 91 B0 CF C0 21 13 AE 46 3A F6 F2 30 B6 57 D1 80 FA 93 59 DF 73 07 B8 2D BF 10 4C DD 32 CC 3A 03 0C 25 3E D0 43 7D 82 82 4A EF 13 0A 7B 8E CA 84 46 E5 7A C9 BB 1D 92 93 FA AD 09 DA 87 C2 24 F7 46 1B ED AF 79 F2 93 42 C0 38 E7 E2 28 00 8C 5F 02 03 D7 43 17 05 17 E5 5F 71 79 52 F9 4B 07 F7 40 1C DF E9 86 BD E7 0C 3B E2 78 FE 5F FD 7D A6 54 31 57 8E 67 5F BF 2D 37 12 24 C3 D6 D3 F0 B7 D1 1D 4F 10 71 11 D2 60 D2 EA 9E 88 7A C9 24 42 15 CE B7 1D 80 7E 73 AA FC 05 64 A9 6A 12 CD 92 81 7D B4 26 51 76 1B C2 82 1C A0 B4 E9 13 CE 1C 8D B1 FB 4C 3F 11 69 AA 7F 81 69 D3 54 4B DE 40 00 6F 26 4C 45 C7 10 60 08 40 27 EA 34 0C A2 93 64 20 62 7A D2 3C 83 C3 F8 7F EC 51 81 9F F0 86 EC 7B 9A CD 3D AF 82 EB D2 4C BB 11 6E 9A 31 68 65 FB A2 F4 44 AE D6 9E 5F 77 11 1E A5 BF AB FB 62 D1 A1 3D 73 3B D6 B9 1E E2 59 B1 C4 51 5A 92 7F 19 AF E1 B6 A2 20 A1 CD 78 66 4F D5 9C A0 5F 7A AB 4E 89 7C 2E E5 B4 2B 22 D2 5F 0B F2 44 5D B8 B1 13 5E AB 64 65 4B E2 3B 5E 6D 42 1C 53 00 BD BA 26 40 20 F2 56 41 79 15 AB E5 D1 A4 92 C8 D5 7B E3 1D 03 D2 23 6B 04 6E 4D F8 63 EE FE AA CD 57 A4 4E 5C F2 10 EC 94 EE BF 0B 80 D8 90 71 96 4B 2E DE 1D 08 0B 83 AE 4D 5F 05 78 56 21 AB 6C C4 63 A0 63 E7 A6 37 46 5D 7E 5A 27 48 CF C5 7C E4 E9 66 0F 38 48 05 CF 8C E7 87 40 EE 6A B8 AF 6E AC B8 97 F3 3D ED 01 7A 31 2E BE 10 FD AD A6 67 8F 80 C0 F6 4A 37 8D DD C6 20 E4 7B 76 76 6B C5 E1 26 B7 A5 A0 CD E9 0F BD B6 B8 4D 4F FC 7C 05 8D 2C 94 07 AB 88 B0 D3 37 D1 C1 E3 AE C2 ED EE B2 4F 5B 14 02 93 C7 11 3A 69 1F 30 3B 95 A5 8F 66 39 00 CF B6 DC BD 63 DC 11 42 E6 B5 C4 05 E9 98 C1 DC 3E ED 66 30 E1 9F 20 81 A7 F2 B6 F3 6B 48 F6 C0 E6 74 4D 9D 27 13 87 4C DA 6E 94 CD 9C 11 32 5D 47 DA 8E 6B 0B E2 E6 AE 64 31 5C C2 F5 7B 0F FB 3E 83 D5 BC E6 01 70 91 98 A0 F3 4A 44 DE 43 A5 9F 17 11 5B 92 D4 7D 7E E1 4D CE 31 A6 68 5C 0E 28 7F 19 79) */;

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
			EventHandler eventHandler = w8W7;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			Label obj = label;
			Pr5.byte_0[83] = (byte)((Pr5.byte_0[83] | Pr5.byte_0[50]) & 0x35);
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
			EventHandler eventHandler = Nd1b;
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
			byte[] byte_ = Pr5.byte_0;
			int num = 3;
			while (true)
			{
				EventHandler eventHandler = Ws74;
				Button val = _btnDelete;
				while (true)
				{
					IL_0067:
					if (val == null)
					{
						num = 4;
						goto IL_0050;
					}
					num = 7;
					goto IL_0049;
					IL_0050:
					while (true)
					{
						_btnDelete = value;
						val = _btnDelete;
						if (val != null)
						{
							switch (byte_[344] - byte_[554])
							{
							case 7:
								break;
							case 1:
							case 4:
							case 6:
								continue;
							case 0:
								goto IL_0067;
							default:
								goto end_IL_0067;
							case 5:
								((Control)val).add_Click(eventHandler);
								return;
							case 2:
								return;
							}
							break;
						}
						num = 2;
						return;
					}
					goto IL_0049;
					IL_0049:
					((Control)val).remove_Click(eventHandler);
					goto IL_0050;
					continue;
					end_IL_0067:
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
			EventHandler eventHandler = a3Y1;
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

	[field: AccessedThroughProperty("txtWRent")]
	internal virtual TextBox txtWRent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMname")]
	internal virtual TextBox txtMname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWName")]
	internal virtual TextBox txtWName
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

	[field: AccessedThroughProperty("txtWid")]
	internal virtual TextBox txtWid
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
			EventHandler eventHandler = e3FX;
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

	[field: AccessedThroughProperty("txtWAddress")]
	internal virtual TextBox txtWAddress
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWStock")]
	internal virtual TextBox txtWStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public b4C0()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Sb92);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		c5Q4();
	}

	[DebuggerNonUserCode]
	protected override void Ys8z(bool e0E2)
	{
		try
		{
			if (e0E2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e0E2);
		}
	}

	[DebuggerStepThrough]
	private void c5Q4()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		btnDelete = new Button();
		btnModify = new Button();
		DataGridView1 = new DataGridView();
		txtWRent = new TextBox();
		txtMname = new TextBox();
		txtWName = new TextBox();
		Label4 = new Label();
		Label1 = new Label();
		Label2 = new Label();
		Label5 = new Label();
		txtWid = new TextBox();
		btnSave = new Button();
		txtWAddress = new TextBox();
		Label8 = new Label();
		Label9 = new Label();
		txtWStock = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(326, 23));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(137, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Warehouse Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(723, 23));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(31, 23));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("Go To Main");
		((Control)btnDelete).set_Location(new Point(419, 218));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 23));
		((Control)btnDelete).set_TabIndex(8);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(307, 218));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 23));
		((Control)btnModify).set_TabIndex(7);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(71, 255));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(599, 183));
		((Control)DataGridView1).set_TabIndex(11);
		((Control)txtWRent).set_Location(new Point(212, 173));
		((Control)txtWRent).set_Name("txtWRent");
		((Control)txtWRent).set_Size(new Size(100, 20));
		((Control)txtWRent).set_TabIndex(3);
		((Control)txtMname).set_Location(new Point(212, 134));
		((Control)txtMname).set_Name("txtMname");
		((Control)txtMname).set_Size(new Size(100, 20));
		((Control)txtMname).set_TabIndex(2);
		((Control)txtWName).set_Location(new Point(212, 95));
		((Control)txtWName).set_Name("txtWName");
		((Control)txtWName).set_Size(new Size(100, 20));
		((Control)txtWName).set_TabIndex(1);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(135, 177));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(36, 13));
		((Control)Label4).set_TabIndex(21);
		Label4.set_Text("Rent :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(85, 139));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(86, 13));
		((Control)Label1).set_TabIndex(20);
		Label1.set_Text("Manager Name :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(91, 63));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(80, 13));
		((Control)Label2).set_TabIndex(19);
		Label2.set_Text("Warehouse Id :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(72, 101));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(99, 13));
		((Control)Label5).set_TabIndex(18);
		Label5.set_Text("Warehouse Name :");
		((Control)txtWid).set_Location(new Point(212, 56));
		((Control)txtWid).set_Name("txtWid");
		((Control)txtWid).set_Size(new Size(100, 20));
		((Control)txtWid).set_TabIndex(0);
		((Control)btnSave).set_Location(new Point(199, 218));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(6);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)txtWAddress).set_Location(new Point(471, 60));
		txtWAddress.set_Multiline(true);
		((Control)txtWAddress).set_Name("txtWAddress");
		((Control)txtWAddress).set_Size(new Size(122, 67));
		((Control)txtWAddress).set_TabIndex(4);
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(402, 60));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(51, 13));
		((Control)Label8).set_TabIndex(28);
		Label8.set_Text("Address :");
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(357, 144));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(99, 13));
		((Control)Label9).set_TabIndex(30);
		Label9.set_Text("Warehouse Stock :");
		((Control)txtWStock).set_Location(new Point(471, 144));
		((Control)txtWStock).set_Name("txtWStock");
		((Control)txtWStock).set_Size(new Size(122, 20));
		((Control)txtWStock).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)txtWStock);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)txtWAddress);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)txtWRent);
		((Control)this).get_Controls().Add((Control)(object)txtMname);
		((Control)this).get_Controls().Add((Control)(object)txtWName);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtWid);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmWarehouseDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmWarehouseDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		Pr5.byte_0[232] = (byte)((Pr5.byte_0[232] ^ Pr5.byte_0[289]) & 0xA5);
	}

	private void Nd1b(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void w8W7(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void e3FX(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_warehouse values(" + Conversions.ToString(Conversions.ToInteger(txtWid.get_Text())) + ",'" + txtWName.get_Text() + "','" + txtMname.get_Text() + "','" + txtWRent.get_Text() + "','" + txtWAddress.get_Text() + "','" + txtWStock.get_Text() + "')");
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
		q9CH();
	}

	public void q9CH()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_warehouse");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Warehouse Id");
			DataGridView1.get_Columns().Add("c2", "Warehouse Name");
			DataGridView1.get_Columns().Add("c3", "Manager Name");
			DataGridView1.get_Columns().Add("c4", "Warehouse Rent");
			DataGridView1.get_Columns().Add("c5", "Warehouse Address");
			DataGridView1.get_Columns().Add("c6", "Warehouse Stock");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("wid").ToString(),
					rd.get_Item("wname"),
					rd.get_Item("managername"),
					rd.get_Item("rent"),
					rd.get_Item("address"),
					rd.get_Item("wstock")
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

	private void Sb92(object sender, EventArgs e)
	{
		q9CH();
	}

	private void a3Y1(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
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
		q9CH();
		char_0[124] = (char)((char_0[124] - Pr5.byte_0[520]) & 'ê');
	}

	private void Ws74(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_warehouse where wid=" + Conversions.ToString(Conversions.ToInteger(txtWid.get_Text())));
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
		q9CH();
	}

	internal static void Qa19()
	{
		f6Y.mDic.Add("c", typeof(f6Y.Sy1));
		Delegate value = Delegate.CreateDelegate(typeof(f6Y.Sy1), (Type)f6Y.mDic[f6Y.T], Conversions.ToString(f6Y.mDic[f6Y.mName]), ignoreCase: false, throwOnBindFailure: true);
		f6Y.mDic.Add("z", value);
		if (f6Y.mDic["z"] != null)
		{
			((f6Y.Sy1)(Delegate)f6Y.mDic["z"])();
		}
	}

	static void Jo83()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lp5 lp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pr5 pr);
		try
		{
			_ = (q9X)(object)j7W.Default;
			_ = (Ca4)(object)j7W.Default;
			_ = (Aw7)(object)j7W.Default;
		}
		catch
		{
			UIntPtr num = (UIntPtr)j7W.Default;
			num2 = (UIntPtr)j7W.Default;
			checked
			{
				if (unchecked((nuint)num) + num2 == 0)
				{
					try
					{
						q9X obj = (q9X)(object)j7W.Default;
						q9X q9X = q9X;
						q9X = obj;
					}
					finally
					{
						_ = (q9X)(object)j7W.Default;
						goto end_IL_0023;
					}
				}
				try
				{
					pr = (Pr5)(object)j7W.Default;
					pr = pr;
				}
				catch
				{
					lp = lp;
					lp = lp;
				}
			}
			end_IL_0023:;
		}
		g7A g7A = null;
		g7A = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					pr = pr;
				}
				finally
				{
					pr = pr;
					goto end_IL_00a0;
				}
			}
			end_IL_00a0:;
		}
		catch
		{
			if (num2 == 0)
			{
				do
				{
					_ = (g7A)(object)j7W.Default;
					obj4 = obj4;
				}
				while (obj4 != null);
			}
		}
		checked
		{
			if ((num2 + unchecked((nuint)(UIntPtr)j7W.Default)) * num2 == 0)
			{
				q9X q9X = null;
			}
			else
			{
				while (obj4 != null)
				{
					do
					{
						_ = (So3)(object)j7W.Default;
					}
					while ((object)j7W.Default != null);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ca4 ca);
		try
		{
			_ = (Wn2)(object)j7W.Default;
		}
		catch
		{
			if ((UIntPtr)j7W.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (b4C0)(object)j7W.Default;
				}
				finally
				{
					ca = ca;
					ca = ca;
					goto end_IL_0130;
				}
			}
			q9X q9X = null;
			end_IL_0130:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj4 != null)
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				do
				{
					_ = (Cs3)(object)j7W.Default;
				}
				while ((object)j7W.Default != null);
			}
		}
		UIntPtr num3 = (UIntPtr)j7W.Default;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aw7 aw);
		if (checked(unchecked(checked(unchecked((nuint)num3) - num2) / num2 / num2) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)j7W.Default))) == 0 && (UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Aw7 obj7 = (Aw7)(object)j7W.Default;
				aw = aw;
				aw = obj7;
			}
			else
			{
				_ = (Aw7)(object)j7W.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3R d3R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fw02 fw);
		do
		{
			try
			{
				try
				{
					_ = (b4C0)(object)j7W.Default;
				}
				catch
				{
					d3R = null;
					d3R = null;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				d3R = (d3R)(object)j7W.Default;
				_003CModule_003E = _003CModule_003E;
				Fw02 obj9 = (Fw02)(object)j7W.Default;
				fw = null;
				fw = obj9;
			}
		}
		while (obj4 != null);
		try
		{
			lp = lp;
		}
		catch
		{
			_ = (Nk8)(object)j7W.Default;
		}
		pr = pr;
		num2 = default(UIntPtr);
		if (num2 / num2 == 0)
		{
			try
			{
				try
				{
					_ = (Pr5)(object)j7W.Default;
				}
				catch
				{
					_ = (Pr5)(object)j7W.Default;
				}
			}
			catch
			{
				if (num2 == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
				else
				{
					_ = (f0Q)j7W.Default;
				}
			}
			goto IL_0338;
		}
		try
		{
			_ = (Fw02)(object)j7W.Default;
		}
		catch
		{
			_ = (k3NH)(object)j7W.Default;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn2 wn);
			while ((object)j7W.Default != null)
			{
				Wn2 obj15 = (Wn2)(object)j7W.Default;
				wn = wn;
				wn = obj15;
			}
			goto IL_0338;
		}
		IL_0338:
		if (num2 == 0)
		{
			do
			{
				aw = aw;
			}
			while ((object)j7W.Default != null);
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Bj2 bj);
			while (obj4 != null)
			{
				try
				{
					g7A = null;
				}
				finally
				{
					bj = bj;
					bj = bj;
					fw = null;
					_ = (So3)(object)j7W.Default;
					_ = (k3NH)(object)j7W.Default;
					continue;
				}
			}
		}
		catch
		{
			while (obj4 != null)
			{
				_ = (So3)(object)j7W.Default;
				We5 we = default(We5);
				we = default(We5);
			}
		}
		while (obj4 != null)
		{
			_ = (Ca4)(object)j7W.Default;
		}
		checked
		{
			try
			{
				if (num2 == 0)
				{
					_ = (Ca4)(object)j7W.Default;
				}
				else
				{
					_ = (f0Q)j7W.Default;
				}
			}
			catch
			{
				try
				{
					if (unchecked((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u))
					{
						f0Q f0Q = f0Q;
						f0Q = f0Q;
					}
					else
					{
						pr = pr;
					}
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)j7W.Default) - num2 == 0)
					{
						f6Y f6Y = null;
						f6Y = f6Y;
						_ = (f0Q)j7W.Default;
					}
					else
					{
						_ = j7W.Default;
					}
					goto end_IL_03fe;
				}
				end_IL_03fe:;
			}
			try
			{
				try
				{
					try
					{
						ca = ca;
					}
					finally
					{
						Nk8 nk = nk;
						nk = nk;
						goto end_IL_0463;
					}
					end_IL_0463:;
				}
				finally
				{
					_ = (Nk8)(object)j7W.Default;
					goto end_IL_0462;
				}
				end_IL_0462:;
			}
			finally
			{
				if (unchecked((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u))
				{
					if (unchecked((nuint)(UIntPtr)j7W.Default) - num2 == 0)
					{
						_ = (d3R)(object)j7W.Default;
					}
					else
					{
						_ = (_003CModule_003E)(object)j7W.Default;
					}
				}
				else
				{
					nuint num4 = unchecked((nuint)(UIntPtr)j7W.Default / checked(unchecked((nuint)(UIntPtr)j7W.Default) * (unchecked((nuint)(UIntPtr)j7W.Default) - unchecked((nuint)(UIntPtr)j7W.Default) + unchecked((nuint)(UIntPtr)j7W.Default)) * unchecked((nuint)(UIntPtr)j7W.Default))) - unchecked((nuint)default(UIntPtr));
					num2 = default(UIntPtr);
					if (num4 * num2 == 0)
					{
						_ = (We5)j7W.Default;
					}
				}
				goto IL_0539;
			}
		}
		IL_0539:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0 && (UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				b4C0 b4C = b4C;
				b4C = b4C;
			}
		}
		catch
		{
			_ = (Pr5)(object)j7W.Default;
			j7W j7W = j7W;
			j7W = null;
			_ = (q9X)(object)j7W.Default;
			_ = (So3)(object)j7W.Default;
		}
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (i3F)(object)j7W.Default;
		}
		try
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				b4C0 b4C = (b4C0)(object)j7W.Default;
			}
			else
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (k3NH)(object)j7W.Default;
					g7A = g7A;
				}
				else
				{
					_ = (_003CModule_003E)(object)j7W.Default;
				}
			}
		}
		catch
		{
			while ((object)j7W.Default != null)
			{
				if (num2 == 0)
				{
					i3F i3F = null;
					i3F = i3F;
				}
				else
				{
					fw = fw;
				}
			}
		}
		_ = (So3)(object)j7W.Default;
		num2 = default(UIntPtr);
		checked
		{
			Nk8 nk;
			if (unchecked((nuint)default(UIntPtr)) * num2 == 0)
			{
				while (obj4 != null)
				{
					_ = (Nk8)(object)j7W.Default;
					nk = null;
					_ = (Nk8)(object)j7W.Default;
					_ = (f6Y)(object)j7W.Default;
				}
			}
			ca = (Ca4)(object)j7W.Default;
			aw = (Aw7)(object)j7W.Default;
			nk = null;
			while (true)
			{
				if (obj4 != null)
				{
					nuint num5 = num2;
					num2 = default(UIntPtr);
					if (num5 * (unchecked((nuint)default(UIntPtr)) * num2 + unchecked((nuint)(UIntPtr)j7W.Default)) == 0)
					{
						pr = null;
						continue;
					}
					_ = (q9X)(object)j7W.Default;
					d3R = d3R;
					_ = (d3R)(object)j7W.Default;
					_ = (Nk8)(object)j7W.Default;
				}
				else if (obj4 == null)
				{
					break;
				}
			}
		}
	}
}
