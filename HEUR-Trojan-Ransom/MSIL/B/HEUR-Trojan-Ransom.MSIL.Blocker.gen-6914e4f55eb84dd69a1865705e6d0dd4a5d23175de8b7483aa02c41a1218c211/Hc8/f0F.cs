using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bx3;
using Dn7;
using Dy1a;
using Gb1;
using Hf9e;
using Hj8;
using Lj1k;
using Microsoft.VisualBasic.CompilerServices;
using Qw80;
using Ss0;
using Tb3;
using c5E;
using c6R;
using g5S;
using i3L;
using o8Z;
using p0H;
using q3F;
using q8X;
using z2Z;

namespace Hc8;

[DesignerGenerated]
public class f0F : Form
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
			EventHandler eventHandler = Ps0;
			Button val = _btnSave;
			Button obj = val;
			Mb5.char_0[213] = (char)((Mb5.char_0[213] ^ Mb5.char_0[183]) & '\u001a');
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
			EventHandler eventHandler = Kf8;
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
			EventHandler eventHandler = s2W;
			Label label = _Label7;
			Label obj = label;
			Pj8.byte_0[43] = (byte)(Pj8.byte_0[43] & Pj8.byte_0[161] & 0xC6);
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
			EventHandler eventHandler = s3Q;
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
			EventHandler eventHandler = Qm9;
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

	public f0F()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Cc2);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		y3T();
	}

	[DebuggerNonUserCode]
	protected override void r7X(bool Yf7)
	{
		char[] char_ = Mb5.char_0;
		byte[] byte_ = Pj8.byte_0;
		try
		{
			int num = 2;
			while (true)
			{
				if (!Yf7)
				{
					num = (int)char_[40] / 2;
					goto IL_0039;
				}
				num = 6;
				goto IL_002e;
				IL_002e:
				if (components != null)
				{
					num = 0;
					break;
				}
				goto IL_001d;
				IL_001d:
				num = byte_[296] - 172;
				goto IL_0039;
				IL_0039:
				switch (num)
				{
				case 1:
				case 7:
					break;
				case 6:
					goto IL_002e;
				default:
					continue;
				case 0:
				case 4:
				case 5:
					goto end_IL_0065;
				case 3:
					return;
				}
				goto IL_001d;
				continue;
				end_IL_0065:
				break;
			}
			components.Dispose();
			num = 3;
		}
		finally
		{
			((Form)this).Dispose(Yf7);
		}
	}

	[DebuggerStepThrough]
	private void y3T()
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected O, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected O, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Expected O, but got Unknown
		char[] char_ = Mb5.char_0;
		byte[] byte_ = Pj8.byte_0;
		int num = 54;
		while (true)
		{
			btnSave = new Button();
			txtTid = new TextBox();
			Label1 = new Label();
			num = 27;
			while (true)
			{
				Label2 = new Label();
				Label3 = new Label();
				Label4 = new Label();
				num = 26;
				while (true)
				{
					txtTCost = new TextBox();
					txtTDistance = new TextBox();
					txtTMode = new TextBox();
					num = 66;
					while (true)
					{
						Label5 = new Label();
						Label6 = new Label();
						Label7 = new Label();
						num = 1;
						while (true)
						{
							DataGridView1 = new DataGridView();
							while (true)
							{
								btnModify = new Button();
								btnDelete = new Button();
								num = 29;
								while (true)
								{
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									((Control)btnSave).set_Location(new Point(160, 202));
									num = 56;
									while (true)
									{
										((Control)btnSave).set_Name("btnSave");
										((Control)btnSave).set_Size(new Size(75, 23));
										num = 21;
										while (true)
										{
											((Control)btnSave).set_TabIndex(4);
											((ButtonBase)btnSave).set_Text("SAVE");
											num = 38;
											while (true)
											{
												((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
												((Control)txtTid).set_Location(new Point(173, 40));
												num = 11;
												while (true)
												{
													((Control)txtTid).set_Name("txtTid");
													((Control)txtTid).set_Size(new Size(100, 20));
													num = 40;
													while (true)
													{
														((Control)txtTid).set_TabIndex(0);
														Label1.set_AutoSize(true);
														num = 62;
														while (true)
														{
															((Control)Label1).set_ForeColor(Color.White);
															((Control)Label1).set_Location(new Point(58, 90));
															num = 41;
															while (true)
															{
																((Control)Label1).set_Name("Label1");
																((Control)Label1).set_Size(new Size(82, 13));
																num = 39;
																while (true)
																{
																	((Control)Label1).set_TabIndex(2);
																	Label1.set_Text("Transport Cost :");
																	num = 58;
																	while (true)
																	{
																		Label2.set_AutoSize(true);
																		((Control)Label2).set_ForeColor(Color.White);
																		num = char_[140] - 34564;
																		while (true)
																		{
																			switch (num)
																			{
																			case 68:
																				((Control)Label4).set_Location(new Point(46, 158));
																				((Control)Label4).set_Name("Label4");
																				num = 10;
																				goto case 10;
																			case 10:
																				((Control)Label4).set_Size(new Size(88, 13));
																				((Control)Label4).set_TabIndex(5);
																				num = 32;
																				goto case 32;
																			case 32:
																				Label4.set_Text("Transport Mode :");
																				((Control)txtTCost).set_Location(new Point(173, 83));
																				num = 43;
																				goto case 43;
																			case 43:
																				((Control)txtTCost).set_Name("txtTCost");
																				((Control)txtTCost).set_Size(new Size(100, 20));
																				num = 44;
																				goto case 44;
																			case 44:
																				((Control)txtTCost).set_TabIndex(1);
																				((Control)txtTDistance).set_Location(new Point(173, 125));
																				num = 57;
																				goto case 57;
																			case 57:
																				((Control)txtTDistance).set_Name("txtTDistance");
																				((Control)txtTDistance).set_Size(new Size(100, 20));
																				num = 45;
																				goto case 45;
																			case 45:
																				((Control)txtTDistance).set_TabIndex(2);
																				((Control)txtTMode).set_Location(new Point(173, 158));
																				num = 12;
																				goto case 12;
																			case 12:
																				((Control)txtTMode).set_Name("txtTMode");
																				((Control)txtTMode).set_Size(new Size(100, 20));
																				num = 19;
																				goto case 19;
																			case 19:
																				((Control)txtTMode).set_TabIndex(3);
																				Label5.set_AutoSize(true);
																				num = 4;
																				goto case 4;
																			case 4:
																				((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 3;
																				goto case 3;
																			case 3:
																				((Control)Label5).set_ForeColor(Color.White);
																				((Control)Label5).set_Location(new Point(341, 19));
																				num = 8;
																				goto case 8;
																			case 8:
																				((Control)Label5).set_Name("Label5");
																				((Control)Label5).set_Size(new Size(126, 17));
																				num = 52;
																				goto case 52;
																			case 52:
																				((Control)Label5).set_TabIndex(8);
																				Label5.set_Text("Transport Detail");
																				num = 13;
																				goto case 13;
																			case 13:
																			case 60:
																				Label6.set_AutoSize(true);
																				((Control)Label6).set_BackColor(Color.Blue);
																				num = 33;
																				goto case 33;
																			case 33:
																				((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 48;
																				goto case 48;
																			case 48:
																				((Control)Label6).set_ForeColor(Color.White);
																				((Control)Label6).set_Location(new Point(731, 19));
																				num = 30;
																				goto case 30;
																			case 30:
																				((Control)Label6).set_Name("Label6");
																				((Control)Label6).set_Size(new Size(18, 17));
																				num = 15;
																				goto case 15;
																			case 15:
																				((Control)Label6).set_TabIndex(9);
																				Label6.set_Text("X");
																				num = 22;
																				goto case 22;
																			case 22:
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 61;
																				goto case 61;
																			case 61:
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 9;
																				goto case 9;
																			case 9:
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(39, 19));
																				num = 49;
																				goto case 49;
																			case 49:
																				((Control)Label7).set_Name("Label7");
																				((Control)Label7).set_Size(new Size(92, 17));
																				num = 2;
																				goto case 2;
																			case 2:
																				((Control)Label7).set_TabIndex(7);
																				Label7.set_Text("Go To Main");
																				num = 24;
																				goto case 24;
																			case 24:
																				DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																				((Control)DataGridView1).set_Location(new Point(32, 239));
																				num = 18;
																				goto case 18;
																			case 18:
																				((Control)DataGridView1).set_Name("DataGridView1");
																				((Control)DataGridView1).set_Size(new Size(599, 199));
																				num = 23;
																				goto case 23;
																			case 23:
																				((Control)DataGridView1).set_TabIndex(10);
																				((Control)btnModify).set_Location(new Point(268, 202));
																				num = 20;
																				goto case 20;
																			case 20:
																				((Control)btnModify).set_Name("btnModify");
																				((Control)btnModify).set_Size(new Size(75, 23));
																				num = 14;
																				goto case 14;
																			case 14:
																				((Control)btnModify).set_TabIndex(5);
																				goto case 51;
																			case 51:
																				((ButtonBase)btnModify).set_Text("MODIFY");
																				num = 64;
																				goto case 64;
																			case 64:
																				((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																				((Control)btnDelete).set_Location(new Point(380, 202));
																				num = 42;
																				goto case 42;
																			case 42:
																				((Control)btnDelete).set_Name("btnDelete");
																				((Control)btnDelete).set_Size(new Size(75, 23));
																				num = 16;
																				goto case 16;
																			case 16:
																				((Control)btnDelete).set_TabIndex(6);
																				((ButtonBase)btnDelete).set_Text("DELETE");
																				num = 37;
																				goto case 37;
																			case 37:
																				((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																				num = 55;
																				goto case 55;
																			case 55:
																				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																				((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																				num = 28;
																				goto case 28;
																			case 28:
																				((Form)this).set_ClientSize(new Size(800, 450));
																				((Control)this).get_Controls().Add((Control)(object)btnDelete);
																				num = 47;
																				goto case 47;
																			case 47:
																				((Control)this).get_Controls().Add((Control)(object)btnModify);
																				((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																				num = 34;
																				goto case 34;
																			case 34:
																				((Control)this).get_Controls().Add((Control)(object)Label6);
																				((Control)this).get_Controls().Add((Control)(object)Label7);
																				num = 0;
																				goto case 0;
																			case 0:
																				((Control)this).get_Controls().Add((Control)(object)Label5);
																				((Control)this).get_Controls().Add((Control)(object)txtTMode);
																				num = 59;
																				goto case 59;
																			case 59:
																				((Control)this).get_Controls().Add((Control)(object)txtTDistance);
																				((Control)this).get_Controls().Add((Control)(object)txtTCost);
																				num = (int)byte_[20] / 4;
																				continue;
																			case 67:
																				Label4.set_AutoSize(true);
																				((Control)Label4).set_ForeColor(Color.White);
																				num = 68;
																				goto case 68;
																			case 65:
																				Label2.set_Text("Transport Id :");
																				Label3.set_AutoSize(true);
																				num = 63;
																				goto case 63;
																			case 63:
																				((Control)Label3).set_ForeColor(Color.White);
																				((Control)Label3).set_Location(new Point(46, 125));
																				num = 53;
																				goto case 53;
																			case 53:
																				((Control)Label3).set_Name("Label3");
																				((Control)Label3).set_Size(new Size(103, 13));
																				num = 7;
																				goto case 7;
																			case 7:
																				((Control)Label3).set_TabIndex(4);
																				Label3.set_Text("Transport Distance :");
																				num = 67;
																				goto case 67;
																			case 36:
																				((Control)Label2).set_Size(new Size(70, 13));
																				((Control)Label2).set_TabIndex(3);
																				num = 65;
																				goto case 65;
																			case 17:
																				((Control)Label2).set_Location(new Point(58, 47));
																				((Control)Label2).set_Name("Label2");
																				num = 36;
																				goto case 36;
																			case 58:
																				break;
																			case 39:
																				goto end_IL_07aa;
																			case 41:
																				goto end_IL_07d9;
																			case 62:
																				goto end_IL_07fa;
																			case 40:
																				goto end_IL_0823;
																			case 11:
																				goto end_IL_084c;
																			case 38:
																				goto end_IL_0869;
																			case 21:
																				goto end_IL_0892;
																			case 56:
																				goto end_IL_08ba;
																			case 29:
																				goto end_IL_08db;
																			case 35:
																				goto end_IL_0904;
																			case 1:
																				goto end_IL_0934;
																			case 66:
																				goto end_IL_094f;
																			case 26:
																				goto end_IL_095c;
																			case 27:
																				goto end_IL_0981;
																			default:
																				goto end_IL_09a7;
																			case 6:
																				((Control)this).get_Controls().Add((Control)(object)Label4);
																				((Control)this).get_Controls().Add((Control)(object)Label3);
																				num = 31;
																				goto case 31;
																			case 31:
																				((Control)this).get_Controls().Add((Control)(object)Label2);
																				((Control)this).get_Controls().Add((Control)(object)Label1);
																				num = 50;
																				goto case 50;
																			case 50:
																				((Control)this).get_Controls().Add((Control)(object)txtTid);
																				((Control)this).get_Controls().Add((Control)(object)btnSave);
																				num = 5;
																				goto case 5;
																			case 5:
																				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																				((Control)this).set_Name("frmTransportDetail");
																				((Form)this).set_StartPosition((FormStartPosition)1);
																				num = 25;
																				goto case 25;
																			case 25:
																				((Form)this).set_Text("frmTransportDetail");
																				((ISupportInitialize)DataGridView1).EndInit();
																				((Control)this).ResumeLayout(false);
																				num = 46;
																				goto case 46;
																			case 46:
																				((Control)this).PerformLayout();
																				return;
																			}
																			break;
																		}
																		continue;
																		end_IL_07aa:
																		break;
																	}
																	continue;
																	end_IL_07d9:
																	break;
																}
																continue;
																end_IL_07fa:
																break;
															}
															continue;
															end_IL_0823:
															break;
														}
														continue;
														end_IL_084c:
														break;
													}
													continue;
													end_IL_0869:
													break;
												}
												continue;
												end_IL_0892:
												break;
											}
											continue;
											end_IL_08ba:
											break;
										}
										continue;
										end_IL_08db:
										break;
									}
									continue;
									end_IL_0904:
									break;
								}
								continue;
								end_IL_0934:
								break;
							}
							continue;
							end_IL_094f:
							break;
						}
						continue;
						end_IL_095c:
						break;
					}
					continue;
					end_IL_0981:
					break;
				}
				continue;
				end_IL_09a7:
				break;
			}
		}
	}

	private void Ps0(object sender, EventArgs e)
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
		y1Q();
	}

	public void y1Q()
	{
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = Mb5.char_0;
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			int num = 4;
			while (true)
			{
				cn.Open();
				while (true)
				{
					cmd.set_Connection(cn);
					num = 2;
					while (true)
					{
						cmd.set_CommandText("select * from tbl_transport");
						rd = cmd.ExecuteReader();
						num = 8;
						while (true)
						{
							DataGridView1.get_Columns().Add("c1", "Transport Id");
							while (true)
							{
								DataGridView1.get_Columns().Add("c2", "Transport Cost");
								num = 1;
								while (true)
								{
									DataGridView1.get_Columns().Add("c3", "Transport Distance");
									DataGridView1.get_Columns().Add("c4", "Transport Mode");
									char num2 = char_[112];
									char num3 = char_[112];
									Mb5.char_0[118] = (char)(Mb5.char_0[118] & Pj8.byte_0[100] & 'j');
									switch (num2 - num3)
									{
									case 1:
										break;
									case 5:
										goto end_IL_002e;
									case 8:
										goto end_IL_00c0;
									case 2:
										goto end_IL_00e2;
									case 7:
										goto end_IL_00ff;
									default:
										goto end_IL_0124;
									case 0:
										if (rd.Read())
										{
											num = 9;
											goto case 9;
										}
										num = 6;
										return;
									case 9:
										DataGridView1.get_Rows().Add(new object[4]
										{
											rd.get_Item("transportid").ToString(),
											rd.get_Item("transportcost"),
											rd.get_Item("transportdistance").ToString(),
											rd.get_Item("transportmode")
										});
										goto case 10;
									case 10:
										num = 0;
										goto case 0;
									case 6:
										return;
									}
									continue;
									end_IL_002e:
									break;
								}
								continue;
								end_IL_00c0:
								break;
							}
							continue;
							end_IL_00e2:
							break;
						}
						continue;
						end_IL_00ff:
						break;
					}
					continue;
					end_IL_0124:
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

	private void s2W(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void Kf8(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Cc2(object sender, EventArgs e)
	{
		y1Q();
	}

	private void s3Q(object sender, EventArgs e)
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
		y1Q();
	}

	private void Qm9(object sender, EventArgs e)
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
		y1Q();
	}

	internal static bool Ta2()
	{
		try
		{
			try
			{
				Eb1.mDic.Add(Eb1.T, Assembly.Load((byte[])Eb1.mDic[Eb1.mArray]).GetExportedTypes()[27]);
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

	static void q1J()
	{
		k6D9 k6D = k6D;
		k6D = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		while ((object)Nf2.Default != null)
		{
			while (true)
			{
				obj = obj;
				if (obj == null)
				{
					break;
				}
				_ = (w4R)(object)Nf2.Default;
			}
		}
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = Nf2.Default;
				}
				finally
				{
					o5CZ o5CZ = null;
					o5CZ = o5CZ;
					_ = (Pj8)(object)Nf2.Default;
					k6D = null;
					goto end_IL_0035;
				}
			}
			end_IL_0035:;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
			}
			else if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Gj4)Nf2.Default;
				_ = (Gj4)Nf2.Default;
				_ = (Gj4)Nf2.Default;
				w4R w4R = w4R;
				w4R = w4R;
				_ = (d4E)(object)Nf2.Default;
			}
			else
			{
				_ = (Mb5)(object)Nf2.Default;
			}
		}
		try
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (d1X)(object)Nf2.Default;
					continue;
				}
				_ = (Eb1)(object)Nf2.Default;
				_ = (Eb1)(object)Nf2.Default;
				_ = (Mb5)(object)Nf2.Default;
			}
			while (obj != null);
		}
		finally
		{
			_ = (f0F)(object)Nf2.Default;
			goto IL_015a;
		}
		IL_0709:
		nuint num;
		try
		{
			while (obj != null)
			{
				if (num == 0)
				{
					_ = (Np8)(object)Nf2.Default;
					o5CZ o5CZ = (o5CZ)(object)Nf2.Default;
					_ = (Eb1)(object)Nf2.Default;
				}
			}
		}
		finally
		{
			_ = (o5CZ)(object)Nf2.Default;
			goto IL_074c;
		}
		IL_074c:
		_ = (Gj4)Nf2.Default;
		_ = (Gj4)Nf2.Default;
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Pj8)(object)Nf2.Default;
				}
				finally
				{
					w4R w4R = (w4R)(object)Nf2.Default;
					goto end_IL_076e;
				}
				end_IL_076e:;
			}
			catch
			{
				do
				{
					_ = (Np8)(object)Nf2.Default;
					_ = (f0F)(object)Nf2.Default;
					_ = (f2L)(object)Nf2.Default;
					Np8 np = (Np8)(object)Nf2.Default;
				}
				while (obj != null);
			}
		}
		_ = (w4R)(object)Nf2.Default;
		do
		{
			_ = (k6D9)(object)Nf2.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (Mb5)(object)Nf2.Default;
					_ = (w4R)(object)Nf2.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					r8M r8M = default(r8M);
				}
				else
				{
					mb = mb;
				}
			}
		}
		catch
		{
			_ = (f2L)(object)Nf2.Default;
		}
		try
		{
			f9T6 f9T = null;
			_ = (Pj8)(object)Nf2.Default;
			_ = (x8D9)(object)Nf2.Default;
			_ = (x8D9)(object)Nf2.Default;
		}
		finally
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Gj4)Nf2.Default;
			}
			goto IL_0881;
		}
		IL_08e3:
		while (true)
		{
			if (obj != null)
			{
				mb = mb;
			}
			else if ((object)Nf2.Default == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		_003CModule_003E _003CModule_003E;
		try
		{
			try
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
				return;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				_ = (f9T6)(object)Nf2.Default;
				_ = (d1X)(object)Nf2.Default;
				nf = nf;
				return;
			}
		}
		catch
		{
			return;
		}
		IL_015a:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (f2L)(object)Nf2.Default;
					mb = mb;
					mb = null;
					x8D = null;
					x8D = null;
					pm = (Pm9)(object)Nf2.Default;
					pm = pm;
				}
				finally
				{
					x8D = x8D;
					_ = (w4R)(object)Nf2.Default;
					_ = (_003CModule_003E)(object)Nf2.Default;
					goto end_IL_016d;
				}
				end_IL_016d:;
			}
			finally
			{
				try
				{
					Np8 obj7 = (Np8)(object)Nf2.Default;
					Np8 np = np;
					np = obj7;
				}
				finally
				{
					x8D = (x8D9)(object)Nf2.Default;
					goto IL_01f5;
				}
			}
		}
		goto IL_01f5;
		IL_0881:
		try
		{
			_ = (w4R)(object)Nf2.Default;
		}
		finally
		{
			try
			{
				_ = (Gj4)Nf2.Default;
			}
			finally
			{
				_ = (_003CModule_003E)(object)Nf2.Default;
				_ = (Pj8)(object)Nf2.Default;
				_ = (k6D9)(object)Nf2.Default;
				_ = (Mb5)(object)Nf2.Default;
				goto IL_08e3;
			}
		}
		IL_01f5:
		UIntPtr num2 = num;
		num = default(UIntPtr);
		d8B d8B;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
			if (unchecked((nuint)num2) + num == 0)
			{
				_ = (d1X)(object)Nf2.Default;
				r8M obj8 = (r8M)Nf2.Default;
				r8M r8M = (r8M)Nf2.Default;
				r8M = obj8;
				m0N = m0N;
				m0N = m0N;
			}
			Np8 np = null;
			try
			{
				while (obj != null)
				{
					try
					{
						_ = (Gj4)Nf2.Default;
					}
					catch
					{
						m0N = m0N;
					}
				}
			}
			catch
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						mb = mb;
						m0N = m0N;
					}
					else
					{
						_ = (d8B)(object)Nf2.Default;
					}
				}
				catch
				{
					if (num == 0)
					{
						_ = (d4E)(object)Nf2.Default;
					}
					else
					{
						_ = (d8B)(object)Nf2.Default;
					}
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
			do
			{
				try
				{
					while ((object)Nf2.Default != null)
					{
						_ = (Pm9)(object)Nf2.Default;
					}
				}
				finally
				{
					try
					{
						pm = pm;
					}
					finally
					{
						Co4 obj12 = (Co4)(object)Nf2.Default;
						co = co;
						co = obj12;
						_ = (w4R)(object)Nf2.Default;
						d8B = (d8B)(object)Nf2.Default;
						d8B = d8B;
						continue;
					}
				}
			}
			while (obj != null);
			_003CModule_003E obj13 = (_003CModule_003E)(object)Nf2.Default;
			_003CModule_003E = null;
			_003CModule_003E = obj13;
			o5CZ o5CZ = (o5CZ)(object)Nf2.Default;
			f0F obj14 = (f0F)(object)Nf2.Default;
			f0F f0F2 = f0F2;
			f0F2 = obj14;
			while ((object)Nf2.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (f0F)(object)Nf2.Default;
				}
			}
			if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
			{
				d8B = d8B;
			}
			else
			{
				nuint num3 = num;
				num = default(UIntPtr);
				if ((num3 + num) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
						_ = (Mb5)(object)Nf2.Default;
						_ = (r8M)Nf2.Default;
						d8B = null;
					}
					catch
					{
						_ = (m0N)(object)Nf2.Default;
					}
				}
			}
			try
			{
				while (obj != null)
				{
					try
					{
						f0F2 = (f0F)(object)Nf2.Default;
					}
					catch
					{
						_ = (o5CZ)(object)Nf2.Default;
					}
				}
			}
			finally
			{
				try
				{
					_ = (f0F)(object)Nf2.Default;
					_ = (Np8)(object)Nf2.Default;
					Nf2 obj17 = Nf2.Default;
					nf = null;
					nf = obj17;
				}
				finally
				{
					if (num == 0)
					{
						f2L f2L = f2L;
					}
					else
					{
						_ = (m0N)(object)Nf2.Default;
					}
					goto IL_046a;
				}
			}
		}
		IL_046a:
		_ = (Pj8)(object)Nf2.Default;
		do
		{
			try
			{
				pm = null;
			}
			catch
			{
				try
				{
					w4R w4R = (w4R)(object)Nf2.Default;
				}
				finally
				{
					_ = (w4R)(object)Nf2.Default;
					goto end_IL_047d;
				}
				end_IL_047d:;
			}
		}
		while (obj != null);
		_ = (m0N)(object)Nf2.Default;
		while ((object)Nf2.Default != null)
		{
			pm = null;
		}
		do
		{
			r8M r8M = default(r8M);
		}
		while ((object)Nf2.Default != null);
		checked
		{
			if (num * num == 0)
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * (num + num) == 0)
				{
					d8B = d8B;
				}
			}
			if (num == 0)
			{
				while ((object)Nf2.Default != null)
				{
					try
					{
						_ = (d8B)(object)Nf2.Default;
						o5CZ o5CZ = (o5CZ)(object)Nf2.Default;
						w4R w4R = (w4R)(object)Nf2.Default;
					}
					finally
					{
						_ = (d8B)(object)Nf2.Default;
						continue;
					}
				}
			}
			if (num == 0)
			{
				while (obj != null)
				{
					while (obj != null)
					{
						_ = (d1X)(object)Nf2.Default;
					}
				}
			}
			f9T6 f9T = f9T;
			f9T = null;
			x8D = x8D;
			_ = (Pm9)(object)Nf2.Default;
		}
		if (num / unchecked((nuint)default(UIntPtr)) == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Pm9)(object)Nf2.Default;
		}
		_ = (Pj8)(object)Nf2.Default;
		try
		{
			o5CZ o5CZ = (o5CZ)(object)Nf2.Default;
		}
		catch
		{
			try
			{
				try
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				finally
				{
					_ = (f2L)(object)Nf2.Default;
					goto end_IL_05e8;
				}
				end_IL_05e8:;
			}
			catch
			{
				_ = (x8D9)(object)Nf2.Default;
			}
		}
		do
		{
			UIntPtr num4 = (UIntPtr)Nf2.Default;
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num4) + unchecked(num / checked(unchecked((nuint)(UIntPtr)Nf2.Default) - num * (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)(UIntPtr)Nf2.Default))))) == 0)
				{
					try
					{
						pm = (Pm9)(object)Nf2.Default;
					}
					finally
					{
						Co4 co = null;
						continue;
					}
				}
			}
		}
		while ((object)Nf2.Default != null);
		try
		{
		}
		catch
		{
			_ = (k6D9)(object)Nf2.Default;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Eb1)(object)Nf2.Default;
				}
			}
			goto IL_0709;
		}
		try
		{
			do
			{
				_ = (d8B)(object)Nf2.Default;
			}
			while (obj != null);
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				pm = pm;
			}
			goto IL_0709;
		}
	}
}
