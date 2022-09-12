using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz7;
using Di68;
using Gn3;
using Jz9;
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

namespace Hx0;

[DesignerGenerated]
public class Qt2 : Form
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
			EventHandler eventHandler = z7K;
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
			EventHandler eventHandler = a9R;
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
			EventHandler eventHandler = n6B;
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
			EventHandler eventHandler = Gd5;
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
			EventHandler eventHandler = m3S;
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

	public Qt2()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)q7Z);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		p8K();
	}

	[DebuggerNonUserCode]
	protected override void r6Y(bool c8R)
	{
		try
		{
			if (c8R && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c8R);
		}
	}

	[DebuggerStepThrough]
	private void p8K()
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
		Qp49.char_0[315] = (char)((Qp49.char_0[315] + Qp49.char_0[137]) & 'D');
	}

	private void a9R(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void z7K(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void q7Z(object sender, EventArgs e)
	{
	}

	private void m3S(object sender, EventArgs e)
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
		Td4();
	}

	public void Td4()
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
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
			while (rd.Read())
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

	internal static void c0C()
	{
		byte[] wm = z8Y.d3L4(133632);
		int num = checked(Conversions.ToInteger(Dx5s.mDic[Dx5s.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		Dx5s.mDic.Add(Dx5s.mArray, o2T.Ld7(wm, (byte[])Dx5s.mDic[Dx5s.sArray], num, 25));
		if (y2HN.Wd5())
		{
			So3.By8();
		}
	}

	private void Gd5(object sender, EventArgs e)
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
		Td4();
	}

	private void n6B(object sender, EventArgs e)
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
		Td4();
	}

	internal static void Ja2()
	{
		string[] pb = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Qp49.d4H7(pb, 0, 3);
		string value2 = Qp49.d4H7(pb, 4, 7);
		Dx5s.mDic.Add(Dx5s.tName, value);
		Dx5s.mDic.Add(Dx5s.mName, value2);
		n0J5.char_0[65] = (char)((n0J5.char_0[65] | Qp49.char_0[379]) & 'm');
	}

	static void Jt3()
	{
		b6G b6G = b6G;
		b6G = b6G;
		y2HN obj = (y2HN)(object)e7WK.Default;
		y2HN y2HN = y2HN;
		y2HN = obj;
		Pw9k pw9k = null;
		pw9k = pw9k;
		Qt2 qt = (Qt2)(object)e7WK.Default;
		qt = qt;
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
		_003CModule_003E = _003CModule_003E;
		_ = (z8Y)(object)e7WK.Default;
		_ = (Cx7)(object)e7WK.Default;
		object obj3;
		checked
		{
			do
			{
				try
				{
					_ = (n0J5)(object)e7WK.Default;
				}
				catch
				{
					_ = (Fz0)e7WK.Default;
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						_ = (n0J5)(object)e7WK.Default;
					}
					continue;
				}
			}
			while ((object)e7WK.Default != null);
			try
			{
				_ = (Qp49)(object)e7WK.Default;
				_ = (Qp49)(object)e7WK.Default;
			}
			finally
			{
				obj3 = null;
				goto IL_00e3;
			}
		}
		IL_0655:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (o2T)(object)e7WK.Default;
					return;
				}
				finally
				{
					z8Y = (z8Y)(object)e7WK.Default;
					return;
				}
			}
			catch
			{
				Cx7 cx = (Cx7)(object)e7WK.Default;
				return;
			}
		}
		z8Y = z8Y;
		_ = (q1M)(object)e7WK.Default;
		qt = null;
		return;
		IL_0314:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		do
		{
			IL_0314_2:
			if ((object)e7WK.Default != null)
			{
				try
				{
					qe = null;
				}
				finally
				{
					_ = (Fz0)e7WK.Default;
					goto IL_0314_2;
				}
			}
		}
		while ((object)e7WK.Default != null);
		_ = (b7KC)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		do
		{
			try
			{
				_ = (y2HN)(object)e7WK.Default;
			}
			finally
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Qe07)(object)e7WK.Default;
					q1M obj5 = (q1M)(object)e7WK.Default;
					q1M = null;
					q1M = obj5;
					_ = (_003CModule_003E)(object)e7WK.Default;
					Fz0 fz = (Fz0)e7WK.Default;
					fz = default(Fz0);
				}
				continue;
			}
		}
		while (obj3 != null);
		while (obj3 != null)
		{
			try
			{
			}
			catch
			{
				_ = (Qt2)(object)e7WK.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / (num / num) == 0)
			{
				UIntPtr num2 = (UIntPtr)e7WK.Default;
				UIntPtr num3 = (UIntPtr)e7WK.Default;
				num = default(UIntPtr);
				if ((nuint)num2 / checked((unchecked((nuint)num3) + num) * num + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
				{
					qe = null;
				}
				else
				{
					_ = (b7KC)(object)e7WK.Default;
				}
			}
		}
		finally
		{
			while (obj3 != null)
			{
			}
			goto IL_042e;
		}
		IL_042e:
		num = default(UIntPtr);
		if (checked(num + (num + unchecked((nuint)default(UIntPtr)))) == 0 && (nuint)(UIntPtr)e7WK.Default / checked(unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0 && (UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = (b7KC)(object)e7WK.Default;
		}
		_ = (b6G)e7WK.Default;
		_ = (b7KC)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T);
		checked
		{
			try
			{
				try
				{
					_ = (Cx7)(object)e7WK.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_04a1;
				}
				end_IL_04a1:;
			}
			finally
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						_ = (z0R3)(object)e7WK.Default;
					}
					else
					{
						_ = (Qp49)(object)e7WK.Default;
					}
				}
				finally
				{
					try
					{
						o2T = o2T;
						o2T = o2T;
						Cx7 obj7 = (Cx7)(object)e7WK.Default;
						Cx7 cx = cx;
						cx = obj7;
					}
					finally
					{
						o2T = o2T;
						goto IL_0524;
					}
				}
			}
		}
		IL_00e3:
		try
		{
			_ = (Dx5s)(object)e7WK.Default;
		}
		finally
		{
			try
			{
			}
			catch
			{
				do
				{
					_ = (Qt2)(object)e7WK.Default;
				}
				while ((object)e7WK.Default != null);
			}
			goto IL_0110;
		}
		IL_0110:
		qe = qe;
		qe = qe;
		n0J5 n0J = (n0J5)(object)e7WK.Default;
		n0J = n0J;
		num = num;
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					pw9k = (Pw9k)(object)e7WK.Default;
				}
				else
				{
					_ = (z0R3)(object)e7WK.Default;
				}
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		while (obj3 != null)
		{
			do
			{
				c8CP obj9 = (c8CP)(object)e7WK.Default;
				c8CP = (c8CP)(object)e7WK.Default;
				c8CP = obj9;
			}
			while (obj3 != null);
		}
		_ = (Pw9k)(object)e7WK.Default;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (o2T)(object)e7WK.Default;
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
			if (num == 0)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					g2J = g2J;
					g2J = g2J;
				}
			}
			else
			{
				try
				{
					qt = (Qt2)(object)e7WK.Default;
					g2J = g2J;
					_ = (b6G)e7WK.Default;
					c8CP = c8CP;
				}
				catch
				{
					_ = (b7KC)(object)e7WK.Default;
				}
			}
		}
		_ = (b7KC)(object)e7WK.Default;
		checked
		{
			if (num == 0)
			{
				z8Y = (z8Y)(object)e7WK.Default;
				z8Y = z8Y;
			}
			else if (unchecked(num / (nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				do
				{
					_ = (n0J5)(object)e7WK.Default;
				}
				while (obj3 != null);
			}
			else
			{
				try
				{
					c8CP = null;
				}
				catch
				{
					qe = (Qe07)(object)e7WK.Default;
				}
			}
			try
			{
				while (obj3 != null)
				{
					while ((object)e7WK.Default != null)
					{
						_ = (n0J5)(object)e7WK.Default;
					}
				}
			}
			finally
			{
				_ = (Pw9k)(object)e7WK.Default;
				goto IL_0314;
			}
		}
		IL_0524:
		try
		{
			try
			{
				try
				{
					y2HN = y2HN;
				}
				finally
				{
					_ = (o2T)(object)e7WK.Default;
					goto end_IL_0526;
				}
				end_IL_0526:;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = null;
				}
				goto end_IL_0525;
			}
			end_IL_0525:;
		}
		catch
		{
			_ = (n0J5)(object)e7WK.Default;
		}
		_ = (_003CModule_003E)(object)e7WK.Default;
		pw9k = (Pw9k)(object)e7WK.Default;
		_ = (Pw9k)(object)e7WK.Default;
		_ = (n0J5)(object)e7WK.Default;
		_ = (Yo50)(object)e7WK.Default;
		_ = (y2HN)(object)e7WK.Default;
		if (checked(unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)default(UIntPtr))) == 0)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					qt = qt;
					_ = (So3)(object)e7WK.Default;
					q1M = q1M;
					_ = (Dx5s)(object)e7WK.Default;
				}
				finally
				{
					_ = (Qt2)(object)e7WK.Default;
					goto IL_0655;
				}
			}
			do
			{
				_ = (b6G)e7WK.Default;
			}
			while ((object)e7WK.Default != null);
		}
		else
		{
			while (obj3 != null)
			{
				while (obj3 != null)
				{
					_ = (y2HN)(object)e7WK.Default;
					Dx5s dx5s = null;
					dx5s = dx5s;
					o2T = o2T;
				}
			}
		}
		goto IL_0655;
	}
}
