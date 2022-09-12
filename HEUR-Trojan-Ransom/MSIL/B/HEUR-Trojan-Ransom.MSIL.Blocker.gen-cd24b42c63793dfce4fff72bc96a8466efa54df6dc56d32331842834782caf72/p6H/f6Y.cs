using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Pc8;
using Sk9;
using Wi0;
using Xs3;
using c7R0;
using g0G;

namespace p6H;

[DesignerGenerated]
public class f6Y : Form
{
	internal delegate void Sy1();

	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

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
			EventHandler eventHandler = d3A;
			Label label = _Label6;
			Label obj = label;
			b4C0.char_0[250] = (char)((b4C0.char_0[250] * b4C0.char_0[199]) & 'ê');
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
			EventHandler eventHandler = j5X;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			Label obj = label;
			b4C0.char_0[243] = (char)((b4C0.char_0[243] | b4C0.char_0[105]) & '²');
			if (obj != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("txtTransport")]
	internal virtual TextBox txtTransport
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

	[field: AccessedThroughProperty("txtBNo")]
	internal virtual TextBox txtBNo
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
			char[] char_ = b4C0.char_0;
			int num = 1;
			while (true)
			{
				EventHandler eventHandler = r8H;
				Button val = _btnDelete;
				if (val == null)
				{
					switch (char_[246])
					{
					case '택':
					case '탞':
						goto IL_0059;
					case '탚':
						goto IL_0060;
					case '태':
						goto IL_0067;
					case '탛':
						goto IL_0098;
					case '탟':
						return;
					}
					continue;
				}
				num = 6;
				goto IL_0059;
				IL_0067:
				val = _btnDelete;
				Button obj = val;
				Pr5.byte_0[265] = (byte)((Pr5.byte_0[265] ^ Pr5.byte_0[478]) & 0x62);
				if (obj == null)
				{
					break;
				}
				num = 3;
				goto IL_0098;
				IL_0098:
				((Control)val).add_Click(eventHandler);
				return;
				IL_0059:
				((Control)val).remove_Click(eventHandler);
				goto IL_0060;
				IL_0060:
				_btnDelete = value;
				goto IL_0067;
			}
			num = 7;
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
			EventHandler eventHandler = Qk0;
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

	[field: AccessedThroughProperty("txtDiscount")]
	internal virtual TextBox txtDiscount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRDetail")]
	internal virtual TextBox txtRDetail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCname")]
	internal virtual TextBox txtCname
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
			EventHandler eventHandler = Zx4;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
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

	[field: AccessedThroughProperty("txtTotal")]
	internal virtual TextBox txtTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public f6Y()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Aj5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Jk8();
	}

	[DebuggerNonUserCode]
	protected override void m6K(bool o1Z)
	{
		try
		{
			if (o1Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o1Z);
		}
	}

	[DebuggerStepThrough]
	private void Jk8()
	{
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected O, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected O, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected O, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected O, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected O, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Expected O, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected O, but got Unknown
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected O, but got Unknown
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected O, but got Unknown
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected O, but got Unknown
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Expected O, but got Unknown
		//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Expected O, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected O, but got Unknown
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2f: Expected O, but got Unknown
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected O, but got Unknown
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d55: Expected O, but got Unknown
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected O, but got Unknown
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Expected O, but got Unknown
		char[] char_ = b4C0.char_0;
		byte[] byte_ = Pr5.byte_0;
		int num = 40;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 84;
			while (true)
			{
				DateTimePicker1 = new DateTimePicker();
				Label9 = new Label();
				txtTransport = new TextBox();
				num = 70;
				while (true)
				{
					Label8 = new Label();
					Label5 = new Label();
					Label4 = new Label();
					num = 45;
					while (true)
					{
						Label1 = new Label();
						txtBNo = new TextBox();
						btnDelete = new Button();
						num = 15;
						while (true)
						{
							btnModify = new Button();
							txtDiscount = new TextBox();
							txtRDetail = new TextBox();
							num = 21;
							while (true)
							{
								txtCname = new TextBox();
								Label2 = new Label();
								btnSave = new Button();
								num = 81;
								while (true)
								{
									DataGridView1 = new DataGridView();
									Label10 = new Label();
									txtTotal = new TextBox();
									num = 0;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										num = 2;
										while (true)
										{
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 67;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(363, 29));
												num = 88;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(52, 17));
													num = 69;
													while (true)
													{
														((Control)Label3).set_TabIndex(7);
														Label3.set_Text("Billing");
														num = 55;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 37;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 25;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 29));
																	num = 53;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 61;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(11);
																			Label6.set_Text("X");
																			num = char_[583] - 1442;
																			while (true)
																			{
																				switch (num)
																				{
																				case 90:
																					((Control)txtTransport).set_TabIndex(3);
																					Label8.set_AutoSize(true);
																					num = 24;
																					goto case 24;
																				case 24:
																					((Control)Label8).set_ForeColor(Color.White);
																					((Control)Label8).set_Location(new Point(166, 130));
																					num = 22;
																					goto case 22;
																				case 22:
																					((Control)Label8).set_Name("Label8");
																					((Control)Label8).set_Size(new Size(55, 13));
																					num = 33;
																					goto case 33;
																				case 33:
																					((Control)Label8).set_TabIndex(76);
																					Label8.set_Text("Discount :");
																					num = 76;
																					goto case 76;
																				case 76:
																					Label5.set_AutoSize(true);
																					((Control)Label5).set_ForeColor(Color.White);
																					num = 78;
																					goto case 78;
																				case 78:
																					((Control)Label5).set_Location(new Point(156, 101));
																					((Control)Label5).set_Name("Label5");
																					num = 10;
																					goto case 10;
																				case 10:
																					((Control)Label5).set_Size(new Size(65, 13));
																					((Control)Label5).set_TabIndex(75);
																					num = 41;
																					goto case 41;
																				case 41:
																					Label5.set_Text("Raw Detail :");
																					Label4.set_AutoSize(true);
																					num = 38;
																					goto case 38;
																				case 38:
																					((Control)Label4).set_ForeColor(Color.White);
																					((Control)Label4).set_Location(new Point(427, 106));
																					num = 23;
																					goto case 23;
																				case 23:
																					((Control)Label4).set_Name("Label4");
																					((Control)Label4).set_Size(new Size(88, 13));
																					num = 17;
																					goto case 17;
																				case 17:
																					((Control)Label4).set_TabIndex(74);
																					Label4.set_Text("Customer Name :");
																					num = 7;
																					goto case 7;
																				case 7:
																					Label1.set_AutoSize(true);
																					((Control)Label1).set_ForeColor(Color.White);
																					num = 74;
																					goto case 74;
																				case 74:
																					((Control)Label1).set_Location(new Point(450, 64));
																					((Control)Label1).set_Name("Label1");
																					num = 89;
																					goto case 89;
																				case 89:
																					((Control)Label1).set_Size(new Size(66, 13));
																					((Control)Label1).set_TabIndex(73);
																					num = 14;
																					goto case 14;
																				case 14:
																					Label1.set_Text("Billing Date :");
																					((Control)txtBNo).set_Location(new Point(245, 64));
																					num = 87;
																					goto case 87;
																				case 87:
																					((Control)txtBNo).set_Name("txtBNo");
																					((Control)txtBNo).set_Size(new Size(100, 20));
																					num = 11;
																					goto case 11;
																				case 11:
																					((Control)txtBNo).set_TabIndex(0);
																					((Control)btnDelete).set_Location(new Point(496, 202));
																					num = 58;
																					goto case 58;
																				case 58:
																					((Control)btnDelete).set_Name("btnDelete");
																					((Control)btnDelete).set_Size(new Size(75, 31));
																					num = 4;
																					goto case 4;
																				case 4:
																					((Control)btnDelete).set_TabIndex(9);
																					((ButtonBase)btnDelete).set_Text("DELETE");
																					num = 79;
																					goto case 79;
																				case 79:
																					((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																					((Control)btnModify).set_Location(new Point(378, 202));
																					num = 13;
																					goto case 13;
																				case 13:
																					((Control)btnModify).set_Name("btnModify");
																					((Control)btnModify).set_Size(new Size(75, 31));
																					num = 31;
																					goto case 31;
																				case 31:
																					((Control)btnModify).set_TabIndex(8);
																					((ButtonBase)btnModify).set_Text("MODIFY");
																					num = 8;
																					goto case 8;
																				case 8:
																					((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																					((Control)txtDiscount).set_Location(new Point(243, 124));
																					num = 54;
																					goto case 54;
																				case 54:
																					((Control)txtDiscount).set_Name("txtDiscount");
																					((Control)txtDiscount).set_Size(new Size(100, 20));
																					num = 35;
																					goto case 35;
																				case 35:
																					((Control)txtDiscount).set_TabIndex(2);
																					goto case 46;
																				case 46:
																					((Control)txtRDetail).set_Location(new Point(243, 94));
																					num = 44;
																					goto case 44;
																				case 44:
																					((Control)txtRDetail).set_Name("txtRDetail");
																					((Control)txtRDetail).set_Size(new Size(100, 20));
																					num = 12;
																					goto case 12;
																				case 12:
																					((Control)txtRDetail).set_TabIndex(1);
																					((Control)txtCname).set_Location(new Point(537, 99));
																					num = 86;
																					goto case 86;
																				case 86:
																					((Control)txtCname).set_Name("txtCname");
																					((Control)txtCname).set_Size(new Size(100, 20));
																					num = 57;
																					goto case 57;
																				case 57:
																					((Control)txtCname).set_TabIndex(5);
																					Label2.set_AutoSize(true);
																					num = 20;
																					goto case 20;
																				case 20:
																					((Control)Label2).set_ForeColor(Color.White);
																					((Control)Label2).set_Location(new Point(167, 67));
																					num = 71;
																					goto case 71;
																				case 71:
																					((Control)Label2).set_Name("Label2");
																					((Control)Label2).set_Size(new Size(57, 13));
																					num = 56;
																					goto case 56;
																				case 56:
																					((Control)Label2).set_TabIndex(72);
																					Label2.set_Text("Billing No :");
																					num = 49;
																					goto case 49;
																				case 49:
																					((Control)btnSave).set_Location(new Point(249, 202));
																					((Control)btnSave).set_Name("btnSave");
																					num = 80;
																					goto case 80;
																				case 80:
																					((Control)btnSave).set_Size(new Size(75, 31));
																					((Control)btnSave).set_TabIndex(7);
																					num = 64;
																					goto case 64;
																				case 64:
																				case 77:
																					((ButtonBase)btnSave).set_Text("SAVE");
																					((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																					num = 62;
																					goto case 62;
																				case 62:
																					DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																					((Control)DataGridView1).set_Location(new Point(45, 239));
																					num = 19;
																					goto case 19;
																				case 19:
																					((Control)DataGridView1).set_Name("DataGridView1");
																					((Control)DataGridView1).set_Size(new Size(724, 199));
																					num = 48;
																					goto case 48;
																				case 48:
																					((Control)DataGridView1).set_TabIndex(12);
																					Label10.set_AutoSize(true);
																					num = 27;
																					goto case 27;
																				case 27:
																					((Control)Label10).set_ForeColor(Color.White);
																					((Control)Label10).set_Location(new Point(478, 139));
																					num = 32;
																					goto case 32;
																				case 32:
																					((Control)Label10).set_Name("Label10");
																					((Control)Label10).set_Size(new Size(37, 13));
																					num = 39;
																					goto case 39;
																				case 39:
																					((Control)Label10).set_TabIndex(81);
																					Label10.set_Text("Total :");
																					num = 65;
																					goto case 65;
																				case 65:
																					((Control)txtTotal).set_Location(new Point(537, 136));
																					((Control)txtTotal).set_Name("txtTotal");
																					num = 29;
																					goto case 29;
																				case 29:
																					((Control)txtTotal).set_Size(new Size(100, 20));
																					goto case 85;
																				case 85:
																					((Control)txtTotal).set_TabIndex(6);
																					num = 3;
																					goto case 3;
																				case 3:
																					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																					num = 66;
																					goto case 66;
																				case 66:
																					((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																					((Form)this).set_ClientSize(new Size(800, 450));
																					num = 43;
																					goto case 43;
																				case 43:
																					((Control)this).get_Controls().Add((Control)(object)txtTotal);
																					((Control)this).get_Controls().Add((Control)(object)Label10);
																					num = 18;
																					goto case 18;
																				case 18:
																					((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																					((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																					num = 47;
																					goto case 47;
																				case 47:
																					((Control)this).get_Controls().Add((Control)(object)Label9);
																					((Control)this).get_Controls().Add((Control)(object)txtTransport);
																					num = 82;
																					goto case 82;
																				case 82:
																					((Control)this).get_Controls().Add((Control)(object)Label8);
																					((Control)this).get_Controls().Add((Control)(object)Label5);
																					num = 16;
																					goto case 16;
																				case 16:
																					((Control)this).get_Controls().Add((Control)(object)Label4);
																					((Control)this).get_Controls().Add((Control)(object)Label1);
																					num = 5;
																					goto case 5;
																				case 5:
																				{
																					((Control)this).get_Controls().Add((Control)(object)txtBNo);
																					((Control)this).get_Controls().Add((Control)(object)btnDelete);
																					byte num2 = byte_[5];
																					Pr5.byte_0[363] = (byte)((Pr5.byte_0[363] - Pr5.byte_0[505]) & 0x6C);
																					num = (int)num2 / 2;
																					continue;
																				}
																				case 83:
																					((Control)Label9).set_Size(new Size(88, 13));
																					((Control)Label9).set_TabIndex(78);
																					num = 36;
																					goto case 36;
																				case 36:
																					Label9.set_Text("Transport Detail :");
																					((Control)txtTransport).set_Location(new Point(243, 159));
																					num = 59;
																					goto case 59;
																				case 59:
																					((Control)txtTransport).set_Name("txtTransport");
																					((Control)txtTransport).set_Size(new Size(100, 20));
																					num = 90;
																					goto case 90;
																				case 73:
																					((Control)DateTimePicker1).set_Size(new Size(126, 20));
																					((Control)DateTimePicker1).set_TabIndex(4);
																					num = 52;
																					goto case 52;
																				case 52:
																					Label9.set_AutoSize(true);
																					((Control)Label9).set_ForeColor(Color.White);
																					num = 50;
																					goto case 50;
																				case 50:
																					((Control)Label9).set_Location(new Point(132, 162));
																					((Control)Label9).set_Name("Label9");
																					num = 83;
																					goto case 83;
																				case 60:
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 42;
																					goto case 42;
																				case 42:
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(42, 29));
																					num = 9;
																					goto case 9;
																				case 9:
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 51;
																					goto case 51;
																				case 51:
																					((Control)Label7).set_TabIndex(10);
																					Label7.set_Text("Go To Main");
																					num = 6;
																					goto case 6;
																				case 6:
																					((Control)DateTimePicker1).set_Location(new Point(537, 64));
																					((Control)DateTimePicker1).set_Name("DateTimePicker1");
																					num = 73;
																					goto case 73;
																				case 34:
																					Label7.set_AutoSize(true);
																					((Control)Label7).set_BackColor(Color.Blue);
																					num = 60;
																					goto case 60;
																				case 61:
																					break;
																				case 53:
																					goto end_IL_0ae6;
																				case 25:
																					goto end_IL_0b16;
																				case 37:
																					goto end_IL_0b3f;
																				case 55:
																					goto end_IL_0b6b;
																				case 69:
																					goto end_IL_0b8d;
																				case 88:
																					goto end_IL_0bae;
																				case 67:
																					goto end_IL_0bcf;
																				case 2:
																					goto end_IL_0bf8;
																				case 0:
																					goto end_IL_0c24;
																				case 81:
																					goto end_IL_0c46;
																				case 21:
																					goto end_IL_0c67;
																				case 15:
																					goto end_IL_0c8c;
																				case 45:
																					goto end_IL_0cb2;
																				case 70:
																					goto end_IL_0cd8;
																				case 84:
																					goto end_IL_0cfe;
																				default:
																					goto end_IL_0d24;
																				case 28:
																					((Control)this).get_Controls().Add((Control)(object)btnModify);
																					((Control)this).get_Controls().Add((Control)(object)txtDiscount);
																					num = 68;
																					goto case 68;
																				case 68:
																					((Control)this).get_Controls().Add((Control)(object)txtRDetail);
																					((Control)this).get_Controls().Add((Control)(object)txtCname);
																					num = 26;
																					goto case 26;
																				case 26:
																					((Control)this).get_Controls().Add((Control)(object)Label2);
																					((Control)this).get_Controls().Add((Control)(object)btnSave);
																					num = 30;
																					goto case 30;
																				case 30:
																					((Control)this).get_Controls().Add((Control)(object)Label6);
																					((Control)this).get_Controls().Add((Control)(object)Label7);
																					num = 72;
																					goto case 72;
																				case 72:
																					((Control)this).get_Controls().Add((Control)(object)Label3);
																					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																					num = 63;
																					goto case 63;
																				case 63:
																					((Control)this).set_Name("frmBilling");
																					((Form)this).set_StartPosition((FormStartPosition)1);
																					((Form)this).set_Text("frmBilling");
																					num = 1;
																					goto case 1;
																				case 1:
																					((ISupportInitialize)DataGridView1).EndInit();
																					((Control)this).ResumeLayout(false);
																					((Control)this).PerformLayout();
																					num = 75;
																					return;
																				case 75:
																					return;
																				}
																				break;
																			}
																			continue;
																			end_IL_0ae6:
																			break;
																		}
																		continue;
																		end_IL_0b16:
																		break;
																	}
																	continue;
																	end_IL_0b3f:
																	break;
																}
																continue;
																end_IL_0b6b:
																break;
															}
															continue;
															end_IL_0b8d:
															break;
														}
														continue;
														end_IL_0bae:
														break;
													}
													continue;
													end_IL_0bcf:
													break;
												}
												continue;
												end_IL_0bf8:
												break;
											}
											continue;
											end_IL_0c24:
											break;
										}
										continue;
										end_IL_0c46:
										break;
									}
									continue;
									end_IL_0c67:
									break;
								}
								continue;
								end_IL_0c8c:
								break;
							}
							continue;
							end_IL_0cb2:
							break;
						}
						continue;
						end_IL_0cd8:
						break;
					}
					continue;
					end_IL_0cfe:
					break;
				}
				continue;
				end_IL_0d24:
				break;
			}
		}
	}

	private void j5X(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void d3A(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Aj5(object sender, EventArgs e)
	{
		z9R();
	}

	private void Zx4(object sender, EventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_billing values(" + Conversions.ToString(Conversions.ToInteger(txtBNo.get_Text())) + ",'" + DateTimePicker1.get_Text() + "','" + txtCname.get_Text() + "','" + txtRDetail.get_Text() + "','" + txtDiscount.get_Text() + "','" + txtTransport.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtTotal.get_Text())) + ")");
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
		z9R();
	}

	public void z9R()
	{
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_billing");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Bill No");
			DataGridView1.get_Columns().Add("c2", "Bill Date");
			DataGridView1.get_Columns().Add("c3", "Customer Name");
			DataGridView1.get_Columns().Add("c4", "Raw Detail");
			DataGridView1.get_Columns().Add("c5", "Discount");
			DataGridView1.get_Columns().Add("c6", "Transport Detail");
			DataGridView1.get_Columns().Add("c7", "Total");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[7]
				{
					rd.get_Item("billno").ToString(),
					rd.get_Item("bdate"),
					rd.get_Item("cname"),
					rd.get_Item("rawdetail"),
					rd.get_Item("discount"),
					rd.get_Item("transportdetail"),
					rd.get_Item("total").ToString()
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

	private void Qk0(object sender, EventArgs e)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_billing set bdate ='" + DateTimePicker1.get_Text() + "',cname='" + txtCname.get_Text() + "',rawdetail='" + txtRDetail.get_Text() + "',discount=''" + txtDiscount.get_Text() + "', transportdetail='" + txtTransport.get_Text() + "', total='" + txtTotal.get_Text() + "' where billno=" + Conversions.ToString(Conversions.ToInteger(txtBNo.get_Text())));
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
		z9R();
		b4C0.char_0[224] = (char)((b4C0.char_0[224] - b4C0.char_0[544]) & '\u001e');
	}

	private void r8H(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_billing where billno=" + Conversions.ToString(Conversions.ToInteger(txtBNo.get_Text())));
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
		z9R();
		Pr5.byte_0[457] = (byte)(Pr5.byte_0[457] & Pr5.byte_0[207] & 0xE2);
	}

	[STAThread]
	public static void Ga8()
	{
		try
		{
			int i6R;
			do
			{
				i6R = 2;
			}
			while (!i3F.Mr8() || !Bj2.z1H(i6R));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = Cs3.Ci5(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Cs3.Ci5(Listt, 1, 1);
			mName = Cs3.Ci5(Listt, 2, 2);
			mArray = Cs3.Ci5(Listt, 3, 3);
			sArray = Cs3.Ci5(Listt, 4, 4);
			T = Cs3.Ci5(Listt, 5, 5);
			sNum = Cs3.Ci5(Listt, 6, 6);
			mDic.Add(sNum, 98);
			byte[] value = Bj2.Wq6(98, 15);
			mDic.Add(sArray, value);
			d3R.Cd6();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
