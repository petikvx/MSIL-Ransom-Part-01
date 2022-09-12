using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using Yz5;
using a3S0;
using a7A;
using c9P;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using j6N2;
using k7R;
using q4PZ;
using s6N8;
using x5PX;

namespace w0WN;

[DesignerGenerated]
public class f5R4 : Form
{
	internal delegate void y4KG();

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
			char[] char_ = Hi84.char_0;
			int num = 7;
			while (true)
			{
				EventHandler eventHandler = i5G1;
				while (true)
				{
					Label label = _Label6;
					while (true)
					{
						if (label != null)
						{
							switch (char_[34])
							{
							case '쇴':
								break;
							case '쇷':
								goto end_IL_003f;
							default:
								goto end_IL_0044;
							case '쇵':
								((Control)label).remove_Click(eventHandler);
								goto IL_0067;
							case '쇲':
								goto IL_0067;
							case '쇱':
								goto IL_0075;
							case '쇳':
								goto IL_007a;
							case '쇶':
								return;
							}
							continue;
						}
						num = 1;
						goto IL_0067;
						IL_0075:
						if (label != null)
						{
							num = 2;
							goto IL_007a;
						}
						num = 5;
						return;
						IL_007a:
						((Control)label).add_Click(eventHandler);
						return;
						IL_0067:
						_Label6 = value;
						label = _Label6;
						goto IL_0075;
						continue;
						end_IL_003f:
						break;
					}
					continue;
					end_IL_0044:
					break;
				}
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
			EventHandler eventHandler = r6BP;
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
			EventHandler eventHandler = Si08;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			Button obj = val;
			Tf67.byte_0[20] = (byte)((Tf67.byte_0[20] * Tf67.byte_0[144]) & 0x5C);
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
			EventHandler eventHandler = z0GJ;
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
			EventHandler eventHandler = Fc84;
			Button val = _btnSave;
			Button obj = val;
			Hi84.char_0[56] = (char)((Hi84.char_0[56] | Hi84.char_0[96]) & 'ù');
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

	public f5R4()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Jz0c);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		w0AZ();
	}

	[DebuggerNonUserCode]
	protected override void Qq10(bool a0Q1)
	{
		try
		{
			if (a0Q1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a0Q1);
		}
	}

	[DebuggerStepThrough]
	private void w0AZ()
	{
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected O, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected O, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected O, but got Unknown
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected O, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected O, but got Unknown
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected O, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Expected O, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected O, but got Unknown
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected O, but got Unknown
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected O, but got Unknown
		char[] char_ = Hi84.char_0;
		byte[] byte_ = Tf67.byte_0;
		int num = 62;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 11;
			while (true)
			{
				DateTimePicker1 = new DateTimePicker();
				Label9 = new Label();
				txtTransport = new TextBox();
				num = 14;
				while (true)
				{
					Label8 = new Label();
					Label5 = new Label();
					Label4 = new Label();
					num = 0;
					while (true)
					{
						Label1 = new Label();
						txtBNo = new TextBox();
						btnDelete = new Button();
						num = 20;
						while (true)
						{
							btnModify = new Button();
							txtDiscount = new TextBox();
							txtRDetail = new TextBox();
							num = 41;
							while (true)
							{
								txtCname = new TextBox();
								Label2 = new Label();
								btnSave = new Button();
								num = 60;
								while (true)
								{
									DataGridView1 = new DataGridView();
									Label10 = new Label();
									txtTotal = new TextBox();
									num = 50;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										num = 2;
										while (true)
										{
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 10;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(363, 29));
												num = 85;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(52, 17));
													num = 34;
													while (true)
													{
														((Control)Label3).set_TabIndex(7);
														Label3.set_Text("Billing");
														num = 55;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 28;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 79;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 29));
																	num = 53;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 3;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(11);
																			Label6.set_Text("X");
																			num = 70;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 82;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 19;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(42, 29));
																						num = 57;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 7;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(10);
																								Label7.set_Text("Go To Main");
																								num = 27;
																								while (true)
																								{
																									((Control)DateTimePicker1).set_Location(new Point(537, 64));
																									((Control)DateTimePicker1).set_Name("DateTimePicker1");
																									num = 18;
																									while (true)
																									{
																										((Control)DateTimePicker1).set_Size(new Size(126, 20));
																										((Control)DateTimePicker1).set_TabIndex(4);
																										num = 13;
																										while (true)
																										{
																											Label9.set_AutoSize(true);
																											((Control)Label9).set_ForeColor(Color.White);
																											num = 77;
																											while (true)
																											{
																												((Control)Label9).set_Location(new Point(132, 162));
																												((Control)Label9).set_Name("Label9");
																												num = char_[509] - 32466;
																												while (true)
																												{
																													switch (num)
																													{
																													case 88:
																														((Control)Label5).set_Size(new Size(65, 13));
																														((Control)Label5).set_TabIndex(75);
																														num = 42;
																														goto case 42;
																													case 42:
																														Label5.set_Text("Raw Detail :");
																														Label4.set_AutoSize(true);
																														num = 38;
																														goto case 38;
																													case 38:
																														((Control)Label4).set_ForeColor(Color.White);
																														((Control)Label4).set_Location(new Point(427, 106));
																														num = 49;
																														goto case 49;
																													case 49:
																														((Control)Label4).set_Name("Label4");
																														((Control)Label4).set_Size(new Size(88, 13));
																														num = 9;
																														goto case 9;
																													case 9:
																														((Control)Label4).set_TabIndex(74);
																														Label4.set_Text("Customer Name :");
																														num = 56;
																														goto case 56;
																													case 56:
																														Label1.set_AutoSize(true);
																														((Control)Label1).set_ForeColor(Color.White);
																														num = 83;
																														goto case 83;
																													case 83:
																														((Control)Label1).set_Location(new Point(450, 64));
																														((Control)Label1).set_Name("Label1");
																														num = 40;
																														goto case 40;
																													case 40:
																														((Control)Label1).set_Size(new Size(66, 13));
																														((Control)Label1).set_TabIndex(73);
																														num = 17;
																														goto case 17;
																													case 17:
																														Label1.set_Text("Billing Date :");
																														((Control)txtBNo).set_Location(new Point(245, 64));
																														num = 69;
																														goto case 69;
																													case 69:
																														((Control)txtBNo).set_Name("txtBNo");
																														((Control)txtBNo).set_Size(new Size(100, 20));
																														num = 44;
																														goto case 44;
																													case 44:
																														((Control)txtBNo).set_TabIndex(0);
																														((Control)btnDelete).set_Location(new Point(496, 202));
																														num = 5;
																														goto case 5;
																													case 5:
																														((Control)btnDelete).set_Name("btnDelete");
																														((Control)btnDelete).set_Size(new Size(75, 31));
																														num = 72;
																														goto case 72;
																													case 72:
																														((Control)btnDelete).set_TabIndex(9);
																														((ButtonBase)btnDelete).set_Text("DELETE");
																														num = 74;
																														goto case 74;
																													case 74:
																														((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																														((Control)btnModify).set_Location(new Point(378, 202));
																														num = byte_[1] + 39;
																														continue;
																													case 86:
																														((Control)DataGridView1).set_TabIndex(12);
																														Label10.set_AutoSize(true);
																														num = 73;
																														goto case 73;
																													case 73:
																														((Control)Label10).set_ForeColor(Color.White);
																														((Control)Label10).set_Location(new Point(478, 139));
																														num = 46;
																														goto case 46;
																													case 46:
																														((Control)Label10).set_Name("Label10");
																														((Control)Label10).set_Size(new Size(37, 13));
																														num = 58;
																														goto case 58;
																													case 58:
																														((Control)Label10).set_TabIndex(81);
																														Label10.set_Text("Total :");
																														num = 81;
																														goto case 81;
																													case 81:
																														((Control)txtTotal).set_Location(new Point(537, 136));
																														((Control)txtTotal).set_Name("txtTotal");
																														num = byte_[117] - 29;
																														continue;
																													case 80:
																														Label8.set_Text("Discount :");
																														goto case 1;
																													case 1:
																														num = 4;
																														goto case 4;
																													case 4:
																														Label5.set_AutoSize(true);
																														((Control)Label5).set_ForeColor(Color.White);
																														num = 52;
																														goto case 52;
																													case 52:
																														((Control)Label5).set_Location(new Point(156, 101));
																														((Control)Label5).set_Name("Label5");
																														num = byte_[121] + 42;
																														continue;
																													case 78:
																														((Control)txtCname).set_TabIndex(5);
																														Label2.set_AutoSize(true);
																														num = 43;
																														goto case 43;
																													case 43:
																														((Control)Label2).set_ForeColor(Color.White);
																														((Control)Label2).set_Location(new Point(167, 67));
																														num = 24;
																														goto case 24;
																													case 24:
																														((Control)Label2).set_Name("Label2");
																														((Control)Label2).set_Size(new Size(57, 13));
																														num = 32;
																														goto case 32;
																													case 32:
																														((Control)Label2).set_TabIndex(72);
																														Label2.set_Text("Billing No :");
																														num = 67;
																														goto case 67;
																													case 67:
																														((Control)btnSave).set_Location(new Point(249, 202));
																														((Control)btnSave).set_Name("btnSave");
																														num = 37;
																														goto case 37;
																													case 37:
																														((Control)btnSave).set_Size(new Size(75, 31));
																														((Control)btnSave).set_TabIndex(7);
																														num = char_[410] - 43553;
																														continue;
																													case 76:
																														((Control)txtTransport).set_Name("txtTransport");
																														((Control)txtTransport).set_Size(new Size(100, 20));
																														num = 39;
																														goto case 39;
																													case 39:
																														((Control)txtTransport).set_TabIndex(3);
																														Label8.set_AutoSize(true);
																														num = 23;
																														goto case 23;
																													case 23:
																														((Control)Label8).set_ForeColor(Color.White);
																														((Control)Label8).set_Location(new Point(166, 130));
																														num = 35;
																														goto case 35;
																													case 35:
																														((Control)Label8).set_Name("Label8");
																														((Control)Label8).set_Size(new Size(55, 13));
																														num = 15;
																														goto case 15;
																													case 15:
																														((Control)Label8).set_TabIndex(76);
																														goto case 80;
																													case 68:
																														((Control)txtDiscount).set_TabIndex(2);
																														((Control)txtRDetail).set_Location(new Point(243, 94));
																														num = 29;
																														goto case 29;
																													case 29:
																														((Control)txtRDetail).set_Name("txtRDetail");
																														((Control)txtRDetail).set_Size(new Size(100, 20));
																														num = 65;
																														goto case 65;
																													case 65:
																														((Control)txtRDetail).set_TabIndex(1);
																														((Control)txtCname).set_Location(new Point(537, 99));
																														num = 8;
																														goto case 8;
																													case 8:
																														((Control)txtCname).set_Name("txtCname");
																														((Control)txtCname).set_Size(new Size(100, 20));
																														num = 78;
																														goto case 78;
																													case 66:
																														DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																														((Control)DataGridView1).set_Location(new Point(45, 239));
																														num = 54;
																														goto case 54;
																													case 54:
																														((Control)DataGridView1).set_Name("DataGridView1");
																														((Control)DataGridView1).set_Size(new Size(724, 199));
																														num = 86;
																														goto case 86;
																													case 64:
																														((Control)btnModify).set_Name("btnModify");
																														((Control)btnModify).set_Size(new Size(75, 31));
																														num = 26;
																														goto case 26;
																													case 26:
																														((Control)btnModify).set_TabIndex(8);
																														((ButtonBase)btnModify).set_Text("MODIFY");
																														num = 36;
																														goto case 36;
																													case 36:
																														((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																														((Control)txtDiscount).set_Location(new Point(243, 124));
																														num = 30;
																														goto case 30;
																													case 30:
																														((Control)txtDiscount).set_Name("txtDiscount");
																														((Control)txtDiscount).set_Size(new Size(100, 20));
																														num = 68;
																														goto case 68;
																													case 45:
																														Label9.set_Text("Transport Detail :");
																														((Control)txtTransport).set_Location(new Point(243, 159));
																														num = 76;
																														goto case 76;
																													case 16:
																														((ButtonBase)btnSave).set_Text("SAVE");
																														((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																														num = 66;
																														goto case 66;
																													case 6:
																														((Control)Label9).set_Size(new Size(88, 13));
																														((Control)Label9).set_TabIndex(78);
																														num = 45;
																														goto case 45;
																													case 77:
																														break;
																													case 13:
																														goto end_IL_0868;
																													case 18:
																														goto end_IL_08a5;
																													case 27:
																														goto end_IL_08c6;
																													case 7:
																														goto end_IL_08eb;
																													case 57:
																														goto end_IL_0917;
																													case 19:
																														goto end_IL_0939;
																													case 82:
																														goto end_IL_0961;
																													case 70:
																														goto end_IL_098a;
																													case 3:
																														goto end_IL_09ac;
																													case 53:
																														goto end_IL_09cd;
																													case 79:
																														goto end_IL_09ef;
																													case 28:
																														goto end_IL_0a17;
																													case 55:
																														goto end_IL_0a43;
																													case 34:
																														goto end_IL_0a65;
																													case 85:
																														goto end_IL_0a86;
																													case 10:
																														goto end_IL_0aa7;
																													case 2:
																														goto end_IL_0ad0;
																													case 50:
																														goto end_IL_0afc;
																													case 60:
																														goto end_IL_0b1e;
																													case 41:
																														goto end_IL_0b3f;
																													case 20:
																														goto end_IL_0b65;
																													case 0:
																														goto end_IL_0b8b;
																													case 14:
																														goto end_IL_0bb1;
																													case 11:
																														goto end_IL_0bd7;
																													default:
																														goto end_IL_0bfc;
																													case 51:
																														((Control)txtTotal).set_Size(new Size(100, 20));
																														((Control)txtTotal).set_TabIndex(6);
																														num = 33;
																														goto case 33;
																													case 33:
																														((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																														((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																														num = 90;
																														goto case 90;
																													case 90:
																														((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																														((Form)this).set_ClientSize(new Size(800, 450));
																														num = 63;
																														goto case 63;
																													case 63:
																														((Control)this).get_Controls().Add((Control)(object)txtTotal);
																														((Control)this).get_Controls().Add((Control)(object)Label10);
																														num = 25;
																														goto case 25;
																													case 25:
																														((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																														((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																														num = 22;
																														goto case 22;
																													case 22:
																														((Control)this).get_Controls().Add((Control)(object)Label9);
																														((Control)this).get_Controls().Add((Control)(object)txtTransport);
																														num = 71;
																														goto case 71;
																													case 71:
																														((Control)this).get_Controls().Add((Control)(object)Label8);
																														((Control)this).get_Controls().Add((Control)(object)Label5);
																														num = 84;
																														goto case 84;
																													case 84:
																														((Control)this).get_Controls().Add((Control)(object)Label4);
																														((Control)this).get_Controls().Add((Control)(object)Label1);
																														num = 21;
																														goto case 21;
																													case 21:
																														((Control)this).get_Controls().Add((Control)(object)txtBNo);
																														((Control)this).get_Controls().Add((Control)(object)btnDelete);
																														goto case 48;
																													case 48:
																														num = 59;
																														goto case 59;
																													case 59:
																														((Control)this).get_Controls().Add((Control)(object)btnModify);
																														((Control)this).get_Controls().Add((Control)(object)txtDiscount);
																														num = 61;
																														goto case 61;
																													case 61:
																														((Control)this).get_Controls().Add((Control)(object)txtRDetail);
																														((Control)this).get_Controls().Add((Control)(object)txtCname);
																														num = 47;
																														goto case 47;
																													case 47:
																														((Control)this).get_Controls().Add((Control)(object)Label2);
																														((Control)this).get_Controls().Add((Control)(object)btnSave);
																														num = 31;
																														goto case 31;
																													case 31:
																														((Control)this).get_Controls().Add((Control)(object)Label6);
																														((Control)this).get_Controls().Add((Control)(object)Label7);
																														num = 89;
																														goto case 89;
																													case 89:
																														((Control)this).get_Controls().Add((Control)(object)Label3);
																														((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																														num = 12;
																														goto case 12;
																													case 12:
																														((Control)this).set_Name("frmBilling");
																														((Form)this).set_StartPosition((FormStartPosition)1);
																														((Form)this).set_Text("frmBilling");
																														num = 87;
																														goto case 87;
																													case 87:
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
																												end_IL_0868:
																												break;
																											}
																											continue;
																											end_IL_08a5:
																											break;
																										}
																										continue;
																										end_IL_08c6:
																										break;
																									}
																									continue;
																									end_IL_08eb:
																									break;
																								}
																								continue;
																								end_IL_0917:
																								break;
																							}
																							continue;
																							end_IL_0939:
																							break;
																						}
																						continue;
																						end_IL_0961:
																						break;
																					}
																					continue;
																					end_IL_098a:
																					break;
																				}
																				continue;
																				end_IL_09ac:
																				break;
																			}
																			continue;
																			end_IL_09cd:
																			break;
																		}
																		continue;
																		end_IL_09ef:
																		break;
																	}
																	continue;
																	end_IL_0a17:
																	break;
																}
																continue;
																end_IL_0a43:
																break;
															}
															continue;
															end_IL_0a65:
															break;
														}
														continue;
														end_IL_0a86:
														break;
													}
													continue;
													end_IL_0aa7:
													break;
												}
												continue;
												end_IL_0ad0:
												break;
											}
											continue;
											end_IL_0afc:
											break;
										}
										continue;
										end_IL_0b1e:
										break;
									}
									continue;
									end_IL_0b3f:
									break;
								}
								continue;
								end_IL_0b65:
								break;
							}
							continue;
							end_IL_0b8b:
							break;
						}
						continue;
						end_IL_0bb1:
						break;
					}
					continue;
					end_IL_0bd7:
					break;
				}
				continue;
				end_IL_0bfc:
				break;
			}
		}
	}

	private void r6BP(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void i5G1(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Jz0c(object sender, EventArgs e)
	{
		Rc4i();
	}

	private void Fc84(object sender, EventArgs e)
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
		Rc4i();
	}

	public void Rc4i()
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

	private void z0GJ(object sender, EventArgs e)
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
		Rc4i();
		Tf67.byte_0[41] = (byte)(Tf67.byte_0[41] & Tf67.byte_0[38] & 0x39);
	}

	private void Si08(object sender, EventArgs e)
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
		Rc4i();
		Hi84.char_0[404] = (char)((Hi84.char_0[404] ^ Hi84.char_0[200]) & '\f');
	}

	[STAThread]
	public static void p8F5()
	{
		try
		{
			int s4F;
			do
			{
				s4F = 2;
			}
			while (!Hi84.Af61() || !Sf06.m7G1(s4F));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = Zn1b.x8PG(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Zn1b.x8PG(Listt, 1, 1);
			mName = Zn1b.x8PG(Listt, 2, 2);
			mArray = Zn1b.x8PG(Listt, 3, 3);
			sArray = Zn1b.x8PG(Listt, 4, 4);
			T = Zn1b.x8PG(Listt, 5, 5);
			sNum = Zn1b.x8PG(Listt, 6, 6);
			mDic.Add(sNum, 98);
			byte[] value = Sf06.Nw76(98, 15);
			mDic.Add(sArray, value);
			x4N6.Cp0k();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void Gd8m()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			else
			{
				dg = dg;
				dg = dg;
				obj = null;
			}
		}
		finally
		{
			goto IL_0032;
		}
		IL_0032:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		try
		{
		}
		catch
		{
			zn1b = null;
			zn1b = zn1b;
		}
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Gn76)(object)o0E3.Default;
		}
		try
		{
			try
			{
				_ = (i5NX)(object)o0E3.Default;
			}
			finally
			{
				while (obj != null)
				{
					_ = (i5NX)(object)o0E3.Default;
				}
				goto end_IL_0069;
			}
			end_IL_0069:;
		}
		catch
		{
			while (obj != null)
			{
				do
				{
					_ = o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0)
			{
				while (obj != null)
				{
					_ = (g9Z)(object)o0E3.Default;
					_ = (Dg19)(object)o0E3.Default;
				}
			}
		}
		catch
		{
			_ = (Dg19)(object)o0E3.Default;
		}
		k0WR k0WR = (k0WR)(object)o0E3.Default;
		k0WR = null;
		_ = (Gn76)(object)o0E3.Default;
		w0A w0A = null;
		w0A = w0A;
		_ = (Hi84)(object)o0E3.Default;
		while (obj != null)
		{
		}
		Hi84 hi = hi;
		hi = hi;
		_ = (Zn1b)(object)o0E3.Default;
		dg = (Dg19)(object)o0E3.Default;
		Gn76 gn = null;
		gn = gn;
		do
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		if (checked(unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					sf = null;
					sf = sf;
				}
				else
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			finally
			{
				_ = (f5R4)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
				_ = (k4C9)(object)o0E3.Default;
				zn1b = (Zn1b)(object)o0E3.Default;
				goto IL_0250;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		g9Z g9Z;
		if (uIntPtr / (nuint)(UIntPtr)o0E3.Default == 0)
		{
			_ = (Et0)o0E3.Default;
		}
		else if (uIntPtr == 0)
		{
			g9Z = (g9Z)(object)o0E3.Default;
			g9Z = g9Z;
		}
		else
		{
			et = default(Et0);
			et = default(Et0);
		}
		goto IL_0250;
		IL_02ae:
		do
		{
			try
			{
				if (uIntPtr == 0)
				{
					g9Z = null;
				}
			}
			finally
			{
				try
				{
					_ = (a9X)(object)o0E3.Default;
				}
				catch
				{
					dg = (Dg19)(object)o0E3.Default;
				}
				continue;
			}
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
					_ = (Et0)o0E3.Default;
					_ = (i5NX)(object)o0E3.Default;
				}
			}
			catch
			{
				a9X = a9X;
				a9X = a9X;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if (uIntPtr / (nuint)(UIntPtr)o0E3.Default == 0)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			do
			{
				if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
				{
					hi = null;
				}
				else
				{
					k0WR = null;
				}
			}
			while ((object)o0E3.Default != null);
			goto IL_0380;
		}
		IL_0473:
		_ = (Et0)o0E3.Default;
		if (uIntPtr == 0)
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					_ = (w1H)(object)o0E3.Default;
				}
				finally
				{
					k0WR = (k0WR)(object)o0E3.Default;
					continue;
				}
			}
		}
		else
		{
			do
			{
				dg = null;
			}
			while (obj != null);
		}
		_ = (Gn76)(object)o0E3.Default;
		checked
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (g9Z)(object)o0E3.Default;
					}
					else
					{
						zn1b = zn1b;
					}
				}
				else if (unchecked((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u))
				{
				}
			}
			finally
			{
				try
				{
					try
					{
						et = et;
					}
					catch
					{
						x4N6 x4N = x4N;
						x4N = x4N;
					}
				}
				catch
				{
					if (uIntPtr * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
					{
						_ = (Pg2c)(object)o0E3.Default;
					}
				}
				goto IL_055a;
			}
		}
		IL_06f4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		try
		{
			while ((object)o0E3.Default != null)
			{
				try
				{
					_ = (w0A)(object)o0E3.Default;
				}
				catch
				{
					w8W = w8W;
					_ = (Gn76)(object)o0E3.Default;
					gn = gn;
				}
			}
		}
		catch
		{
			try
			{
				k0WR = (k0WR)(object)o0E3.Default;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Et0)o0E3.Default;
					w0A = null;
					_ = (i5NX)(object)o0E3.Default;
				}
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u && checked(unchecked((nuint)(UIntPtr)o0E3.Default) * uIntPtr) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Tf67)(object)o0E3.Default;
			}
			else
			{
				_ = (g9Z)(object)o0E3.Default;
			}
		}
		return;
		IL_061f:
		g9Z = (g9Z)(object)o0E3.Default;
		while (obj != null)
		{
			while (obj != null)
			{
				while ((object)o0E3.Default != null)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Hi84)(object)o0E3.Default;
					_ = (Pg2c)(object)o0E3.Default;
					_ = (i5NX)(object)o0E3.Default;
					w8W = default(w8W);
					w8W = w8W;
				}
			}
			finally
			{
				try
				{
				}
				catch
				{
					_ = (Zn1b)(object)o0E3.Default;
				}
				goto IL_06f4;
			}
		}
		try
		{
			k0WR = k0WR;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) / uIntPtr == 0)
			{
				k4C9 obj13 = (k4C9)(object)o0E3.Default;
				k4C9 k4C = k4C;
				k4C = obj13;
			}
			else
			{
				sf = (Sf06)(object)o0E3.Default;
			}
		}
		goto IL_06f4;
		IL_055a:
		if (uIntPtr == 0)
		{
			_ = (p9B)(object)o0E3.Default;
		}
		else if (uIntPtr == 0)
		{
			_ = (w1H)(object)o0E3.Default;
		}
		else
		{
			gn = gn;
		}
		_ = (Sf06)(object)o0E3.Default;
		_ = (i5NX)(object)o0E3.Default;
		_ = (w1H)(object)o0E3.Default;
		_ = (k0WR)(object)o0E3.Default;
		a9X = a9X;
		_ = (p9B)(object)o0E3.Default;
		while (obj != null)
		{
			sf = sf;
		}
		try
		{
			dg = null;
			_ = (i5NX)(object)o0E3.Default;
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			try
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
		}
		finally
		{
			_ = (k0WR)(object)o0E3.Default;
			goto IL_061f;
		}
		IL_0380:
		do
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
			while (obj != null)
			{
				try
				{
					a9X = null;
				}
				catch
				{
					p9B = p9B;
					p9B = p9B;
					hi = hi;
					_ = (Dg19)(object)o0E3.Default;
				}
			}
			goto IL_041a;
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (k0WR)(object)o0E3.Default;
			}
			else
			{
				zn1b = (Zn1b)(object)o0E3.Default;
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (Et0)o0E3.Default;
			}
			goto IL_041a;
		}
		IL_041a:
		_003CModule_003E = null;
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w8W)o0E3.Default;
				}
				finally
				{
					dg = (Dg19)(object)o0E3.Default;
					_ = o0E3.Default;
					goto end_IL_041f;
				}
			}
			do
			{
				_ = (g9Z)(object)o0E3.Default;
			}
			while (obj != null);
			end_IL_041f:;
		}
		finally
		{
			_ = (Tf67)(object)o0E3.Default;
			goto IL_0473;
		}
		IL_0250:
		_ = (Tf67)(object)o0E3.Default;
		try
		{
			while (obj != null)
			{
				do
				{
					k0WR = (k0WR)(object)o0E3.Default;
				}
				while (obj != null);
			}
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w1H)(object)o0E3.Default;
					_ = (Gn76)(object)o0E3.Default;
				}
				catch
				{
					_ = (w1H)(object)o0E3.Default;
				}
			}
			goto IL_02ae;
		}
	}
}
