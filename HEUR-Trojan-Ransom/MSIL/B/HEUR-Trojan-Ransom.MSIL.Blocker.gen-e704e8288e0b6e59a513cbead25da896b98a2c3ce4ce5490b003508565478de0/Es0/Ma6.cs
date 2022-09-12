using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ba50;
using Cd1t;
using Ci75;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Ri5n;
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xo8;
using Xs5;
using a9D;
using c4ZK;
using e6H;
using j3B;
using q8B;
using s1Y;
using t5D;
using x9E1;

namespace Es0;

[DesignerGenerated]
public class Ma6 : Form
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
			EventHandler eventHandler = q9Y;
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
				c0B.int_0[90] = (c0B.int_0[90] | c0B.int_0[312]) & 0x23;
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
			EventHandler eventHandler = b0H;
			Label label = _Label7;
			Label obj = label;
			Ta8.char_0[283] = (char)((Ta8.char_0[283] + Ta8.char_0[118]) & '÷');
			if (obj != null)
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

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
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
			EventHandler eventHandler = Ry9;
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
			EventHandler eventHandler = x1Z;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCode")]
	internal virtual TextBox txtPCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPRaw")]
	internal virtual TextBox txtPRaw
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

	[field: AccessedThroughProperty("txtPDate")]
	internal virtual TextBox txtPDate
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
			EventHandler eventHandler = o6R;
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRWeight")]
	internal virtual TextBox txtRWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Ma6()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Yp7);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		w8B();
	}

	[DebuggerNonUserCode]
	protected override void Gm8(bool Qs7)
	{
		try
		{
			if (Qs7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qs7);
		}
	}

	[DebuggerStepThrough]
	private void w8B()
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		char[] char_ = Ta8.char_0;
		int num = 72;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 5;
			while (true)
			{
				txtPId = new TextBox();
				btnDelete = new Button();
				btnModify = new Button();
				num = 10;
				while (true)
				{
					DataGridView1 = new DataGridView();
					txtPCode = new TextBox();
					txtPMachine = new TextBox();
					num = 39;
					while (true)
					{
						txtPRaw = new TextBox();
						Label2 = new Label();
						txtPDate = new TextBox();
						num = 0;
						while (true)
						{
							btnSave = new Button();
							Label1 = new Label();
							Label4 = new Label();
							num = 49;
							while (true)
							{
								Label5 = new Label();
								Label8 = new Label();
								Label9 = new Label();
								num = 53;
								while (true)
								{
									txtRWeight = new TextBox();
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										num = 22;
										while (true)
										{
											Label3.set_AutoSize(true);
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 13;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(331, 27));
												num = 23;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(135, 17));
													num = 41;
													while (true)
													{
														((Control)Label3).set_TabIndex(9);
														Label3.set_Text("Processing Detail");
														switch (char_[74])
														{
														case '惴':
															break;
														case '惢':
															goto end_IL_000e;
														case '惘':
															goto end_IL_018d;
														case '惡':
															goto end_IL_01bc;
														case '惞':
															goto end_IL_01e8;
														case '愀':
															goto end_IL_0216;
														case '惼':
															goto end_IL_022c;
														case '惋':
															goto end_IL_0239;
														case '惲':
															goto end_IL_025f;
														case '惕':
															goto end_IL_0285;
														case '惐':
															goto end_IL_02aa;
														default:
															goto end_IL_02d0;
														case '惧':
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 21;
															goto case '惠';
														case '惠':
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 67;
															goto case '愎';
														case '愎':
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(742, 27));
															num = 44;
															goto case '惷';
														case '惷':
															((Control)Label6).set_Name("Label6");
															((Control)Label6).set_Size(new Size(18, 17));
															num = 33;
															goto case '惬';
														case '惬':
															((Control)Label6).set_TabIndex(10);
															Label6.set_Text("X");
															num = 58;
															goto case '愅';
														case '愅':
															Label7.set_AutoSize(true);
															((Control)Label7).set_BackColor(Color.Blue);
															num = 31;
															goto case '惪';
														case '惪':
															((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 45;
															goto case '惸';
														case '惸':
															((Control)Label7).set_ForeColor(Color.White);
															((Control)Label7).set_Location(new Point(50, 27));
															num = 34;
															goto case '惭';
														case '惭':
															((Control)Label7).set_Name("Label7");
															((Control)Label7).set_Size(new Size(92, 17));
															num = 71;
															goto case '愒';
														case '愒':
															((Control)Label7).set_TabIndex(9);
															Label7.set_Text("Go To Main");
															num = 66;
															goto case '愍';
														case '愍':
															((Control)txtPId).set_Location(new Point(242, 72));
															((Control)txtPId).set_Name("txtPId");
															num = 18;
															goto case '惝';
														case '惝':
															((Control)txtPId).set_Size(new Size(100, 20));
															((Control)txtPId).set_TabIndex(0);
															num = 55;
															goto case '愂';
														case '愂':
															((Control)btnDelete).set_Location(new Point(417, 183));
															((Control)btnDelete).set_Name("btnDelete");
															num = 52;
															goto case '惿';
														case '惿':
															((Control)btnDelete).set_Size(new Size(75, 31));
															((Control)btnDelete).set_TabIndex(8);
															num = 77;
															goto case '愘';
														case '愘':
															((ButtonBase)btnDelete).set_Text("DELETE");
															((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
															num = 57;
															goto case '愄';
														case '愄':
															((Control)btnModify).set_Location(new Point(417, 129));
															((Control)btnModify).set_Name("btnModify");
															num = 46;
															goto case '惹';
														case '惹':
															((Control)btnModify).set_Size(new Size(75, 31));
															((Control)btnModify).set_TabIndex(7);
															num = 35;
															goto case '惮';
														case '惮':
															((ButtonBase)btnModify).set_Text("MODIFY");
															((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
															num = 9;
															goto case '惔';
														case '惔':
															DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
															((Control)DataGridView1).set_Location(new Point(53, 241));
															num = 38;
															goto case '惱';
														case '惱':
															((Control)DataGridView1).set_Name("DataGridView1");
															((Control)DataGridView1).set_Size(new Size(707, 206));
															num = 80;
															goto case '愛';
														case '愛':
															((Control)DataGridView1).set_TabIndex(11);
															((Control)txtPCode).set_Location(new Point(242, 183));
															num = 73;
															goto case '愔';
														case '愔':
															((Control)txtPCode).set_Name("txtPCode");
															((Control)txtPCode).set_Size(new Size(100, 20));
															num = 40;
															goto case '想';
														case '想':
															((Control)txtPCode).set_TabIndex(4);
															((Control)txtPMachine).set_Location(new Point(242, 156));
															num = 68;
															goto case '意';
														case '意':
															((Control)txtPMachine).set_Name("txtPMachine");
															((Control)txtPMachine).set_Size(new Size(100, 20));
															num = 74;
															goto case '愕';
														case '愕':
															((Control)txtPMachine).set_TabIndex(3);
															((Control)txtPRaw).set_Location(new Point(242, 129));
															num = 29;
															goto case '惨';
														case '惨':
															((Control)txtPRaw).set_Name("txtPRaw");
															((Control)txtPRaw).set_Size(new Size(100, 20));
															num = 76;
															goto case '愗';
														case '愗':
															((Control)txtPRaw).set_TabIndex(2);
															Label2.set_AutoSize(true);
															num = 60;
															goto case '愇';
														case '愇':
															((Control)Label2).set_ForeColor(Color.White);
															((Control)Label2).set_Location(new Point(164, 75));
															num = 81;
															goto case '愜';
														case '愜':
															((Control)Label2).set_Name("Label2");
															((Control)Label2).set_Size(new Size(63, 13));
															num = 11;
															goto case '惖';
														case '惖':
															((Control)Label2).set_TabIndex(33);
															Label2.set_Text("Process Id :");
															num = 43;
															goto case '惶';
														case '惶':
															((Control)txtPDate).set_Location(new Point(242, 99));
															((Control)txtPDate).set_Name("txtPDate");
															num = 59;
															goto case '愆';
														case '愆':
															((Control)txtPDate).set_Size(new Size(100, 20));
															((Control)txtPDate).set_TabIndex(1);
															num = 2;
															goto case '惍';
														case '惍':
															((Control)btnSave).set_Location(new Point(417, 72));
															((Control)btnSave).set_Name("btnSave");
															num = 79;
															goto case '愚';
														case '愚':
															((Control)btnSave).set_Size(new Size(75, 31));
															((Control)btnSave).set_TabIndex(6);
															num = 20;
															goto case '惟';
														case '惟':
															((ButtonBase)btnSave).set_Text("SAVE");
															((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
															num = 51;
															goto case '惾';
														case '惾':
															Label1.set_AutoSize(true);
															((Control)Label1).set_ForeColor(Color.White);
															num = 42;
															goto case '惵';
														case '惵':
															((Control)Label1).set_Location(new Point(150, 102));
															((Control)Label1).set_Name("Label1");
															num = 3;
															goto case '惎';
														case '惎':
															((Control)Label1).set_Size(new Size(77, 13));
															((Control)Label1).set_TabIndex(43);
															num = 69;
															goto case '愐';
														case '愐':
															Label1.set_Text("Process Date :");
															Label4.set_AutoSize(true);
															num = 47;
															goto case '惺';
														case '惺':
															((Control)Label4).set_ForeColor(Color.White);
															((Control)Label4).set_Location(new Point(150, 136));
															num = 15;
															goto case '惚';
														case '惚':
															((Control)Label4).set_Name("Label4");
															((Control)Label4).set_Size(new Size(76, 13));
															num = 1;
															goto case '惌';
														case '惌':
															((Control)Label4).set_TabIndex(44);
															Label4.set_Text("Process Raw :");
															num = 62;
															goto case '愉';
														case '愉':
															Label5.set_AutoSize(true);
															((Control)Label5).set_ForeColor(Color.White);
															num = 36;
															goto case '惯';
														case '惯':
															((Control)Label5).set_Location(new Point(132, 163));
															((Control)Label5).set_Name("Label5");
															num = 48;
															goto case '惻';
														case '惻':
															((Control)Label5).set_Size(new Size(95, 13));
															((Control)Label5).set_TabIndex(45);
															num = 78;
															goto case '愙';
														case '愙':
															Label5.set_Text("Process Machine :");
															Label8.set_AutoSize(true);
															num = 37;
															goto case '惰';
														case '惰':
															((Control)Label8).set_ForeColor(Color.White);
															((Control)Label8).set_Location(new Point(134, 186));
															num = 6;
															goto case '惑';
														case '惑':
															((Control)Label8).set_Name("Label8");
															((Control)Label8).set_Size(new Size(93, 13));
															num = 26;
															goto case '惥';
														case '惥':
															((Control)Label8).set_TabIndex(46);
															Label8.set_Text("Processing Code :");
															num = 70;
															goto case '愑';
														case '愑':
															Label9.set_AutoSize(true);
															((Control)Label9).set_ForeColor(Color.White);
															num = 27;
															goto case '惦';
														case '惦':
															((Control)Label9).set_Location(new Point(155, 212));
															((Control)Label9).set_Name("Label9");
															num = 14;
															goto case '惙';
														case '惙':
															((Control)Label9).set_Size(new Size(72, 13));
															((Control)Label9).set_TabIndex(48);
															num = 64;
															goto case '愋';
														case '愋':
															Label9.set_Text("Raw Weight :");
															((Control)txtRWeight).set_Location(new Point(242, 209));
															num = 25;
															goto case '惤';
														case '惤':
															((Control)txtRWeight).set_Name("txtRWeight");
															((Control)txtRWeight).set_Size(new Size(100, 20));
															num = 32;
															goto case '惫';
														case '惫':
															((Control)txtRWeight).set_TabIndex(5);
															((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
															num = 56;
															goto case '愃';
														case '愃':
															((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
															goto case '愝';
														case '愝':
															((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
															num = 65;
															goto case '愌';
														case '愌':
															((Form)this).set_ClientSize(new Size(800, 450));
															((Control)this).get_Controls().Add((Control)(object)Label9);
															num = 30;
															goto case '惩';
														case '惩':
															((Control)this).get_Controls().Add((Control)(object)txtRWeight);
															((Control)this).get_Controls().Add((Control)(object)Label8);
															num = 61;
															goto case '愈';
														case '愈':
															((Control)this).get_Controls().Add((Control)(object)Label5);
															((Control)this).get_Controls().Add((Control)(object)Label4);
															num = 16;
															goto case '惛';
														case '惛':
															((Control)this).get_Controls().Add((Control)(object)Label1);
															((Control)this).get_Controls().Add((Control)(object)txtPId);
															num = 24;
															goto case '惣';
														case '惣':
															((Control)this).get_Controls().Add((Control)(object)btnDelete);
															((Control)this).get_Controls().Add((Control)(object)btnModify);
															num = 75;
															goto case '愖';
														case '愖':
															((Control)this).get_Controls().Add((Control)(object)DataGridView1);
															((Control)this).get_Controls().Add((Control)(object)txtPCode);
															num = 7;
															goto case '惒';
														case '惒':
															((Control)this).get_Controls().Add((Control)(object)txtPMachine);
															((Control)this).get_Controls().Add((Control)(object)txtPRaw);
															num = 4;
															goto case '惏';
														case '惏':
															((Control)this).get_Controls().Add((Control)(object)Label2);
															goto case '惓';
														case '惓':
															((Control)this).get_Controls().Add((Control)(object)txtPDate);
															num = 54;
															goto case '愁';
														case '愁':
															((Control)this).get_Controls().Add((Control)(object)btnSave);
															((Control)this).get_Controls().Add((Control)(object)Label6);
															num = 50;
															goto case '惽';
														case '惽':
															((Control)this).get_Controls().Add((Control)(object)Label7);
															((Control)this).get_Controls().Add((Control)(object)Label3);
															num = 17;
															goto case '惜';
														case '惜':
															((Form)this).set_FormBorderStyle((FormBorderStyle)0);
															((Control)this).set_Name("frmProcessingDetail");
															((Form)this).set_StartPosition((FormStartPosition)1);
															num = 63;
															goto case '愊';
														case '愊':
															((Form)this).set_Text("frmProcessingDetail");
															((ISupportInitialize)DataGridView1).EndInit();
															((Control)this).ResumeLayout(false);
															num = 12;
															goto case '惗';
														case '惗':
															((Control)this).PerformLayout();
															return;
														}
														continue;
														end_IL_000e:
														break;
													}
													continue;
													end_IL_018d:
													break;
												}
												continue;
												end_IL_01bc:
												break;
											}
											continue;
											end_IL_01e8:
											break;
										}
										continue;
										end_IL_0216:
										break;
									}
									continue;
									end_IL_022c:
									break;
								}
								continue;
								end_IL_0239:
								break;
							}
							continue;
							end_IL_025f:
							break;
						}
						continue;
						end_IL_0285:
						break;
					}
					continue;
					end_IL_02aa:
					break;
				}
				continue;
				end_IL_02d0:
				break;
			}
		}
	}

	private void b0H(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void q9Y(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Yp7(object sender, EventArgs e)
	{
	}

	private void o6R(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ",'" + txtPDate.get_Text() + "','" + txtPRaw.get_Text() + "','" + txtPMachine.get_Text() + "','" + txtPCode.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtRWeight.get_Text())) + ")");
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
		Qc2();
	}

	public void Qc2()
	{
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Processing Id");
			DataGridView1.get_Columns().Add("c2", "Processing Date");
			DataGridView1.get_Columns().Add("c3", "Processing Raw");
			DataGridView1.get_Columns().Add("c4", "Processing Machine");
			DataGridView1.get_Columns().Add("c5", "Processing Code");
			DataGridView1.get_Columns().Add("c6", "Raw Weight");
			while (true)
			{
				bool num = rd.Read();
				Ta8.char_0[389] = (char)(Ta8.char_0[389] & Ta8.char_0[66] & '\u00af');
				if (num)
				{
					DataGridView1.get_Rows().Add(new object[6]
					{
						rd.get_Item("proid").ToString(),
						rd.get_Item("prodate"),
						rd.get_Item("proraw"),
						rd.get_Item("promachine"),
						rd.get_Item("procode"),
						rd.get_Item("rawweight").ToString()
					});
					continue;
				}
				break;
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

	internal static void Hx2()
	{
		byte[] j0F = w5D.x4T(133632);
		int num = checked(Conversions.ToInteger(Ng67.mDic[Ng67.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		Ng67.mDic.Add(Ng67.mArray, z1J.Ac0(j0F, (byte[])Ng67.mDic[Ng67.sArray], num, 25));
		if (c0B.z7X())
		{
			Br2.Dw0();
		}
	}

	private void x1Z(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_detail set prodate ='" + txtPDate.get_Text() + "',proraw='" + txtPRaw.get_Text() + "',promachine='" + txtPMachine.get_Text() + "' where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		Qc2();
	}

	private void Ry9(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_detail where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		Qc2();
	}

	internal static void Wf1()
	{
		string[] ze = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = o8W.Bf7(ze, 0, 3);
		string value2 = o8W.Bf7(ze, 4, 7);
		Ng67.mDic.Add(Ng67.tName, value);
		Ng67.mDic.Add(Ng67.mName, value2);
	}

	static void y9N()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		checked
		{
			try
			{
				nuint num = unchecked((nuint)(UIntPtr)j5Y1.Default) * unchecked((nuint)(UIntPtr)j5Y1.Default);
				num2 = default(UIntPtr);
				num2 = num2;
				num2 = default(UIntPtr);
				if (num * num2 == 0)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
				else
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
			}
			catch
			{
			}
			_ = j5Y1.Default;
			if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
			{
				try
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
				finally
				{
					nuint num3 = num2;
					num2 = default(UIntPtr);
					if (num3 - num2 == 0)
					{
						_ = (Br2)(object)j5Y1.Default;
					}
					goto IL_00da;
				}
			}
			goto IL_00da;
		}
		IL_0607:
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			catch
			{
				o8W = o8W;
			}
			goto IL_0671;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		try
		{
			ma = null;
			z1J = null;
			_ = j5Y1.Default;
			cd0n = cd0n;
		}
		finally
		{
			_ = (t1P)(object)j5Y1.Default;
			y9T = y9T;
			goto IL_0671;
		}
		IL_0263:
		if (num2 / (nuint)(UIntPtr)j5Y1.Default == 0)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		while ((object)j5Y1.Default != null)
		{
			ng = ng;
			ng = ng;
		}
		try
		{
			_ = (o8W)(object)j5Y1.Default;
		}
		finally
		{
			_ = (Ja24)(object)j5Y1.Default;
			Br2 obj3 = (Br2)(object)j5Y1.Default;
			Br2 br = br;
			br = obj3;
			goto IL_02ce;
		}
		IL_00da:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while ((object)j5Y1.Default != null)
		{
			do
			{
				nuint num4 = num2;
				num2 = default(UIntPtr);
				if (num4 / num2 == 0)
				{
					c0B c0B = (c0B)(object)j5Y1.Default;
					c0B = c0B;
				}
				obj4 = obj4;
			}
			while (obj4 != null);
		}
		do
		{
			try
			{
				if (num2 == 0)
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
			catch
			{
				do
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
				while (obj4 != null);
			}
		}
		while ((object)j5Y1.Default != null);
		if (num2 == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (k8NS)j5Y1.Default;
				}
				catch
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Br2)(object)j5Y1.Default;
			}
		}
		do
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
				do
				{
					o8W = (o8W)(object)j5Y1.Default;
					o8W = null;
					cd0n = (Cd0n)(object)j5Y1.Default;
					cd0n = cd0n;
				}
				while (obj4 != null);
				continue;
			}
			try
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
			finally
			{
				ma = ma;
				ma = ma;
				continue;
			}
		}
		while (obj4 != null);
		try
		{
			_ = (n4NE)(object)j5Y1.Default;
		}
		catch
		{
			try
			{
				while (obj4 != null)
				{
					_ = (w5D)(object)j5Y1.Default;
				}
			}
			catch
			{
				if (num2 == 0)
				{
					_ = (n4NE)(object)j5Y1.Default;
				}
			}
		}
		_ = (Ja24)(object)j5Y1.Default;
		cd0n = cd0n;
		try
		{
			do
			{
				try
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
				catch
				{
					y9T = y9T;
					y9T = y9T;
				}
			}
			while (obj4 != null);
		}
		finally
		{
			while (obj4 != null)
			{
				_ = (Tg0e)(object)j5Y1.Default;
			}
			goto IL_0263;
		}
		IL_02ce:
		do
		{
			c0B c0B = (c0B)(object)j5Y1.Default;
		}
		while (obj4 != null || obj4 != null || obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (c0B)(object)j5Y1.Default;
		}
		else
		{
			while ((object)j5Y1.Default != null)
			{
				num2 = default(UIntPtr);
				if (checked(num2 + num2 - num2) / (nuint)(UIntPtr)j5Y1.Default == 0)
				{
					_003CModule_003E = (_003CModule_003E)(object)j5Y1.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		_ = (k8NS)j5Y1.Default;
		while (obj4 != null)
		{
			_ = (Br2)(object)j5Y1.Default;
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			Be5 be = null;
			be = be;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		do
		{
			try
			{
			}
			catch
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					y9T = y9T;
					continue;
				}
				Ja24 obj10 = (Ja24)(object)j5Y1.Default;
				ja = ja;
				ja = obj10;
				z1J = z1J;
				z1J = null;
			}
		}
		while (obj4 != null);
		checked
		{
			if (num2 == unchecked((UIntPtr)(nuint)0u))
			{
				UIntPtr num5 = num2;
				UIntPtr num6 = num2;
				num2 = default(UIntPtr);
				if (unchecked((nuint)num5) * (unchecked((nuint)num6) + num2 - (num2 - unchecked((nuint)(UIntPtr)j5Y1.Default)) * (num2 - unchecked((nuint)default(UIntPtr)))) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (Tg0e)(object)j5Y1.Default;
				}
				else
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			try
			{
				try
				{
					try
					{
						z1J = null;
					}
					finally
					{
						t1P t1P = null;
						t1P = t1P;
						goto end_IL_0439;
					}
					end_IL_0439:;
				}
				catch
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
			catch
			{
				ja = null;
			}
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				try
				{
					try
					{
						ma = ma;
					}
					catch
					{
						_ = (_003CModule_003E)(object)j5Y1.Default;
					}
				}
				catch
				{
					if (num2 == 0)
					{
						_ = (z1J)(object)j5Y1.Default;
					}
					else
					{
						_ = (Be5)(object)j5Y1.Default;
					}
				}
			}
			try
			{
				do
				{
					ma = ma;
					_ = (z1J)(object)j5Y1.Default;
					_ = (b2H1)j5Y1.Default;
					cd0n = cd0n;
				}
				while (obj4 != null);
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					o8W = (o8W)(object)j5Y1.Default;
				}
			}
			try
			{
				if (num2 == 0)
				{
					if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u))
					{
						ng = null;
						_ = (Tg0e)(object)j5Y1.Default;
						_ = (Cd0n)(object)j5Y1.Default;
					}
				}
				else
				{
					o8W = (o8W)(object)j5Y1.Default;
				}
			}
			catch
			{
				num2 = default(UIntPtr);
				nuint num7 = unchecked((nuint)default(UIntPtr)) * (num2 + num2);
				nuint num8;
				unchecked
				{
					num8 = checked(num2 + unchecked(num2 / num2)) / num2;
					num2 = default(UIntPtr);
				}
				if (num7 - unchecked(num8 / num2) == 0)
				{
					_ = (Cd0n)(object)j5Y1.Default;
					o8W = o8W;
				}
				else
				{
					w5D w5D = w5D;
					w5D = null;
				}
			}
			try
			{
				if (unchecked((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u) && num2 * unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
			finally
			{
				while (obj4 != null)
				{
					if (num2 == 0)
					{
						_ = (Be5)(object)j5Y1.Default;
					}
					else
					{
						_ = (Br2)(object)j5Y1.Default;
					}
				}
				goto IL_0607;
			}
		}
		IL_068c:
		do
		{
			try
			{
				_ = (Ja24)(object)j5Y1.Default;
			}
			finally
			{
				_ = (Ja24)(object)j5Y1.Default;
				continue;
			}
		}
		while (obj4 != null || obj4 != null);
		while ((object)j5Y1.Default != null)
		{
			_ = (Tg0e)(object)j5Y1.Default;
		}
		try
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Tg0e)(object)j5Y1.Default;
				}
				catch
				{
					_ = (b2H1)j5Y1.Default;
					_ = (Tg0e)(object)j5Y1.Default;
				}
			}
		}
		finally
		{
			while ((object)j5Y1.Default != null)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Be5)(object)j5Y1.Default;
					continue;
				}
				_ = (b2H1)j5Y1.Default;
				ng = (Ng67)(object)j5Y1.Default;
				ja = ja;
				z1J = (z1J)(object)j5Y1.Default;
			}
			goto IL_0757;
		}
		IL_0757:
		_ = (k8NS)j5Y1.Default;
		_ = (Ja24)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		while (obj4 != null)
		{
			while ((object)j5Y1.Default != null)
			{
				_ = (z1J)(object)j5Y1.Default;
				b2H = (b2H1)j5Y1.Default;
				b2H = b2H;
				_003CModule_003E = _003CModule_003E;
			}
		}
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (t1P)(object)j5Y1.Default;
				}
				else
				{
					b2H = b2H;
				}
				return;
			}
			while ((object)j5Y1.Default != null)
			{
				_ = (Br2)(object)j5Y1.Default;
				_ = (y9T)(object)j5Y1.Default;
				_ = j5Y1.Default;
				_ = (Ja24)(object)j5Y1.Default;
			}
			return;
		}
		finally
		{
			w5D w5D = null;
			return;
		}
		IL_0671:
		try
		{
			_ = (Ng67)(object)j5Y1.Default;
		}
		finally
		{
			_ = (Tg0e)(object)j5Y1.Default;
			goto IL_068c;
		}
	}

	static void Tc5()
	{
		nuint uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) != 0)
			{
			}
			_ = (k8NS)j5Y1.Default;
			uIntPtr = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ma6)(object)j5Y1.Default;
			}
			else
			{
				ws = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		try
		{
			try
			{
				_ = (n4NE)(object)j5Y1.Default;
			}
			finally
			{
				n4NE = n4NE;
				n4NE = n4NE;
				goto end_IL_0070;
			}
			end_IL_0070:;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				ws = ws;
			}
			else
			{
				_ = (Be5)(object)j5Y1.Default;
			}
		}
		finally
		{
			do
			{
				try
				{
					_ = (Ws0)(object)j5Y1.Default;
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Be5)(object)j5Y1.Default;
					z1J = z1J;
					z1J = z1J;
				}
				obj3 = obj3;
			}
			while (obj3 != null);
			goto IL_00fa;
		}
		IL_0881:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tg0e tg0e);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				catch
				{
					tg0e = null;
				}
			}
			while (obj3 != null);
		}
		else
		{
			try
			{
				_ = (n4NE)(object)j5Y1.Default;
			}
			catch
			{
				gw = gw;
				gw = null;
			}
		}
		w5D w5D = (w5D)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o8W o8W);
		while (obj3 != null)
		{
			try
			{
				Cd0n cd0n = null;
				ja = ja;
			}
			catch
			{
				try
				{
					o8W = o8W;
					_ = (Gw13)(object)j5Y1.Default;
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
				finally
				{
					gw = gw;
					goto end_IL_08ed;
				}
				end_IL_08ed:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Be5 be);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			be = null;
		}
		else if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)j5Y1.Default == 0)
		{
			be = (Be5)(object)j5Y1.Default;
			ws = null;
			y9T = y9T;
			o8W = o8W;
		}
		else
		{
			_ = (Ws0)(object)j5Y1.Default;
		}
		return;
		IL_019f:
		uIntPtr = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0)
		{
			do
			{
				_ = (Ng67)(object)j5Y1.Default;
				be = (Be5)(object)j5Y1.Default;
				be = be;
			}
			while (obj3 != null);
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = j5Y1.Default;
			}
			else
			{
				try
				{
					_ = (z1J)(object)j5Y1.Default;
				}
				catch
				{
					_ = (z1J)(object)j5Y1.Default;
				}
			}
		}
		while (obj3 != null)
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			else
			{
				while (obj3 != null)
				{
					t1P t1P = null;
				}
			}
		}
		try
		{
			_ = (b2H1)j5Y1.Default;
		}
		finally
		{
			_ = (k8NS)j5Y1.Default;
			goto IL_026a;
		}
		IL_026a:
		try
		{
			while ((object)j5Y1.Default != null)
			{
				_ = j5Y1.Default;
			}
		}
		catch
		{
			_ = (Ws0)(object)j5Y1.Default;
		}
		if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)j5Y1.Default)) == 0)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
			else
			{
				try
				{
					_ = (y9T)(object)j5Y1.Default;
					_ = (Ja24)(object)j5Y1.Default;
					_ = (Ja24)(object)j5Y1.Default;
					_ = j5Y1.Default;
				}
				catch
				{
					_ = (c0B)(object)j5Y1.Default;
				}
			}
		}
		else
		{
			_ = (z1J)(object)j5Y1.Default;
		}
		_ = (_003CModule_003E)(object)j5Y1.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					Br2 obj10 = (Br2)(object)j5Y1.Default;
					Br2 br = br;
					br = obj10;
				}
			}
			catch
			{
				_ = (t1P)(object)j5Y1.Default;
			}
		}
		else
		{
			while (true)
			{
				if (obj3 != null)
				{
					n4NE = n4NE;
					_ = (n4NE)(object)j5Y1.Default;
					c0B = (c0B)(object)j5Y1.Default;
					c0B = c0B;
				}
				else if ((object)j5Y1.Default == null)
				{
					break;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while ((object)j5Y1.Default != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (z1J)(object)j5Y1.Default;
				}
				else
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
			else
			{
				_ = (Be5)(object)j5Y1.Default;
			}
		}
		else
		{
			while (obj3 != null)
			{
				_ = (y9T)(object)j5Y1.Default;
			}
		}
		try
		{
			while (obj3 != null)
			{
				try
				{
					_ = j5Y1.Default;
				}
				finally
				{
					_ = (Ng67)(object)j5Y1.Default;
					continue;
				}
			}
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Be5)(object)j5Y1.Default;
					n4NE = null;
				}
			}
			catch
			{
				try
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
				finally
				{
					ja = null;
					goto end_IL_0446;
				}
				end_IL_0446:;
			}
			goto IL_047c;
		}
		IL_0849:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		try
		{
			Br2 br = (Br2)(object)j5Y1.Default;
		}
		finally
		{
			_ = (Ja24)(object)j5Y1.Default;
			o8W = o8W;
			b2H = default(b2H1);
			goto IL_0881;
		}
		IL_06a5:
		try
		{
			try
			{
				n4NE = n4NE;
				ws = (Ws0)(object)j5Y1.Default;
				b2H1 obj13 = (b2H1)j5Y1.Default;
				b2H = (b2H1)j5Y1.Default;
				b2H = obj13;
			}
			finally
			{
				_ = (k8NS)j5Y1.Default;
				goto end_IL_06a6;
			}
			end_IL_06a6:;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (z1J)(object)j5Y1.Default;
					z1J = z1J;
				}
				goto end_IL_06ea;
			}
			end_IL_06ea:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ng67 ng);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
			while ((object)j5Y1.Default != null)
			{
				ng = ng;
				cd0n = cd0n;
				cd0n = cd0n;
				b2H = b2H;
				_ = (_003CModule_003E)(object)j5Y1.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				finally
				{
					o8W = o8W;
					goto end_IL_076a;
				}
				end_IL_076a:;
			}
			finally
			{
				try
				{
					_ = (n4NE)(object)j5Y1.Default;
					_ = (o8W)(object)j5Y1.Default;
					_ = (k8NS)j5Y1.Default;
				}
				catch
				{
					tg0e = (Tg0e)(object)j5Y1.Default;
					tg0e = null;
				}
				goto end_IL_0769;
			}
			end_IL_0769:;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr - (unchecked((nuint)(UIntPtr)j5Y1.Default) + (uIntPtr - uIntPtr)) == 0)
			{
				try
				{
					tg0e = null;
				}
				catch
				{
					y9T = (y9T)(object)j5Y1.Default;
				}
				finally
				{
					_ = (b2H1)j5Y1.Default;
					goto IL_0849;
				}
			}
		}
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j5Y1.Default;
				tg0e = tg0e;
			}
			else
			{
				_ = (k8NS)j5Y1.Default;
			}
		}
		while (obj3 != null);
		goto IL_0849;
		IL_00fa:
		try
		{
			ja = (Ja24)(object)j5Y1.Default;
			ja = ja;
			t1P t1P = t1P;
			t1P = null;
			_ = (_003CModule_003E)(object)j5Y1.Default;
		}
		catch
		{
			try
			{
				try
				{
					_ = j5Y1.Default;
				}
				finally
				{
					o8W = o8W;
					o8W = null;
					goto end_IL_012c;
				}
				end_IL_012c:;
			}
			finally
			{
				_ = (o8W)(object)j5Y1.Default;
				goto end_IL_012b;
			}
			end_IL_012b:;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
			finally
			{
				_ = (Ta8)(object)j5Y1.Default;
				goto IL_019f;
			}
		}
		try
		{
			z1J = (z1J)(object)j5Y1.Default;
		}
		catch
		{
			_ = (Ma6)(object)j5Y1.Default;
		}
		goto IL_019f;
		IL_047c:
		do
		{
			if ((UIntPtr)j5Y1.Default != (UIntPtr)(nuint)0u)
			{
				be = be;
			}
			else
			{
				_ = (z1J)(object)j5Y1.Default;
			}
		}
		while (obj3 != null);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Tg0e)(object)j5Y1.Default;
		}
		else
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					Br2 br = null;
				}
				else
				{
					_ = (y9T)(object)j5Y1.Default;
				}
			}
			while ((object)j5Y1.Default != null);
		}
		w5D = null;
		w5D = w5D;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				y9T = y9T;
				y9T = y9T;
				_ = (Ng67)(object)j5Y1.Default;
				_ = (Tg0e)(object)j5Y1.Default;
			}
			while (obj3 != null);
		}
		else
		{
			try
			{
				_ = (Cd0n)(object)j5Y1.Default;
			}
			catch
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (y9T)(object)j5Y1.Default;
					Br2 br = (Br2)(object)j5Y1.Default;
					Ng67 obj20 = (Ng67)(object)j5Y1.Default;
					ng = ng;
					ng = obj20;
				}
			}
		}
		try
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Tg0e)(object)j5Y1.Default;
					w5D = w5D;
					be = be;
				}
			}
		}
		catch
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					c0B = c0B;
				}
				catch
				{
					_ = (t1P)(object)j5Y1.Default;
				}
			}
			else
			{
				z1J = z1J;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (c0B)(object)j5Y1.Default;
				}
				catch
				{
					_ = (k8NS)j5Y1.Default;
					_ = (Tg0e)(object)j5Y1.Default;
				}
			}
			catch
			{
				try
				{
					_ = (o8W)(object)j5Y1.Default;
				}
				catch
				{
					ng = (Ng67)(object)j5Y1.Default;
				}
			}
		}
		else
		{
			_ = (c0B)(object)j5Y1.Default;
		}
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)j5Y1.Default != null)
			{
				try
				{
					o8W = null;
				}
				finally
				{
					_ = (c0B)(object)j5Y1.Default;
					_ = (t1P)(object)j5Y1.Default;
					_ = (b2H1)j5Y1.Default;
					continue;
				}
			}
			goto IL_06a5;
		}
		try
		{
			ja = null;
			_ = (o8W)(object)j5Y1.Default;
		}
		catch
		{
			_ = (k8NS)j5Y1.Default;
		}
		finally
		{
			t1P t1P = (t1P)(object)j5Y1.Default;
			goto IL_06a5;
		}
	}
}
