using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dn7;
using Dy1a;
using Gb1;
using Hc8;
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

namespace Bx3;

[DesignerGenerated]
public class w4R : Form
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
			EventHandler eventHandler = Zn5;
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
			EventHandler eventHandler = s0L;
			Label label = _Label7;
			Label obj = label;
			Pj8.byte_0[234] = (byte)((Pj8.byte_0[234] * Pj8.byte_0[62]) & 0x78);
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
			EventHandler eventHandler = Wn6;
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
			EventHandler eventHandler = f9F;
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
			EventHandler eventHandler = Ee2;
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

	public w4R()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)n9M);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		e0B();
	}

	[DebuggerNonUserCode]
	protected override void t2X(bool Gd6)
	{
		byte[] byte_ = Pj8.byte_0;
		try
		{
			int num = 7;
			while (true)
			{
				if (Gd6)
				{
					switch (byte_[278] - byte_[26])
					{
					case 2:
						goto IL_0042;
					case 5:
						goto IL_004f;
					case 0:
						goto IL_0073;
					case 3:
					case 4:
						goto IL_007e;
					case 6:
						return;
					}
					continue;
				}
				num = 5;
				goto IL_004f;
				IL_007e:
				num = 6;
				return;
				IL_0042:
				int num2 = ((components != null) ? 1 : 0);
				goto IL_0050;
				IL_0073:
				components.Dispose();
				goto IL_007e;
				IL_004f:
				num2 = 0;
				goto IL_0050;
				IL_0050:
				Mb5.char_0[108] = (char)((Mb5.char_0[108] | Pj8.byte_0[484]) & '\u001b');
				if (num2 == 0)
				{
					break;
				}
				num = 0;
				goto IL_0073;
			}
			num = 6;
		}
		finally
		{
			((Form)this).Dispose(Gd6);
		}
	}

	[DebuggerStepThrough]
	private void e0B()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		char[] char_ = Mb5.char_0;
		int num = 4;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 13;
			while (true)
			{
				DataGridView1 = new DataGridView();
				DateTimePicker1 = new DateTimePicker();
				Label8 = new Label();
				num = 11;
				while (true)
				{
					Label5 = new Label();
					Label4 = new Label();
					Label1 = new Label();
					num = 1;
					while (true)
					{
						txtSNo = new TextBox();
						btnDelete = new Button();
						btnModify = new Button();
						num = 38;
						while (true)
						{
							txtAmount = new TextBox();
							txtSRaw = new TextBox();
							txtWeight = new TextBox();
							switch (char_[86])
							{
							case '\uf396':
								break;
							case '\uf371':
								goto end_IL_000d;
							case '\uf37b':
								goto end_IL_0171;
							case '\uf37d':
								goto end_IL_019a;
							default:
								goto end_IL_01bf;
							case '\uf376':
								Label2 = new Label();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 39;
								goto case '\uf397';
							case '\uf397':
								((Control)this).SuspendLayout();
								Label3.set_AutoSize(true);
								((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 18;
								goto case '\uf382';
							case '\uf382':
							case '\uf38c':
								((Control)Label3).set_ForeColor(Color.White);
								((Control)Label3).set_Location(new Point(355, 22));
								num = 40;
								goto case '\uf398';
							case '\uf398':
								((Control)Label3).set_Name("Label3");
								((Control)Label3).set_Size(new Size(95, 17));
								num = 56;
								goto case '\uf3a8';
							case '\uf3a8':
								((Control)Label3).set_TabIndex(9);
								Label3.set_Text("Sales Detail");
								num = 55;
								goto case '\uf3a7';
							case '\uf3a7':
								Label6.set_AutoSize(true);
								((Control)Label6).set_BackColor(Color.Blue);
								num = 58;
								goto case '\uf3aa';
							case '\uf3aa':
								((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 63;
								goto case '\uf3af';
							case '\uf3af':
								((Control)Label6).set_ForeColor(Color.White);
								((Control)Label6).set_Location(new Point(739, 22));
								num = 43;
								goto case '\uf39b';
							case '\uf39b':
								((Control)Label6).set_Name("Label6");
								((Control)Label6).set_Size(new Size(18, 17));
								num = 2;
								goto case '\uf372';
							case '\uf372':
								((Control)Label6).set_TabIndex(9);
								Label6.set_Text("X");
								num = 64;
								goto case '\uf3b0';
							case '\uf3b0':
								Label7.set_AutoSize(true);
								((Control)Label7).set_BackColor(Color.Blue);
								num = 33;
								goto case '\uf391';
							case '\uf391':
								((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								num = 50;
								goto case '\uf3a2';
							case '\uf3a2':
								((Control)Label7).set_ForeColor(Color.White);
								((Control)Label7).set_Location(new Point(47, 22));
								num = 69;
								goto case '\uf3b5';
							case '\uf3b5':
								((Control)Label7).set_Name("Label7");
								((Control)Label7).set_Size(new Size(92, 17));
								num = 23;
								goto case '\uf387';
							case '\uf387':
								((Control)Label7).set_TabIndex(8);
								Label7.set_Text("Go To Main");
								num = 52;
								goto case '\uf3a4';
							case '\uf3a4':
								DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
								((Control)DataGridView1).set_Location(new Point(33, 239));
								num = 22;
								goto case '\uf386';
							case '\uf386':
								((Control)DataGridView1).set_Name("DataGridView1");
								((Control)DataGridView1).set_Size(new Size(724, 199));
								num = 74;
								goto case '\uf3ba';
							case '\uf3ba':
								((Control)DataGridView1).set_TabIndex(10);
								((Control)DateTimePicker1).set_Location(new Point(525, 64));
								num = 41;
								goto case '\uf399';
							case '\uf399':
								((Control)DateTimePicker1).set_Name("DateTimePicker1");
								((Control)DateTimePicker1).set_Size(new Size(126, 20));
								num = 62;
								goto case '\uf3ae';
							case '\uf3ae':
								((Control)DateTimePicker1).set_TabIndex(3);
								Label8.set_AutoSize(true);
								num = 66;
								goto case '\uf3b2';
							case '\uf3b2':
								((Control)Label8).set_ForeColor(Color.White);
								((Control)Label8).set_Location(new Point(154, 130));
								num = 44;
								goto case '\uf39c';
							case '\uf39c':
								((Control)Label8).set_Name("Label8");
								((Control)Label8).set_Size(new Size(49, 13));
								num = 73;
								goto case '\uf3b9';
							case '\uf3b9':
								((Control)Label8).set_TabIndex(94);
								Label8.set_Text("Amount :");
								num = 16;
								goto case '\uf380';
							case '\uf380':
								Label5.set_AutoSize(true);
								((Control)Label5).set_ForeColor(Color.White);
								num = 57;
								goto case '\uf3a9';
							case '\uf3a9':
								((Control)Label5).set_Location(new Point(144, 101));
								((Control)Label5).set_Name("Label5");
								num = 67;
								goto case '\uf3b3';
							case '\uf3b3':
								((Control)Label5).set_Size(new Size(66, 13));
								((Control)Label5).set_TabIndex(93);
								num = 8;
								goto case '\uf378';
							case '\uf378':
								Label5.set_Text("Raw Name :");
								Label4.set_AutoSize(true);
								num = 32;
								goto case '\uf390';
							case '\uf390':
								((Control)Label4).set_ForeColor(Color.White);
								((Control)Label4).set_Location(new Point(431, 102));
								num = 60;
								goto case '\uf3ac';
							case '\uf3ac':
								((Control)Label4).set_Name("Label4");
								((Control)Label4).set_Size(new Size(72, 13));
								num = 24;
								goto case '\uf388';
							case '\uf388':
								((Control)Label4).set_TabIndex(92);
								Label4.set_Text("Raw Weight :");
								num = 35;
								goto case '\uf393';
							case '\uf393':
								Label1.set_AutoSize(true);
								((Control)Label1).set_ForeColor(Color.White);
								num = 68;
								goto case '\uf3b4';
							case '\uf3b4':
								((Control)Label1).set_Location(new Point(438, 64));
								((Control)Label1).set_Name("Label1");
								num = 61;
								goto case '\uf3ad';
							case '\uf3ad':
								((Control)Label1).set_Size(new Size(65, 13));
								((Control)Label1).set_TabIndex(91);
								num = 19;
								goto case '\uf383';
							case '\uf383':
								Label1.set_Text("Sales Date :");
								((Control)txtSNo).set_Location(new Point(233, 64));
								num = 36;
								goto case '\uf394';
							case '\uf394':
								((Control)txtSNo).set_Name("txtSNo");
								goto case '\uf38f';
							case '\uf38f':
								((Control)txtSNo).set_Size(new Size(100, 20));
								num = 5;
								goto case '\uf375';
							case '\uf375':
								((Control)txtSNo).set_TabIndex(0);
								((Control)btnDelete).set_Location(new Point(480, 172));
								num = 65;
								goto case '\uf3b1';
							case '\uf3b1':
								((Control)btnDelete).set_Name("btnDelete");
								((Control)btnDelete).set_Size(new Size(75, 31));
								num = 53;
								goto case '\uf3a5';
							case '\uf3a5':
								((Control)btnDelete).set_TabIndex(7);
								((ButtonBase)btnDelete).set_Text("DELETE");
								num = 49;
								goto case '\uf3a1';
							case '\uf3a1':
								((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
								((Control)btnModify).set_Location(new Point(362, 172));
								num = 72;
								goto case '\uf3b8';
							case '\uf3b8':
								((Control)btnModify).set_Name("btnModify");
								((Control)btnModify).set_Size(new Size(75, 31));
								goto case '\uf37a';
							case '\uf37a':
								num = 21;
								goto case '\uf385';
							case '\uf385':
								((Control)btnModify).set_TabIndex(6);
								((ButtonBase)btnModify).set_Text("MODIFY");
								num = 9;
								goto case '\uf379';
							case '\uf379':
								((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
								((Control)txtAmount).set_Location(new Point(231, 124));
								num = 7;
								goto case '\uf377';
							case '\uf377':
								((Control)txtAmount).set_Name("txtAmount");
								((Control)txtAmount).set_Size(new Size(100, 20));
								num = 25;
								goto case '\uf389';
							case '\uf389':
								((Control)txtAmount).set_TabIndex(2);
								((Control)txtSRaw).set_Location(new Point(231, 94));
								num = 70;
								goto case '\uf3b6';
							case '\uf3b6':
								((Control)txtSRaw).set_Name("txtSRaw");
								((Control)txtSRaw).set_Size(new Size(100, 20));
								num = 71;
								goto case '\uf3b7';
							case '\uf3b7':
								((Control)txtSRaw).set_TabIndex(1);
								((Control)txtWeight).set_Location(new Point(525, 99));
								num = 12;
								goto case '\uf37c';
							case '\uf37c':
								((Control)txtWeight).set_Name("txtWeight");
								((Control)txtWeight).set_Size(new Size(100, 20));
								num = 51;
								goto case '\uf3a3';
							case '\uf3a3':
								((Control)txtWeight).set_TabIndex(4);
								Label2.set_AutoSize(true);
								num = 0;
								goto case '\uf370';
							case '\uf370':
								((Control)Label2).set_ForeColor(Color.White);
								((Control)Label2).set_Location(new Point(155, 67));
								num = 30;
								goto case '\uf38e';
							case '\uf38e':
								((Control)Label2).set_Name("Label2");
								((Control)Label2).set_Size(new Size(56, 13));
								num = 17;
								goto case '\uf381';
							case '\uf381':
								((Control)Label2).set_TabIndex(90);
								Label2.set_Text("Sales No :");
								num = 59;
								goto case '\uf3ab';
							case '\uf3ab':
								((Control)btnSave).set_Location(new Point(233, 172));
								((Control)btnSave).set_Name("btnSave");
								num = 48;
								goto case '\uf3a0';
							case '\uf3a0':
								((Control)btnSave).set_Size(new Size(75, 31));
								((Control)btnSave).set_TabIndex(5);
								num = 15;
								goto case '\uf37f';
							case '\uf37f':
								((ButtonBase)btnSave).set_Text("SAVE");
								((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
								num = 75;
								goto case '\uf3bb';
							case '\uf3bb':
								((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
								((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
								num = 26;
								goto case '\uf38a';
							case '\uf38a':
								((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
								((Form)this).set_ClientSize(new Size(800, 450));
								num = 37;
								goto case '\uf395';
							case '\uf395':
								((Control)this).get_Controls().Add((Control)(object)DataGridView1);
								((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
								num = 45;
								goto case '\uf39d';
							case '\uf39d':
								((Control)this).get_Controls().Add((Control)(object)Label8);
								((Control)this).get_Controls().Add((Control)(object)Label5);
								num = 42;
								goto case '\uf39a';
							case '\uf39a':
								((Control)this).get_Controls().Add((Control)(object)Label4);
								((Control)this).get_Controls().Add((Control)(object)Label1);
								num = 27;
								goto case '\uf38b';
							case '\uf38b':
								((Control)this).get_Controls().Add((Control)(object)txtSNo);
								((Control)this).get_Controls().Add((Control)(object)btnDelete);
								num = 34;
								goto case '\uf392';
							case '\uf392':
								((Control)this).get_Controls().Add((Control)(object)btnModify);
								((Control)this).get_Controls().Add((Control)(object)txtAmount);
								num = 46;
								goto case '\uf39e';
							case '\uf39e':
								((Control)this).get_Controls().Add((Control)(object)txtSRaw);
								((Control)this).get_Controls().Add((Control)(object)txtWeight);
								num = 14;
								goto case '\uf37e';
							case '\uf37e':
								((Control)this).get_Controls().Add((Control)(object)Label2);
								((Control)this).get_Controls().Add((Control)(object)btnSave);
								num = 3;
								goto case '\uf373';
							case '\uf373':
								((Control)this).get_Controls().Add((Control)(object)Label6);
								((Control)this).get_Controls().Add((Control)(object)Label7);
								num = 47;
								goto case '\uf39f';
							case '\uf39f':
								((Control)this).get_Controls().Add((Control)(object)Label3);
								((Form)this).set_FormBorderStyle((FormBorderStyle)0);
								num = 20;
								goto case '\uf384';
							case '\uf384':
								((Control)this).set_Name("frmSalesDetail");
								((Form)this).set_StartPosition((FormStartPosition)1);
								((Form)this).set_Text("frmSalesDetail");
								num = 29;
								goto case '\uf38d';
							case '\uf38d':
								((ISupportInitialize)DataGridView1).EndInit();
								((Control)this).ResumeLayout(false);
								((Control)this).PerformLayout();
								num = 54;
								return;
							case '\uf3a6':
								return;
							}
							continue;
							end_IL_000d:
							break;
						}
						continue;
						end_IL_0171:
						break;
					}
					continue;
					end_IL_019a:
					break;
				}
				continue;
				end_IL_01bf:
				break;
			}
		}
	}

	private void s0L(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void Zn5(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void n9M(object sender, EventArgs e)
	{
	}

	private void Ee2(object sender, EventArgs e)
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
		Nz1();
	}

	public void Nz1()
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

	private void Wn6(object sender, EventArgs e)
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
		Nz1();
	}

	internal static string[] No0()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(Eb1.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = array2.Length;
					Pj8.byte_0[136] = unchecked((byte)(Pj8.byte_0[136] & Pj8.byte_0[63] & 0x26));
					if (num3 >= num4)
					{
						break;
					}
					string item = array2[num2];
					list.Add(item);
					num2++;
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num5 = array3.Length - 1;
				for (num = 0; num <= num5; num++)
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

	private void f9F(object sender, EventArgs e)
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
		Nz1();
	}

	static void k8S()
	{
		m0N m0N = m0N;
		m0N = m0N;
		f9T6 f9T = f9T;
		f9T = f9T;
		_ = (x8D9)(object)Nf2.Default;
		_ = (m0N)(object)Nf2.Default;
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				while ((object)Nf2.Default != null)
				{
					_ = (r8M)Nf2.Default;
				}
			}
		}
		finally
		{
			goto IL_005f;
		}
		IL_005f:
		UIntPtr num;
		checked
		{
			num = unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		if (num == 0)
		{
			try
			{
				Pm9 obj = (Pm9)(object)Nf2.Default;
				pm = null;
				pm = obj;
			}
			catch
			{
				_ = (k6D9)(object)Nf2.Default;
			}
			finally
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					d4E d4E = (d4E)(object)Nf2.Default;
					d4E = d4E;
				}
				else
				{
					f9T = f9T;
					_ = Nf2.Default;
					r8M = r8M;
					r8M = r8M;
				}
				goto IL_0146;
			}
		}
		try
		{
			_ = (Co4)(object)Nf2.Default;
		}
		catch
		{
		}
		goto IL_0146;
		IL_0348:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		if (num == 0)
		{
			while (obj4 != null)
			{
				_ = (Co4)(object)Nf2.Default;
			}
		}
		else if (num == 0)
		{
			_ = (_003CModule_003E)(object)Nf2.Default;
		}
		try
		{
			_ = (f9T6)(object)Nf2.Default;
			_ = (Np8)(object)Nf2.Default;
			_ = (Mb5)(object)Nf2.Default;
			_ = (Pm9)(object)Nf2.Default;
		}
		finally
		{
			while ((object)Nf2.Default != null)
			{
				try
				{
					_ = Nf2.Default;
				}
				catch
				{
					_ = (w4R)(object)Nf2.Default;
				}
			}
			goto IL_03da;
		}
		IL_03da:
		k6D9 k6D = (k6D9)(object)Nf2.Default;
		k6D = k6D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		while ((object)Nf2.Default != null)
		{
			try
			{
				x8D = null;
			}
			finally
			{
				_ = (Mb5)(object)Nf2.Default;
				continue;
			}
		}
		_ = (_003CModule_003E)(object)Nf2.Default;
		do
		{
			_ = Nf2.Default;
		}
		while (obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			try
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
				while (obj4 != null);
			}
			finally
			{
				d1X d1X = d1X;
				d1X = d1X;
				goto end_IL_042f;
			}
			end_IL_042f:;
		}
		catch
		{
			try
			{
				while (obj4 != null)
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
					goto end_IL_0471;
				}
				finally
				{
					_ = (r8M)Nf2.Default;
					goto end_IL_0471;
				}
				end_IL_0471:;
			}
		}
		checked
		{
			try
			{
				try
				{
				}
				finally
				{
					pm = pm;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (d8B)(object)Nf2.Default;
					goto end_IL_0492;
				}
				end_IL_0492:;
			}
			catch
			{
				_ = (m0N)(object)Nf2.Default;
			}
			finally
			{
				if (num * unchecked((nuint)default(UIntPtr)) == 0)
				{
					try
					{
					}
					finally
					{
						pm = pm;
						goto IL_0503;
					}
				}
				while (obj4 != null)
				{
					Eb1 eb = (Eb1)(object)Nf2.Default;
				}
				goto IL_0503;
			}
		}
		IL_0146:
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
			while (true)
			{
				obj4 = obj4;
				if (obj4 == null)
				{
					break;
				}
				if (unchecked((nuint)(UIntPtr)Nf2.Default) - num == 0)
				{
					try
					{
						_ = (d4E)(object)Nf2.Default;
					}
					catch
					{
						Pj8 obj9 = (Pj8)(object)Nf2.Default;
						pj = pj;
						pj = obj9;
					}
				}
			}
			try
			{
				do
				{
					try
					{
						Mb5 mb = (Mb5)(object)Nf2.Default;
						mb = mb;
					}
					finally
					{
						_ = (d1X)(object)Nf2.Default;
						continue;
					}
				}
				while (obj4 != null);
			}
			finally
			{
				if (num == 0)
				{
					try
					{
						_ = (Co4)(object)Nf2.Default;
					}
					catch
					{
						_ = (d1X)(object)Nf2.Default;
					}
				}
				goto IL_01a6;
			}
		}
		IL_02c2:
		while ((object)Nf2.Default != null)
		{
			if (num == 0)
			{
				_ = (m0N)(object)Nf2.Default;
				_ = (Np8)(object)Nf2.Default;
				x8D = x8D;
			}
			else
			{
				while (obj4 != null)
				{
					_ = (Mb5)(object)Nf2.Default;
				}
			}
		}
		_ = (Co4)(object)Nf2.Default;
		_ = (f2L)(object)Nf2.Default;
		try
		{
			Eb1 eb = (Eb1)(object)Nf2.Default;
			eb = eb;
			_ = (k6D9)(object)Nf2.Default;
			_ = (f0F)(object)Nf2.Default;
			x8D = x8D;
		}
		catch
		{
			_ = (w4R)(object)Nf2.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (o5CZ)(object)Nf2.Default;
			}
			goto IL_0348;
		}
		IL_01a6:
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			while ((object)Nf2.Default != null)
			{
				x8D = x8D;
			}
		}
		UIntPtr num2 = (UIntPtr)Nf2.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num2) + num == 0)
			{
				do
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						pm = pm;
						_ = (x8D9)(object)Nf2.Default;
						d4E d4E = null;
						_ = (Np8)(object)Nf2.Default;
					}
				}
				while ((object)Nf2.Default != null);
			}
			else
			{
				nuint num3 = num;
				num = default(UIntPtr);
				nuint num4 = num;
				nuint num5 = unchecked((nuint)(UIntPtr)Nf2.Default) - num;
				UIntPtr num6 = unchecked((UIntPtr)Nf2.Default);
				num = default(UIntPtr);
				if (num3 * (num4 - (num5 + (unchecked((nuint)num6) - num)) + num) == 0)
				{
					try
					{
						_ = (o5CZ)(object)Nf2.Default;
					}
					finally
					{
						_ = (f0F)(object)Nf2.Default;
						goto IL_02c2;
					}
				}
			}
			goto IL_02c2;
		}
		IL_0503:
		try
		{
			_ = (f0F)(object)Nf2.Default;
		}
		catch
		{
			_ = (w4R)(object)Nf2.Default;
			x8D = x8D;
		}
		_ = (_003CModule_003E)(object)Nf2.Default;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (k6D9)(object)Nf2.Default;
		}
		r8M = default(r8M);
		_ = (f2L)(object)Nf2.Default;
		if (num == (UIntPtr)(nuint)0u)
		{
		}
		do
		{
			try
			{
				_ = (f0F)(object)Nf2.Default;
			}
			finally
			{
				_ = (d4E)(object)Nf2.Default;
				continue;
			}
		}
		while (obj4 != null || obj4 != null);
		_ = (x8D9)(object)Nf2.Default;
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		while (true)
		{
			if (obj4 != null)
			{
				_ = (Gj4)Nf2.Default;
				_ = (d8B)(object)Nf2.Default;
			}
			else if (obj4 == null)
			{
				break;
			}
		}
	}

	static void g4E()
	{
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
		if (uIntPtr == 0)
		{
			d1X = (d1X)(object)Nf2.Default;
			d1X = null;
		}
		Eb1 eb = (Eb1)(object)Nf2.Default;
		eb = eb;
		Pm9 pm = pm;
		pm = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		try
		{
			try
			{
				d1X = d1X;
			}
			finally
			{
				try
				{
					d4E d4E = null;
					d4E = d4E;
					_ = (Np8)(object)Nf2.Default;
					mb = mb;
					mb = null;
					_ = (o5CZ)(object)Nf2.Default;
				}
				finally
				{
					_ = (Pm9)(object)Nf2.Default;
					goto end_IL_004e;
				}
			}
			end_IL_004e:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Gj4)Nf2.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					goto end_IL_009e;
				}
				end_IL_009e:;
			}
			finally
			{
				d8B = d8B;
				d8B = d8B;
				goto IL_00d4;
			}
		}
		IL_0357:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				try
				{
					_ = (k6D9)(object)Nf2.Default;
				}
				finally
				{
					_ = (d1X)(object)Nf2.Default;
					_ = (Np8)(object)Nf2.Default;
					_ = (Pj8)(object)Nf2.Default;
					goto end_IL_0358;
				}
			}
			end_IL_0358:;
		}
		catch
		{
			try
			{
				m0N = m0N;
				m0N = m0N;
				_ = (o5CZ)(object)Nf2.Default;
				_ = (Np8)(object)Nf2.Default;
			}
			catch
			{
				_ = (f9T6)(object)Nf2.Default;
			}
			finally
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (r8M)Nf2.Default;
				}
				goto end_IL_039f;
			}
			end_IL_039f:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		try
		{
			if (uIntPtr / (nuint)(UIntPtr)Nf2.Default == 0)
			{
				k6D = k6D;
				k6D = k6D;
			}
			else
			{
				_ = (Pj8)(object)Nf2.Default;
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Eb1)(object)Nf2.Default;
				_ = (x8D9)(object)Nf2.Default;
				_ = (d1X)(object)Nf2.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		while (obj4 != null)
		{
			_ = (f9T6)(object)Nf2.Default;
			_ = (w4R)(object)Nf2.Default;
			np = np;
			np = np;
		}
		k6D = null;
		try
		{
			do
			{
				_ = (Gj4)Nf2.Default;
			}
			while (obj4 != null || obj4 != null);
		}
		finally
		{
			_ = (Pm9)(object)Nf2.Default;
			goto IL_04cd;
		}
		IL_04cd:
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				eb = (Eb1)(object)Nf2.Default;
			}
		}
		while (obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		try
		{
			r8M r8M = default(r8M);
		}
		catch
		{
			try
			{
			}
			catch
			{
				try
				{
					x8D9 x8D = x8D;
					x8D = x8D;
					goto end_IL_04fe;
				}
				finally
				{
					o5CZ = null;
					goto end_IL_04fe;
				}
				end_IL_04fe:;
			}
		}
		Gj4 gj;
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					gj = gj;
				}
				finally
				{
					o5CZ = o5CZ;
					goto end_IL_051d;
				}
			}
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			else
			{
				_ = (Gj4)Nf2.Default;
				_ = (Pm9)(object)Nf2.Default;
				_ = (Pm9)(object)Nf2.Default;
				_003CModule_003E = _003CModule_003E;
			}
			end_IL_051d:;
		}
		catch
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gj = default(Gj4);
					_ = (x8D9)(object)Nf2.Default;
				}
			}
			while (obj4 != null);
		}
		try
		{
			do
			{
				if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
				{
					np = np;
					continue;
				}
				np = np;
				_ = (f2L)(object)Nf2.Default;
				_ = Nf2.Default;
				o5CZ = o5CZ;
			}
			while (obj4 != null);
		}
		finally
		{
			if (checked((unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = Nf2.Default;
					_ = Nf2.Default;
				}
				else
				{
					m0N = m0N;
				}
			}
			goto IL_0666;
		}
		IL_00d4:
		f0F f0F;
		if (uIntPtr / unchecked((nuint)default(UIntPtr)) == 0)
		{
			f0F = (f0F)(object)Nf2.Default;
			f0F = f0F;
			_ = (o5CZ)(object)Nf2.Default;
			o5CZ = null;
			o5CZ = null;
			_ = (f2L)(object)Nf2.Default;
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				while ((object)Nf2.Default != null)
				{
					d1X = null;
				}
			}
			else
			{
				while ((object)Nf2.Default != null)
				{
					gj = (Gj4)Nf2.Default;
					gj = gj;
				}
			}
			obj4 = obj4;
		}
		while (obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4R w4R2);
		do
		{
			gj = (Gj4)Nf2.Default;
			_003CModule_003E = _003CModule_003E;
			_ = (f2L)(object)Nf2.Default;
			w4R2 = w4R2;
			w4R2 = null;
		}
		while (obj4 != null);
		try
		{
			_ = (m0N)(object)Nf2.Default;
		}
		finally
		{
			try
			{
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					mb = (Mb5)(object)Nf2.Default;
				}
				else
				{
					f0F = null;
					_ = (Eb1)(object)Nf2.Default;
					_ = (d8B)(object)Nf2.Default;
					f2L obj8 = (f2L)(object)Nf2.Default;
					f2L f2L = f2L;
					f2L = obj8;
				}
			}
			catch
			{
				try
				{
					eb = eb;
					Co4 co = co;
					co = co;
					_ = (f0F)(object)Nf2.Default;
					_ = (Pj8)(object)Nf2.Default;
				}
				finally
				{
					_ = (f0F)(object)Nf2.Default;
					goto end_IL_020b;
				}
				end_IL_020b:;
			}
			goto IL_024d;
		}
		IL_02bb:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					f0F = f0F;
				}
				catch
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
		}
		catch
		{
		}
		try
		{
			mb = mb;
			_ = (Gj4)Nf2.Default;
		}
		catch
		{
			try
			{
				_ = (r8M)Nf2.Default;
			}
			catch
			{
				while (true)
				{
					d1X = d1X;
					if ((object)Nf2.Default != null)
					{
						continue;
					}
					goto end_IL_030d;
				}
				end_IL_030d:;
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					Co4 co = null;
				}
				while ((object)Nf2.Default != null);
			}
		}
		finally
		{
			_ = (Np8)(object)Nf2.Default;
			goto IL_0357;
		}
		IL_024d:
		f0F = null;
		_ = (Pj8)(object)Nf2.Default;
		try
		{
		}
		catch
		{
			while ((object)Nf2.Default != null)
			{
				d8B = d8B;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (r8M)Nf2.Default;
				}
				while (obj4 != null);
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					w4R2 = null;
				}
				goto IL_02bb;
			}
		}
		mb = mb;
		goto IL_02bb;
		IL_0666:
		_ = (Pj8)(object)Nf2.Default;
		while ((object)Nf2.Default != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				Co4 co = (Co4)(object)Nf2.Default;
				continue;
			}
			gj = gj;
			eb = eb;
			_ = (k6D9)(object)Nf2.Default;
			_ = (Eb1)(object)Nf2.Default;
		}
		m0N = m0N;
		while (obj4 != null)
		{
			while ((object)Nf2.Default != null)
			{
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj4 != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Co4)(object)Nf2.Default;
				}
				else
				{
					np = (Np8)(object)Nf2.Default;
				}
			}
		}
		m0N = m0N;
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					while (obj4 != null)
					{
						_ = (Gj4)Nf2.Default;
					}
				}
			}
			finally
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr - uIntPtr == 0)
					{
						_ = (o5CZ)(object)Nf2.Default;
					}
					else
					{
						_ = (_003CModule_003E)(object)Nf2.Default;
					}
				}
				catch
				{
					try
					{
						r8M r8M = default(r8M);
					}
					catch
					{
						_ = (Np8)(object)Nf2.Default;
					}
				}
				goto IL_07a5;
			}
		}
		IL_07a5:
		w4R2 = null;
	}
}
