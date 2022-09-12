using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bm4r;
using Cr4;
using Jo7k;
using Kc9;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Sd9;
using Ti18;
using Wf0t;
using Yf06;
using Yn19;
using Yn6o;
using b3YP;
using c9S;
using i1QX;
using i9XQ;
using k2CM;
using k3R;
using q9Z2;

namespace Ds3;

[DesignerGenerated]
public class Ty3 : Form
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
			EventHandler eventHandler = Cr2;
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
			char[] char_ = o1W.char_0;
			int num = 6;
			while (true)
			{
				EventHandler eventHandler = y5N;
				Label label = _Label7;
				if (label == null)
				{
					switch (char_[99])
					{
					case '껞':
						goto IL_0056;
					case '껗':
					case '껙':
						goto IL_005d;
					case '께':
						goto IL_0064;
					case '껚':
					case '껛':
						goto IL_0070;
					case '껜':
						return;
					}
					continue;
				}
				num = 7;
				goto IL_0056;
				IL_0064:
				label = _Label7;
				if (label == null)
				{
					break;
				}
				num = 3;
				goto IL_0070;
				IL_0070:
				((Control)label).add_Click(eventHandler);
				return;
				IL_0056:
				((Control)label).remove_Click(eventHandler);
				goto IL_005d;
				IL_005d:
				_Label7 = value;
				goto IL_0064;
			}
			num = 5;
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
			EventHandler eventHandler = m7K;
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
			char[] char_ = o1W.char_0;
			int num = 7;
			while (true)
			{
				IL_0063:
				EventHandler eventHandler = Yb2;
				Button val = _btnModify;
				if (val == null)
				{
					num = 3;
					goto IL_0056;
				}
				num = 1;
				goto IL_004f;
				IL_0056:
				while (true)
				{
					IL_0056_2:
					_btnModify = value;
					while (true)
					{
						val = _btnModify;
						if (val == null)
						{
							switch (char_[113])
							{
							case '\u05f6':
							case '\u05f8':
								break;
							case '\u05f5':
								goto end_IL_0043;
							case '\u05f7':
								goto IL_0056_2;
							default:
								goto IL_0063;
							case '״':
							case '\u05fa':
								goto IL_007e;
							case '\u05f9':
								return;
							}
							continue;
						}
						num = 6;
						goto IL_007e;
						IL_007e:
						((Control)val).add_Click(eventHandler);
						return;
						continue;
						end_IL_0043:
						break;
					}
					break;
				}
				goto IL_004f;
				IL_004f:
				((Control)val).remove_Click(eventHandler);
				goto IL_0056;
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
			EventHandler eventHandler = Qt4;
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

	public Ty3()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Zc5);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Fa7();
	}

	[DebuggerNonUserCode]
	protected override void z9J(bool Gr9)
	{
		try
		{
			bool num = Gr9 && components != null;
			o1W.char_0[246] = (char)((o1W.char_0[246] * o1W.char_0[181]) & '\u0095');
			if (num)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gr9);
		}
	}

	[DebuggerStepThrough]
	private void Fa7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		Label3 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		txtPId = new TextBox();
		btnDelete = new Button();
		btnModify = new Button();
		DataGridView1 = new DataGridView();
		txtPCode = new TextBox();
		txtPMachine = new TextBox();
		txtPRaw = new TextBox();
		Label2 = new Label();
		txtPDate = new TextBox();
		btnSave = new Button();
		Label1 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		txtRWeight = new TextBox();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(331, 27));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(135, 17));
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Processing Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(742, 27));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(50, 27));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("Go To Main");
		((Control)txtPId).set_Location(new Point(242, 72));
		((Control)txtPId).set_Name("txtPId");
		((Control)txtPId).set_Size(new Size(100, 20));
		((Control)txtPId).set_TabIndex(0);
		((Control)btnDelete).set_Location(new Point(417, 183));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 31));
		((Control)btnDelete).set_TabIndex(8);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((Control)btnModify).set_Location(new Point(417, 129));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 31));
		((Control)btnModify).set_TabIndex(7);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(53, 241));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(707, 206));
		((Control)DataGridView1).set_TabIndex(11);
		((Control)txtPCode).set_Location(new Point(242, 183));
		((Control)txtPCode).set_Name("txtPCode");
		((Control)txtPCode).set_Size(new Size(100, 20));
		((Control)txtPCode).set_TabIndex(4);
		((Control)txtPMachine).set_Location(new Point(242, 156));
		((Control)txtPMachine).set_Name("txtPMachine");
		((Control)txtPMachine).set_Size(new Size(100, 20));
		((Control)txtPMachine).set_TabIndex(3);
		((Control)txtPRaw).set_Location(new Point(242, 129));
		((Control)txtPRaw).set_Name("txtPRaw");
		((Control)txtPRaw).set_Size(new Size(100, 20));
		((Control)txtPRaw).set_TabIndex(2);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(164, 75));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(63, 13));
		((Control)Label2).set_TabIndex(33);
		Label2.set_Text("Process Id :");
		((Control)txtPDate).set_Location(new Point(242, 99));
		((Control)txtPDate).set_Name("txtPDate");
		((Control)txtPDate).set_Size(new Size(100, 20));
		((Control)txtPDate).set_TabIndex(1);
		((Control)btnSave).set_Location(new Point(417, 72));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 31));
		((Control)btnSave).set_TabIndex(6);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(150, 102));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(77, 13));
		((Control)Label1).set_TabIndex(43);
		Label1.set_Text("Process Date :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(150, 136));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(76, 13));
		((Control)Label4).set_TabIndex(44);
		Label4.set_Text("Process Raw :");
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(132, 163));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(95, 13));
		((Control)Label5).set_TabIndex(45);
		Label5.set_Text("Process Machine :");
		Label8.set_AutoSize(true);
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(134, 186));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(93, 13));
		((Control)Label8).set_TabIndex(46);
		Label8.set_Text("Processing Code :");
		Label9.set_AutoSize(true);
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(155, 212));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(72, 13));
		((Control)Label9).set_TabIndex(48);
		Label9.set_Text("Raw Weight :");
		((Control)txtRWeight).set_Location(new Point(242, 209));
		((Control)txtRWeight).set_Name("txtRWeight");
		((Control)txtRWeight).set_Size(new Size(100, 20));
		((Control)txtRWeight).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)txtRWeight);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtPId);
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)txtPCode);
		((Control)this).get_Controls().Add((Control)(object)txtPMachine);
		((Control)this).get_Controls().Add((Control)(object)txtPRaw);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)txtPDate);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmProcessingDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmProcessingDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void y5N(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void Cr2(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Zc5(object sender, EventArgs e)
	{
	}

	private void Qt4(object sender, EventArgs e)
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
		Em4();
	}

	public void Em4()
	{
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = o1W.char_0;
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			int num = 3;
			while (true)
			{
				cn.Open();
				while (true)
				{
					cmd.set_Connection(cn);
					num = 9;
					while (true)
					{
						cmd.set_CommandText("select * from tbl_processing_detail");
						rd = cmd.ExecuteReader();
						num = 5;
						while (true)
						{
							DataGridView1.get_Columns().Add("c1", "Processing Id");
							DataGridView1.get_Columns().Add("c2", "Processing Date");
							num = 0;
							while (true)
							{
								DataGridView1.get_Columns().Add("c3", "Processing Raw");
								DataGridView1.get_Columns().Add("c4", "Processing Machine");
								switch (char_[127])
								{
								case '\udaf4':
									break;
								case '\udaf9':
									goto end_IL_002e;
								case '\udafd':
									goto end_IL_00a8;
								case '\udaf6':
									goto end_IL_00e5;
								default:
									goto end_IL_010a;
								case '\udaf5':
									DataGridView1.get_Columns().Add("c5", "Processing Code");
									goto case '\udafb';
								case '\udafb':
									DataGridView1.get_Columns().Add("c6", "Raw Weight");
									num = 10;
									goto case '\udafe';
								case '\udafc':
									DataGridView1.get_Rows().Add(new object[6]
									{
										rd.get_Item("proid").ToString(),
										rd.get_Item("prodate"),
										rd.get_Item("proraw"),
										rd.get_Item("promachine"),
										rd.get_Item("procode"),
										rd.get_Item("rawweight").ToString()
									});
									goto case '\udaf8';
								case '\udaf8':
									num = 10;
									goto case '\udafe';
								case '\udafe':
									if (rd.Read())
									{
										num = 8;
										goto case '\udafc';
									}
									num = 6;
									return;
								case '\udafa':
									return;
								}
								continue;
								end_IL_002e:
								break;
							}
							continue;
							end_IL_00a8:
							break;
						}
						continue;
						end_IL_00e5:
						break;
					}
					continue;
					end_IL_010a:
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

	internal static void j1G()
	{
		byte[] c6E = o1W.Zb68(133632);
		int num = checked(Conversions.ToInteger(k2GS.mDic[k2GS.sNum]) * 3);
		bool num2 = num > 255;
		s5C.int_0[50] = (s5C.int_0[50] - s5C.int_0[384]) & 0x99;
		if (num2)
		{
			num = 255;
		}
		k2GS.mDic.Add(k2GS.mArray, Sd5.e5J(c6E, (byte[])k2GS.mDic[k2GS.sArray], num, 25));
		if (Es6d.w6WM())
		{
			Cr17.p5TN();
		}
	}

	private void Yb2(object sender, EventArgs e)
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
		Em4();
		o1W.char_0[92] = (char)((o1W.char_0[92] | o1W.char_0[348]) & '\u0014');
	}

	private void m7K(object sender, EventArgs e)
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
		Em4();
	}

	internal static void Na6()
	{
		string[] f6T = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Cy1.Xr2(f6T, 0, 3);
		string value2 = Cy1.Xr2(f6T, 4, 7);
		k2GS.mDic.Add(k2GS.tName, value);
		k2GS.mDic.Add(k2GS.mName, value2);
	}

	static void n9G()
	{
		object obj = null;
		a1HS a1HS = (a1HS)(object)Ns87.Default;
		a1HS = a1HS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g6EQ g6EQ);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1D8 f1D);
		while (obj != null)
		{
			do
			{
				try
				{
					f1D = f1D;
					_ = (q1J3)(object)Ns87.Default;
				}
				catch
				{
					g6EQ obj2 = (g6EQ)(object)Ns87.Default;
					g6EQ = g6EQ;
					g6EQ = obj2;
				}
			}
			while (obj != null);
		}
		do
		{
			_ = (k2GS)(object)Ns87.Default;
		}
		while ((object)Ns87.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			if (num / unchecked((nuint)default(UIntPtr)) == 0)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
				else
				{
					_ = Ns87.Default;
				}
			}
			else
			{
				do
				{
					_ = (Xq90)(object)Ns87.Default;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		Sd5 sd;
		while ((object)Ns87.Default != null)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Sa53)Ns87.Default;
					sa = sa;
					sa = sa;
					_ = (Xj06)Ns87.Default;
				}
				continue;
			}
			try
			{
				_ = Ns87.Default;
				_ = (q4PG)(object)Ns87.Default;
				Sd5 obj4 = (Sd5)(object)Ns87.Default;
				sd = (Sd5)(object)Ns87.Default;
				sd = obj4;
				Ns87 ns = null;
				ns = ns;
			}
			finally
			{
				f1D = null;
				continue;
			}
		}
		_ = (a1HS)(object)Ns87.Default;
		_ = (_003CModule_003E)(object)Ns87.Default;
		g6EQ = g6EQ;
		_ = (c7G)(object)Ns87.Default;
		sd = null;
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (o1W)(object)Ns87.Default;
			}
		}
		Es6d es6d = null;
		es6d = es6d;
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (k2GS)(object)Ns87.Default;
				}
				catch
				{
					_ = (c7G)(object)Ns87.Default;
					sd = sd;
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			while ((object)Ns87.Default != null);
		}
		try
		{
			while (obj != null)
			{
				_ = (f1D8)(object)Ns87.Default;
			}
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			try
			{
				try
				{
					_ = (c7G)(object)Ns87.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Ns87.Default;
					_003CModule_003E = (_003CModule_003E)(object)Ns87.Default;
					_003CModule_003E = _003CModule_003E;
					g6EQ = g6EQ;
					goto end_IL_0230;
				}
				end_IL_0230:;
			}
			finally
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (g6EQ)(object)Ns87.Default;
				}
				goto IL_0288;
			}
		}
		IL_038b:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1J3 q1J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s5C s5C);
		if (checked(num + unchecked((nuint)(UIntPtr)Ns87.Default)) == 0)
		{
			UIntPtr num2 = (UIntPtr)Ns87.Default;
			num = default(UIntPtr);
			if ((nuint)num2 / num == 0)
			{
				try
				{
					o1W o1W = o1W;
					o1W = null;
					g6EQ = null;
					_ = (c7G)(object)Ns87.Default;
					es6d = es6d;
				}
				finally
				{
					s5C = null;
					_ = (a1HS)(object)Ns87.Default;
					_ = (a1HS)(object)Ns87.Default;
					q1J = null;
					q1J = null;
					goto IL_0463;
				}
			}
			if (num == 0)
			{
				_ = (o1W)(object)Ns87.Default;
			}
			else
			{
				_ = (Sd5)(object)Ns87.Default;
			}
		}
		else
		{
			do
			{
				try
				{
					a1HS = (a1HS)(object)Ns87.Default;
				}
				finally
				{
					_ = (Sd5)(object)Ns87.Default;
					continue;
				}
			}
			while (obj != null);
		}
		goto IL_0463;
		IL_04a6:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q4PG q4PG);
		checked
		{
			if (num * unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				try
				{
					try
					{
						_ = (_003CModule_003E)(object)Ns87.Default;
					}
					finally
					{
						q4PG = q4PG;
						goto end_IL_04b7;
					}
					end_IL_04b7:;
				}
				catch
				{
					_ = (Cr17)(object)Ns87.Default;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					try
					{
						q4PG = q4PG;
						_ = (Sd5)(object)Ns87.Default;
						_ = Ns87.Default;
						f1D = f1D;
					}
					finally
					{
						_ = (s5C)(object)Ns87.Default;
						goto IL_054a;
					}
				}
				do
				{
					Ns87 ns = Ns87.Default;
				}
				while ((object)Ns87.Default != null);
			}
			goto IL_054a;
		}
		IL_0463:
		while ((object)Ns87.Default != null)
		{
			_ = (q4PG)(object)Ns87.Default;
		}
		if (num != 0)
		{
		}
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Sd5)(object)Ns87.Default;
			}
			finally
			{
				_ = (q1C3)(object)Ns87.Default;
				goto IL_04a6;
			}
		}
		_ = (Ty3)(object)Ns87.Default;
		goto IL_04a6;
		IL_0288:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C);
		try
		{
			checked
			{
				while (obj != null)
				{
					if (unchecked((nuint)(UIntPtr)Ns87.Default) + num == 0)
					{
						q4PG = q4PG;
						q4PG = null;
					}
					else
					{
						q1C = q1C;
					}
				}
			}
		}
		finally
		{
			try
			{
				k2GS k2GS = k2GS;
				k2GS = null;
			}
			catch
			{
				_ = (Cy1)(object)Ns87.Default;
			}
			finally
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Sa53)Ns87.Default;
					_ = (a1HS)(object)Ns87.Default;
				}
				goto IL_0303;
			}
		}
		IL_054a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cy1 cy);
		Xq90 xq;
		do
		{
			try
			{
				try
				{
					xq = (Xq90)(object)Ns87.Default;
					xq = xq;
				}
				finally
				{
					cy = cy;
					cy = null;
					goto end_IL_054a;
				}
				end_IL_054a:;
			}
			catch
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Sa53)Ns87.Default;
				}
				else
				{
					q4PG = null;
				}
			}
		}
		while (obj != null);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (num * unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
				{
					try
					{
						k2GS k2GS = null;
					}
					catch
					{
						_ = (k2GS)(object)Ns87.Default;
						a1HS = a1HS;
					}
				}
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
			else
			{
				_ = (g6EQ)(object)Ns87.Default;
			}
		}
		else
		{
			q1J = q1J;
		}
		c7G c7G = null;
		c7G = c7G;
		q1C = (q1C3)(object)Ns87.Default;
		do
		{
			f1D = (f1D8)(object)Ns87.Default;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ea3q ea3q);
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			ea3q = ea3q;
		}
		_ = (_003CModule_003E)(object)Ns87.Default;
		xq = (Xq90)(object)Ns87.Default;
		return;
		IL_0303:
		a1HS = (a1HS)(object)Ns87.Default;
		a1HS = null;
		s5C obj11 = (s5C)(object)Ns87.Default;
		s5C = s5C;
		s5C = obj11;
		try
		{
			do
			{
				ea3q = null;
			}
			while ((object)Ns87.Default != null || obj != null);
		}
		finally
		{
			try
			{
				try
				{
					_ = (Es6d)(object)Ns87.Default;
				}
				finally
				{
					_ = (q1C3)(object)Ns87.Default;
					goto end_IL_034b;
				}
				end_IL_034b:;
			}
			finally
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (q4PG)(object)Ns87.Default;
					q1C = q1C;
				}
				goto IL_038b;
			}
		}
	}
}
