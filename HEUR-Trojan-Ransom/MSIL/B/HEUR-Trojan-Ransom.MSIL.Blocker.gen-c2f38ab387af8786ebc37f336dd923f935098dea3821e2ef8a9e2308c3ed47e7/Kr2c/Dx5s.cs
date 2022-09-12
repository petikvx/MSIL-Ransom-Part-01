using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz7;
using Di68;
using Gn3;
using Hx0;
using Jz9;
using Kd1q;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using a2A;
using b9YC;
using e2D3;
using i4B6;
using j3S2;
using n2X;
using o5FP;
using q0GA;
using q4G1;
using w1R;
using x0S1;
using x9B;

namespace Kr2c;

[DesignerGenerated]
public class Dx5s : Form
{
	internal delegate void q0D5();

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
			EventHandler eventHandler = Po1p;
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
			EventHandler eventHandler = p9X8;
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
			EventHandler eventHandler = q2A1;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			Button obj = val;
			Qp49.char_0[288] = (char)((Qp49.char_0[288] | n0J5.char_0[302]) & 'U');
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
			EventHandler eventHandler = Wt34;
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
			EventHandler eventHandler = k1B5;
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

	public Dx5s()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Ji50);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Me4r();
	}

	[DebuggerNonUserCode]
	protected override void x9JK(bool r8L3)
	{
		char[] char_ = Qp49.char_0;
		try
		{
			int num = 1;
			bool flag = default(bool);
			while (true)
			{
				if (!r8L3)
				{
					switch (char_[380])
					{
					case '邦':
						goto IL_0043;
					case '邬':
						goto IL_004e;
					case '邪':
						goto IL_0050;
					case '邨':
						goto IL_0055;
					case '邭':
						goto end_IL_003e;
					case '邩':
					case '邫':
						return;
					}
					continue;
				}
				num = 0;
				goto IL_0043;
				IL_0050:
				if (flag)
				{
					num = 2;
					goto IL_0055;
				}
				num = 5;
				return;
				IL_0055:
				components.Dispose();
				break;
				IL_004e:
				int num2 = 0;
				goto IL_004f;
				IL_0043:
				num2 = ((components != null) ? 1 : 0);
				goto IL_004f;
				IL_004f:
				flag = (byte)num2 != 0;
				goto IL_0050;
				continue;
				end_IL_003e:
				break;
			}
			num = 5;
		}
		finally
		{
			((Form)this).Dispose(r8L3);
		}
	}

	[DebuggerStepThrough]
	private void Me4r()
	{
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		char[] char_ = Qp49.char_0;
		int num = 37;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 39;
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
					num = 2;
					while (true)
					{
						Label1 = new Label();
						txtBNo = new TextBox();
						btnDelete = new Button();
						num = 48;
						while (true)
						{
							btnModify = new Button();
							txtDiscount = new TextBox();
							txtRDetail = new TextBox();
							num = 10;
							while (true)
							{
								txtCname = new TextBox();
								Label2 = new Label();
								btnSave = new Button();
								num = 24;
								while (true)
								{
									DataGridView1 = new DataGridView();
									Label10 = new Label();
									txtTotal = new TextBox();
									num = 85;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										Label3.set_AutoSize(true);
										num = 81;
										while (true)
										{
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 6;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(363, 29));
												num = 67;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(52, 17));
													num = 58;
													while (true)
													{
														((Control)Label3).set_TabIndex(7);
														Label3.set_Text("Billing");
														num = 66;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 32;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 54;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 29));
																	num = 59;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 21;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(11);
																			Label6.set_Text("X");
																			num = 52;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 15;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 38;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(42, 29));
																						num = 49;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 56;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(10);
																								Label7.set_Text("Go To Main");
																								num = 5;
																								while (true)
																								{
																									((Control)DateTimePicker1).set_Location(new Point(537, 64));
																									while (true)
																									{
																										((Control)DateTimePicker1).set_Name("DateTimePicker1");
																										num = 42;
																										while (true)
																										{
																											((Control)DateTimePicker1).set_Size(new Size(126, 20));
																											((Control)DateTimePicker1).set_TabIndex(4);
																											switch (char_[65])
																											{
																											case '紩':
																												break;
																											case '級':
																												goto end_IL_000e;
																											case '約':
																												goto end_IL_01b0;
																											case '紷':
																												goto end_IL_01c8;
																											case '細':
																												goto end_IL_01e1;
																											case '紥':
																												goto end_IL_0202;
																											case '紎':
																												goto end_IL_022b;
																											case '紳':
																												goto end_IL_0254;
																											case '純':
																												goto end_IL_0276;
																											case '紺':
																												goto end_IL_0297;
																											case '紵':
																												goto end_IL_02b9;
																											case '紟':
																												goto end_IL_02e2;
																											case '絁':
																												goto end_IL_030e;
																											case '紹':
																												goto end_IL_0330;
																											case '終':
																												goto end_IL_0351;
																											case '紅':
																												goto end_IL_0372;
																											case '結':
																												goto end_IL_039b;
																											case '絔':
																												goto end_IL_03c7;
																											case '紗':
																												goto end_IL_03e8;
																											case '紉':
																												goto end_IL_040a;
																											case '累':
																												goto end_IL_0430;
																											case '紁':
																												goto end_IL_0456;
																											case '絒':
																												goto end_IL_047c;
																											case '紦':
																												goto end_IL_04a2;
																											default:
																												goto end_IL_04c7;
																											case '糿':
																												Label9.set_AutoSize(true);
																												((Control)Label9).set_ForeColor(Color.White);
																												num = 28;
																												goto case '紛';
																											case '紛':
																												((Control)Label9).set_Location(new Point(132, 162));
																												((Control)Label9).set_Name("Label9");
																												num = 22;
																												goto case '紕';
																											case '紕':
																												((Control)Label9).set_Size(new Size(88, 13));
																												((Control)Label9).set_TabIndex(78);
																												num = 33;
																												goto case '素';
																											case '素':
																												Label9.set_Text("Transport Detail :");
																												((Control)txtTransport).set_Location(new Point(243, 159));
																												num = 19;
																												goto case '紒';
																											case '紒':
																												((Control)txtTransport).set_Name("txtTransport");
																												((Control)txtTransport).set_Size(new Size(100, 20));
																												num = 76;
																												goto case '絋';
																											case '絋':
																												((Control)txtTransport).set_TabIndex(3);
																												Label8.set_AutoSize(true);
																												num = 80;
																												goto case '絏';
																											case '絏':
																												((Control)Label8).set_ForeColor(Color.White);
																												((Control)Label8).set_Location(new Point(166, 130));
																												num = 8;
																												goto case '紇';
																											case '紇':
																												((Control)Label8).set_Name("Label8");
																												((Control)Label8).set_Size(new Size(55, 13));
																												num = 65;
																												goto case '絀';
																											case '絀':
																												((Control)Label8).set_TabIndex(76);
																												Label8.set_Text("Discount :");
																												num = 7;
																												goto case '紆';
																											case '紆':
																												Label5.set_AutoSize(true);
																												((Control)Label5).set_ForeColor(Color.White);
																												num = 47;
																												goto case '紮';
																											case '紮':
																												((Control)Label5).set_Location(new Point(156, 101));
																												((Control)Label5).set_Name("Label5");
																												num = 86;
																												goto case '絕';
																											case '絕':
																												((Control)Label5).set_Size(new Size(65, 13));
																												((Control)Label5).set_TabIndex(75);
																												num = 77;
																												goto case '経';
																											case '経':
																												Label5.set_Text("Raw Detail :");
																												Label4.set_AutoSize(true);
																												num = 17;
																												goto case '紐';
																											case '紐':
																												((Control)Label4).set_ForeColor(Color.White);
																												((Control)Label4).set_Location(new Point(427, 106));
																												num = 9;
																												goto case '紈';
																											case '紈':
																												((Control)Label4).set_Name("Label4");
																												((Control)Label4).set_Size(new Size(88, 13));
																												num = 30;
																												goto case '紝';
																											case '紝':
																												((Control)Label4).set_TabIndex(74);
																												Label4.set_Text("Customer Name :");
																												num = 63;
																												goto case '紾';
																											case '紾':
																												Label1.set_AutoSize(true);
																												((Control)Label1).set_ForeColor(Color.White);
																												num = 45;
																												goto case '紬';
																											case '紬':
																												((Control)Label1).set_Location(new Point(450, 64));
																												((Control)Label1).set_Name("Label1");
																												num = 78;
																												goto case '絍';
																											case '絍':
																												((Control)Label1).set_Size(new Size(66, 13));
																												((Control)Label1).set_TabIndex(73);
																												num = 50;
																												goto case '紱';
																											case '紱':
																												Label1.set_Text("Billing Date :");
																												((Control)txtBNo).set_Location(new Point(245, 64));
																												num = 68;
																												goto case '絃';
																											case '絃':
																												((Control)txtBNo).set_Name("txtBNo");
																												((Control)txtBNo).set_Size(new Size(100, 20));
																												num = 11;
																												goto case '紊';
																											case '紊':
																												((Control)txtBNo).set_TabIndex(0);
																												((Control)btnDelete).set_Location(new Point(496, 202));
																												goto case '紴';
																											case '紴':
																												num = 16;
																												goto case '紏';
																											case '紏':
																												((Control)btnDelete).set_Name("btnDelete");
																												((Control)btnDelete).set_Size(new Size(75, 31));
																												num = 79;
																												goto case '絎';
																											case '絎':
																												((Control)btnDelete).set_TabIndex(9);
																												((ButtonBase)btnDelete).set_Text("DELETE");
																												num = 43;
																												goto case '紪';
																											case '紪':
																												((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																												goto case '納';
																											case '納':
																												((Control)btnModify).set_Location(new Point(378, 202));
																												num = 72;
																												goto case '絇';
																											case '絇':
																												((Control)btnModify).set_Name("btnModify");
																												((Control)btnModify).set_Size(new Size(75, 31));
																												num = 69;
																												goto case '組';
																											case '組':
																												((Control)btnModify).set_TabIndex(8);
																												((ButtonBase)btnModify).set_Text("MODIFY");
																												num = 61;
																												goto case '紼';
																											case '紼':
																												((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																												((Control)txtDiscount).set_Location(new Point(243, 124));
																												num = 74;
																												goto case '絉';
																											case '絉':
																												((Control)txtDiscount).set_Name("txtDiscount");
																												((Control)txtDiscount).set_Size(new Size(100, 20));
																												num = 55;
																												goto case '紶';
																											case '紶':
																												((Control)txtDiscount).set_TabIndex(2);
																												((Control)txtRDetail).set_Location(new Point(243, 94));
																												num = 18;
																												goto case '紑';
																											case '紑':
																												((Control)txtRDetail).set_Name("txtRDetail");
																												((Control)txtRDetail).set_Size(new Size(100, 20));
																												num = 60;
																												goto case '紻';
																											case '紻':
																												((Control)txtRDetail).set_TabIndex(1);
																												((Control)txtCname).set_Location(new Point(537, 99));
																												num = 1;
																												goto case '紀';
																											case '紀':
																												((Control)txtCname).set_Name("txtCname");
																												((Control)txtCname).set_Size(new Size(100, 20));
																												num = 62;
																												goto case '紽';
																											case '紽':
																												((Control)txtCname).set_TabIndex(5);
																												Label2.set_AutoSize(true);
																												num = 75;
																												goto case '絊';
																											case '絊':
																												((Control)Label2).set_ForeColor(Color.White);
																												((Control)Label2).set_Location(new Point(167, 67));
																												num = 36;
																												goto case '紣';
																											case '紣':
																												((Control)Label2).set_Name("Label2");
																												((Control)Label2).set_Size(new Size(57, 13));
																												num = 89;
																												goto case '絘';
																											case '絘':
																												((Control)Label2).set_TabIndex(72);
																												Label2.set_Text("Billing No :");
																												num = 26;
																												goto case '紙';
																											case '紙':
																												((Control)btnSave).set_Location(new Point(249, 202));
																												((Control)btnSave).set_Name("btnSave");
																												num = 40;
																												goto case '紧';
																											case '紧':
																												((Control)btnSave).set_Size(new Size(75, 31));
																												((Control)btnSave).set_TabIndex(7);
																												num = 13;
																												goto case '紌';
																											case '紌':
																												((ButtonBase)btnSave).set_Text("SAVE");
																												((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																												num = 34;
																												goto case '紡';
																											case '紡':
																												DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																												((Control)DataGridView1).set_Location(new Point(45, 239));
																												num = 46;
																												goto case '紭';
																											case '紭':
																												((Control)DataGridView1).set_Name("DataGridView1");
																												((Control)DataGridView1).set_Size(new Size(724, 199));
																												num = 35;
																												goto case '索';
																											case '索':
																												((Control)DataGridView1).set_TabIndex(12);
																												Label10.set_AutoSize(true);
																												num = 71;
																												goto case '絆';
																											case '絆':
																												((Control)Label10).set_ForeColor(Color.White);
																												((Control)Label10).set_Location(new Point(478, 139));
																												num = 12;
																												goto case '紋';
																											case '紋':
																												((Control)Label10).set_Name("Label10");
																												((Control)Label10).set_Size(new Size(37, 13));
																												num = 82;
																												goto case '絑';
																											case '絑':
																												((Control)Label10).set_TabIndex(81);
																												Label10.set_Text("Total :");
																												num = 88;
																												goto case '絗';
																											case '絗':
																												((Control)txtTotal).set_Location(new Point(537, 136));
																												((Control)txtTotal).set_Name("txtTotal");
																												num = 64;
																												goto case '紿';
																											case '紿':
																												((Control)txtTotal).set_Size(new Size(100, 20));
																												((Control)txtTotal).set_TabIndex(6);
																												num = 70;
																												goto case '絅';
																											case '絅':
																												((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																												((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																												num = 31;
																												goto case '紞';
																											case '紞':
																												((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																												((Form)this).set_ClientSize(new Size(800, 450));
																												num = 73;
																												goto case '絈';
																											case '絈':
																												((Control)this).get_Controls().Add((Control)(object)txtTotal);
																												((Control)this).get_Controls().Add((Control)(object)Label10);
																												num = 87;
																												goto case '絖';
																											case '絖':
																												((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																												((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																												num = 44;
																												goto case '紫';
																											case '紫':
																												((Control)this).get_Controls().Add((Control)(object)Label9);
																												((Control)this).get_Controls().Add((Control)(object)txtTransport);
																												num = 20;
																												goto case '紓';
																											case '紓':
																												((Control)this).get_Controls().Add((Control)(object)Label8);
																												((Control)this).get_Controls().Add((Control)(object)Label5);
																												num = 51;
																												goto case '紲';
																											case '紲':
																												((Control)this).get_Controls().Add((Control)(object)Label4);
																												((Control)this).get_Controls().Add((Control)(object)Label1);
																												num = 4;
																												goto case '紃';
																											case '紃':
																												((Control)this).get_Controls().Add((Control)(object)txtBNo);
																												((Control)this).get_Controls().Add((Control)(object)btnDelete);
																												num = 29;
																												goto case '紜';
																											case '紜':
																												((Control)this).get_Controls().Add((Control)(object)btnModify);
																												((Control)this).get_Controls().Add((Control)(object)txtDiscount);
																												num = 23;
																												goto case '紖';
																											case '紖':
																												((Control)this).get_Controls().Add((Control)(object)txtRDetail);
																												((Control)this).get_Controls().Add((Control)(object)txtCname);
																												num = 57;
																												goto case '紸';
																											case '紸':
																												((Control)this).get_Controls().Add((Control)(object)Label2);
																												((Control)this).get_Controls().Add((Control)(object)btnSave);
																												num = 25;
																												goto case '紘';
																											case '紘':
																												((Control)this).get_Controls().Add((Control)(object)Label6);
																												((Control)this).get_Controls().Add((Control)(object)Label7);
																												num = 90;
																												goto case '絙';
																											case '絙':
																												((Control)this).get_Controls().Add((Control)(object)Label3);
																												((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																												num = 41;
																												goto case '紨';
																											case '紨':
																												((Control)this).set_Name("frmBilling");
																												((Form)this).set_StartPosition((FormStartPosition)1);
																												((Form)this).set_Text("frmBilling");
																												num = 84;
																												goto case '絓';
																											case '絓':
																												((ISupportInitialize)DataGridView1).EndInit();
																												((Control)this).ResumeLayout(false);
																												((Control)this).PerformLayout();
																												num = 3;
																												return;
																											case '紂':
																												return;
																											}
																											continue;
																											end_IL_000e:
																											break;
																										}
																										continue;
																										end_IL_01b0:
																										break;
																									}
																									continue;
																									end_IL_01c8:
																									break;
																								}
																								continue;
																								end_IL_01e1:
																								break;
																							}
																							continue;
																							end_IL_0202:
																							break;
																						}
																						continue;
																						end_IL_022b:
																						break;
																					}
																					continue;
																					end_IL_0254:
																					break;
																				}
																				continue;
																				end_IL_0276:
																				break;
																			}
																			continue;
																			end_IL_0297:
																			break;
																		}
																		continue;
																		end_IL_02b9:
																		break;
																	}
																	continue;
																	end_IL_02e2:
																	break;
																}
																continue;
																end_IL_030e:
																break;
															}
															continue;
															end_IL_0330:
															break;
														}
														continue;
														end_IL_0351:
														break;
													}
													continue;
													end_IL_0372:
													break;
												}
												continue;
												end_IL_039b:
												break;
											}
											continue;
											end_IL_03c7:
											break;
										}
										continue;
										end_IL_03e8:
										break;
									}
									continue;
									end_IL_040a:
									break;
								}
								continue;
								end_IL_0430:
								break;
							}
							continue;
							end_IL_0456:
							break;
						}
						continue;
						end_IL_047c:
						break;
					}
					continue;
					end_IL_04a2:
					break;
				}
				continue;
				end_IL_04c7:
				break;
			}
		}
	}

	private void p9X8(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void Po1p(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Ji50(object sender, EventArgs e)
	{
		Qf34();
	}

	private void k1B5(object sender, EventArgs e)
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
		Qf34();
	}

	public void Qf34()
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

	private void Wt34(object sender, EventArgs e)
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
		Qf34();
	}

	private void q2A1(object sender, EventArgs e)
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
		Qf34();
	}

	[STAThread]
	public static void Wp4j()
	{
		try
		{
			int j0X;
			do
			{
				j0X = 2;
			}
			while (!g2J4.Kd0() || !Cx7.c2C(j0X));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = Qp49.d4H7(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = Qp49.d4H7(Listt, 1, 1);
			mName = Qp49.d4H7(Listt, 2, 2);
			mArray = Qp49.d4H7(Listt, 3, 3);
			sArray = Qp49.d4H7(Listt, 4, 4);
			T = Qp49.d4H7(Listt, 5, 5);
			sNum = Qp49.d4H7(Listt, 6, 6);
			mDic.Add(sNum, 98);
			byte[] value = Cx7.j1Z(98, 15);
			mDic.Add(sArray, value);
			Qt2.c0C();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void t7CY()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pw9k pw9k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
		while ((object)e7WK.Default != null)
		{
			uIntPtr = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					pw9k = pw9k;
					pw9k = null;
					z0R = z0R;
					z0R = null;
				}
				else
				{
					_ = (b6G)e7WK.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		try
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (b6G)e7WK.Default;
				}
				else
				{
					c8CP obj = (c8CP)(object)e7WK.Default;
					c8CP = (c8CP)(object)e7WK.Default;
					c8CP = obj;
				}
				obj2 = e7WK.Default;
			}
			while (obj2 != null);
		}
		catch
		{
			do
			{
				if ((nuint)(UIntPtr)e7WK.Default / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			while (obj2 != null);
		}
		UIntPtr num = (UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		Yo50 yo;
		if (checked(unchecked((nuint)num) * uIntPtr) == 0)
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = e7WK.Default;
				}
				else
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
			}
			catch
			{
			}
		}
		else if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				_ = (b6G)e7WK.Default;
			}
		}
		else
		{
			yo = (Yo50)(object)e7WK.Default;
			yo = yo;
		}
		do
		{
			_ = (Dx5s)(object)e7WK.Default;
		}
		while (obj2 != null);
		nuint num2 = checked((unchecked((nuint)(UIntPtr)e7WK.Default) - uIntPtr) * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) / (nuint)(UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		if (num2 / uIntPtr == 0)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (n0J5)(object)e7WK.Default;
			}
			else
			{
				qe = (Qe07)(object)e7WK.Default;
				qe = qe;
				_ = (n0J5)(object)e7WK.Default;
				z0R = z0R;
			}
		}
		try
		{
			while ((object)e7WK.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					qe = (Qe07)(object)e7WK.Default;
				}
			}
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (g2J4)(object)e7WK.Default;
			}
			goto IL_024f;
		}
		IL_03d2:
		qe = qe;
		checked
		{
			if (unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				while (obj2 != null)
				{
					_ = (Yo50)(object)e7WK.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		while (obj2 != null)
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					q1M = q1M;
					q1M = null;
					continue;
				}
				_ = (z8Y)(object)e7WK.Default;
				_ = (So3)(object)e7WK.Default;
				fz = fz;
				fz = default(Fz0);
				fz = fz;
			}
			catch
			{
				_003CModule_003E = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				do
				{
					nuint num3 = uIntPtr * unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (num3 + uIntPtr == 0)
					{
						cx = (Cx7)(object)e7WK.Default;
					}
				}
				while ((object)e7WK.Default != null);
			}
		}
		_ = (Qe07)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr != 0)
			{
			}
		}
		else
		{
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				try
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
				finally
				{
					z0R = null;
					goto IL_050d;
				}
			}
			if (uIntPtr == 0)
			{
				y2HN = y2HN;
			}
			else
			{
				_ = (Qt2)(object)e7WK.Default;
			}
		}
		goto IL_050d;
		IL_05dc:
		do
		{
			q1M = null;
		}
		while ((object)e7WK.Default != null);
		_ = (o2T)(object)e7WK.Default;
		if (uIntPtr != 0)
		{
			_ = (b6G)e7WK.Default;
		}
		yo = null;
		_ = (Qt2)(object)e7WK.Default;
		_ = (Pw9k)(object)e7WK.Default;
		do
		{
			try
			{
				do
				{
					n0J5 n0J = (n0J5)(object)e7WK.Default;
					n0J = n0J;
				}
				while (obj2 != null);
			}
			catch
			{
				cx = cx;
			}
		}
		while ((object)e7WK.Default != null);
		try
		{
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Qe07)(object)e7WK.Default;
				_ = (_003CModule_003E)(object)e7WK.Default;
				yo = null;
			}
			else
			{
				_ = (Cx7)(object)e7WK.Default;
			}
		}
		while ((object)e7WK.Default != null)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				finally
				{
					cx = (Cx7)(object)e7WK.Default;
					continue;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			b6G b6G = default(b6G);
		}
		return;
		IL_050d:
		try
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = e7WK.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					qe = qe;
				}
				else
				{
					e7WK e7WK = e7WK;
					e7WK = e7WK;
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				goto end_IL_054b;
			}
			end_IL_054b:;
		}
		try
		{
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (b6G)e7WK.Default;
			}
			else
			{
				Qt2 qt = qt;
			}
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
			while (obj2 != null)
			{
				Qp49 obj11 = (Qp49)(object)e7WK.Default;
				qp = qp;
				qp = obj11;
			}
			goto IL_05dc;
		}
		IL_024f:
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					y2HN = y2HN;
					y2HN = null;
				}
				else
				{
					_ = (Qt2)(object)e7WK.Default;
				}
			}
			catch
			{
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				y2HN = (y2HN)(object)e7WK.Default;
			}
		}
		_ = (_003CModule_003E)(object)e7WK.Default;
		try
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (o2T)(object)e7WK.Default;
				}
				else
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			finally
			{
				try
				{
					_ = (b7KC)(object)e7WK.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
					goto end_IL_029a;
				}
			}
			end_IL_029a:;
		}
		catch
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					b6G b6G = default(b6G);
				}
				else
				{
					_ = (b7KC)(object)e7WK.Default;
					cx = cx;
					cx = null;
					_ = (Cx7)(object)e7WK.Default;
				}
			}
			finally
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (So3)(object)e7WK.Default;
				}
				goto end_IL_02e0;
			}
			end_IL_02e0:;
		}
		checked
		{
			if (unchecked(checked(uIntPtr + uIntPtr) / uIntPtr) + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			try
			{
				while (obj2 != null)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
						_ = (Dx5s)(object)e7WK.Default;
					}
					finally
					{
						_ = (o2T)(object)e7WK.Default;
						continue;
					}
				}
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
				finally
				{
					c8CP = c8CP;
					goto end_IL_039e;
				}
				end_IL_039e:;
			}
			try
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
			finally
			{
				while (obj2 != null)
				{
				}
				goto IL_03d2;
			}
		}
	}

	static void c3J7()
	{
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		if (num == 0)
		{
			do
			{
				try
				{
					cx = null;
					cx = cx;
				}
				finally
				{
					_ = (Yo50)(object)e7WK.Default;
					continue;
				}
			}
			while ((object)e7WK.Default != null);
		}
		else if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)e7WK.Default != null)
			{
				_ = (n0J5)(object)e7WK.Default;
				_ = (z8Y)(object)e7WK.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		checked
		{
			try
			{
				z0R3 z0R = (z0R3)(object)e7WK.Default;
				z0R = z0R;
			}
			finally
			{
				do
				{
					if (num + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						fz = fz;
						fz = default(Fz0);
					}
					obj = obj;
				}
				while (obj != null);
				goto IL_00d0;
			}
		}
		IL_028e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			while (obj != null)
			{
			}
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			goto IL_02ad;
		}
		IL_07bc:
		checked
		{
			while (obj != null)
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * unchecked(num / num) == 0)
				{
					if (num * (num - unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
					{
						_ = (_003CModule_003E)(object)e7WK.Default;
					}
				}
				else if (num == 0)
				{
					_ = e7WK.Default;
				}
			}
			return;
		}
		IL_02ad:
		Qe07 qe = qe;
		qe = qe;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
		if (num == 0)
		{
			do
			{
				g2J = null;
			}
			while ((object)e7WK.Default != null);
		}
		So3 so;
		while ((object)e7WK.Default != null)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qe07)(object)e7WK.Default;
				}
				catch
				{
					so = null;
				}
			}
			else
			{
				_ = (So3)(object)e7WK.Default;
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				qp = qp;
				_ = (b7KC)(object)e7WK.Default;
				_ = (b7KC)(object)e7WK.Default;
				_ = (y2HN)(object)e7WK.Default;
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				try
				{
					_ = (Qe07)(object)e7WK.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
				finally
				{
					cx = cx;
					goto end_IL_036d;
				}
				end_IL_036d:;
			}
			catch
			{
				try
				{
					_ = (o2T)(object)e7WK.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_0387;
				}
				end_IL_0387:;
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)e7WK.Default != null)
				{
					fz = fz;
				}
			}
			catch
			{
				qp = qp;
			}
		}
		while ((object)e7WK.Default != null)
		{
			_ = (Cx7)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		try
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (So3)(object)e7WK.Default;
			}
			else
			{
				dx5s = (Dx5s)(object)e7WK.Default;
				dx5s = null;
			}
		}
		finally
		{
			so = so;
			_ = (Cx7)(object)e7WK.Default;
			goto IL_042b;
		}
		IL_0273:
		try
		{
			_ = (o2T)(object)e7WK.Default;
		}
		finally
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
			goto IL_028e;
		}
		IL_042b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (y2HN)(object)e7WK.Default;
			qe = (Qe07)(object)e7WK.Default;
			q1M = (q1M)(object)e7WK.Default;
			q1M = q1M;
			o2T o2T = null;
		}
		_ = (c8CP)(object)e7WK.Default;
		_ = (Yo50)(object)e7WK.Default;
		cx = null;
		dx5s = dx5s;
		while (true)
		{
			if ((object)e7WK.Default != null)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (z0R3)(object)e7WK.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out n0J5 n0J);
			try
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
				}
				finally
				{
					if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						z8Y obj7 = (z8Y)(object)e7WK.Default;
						z8Y z8Y = z8Y;
						z8Y = obj7;
					}
					else
					{
						n0J = n0J;
						n0J = n0J;
					}
					goto end_IL_04b7;
				}
				end_IL_04b7:;
			}
			catch
			{
				while (obj != null)
				{
					do
					{
						_ = (o2T)(object)e7WK.Default;
					}
					while (obj != null);
				}
			}
			try
			{
				_ = (Pw9k)(object)e7WK.Default;
			}
			catch
			{
				g2J = null;
			}
			_ = (_003CModule_003E)(object)e7WK.Default;
			_ = (Dx5s)(object)e7WK.Default;
			n0J = n0J;
			_ = (b7KC)(object)e7WK.Default;
			while (obj != null)
			{
				q1M = q1M;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
			do
			{
				UIntPtr num2 = unchecked((UIntPtr)e7WK.Default);
				num = default(UIntPtr);
				if ((unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)num2) - num)) + num) * unchecked(num / num) == 0)
				{
					num = default(UIntPtr);
					if (unchecked(num / num) == 0)
					{
						_ = (y2HN)(object)e7WK.Default;
						continue;
					}
					e7WK obj10 = e7WK.Default;
					e7WK = e7WK;
					e7WK = obj10;
					_ = (Qp49)(object)e7WK.Default;
					_ = (_003CModule_003E)(object)e7WK.Default;
					_ = (y2HN)(object)e7WK.Default;
				}
			}
			while (obj != null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
			while (true)
			{
				if (obj != null)
				{
					try
					{
						b6G = b6G;
						b6G = b6G;
					}
					catch
					{
						qt = qt;
					}
				}
				else if (obj == null)
				{
					break;
				}
			}
			if (num == 0)
			{
				while ((object)e7WK.Default != null)
				{
					while (obj != null)
					{
						dx5s = dx5s;
					}
				}
			}
			cx = null;
			cx = cx;
			so = so;
			_ = (Pw9k)(object)e7WK.Default;
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					while (obj != null)
					{
						fz = (Fz0)e7WK.Default;
					}
				}
			}
			catch
			{
				do
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
				while (obj != null || (object)e7WK.Default != null);
			}
			_ = (Pw9k)(object)e7WK.Default;
			if (num == 0)
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)e7WK.Default / ((nuint)(UIntPtr)e7WK.Default / (nuint)(UIntPtr)e7WK.Default)) + num == 0)
					{
						so = so;
					}
					else
					{
						z8Y z8Y = (z8Y)(object)e7WK.Default;
						c8CP = c8CP;
						_ = (c8CP)(object)e7WK.Default;
					}
				}
				finally
				{
					try
					{
						so = null;
					}
					finally
					{
						g2J = g2J;
						goto IL_07bc;
					}
				}
			}
			goto IL_07bc;
		}
		IL_0121:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (o2T)(object)e7WK.Default;
		}
		try
		{
			fz = default(Fz0);
			fz = fz;
		}
		catch
		{
			y2HN y2HN = y2HN;
			y2HN = y2HN;
		}
		_ = (b7KC)(object)e7WK.Default;
		so = (So3)(object)e7WK.Default;
		try
		{
			z0R3 z0R = null;
		}
		catch
		{
			try
			{
				_ = (Qe07)(object)e7WK.Default;
			}
			catch
			{
				_ = (Qe07)(object)e7WK.Default;
			}
		}
		finally
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					fz = (Fz0)e7WK.Default;
				}
				else
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			while (obj != null);
			goto IL_01e5;
		}
		IL_00d0:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				so = (So3)(object)e7WK.Default;
				so = null;
			}
			finally
			{
				qt = (Qt2)(object)e7WK.Default;
				qt = null;
				goto IL_0106;
			}
		}
		goto IL_0106;
		IL_01e5:
		while (obj != null)
		{
			while (obj != null)
			{
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			c8CP = c8CP;
			c8CP = c8CP;
		}
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				try
				{
					o2T o2T = o2T;
					o2T = o2T;
				}
				finally
				{
					num = default(UIntPtr);
					nuint num3 = num - num;
					num = default(UIntPtr);
					if (num3 + num == 0)
					{
						g2J4 obj16 = (g2J4)(object)e7WK.Default;
						g2J = null;
						g2J = obj16;
					}
					else
					{
						_ = (Pw9k)(object)e7WK.Default;
					}
					goto IL_0273;
				}
			}
			goto IL_0273;
		}
		IL_0106:
		try
		{
			_ = (Pw9k)(object)e7WK.Default;
			_ = (Pw9k)(object)e7WK.Default;
		}
		finally
		{
			goto IL_0121;
		}
	}
}
