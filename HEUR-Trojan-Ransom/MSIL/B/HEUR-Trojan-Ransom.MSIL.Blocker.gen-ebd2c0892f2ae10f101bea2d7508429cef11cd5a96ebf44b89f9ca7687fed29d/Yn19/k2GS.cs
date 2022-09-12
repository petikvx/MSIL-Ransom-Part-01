using System;
using System.Collections.Generic;
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
using Kc9;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Sd9;
using Ti18;
using Wf0t;
using Yf06;
using Yn6o;
using b3YP;
using c9S;
using i1QX;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace Yn19;

[DesignerGenerated]
public class k2GS : Form
{
	internal delegate void Zm3();

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
			EventHandler eventHandler = k2FG;
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
			int[] int_ = s5C.int_0;
			int num = 1;
			while (true)
			{
				IL_0066:
				EventHandler eventHandler = Ds7c;
				Label label = _Label7;
				if (label == null)
				{
					num = 7;
					goto IL_0052;
				}
				num = 6;
				goto IL_004b;
				IL_0052:
				while (true)
				{
					IL_0052_2:
					_Label7 = value;
					label = _Label7;
					while (true)
					{
						if (label != null)
						{
							switch (int_[249])
							{
							case 52951:
							case 52952:
								break;
							case 52955:
								goto end_IL_0046;
							case 52956:
								goto IL_0052_2;
							default:
								goto IL_0066;
							case 52953:
							case 52954:
								((Control)label).add_Click(eventHandler);
								return;
							case 52949:
								return;
							}
							continue;
						}
						num = 0;
						return;
						continue;
						end_IL_0046:
						break;
					}
					break;
				}
				goto IL_004b;
				IL_004b:
				((Control)label).remove_Click(eventHandler);
				goto IL_0052;
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
			EventHandler eventHandler = a0WT;
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
				o1W.char_0[273] = (char)((o1W.char_0[273] | o1W.char_0[547]) & '\u0082');
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
			EventHandler eventHandler = x6ZX;
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
			EventHandler eventHandler = Xc3o;
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

	public k2GS()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Gb1e);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Qw20();
	}

	[DebuggerNonUserCode]
	protected override void g5DE(bool Ap08)
	{
		char[] char_ = o1W.char_0;
		try
		{
			int num = 5;
			while (true)
			{
				if (!Ap08)
				{
					switch (char_[22])
					{
					case '籏':
					case '籔':
						goto IL_0045;
					case '籎':
						goto IL_0052;
					case '籍':
					case '籓':
						goto IL_005d;
					case '籐':
						goto IL_0061;
					case '籑':
						goto end_IL_003b;
					}
					continue;
				}
				num = 2;
				goto IL_0045;
				IL_0052:
				components.Dispose();
				goto IL_005d;
				IL_005d:
				num = 4;
				break;
				IL_0045:
				if (components != null)
				{
					num = 1;
					goto IL_0052;
				}
				goto IL_0061;
				IL_0061:
				num = 4;
				break;
				continue;
				end_IL_003b:
				break;
			}
		}
		finally
		{
			((Form)this).Dispose(Ap08);
		}
		o1W.char_0[69] = (char)((o1W.char_0[69] * o1W.char_0[34]) & '\u0019');
	}

	[DebuggerStepThrough]
	private void Qw20()
	{
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected O, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected O, but got Unknown
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected O, but got Unknown
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Expected O, but got Unknown
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Expected O, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected O, but got Unknown
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Expected O, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected O, but got Unknown
		//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected O, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected O, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected O, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected O, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected O, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected O, but got Unknown
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected O, but got Unknown
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected O, but got Unknown
		//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dca: Expected O, but got Unknown
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected O, but got Unknown
		char[] char_ = o1W.char_0;
		int num = 69;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 89;
			while (true)
			{
				DateTimePicker1 = new DateTimePicker();
				Label9 = new Label();
				txtTransport = new TextBox();
				num = 83;
				while (true)
				{
					Label8 = new Label();
					Label5 = new Label();
					Label4 = new Label();
					num = 33;
					while (true)
					{
						Label1 = new Label();
						txtBNo = new TextBox();
						btnDelete = new Button();
						num = 14;
						while (true)
						{
							btnModify = new Button();
							txtDiscount = new TextBox();
							txtRDetail = new TextBox();
							num = 12;
							while (true)
							{
								txtCname = new TextBox();
								Label2 = new Label();
								btnSave = new Button();
								num = 79;
								while (true)
								{
									DataGridView1 = new DataGridView();
									Label10 = new Label();
									txtTotal = new TextBox();
									num = 6;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										num = 80;
										while (true)
										{
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 37;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(363, 29));
												num = 87;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(52, 17));
													num = 67;
													while (true)
													{
														((Control)Label3).set_TabIndex(7);
														Label3.set_Text("Billing");
														num = 22;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 13;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 85;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 29));
																	num = 57;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 59;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(11);
																			Label6.set_Text("X");
																			num = 60;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 78;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 20;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(42, 29));
																						num = 58;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 21;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(10);
																								Label7.set_Text("Go To Main");
																								num = 54;
																								while (true)
																								{
																									((Control)DateTimePicker1).set_Location(new Point(537, 64));
																									((Control)DateTimePicker1).set_Name("DateTimePicker1");
																									num = 28;
																									while (true)
																									{
																										((Control)DateTimePicker1).set_Size(new Size(126, 20));
																										((Control)DateTimePicker1).set_TabIndex(4);
																										num = 47;
																										while (true)
																										{
																											Label9.set_AutoSize(true);
																											((Control)Label9).set_ForeColor(Color.White);
																											num = 48;
																											while (true)
																											{
																												((Control)Label9).set_Location(new Point(132, 162));
																												((Control)Label9).set_Name("Label9");
																												num = 15;
																												while (true)
																												{
																													((Control)Label9).set_Size(new Size(88, 13));
																													((Control)Label9).set_TabIndex(78);
																													num = 73;
																													while (true)
																													{
																														Label9.set_Text("Transport Detail :");
																														((Control)txtTransport).set_Location(new Point(243, 159));
																														num = 7;
																														while (true)
																														{
																															((Control)txtTransport).set_Name("txtTransport");
																															((Control)txtTransport).set_Size(new Size(100, 20));
																															char num2 = char_[199];
																															o1W.char_0[479] = (char)((o1W.char_0[479] - o1W.char_0[344]) & '¥');
																															num = num2 - 52713;
																															while (true)
																															{
																																switch (num)
																																{
																																case 90:
																																	((Control)btnDelete).set_TabIndex(9);
																																	((ButtonBase)btnDelete).set_Text("DELETE");
																																	num = 77;
																																	goto case 77;
																																case 77:
																																	((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																	((Control)btnModify).set_Location(new Point(378, 202));
																																	num = 25;
																																	goto case 25;
																																case 25:
																																	((Control)btnModify).set_Name("btnModify");
																																	((Control)btnModify).set_Size(new Size(75, 31));
																																	num = 34;
																																	goto case 34;
																																case 34:
																																	((Control)btnModify).set_TabIndex(8);
																																	((ButtonBase)btnModify).set_Text("MODIFY");
																																	num = 46;
																																	goto case 46;
																																case 46:
																																	((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																	((Control)txtDiscount).set_Location(new Point(243, 124));
																																	num = 26;
																																	goto case 26;
																																case 26:
																																	((Control)txtDiscount).set_Name("txtDiscount");
																																	((Control)txtDiscount).set_Size(new Size(100, 20));
																																	num = 29;
																																	goto case 29;
																																case 29:
																																	((Control)txtDiscount).set_TabIndex(2);
																																	((Control)txtRDetail).set_Location(new Point(243, 94));
																																	num = 31;
																																	goto case 31;
																																case 31:
																																	((Control)txtRDetail).set_Name("txtRDetail");
																																	goto case 42;
																																case 42:
																																	((Control)txtRDetail).set_Size(new Size(100, 20));
																																	num = 74;
																																	goto case 74;
																																case 74:
																																	((Control)txtRDetail).set_TabIndex(1);
																																	((Control)txtCname).set_Location(new Point(537, 99));
																																	num = 63;
																																	goto case 63;
																																case 63:
																																	((Control)txtCname).set_Name("txtCname");
																																	((Control)txtCname).set_Size(new Size(100, 20));
																																	num = 30;
																																	goto case 30;
																																case 30:
																																	((Control)txtCname).set_TabIndex(5);
																																	Label2.set_AutoSize(true);
																																	num = 61;
																																	goto case 61;
																																case 61:
																																	((Control)Label2).set_ForeColor(Color.White);
																																	((Control)Label2).set_Location(new Point(167, 67));
																																	num = 65;
																																	goto case 65;
																																case 65:
																																	((Control)Label2).set_Name("Label2");
																																	((Control)Label2).set_Size(new Size(57, 13));
																																	num = 55;
																																	goto case 55;
																																case 55:
																																	((Control)Label2).set_TabIndex(72);
																																	Label2.set_Text("Billing No :");
																																	num = 35;
																																	goto case 35;
																																case 35:
																																	((Control)btnSave).set_Location(new Point(249, 202));
																																	((Control)btnSave).set_Name("btnSave");
																																	num = 53;
																																	goto case 53;
																																case 53:
																																	((Control)btnSave).set_Size(new Size(75, 31));
																																	((Control)btnSave).set_TabIndex(7);
																																	num = 84;
																																	goto case 84;
																																case 84:
																																	((ButtonBase)btnSave).set_Text("SAVE");
																																	((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																	num = 49;
																																	goto case 16;
																																case 16:
																																case 49:
																																	DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																	((Control)DataGridView1).set_Location(new Point(45, 239));
																																	num = 70;
																																	goto case 70;
																																case 70:
																																	((Control)DataGridView1).set_Name("DataGridView1");
																																	((Control)DataGridView1).set_Size(new Size(724, 199));
																																	num = 17;
																																	goto case 17;
																																case 17:
																																	((Control)DataGridView1).set_TabIndex(12);
																																	Label10.set_AutoSize(true);
																																	num = 41;
																																	goto case 41;
																																case 41:
																																	((Control)Label10).set_ForeColor(Color.White);
																																	((Control)Label10).set_Location(new Point(478, 139));
																																	num = 56;
																																	goto case 56;
																																case 56:
																																	((Control)Label10).set_Name("Label10");
																																	((Control)Label10).set_Size(new Size(37, 13));
																																	num = 72;
																																	goto case 72;
																																case 72:
																																	((Control)Label10).set_TabIndex(81);
																																	Label10.set_Text("Total :");
																																	num = 81;
																																	goto case 81;
																																case 81:
																																	((Control)txtTotal).set_Location(new Point(537, 136));
																																	((Control)txtTotal).set_Name("txtTotal");
																																	num = 40;
																																	goto case 40;
																																case 40:
																																	((Control)txtTotal).set_Size(new Size(100, 20));
																																	((Control)txtTotal).set_TabIndex(6);
																																	num = 11;
																																	goto case 11;
																																case 11:
																																	((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																	((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																	num = 32;
																																	goto case 32;
																																case 32:
																																	((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																	((Form)this).set_ClientSize(new Size(800, 450));
																																	num = 4;
																																	goto case 4;
																																case 4:
																																	((Control)this).get_Controls().Add((Control)(object)txtTotal);
																																	((Control)this).get_Controls().Add((Control)(object)Label10);
																																	num = 76;
																																	goto case 76;
																																case 76:
																																	((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																	((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																																	num = 5;
																																	goto case 5;
																																case 5:
																																	((Control)this).get_Controls().Add((Control)(object)Label9);
																																	((Control)this).get_Controls().Add((Control)(object)txtTransport);
																																	num = 64;
																																	goto case 64;
																																case 64:
																																	((Control)this).get_Controls().Add((Control)(object)Label8);
																																	((Control)this).get_Controls().Add((Control)(object)Label5);
																																	num = 66;
																																	goto case 66;
																																case 66:
																																	((Control)this).get_Controls().Add((Control)(object)Label4);
																																	((Control)this).get_Controls().Add((Control)(object)Label1);
																																	num = 51;
																																	goto case 51;
																																case 51:
																																	((Control)this).get_Controls().Add((Control)(object)txtBNo);
																																	((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																	num = 50;
																																	goto case 50;
																																case 50:
																																	((Control)this).get_Controls().Add((Control)(object)btnModify);
																																	((Control)this).get_Controls().Add((Control)(object)txtDiscount);
																																	num = 39;
																																	goto case 39;
																																case 39:
																																	((Control)this).get_Controls().Add((Control)(object)txtRDetail);
																																	((Control)this).get_Controls().Add((Control)(object)txtCname);
																																	num = char_[571] - 46692;
																																	continue;
																																case 88:
																																	((Control)Label4).set_ForeColor(Color.White);
																																	((Control)Label4).set_Location(new Point(427, 106));
																																	num = 18;
																																	goto case 18;
																																case 18:
																																	((Control)Label4).set_Name("Label4");
																																	((Control)Label4).set_Size(new Size(88, 13));
																																	num = 52;
																																	goto case 52;
																																case 52:
																																	((Control)Label4).set_TabIndex(74);
																																	Label4.set_Text("Customer Name :");
																																	num = 27;
																																	goto case 27;
																																case 27:
																																	Label1.set_AutoSize(true);
																																	((Control)Label1).set_ForeColor(Color.White);
																																	num = 2;
																																	goto case 2;
																																case 2:
																																	((Control)Label1).set_Location(new Point(450, 64));
																																	((Control)Label1).set_Name("Label1");
																																	num = 1;
																																	goto case 1;
																																case 1:
																																	((Control)Label1).set_Size(new Size(66, 13));
																																	((Control)Label1).set_TabIndex(73);
																																	num = 62;
																																	goto case 62;
																																case 62:
																																	Label1.set_Text("Billing Date :");
																																	((Control)txtBNo).set_Location(new Point(245, 64));
																																	num = 9;
																																	goto case 9;
																																case 9:
																																	((Control)txtBNo).set_Name("txtBNo");
																																	((Control)txtBNo).set_Size(new Size(100, 20));
																																	num = 3;
																																	goto case 3;
																																case 3:
																																	((Control)txtBNo).set_TabIndex(0);
																																	((Control)btnDelete).set_Location(new Point(496, 202));
																																	num = 23;
																																	goto case 23;
																																case 23:
																																	((Control)btnDelete).set_Name("btnDelete");
																																	((Control)btnDelete).set_Size(new Size(75, 31));
																																	num = 90;
																																	goto case 90;
																																case 82:
																																	Label5.set_AutoSize(true);
																																	((Control)Label5).set_ForeColor(Color.White);
																																	num = 36;
																																	goto case 36;
																																case 36:
																																	((Control)Label5).set_Location(new Point(156, 101));
																																	((Control)Label5).set_Name("Label5");
																																	num = 10;
																																	goto case 10;
																																case 10:
																																	((Control)Label5).set_Size(new Size(65, 13));
																																	((Control)Label5).set_TabIndex(75);
																																	num = 75;
																																	goto case 75;
																																case 75:
																																	Label5.set_Text("Raw Detail :");
																																	Label4.set_AutoSize(true);
																																	num = 88;
																																	goto case 88;
																																case 43:
																																	((Control)Label8).set_Name("Label8");
																																	((Control)Label8).set_Size(new Size(55, 13));
																																	num = 38;
																																	goto case 38;
																																case 38:
																																	((Control)Label8).set_TabIndex(76);
																																	Label8.set_Text("Discount :");
																																	num = 82;
																																	goto case 82;
																																case 24:
																																	((Control)txtTransport).set_TabIndex(3);
																																	Label8.set_AutoSize(true);
																																	num = 0;
																																	goto case 0;
																																case 0:
																																	((Control)Label8).set_ForeColor(Color.White);
																																	((Control)Label8).set_Location(new Point(166, 130));
																																	num = 43;
																																	goto case 43;
																																case 7:
																																	break;
																																case 73:
																																	goto end_IL_094f;
																																case 15:
																																	goto end_IL_09ae;
																																case 48:
																																	goto end_IL_09df;
																																case 47:
																																	goto end_IL_0a05;
																																case 28:
																																	goto end_IL_0a34;
																																case 54:
																																	goto end_IL_0a55;
																																case 21:
																																	goto end_IL_0a7a;
																																case 58:
																																	goto end_IL_0aa6;
																																case 20:
																																	goto end_IL_0ac8;
																																case 78:
																																case 86:
																																	goto end_IL_0af1;
																																case 60:
																																	goto end_IL_0b1a;
																																case 59:
																																	goto end_IL_0b3c;
																																case 57:
																																	goto end_IL_0b5d;
																																case 85:
																																	goto end_IL_0b7f;
																																case 13:
																																	goto end_IL_0ba8;
																																case 22:
																																	goto end_IL_0bd4;
																																case 67:
																																	goto end_IL_0bf6;
																																case 87:
																																	goto end_IL_0c17;
																																case 37:
																																	goto end_IL_0c38;
																																case 80:
																																	goto end_IL_0c61;
																																case 6:
																																	goto end_IL_0c8d;
																																case 79:
																																	goto end_IL_0caf;
																																case 12:
																																	goto end_IL_0cd1;
																																case 14:
																																	goto end_IL_0cf6;
																																case 33:
																																	goto end_IL_0d1c;
																																case 83:
																																	goto end_IL_0d42;
																																case 89:
																																	goto end_IL_0d68;
																																default:
																																	goto end_IL_0d8e;
																																case 19:
																																	((Control)this).get_Controls().Add((Control)(object)Label2);
																																	((Control)this).get_Controls().Add((Control)(object)btnSave);
																																	num = 8;
																																	goto case 8;
																																case 8:
																																	((Control)this).get_Controls().Add((Control)(object)Label6);
																																	((Control)this).get_Controls().Add((Control)(object)Label7);
																																	num = 44;
																																	goto case 44;
																																case 44:
																																	((Control)this).get_Controls().Add((Control)(object)Label3);
																																	((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																	num = 68;
																																	goto case 68;
																																case 68:
																																	((Control)this).set_Name("frmBilling");
																																	((Form)this).set_StartPosition((FormStartPosition)1);
																																	((Form)this).set_Text("frmBilling");
																																	num = 45;
																																	goto case 45;
																																case 45:
																																	((ISupportInitialize)DataGridView1).EndInit();
																																	((Control)this).ResumeLayout(false);
																																	((Control)this).PerformLayout();
																																	num = 71;
																																	return;
																																case 71:
																																	return;
																																}
																																break;
																															}
																															continue;
																															end_IL_094f:
																															break;
																														}
																														continue;
																														end_IL_09ae:
																														break;
																													}
																													continue;
																													end_IL_09df:
																													break;
																												}
																												continue;
																												end_IL_0a05:
																												break;
																											}
																											continue;
																											end_IL_0a34:
																											break;
																										}
																										continue;
																										end_IL_0a55:
																										break;
																									}
																									continue;
																									end_IL_0a7a:
																									break;
																								}
																								continue;
																								end_IL_0aa6:
																								break;
																							}
																							continue;
																							end_IL_0ac8:
																							break;
																						}
																						continue;
																						end_IL_0af1:
																						break;
																					}
																					continue;
																					end_IL_0b1a:
																					break;
																				}
																				continue;
																				end_IL_0b3c:
																				break;
																			}
																			continue;
																			end_IL_0b5d:
																			break;
																		}
																		continue;
																		end_IL_0b7f:
																		break;
																	}
																	continue;
																	end_IL_0ba8:
																	break;
																}
																continue;
																end_IL_0bd4:
																break;
															}
															continue;
															end_IL_0bf6:
															break;
														}
														continue;
														end_IL_0c17:
														break;
													}
													continue;
													end_IL_0c38:
													break;
												}
												continue;
												end_IL_0c61:
												break;
											}
											continue;
											end_IL_0c8d:
											break;
										}
										continue;
										end_IL_0caf:
										break;
									}
									continue;
									end_IL_0cd1:
									break;
								}
								continue;
								end_IL_0cf6:
								break;
							}
							continue;
							end_IL_0d1c:
							break;
						}
						continue;
						end_IL_0d42:
						break;
					}
					continue;
					end_IL_0d68:
					break;
				}
				continue;
				end_IL_0d8e:
				break;
			}
		}
	}

	private void Ds7c(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void k2FG(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Gb1e(object sender, EventArgs e)
	{
		Mp8d();
	}

	private void Xc3o(object sender, EventArgs e)
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
		Mp8d();
	}

	public void Mp8d()
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

	private void x6ZX(object sender, EventArgs e)
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
		Mp8d();
		o1W.char_0[34] = (char)((o1W.char_0[34] * o1W.char_0[423]) & '\u0018');
	}

	private void a0WT(object sender, EventArgs e)
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
		Mp8d();
	}

	[STAThread]
	public static void Da0f()
	{
		try
		{
			int po;
			do
			{
				po = 2;
			}
			while (!c7G.Ma8() || !s5C.Qr3(po));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = Cy1.Xr2(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Cy1.Xr2(Listt, 1, 1);
			mName = Cy1.Xr2(Listt, 2, 2);
			mArray = Cy1.Xr2(Listt, 3, 3);
			sArray = Cy1.Xr2(Listt, 4, 4);
			T = Cy1.Xr2(Listt, 5, 5);
			sNum = Cy1.Xr2(Listt, 6, 6);
			mDic.Add(sNum, 98);
			byte[] value = s5C.y7R(98, 15);
			mDic.Add(sArray, value);
			Ty3.j1G();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void i1E8()
	{
		Xj06 obj = (Xj06)Ns87.Default;
		Xj06 xj = default(Xj06);
		xj = obj;
		_ = (Es6d)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4PG q4PG);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			_ = (g6EQ)(object)Ns87.Default;
		}
		catch
		{
			num = checked(num + num);
			if (num == 0)
			{
				if (num == 0)
				{
					q4PG = null;
					q4PG = q4PG;
				}
				else
				{
					_ = (s5C)(object)Ns87.Default;
				}
			}
		}
		object obj3 = null;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = null;
		num = default(UIntPtr);
		nuint num2 = num / num;
		num = default(UIntPtr);
		nuint num3 = num2 / num;
		nuint num4 = num;
		UIntPtr num5 = (UIntPtr)Ns87.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7G c7G);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		checked
		{
			if (num3 * (num4 * (unchecked((nuint)num5) * num) * num) == 0)
			{
				g6EQ = (g6EQ)(object)Ns87.Default;
				g6EQ = g6EQ;
			}
			if (unchecked((nuint)(UIntPtr)Ns87.Default) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					try
					{
						s5C = (s5C)(object)Ns87.Default;
						s5C = s5C;
					}
					finally
					{
						Sd5 obj4 = (Sd5)(object)Ns87.Default;
						Sd5 sd = sd;
						sd = obj4;
						goto end_IL_00fc;
					}
					end_IL_00fc:;
				}
				finally
				{
					try
					{
						_ = (Xq90)(object)Ns87.Default;
						_ = (Xq90)(object)Ns87.Default;
					}
					finally
					{
						a1HS obj5 = (a1HS)(object)Ns87.Default;
						a1HS = (a1HS)(object)Ns87.Default;
						a1HS = obj5;
						c7G = c7G;
						c7G = c7G;
						_ = (s5C)(object)Ns87.Default;
						goto IL_0183;
					}
				}
			}
			goto IL_0183;
		}
		IL_07cb:
		Sa53 sa = default(Sa53);
		return;
		IL_0544:
		_ = (f1D8)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				xj = default(Xj06);
				xj = xj;
			}
		}
		finally
		{
			try
			{
				_ = (k2GS)(object)Ns87.Default;
				xj = (Xj06)Ns87.Default;
				cy = cy;
				s5C = s5C;
			}
			catch
			{
				_ = (o1W)(object)Ns87.Default;
				_ = (_003CModule_003E)(object)Ns87.Default;
				g6EQ = (g6EQ)(object)Ns87.Default;
			}
			goto IL_05c8;
		}
		IL_05c8:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				_ = (_003CModule_003E)(object)Ns87.Default;
				_ = (Xj06)Ns87.Default;
				g6EQ = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS2);
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Ea3q)(object)Ns87.Default;
				}
				catch
				{
					k2GS2 = null;
				}
			}
		}
		num = default(UIntPtr);
		if (checked(num * num) == 0)
		{
			try
			{
				if (num == 0)
				{
					_ = (q1C3)(object)Ns87.Default;
				}
			}
			finally
			{
				try
				{
					_ = (s5C)(object)Ns87.Default;
					Ea3q ea3q = (Ea3q)(object)Ns87.Default;
					_ = (f1D8)(object)Ns87.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
				goto IL_06db;
			}
		}
		while ((object)Ns87.Default != null)
		{
			while (obj3 != null)
			{
				_ = (Cy1)(object)Ns87.Default;
			}
		}
		goto IL_06db;
		IL_0754:
		while (obj3 != null)
		{
			Ea3q ea3q = (Ea3q)(object)Ns87.Default;
		}
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (s5C)(object)Ns87.Default;
				}
				catch
				{
					_ = (q1J3)(object)Ns87.Default;
				}
			}
		}
		catch
		{
			_ = (a1HS)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		checked
		{
			try
			{
				while (obj3 != null)
				{
					if (num == 0)
					{
						q1C = null;
					}
				}
			}
			finally
			{
				if (num + (num + unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
				{
					_ = (q4PG)(object)Ns87.Default;
				}
				goto IL_07cb;
			}
		}
		IL_0183:
		_ = (Sd5)(object)Ns87.Default;
		Ns87 obj11 = Ns87.Default;
		Ns87 ns = ns;
		ns = obj11;
		_ = (Ea3q)(object)Ns87.Default;
		_ = (Xq90)(object)Ns87.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			q4PG = (q4PG)(object)Ns87.Default;
		}
		else
		{
			while (obj3 != null)
			{
			}
		}
		q1C3 obj12 = (q1C3)(object)Ns87.Default;
		q1C = q1C;
		q1C = obj12;
		while (obj3 != null)
		{
			q4PG = q4PG;
		}
		try
		{
			try
			{
			}
			finally
			{
				while (obj3 != null)
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				goto end_IL_0208;
			}
			end_IL_0208:;
		}
		catch
		{
			a1HS = (a1HS)(object)Ns87.Default;
		}
		_ = (o1W)(object)Ns87.Default;
		f1D8 f1D = (f1D8)(object)Ns87.Default;
		f1D = f1D;
		_ = (Xq90)(object)Ns87.Default;
		_ = Ns87.Default;
		while (obj3 != null)
		{
			_ = (q4PG)(object)Ns87.Default;
		}
		try
		{
			_ = (Ty3)(object)Ns87.Default;
		}
		finally
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					q1C = q1C;
				}
				else
				{
					_ = (Sd5)(object)Ns87.Default;
				}
			}
			else
			{
				sa = sa;
				sa = default(Sa53);
			}
			goto IL_02d0;
		}
		IL_02d0:
		try
		{
			if (checked(num * num + (num - num)) == 0)
			{
				try
				{
					c7G = c7G;
				}
				catch
				{
					_ = (Cy1)(object)Ns87.Default;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				ns = ns;
			}
			goto IL_0316;
		}
		IL_0316:
		try
		{
			try
			{
				while (obj3 != null)
				{
					_ = Ns87.Default;
				}
			}
			finally
			{
				g6EQ = (g6EQ)(object)Ns87.Default;
				goto end_IL_0317;
			}
			end_IL_0317:;
		}
		catch
		{
			_ = (Cr17)(object)Ns87.Default;
			_ = (k2GS)(object)Ns87.Default;
			_ = (k2GS)(object)Ns87.Default;
			_ = (q1J3)(object)Ns87.Default;
		}
		_ = (Xq90)(object)Ns87.Default;
		ns = ns;
		try
		{
			try
			{
				cy = cy;
				cy = null;
			}
			catch
			{
				while ((object)Ns87.Default != null)
				{
					_ = (Es6d)(object)Ns87.Default;
				}
			}
		}
		catch
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				try
				{
					Ea3q ea3q = ea3q;
					ea3q = ea3q;
				}
				catch
				{
					_ = (o1W)(object)Ns87.Default;
				}
				goto end_IL_03b3;
			}
			end_IL_03b3:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		while (obj3 != null)
		{
			try
			{
				if (num == 0)
				{
					k2GS obj19 = (k2GS)(object)Ns87.Default;
					k2GS2 = (k2GS)(object)Ns87.Default;
					k2GS2 = obj19;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					k2GS2 = k2GS2;
					q1J3 obj20 = (q1J3)(object)Ns87.Default;
					q1J = q1J;
					q1J = obj20;
				}
				else
				{
					q1J = q1J;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o1W o1W);
		do
		{
			if (num != 0)
			{
				while (obj3 != null)
				{
					o1W = o1W;
				}
				continue;
			}
			try
			{
				q4PG = null;
			}
			catch
			{
				ns = Ns87.Default;
			}
		}
		while (obj3 != null);
		checked
		{
			try
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * num == 0)
				{
					try
					{
						a1HS = a1HS;
						_ = Ns87.Default;
						_ = (Xj06)Ns87.Default;
						_ = (g6EQ)(object)Ns87.Default;
					}
					finally
					{
						q4PG = q4PG;
						goto IL_0544;
					}
				}
				nuint num6 = num;
				nuint num7 = num;
				num = default(UIntPtr);
				if (unchecked(checked(num6 - unchecked(checked(num7 * (unchecked(num / num) - unchecked((nuint)(UIntPtr)Ns87.Default))) / (nuint)(UIntPtr)Ns87.Default)) / (nuint)(UIntPtr)Ns87.Default / (num / num)) + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
				{
					_ = (Xj06)Ns87.Default;
				}
				goto IL_0544;
			}
		}
		IL_06db:
		while ((object)Ns87.Default != null)
		{
			try
			{
				try
				{
					xj = xj;
					o1W = o1W;
					_ = (Sd5)(object)Ns87.Default;
				}
				finally
				{
					g6EQ = g6EQ;
					goto end_IL_069e;
				}
				end_IL_069e:;
			}
			catch
			{
				try
				{
					_ = (o1W)(object)Ns87.Default;
				}
				catch
				{
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			do
			{
				_ = (q4PG)(object)Ns87.Default;
			}
			while (obj3 != null);
			goto IL_0754;
		}
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default) * num == 0)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			finally
			{
				while (obj3 != null)
				{
					sa = default(Sa53);
				}
				goto IL_0754;
			}
		}
	}

	static void s9G6()
	{
		Cr17 cr = null;
		cr = null;
		Sa53 obj = (Sa53)Ns87.Default;
		Sa53 sa = sa;
		sa = obj;
		UIntPtr uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj2 = obj2;
				if (obj2 != null)
				{
					_ = (q4PG)(object)Ns87.Default;
				}
				else if ((object)Ns87.Default == null)
				{
					break;
				}
			}
		}
		else if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Ns87.Default != null)
			{
				_ = (Cr17)(object)Ns87.Default;
			}
		}
		_ = (f1D8)(object)Ns87.Default;
		Cy1 obj3 = (Cy1)(object)Ns87.Default;
		Cy1 cy = cy;
		cy = obj3;
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (f1D8)(object)Ns87.Default;
					_ = (f1D8)(object)Ns87.Default;
				}
				catch
				{
					_ = (q4PG)(object)Ns87.Default;
				}
			}
			while ((object)Ns87.Default != null);
		}
		q1J3 q1J = q1J;
		q1J = q1J;
		c7G c7G = c7G;
		c7G = c7G;
		Xq90 xq = null;
		xq = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Ns87.Default) * unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) * uIntPtr == 0)
					{
						_ = (Xj06)Ns87.Default;
					}
					else
					{
						xq = xq;
					}
				}
				else
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr + unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				_ = (Sa53)Ns87.Default;
			}
			s5C obj5 = (s5C)(object)Ns87.Default;
			s5C = s5C;
			s5C = obj5;
		}
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o1W)(object)Ns87.Default;
			}
		}
		finally
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			goto IL_01df;
		}
		IL_0240:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					cy = cy;
				}
				catch
				{
					_ = (Cy1)(object)Ns87.Default;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (s5C)(object)Ns87.Default;
					_ = (Xq90)(object)Ns87.Default;
					cy = cy;
				}
				else
				{
					g6EQ obj7 = (g6EQ)(object)Ns87.Default;
					g6EQ = g6EQ;
					g6EQ = obj7;
				}
			}
			goto IL_02b5;
		}
		IL_0407:
		_ = (k2GS)(object)Ns87.Default;
		_ = (q4PG)(object)Ns87.Default;
		do
		{
			cy = null;
		}
		while (obj2 != null);
		try
		{
		}
		catch
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Es6d)(object)Ns87.Default;
					_ = (q1C3)(object)Ns87.Default;
					cr = cr;
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		do
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Cr17)(object)Ns87.Default;
					q1C = (q1C3)(object)Ns87.Default;
					_ = (Sd5)(object)Ns87.Default;
					g6EQ = g6EQ;
				}
				else
				{
					cr = null;
				}
			}
			catch
			{
				_ = (a1HS)(object)Ns87.Default;
			}
		}
		while (obj2 != null);
		if (uIntPtr == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Ty3 ty = ty;
				ty = null;
			}
		}
		else if (uIntPtr == 0)
		{
			_ = (Sa53)Ns87.Default;
		}
		_ = (Xj06)Ns87.Default;
		try
		{
			try
			{
				_ = (Xq90)(object)Ns87.Default;
				_ = (Sa53)Ns87.Default;
				_ = (Ea3q)(object)Ns87.Default;
			}
			finally
			{
				q1C = q1C;
				goto end_IL_04ea;
			}
			end_IL_04ea:;
		}
		finally
		{
			do
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
			while (obj2 != null);
			goto IL_052e;
		}
		IL_052e:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (q4PG)(object)Ns87.Default;
			sa = sa;
			goto IL_056f;
		}
		try
		{
		}
		finally
		{
			goto IL_056f;
		}
		IL_02b5:
		_ = Ns87.Default;
		Sd5 sd = (Sd5)(object)Ns87.Default;
		sd = sd;
		nuint num = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (num / checked(unchecked((nuint)default(UIntPtr)) * uIntPtr) == 0)
		{
			xq = null;
		}
		else
		{
			do
			{
				_ = (Xq90)(object)Ns87.Default;
				_ = (g6EQ)(object)Ns87.Default;
				_ = (Cy1)(object)Ns87.Default;
				_ = (Es6d)(object)Ns87.Default;
			}
			while ((object)Ns87.Default != null);
		}
		_ = (s5C)(object)Ns87.Default;
		checked
		{
			try
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						s5C = s5C;
						_ = (q1J3)(object)Ns87.Default;
						Xj06 xj = default(Xj06);
						xj = default(Xj06);
					}
				}
				catch
				{
					_ = (q1C3)(object)Ns87.Default;
				}
			}
			catch
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 - uIntPtr + uIntPtr == 0)
				{
					while (obj2 != null)
					{
						_ = (Cy1)(object)Ns87.Default;
					}
				}
			}
			try
			{
				if (uIntPtr + uIntPtr == 0)
				{
					while (obj2 != null)
					{
						_ = (Sa53)Ns87.Default;
						_ = (f1D8)(object)Ns87.Default;
					}
				}
			}
			finally
			{
				goto IL_0407;
			}
		}
		IL_01df:
		try
		{
			do
			{
				_ = Ns87.Default;
				_ = Ns87.Default;
			}
			while ((object)Ns87.Default != null);
		}
		finally
		{
			try
			{
				do
				{
					q1C = (q1C3)(object)Ns87.Default;
					q1C = q1C;
					_ = (Ea3q)(object)Ns87.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				_ = (_003CModule_003E)(object)Ns87.Default;
			}
			goto IL_0240;
		}
		IL_056f:
		while (obj2 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Sd5)(object)Ns87.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				try
				{
					a1HS = a1HS;
					a1HS = a1HS;
					_ = Ns87.Default;
					_ = (s5C)(object)Ns87.Default;
					_ = Ns87.Default;
				}
				finally
				{
					_ = (Sa53)Ns87.Default;
					continue;
				}
			}
		}
		checked
		{
			do
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) - (unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)default(UIntPtr))) == 0)
					{
						sd = (Sd5)(object)Ns87.Default;
					}
				}
				catch
				{
					try
					{
						_ = (Xj06)Ns87.Default;
					}
					catch
					{
						_ = (q4PG)(object)Ns87.Default;
					}
				}
			}
			while ((object)Ns87.Default != null);
			_ = (q4PG)(object)Ns87.Default;
			do
			{
				try
				{
					q1J = null;
					sd = (Sd5)(object)Ns87.Default;
					_ = (Sa53)Ns87.Default;
					_ = (_003CModule_003E)(object)Ns87.Default;
				}
				finally
				{
					do
					{
						q1J = null;
					}
					while ((object)Ns87.Default != null);
					continue;
				}
			}
			while (obj2 != null);
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Sa53)Ns87.Default;
		}
		_ = (Xj06)Ns87.Default;
		try
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (g6EQ)(object)Ns87.Default;
				return;
			}
			try
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			finally
			{
				_ = (Ea3q)(object)Ns87.Default;
				return;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (f1D8)(object)Ns87.Default;
				}
				finally
				{
					_ = (f1D8)(object)Ns87.Default;
					return;
				}
			}
			finally
			{
				xq = null;
				return;
			}
		}
	}

	static void Hy8f()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj06 xj);
		nuint num;
		try
		{
			xj = (Xj06)Ns87.Default;
			xj = default(Xj06);
			xj = xj;
		}
		finally
		{
			num = (UIntPtr)Ns87.Default;
			if (num == 0)
			{
				q4PG obj = (q4PG)(object)Ns87.Default;
				q4PG q4PG = q4PG;
				q4PG = obj;
			}
			else
			{
				_ = (_003CModule_003E)(object)Ns87.Default;
			}
			goto IL_005c;
		}
		IL_005c:
		Cy1 cy = cy;
		cy = cy;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
			try
			{
				nuint num2 = (num * num + unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default)) * unchecked((nuint)(UIntPtr)Ns87.Default);
				UIntPtr num3 = unchecked((UIntPtr)Ns87.Default);
				num = default(UIntPtr);
				nuint num4 = unchecked((nuint)num3) * num;
				num = default(UIntPtr);
				if (num2 + unchecked(num4 / num) + (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default)) == 0 && num * unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
				{
					Sd5 obj2 = (Sd5)(object)Ns87.Default;
					sd = sd;
					sd = obj2;
				}
			}
			catch
			{
				do
				{
					try
					{
						_ = (Ea3q)(object)Ns87.Default;
						es6d = (Es6d)(object)Ns87.Default;
						es6d = es6d;
						_ = (k2GS)(object)Ns87.Default;
						cy = cy;
					}
					catch
					{
						sd = sd;
					}
				}
				while ((object)Ns87.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj6);
		try
		{
			do
			{
				try
				{
					_ = (Es6d)(object)Ns87.Default;
				}
				catch
				{
					_ = (c7G)(object)Ns87.Default;
					_ = (k2GS)(object)Ns87.Default;
					cy = cy;
					_ = (q4PG)(object)Ns87.Default;
				}
				obj6 = obj6;
			}
			while (obj6 != null);
		}
		catch
		{
			nuint num5 = num;
			UIntPtr num6 = (UIntPtr)Ns87.Default;
			nuint num7 = num;
			num = default(UIntPtr);
			if (num5 / checked(unchecked((nuint)num6) * (num7 * num)) == 0)
			{
				_ = (Xj06)Ns87.Default;
			}
		}
		g6EQ g6EQ;
		do
		{
			try
			{
				g6EQ obj8 = (g6EQ)(object)Ns87.Default;
				g6EQ = (g6EQ)(object)Ns87.Default;
				g6EQ = obj8;
			}
			finally
			{
				_ = (Xq90)(object)Ns87.Default;
				_ = (Sa53)Ns87.Default;
				continue;
			}
		}
		while (obj6 != null);
		if (num == 0)
		{
			try
			{
				_ = (s5C)(object)Ns87.Default;
			}
			catch
			{
				es6d = es6d;
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out o1W o1W);
			do
			{
				o1W = o1W;
				o1W = null;
			}
			while (obj6 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		checked
		{
			if (unchecked((nuint)(UIntPtr)Ns87.Default) + num == 0)
			{
				try
				{
					while ((object)Ns87.Default != null)
					{
						a1HS obj10 = (a1HS)(object)Ns87.Default;
						a1HS = a1HS;
						a1HS = obj10;
					}
				}
				finally
				{
					_ = (Ea3q)(object)Ns87.Default;
					goto IL_0328;
				}
			}
			goto IL_0328;
		}
		IL_0328:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7G c7G);
		checked
		{
			while (obj6 != null)
			{
				try
				{
					num = default(UIntPtr);
					if (num - num == 0)
					{
						_ = (f1D8)(object)Ns87.Default;
						_ = (f1D8)(object)Ns87.Default;
						Sa53 obj11 = (Sa53)Ns87.Default;
						sa = sa;
						sa = obj11;
						_ = (a1HS)(object)Ns87.Default;
					}
					else
					{
						c7G = c7G;
						c7G = c7G;
					}
				}
				finally
				{
					try
					{
						ty = ty;
						ty = ty;
					}
					catch
					{
						Cr17 cr = (Cr17)(object)Ns87.Default;
						cr = cr;
					}
					continue;
				}
			}
			g6EQ = (g6EQ)(object)Ns87.Default;
			try
			{
				_ = (Ea3q)(object)Ns87.Default;
			}
			catch
			{
				num = default(UIntPtr);
				nuint num8 = num + num;
				num = default(UIntPtr);
				if (num8 * num != 0)
				{
					try
					{
						_ = (c7G)(object)Ns87.Default;
					}
					finally
					{
						_ = (Xq90)(object)Ns87.Default;
						_ = (Cr17)(object)Ns87.Default;
						ty = ty;
						goto end_IL_034c;
					}
				}
				if (unchecked((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u))
				{
					_ = (Es6d)(object)Ns87.Default;
				}
				end_IL_034c:;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
			do
			{
				sa = default(Sa53);
				s5C obj14 = (s5C)(object)Ns87.Default;
				s5C = s5C;
				s5C = obj14;
				q4PG q4PG = (q4PG)(object)Ns87.Default;
			}
			while (obj6 != null);
			while (obj6 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					try
					{
						_ = (q1J3)(object)Ns87.Default;
					}
					finally
					{
						g6EQ = (g6EQ)(object)Ns87.Default;
						continue;
					}
				}
			}
			q1C = q1C;
			q1C = q1C;
			if (num == 0)
			{
				try
				{
					c7G = c7G;
					_ = (q1J3)(object)Ns87.Default;
					ty = ty;
				}
				catch
				{
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
		}
		finally
		{
			try
			{
				while (obj6 != null)
				{
					_ = Ns87.Default;
				}
			}
			finally
			{
				xj = xj;
				goto IL_04ae;
			}
		}
		IL_07e5:
		while ((object)Ns87.Default != null)
		{
		}
		return;
		IL_060f:
		do
		{
			_ = (Xj06)Ns87.Default;
		}
		while ((object)Ns87.Default != null);
		do
		{
			es6d = null;
		}
		while (obj6 != null);
		_ = (_003CModule_003E)(object)Ns87.Default;
		do
		{
			ty = ty;
		}
		while ((object)Ns87.Default != null);
		c7G = c7G;
		try
		{
			Ns87 ns = ns;
			ns = null;
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (num / (nuint)(UIntPtr)Ns87.Default != 0)
				{
					_ = (c7G)(object)Ns87.Default;
					_ = (Xj06)Ns87.Default;
					_003CModule_003E _003CModule_003E = null;
				}
				else
				{
					Ns87 ns = Ns87.Default;
				}
			}
			while (obj6 != null);
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0 && num == 0)
			{
				g6EQ = null;
			}
		}
		else
		{
			while (obj6 != null)
			{
				try
				{
					sa = sa;
				}
				finally
				{
					_ = Ns87.Default;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ea3q ea3q);
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					o1W o1W = null;
				}
				catch
				{
					_ = (k2GS)(object)Ns87.Default;
				}
			}
			else if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				ea3q = null;
			}
		}
		else
		{
			while (obj6 != null)
			{
				g6EQ = g6EQ;
			}
		}
		checked
		{
			do
			{
				try
				{
					try
					{
						_ = (q4PG)(object)Ns87.Default;
					}
					finally
					{
						o1W o1W = null;
						q1C = null;
						_ = (Ty3)(object)Ns87.Default;
						_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
						goto end_IL_074c;
					}
					end_IL_074c:;
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						_ = (Sa53)Ns87.Default;
						_ = (g6EQ)(object)Ns87.Default;
					}
				}
			}
			while (obj6 != null);
			try
			{
				Cr17 cr = null;
			}
			finally
			{
				while (true)
				{
					if ((object)Ns87.Default != null)
					{
						q1C = q1C;
					}
					else if (obj6 == null)
					{
						break;
					}
				}
				goto IL_07e5;
			}
		}
		IL_04ae:
		a1HS = null;
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (f1D8)(object)Ns87.Default;
			_ = (Es6d)(object)Ns87.Default;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					Sd5 sd = (Sd5)(object)Ns87.Default;
				}
				finally
				{
					Ea3q obj19 = (Ea3q)(object)Ns87.Default;
					ea3q = ea3q;
					ea3q = obj19;
					goto end_IL_04da;
				}
			}
			end_IL_04da:;
		}
		catch
		{
			if (num / (nuint)(UIntPtr)Ns87.Default == 0)
			{
				xj = xj;
			}
			else
			{
				try
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
		}
		_ = (Cr17)(object)Ns87.Default;
		try
		{
			if (num == 0)
			{
				Sd5 sd = (Sd5)(object)Ns87.Default;
			}
			else
			{
				ea3q = ea3q;
				_ = (Xj06)Ns87.Default;
				_ = (k2GS)(object)Ns87.Default;
				q1C = (q1C3)(object)Ns87.Default;
			}
		}
		catch
		{
			if (num == 0)
			{
				while (obj6 != null)
				{
					_ = (Ea3q)(object)Ns87.Default;
				}
			}
			else
			{
				_ = (s5C)(object)Ns87.Default;
			}
		}
		do
		{
			if (num == 0)
			{
				xj = xj;
			}
		}
		while (obj6 != null);
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (Cr17)(object)Ns87.Default;
			}
			finally
			{
				k2GS k2GS2 = k2GS2;
				k2GS2 = null;
				goto IL_060f;
			}
		}
		goto IL_060f;
	}

	static void Yi07()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				num = (UIntPtr)Ns87.Default;
				checked
				{
					if (num * unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						_ = (q4PG)(object)Ns87.Default;
					}
					else
					{
						_ = (f1D8)(object)Ns87.Default;
					}
				}
			}
		}
		if (num == 0)
		{
			_ = (k2GS)(object)Ns87.Default;
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (q1C3)(object)Ns87.Default;
			}
			finally
			{
				while ((object)Ns87.Default != null)
				{
					_ = (s5C)(object)Ns87.Default;
					_ = (Xj06)Ns87.Default;
				}
				goto IL_0099;
			}
		}
		goto IL_0099;
		IL_024e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			Cy1 obj2 = (Cy1)(object)Ns87.Default;
			cy = null;
			cy = obj2;
		}
		if (num == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					q4PG q4PG = q4PG;
					q4PG = q4PG;
				}
			}
			finally
			{
				Sd5 sd = null;
				goto IL_029c;
			}
		}
		goto IL_029c;
		IL_029c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Ns87.Default != null)
			{
				while (obj3 != null)
				{
					c7G c7G = null;
					c7G = c7G;
				}
			}
		}
		s5C s5C = null;
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			f1D8 f1D = null;
			f1D = f1D;
		}
		while (obj3 != null)
		{
		}
		_ = (a1HS)(object)Ns87.Default;
		Cr17 cr = cr;
		cr = cr;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				Xj06 xj = xj;
			}
			finally
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (q1C3)(object)Ns87.Default;
				}
				else
				{
					f1D8 f1D = (f1D8)(object)Ns87.Default;
				}
				goto IL_03a3;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (k2GS)(object)Ns87.Default;
		}
		else
		{
			do
			{
				_ = (q1J3)(object)Ns87.Default;
			}
			while (obj3 != null);
		}
		goto IL_03a3;
		IL_01dd:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o1W o1W);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
			while (obj3 != null)
			{
				try
				{
					o1W = (o1W)(object)Ns87.Default;
					_ = (Ea3q)(object)Ns87.Default;
					sd = sd;
					sd = null;
				}
				catch
				{
					_ = (Cy1)(object)Ns87.Default;
				}
			}
		}
		finally
		{
			_ = (g6EQ)(object)Ns87.Default;
			_ = (Cr17)(object)Ns87.Default;
			_ = (q1J3)(object)Ns87.Default;
			_ = (s5C)(object)Ns87.Default;
			goto IL_024e;
		}
		IL_03a3:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
		do
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				do
				{
					_ = (Xj06)Ns87.Default;
				}
				while (obj3 != null);
			}
			else
			{
				do
				{
					es6d = es6d;
				}
				while (obj3 != null);
			}
		}
		while ((object)Ns87.Default != null);
		try
		{
			try
			{
				_ = (Sd5)(object)Ns87.Default;
			}
			catch
			{
				if (num == 0)
				{
					q1C3 obj5 = (q1C3)(object)Ns87.Default;
					q1C3 q1C = q1C;
					q1C = obj5;
				}
			}
		}
		catch
		{
			do
			{
				Xj06 xj = (Xj06)Ns87.Default;
			}
			while (obj3 != null);
		}
		_ = (q1C3)(object)Ns87.Default;
		if ((nuint)(UIntPtr)Ns87.Default / num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Xq90)(object)Ns87.Default;
					_ = (Xq90)(object)Ns87.Default;
					q1C3 q1C = null;
				}
			}
			finally
			{
				checked
				{
					nuint num2 = unchecked(num / num) - unchecked((nuint)(UIntPtr)Ns87.Default);
					num = default(UIntPtr);
					UIntPtr num3 = num;
					UIntPtr num4 = unchecked((UIntPtr)Ns87.Default);
					UIntPtr num5 = num;
					num = default(UIntPtr);
					if (num2 + unchecked((nuint)num3) * (unchecked((nuint)num4) * unchecked((nuint)num5 / num)) == 0)
					{
						Sa53 sa = default(Sa53);
						sa = default(Sa53);
					}
					else
					{
						_ = (Xj06)Ns87.Default;
					}
					goto IL_04be;
				}
			}
		}
		goto IL_04be;
		IL_0191:
		if (num / (nuint)(UIntPtr)Ns87.Default == 0)
		{
			if (num == 0)
			{
				s5C = s5C;
				s5C = s5C;
			}
			else
			{
				o1W = o1W;
			}
		}
		try
		{
		}
		finally
		{
			if (checked(num * num) == 0)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
			goto IL_01dd;
		}
		IL_0099:
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (k2GS)(object)Ns87.Default;
			}
		}
		else
		{
			_ = (Ty3)(object)Ns87.Default;
			obj3 = null;
		}
		o1W = o1W;
		o1W = null;
		do
		{
			o1W = o1W;
		}
		while ((object)Ns87.Default != null);
		es6d = es6d;
		es6d = es6d;
		_ = (Cy1)(object)Ns87.Default;
		_ = (q1J3)(object)Ns87.Default;
		_ = (Xj06)Ns87.Default;
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					Ns87 ns = Ns87.Default;
					ns = ns;
				}
				finally
				{
					_ = (Ty3)(object)Ns87.Default;
					goto IL_0191;
				}
			}
			_003CModule_003E _003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
		}
		else if (num == 0)
		{
			g6EQ g6EQ = (g6EQ)(object)Ns87.Default;
			g6EQ = g6EQ;
		}
		goto IL_0191;
		IL_04be:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			c7G c7G = null;
			_ = (Ea3q)(object)Ns87.Default;
		}
		else
		{
			while (obj3 != null)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
		}
		if (num == 0)
		{
			_ = (Sa53)Ns87.Default;
		}
		else
		{
			do
			{
				_ = (_003CModule_003E)(object)Ns87.Default;
			}
			while (obj3 != null);
		}
		while (obj3 != null)
		{
			cy = cy;
		}
		a1HS a1HS = null;
		a1HS = a1HS;
		try
		{
			_ = (q1C3)(object)Ns87.Default;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (q1J3)(object)Ns87.Default;
			}
		}
		do
		{
			f1D8 f1D = (f1D8)(object)Ns87.Default;
			_ = (Cy1)(object)Ns87.Default;
			_ = (Sd5)(object)Ns87.Default;
		}
		while (obj3 != null);
	}

	static void n9A4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS2);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			k2GS2 = (k2GS)(object)Ns87.Default;
			k2GS2 = k2GS2;
		}
		_ = (Xq90)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sd5 sd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			try
			{
				_ = (k2GS)(object)Ns87.Default;
			}
			finally
			{
				k2GS2 = (k2GS)(object)Ns87.Default;
				goto end_IL_0032;
			}
			end_IL_0032:;
		}
		catch
		{
			while (obj != null)
			{
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					sd = sd;
					sd = sd;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ns87 ns);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (q1J3)(object)Ns87.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		else if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				Xj06 xj = (Xj06)Ns87.Default;
				xj = xj;
			}
		}
		else
		{
			try
			{
				Ns87 obj3 = Ns87.Default;
				ns = ns;
				ns = obj3;
				_ = (k2GS)(object)Ns87.Default;
				_ = (s5C)(object)Ns87.Default;
				g6EQ = g6EQ;
				g6EQ = g6EQ;
			}
			catch
			{
				_ = (a1HS)(object)Ns87.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ty3 ty);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ea3q ea3q);
		if (uIntPtr == 0)
		{
			ty = null;
			ty = ty;
			Ea3q obj5 = (Ea3q)(object)Ns87.Default;
			ea3q = ea3q;
			ea3q = obj5;
			_ = (k2GS)(object)Ns87.Default;
		}
		else if ((nuint)(UIntPtr)Ns87.Default / (uIntPtr / (nuint)(UIntPtr)Ns87.Default) == 0)
		{
		}
		_ = (Sa53)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr17 cr);
		try
		{
			try
			{
				_ = (Sa53)Ns87.Default;
			}
			catch
			{
				_ = (Ty3)(object)Ns87.Default;
			}
			finally
			{
				try
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				catch
				{
					_ = (Sd5)(object)Ns87.Default;
				}
				goto end_IL_0190;
			}
			end_IL_0190:;
		}
		catch
		{
			cr = cr;
			q1C = (q1C3)(object)Ns87.Default;
			q1C = q1C;
			ea3q = ea3q;
		}
		nuint num = uIntPtr;
		uIntPtr = default(UIntPtr);
		nuint num2 = checked(num * (uIntPtr * uIntPtr));
		uIntPtr = default(UIntPtr);
		if (num2 / uIntPtr == 0)
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					ty = ty;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Es6d es6d);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1D8 f1D);
		try
		{
			try
			{
				Es6d obj9 = (Es6d)(object)Ns87.Default;
				es6d = null;
				es6d = obj9;
			}
			catch
			{
				_ = (k2GS)(object)Ns87.Default;
			}
		}
		catch
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o1W)(object)Ns87.Default;
			}
			else
			{
				q1C = null;
				q1C = q1C;
				_ = (Cr17)(object)Ns87.Default;
				f1D = f1D;
				f1D = f1D;
			}
		}
		finally
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					g6EQ = g6EQ;
					_ = (a1HS)(object)Ns87.Default;
					_ = (o1W)(object)Ns87.Default;
					_003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
			goto IL_02f4;
		}
		IL_02f4:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq90 xq);
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				if (uIntPtr == 0)
				{
					UIntPtr num3 = unchecked((UIntPtr)Ns87.Default);
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num3) - uIntPtr * unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						cr = cr;
					}
					else
					{
						cr = cr;
					}
				}
				else
				{
					do
					{
						Xq90 obj12 = (Xq90)(object)Ns87.Default;
						xq = xq;
						xq = obj12;
					}
					while ((object)Ns87.Default != null);
				}
			}
			else
			{
				do
				{
					try
					{
						sd = sd;
					}
					finally
					{
						cy = cy;
						cy = cy;
						continue;
					}
				}
				while (obj != null);
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					cr = (Cr17)(object)Ns87.Default;
					_ = (k2GS)(object)Ns87.Default;
					_ = (q1C3)(object)Ns87.Default;
					ea3q = null;
				}
				else
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (g6EQ)(object)Ns87.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (uIntPtr / ((nuint)(UIntPtr)Ns87.Default / (nuint)(UIntPtr)Ns87.Default)) == 0)
				{
					ea3q = null;
				}
			}
		}
		_ = (Ty3)(object)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
		try
		{
			try
			{
				s5C = (s5C)(object)Ns87.Default;
				s5C = s5C;
			}
			finally
			{
				ea3q = ea3q;
				goto end_IL_044a;
			}
			end_IL_044a:;
		}
		catch
		{
			q1J3 q1J = (q1J3)(object)Ns87.Default;
			q1J = q1J;
		}
		while ((object)Ns87.Default != null)
		{
			_ = (Xq90)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7G c7G);
		try
		{
			uIntPtr = default(UIntPtr);
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / (uIntPtr / (nuint)(UIntPtr)Ns87.Default) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					c7G = c7G;
					c7G = null;
				}
			}
			else if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Cr17)(object)Ns87.Default;
			}
		}
		finally
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				k2GS2 = (k2GS)(object)Ns87.Default;
			}
			goto IL_0522;
		}
		IL_09a2:
		_ = (Xq90)(object)Ns87.Default;
		while (obj != null)
		{
			sd = null;
		}
		do
		{
			try
			{
				cr = null;
				es6d = null;
				ty = (Ty3)(object)Ns87.Default;
			}
			catch
			{
				es6d = es6d;
			}
			finally
			{
				while (obj != null)
				{
					_ = (Sa53)Ns87.Default;
				}
				continue;
			}
		}
		while ((object)Ns87.Default != null);
		return;
		IL_058f:
		try
		{
			q1C = (q1C3)(object)Ns87.Default;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				do
				{
					q1C = (q1C3)(object)Ns87.Default;
				}
				while (obj != null);
			}
			goto IL_05bc;
		}
		IL_06df:
		_ = (a1HS)(object)Ns87.Default;
		ns = null;
		try
		{
			cy = cy;
		}
		finally
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = (q4PG)(object)Ns87.Default;
			}
			goto IL_0712;
		}
		IL_0904:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				do
				{
					_ = (o1W)(object)Ns87.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					ty = ty;
				}
			}
		}
		checked
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = Ns87.Default;
					cy = cy;
					c7G = c7G;
					_ = (o1W)(object)Ns87.Default;
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					do
					{
						q4PG q4PG = (q4PG)(object)Ns87.Default;
					}
					while (obj != null);
				}
				goto IL_09a2;
			}
		}
		IL_0712:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			xq = xq;
			_ = (q1C3)(object)Ns87.Default;
			_ = (q1C3)(object)Ns87.Default;
			_ = (s5C)(object)Ns87.Default;
		}
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Xj06)Ns87.Default;
				}
				catch
				{
					_ = (f1D8)(object)Ns87.Default;
				}
				finally
				{
					if (uIntPtr + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						_ = (o1W)(object)Ns87.Default;
						q1C = q1C;
						_ = (a1HS)(object)Ns87.Default;
					}
					goto IL_07a0;
				}
			}
			goto IL_07a0;
		}
		IL_05bc:
		_ = Ns87.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				ea3q = null;
			}
			else
			{
				try
				{
					_ = (f1D8)(object)Ns87.Default;
				}
				catch
				{
					_ = Ns87.Default;
				}
			}
		}
		_ = (q1J3)(object)Ns87.Default;
		while ((object)Ns87.Default != null)
		{
			while ((object)Ns87.Default != null)
			{
				xq = xq;
			}
		}
		es6d = es6d;
		_ = (a1HS)(object)Ns87.Default;
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						cr = (Cr17)(object)Ns87.Default;
					}
					else
					{
						c7G = c7G;
						_ = (f1D8)(object)Ns87.Default;
					}
				}
				finally
				{
					try
					{
						k2GS2 = k2GS2;
					}
					finally
					{
						_ = (Es6d)(object)Ns87.Default;
						_ = (o1W)(object)Ns87.Default;
						goto IL_06df;
					}
				}
			}
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			ty = null;
			goto IL_06df;
		}
		try
		{
			_ = (s5C)(object)Ns87.Default;
		}
		finally
		{
			_ = (Sa53)Ns87.Default;
			goto IL_06df;
		}
		IL_082c:
		f1D = null;
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			checked
			{
				do
				{
					nuint num5 = uIntPtr * unchecked((nuint)default(UIntPtr));
					UIntPtr num6 = unchecked((UIntPtr)Ns87.Default);
					uIntPtr = default(UIntPtr);
					if (num5 + (unchecked((nuint)num6) - uIntPtr) * unchecked((nuint)(UIntPtr)Ns87.Default) != 0)
					{
						_ = (o1W)(object)Ns87.Default;
					}
					else
					{
						g6EQ = (g6EQ)(object)Ns87.Default;
					}
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (g6EQ)(object)Ns87.Default;
				}
				catch
				{
					s5C = s5C;
				}
			}
		}
		finally
		{
			try
			{
				_ = (Xq90)(object)Ns87.Default;
			}
			catch
			{
				_ = (o1W)(object)Ns87.Default;
			}
			goto IL_0904;
		}
		IL_0522:
		_003CModule_003E = _003CModule_003E;
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Ty3)(object)Ns87.Default;
				_ = (Ea3q)(object)Ns87.Default;
				_ = (Cy1)(object)Ns87.Default;
				q4PG q4PG = q4PG;
				q4PG = q4PG;
			}
			else
			{
				f1D = (f1D8)(object)Ns87.Default;
			}
		}
		finally
		{
			while ((object)Ns87.Default != null)
			{
				_ = (Sd5)(object)Ns87.Default;
			}
			goto IL_058f;
		}
		IL_07a0:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Ea3q)(object)Ns87.Default;
				_ = (q1J3)(object)Ns87.Default;
			}
			catch
			{
				sa = sa;
				sa = sa;
				_ = (Cy1)(object)Ns87.Default;
				xq = xq;
				ea3q = ea3q;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0)
			{
				try
				{
					k2GS2 = k2GS2;
				}
				finally
				{
					sa = sa;
					goto IL_082c;
				}
			}
			while ((object)Ns87.Default != null)
			{
				_ = (Xq90)(object)Ns87.Default;
			}
		}
		goto IL_082c;
	}
}
