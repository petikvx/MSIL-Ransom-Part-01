using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wi0;
using Xs3;
using c7R0;
using p6H;

namespace Fz5;

[DesignerGenerated]
public class g7A : Form
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
			EventHandler eventHandler = Zp5;
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
				Pr5.byte_0[160] = (byte)((Pr5.byte_0[160] + Pr5.byte_0[245]) & 0x51);
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
			EventHandler eventHandler = Wb0;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("txtSNo")]
	internal virtual TextBox txtSNo
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
			EventHandler eventHandler = Hd9;
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
				b4C0.char_0[580] = (char)((b4C0.char_0[580] + b4C0.char_0[292]) & '6');
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
			EventHandler eventHandler = Ny4;
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

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRaw")]
	internal virtual TextBox txtSRaw
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
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
			EventHandler eventHandler = e9B;
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

	public g7A()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)t3W);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		y1X();
	}

	[DebuggerNonUserCode]
	protected override void m1T(bool Rk0)
	{
		byte[] byte_ = Pr5.byte_0;
		try
		{
			int num = 1;
			while (true)
			{
				IL_0052:
				if (!Rk0)
				{
					num = 7;
					goto IL_000e;
				}
				num = 0;
				goto IL_003e;
				IL_003e:
				if (components == null)
				{
					goto IL_000e;
				}
				num = 2;
				goto IL_0059;
				IL_0059:
				components.Dispose();
				break;
				IL_000e:
				while (true)
				{
					switch (byte_[108])
					{
					case 80:
						break;
					case 73:
					case 78:
						goto end_IL_000e;
					default:
						goto IL_0052;
					case 75:
						goto IL_0059;
					case 76:
						goto end_IL_0052;
					case 77:
					case 79:
						return;
					}
					continue;
					end_IL_000e:
					break;
				}
				goto IL_003e;
				continue;
				end_IL_0052:
				break;
			}
			num = 4;
		}
		finally
		{
			((Form)this).Dispose(Rk0);
		}
	}

	[DebuggerStepThrough]
	private void y1X()
	{
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		char[] char_ = b4C0.char_0;
		int num = 23;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 41;
			while (true)
			{
				DataGridView1 = new DataGridView();
				DateTimePicker1 = new DateTimePicker();
				Label8 = new Label();
				num = 40;
				while (true)
				{
					Label5 = new Label();
					Label4 = new Label();
					Label1 = new Label();
					num = 10;
					while (true)
					{
						txtSNo = new TextBox();
						btnDelete = new Button();
						btnModify = new Button();
						num = 8;
						while (true)
						{
							txtAmount = new TextBox();
							txtSRaw = new TextBox();
							txtWeight = new TextBox();
							num = 12;
							while (true)
							{
								Label2 = new Label();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 49;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 68;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(355, 22));
										num = 0;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(95, 17));
											num = 65;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Sales Detail");
												num = 16;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 57;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 71;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(739, 22));
															num = 6;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 51;
																while (true)
																{
																	((Control)Label6).set_TabIndex(9);
																	Label6.set_Text("X");
																	num = 1;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 52;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 7;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(47, 22));
																				while (true)
																				{
																					num = 56;
																					while (true)
																					{
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 20;
																						while (true)
																						{
																							((Control)Label7).set_TabIndex(8);
																							Label7.set_Text("Go To Main");
																							num = 60;
																							while (true)
																							{
																								DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																								((Control)DataGridView1).set_Location(new Point(33, 239));
																								num = 15;
																								while (true)
																								{
																									((Control)DataGridView1).set_Name("DataGridView1");
																									((Control)DataGridView1).set_Size(new Size(724, 199));
																									num = 35;
																									while (true)
																									{
																										((Control)DataGridView1).set_TabIndex(10);
																										((Control)DateTimePicker1).set_Location(new Point(525, 64));
																										num = 53;
																										while (true)
																										{
																											((Control)DateTimePicker1).set_Name("DateTimePicker1");
																											((Control)DateTimePicker1).set_Size(new Size(126, 20));
																											num = 11;
																											while (true)
																											{
																												((Control)DateTimePicker1).set_TabIndex(3);
																												Label8.set_AutoSize(true);
																												num = 44;
																												while (true)
																												{
																													((Control)Label8).set_ForeColor(Color.White);
																													((Control)Label8).set_Location(new Point(154, 130));
																													num = 14;
																													while (true)
																													{
																														((Control)Label8).set_Name("Label8");
																														((Control)Label8).set_Size(new Size(49, 13));
																														num = 48;
																														while (true)
																														{
																															((Control)Label8).set_TabIndex(94);
																															Label8.set_Text("Amount :");
																															num = 19;
																															while (true)
																															{
																																Label5.set_AutoSize(true);
																																((Control)Label5).set_ForeColor(Color.White);
																																num = 31;
																																while (true)
																																{
																																	((Control)Label5).set_Location(new Point(144, 101));
																																	((Control)Label5).set_Name("Label5");
																																	num = 24;
																																	while (true)
																																	{
																																		((Control)Label5).set_Size(new Size(66, 13));
																																		((Control)Label5).set_TabIndex(93);
																																		num = 28;
																																		while (true)
																																		{
																																			Label5.set_Text("Raw Name :");
																																			Label4.set_AutoSize(true);
																																			char num2 = char_[416];
																																			Pr5.byte_0[258] = (byte)((Pr5.byte_0[258] * Pr5.byte_0[40]) & 0xE2);
																																			switch (num2 - 64371)
																																			{
																																			case 28:
																																				break;
																																			case 24:
																																				goto end_IL_000e;
																																			case 31:
																																				goto end_IL_0198;
																																			case 19:
																																				goto end_IL_01c1;
																																			case 48:
																																				goto end_IL_01ed;
																																			case 14:
																																				goto end_IL_020e;
																																			case 44:
																																				goto end_IL_0230;
																																			case 11:
																																				goto end_IL_0259;
																																			case 53:
																																				goto end_IL_0288;
																																			case 35:
																																				goto end_IL_02a5;
																																			case 15:
																																				goto end_IL_02ce;
																																			case 60:
																																				goto end_IL_02f7;
																																			case 20:
																																				goto end_IL_0326;
																																			case 56:
																																				goto end_IL_034e;
																																			case 67:
																																				goto end_IL_036f;
																																			case 7:
																																				goto end_IL_0398;
																																			case 52:
																																				goto end_IL_039d;
																																			case 1:
																																				goto end_IL_03c3;
																																			case 51:
																																				goto end_IL_03e4;
																																			case 6:
																																				goto end_IL_0405;
																																			case 71:
																																				goto end_IL_0426;
																																			case 57:
																																				goto end_IL_044f;
																																			case 16:
																																				goto end_IL_047a;
																																			case 65:
																																				goto end_IL_049c;
																																			case 0:
																																				goto end_IL_04bd;
																																			case 68:
																																				goto end_IL_04df;
																																			case 49:
																																				goto end_IL_0508;
																																			case 12:
																																				goto end_IL_0533;
																																			case 8:
																																				goto end_IL_0567;
																																			case 10:
																																				goto end_IL_058d;
																																			case 40:
																																				goto end_IL_05b3;
																																			case 41:
																																				goto end_IL_05d8;
																																			default:
																																				goto end_IL_05fe;
																																			case 58:
																																			case 62:
																																				((Control)Label4).set_ForeColor(Color.White);
																																				((Control)Label4).set_Location(new Point(431, 102));
																																				num = 26;
																																				goto case 26;
																																			case 26:
																																				((Control)Label4).set_Name("Label4");
																																				((Control)Label4).set_Size(new Size(72, 13));
																																				num = 55;
																																				goto case 55;
																																			case 55:
																																				((Control)Label4).set_TabIndex(92);
																																				Label4.set_Text("Raw Weight :");
																																				num = 61;
																																				goto case 61;
																																			case 61:
																																				Label1.set_AutoSize(true);
																																				((Control)Label1).set_ForeColor(Color.White);
																																				num = 5;
																																				goto case 5;
																																			case 5:
																																			case 38:
																																				((Control)Label1).set_Location(new Point(438, 64));
																																				((Control)Label1).set_Name("Label1");
																																				num = 34;
																																				goto case 34;
																																			case 34:
																																				((Control)Label1).set_Size(new Size(65, 13));
																																				((Control)Label1).set_TabIndex(91);
																																				num = 69;
																																				goto case 69;
																																			case 69:
																																				Label1.set_Text("Sales Date :");
																																				((Control)txtSNo).set_Location(new Point(233, 64));
																																				num = 75;
																																				goto case 75;
																																			case 75:
																																				((Control)txtSNo).set_Name("txtSNo");
																																				((Control)txtSNo).set_Size(new Size(100, 20));
																																				num = 73;
																																				goto case 73;
																																			case 73:
																																				((Control)txtSNo).set_TabIndex(0);
																																				((Control)btnDelete).set_Location(new Point(480, 172));
																																				num = 70;
																																				goto case 70;
																																			case 70:
																																				((Control)btnDelete).set_Name("btnDelete");
																																				((Control)btnDelete).set_Size(new Size(75, 31));
																																				num = 22;
																																				goto case 22;
																																			case 22:
																																				((Control)btnDelete).set_TabIndex(7);
																																				((ButtonBase)btnDelete).set_Text("DELETE");
																																				num = 66;
																																				goto case 66;
																																			case 66:
																																				((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																				((Control)btnModify).set_Location(new Point(362, 172));
																																				num = 63;
																																				goto case 63;
																																			case 63:
																																				((Control)btnModify).set_Name("btnModify");
																																				((Control)btnModify).set_Size(new Size(75, 31));
																																				num = 45;
																																				goto case 45;
																																			case 45:
																																				((Control)btnModify).set_TabIndex(6);
																																				((ButtonBase)btnModify).set_Text("MODIFY");
																																				num = 64;
																																				goto case 64;
																																			case 64:
																																				((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																				((Control)txtAmount).set_Location(new Point(231, 124));
																																				num = 37;
																																				goto case 37;
																																			case 37:
																																				((Control)txtAmount).set_Name("txtAmount");
																																				((Control)txtAmount).set_Size(new Size(100, 20));
																																				num = 47;
																																				goto case 47;
																																			case 47:
																																				((Control)txtAmount).set_TabIndex(2);
																																				((Control)txtSRaw).set_Location(new Point(231, 94));
																																				num = 29;
																																				goto case 29;
																																			case 29:
																																				((Control)txtSRaw).set_Name("txtSRaw");
																																				((Control)txtSRaw).set_Size(new Size(100, 20));
																																				num = 2;
																																				goto case 2;
																																			case 2:
																																				((Control)txtSRaw).set_TabIndex(1);
																																				((Control)txtWeight).set_Location(new Point(525, 99));
																																				num = 74;
																																				goto case 74;
																																			case 74:
																																				((Control)txtWeight).set_Name("txtWeight");
																																				((Control)txtWeight).set_Size(new Size(100, 20));
																																				num = 36;
																																				goto case 36;
																																			case 36:
																																				((Control)txtWeight).set_TabIndex(4);
																																				Label2.set_AutoSize(true);
																																				num = 59;
																																				goto case 59;
																																			case 59:
																																				((Control)Label2).set_ForeColor(Color.White);
																																				((Control)Label2).set_Location(new Point(155, 67));
																																				num = 9;
																																				goto case 9;
																																			case 9:
																																				((Control)Label2).set_Name("Label2");
																																				((Control)Label2).set_Size(new Size(56, 13));
																																				num = 25;
																																				goto case 25;
																																			case 25:
																																				((Control)Label2).set_TabIndex(90);
																																				Label2.set_Text("Sales No :");
																																				num = 50;
																																				goto case 50;
																																			case 50:
																																				((Control)btnSave).set_Location(new Point(233, 172));
																																				((Control)btnSave).set_Name("btnSave");
																																				num = 3;
																																				goto case 3;
																																			case 3:
																																				((Control)btnSave).set_Size(new Size(75, 31));
																																				((Control)btnSave).set_TabIndex(5);
																																				num = 30;
																																				goto case 30;
																																			case 30:
																																				((ButtonBase)btnSave).set_Text("SAVE");
																																				((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																				num = 39;
																																				goto case 39;
																																			case 39:
																																				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																				num = 32;
																																				goto case 32;
																																			case 32:
																																				((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																				((Form)this).set_ClientSize(new Size(800, 450));
																																				num = 54;
																																				goto case 54;
																																			case 54:
																																				((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																				((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																																				num = 43;
																																				goto case 43;
																																			case 43:
																																				((Control)this).get_Controls().Add((Control)(object)Label8);
																																				((Control)this).get_Controls().Add((Control)(object)Label5);
																																				num = 33;
																																				goto case 33;
																																			case 33:
																																				((Control)this).get_Controls().Add((Control)(object)Label4);
																																				((Control)this).get_Controls().Add((Control)(object)Label1);
																																				num = 72;
																																				goto case 72;
																																			case 72:
																																				((Control)this).get_Controls().Add((Control)(object)txtSNo);
																																				((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																				num = 17;
																																				goto case 17;
																																			case 17:
																																				((Control)this).get_Controls().Add((Control)(object)btnModify);
																																				((Control)this).get_Controls().Add((Control)(object)txtAmount);
																																				num = 21;
																																				goto case 21;
																																			case 21:
																																				((Control)this).get_Controls().Add((Control)(object)txtSRaw);
																																				((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																				num = 4;
																																				goto case 4;
																																			case 4:
																																				((Control)this).get_Controls().Add((Control)(object)Label2);
																																				((Control)this).get_Controls().Add((Control)(object)btnSave);
																																				num = 18;
																																				goto case 18;
																																			case 18:
																																				((Control)this).get_Controls().Add((Control)(object)Label6);
																																				((Control)this).get_Controls().Add((Control)(object)Label7);
																																				num = 42;
																																				goto case 42;
																																			case 42:
																																				((Control)this).get_Controls().Add((Control)(object)Label3);
																																				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																				num = 46;
																																				goto case 46;
																																			case 46:
																																				((Control)this).set_Name("frmSalesDetail");
																																				((Form)this).set_StartPosition((FormStartPosition)1);
																																				((Form)this).set_Text("frmSalesDetail");
																																				num = 27;
																																				goto case 27;
																																			case 27:
																																				((ISupportInitialize)DataGridView1).EndInit();
																																				((Control)this).ResumeLayout(false);
																																				((Control)this).PerformLayout();
																																				num = 13;
																																				return;
																																			case 13:
																																				return;
																																			}
																																			continue;
																																			end_IL_000e:
																																			break;
																																		}
																																		continue;
																																		end_IL_0198:
																																		break;
																																	}
																																	continue;
																																	end_IL_01c1:
																																	break;
																																}
																																continue;
																																end_IL_01ed:
																																break;
																															}
																															continue;
																															end_IL_020e:
																															break;
																														}
																														continue;
																														end_IL_0230:
																														break;
																													}
																													continue;
																													end_IL_0259:
																													break;
																												}
																												continue;
																												end_IL_0288:
																												break;
																											}
																											continue;
																											end_IL_02a5:
																											break;
																										}
																										continue;
																										end_IL_02ce:
																										break;
																									}
																									continue;
																									end_IL_02f7:
																									break;
																								}
																								continue;
																								end_IL_0326:
																								break;
																							}
																							continue;
																							end_IL_034e:
																							break;
																						}
																						continue;
																						end_IL_036f:
																						break;
																					}
																					continue;
																					end_IL_0398:
																					break;
																				}
																				continue;
																				end_IL_039d:
																				break;
																			}
																			continue;
																			end_IL_03c3:
																			break;
																		}
																		continue;
																		end_IL_03e4:
																		break;
																	}
																	continue;
																	end_IL_0405:
																	break;
																}
																continue;
																end_IL_0426:
																break;
															}
															continue;
															end_IL_044f:
															break;
														}
														continue;
														end_IL_047a:
														break;
													}
													continue;
													end_IL_049c:
													break;
												}
												continue;
												end_IL_04bd:
												break;
											}
											continue;
											end_IL_04df:
											break;
										}
										continue;
										end_IL_0508:
										break;
									}
									continue;
									end_IL_0533:
									break;
								}
								continue;
								end_IL_0567:
								break;
							}
							continue;
							end_IL_058d:
							break;
						}
						continue;
						end_IL_05b3:
						break;
					}
					continue;
					end_IL_05d8:
					break;
				}
				continue;
				end_IL_05fe:
				break;
			}
		}
	}

	private void Wb0(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void Zp5(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void t3W(object sender, EventArgs e)
	{
	}

	private void e9B(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_sales_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())) + ",'" + DateTimePicker1.get_Text() + "','" + txtSRaw.get_Text() + "','" + txtWeight.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ")");
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
		x7H();
	}

	public void x7H()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_sales_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Sales No");
			DataGridView1.get_Columns().Add("c2", "Sales Date");
			DataGridView1.get_Columns().Add("c3", "Raw Name");
			DataGridView1.get_Columns().Add("c4", "Raw Weight");
			DataGridView1.get_Columns().Add("c4", "Amount");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("salesno").ToString(),
					rd.get_Item("salesdate"),
					rd.get_Item("raw"),
					rd.get_Item("rawweight"),
					rd.get_Item("amount").ToString()
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

	private void Hd9(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_sales_detail where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		x7H();
	}

	internal static string[] e8G()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(f6Y.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				int num2 = 0;
				while (true)
				{
					bool num3 = num2 < array2.Length;
					b4C0.char_0[84] = unchecked((char)((b4C0.char_0[84] | b4C0.char_0[488]) & '\u008f'));
					if (!num3)
					{
						break;
					}
					string item = array2[num2];
					list.Add(item);
					num2++;
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num4 = array3.Length - 1;
				for (num = 0; num <= num4; num++)
				{
					array3[num] = list[num];
				}
				return array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Ny4(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_sales_detail set salesdate ='" + DateTimePicker1.get_Text() + "',raw='" + txtSRaw.get_Text() + "',rawweight='" + txtWeight.get_Text() + "',amount='" + txtAmount.get_Text() + "'  where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		x7H();
	}
}
