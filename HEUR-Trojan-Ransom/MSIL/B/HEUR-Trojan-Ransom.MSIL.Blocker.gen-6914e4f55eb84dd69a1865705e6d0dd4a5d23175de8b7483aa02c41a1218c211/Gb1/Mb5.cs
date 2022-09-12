using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bx3;
using Dn7;
using Dy1a;
using Hc8;
using Hf9e;
using Hj8;
using Lj1k;
using Microsoft.VisualBasic.CompilerServices;
using Qw80;
using Ss0;
using Tb3;
using c5E;
using c6R;
using g5S;
using i3L;
using o8Z;
using p0H;
using q3F;
using q8X;
using z2Z;

namespace Gb1;

[DesignerGenerated]
public class Mb5 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static r8M r8M_0/* Not supported: data(18 59 83 0E 3C D5 39 EF ED AA 70 56 0B 34 1B 8C 3E 96 E7 89 BB C6 04 7D FB 19 E6 13 5C 09 7D 71 22 ED AE CD 89 67 0D B2 44 D1 C7 FD BC D8 53 9F AE 0B 3E 83 9D B0 A6 F5 A8 B0 C9 20 95 AA 09 CB 34 31 E7 68 A7 B5 FA FF 18 3F 61 95 F3 69 02 83 02 00 C9 3B 92 05 6D 0C 92 23 B7 3A DE FE 30 2B F1 F7 C5 C7 46 14 9D 43 92 D7 C7 ED 19 AC 50 5B C5 35 E8 35 8A E3 AE 27 D1 A5 63 3E 72 DB 74 75 50 DF B1 FB D0 4B 12 B1 3E 5E 60 09 64 32 C1 57 BB 63 86 E4 0A B2 7A 95 34 F8 4F CC C0 7B F6 D0 5F 84 6D 85 B4 FD E1 E8 83 0C F7 66 76 F3 6C 43 CC BC 56 5A 34 CA 2F 09 D5 B1 44 42 2F DD 9E C1 56 60 1D 90 1B 2D E0 27 E6 EE CB 4D F0 CC 90 EE 60 95 84 BC E1 DF 0A F3 BC 3B 9F 16 1B 63 75 69 27 BA 94 12 4E A3 64 20 AE 40 8F F2 F1 68 58 78 3B 08 63 08 45 F4 E8 03 2B 3F 34 29 EA A5 76 21 56 07 6B F0 24 35 17 68 33 9F E0 53 0E E2 94 36 7C B8 24 0F 81 53 FD 4F 15 87 6B 00 AF 07 2C A6 39 F7 BF 60 07 4F 41 9F F5 9E CB BC EF 80 C5 6D 2B 27 C1 B4 A4 1F 82 E6 84 59 07 C9 64 AF 2C 6C 9A 16 6A BE B3 EB 50 4B 7A E1 03 FB 40 CA 46 66 84 30 B9 6C E7 67 8A 31 0E 9F F3 18 42 F1 CF 07 B4 00 18 4E AD 0C 6A DE 2B DA A9 06 80 82 8A 4A 7B 6F 5D C7 EB 40 71 EA 3B 34 8B FB 0E DD 73 EF BE 5F 54 E7 63 39 A9 C8 B6 14 5D BC B1 C4 35 FC 7E 96 C0 E8 BC 6E 3B 32 E4 54 65 4F B6 CE 38 0E 7E C3 D5 17 CE E5 6C 0B 5A BC F8 D0 FF 91 F0 0F) */;

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
			EventHandler eventHandler = z1L;
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
			EventHandler eventHandler = Lb5;
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

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
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
			EventHandler eventHandler = Yq3;
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
			EventHandler eventHandler = Zf6;
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

	[field: AccessedThroughProperty("txtPCode")]
	internal virtual TextBox txtPCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPRaw")]
	internal virtual TextBox txtPRaw
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

	[field: AccessedThroughProperty("txtPDate")]
	internal virtual TextBox txtPDate
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
			EventHandler eventHandler = Xy9;
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("txtRWeight")]
	internal virtual TextBox txtRWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Mb5()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)p7P);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Qy7();
	}

	[DebuggerNonUserCode]
	protected override void k0N(bool Jr9)
	{
		try
		{
			if (Jr9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jr9);
		}
		char_0[108] = (char)((char_0[108] ^ char_0[121]) & 'ö');
	}

	[DebuggerStepThrough]
	private void Qy7()
	{
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected O, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected O, but got Unknown
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected O, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected O, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected O, but got Unknown
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected O, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected O, but got Unknown
		char[] array = char_0;
		byte[] byte_ = Pj8.byte_0;
		int num = 40;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 72;
			while (true)
			{
				txtPId = new TextBox();
				btnDelete = new Button();
				btnModify = new Button();
				num = 5;
				while (true)
				{
					DataGridView1 = new DataGridView();
					txtPCode = new TextBox();
					txtPMachine = new TextBox();
					num = 28;
					while (true)
					{
						txtPRaw = new TextBox();
						Label2 = new Label();
						txtPDate = new TextBox();
						num = 13;
						while (true)
						{
							btnSave = new Button();
							Label1 = new Label();
							Label4 = new Label();
							num = 66;
							while (true)
							{
								Label5 = new Label();
								Label8 = new Label();
								Label9 = new Label();
								num = array[126] - 42407;
								while (true)
								{
									switch (num)
									{
									case 80:
										((Control)txtPCode).set_TabIndex(4);
										((Control)txtPMachine).set_Location(new Point(242, 156));
										num = 4;
										goto case 4;
									case 4:
										((Control)txtPMachine).set_Name("txtPMachine");
										((Control)txtPMachine).set_Size(new Size(100, 20));
										num = 54;
										goto case 54;
									case 54:
										((Control)txtPMachine).set_TabIndex(3);
										((Control)txtPRaw).set_Location(new Point(242, 129));
										num = 15;
										goto case 15;
									case 15:
										((Control)txtPRaw).set_Name("txtPRaw");
										((Control)txtPRaw).set_Size(new Size(100, 20));
										num = 20;
										goto case 20;
									case 20:
										((Control)txtPRaw).set_TabIndex(2);
										Label2.set_AutoSize(true);
										num = 10;
										goto case 10;
									case 10:
										((Control)Label2).set_ForeColor(Color.White);
										((Control)Label2).set_Location(new Point(164, 75));
										num = 55;
										goto case 55;
									case 55:
										((Control)Label2).set_Name("Label2");
										((Control)Label2).set_Size(new Size(63, 13));
										num = 68;
										goto case 68;
									case 68:
										((Control)Label2).set_TabIndex(33);
										Label2.set_Text("Process Id :");
										num = 64;
										goto case 64;
									case 64:
										((Control)txtPDate).set_Location(new Point(242, 99));
										goto case 35;
									case 35:
										((Control)txtPDate).set_Name("txtPDate");
										num = 30;
										goto case 30;
									case 30:
										((Control)txtPDate).set_Size(new Size(100, 20));
										((Control)txtPDate).set_TabIndex(1);
										num = 33;
										goto case 33;
									case 33:
										((Control)btnSave).set_Location(new Point(417, 72));
										((Control)btnSave).set_Name("btnSave");
										num = 65;
										goto case 65;
									case 65:
										((Control)btnSave).set_Size(new Size(75, 31));
										((Control)btnSave).set_TabIndex(6);
										num = 60;
										goto case 60;
									case 60:
										((ButtonBase)btnSave).set_Text("SAVE");
										((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
										num = 23;
										goto case 23;
									case 23:
										Label1.set_AutoSize(true);
										((Control)Label1).set_ForeColor(Color.White);
										num = 25;
										goto case 25;
									case 25:
										((Control)Label1).set_Location(new Point(150, 102));
										((Control)Label1).set_Name("Label1");
										num = 73;
										goto case 73;
									case 73:
										((Control)Label1).set_Size(new Size(77, 13));
										((Control)Label1).set_TabIndex(43);
										num = 32;
										goto case 32;
									case 32:
										Label1.set_Text("Process Date :");
										Label4.set_AutoSize(true);
										num = 26;
										goto case 26;
									case 26:
										((Control)Label4).set_ForeColor(Color.White);
										((Control)Label4).set_Location(new Point(150, 136));
										num = byte_[238] - 3;
										continue;
									case 77:
										((Control)txtPId).set_Location(new Point(242, 72));
										((Control)txtPId).set_Name("txtPId");
										num = 27;
										goto case 27;
									case 27:
										((Control)txtPId).set_Size(new Size(100, 20));
										((Control)txtPId).set_TabIndex(0);
										num = 3;
										goto case 3;
									case 3:
										((Control)btnDelete).set_Location(new Point(417, 183));
										((Control)btnDelete).set_Name("btnDelete");
										num = 58;
										goto case 58;
									case 58:
										((Control)btnDelete).set_Size(new Size(75, 31));
										((Control)btnDelete).set_TabIndex(8);
										num = 71;
										goto case 71;
									case 71:
										((ButtonBase)btnDelete).set_Text("DELETE");
										((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
										num = 34;
										goto case 34;
									case 34:
										((Control)btnModify).set_Location(new Point(417, 129));
										((Control)btnModify).set_Name("btnModify");
										num = 41;
										goto case 41;
									case 41:
										((Control)btnModify).set_Size(new Size(75, 31));
										((Control)btnModify).set_TabIndex(7);
										num = 29;
										goto case 29;
									case 29:
										((ButtonBase)btnModify).set_Text("MODIFY");
										((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
										num = 39;
										goto case 39;
									case 39:
										DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
										((Control)DataGridView1).set_Location(new Point(53, 241));
										num = 51;
										goto case 51;
									case 51:
										((Control)DataGridView1).set_Name("DataGridView1");
										((Control)DataGridView1).set_Size(new Size(707, 206));
										num = 8;
										goto case 8;
									case 8:
										((Control)DataGridView1).set_TabIndex(11);
										((Control)txtPCode).set_Location(new Point(242, 183));
										num = 61;
										goto case 61;
									case 61:
										((Control)txtPCode).set_Name("txtPCode");
										((Control)txtPCode).set_Size(new Size(100, 20));
										num = 80;
										goto case 80;
									case 75:
										((Control)Label4).set_TabIndex(44);
										Label4.set_Text("Process Raw :");
										num = 74;
										goto case 74;
									case 74:
										Label5.set_AutoSize(true);
										((Control)Label5).set_ForeColor(Color.White);
										num = byte_[273] * 2;
										continue;
									case 70:
										((Control)Label7).set_Name("Label7");
										((Control)Label7).set_Size(new Size(92, 17));
										num = 12;
										goto case 12;
									case 12:
										((Control)Label7).set_TabIndex(9);
										Label7.set_Text("Go To Main");
										num = 77;
										goto case 77;
									case 67:
										txtRWeight = new TextBox();
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										num = 63;
										goto case 63;
									case 63:
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 46;
										goto case 46;
									case 46:
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(331, 27));
										num = 52;
										goto case 52;
									case 52:
										((Control)Label3).set_Name("Label3");
										((Control)Label3).set_Size(new Size(135, 17));
										num = 47;
										goto case 47;
									case 47:
										((Control)Label3).set_TabIndex(9);
										Label3.set_Text("Processing Detail");
										num = 6;
										goto case 6;
									case 6:
										Label6.set_AutoSize(true);
										((Control)Label6).set_BackColor(Color.Blue);
										num = 0;
										goto case 0;
									case 0:
										((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 62;
										goto case 62;
									case 62:
										((Control)Label6).set_ForeColor(Color.White);
										((Control)Label6).set_Location(new Point(742, 27));
										num = 42;
										goto case 42;
									case 42:
										((Control)Label6).set_Name("Label6");
										((Control)Label6).set_Size(new Size(18, 17));
										num = 9;
										goto case 9;
									case 9:
										((Control)Label6).set_TabIndex(10);
										Label6.set_Text("X");
										num = 53;
										goto case 53;
									case 53:
										Label7.set_AutoSize(true);
										((Control)Label7).set_BackColor(Color.Blue);
										num = 49;
										goto case 49;
									case 49:
										((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 21;
										goto case 21;
									case 21:
										((Control)Label7).set_ForeColor(Color.White);
										((Control)Label7).set_Location(new Point(50, 27));
										num = 70;
										goto case 70;
									case 43:
										((Control)Label4).set_Name("Label4");
										((Control)Label4).set_Size(new Size(76, 13));
										num = 75;
										goto case 75;
									case 66:
										break;
									case 13:
										goto end_IL_0881;
									case 28:
										goto end_IL_08b2;
									case 5:
										goto end_IL_08d8;
									case 37:
									case 72:
										goto end_IL_08fe;
									default:
										goto end_IL_0924;
									case 36:
										((Control)Label5).set_Location(new Point(132, 163));
										((Control)Label5).set_Name("Label5");
										num = 57;
										goto case 57;
									case 57:
										((Control)Label5).set_Size(new Size(95, 13));
										((Control)Label5).set_TabIndex(45);
										num = 11;
										goto case 11;
									case 11:
										Label5.set_Text("Process Machine :");
										Label8.set_AutoSize(true);
										num = 50;
										goto case 50;
									case 50:
										((Control)Label8).set_ForeColor(Color.White);
										((Control)Label8).set_Location(new Point(134, 186));
										num = 48;
										goto case 48;
									case 48:
										((Control)Label8).set_Name("Label8");
										((Control)Label8).set_Size(new Size(93, 13));
										num = 31;
										goto case 31;
									case 31:
										((Control)Label8).set_TabIndex(46);
										Label8.set_Text("Processing Code :");
										num = 16;
										goto case 16;
									case 16:
										Label9.set_AutoSize(true);
										((Control)Label9).set_ForeColor(Color.White);
										num = 45;
										goto case 45;
									case 45:
										((Control)Label9).set_Location(new Point(155, 212));
										((Control)Label9).set_Name("Label9");
										num = 78;
										goto case 78;
									case 78:
										((Control)Label9).set_Size(new Size(72, 13));
										((Control)Label9).set_TabIndex(48);
										num = 7;
										goto case 7;
									case 7:
										Label9.set_Text("Raw Weight :");
										((Control)txtRWeight).set_Location(new Point(242, 209));
										num = 2;
										goto case 2;
									case 2:
										((Control)txtRWeight).set_Name("txtRWeight");
										((Control)txtRWeight).set_Size(new Size(100, 20));
										num = 17;
										goto case 17;
									case 17:
										((Control)txtRWeight).set_TabIndex(5);
										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
										num = 59;
										goto case 59;
									case 59:
										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
										num = 82;
										goto case 82;
									case 82:
										((Form)this).set_ClientSize(new Size(800, 450));
										((Control)this).get_Controls().Add((Control)(object)Label9);
										num = 44;
										goto case 44;
									case 44:
										((Control)this).get_Controls().Add((Control)(object)txtRWeight);
										((Control)this).get_Controls().Add((Control)(object)Label8);
										num = 38;
										goto case 38;
									case 38:
										((Control)this).get_Controls().Add((Control)(object)Label5);
										((Control)this).get_Controls().Add((Control)(object)Label4);
										num = 18;
										goto case 18;
									case 18:
										((Control)this).get_Controls().Add((Control)(object)Label1);
										((Control)this).get_Controls().Add((Control)(object)txtPId);
										num = 24;
										goto case 24;
									case 24:
										((Control)this).get_Controls().Add((Control)(object)btnDelete);
										((Control)this).get_Controls().Add((Control)(object)btnModify);
										num = 56;
										goto case 56;
									case 56:
										((Control)this).get_Controls().Add((Control)(object)DataGridView1);
										((Control)this).get_Controls().Add((Control)(object)txtPCode);
										num = 79;
										goto case 79;
									case 79:
										((Control)this).get_Controls().Add((Control)(object)txtPMachine);
										((Control)this).get_Controls().Add((Control)(object)txtPRaw);
										num = 14;
										goto case 14;
									case 14:
										((Control)this).get_Controls().Add((Control)(object)Label2);
										((Control)this).get_Controls().Add((Control)(object)txtPDate);
										num = 19;
										goto case 19;
									case 19:
										((Control)this).get_Controls().Add((Control)(object)btnSave);
										goto case 69;
									case 69:
										((Control)this).get_Controls().Add((Control)(object)Label6);
										num = 76;
										goto case 76;
									case 76:
										((Control)this).get_Controls().Add((Control)(object)Label7);
										((Control)this).get_Controls().Add((Control)(object)Label3);
										num = 22;
										goto case 22;
									case 22:
										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
										((Control)this).set_Name("frmProcessingDetail");
										((Form)this).set_StartPosition((FormStartPosition)1);
										num = 1;
										goto case 1;
									case 1:
										((Form)this).set_Text("frmProcessingDetail");
										((ISupportInitialize)DataGridView1).EndInit();
										((Control)this).ResumeLayout(false);
										num = 81;
										goto case 81;
									case 81:
										((Control)this).PerformLayout();
										return;
									}
									break;
								}
								continue;
								end_IL_0881:
								break;
							}
							continue;
							end_IL_08b2:
							break;
						}
						continue;
						end_IL_08d8:
						break;
					}
					continue;
					end_IL_08fe:
					break;
				}
				continue;
				end_IL_0924:
				break;
			}
		}
	}

	private void Lb5(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void z1L(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void p7P(object sender, EventArgs e)
	{
	}

	private void Xy9(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ",'" + txtPDate.get_Text() + "','" + txtPRaw.get_Text() + "','" + txtPMachine.get_Text() + "','" + txtPCode.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtRWeight.get_Text())) + ")");
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
		y1D();
	}

	public void y1D()
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Processing Id");
			DataGridView1.get_Columns().Add("c2", "Processing Date");
			DataGridView1.get_Columns().Add("c3", "Processing Raw");
			DataGridView1.get_Columns().Add("c4", "Processing Machine");
			DataGridView1.get_Columns().Add("c5", "Processing Code");
			DataGridView1.get_Columns().Add("c6", "Raw Weight");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("proid").ToString(),
					rd.get_Item("prodate"),
					rd.get_Item("proraw"),
					rd.get_Item("promachine"),
					rd.get_Item("procode"),
					rd.get_Item("rawweight").ToString()
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

	internal static void Qe8()
	{
		char[] array = char_0;
		int num = 1;
		while (true)
		{
			byte[] o0GR = x8D9.Qg5(133632);
			int num2 = checked(Conversions.ToInteger(Eb1.mDic[Eb1.sNum]) * 3);
			num = 7;
			while (true)
			{
				if (num2 > 255)
				{
					num = 3;
					while (true)
					{
						num2 = 255;
						switch (array[13])
						{
						case 'Ꮰ':
							break;
						case 'Ꮲ':
						case 'Ꮴ':
							goto end_IL_000f;
						default:
							goto end_IL_0053;
						case 'Ꮶ':
							goto IL_008a;
						case 'Ꮵ':
							goto IL_00b9;
						case 'Ꮯ':
							goto IL_00c3;
						case 'Ꮭ':
							goto IL_00c8;
						case 'Ꮱ':
							goto IL_00d0;
						case 'Ꮳ':
							return;
						}
						continue;
						end_IL_000f:
						break;
					}
					continue;
				}
				num = 9;
				goto IL_008a;
				IL_00d0:
				Pj8.byte_0[89] = (byte)(Pj8.byte_0[89] & Pj8.byte_0[386] & 0x79);
				return;
				IL_00c8:
				num = 4;
				goto IL_00d0;
				IL_00c3:
				d4E.c4Y();
				goto IL_00c8;
				IL_008a:
				Eb1.mDic.Add(Eb1.mArray, d1X.Zs24(o0GR, (byte[])Eb1.mDic[Eb1.sArray], num2, 25));
				num = 8;
				goto IL_00b9;
				IL_00b9:
				if (f0F.Ta2())
				{
					num = 2;
					goto IL_00c3;
				}
				num = 4;
				goto IL_00d0;
				continue;
				end_IL_0053:
				break;
			}
		}
	}

	private void Zf6(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_detail set prodate ='" + txtPDate.get_Text() + "',proraw='" + txtPRaw.get_Text() + "',promachine='" + txtPMachine.get_Text() + "' where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		y1D();
	}

	private void Yq3(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_detail where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		y1D();
	}

	internal static void Yk5()
	{
		byte[] byte_ = Pj8.byte_0;
		int num = 1;
		while (true)
		{
			string[] p6R = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
			num = 5;
			while (true)
			{
				string value = m0N.Pi1(p6R, 0, 3);
				while (true)
				{
					string value2 = m0N.Pi1(p6R, 4, 7);
					while (true)
					{
						switch (byte_[96])
						{
						case 78:
							break;
						case 80:
							goto end_IL_000c;
						case 79:
						case 81:
							goto end_IL_0037;
						default:
							goto end_IL_0042;
						case 76:
							Eb1.mDic.Add(Eb1.tName, value);
							Eb1.mDic.Add(Eb1.mName, value2);
							Pj8.byte_0[424] = (byte)((Pj8.byte_0[424] + Pj8.byte_0[213]) & 0x4E);
							return;
						}
						continue;
						end_IL_000c:
						break;
					}
					continue;
					end_IL_0037:
					break;
				}
				continue;
				end_IL_0042:
				break;
			}
		}
	}

	static void b6D()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		try
		{
			num = num;
			if (num != 0)
			{
				try
				{
					np = (Np8)(object)Nf2.Default;
					np = np;
				}
				finally
				{
					d4E obj = (d4E)(object)Nf2.Default;
					d4E = d4E;
					d4E = obj;
					goto end_IL_0000;
				}
			}
			m0N = null;
			m0N = m0N;
			end_IL_0000:;
		}
		catch
		{
			f2L = (f2L)(object)Nf2.Default;
			f2L = f2L;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4R w4R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		if (num == 0)
		{
			_ = (Eb1)(object)Nf2.Default;
		}
		else
		{
			try
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (num2 / num == 0)
				{
					mb = mb;
					mb = mb;
				}
			}
			catch
			{
				try
				{
					w4R = (w4R)(object)Nf2.Default;
					w4R = w4R;
				}
				finally
				{
					_ = (f0F)(object)Nf2.Default;
					goto end_IL_00a4;
				}
				end_IL_00a4:;
			}
		}
		object obj4;
		while (true)
		{
			obj4 = Nf2.Default;
			if (obj4 == null)
			{
				break;
			}
			do
			{
				_ = (k6D9)(object)Nf2.Default;
			}
			while ((object)Nf2.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eb1 eb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		try
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					r8M = r8M;
					r8M = default(r8M);
					r8M = r8M;
				}
				else
				{
					d1X = d1X;
					d1X = d1X;
				}
			}
			catch
			{
				try
				{
					k6D = k6D;
					k6D = k6D;
					d1X = d1X;
					d8B obj5 = (d8B)(object)Nf2.Default;
					d8B = (d8B)(object)Nf2.Default;
					d8B = obj5;
					_ = (f9T6)(object)Nf2.Default;
				}
				catch
				{
					r8M = r8M;
				}
			}
		}
		catch
		{
			if (num != 0)
			{
				if (num == 0)
				{
					_ = (r8M)Nf2.Default;
				}
				else
				{
					eb = eb;
					eb = eb;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		try
		{
			_ = (Pm9)(object)Nf2.Default;
		}
		catch
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					Co4 obj9 = (Co4)(object)Nf2.Default;
					co = null;
					co = obj9;
				}
			}
			finally
			{
				while (obj4 != null)
				{
					w4R = w4R;
				}
				goto end_IL_01bd;
			}
			end_IL_01bd:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		try
		{
			try
			{
				do
				{
					pm = pm;
					pm = null;
					_ = (f9T6)(object)Nf2.Default;
					_ = (d1X)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
			finally
			{
				do
				{
					w4R = null;
				}
				while (obj4 != null);
				goto end_IL_01f8;
			}
			end_IL_01f8:;
		}
		finally
		{
			try
			{
				checked
				{
					nuint num3 = unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)(UIntPtr)Nf2.Default);
					num = default(UIntPtr);
					if (num3 - num + unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						eb = eb;
					}
				}
			}
			finally
			{
				if ((nuint)(UIntPtr)Nf2.Default / (nuint)(UIntPtr)Nf2.Default == 0)
				{
					_ = (x8D9)(object)Nf2.Default;
				}
				else
				{
					eb = (Eb1)(object)Nf2.Default;
					pm = pm;
				}
				goto IL_02b5;
			}
		}
		IL_0717:
		try
		{
			try
			{
				_ = (Np8)(object)Nf2.Default;
			}
			catch
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		catch
		{
			try
			{
				d1X = d1X;
			}
			catch
			{
				_ = (f2L)(object)Nf2.Default;
			}
		}
		finally
		{
			try
			{
				m0N = null;
			}
			finally
			{
				while (obj4 != null)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				goto IL_0774;
			}
		}
		IL_04c9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			try
			{
				try
				{
					num = default(UIntPtr);
					if (num * unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						_ = (w4R)(object)Nf2.Default;
					}
					else
					{
						gj = gj;
						f0F f0F = null;
						_ = (f9T6)(object)Nf2.Default;
						_003CModule_003E = null;
						_003CModule_003E = _003CModule_003E;
					}
				}
				catch
				{
					do
					{
						_ = (d4E)(object)Nf2.Default;
						_ = (f0F)(object)Nf2.Default;
					}
					while (obj4 != null);
				}
			}
			catch
			{
				_ = (w4R)(object)Nf2.Default;
			}
			try
			{
				if (num == 0)
				{
					try
					{
						_ = (w4R)(object)Nf2.Default;
					}
					catch
					{
						co = co;
						_ = (f2L)(object)Nf2.Default;
						_ = (Pj8)(object)Nf2.Default;
						f0F f0F = null;
					}
				}
			}
			finally
			{
				goto IL_0592;
			}
		}
		IL_0692:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		try
		{
			d4E = null;
		}
		catch
		{
			x8D = null;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				try
				{
					_ = (f2L)(object)Nf2.Default;
					m0N = (m0N)(object)Nf2.Default;
					_ = (k6D9)(object)Nf2.Default;
					_ = (Gj4)Nf2.Default;
				}
				finally
				{
					_ = (Mb5)(object)Nf2.Default;
					goto IL_0717;
				}
			}
			num = default(UIntPtr);
		}
		if (num / num == 0)
		{
			_ = (d1X)(object)Nf2.Default;
		}
		goto IL_0717;
		IL_039f:
		try
		{
			try
			{
				try
				{
					co = co;
				}
				finally
				{
					_ = (f2L)(object)Nf2.Default;
					goto end_IL_03a1;
				}
				end_IL_03a1:;
			}
			finally
			{
				goto end_IL_03a0;
			}
			end_IL_03a0:;
		}
		catch
		{
			co = co;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Pj8)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
			finally
			{
				try
				{
					_ = (f0F)(object)Nf2.Default;
					co = null;
				}
				finally
				{
					_ = (Co4)(object)Nf2.Default;
					goto IL_044b;
				}
			}
		}
		try
		{
			mb = null;
		}
		catch
		{
			d4E = d4E;
		}
		goto IL_044b;
		IL_0592:
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (f2L)(object)Nf2.Default;
					_ = (f2L)(object)Nf2.Default;
					_ = (f0F)(object)Nf2.Default;
					d8B = d8B;
				}
			}
			catch
			{
				try
				{
					m0N = m0N;
					_ = (Pj8)(object)Nf2.Default;
				}
				catch
				{
					f9T6 f9T = f9T;
					f9T = null;
				}
			}
		}
		catch
		{
			while ((object)Nf2.Default != null)
			{
				co = co;
			}
		}
		mb = (Mb5)(object)Nf2.Default;
		try
		{
			f0F f0F = null;
		}
		finally
		{
			try
			{
				if ((nuint)(UIntPtr)Nf2.Default / num == 0)
				{
					_ = (Pj8)(object)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				else
				{
					_ = (f2L)(object)Nf2.Default;
					k6D = (k6D9)(object)Nf2.Default;
					x8D = x8D;
					x8D = x8D;
				}
			}
			finally
			{
				gj = default(Gj4);
				goto IL_0692;
			}
		}
		IL_044b:
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + num == 0)
				{
					if (num == 0)
					{
						k6D = k6D;
					}
					else
					{
						gj = gj;
					}
				}
			}
			while (obj4 != null);
		}
		try
		{
			do
			{
				_ = (d8B)(object)Nf2.Default;
			}
			while (obj4 != null);
		}
		finally
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Np8)(object)Nf2.Default;
				}
				catch
				{
					co = null;
					w4R = null;
					f0F f0F = f0F;
					f0F = f0F;
				}
			}
			else
			{
				while (obj4 != null)
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
			}
			goto IL_04c9;
		}
		IL_0900:
		try
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (d1X)(object)Nf2.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Pm9)(object)Nf2.Default;
				}
				catch
				{
					co = co;
				}
				goto end_IL_0901;
			}
			end_IL_0901:;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Pm9)(object)Nf2.Default;
				}
				catch
				{
					x8D = null;
				}
			}
			catch
			{
				try
				{
					_ = (x8D9)(object)Nf2.Default;
					goto end_IL_0954;
				}
				finally
				{
					x8D = x8D;
					_ = (r8M)Nf2.Default;
					co = (Co4)(object)Nf2.Default;
					goto end_IL_0954;
				}
				end_IL_0954:;
			}
		}
		while (obj4 != null)
		{
			try
			{
				co = null;
			}
			catch
			{
				_ = (x8D9)(object)Nf2.Default;
			}
			finally
			{
				while ((object)Nf2.Default != null)
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
				continue;
			}
		}
		while ((object)Nf2.Default != null)
		{
			_ = (Pj8)(object)Nf2.Default;
		}
		x8D = x8D;
		if (num == 0)
		{
			if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Gj4)Nf2.Default;
				}
				finally
				{
					pm = pm;
					goto IL_0a42;
				}
			}
			try
			{
				np = np;
			}
			catch
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		else
		{
			while (true)
			{
				if (obj4 != null)
				{
					f2L = null;
				}
				else if ((object)Nf2.Default == null)
				{
					break;
				}
			}
		}
		goto IL_0a42;
		IL_02b5:
		do
		{
			f2L = f2L;
		}
		while (obj4 != null);
		r8M = (r8M)Nf2.Default;
		_ = (f0F)(object)Nf2.Default;
		_ = (r8M)Nf2.Default;
		_ = (d1X)(object)Nf2.Default;
		if (checked(unchecked((nuint)(UIntPtr)Nf2.Default) - num) == 0)
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					d1X = null;
					_ = (d8B)(object)Nf2.Default;
					gj = (Gj4)Nf2.Default;
					gj = default(Gj4);
					gj = gj;
				}
			}
			catch
			{
				while (obj4 != null)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
			}
		}
		m0N = m0N;
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					_ = (f9T6)(object)Nf2.Default;
				}
			}
			finally
			{
				Pj8 pj = (Pj8)(object)Nf2.Default;
				pj = pj;
				goto IL_039f;
			}
		}
		goto IL_039f;
		IL_0a42:
		try
		{
			mb = (Mb5)(object)Nf2.Default;
			_ = (r8M)Nf2.Default;
			gj = default(Gj4);
			gj = gj;
		}
		catch
		{
			k6D = (k6D9)(object)Nf2.Default;
		}
		checked
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					num = default(UIntPtr);
					if (unchecked(num / num) + unchecked((nuint)(UIntPtr)Nf2.Default / unchecked((nuint)default(UIntPtr))) == 0)
					{
						mb = null;
					}
				}
				return;
			}
			finally
			{
				try
				{
					_003CModule_003E = null;
					return;
				}
				finally
				{
					gj = gj;
					return;
				}
			}
		}
		IL_080f:
		checked
		{
			try
			{
			}
			catch
			{
				num = default(UIntPtr);
				nuint num4 = num;
				num = default(UIntPtr);
				nuint num5 = num;
				num = default(UIntPtr);
				nuint num6 = num;
				num = default(UIntPtr);
				nuint num7 = num;
				num = default(UIntPtr);
				nuint num8 = num6 * (num7 - num);
				num = default(UIntPtr);
				nuint num9 = num;
				num = default(UIntPtr);
				nuint num10 = num;
				num = default(UIntPtr);
				if (num4 * (num5 - (unchecked(num8 / (num9 / checked(num10 - unchecked(num / (nuint)(UIntPtr)Nf2.Default)))) - unchecked((nuint)(UIntPtr)Nf2.Default))) == 0)
				{
					_ = (x8D9)(object)Nf2.Default;
				}
			}
			finally
			{
				nuint num11 = num;
				num = default(UIntPtr);
				if (num11 + unchecked((nuint)default(UIntPtr)) * num != 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
					else
					{
						_ = (f9T6)(object)Nf2.Default;
					}
				}
				goto IL_0900;
			}
		}
		IL_0774:
		_ = Nf2.Default;
		if (num == 0)
		{
			if (num == 0)
			{
				if (num == 0)
				{
					_ = (d1X)(object)Nf2.Default;
				}
			}
			else if (checked(num - num) == 0)
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			else
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			goto IL_080f;
		}
		try
		{
			do
			{
				co = co;
			}
			while (obj4 != null);
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = Nf2.Default;
			}
			else
			{
				_ = (Np8)(object)Nf2.Default;
				d4E = null;
				_ = (Pj8)(object)Nf2.Default;
			}
			goto IL_080f;
		}
	}

	static void o3C()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			_ = (f0F)(object)Nf2.Default;
			obj = obj;
		}
		while (obj != null);
		try
		{
			_ = (d4E)(object)Nf2.Default;
		}
		finally
		{
			f9T6 f9T = (f9T6)(object)Nf2.Default;
			f9T = f9T;
			goto IL_003e;
		}
		IL_0279:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			_ = (r8M)Nf2.Default;
		}
		finally
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pj8)(object)Nf2.Default;
					_ = (d4E)(object)Nf2.Default;
					_ = (d8B)(object)Nf2.Default;
				}
				else
				{
					pj = pj;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					nf = nf;
					nf = null;
					_ = (Mb5)(object)Nf2.Default;
				}
				else
				{
					_ = (x8D9)(object)Nf2.Default;
				}
				goto IL_02fa;
			}
		}
		IL_003e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = (nuint)(UIntPtr)Nf2.Default / num;
				num = default(UIntPtr);
				if (num == 0)
				{
					co = null;
					co = co;
				}
				else
				{
					k6D = (k6D9)(object)Nf2.Default;
					k6D = k6D;
				}
			}
			catch
			{
				_ = (d1X)(object)Nf2.Default;
			}
		}
		else
		{
			try
			{
				pm = pm;
				pm = null;
				co = null;
				m0N = (m0N)(object)Nf2.Default;
				m0N = m0N;
			}
			catch
			{
				_ = (Gj4)Nf2.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		try
		{
			d8B = null;
			d8B = d8B;
		}
		catch
		{
			try
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				catch
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
			}
			catch
			{
				while (true)
				{
					x8D = null;
					x8D = x8D;
					if (obj != null)
					{
						continue;
					}
					goto end_IL_010a;
				}
				end_IL_010a:;
			}
		}
		_ = (d1X)(object)Nf2.Default;
		while (obj != null)
		{
			_ = (r8M)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		try
		{
			while (obj != null)
			{
				try
				{
					x8D = x8D;
				}
				finally
				{
					_ = (d4E)(object)Nf2.Default;
					_ = (Np8)(object)Nf2.Default;
					f0F obj7 = (f0F)(object)Nf2.Default;
					f0F = f0F;
					f0F = obj7;
					_ = (f2L)(object)Nf2.Default;
					continue;
				}
			}
		}
		finally
		{
			do
			{
				try
				{
					Np8 obj8 = (Np8)(object)Nf2.Default;
					np = (Np8)(object)Nf2.Default;
					np = obj8;
				}
				finally
				{
					_ = (r8M)Nf2.Default;
					continue;
				}
			}
			while (obj != null);
			goto IL_01c4;
		}
		IL_042c:
		if (num == 0)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (m0N)(object)Nf2.Default;
				}
			}
		}
		else
		{
			np = (Np8)(object)Nf2.Default;
		}
		_ = (f0F)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		do
		{
			try
			{
				Gj4 obj9 = (Gj4)Nf2.Default;
				gj = gj;
				gj = obj9;
			}
			finally
			{
				while ((object)Nf2.Default != null)
				{
					_ = (d4E)(object)Nf2.Default;
					gj = gj;
					np = (Np8)(object)Nf2.Default;
					Mb5 mb = null;
					mb = mb;
				}
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		try
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					f0F = f0F;
				}
				else
				{
					_ = (Np8)(object)Nf2.Default;
				}
			}
			finally
			{
				r8M = r8M;
				r8M = r8M;
				goto end_IL_04c4;
			}
			end_IL_04c4:;
		}
		finally
		{
			d8B = d8B;
			goto IL_0557;
		}
		IL_0378:
		checked
		{
			while (obj != null)
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) - num == 0)
				{
					if (num == 0)
					{
						_ = (Pm9)(object)Nf2.Default;
					}
					else
					{
						_ = (r8M)Nf2.Default;
					}
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				UIntPtr num2 = unchecked((UIntPtr)Nf2.Default);
				nuint num3 = num;
				num = default(UIntPtr);
				if (unchecked((nuint)num2) * unchecked(num3 / (num / (nuint)(UIntPtr)Nf2.Default)) == 0)
				{
				}
			}
			try
			{
				_ = (o5CZ)(object)Nf2.Default;
			}
			catch
			{
				_ = (Eb1)(object)Nf2.Default;
				co = co;
			}
		}
		try
		{
			if (num == 0)
			{
				try
				{
					_ = (f9T6)(object)Nf2.Default;
				}
				catch
				{
					_ = (Pj8)(object)Nf2.Default;
				}
			}
		}
		finally
		{
			if (num == 0)
			{
				UIntPtr num4 = (UIntPtr)Nf2.Default;
				num = default(UIntPtr);
				if ((nuint)num4 / num == 0)
				{
					pj = pj;
				}
			}
			goto IL_042c;
		}
		IL_05e5:
		_ = (x8D9)(object)Nf2.Default;
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				try
				{
					try
					{
						_ = (Gj4)Nf2.Default;
					}
					finally
					{
						k6D = k6D;
						goto end_IL_0601;
					}
					end_IL_0601:;
				}
				catch
				{
					while (obj != null)
					{
						r8M = r8M;
					}
				}
			}
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Np8)(object)Nf2.Default;
					_ = (f2L)(object)Nf2.Default;
					_ = Nf2.Default;
					d8B = d8B;
				}
				finally
				{
					nf = nf;
					goto IL_06cc;
				}
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Eb1)(object)Nf2.Default;
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					pm = null;
					pm = null;
					_ = (Pj8)(object)Nf2.Default;
					_ = (w4R)(object)Nf2.Default;
				}
			}
			catch
			{
				k6D = null;
			}
		}
		goto IL_06cc;
		IL_0557:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		do
		{
			if (num != 0)
			{
				while (obj != null)
				{
					_ = (x8D9)(object)Nf2.Default;
				}
				continue;
			}
			if (num == 0)
			{
				_ = (d1X)(object)Nf2.Default;
				continue;
			}
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			_ = (o5CZ)(object)Nf2.Default;
			r8M = r8M;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		try
		{
			do
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Eb1 eb = eb;
					eb = eb;
					_ = (f0F)(object)Nf2.Default;
					_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				else
				{
					d1X = null;
				}
			}
			catch
			{
				_ = (o5CZ)(object)Nf2.Default;
			}
			goto IL_05e5;
		}
		IL_06cc:
		try
		{
			f0F = null;
			return;
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					pj = null;
					return;
				}
				catch
				{
					_ = (f9T6)(object)Nf2.Default;
					return;
				}
			}
			return;
		}
		IL_02fa:
		d1X obj16 = (d1X)(object)Nf2.Default;
		d1X = d1X;
		d1X = obj16;
		np = np;
		try
		{
			try
			{
				try
				{
					_ = (w4R)(object)Nf2.Default;
				}
				finally
				{
					_ = (w4R)(object)Nf2.Default;
					goto end_IL_0319;
				}
				end_IL_0319:;
			}
			finally
			{
				pm = pm;
				goto end_IL_0318;
			}
			end_IL_0318:;
		}
		finally
		{
			pj = null;
			goto IL_0378;
		}
		IL_01c4:
		if (num == 0)
		{
			do
			{
				try
				{
					_ = (m0N)(object)Nf2.Default;
				}
				finally
				{
					m0N = m0N;
					continue;
				}
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + num - num == 0)
			{
				do
				{
					try
					{
						pj = null;
						pj = pj;
						_ = (Np8)(object)Nf2.Default;
						_ = (m0N)(object)Nf2.Default;
					}
					catch
					{
						_ = (Pm9)(object)Nf2.Default;
					}
				}
				while (obj != null);
			}
			else
			{
				_ = (d8B)(object)Nf2.Default;
			}
			if (num == 0)
			{
				try
				{
					pm = pm;
				}
				finally
				{
					while (obj != null)
					{
						_ = (x8D9)(object)Nf2.Default;
					}
					goto IL_0279;
				}
			}
			goto IL_0279;
		}
	}

	static void s9L()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f9T6 f9T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		while (true)
		{
			obj = Nf2.Default;
			if (obj == null)
			{
				break;
			}
			try
			{
				while ((object)Nf2.Default != null)
				{
					_ = (f0F)(object)Nf2.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Gj4)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
					f9T = f9T;
					f9T = f9T;
					_ = (Mb5)(object)Nf2.Default;
				}
				catch
				{
					r8M = r8M;
					r8M = r8M;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		d4E d4E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		x8D9 x8D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4R w4R);
		checked
		{
			num = unchecked(num / checked(unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)default(UIntPtr)))) + unchecked((nuint)(UIntPtr)Nf2.Default);
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (f9T6)(object)Nf2.Default;
			}
			try
			{
				if (num == 0)
				{
					if (unchecked((nuint)(UIntPtr)Nf2.Default) + num != 0)
					{
						_ = (r8M)Nf2.Default;
					}
				}
				else
				{
					do
					{
						x8D = (x8D9)(object)Nf2.Default;
						x8D = null;
					}
					while (obj != null);
				}
			}
			catch
			{
				UIntPtr num2 = unchecked((UIntPtr)Nf2.Default);
				num = default(UIntPtr);
				if (unchecked((nuint)num2) + num == 0)
				{
					try
					{
						d1X = null;
						d1X = d1X;
					}
					finally
					{
						w4R = w4R;
						w4R = w4R;
						goto end_IL_0105;
					}
				}
				while ((object)Nf2.Default != null)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				end_IL_0105:;
			}
			while ((object)Nf2.Default != null)
			{
				try
				{
					_ = (r8M)Nf2.Default;
				}
				catch
				{
					o5CZ = o5CZ;
					o5CZ = o5CZ;
				}
			}
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
			_ = (w4R)(object)Nf2.Default;
			r8M = (r8M)Nf2.Default;
			d4E obj5 = (d4E)(object)Nf2.Default;
			d4E = null;
			d4E = obj5;
			if (unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default / num) == 0)
				{
					while (obj != null)
					{
						_ = (d4E)(object)Nf2.Default;
					}
				}
				else
				{
					do
					{
						_ = (Np8)(object)Nf2.Default;
						d4E = d4E;
						f9T = (f9T6)(object)Nf2.Default;
						x8D = null;
					}
					while ((object)Nf2.Default != null);
				}
			}
			else
			{
				Pj8 pj = null;
				pj = pj;
				_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
				_ = (Np8)(object)Nf2.Default;
			}
		}
		do
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		while ((object)Nf2.Default != null || (object)Nf2.Default != null);
		o5CZ = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			UIntPtr num3 = (UIntPtr)Nf2.Default;
			num = default(UIntPtr);
			if ((nuint)num3 / num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Gj4)Nf2.Default;
					d1X = d1X;
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
				do
				{
					co = co;
					co = co;
				}
				while (obj != null);
			}
		}
		else if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				w4R = null;
				_ = (Np8)(object)Nf2.Default;
				_ = (f9T6)(object)Nf2.Default;
				_ = (m0N)(object)Nf2.Default;
			}
			catch
			{
				f2L = (f2L)(object)Nf2.Default;
				f2L = null;
			}
		}
		else
		{
			while ((object)Nf2.Default != null)
			{
				_ = (x8D9)(object)Nf2.Default;
			}
		}
		try
		{
			if (num == 0)
			{
				try
				{
					Co4 co = (Co4)(object)Nf2.Default;
				}
				catch
				{
					_ = (Np8)(object)Nf2.Default;
				}
			}
		}
		finally
		{
			_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
			d4E = null;
			_ = (Np8)(object)Nf2.Default;
			goto IL_03a8;
		}
		IL_04e7:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)Nf2.Default != null)
			{
				try
				{
					_ = (Pm9)(object)Nf2.Default;
					_ = (Eb1)(object)Nf2.Default;
				}
				catch
				{
					np = null;
					np = np;
				}
			}
		}
		else if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (f9T6)(object)Nf2.Default;
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		checked
		{
			if (num + unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				if (num == 0)
				{
					nuint num4 = num;
					num = default(UIntPtr);
					if (num4 - unchecked((nuint)default(UIntPtr)) * num == 0)
					{
						_ = (Pj8)(object)Nf2.Default;
					}
				}
			}
			else if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
			{
				_ = (f2L)(object)Nf2.Default;
				Nf2 obj9 = Nf2.Default;
				nf = Nf2.Default;
				nf = obj9;
				_ = (f9T6)(object)Nf2.Default;
				o5CZ = o5CZ;
			}
			try
			{
				o5CZ = o5CZ;
			}
			catch
			{
				np = np;
			}
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (w4R)(object)Nf2.Default;
					d4E = d4E;
					_ = (f0F)(object)Nf2.Default;
					_ = (k6D9)(object)Nf2.Default;
				}
			}
			else
			{
				do
				{
					num = default(UIntPtr);
					if (num != 0)
					{
						_ = (x8D9)(object)Nf2.Default;
					}
					else
					{
						Pj8 pj = (Pj8)(object)Nf2.Default;
					}
				}
				while (obj != null);
			}
		}
		if (num == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			d8B obj11 = (d8B)(object)Nf2.Default;
			d8B d8B = d8B;
			d8B = obj11;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		do
		{
			if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
			{
				nf = nf;
				continue;
			}
			k6D9 obj12 = (k6D9)(object)Nf2.Default;
			k6D = k6D;
			k6D = obj12;
			_ = (f9T6)(object)Nf2.Default;
			f2L = (f2L)(object)Nf2.Default;
			_ = (f0F)(object)Nf2.Default;
		}
		while ((object)Nf2.Default != null || obj != null);
		while (obj != null)
		{
		}
		do
		{
			if (num != 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (m0N)(object)Nf2.Default;
					x8D = (x8D9)(object)Nf2.Default;
					_ = (Pm9)(object)Nf2.Default;
				}
			}
			else
			{
				while ((object)Nf2.Default != null)
				{
					_ = (w4R)(object)Nf2.Default;
					f2L = f2L;
					_ = (k6D9)(object)Nf2.Default;
					_ = (x8D9)(object)Nf2.Default;
				}
			}
		}
		while (obj != null);
		try
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					nf = null;
					r8M = (r8M)Nf2.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				while (obj != null);
				goto end_IL_0784;
			}
			end_IL_0784:;
		}
		finally
		{
			while (obj != null)
			{
				if (num == 0)
				{
					_ = (f9T6)(object)Nf2.Default;
				}
			}
			goto IL_07db;
		}
		IL_040c:
		do
		{
			d4E = d4E;
		}
		while (obj != null || obj != null);
		d1X = null;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				goto IL_0492;
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (o5CZ)(object)Nf2.Default;
			goto IL_0492;
		}
		try
		{
			_ = (Np8)(object)Nf2.Default;
			_ = (Gj4)Nf2.Default;
		}
		finally
		{
			Pj8 pj = (Pj8)(object)Nf2.Default;
			goto IL_0492;
		}
		IL_07db:
		do
		{
			try
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				catch
				{
					w4R = null;
				}
			}
			catch
			{
				try
				{
					nf = null;
				}
				finally
				{
					_ = (d1X)(object)Nf2.Default;
					goto end_IL_07f3;
				}
				end_IL_07f3:;
			}
		}
		while (obj != null);
		_ = (d8B)(object)Nf2.Default;
		return;
		IL_0492:
		_ = (r8M)Nf2.Default;
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (d8B)(object)Nf2.Default;
				}
			}
			finally
			{
				try
				{
					x8D = x8D;
					_ = (Pj8)(object)Nf2.Default;
				}
				finally
				{
					_ = (w4R)(object)Nf2.Default;
					goto IL_04e7;
				}
			}
		}
		goto IL_04e7;
		IL_03a8:
		w4R = w4R;
		try
		{
			_ = (Np8)(object)Nf2.Default;
			_ = (o5CZ)(object)Nf2.Default;
			f2L = f2L;
		}
		finally
		{
			try
			{
				_ = (k6D9)(object)Nf2.Default;
			}
			finally
			{
				_ = (k6D9)(object)Nf2.Default;
				x8D = (x8D9)(object)Nf2.Default;
				_ = (w4R)(object)Nf2.Default;
				goto IL_040c;
			}
		}
	}

	static void c6F()
	{
		object obj;
		do
		{
			_ = (Pj8)(object)Nf2.Default;
			obj = Nf2.Default;
		}
		while (obj != null);
		UIntPtr uIntPtr = (UIntPtr)Nf2.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (f2L)(object)Nf2.Default;
			}
			while (obj != null || obj != null);
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				_ = (Mb5)(object)Nf2.Default;
			}
		}
		while (obj != null);
		if (uIntPtr == 0)
		{
			_ = (x8D9)(object)Nf2.Default;
		}
		do
		{
			_ = Nf2.Default;
		}
		while ((object)Nf2.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		do
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					pj = pj;
					pj = pj;
				}
				finally
				{
					d8B = d8B;
					d8B = d8B;
					continue;
				}
			}
		}
		while ((object)Nf2.Default != null);
		f2L f2L;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		do
		{
			if (uIntPtr != 0)
			{
				do
				{
					k6D = (k6D9)(object)Nf2.Default;
					k6D = k6D;
				}
				while (obj != null);
				continue;
			}
			while ((object)Nf2.Default != null)
			{
				_ = (d1X)(object)Nf2.Default;
				f2L = null;
				f2L = f2L;
				_ = (_003CModule_003E)(object)Nf2.Default;
				_ = (Np8)(object)Nf2.Default;
			}
		}
		while (obj != null);
		if (uIntPtr == 0)
		{
			_ = (Pj8)(object)Nf2.Default;
		}
		else
		{
			_ = (Eb1)(object)Nf2.Default;
		}
		_ = (_003CModule_003E)(object)Nf2.Default;
		_ = (d4E)(object)Nf2.Default;
		f2L = (f2L)(object)Nf2.Default;
		Np8 np = null;
		np = np;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
			while (obj != null)
			{
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num * uIntPtr) == 0)
				{
					Co4 co = null;
					co = co;
					continue;
				}
				_ = Nf2.Default;
				_ = (Co4)(object)Nf2.Default;
				Mb5 obj2 = (Mb5)(object)Nf2.Default;
				mb = mb;
				mb = obj2;
				_ = Nf2.Default;
			}
		}
		finally
		{
			goto IL_0258;
		}
		IL_0258:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (f9T6)(object)Nf2.Default;
				}
				catch
				{
					pj = null;
					f0F = (f0F)(object)Nf2.Default;
					f0F = f0F;
					_ = (Np8)(object)Nf2.Default;
				}
			}
			else
			{
				while ((object)Nf2.Default != null)
				{
					d8B = null;
				}
			}
		}
		while ((object)Nf2.Default != null);
		_ = (x8D9)(object)Nf2.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					Co4 co = null;
				}
				catch
				{
					pj = pj;
				}
			}
			catch
			{
				while ((object)Nf2.Default != null)
				{
					d4E obj5 = (d4E)(object)Nf2.Default;
					d4E = d4E;
					d4E = obj5;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eb1 eb);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (f2L)(object)Nf2.Default;
				}
				else
				{
					eb = eb;
					eb = eb;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (f0F)(object)Nf2.Default;
				}
				else
				{
					_ = (Mb5)(object)Nf2.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (d4E)(object)Nf2.Default;
				}
				catch
				{
					o5CZ = (o5CZ)(object)Nf2.Default;
					o5CZ = o5CZ;
				}
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						pm = (Pm9)(object)Nf2.Default;
						pm = null;
						Co4 co = (Co4)(object)Nf2.Default;
						_003CModule_003E obj8 = (_003CModule_003E)(object)Nf2.Default;
						_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
						_003CModule_003E = obj8;
						np = (Np8)(object)Nf2.Default;
						continue;
					}
					goto end_IL_034e;
				}
				end_IL_034e:;
			}
		}
		w4R w4R;
		try
		{
			do
			{
				try
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
				catch
				{
					f0F = f0F;
					_ = (k6D9)(object)Nf2.Default;
				}
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					w4R = null;
					w4R = w4R;
					_ = (d4E)(object)Nf2.Default;
					f0F = f0F;
				}
			}
			catch
			{
				d8B = d8B;
			}
		}
		try
		{
			if (uIntPtr / (nuint)(UIntPtr)Nf2.Default == 0)
			{
				Co4 co = (Co4)(object)Nf2.Default;
			}
			else
			{
				try
				{
					_ = (f2L)(object)Nf2.Default;
				}
				catch
				{
					_ = Nf2.Default;
					o5CZ = o5CZ;
				}
			}
		}
		catch
		{
			_ = (o5CZ)(object)Nf2.Default;
		}
		try
		{
			try
			{
				_ = (m0N)(object)Nf2.Default;
				_ = Nf2.Default;
			}
			finally
			{
				try
				{
					Co4 co = null;
					f9T6 f9T = null;
					f9T = f9T;
					_ = (Pm9)(object)Nf2.Default;
					Mb5 mb = null;
				}
				catch
				{
					_ = (f2L)(object)Nf2.Default;
					k6D = (k6D9)(object)Nf2.Default;
				}
				goto end_IL_0474;
			}
			end_IL_0474:;
		}
		catch
		{
			try
			{
				_ = (f2L)(object)Nf2.Default;
			}
			catch
			{
				_ = (d1X)(object)Nf2.Default;
			}
			finally
			{
				do
				{
					f9T6 f9T = null;
				}
				while ((object)Nf2.Default != null);
				goto end_IL_04d2;
			}
			end_IL_04d2:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (m0N)(object)Nf2.Default;
					r8M = default(r8M);
					r8M = r8M;
					r8M = default(r8M);
					r8M = r8M;
				}
				else
				{
					d4E = null;
					f9T6 f9T = null;
				}
			}
			catch
			{
				try
				{
					f0F = null;
				}
				finally
				{
					d1X d1X = d1X;
					d1X = null;
					o5CZ = o5CZ;
					Gj4 gj = default(Gj4);
					goto end_IL_0563;
				}
				end_IL_0563:;
			}
		}
		w4R = (w4R)(object)Nf2.Default;
		while ((object)Nf2.Default != null)
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					pj = (Pj8)(object)Nf2.Default;
				}
				else
				{
					_ = Nf2.Default;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				finally
				{
					_ = (d4E)(object)Nf2.Default;
					continue;
				}
			}
			while (obj != null);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				try
				{
					o5CZ = o5CZ;
				}
				catch
				{
					f9T6 f9T = (f9T6)(object)Nf2.Default;
				}
			}
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Co4)(object)Nf2.Default;
			}
			while ((object)Nf2.Default != null);
		}
		checked
		{
			if (uIntPtr == 0)
			{
				o5CZ = o5CZ;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				nuint num2 = uIntPtr + uIntPtr;
				nuint num3 = uIntPtr;
				uIntPtr = default(UIntPtr);
				UIntPtr num4 = uIntPtr;
				UIntPtr num5 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 - (num3 - (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num4) + unchecked((nuint)num5 / uIntPtr)))) == 0)
				{
					try
					{
						_ = (Gj4)Nf2.Default;
					}
					catch
					{
						k6D = (k6D9)(object)Nf2.Default;
					}
				}
			}
			try
			{
				try
				{
					if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
					{
						_ = (m0N)(object)Nf2.Default;
						_ = (m0N)(object)Nf2.Default;
					}
				}
				finally
				{
					if (uIntPtr + uIntPtr == 0)
					{
						_ = (k6D9)(object)Nf2.Default;
					}
					else
					{
						_ = (f2L)(object)Nf2.Default;
					}
					goto end_IL_06e4;
				}
				end_IL_06e4:;
			}
			finally
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Np8)(object)Nf2.Default;
					}
				}
				finally
				{
					goto IL_0752;
				}
			}
		}
		IL_0752:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (k6D9)(object)Nf2.Default;
			}
			catch
			{
				do
				{
					_ = (x8D9)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
		}
		else
		{
			try
			{
				x8D = (x8D9)(object)Nf2.Default;
				x8D = null;
				x8D = null;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					k6D = k6D;
				}
			}
		}
		if (uIntPtr == 0)
		{
			eb = (Eb1)(object)Nf2.Default;
		}
		else
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (w4R)(object)Nf2.Default;
				}
			}
			catch
			{
			}
		}
		if (uIntPtr == 0)
		{
			while ((object)Nf2.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = Nf2.Default;
				}
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				catch
				{
					d4E = d4E;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				_ = Nf2.Default;
			}
		}
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (m0N)(object)Nf2.Default;
				}
				finally
				{
					_ = (k6D9)(object)Nf2.Default;
					continue;
				}
			}
			_ = (d8B)(object)Nf2.Default;
			np = (Np8)(object)Nf2.Default;
		}
		r8M = r8M;
		_ = (_003CModule_003E)(object)Nf2.Default;
		try
		{
			while (obj != null)
			{
				try
				{
					f0F = f0F;
				}
				catch
				{
					x8D = x8D;
					_ = (Gj4)Nf2.Default;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				f2L = f2L;
			}
		}
		try
		{
			while (obj != null)
			{
				d4E = null;
				_ = (k6D9)(object)Nf2.Default;
			}
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
			}
			finally
			{
				goto end_IL_08ec;
			}
			end_IL_08ec:;
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Co4)(object)Nf2.Default;
				}
				catch
				{
					pm = pm;
				}
			}
		}
		finally
		{
			_ = (m0N)(object)Nf2.Default;
			_ = (Mb5)(object)Nf2.Default;
			o5CZ = o5CZ;
			eb = eb;
			goto IL_0951;
		}
		IL_0951:
		if (uIntPtr / uIntPtr / (uIntPtr / uIntPtr) == 0)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
					f2L = f2L;
				}
				while (obj != null);
			}
			else
			{
				while ((object)Nf2.Default != null)
				{
					_ = (m0N)(object)Nf2.Default;
				}
			}
		}
		else
		{
			eb = eb;
		}
	}
}
