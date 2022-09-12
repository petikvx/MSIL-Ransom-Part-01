using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Es0;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Xs5;
using e6H;
using q8B;

namespace a9D;

[DesignerGenerated]
public class z1J : Form
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
			EventHandler eventHandler = Yc0;
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
			EventHandler eventHandler = y8J;
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
			EventHandler eventHandler = Qp8;
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
			EventHandler eventHandler = Qi3;
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
				c0B.int_0[116] = (c0B.int_0[116] + Ta8.char_0[108]) & 0xB;
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
			EventHandler eventHandler = o6B;
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

	public z1J()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Kt5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Zf5();
	}

	[DebuggerNonUserCode]
	protected override void o7S(bool d5E)
	{
		try
		{
			if (d5E && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d5E);
		}
	}

	[DebuggerStepThrough]
	private void Zf5()
	{
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected O, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		int[] int_ = c0B.int_0;
		int num = 9;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 54;
			while (true)
			{
				txtPMachine = new TextBox();
				Label9 = new Label();
				btnDelete = new Button();
				num = 48;
				while (true)
				{
					btnModify = new Button();
					DataGridView1 = new DataGridView();
					txtWeight = new TextBox();
					num = 39;
					while (true)
					{
						txtPStock = new TextBox();
						txtPCost = new TextBox();
						Label4 = new Label();
						num = 27;
						while (true)
						{
							Label1 = new Label();
							Label2 = new Label();
							Label5 = new Label();
							num = 20;
							while (true)
							{
								txtPid = new TextBox();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 36;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 53;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(332, 21));
										num = 4;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(111, 17));
											num = 69;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Product Detail");
												num = 46;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 70;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 63;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(739, 21));
															num = 11;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 57;
																while (true)
																{
																	((Control)Label6).set_TabIndex(14);
																	Label6.set_Text("X");
																	num = 59;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 75;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 21;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(47, 21));
																				num = 24;
																				while (true)
																				{
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 71;
																					while (true)
																					{
																						((Control)Label7).set_TabIndex(13);
																						Label7.set_Text("Go To Main");
																						num = 31;
																						while (true)
																						{
																							((Control)txtPMachine).set_Location(new Point(413, 99));
																							((Control)txtPMachine).set_Name("txtPMachine");
																							num = 19;
																							while (true)
																							{
																								((Control)txtPMachine).set_Size(new Size(122, 20));
																								((Control)txtPMachine).set_TabIndex(4);
																								num = 74;
																								while (true)
																								{
																									Label9.set_AutoSize(true);
																									((Control)Label9).set_ForeColor(Color.White);
																									num = 1;
																									while (true)
																									{
																										((Control)Label9).set_Location(new Point(299, 99));
																										((Control)Label9).set_Name("Label9");
																										num = 40;
																										while (true)
																										{
																											((Control)Label9).set_Size(new Size(108, 13));
																											((Control)Label9).set_TabIndex(46);
																											num = 72;
																											while (true)
																											{
																												Label9.set_Text("Production Machine :");
																												((Control)btnDelete).set_Location(new Point(398, 218));
																												num = 3;
																												while (true)
																												{
																													((Control)btnDelete).set_Name("btnDelete");
																													((Control)btnDelete).set_Size(new Size(75, 23));
																													num = 17;
																													while (true)
																													{
																														((Control)btnDelete).set_TabIndex(7);
																														((ButtonBase)btnDelete).set_Text("DELETE");
																														num = 7;
																														while (true)
																														{
																															((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																															((Control)btnModify).set_Location(new Point(286, 218));
																															num = 56;
																															while (true)
																															{
																																((Control)btnModify).set_Name("btnModify");
																																((Control)btnModify).set_Size(new Size(75, 23));
																																num = 73;
																																while (true)
																																{
																																	((Control)btnModify).set_TabIndex(6);
																																	((ButtonBase)btnModify).set_Text("MODIFY");
																																	num = 5;
																																	while (true)
																																	{
																																		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																		num = 49;
																																		while (true)
																																		{
																																			((Control)DataGridView1).set_Location(new Point(50, 255));
																																			((Control)DataGridView1).set_Name("DataGridView1");
																																			num = 60;
																																			while (true)
																																			{
																																				((Control)DataGridView1).set_Size(new Size(599, 183));
																																				((Control)DataGridView1).set_TabIndex(41);
																																				num = 44;
																																				while (true)
																																				{
																																					((Control)txtWeight).set_Location(new Point(413, 53));
																																					((Control)txtWeight).set_Name("txtWeight");
																																					num = 68;
																																					while (true)
																																					{
																																						((Control)txtWeight).set_Size(new Size(122, 20));
																																						((Control)txtWeight).set_TabIndex(3);
																																						switch (int_[424])
																																						{
																																						case 23386:
																																							break;
																																						case 23362:
																																							goto end_IL_000e;
																																						case 23378:
																																							goto end_IL_0177;
																																						case 23367:
																																							goto end_IL_01a6;
																																						case 23323:
																																							goto end_IL_01d2;
																																						case 23391:
																																							goto end_IL_01fe;
																																						case 23374:
																																							goto end_IL_021b;
																																						case 23325:
																																							goto end_IL_023b;
																																						case 23335:
																																							goto end_IL_0264;
																																						case 23321:
																																							goto end_IL_028f;
																																						case 23390:
																																							goto end_IL_02af;
																																						case 23358:
																																							goto end_IL_02d8;
																																						case 23319:
																																							goto end_IL_0306;
																																						case 23392:
																																							goto end_IL_032c;
																																						case 23337:
																																							goto end_IL_0358;
																																						case 23349:
																																							goto end_IL_0378;
																																						case 23389:
																																							goto end_IL_039d;
																																						case 23342:
																																							goto end_IL_03c9;
																																						case 23339:
																																							goto end_IL_03eb;
																																						case 23393:
																																							goto end_IL_0414;
																																						case 23377:
																																							goto end_IL_043d;
																																						case 23375:
																																							goto end_IL_045f;
																																						case 23329:
																																							goto end_IL_0480;
																																						case 23381:
																																							goto end_IL_04a2;
																																						case 23388:
																																							goto end_IL_04cb;
																																						case 23364:
																																							goto end_IL_04f7;
																																						case 23387:
																																							goto end_IL_0519;
																																						case 23322:
																																							goto end_IL_053a;
																																						case 23371:
																																							goto end_IL_055c;
																																						case 23354:
																																							goto end_IL_0585;
																																						case 23338:
																																							goto end_IL_05b0;
																																						case 23345:
																																							goto end_IL_05e4;
																																						case 23357:
																																							goto end_IL_060a;
																																						case 23366:
																																							goto end_IL_0630;
																																						case 23372:
																																							goto end_IL_0656;
																																						default:
																																							goto end_IL_067c;
																																						case 23363:
																																							((Control)txtPStock).set_Location(new Point(191, 134));
																																							((Control)txtPStock).set_Name("txtPStock");
																																							num = 65;
																																							goto case 23383;
																																						case 23383:
																																							((Control)txtPStock).set_Size(new Size(100, 20));
																																							((Control)txtPStock).set_TabIndex(2);
																																							num = 67;
																																							goto case 23385;
																																						case 23385:
																																							((Control)txtPCost).set_Location(new Point(191, 95));
																																							((Control)txtPCost).set_Name("txtPCost");
																																							num = 23;
																																							goto case 23341;
																																						case 23341:
																																							((Control)txtPCost).set_Size(new Size(100, 20));
																																							((Control)txtPCost).set_TabIndex(1);
																																							num = 30;
																																							goto case 23348;
																																						case 23348:
																																							Label4.set_AutoSize(true);
																																							goto case 23359;
																																						case 23359:
																																							((Control)Label4).set_ForeColor(Color.White);
																																							num = 10;
																																							goto case 23328;
																																						case 23328:
																																							((Control)Label4).set_Location(new Point(360, 56));
																																							((Control)Label4).set_Name("Label4");
																																							num = 43;
																																							goto case 23361;
																																						case 23361:
																																							((Control)Label4).set_Size(new Size(47, 13));
																																							((Control)Label4).set_TabIndex(37);
																																							num = 6;
																																							goto case 23324;
																																						case 23324:
																																							Label4.set_Text("Weight :");
																																							Label1.set_AutoSize(true);
																																							num = 22;
																																							goto case 23340;
																																						case 23340:
																																						case 23346:
																																							((Control)Label1).set_ForeColor(Color.White);
																																							((Control)Label1).set_Location(new Point(120, 141));
																																							goto case 23376;
																																						case 23376:
																																							num = 61;
																																							goto case 23379;
																																						case 23379:
																																							((Control)Label1).set_Name("Label1");
																																							((Control)Label1).set_Size(new Size(41, 13));
																																							num = 16;
																																							goto case 23334;
																																						case 23334:
																																							((Control)Label1).set_TabIndex(36);
																																							Label1.set_Text("Stock :");
																																							num = 35;
																																							goto case 23353;
																																						case 23353:
																																							Label2.set_AutoSize(true);
																																							((Control)Label2).set_ForeColor(Color.White);
																																							num = 14;
																																							goto case 23332;
																																						case 23332:
																																							((Control)Label2).set_Location(new Point(99, 59));
																																							((Control)Label2).set_Name("Label2");
																																							num = 13;
																																							goto case 23331;
																																						case 23331:
																																							((Control)Label2).set_Size(new Size(62, 13));
																																							((Control)Label2).set_TabIndex(35);
																																							num = 25;
																																							goto case 23343;
																																						case 23343:
																																							Label2.set_Text("Product Id :");
																																							Label5.set_AutoSize(true);
																																							num = 66;
																																							goto case 23384;
																																						case 23384:
																																							((Control)Label5).set_ForeColor(Color.White);
																																							((Control)Label5).set_Location(new Point(127, 102));
																																							num = 51;
																																							goto case 23369;
																																						case 23369:
																																							((Control)Label5).set_Name("Label5");
																																							((Control)Label5).set_Size(new Size(34, 13));
																																							num = 18;
																																							goto case 23336;
																																						case 23336:
																																							((Control)Label5).set_TabIndex(34);
																																							Label5.set_Text("Cost :");
																																							num = 15;
																																							goto case 23333;
																																						case 23333:
																																							((Control)txtPid).set_Location(new Point(191, 56));
																																							((Control)txtPid).set_Name("txtPid");
																																							num = 33;
																																							goto case 23351;
																																						case 23351:
																																							((Control)txtPid).set_Size(new Size(100, 20));
																																							((Control)txtPid).set_TabIndex(0);
																																							num = 52;
																																							goto case 23370;
																																						case 23370:
																																							((Control)btnSave).set_Location(new Point(178, 218));
																																							((Control)btnSave).set_Name("btnSave");
																																							num = 26;
																																							goto case 23344;
																																						case 23344:
																																							((Control)btnSave).set_Size(new Size(75, 23));
																																							((Control)btnSave).set_TabIndex(5);
																																							num = 62;
																																							goto case 23380;
																																						case 23380:
																																							((ButtonBase)btnSave).set_Text("SAVE");
																																							((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																							num = 50;
																																							goto case 23368;
																																						case 23368:
																																							((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																							((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																							num = 64;
																																							goto case 23382;
																																						case 23382:
																																							((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																							((Form)this).set_ClientSize(new Size(800, 450));
																																							num = 47;
																																							goto case 23365;
																																						case 23365:
																																							((Control)this).get_Controls().Add((Control)(object)txtPMachine);
																																							((Control)this).get_Controls().Add((Control)(object)Label9);
																																							num = 12;
																																							goto case 23330;
																																						case 23330:
																																							((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																							((Control)this).get_Controls().Add((Control)(object)btnModify);
																																							num = 42;
																																							goto case 23360;
																																						case 23360:
																																							((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																							((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																							num = 29;
																																							goto case 23347;
																																						case 23347:
																																							((Control)this).get_Controls().Add((Control)(object)txtPStock);
																																							((Control)this).get_Controls().Add((Control)(object)txtPCost);
																																							num = 32;
																																							goto case 23350;
																																						case 23350:
																																							((Control)this).get_Controls().Add((Control)(object)Label4);
																																							((Control)this).get_Controls().Add((Control)(object)Label1);
																																							num = 0;
																																							goto case 23318;
																																						case 23318:
																																							((Control)this).get_Controls().Add((Control)(object)Label2);
																																							((Control)this).get_Controls().Add((Control)(object)Label5);
																																							num = 55;
																																							goto case 23373;
																																						case 23373:
																																							((Control)this).get_Controls().Add((Control)(object)txtPid);
																																							((Control)this).get_Controls().Add((Control)(object)btnSave);
																																							num = 38;
																																							goto case 23356;
																																						case 23356:
																																							((Control)this).get_Controls().Add((Control)(object)Label6);
																																							((Control)this).get_Controls().Add((Control)(object)Label7);
																																							num = 37;
																																							goto case 23355;
																																						case 23355:
																																							((Control)this).get_Controls().Add((Control)(object)Label3);
																																							((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																							num = 2;
																																							goto case 23320;
																																						case 23320:
																																							((Control)this).set_Name("frmProductDetail");
																																							((Form)this).set_StartPosition((FormStartPosition)1);
																																							((Form)this).set_Text("frmProductDetail");
																																							num = 8;
																																							goto case 23326;
																																						case 23326:
																																							((ISupportInitialize)DataGridView1).EndInit();
																																							((Control)this).ResumeLayout(false);
																																							((Control)this).PerformLayout();
																																							num = 34;
																																							return;
																																						case 23352:
																																							return;
																																						}
																																						continue;
																																						end_IL_000e:
																																						break;
																																					}
																																					continue;
																																					end_IL_0177:
																																					break;
																																				}
																																				continue;
																																				end_IL_01a6:
																																				break;
																																			}
																																			continue;
																																			end_IL_01d2:
																																			break;
																																		}
																																		continue;
																																		end_IL_01fe:
																																		break;
																																	}
																																	continue;
																																	end_IL_021b:
																																	break;
																																}
																																continue;
																																end_IL_023b:
																																break;
																															}
																															continue;
																															end_IL_0264:
																															break;
																														}
																														continue;
																														end_IL_028f:
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
																											end_IL_0306:
																											break;
																										}
																										continue;
																										end_IL_032c:
																										break;
																									}
																									continue;
																									end_IL_0358:
																									break;
																								}
																								continue;
																								end_IL_0378:
																								break;
																							}
																							continue;
																							end_IL_039d:
																							break;
																						}
																						continue;
																						end_IL_03c9:
																						break;
																					}
																					continue;
																					end_IL_03eb:
																					break;
																				}
																				continue;
																				end_IL_0414:
																				break;
																			}
																			continue;
																			end_IL_043d:
																			break;
																		}
																		continue;
																		end_IL_045f:
																		break;
																	}
																	continue;
																	end_IL_0480:
																	break;
																}
																continue;
																end_IL_04a2:
																break;
															}
															continue;
															end_IL_04cb:
															break;
														}
														continue;
														end_IL_04f7:
														break;
													}
													continue;
													end_IL_0519:
													break;
												}
												continue;
												end_IL_053a:
												break;
											}
											continue;
											end_IL_055c:
											break;
										}
										continue;
										end_IL_0585:
										break;
									}
									continue;
									end_IL_05b0:
									break;
								}
								continue;
								end_IL_05e4:
								break;
							}
							continue;
							end_IL_060a:
							break;
						}
						continue;
						end_IL_0630:
						break;
					}
					continue;
					end_IL_0656:
					break;
				}
				continue;
				end_IL_067c:
				break;
			}
		}
	}

	private void y8J(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void Yc0(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void o6B(object sender, EventArgs e)
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
		s8C();
	}

	public void s8C()
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = Ta8.char_0;
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			int num = 4;
			while (true)
			{
				cn.Open();
				cmd.set_Connection(cn);
				num = 0;
				while (true)
				{
					cmd.set_CommandText("select * from tbl_product_detail");
					rd = cmd.ExecuteReader();
					num = 11;
					while (true)
					{
						DataGridView1.get_Columns().Add("c1", "Product Id");
						DataGridView1.get_Columns().Add("c2", "Product Cost");
						num = 5;
						while (true)
						{
							DataGridView1.get_Columns().Add("c3", "Product Stock");
							DataGridView1.get_Columns().Add("c4", "Product Weight");
							while (true)
							{
								num = 1;
								while (true)
								{
									DataGridView1.get_Columns().Add("c5", "Production Machine");
									num = 3;
									while (true)
									{
										bool num2 = rd.Read();
										Ta8.char_0[201] = (char)((Ta8.char_0[201] * Ta8.char_0[314]) & '\u0010');
										if (!num2)
										{
											switch (char_[34])
											{
											case 'Ѕ':
												break;
											case 'Ͼ':
												continue;
											case 'ϼ':
												goto end_IL_00f9;
											case 'Ђ':
												goto end_IL_0130;
											case 'Ѐ':
												goto end_IL_014f;
											case 'І':
												goto end_IL_0153;
											case 'ϻ':
												goto end_IL_018b;
											default:
												goto end_IL_01c5;
											case 'Є':
												return;
											}
										}
										DataGridView1.get_Rows().Add(new object[5]
										{
											rd.get_Item("pid").ToString(),
											rd.get_Item("pcost").ToString(),
											rd.get_Item("pstock"),
											rd.get_Item("stockweight"),
											rd.get_Item("productionmachine")
										});
										num = 3;
										continue;
										end_IL_00f9:
										break;
									}
									continue;
									end_IL_0130:
									break;
								}
								continue;
								end_IL_014f:
								break;
							}
							continue;
							end_IL_0153:
							break;
						}
						continue;
						end_IL_018b:
						break;
					}
					continue;
					end_IL_01c5:
					break;
				}
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

	internal static byte[] Ac0(byte[] j0F, byte[] Be8, int r7C, int q4M)
	{
		int num = checked(j0F.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			j0F[i] = (byte)(j0F[i] ^ checked((byte)(Be8[unchecked(i % Be8.Length)] ^ ((i + unchecked(r7C % Be8.Length)) & r7C))));
		}
		return j0F;
	}

	private void Qp8(object sender, EventArgs e)
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
		s8C();
	}

	private void Qi3(object sender, EventArgs e)
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
		s8C();
		Ta8.char_0[363] = (char)((Ta8.char_0[363] ^ Ta8.char_0[27]) & '\u0016');
	}

	private void Kt5(object sender, EventArgs e)
	{
		s8C();
	}

	internal static string[] k5F()
	{
		int[] int_ = c0B.int_0;
		int num = 3;
		while (true)
		{
			Ma6.Wf1();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Ng67.mDic.Add("AO", executingAssembly);
			while (true)
			{
				switch (int_[165])
				{
				case 32626:
				case 32628:
					continue;
				case 32625:
					return Ta8.Sw8();
				}
				break;
			}
		}
	}
}
