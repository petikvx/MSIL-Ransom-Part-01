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
using Di68;
using Kr2c;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using x0S1;

namespace q4G1;

[DesignerGenerated]
public class b7KC : Form
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
			EventHandler eventHandler = q6F8;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			Label obj = label;
			Qp49.char_0[75] = (char)((Qp49.char_0[75] - n0J5.char_0[132]) & 'Y');
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
			EventHandler eventHandler = Ww97;
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
			EventHandler eventHandler = Ci8y;
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
			EventHandler eventHandler = Kx95;
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
			EventHandler eventHandler = Hk27;
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

	public b7KC()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)c9ZT);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		s7GP();
	}

	[DebuggerNonUserCode]
	protected override void c1NQ(bool g4X1)
	{
		try
		{
			if (g4X1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g4X1);
		}
	}

	[DebuggerStepThrough]
	private void s7GP()
	{
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		char[] char_ = Qp49.char_0;
		int num = 13;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 9;
			while (true)
			{
				txtSRcode = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 62;
				while (true)
				{
					Label9 = new Label();
					txtSRName = new TextBox();
					Label8 = new Label();
					num = 65;
					while (true)
					{
						Label5 = new Label();
						Label4 = new Label();
						txtSCode = new TextBox();
						num = 37;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							txtSEmail = new TextBox();
							num = 6;
							while (true)
							{
								txtSName = new TextBox();
								txtSRAmount = new TextBox();
								Label2 = new Label();
								num = 45;
								while (true)
								{
									btnSave = new Button();
									txtSphoneno = new TextBox();
									Label1 = new Label();
									num = 11;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										while (true)
										{
											Label3.set_AutoSize(true);
											num = 17;
											while (true)
											{
												((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
												num = 59;
												while (true)
												{
													((Control)Label3).set_ForeColor(Color.White);
													((Control)Label3).set_Location(new Point(336, 29));
													num = 82;
													while (true)
													{
														((Control)Label3).set_Name("Label3");
														((Control)Label3).set_Size(new Size(115, 17));
														num = 76;
														while (true)
														{
															((Control)Label3).set_TabIndex(9);
															Label3.set_Text("Supplier Detail");
															num = 33;
															while (true)
															{
																Label6.set_AutoSize(true);
																((Control)Label6).set_BackColor(Color.Blue);
																num = 64;
																while (true)
																{
																	((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																	num = 12;
																	while (true)
																	{
																		((Control)Label6).set_ForeColor(Color.White);
																		((Control)Label6).set_Location(new Point(721, 29));
																		num = 78;
																		while (true)
																		{
																			((Control)Label6).set_Name("Label6");
																			((Control)Label6).set_Size(new Size(18, 17));
																			num = 66;
																			while (true)
																			{
																				((Control)Label6).set_TabIndex(11);
																				Label6.set_Text("X");
																				num = 39;
																				while (true)
																				{
																					Label7.set_AutoSize(true);
																					((Control)Label7).set_BackColor(Color.Blue);
																					switch (char_[6])
																					{
																					case 'ڜ':
																						break;
																					case 'ڷ':
																						goto end_IL_000e;
																					case 'ۃ':
																						goto end_IL_01ab;
																					case 'ځ':
																						goto end_IL_01d0;
																					case 'ڵ':
																						goto end_IL_01f9;
																					case 'ږ':
																						goto end_IL_0225;
																					case 'ہ':
																						goto end_IL_0247;
																					case 'ۇ':
																						goto end_IL_0268;
																					case 'ڰ':
																						goto end_IL_028a;
																					case 'چ':
																						goto end_IL_02b3;
																					case 'ۄ':
																						goto end_IL_02df;
																					case 'ڀ':
																						goto end_IL_0301;
																					case 'ڢ':
																						goto end_IL_0312;
																					case 'ٻ':
																						goto end_IL_0325;
																					case 'ښ':
																						goto end_IL_034b;
																					case 'ڶ':
																						goto end_IL_0371;
																					case 'ڳ':
																						goto end_IL_0396;
																					case 'پ':
																						goto end_IL_03bc;
																					default:
																						goto end_IL_03e2;
																					case 'ڕ':
																						((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																						num = 8;
																						goto case 'ٽ';
																					case 'ٽ':
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(29, 29));
																						num = 51;
																						goto case 'ڨ';
																					case 'ڨ':
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 10;
																						goto case 'ٿ';
																					case 'ٿ':
																						((Control)Label7).set_TabIndex(10);
																						Label7.set_Text("Go To Main");
																						num = 2;
																						goto case 'ٷ';
																					case 'ٷ':
																						((Control)txtSRcode).set_Location(new Point(504, 151));
																						((Control)txtSRcode).set_Name("txtSRcode");
																						num = 84;
																						goto case 'ۉ';
																					case 'ۉ':
																						((Control)txtSRcode).set_Size(new Size(100, 20));
																						((Control)txtSRcode).set_TabIndex(6);
																						num = 81;
																						goto case 'ۆ';
																					case 'ۆ':
																						Label10.set_AutoSize(true);
																						((Control)Label10).set_ForeColor(Color.White);
																						num = 52;
																						goto case 'ک';
																					case 'ک':
																						((Control)Label10).set_Location(new Point(428, 157));
																						((Control)Label10).set_Name("Label10");
																						num = 75;
																						goto case 'ۀ';
																					case 'ۀ':
																						((Control)Label10).set_Size(new Size(60, 13));
																						((Control)Label10).set_TabIndex(99);
																						num = 24;
																						goto case 'ڍ';
																					case 'ڍ':
																						Label10.set_Text("Raw Code:");
																						DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																						num = 35;
																						goto case 'ژ';
																					case 'ژ':
																						((Control)DataGridView1).set_Location(new Point(32, 239));
																						((Control)DataGridView1).set_Name("DataGridView1");
																						num = 1;
																						goto case 'ٶ';
																					case 'ٶ':
																						((Control)DataGridView1).set_Size(new Size(724, 199));
																						((Control)DataGridView1).set_TabIndex(11);
																						num = 60;
																						goto case 'ڱ';
																					case 'ڱ':
																						Label9.set_AutoSize(true);
																						((Control)Label9).set_ForeColor(Color.White);
																						num = 28;
																						goto case 'ڑ';
																					case 'ڑ':
																						((Control)Label9).set_Location(new Point(422, 95));
																						((Control)Label9).set_Name("Label9");
																						num = 5;
																						goto case 'ٺ';
																					case 'ٺ':
																						((Control)Label9).set_Size(new Size(66, 13));
																						((Control)Label9).set_TabIndex(96);
																						num = 57;
																						goto case 'ڮ';
																					case 'ڮ':
																						Label9.set_Text("Raw Name :");
																						((Control)txtSRName).set_Location(new Point(504, 88));
																						num = 58;
																						goto case 'گ';
																					case 'گ':
																						((Control)txtSRName).set_Name("txtSRName");
																						((Control)txtSRName).set_Size(new Size(100, 20));
																						num = 25;
																						goto case 'ڎ';
																					case 'ڎ':
																						((Control)txtSRName).set_TabIndex(4);
																						Label8.set_AutoSize(true);
																						num = 18;
																						goto case 'ڇ';
																					case 'ڇ':
																						((Control)Label8).set_ForeColor(Color.White);
																						((Control)Label8).set_Location(new Point(164, 182));
																						num = 74;
																						goto case 'ڿ';
																					case 'ڿ':
																						((Control)Label8).set_Name("Label8");
																						((Control)Label8).set_Size(new Size(50, 13));
																						num = 16;
																						goto case 'څ';
																					case 'څ':
																						((Control)Label8).set_TabIndex(94);
																						Label8.set_Text("Email Id :");
																						num = 41;
																						goto case 'ڞ';
																					case 'ڞ':
																						Label5.set_AutoSize(true);
																						((Control)Label5).set_ForeColor(Color.White);
																						num = 72;
																						goto case 'ڽ';
																					case 'ڽ':
																						((Control)Label5).set_Location(new Point(134, 122));
																						((Control)Label5).set_Name("Label5");
																						num = 38;
																						goto case 'ڛ';
																					case 'ڛ':
																						((Control)Label5).set_Size(new Size(82, 13));
																						((Control)Label5).set_TabIndex(93);
																						num = 31;
																						goto case 'ڔ';
																					case 'ڔ':
																						Label5.set_Text("Supplier Name :");
																						Label4.set_AutoSize(true);
																						num = 22;
																						goto case 'ڋ';
																					case 'ڋ':
																						((Control)Label4).set_ForeColor(Color.White);
																						((Control)Label4).set_Location(new Point(414, 127));
																						num = 50;
																						goto case 'ڧ';
																					case 'ڧ':
																						((Control)Label4).set_Name("Label4");
																						((Control)Label4).set_Size(new Size(74, 13));
																						num = 30;
																						goto case 'ړ';
																					case 'ړ':
																						((Control)Label4).set_TabIndex(92);
																						Label4.set_Text("Raw Amount :");
																						num = 29;
																						goto case 'ڒ';
																					case 'ڒ':
																						((Control)txtSCode).set_Location(new Point(241, 85));
																						((Control)txtSCode).set_Name("txtSCode");
																						num = 88;
																						goto case 'ۍ';
																					case 'ۍ':
																						((Control)txtSCode).set_Size(new Size(100, 20));
																						((Control)txtSCode).set_TabIndex(0);
																						num = 19;
																						goto case 'ڈ';
																					case 'ڈ':
																						((Control)btnDelete).set_Location(new Point(483, 202));
																						((Control)btnDelete).set_Name("btnDelete");
																						num = 71;
																						goto case 'ڼ';
																					case 'ڼ':
																						((Control)btnDelete).set_Size(new Size(75, 31));
																						((Control)btnDelete).set_TabIndex(9);
																						num = 36;
																						goto case 'ڙ';
																					case 'ڙ':
																						((ButtonBase)btnDelete).set_Text("DELETE");
																						((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																						num = 85;
																						goto case 'ۊ';
																					case 'ۊ':
																						((Control)btnModify).set_Location(new Point(365, 202));
																						((Control)btnModify).set_Name("btnModify");
																						num = 4;
																						goto case 'ٹ';
																					case 'ٹ':
																						((Control)btnModify).set_Size(new Size(75, 31));
																						((Control)btnModify).set_TabIndex(8);
																						num = 73;
																						goto case 'ھ';
																					case 'ھ':
																						((ButtonBase)btnModify).set_Text("MODIFY");
																						((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																						num = 87;
																						goto case 'ی';
																					case 'ی':
																						((Control)txtSEmail).set_Location(new Point(241, 176));
																						((Control)txtSEmail).set_Name("txtSEmail");
																						num = 20;
																						goto case 'ډ';
																					case 'ډ':
																						((Control)txtSEmail).set_Size(new Size(100, 20));
																						((Control)txtSEmail).set_TabIndex(3);
																						num = 42;
																						goto case 'ڟ';
																					case 'ڟ':
																					case 'ۈ':
																						((Control)txtSName).set_Location(new Point(239, 115));
																						((Control)txtSName).set_Name("txtSName");
																						num = 40;
																						goto case 'ڝ';
																					case 'ڝ':
																						((Control)txtSName).set_Size(new Size(100, 20));
																						((Control)txtSName).set_TabIndex(1);
																						num = 48;
																						goto case 'ڥ';
																					case 'ڥ':
																						((Control)txtSRAmount).set_Location(new Point(504, 122));
																						((Control)txtSRAmount).set_Name("txtSRAmount");
																						num = 70;
																						goto case 'ڻ';
																					case 'ڻ':
																						((Control)txtSRAmount).set_Size(new Size(100, 20));
																						((Control)txtSRAmount).set_TabIndex(5);
																						num = 7;
																						goto case 'ټ';
																					case 'ټ':
																						Label2.set_AutoSize(true);
																						((Control)Label2).set_ForeColor(Color.White);
																						num = 46;
																						goto case 'ڣ';
																					case 'ڣ':
																						((Control)Label2).set_Location(new Point(138, 88));
																						goto case 'ڡ';
																					case 'ڡ':
																						((Control)Label2).set_Name("Label2");
																						num = 3;
																						goto case 'ٸ';
																					case 'ٸ':
																						((Control)Label2).set_Size(new Size(79, 13));
																						((Control)Label2).set_TabIndex(90);
																						num = 54;
																						goto case 'ګ';
																					case 'ګ':
																						Label2.set_Text("Supplier Code :");
																						((Control)btnSave).set_Location(new Point(236, 202));
																						num = 47;
																						goto case 'ڤ';
																					case 'ڤ':
																						((Control)btnSave).set_Name("btnSave");
																						((Control)btnSave).set_Size(new Size(75, 31));
																						num = 0;
																						goto case 'ٵ';
																					case 'ٵ':
																						((Control)btnSave).set_TabIndex(7);
																						((ButtonBase)btnSave).set_Text("SAVE");
																						num = 26;
																						goto case 'ڏ';
																					case 'ڏ':
																						((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																						((Control)txtSphoneno).set_Location(new Point(239, 150));
																						num = 56;
																						goto case 'ڭ';
																					case 'ڭ':
																						((Control)txtSphoneno).set_Name("txtSphoneno");
																						((Control)txtSphoneno).set_Size(new Size(100, 20));
																						num = 23;
																						goto case 'ڌ';
																					case 'ڌ':
																						((Control)txtSphoneno).set_TabIndex(2);
																						Label1.set_AutoSize(true);
																						num = 14;
																						goto case 'ڃ';
																					case 'ڃ':
																						((Control)Label1).set_ForeColor(Color.White);
																						((Control)Label1).set_Location(new Point(153, 153));
																						num = 21;
																						goto case 'ڊ';
																					case 'ڊ':
																						((Control)Label1).set_Name("Label1");
																						((Control)Label1).set_Size(new Size(61, 13));
																						num = 55;
																						goto case 'ڬ';
																					case 'ڬ':
																						((Control)Label1).set_TabIndex(101);
																						Label1.set_Text("Phone No :");
																						num = 80;
																						goto case 'ۅ';
																					case 'ۅ':
																						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																						((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																						num = 27;
																						goto case 'ڐ';
																					case 'ڐ':
																						((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																						((Form)this).set_ClientSize(new Size(800, 450));
																						num = 68;
																						goto case 'ڹ';
																					case 'ڹ':
																						((Control)this).get_Controls().Add((Control)(object)Label1);
																						((Control)this).get_Controls().Add((Control)(object)txtSphoneno);
																						num = 61;
																						goto case 'ڲ';
																					case 'ڲ':
																						((Control)this).get_Controls().Add((Control)(object)txtSRcode);
																						((Control)this).get_Controls().Add((Control)(object)Label10);
																						num = 63;
																						goto case 'ڴ';
																					case 'ڴ':
																						((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																						((Control)this).get_Controls().Add((Control)(object)Label9);
																						num = 67;
																						goto case 'ڸ';
																					case 'ڸ':
																						((Control)this).get_Controls().Add((Control)(object)txtSRName);
																						((Control)this).get_Controls().Add((Control)(object)Label8);
																						num = 69;
																						goto case 'ں';
																					case 'ں':
																						((Control)this).get_Controls().Add((Control)(object)Label5);
																						((Control)this).get_Controls().Add((Control)(object)Label4);
																						num = 34;
																						goto case 'ڗ';
																					case 'ڗ':
																						((Control)this).get_Controls().Add((Control)(object)txtSCode);
																						((Control)this).get_Controls().Add((Control)(object)btnDelete);
																						num = 43;
																						goto case 'ڠ';
																					case 'ڠ':
																						((Control)this).get_Controls().Add((Control)(object)btnModify);
																						((Control)this).get_Controls().Add((Control)(object)txtSEmail);
																						num = 15;
																						goto case 'ڄ';
																					case 'ڄ':
																						((Control)this).get_Controls().Add((Control)(object)txtSName);
																						((Control)this).get_Controls().Add((Control)(object)txtSRAmount);
																						num = 53;
																						goto case 'ڪ';
																					case 'ڪ':
																						((Control)this).get_Controls().Add((Control)(object)Label2);
																						((Control)this).get_Controls().Add((Control)(object)btnSave);
																						num = 89;
																						goto case 'ێ';
																					case 'ێ':
																						((Control)this).get_Controls().Add((Control)(object)Label6);
																						((Control)this).get_Controls().Add((Control)(object)Label7);
																						num = 86;
																						goto case 'ۋ';
																					case 'ۋ':
																						((Control)this).get_Controls().Add((Control)(object)Label3);
																						((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																						num = 90;
																						goto case 'ۏ';
																					case 'ۏ':
																						((Control)this).set_Name("frmSupplierDetail");
																						((Form)this).set_StartPosition((FormStartPosition)1);
																						((Form)this).set_Text("frmSupplierDetail");
																						num = 77;
																						goto case 'ۂ';
																					case 'ۂ':
																						((ISupportInitialize)DataGridView1).EndInit();
																						((Control)this).ResumeLayout(false);
																						((Control)this).PerformLayout();
																						num = 49;
																						return;
																					case 'ڦ':
																						return;
																					}
																					continue;
																					end_IL_000e:
																					break;
																				}
																				continue;
																				end_IL_01ab:
																				break;
																			}
																			continue;
																			end_IL_01d0:
																			break;
																		}
																		continue;
																		end_IL_01f9:
																		break;
																	}
																	continue;
																	end_IL_0225:
																	break;
																}
																continue;
																end_IL_0247:
																break;
															}
															continue;
															end_IL_0268:
															break;
														}
														continue;
														end_IL_028a:
														break;
													}
													continue;
													end_IL_02b3:
													break;
												}
												continue;
												end_IL_02df:
												break;
											}
											continue;
											end_IL_0301:
											break;
										}
										continue;
										end_IL_0312:
										break;
									}
									continue;
									end_IL_0325:
									break;
								}
								continue;
								end_IL_034b:
								break;
							}
							continue;
							end_IL_0371:
							break;
						}
						continue;
						end_IL_0396:
						break;
					}
					continue;
					end_IL_03bc:
					break;
				}
				continue;
				end_IL_03e2:
				break;
			}
		}
	}

	private void Ww97(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void q6F8(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void c9ZT(object sender, EventArgs e)
	{
		Wg3x();
	}

	private void Hk27(object sender, EventArgs e)
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
		Wg3x();
		Qp49.char_0[184] = (char)((Qp49.char_0[184] ^ Qp49.char_0[55]) & 'Á');
	}

	public void Wg3x()
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

	private void Ci8y(object sender, EventArgs e)
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
		Wg3x();
	}

	private void Kx95(object sender, EventArgs e)
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
		Wg3x();
	}

	internal static byte[] Jn29(string[] k5SZ, int Li17)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[k5SZ.Length - 1 + 1];
				int num = k5SZ.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (k5SZ[i].Contains(value))
						{
							int startIndex = k5SZ[i].IndexOf(value);
							array[i] = k5SZ[i].Remove(startIndex, 10);
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Dx5s.mDic["AO"]);
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
