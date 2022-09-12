using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz7;
using Di68;
using Gn3;
using Hx0;
using Kd1q;
using Kr2c;
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

namespace Jz9;

[DesignerGenerated]
public class o2T : Form
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
			EventHandler eventHandler = x5A;
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
			EventHandler eventHandler = t7L;
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

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
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
			EventHandler eventHandler = j4H;
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
			EventHandler eventHandler = k3R;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			Button obj = val;
			Qp49.char_0[284] = (char)((Qp49.char_0[284] * Qp49.char_0[247]) & '\u001e');
			if (obj != null)
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

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPStock")]
	internal virtual TextBox txtPStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCost")]
	internal virtual TextBox txtPCost
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

	[field: AccessedThroughProperty("txtPid")]
	internal virtual TextBox txtPid
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
			EventHandler eventHandler = So3;
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

	public o2T()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)q2Z);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		f5D();
	}

	[DebuggerNonUserCode]
	protected override void s8Q(bool Fi1)
	{
		try
		{
			Qp49.char_0[377] = (char)((Qp49.char_0[377] ^ Qp49.char_0[401]) & 'T');
			if (Fi1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fi1);
		}
	}

	[DebuggerStepThrough]
	private void f5D()
	{
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected O, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Expected O, but got Unknown
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected O, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected O, but got Unknown
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected O, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected O, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected O, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected O, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected O, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected O, but got Unknown
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected O, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected O, but got Unknown
		char[] char_ = n0J5.char_0;
		char[] char_2 = Qp49.char_0;
		int num = 75;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 44;
			while (true)
			{
				txtPMachine = new TextBox();
				Label9 = new Label();
				btnDelete = new Button();
				num = 38;
				while (true)
				{
					btnModify = new Button();
					DataGridView1 = new DataGridView();
					txtWeight = new TextBox();
					num = 48;
					while (true)
					{
						txtPStock = new TextBox();
						txtPCost = new TextBox();
						Label4 = new Label();
						num = 20;
						while (true)
						{
							Label1 = new Label();
							Label2 = new Label();
							Label5 = new Label();
							num = 72;
							while (true)
							{
								txtPid = new TextBox();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 61;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 70;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(332, 21));
										num = 68;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(111, 17));
											num = 41;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Product Detail");
												num = 12;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 24;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 63;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(739, 21));
															num = 56;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 29;
																while (true)
																{
																	((Control)Label6).set_TabIndex(14);
																	Label6.set_Text("X");
																	num = 31;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 73;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 65;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(47, 21));
																				num = 66;
																				while (true)
																				{
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 6;
																					while (true)
																					{
																						((Control)Label7).set_TabIndex(13);
																						Label7.set_Text("Go To Main");
																						num = 62;
																						while (true)
																						{
																							((Control)txtPMachine).set_Location(new Point(413, 99));
																							((Control)txtPMachine).set_Name("txtPMachine");
																							num = 19;
																							while (true)
																							{
																								((Control)txtPMachine).set_Size(new Size(122, 20));
																								((Control)txtPMachine).set_TabIndex(4);
																								num = 3;
																								while (true)
																								{
																									Label9.set_AutoSize(true);
																									((Control)Label9).set_ForeColor(Color.White);
																									num = 51;
																									while (true)
																									{
																										((Control)Label9).set_Location(new Point(299, 99));
																										((Control)Label9).set_Name("Label9");
																										num = 14;
																										while (true)
																										{
																											((Control)Label9).set_Size(new Size(108, 13));
																											((Control)Label9).set_TabIndex(46);
																											num = 8;
																											while (true)
																											{
																												Label9.set_Text("Production Machine :");
																												((Control)btnDelete).set_Location(new Point(398, 218));
																												num = 55;
																												while (true)
																												{
																													((Control)btnDelete).set_Name("btnDelete");
																													((Control)btnDelete).set_Size(new Size(75, 23));
																													num = char_[336] - 57957;
																													while (true)
																													{
																														switch (num)
																														{
																														case 74:
																															((Control)this).get_Controls().Add((Control)(object)Label2);
																															((Control)this).get_Controls().Add((Control)(object)Label5);
																															num = char_2[3] - 3535;
																															continue;
																														case 71:
																															((Control)Label2).set_Size(new Size(62, 13));
																															((Control)Label2).set_TabIndex(35);
																															num = 16;
																															goto case 16;
																														case 16:
																															Label2.set_Text("Product Id :");
																															Label5.set_AutoSize(true);
																															num = 1;
																															goto case 1;
																														case 1:
																															((Control)Label5).set_ForeColor(Color.White);
																															((Control)Label5).set_Location(new Point(127, 102));
																															num = 60;
																															goto case 60;
																														case 60:
																															((Control)Label5).set_Name("Label5");
																															((Control)Label5).set_Size(new Size(34, 13));
																															num = 53;
																															goto case 53;
																														case 53:
																															((Control)Label5).set_TabIndex(34);
																															Label5.set_Text("Cost :");
																															num = 45;
																															goto case 45;
																														case 45:
																															((Control)txtPid).set_Location(new Point(191, 56));
																															((Control)txtPid).set_Name("txtPid");
																															num = 43;
																															goto case 43;
																														case 43:
																															((Control)txtPid).set_Size(new Size(100, 20));
																															((Control)txtPid).set_TabIndex(0);
																															num = 2;
																															goto case 2;
																														case 2:
																															((Control)btnSave).set_Location(new Point(178, 218));
																															((Control)btnSave).set_Name("btnSave");
																															num = 15;
																															goto case 15;
																														case 15:
																															((Control)btnSave).set_Size(new Size(75, 23));
																															((Control)btnSave).set_TabIndex(5);
																															num = 21;
																															goto case 21;
																														case 21:
																															((ButtonBase)btnSave).set_Text("SAVE");
																															((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																															num = 40;
																															goto case 40;
																														case 40:
																															((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																															((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																															num = 17;
																															goto case 17;
																														case 17:
																															((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																															((Form)this).set_ClientSize(new Size(800, 450));
																															num = 4;
																															goto case 4;
																														case 4:
																															((Control)this).get_Controls().Add((Control)(object)txtPMachine);
																															((Control)this).get_Controls().Add((Control)(object)Label9);
																															num = 59;
																															goto case 59;
																														case 59:
																															((Control)this).get_Controls().Add((Control)(object)btnDelete);
																															((Control)this).get_Controls().Add((Control)(object)btnModify);
																															num = 0;
																															goto case 0;
																														case 0:
																															((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																															((Control)this).get_Controls().Add((Control)(object)txtWeight);
																															num = 32;
																															goto case 32;
																														case 32:
																															((Control)this).get_Controls().Add((Control)(object)txtPStock);
																															((Control)this).get_Controls().Add((Control)(object)txtPCost);
																															num = 11;
																															goto case 11;
																														case 11:
																															((Control)this).get_Controls().Add((Control)(object)Label4);
																															((Control)this).get_Controls().Add((Control)(object)Label1);
																															num = 74;
																															goto case 74;
																														case 69:
																															Label4.set_Text("Weight :");
																															Label1.set_AutoSize(true);
																															num = 5;
																															goto case 5;
																														case 5:
																															((Control)Label1).set_ForeColor(Color.White);
																															((Control)Label1).set_Location(new Point(120, 141));
																															num = 36;
																															goto case 36;
																														case 36:
																															((Control)Label1).set_Name("Label1");
																															((Control)Label1).set_Size(new Size(41, 13));
																															num = 30;
																															goto case 30;
																														case 30:
																															((Control)Label1).set_TabIndex(36);
																															Label1.set_Text("Stock :");
																															num = 67;
																															goto case 67;
																														case 67:
																															Label2.set_AutoSize(true);
																															((Control)Label2).set_ForeColor(Color.White);
																															num = 34;
																															goto case 34;
																														case 34:
																															((Control)Label2).set_Location(new Point(99, 59));
																															((Control)Label2).set_Name("Label2");
																															num = 71;
																															goto case 71;
																														case 64:
																															((Control)txtPStock).set_Location(new Point(191, 134));
																															((Control)txtPStock).set_Name("txtPStock");
																															num = 7;
																															goto case 7;
																														case 7:
																															((Control)txtPStock).set_Size(new Size(100, 20));
																															((Control)txtPStock).set_TabIndex(2);
																															num = 9;
																															goto case 9;
																														case 9:
																														case 25:
																															((Control)txtPCost).set_Location(new Point(191, 95));
																															((Control)txtPCost).set_Name("txtPCost");
																															num = 26;
																															goto case 26;
																														case 26:
																															((Control)txtPCost).set_Size(new Size(100, 20));
																															((Control)txtPCost).set_TabIndex(1);
																															num = 52;
																															goto case 52;
																														case 52:
																															Label4.set_AutoSize(true);
																															((Control)Label4).set_ForeColor(Color.White);
																															num = 27;
																															goto case 27;
																														case 27:
																															((Control)Label4).set_Location(new Point(360, 56));
																															((Control)Label4).set_Name("Label4");
																															num = 42;
																															goto case 42;
																														case 42:
																														case 58:
																															((Control)Label4).set_Size(new Size(47, 13));
																															((Control)Label4).set_TabIndex(37);
																															num = 69;
																															goto case 69;
																														case 54:
																															((Control)btnModify).set_TabIndex(6);
																															goto case 50;
																														case 50:
																															((ButtonBase)btnModify).set_Text("MODIFY");
																															num = 35;
																															goto case 35;
																														case 35:
																															((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																															DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																															num = 33;
																															goto case 33;
																														case 33:
																															((Control)DataGridView1).set_Location(new Point(50, 255));
																															((Control)DataGridView1).set_Name("DataGridView1");
																															num = 22;
																															goto case 22;
																														case 22:
																															((Control)DataGridView1).set_Size(new Size(599, 183));
																															((Control)DataGridView1).set_TabIndex(41);
																															num = char_2[20] - 51473;
																															continue;
																														case 46:
																															((Control)this).get_Controls().Add((Control)(object)txtPid);
																															((Control)this).get_Controls().Add((Control)(object)btnSave);
																															num = char_[263] - 27975;
																															continue;
																														case 39:
																															((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																															((Control)btnModify).set_Location(new Point(286, 218));
																															num = 37;
																															goto case 37;
																														case 37:
																															((Control)btnModify).set_Name("btnModify");
																															((Control)btnModify).set_Size(new Size(75, 23));
																															num = 54;
																															goto case 54;
																														case 28:
																															((Control)txtWeight).set_Size(new Size(122, 20));
																															((Control)txtWeight).set_TabIndex(3);
																															num = 64;
																															goto case 64;
																														case 23:
																															((Control)btnDelete).set_TabIndex(7);
																															((ButtonBase)btnDelete).set_Text("DELETE");
																															num = 39;
																															goto case 39;
																														case 18:
																															((Control)txtWeight).set_Location(new Point(413, 53));
																															((Control)txtWeight).set_Name("txtWeight");
																															num = 28;
																															goto case 28;
																														case 55:
																															break;
																														case 8:
																															goto end_IL_0772;
																														case 14:
																															goto end_IL_07a9;
																														case 51:
																															goto end_IL_07d8;
																														case 3:
																															goto end_IL_07fd;
																														case 19:
																															goto end_IL_0829;
																														case 62:
																															goto end_IL_084a;
																														case 6:
																															goto end_IL_086e;
																														case 66:
																															goto end_IL_089a;
																														case 65:
																															goto end_IL_08bc;
																														case 73:
																															goto end_IL_08e4;
																														case 31:
																															goto end_IL_090d;
																														case 29:
																															goto end_IL_092f;
																														case 56:
																															goto end_IL_0950;
																														case 63:
																															goto end_IL_0972;
																														case 24:
																															goto end_IL_099b;
																														case 12:
																															goto end_IL_09c7;
																														case 41:
																															goto end_IL_09e9;
																														case 68:
																															goto end_IL_0a0a;
																														case 70:
																															goto end_IL_0a2c;
																														case 61:
																															goto end_IL_0a55;
																														case 72:
																															goto end_IL_0a81;
																														case 20:
																															goto end_IL_0ab5;
																														case 48:
																															goto end_IL_0adb;
																														case 38:
																															goto end_IL_0b01;
																														case 44:
																															goto end_IL_0b27;
																														default:
																															goto end_IL_0b4d;
																														case 10:
																															((Control)this).get_Controls().Add((Control)(object)Label6);
																															((Control)this).get_Controls().Add((Control)(object)Label7);
																															num = 13;
																															goto case 13;
																														case 13:
																															((Control)this).get_Controls().Add((Control)(object)Label3);
																															((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																															num = 57;
																															goto case 57;
																														case 57:
																															((Control)this).set_Name("frmProductDetail");
																															((Form)this).set_StartPosition((FormStartPosition)1);
																															((Form)this).set_Text("frmProductDetail");
																															num = 49;
																															goto case 49;
																														case 49:
																															((ISupportInitialize)DataGridView1).EndInit();
																															((Control)this).ResumeLayout(false);
																															((Control)this).PerformLayout();
																															num = 47;
																															return;
																														case 47:
																															return;
																														}
																														break;
																													}
																													continue;
																													end_IL_0772:
																													break;
																												}
																												continue;
																												end_IL_07a9:
																												break;
																											}
																											continue;
																											end_IL_07d8:
																											break;
																										}
																										continue;
																										end_IL_07fd:
																										break;
																									}
																									continue;
																									end_IL_0829:
																									break;
																								}
																								continue;
																								end_IL_084a:
																								break;
																							}
																							continue;
																							end_IL_086e:
																							break;
																						}
																						continue;
																						end_IL_089a:
																						break;
																					}
																					continue;
																					end_IL_08bc:
																					break;
																				}
																				continue;
																				end_IL_08e4:
																				break;
																			}
																			continue;
																			end_IL_090d:
																			break;
																		}
																		continue;
																		end_IL_092f:
																		break;
																	}
																	continue;
																	end_IL_0950:
																	break;
																}
																continue;
																end_IL_0972:
																break;
															}
															continue;
															end_IL_099b:
															break;
														}
														continue;
														end_IL_09c7:
														break;
													}
													continue;
													end_IL_09e9:
													break;
												}
												continue;
												end_IL_0a0a:
												break;
											}
											continue;
											end_IL_0a2c:
											break;
										}
										continue;
										end_IL_0a55:
										break;
									}
									continue;
									end_IL_0a81:
									break;
								}
								continue;
								end_IL_0ab5:
								break;
							}
							continue;
							end_IL_0adb:
							break;
						}
						continue;
						end_IL_0b01:
						break;
					}
					continue;
					end_IL_0b27:
					break;
				}
				continue;
				end_IL_0b4d:
				break;
			}
		}
	}

	private void t7L(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void x5A(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void So3(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_product_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",'" + txtPStock.get_Text() + "','" + txtWeight.get_Text() + "','" + txtPMachine.get_Text() + "')");
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
		j5B();
	}

	public void j5B()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_product_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Product Id");
			DataGridView1.get_Columns().Add("c2", "Product Cost");
			DataGridView1.get_Columns().Add("c3", "Product Stock");
			DataGridView1.get_Columns().Add("c4", "Product Weight");
			DataGridView1.get_Columns().Add("c5", "Production Machine");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("pid").ToString(),
					rd.get_Item("pcost").ToString(),
					rd.get_Item("pstock"),
					rd.get_Item("stockweight"),
					rd.get_Item("productionmachine")
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
		Qp49.char_0[388] = (char)((Qp49.char_0[388] ^ Qp49.char_0[52]) & '\u001c');
	}

	internal static byte[] Ld7(byte[] Wm4, byte[] Aq9, int e0P, int r1E)
	{
		int num = checked(Wm4.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			Wm4[i] = (byte)(Wm4[i] ^ checked((byte)(Aq9[unchecked(i % Aq9.Length)] ^ ((i + unchecked(e0P % Aq9.Length)) & e0P))));
		}
		return Wm4;
	}

	private void j4H(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_product_detail where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		j5B();
		Qp49.char_0[0] = (char)(Qp49.char_0[0] & Qp49.char_0[368] & 'µ');
	}

	private void k3R(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_product_detail set pcost = " + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",pstock=" + txtPStock.get_Text() + ",stockweight='" + txtWeight.get_Text() + "',productionmachine='" + txtPMachine.get_Text() + "' where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		j5B();
	}

	private void q2Z(object sender, EventArgs e)
	{
		j5B();
	}

	internal static string[] o7L()
	{
		Qt2.Ja2();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Dx5s.mDic.Add("AO", executingAssembly);
		string[] result = c8CP.Tf0r();
		n0J5.char_0[168] = (char)((n0J5.char_0[168] + n0J5.char_0[200]) & 'i');
		return result;
	}

	static void Ns6()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			_ = (Qe07)(object)e7WK.Default;
		}
		finally
		{
			num = checked(unchecked((nuint)(UIntPtr)e7WK.Default) + num) / checked(num * unchecked(num / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr)));
			if (num == 0)
			{
				_ = (y2HN)(object)e7WK.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
			goto IL_0068;
		}
		IL_0068:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Pw9k pw9k = pw9k;
					pw9k = pw9k;
				}
				finally
				{
					_ = (Fz0)e7WK.Default;
					goto IL_00c5;
				}
			}
			_003CModule_003E _003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
		}
		else
		{
			do
			{
				obj = obj;
			}
			while (obj != null);
		}
		goto IL_00c5;
		IL_00c5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		try
		{
			_ = (So3)(object)e7WK.Default;
		}
		finally
		{
			try
			{
				do
				{
					_ = (b7KC)(object)e7WK.Default;
				}
				while (obj != null);
			}
			finally
			{
				if ((nuint)(UIntPtr)e7WK.Default / (nuint)(UIntPtr)e7WK.Default == 0)
				{
					so = null;
					so = so;
				}
				else
				{
					qe = null;
					qe = null;
					_ = (z8Y)(object)e7WK.Default;
				}
				goto IL_0127;
			}
		}
		IL_0424:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
			do
			{
				try
				{
					e7WK = e7WK;
					e7WK = e7WK;
				}
				finally
				{
					_ = (Qt2)(object)e7WK.Default;
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			while (obj != null)
			{
				o2T2 = null;
			}
		}
		g2J4 g2J;
		do
		{
			_ = (Cx7)(object)e7WK.Default;
			g2J = null;
			_ = (b7KC)(object)e7WK.Default;
		}
		while (obj != null);
		do
		{
			try
			{
				_ = (b7KC)(object)e7WK.Default;
			}
			finally
			{
				try
				{
					_ = (y2HN)(object)e7WK.Default;
				}
				finally
				{
					continue;
				}
			}
		}
		while ((object)e7WK.Default != null);
		try
		{
			do
			{
				_ = (Dx5s)(object)e7WK.Default;
			}
			while (obj != null || obj != null);
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
				else
				{
					_ = (y2HN)(object)e7WK.Default;
				}
			}
			finally
			{
				o2T2 = o2T2;
				o2T2 = null;
				o2T2 = o2T2;
				g2J = (g2J4)(object)e7WK.Default;
				goto end_IL_04c9;
			}
			end_IL_04c9:;
		}
		_ = (y2HN)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			fz = fz;
			goto IL_05df;
		}
		checked
		{
			try
			{
				Qp49 qp = qp;
				qp = qp;
				_ = (Cx7)(object)e7WK.Default;
				_ = (y2HN)(object)e7WK.Default;
				_ = (Cx7)(object)e7WK.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if ((unchecked((nuint)default(UIntPtr)) * num - unchecked((nuint)(UIntPtr)e7WK.Default)) * num == 0)
				{
					_ = (q1M)(object)e7WK.Default;
					_ = (z8Y)(object)e7WK.Default;
				}
				else
				{
					e7WK e7WK = e7WK.Default;
				}
				goto IL_05df;
			}
		}
		IL_05df:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					_ = e7WK.Default;
				}
			}
			while (obj != null || obj != null);
			try
			{
				_ = (Cx7)(object)e7WK.Default;
			}
			catch
			{
				while (obj != null)
				{
					do
					{
						_ = (y2HN)(object)e7WK.Default;
					}
					while (obj != null);
				}
			}
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (y2HN)(object)e7WK.Default;
					_ = (q1M)(object)e7WK.Default;
					_ = (y2HN)(object)e7WK.Default;
				}
			}
			else
			{
				try
				{
					num = default(UIntPtr);
					if (num * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						z0R3 z0R = null;
					}
				}
				catch
				{
					_ = (Qp49)(object)e7WK.Default;
				}
			}
			while (obj != null)
			{
				if (num == 0)
				{
					if (num == 0)
					{
						qt = qt;
						q1M q1M = (q1M)(object)e7WK.Default;
						_ = (o2T)(object)e7WK.Default;
						_ = (g2J4)(object)e7WK.Default;
					}
					else
					{
						_ = (b6G)e7WK.Default;
					}
				}
			}
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					while ((object)e7WK.Default != null)
					{
						qt = qt;
						_ = (Qp49)(object)e7WK.Default;
					}
				}
				else
				{
					while ((object)e7WK.Default != null)
					{
						_ = (b6G)e7WK.Default;
						_ = (_003CModule_003E)(object)e7WK.Default;
						_ = (Qt2)(object)e7WK.Default;
					}
				}
			}
			catch
			{
				while ((object)e7WK.Default != null)
				{
					try
					{
						qt = qt;
					}
					catch
					{
						Pw9k pw9k = null;
					}
				}
			}
			if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u) && num == 0)
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					_ = (b7KC)(object)e7WK.Default;
					_ = (b6G)e7WK.Default;
				}
				else
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
			}
			_ = (So3)(object)e7WK.Default;
			_ = (Cx7)(object)e7WK.Default;
			_ = (n0J5)(object)e7WK.Default;
			while ((object)e7WK.Default != null)
			{
				do
				{
					if (num == 0)
					{
					}
				}
				while (obj != null);
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u && (UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = (n0J5)(object)e7WK.Default;
		}
		Dx5s dx5s = null;
		qe = (Qe07)(object)e7WK.Default;
		z8Y z8Y = null;
		g2J = g2J;
		_ = (So3)(object)e7WK.Default;
		_ = (g2J4)(object)e7WK.Default;
		qe = null;
		_ = (q1M)(object)e7WK.Default;
		return;
		IL_0127:
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + num * (unchecked((nuint)(UIntPtr)e7WK.Default) + num) == 0)
			{
				so = so;
			}
			while (obj != null)
			{
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
			if (num == 0)
			{
				if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u))
				{
					while (obj != null)
					{
						b6G = b6G;
						b6G = b6G;
					}
				}
				else
				{
					try
					{
						_ = (y2HN)(object)e7WK.Default;
					}
					catch
					{
						qt = qt;
						qt = qt;
					}
				}
			}
			b6G = b6G;
			do
			{
				try
				{
					o2T2 = o2T2;
					o2T2 = o2T2;
					_ = (z0R3)(object)e7WK.Default;
				}
				finally
				{
					_ = (g2J4)(object)e7WK.Default;
					continue;
				}
			}
			while (obj != null || (object)e7WK.Default != null);
			z8Y obj9 = (z8Y)(object)e7WK.Default;
			z8Y = z8Y;
			z8Y = obj9;
			do
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)(UIntPtr)e7WK.Default) != 0)
				{
					while ((object)e7WK.Default != null)
					{
						_ = (q1M)(object)e7WK.Default;
					}
				}
				else
				{
					do
					{
						_ = e7WK.Default;
					}
					while (obj != null);
				}
			}
			while (obj != null);
			while ((object)e7WK.Default != null)
			{
				try
				{
					try
					{
						_ = (Yo50)(object)e7WK.Default;
					}
					finally
					{
						_ = (q1M)(object)e7WK.Default;
						_ = (Qe07)(object)e7WK.Default;
						_ = (Qe07)(object)e7WK.Default;
						goto end_IL_0261;
					}
					end_IL_0261:;
				}
				finally
				{
					while ((object)e7WK.Default != null)
					{
						_ = (n0J5)(object)e7WK.Default;
					}
					continue;
				}
			}
			if (num != 0)
			{
			}
			so = null;
			_ = (c8CP)(object)e7WK.Default;
			fz = fz;
			fz = fz;
			try
			{
				try
				{
					z0R3 z0R = z0R;
					z0R = z0R;
				}
				finally
				{
					try
					{
						_ = (z0R3)(object)e7WK.Default;
					}
					finally
					{
						_ = (b7KC)(object)e7WK.Default;
						goto end_IL_02e2;
					}
				}
				end_IL_02e2:;
			}
			catch
			{
				while (obj != null)
				{
					try
					{
						_ = (o2T)(object)e7WK.Default;
					}
					catch
					{
						_ = (g2J4)(object)e7WK.Default;
					}
				}
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				_ = (y2HN)(object)e7WK.Default;
				_ = (y2HN)(object)e7WK.Default;
			}
			else
			{
				do
				{
					q1M q1M = null;
					q1M = q1M;
				}
				while ((object)e7WK.Default != null);
			}
		}
		try
		{
			_ = (Qp49)(object)e7WK.Default;
		}
		catch
		{
			try
			{
				_ = (c8CP)(object)e7WK.Default;
			}
			catch
			{
				o2T2 = (o2T)(object)e7WK.Default;
			}
			finally
			{
				while (obj != null)
				{
					so = null;
					Dx5s obj13 = (Dx5s)(object)e7WK.Default;
					dx5s = dx5s;
					dx5s = obj13;
					_ = e7WK.Default;
				}
				goto end_IL_038a;
			}
			end_IL_038a:;
		}
		if (num == 0)
		{
			try
			{
				do
				{
					_ = (Qp49)(object)e7WK.Default;
					qe = qe;
					_ = (n0J5)(object)e7WK.Default;
					_ = (n0J5)(object)e7WK.Default;
				}
				while (obj != null);
			}
			finally
			{
				_ = (q1M)(object)e7WK.Default;
				goto IL_0424;
			}
		}
		goto IL_0424;
	}

	static void Tc3()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = (UIntPtr)e7WK.Default;
				checked
				{
					if (num - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						qt = qt;
						qt = qt;
					}
					else
					{
						_ = (z0R3)(object)e7WK.Default;
					}
				}
			}
			finally
			{
				try
				{
					y2HN = y2HN;
					y2HN = null;
				}
				finally
				{
					qt = qt;
					goto IL_0076;
				}
			}
		}
		Qp49 qp = qp;
		qp = qp;
		goto IL_0076;
		IL_0728:
		do
		{
			_ = (c8CP)(object)e7WK.Default;
			_ = (Fz0)e7WK.Default;
		}
		while ((object)e7WK.Default != null);
		_ = (b6G)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		do
		{
			o2T o2T2 = (o2T)(object)e7WK.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
		try
		{
			do
			{
				try
				{
					g2J = g2J;
				}
				finally
				{
					y2HN = null;
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			_ = (b6G)e7WK.Default;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pw9k pw9k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Cx7)(object)e7WK.Default;
					_ = (o2T)(object)e7WK.Default;
				}
				finally
				{
					q1M = q1M;
					goto IL_07d8;
				}
			}
			pw9k = (Pw9k)(object)e7WK.Default;
		}
		goto IL_07d8;
		IL_07d8:
		_ = (_003CModule_003E)(object)e7WK.Default;
		_ = (Pw9k)(object)e7WK.Default;
		q1M = q1M;
		c8CP c8CP = (c8CP)(object)e7WK.Default;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = (b6G)e7WK.Default;
		}
		pw9k = pw9k;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Qt2)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null);
		}
		return;
		IL_0076:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (n0J5)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num + num == 0)
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (n0J5)(object)e7WK.Default;
						_ = (b7KC)(object)e7WK.Default;
					}
					else
					{
						_ = (Fz0)e7WK.Default;
					}
				}
			}
			catch
			{
				try
				{
					try
					{
						pw9k = (Pw9k)(object)e7WK.Default;
						pw9k = pw9k;
					}
					catch
					{
						_ = (Fz0)e7WK.Default;
					}
				}
				catch
				{
					while (true)
					{
						z8Y = null;
						z8Y = z8Y;
						if ((object)e7WK.Default != null)
						{
							continue;
						}
						goto end_IL_0115;
					}
					end_IL_0115:;
				}
			}
			try
			{
				do
				{
					try
					{
					}
					finally
					{
						_ = (y2HN)(object)e7WK.Default;
						continue;
					}
				}
				while ((object)e7WK.Default != null);
			}
			finally
			{
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						_ = (Pw9k)(object)e7WK.Default;
						continue;
					}
					break;
				}
				goto IL_0171;
			}
		}
		IL_0305:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		try
		{
			if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)e7WK.Default == 0)
			{
				_ = (z0R3)(object)e7WK.Default;
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					dx5s = dx5s;
				}
				else
				{
					_ = (c8CP)(object)e7WK.Default;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = (g2J4)(object)e7WK.Default;
				}
				finally
				{
					_ = (o2T)(object)e7WK.Default;
					_ = e7WK.Default;
					continue;
				}
			}
			goto IL_0399;
		}
		IL_02b2:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (y2HN)(object)e7WK.Default;
		}
		else
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (g2J4)(object)e7WK.Default;
				}
				finally
				{
					z0R3 z0R = z0R;
					z0R = z0R;
					goto IL_0305;
				}
			}
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (n0J5)(object)e7WK.Default;
			}
		}
		goto IL_0305;
		IL_0399:
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (b6G)e7WK.Default;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0 && num == 0)
			{
				_ = (b7KC)(object)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
				o2T o2T2 = o2T2;
				o2T2 = o2T2;
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
		}
		catch
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (z8Y)(object)e7WK.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		while (obj != null)
		{
			if (checked(num + num) == 0)
			{
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				catch
				{
					so = null;
				}
			}
		}
		while ((object)e7WK.Default != null)
		{
			if (num / (nuint)(UIntPtr)e7WK.Default / num == 0)
			{
				do
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				while ((object)e7WK.Default != null);
			}
			else
			{
				while (obj != null)
				{
					y2HN = y2HN;
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			do
			{
				if (num == 0)
				{
					_ = (y2HN)(object)e7WK.Default;
					_ = (q1M)(object)e7WK.Default;
					_ = (z8Y)(object)e7WK.Default;
				}
			}
			while ((object)e7WK.Default != null);
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				do
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
				while (obj != null);
			}
			else
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		else if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = (q1M)(object)e7WK.Default;
		}
		else if (num == 0)
		{
			z8Y = z8Y;
		}
		else
		{
			g2J = (g2J4)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		if (num == 0)
		{
			do
			{
				if ((UIntPtr)e7WK.Default != (UIntPtr)(nuint)0u)
				{
					_ = (b6G)e7WK.Default;
					continue;
				}
				Fz0 obj9 = (Fz0)e7WK.Default;
				fz = (Fz0)e7WK.Default;
				fz = obj9;
			}
			while (obj != null);
		}
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				do
				{
					if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u))
					{
						_ = (b7KC)(object)e7WK.Default;
					}
				}
				while ((object)e7WK.Default != null);
			}
			else
			{
				_ = (Qt2)(object)e7WK.Default;
				_ = (z8Y)(object)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
			}
			do
			{
				_ = (Qt2)(object)e7WK.Default;
				Yo50 yo = (Yo50)(object)e7WK.Default;
				yo = yo;
				_ = (Qe07)(object)e7WK.Default;
				_ = (b7KC)(object)e7WK.Default;
			}
			while (obj != null);
			do
			{
				fz = fz;
			}
			while ((object)e7WK.Default != null);
			while (obj != null)
			{
				if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u) && unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					z8Y = null;
					_ = (n0J5)(object)e7WK.Default;
					_ = (g2J4)(object)e7WK.Default;
				}
			}
			qt = qt;
		}
		try
		{
			try
			{
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				catch
				{
					_ = (So3)(object)e7WK.Default;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (b6G)e7WK.Default;
				}
				else
				{
					pw9k = pw9k;
					_ = (z0R3)(object)e7WK.Default;
				}
			}
		}
		catch
		{
			while ((object)e7WK.Default != null)
			{
				so = null;
			}
		}
		try
		{
			so = so;
		}
		catch
		{
			z8Y = null;
		}
		finally
		{
			_ = (Qe07)(object)e7WK.Default;
			goto IL_0728;
		}
		IL_0171:
		q1M = q1M;
		q1M = q1M;
		try
		{
			g2J4 obj14 = (g2J4)(object)e7WK.Default;
			g2J = null;
			g2J = obj14;
		}
		catch
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c8CP)(object)e7WK.Default;
				}
				else
				{
					_ = (z8Y)(object)e7WK.Default;
				}
			}
			catch
			{
				try
				{
					_ = (Qe07)(object)e7WK.Default;
					goto end_IL_01bd;
				}
				finally
				{
					q1M = (q1M)(object)e7WK.Default;
					goto end_IL_01bd;
				}
				end_IL_01bd:;
			}
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				_ = (Cx7)(object)e7WK.Default;
			}
			_ = (b7KC)(object)e7WK.Default;
			dx5s = dx5s;
			dx5s = dx5s;
			_ = (Pw9k)(object)e7WK.Default;
			do
			{
				b6G b6G = default(b6G);
				b6G = default(b6G);
			}
			while (obj != null);
			if (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				try
				{
					try
					{
						qt = qt;
					}
					finally
					{
						c8CP = (c8CP)(object)e7WK.Default;
						c8CP = c8CP;
						goto end_IL_0268;
					}
					end_IL_0268:;
				}
				finally
				{
					if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u))
					{
						so = null;
						so = null;
					}
					else
					{
						_ = (Pw9k)(object)e7WK.Default;
					}
					goto IL_02b2;
				}
			}
			goto IL_02b2;
		}
	}

	static void r5B()
	{
		_ = (y2HN)(object)e7WK.Default;
		UIntPtr num = (UIntPtr)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		UIntPtr num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		nuint num3;
		checked
		{
			num3 = unchecked((nuint)num2) + (unchecked((nuint)default(UIntPtr)) + unchecked(checked(unchecked((nuint)default(UIntPtr)) + uIntPtr) / uIntPtr));
		}
		UIntPtr num4 = (UIntPtr)e7WK.Default;
		UIntPtr num5 = (UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n0J5 n0J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		checked
		{
			if (unchecked((nuint)num) * (num3 * ((unchecked((nuint)num4) + unchecked((nuint)default(UIntPtr)) * ((unchecked((nuint)num5) + uIntPtr) * unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default) + uIntPtr)) * uIntPtr)) == 0)
			{
				try
				{
				}
				catch
				{
					_ = (Yo50)(object)e7WK.Default;
				}
			}
			else
			{
				try
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
				catch
				{
					g2J4 g2J = g2J;
					g2J = null;
				}
			}
			while (obj3 != null)
			{
				try
				{
					while (true)
					{
						obj3 = e7WK.Default;
						if (obj3 != null)
						{
							b6G obj4 = (b6G)e7WK.Default;
							b6G = b6G;
							b6G = obj4;
							continue;
						}
						break;
					}
				}
				finally
				{
					while (obj3 != null)
					{
						qp = qp;
						qp = qp;
					}
					continue;
				}
			}
			try
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						n0J = null;
						n0J = n0J;
					}
				}
				finally
				{
					try
					{
						_ = (z0R3)(object)e7WK.Default;
					}
					catch
					{
						dx5s = null;
						dx5s = dx5s;
					}
					goto end_IL_0122;
				}
				end_IL_0122:;
			}
			finally
			{
				try
				{
					do
					{
						_ = (Qp49)(object)e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
				catch
				{
					if (uIntPtr == 0)
					{
						q1M q1M = q1M;
						q1M = null;
					}
				}
				goto IL_0197;
			}
		}
		IL_069c:
		_ = (o2T)(object)e7WK.Default;
		_ = (Fz0)e7WK.Default;
		qp = qp;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (uIntPtr == 0)
		{
			_ = (y2HN)(object)e7WK.Default;
			_003CModule_003E = null;
		}
		try
		{
			if ((UIntPtr)e7WK.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Fz0)e7WK.Default;
				}
				finally
				{
					goto end_IL_06db;
				}
			}
			nuint num6 = uIntPtr;
			nuint num7;
			checked
			{
				num7 = unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default) * uIntPtr;
				uIntPtr = default(UIntPtr);
			}
			if (num6 / checked(num7 + unchecked(uIntPtr / uIntPtr) + uIntPtr) == 0)
			{
				_ = (g2J4)(object)e7WK.Default;
			}
			end_IL_06db:;
		}
		catch
		{
			try
			{
				while (obj3 != null)
				{
					g2J4 g2J = null;
				}
			}
			catch
			{
				while (true)
				{
					_ = (o2T)(object)e7WK.Default;
					_ = (Dx5s)(object)e7WK.Default;
					_ = (c8CP)(object)e7WK.Default;
					if (obj3 != null)
					{
						continue;
					}
					goto end_IL_0751;
				}
				end_IL_0751:;
			}
		}
		_ = (_003CModule_003E)(object)e7WK.Default;
		return;
		IL_04ef:
		if (uIntPtr == 0)
		{
			try
			{
			}
			finally
			{
				goto IL_0536;
			}
		}
		_ = (b6G)e7WK.Default;
		goto IL_0536;
		IL_0536:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		while ((object)e7WK.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E obj9 = (_003CModule_003E)(object)e7WK.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj9;
			}
			else
			{
				c8CP = c8CP;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		try
		{
			UIntPtr num8 = (UIntPtr)e7WK.Default;
			uIntPtr = default(UIntPtr);
			nuint num9 = checked(unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num8) + unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr))) / uIntPtr;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (num9 * (unchecked(uIntPtr / uIntPtr) + unchecked((nuint)default(UIntPtr))) == 0)
				{
					try
					{
						q1M q1M = (q1M)(object)e7WK.Default;
					}
					catch
					{
						z8Y z8Y = z8Y;
						qp = null;
					}
				}
				else
				{
					while (obj3 != null)
					{
						cx = (Cx7)(object)e7WK.Default;
					}
				}
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
			}
		}
		_ = (n0J5)(object)e7WK.Default;
		cx = null;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
		}
		_ = (c8CP)(object)e7WK.Default;
		_ = (Dx5s)(object)e7WK.Default;
		Fz0 fz = fz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					n0J = n0J;
					z0R = z0R;
				}
			}
			while ((object)e7WK.Default != null);
		}
		finally
		{
			try
			{
				do
				{
					o2T2 = o2T2;
				}
				while ((object)e7WK.Default != null);
			}
			finally
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (So3)(object)e7WK.Default;
				}
				goto IL_069c;
			}
		}
		IL_030a:
		_ = (z8Y)(object)e7WK.Default;
		do
		{
			UIntPtr num10 = (UIntPtr)e7WK.Default;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num10) - uIntPtr * unchecked((nuint)(UIntPtr)e7WK.Default)) != 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / uIntPtr == 0)
				{
					fz = default(Fz0);
				}
				else
				{
					_ = (o2T)(object)e7WK.Default;
				}
			}
			else
			{
				_ = (So3)(object)e7WK.Default;
				_ = (So3)(object)e7WK.Default;
			}
		}
		while ((object)e7WK.Default != null);
		while ((object)e7WK.Default != null)
		{
			try
			{
				do
				{
					fz = (Fz0)e7WK.Default;
					e7WK e7WK = null;
					e7WK = e7WK;
					b6G = default(b6G);
				}
				while (obj3 != null);
			}
			finally
			{
				Qe07 qe = (Qe07)(object)e7WK.Default;
				continue;
			}
		}
		nuint num11 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		checked
		{
			if (num11 + unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) == 0)
			{
				while (true)
				{
					if ((object)e7WK.Default != null)
					{
						_ = e7WK.Default;
					}
					else if ((object)e7WK.Default == null)
					{
						break;
					}
				}
			}
			else
			{
				do
				{
					o2T2 = (o2T)(object)e7WK.Default;
				}
				while (obj3 != null || obj3 != null);
			}
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
					_ = (b7KC)(object)e7WK.Default;
					qt = qt;
					_ = (Cx7)(object)e7WK.Default;
				}
				catch
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			catch
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Qe07)(object)e7WK.Default;
				}
			}
			finally
			{
				try
				{
					o2T2 = (o2T)(object)e7WK.Default;
					_ = (g2J4)(object)e7WK.Default;
				}
				catch
				{
					try
					{
						_ = (q1M)(object)e7WK.Default;
					}
					finally
					{
						dx5s = dx5s;
						goto end_IL_04d3;
					}
					end_IL_04d3:;
				}
				goto IL_04ef;
			}
		}
		IL_0197:
		_ = (Qt2)(object)e7WK.Default;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			Qe07 qe = qe;
			qe = null;
		}
		else
		{
			try
			{
			}
			catch
			{
				try
				{
					b6G = b6G;
					fz = fz;
					fz = fz;
				}
				catch
				{
					_ = (q1M)(object)e7WK.Default;
				}
			}
		}
		do
		{
			try
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
				qt = qt;
				qt = null;
			}
			catch
			{
				_ = (n0J5)(object)e7WK.Default;
			}
		}
		while (obj3 != null || obj3 != null);
		if (uIntPtr == 0)
		{
			_ = (y2HN)(object)e7WK.Default;
		}
		else
		{
			try
			{
				do
				{
					_ = e7WK.Default;
				}
				while (obj3 != null);
			}
			catch
			{
				try
				{
					_ = (c8CP)(object)e7WK.Default;
				}
				catch
				{
					cx = cx;
					cx = cx;
				}
			}
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
				}
				catch
				{
					_ = (b6G)e7WK.Default;
				}
			}
		}
		while (obj3 != null);
		checked
		{
			try
			{
				try
				{
					e7WK e7WK = null;
					e7WK = null;
				}
				finally
				{
					o2T obj21 = (o2T)(object)e7WK.Default;
					o2T2 = o2T2;
					o2T2 = obj21;
					goto end_IL_0298;
				}
				end_IL_0298:;
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					n0J = n0J;
				}
				else
				{
					_ = (g2J4)(object)e7WK.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Cx7)(object)e7WK.Default;
				}
				while ((object)e7WK.Default != null);
				goto IL_030a;
			}
		}
	}
}
