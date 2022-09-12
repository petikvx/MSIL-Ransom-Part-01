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
using Microsoft.VisualBasic.CompilerServices;
using Wi0;
using Xs3;
using c7R0;
using p6H;

namespace Mf0;

[DesignerGenerated]
public class q9X : Form
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
			EventHandler eventHandler = Xe4f;
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
			EventHandler eventHandler = g5M1;
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
			EventHandler eventHandler = Qp72;
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
			EventHandler eventHandler = o1KY;
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
			EventHandler eventHandler = c8Q3;
			Button val = _btnSave;
			Button obj = val;
			Pr5.byte_0[559] = (byte)((Pr5.byte_0[559] | Pr5.byte_0[300]) & 0x98);
			if (obj != null)
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

	public q9X()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)a1N3);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		x0N();
	}

	[DebuggerNonUserCode]
	protected override void e4C(bool b1M)
	{
		try
		{
			if (b1M && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b1M);
		}
		b4C0.char_0[544] = (char)((b4C0.char_0[544] * b4C0.char_0[158]) & '\u0010');
	}

	[DebuggerStepThrough]
	private void x0N()
	{
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected O, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected O, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected O, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		char[] char_ = b4C0.char_0;
		byte[] byte_ = Pr5.byte_0;
		int num = 22;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 40;
			while (true)
			{
				txtSRcode = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 79;
				while (true)
				{
					Label9 = new Label();
					txtSRName = new TextBox();
					Label8 = new Label();
					num = 11;
					while (true)
					{
						Label5 = new Label();
						Label4 = new Label();
						txtSCode = new TextBox();
						num = 54;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							txtSEmail = new TextBox();
							num = 12;
							while (true)
							{
								txtSName = new TextBox();
								txtSRAmount = new TextBox();
								Label2 = new Label();
								num = 10;
								while (true)
								{
									btnSave = new Button();
									txtSphoneno = new TextBox();
									Label1 = new Label();
									num = 23;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										num = 21;
										while (true)
										{
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 8;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												while (true)
												{
													((Control)Label3).set_Location(new Point(336, 29));
													num = 38;
													while (true)
													{
														((Control)Label3).set_Name("Label3");
														((Control)Label3).set_Size(new Size(115, 17));
														num = 56;
														while (true)
														{
															((Control)Label3).set_TabIndex(9);
															Label3.set_Text("Supplier Detail");
															num = 30;
															while (true)
															{
																Label6.set_AutoSize(true);
																((Control)Label6).set_BackColor(Color.Blue);
																num = 59;
																while (true)
																{
																	((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																	num = 20;
																	while (true)
																	{
																		((Control)Label6).set_ForeColor(Color.White);
																		((Control)Label6).set_Location(new Point(721, 29));
																		num = 5;
																		while (true)
																		{
																			((Control)Label6).set_Name("Label6");
																			((Control)Label6).set_Size(new Size(18, 17));
																			num = char_[557] - 47277;
																			while (true)
																			{
																				switch (num)
																				{
																				case 90:
																					Label9.set_Text("Raw Name :");
																					((Control)txtSRName).set_Location(new Point(504, 88));
																					num = 31;
																					goto case 31;
																				case 31:
																					((Control)txtSRName).set_Name("txtSRName");
																					((Control)txtSRName).set_Size(new Size(100, 20));
																					num = 66;
																					goto case 66;
																				case 66:
																					((Control)txtSRName).set_TabIndex(4);
																					Label8.set_AutoSize(true);
																					num = 63;
																					goto case 63;
																				case 63:
																					((Control)Label8).set_ForeColor(Color.White);
																					((Control)Label8).set_Location(new Point(164, 182));
																					num = 2;
																					goto case 2;
																				case 2:
																					((Control)Label8).set_Name("Label8");
																					((Control)Label8).set_Size(new Size(50, 13));
																					num = 13;
																					goto case 13;
																				case 13:
																					((Control)Label8).set_TabIndex(94);
																					Label8.set_Text("Email Id :");
																					num = 28;
																					goto case 28;
																				case 28:
																					Label5.set_AutoSize(true);
																					((Control)Label5).set_ForeColor(Color.White);
																					num = 65;
																					goto case 65;
																				case 65:
																					((Control)Label5).set_Location(new Point(134, 122));
																					((Control)Label5).set_Name("Label5");
																					num = 47;
																					goto case 47;
																				case 47:
																					((Control)Label5).set_Size(new Size(82, 13));
																					((Control)Label5).set_TabIndex(93);
																					num = 36;
																					goto case 36;
																				case 36:
																					Label5.set_Text("Supplier Name :");
																					Label4.set_AutoSize(true);
																					num = 83;
																					goto case 83;
																				case 83:
																					((Control)Label4).set_ForeColor(Color.White);
																					((Control)Label4).set_Location(new Point(414, 127));
																					num = 72;
																					goto case 72;
																				case 72:
																					((Control)Label4).set_Name("Label4");
																					((Control)Label4).set_Size(new Size(74, 13));
																					num = 86;
																					goto case 86;
																				case 86:
																				{
																					((Control)Label4).set_TabIndex(92);
																					Label4.set_Text("Raw Amount :");
																					byte num2 = byte_[409];
																					byte num3 = byte_[217];
																					Pr5.byte_0[126] = (byte)((Pr5.byte_0[126] ^ Pr5.byte_0[263]) & 0x95);
																					num = num2 - num3;
																					continue;
																				}
																				case 78:
																					((Control)txtSRcode).set_Size(new Size(100, 20));
																					((Control)txtSRcode).set_TabIndex(6);
																					num = 49;
																					goto case 49;
																				case 49:
																					Label10.set_AutoSize(true);
																					((Control)Label10).set_ForeColor(Color.White);
																					num = 69;
																					goto case 69;
																				case 69:
																					((Control)Label10).set_Location(new Point(428, 157));
																					((Control)Label10).set_Name("Label10");
																					num = 60;
																					goto case 60;
																				case 60:
																					((Control)Label10).set_Size(new Size(60, 13));
																					((Control)Label10).set_TabIndex(99);
																					num = 77;
																					goto case 77;
																				case 77:
																					Label10.set_Text("Raw Code:");
																					DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																					num = 74;
																					goto case 74;
																				case 74:
																					((Control)DataGridView1).set_Location(new Point(32, 239));
																					((Control)DataGridView1).set_Name("DataGridView1");
																					num = 7;
																					goto case 7;
																				case 7:
																					((Control)DataGridView1).set_Size(new Size(724, 199));
																					((Control)DataGridView1).set_TabIndex(11);
																					num = 35;
																					goto case 35;
																				case 35:
																					Label9.set_AutoSize(true);
																					((Control)Label9).set_ForeColor(Color.White);
																					num = 32;
																					goto case 32;
																				case 32:
																					((Control)Label9).set_Location(new Point(422, 95));
																					((Control)Label9).set_Name("Label9");
																					num = 1;
																					goto case 1;
																				case 1:
																					((Control)Label9).set_Size(new Size(66, 13));
																					((Control)Label9).set_TabIndex(96);
																					num = 90;
																					goto case 90;
																				case 76:
																					((Control)txtSRcode).set_Location(new Point(504, 151));
																					((Control)txtSRcode).set_Name("txtSRcode");
																					num = 78;
																					goto case 78;
																				case 75:
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 57;
																					goto case 57;
																				case 57:
																					((Control)Label7).set_TabIndex(10);
																					Label7.set_Text("Go To Main");
																					num = 76;
																					goto case 76;
																				case 64:
																					Label7.set_AutoSize(true);
																					((Control)Label7).set_BackColor(Color.Blue);
																					num = 17;
																					goto case 17;
																				case 17:
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 51;
																					goto case 51;
																				case 51:
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(29, 29));
																					num = 75;
																					goto case 75;
																				case 9:
																					((Control)Label6).set_TabIndex(11);
																					Label6.set_Text("X");
																					num = 64;
																					goto case 64;
																				case 5:
																					break;
																				case 20:
																					goto end_IL_061c;
																				case 59:
																					goto end_IL_0653;
																				case 30:
																					goto end_IL_067e;
																				case 56:
																					goto end_IL_06a0;
																				case 38:
																					goto end_IL_06c1;
																				case 80:
																					goto end_IL_06e3;
																				case 8:
																					goto end_IL_070c;
																				case 21:
																					goto end_IL_0728;
																				case 23:
																					goto end_IL_073a;
																				case 10:
																				case 15:
																					goto end_IL_075b;
																				case 12:
																					goto end_IL_077d;
																				case 54:
																					goto end_IL_07a3;
																				case 11:
																					goto end_IL_07c9;
																				case 79:
																					goto end_IL_07ef;
																				case 40:
																					goto end_IL_0815;
																				default:
																					goto end_IL_083b;
																				case 27:
																					((Control)txtSCode).set_Location(new Point(241, 85));
																					((Control)txtSCode).set_Name("txtSCode");
																					num = 33;
																					goto case 33;
																				case 33:
																					((Control)txtSCode).set_Size(new Size(100, 20));
																					((Control)txtSCode).set_TabIndex(0);
																					num = 84;
																					goto case 84;
																				case 84:
																					((Control)btnDelete).set_Location(new Point(483, 202));
																					((Control)btnDelete).set_Name("btnDelete");
																					num = 42;
																					goto case 42;
																				case 42:
																					((Control)btnDelete).set_Size(new Size(75, 31));
																					((Control)btnDelete).set_TabIndex(9);
																					num = 19;
																					goto case 19;
																				case 19:
																					((ButtonBase)btnDelete).set_Text("DELETE");
																					((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																					num = 26;
																					goto case 26;
																				case 26:
																					((Control)btnModify).set_Location(new Point(365, 202));
																					((Control)btnModify).set_Name("btnModify");
																					num = 39;
																					goto case 39;
																				case 39:
																					((Control)btnModify).set_Size(new Size(75, 31));
																					((Control)btnModify).set_TabIndex(8);
																					num = 62;
																					goto case 62;
																				case 62:
																					((ButtonBase)btnModify).set_Text("MODIFY");
																					((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																					num = 89;
																					goto case 89;
																				case 89:
																					((Control)txtSEmail).set_Location(new Point(241, 176));
																					((Control)txtSEmail).set_Name("txtSEmail");
																					num = 87;
																					goto case 87;
																				case 87:
																					((Control)txtSEmail).set_Size(new Size(100, 20));
																					((Control)txtSEmail).set_TabIndex(3);
																					num = 24;
																					goto case 24;
																				case 24:
																					((Control)txtSName).set_Location(new Point(239, 115));
																					((Control)txtSName).set_Name("txtSName");
																					num = 3;
																					goto case 3;
																				case 3:
																					((Control)txtSName).set_Size(new Size(100, 20));
																					((Control)txtSName).set_TabIndex(1);
																					num = 18;
																					goto case 18;
																				case 18:
																					((Control)txtSRAmount).set_Location(new Point(504, 122));
																					((Control)txtSRAmount).set_Name("txtSRAmount");
																					num = 52;
																					goto case 52;
																				case 52:
																					((Control)txtSRAmount).set_Size(new Size(100, 20));
																					((Control)txtSRAmount).set_TabIndex(5);
																					num = 58;
																					goto case 58;
																				case 58:
																					Label2.set_AutoSize(true);
																					((Control)Label2).set_ForeColor(Color.White);
																					num = 44;
																					goto case 44;
																				case 44:
																					((Control)Label2).set_Location(new Point(138, 88));
																					((Control)Label2).set_Name("Label2");
																					num = 43;
																					goto case 43;
																				case 43:
																					((Control)Label2).set_Size(new Size(79, 13));
																					((Control)Label2).set_TabIndex(90);
																					num = 70;
																					goto case 70;
																				case 70:
																					Label2.set_Text("Supplier Code :");
																					((Control)btnSave).set_Location(new Point(236, 202));
																					num = 61;
																					goto case 61;
																				case 61:
																					((Control)btnSave).set_Name("btnSave");
																					((Control)btnSave).set_Size(new Size(75, 31));
																					num = 0;
																					goto case 0;
																				case 0:
																					((Control)btnSave).set_TabIndex(7);
																					((ButtonBase)btnSave).set_Text("SAVE");
																					num = 82;
																					goto case 82;
																				case 82:
																					((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																					((Control)txtSphoneno).set_Location(new Point(239, 150));
																					num = 45;
																					goto case 45;
																				case 45:
																					((Control)txtSphoneno).set_Name("txtSphoneno");
																					((Control)txtSphoneno).set_Size(new Size(100, 20));
																					num = 68;
																					goto case 68;
																				case 68:
																					((Control)txtSphoneno).set_TabIndex(2);
																					Label1.set_AutoSize(true);
																					num = 88;
																					goto case 88;
																				case 88:
																					((Control)Label1).set_ForeColor(Color.White);
																					((Control)Label1).set_Location(new Point(153, 153));
																					num = 14;
																					goto case 14;
																				case 14:
																					((Control)Label1).set_Name("Label1");
																					((Control)Label1).set_Size(new Size(61, 13));
																					num = 67;
																					goto case 67;
																				case 67:
																					((Control)Label1).set_TabIndex(101);
																					Label1.set_Text("Phone No :");
																					num = 25;
																					goto case 16;
																				case 16:
																				case 25:
																					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																					num = 48;
																					goto case 48;
																				case 48:
																					((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																					((Form)this).set_ClientSize(new Size(800, 450));
																					num = 81;
																					goto case 81;
																				case 81:
																					((Control)this).get_Controls().Add((Control)(object)Label1);
																					((Control)this).get_Controls().Add((Control)(object)txtSphoneno);
																					num = 46;
																					goto case 46;
																				case 46:
																					((Control)this).get_Controls().Add((Control)(object)txtSRcode);
																					((Control)this).get_Controls().Add((Control)(object)Label10);
																					num = 6;
																					goto case 6;
																				case 6:
																					((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																					((Control)this).get_Controls().Add((Control)(object)Label9);
																					num = 55;
																					goto case 55;
																				case 55:
																					((Control)this).get_Controls().Add((Control)(object)txtSRName);
																					((Control)this).get_Controls().Add((Control)(object)Label8);
																					num = 29;
																					goto case 29;
																				case 29:
																					((Control)this).get_Controls().Add((Control)(object)Label5);
																					((Control)this).get_Controls().Add((Control)(object)Label4);
																					num = 73;
																					goto case 73;
																				case 73:
																					((Control)this).get_Controls().Add((Control)(object)txtSCode);
																					((Control)this).get_Controls().Add((Control)(object)btnDelete);
																					num = 37;
																					goto case 37;
																				case 37:
																					((Control)this).get_Controls().Add((Control)(object)btnModify);
																					((Control)this).get_Controls().Add((Control)(object)txtSEmail);
																					num = 53;
																					goto case 53;
																				case 53:
																					((Control)this).get_Controls().Add((Control)(object)txtSName);
																					((Control)this).get_Controls().Add((Control)(object)txtSRAmount);
																					num = 34;
																					goto case 34;
																				case 34:
																					((Control)this).get_Controls().Add((Control)(object)Label2);
																					((Control)this).get_Controls().Add((Control)(object)btnSave);
																					num = 71;
																					goto case 71;
																				case 71:
																					((Control)this).get_Controls().Add((Control)(object)Label6);
																					((Control)this).get_Controls().Add((Control)(object)Label7);
																					num = 41;
																					goto case 41;
																				case 41:
																					((Control)this).get_Controls().Add((Control)(object)Label3);
																					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																					num = 85;
																					goto case 85;
																				case 85:
																					((Control)this).set_Name("frmSupplierDetail");
																					((Form)this).set_StartPosition((FormStartPosition)1);
																					((Form)this).set_Text("frmSupplierDetail");
																					num = 4;
																					goto case 4;
																				case 4:
																					((ISupportInitialize)DataGridView1).EndInit();
																					((Control)this).ResumeLayout(false);
																					((Control)this).PerformLayout();
																					num = 50;
																					return;
																				case 50:
																					return;
																				}
																				break;
																			}
																			continue;
																			end_IL_061c:
																			break;
																		}
																		continue;
																		end_IL_0653:
																		break;
																	}
																	continue;
																	end_IL_067e:
																	break;
																}
																continue;
																end_IL_06a0:
																break;
															}
															continue;
															end_IL_06c1:
															break;
														}
														continue;
														end_IL_06e3:
														break;
													}
													continue;
													end_IL_070c:
													break;
												}
												continue;
												end_IL_0728:
												break;
											}
											continue;
											end_IL_073a:
											break;
										}
										continue;
										end_IL_075b:
										break;
									}
									continue;
									end_IL_077d:
									break;
								}
								continue;
								end_IL_07a3:
								break;
							}
							continue;
							end_IL_07c9:
							break;
						}
						continue;
						end_IL_07ef:
						break;
					}
					continue;
					end_IL_0815:
					break;
				}
				continue;
				end_IL_083b:
				break;
			}
		}
	}

	private void g5M1(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void Xe4f(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void a1N3(object sender, EventArgs e)
	{
		Bg24();
	}

	private void c8Q3(object sender, EventArgs e)
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
		Bg24();
	}

	public void Bg24()
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
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
			while (rd.Read())
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

	private void Qp72(object sender, EventArgs e)
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
		Bg24();
	}

	private void o1KY(object sender, EventArgs e)
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
		Bg24();
	}

	internal static byte[] k5PS(string[] r2Q3, int s4TH)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[r2Q3.Length - 1 + 1];
				int num = r2Q3.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (r2Q3[i].Contains(value))
						{
							int startIndex = r2Q3[i].IndexOf(value);
							array[i] = r2Q3[i].Remove(startIndex, 10);
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)f6Y.mDic["AO"]);
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
